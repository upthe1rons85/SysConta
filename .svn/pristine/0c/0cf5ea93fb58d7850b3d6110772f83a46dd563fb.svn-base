Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports System.Drawing.Printing

Public Class frmBancosMov_Imprimir
    Dim ImpresoraActual As String
    Dim FolioKardex As Integer = 0
    Dim fechacheque As String = ""
    Dim Beneficiario As String = ""
    Dim importeNumero As Decimal = 0
    Dim NumeroCheque As Integer = 0
    Dim ImporteLetra As String = ""
    Dim NumeroPoliza As Integer = 0
    Dim NombreBanco As String = ""
    Dim CuentaBanco As String = ""
    Dim NombreProveedor As String = ""
    Dim CuentaProveedor As String = ""
    Dim concepto As String = ""
    Dim concepto2 As String = ""
    Dim concepto3 As String = ""
    Dim concepto4 As String = ""
    Dim concepto5 As String = ""
    Dim concepto6 As String = ""
    Dim CodigoProveedor As Integer = 0
    Dim TotalDlls As Decimal = 0.0


    Dim conceptoimporte As String = ""
    Dim TipoMonedaBanco As String = 0

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
    Private Sub txtChequeIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtChequefin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub CargarBancos()

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select codigo,banco from catBancos (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)


        cbxBancos.ValueMember = Trim("codigo")
        cbxBancos.DisplayMember = Trim("Banco")
        cbxBancos.DataSource = dt
    End Sub

    Private Sub frmBancosMov_Imprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarBancos()
        ' IMPRESORA PREDETERMIANDA ACTUAL
        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName
        ImpresoraActual = impresosaPredt

        DTPCheque.Text = DateTime.Now.ToString
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        cbxDocumento.SelectedIndex = 0
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCheque.Click
     
        If cbxDocumento.Text = "CHEQUE" Then
            'gbxRangoFol.Enabled = False
            DGVCheques.DataSource = Nothing
            DGVCheques.Rows.Clear()
            If cbxBancos.SelectedValue = 0 Then
                MsgBox("Seleccione un Banco", MsgBoxStyle.Exclamation)
            Else
                'cbxBancos.Enabled = False

                Dim fecha As String
                If cbxBancos.SelectedValue = Nothing Then
                    MsgBox("No se ha seleccionado ningun Banco valido", vbCritical, "Sistema Contable")
                Else
                    '--------
                    fecha = Format(DTPCheque.Value, "yyyyMMdd")


                    Dim dr As SqlDataReader
                    Dim oclsMovBancos = New clsMovBancos()

                    dr = oclsMovBancos.SeleccionaCheques(cbxBancos.SelectedValue, fecha)
                    Dim dt = New DataTable()
                    dt.Load(dr)

                    If dt.Rows.Count > 0 Then


                        '' llenar DATAGRID ------------------

                        DGVCheques.Enabled = True
                        DGVCheques.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente

                        DGVCheques.Columns(0).DataPropertyName = Trim("folio")
                        DGVCheques.Columns(1).DataPropertyName = Trim("fecha")
                        DGVCheques.Columns(2).DataPropertyName = Trim("codigobanco")
                        DGVCheques.Columns(3).DataPropertyName = Trim("numerocheque")
                        DGVCheques.Columns(4).DataPropertyName = Trim("proveedor")
                        DGVCheques.Columns(5).DataPropertyName = Trim("Subtotal")
                        DGVCheques.Columns(6).DataPropertyName = Trim("IVA")
                        DGVCheques.Columns(7).DataPropertyName = Trim("IVARet")
                        DGVCheques.Columns(8).DataPropertyName = Trim("total")


                        DGVCheques.DataSource = dt


                    Else

                        MsgBox("No existen Documentos Pendientes del banco y Fecha seleccionada", vbInformation, "Sistema Contable")

                    End If
                End If
            End If
        Else
            'gbxRangoFol.Enabled = False
            DGVCheques.DataSource = Nothing
            DGVCheques.Rows.Clear()
            If cbxBancos.SelectedValue = 0 Then
                MsgBox("Seleccione un Banco", MsgBoxStyle.Exclamation)
            Else
                'cbxBancos.Enabled = False

                Dim fecha As String
                If cbxBancos.SelectedValue = Nothing Then
                    MsgBox("No se ha seleccionado ningun Banco valido", vbCritical, "Sistema Contable")
                Else
                    '--------
                    fecha = Format(DTPCheque.Value, "yyyyMMdd")


                    Dim dr As SqlDataReader
                    Dim oclsMovBancos = New clsMovBancos()

                    dr = oclsMovBancos.SeleccionaTransferencias(cbxBancos.SelectedValue, fecha)
                    Dim dt = New DataTable()
                    dt.Load(dr)

                    If dt.Rows.Count > 0 Then


                        '' llenar DATAGRID ------------------

                        DGVCheques.Enabled = True
                        DGVCheques.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente

                        DGVCheques.Columns(0).DataPropertyName = Trim("folio")
                        DGVCheques.Columns(1).DataPropertyName = Trim("fecha")
                        DGVCheques.Columns(2).DataPropertyName = Trim("codigobanco")
                        DGVCheques.Columns(3).DataPropertyName = Trim("Folio")
                        DGVCheques.Columns(4).DataPropertyName = Trim("proveedor")
                        DGVCheques.Columns(5).DataPropertyName = Trim("Subtotal")
                        DGVCheques.Columns(6).DataPropertyName = Trim("IVA")
                        DGVCheques.Columns(7).DataPropertyName = Trim("IVARet")
                        DGVCheques.Columns(8).DataPropertyName = Trim("total")


                        DGVCheques.DataSource = dt


                    Else

                        MsgBox("No existen Transferencias Pendientes del banco y Fecha seleccionada", vbInformation, "Sistema Contable")

                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        '-----IMPRESION DE CHEQUE--
        '---CUANDO SE SELECCIONO IMPRIMIR POR EL FOLIO SELECCIONADO---
        If cbxDocumento.Text = "CHEQUE" Then

            Dim wQuery As String = ""
            Dim cmd As SqlCommand
            Dim drBanco As SqlDataReader
            ' Dim transaction As SqlTransaction
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            wQuery = "SELECT TipoMoneda FROM catBancos where codigo= " & cbxBancos.SelectedValue

            cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
            cmd.CommandType = Data.CommandType.Text
            '---Convierte el importe en Letras para la generacion de cheque----

            cmd.Connection = cnnConexion

            drBanco = cmd.ExecuteReader()
            If drBanco.Read Then
                TipoMonedaBanco = drBanco("TipoMoneda").ToString()

            Else
                MsgBox("No se Encontro Datos del Banco", MsgBoxStyle.Critical, "Sistema Contable")
                Exit Sub

            End If
            drBanco.Close()


            If chbxRango.Checked = False Then
                Dim Selecciona As Integer = 0
                For Each row As DataGridViewRow In DGVCheques.Rows

                    If row.Cells("dselecciona").Value = True Then
                        Selecciona = Selecciona + 1
                    End If
                Next

                If Selecciona = 0 Then
                    MsgBox("No Se ah Seleccionado Ningun Documento", MsgBoxStyle.Exclamation, "Sistema Contable")
                    Exit Sub
                End If

                Dim FRM As New frmSeleccionarImpresora
                FRM.ShowDialog()
                If FRM.ImpresoraSeleccionada = "" Then
                    If MessageBox.Show("Se imprima con impresora predeterminada de windows", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                End If

                Dim printDoc As New PrintDocument

                For Each row As DataGridViewRow In DGVCheques.Rows

                    If row.Cells("dselecciona").Value = True Then

                        NumeroCheque = row.Cells("dFolioCheque").Value
                        Dim oClsMovBancos As New clsMovBancos
                        Dim dr As SqlDataReader

                        dr = oClsMovBancos.SeleccionaChequesImprimeContinuo(cbxBancos.SelectedValue, row.Cells("dcheque").Value, "")

                        If dr.Read Then
                            fechacheque = Trim(dr("FechaMovimiento").ToString)
                            Beneficiario = Trim(dr("Beneficiario").ToString)
                            importeNumero = Trim(dr("Total").ToString)
                            NumeroCheque = Trim(dr("NumeroCheque").ToString)
                            NumeroPoliza = Trim(dr("Poliza").ToString)
                            concepto = Trim(dr("Concepto").ToString)
                            concepto2 = Trim(dr("Concepto2").ToString)
                            concepto3 = Trim(dr("Concepto3").ToString)
                            concepto4 = Trim(dr("Concepto4").ToString)
                            concepto5 = Trim(dr("Concepto5").ToString)
                            concepto6 = Trim(dr("Concepto6").ToString)
                            NombreBanco = Trim(dr("Banco").ToString)
                            CuentaBanco = Trim(dr("CUENTA_BANCO").ToString)
                            NombreProveedor = Trim(dr("Proveedor").ToString)
                            CuentaProveedor = Trim(dr("CUENTA_PROV").ToString)
                            CodigoProveedor = Trim(dr("CodigoProveedor").ToString)
                            TotalDlls = Trim(dr("TotalDlls").ToString)

                            If TipoMonedaBanco = 1 Then
                                ImporteLetra = NumerosLetras(Trim(importeNumero), VbStrConv.ProperCase)
                                conceptoimporte = importeNumero
                            Else
                                ImporteLetra = NumerosLetras_DLLS(Trim(TotalDlls), VbStrConv.ProperCase)
                                conceptoimporte = TotalDlls
                            End If

                            ImporteLetra.ToUpper()



                        Else
                            MsgBox("Error al obtener Informacion de Impresion", MsgBoxStyle.Critical, "Sistema Contable")
                            Exit Sub
                        End If

                        Dim oClsMovBancos2 As New clsMovBancos
                        Dim dr2 As SqlDataReader

                        dr2 = oClsMovBancos.SeleccionaCoordenadas(cbxBancos.SelectedValue)


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


                            AddHandler printDoc.PrintPage, AddressOf print_PrintPage
                            printDoc.Print()


                        End If
                    End If
                Next
                MsgBox("Se Enviaron los documentos a la impresora", MsgBoxStyle.Information)
            Else
                '---CUANDO SE SELECCIONO IMPRIMIR POR RANGO DE FOLIOS---

                If txtChequeIni.Text = "" Or txtChequefin.Text = "" Then
                    MsgBox("Complete los valores para la impresion", MsgBoxStyle.Critical)

                Else

                    Dim FRM As New frmSeleccionarImpresora
                    FRM.ShowDialog()
                    If FRM.ImpresoraSeleccionada = "" Then
                        If MessageBox.Show("Se imprima con impresora predeterminada de windows", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                            Exit Sub
                        End If

                    End If

                    Dim printDoc As New PrintDocument

                    'Dim Contador As Integer
                    Dim folioIni As Integer
                    Dim FolioFin As Integer
                    'Dim folio As Integer

                    folioIni = CInt(txtChequeIni.Text)
                    FolioFin = CInt(txtChequefin.Text)
                    'FolioKardex = CInt(txtChequeIni.Text)
                    NumeroCheque = CInt(txtChequeIni.Text)
                    'FolioKardex = folio


                    Do While NumeroCheque <= FolioFin
                        Dim oClsMovBancos As New clsMovBancos
                        Dim dr As SqlDataReader

                        dr = oClsMovBancos.SeleccionaChequesImprimeContinuo(cbxBancos.SelectedValue, NumeroCheque, " ")

                        If dr.Read Then

                            fechacheque = Trim(dr("FechaMovimiento").ToString)
                            Beneficiario = Trim(dr("Beneficiario").ToString)
                            importeNumero = Trim(dr("Total").ToString)
                            NumeroCheque = Trim(dr("NumeroCheque").ToString)
                            NumeroPoliza = Trim(dr("Poliza").ToString)
                            concepto = Trim(dr("Concepto").ToString)
                            concepto2 = Trim(dr("Concepto2").ToString)
                            concepto3 = Trim(dr("Concepto3").ToString)
                            concepto4 = Trim(dr("Concepto4").ToString)
                            concepto5 = Trim(dr("Concepto5").ToString)
                            concepto6 = Trim(dr("Concepto6").ToString)
                            NombreBanco = Trim(dr("Banco").ToString)
                            CuentaBanco = Trim(dr("CUENTA_BANCO").ToString)
                            NombreProveedor = Trim(dr("Proveedor").ToString)
                            CuentaProveedor = Trim(dr("CUENTA_PROV").ToString)
                            CodigoProveedor = Trim(dr("CodigoProveedor").ToString)
                            TotalDlls = Trim(dr("TotalDlls").ToString)
                            If TipoMonedaBanco = 1 Then
                                ImporteLetra = NumerosLetras(Trim(importeNumero), VbStrConv.ProperCase)
                            Else
                                ImporteLetra = NumerosLetras_DLLS(Trim(TotalDlls), VbStrConv.ProperCase)
                            End If
                            ImporteLetra.ToUpper()
                            conceptoimporte = importeNumero

                            Dim oClsMovBancos2 As New clsMovBancos
                            Dim dr2 As SqlDataReader

                            dr2 = oClsMovBancos.SeleccionaCoordenadas(cbxBancos.SelectedValue)


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
                                '----------------------------------------impresora--------------------------------

                                AddHandler printDoc.PrintPage, AddressOf print_PrintPage
                                printDoc.Print()

                            End If
                            NumeroCheque = NumeroCheque + 1
                        Else
                            MsgBox("El Numero de Cheque " & NumeroCheque & "No Existe o se encuentra en estatus cancelado")
                            NumeroCheque = NumeroCheque + 1
                        End If
                    Loop
                    MsgBox("Se Enviaron los documentos a la impresora", MsgBoxStyle.Information)
                End If
            End If
            Shell(String.Format("rundll32 printui.dll,PrintUIEntry /y /n ""{0}""", ImpresoraActual))

        Else
            If chbxRango.Checked = True Then
                If txtTransferencia.Text = "" Then
                    MsgBox("No Se ha Capturado el Numero de Transferencia")
                    Exit Sub
                End If
                Dim frm As New frmRPTTransferencia
                frm.FolioTransferencia = txtTransferencia.Text
                frm.ShowDialog()
            Else

                Dim Selecciona As Integer = 0
                For Each row As DataGridViewRow In DGVCheques.Rows

                    If row.Cells("dselecciona").Value = True Then
                        Selecciona = Selecciona + 1
                    End If
                Next

                If Selecciona = 0 Then
                    MsgBox("No Se ha Seleccionado Ningun Documento", MsgBoxStyle.Exclamation, "Sistema Contable")
                    Exit Sub
                End If
                '-----IMPRESION de INFORME------
                For Each row As DataGridViewRow In DGVCheques.Rows

                    If row.Cells("dselecciona").Value = True Then

                        Dim frm As New frmRPTTransferencia
                        frm.FolioTransferencia = row.Cells("dFolioCheque").Value
                        frm.ShowDialog()
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub print_PrintPage(ByVal sender As Object, _
                           ByVal e As PrintPageEventArgs)

        Dim Importe As String
        'Dim numeroletra As String
        'Dim conceptoLin1 As String
        'Dim conceptoLin2 As String


        Importe = importeNumero
        ImporteLetra = ImporteLetra.ToUpper
        If Importe > 999999 Then
            Importe = Format(CDec(Importe), "###,###,##0.#0")
            Importe = Importe.PadLeft(15, " ")

        Else
            Importe = Format(CDec(Importe), "###,###,##0.#0")
            Importe = Importe.PadLeft(13, " ")
        End If

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
        'Dim Poliza As String = "0.00"

        Dim IVA As Integer = 0

        If CodigoProveedor = 464 Then
            IVA = 1
        End If

        cmd.Parameters.Clear()
        cmd.CommandText = "spSelPolizaImpresionCoordenadas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipopoliza", SqlDbType.Int).Value = 15
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = ""
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 1
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = NumeroPoliza
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
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = ""
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 2
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = NumeroPoliza
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
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = ""
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 3
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = NumeroPoliza
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
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = ""
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 4
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = NumeroPoliza
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
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = ""
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 5
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = NumeroPoliza
        cmd.Parameters.Add("@pConIVA", SqlDbType.VarChar).Value = IVA

        DR5 = cmd.ExecuteReader()

        If DR5.Read Then
            ImporteLin5 = DR5("Importe").ToString
            'Poliza = DR5("Poliza").ToString
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
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = ""
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = 6
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = NumeroPoliza
        cmd.Parameters.Add("@pConIVA", SqlDbType.VarChar).Value = IVA

        DR6 = cmd.ExecuteReader()

        If DR6.Read Then
            ImporteLin6 = DR6("Importe").ToString * -1
            'Poliza = DR6("Poliza").ToString
        Else
            ImporteLin6 = "0.00"

        End If
        DR6.Close()

        If TipoMonedaBanco = 2 Then
            Importe = TotalDlls
        End If

        '--------------------------------------------------------

        Dim prFont As New Font("Times New Roman", 13)
        Dim prFontNum As New Font("Times New Roman", 10)
        Dim prFontPol As New Font("Times New Roman", 9)
        '-------Linea de la Fecha --------------
        e.Graphics.DrawString(Trim(fechacheque), prFontNum, Brushes.Black, FechaX, FechaY)
        '-------Linea del Proveedor-------------
        e.Graphics.DrawString(Trim(Beneficiario), prFont, Brushes.Black, NombreX, NombreY)
        '-------Linea del Importe Numero--------
        e.Graphics.DrawString(Trim(Importe), prFontNum, Brushes.Black, MontoNumX, MontoNumY)
        '-------Linea del Importe con letra-----
        e.Graphics.DrawString(Trim("(" & ImporteLetra & ")"), prFontNum, Brushes.Black, MontoLtrX, MontoLtrY)
        '-------Linea del Concepto Linea 1------
        e.Graphics.DrawString(Trim(concepto), prFontNum, Brushes.Black, ConceptoX, ConceptoY)
        '-------Linea del Concepto Linea 2------
        e.Graphics.DrawString(Trim(concepto2), prFontNum, Brushes.Black, ConceptoX, (ConceptoY) + 20)
        '-------Linea del Concepto Linea 3------
        e.Graphics.DrawString(Trim(concepto3), prFontNum, Brushes.Black, ConceptoX, (ConceptoY) + 40)
        '-------Linea del Concepto Linea 4------
        e.Graphics.DrawString(Trim(concepto4), prFontNum, Brushes.Black, ConceptoX, (ConceptoY) + 60)
        '-------Linea del Concepto Linea 5------
        e.Graphics.DrawString(Trim(concepto5), prFontNum, Brushes.Black, ConceptoX, (ConceptoY) + 80)
        '-------Linea del Concepto Linea 6------
        e.Graphics.DrawString(Trim(concepto6), prFontNum, Brushes.Black, ConceptoX, (ConceptoY) + 100)
        '-------Linea del Concepto Linea Inferior
        e.Graphics.DrawString(Trim(Beneficiario), prFontNum, Brushes.Black, ConceptoInfX, ConceptoInfY)
        '-------Linea del Concepto Linea Inferior Importe -----
        e.Graphics.DrawString(Trim(Importe), prFontNum, Brushes.Black, ConceptoImpX, ConceptoImpY)


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
        e.Graphics.DrawString(Trim(ImporteLin5), prFontPol, Brushes.Black, (PolizaX + 550), (PolizaY + 275))
        e.Graphics.DrawString(Trim(ImporteLin6), prFontPol, Brushes.Black, (PolizaX + 660), (PolizaY + 275))

        '--------NUMERO DE CHEQUE--
        e.Graphics.DrawString(Trim("TR-15 "), prFontNum, Brushes.Black, PolizaX, (PolizaY + 300))
        e.Graphics.DrawString(Trim(NumeroPoliza & " - " & NumeroCheque), prFontNum, Brushes.Black, (PolizaX + 245), (PolizaY + 300))

    End Sub


    Private Sub txtChequeIni_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChequeIni.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtChequefin.Focus()
        End If
    End Sub

    Private Sub txtChequefin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChequefin.GotFocus
        txtChequefin.SelectAll()
    End Sub

    Private Sub txtChequefin_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChequefin.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnImprimir.PerformClick()
        End If
    End Sub

    Private Sub chbxRango_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbxRango.CheckedChanged

        If chbxRango.Checked = True Then
            If cbxDocumento.Text = "CHEQUE" Then
                btnBuscarCheque.Enabled = False
                txtChequeIni.Enabled = True
                txtChequefin.Enabled = True
                txtChequeIni.Focus()
            Else

                btnBuscarCheque.Enabled = False
                txtChequeIni.Enabled = False
                txtChequefin.Enabled = False
                txtTransferencia.Enabled = True
                txtTransferencia.Focus()
            End If
        Else
            txtChequeIni.Enabled = False
            txtChequefin.Enabled = False
            txtTransferencia.Enabled = False
            txtTransferencia.Enabled = False
            btnBuscarCheque.Enabled = True
            txtChequeIni.Text = ""
            txtChequefin.Text = ""
            txtTransferencia.Text = ""

        End If
       
    End Sub

    Private Sub txtChequeIni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChequeIni.LostFocus
        txtChequefin.Text = txtChequeIni.Text
    End Sub

    Private Sub chbxRango_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbxRango.Click
        DGVCheques.DataSource = Nothing
        DGVCheques.Rows.Clear()
    End Sub

    Private Sub cbxDocumento_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxDocumento.SelectedValueChanged
        chbxRango.Checked = False
        txtChequeIni.Text = ""
        txtChequefin.Text = ""
        txtTransferencia.Text = ""
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        DGVCheques.DataSource = Nothing
        DGVCheques.Rows.Clear()
        txtChequeIni.Text = ""
        txtChequefin.Text = ""
        txtTransferencia.Text = ""
        chbxRango.Checked = False
        btnBuscarCheque.Enabled = True
        cbxBancos.SelectedIndex = 0
    End Sub

    Private Sub cbxBancos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxBancos.SelectedIndexChanged
        DGVCheques.DataSource = Nothing
        DGVCheques.Rows.Clear()
    End Sub
End Class