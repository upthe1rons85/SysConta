Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports WindowsApplication1.frmProgramacionPago_FacProv
Imports System.Data.SqlClient
Imports System.Windows.Forms.ListView

Public Class frmNotaCredito
    Public FactNC As String
    Public FechatNC As String
    Public CuentaProv As String
    Private Sub frmNotaCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Notas " + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        CargaProveedores()
        CargaMonedas()
        CargaConceptosNC()
        cbxConcepto.Text = "<<Seleccionar>>"
    End Sub

    Private Sub CargaProveedores()
        Dim dr As SqlDataReader
        Dim oclsProveedor As New ClsProveedores
        Dim dt As New DataTable
        dr = oclsProveedor.SeleccionaProveedoresListaItem()

        dt.Load(dr)

        cbxProveedores.ValueMember = Trim("codigo")
        cbxProveedores.DisplayMember = Trim("proveedor")
        cbxProveedores.DataSource = dt
        
    End Sub
    Private Sub CargaConceptosNC()

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "SELECT CodigoNotaCredito, Concepto = CASE WHEN TipoAfectacion = 'A' THEN 'Abono - ' + Concepto 	ELSE    'Cargo - ' + Concepto END FROM catNotaCredito (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxConcepto.ValueMember = Trim("CodigoNotaCredito")
        cbxConcepto.DisplayMember = Trim("Concepto")
        cbxConcepto.DataSource = dt
        cbxConcepto.Text = ""
    End Sub

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        CargarInformacionFactura()
        DGVFacturas.Enabled = True
        Dim dr As SqlDataReader
        Dim oclsNotaCred = New ClsNotaCredito()

        dr = oclsNotaCred.SelCuentaProveedor(cbxProveedores.SelectedValue)
        Dim ds = New DataSet()

        If dr.Read() Then
            CuentaProv = Trim(dr("cuentacontable").ToString())
        End If

        dr.Close()

  
    End Sub

    Private Sub CargarInformacionFactura()
        DGVFacturas.DataSource = Nothing
        DGVFacturas.Rows.Clear()
        DGVCuentas.DataSource = Nothing
        DGVCuentas.Rows.Clear()
        lstFacturas.Items.Clear()
        lstNotas.Items.Clear()
        txtFac.Text = ""
        txtImporteNC.Text = "0.00"
        txtSumaCuenta.Text = "0.00"
        txtFolioContraRecibo.Text = ""
        txtIVA.Text = "0.00"
        txtIvaMax.Text = "0.00"
        txtImporte.Text = "0.00"
        txtSaldo.Text = "0.00"
        txtSubtotal.Text = "0.00"
        txtObs.Text = ""
        btnAgregarFactura.Enabled = True
        BtnGuardar.Enabled = False
        DGVFacturas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)

        btnAgregarFactura.Enabled = True
        If cbxProveedores.Text = "" Then
            MsgBox("Seleccione un proveedor", MsgBoxStyle.Exclamation)
        Else
            'cbxProveedores.Enabled = False

            Dim factura As String
            'lblCodigo.Text = ""
            'Valida que el valor del listbox sea un proveedor del catalogo
            If cbxProveedores.SelectedValue = Nothing Or cbxProveedores.SelectedValue = "0" Then
                MsgBox("No se ha seleccionado ningun proveedor valido", vbCritical, "Sistema Contable")
            Else
                '--------
                If txtFactura.Text = "" Then
                    factura = ""
                Else
                    factura = txtFactura.Text
                End If

                Dim dr As SqlDataReader
                Dim oclsNotaCred = New ClsNotaCredito()

                dr = oclsNotaCred.SeleccionaCRFacturas(cbxProveedores.SelectedValue, factura)
                Dim dt = New DataTable()
                dt.Load(dr)

                If dt.Rows.Count > 0 Then


                    '' llenar DATAGRID ------------------

                    DGVFacturas.Enabled = True
                    DGVFacturas.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente
                    ''Format(CDec(txtTotAbonoDlls.Text), "###,###,##0.#0")
                    DGVFacturas.Columns(0).DataPropertyName = Trim("CodigoProveedor") 'Inserta la cuenta contable
                    DGVFacturas.Columns(1).DataPropertyName = Trim("FolioContraRecibo")
                    DGVFacturas.Columns(2).DataPropertyName = Trim("FechaContraRecibo")
                    DGVFacturas.Columns(3).DataPropertyName = Trim("FechaProgPago")
                    DGVFacturas.Columns(4).DataPropertyName = Trim("FacturaProveedor")
                    DGVFacturas.Columns(5).DataPropertyName = Trim("Subtotal")
                    DGVFacturas.Columns(6).DataPropertyName = Trim("IVA16")
                    DGVFacturas.Columns(7).DataPropertyName = Trim("IVARet4")
                    DGVFacturas.Columns(8).DataPropertyName = Trim("Importe")
                    DGVFacturas.Columns(9).DataPropertyName = Trim("Saldo")
                    DGVFacturas.Columns(10).DataPropertyName = Trim("TipoMoneda")
                    DGVFacturas.Columns(11).DataPropertyName = Trim("IVA11")
                    DGVFacturas.Columns(12).DataPropertyName = Trim("IVAIMP")
                    DGVFacturas.Columns(13).DataPropertyName = Trim("IVARetHon")
                    DGVFacturas.Columns(14).DataPropertyName = Trim("IVARetArr")
                    DGVFacturas.Columns(15).DataPropertyName = Trim("ISRHon")
                    DGVFacturas.Columns(16).DataPropertyName = Trim("ISRArr")
                    DGVFacturas.Columns(17).DataPropertyName = Trim("IEPS")
                    DGVFacturas.Columns(18).DataPropertyName = Trim("TipoCambio")

                    DGVFacturas.DataSource = dt

                    lstNotas.Items.Clear()
                    'BtnEliminar.Enabled = True
                    'BtnGuardar.Enabled = False
                    'SumaImportes()
                    'BtnModificar.Enabled = True

                Else

                    MsgBox("No existen Documentos Pendientes de pago del proveedor y Fecha seleccionada", vbInformation, "Sistema Contable")
                    cbxProveedores.Enabled = True
                    cbxProveedores.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim cDolares As Integer = 0
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim wQuery As String = ""
        Dim cmd As SqlCommand
        Dim wFolio As String = 0
        Dim dr As SqlDataReader
        Dim transaction As SqlTransaction
        Dim XError As String

        Dim TipoMovimiento As Integer
        Dim TipoPoliza As Integer
        Dim nPoliza As Integer

        SUMAPPOLIZA()

        If Not CDbl(txtSumaCuenta.Text) = CDbl(txtImporteNC.Text) Then
            MsgBox("Existen diferencias en Saldos de la Polizas", MsgBoxStyle.Information, "Sistema Contabilidad")
            Exit Sub
        End If

        If cbxConcepto.Text = "<<Seleccionar>>" Then
            MsgBox("Debe Seleccionar concepto de Nota de Credito/Cargo", MsgBoxStyle.Information)
            Exit Sub
        End If

        If lstFacturas.Items.Count < 1 Then
            MsgBox("Favor de ingresar Folio de la Nota de Credito ", MsgBoxStyle.Information)
            btnAgregarFactura.Select
            Exit Sub
        End If
        If cbxConcepto.Text Like "*" + "Abono" + "*" Then
            TipoPoliza = 32
            TipoMovimiento = 59
        Else
            TipoPoliza = 36
            TipoMovimiento = 8
        End If

            Dim dr2 As SqlDataReader
            Dim oclsPolizasAjuste = New clsPolizasAjuste()
            dr2 = oclsPolizasAjuste.UltimoFolio(TipoPoliza)

            Dim ds = New DataSet()

            If dr2.Read() Then
                nPoliza = Trim(dr2("Folio").ToString())
            End If

            dr2.Close()

            wQuery = "SELECT (folionotaCred)+1 as Folio FROM parametros"
            cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
            cmd.CommandType = Data.CommandType.Text
            transaction = cnnConexion.BeginTransaction

            cmd.Connection = cnnConexion
            cmd.Transaction = transaction
            Try

                dr = cmd.ExecuteReader()
                If dr.Read Then
                    txtFolioSig.Text = dr("Folio").ToString()
                    wFolio = txtFolioSig.Text
                Else
                    MsgBox("No Se Genero Consecutivo de Folio Kardex")
                End If
                dr.Close()
                XError = "Error en Lista de Factura Nota C"
                For Each item As ListViewItem In lstFacturas.Items
                    ''***************************************
                    cmd.Parameters.Clear()
                    'If row.Cells("mCantPago").Value > 0 Then
                    FactNC = item.SubItems(0).Text
                    FechatNC = item.SubItems(1).Text

                    cmd.CommandText = "spInsNotaCredito"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = cnnConexion
                    cmd.Transaction = transaction

                    cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.Int).Value = TipoMovimiento
                    cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
                    cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = item.SubItems(1).Text
                    cmd.Parameters.Add("@pCodigoBanco", SqlDbType.Int).Value = 0
                    cmd.Parameters.Add("@pNumeroCheque", SqlDbType.Int).Value = 0
                    cmd.Parameters.Add("@pCodigoProveedor", SqlDbType.VarChar).Value = cbxProveedores.SelectedValue
                    cmd.Parameters.Add("@pFolioContrarecibo", SqlDbType.Int).Value = txtFolioContraRecibo.Text
                    cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = txtFac.Text
                    'If cbxMoneda.SelectedValue = 2 Then
                    ' cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = txtTotalNC.Text * txtTipoCambio.Text
                    ' Else
                    cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = item.SubItems(3).Text
                    'End If
                    cmd.Parameters.Add("@pFolioNotaCredito", SqlDbType.VarChar).Value = item.SubItems(0).Text
                    cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = item.SubItems(4).Text
                    cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = item.SubItems(5).Text
                    cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = item.SubItems(6).Text
                    cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = item.SubItems(7).Text
                    cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = item.SubItems(8).Text
                    cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = item.SubItems(9).Text
                    cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = item.SubItems(10).Text
                    cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = item.SubItems(11).Text
                    cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = item.SubItems(12).Text
                    cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = item.SubItems(13).Text
                    cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = item.SubItems(13).Text
                    If CInt(item.SubItems(14).Text) = 2 Then
                        cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = CDec(item.SubItems(13).Text)
                    Else
                        cmd.Parameters.Add("@pTotalAbonoDLLS", SqlDbType.Decimal).Value = 0.0
                    End If
                    cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = TipoPoliza
                    cmd.Parameters.Add("@pPoliza", SqlDbType.Int).Value = nPoliza
                    cmd.Parameters.Add("@pUsuarioModificacion", SqlDbType.VarChar).Value = LoginUsuario
                    cmd.Parameters.Add("@pBeneficiario", SqlDbType.VarChar).Value = cbxConcepto.Text + " " + txtObs.Text
                    cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = CInt(item.SubItems(14).Text)
                    cmd.Parameters.Add("@pTipoCambio", SqlDbType.VarChar).Value = txtTipoCambio.Text
                    cmd.Parameters.Add("@TipoNC", SqlDbType.Int).Value = cbxConcepto.SelectedValue
                    cmd.ExecuteNonQuery()

                Next
                '----Adelanta folio de Movimiento en los parametros
                XError = "Error en Siguente Folio NC"
                cmd.Parameters.Clear()
                cmd.CommandText = "spAdeFolioNotaCredito"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnnConexion

                cmd.Parameters.Add("@FolioNotaCredito", SqlDbType.NVarChar).Value = wFolio
                cmd.ExecuteNonQuery()


                '------------POLIZA CONTABLE
                XError = "Error en realizar Poliza NC"
                Dim Cuenta As String
                Dim importe As Double
                If TipoPoliza = 32 Then  ' ------ POLIZAS A NOTAS CREDITO(INVERSA A POLIZAS)
                    cmd.Parameters.Clear()

                    cmd.CommandText = "spInsPolizaNotaCredito"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = cnnConexion
                    cmd.Transaction = transaction

                    cmd.Parameters.Add("@nFolioCR", SqlDbType.Int).Value = txtFolioContraRecibo.Text
                    cmd.Parameters.Add("@nCuenta", SqlDbType.VarChar).Value = CuentaProv
                    cmd.Parameters.Add("@Importe", SqlDbType.VarChar).Value = CDbl(txtSumaCuenta.Text)
                    cmd.Parameters.Add("@pTipoPol", SqlDbType.VarChar).Value = TipoPoliza
                    cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = nPoliza
                    cmd.Parameters.Add("@CargoAbono", SqlDbType.VarChar).Value = "C"
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = LoginUsuario
                    cmd.Parameters.Add("@nFolioNC", SqlDbType.VarChar).Value = wFolio
                    cmd.Parameters.Add("@DescNC", SqlDbType.VarChar).Value = cbxConcepto.Text
                    cmd.Parameters.Add("@FactuNC", SqlDbType.VarChar).Value = FactNC
                    cmd.Parameters.Add("@FechaFac", SqlDbType.VarChar).Value = FechatNC
                    cmd.ExecuteNonQuery()

                    For Each row As DataGridViewRow In DGVCuentas.Rows
                        Cuenta = row.Cells("cuenta").Value
                        importe = row.Cells("importe").Value

                        cmd.Parameters.Clear()

                        cmd.CommandText = "spInsPolizaNotaCredito"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion
                        cmd.Transaction = transaction

                        cmd.Parameters.Add("@nFolioCR", SqlDbType.Int).Value = txtFolioContraRecibo.Text
                        cmd.Parameters.Add("@nCuenta", SqlDbType.VarChar).Value = Cuenta
                        cmd.Parameters.Add("@Importe", SqlDbType.VarChar).Value = importe
                        cmd.Parameters.Add("@pTipoPol", SqlDbType.VarChar).Value = TipoPoliza
                        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = nPoliza
                        cmd.Parameters.Add("@CargoAbono", SqlDbType.VarChar).Value = "A"
                        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = LoginUsuario
                        cmd.Parameters.Add("@nFolioNC", SqlDbType.VarChar).Value = wFolio
                    cmd.Parameters.Add("@DescNC", SqlDbType.VarChar).Value = cbxConcepto.Text
                        cmd.Parameters.Add("@FactuNC", SqlDbType.VarChar).Value = FactNC
                        cmd.Parameters.Add("@FechaFac", SqlDbType.VarChar).Value = FechatNC
                        cmd.ExecuteNonQuery()
                    Next
                Else
                    '----POLIZAS A NOTAS CARGOS(IGUAL A CONTRARECIBO)

                    For Each row As DataGridViewRow In DGVCuentas.Rows
                        Cuenta = row.Cells("cuenta").Value
                        importe = row.Cells("importe").Value

                        cmd.Parameters.Clear()

                        cmd.CommandText = "spInsPolizaNotaCredito"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion
                        cmd.Transaction = transaction

                        cmd.Parameters.Add("@nFolioCR", SqlDbType.Int).Value = txtFolioContraRecibo.Text
                        cmd.Parameters.Add("@nCuenta", SqlDbType.VarChar).Value = Cuenta
                        cmd.Parameters.Add("@Importe", SqlDbType.VarChar).Value = importe
                        cmd.Parameters.Add("@pTipoPol", SqlDbType.VarChar).Value = TipoPoliza
                        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = nPoliza
                        cmd.Parameters.Add("@CargoAbono", SqlDbType.VarChar).Value = "A"
                        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = LoginUsuario
                        cmd.Parameters.Add("@nFolioNC", SqlDbType.VarChar).Value = wFolio
                        cmd.Parameters.Add("@DescNC", SqlDbType.VarChar).Value = cbxConcepto.Text
                        cmd.Parameters.Add("@FactuNC", SqlDbType.VarChar).Value = FactNC
                        cmd.Parameters.Add("@FechaFac", SqlDbType.VarChar).Value = FechatNC
                        cmd.ExecuteNonQuery()
                    Next

                    cmd.Parameters.Clear()

                    cmd.CommandText = "spInsPolizaNotaCredito"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = cnnConexion
                    cmd.Transaction = transaction

                    cmd.Parameters.Add("@nFolioCR", SqlDbType.Int).Value = txtFolioContraRecibo.Text
                    cmd.Parameters.Add("@nCuenta", SqlDbType.VarChar).Value = CuentaProv
                    cmd.Parameters.Add("@Importe", SqlDbType.VarChar).Value = CDbl(txtSumaCuenta.Text)
                    cmd.Parameters.Add("@pTipoPol", SqlDbType.VarChar).Value = TipoPoliza
                    cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = nPoliza
                    cmd.Parameters.Add("@CargoAbono", SqlDbType.VarChar).Value = "C"
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = LoginUsuario
                    cmd.Parameters.Add("@nFolioNC", SqlDbType.VarChar).Value = wFolio
                    cmd.Parameters.Add("@DescNC", SqlDbType.VarChar).Value = cbxConcepto.Text
                cmd.Parameters.Add("@FactuNC", SqlDbType.VarChar).Value = FactNC
                cmd.Parameters.Add("@FechaFac", SqlDbType.VarChar).Value = FechatNC
                    cmd.ExecuteNonQuery()

                End If


                txtFolioSig.Text = wFolio
                transaction.Commit()

                MsgBox("Se Grabo Correctamente, N.C. : " & wFolio, MsgBoxStyle.Information)
                btnImprimir.Enabled = True
                btnImprimir.PerformClick()

                btnNuevo.PerformClick()
                btnImprimir.Enabled = True
                DGVFacturas.Enabled = True
                CargarInformacionFactura()
            Catch err As Exception
                transaction.Rollback()
                MsgBox("Ocurrio un Error al Grabar ", MsgBoxStyle.Critical)
                MessageBox.Show("Error:" & err.Message)
            Finally
                cnnConexion.Dispose()
                cnnConexion.Close()

            End Try
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

    Private Sub DGVFacturas_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVFacturas.CellMouseClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        txtFolioSig.Text = ""
        Dim row As DataGridViewRow = DGVFacturas.Rows(e.RowIndex)
        Dim celda As DataGridViewCell = DGVFacturas.CurrentCell

        txtSubtotal.Text = row.Cells("dSubtotal").Value
        txtSaldo.Text = row.Cells("mSaldo").Value
        'dtpFecha.Text = row.Cells("dFechaDoc").Value
        txtTipoCambio.Text = row.Cells("mTipoCambio").Value
        txtImporte.Text = row.Cells("dTotDoc").Value
        txtFac.Text = row.Cells("dFactura").Value
        txtIVA.Text = row.Cells("dIVA").Value
        cbxMoneda.SelectedIndex = row.Cells("mMoneda").Value - 1
        txtFolioContraRecibo.Text = row.Cells("dfolioRP").Value
        txtImporteNC.Text = "0.00"
        txtSumaCuenta.Text = "0.00"

        DGVCuentas.DataSource = Nothing
        DGVCuentas.Rows.Clear()

        btnAgregarFactura.Enabled = True
        lstNotas.Items.Clear()
        lstFacturas.Items.Clear()
        CargarInformacionCuentas()
        LlenarNC()
        'BtnEliminar.Enabled = False
        btnImprimir.Enabled = False
    End Sub

    Private Sub CargarInformacionCuentas()
        DGVCuentas.DataSource = Nothing
        DGVCuentas.Rows.Clear()
        DGVCuentas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 6)
        DGVCuentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        If txtFolioContraRecibo.Text = "" Then
            MsgBox("Seleccione una factura ", MsgBoxStyle.Exclamation)
        Else

            Dim dr As SqlDataReader
            Dim oclsNotaCred = New ClsNotaCredito()

            dr = oclsNotaCred.SeleccionaCuentasCR(1, txtFolioContraRecibo.Text)
            Dim dt = New DataTable()
            dt.Load(dr)

            If dt.Rows.Count > 0 Then
                '' llenar DATAGRID ------------------
                DGVCuentas.Enabled = True
                DGVCuentas.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente
                ''Format(CDec(txtTotAbonoDlls.Text), "###,###,##0.#0")
                DGVCuentas.Columns(0).DataPropertyName = Trim("Cuenta")
                DGVCuentas.Columns(1).DataPropertyName = Trim("descripcion")

                DGVCuentas.DataSource = dt
            Else
                MsgBox("No existen polizas en contra recibo", vbInformation, "Sistema Contable")
                cbxProveedores.Enabled = True
                cbxProveedores.Focus()
            End If
        End If
    End Sub

    Public Sub LlenarNC()
        Dim dr As SqlDataReader
        Dim oclsProgramacionPago = New ClsNotaCredito
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")
        dr = oclsProgramacionPago.SeleccionarNC(txtFolioContraRecibo.Text, "1")
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstNotas.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("Folio").ToString)
                lstLista.SubItems.Add(Trim(rRow("FolioNotaCred").ToString))
                lstLista.SubItems.Add(Trim(rRow("FechaMovimiento").ToString))
                lstLista.SubItems.Add(Trim(rRow("Beneficiario").ToString))
                lstLista.SubItems.Add(Trim(rRow("Total").ToString))
                lstLista.SubItems.Add(Trim(rRow("TipoMovimiento").ToString))
                lstLista.SubItems.Add(Trim(rRow("TipoPoliza").ToString))
                lstLista.SubItems.Add(Trim(rRow("poliza").ToString))
                lstNotas.Items.Add(lstLista)

            Next
        End If
    End Sub

    Private Sub txtFolioSig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioSig.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Dim oclsProgramacionPago = New clsProgramacionPago()

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtFolioSig.Text = "" Then
                btnNuevo.PerformClick()
                txtFolioSig.Text = "  * * *  "
                txtFolioSig.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        txtFac.Text = ""
        txtSubtotal.Text = "0.00"
        txtSaldo.Text = "0.00"
        txtTipoCambio.Text = "0.00"
        txtImporte.Text = "0.00"
        txtIVA.Text = "0.00"
        txtSumaCuenta.Text = "0.00"
        txtImporteNC.Text = "0.00"
        txtIvaMax.Text = "0.00"
        txtFolioContraRecibo.Text = ""
        txtObs.Text = ""
        BtnGuardar.Enabled = False
        btnAgregarFactura.Enabled = True
        txtFolioSig.Select()
        'BtnEliminar.Enabled = False
        btnImprimir.Enabled = False
        lstNotas.Items.Clear()
        DGVFacturas.DataSource = Nothing
        DGVFacturas.Rows.Clear()
        DGVCuentas.DataSource = Nothing
        DGVCuentas.Rows.Clear()
        lstFacturas.Items.Clear()
    End Sub

    Private Sub lstNotas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstNotas.Click
        txtFolioSig.Text = Trim(lstNotas.SelectedItems(0).SubItems(0).Text)
        FactNC = Trim(lstNotas.SelectedItems(0).SubItems(1).Text)
        'BtnEliminar.Enabled = True
        btnAgregarFactura.Enabled = False
        btnImprimir.Enabled = True
        LlenarCamposFacturas()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTImprimirNC
        frm.nFolio = txtFolioSig.Text
        frm.ShowDialog()

        If chkImpPoliza.Checked = True Then
            Dim clsDB = New clsBD()
            Dim cnnConexion = New SqlConnection()

            cnnConexion = clsDB.CreaConexion()

            Dim wQuery As String = ""
            Dim cmd As SqlCommand
            Dim wFolio As String = 0
            Dim wFecha As String = ""
            Dim dr As SqlDataReader
            Dim transaction As SqlTransaction
            Dim TipoPoliza As Integer

            wQuery = "SELECT poliza,fechaMovimiento,tipopoliza FROM bcoKardexMovimientos WHERE folionotacred = '" & FactNC & "'"

            cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
            cmd.CommandType = Data.CommandType.Text
            transaction = cnnConexion.BeginTransaction
            cmd.Transaction = transaction
            cmd.Connection = cnnConexion

            dr = cmd.ExecuteReader()
            If dr.Read Then
                wFolio = dr("poliza").ToString()
                wFecha = dr("fechaMovimiento").ToString()
                TipoPoliza = dr("tipopoliza").ToString()
            Else
                MsgBox("No se Pudo realizar la consulta de Poliza", MsgBoxStyle.Exclamation)
            End If
            BtnGuardar.Enabled = False

            Dim frmPoliza As New frmRPTPolizasManual
            frmPoliza.fecha = wFecha
            frmPoliza.folio = wFolio
            frmPoliza.tipoPoliza = TipoPoliza

            frmPoliza.ShowDialog()
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtFolioSig.Text = "" Or txtFolioSig.Text = "***" Then
            Exit Sub
        End If
        If MessageBox.Show("¿Desea CANCELAR el Folio Int:" + txtFolioSig.Text, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim oclsProgramacionPago = New ClsNotaCredito()
                oclsProgramacionPago.CancelaNC(Trim(txtFolioSig.Text))
                MsgBox("Se Cancelo El registro correctamente", MsgBoxStyle.Information)
                CargarInformacionFactura()
                btnNuevo.PerformClick()
            Catch ex As Exception
                MsgBox("Ocurrio un Error al Cancelar")

            End Try
            btnNuevo.PerformClick()
        End If
    End Sub

    Private Sub btnAgregarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarFactura.Click
        AgregarFactura()
        DGVFacturas.Enabled = False
        BtnGuardar.Enabled = True
    End Sub
    Private Sub AgregarFactura()
        Dim FRM As New frmProgramacionPago_FacProv
        Dim oclsNotasCredito = New ClsNotaCredito
        Dim NumeroFactura As String
        FRM.NuevoFactura()
        FRM.frmTipoMoneda.Visible = True ' Oculta el frame de Tipo Moneda
        FRM.ShowDialog()
        If FRM.fechaProv = Nothing Or
        FRM.facturaProv = Nothing Or
            FRM.UnidadesProv = 0 Or
            FRM.subtotalProv = 0 Or
            FRM.TotalProv = 0 Then
        Else
            NumeroFactura = FRM.facturaProv
            'Verifica si la factura ya de encuentra agregada en un folio anterior guardado
            Dim dr As SqlDataReader
            dr = oclsNotasCredito.VerificaFacturaNotaCredito(CDbl(cbxProveedores.SelectedValue), NumeroFactura)
            If dr.Read() Then
                Dim folioexiste As String
                Dim fecha As String
                folioexiste = dr("folio").ToString()
                fecha = Mid(Trim(dr("fechamodificacion").ToString()), 1, 10)
                MsgBox("La Factura " & NumeroFactura & " ya se encuentra registrada en la fecha " & fecha & " en el folio " & folioexiste & " NO PROCEDE !!", MsgBoxStyle.Information, "Sistema Contable")
                Exit Sub
            End If
            '-----------------------------------------------------------------------------
            Dim facturaproveedor As String
            Dim contiene As Integer = 0
            Dim nTipoMoneda As Integer
            If FRM.rdPesos.Checked = True Then
                nTipoMoneda = 1
            Else
                nTipoMoneda = 2
            End If
            For i = 0 To lstFacturas.Items.Count - 1
                facturaproveedor = Trim(lstFacturas.Items(i).SubItems(2).Text) '
                If FRM.facturaProv = facturaproveedor Then
                    contiene = 1
                End If
            Next

            If CDbl(FRM.txtTotalProv.Text) > CDbl(txtSaldo.Text) Then
                MsgBox("El importe de la nota de credito  no debe superar la cantidad de saldo ", MsgBoxStyle.Information, "Sistema contable")
                Exit Sub
            End If

            If contiene = 1 Then
                MsgBox("La Factura " & FRM.facturaProv & " ya se encuentra agregada", MsgBoxStyle.Exclamation, "Sistema contable")
            Else
                Dim RangoTotal As Double
                RangoTotal = CDbl(FRM.txtRango.Text)
                'Dim DiferenciaTotal As Double
                'Dim DiferenciaIVA As Double
                'Dim DiferenciaRet4 As Double
                'Dim DiferenciaSubTotal As Double

                'DiferenciaTotal = Math.Abs((CDbl(FRM.TotalProv) - CDbl(txtTotal.Text)))
                'DiferenciaIVA = Math.Abs((CDbl(FRM.IvaProv) - CDbl(txtIVA.Text)))
                'DiferenciaSubTotal = Math.Abs((CDbl(FRM.subtotalProv) - CDbl(txtSubtotal.Text)))

                'Dim factorDiferencial As Double
                'factorDiferencial = CDbl(FRM.TotalProv) / CDbl(txtImporte.Text)

                Dim lista As New ListViewItem

                lista = lstFacturas.Items.Add(Trim(FRM.facturaProv))
                lista.SubItems.Add(Trim(FRM.fechaProv))
                lista.SubItems.Add(Trim(FRM.UnidadesProv))
                lista.SubItems.Add(Trim(FRM.subtotalProv))
                lista.SubItems.Add(Trim(FRM.IvaProv))
                lista.SubItems.Add(Trim(FRM.IvaProv11))
                lista.SubItems.Add(Trim(FRM.IVAImp))
                lista.SubItems.Add(Trim(FRM.Ret10Hono))
                lista.SubItems.Add(Trim(FRM.Ret10Arrenda))
                lista.SubItems.Add(Trim(FRM.Ret4))
                lista.SubItems.Add(Trim(FRM.ISRHono))
                lista.SubItems.Add(Trim(FRM.ISRArrenda))
                lista.SubItems.Add(Trim(FRM.IEPS))
                lista.SubItems.Add(Trim(FRM.TotalProv))
                lista.SubItems.Add(nTipoMoneda)

                'End If
                txtImporteNC.Text = Format(FRM.TotalProv, "###,###,##0.#0")
                btnAgregarFactura.Enabled = False
            End If
            'dr.Close()
            End If
    End Sub
    Private Sub SUMAPPOLIZA()
        '-------------Suma los Cargos y va sumando por registro toda la columna y la coloca en el text Total---------
        'Me.DGVCapturaPoliza.Columns("UnitPrice").DefaultCellStyle.Format = "c"
        Dim resultado As Decimal = 0D

        For Each row As DataGridViewRow In DGVCuentas.Rows
            Dim value As Object = row.Cells("importe").Value
            Dim d As Decimal
            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultado += Convert.ToDecimal(d)

        Next
        txtSumaCuenta.Text = Format(resultado, "###,###,##0.#0")

        '-------------Suma los Abonos y va sumando por registro toda la columna y la coloca en el text Total---------

    End Sub

    Private Sub DGVCuentas_CellStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellStateChangedEventArgs) Handles DGVCuentas.CellStateChanged
        Dim Celda As DataGridViewCell = Me.DGVCuentas.CurrentCell()
        If Celda.ColumnIndex = 3 Then
            SUMAPPOLIZA()
            Celda.Value = Format(CDbl(Celda.Value), "###,##0.00")
        End If
    End Sub

    Private Sub DGVCuentas_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DGVCuentas.CellValidating
        Select Case DGVCuentas.Columns(e.ColumnIndex).Name
            Case "importe"
                'se valida que sea un dato numérico
                If Not IsNumeric(e.FormattedValue.ToString()) And Not String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                    DGVCuentas.Rows(e.RowIndex).ErrorText = "Debe ingresar un valor numérico"
                    e.Cancel = True
                Else
                    DGVCuentas.Rows(e.RowIndex).ErrorText = String.Empty
                End If
        End Select
    End Sub

    Private Sub DGVCuentas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVCuentas.LostFocus
        SUMAPPOLIZA()
    End Sub

    Private Sub cbxProveedores_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxProveedores.Click
        

    End Sub

    Private Sub cbxProveedores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxProveedores.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnBusca.PerformClick()
        End If
    End Sub

    Private Sub txtFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactura.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnBusca.PerformClick()
        End If
    End Sub

    Private Sub cbxProveedores_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxProveedores.SelectedValueChanged
        If Not cbxProveedores.SelectedValue = 0 Then
            btnBusca.PerformClick()
        End If
    End Sub

    Public Sub LlenarCamposFacturas()
        Dim dr As SqlDataReader
        Dim oclsProgramacionPago = New ClsNotaCredito
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")
        dr = oclsProgramacionPago.SeleccionarNC(txtFolioSig.Text, "2")
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstFacturas.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(Trim(rRow("FolioNotaCred").ToString))
                lstLista.SubItems.Add(Format(CDate(Trim(rRow("FechaModificacion").ToString)), "d"))
                lstLista.SubItems.Add(" ")
                lstLista.SubItems.Add(Format(CDbl(rRow("SubTotal").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("Iva").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVA11").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVAImp").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVARetHon").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVARetArr").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVARet4").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("ISRHon").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("ISRArr").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IEPS").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("Total").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(CDbl(rRow("TipoMoneda").ToString))

                lstFacturas.Items.Add(lstLista)

            Next
        Else
            MsgBox("No Existen Facturas Relacionadas al Folio Seleccionado", MsgBoxStyle.Information)
        End If
    End Sub
End Class

