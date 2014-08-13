﻿Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports System.Drawing.Printing
Public Class frmMovBancos_Historico

    Private Sub frmMovBancos_Historico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarBancos()
        CargaProveedores()
        MaximizeBox = False
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
    Private Sub CargarBancos()

        Dim dr As SqlDataReader
        Dim oclsbancos As New clsBancos
        Dim dt As New DataTable
        dr = oclsbancos.SeleccionaBancosListaItem()

        dt.Load(dr)

        cbxBancos.ValueMember = Trim("codigo")
        cbxBancos.DisplayMember = Trim("Banco")
        cbxBancos.DataSource = dt

    End Sub

    Private Sub txtCheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCheque.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CargarCheques()
        End If
    End Sub

    Private Sub CargarCheques()
        lstCheques.Items.Clear()
        lstContraRecibo.Items.Clear()
        lstPolizas.Items.Clear()


        '------CARGAR PROVEEDOR 

        'Dim dr2 As SqlDataReader
        'Dim cmd As New SqlCommand
        'Dim cnnConexion = New SqlConnection()
        'Dim clsDB = New clsBD()
        'cnnConexion = clsDB.CreaConexion()
        'cmd.CommandText = "sPMovimientoBanco_HistoricoCheque"
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Connection = cnnConexion
        'cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
        'cmd.Parameters.Add("@nBanco", SqlDbType.Int).Value = cbxBancos.SelectedValue
        'cmd.Parameters.Add("@nCheque", SqlDbType.Int).Value = txtCheque.Text
        'cmd.Parameters.Add("@nProveedor", SqlDbType.Int).Value = cbxProveedores.SelectedValue
        'dr2 = cmd.ExecuteReader()


        'If dr2.Read Then

        'txtProveedor.Text = dr2("Proveedor").ToString()

        'End If

        '----------------------


        '-----------------CARGA GRID KARDEX MOVIMIENTO
        Dim dr As SqlDataReader
        Dim oclsMovientosBanco = New clsMovBancos

        Dim nBanco As Integer
        Dim nCheque As Integer
        Dim nProveedor As Integer

        If cbxBancos.SelectedValue = 0 Then
            nBanco = 0
        Else
            nBanco = cbxBancos.SelectedValue
        End If
        If txtCheque.Text = "" Then
            nCheque = 0
        Else
            nCheque = txtCheque.Text
        End If
        If cbxProveedores.SelectedValue = 0 Then
            nProveedor = 0
        Else
            nProveedor = cbxProveedores.SelectedValue
        End If

        dr = oclsMovientosBanco.SeleccionaListaChequesHitorico(nBanco, nCheque, nProveedor)

        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then

            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("NumeroCheque").ToString)
                lstLista.SubItems.Add(rRow("Beneficiario").ToString)
                lstLista.SubItems.Add(rRow("FolioContraRecibo").ToString)
                lstLista.SubItems.Add(rRow("FacturaProveedor").ToString)
                lstLista.SubItems.Add(Format(CDec(rRow("SubTotal").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("Iva").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("IVA11").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("IVAIMP").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("IVARetHon").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("IVARetArr").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("IVARet4").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("ISRHon").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("ISRArr").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("IEPS").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("Total").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(Format(CDec(rRow("TotalDlls").ToString), "###,###,##0.#0"))
                lstLista.SubItems.Add(rRow("TipoMoneda").ToString)
                lstLista.SubItems.Add(rRow("TipoPoliza").ToString)
                lstLista.SubItems.Add(rRow("Poliza").ToString)
                lstCheques.Items.Add(lstLista)

            Next
            '-----------------FIN CARGAR GRID
        End If
    End Sub

    Private Sub lstCheques_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCheques.Click
        lstContraRecibo.Items.Clear()
        lstPolizas.Items.Clear()
        LlenarLSTContra(Trim(lstCheques.SelectedItems(0).SubItems(2).Text))
        LlenarLSTPoliza(Trim(lstCheques.SelectedItems(0).SubItems(18).Text), Trim(lstCheques.SelectedItems(0).SubItems(17).Text))
    End Sub

    Private Sub LlenarLSTContra(ByVal nFolio)
        Dim dr As SqlDataReader
        Dim oclsMovientosBanco = New clsMovBancos()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")
        dr = oclsMovientosBanco.SeleccionaListaChequesHitoricoCRecibo(nFolio)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstContraRecibo.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("FechaContraRecibo").ToString)
                lstLista.SubItems.Add(Trim(rRow("FechaRecepcion").ToString))
                lstLista.SubItems.Add(Trim(rRow("FacturaProveedor").ToString))
                lstLista.SubItems.Add(Trim(rRow("FechaFactura").ToString))
                lstLista.SubItems.Add(Trim(rRow("Folio_Sol").ToString))
                lstLista.SubItems.Add(Trim(rRow("Folio_Cot").ToString))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("SubTotal").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("IVA16").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("IVA11").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("IVAIMP").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("IVARetHon").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("IVARetArr").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("IVARet4").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("ISRHon").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("ISRArr").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("IEPS").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("Importe").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("Saldo").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(rRow("FechaProgPago").ToString))
                lstLista.SubItems.Add(Trim(rRow("Poliza").ToString))
                lstContraRecibo.Items.Add(lstLista)

            Next

        End If
    End Sub
    Private Sub LlenarLSTPoliza(ByVal nPoliza, ByVal nTipoPoliza)
        Dim dr As SqlDataReader
        Dim oclsMovientosBanco = New clsMovBancos()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")
        dr = oclsMovientosBanco.SeleccionaListaChequesHitoricoPoliza(nPoliza, nTipoPoliza)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstPolizas.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("NumeroLinea").ToString)
                lstLista.SubItems.Add(Trim(rRow("Fecha").ToString))
                lstLista.SubItems.Add(Trim(rRow("TipoPoliza").ToString))
                lstLista.SubItems.Add(Trim(rRow("Poliza").ToString))
                lstLista.SubItems.Add(Trim(rRow("Cuenta").ToString))
                lstLista.SubItems.Add(Trim(rRow("Concepto").ToString))
                lstLista.SubItems.Add(Trim(rRow("CargoAbono").ToString))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("Importe").ToString), "###,###,##0.#0")))
                lstLista.SubItems.Add(Trim(rRow("CECO").ToString))
                lstLista.SubItems.Add(Trim(rRow("RefDocumento").ToString))
                lstLista.SubItems.Add(Trim(rRow("Referencia").ToString))
                lstPolizas.Items.Add(lstLista)

            Next

            Dim contiene As Integer = 0
            Dim SumaImporte As Double

            For i = 0 To frmProgramacionPago.lstFacturas.Items.Count - 1
                SumaImporte = Trim(frmProgramacionPago.lstFacturas.Items(i).SubItems(7).Text) '
            Next
            txtSumaPoliza.Text = SumaImporte

        End If
    End Sub


    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        CargarCheques()
    End Sub

End Class