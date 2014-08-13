﻿Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports WindowsApplication1.frmProgramacionPago_FacProv
Imports System.Data.SqlClient
Imports System.Windows.Forms.ListView

Public Class frmProgramacionPago
    Dim ArrSelecionado(0 To 100) As StruFolio
    'Dim SelCot As Integer
    'Dim SelSol As Integer
    Dim SelCot As String
    Dim SelSol As String
    Dim CuentaAnticipoProveedor As String
    Public TipoCambio As Decimal = "0.00"
    Public bFletes As Boolean = False

    Dim IndexCotizacionlist As Integer
    '--------------Variables para formulario de Agregar Factura---------------

    Private Structure StruFolio
        Dim Fol_Sol As Integer
        Dim Fol_Cot As String
    End Structure

    Private Sub frmProgramacionPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------VALIDA PERFIL USUARIO------------------
        Dim Perfil As String
        Perfil = "00-05-06"

        If Perfil Like "*" + Perfilesusuario + "*" Then
            Me.Text = "Programación de Pago" + Space(10) + CStr(VersionCont())
            STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario

            Me.MaximizeBox = False
            DtpFecha.Text = Today
        Else

            MsgBox("No tiene Derechos Sobre esta Opcion", vbCritical, "Sistema Contable")
            Me.Close()
        End If
        '   checkbox en list
        'lstCotizaciones.RightToLeftLayout = True
        'lstCotizaciones.RightToLeft = Windows.Forms.RightToLeft.Yes
        'lstCotizaciones.View = View.Details
        'lstCotizaciones.CheckBoxes = True

        '------------------- CARGA LISTA PROVEEDORES ----------------------
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select * from almacen.dbo.catProveedores (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxProveedor.ValueMember = "cuentacontable"
        cbxProveedor.DisplayMember = "proveedor"

        cbxProveedor.DataSource = dt
        '--------------------------------

        cbxProveedor.Text = ""

        '----CARGA TIPO DE CAMBIO

        CargatipoCambio()
        txtFolio.Select()
    End Sub

    Private Sub txtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolio.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Dim oclsProgramacionPago = New clsProgramacionPago()
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            '-----
            If txtFolio.Text = "" Then
                btnNuevo.PerformClick()
                txtFolio.Text = "      * * * * *     "
                txtFolio.Enabled = False
                cbxProveedor.Enabled = True
                btnBuscar.Enabled = True
                'BtnGuardar.Enabled = True
                txtObservaciones.Enabled = True
                cbxProveedor.Focus()
                lblEstatus.Text = "ACTIVO"
                lblEstatus.ForeColor = Color.Green
            Else
                'btnNuevo.PerformClick()

                '---BORRAR CONSULTA ACTUAL----
                txtFolio.Enabled = True
                cbxProveedor.Text = ""
                txtObservaciones.Text = ""
                btnAgregarFactura.Enabled = False
                btnEliminarFac.Enabled = False
                lstCotizaciones.Enabled = True
                lstCotizaciones.Items.Clear()
                lstFacturas.Items.Clear()
                lstDetCotizacion.Items.Clear()
                txtSolicito.Text = ""
                txtAutorizo.Text = ""
                txtFechaSolicitud.Text = ""
                txtFechaRequerimiento.Text = ""
                txtUnidades.Text = ""
                txtSubtotal.Text = "0.00"
                txtTotal.Text = "0.00"
                btnImprimir.Enabled = True
                cbxAgregaElimina.Enabled = False

                '----------------------
                'VALIDAR SI EXISTE FOLIO CONTRA RECIBO
                Dim dr4 As SqlDataReader
                dr4 = oclsProgramacionPago.ExisteFolioContrarecibo(Me.txtFolio.Text)
                If dr4.Read Then
                    cbxProveedor.Text = dr4("proveedor").ToString()
                    chAnticipados.Checked = True
                    chAnticipados.Enabled = False
                Else
                    MsgBox("No existe folio de ContraRecibo, Verifique", vbInformation, "Sistema Contable")
                    Exit Sub
                End If

                '-------------------------------
                Dim dr As SqlDataReader
                dr = oclsProgramacionPago.SeleccionaContraRecibo(Me.txtFolio.Text)
                Dim dt = New DataTable()
                dt.Load(dr)
                If dt.Rows.Count > 0 Then

                    For Each rRow As DataRow In dt.Rows
                        Dim lstLista As New ListViewItem("OK")
                        lstLista.SubItems.Add(rRow("folio_sol").ToString)
                        lstLista.SubItems.Add(rRow("folio_cot").ToString)
                        lstLista.SubItems.Add(rRow("PROVEEDOR").ToString)
                        lstLista.SubItems.Add(rRow("PiezasT").ToString)
                        lstLista.SubItems.Add(Format(CDbl(rRow("IVA_TOT").ToString), "###,###,##0.00"))
                        lstLista.SubItems.Add(Format(CDbl(rRow("Imp_total").ToString), "###,###,##0.00"))
                        lstLista.SubItems.Add(rRow("TipoMoneda").ToString)

                        lstCotizaciones.Items.Add(lstLista)

                    Next
                    'lstCotizaciones.View = View.Details
                    'lstCotizaciones.Columns.Add("File type", 20, HorizontalAlignment.Left)
                    dr.Close()

                End If

                Dim dr2 As SqlDataReader
                'txtCuenta.Text = Format(txtCuenta.Text, "0000")
                dr2 = oclsProgramacionPago.SeleccionaObservacionContraRecibo(Me.txtFolio.Text)
                If dr2.Read Then
                    txtObservaciones.Text = dr2("Observaciones").ToString()
                End If
                dr2.Close()
                '--OBTIENE EL ESTATUS---
                Dim dr3 As SqlDataReader
                'txtCuenta.Text = Format(txtCuenta.Text, "0000")
                dr3 = oclsProgramacionPago.SeleccionaEstatusContraRecibo(Me.txtFolio.Text)
                If dr3.Read Then

                    lblEstatus.Text = dr3("DESCRIPCION").ToString()

                    If lblEstatus.Text = "ACTIVO" Then
                        lblEstatus.ForeColor = Color.Green
                    Else
                        lblEstatus.ForeColor = Color.Red
                    End If

                Else
                    MsgBox("No Se encontro Estatus Asignado", vbInformation, "Sistema Contable")
                End If
                dr3.Close()
                LlenarCamposFacturas()
                txtObservaciones.Enabled = False
                BtnEliminar.Enabled = True
                BtnGuardar.Enabled = False

                If lstCotizaciones.Items.Count > 0 Then
                    lstCotizaciones.Focus()
                    lstCotizaciones.Items(0).Selected = True
                    cbxProveedor.Text = lstCotizaciones.SelectedItems(0).SubItems(3).Text
                    SumaImporteCotizacionesConsulta()
                    chAnticipados.Checked = False
                    chAnticipados.Enabled = False
                End If
                btnAgregarFactura.Enabled = False
                cbxProveedor.Enabled = False
                SumaImporteFacturas()
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        bFletes = False
        lstCotizaciones.Enabled = False
        txtDiascredito.Text = ""
        txtVencimiento.Text = ""
        lblCodigo.Text = ""
        txtFolio.Enabled = True
        cbxProveedor.Enabled = False
        btnBuscar.Enabled = False
        cbxAgregaElimina.Enabled = True
        txtFolio.Text = ""
        txtFolio.Focus()
        cbxProveedor.Text = ""
        txtObservaciones.Text = ""
        btnAgregarFactura.Enabled = False
        btnEliminarFac.Enabled = False
        lstCotizaciones.Enabled = True
        lstCotizaciones.Items.Clear()
        lstFacturas.Items.Clear()
        lstDetCotizacion.Items.Clear()
        BtnEliminar.Enabled = False
        txtIVA.Text = "0.00"
        txtTotalDocumento.Text = ""
        txtSolicito.Text = ""
        txtAutorizo.Text = ""
        txtFechaSolicitud.Text = ""
        txtFechaRequerimiento.Text = ""
        txtUnidades.Text = ""
        txtSubtotal.Text = "0.00"
        txtTotal.Text = "0.00"
        btnImprimir.Enabled = False
        lblEstatus.Text = ""
        chAnticipados.Enabled = True
        chAnticipados.Checked = False
        CargatipoCambio()
    End Sub

    Private Sub lstCotizaciones_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCotizaciones.Click
        'If lstFacturas.SelectedIndices.Count > 0 Then
        ReDim ArrSelecionado(UBound(ArrSelecionado))
        SelSol = Trim(lstCotizaciones.SelectedItems(0).SubItems(1).Text)
        SelCot = Trim(lstCotizaciones.SelectedItems(0).SubItems(2).Text)
        If lstCotizaciones.SelectedItems.Count = 1 Then
            LlenarCamposDetalle()
            LlenarCamposCOT()
        Else


            For i = 1 To lstCotizaciones.SelectedItems.Count
                If lstCotizaciones.SelectedItems.Count > 0 Then
                    'MsgBox(lstCotizaciones.SelectedItems(i - 1).SubItems(2).Text)
                    SelSol = Trim(lstCotizaciones.SelectedItems(i - 1).SubItems(1).Text)
                    SelCot = Trim(lstCotizaciones.SelectedItems(i - 1).SubItems(2).Text)


                    ArrSelecionado(i - 1).Fol_Sol = SelSol
                    ArrSelecionado(i - 1).Fol_Cot = SelCot

                    If i = 1 Then
                        LlenarCamposDetalle()
                        LlenarCamposCOT()
                    Else
                        LlenarCamposDetalleMAS()
                        LlenarCamposCOT()
                    End If
                    
                End If
            Next i

        End If

    End Sub


    Private Sub LlenarCamposCOT()
        Dim dr As SqlDataReader
        Dim DiasCredito As String
        Dim vencimiento As Date
        Dim oclsProgramacionPago = New clsProgramacionPago()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")
        dr = oclsProgramacionPago.SeleccionaCotizacion(SelSol, SelCot)
        'Dim dt = New DataTable()
        'dt.Load(dr)
        If dr.Read() Then
            'txtProveedorDescripcion.Text = Trim(dr("Proveedor").ToString())
            txtSolicito.Text = Trim(dr("nom_sol").ToString())
            txtAutorizo.Text = Trim(dr("GGRAL_AUT").ToString())
            txtFechaSolicitud.Text = Trim(dr("FEC_SOL").ToString())
            txtFechaRequerimiento.Text = Trim(dr("FEC_REQ_SOL").ToString())
            DiasCredito = Trim(dr("diascredito").ToString())
            If DiasCredito = "" Then
                txtDiascredito.Text = 30
            Else
                txtDiascredito.Text = DiasCredito
            End If

            vencimiento = CDate(DtpFecha.Value).AddDays(CInt(txtDiascredito.Text))

            'Dim fc As Date = CDate(Me.txtfecha.Text)

            If vencimiento.DayOfWeek = DayOfWeek.Thursday Or vencimiento.DayOfWeek = DayOfWeek.Friday Then
                vencimiento = vencimiento

            Else
                Do
                    vencimiento = vencimiento.AddDays(1)
                Loop While (vencimiento.DayOfWeek <> DayOfWeek.Thursday)

            End If
            txtVencimiento.Text = vencimiento

            Dim importeUnidades As Decimal
            Dim totalUnidades As Decimal = 0
            For i = 0 To lstDetCotizacion.Items.Count - 1
                importeUnidades = CDec(lstDetCotizacion.Items(i).SubItems(0).Text) 'Leemos el valor de la columna de importe
                totalUnidades = totalUnidades + importeUnidades
                txtUnidades.Text = totalUnidades
                'txtUnidades.Text = Format(CDec(txtUnidades.Text), "##,##0.00")
                'Leemos el valor de las siguientes columnas
            Next

            Dim importeIVA As Decimal
            Dim totalIVA As Decimal = 0
            For i = 0 To lstDetCotizacion.Items.Count - 1
                importeIVA = CDec(lstDetCotizacion.Items(i).SubItems(5).Text) 'Leemos el valor de la columna de importe
                totalIVA = totalIVA + importeIVA
                txtIVA.Text = Format(CDec(totalIVA), "##,##0.00")
                'Leemos el valor de las siguientes columnas
            Next

            Dim OtrosIVA As Decimal
            Dim TotalOtrosIVA As Decimal

            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 8 Or CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 7 Then
                    OtrosIVA = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    TotalOtrosIVA = TotalOtrosIVA + OtrosIVA
                    'Leemos el valor de las siguientes columnas
                End If
            Next
            txtIVA.Text = Format(CDec(TotalOtrosIVA + totalIVA), "##,##0.00")
            Dim importeSUBTOTAL As Decimal
            Dim totalSUBTOTAL As Decimal = 0
            For i = 0 To lstDetCotizacion.Items.Count - 1
                txtSubtotal.Text = Format(CDec(totalSUBTOTAL), "##,##0.00")
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 0 Then
                    importeSUBTOTAL = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    totalSUBTOTAL = totalSUBTOTAL + importeSUBTOTAL
                    txtSubtotal.Text = Format(CDec(totalSUBTOTAL), "##,##0.00")
                    'Leemos el valor de las siguientes columnas
                End If
            Next

            Dim importeIVARet4 As Decimal
            Dim totalIVARet4 As Decimal = 0
            txtRet4.Text = Format(CDec(totalIVARet4), "##,##0.00")
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 4 Then
                    importeIVARet4 = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    totalIVARet4 = totalIVARet4 + importeIVARet4
                    txtRet4.Text = Format(CDec(totalIVARet4), "##,##0.00")
                    bFletes = True
                    'Leemos el valor de las siguientes columnas
                End If
            Next
            '---------------------------------
            Dim importeIVARet10 As Decimal
            Dim totalIVARet10 As Decimal = 0
            txtRet10.Text = Format(CDec(totalIVARet10), "##,##0.00")
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 5 Or CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 6 Then
                    importeIVARet10 = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    totalIVARet10 = totalIVARet10 + importeIVARet10
                    txtRet10.Text = Format(CDec(totalIVARet10), "##,##0.00")
                    'Leemos el valor de las siguientes columnas
                End If
            Next

            Dim importeISR As Decimal
            Dim totalISR As Decimal = 0
            txtISR.Text = Format(CDec(totalISR), "##,##0.00")
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 1 Or CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 2 Then
                    importeISR = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    totalISR = totalISR + importeISR
                    txtISR.Text = Format(CDec(totalISR), "##,##0.00")
                    'Leemos el valor de las siguientes columnas
                End If
            Next

            Dim importeIEPS As Decimal
            Dim totalIEPS As Decimal = 0
            txtIEPS.Text = Format(CDec(totalIEPS), "##,##0.00")
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 3 Then
                    importeIEPS = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    totalIEPS = totalIEPS + importeIEPS
                    txtIEPS.Text = Format(CDec(totalIEPS), "##,##0.00")
                    'Leemos el valor de las siguientes columnas
                End If
            Next
            '------------------------------------------------
            Dim importeTOTAL As Decimal
            Dim totalTOTAL As Decimal = 0
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 0 Then
                    importeTOTAL = CDec(lstDetCotizacion.Items(i).SubItems(7).Text) 'Leemos el valor de la columna de importe
                    totalTOTAL = totalTOTAL + importeTOTAL
                    txtTotal.Text = Format(CDec(totalTOTAL), "##,##0.00")
                End If
                'Leemos el valor de las siguientes columnas
            Next
            txtTotal.Text = Format(CDec((totalTOTAL + totalIEPS + TotalOtrosIVA) - (totalIVARet4 + totalISR + totalIVARet10)), "##,##0.00")
            ''txtUnidades.Text = Trim(dr("PiezasT").ToString())
            ''txtIVA.Text = Trim(dr("IVA_TOT").ToString())
            ''txtTotal.Text = Trim(dr("IMP_TOTAL").ToString())

            txtIVA.Text = Format(CDec(txtIVA.Text), "##,##0.00")
            txtTotal.Text = Format(CDec(txtTotal.Text), "##,##0.00")

            'txtSubtotal.Text = Format(CDec(txtTotal.Text - txtIVA.Text), "##,##0.00")
            'txtSubtotal.Text = Format(CDec(txtSubtotal.Text - txtRet4.Text), "##,##0.00")

            ''validar si el folio y solicitud ya estan agregados en las facturas
            If lstCotizaciones.SelectedItems(0).SubItems(0).Text = "OK" Then
                btnAgregarFactura.Enabled = False
                btnEliminarFac.Enabled = True
            Else
                btnAgregarFactura.Enabled = True
                btnEliminarFac.Enabled = False
            End If

        End If

    End Sub

    Private Sub LlenarCamposCOTMAS()
        Dim dr As SqlDataReader
        Dim DiasCredito As String
        Dim vencimiento As Date
        Dim oclsProgramacionPago = New clsProgramacionPago()
        dr = oclsProgramacionPago.SeleccionaCotizacion(SelSol, SelCot)

        If dr.Read() Then
            'txtProveedorDescripcion.Text = Trim(dr("Proveedor").ToString())
            txtSolicito.Text = Trim(dr("nom_sol").ToString())
            txtAutorizo.Text = Trim(dr("GGRAL_AUT").ToString())
            txtFechaSolicitud.Text = Trim(dr("FEC_SOL").ToString())
            txtFechaRequerimiento.Text = Trim(dr("FEC_REQ_SOL").ToString())
            DiasCredito = Trim(dr("diascredito").ToString())
            If DiasCredito = "" Then
                txtDiascredito.Text = 30
            Else
                txtDiascredito.Text = DiasCredito
            End If

            vencimiento = CDate(DtpFecha.Value).AddDays(CInt(txtDiascredito.Text))

            'Dim fc As Date = CDate(Me.txtfecha.Text)

            If vencimiento.DayOfWeek = DayOfWeek.Thursday Or vencimiento.DayOfWeek = DayOfWeek.Friday Then
                vencimiento = vencimiento

            Else
                Do
                    vencimiento = vencimiento.AddDays(1)
                Loop While (vencimiento.DayOfWeek <> DayOfWeek.Thursday)

            End If
            txtVencimiento.Text = vencimiento

            Dim importeUnidades As Decimal
            Dim totalUnidades As Decimal = 0
            For i = 0 To lstDetCotizacion.Items.Count - 1
                importeUnidades = CDec(lstDetCotizacion.Items(i).SubItems(0).Text) 'Leemos el valor de la columna de importe
                totalUnidades = totalUnidades + importeUnidades
                txtUnidades.Text = totalUnidades
                'txtUnidades.Text = Format(CDec(txtUnidades.Text), "##,##0.00")
                'Leemos el valor de las siguientes columnas
            Next

            Dim importeIVA As Decimal
            Dim totalIVA As Decimal = 0
            For i = 0 To lstDetCotizacion.Items.Count - 1
                importeIVA = CDec(lstDetCotizacion.Items(i).SubItems(5).Text) 'Leemos el valor de la columna de importe
                totalIVA = totalIVA + importeIVA
                txtIVA.Text = Format(CDec(totalIVA), "##,##0.000")
                'Leemos el valor de las siguientes columnas
            Next

            Dim importeSUBTOTAL As Decimal
            Dim totalSUBTOTAL As Decimal = 0
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 0 Then
                    importeSUBTOTAL = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    totalSUBTOTAL = totalSUBTOTAL + importeSUBTOTAL
                    txtSubtotal.Text = Format(CDec(totalSUBTOTAL), "##,##0.000")
                    'Leemos el valor de las siguientes columnas
                End If
            Next

            Dim importeIVARet4 As Decimal
            Dim totalIVARet4 As Decimal = 0
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 4 Then
                    importeIVARet4 = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    totalIVARet4 = totalIVARet4 + importeIVARet4
                    txtRet4.Text = Format(CDec(totalIVARet4), "##,##0.000")
                    'Leemos el valor de las siguientes columnas
                End If
            Next

            '---------------------------------
            Dim importeIVARet10 As Decimal
            Dim totalIVARet10 As Decimal = 0
            txtRet10.Text = Format(CDec(totalIVARet10), "##,##0.000")
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 5 Or CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 6 Then
                    importeIVARet10 = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    totalIVARet10 = totalIVARet10 + importeIVARet10
                    txtRet10.Text = Format(CDec(totalIVARet10), "##,##0.000")
                    'Leemos el valor de las siguientes columnas
                End If
            Next

            Dim importeISR As Decimal
            Dim totalISR As Decimal = 0
            txtISR.Text = Format(CDec(totalISR), "##,##0.000")
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 1 Or CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 2 Then
                    importeISR = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    totalISR = totalISR + importeISR
                    txtISR.Text = Format(CDec(totalISR), "##,##0.000")
                    'Leemos el valor de las siguientes columnas
                End If
            Next

            Dim importeIEPS As Decimal
            Dim totalIEPS As Decimal = 0
            txtIEPS.Text = Format(CDec(totalIEPS), "##,##0.000")
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 3 Then
                    importeIEPS = CDec(lstDetCotizacion.Items(i).SubItems(6).Text) 'Leemos el valor de la columna de importe
                    totalIEPS = totalIEPS + importeIEPS
                    txtIEPS.Text = Format(CDec(totalIEPS), "##,##0.000")
                    'Leemos el valor de las siguientes columnas
                End If
            Next
            '-----

            Dim importeTOTAL As Decimal
            Dim totalTOTAL As Decimal = 0
            For i = 0 To lstDetCotizacion.Items.Count - 1
                If CDbl(lstDetCotizacion.Items(i).SubItems(9).Text) = 0 Then
                    importeTOTAL = CDec(lstDetCotizacion.Items(i).SubItems(7).Text) 'Leemos el valor de la columna de importe
                    totalTOTAL = totalTOTAL + importeTOTAL
                    txtTotal.Text = Format(CDec(totalTOTAL), "##,##0.000")
                End If
                'Leemos el valor de las siguientes columnas
            Next
            txtTotal.Text = Format(CDec((totalTOTAL + totalIEPS) - (totalIVARet4 + totalISR + totalIVARet10)), "##,##0.000")
            ''txtUnidades.Text = Trim(dr("PiezasT").ToString())
            ''txtIVA.Text = Trim(dr("IVA_TOT").ToString())
            ''txtTotal.Text = Trim(dr("IMP_TOTAL").ToString())

            txtIVA.Text = Format(CDec(txtIVA.Text), "##,##0.000")
            txtTotal.Text = Format(CDec(txtTotal.Text), "##,##0.000")

            'txtSubtotal.Text = Format(CDec(txtTotal.Text - txtIVA.Text), "##,##0.00")
            'txtSubtotal.Text = Format(CDec(txtSubtotal.Text - txtRet4.Text), "##,##0.00")

            ''validar si el folio y solicitud ya estan agregados en las facturas
            If lstCotizaciones.SelectedItems(0).SubItems(0).Text = "OK" Then
                btnAgregarFactura.Enabled = False
                btnEliminarFac.Enabled = True
            Else
                btnAgregarFactura.Enabled = True
                btnEliminarFac.Enabled = False
            End If

        End If

    End Sub

    Private Sub LlenarCamposDetalle()
        Dim dr As SqlDataReader
        Dim oclsProgramacionPago = New clsProgramacionPago()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")
        dr = oclsProgramacionPago.SeleccionaDetalleCotizacion(SelSol, SelCot)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstDetCotizacion.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CAN_PZA").ToString)
                lstLista.SubItems.Add(Trim(rRow("UNI_PRO").ToString))
                lstLista.SubItems.Add(Trim(rRow("DES_PRO").ToString))
                lstLista.SubItems.Add(Format(CDbl(rRow("CTO_UNI").ToString), "###,###,##0.00000"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVA_PRO").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVATOTAL").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("SUBTOTAL").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IMP_TOT").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Trim(rRow("Obser").ToString))
                lstLista.SubItems.Add(Trim(rRow("IVARET4").ToString))

                lstDetCotizacion.Items.Add(lstLista)

            Next

        Else

            MsgBox("No existe folio/Cotizacion de Compra, Verifique", vbInformation, "Sistema Contable")


        End If
        Dim dr2 As SqlDataReader
        Dim oclsProgramacionPago2 = New clsProgramacionPago()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")

        dr2 = oclsProgramacionPago2.SeleccionaFechaRecepcion(SelSol, SelCot)

        If dr2.Read Then
            txtFechaRecepcion.Text = Mid(dr2("FECHA_RECIBE").ToString, 1, 10)
        Else
            MsgBox("No se Encontro fecha de Recepcion. Verifique!!", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub LlenarCamposDetalleMAS()
        Dim dr As SqlDataReader
        Dim oclsProgramacionPago = New clsProgramacionPago()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")
        dr = oclsProgramacionPago.SeleccionaDetalleCotizacion(SelSol, SelCot)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CAN_PZA").ToString)
                lstLista.SubItems.Add(Trim(rRow("UNI_PRO").ToString))
                lstLista.SubItems.Add(Trim(rRow("DES_PRO").ToString))
                lstLista.SubItems.Add(Format(CDbl(rRow("CTO_UNI").ToString), "###,###,##0.00000"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVA_PRO").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVATOTAL").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("SUBTOTAL").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IMP_TOT").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Trim(rRow("Obser").ToString))
                lstLista.SubItems.Add(Trim(rRow("IVARET4").ToString))

                lstDetCotizacion.Items.Add(lstLista)

            Next

        Else

            MsgBox("No existe folio/Cotizacion de Compra, Verifique", vbInformation, "Sistema Contable")


        End If
        Dim dr2 As SqlDataReader
        Dim oclsProgramacionPago2 = New clsProgramacionPago()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")

        dr2 = oclsProgramacionPago2.SeleccionaFechaRecepcion(SelSol, SelCot)

        If dr2.Read Then
            txtFechaRecepcion.Text = Mid(dr2("FECHA_RECIBE").ToString, 1, 10)
        Else
            MsgBox("No se Encontro fecha de Recepcion. Verifique!!", MsgBoxStyle.Critical)
        End If
    End Sub
    Public Sub LlenarCamposFacturas()
        Dim dr As SqlDataReader
        Dim oclsProgramacionPago = New clsProgramacionPago()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")
        dr = oclsProgramacionPago.SeleccionaFacturasContraRecibo(txtFolio.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstFacturas.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("folio_sol").ToString)
                lstLista.SubItems.Add(Trim(rRow("folio_cot").ToString))
                lstLista.SubItems.Add(Trim(rRow("FacturaProveedor").ToString))
                lstLista.SubItems.Add(Trim(rRow("FechaFactura").ToString))
                lstLista.SubItems.Add(" ")
                lstLista.SubItems.Add(Format(CDbl(rRow("SubTotal").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVA16").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVA11").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVAImp").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVARetHon").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVARetArr").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVARet4").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("ISRHon").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("ISRArr").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IEPS").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("Importe").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(CDbl(rRow("TipoMoneda").ToString))

                lstFacturas.Items.Add(lstLista)

            Next
        Else
            MsgBox("No Existen Facturas Relacionadas al Folio Seleccionado", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim dr As SqlDataReader
        Dim oclsProgramacionPago = New clsProgramacionPago()

        If cbxProveedor.Text = "" Then
            MsgBox("Seleccione un proveedor", MsgBoxStyle.Exclamation)
        Else
            cbxProveedor.Enabled = False
            lstCotizaciones.Enabled = True
            lstCotizaciones.Items.Clear()
            lstFacturas.Items.Clear()

            lblCodigo.Text = ""
            'Valida que el valor del listbox sea un proveedor del catalogo
            If cbxProveedor.SelectedValue = Nothing Then
                MsgBox("No se ha seleccionado ningun proveedor valido", vbCritical, "Sistema Contable")
            Else
                '--------
                If chAnticipados.Checked = False Then
                    dr = oclsProgramacionPago.SeleccionaCotProveedor(cbxProveedor.SelectedValue)
                    Dim dt = New DataTable()
                    dt.Load(dr)

                    If dt.Rows.Count > 0 Then
                        For Each rRow As DataRow In dt.Rows
                            Dim lstLista As New ListViewItem()
                            lstLista.SubItems.Add(rRow("folio_sol").ToString)
                            lstLista.SubItems.Add(rRow("folio_cot").ToString)
                            lstLista.SubItems.Add(rRow("PROVEEDOR").ToString)
                            lstLista.SubItems.Add(rRow("PiezasT").ToString)
                            lstLista.SubItems.Add(Format(CDbl(rRow("IVA_TOT").ToString), "###,###,##0.00"))
                            lstLista.SubItems.Add(Format(CDbl(rRow("Imp_total").ToString), "###,###,##0.00"))
                            lstLista.SubItems.Add(rRow("TipoMoneda").ToString)
                            lstCotizaciones.Items.Add(lstLista)
                            lstCotizaciones.Items(0).Selected = True
                        Next
                        'btnAgregarFactura.Enabled = True
                        BtnGuardar.Enabled = False

                    Else
                        MsgBox("No existen Ordenes de Compra Pendientes para el proveedor seleccionado, Verifique", vbInformation, "Sistema Contable")
                        cbxProveedor.Enabled = True
                        cbxProveedor.Focus()
                    End If
                Else
                    dr = oclsProgramacionPago.ValidarCuentaAnticipoProveedor(Me.cbxProveedor.SelectedValue)
                    If dr.Read Then
                        CuentaAnticipoProveedor = dr("CUENTAANTICIPO").ToString
                        If dr("CUENTAANTICIPO").ToString = "" Then
                            MsgBox("El proveedor no tiene asignado una Cuenta de Anticipo", vbCritical, "Sistema Contable")
                            cbxProveedor.Enabled = True
                            cbxProveedor.Focus()
                        Else
                            chAnticipados.Enabled = False
                            btnAgregarFactura.Enabled = True
                            BtnGuardar.Enabled = False
                            AgregarFacturaAnticipada()
                        End If
                    Else
                        MsgBox("El proveedor no tiene asignado una Cuenta de Anticipo", vbCritical, "Sistema Contable")
                        cbxProveedor.Enabled = True
                        cbxProveedor.Focus()
                    End If
                End If

                '----BUSCAR NUMERO DE PROVEEDOR ----
                Dim dr2 As SqlDataReader
                dr2 = oclsProgramacionPago.SeleccionaCodigoProveedor(Me.cbxProveedor.SelectedValue)
                If dr2.Read Then
                    lblCodigo.Text = dr2("codigo").ToString
                Else
                    MsgBox("El Proveedor no tiene asignado un Codigo", vbCritical, "Sistema Contable")
                End If

            End If
        End If
    End Sub

    Private Sub btnAgregarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarFactura.Click
        If chAnticipados.Checked = False Then
            AgregarFactura()
            SumaImporteFacturas()
        Else
            AgregarFacturaAnticipada()
            SumaImporteFacturas()

        End If

    End Sub
    Private Sub AgregarFacturaAnticipada()
        Dim FRM As New frmProgramacionPago_FacProv
        'Dim dr As SqlDataReader

        Dim oclsProgramacionPago = New clsProgramacionPago()
        Dim NumeroFactura As String
        FRM.NuevoFactura()
        FRM.TipoCambio = TipoCambio
        FRM.txtTipoCambio.Text = TipoCambio
        FRM.frmTipoMoneda.Visible = True ' Muestra el frame de Tipo Moneda
        FRM.ShowDialog()
        If FRM.fechaProv = Nothing Or
         FRM.facturaProv = Nothing Or
           FRM.UnidadesProv = 0 Or
           FRM.subtotalProv = 0 Or
           FRM.TotalProv = 0 Then
        Else
            txtTipoCambio.Text = FRM.txtTipoCambio.Text
            TipoCambio = FRM.txtTipoCambio.Text
            NumeroFactura = FRM.facturaProv
            Dim dr As SqlDataReader
            dr = oclsProgramacionPago.VerificaFactura(lblCodigo.Text, NumeroFactura)
            If dr.Read() Then
                Dim folioexiste As String
                Dim fecha As String
                folioexiste = dr("foliocontrarecibo").ToString()
                fecha = Mid(Trim(dr("fechacontrarecibo").ToString()), 1, 10)
                MsgBox("La Factura " & FRM.facturaProv & " ya se encuentra registrada en la fecha " & fecha & " en el folio " & folioexiste & " NO PROCEDE !!", MsgBoxStyle.Information, "Sistema Contable")
            Else
                '---------FACTURAS EN EL LA LISTA lstFacturas
                Dim facturaproveedor As String
                Dim contiene As Integer = 0
                For i = 0 To lstFacturas.Items.Count - 1
                    facturaproveedor = Trim(lstFacturas.Items(i).SubItems(2).Text) '
                    If FRM.facturaProv = facturaproveedor Then
                        contiene = 1
                    End If
                Next
                If contiene = 1 Then
                    MsgBox("La Factura " & FRM.facturaProv & " ya se encuentra agregada", MsgBoxStyle.Exclamation, "Sistema contable")
                Else
                    Dim tipoMoneda As Integer
                    Dim lista As New ListViewItem
                    If FRM.rdPesos.Checked = True Then
                        tipoMoneda = 1
                    Else
                        tipoMoneda = 2
                    End If
                    lista = lstFacturas.Items.Add("")
                    lista.SubItems.Add("")
                    lista.SubItems.Add(Trim(FRM.facturaProv))
                    lista.SubItems.Add(Trim(FRM.fechaProv))
                    lista.SubItems.Add(Trim(FRM.UnidadesProv))
                    lista.SubItems.Add(Format(CDbl(FRM.subtotalProv), "###,###,##0.00"))
                    lista.SubItems.Add(Format(CDbl(FRM.IvaProv), "###,###,##0.00"))
                    lista.SubItems.Add(Format(CDbl(FRM.IvaProv11), "###,###,##0.00"))
                    lista.SubItems.Add(Format(CDbl(FRM.IVAImp), "###,###,##0.00"))
                    lista.SubItems.Add(Format(CDbl(FRM.Ret10Hono), "###,###,##0.00"))
                    lista.SubItems.Add(Format(CDbl(FRM.Ret10Arrenda), "###,###,##0.00"))
                    lista.SubItems.Add(Format(CDbl(FRM.Ret4), "###,###,##0.00"))
                    lista.SubItems.Add(Format(CDbl(FRM.ISRHono), "###,###,##0.00"))
                    lista.SubItems.Add(Format(CDbl(FRM.ISRArrenda), "###,###,##0.00"))
                    lista.SubItems.Add(Format(CDbl(FRM.IEPS), "###,###,##0.00"))
                    lista.SubItems.Add(Format(CDbl(FRM.TotalProv), "###,###,##0.00"))
                    lista.SubItems.Add(tipoMoneda)
                    lista.SubItems.Add(Format(CDbl(FRM.Descuento), "###,###,##0.00"))
                    lista.SubItems.Add(FRM.CuentaDescuento)


                    btnEliminarFac.Enabled = True
                    BtnGuardar.Enabled = True
                End If
                '.....................FIN FACTURAS EN EL LA LISTA
            End If
            dr.Close()
        End If

    End Sub
    Private Sub AgregarFactura()
        Dim FRM As New frmProgramacionPago_FacProv
        Dim oclsProgramacionPago = New clsProgramacionPago()
        Dim NumeroFactura As String
        FRM.NuevoFactura()
        FRM.frmTipoMoneda.Visible = False ' Oculta el frame de Tipo Moneda
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
            dr = oclsProgramacionPago.VerificaFactura(lblCodigo.Text, FRM.facturaProv)
            If dr.Read() Then
                Dim folioexiste As String
                Dim fecha As String
                folioexiste = dr("foliocontrarecibo").ToString()
                fecha = Mid(Trim(dr("fechacontrarecibo").ToString()), 1, 10)
                MsgBox("La Factura " & FRM.facturaProv & " ya se encuentra registrada en la fecha " & fecha & " en el folio " & folioexiste & " NO PROCEDE !!", MsgBoxStyle.Information, "Sistema Contable")
            Else
                Dim facturaproveedor As String
                Dim contiene As Integer = 0
                For i = 0 To lstFacturas.Items.Count - 1
                    facturaproveedor = Trim(lstFacturas.Items(i).SubItems(2).Text) '
                    If FRM.facturaProv = facturaproveedor Then
                        contiene = 1
                    End If
                Next

                If contiene = 1 Then
                    MsgBox("La Factura " & FRM.facturaProv & " ya se encuentra agregada", MsgBoxStyle.Exclamation, "Sistema contable")
                Else
                    Dim RangoTotal As Double
                    RangoTotal = CDbl(FRM.txtRango.Text)
                    'Poner Validadador Diferencia Factura
                    'If (FRM.IvaProv <= ((txtIVA.Text + RangoTotal) * (-1)) Or FRM.IvaProv <= ((txtIVA.Text + RangoTotal) * (-1))) Or
                    '    FRM.TotalProv <> txtTotal.Text Or
                    '    FRM.Ret4 <> txtRet4.Text Then.
                    '                        MsgBox("Existen Diferencias Entre la Cotizacion y la factura del proveedor. Verifique !!")
                    Dim DiferenciaTotal As Double
                    Dim DiferenciaIVA As Double
                    Dim DiferenciaRet4 As Double
                    Dim DiferenciaSubTotal As Double

                    DiferenciaTotal = Math.Abs((CDbl(FRM.TotalProv + FRM.Descuento + FRM.Descuento * (0.16)) - CDbl(txtTotal.Text)))
                    If FRM.Descuento = 0 Then
                        DiferenciaIVA = Math.Abs(((CDbl(FRM.IvaProv) + CDbl(FRM.IvaProv11) + CDbl(FRM.IVAImp)) + CDbl(FRM.Descuento * 0.16) - CDbl(txtIVA.Text)))
                        DiferenciaSubTotal = Math.Abs((CDbl(FRM.subtotalProv + FRM.Descuento) - CDbl(txtSubtotal.Text)))
                    Else
                        DiferenciaIVA = 0
                        DiferenciaSubTotal = 0
                    End If

                    If bFletes = False Then
                        DiferenciaRet4 = Math.Abs((CDbl(FRM.Ret4) - CDbl(txtRet4.Text)))
                    Else
                        DiferenciaRet4 = 0
                    End If


                    If RangoTotal <= DiferenciaTotal Or RangoTotal <= DiferenciaIVA Or RangoTotal <= DiferenciaRet4 Or RangoTotal <= DiferenciaSubTotal Then
                        MsgBox("Existen Diferencias Entre la Cotizacion y la factura del proveedor. Verifique !!")
                    Else
                        Dim lista As New ListViewItem

                        lista = lstFacturas.Items.Add(Trim(lstCotizaciones.SelectedItems(0).SubItems(1).Text))
                        lista.SubItems.Add(Trim(lstCotizaciones.SelectedItems(0).SubItems(2).Text))
                        lista.SubItems.Add(Trim(FRM.facturaProv))
                        lista.SubItems.Add(Trim(FRM.fechaProv))
                        lista.SubItems.Add(Trim(FRM.UnidadesProv))
                        lista.SubItems.Add(Format(CDbl(FRM.subtotalProv), "###,###,##0.00"))
                        lista.SubItems.Add(Format(CDbl(FRM.IvaProv), "###,###,##0.00"))
                        lista.SubItems.Add(Format(CDbl(FRM.IvaProv11), "###,###,##0.00"))
                        lista.SubItems.Add(Format(CDbl(FRM.IVAImp), "###,###,##0.00"))
                        lista.SubItems.Add(Format(CDbl(FRM.Ret10Hono), "###,###,##0.00"))
                        lista.SubItems.Add(Format(CDbl(FRM.Ret10Arrenda), "###,###,##0.00"))
                        lista.SubItems.Add(Format(CDbl(FRM.Ret4), "###,###,##0.00"))
                        lista.SubItems.Add(Format(CDbl(FRM.ISRHono), "###,###,##0.00"))
                        lista.SubItems.Add(Format(CDbl(FRM.ISRArrenda), "###,###,##0.00"))
                        lista.SubItems.Add(Format(CDbl(FRM.IEPS), "###,###,##0.00"))
                        lista.SubItems.Add(Format(CDbl(FRM.TotalProv), "###,###,##0.00"))
                        lista.SubItems.Add(Trim(lstCotizaciones.SelectedItems(0).SubItems(7).Text))
                        lista.SubItems.Add(Format(CDbl(FRM.Descuento), "###,###,##0.00"))
                        lista.SubItems.Add(FRM.CuentaDescuento)

                        If lstCotizaciones.SelectedItems.Count = 1 Then
                            lstCotizaciones.SelectedItems(0).SubItems(0).ForeColor = Color.Green
                            lstCotizaciones.SelectedItems(0).SubItems(0).Text = "OK"
                            SumaImporteFacturas()
                            btnAgregarFactura.Enabled = False
                            btnEliminarFac.Enabled = True
                            BtnGuardar.Enabled = True
                        Else
                            For i = 1 To lstCotizaciones.SelectedItems.Count
                                lstCotizaciones.SelectedItems(0).SubItems(0).ForeColor = Color.Green
                                lstCotizaciones.SelectedItems(0).SubItems(0).Text = "OK"
                                SumaImporteFacturas()

                                lstCotizaciones.SelectedItems(i - 1).SubItems(0).ForeColor = Color.Green
                                lstCotizaciones.SelectedItems(i - 1).SubItems(0).Text = "OK"
                            Next i
                            btnAgregarFactura.Enabled = False
                            btnEliminarFac.Enabled = True
                            BtnGuardar.Enabled = True
                        End If

                    End If
                End If

            End If
            dr.Close()
        End If
    End Sub

    Private Sub AgregarFacturaMAS(ByVal pSolicitud As String, ByVal pCotizacion As String)
        Dim dr As SqlDataReader
        Dim oclsProgramacionPago = New clsProgramacionPago()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")
        dr = oclsProgramacionPago.SeleccionaDetalleCotizacion(pSolicitud, pCotizacion)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CAN_PZA").ToString)
                lstLista.SubItems.Add(Trim(rRow("UNI_PRO").ToString))
                lstLista.SubItems.Add(Trim(rRow("DES_PRO").ToString))
                lstLista.SubItems.Add(Trim(rRow("CTO_UNI").ToString))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVA_PRO").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IVATOTAL").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("SUBTOTAL").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IMP_TOT").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Trim(rRow("Obser").ToString))
                lstLista.SubItems.Add(Trim(rRow("IVARET4").ToString))
                lstDetCotizacion.Items.Add(lstLista)
                SumaImporteFacturas()
            Next
        Else

            MsgBox("No existe folio/Cotizacion de Compra, Verifique", vbInformation, "Sistema Contable")


        End If
        Dim dr2 As SqlDataReader
        Dim oclsProgramacionPago2 = New clsProgramacionPago()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")

        dr2 = oclsProgramacionPago2.SeleccionaFechaRecepcion(SelSol, SelCot)

        If dr2.Read Then
            txtFechaRecepcion.Text = Mid(dr2("FECHA_RECIBE").ToString, 1, 10)
        Else
            MsgBox("No se Encontro fecha de Recepcion. Verifique!!", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub SumaImporteFacturas()
        Dim importe As Decimal
        Dim total As Decimal = 0
        For i = 0 To lstFacturas.Items.Count - 1
            importe = CDbl(lstFacturas.Items(i).SubItems(15).Text) 'Leemos el valor de la columna de importe
            total = total + importe
            txtTotalDocumento.Text = total
            txtTotalDocumento.Text = Format(CDec(txtTotalDocumento.Text), "##,##0.00")
            'Leemos el valor de las siguientes columnas
        Next
    End Sub
    Private Sub SumaImporteCotizacionesConsulta()
        Dim importe As Decimal
        Dim total As Decimal = 0
        For i = 0 To lstFacturas.Items.Count - 1
            importe = CDec(lstFacturas.Items(i).SubItems(15).Text) 'Leemos el valor de la primera columna
            total = total + importe
            txtTotalDocumento.Text = Format(CDec(total), "##,##0.00")
            'Leemos el valor de las siguientes columnas
        Next
    End Sub

    Private Sub btnEliminarFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarFac.Click


        If MessageBox.Show("Elemento ya registrado, ¿Desea eliminar de la lista?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If chAnticipados.Checked = False Then
                lstCotizaciones.SelectedItems(0).SubItems(0).ForeColor = Color.Black
                lstCotizaciones.SelectedItems(0).SubItems(0).Text = ""
            End If

            lstFacturas.Focus()
            Dim i As Integer
            For i = 0 To lstFacturas.Items.Count - 1
                If lstFacturas.Items(i).SubItems(0).Text = SelSol And lstFacturas.Items(i).SubItems(1).Text = SelCot Then
                    'Dim c As Integer
                    'c = lstFacturas.SelectedIndices(c)
                    lstFacturas.Items.RemoveAt(i)
                    If lstFacturas.Items.Count = 0 Then
                        txtTotalDocumento.Text = "0.00"
                        BtnGuardar.Enabled = False

                    Else
                        SumaImporteFacturas()
                    End If
                    Exit Sub
                End If
            Next
        End If
        btnEliminarFac.Enabled = False
    End Sub

    Private Sub lstCotizaciones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCotizaciones.DoubleClick
        If Not lstCotizaciones.Items.Count > 0 Then
            Exit Sub
        End If
        If lstCotizaciones.SelectedItems(0).SubItems(0).Text = "OK" Then
            btnEliminarFac.PerformClick()
        Else
            btnAgregarFactura.PerformClick()
        End If
    End Sub

    Private Sub lstCotizaciones_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstCotizaciones.KeyUp
        If Not lstCotizaciones.Items.Count > 0 Then
            Exit Sub
        End If
        SelSol = Trim(lstCotizaciones.SelectedItems(0).SubItems(1).Text)
        SelCot = Trim(lstCotizaciones.SelectedItems(0).SubItems(2).Text)
        If lstCotizaciones.SelectedItems.Count = 1 Then
            LlenarCamposDetalle()
            LlenarCamposCOT()
        Else
            'LlenarCamposDetalleMAS()
        End If
        'LlenarCamposCOT()
        'LlenarCamposDetalle()
    End Sub


    Private Sub cbxProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxProveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            '-----
            btnBuscar.PerformClick()
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If MessageBox.Show("¿Desea GUARDAR el Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PgsGrabar.Minimum = 0
            PgsGrabar.Maximum = 100

            PgsGrabar.Value = 10


            Dim XError As String
            Dim clsDB = New clsBD()
            Dim cnnConexion = New SqlConnection()

            cnnConexion = clsDB.CreaConexion()

            Dim wQuery As String = ""
            Dim cmd As SqlCommand
            Dim wFolio As String = 0
            Dim dr As SqlDataReader
            Dim transaction As SqlTransaction


            Dim TipoPoliza As Integer
            Dim oclsProgramacionPago = New clsProgramacionPago()
            Dim dr2 As SqlDataReader

            Dim moneda As String = 1

            If bFletes = False Then
                If chAnticipados.Checked = False Then
                    TipoPoliza = 19
                Else
                    TipoPoliza = 83
                End If
            End If

            wQuery = "SELECT (folioReciboProv)+1 as FolioRecibo FROM parametros"
            XError = "Error al obtener Folio Consecutivo"
            cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
            cmd.CommandType = Data.CommandType.Text
            transaction = cnnConexion.BeginTransaction

            cmd.Connection = cnnConexion
            cmd.Transaction = transaction
            Try
                dr = cmd.ExecuteReader()
                If dr.Read Then
                    wFolio = dr("FolioRecibo").ToString()
                Else
                    MsgBox("No Se Genero Consecutivo de Folio Producto")

                End If
                PgsGrabar.Value = 20

                If wFolio IsNot Nothing Then
                    'OK Avanza
                Else
                    'Error
                    MsgBox("No Se Genero Consecutivo de Folio Producto", vbInformation, "Sistema Almacen")
                    XError = "Error al obtener Folio Consecutivo"
                End If
                dr.Close()

                Dim fechaAct As String = Format(DtpFecha.Value, "dd/MM/yyyy")
                Dim fechaSol As String = txtFechaSolicitud.Text
                Dim fechaCot As String = txtFechaRequerimiento.Text
                Dim fechaRec As String
                If txtFechaRecepcion.Text = "" Then
                    fechaRec = Format(Now, "dd/MM/yyyy")
                Else
                    fechaRec = txtFechaRecepcion.Text
                End If

                For Each item As ListViewItem In lstFacturas.Items
                    XError = "Error al Grabar Detalle de ContraRecibo"
                    cmd.Parameters.Clear()
                    cmd.CommandText = "spInsProgramacionPago"
                    cmd.CommandType = CommandType.StoredProcedure

                    moneda = item.SubItems(16).Text
                    If moneda = "" Or moneda = Nothing Then
                        moneda = 1
                    End If

                    If moneda = 2 And txtTipoCambio.Text = 0.0 Then
                        MsgBox("No Existe tipo de cambio, No se Permite continuar")
                        transaction.Rollback()
                        Exit Sub
                    End If


                    'Dim MulTipoCambio As Decimal


                    If bFletes = True Then
                        dr2 = oclsProgramacionPago.SeleccionarTipoPoliza(item.SubItems(0).Text)
                        If dr2.Read Then
                            TipoPoliza = dr2("TipoPoliza").ToString()
                        End If
                    End If

                    'If moneda = 1 Then
                    '    MulTipoCambio = 1
                    'Else
                    '    MulTipoCambio = txtTipoCambio.Text
                    'End If


                    cmd.Parameters.Add("@pFolioContraRecibo", SqlDbType.VarChar).Value = wFolio
                    cmd.Parameters.Add("@pFechaContra", SqlDbType.VarChar).Value = fechaAct
                    cmd.Parameters.Add("@pCodProveedor", SqlDbType.VarChar).Value = Trim(lblCodigo.Text)
                    cmd.Parameters.Add("@pFechaRecepcion", SqlDbType.VarChar).Value = fechaRec
                    cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = item.SubItems(2).Text
                    cmd.Parameters.Add("@pFechaFactura", SqlDbType.VarChar).Value = item.SubItems(3).Text
                    cmd.Parameters.Add("@pFolioSol", SqlDbType.VarChar).Value = item.SubItems(0).Text
                    cmd.Parameters.Add("@pFolioCot", SqlDbType.VarChar).Value = item.SubItems(1).Text

                    cmd.Parameters.Add("@pSubtotal", SqlDbType.VarChar).Value = CDbl(item.SubItems(5).Text) ' * MulTipoCambio
                    cmd.Parameters.Add("@pIVA16", SqlDbType.VarChar).Value = CDbl(item.SubItems(6).Text) ' * MulTipoCambio
                    cmd.Parameters.Add("@pIVA11", SqlDbType.VarChar).Value = CDbl(item.SubItems(7).Text) '* MulTipoCambio
                    cmd.Parameters.Add("@pIVAIMP", SqlDbType.VarChar).Value = CDbl(item.SubItems(8).Text) ' * MulTipoCambio
                    cmd.Parameters.Add("@pIVARetHon", SqlDbType.VarChar).Value = CDbl(item.SubItems(9).Text) '* MulTipoCambio
                    cmd.Parameters.Add("@pIVARetArr", SqlDbType.VarChar).Value = CDbl(item.SubItems(10).Text) '* MulTipoCambio
                    cmd.Parameters.Add("@pIVARet4", SqlDbType.VarChar).Value = CDbl(item.SubItems(11).Text) '* MulTipoCambio
                    cmd.Parameters.Add("@pISRHon", SqlDbType.VarChar).Value = CDbl(item.SubItems(12).Text) '* MulTipoCambio
                    cmd.Parameters.Add("@pISRArr", SqlDbType.VarChar).Value = CDbl(item.SubItems(13).Text) '* MulTipoCambio
                    cmd.Parameters.Add("@pIEPS", SqlDbType.VarChar).Value = CDbl(item.SubItems(14).Text) '* MulTipoCambio
                    cmd.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = CDbl(item.SubItems(15).Text) '* MulTipoCambio

                    cmd.Parameters.Add("@pEstatus", SqlDbType.VarChar).Value = 1
                    cmd.Parameters.Add("@pUsuarioModificacion", SqlDbType.VarChar).Value = LoginUsuario
                    cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = 0
                    cmd.Parameters.Add("@pObservaciones", SqlDbType.VarChar).Value = Trim(txtObservaciones.Text)
                    cmd.Parameters.Add("@pFechaProgPago", SqlDbType.VarChar).Value = txtVencimiento.Text
                    cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = moneda
                    cmd.Parameters.Add("@pTipoCambio", SqlDbType.VarChar).Value = txtTipoCambio.Text
                    cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = TipoPoliza
                    cmd.Parameters.Add("@pDescuento", SqlDbType.VarChar).Value = CDbl(item.SubItems(17).Text)
                    cmd.Parameters.Add("@pCtaDescuento", SqlDbType.VarChar).Value = Trim(item.SubItems(18).Text)

                    cmd.ExecuteNonQuery()

                Next
                PgsGrabar.Value = 45
                '---Actualiza las Cotizaciones con el FolioContraRecibo-----------------------------------------------------

                If chAnticipados.Checked = False Then
                    Dim x As Integer
                    If Not ArrSelecionado(0).Fol_Sol = 0 Then


                        For x = LBound(ArrSelecionado) To UBound(ArrSelecionado)
                            If Not ArrSelecionado(x).Fol_Sol = 0 Then
                                XError = "Error al Grabar Detalle de ContraRecibo (Actualizar folios CR en cotizacion)"
                                cmd.Parameters.Clear()
                                cmd.CommandText = "spInsFolioContrareciboCOT"
                                cmd.CommandType = CommandType.StoredProcedure

                                cmd.Parameters.Add("@pFolioContraRecibo", SqlDbType.VarChar).Value = wFolio
                                cmd.Parameters.Add("@pFolioSol", SqlDbType.VarChar).Value = ArrSelecionado(x).Fol_Sol
                                cmd.Parameters.Add("@pFolioCot", SqlDbType.VarChar).Value = ArrSelecionado(x).Fol_Cot

                                cmd.ExecuteNonQuery()
                            Else
                                Exit For
                            End If
                        Next

                    End If
                End If
                '---Inserta la observacion del documento en una tabla aparte
                XError = "Error al Insertar Observacion de ContraRecibo"
                cmd.Parameters.Clear()
                cmd.CommandText = "spInsObsContrarecibo"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnnConexion

                cmd.Parameters.Add("@pFoliocontraRecibo", SqlDbType.VarChar).Value = wFolio
                cmd.Parameters.Add("@pObservaciones", SqlDbType.VarChar).Value = Trim(txtObservaciones.Text)

                cmd.ExecuteNonQuery()

                PgsGrabar.Value = 60

                '----Adelanta folio de contrarecibo en los parametros

                XError = "Error al Actualizar Folio consecutivo"
                cmd.Parameters.Clear()
                cmd.CommandText = "sp_AdeFolioContraRecibo"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnnConexion

                cmd.Parameters.Add("@FoliocontraRecibo", SqlDbType.Float).Value = wFolio

                cmd.ExecuteNonQuery()
                PgsGrabar.Value = 80

                '-------TEMPORAL
                'transaction.Commit()

                '----Crea Poliza Contable
                If chAnticipados.Checked = False Then


                    XError = "Error al Realizar Poliza Contable"
                    cmd.Parameters.Clear()

                    If bFletes = False Then
                        XError = "Error al Realizar Poliza Contable"
                        cmd.Parameters.Clear()
                        If lstFacturas.Items.Count > 1 Then
                            cmd.CommandText = "spPolizaContraRecibo_MULTIPLE"
                        Else
                            cmd.CommandText = "spPolizaContraRecibo"
                        End If
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion

                        cmd.Parameters.Add("@pFolio", SqlDbType.VarChar).Value = wFolio
                        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fechaAct
                        'cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = "20140306"
                        cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.VarChar).Value = 5
                        cmd.Parameters.Add("@pMoneda", SqlDbType.VarChar).Value = moneda
                        cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = LoginUsuario


                        cmd.ExecuteNonQuery()
                        PgsGrabar.Value = 100
                    Else
                        XError = "Error al Realizar Poliza Contable Flete"
                        cmd.Parameters.Clear()
                        cmd.CommandText = "spPolizaFletes"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion

                        cmd.Parameters.Add("@folioContrarecibo", SqlDbType.VarChar).Value = wFolio

                        cmd.ExecuteNonQuery()
                        PgsGrabar.Value = 100
                    End If

                Else
                    XError = "Error al Realizar Poliza  Anticipo"
                    cmd.Parameters.Clear()
                    cmd.CommandText = "spPolizasPagoAnticipado"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = cnnConexion

                    cmd.Parameters.Add("@FolioContraRecibo", SqlDbType.Int).Value = wFolio
                    cmd.Parameters.Add("@nProveedor", SqlDbType.Int).Value = lblCodigo.Text
                    cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = LoginUsuario

                    cmd.ExecuteNonQuery()
                    PgsGrabar.Value = 100
                End If
                    '----Termino de transaccion se Cierra transaccion

                    transaction.Commit()
                    MsgBox("Se Grabo Correctamente, Folio de Contrarecibo : " & wFolio, MsgBoxStyle.Information)

                    txtFolio.Text = wFolio
                    BtnGuardar.Enabled = False
                    btnAgregarFactura.Enabled = False
                    btnEliminarFac.Enabled = False
                    txtObservaciones.Enabled = False
                    btnImprimir.Enabled = True
                    PgsGrabar.Value = 0
                    XError = "Error al Imprimir"
                btnImprimir.PerformClick()


                If MessageBox.Show("¿Desea Seguir Capturando Con El Mismo Proveedor?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    lstCotizaciones.Enabled = False
                    txtDiascredito.Text = ""
                    txtVencimiento.Text = ""
                    lblCodigo.Text = ""
                    txtFolio.Enabled = True
                    cbxProveedor.Enabled = False
                    cbxAgregaElimina.Enabled = True
                    txtObservaciones.Text = ""
                    btnAgregarFactura.Enabled = False
                    btnEliminarFac.Enabled = False
                    lstCotizaciones.Enabled = True
                    lstCotizaciones.Items.Clear()
                    lstFacturas.Items.Clear()
                    lstDetCotizacion.Items.Clear()

                    txtIVA.Text = "0.00"
                    txtTotalDocumento.Text = ""
                    txtSolicito.Text = ""
                    txtAutorizo.Text = ""
                    txtFechaSolicitud.Text = ""
                    txtFechaRequerimiento.Text = ""
                    txtUnidades.Text = ""
                    txtSubtotal.Text = "0.00"
                    txtTotal.Text = "0.00"
                    btnImprimir.Enabled = False
                    lblEstatus.Text = ""
                    chAnticipados.Enabled = True
                    CargatipoCambio()

                    txtFolio.Text = "      * * * * *     "
                    txtFolio.Enabled = False
                    cbxProveedor.Enabled = False
                    btnBuscar.PerformClick()
                Else
                    btnNuevo.PerformClick()
                End If
            Catch err As Exception
                transaction.Rollback()
                MsgBox("Ocurrio un Error al Grabar " & XError, MsgBoxStyle.Critical)
                MessageBox.Show("Error:" & err.Message)
            Finally
                cnnConexion.Dispose()
                cnnConexion.Close()

            End Try
            


        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTProgramacionPagos
        frm.folioContraRecibo = txtFolio.Text
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

            wQuery = "SELECT poliza,fechacontrarecibo,tipopoliza FROM bcocontrarecibo WHERE folioContraRecibo = " & txtFolio.Text

            cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
            cmd.CommandType = Data.CommandType.Text
            transaction = cnnConexion.BeginTransaction
            cmd.Transaction = transaction
            cmd.Connection = cnnConexion

            dr = cmd.ExecuteReader()
            If dr.Read Then
                wFolio = dr("poliza").ToString()
                wFecha = dr("FechaContrarecibo").ToString()
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

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        If txtFolio.Text = "" Or txtFolio.Text = "****" Then
            Exit Sub
        End If
        If MessageBox.Show("¿Desea CANCELAR el Folio?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim oclsProgramacionPago = New clsProgramacionPago()
                oclsProgramacionPago.CancelaContrarecibo(Trim(txtFolio.Text))
                MsgBox("Se Cancelo El registro correctamente", MsgBoxStyle.Information)
                lblEstatus.Text = "CANCELADO"
                lblEstatus.ForeColor = Color.Red
            Catch ex As Exception
                MsgBox("Ocurrio un Error al Cancelar")

            End Try
            btnNuevo.PerformClick()
        End If
    End Sub

    'Private Sub CKBRetencion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CKBRetencion.Click
    '    If CKBRetencion.Checked = True Then
    '        'RBTRetension.Checked = True
    '        txtRetension.Text = (txtSubtotal.Text) * 0.04
    '        txtRetension.Text = Format(CDec(txtRetension.Text), "##,##0.00")
    '        txtTotal.Text = Format(CDec((CDec(txtSubtotal.Text) + CDec(txtIVA.Text)) - txtRetension.Text), "##,##0.00")
    '    Else
    '        txtRetension.Text = 0
    '        txtRetension.Text = Format(CDec(txtRetension.Text), "##,##0.00")
    '        txtTotal.Text = Format(CDec((CDec(txtSubtotal.Text) + CDec(txtIVA.Text)) - txtRetension.Text), "##,##0.00")
    '    End If
    'End Sub
    Private Sub CargatipoCambio()

        Dim DR As SqlDataReader
        Dim oclstipocambio As New clsTipocambio
        Dim fecha As String
        Dim fechaCam As String
        fecha = DateTime.Now.ToString("dd/MM/yyyy")
        fechaCam = Format(DtpFecha.Value, "yyyyMMdd")
        DR = oclstipocambio.CargaTipoCambio(fechaCam)

        If DR.Read() Then

            txtTipoCambio.Text = DR("TipoCambio").ToString()

        Else
            MsgBox("No hay Tipo de Cambio del dia", MsgBoxStyle.Critical, "Sistema Contable")
            txtTipoCambio.Text = "0.00"
        End If
    End Sub

    Private Sub lstFacturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstFacturas.DoubleClick
        If IsNumeric(txtFolio.Text) = False Or lblEstatus.Text = "CANCELADO" Then
            Exit Sub
        End If
        If MessageBox.Show("¿Desea cambiar el folio de la factura " & Trim(lstFacturas.SelectedItems(0).SubItems(2).Text) & " ?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim frm As New frmProgramacionPago_CambioFactura
            frm.frmProveedor.Text = cbxProveedor.Text

            frm.txtFactura.Text = lstFacturas.SelectedItems(0).SubItems(2).Text
            frm.txtFechaFactura.Text = lstFacturas.SelectedItems(0).SubItems(3).Text
            frm.txtImporte.Text = lstFacturas.SelectedItems(0).SubItems(15).Text
            frm.dtpFechaFactura.Value = lstFacturas.SelectedItems(0).SubItems(3).Text
            frm.lblCodigo.Text = lblCodigo.Text
            frm.txtFolio.Text = txtFolio.Text
            frm.ShowDialog()
            LlenarCamposFacturas()
        End If

    End Sub

    Private Sub cbxProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxProveedor.SelectedValueChanged
        btnBuscar.Select()
    End Sub

    Private Sub DtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFecha.ValueChanged
        CargatipoCambio()
    End Sub
End Class