Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports System.Drawing.Printing

Public Class frmMovBancos

    Dim folioMovimiento As Integer
    Dim GiroProveedor As Integer
    Dim ImpresoraActual As String

    Dim folioContrarecibo As Integer
    Dim facProv As String
    Public wCheque As Integer
    Public wCodigo As Integer
    Public wCuenta As String
    Public wCuentaProv As String
    Public wPoliza As String
    Public wFolioKardex As String
    Public wFolioTransfer As Integer

    Public Aprobado As Integer = 1


    '---Variable de las Coordenadas
    Dim ImporteLetras As String
    Dim FechaX As Single = 0
    Dim FechaY As Single = 0
    Dim NombreX As Single = 0
    Dim NombreY As Single = 0
    Dim MontoNumX As Single = 0
    Dim MontoNumY As Single = 0
    Dim MontoLtrX As Single = 0
    Dim MontoLtrY As Single = 0
    Dim ConceptoX As Single = 0
    Dim ConceptoY As Single = 0
    Dim ConceptoInfX As Single = 0
    Dim ConceptoInfY As Single = 0
    Dim ConceptoImpX As Single = 0
    Dim ConceptoImpY As Single = 0
    Dim PolizaX As Single = 0
    Dim PolizaY As Single = 0
    '------------------------------

    '---VARIABLES POLIZAS----------
    Dim CError As Integer
    Dim MError As Integer
    Dim CCuenta As String
    Dim CMoneda As Integer
    Dim cDolares As Integer = 0
    Dim wPolizaTC As String = 0

    'Dim datoConcepto As String
    Dim existe As Integer
    Dim Tabcontrol As Integer

    '-------Cuentas IVA--------

    Dim IVA16 As Decimal = 0
    Dim IVA11 As Decimal = 0
    Dim IVAIMP As Decimal = 0
    Dim IVARetHon As Decimal = 0
    Dim IVARetArr As Decimal = 0
    Dim IVARet4 As Decimal = 0
    Dim ISRHon As Decimal = 0
    Dim ISRArr As Decimal = 0
    Dim IEPS As Decimal = 0



    Private Sub frmMovBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '-----------------VALIDA PERFIL USUARIO------------------
        Dim Perfil As String
        Perfil = "00-05-06"

        If Perfil Like "*" + Perfilesusuario + "*" Then
            Me.Text = "Movimientos Bancos" + Space(10) + CStr(VersionCont())
            STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario

            Me.MaximizeBox = False
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        Else
            MsgBox("No tiene Derechos Sobre esta Opcion", vbCritical, "Sistema Contable")
            Me.Close()
        End If
        '------------------- CARGA LISTA PROVEEDORES ----------------------
        CargaProveedores()
        CargaProveedores_libre()
        CargarBancos()
        CargaMonedas()
        CargaMonedas_libre()
        CargatipoCambio()

        '--------------------LIMPIA REGISTROS-------------------
        'cbxBancos.Text = ""
        txtConcepto.Text = ""
        cbxMetodoPago.Text = ""
        txtBenefi.Text = ""
        cbxBancos.Text = ""
        txtCodigo.Text = ""
        txtCodigo.Focus()

    End Sub

    Sub buscaCodigoProveedor()

        '----BUSCAR NUMERO DE PROVEEDOR ----
        Dim dr2 As SqlDataReader
        Dim oclsProgramacionPago2 = New clsProgramacionPago()
        dr2 = oclsProgramacionPago2.SeleccionaCodigoProveedor(Me.cbxProveedores.SelectedValue)
        'Dim dt = New DataTable()
        'dt.Rows.Count > 0mspa
        If dr2.Read Then
            txtCodigo.Text = dr2("codigo").ToString
            '---------------------------------------
            wCuentaProv = dr2("CuentaContable").ToString
        Else

            MsgBox("El Proveedor no tiene asignado un Codigo", vbCritical, "Sistema Contable")

        End If
        dr2.Close()
    End Sub
    Sub buscaCodigoProveedor_libre()

        '----BUSCAR NUMERO DE PROVEEDOR ----
        Dim dr2 As SqlDataReader
        Dim oclsProgramacionPago2 = New clsProgramacionPago()
        dr2 = oclsProgramacionPago2.SeleccionaCodigoProveedor(Me.cbxProveedores_libre.SelectedValue)
        'Dim dt = New DataTable()
        'dt.Rows.Count > 0mspa
        If dr2.Read Then
            txtCodigo_libre.Text = dr2("codigo").ToString
            '---------------------------------------
            wCuentaProv = dr2("CuentaContable").ToString
        Else

            MsgBox("El Proveedor no tiene asignado un Codigo", vbCritical, "Sistema Contable")

        End If
        dr2.Close()
    End Sub

    Private Sub CargaProveedores_libre()

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select * from almacen.dbo.catProveedores (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxProveedores_libre.ValueMember = Trim("CuentaContable")
        cbxProveedores_libre.DisplayMember = Trim("proveedor")

        cbxProveedores_libre.DataSource = dt
        cbxProveedores_libre.Text = ""

    End Sub

    Private Sub CargaProveedores()

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select * from almacen.dbo.catProveedores (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxProveedores.ValueMember = Trim("CuentaContable")
        cbxProveedores.DisplayMember = Trim("proveedor")

        cbxProveedores.DataSource = dt
        cbxProveedores.Text = ""

    End Sub
    Private Sub SumaAbonos()
        '-------------Suma los Cargos y va sumando por registro toda la columna y la coloca en el text Total---------
        Dim Celda As DataGridViewCell = Me.DGVFacturaPagos.CurrentCell()

        'If Celda.ColumnIndex = 11 Then

        Dim resultadoAbonos As Decimal = 0D

        For Each row As DataGridViewRow In DGVFacturaPagos.Rows
            row.Cells("mCantPago").Value = Format(CDec(row.Cells("mCantPago").Value), "###,###,##0.###0")

            Dim Motivo As Decimal

            If row.Cells("mMoneda").Value = cbxMoneda.SelectedValue And row.Cells("mCantPago").Value > row.Cells("mSaldo").Value Then
                Motivo = Format(CDec(row.Cells("mSaldo").Value), "###,###,##0.###0")
                MsgBox("El Abono no puede ser mayor que el Saldo Maximo=" & Motivo & " " & cbxMoneda.ValueMember, MsgBoxStyle.Critical, "Sistema Contable")
                row.Cells("mCantPago").Value = "0.00"
            End If

            If row.Cells("mMoneda").Value = 1 And cbxMoneda.SelectedValue = 2 And row.Cells("mCantPago").Value > (row.Cells("mSaldo").Value / (txtTipoCambio.Text - 0.01)) Then
                Motivo = Format(CDec(row.Cells("mSaldo").Value / (txtTipoCambio.Text)), "###,###,##0.###0")
                MsgBox("El Abono no puede ser mayor que el Saldo Maximo=" & Motivo & " " & cbxMoneda.ValueMember, MsgBoxStyle.Critical, "Sistema Contable")
                row.Cells("mCantPago").Value = "0.00"
            End If

            If row.Cells("mMoneda").Value = 2 And cbxMoneda.SelectedValue = 1 And row.Cells("mCantPago").Value > (row.Cells("mSaldo").Value * (txtTipoCambio.Text + 0.01)) Then
                Motivo = Format(CDec(row.Cells("mSaldo").Value * (txtTipoCambio.Text)), "###,###,##0.###0")
                MsgBox("El Abono no puede ser mayor que el Saldo Maximo=" & Motivo & " " & cbxMoneda.ValueMember, MsgBoxStyle.Critical, "Sistema Contable")
                row.Cells("mCantPago").Value = "0.00"
            End If

            Dim value As Object = row.Cells("mCantPago").Value

            Dim d As Decimal

            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultadoAbonos += Convert.ToDecimal(d)

            'If cbxMoneda.SelectedIndex = 1 Then
            '    resultadoAbonos = resultadoAbonos * txtTipoCambio.Text

            'End If
        Next

        If cbxMoneda.SelectedIndex = 1 Then
            txtTotAbonoDlls.Text = Format(resultadoAbonos, "###,###,##0.#0")
            If txtTipoCambio.Text > 0.0 Then
                txtTotAbono.Text = resultadoAbonos * CDec(txtTipoCambio.Text)

                txtTotAbono.Text = Format(CDec(txtTotAbono.Text), "###,###,##0.#0")
            End If
        Else

            txtTotAbono.Text = Format(resultadoAbonos, "###,###,##0.#0")
            If txtTipoCambio.Text > 0.0 Then
                txtTotAbonoDlls.Text = resultadoAbonos / CDec(txtTipoCambio.Text)

                txtTotAbonoDlls.Text = Format(CDec(txtTotAbonoDlls.Text), "###,###,##0.#0")
            End If
        End If
        txtSaldo.Text = CDec(txtTotalDocumento.Text) - CDec(txtTotAbono.Text)

        txtSaldo.Text = Format(CDec(txtSaldo.Text), "###,###,##0.#0")

        'End If
    End Sub

    Private Sub SumaImportes()
        '-------------Suma los Cargos y va sumando por registro toda la columna y la coloca en el text Total---------
        'Dim Celda As DataGridViewCell = Me.DGVFacturaPago.CurrentCell()
        'If Celda.ColumnIndex = 5 Then

        Dim resultadoSubtotal As Decimal = 0D

        For Each row As DataGridViewRow In DGVFacturaPagos.Rows
            Dim value As Object = row.Cells("dSubtotal").Value

            Dim d As Decimal

            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultadoSubtotal += Convert.ToDecimal(d)

            If row.Cells("mMoneda").Value = 2 Then
                resultadoSubtotal = resultadoSubtotal * txtTipoCambio.Text
            End If
        Next

        txtSubtotal.Text = Format(resultadoSubtotal, "###,###,##0.#0")


        ' End If

        'If Celda.ColumnIndex = 6 Then

        Dim resultadoIVA As Decimal = 0D

        For Each row As DataGridViewRow In DGVFacturaPagos.Rows
            Dim value As Object = row.Cells("dIVA").Value

            Dim d As Decimal

            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultadoIVA += Convert.ToDecimal(d)

            If row.Cells("mMoneda").Value = 2 Then
                resultadoIVA = resultadoIVA * txtTipoCambio.Text
            End If
        Next

        txtIVA.Text = Format(resultadoIVA, "###,###,##0.#0")

        'End If
        'If Celda.ColumnIndex = 7 Then

        Dim resultadoIVARet As Decimal = 0D

        For Each row As DataGridViewRow In DGVFacturaPagos.Rows
            Dim value As Object = row.Cells("mIVARet4").Value

            Dim d As Decimal

            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultadoIVARet += Convert.ToDecimal(d)

            If row.Cells("mMoneda").Value = 2 Then
                resultadoIVARet = resultadoIVARet * txtTipoCambio.Text
            End If
        Next

        txtIVARet.Text = Format(resultadoIVARet, "###,###,##0.#0")

        'End If
        'If Celda.ColumnIndex = 8 Then

        Dim resultadoTotal As Decimal = 0D

        For Each row As DataGridViewRow In DGVFacturaPagos.Rows

            Dim value As Object = row.Cells("dTotDoc").Value

            Dim d As Decimal

            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultadoTotal += Convert.ToDecimal(d)
            If row.Cells("mMoneda").Value = 2 Then
                resultadoTotal = resultadoTotal * txtTipoCambio.Text
            End If
        Next

        txtTotalDocumento.Text = Format(resultadoTotal, "###,###,##0.#0")

        'End If
    End Sub




    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        DGVFacturaPagos.DataSource = Nothing
        DGVFacturaPagos.Rows.Clear()
        DGVCapturaPoliza.DataSource = Nothing
        DGVCapturaPoliza.Rows.Clear()
        txtSubtotal.Text = "0.00"
        txtIVA.Text = "0.00"
        txtIVARet.Text = "0.00"
        txtSaldo.Text = "0.00"
        txtTotalDocumento.Text = "0.00"
        txtTotAbono.Text = "0.00"
        txtAbonos.Text = "0.00"
        txtCargos.Text = "0.00"
        txtBenefi.Text = ""
        txtConcepto.Text = ""
        txtConcepto2.Text = ""
        txtConcepto3.Text = ""
        txtConcepto4.Text = ""
        txtConcepto5.Text = ""
        txtConcepto6.Text = ""
        cbxProveedores.Text = ""
        txtBenefLibre.Text = ""
        txtImporteLibre.Text = "0.00"
        txtTotAbonoDlls.Text = "0.00"
        'lblCantidadLetra.Text = ""
        txtCantidadLetra.Text = ""
        cbxMetodoPago.SelectedIndex = 0
        cbxBancos.SelectedIndex = 0
        txtCargos.Text = "0.00"
        txtAbonos.Text = "0.00"
        txtTotAbono.Text = "0.00"
        txtTotalCargos.Text = "0.00"
        lstMuestraPol.Items.Clear()
        lblDiferenciaM.Text = ""
        lblDiferencia.Text = ""
        txtFolioSig.Text = "N/A"
        btnPoliza.Enabled = True
        cDolares = 0
        txtFolioDocumento.Text = 0
        txtCuentaT.Text = ""
        txtBancoT.Text = ""
        txtTotalAbonos.Text = "0.00"
        cbxMoneda.SelectedIndex = 0
        cbxProveedores_libre.Text = ""
        txtCodigo_libre.Text = ""
        cbxBancos.Enabled = True
        cbxBancosLibre.Enabled = True

        chbxTodos.Checked = False
        cbxProveedores.Enabled = True
        dtpFecha.Enabled = True
        txtCodigo.Text = ""
        If TbcControl.SelectedIndex = 0 Then
            txtCodigo.Focus()
        Else
            txtCodigo_libre.Focus()
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If TbcControl.SelectedIndex = 1 And cbxMetodoPago.SelectedIndex = 1 Then
            MsgBox("No se Permite realizar Transferencias Sin Facturas", MsgBoxStyle.Exclamation, "Sistema Contable")
            Exit Sub
        End If

        If txtFolioSig.Text = "" Then
            MsgBox("No se ha Selecionado el Banco", MsgBoxStyle.Critical, "Sistema Contable")
            Exit Sub
        End If
        If cbxMetodoPago.Text = "" Then
            MsgBox("No se ha Selecionado un Metodo de Pago", MsgBoxStyle.Critical, "Sistema Contable")
            Exit Sub
        End If
   

        If cbxMoneda.SelectedIndex = 1 And txtTipoCambio.Text = 0.0 Then
            MsgBox("No Se pueden Realizar Operacion sin un tipo de cambio registrado", MsgBoxStyle.Critical, "Sistema Contable")
            Exit Sub
        End If

        VALIDABANCOS_TipMon()


        If Aprobado = 0 Then
            Exit Sub
        End If
        If TbcControl.SelectedIndex = 0 Then

            SumaAbonos()
            If txtTotalAbonos.Text <> txtImporteLibre.Text And txtTotalCargos.Text <> txtImporteLibre.Text Then
                MsgBox("La Poliza Debe Coincidir con el Importe Capturado", MsgBoxStyle.Critical, "Sistema Contable")
                Exit Sub
            End If
            Dim printDoc As New PrintDocument
            If lblCuentaBancaria.Text = "0000000000" Or lblCuentaBancaria.Text = "" Or cbxBancos.Text = "" Or _
                       txtCodigo.Text = "" Or txtTotAbono.Text = 0 Or cbxMetodoPago.Text = "" Or cbxBancos.SelectedValue = 0 Then

                MsgBox("Existen Datos Incompletos Verifique!!", MsgBoxStyle.Information, "SistemaContable")

            Else
                If cbxMetodoPago.Text = "TRANSFERENCIA" Then
                    '---------------------------------
                    '----CODIGO PARA TRANSFERENCIA----
                    If txtBancoT.Text = "" Or txtCuentaT.Text = "" Then
                        MsgBox("Faltan Datos de Cuenta y/o Banco a Transferir", MsgBoxStyle.Information, "Sistema Bancos")
                        Exit Sub
                    End If


                    '----------------------

                    ExtraerTransferCodigo()
                    txtFolioSig.Text = wFolioTransfer
                    Dim frm As New frmMovBancos_Transfer
                    Dim Facturas As String = ""

                    frm.fecha = Format(DTPCheque.Value, "dd/MM/yyyy")
                    frm.CodigoProv = Trim(txtCodigo.Text)
                    frm.NombreProv = Trim(txtBenefi.Text)
                    If Trim(cbxMoneda.Text) = "DOLARES" Then
                        frm.ImportePago = txtTotAbonoDlls.Text
                    Else
                        frm.ImportePago = txtTotAbono.Text
                    End If
                    frm.MetodoPago = cbxMetodoPago.Text
                    frm.Banco = cbxBancos.Text
                    frm.NumeroTransfer = wFolioTransfer
                    frm.TipoMoneda = Trim(cbxMoneda.Text)

                    If txtTotAbono.Text = 0 Then
                        MsgBox("El Abono no puede ser igual a Cero. Verifique!!", MsgBoxStyle.Critical, "Sistema Contable")
                        Exit Sub
                    End If
                    frm.ShowDialog()



                    If MessageBox.Show("¿Desea Guardar la Transferencia?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        '---INICIA GRABADO DE TRANSFERENCIA----

                        GUARDA_MOV_TRANSFERENCIA()

                    End If

                    '--------------------------
                    '----CODIGO PARA CHEQUE----
                Else
                    VALIDA_EXISTECHEQUE()

                    If Aprobado = 0 Then
                        Exit Sub
                    End If

                    Tabcontrol = 0
                    ExtraerChequeCodigo()
                    Dim frm As New frmMovBancos_Pago
                    Dim Facturas As String = ""

                    frm.fecha = Format(DTPCheque.Value, "dd/MM/yyyy")
                    frm.CodigoProv = Trim(txtCodigo.Text)
                    frm.NombreProv = Trim(txtBenefi.Text)
                    If Trim(cbxMoneda.Text) = "DOLARES" Then
                        frm.ImportePago = txtTotAbonoDlls.Text
                    Else
                        frm.ImportePago = txtTotAbono.Text
                    End If

                    frm.MetodoPago = cbxMetodoPago.Text
                    frm.Banco = cbxBancos.Text
                    frm.NumeroCheque = wCheque
                    frm.tipoMoneda = Trim(cbxMoneda.Text)

                    If txtTotAbono.Text = 0 Then
                        MsgBox("El Abono no puede ser igual a Cero. Verifique!!", MsgBoxStyle.Critical, "Sistema Contable")
                        Exit Sub
                    Else
                        frm.ShowDialog()
                    End If

                    If MessageBox.Show("¿Desea Guardar el Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        Dim XError As String
                        Dim clsDB = New clsBD()
                        Dim cnnConexion = New SqlConnection()

                        cnnConexion = clsDB.CreaConexion()

                        Dim wQuery As String = ""
                        Dim cmd As SqlCommand
                        Dim wFolio As String = 0
                        Dim dr As SqlDataReader
                        Dim transaction As SqlTransaction


                        wQuery = "SELECT (folioBcoKardex)+1 as Folio FROM parametros"
                        XError = "Error al obtener Folio Consecutivo"
                        cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                        cmd.CommandType = Data.CommandType.Text
                        transaction = cnnConexion.BeginTransaction

                        '---Convierte el importe en Letras para la generacion de cheque----

                        If Trim(cbxMoneda.Text) = "DOLARES" Then

                            ImporteLetras = NumerosLetras_DLLS(Trim(txtTotAbonoDlls.Text), VbStrConv.ProperCase)
                        Else
                            ImporteLetras = NumerosLetras(Trim(txtTotAbono.Text), VbStrConv.ProperCase)
                        End If

                        cmd.Connection = cnnConexion
                        cmd.Transaction = transaction

                        Dim ActivaPolizaCambiaria As Integer = 0
                        Dim ActivaPolizaComplem As Integer = 0

                        Try
                            dr = cmd.ExecuteReader()
                            If dr.Read Then
                                wFolio = dr("Folio").ToString()
                            Else
                                MsgBox("No Se Genero Consecutivo de Folio Kardex")
                            End If
                            dr.Close()

                            Dim fechaAct As String = Format(Me.DTPCheque.Value, "dd/MM/yyyy")




                            For Each row As DataGridViewRow In DGVFacturaPagos.Rows
                                XError = "Error al Grabar Detalle de Pago"
                                cmd.Parameters.Clear()

                                'Pago dolares
                                If cbxMoneda.SelectedValue = 2 Then

                                    ActivaPolizaComplem = 1
                                End If

                                'Origen dolares - Pago Pesos
                                If row.Cells("mMoneda").Value = 2 And cbxMoneda.SelectedValue = 1 Then

                                    ActivaPolizaCambiaria = 1
                                End If

                                'Dim moneda As Integer
                                'If cbxMoneda.SelectedIndex = 0 Then
                                '    moneda = 1
                                'Else
                                '    moneda = 2
                                'End If

                                If row.Cells("mCantPago").Value > 0 Then

                                    cmd.CommandText = "spInsMovBancos"
                                    cmd.CommandType = CommandType.StoredProcedure
                                    cmd.Connection = cnnConexion
                                    cmd.Transaction = transaction

                                    cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.Int).Value = 55
                                    cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
                                    cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fechaAct
                                    cmd.Parameters.Add("@pCodigoBanco", SqlDbType.Int).Value = wCodigo
                                    cmd.Parameters.Add("@pNumeroCheque", SqlDbType.Int).Value = wCheque
                                    cmd.Parameters.Add("@pCodigoProveedor", SqlDbType.VarChar).Value = Trim(txtCodigo.Text)
                                    cmd.Parameters.Add("@pFolioContrarecibo", SqlDbType.Int).Value = row.Cells("dfolioRP").Value
                                    cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = row.Cells("dFactura").Value

                                    'Origen Pesos----pago DOLARES
                                    If row.Cells("mMoneda").Value = 1 And cbxMoneda.SelectedValue = 2 Then
                                        cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = row.Cells("dSubtotal").Value ' * txtTipoCambio.Text
                                        cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = row.Cells("dIVA").Value ' * txtTipoCambio.Text
                                        cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = row.Cells("mIVA11").Value ' * txtTipoCambio.Text
                                        cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = row.Cells("mIVAImp").Value '* txtTipoCambio.Text
                                        cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = row.Cells("mIVARetHon").Value ' * txtTipoCambio.Text
                                        cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = row.Cells("mIVARetArr").Value ' * txtTipoCambio.Text
                                        cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = row.Cells("mIVARet4").Value '* txtTipoCambio.Text
                                        cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = row.Cells("mISRHon").Value ' * txtTipoCambio.Text
                                        cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = row.Cells("mISRArr").Value ' * txtTipoCambio.Text
                                        cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = row.Cells("mIEPS").Value '* txtTipoCambio.Text

                                        cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = row.Cells("dTotDoc").Value ' * txtTipoCambio.Text
                                        cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value * txtTipoCambio.Text
                                        cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = CDec(row.Cells("mCantPago").Value)


                                    Else
                                        'Origen Dolares----pago Pesos
                                        If row.Cells("mMoneda").Value = 2 And cbxMoneda.SelectedValue = 1 Then

                                            cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = row.Cells("dSubtotal").Value * txtTipoCambio.Text
                                            cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = row.Cells("dIVA").Value * txtTipoCambio.Text
                                            cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = row.Cells("mIVA11").Value * txtTipoCambio.Text
                                            cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = row.Cells("mIVAImp").Value * txtTipoCambio.Text
                                            cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = row.Cells("mIVARetHon").Value * txtTipoCambio.Text
                                            cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = row.Cells("mIVARetArr").Value * txtTipoCambio.Text
                                            cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = row.Cells("mIVARet4").Value * txtTipoCambio.Text
                                            cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = row.Cells("mISRHon").Value * txtTipoCambio.Text
                                            cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = row.Cells("mISRArr").Value * txtTipoCambio.Text
                                            cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = row.Cells("mIEPS").Value * txtTipoCambio.Text

                                            cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = row.Cells("dTotDoc").Value * txtTipoCambio.Text
                                            cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value
                                            cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = CDec(row.Cells("mCantPago").Value / txtTipoCambio.Text)
                                            cDolares = 1
                                        Else
                                            'Origen Dolares----pago Dolares
                                            If row.Cells("mMoneda").Value = 2 And cbxMoneda.SelectedValue = 2 Then

                                                cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = row.Cells("dSubtotal").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = row.Cells("dIVA").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = row.Cells("mIVA11").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = row.Cells("mIVAImp").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = row.Cells("mIVARetHon").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = row.Cells("mIVARetArr").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = row.Cells("mIVARet4").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = row.Cells("mISRHon").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = row.Cells("mISRArr").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = row.Cells("mIEPS").Value * txtTipoCambio.Text

                                                cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = row.Cells("dTotDoc").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value * txtTipoCambio.Text
                                                cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = CDec(row.Cells("mCantPago").Value)

                                            Else
                                                'Origen Pesos----pago Pesos
                                                cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = row.Cells("dSubtotal").Value
                                                cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = row.Cells("dIVA").Value
                                                cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = row.Cells("mIVA11").Value
                                                cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = row.Cells("mIVAImp").Value
                                                cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = row.Cells("mIVARetHon").Value
                                                cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = row.Cells("mIVARetArr").Value
                                                cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = row.Cells("mIVARet4").Value
                                                cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = row.Cells("mISRHon").Value
                                                cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = row.Cells("mISRArr").Value
                                                cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = row.Cells("mIEPS").Value

                                                cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = row.Cells("dTotDoc").Value
                                                cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value

                                                Dim TCAM As Decimal
                                                TCAM = txtTipoCambio.Text
                                                If TCAM = 0.0 Then
                                                    TCAM = 0.0
                                                Else
                                                    TCAM = CDec(row.Cells("mCantPago").Value / txtTipoCambio.Text)
                                                End If
                                                cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = TCAM

                                            End If
                                        End If
                                    End If
                                    cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = 15
                                    cmd.Parameters.Add("@pPoliza", SqlDbType.Int).Value = 0
                                    cmd.Parameters.Add("@pUsuarioModificacion", SqlDbType.VarChar).Value = LoginUsuario
                                    cmd.Parameters.Add("@pBeneficiario", SqlDbType.VarChar).Value = txtBenefi.Text
                                    cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = cbxMoneda.SelectedValue
                                    cmd.Parameters.Add("@pTipoCambio", SqlDbType.Decimal).Value = txtTipoCambio.Text
                                    cmd.ExecuteNonQuery()


                                    '----Rebajar Saldo a la Factura en el Contrarecibo---
                                    Dim TipoMonedaOrigen As Integer
                                    TipoMonedaOrigen = row.Cells("mMoneda").Value
                                    Dim TipoMonedaPago As Integer
                                    TipoMonedaPago = cbxMoneda.SelectedValue

                                    XError = "Error al Actualizar Saldo Contrarecibo"
                                    cmd.Parameters.Clear()
                                    cmd.CommandText = "spMovBancoDescuentaSaldoRP"
                                    cmd.CommandType = CommandType.StoredProcedure
                                    cmd.Connection = cnnConexion

                                    cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = row.Cells("dFactura").Value
                                    cmd.Parameters.Add("@pAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value
                                    cmd.Parameters.Add("@pTipoCambio", SqlDbType.Decimal).Value = txtTipoCambio.Text
                                    cmd.Parameters.Add("@pFolioContrarecibo", SqlDbType.Int).Value = row.Cells("dfolioRP").Value
                                    cmd.Parameters.Add("@pTipoMonedaOrigen", SqlDbType.Int).Value = TipoMonedaOrigen
                                    cmd.Parameters.Add("@pTipoMonedaPago", SqlDbType.Int).Value = TipoMonedaPago

                                    cmd.ExecuteNonQuery()
                                End If

                            Next

                            '----insertar Concepto

                            XError = "Error al Insertar Concepto"
                            cmd.Parameters.Clear()
                            cmd.CommandText = "spInsConceptoMovBancos"
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Connection = cnnConexion

                            cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
                            cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = 15
                            cmd.Parameters.Add("@pConcepto", SqlDbType.VarChar).Value = Trim(txtConcepto.Text)
                            cmd.Parameters.Add("@pConcepto2", SqlDbType.VarChar).Value = Trim(txtConcepto2.Text)
                            cmd.Parameters.Add("@pConcepto3", SqlDbType.VarChar).Value = Trim(txtConcepto3.Text)
                            cmd.Parameters.Add("@pConcepto4", SqlDbType.VarChar).Value = Trim(txtConcepto4.Text)
                            cmd.Parameters.Add("@pConcepto5", SqlDbType.VarChar).Value = Trim(txtConcepto5.Text)
                            cmd.Parameters.Add("@pConcepto6", SqlDbType.VarChar).Value = Trim(txtConcepto6.Text)

                            cmd.ExecuteNonQuery()



                            '----Rebajar Saldo al banco

                            XError = "Error al Actualizar Importe Bancos"
                            cmd.Parameters.Clear()
                            cmd.CommandText = "spActImporteBanco"
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Connection = cnnConexion

                            cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = wCodigo
                            If Trim(cbxMoneda.Text) = "DOLARES" Then
                                cmd.Parameters.Add("@pImporte", SqlDbType.Float).Value = txtTotAbonoDlls.Text
                            Else
                                cmd.Parameters.Add("@pImporte", SqlDbType.Float).Value = txtTotAbono.Text
                            End If


                            cmd.ExecuteNonQuery()



                            '----Adelanta folio de Movimiento en los parametros

                            XError = "Error al Actualizar Parametro Foliador consecutivo "
                            cmd.Parameters.Clear()
                            cmd.CommandText = "spAdeFolioBcoKardex"
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Connection = cnnConexion

                            cmd.Parameters.Add("@Foliokardex", SqlDbType.NVarChar).Value = wFolio


                            cmd.ExecuteNonQuery()


                            '----Adelanta folio de Cheques 

                            XError = "Error al Actualizar Folio consecutivo de Cheque"
                            cmd.Parameters.Clear()
                            cmd.CommandText = "spAdeFolioCheque"
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Connection = cnnConexion

                            cmd.Parameters.Add("@pCodigo", SqlDbType.NVarChar).Value = wCodigo
                            cmd.Parameters.Add("@pNumeroCheque", SqlDbType.NVarChar).Value = wCheque

                            cmd.ExecuteNonQuery()

                            '----Genera Poliza contable


                            XError = "Error al Generar Poliza"
                            cmd.Parameters.Clear()
                            If ActivaPolizaCambiaria = 1 Then
                                cmd.CommandText = "spPolizaBancoCheque_cambiaria"
                            Else
                                If ActivaPolizaComplem = 1 Then
                                    cmd.CommandText = "spPolizaBancoCheque_complem"
                                Else
                                    cmd.CommandText = "spPolizaBancoCheque"
                                End If
                            End If
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Connection = cnnConexion

                            cmd.Parameters.Add("@pFolio", SqlDbType.NVarChar).Value = wFolio
                            cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = LoginUsuario
                            cmd.Parameters.Add("@pMoneda", SqlDbType.NVarChar).Value = cbxMoneda.SelectedValue


                            cmd.ExecuteNonQuery()

                            '-----SI ES DOLARES GENERAR POLIZA CAMBIARIA ---

                            'If ActivaPolizaCambiaria = 1 Then

                            '    XError = "Error al Generar Poliza diferencia Cambiaria"
                            '    cmd.Parameters.Clear()
                            '    cmd.CommandText = "spinspolizadifcam"
                            '    cmd.CommandType = CommandType.StoredProcedure
                            '    cmd.Connection = cnnConexion

                            '    cmd.Parameters.Add("@FolioKar", SqlDbType.Int).Value = wFolio
                            '    cmd.Parameters.Add("@TipoPoliza", SqlDbType.Int).Value = 15
                            '    cmd.Parameters.Add("@fecha", SqlDbType.NVarChar).Value = fechaAct
                            '    cmd.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = LoginUsuario


                            '    cmd.ExecuteNonQuery()
                            'End If




                            '-----IMPRESION de CHEQUE--
                            Dim dr2 As SqlDataReader
                            XError = "Error al Imprimir Cheque"
                            cmd.Parameters.Clear()
                            cmd.CommandText = "spSelCoordenadasImp"
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Connection = cnnConexion
                            cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = wCodigo

                            dr2 = cmd.ExecuteReader()

                            If dr2.Read Then
                                FechaX = Trim(dr2("FechaX").ToString)
                                FechaY = Trim(dr2("FechaY").ToString)
                                NombreX = Trim(dr2("NombreX").ToString)
                                NombreY = Trim(dr2("NombreY").ToString)
                                MontoNumX = Trim(dr2("MontoNumX").ToString)
                                MontoNumY = Trim(dr2("MontoNumY").ToString)
                                MontoLtrX = Trim(dr2("MontoLtrX").ToString)
                                MontoLtrY = Trim(dr2("MontoLtrY").ToString)
                                ConceptoX = Trim(dr2("ConceptoX").ToString)
                                ConceptoY = Trim(dr2("ConceptoY").ToString)
                                ConceptoInfX = Trim(dr2("ConceptoInfX").ToString)
                                ConceptoInfY = Trim(dr2("ConceptoInfY").ToString)
                                ConceptoImpX = Trim(dr2("ConceptoImpX").ToString)
                                ConceptoImpY = Trim(dr2("ConceptoImpY").ToString)
                                PolizaX = Trim(dr2("PolizaX").ToString)
                                PolizaY = Trim(dr2("PolizaY").ToString)

                            End If
                            dr2.Close()
                            '----- Consultar Numero de Poliza---
                            'cmd.Dispose()

                            XError = "Error al Consultar Poliza"
                            Dim wQuerypoliza As String = ""
                            Dim dr10 As SqlDataReader

                            cmd.Parameters.Clear()
                            wQuerypoliza = "SELECT top 1 Folio,Poliza,PolizaTC  FROM bcoKardexMovimientos (NOLOCK) where codigoBanco= " & wCodigo & " and numerocheque= " & wCheque
                            cmd = New Data.SqlClient.SqlCommand(wQuerypoliza, cnnConexion)
                            cmd.CommandType = Data.CommandType.Text

                            cmd.Connection = cnnConexion
                            cmd.Transaction = transaction
                            dr10 = cmd.ExecuteReader

                            If dr10.Read Then
                                'If cDolares = 1 Then
                                '    wPoliza = dr10("Poliza").ToString()
                                '    wFolioKardex = dr10("Folio").ToString()
                                '    wPolizaTC = dr10("PolizaTC").ToString()
                                'Else
                                wPoliza = dr10("Poliza").ToString()
                                wFolioKardex = dr10("Folio").ToString()
                                wPolizaTC = 0
                                'End If
                            Else
                            MsgBox("Error al obtener Numero de Poliza")
                            End If

                            dr10.Close()


                            '---- Finalizacion de Trasaccion
                            transaction.Commit()
                            MsgBox("Se Grabo Correctamente", MsgBoxStyle.Information, "Sistema Contable")


                            If MessageBox.Show("¿Desea Imprimir el Documento ?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                XError = "Error al Imprimir Documento"
                                '-------------IMPRESORA-------------

                                Dim FRM2 As New frmSeleccionarImpresora
                                FRM2.Banco = lblCuentaBancaria.Text
                                FRM2.numcheque = txtFolioSig.Text
                                FRM2.letra = Trim(ImporteLetras)
                                FRM2.ShowDialog()


                                If FRM2.ImpresoraSeleccionada = "" Then
                                    If MessageBox.Show("Se imprima con impresora predeterminada de windows", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                                        Exit Sub
                                    End If

                                End If
                                ' MsgBox("Prepare Impresora ", MsgBoxStyle.Information, "Sistema Contable")

                                '---- Finalizacion de Trasaccion
                                folioMovimiento = wPoliza
                                AddHandler printDoc.PrintPage, AddressOf print_PrintPage_libre
                                'printDoc.PrinterSettings.PrinterName = "EPSON"

                                printDoc.Print()
                            End If

                            'If cDolares = 1 And Trim(cbxMoneda.Text) = "PESOS" Then
                            '    MsgBox("Poliza Cambiaria", MsgBoxStyle.Information)
                            '    Dim frmConsultaPoliza As New frmRPTPolizasManual
                            '    frmConsultaPoliza.fecha = fechaAct
                            '    frmConsultaPoliza.tipoPoliza = 70
                            '    frmConsultaPoliza.folio = wPolizaTC
                            '    frmConsultaPoliza.ShowDialog()
                            'End If
                            btnNuevo.PerformClick()
                            chbxTodos.CheckState = CheckState.Checked
                  
                        Catch err As Exception
                            transaction.Rollback()
                            MsgBox("Ocurrio un Error al Grabar " & XError, MsgBoxStyle.Critical)
                            MessageBox.Show("Error:" & err.Message)

                        Finally
                            cnnConexion.Dispose()
                            cnnConexion.Close()

                            'btnBusca.PerformClick()

                        End Try
                        Shell(String.Format("rundll32 printui.dll,PrintUIEntry /y /n ""{0}""", ImpresoraActual))
                    End If
                End If
            End If
        End If

        If TbcControl.SelectedIndex = 1 Then
            '------------------SEGUNDA PESTAÑA CHEQUES LIBRE------------------------
            VALIDA_EXISTECHEQUE()

            If Aprobado = 0 Then
                Exit Sub
            End If

            SUMAPPOLIZA()
            ingresadatos()


            If lblCuentaBancaria.Text = "0000000000" Or lblCuentaBancaria.Text = "" Or cbxBancos.Text = "" Or _
                txtTotAbono.Text = 0 Or cbxMetodoPago.Text = "" Or cbxBancos.SelectedValue = 0 Or txtImporteLibre.Text = 0 Then

                MsgBox("Existen Datos Incompletos Verifique!!", MsgBoxStyle.Information, "SistemaContable")
            Else
                If DGVCapturaPoliza.Rows.Count < 2 Then
                    MsgBox("La Poliza Debe Contener Mas de una Linea", MsgBoxStyle.Critical, "SistemaContable")

                Else
                    If lblDiferencia.Text <> 0 Then
                        MsgBox("Existen Diferencias Verifique", MsgBoxStyle.Critical, "SistemaContable")
                    Else
                        If CError = 1 Or MError = 1 Then
                            MsgBox("Existen Datos No Validos, Verifique", MsgBoxStyle.Critical, "SistemaContable")
                        Else


                            ingresadatos()
                            Tabcontrol = 1
                            Dim NumFilas As Integer
                            Dim CuentasTot As Long = 0
                            NumFilas = DGVCapturaPoliza.RowCount
                            For Each rowgrid1 As DataGridViewRow In DGVCapturaPoliza.Rows
                                Dim CuentaOK As Object = rowgrid1.Cells("dcuenta").Value
                                'value = rowgrid.Item("Fecha")
                                If CuentaOK > 0 Then
                                    CuentasTot = CuentasTot + 1
                                End If
                            Next

                            If Trim(cbxMoneda.Text) = "DOLARES" Then
                                cDolares = 1
                            End If
                            If NumFilas <> CuentasTot Then
                                MsgBox("Existen Filas Sin Datos Verifique", MsgBoxStyle.Exclamation)
                            Else
                                ''------------INICIO-------------------
                                ExtraerChequeCodigo()
                                Dim frm As New frmMovBancos_Pago
                                Dim Facturas As String = ""

                                frm.fecha = Format(DTPCheque.Value, "dd/MM/yyyy")
                                frm.CodigoProv = 464
                                frm.NombreProv = Trim(txtBenefLibre.Text)
                                If Trim(cbxMoneda.Text) = "DOLARES" Then
                                    frm.ImportePago = txtTotAbonoDlls.Text
                                Else
                                    frm.ImportePago = txtTotAbono.Text
                                End If
                                frm.MetodoPago = cbxMetodoPago.Text
                                frm.Banco = cbxBancos.Text
                                frm.NumeroCheque = wCheque
                                frm.tipoMoneda = cbxMoneda.Text


                                If txtTotAbono.Text = 0 Then
                                    MsgBox("El Abono no puede ser igual a Cero. Verifique!!", MsgBoxStyle.Critical, "Sistema Contable")

                                Else
                                    frm.ShowDialog()
                                End If


                                If MessageBox.Show("¿Desea Guardar el Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                    Dim XError As String
                                    Dim clsDB = New clsBD()
                                    Dim cnnConexion = New SqlConnection()

                                    cnnConexion = clsDB.CreaConexion()

                                    Dim wQuery As String = ""
                                    Dim cmd As SqlCommand
                                    Dim wFolio As String = 0
                                    Dim dr As SqlDataReader
                                    Dim transaction As SqlTransaction


                                    wQuery = "SELECT (folioBcoKardex)+1 as Folio FROM parametros"
                                    XError = "Error al obtener Folio Consecutivo"
                                    cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                                    cmd.CommandType = Data.CommandType.Text
                                    transaction = cnnConexion.BeginTransaction
                                    If Trim(cbxMoneda.Text) = "DOLARES" Then
                                        ImporteLetras = NumerosLetras_DLLS(Trim(txtTotAbonoDlls.Text), VbStrConv.ProperCase)
                                    Else
                                        ImporteLetras = NumerosLetras(Trim(txtTotAbono.Text), VbStrConv.ProperCase)
                                    End If
                                    '---Convierte el importe en Letras para la generacion de cheque----

                                    If cbxMoneda.SelectedIndex = 1 Then
                                        cDolares = 1
                                    End If

                                    cmd.Connection = cnnConexion
                                    cmd.Transaction = transaction

                                    Try
                                        dr = cmd.ExecuteReader()
                                        IndicaFoliosiguiente()
                                        If dr.Read Then
                                            wFolio = dr("Folio").ToString()
                                        Else
                                            MsgBox("No Se Genero Consecutivo de Folio Producto")
                                        End If
                                        dr.Close()

                                        '---EXTRAE LOS VALORES DE IVA CAPTURADOS EN LA POLIZA-----
                                        'VALIDACUENTASIVA()
                                        '---------------------------------------------------------

                                        Dim fechaAct As String = Format(Me.DTPCheque.Value, "dd/MM/yyyy")

                                        'For Each row As DataGridViewRow In DGVFacturaPagos.Rows
                                        XError = "Error al Grabar Detalle de Pago"
                                        cmd.Parameters.Clear()
                                        'If row.Cells("mCantPago").Value > 0 Then

                                        cmd.CommandText = "spInsMovBancos"
                                        cmd.CommandType = CommandType.StoredProcedure
                                        cmd.Connection = cnnConexion
                                        cmd.Transaction = transaction

                                        cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.Int).Value = 55
                                        cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
                                        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fechaAct
                                        cmd.Parameters.Add("@pCodigoBanco", SqlDbType.Int).Value = wCodigo
                                        cmd.Parameters.Add("@pNumeroCheque", SqlDbType.Int).Value = wCheque
                                        cmd.Parameters.Add("@pCodigoProveedor", SqlDbType.VarChar).Value = 464
                                        cmd.Parameters.Add("@pFolioContrarecibo", SqlDbType.Int).Value = 0
                                        cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = vbNullChar
                                        If cDolares = 1 Then
                                            cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = (txtImporteLibre.Text * txtTipoCambio.Text) '- (IVA16 + IVA11 + IVAIMP + IVARetHon + IVARetArr + IVARet4 + ISRHon + ISRArr + IEPS)
                                        Else
                                            cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = (txtImporteLibre.Text) ' - (IVA16 + IVA11 + IVAIMP + IVARetHon + IVARetArr + IVARet4 + ISRHon + ISRArr + IEPS)
                                        End If
                                        cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = 0.0 'IVA16
                                        cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = 0.0 'IVA11
                                        cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = 0.0 'IVAIMP
                                        cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = 0.0 'IVARetHon
                                        cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = 0.0 'IVARetArr
                                        cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = 0.0 'IVARet4
                                        cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = 0.0 'ISRHon
                                        cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = 0.0 'ISRArr
                                        cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = 0.0 'IEPS

                                        cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = txtImporteLibre.Text
                                        cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = txtImporteLibre.Text
                                        If cDolares = 1 Then
                                            cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = CDec(txtImporteLibre.Text)
                                        Else
                                            cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = 0.0
                                        End If
                                        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = 15
                                        cmd.Parameters.Add("@pPoliza", SqlDbType.Int).Value = Trim(txtFolioDocumento.Text)
                                        cmd.Parameters.Add("@pUsuarioModificacion", SqlDbType.VarChar).Value = LoginUsuario
                                        cmd.Parameters.Add("@pBeneficiario", SqlDbType.VarChar).Value = txtBenefLibre.Text
                                        cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = cbxMoneda.SelectedValue
                                        cmd.Parameters.Add("@pTipoCambio", SqlDbType.VarChar).Value = txtTipoCambio.Text
                                        cmd.ExecuteNonQuery()
                                        'End If
                                        'Next

                                        '----insertar Concepto

                                        XError = "Error al Insertar Concepto"
                                        cmd.Parameters.Clear()
                                        cmd.CommandText = "spInsConceptoMovBancos"
                                        cmd.CommandType = CommandType.StoredProcedure
                                        cmd.Connection = cnnConexion

                                        cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
                                        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = 15
                                        cmd.Parameters.Add("@pConcepto", SqlDbType.VarChar).Value = Trim(txtConcepto.Text)
                                        cmd.Parameters.Add("@pConcepto2", SqlDbType.VarChar).Value = Trim(txtConcepto2.Text)
                                        cmd.Parameters.Add("@pConcepto3", SqlDbType.VarChar).Value = Trim(txtConcepto3.Text)
                                        cmd.Parameters.Add("@pConcepto4", SqlDbType.VarChar).Value = Trim(txtConcepto4.Text)
                                        cmd.Parameters.Add("@pConcepto5", SqlDbType.VarChar).Value = Trim(txtConcepto5.Text)
                                        cmd.Parameters.Add("@pConcepto6", SqlDbType.VarChar).Value = Trim(txtConcepto6.Text)

                                        cmd.ExecuteNonQuery()

                                        '----Rebajar Saldo al banco

                                        XError = "Error al Actualizar Importe Bancos"
                                        cmd.Parameters.Clear()
                                        cmd.CommandText = "spActImporteBanco"
                                        cmd.CommandType = CommandType.StoredProcedure
                                        cmd.Connection = cnnConexion

                                        cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = wCodigo
                                        If cbxMoneda.SelectedIndex = 1 Then
                                            cmd.Parameters.Add("@pImporte", SqlDbType.Decimal).Value = txtTotAbonoDlls.Text
                                        Else
                                            cmd.Parameters.Add("@pImporte", SqlDbType.Decimal).Value = txtTotAbono.Text
                                        End If
                                        cmd.ExecuteNonQuery()

                                        '----Genera Poliza contable

                                        XError = "Error al insertar Poliza"
                                        Dim fecha As String
                                        Dim importe As Decimal
                                        Dim CarAbo As String
                                        Dim linea As Integer = 1
                                        Dim CECO As String = ""



                                        CMoneda = cbxMoneda.SelectedValue
                                        fecha = Format(DTPCheque.Value, "yyyyMMdd")
                                        'linea = DGVCapturaPoliza.CurrentRow.Index
                                        'linea = linea + 1

                                        'DGVCapturaPoliza.Sort(DGVCapturaPoliza.Columns("dCargos"), System.ComponentModel.ListSortDirection.Descending)

                                        For Each row As DataGridViewRow In DGVCapturaPoliza.Rows

                                            'Dim direction As New ListSortDirection
                                            'DGVCapturaPoliza.Sort(DGVCapturaPoliza.Columns(1), direction.Ascending)

                                            If row.Cells("dRefDocumento").Value = Nothing Then
                                                row.Cells("dRefDocumento").Value = ""
                                            End If
                                            If row.Cells("dconcepto").Value = Nothing Then
                                                row.Cells("dconcepto").Value = ""
                                            End If
                                            If row.Cells("dReferencia").Value = Nothing Then
                                                row.Cells("dReferencia").Value = ""
                                            End If

                                            CECO = row.Cells("dUnidadNegocio").Value
                                            If CECO = Nothing Then
                                                CECO = ""
                                            End If

                                            If row.Cells("dcargos").Value > 0 Then
                                                importe = row.Cells("dcargos").Value
                                                CarAbo = "C"
                                            Else
                                                importe = row.Cells("dabonos").Value
                                                importe = (importe) * (-1)
                                                CarAbo = "A"
                                            End If


                                            cmd.Parameters.Clear()
                                            cmd.CommandText = "spInsPolizaContable"
                                            cmd.CommandType = CommandType.StoredProcedure
                                            cmd.Connection = cnnConexion

                                            cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fecha
                                            cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.VarChar).Value = 55
                                            cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = 15
                                            cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = txtFolioDocumento.Text
                                            cmd.Parameters.Add("@pCuenta", SqlDbType.VarChar).Value = row.Cells("dcuenta").Value
                                            cmd.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = importe
                                            cmd.Parameters.Add("@pCAR_ABO", SqlDbType.VarChar).Value = CarAbo
                                            cmd.Parameters.Add("@pConcepto", SqlDbType.VarChar).Value = row.Cells("dconcepto").Value
                                            cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = row.Cells("dReferencia").Value
                                            cmd.Parameters.Add("@pRefDocumento", SqlDbType.VarChar).Value = row.Cells("dRefDocumento").Value
                                            cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = CMoneda
                                            cmd.Parameters.Add("@pEstatus", SqlDbType.VarChar).Value = " "
                                            cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = LoginUsuario
                                            'cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = "PRUEBA"
                                            cmd.Parameters.Add("@pNumeroLinea", SqlDbType.VarChar).Value = linea
                                            cmd.Parameters.Add("@pCECO", SqlDbType.VarChar).Value = CECO

                                            cmd.ExecuteNonQuery()

                                            linea = linea + 1
                                        Next

                                        '----Adelanta folio de Movimiento en los parametros

                                        XError = "Error al Actualizar Parametro Foliador consecutivo "
                                        cmd.Parameters.Clear()
                                        cmd.CommandText = "spAdeFolioBcoKardex"
                                        cmd.CommandType = CommandType.StoredProcedure
                                        cmd.Connection = cnnConexion

                                        cmd.Parameters.Add("@Foliokardex", SqlDbType.NVarChar).Value = wFolio

                                        cmd.ExecuteNonQuery()


                                        '----Adelanta folio de Cheques 

                                        XError = "Error al Actualizar Folio consecutivo de Cheque"
                                        cmd.Parameters.Clear()
                                        cmd.CommandText = "spAdeFolioCheque"
                                        cmd.CommandType = CommandType.StoredProcedure
                                        cmd.Connection = cnnConexion

                                        cmd.Parameters.Add("@pCodigo", SqlDbType.NVarChar).Value = wCodigo
                                        cmd.Parameters.Add("@pNumeroCheque", SqlDbType.NVarChar).Value = wCheque

                                        cmd.ExecuteNonQuery()

                                        '-----IMPRESION de CHEQUE--
                                        Dim dr2 As SqlDataReader
                                        XError = "Error al Imprimir Cheque"
                                        cmd.Parameters.Clear()
                                        cmd.CommandText = "spSelCoordenadasImp"
                                        cmd.CommandType = CommandType.StoredProcedure
                                        cmd.Connection = cnnConexion
                                        cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = wCodigo

                                        dr2 = cmd.ExecuteReader()

                                        If dr2.Read Then
                                            FechaX = Trim(dr2("FechaX").ToString)
                                            FechaY = Trim(dr2("FechaY").ToString)
                                            NombreX = Trim(dr2("NombreX").ToString)
                                            NombreY = Trim(dr2("NombreY").ToString)
                                            MontoNumX = Trim(dr2("MontoNumX").ToString)
                                            MontoNumY = Trim(dr2("MontoNumY").ToString)
                                            MontoLtrX = Trim(dr2("MontoLtrX").ToString)
                                            MontoLtrY = Trim(dr2("MontoLtrY").ToString)
                                            ConceptoX = Trim(dr2("ConceptoX").ToString)
                                            ConceptoY = Trim(dr2("ConceptoY").ToString)
                                            ConceptoInfX = Trim(dr2("ConceptoInfX").ToString)
                                            ConceptoInfY = Trim(dr2("ConceptoInfY").ToString)
                                            ConceptoImpX = Trim(dr2("ConceptoImpX").ToString)
                                            ConceptoImpY = Trim(dr2("ConceptoImpY").ToString)
                                            PolizaX = Trim(dr2("PolizaX").ToString)
                                            PolizaY = Trim(dr2("PolizaY").ToString)
                                            dr2.Close()
                                        End If

                                        '---- Finalizacion de Trasaccion

                                        transaction.Commit()
                                        MsgBox("Se Grabo Correctamente", MsgBoxStyle.Information, "Sistema Contable")


                                        'Dim InformeChequeLibre As New frmRPTInformeCheque
                                        'InformeChequeLibre.FolioCheque = wFolio
                                        'InformeChequeLibre.ImporteLetra = ImporteLetras.ToUpper
                                        'InformeChequeLibre.ShowDialog()


                                        If MessageBox.Show("¿Desea Imprimir el Documento?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                            '-------------IMPRESORA-------------

                                            Dim FRM2 As New frmSeleccionarImpresora

                                            FRM2.Banco = lblCuentaBancaria.Text
                                            FRM2.numcheque = wCheque
                                            FRM2.letra = ImporteLetras
                                            FRM2.ShowDialog()


                                            If FRM2.ImpresoraSeleccionada = "" Then
                                                If MessageBox.Show("Se imprima con impresora predeterminada de windows", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                                                    Exit Sub
                                                End If

                                            End If
                                            'MsgBox("Prepare Impresora", MsgBoxStyle.Information, "Sistema Contable")

                                            folioMovimiento = txtFolioDocumento.Text
                                            wPoliza = folioMovimiento
                                            wFolioKardex = wFolio
                                            Dim printDoc As New PrintDocument

                                            AddHandler printDoc.PrintPage, AddressOf print_PrintPage_libre

                                            printDoc.Print()
                                            MsgBox("Se Envio el Documento a la impresora", MsgBoxStyle.Information)

                                        End If
                                        btnNuevo.PerformClick()
                                    Catch err As Exception
                                        transaction.Rollback()
                                        MsgBox("Ocurrio un Error al Grabar " & XError, MsgBoxStyle.Critical)
                                        MessageBox.Show("Error:" & err.Message)
                                    Finally
                                        cnnConexion.Dispose()
                                        cnnConexion.Close()
                                    End Try

                                    '----------------
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ExtraerChequeCodigo()

        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()

        cnnConexion = clsDB.CreaConexion()

        Dim wQuery As String = ""
        Dim cmd As SqlCommand

        Dim dr As SqlDataReader

        wQuery = "SELECT numerocheque+1 as cheque,codigo,cuentacontable FROM catBancos where codigo= " & cbxBancos.SelectedValue

        cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
        cmd.CommandType = Data.CommandType.Text

        cmd.Connection = cnnConexion
        dr = cmd.ExecuteReader()
        If dr.Read Then
            wCheque = dr("cheque").ToString
            wCodigo = dr("codigo").ToString
            '------------------------------
            wCuenta = dr("CuentaContable").ToString
            wCheque = txtFolioSig.Text
        Else
            MsgBox("No Se encontro informacion del banco seleccionado", MsgBoxStyle.Information, "Sistema Contable")

        End If
    End Sub

    Private Sub CargarBancos()

        Dim dr As SqlDataReader
        Dim oclsbancos As New clsBancos
        Dim dt As New DataTable
        dr = oclsbancos.SeleccionaBancosListaItem()

        dt.Load(dr)

        cbxBancos.ValueMember = Trim("codigo")
        cbxBancos.DisplayMember = Trim("Banco")
        cbxBancos.DataSource = dt

        cbxBancoslibre.ValueMember = Trim("codigo")
        cbxBancoslibre.DisplayMember = Trim("Banco")
        cbxBancoslibre.DataSource = dt

    End Sub

    Private Sub CargaMonedas()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select Tipomoneda,Descripcion from catmonedas (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)


        cbxMoneda.ValueMember = Trim("TipoMoneda")
        cbxMoneda.DisplayMember = Trim("Descripcion")
        cbxMoneda.DataSource = dt

    End Sub

    Private Sub btnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        DGVFacturaPagos.DataSource = Nothing
        DGVFacturaPagos.Rows.Clear()
        If cbxProveedores.Text = "" Then
            MsgBox("Seleccione un proveedor", MsgBoxStyle.Exclamation)
        Else
            cbxProveedores.Enabled = False

            Dim fecha As String
            'lblCodigo.Text = ""
            'Valida que el valor del listbox sea un proveedor del catalogo
            If cbxProveedores.SelectedValue = Nothing Or txtCodigo.Text = "" Then
                MsgBox("No se ha seleccionado ningun proveedor valido", vbCritical, "Sistema Contable")
            Else
                '--------
                If chbxTodos.Checked = True Then
                    fecha = ""
                Else
                    fecha = Format(dtpFecha.Value, "yyyyMMdd")
                End If

                Dim dr As SqlDataReader
                Dim oclsMovBancos = New clsMovBancos()

                dr = oclsMovBancos.SeleccionaCRFacturas(txtCodigo.Text, fecha)
                Dim dt = New DataTable()
                dt.Load(dr)

                If dt.Rows.Count > 0 Then


                    '' llenar DATAGRID ------------------

                    DGVFacturaPagos.Enabled = True
                    DGVFacturaPagos.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente
                    ''Format(CDec(txtTotAbonoDlls.Text), "###,###,##0.#0")
                    DGVFacturaPagos.Columns(0).DataPropertyName = Trim("CodigoProveedor") 'Inserta la cuenta contable
                    DGVFacturaPagos.Columns(1).DataPropertyName = Trim("FolioContraRecibo")
                    DGVFacturaPagos.Columns(2).DataPropertyName = Trim("FechaContraRecibo")
                    DGVFacturaPagos.Columns(3).DataPropertyName = Trim("FechaProgPago")
                    DGVFacturaPagos.Columns(4).DataPropertyName = Trim("FacturaProveedor")
                    DGVFacturaPagos.Columns(5).DataPropertyName = Trim("Subtotal")
                    DGVFacturaPagos.Columns(6).DataPropertyName = Trim("IVA16")
                    DGVFacturaPagos.Columns(7).DataPropertyName = Trim("IVARet4")
                    DGVFacturaPagos.Columns(8).DataPropertyName = Trim("Importe")
                    DGVFacturaPagos.Columns(9).DataPropertyName = Trim("Saldo")
                    DGVFacturaPagos.Columns(10).DataPropertyName = Trim("TipoMoneda")
                    DGVFacturaPagos.Columns(13).DataPropertyName = Trim("IVA11")
                    DGVFacturaPagos.Columns(14).DataPropertyName = Trim("IVAIMP")
                    DGVFacturaPagos.Columns(15).DataPropertyName = Trim("IVARetHon")
                    DGVFacturaPagos.Columns(16).DataPropertyName = Trim("IVARetArr")
                    DGVFacturaPagos.Columns(17).DataPropertyName = Trim("ISRHon")
                    DGVFacturaPagos.Columns(18).DataPropertyName = Trim("ISRArr")
                    DGVFacturaPagos.Columns(19).DataPropertyName = Trim("IEPS")
                    DGVFacturaPagos.Columns(20).DataPropertyName = Trim("TipoCambio")

                    DGVFacturaPagos.DataSource = dt


                    BtnEliminar.Enabled = True
                    'BtnGuardar.Enabled = False
                    SumaImportes()
                    'BtnModificar.Enabled = True

                Else

                    MsgBox("No existen Documentos Pendientes de pago del proveedor y Fecha seleccionada", vbInformation, "Sistema Contable")
                    cbxProveedores.Enabled = True
                    cbxProveedores.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub cbxProveedores_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxProveedores.SelectedIndexChanged
        If cbxProveedores.SelectedValue = "" Then
            MsgBox("No se ah Seleccionado ningun proveedor", MsgBoxStyle.Critical)
        Else
            buscaCodigoProveedor()
            txtBenefi.Text = cbxProveedores.Text
        End If
    End Sub

    Private Sub chbxTodos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbxTodos.CheckedChanged
        If chbxTodos.Checked = True Then
            dtpFecha.Enabled = False
        Else
            dtpFecha.Enabled = True
        End If
    End Sub

    Private Sub cbxBancos_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxBancos.SelectedIndexChanged

        lblCuentaBancaria.Text = cbxBancos.SelectedValue

        Dim DR As SqlDataReader
        Dim oclsBancos As New clsBancos

        DR = oclsBancos.SeleccionaBancos(cbxBancos.SelectedValue)

        If DR.Read Then
            cbxMoneda.Text = DR("TipoMoneda").ToString
            cbxTipoMonLibre.Text = DR("TipoMoneda").ToString

            If cbxMetodoPago.Text = "CHEQUE" Then
                txtFolioSig.Text = DR("NumeroCheque").ToString + 1
            Else

            End If
        Else
            'txtFolioSig.Text = "N/A"
        End If
        If TbcControl.SelectedIndex = 0 Then
            SumaAbonos()
        Else
            ingresadatos()
        End If

    End Sub
    Private Sub DGVFacturaPagos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGVFacturaPagos.MouseUp
        DGVFacturaPagos.EndEdit()
    End Sub

    Private Sub DGVFacturaPagos_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVFacturaPagos.CellMouseClick
        ' Detecta si se ha seleccionado el header 
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = DGVFacturaPagos.Rows(e.RowIndex)
        Dim celda As DataGridViewCell = DGVFacturaPagos.CurrentCell
        If celda.ColumnIndex = 11 Then

            'If row.Cells("mMoneda").Value = 1 And cbxMoneda.SelectedValue = 2 Then
            '    row.Cells("mCantPago").Value = CDec(row.Cells("mCantPago").Value) / txtTipoCambio.Text
            'End If

            If row.Cells("mSelTod").Value = False Then
                If cbxMoneda.SelectedValue = row.Cells("mMoneda").Value Then
                    row.Cells("mCantPago").Value = row.Cells("mSaldo").Value
                Else
                    If cbxMoneda.SelectedValue = 1 And row.Cells("mMoneda").Value = 2 Then
                        row.Cells("mCantPago").Value = (row.Cells("mSaldo").Value) * CDbl(txtTipoCambio.Text)
                    Else
                        If cbxMoneda.SelectedValue = 2 And row.Cells("mMoneda").Value = 1 Then
                            row.Cells("mCantPago").Value = (row.Cells("mSaldo").Value) / CDbl(txtTipoCambio.Text)
                        End If
                    End If
                End If
                SumaAbonos()
            Else
                row.Cells("mCantPago").Value = "0.00"
                SumaAbonos()
            End If
        End If
    End Sub
    Private Sub DGVFacturaPagos_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFacturaPagos.CellContentClick
    
    End Sub

    Private Sub DGVFacturaPagos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFacturaPagos.CellEndEdit
        SumaAbonos()
    End Sub

  

    Private Sub DGVFacturaPagos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGVFacturaPagos.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf Validar_Numeros_Facturas
    End Sub

    Private Sub DGVFacturaPagos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVFacturaPagos.LostFocus
        SumaAbonos()
    End Sub

    Private Sub txtImporteLibre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteLibre.Click
        txtImporteLibre.SelectAll()
    End Sub

    Private Sub txtImporteLibre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteLibre.GotFocus
        txtImporteLibre.SelectAll()
    End Sub

    Private Sub txtImporteLibre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteLibre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            ingresadatos()
            cbxBancosLibre.Focus()
        End If

        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub txtImporteLibre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteLibre.LostFocus
        ingresaDatos()
    End Sub
    Private Sub print_PrintPage_libre(ByVal sender As Object, _
                           ByVal e As PrintPageEventArgs)


        Dim Importe As String
        Dim numeroletra As String

        Dim CARACTERES As Integer
        'Dim conceptoLin1 As String
        'Dim conceptoLin2 As String
        If Trim(cbxMoneda.Text) = "DOLARES" Then
            Importe = txtTotAbonoDlls.Text
        Else
            Importe = txtTotAbono.Text
        End If
        CARACTERES = 15 - Len(Importe)

        'If Importe > 999999 Then
        '    Importe = Importe.PadLeft(15, " ")

        'Else
        '    Importe = Importe.PadLeft(13, " ")
        'End If
        numeroletra = ImporteLetras.ToUpper


        Dim clsDB As New clsBD
        Dim cnnConexion = New SqlConnection()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.Connection = cnnConexion

        Dim DR As SqlDataReader
        Dim CuentaLin1 As String
        Dim DescripcionLin1 As String
        Dim ImporteLin1 As String

        Dim DR2 As SqlDataReader
        Dim CuentaLin2 As String
        Dim DescripcionLin2 As String
        Dim ImporteLin2 As String

        Dim DR3 As SqlDataReader
        Dim CuentaLin3 As String
        Dim DescripcionLin3 As String
        Dim ImporteLin3 As String

        Dim DR4 As SqlDataReader
        Dim CuentaLin4 As String
        Dim DescripcionLin4 As String
        Dim ImporteLin4 As String

        Dim DR5 As SqlDataReader
        Dim ImporteLin5 As String
        Dim DR6 As SqlDataReader
        Dim ImporteLin6 As String
        Dim Poliza As Integer = 0

        Dim PROVEEDOR As String
        Dim IVA As Integer = 0

        If TbcControl.SelectedIndex = 1 Then
            IVA = 1
        End If

        If TbcControl.SelectedIndex = 0 Or TbcControl.SelectedIndex = Nothing Then
            PROVEEDOR = txtBenefi.Text
            Poliza = folioMovimiento
        Else
            PROVEEDOR = txtBenefLibre.Text
            wFolioKardex = ""
            Poliza = Trim(txtFolioDocumento.Text)

        End If

        cmd.Parameters.Clear()
        cmd.CommandText = "spSelPolizaImpresionCoordenadas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipopoliza", SqlDbType.Int).Value = 15
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = wFolioKardex
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 1
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = Poliza
        cmd.Parameters.Add("@pConIVA", SqlDbType.VarChar).Value = IVA

        DR = cmd.ExecuteReader()
        If DR.Read Then

            CuentaLin1 = DR("Cuenta").ToString
            DescripcionLin1 = DR("Descripcion").ToString
            ImporteLin1 = DR("Importe").ToString
            ImporteLin1 = Format(CDec(ImporteLin1), "###,###,##0.#0")

        Else
            CuentaLin1 = ""
            DescripcionLin1 = ""
            ImporteLin1 = ""
        End If
        DR.Close()
        cmd.Parameters.Clear()


        cmd.CommandText = "spSelPolizaImpresionCoordenadas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipopoliza", SqlDbType.Int).Value = 15
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = wFolioKardex
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 2
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = Poliza
        cmd.Parameters.Add("@pConIVA", SqlDbType.VarChar).Value = IVA

        DR2 = cmd.ExecuteReader()

        If DR2.Read Then

            CuentaLin2 = DR2("Cuenta").ToString
            DescripcionLin2 = DR2("Descripcion").ToString
            ImporteLin2 = DR2("Importe").ToString
            ImporteLin2 = Format(CDec(ImporteLin2), "###,###,##0.#0")
        Else

            CuentaLin2 = ""
            DescripcionLin2 = ""
            ImporteLin2 = ""

        End If
        DR2.Close()
        cmd.Parameters.Clear()


        cmd.CommandText = "spSelPolizaImpresionCoordenadas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipopoliza", SqlDbType.Int).Value = 15
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = wFolioKardex
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 3
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = Poliza
        cmd.Parameters.Add("@pConIVA", SqlDbType.VarChar).Value = IVA

        DR3 = cmd.ExecuteReader()

        If DR3.Read Then

            CuentaLin3 = DR3("Cuenta").ToString
            DescripcionLin3 = DR3("Descripcion").ToString
            ImporteLin3 = DR3("Importe").ToString
            ImporteLin3 = Format(CDec(ImporteLin3), "###,###,##0.#0")
        Else

            CuentaLin3 = ""
            DescripcionLin3 = ""
            ImporteLin3 = ""

        End If

        DR3.Close()
        cmd.Parameters.Clear()


        cmd.CommandText = "spSelPolizaImpresionCoordenadas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipopoliza", SqlDbType.Int).Value = 15
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = wFolioKardex
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 4
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = Poliza
        cmd.Parameters.Add("@pConIVA", SqlDbType.VarChar).Value = IVA

        DR4 = cmd.ExecuteReader()

        If DR4.Read Then

            CuentaLin4 = DR4("Cuenta").ToString
            DescripcionLin4 = DR4("Descripcion").ToString
            ImporteLin4 = DR4("Importe").ToString
            ImporteLin4 = Format(CDec(ImporteLin4), "###,###,##0.#0")
        Else

            CuentaLin4 = ""
            DescripcionLin4 = ""
            ImporteLin4 = ""

        End If
        DR4.Close()

        '----SUMAR CARGOS----
        cmd.Parameters.Clear()


        cmd.CommandText = "spSelPolizaImpresionCoordenadas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipopoliza", SqlDbType.Int).Value = 15
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = wFolioKardex
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 5
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = Poliza
        cmd.Parameters.Add("@pConIVA", SqlDbType.VarChar).Value = IVA

        DR5 = cmd.ExecuteReader()

        If DR5.Read Then
            ImporteLin5 = DR5("Importe").ToString
            Poliza = DR5("Poliza").ToString
            ImporteLin5 = Format(CDec(ImporteLin5), "###,###,##0.#0")
        Else
            ImporteLin5 = "0.00"

        End If
        DR5.Close()

        '----SUMAR ABONOS----
        cmd.Parameters.Clear()


        cmd.CommandText = "spSelPolizaImpresionCoordenadas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipopoliza", SqlDbType.Int).Value = 15
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = wFolioKardex
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 6
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = Poliza
        cmd.Parameters.Add("@pConIVA", SqlDbType.VarChar).Value = IVA

        DR6 = cmd.ExecuteReader()

        If DR6.Read Then
            ImporteLin6 = DR6("Importe").ToString * -1
            Poliza = DR6("Poliza").ToString
        Else
            ImporteLin6 = "0.00"

        End If
        DR6.Close()


        '--------------------------------------------------------

        Dim prFont As New Font("Times New Roman", 13)
        Dim prFontNumImp As New Font("Times New Roman", 11)
        Dim prFontNum As New Font("Times New Roman", 10)
        Dim prFontPol As New Font("Times New Roman", 9)
        '-------Linea de la Fecha --------------
        e.Graphics.DrawString(Trim(Format(DTPCheque.Value, "dd/MM/yyyy")), prFontNumImp, Brushes.Black, FechaX, FechaY)
        '-------Linea del Proveedor-------------
        e.Graphics.DrawString(Trim(PROVEEDOR), prFont, Brushes.Black, NombreX, NombreY)
        '-------Linea del Importe Numero--------
        e.Graphics.DrawString(Trim(Importe), prFontNumImp, Brushes.Black, MontoNumX + CARACTERES, MontoNumY)
        '-------Linea del Importe con letra-----
        e.Graphics.DrawString(Trim("(" & numeroletra & ")"), prFontNum, Brushes.Black, MontoLtrX, MontoLtrY)
        '-------Linea del Concepto Linea 1------
        e.Graphics.DrawString(Trim(txtConcepto.Text), prFontNum, Brushes.Black, ConceptoX, ConceptoY)
        '-------Linea del Concepto Linea 2------
        e.Graphics.DrawString(Trim(txtConcepto2.Text), prFontNum, Brushes.Black, ConceptoX, (ConceptoY) + 20)
        '-------Linea del Concepto Linea 3------
        e.Graphics.DrawString(Trim(txtConcepto3.Text), prFontNum, Brushes.Black, ConceptoX, (ConceptoY) + 40)
        '-------Linea del Concepto Linea 4------
        e.Graphics.DrawString(Trim(txtConcepto4.Text), prFontNum, Brushes.Black, ConceptoX, (ConceptoY) + 60)
        '-------Linea del Concepto Linea 5------
        e.Graphics.DrawString(Trim(txtConcepto5.Text), prFontNum, Brushes.Black, ConceptoX, (ConceptoY) + 80)
        '-------Linea del Concepto Linea 6------
        e.Graphics.DrawString(Trim(txtConcepto6.Text), prFontNum, Brushes.Black, ConceptoX, (ConceptoY) + 100)
        '-------Linea del Concepto Linea Inferior
        e.Graphics.DrawString(Trim(PROVEEDOR), prFontNum, Brushes.Black, ConceptoInfX, ConceptoInfY)
        '-------Linea del Concepto Linea Inferior Importe -----
        e.Graphics.DrawString(Trim(Importe), prFontNumImp, Brushes.Black, ConceptoImpX + CARACTERES, ConceptoImpY)

        'Dim CuentaBanco As String
        'Dim CuentaProveedor As String
        'Dim ImportePoliza As String
        'ImportePoliza = txtTotAbono.Text.PadLeft(14, " ")

        'CuentaBanco = wCuenta
        'CuentaProveedor = wCuentaProv

        e.HasMorePages = False

        '---LINEA 1 CUENTA---
        e.Graphics.DrawString(Trim(CuentaLin1), prFontPol, Brushes.Black, PolizaX, PolizaY)
        '---LINEA 1 DESCRIPCION---
        e.Graphics.DrawString(Trim(DescripcionLin1), prFontPol, Brushes.Black, (PolizaX + 200), PolizaY)
        '---LINEA 1 IMPORTE---
        If ImporteLin1 = "" Then

        Else
            If ImporteLin1 > 0 Then '--(PolizaX + 490)
                ImporteLin1 = Format(CDec(ImporteLin1), "###,###,##0.#0")
                ImporteLin1 = ImporteLin1.PadLeft(14, " ")
                e.Graphics.DrawString(Trim(ImporteLin1), prFontPol, Brushes.Black, (PolizaX + 550), (PolizaY))
            Else
                ImporteLin1 = ImporteLin1 * -1
                ImporteLin1 = Format(CDec(ImporteLin1), "###,###,##0.#0")
                ImporteLin1 = ImporteLin1.PadLeft(14, " ")
                e.Graphics.DrawString(Trim(ImporteLin1), prFontPol, Brushes.Black, (PolizaX + 660), (PolizaY))
            End If
        End If

        'If Tabcontrol = 1 Then '--Inicia ocultar poliza

        '---LINEA 2 CUENTA---
        e.Graphics.DrawString(Trim(CuentaLin2), prFontPol, Brushes.Black, PolizaX, (PolizaY + 50))
        '---LINEA 2 DESCRIPCION---
        e.Graphics.DrawString(Trim(DescripcionLin2), prFontPol, Brushes.Black, (PolizaX + 200), (PolizaY + 50))
        '---LINEA 2 IMPORTE---
        If ImporteLin2 = "" Then

        Else
            If ImporteLin2 > 0 Then
                ImporteLin2 = Format(CDec(ImporteLin2), "###,###,##0.#0")
                ImporteLin2 = ImporteLin2.PadLeft(14, " ")
                e.Graphics.DrawString(Trim(ImporteLin2), prFontPol, Brushes.Black, (PolizaX + 550), (PolizaY + 50))
            Else
                ImporteLin2 = ImporteLin2 * -1
                ImporteLin2 = Format(CDec(ImporteLin2), "###,###,##0.#0")
                ImporteLin2 = ImporteLin2.PadLeft(14, " ")
                e.Graphics.DrawString(Trim(ImporteLin2), prFontPol, Brushes.Black, (PolizaX + 660), (PolizaY + 50))
            End If
        End If

        '---LINEA 3 CUENTA---
        e.Graphics.DrawString(Trim(CuentaLin3), prFontPol, Brushes.Black, PolizaX, (PolizaY + 100))
        '---LINEA 3 DESCRIPCION---
        e.Graphics.DrawString(Trim(DescripcionLin3), prFontPol, Brushes.Black, (PolizaX + 200), (PolizaY + 100))
        '---LINEA 3 IMPORTE---
        If ImporteLin3 = "" Then

        Else
            If ImporteLin3 > 0 Then
                ImporteLin3 = Format(CDec(ImporteLin3), "###,###,##0.#0")
                ImporteLin3 = ImporteLin3.PadLeft(14, " ")
                e.Graphics.DrawString(Trim(ImporteLin3), prFontPol, Brushes.Black, (PolizaX + 550), (PolizaY + 100))

            Else
                ImporteLin3 = ImporteLin3 * -1
                ImporteLin3 = Format(CDec(ImporteLin3), "###,###,##0.#0")
                ImporteLin3 = ImporteLin3.PadLeft(14, " ")
                e.Graphics.DrawString(Trim(ImporteLin3), prFontPol, Brushes.Black, (PolizaX + 660), (PolizaY + 100))
            End If
            'End If
            '--Termina ocultar poliza IVA
        End If
        '---LINEA 4 CUENTA---
        e.Graphics.DrawString(Trim(CuentaLin4), prFontPol, Brushes.Black, PolizaX, (PolizaY + 150))
        '---LINEA 4 DESCRIPCION---
        e.Graphics.DrawString(Trim(DescripcionLin4), prFontPol, Brushes.Black, (PolizaX + 200), (PolizaY + 150))
        '---LINEA 4 IMPORTE---
        If CuentaLin4 = "" Then

        Else
            If ImporteLin4 > 0 Then
                ImporteLin4 = Format(CDec(ImporteLin4), "###,###,##0.#0")
                ImporteLin4 = ImporteLin4.PadLeft(14, " ")
                e.Graphics.DrawString(Trim(ImporteLin4), prFontPol, Brushes.Black, (PolizaX + 550), (PolizaY + 150))

            Else
                ImporteLin4 = ImporteLin4 * -1
                ImporteLin4 = Format(CDec(ImporteLin4), "###,###,##0.#0")
                ImporteLin4 = ImporteLin4.PadLeft(14, " ")
                e.Graphics.DrawString(Trim(ImporteLin4), prFontPol, Brushes.Black, (PolizaX + 660), (PolizaY + 150))
            End If
        End If

        '---------LINEA DE SUMA-----
        'If Tabcontrol = 1 Then
        If ImporteLin5 < 0 Then
            ImporteLin5 = ImporteLin5 * -1
            ImporteLin5 = Format(CDec(ImporteLin5), "###,###,##0.#0")
            ImporteLin5 = ImporteLin5.PadLeft(14, " ")
        Else
            ImporteLin5 = Format(CDec(ImporteLin5), "###,###,##0.#0")
            ImporteLin5 = ImporteLin5.PadLeft(14, " ")
        End If
        If ImporteLin6 < 0 Then
            ImporteLin6 = ImporteLin6 * -1
            ImporteLin6 = Format(CDec(ImporteLin6), "###,###,##0.#0")
            ImporteLin6 = ImporteLin6.PadLeft(14, " ")
        Else
            ImporteLin6 = Format(CDec(ImporteLin6), "###,###,##0.#0")
            ImporteLin6 = ImporteLin6.PadLeft(14, " ")
        End If

        'Else
        'ImporteLin5 = ImporteLin1
        'ImporteLin6 = ImporteLin4
        'End If

        e.Graphics.DrawString(Trim(ImporteLin5), prFontPol, Brushes.Black, (PolizaX + 550), (PolizaY + 275))
        e.Graphics.DrawString(Trim(ImporteLin6), prFontPol, Brushes.Black, (PolizaX + 660), (PolizaY + 275))

        '--------NUMERO DE CHEQUE--
        e.Graphics.DrawString(Trim("TR-15 "), prFontNum, Brushes.Black, PolizaX, (PolizaY + 300))
        e.Graphics.DrawString(Trim(Poliza & " - " & wCheque), prFontNum, Brushes.Black, (PolizaX + 245), (PolizaY + 300))
    End Sub


    Private Sub btnImpCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpCheque.Click
        Dim frm As New frmBancosMov_Imprimir
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        btnNuevo.PerformClick()
        Dim frm As New frmMovBancos_Elimina
        frm.ShowDialog()
    End Sub

    Private Sub CargatipoCambio()

        Dim DR As SqlDataReader
        Dim oclstipocambio As New clsTipocambio
        DR = oclstipocambio.CargaTipoCambio(Format(dtpFecha.Value, "yyyyMMdd") + " 00:00:00")

        If DR.Read() Then

            txtTipoCambio.Text = DR("TipoCambio").ToString()
            dtpFecha.Enabled = False

        Else
            MsgBox("No hay Tipo de Cambio del dia de hoy", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub ChbxModificaTC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChbxModificaTC.CheckedChanged
        If ChbxModificaTC.Checked = True Then
            txtTipoCambio.Enabled = True
            DTPCheque.Enabled = False
            txtTipoCambio.Focus()
            txtTipoCambio.SelectAll()
        Else
            txtTipoCambio.Enabled = False
            DTPCheque.Enabled = True
        End If
    End Sub

    Private Sub txtTipoCambio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoCambio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SumaAbonos()
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtConcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConcepto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtConcepto2.Focus()
        End If
    End Sub

    Private Sub txtConcepto2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConcepto2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtConcepto3.Focus()
        End If
    End Sub

    Private Sub txtConcepto3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConcepto3.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtConcepto4.Focus()
        End If
    End Sub

    Private Sub txtConcepto4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConcepto4.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtConcepto5.Focus()
        End If
    End Sub
    Private Sub txtConcepto5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConcepto5.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtConcepto6.Focus()
        End If
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtCodigo.Text = "" Then
                MsgBox("No se Capturo un Codigo de Proveedor", MsgBoxStyle.Critical)
            Else
                Dim dr As SqlDataReader
                Dim oClsProveedores As New ClsProveedores

                dr = oClsProveedores.SeleccionaProveedores(txtCodigo.Text)

                If dr.Read() Then

                    cbxProveedores.Text = Trim(dr("Proveedor").ToString())
                    txtBenefi.Text = cbxProveedores.Text
                    cbxProveedores.Focus()
                    dtpFecha.Enabled = True


                    'GiroProveedor = dr("ID").ToString()

                Else
                    MsgBox("No Existe el Codigo de Proveedor", MsgBoxStyle.Critical)
                    txtCodigo.SelectAll()
                    cbxProveedores.Text = ""
                    txtBenefi.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub txtBenefLibre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBenefLibre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            cbxTipoMonLibre.Focus()
            cbxTipoMonLibre.SelectAll()
        End If
    End Sub

    Private Sub DGVCapturaPoliza_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCapturaPoliza.CellClick
        Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
        If Celda.ColumnIndex = 2 Then
            Dim frm As New frmPolizasManuales_Cuentas
            frm.ShowDialog()
            DGVCapturaPoliza.CurrentRow.Cells(1).Value = VPCatCuentasPuente

            '---------------------------------------------------------------------------------------
            '------------------Valida que la cuenta contable exista---------------------------------

            Dim clsBD As New clsBD()

            Dim dr As SqlDataReader
            Dim oclsCuentasContables = New clsCuentasContables()

            'Si la cuenta no tiene datos se le coloca un espacio "" para la consulta SQL
            Dim ValorCelda As String = Convert.ToString(DGVCapturaPoliza.CurrentRow.Cells(1).Value)

            dr = oclsCuentasContables.BuscaContable(ValorCelda)

            Dim dt = New DataTable()
            dt.Load(dr)

            If dt.Rows.Count <> 0 Then
                Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
                DGVCapturaPoliza.CurrentRow.Cells(3).Value = CStr(row("Descripcion"))
                DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Black
                CError = 0
            Else
                MsgBox("La Cuenta Contable no es Valida", MsgBoxStyle.Critical)
                DGVCapturaPoliza.CurrentRow.Cells(3).Value = "<< N° de Cuenta NO Valido >>"
                DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Red
                CError = 1
            End If

            '------------------------------------------------------------------------------------
            '---Eliminacion de la Fila Cuando selecciona el boton ubicado en la primer columna---
        End If
        If Celda.ColumnIndex = 0 Then
            If MessageBox.Show("¿Desea eliminar Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim Fila As DataGridViewRow = Me.DGVCapturaPoliza.CurrentRow()
                DGVCapturaPoliza.Rows.Remove(Fila)
                SUMAPPOLIZA()
                DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Black
                If DGVCapturaPoliza.RowCount = 0 Then
                End If
            End If
        End If
        '------------------------------------------------------------------------------------
        '-----------------------Ayuda Para mostrar CAtalogo de CECOS-------------------------
        If Celda.ColumnIndex = 7 Then

            Dim FrmConcultaCECO As New frmPolizasManuales_CECOS
            FrmConcultaCECO.ShowDialog()

            DGVCapturaPoliza.CurrentRow.Cells(6).Value = Trim(FrmConcultaCECO.DepartamenteSelec)
            DGVCapturaPoliza.Columns(6).DefaultCellStyle.ForeColor = Color.Black
            MError = 0
        End If


    End Sub

    Private Sub DGVCapturaPoliza_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCapturaPoliza.CellEnter
        Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
        '---------------------------------------------------------------------------------------
        '------------------Valida que la cuenta contable exista---------------------------------
        'If Celda.ColumnIndex = 1 Then
        'CCuenta = CCuenta + 1
        'DGVCapturaPoliza.CurrentRow.Cells(9).Value = CCuenta

        'End If
        If Celda.ColumnIndex = 3 Then
            Dim clsBD As New clsBD()

            Dim dr As SqlDataReader
            Dim oclsCuentasContables = New clsCuentasContables()

            '-----Si la cuenta no tiene datos se le coloca un espacio "" para la consulta SQL----
            Dim ValorCelda As String = Convert.ToString(DGVCapturaPoliza.CurrentRow.Cells(1).Value)

            dr = oclsCuentasContables.BuscaContable(ValorCelda)

            Dim dt = New DataTable()
            dt.Load(dr)

            If dt.Rows.Count <> 0 Then
                Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
                DGVCapturaPoliza.CurrentRow.Cells(3).Value = CStr(row("Descripcion"))
                DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Black
                '--------------------------------------------------
                '------------Agrega el numero de linea ------------
                'CCuenta = CCuenta + 1
                'DGVCapturaPoliza.CurrentRow.Cells(9).Value = CCuenta
                CError = 0
            Else
                MsgBox("La Cuenta Contable no es Valida", MsgBoxStyle.Critical)
                DGVCapturaPoliza.CurrentRow.Cells(3).Value = "<< Cuenta NO Valida >>"
                DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Red
                CError = 1
            End If
        End If
        If Celda.ColumnIndex = 7 Then

            Dim ValorCelda As String = Convert.ToString(DGVCapturaPoliza.CurrentRow.Cells(6).Value)

            If ValorCelda = "" Or ValorCelda = "      " Then

            Else
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                Dim consulta As String = "select AREA_DEPTO from VIZ_SelAreaDepto (NOLOCK) where AREA_DEPTO= " & ValorCelda
                Dim cmd As New SqlCommand(consulta, cnnConexion)
                cmd.CommandType = CommandType.Text

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MError = 0
                    DGVCapturaPoliza.Columns(6).DefaultCellStyle.ForeColor = Color.Black
                Else
                    MsgBox("EL Numero de CECO no es valido")
                    DGVCapturaPoliza.Columns(6).DefaultCellStyle.ForeColor = Color.Red
                    MError = 1
                End If
            End If
        End If
        'If Celda.ColumnIndex = 8 Then
        '    DGVCapturaPoliza.CurrentRow.Cells(8).Value = datoConcepto
        'End If

        If existe = 0 Then
            '--------------- NUEVO --------------
            If Celda.ColumnIndex = 5 Then

                If DGVCapturaPoliza.CurrentRow.Cells(4).Value = Nothing Or DGVCapturaPoliza.CurrentRow.Cells(4).ToString = "" Or DGVCapturaPoliza.CurrentRow.Cells(4).Value = vbNullString Then

                    DGVCapturaPoliza.CurrentRow.Cells(4).Value = 0.0
                Else
                    DGVCapturaPoliza.CurrentRow.Cells(4).Value = Format(CDec(DGVCapturaPoliza.CurrentRow.Cells(4).Value), "###,###,##0.#0")

                End If
            End If

            If Celda.ColumnIndex = 6 Then

                If DGVCapturaPoliza.CurrentRow.Cells(5).Value = Nothing Or DGVCapturaPoliza.CurrentRow.Cells(5).ToString = "" Or DGVCapturaPoliza.CurrentRow.Cells(5).Value = vbNullString Then

                    DGVCapturaPoliza.CurrentRow.Cells(5).Value = 0.0
                Else

                    DGVCapturaPoliza.CurrentRow.Cells(5).Value = Format(CDec(DGVCapturaPoliza.CurrentRow.Cells(5).Value), "###,###,##0.#0")
                End If
            End If
        End If

    End Sub

    Private Sub DGVCapturaPoliza_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGVCapturaPoliza.CellFormatting
        If DGVCapturaPoliza.Columns(e.ColumnIndex).Name = "dCuentaHelp" Then e.Value = ". . ."
        If DGVCapturaPoliza.Columns(e.ColumnIndex).Name = "dSelCECO" Then e.Value = ". . ."

    End Sub

    Private Sub DGVCapturaPoliza_CellStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellStateChangedEventArgs) Handles DGVCapturaPoliza.CellStateChanged
        Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
        If Celda.ColumnIndex = 4 Or Celda.ColumnIndex = 5 Then
            SUMAPPOLIZA()
        End If
        Dim Celda2 As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
        If Celda2.ColumnIndex = 6 Then
            DGVCapturaPoliza.FirstDisplayedScrollingColumnIndex = 3
        End If

    End Sub

    Private Sub DGVCapturaPoliza_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGVCapturaPoliza.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf Validar_Numeros
    End Sub

    Private Sub Validar_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '---------------------------------------------------------------------------------
        'VALIDA EN LOS CAMPOS DEL GRID CUENTA,CARGOS,ABONOS SOLO SE PUEDAN ESCRIBIR NUMEROS 

        Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()

        If Celda.ColumnIndex = 1 Or Celda.ColumnIndex = 4 Or Celda.ColumnIndex = 5 Then

            If e.KeyChar = "."c Then

                If InStr(Celda.EditedFormattedValue.ToString, ".", CompareMethod.Text) > 0 Then

                    e.Handled = True
                Else

                    e.Handled = False
                End If
            Else

                If Len(Trim(Celda.EditedFormattedValue.ToString)) > 0 Then

                    If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                        e.Handled = False
                    Else

                        e.Handled = True
                    End If
                Else

                    If e.KeyChar = "0"c Then

                        e.Handled = True
                    Else

                        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                            e.Handled = False
                        Else

                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, _
                                             ByVal keyData As System.Windows.Forms.Keys) As Boolean

        '---------REALIZA EL CAMBIO DEL ENTER POR EL TAB PARA CAMBIAR A LA SIGUIENTE COLUMNA----------------

        If (Not DGVCapturaPoliza.Focused) AndAlso _
           (Not DGVCapturaPoliza.IsCurrentCellInEditMode) Then _
           Return MyBase.ProcessCmdKey(msg, keyData)



        If (keyData <> Keys.Return) Then _
           Return MyBase.ProcessCmdKey(msg, keyData)
        Dim cell As DataGridViewCell = DGVCapturaPoliza.CurrentCell
        Dim columnIndex As Int32 = cell.ColumnIndex
        Dim rowIndex As Int32 = cell.RowIndex



        '-----------------
        '--SI ES LA ULTIMA COLUMNA VALIDARA LOS DATOS Y AGREGARA UN NUEVO REGISTRO--




        If columnIndex = 10 Then
            If CError = 1 Or MError = 1 Or _
                DGVCapturaPoliza.CurrentRow.Cells(1).Value = "" Or DGVCapturaPoliza.CurrentRow.Cells(1).Value Is vbNullChar Then
                MsgBox("Existen Datos No Validos o Incompletos, Verifique")
                DGVCapturaPoliza.CurrentRow.Cells(1).Selected = True
            Else
                If existe = 1 Then
                    Dim UltimaFila As Integer
                    UltimaFila = DGVCapturaPoliza.Rows.Count - 1
                    If DGVCapturaPoliza.CurrentRow.Index = UltimaFila Or UltimaFila = 0 Then
                        Dim dt As DataTable = DirectCast(DGVCapturaPoliza.DataSource, DataTable)

                        Dim row As DataRow = dt.NewRow()
                        row.Item("Fecha") = ""
                        row.Item("TipoMovimiento") = 0
                        row.Item("TipoMoneda") = ""
                        row.Item("DESMoneda") = ""
                        row.Item("TipoPoliza") = ""
                        row.Item("DESTipoPoliza") = ""
                        row.Item("DESEstatus") = ""
                        row.Item("Cuenta") = ""
                        row.Item("DESCuenta") = ""
                        dt.Rows.Add(row)

                        DGVCapturaPoliza.DataSource = dt
                        DGVCapturaPoliza.CurrentRow.Cells("dCuenta").Selected = True
                    End If
                Else
                    Dim UltimaFila As Integer
                    UltimaFila = DGVCapturaPoliza.Rows.Count - 1
                    If DGVCapturaPoliza.CurrentRow.Index = UltimaFila Or UltimaFila = 0 Then

                        DGVCapturaPoliza.Rows.Add()
                        DGVCapturaPoliza.CurrentRow.Cells("dCuenta").Selected = True

                    End If
                End If
            End If
        End If
        If columnIndex = 8 Then
            Dim Nrows As Integer = DGVCapturaPoliza.RowCount
            If Nrows > 1 Then

                Dim concepto As String
                Dim FilaSeleccionada As Integer = (DGVCapturaPoliza.CurrentCell.RowIndex) - 1
                Dim FilaActual As Integer = (DGVCapturaPoliza.CurrentCell.RowIndex)
                If FilaSeleccionada >= 0 Then

                    concepto = DGVCapturaPoliza.Rows(FilaSeleccionada).Cells(9).Value
                    DGVCapturaPoliza.Rows(FilaActual).Cells(9).Value = concepto
                End If
            End If
        End If

        '------------------------------------------------------

        If columnIndex = DGVCapturaPoliza.Columns.Count - 1 Then
            If rowIndex = DGVCapturaPoliza.Rows.Count - 1 Then
                cell = DGVCapturaPoliza.Rows(0).Cells(0)
            Else
                cell = DGVCapturaPoliza.Rows(rowIndex + 1).Cells(0)
            End If

        Else
            cell = DGVCapturaPoliza.Rows(rowIndex).Cells(columnIndex + 1)
        End If

        DGVCapturaPoliza.CurrentCell = cell

        Return True

    End Function
    Private Sub DGVCapturaPoliza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVCapturaPoliza.KeyDown

        If e.Control Then
            If e.KeyCode = Keys.G Then
                BtnGuardar.PerformClick()
            End If
        End If
        '-----------REPITE LA CUENTA QUE SE ENCUENTRA ARRIBA CON LA TECLA F2--------------
        If e.KeyValue = Keys.F2 Then
            'FuncKeysModule(e.KeyValue)
            e.Handled = True

            Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
            Dim Nrows As Integer = DGVCapturaPoliza.RowCount
            If Celda.ColumnIndex = 2 Then

                If Nrows > 1 Then

                    Dim Cuenta As String
                    Dim FilaSeleccionada As Integer = (DGVCapturaPoliza.CurrentCell.RowIndex) - 1
                    Dim FilaActual As Integer = (DGVCapturaPoliza.CurrentCell.RowIndex)
                    Cuenta = DGVCapturaPoliza.Rows(FilaSeleccionada).Cells(1).Value
                    DGVCapturaPoliza.Rows(FilaActual).Cells(1).Value = Cuenta
                End If

            End If

        End If

    End Sub

    Private Sub DGVCapturaPoliza_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVCapturaPoliza.KeyUp
        'If e.KeyCode = Keys.F3 Then
        '    MsgBox("Aqui Repetir")
        'End If
        If e.KeyCode = 112 Then
            Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
            If Celda.ColumnIndex = 2 Then
                frmPolizasManuales_Cuentas.ShowDialog()
                DGVCapturaPoliza.CurrentRow.Cells(1).Value = VPCatCuentasPuente

                '---------------------------------------------------------------------------------------
                '------------------Valida que la cuenta contable exista---------------------------------

                Dim clsBD As New clsBD()

                Dim dr As SqlDataReader
                Dim oclsCuentasContables = New clsCuentasContables()

                'Si la cuenta no tiene datos se le coloca un espacio "" para la consulta SQL
                Dim ValorCelda As String = Convert.ToString(DGVCapturaPoliza.CurrentRow.Cells(1).Value)

                dr = oclsCuentasContables.BuscaContable(ValorCelda)

                Dim dt = New DataTable()
                dt.Load(dr)

                If dt.Rows.Count <> 0 Then
                    Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
                    DGVCapturaPoliza.CurrentRow.Cells(3).Value = CStr(row("Descripcion"))
                    DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Black
                    CError = 0
                Else
                    MsgBox("La Cuenta Contable no es Valida", MsgBoxStyle.Critical)
                    DGVCapturaPoliza.CurrentRow.Cells(3).Value = "<< N° de Cuenta NO Valido >>"
                    DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Red
                    CError = 1
                End If
                '------------------------------------------------------------------------------------
                '---Eliminacion de la Fila Cuando selecciona el boton ubicado en la primer columna---


            End If
        End If
    End Sub

    Private Sub SUMAPPOLIZA()

        '-------------Suma los Cargos y va sumando por registro toda la columna y la coloca en el text Total---------

        Dim resultadoCargos As Decimal = 0D

        For Each row As DataGridViewRow In DGVCapturaPoliza.Rows
            Dim value As Object = row.Cells("dCargos").Value
            Dim d As Decimal

            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultadoCargos += Convert.ToDecimal(d)

            'row.Cells("dCargos").Value = Format(Decimal.TryParse(Convert.ToString(row.Cells("dCargos").Value), d), "###,###,##0.#0")


        Next

        txtTotalCargos.Text = Format(resultadoCargos, "###,###,##0.#0")

        '-------------Suma los Abonos y va sumando por registro toda la columna y la coloca en el text Total---------
        Dim resultadoAbonos As Decimal = 0D

        For Each row As DataGridViewRow In DGVCapturaPoliza.Rows
            Dim value As Object = row.Cells("dAbonos").Value

            Dim d As Decimal

            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultadoAbonos += Convert.ToDecimal(d)

        Next

        txtTotalAbonos.Text = Format(resultadoAbonos, "###,###,##0.#0")

        lblDiferencia.Text = Format((resultadoCargos - resultadoAbonos), "###,###,##0.#0")

        If lblDiferencia.Text <> 0.0 Then

            lblDiferencia.ForeColor = Color.Red
        Else
            lblDiferencia.ForeColor = Color.Green

        End If



    End Sub

    Private Sub btnPoliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoliza.Click
        'IndicaFoliosiguiente()
        btnPoliza.Enabled = False
        DGVCapturaPoliza.Enabled = True
        cbxBancos.Enabled = False
        cbxBancosLibre.Enabled = False


        If cbxBancos.SelectedValue = 0 Then
            DGVCapturaPoliza.Focus()
            DGVCapturaPoliza.Rows.Add()
            DGVCapturaPoliza.FirstDisplayedScrollingColumnIndex = 0
            DGVCapturaPoliza.CurrentRow.Cells(1).Selected = True
        Else

            Dim clsDB = New clsBD()
            Dim cnnConexion = New SqlConnection()

            cnnConexion = clsDB.CreaConexion()

            Dim wQuery As String = ""
            Dim cmd As SqlCommand
            Dim wFolio As String = 0
            Dim dr As SqlDataReader
            'Dim transaction As SqlTransaction


            wQuery = "SELECT (cuentacontable) from catbancos where codigo= " & lblCuentaBancaria.Text
            cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
            cmd.CommandType = Data.CommandType.Text


            '---Convierte el importe en Letras para la generacion de cheque----

            'ImporteLetras = NumerosLetras(Trim(txtTotAbono.Text), VbStrConv.ProperCase)

            cmd.Connection = cnnConexion
            ' cmd.Transaction = transaction

            dr = cmd.ExecuteReader()
            Dim cuenta As String

            If dr.Read Then
                cuenta = dr("cuentaContable").ToString()
                Dim ds = New DataSet()
                Dim dt As New DataTable
                dt.Load(dr)

                '------------------

                DGVCapturaPoliza.Enabled = True
                DGVCapturaPoliza.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente

                'DGVCapturaPoliza.Columns(1).DataPropertyName = Format(CDec("Cuenta"), "###,###,##0.#0")
                DGVCapturaPoliza.Rows.Add()
                DGVCapturaPoliza.Rows.Add()
                DGVCapturaPoliza.Item(1, 1).Value = cuenta 'Inserta la cuenta contable
                DGVCapturaPoliza.Item(3, 1).Value = cbxBancos.Text
                DGVCapturaPoliza.Item(5, 1).Value = txtImporteLibre.Text

                SUMAPPOLIZA()
                DGVCapturaPoliza.Focus()
                DGVCapturaPoliza.FirstDisplayedScrollingColumnIndex = 0
                'DGVCapturaPoliza.CurrentRow.Cells(1).Selected = True
            Else
                MsgBox("No Existe Cuenta Contable")
            End If
            dr.Close()
        End If
    End Sub

    Private Sub FrmMovBancos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            If MessageBox.Show("¿Desea Salir del Modulo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Me.Close()
            End If
        End If
    End Sub


    Private Sub IndicaFoliosiguiente()
        Dim dr As SqlDataReader
        Dim oclsPolizasContables As New clsPolizasContables

        dr = oclsPolizasContables.SeleccionaConsecutivo(15)

        If dr.Read() Then

            txtFolioDocumento.Text = dr("Folio").ToString()
        Else
            txtFolioDocumento.Text = ""
        End If

    End Sub

    Private Sub TbcControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TbcControl.SelectedIndexChanged
        If TbcControl.SelectedIndex = 0 Then
            txtCodigo.Focus()
            btnMuestraPol.Enabled = True
        End If
        If TbcControl.SelectedIndex = 1 Then
            txtCodigo_libre.Focus()
            cbxProveedores_libre.Text = ""
            txtCodigo_libre.Text = ""
            txtBenefLibre.Text = ""
            btnMuestraPol.Enabled = False
            cbxMetodoPago.SelectedIndex = 0
        End If
    End Sub

    Private Sub LlenaPolizaPrevia()

        Dim XError As String
        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()

        cnnConexion = clsDB.CreaConexion()

        Dim wQuery As String = ""
        Dim cmd As SqlCommand
        Dim wFolio As String = 0
        Dim dr As SqlDataReader
        'Dim transaction As SqlTransaction


        wQuery = "SELECT (folioBcoKardex)+1 as Folio FROM parametros"
        XError = "Error al obtener Folio Consecutivo"
        cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
        cmd.CommandType = Data.CommandType.Text


        '---Convierte el importe en Letras para la generacion de cheque----

        'ImporteLetras = NumerosLetras(Trim(txtTotAbono.Text), VbStrConv.ProperCase)

        cmd.Connection = cnnConexion
        ' cmd.Transaction = transaction

        dr = cmd.ExecuteReader()
        If dr.Read Then
            wFolio = dr("Folio").ToString()
        Else
            MsgBox("No Se Genero Consecutivo de Folio Producto")
        End If
        dr.Close()

        Dim fechaAct As String = Format(Me.DTPCheque.Value, "dd/MM/yyyy")
        lstMuestraPol.Items.Clear()
        For Each row As DataGridViewRow In DGVFacturaPagos.Rows
            XError = "Error al Grabar Detalle de Pago"
            cmd.Parameters.Clear()
            If row.Cells("mCantPago").Value > 0 Then

                cmd.CommandText = "spSelPrevioPolizaCheque_prueba2"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnnConexion
                'cmd.Transaction = transaction

                cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.Int).Value = 55
                cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
                cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fechaAct
                cmd.Parameters.Add("@pCodigoBanco", SqlDbType.Int).Value = cbxBancos.SelectedValue
                cmd.Parameters.Add("@pNumeroCheque", SqlDbType.Int).Value = txtFolioSig.Text
                cmd.Parameters.Add("@pCodigoProveedor", SqlDbType.Int).Value = Trim(txtCodigo.Text)
                cmd.Parameters.Add("@pFolioContrarecibo", SqlDbType.Int).Value = row.Cells("dfolioRP").Value
                cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = row.Cells("dFactura").Value
                cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = row.Cells("dSubtotal").Value

                cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = row.Cells("dIVA").Value
                cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = row.Cells("mIVA11").Value
                cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = row.Cells("mIVAImp").Value
                cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = row.Cells("mIVARetHon").Value
                cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = row.Cells("mIVARetArr").Value
                cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = row.Cells("mIVARet4").Value
                cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = row.Cells("mISRHon").Value
                cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = row.Cells("mISRArr").Value
                cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = row.Cells("mIEPS").Value

                cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = row.Cells("dTotDoc").Value
                cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value
                cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = 15
                cmd.Parameters.Add("@pPoliza", SqlDbType.Int).Value = 0
                cmd.Parameters.Add("@pUsuarioModificacion", SqlDbType.VarChar).Value = LoginUsuario
                cmd.Parameters.Add("@pConcepto", SqlDbType.VarChar).Value = Trim(txtConcepto.Text)
                cmd.Parameters.Add("@pConcepto2", SqlDbType.VarChar).Value = Trim(txtConcepto2.Text)
                cmd.Parameters.Add("@pConcepto3", SqlDbType.VarChar).Value = Trim(txtConcepto3.Text)
                cmd.Parameters.Add("@pConcepto4", SqlDbType.VarChar).Value = Trim(txtConcepto4.Text)
                cmd.Parameters.Add("@pConcepto5", SqlDbType.VarChar).Value = Trim(txtConcepto5.Text)
                cmd.Parameters.Add("@pConcepto6", SqlDbType.VarChar).Value = Trim(txtConcepto6.Text)
                cmd.Parameters.Add("@pBeneficiario", SqlDbType.VarChar).Value = txtBenefi.Text
                cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = row.Cells("mMoneda").Value
            
                dr = cmd.ExecuteReader()

                'If dr.Read Then
                Dim dt = New DataTable()
                dt.Load(dr)

                If dt.Rows.Count > 0 Then

                    For Each rRow As DataRow In dt.Rows
                        Dim lstLista As New ListViewItem(rRow("Cuenta").ToString)
                        'lstLista.SubItems.Add(rRow("cuenta").ToString)
                        lstLista.SubItems.Add(rRow("descripcion").ToString)
                        lstLista.SubItems.Add(rRow("cargo").ToString)
                        lstLista.SubItems.Add(rRow("abono").ToString)
                        lstMuestraPol.Items.Add(lstLista)
                    Next
                Else
                    MsgBox("No se Pudieron Obtener los Datos")
                End If
            End If
                'End If
        Next
        SumaImportePoliza()
    End Sub

    Private Sub btnMuestraPol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMuestraPol.Click
        If lblCuentaBancaria.Text = "0000000000" Or lblCuentaBancaria.Text = "" Or cbxBancos.Text = "" Or _
           txtCodigo.Text = "" Or txtTotAbono.Text = 0 Or cbxMetodoPago.Text = "" Or cbxBancos.SelectedValue = 0 Or DGVFacturaPagos.RowCount = 0 Then

            MsgBox("Existen Datos Incompletos Verifique!!")
        Else
            LlenaPolizaPrevia()
        End If
    End Sub

    Private Sub Validar_Numeros_Facturas(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '---------------------------------------------------------------------------------
        'VALIDA EN LOS CAMPOS DEL GRID CUENTA,CARGOS,ABONOS SOLO SE PUEDAN ESCRIBIR NUMEROS 

        Dim Celda As DataGridViewCell = Me.DGVFacturaPagos.CurrentCell()

        If Celda.ColumnIndex = 12 Then

            If e.KeyChar = "."c Then

                If InStr(Celda.EditedFormattedValue.ToString, ".", CompareMethod.Text) > 0 Then

                    e.Handled = True
                Else

                    e.Handled = False
                End If
            Else

                If Len(Trim(Celda.EditedFormattedValue.ToString)) > 0 Then

                    If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                        e.Handled = False
                    Else

                        e.Handled = True
                    End If
                Else

                    If e.KeyChar = "0"c Then

                        e.Handled = True
                    Else

                        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                            e.Handled = False
                        Else

                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub SumaImportePoliza()
        Dim importe As Decimal
        Dim total As Decimal = 0
        For i = 0 To lstMuestraPol.Items.Count - 1
            If lstMuestraPol.Items(i).SubItems(2).Text = "" Then

            Else
                importe = CDec(lstMuestraPol.Items(i).SubItems(2).Text) 'Leemos el valor de la columna de importe
                total = total + importe
                txtCargos.Text = total
                txtCargos.Text = Format(CDec(txtCargos.Text), "##,##0.00")
            End If
            'Leemos el valor de las siguientes columnas
        Next
        total = 0
        For i = 0 To lstMuestraPol.Items.Count - 1
            If lstMuestraPol.Items(i).SubItems(3).Text = "" Then

            Else
                importe = CDec(lstMuestraPol.Items(i).SubItems(3).Text) 'Leemos el valor de la columna de importe
                total = total + importe
                txtAbonos.Text = total
                txtAbonos.Text = Format(CDec(txtAbonos.Text), "##,##0.00")
            End If
        Next
        Dim RESULTADO As Decimal
        RESULTADO = txtCargos.Text - txtAbonos.Text
        lblDiferenciaM.Text = RESULTADO

    End Sub

    Private Sub ExtraerTransferCodigo()

        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()

        cnnConexion = clsDB.CreaConexion()

        Dim wQuery As String = ""
        Dim cmd As SqlCommand

        Dim dr As SqlDataReader

        wQuery = "SELECT folioTransElec+1 as FolioTransfer FROM parametros"

        cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
        cmd.CommandType = Data.CommandType.Text

        cmd.Connection = cnnConexion
        dr = cmd.ExecuteReader()
        If dr.Read Then
            wFolioTransfer = dr("FolioTransfer").ToString
            '------------------------------
        Else
            MsgBox("No Se encontro informacion del banco seleccionado", MsgBoxStyle.Information, "Sistema Contable")

        End If
        dr.Close()
    End Sub

    Private Sub txtCuentaT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaT.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtBancoT.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub cbxMetodoPago_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMetodoPago.SelectedIndexChanged
        cbxBancos.Enabled = True

        If cbxMetodoPago.Text = "CHEQUE" Then

            txtBancoT.Enabled = False
            txtCuentaT.Enabled = False
            txtBancoT.BackColor = Color.LightSteelBlue
            txtCuentaT.BackColor = Color.LightSteelBlue
        Else
            ExtraerTransferCodigo()
            txtFolioSig.Text = wFolioTransfer
            txtBancoT.Enabled = True
            txtCuentaT.Enabled = True
            txtBancoT.BackColor = Color.White
            txtCuentaT.BackColor = Color.White
        End If
    End Sub

    Private Sub GUARDA_MOV_TRANSFERENCIA()
        Dim XError As String
        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()

        cnnConexion = clsDB.CreaConexion()

        Dim wQuery As String = ""
        Dim cmd As SqlCommand
        Dim wFolio As String = 0
        Dim dr As SqlDataReader
        Dim transaction As SqlTransaction

        Dim ActivaPolizaComplem As Integer

        wQuery = "SELECT (foliotransElec)+1 as Folio FROM parametros"
        XError = "Error al obtener Folio Consecutivo"
        cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
        cmd.CommandType = Data.CommandType.Text
        transaction = cnnConexion.BeginTransaction

        '---Convierte el importe en Letras para la generacion de cheque----

        'ImporteLetras = NumerosLetras(Trim(txtTotAbono.Text), VbStrConv.ProperCase)

        cmd.Connection = cnnConexion
        cmd.Transaction = transaction

        Dim ActivaPolizaCambiaria As Integer = 0

        Try
            dr = cmd.ExecuteReader()
            If dr.Read Then
                wFolio = dr("Folio").ToString()
            Else
                MsgBox("No Se Genero Consecutivo de Folio Producto")
            End If
            dr.Close()

            Dim fechaAct As String = Format(Me.DTPCheque.Value, "dd/MM/yyyy")

            For Each row As DataGridViewRow In DGVFacturaPagos.Rows
                XError = "Error al Grabar Detalle de Pago"
                cmd.Parameters.Clear()

                If row.Cells("mCantPago").Value > 0 Then

                    If cbxMoneda.SelectedValue = 2 Then 'Dolares
                        ActivaPolizaComplem = 1
                    End If

                    If row.Cells("mMoneda").Value = 2 And cbxMoneda.SelectedValue = 1 Then
                        ActivaPolizaCambiaria = 1
                    End If

                    cmd.CommandText = "spInsMovBancos"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = cnnConexion
                    cmd.Transaction = transaction

                    cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.Int).Value = 55
                    cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
                    cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fechaAct
                    cmd.Parameters.Add("@pCodigoBanco", SqlDbType.Int).Value = lblCuentaBancaria.Text
                    cmd.Parameters.Add("@pNumeroCheque", SqlDbType.Int).Value = 0
                    cmd.Parameters.Add("@pCodigoProveedor", SqlDbType.VarChar).Value = Trim(txtCodigo.Text)
                    cmd.Parameters.Add("@pFolioContrarecibo", SqlDbType.Int).Value = row.Cells("dfolioRP").Value
                    cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = row.Cells("dFactura").Value


                    'Origen Pesos----pago DOLARES
                    If row.Cells("mMoneda").Value = 1 And cbxMoneda.SelectedValue = 2 Then
                        cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = row.Cells("dSubtotal").Value ' * txtTipoCambio.Text
                        cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = row.Cells("dIVA").Value ' * txtTipoCambio.Text
                        cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = row.Cells("mIVA11").Value ' * txtTipoCambio.Text
                        cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = row.Cells("mIVAImp").Value '* txtTipoCambio.Text
                        cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = row.Cells("mIVARetHon").Value ' * txtTipoCambio.Text
                        cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = row.Cells("mIVARetArr").Value ' * txtTipoCambio.Text
                        cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = row.Cells("mIVARet4").Value '* txtTipoCambio.Text
                        cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = row.Cells("mISRHon").Value ' * txtTipoCambio.Text
                        cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = row.Cells("mISRArr").Value ' * txtTipoCambio.Text
                        cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = row.Cells("mIEPS").Value '* txtTipoCambio.Text

                        cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = row.Cells("dTotDoc").Value ' * txtTipoCambio.Text
                        cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value * txtTipoCambio.Text
                        cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = CDec(row.Cells("mCantPago").Value)


                    Else
                        'Origen Dolares----pago Pesos
                        If row.Cells("mMoneda").Value = 2 And cbxMoneda.SelectedValue = 1 Then

                            cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = row.Cells("dSubtotal").Value * txtTipoCambio.Text
                            cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = row.Cells("dIVA").Value * txtTipoCambio.Text
                            cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = row.Cells("mIVA11").Value * txtTipoCambio.Text
                            cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = row.Cells("mIVAImp").Value * txtTipoCambio.Text
                            cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = row.Cells("mIVARetHon").Value * txtTipoCambio.Text
                            cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = row.Cells("mIVARetArr").Value * txtTipoCambio.Text
                            cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = row.Cells("mIVARet4").Value * txtTipoCambio.Text
                            cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = row.Cells("mISRHon").Value * txtTipoCambio.Text
                            cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = row.Cells("mISRArr").Value * txtTipoCambio.Text
                            cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = row.Cells("mIEPS").Value * txtTipoCambio.Text

                            cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = row.Cells("dTotDoc").Value * txtTipoCambio.Text
                            cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value
                            cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = CDec(row.Cells("mCantPago").Value / txtTipoCambio.Text)
                            cDolares = 1
                        Else
                            'Origen Dolares----pago Dolares
                            If row.Cells("mMoneda").Value = 2 And cbxMoneda.SelectedValue = 2 Then

                                cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = row.Cells("dSubtotal").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = row.Cells("dIVA").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = row.Cells("mIVA11").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = row.Cells("mIVAImp").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = row.Cells("mIVARetHon").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = row.Cells("mIVARetArr").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = row.Cells("mIVARet4").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = row.Cells("mISRHon").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = row.Cells("mISRArr").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = row.Cells("mIEPS").Value * txtTipoCambio.Text

                                cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = row.Cells("dTotDoc").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value * txtTipoCambio.Text
                                cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = CDec(row.Cells("mCantPago").Value)

                            Else
                                'Origen Pesos----pago Pesos
                                cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = row.Cells("dSubtotal").Value
                                cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = row.Cells("dIVA").Value
                                cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = row.Cells("mIVA11").Value
                                cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = row.Cells("mIVAImp").Value
                                cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = row.Cells("mIVARetHon").Value
                                cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = row.Cells("mIVARetArr").Value
                                cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = row.Cells("mIVARet4").Value
                                cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = row.Cells("mISRHon").Value
                                cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = row.Cells("mISRArr").Value
                                cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = row.Cells("mIEPS").Value

                                cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = row.Cells("dTotDoc").Value
                                cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value

                                Dim TCAM As Decimal 'PARA QUE SINO HAY TIPO DE CAMBIO REGISTRADO NO MARQUE ERROR (DIV/0)
                                TCAM = txtTipoCambio.Text
                                If TCAM = 0.0 Then
                                    TCAM = 0.0
                                Else
                                    TCAM = CDec(row.Cells("mCantPago").Value / txtTipoCambio.Text)
                                End If
                                cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = TCAM

                            End If
                        End If
                    End If


                    cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = 34
                    cmd.Parameters.Add("@pPoliza", SqlDbType.Int).Value = 0
                    cmd.Parameters.Add("@pUsuarioModificacion", SqlDbType.VarChar).Value = LoginUsuario
                    cmd.Parameters.Add("@pBeneficiario", SqlDbType.VarChar).Value = txtBenefi.Text
                    cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = cbxMoneda.SelectedValue
                    cmd.Parameters.Add("@pTipoCambio", SqlDbType.VarChar).Value = txtTipoCambio.Text
                    cmd.ExecuteNonQuery()

                    '----Rebajar Saldo a la Factura en el Contrarecibo---
                    Dim TipoMonedaOrigen As Integer
                    TipoMonedaOrigen = row.Cells("mMoneda").Value
                    Dim TipoMonedaPago As Integer
                    TipoMonedaPago = cbxMoneda.SelectedValue

                    XError = "Error al Actualizar Saldo Contrarecibo"
                    cmd.Parameters.Clear()
                    cmd.CommandText = "spMovBancoDescuentaSaldoRP"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = cnnConexion

                    cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = row.Cells("dFactura").Value
                    cmd.Parameters.Add("@pAbono", SqlDbType.Decimal).Value = row.Cells("mCantPago").Value
                    cmd.Parameters.Add("@pTipoCambio", SqlDbType.Decimal).Value = txtTipoCambio.Text
                    cmd.Parameters.Add("@pFolioContrarecibo", SqlDbType.Int).Value = row.Cells("dfolioRP").Value
                    cmd.Parameters.Add("@pTipoMonedaOrigen", SqlDbType.Int).Value = TipoMonedaOrigen
                    cmd.Parameters.Add("@pTipoMonedaPago", SqlDbType.Int).Value = TipoMonedaPago

                    cmd.ExecuteNonQuery()

                End If
            Next
            '----insertar Concepto

            XError = "Error al Insertar Concepto"
            cmd.Parameters.Clear()
            cmd.CommandText = "spInsConceptoMovBancos"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnnConexion

            cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
            cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = 34
            cmd.Parameters.Add("@pConcepto", SqlDbType.VarChar).Value = Trim(txtConcepto.Text)
            cmd.Parameters.Add("@pConcepto2", SqlDbType.VarChar).Value = Trim(txtConcepto2.Text)
            cmd.Parameters.Add("@pConcepto3", SqlDbType.VarChar).Value = Trim(txtConcepto3.Text)
            cmd.Parameters.Add("@pConcepto4", SqlDbType.VarChar).Value = Trim(txtConcepto4.Text)
            cmd.Parameters.Add("@pConcepto5", SqlDbType.VarChar).Value = Trim(txtConcepto5.Text)
            cmd.Parameters.Add("@pConcepto6", SqlDbType.VarChar).Value = Trim(txtConcepto6.Text)

            cmd.ExecuteNonQuery()

            '----insertar Cuentas Trasferencias

            XError = "Error al Insertar Cuenta Transferencia"
            cmd.Parameters.Clear()
            cmd.CommandText = "spInsCuentasTransferencia"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnnConexion

            cmd.Parameters.Add("@pFolioTran", SqlDbType.Int).Value = wFolio
            cmd.Parameters.Add("@pCuenta", SqlDbType.NVarChar).Value = Trim(txtCuentaT.Text)
            cmd.Parameters.Add("@pBanco", SqlDbType.NVarChar).Value = Trim(txtBancoT.Text)

            cmd.ExecuteNonQuery()


            '----Rebajar Saldo al banco

            XError = "Error al Actualizar Importe Bancos"
            cmd.Parameters.Clear()
            cmd.CommandText = "spActImporteBanco"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnnConexion

            cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = Trim(lblCuentaBancaria.Text)
            If cbxMoneda.SelectedValue = 2 Then
                cmd.Parameters.Add("@pImporte", SqlDbType.Float).Value = txtTotAbonoDlls.Text
            Else
                cmd.Parameters.Add("@pImporte", SqlDbType.Float).Value = txtTotAbono.Text
            End If
            cmd.ExecuteNonQuery()

            '----Adelanta folio de Movimiento en los parametros

            XError = "Error al Actualizar Parametro Foliador consecutivo "
            cmd.Parameters.Clear()
            cmd.CommandText = "spAdeFolioTransferencia"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnnConexion

            cmd.Parameters.Add("@FolioTransferencia", SqlDbType.NVarChar).Value = wFolio


            cmd.ExecuteNonQuery()

            '----Genera Poliza contable

            XError = "Error al Generar Poliza"
            cmd.Parameters.Clear()
            If ActivaPolizaCambiaria = 1 Then
                cmd.CommandText = "spPolizaBancoTransfer_cambiaria"
            Else
                If ActivaPolizaComplem = 1 Then
                    cmd.CommandText = "spPolizaBancoTransferencia_complem"
                Else
                    cmd.CommandText = "spPolizaBancoTransferencia"
                End If
            End If
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnnConexion

            cmd.Parameters.Add("@pFolio", SqlDbType.NVarChar).Value = wFolio
            cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = LoginUsuario
            cmd.Parameters.Add("@pMoneda", SqlDbType.NVarChar).Value = cbxMoneda.SelectedValue


            cmd.ExecuteNonQuery()

            '-----SI ES DOLARES GENERAR POLIZA CAMBIARIA ---

            'If cDolares = 1 Then

            '    XError = "Error al Generar Poliza diferencia Cambiaria"
            '    cmd.Parameters.Clear()
            '    cmd.CommandText = "spinspolizadifcam"
            '    cmd.CommandType = CommandType.StoredProcedure
            '    cmd.Connection = cnnConexion

            '    cmd.Parameters.Add("@FolioKar", SqlDbType.Int).Value = wFolio
            '    cmd.Parameters.Add("@TipoPoliza", SqlDbType.Int).Value = 34
            '    cmd.Parameters.Add("@fecha", SqlDbType.NVarChar).Value = fechaAct
            '    cmd.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = LoginUsuario

            '    cmd.ExecuteNonQuery()
            'End If

            '---- Finalizacion de Trasaccion
            transaction.Commit()
            MsgBox("Se Grabo Correctamente", MsgBoxStyle.Information, "Sistema Contable")

            'If cDolares = 1 Then
            '    MsgBox("Poliza Cambiaria", MsgBoxStyle.Information)
            '    Dim frmConsultaPoliza As New frmRPTPolizasManual
            '    frmConsultaPoliza.fecha = fechaAct
            '    frmConsultaPoliza.tipoPoliza = 70
            '    frmConsultaPoliza.folio = wPolizaTC
            '    frmConsultaPoliza.ShowDialog()
            'End If

        Catch err As Exception
            transaction.Rollback()
            MsgBox("Ocurrio un Error al Grabar " & XError, MsgBoxStyle.Critical)
            MessageBox.Show("Error:" & err.Message)
        Finally

            '-----IMPRESION de Informe------
            XError = "Error al Imprimir Transferencia"
            Dim frm As New frmRPTTransferencia
            frm.FolioTransferencia = wFolio
            frm.ShowDialog()


            cnnConexion.Dispose()
            cnnConexion.Close()
            btnNuevo.PerformClick()
            'chbxTodos.CheckState = CheckState.Checked
            'btnBusca.PerformClick()
        End Try
    End Sub

    Private Sub txtTipoCambio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoCambio.LostFocus
        SumaAbonos()
    End Sub

    Private Sub cbxTipoMonLibre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxTipoMonLibre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtImporteLibre.Focus()
            txtImporteLibre.SelectAll()
            ingresadatos()
        End If
    End Sub

    Private Sub ingresadatos()
        If txtImporteLibre.Text = "" Then
            txtImporteLibre.Text = 0.0
        End If
      
        'If txtTipoCambio.Text > 0 Then
        '    txtTotAbonoDlls.Text = (txtTotAbono.Text / txtTipoCambio.Text)
        '    txtTotAbonoDlls.Text = Format(CDec(txtTotAbonoDlls.Text), "##,##0.00")
        'End If

        If Trim(cbxTipoMonLibre.Text) = "DOLARES" Then
            txtCantidadLetra.Text = NumerosLetras_DLLS(Trim(txtImporteLibre.Text), VbStrConv.ProperCase)
            txtImporteLibre.Text = Format(CDec(txtImporteLibre.Text), "##,##0.00")
            txtTotAbonoDlls.Text = Format(CDec(txtImporteLibre.Text), "##,##0.00")
            txtTotAbono.Text = (txtTotAbonoDlls.Text * txtTipoCambio.Text)
            txtTotAbono.Text = Format(CDec(txtTotAbono.Text), "##,##0.00")
        Else
            txtCantidadLetra.Text = NumerosLetras(Trim(txtImporteLibre.Text), VbStrConv.ProperCase)
            txtImporteLibre.Text = Format(CDec(txtImporteLibre.Text), "##,##0.00")
            txtTotAbono.Text = Format(CDec(txtImporteLibre.Text), "##,##0.00")
            If txtTipoCambio.Text = 0 Then
                txtTotAbonoDlls.Text = "0.00"
            Else
                txtTotAbonoDlls.Text = (CDec(txtTotAbono.Text) / CDec(txtTipoCambio.Text))
            End If
            txtTotAbonoDlls.Text = Format(CDec(txtTotAbonoDlls.Text), "##,##0.00")
        End If
        txtCantidadLetra.Text = txtCantidadLetra.Text.ToUpper
    End Sub


    Private Sub cbxTipoMonLibre_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipoMonLibre.SelectedIndexChanged
        cbxMoneda.SelectedIndex = cbxTipoMonLibre.SelectedIndex
        ingresadatos()
    End Sub

    Private Sub VALIDABANCOS_TipMon()

        Dim moneda As Integer
        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()
        cnnConexion = clsDB.CreaConexion()

        Dim wQuery As String = ""
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        wQuery = "SELECT TipoMoneda FROM catbancos WHERE codigo= " & cbxBancos.SelectedValue
        cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
        cmd.CommandType = Data.CommandType.Text

        dr = cmd.ExecuteReader()
        If dr.Read Then
            moneda = dr("TipoMoneda").ToString()
            If moneda = cbxMoneda.SelectedValue Then
                Aprobado = 1
            Else
                MsgBox("No Coinciden Tipo de Moneda PAGO vs BANCO", MsgBoxStyle.Critical, "Sistema Bancos")
                Aprobado = 0
            End If
        Else
            MsgBox("No Se Pudo Comparar Bancos vs TipoMoneda")
        End If

    End Sub
    Private Sub CargaMonedas_libre()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select Tipomoneda,Descripcion from catmonedas (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxTipoMonLibre.ValueMember = Trim("TipoMoneda")
        cbxTipoMonLibre.DisplayMember = Trim("Descripcion")
        cbxTipoMonLibre.DataSource = dt

    End Sub

    Private Sub txtFolioSig_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFolioSig.GotFocus
        txtFolioSig.SelectAll()
    End Sub

    Private Sub btnHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistorico.Click
        Dim frm As New frmMovBancos_Historico
        frm.ShowDialog()
    End Sub
    Private Sub VALIDA_EXISTECHEQUE()

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.Parameters.Clear()
        cmd.CommandText = "spValidaChequesExiste"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = lblCuentaBancaria.Text
        cmd.Parameters.Add("@pCheque", SqlDbType.Int).Value = txtFolioSig.Text
        
        dr = cmd.ExecuteReader()
        If dr.Read Then
            MsgBox("El Cheque Numero " & txtFolioSig.Text & " Del Banco " & cbxBancos.Text & " Ya se Encuentra Registrado Anteriormente ", MsgBoxStyle.Information, "Sistema Contable")
            Aprobado = 0
        Else
            Aprobado = 1
        End If

    End Sub

    Private Sub txtCodigo_libre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo_libre.KeyPress

        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtCodigo_libre.Text = "" Then
                MsgBox("No se Capturo un Codigo de Proveedor", MsgBoxStyle.Critical)
            Else
                Dim dr As SqlDataReader
                Dim oClsProveedores As New ClsProveedores

                dr = oClsProveedores.SeleccionaProveedores(txtCodigo_libre.Text)

                If dr.Read() Then

                    cbxProveedores_libre.Text = Trim(dr("Proveedor").ToString())
                    txtBenefLibre.Text = cbxProveedores_libre.Text
                    cbxProveedores_libre.Focus()


                    'GiroProveedor = dr("ID").ToString()

                Else
                    MsgBox("No Existe el Codigo de Proveedor", MsgBoxStyle.Critical)
                    txtCodigo_libre.SelectAll()
                    cbxProveedores_libre.Text = ""
                    txtBenefLibre.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub cbxProveedores_libre_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxProveedores_libre.SelectedIndexChanged
        If cbxProveedores_libre.SelectedValue = "" Then
            MsgBox("No se ah Seleccionado ningun proveedor", MsgBoxStyle.Critical)
        Else
            buscaCodigoProveedor_libre()
            txtBenefLibre.Text = cbxProveedores_libre.Text
        End If
    End Sub

    Private Sub cbxBancosLibre_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxBancosLibre.SelectedIndexChanged
        lblCuentaBancaria.Text = cbxBancos.SelectedValue

        If cbxMetodoPago.Text = "CHEQUE" Then

            Dim DR As SqlDataReader
            Dim oclsBancos As New clsBancos

            DR = oclsBancos.SeleccionaBancos(cbxBancos.SelectedValue)

            If DR.Read Then
                txtFolioSig.Text = DR("NumeroCheque").ToString + 1
            Else
                txtFolioSig.Text = "N/A"
            End If
        End If
    End Sub

    Private Sub cbxMoneda_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMoneda.SelectedIndexChanged
        If TbcControl.SelectedIndex = 0 Then
            SumaAbonos()
        Else
            ingresadatos()
        End If
    End Sub


    Private Sub VALIDACUENTASIVA()

        Dim oClsMovBancos As New clsMovBancos
        Dim dr As SqlDataReader
        Dim CuentaIVA16 As String
        Dim CuentaIVA11 As String
        Dim CuentaIVAIMP As String
        Dim CuentaIVARetHon As String
        Dim CuentaIVARetArr As String
        Dim CuentaIVARet4 As String
        Dim CuentaISRHon As String
        Dim CuentaISRArr As String
        Dim CuentaIEPS As String

        dr = oClsMovBancos.SeleccionaCuentasIVA()
        If dr.Read Then

            CuentaIVA16 = dr("CuentaIVA16").ToString
            CuentaIVA11 = dr("CuentaIVA11").ToString
            CuentaIVAIMP = dr("CuentaIVAIMP").ToString
            CuentaIVARetHon = dr("CuentaIVARetHon").ToString
            CuentaIVARetArr = dr("CuentaIVARetArr").ToString
            CuentaIVARet4 = dr("CuentaIVARet4").ToString
            CuentaISRHon = dr("CuentaISRHon").ToString
            CuentaISRArr = dr("CuentaISRArr").ToString
            CuentaIEPS = dr("CuentaIEPS").ToString
        Else
            MsgBox("Error al Obtener Datos de IVA", MsgBoxStyle.Critical, "Sistema Contable")
            Exit Sub
        End If

        For Each row As DataGridViewRow In DGVCapturaPoliza.Rows

            Select Case row.Cells("dcuenta").Value
                Case CuentaIVA16
                    IVA16 = row.Cells("dCargos").Value + row.Cells("dAbonos").Value
                Case CuentaIVA11
                    IVA11 = row.Cells("dCargos").Value + row.Cells("dAbonos").Value
                Case CuentaIVAIMP
                    IVAIMP = row.Cells("dCargos").Value + row.Cells("dAbonos").Value
                Case CuentaIVARetHon
                    IVARetHon = row.Cells("dCargos").Value + row.Cells("dAbonos").Value
                Case CuentaIVARetArr
                    IVARetArr = row.Cells("dCargos").Value + row.Cells("dAbonos").Value
                Case CuentaIVARet4
                    IVARet4 = row.Cells("dCargos").Value + row.Cells("dAbonos").Value
                Case CuentaISRHon
                    ISRHon = row.Cells("dCargo").Value + row.Cells("dAbono").Value
                Case CuentaISRArr
                    ISRArr = row.Cells("dCargo").Value + row.Cells("dAbono").Value
                Case CuentaIEPS
                    IEPS = row.Cells("dCargo").Value + row.Cells("dAbono").Value
            End Select
        Next
    End Sub

End Class