﻿Imports System.Data.SqlClient
Public Class frmProveedorCambioPrecioOC

    Private Sub txtOCFolioCOT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOCFolioCOT.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnBusca.PerformClick()
        End If
    End Sub

    Private Sub ListaCOTIZACION()
        Dim dr As SqlDataReader
        Dim ocls = New clsProveedorCambioPrecio

        dr = ocls.SeleccionaListaCotizacion(1, txtOCFolioCOT.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then

            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("ID_FOLSOL").ToString)
                lstLista.SubItems.Add(rRow("FOLIO_SOL").ToString)
                lstLista.SubItems.Add(rRow("folio_cot").ToString)
                lstLista.SubItems.Add(rRow("CUENTA").ToString)
                lstLista.SubItems.Add(rRow("DES_PRO").ToString)
                lstLista.SubItems.Add(rRow("CAN_PZA").ToString)
                lstLista.SubItems.Add(Format(CDbl(rRow("CTO_UNI").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("SUBTOTAL").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(rRow("TipoIVA").ToString)
                lstLista.SubItems.Add(Format(CDbl(rRow("IVA_PRO").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("IMP_TOT").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("CTO_UNI_ANT").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(rRow("USUARIO_CAMBIO").ToString)
                lstCotizacion.Items.Add(lstLista)
            Next
            '-----------------FIN CARGAR GRID
        End If

        dr.Close()

    End Sub

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        lstCotizacion.Items.Clear()
        If Not txtOCFolioCOT.Text = "" Then
            ListaCOTIZACION()
            LimbiarCamposDetalle()
        End If
    End Sub

    Private Sub frmProveedorCambioPrecioOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarPorcientoCambioPrecio()
        CargaCuenta(1)

    End Sub

    Private Sub CargaCuenta(ByVal nOpcion As Integer)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String
        consulta = ""

        If nOpcion = 1 Then
            consulta = "SELECT * FROM catCuentas  WHERE left(cuenta,4)='6100'  OR cuenta IN ( " _
            & "'11003401300001','52001301300101','21002202500102','21002202500101','21002202500100','21002202200101'," _
            & "'21002202200100','11003103100130','11003101300160','11003103100130') " _
            & " order by substring(cuenta,1,1), Descripcion"
        Else
            consulta = "SELECT * FROM catCuentas order by substring(cuenta,1,1), Descripcion"
        End If
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxCuenta.ValueMember = "cuenta"
        cbxCuenta.DisplayMember = "descripcion"

        cbxCuenta.DataSource = dt

    End Sub
    Private Sub lstCotizacion_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCotizacion.DoubleClick
        LimbiarCamposDetalle()
        If Trim(lstCotizacion.SelectedItems(0).SubItems(12).Text) = "" Then
            cbxCuenta.Enabled = True
            If CDbl(Mid(lstCotizacion.SelectedItems(0).SubItems(3).Text, 1, 1)) = 6 Then
                CargaCuenta(1)
            Else
                CargaCuenta(2)
            End If
            txtIDSol.Text = Trim(lstCotizacion.SelectedItems(0).SubItems(0).Text)
            txtSol.Text = Trim(lstCotizacion.SelectedItems(0).SubItems(1).Text)
            txtCot.Text = Trim(lstCotizacion.SelectedItems(0).SubItems(2).Text)
            'cbxCuenta.Text = Trim(lstCotizacion.SelectedItems(0).SubItems(3).Text)
            cbxCuenta.SelectedValue = Trim(lstCotizacion.SelectedItems(0).SubItems(3).Text)
            txtDescripcion.Text = UCase(Trim(lstCotizacion.SelectedItems(0).SubItems(4).Text))
            txtCantidad.Text = Trim(lstCotizacion.SelectedItems(0).SubItems(5).Text)
            txtCostoAnt.Text = Trim(lstCotizacion.SelectedItems(0).SubItems(6).Text)
            txtSubtotal.Text = Trim(lstCotizacion.SelectedItems(0).SubItems(7).Text)
            cbxTipoIva.Text = Trim(lstCotizacion.SelectedItems(0).SubItems(8).Text)
            txtIva.Text = Trim(lstCotizacion.SelectedItems(0).SubItems(9).Text)
            txtImporte.Text = Trim(lstCotizacion.SelectedItems(0).SubItems(10).Text)
            txtCostoNuevo.Text = txtCostoAnt.Text
            If Not Mid(cbxCuenta.SelectedValue, 1, 1) = 6 Then
                cbxCuenta.Enabled = False
            End If
            txtCostoNuevo.Enabled = True
            BtnGuardar.Enabled = True
        Else
            LimbiarCamposDetalle()

        End If
    End Sub
    Private Sub LimbiarCamposDetalle()
        cbxCuenta.Enabled = True
        txtIDSol.Text = ""
        txtSol.Text = ""
        txtCot.Text = ""
        cbxCuenta.Text = ""
        cbxTipoIva.Text = ""
        txtDescripcion.Text = ""
        txtCantidad.Text = ""
        txtCostoAnt.Text = ""
        txtSubtotal.Text = ""
        txtIva.Text = ""
        txtImporte.Text = ""
        txtCostoNuevo.Text = ""
        cbxTipoIva.Text = ""
        cbxCuenta.Text = ""
        txtDescripcion.Text = ""
        txtCostoNuevo.Enabled = False
        BtnGuardar.Enabled = False
        cbxCuenta.Enabled = False
    End Sub
    Private Sub txtCostoNuevo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostoNuevo.GotFocus
        txtCostoNuevo.SelectAll()
    End Sub

    Private Sub txtCostoNuevo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostoNuevo.KeyPress
        Dim i As Integer
        i = InStr(txtCostoNuevo.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtCostoNuevo.Text = "" Then
                txtCostoNuevo.Text = "0.00"
            End If
            txtCostoNuevo.Text = Format(CDec(txtCostoNuevo.Text), "##,##0.00")
            BtnGuardar.Focus()
        End If
        
    End Sub

    Private Sub CargarPorcientoCambioPrecio()
        Dim cnnConexion = New SqlConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        cmd.CommandText = "SELECT Valor FROM ParametrosAdministrados (NOLOCK) WHERE sNombre = 'ToleranciaCambioPrecioOC'"
        cmd.CommandType = CommandType.Text
        cmd.Connection = cnnConexion

        dr = cmd.ExecuteReader()
        If dr.Read Then
            txtPorciento.Text = dr("Valor").ToString
        End If
        cnnConexion.Close()

    End Sub

    Private Sub txtCostoNuevo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostoNuevo.LostFocus
        CargarPorcientoCambioPrecio()
        Dim ValorMin As Double
        If txtCostoAnt.Text = "" Then
            txtCostoAnt.Text = "0.00"
        End If
        ValorMin = CDbl(txtCostoAnt.Text) - (CDbl(txtCostoAnt.Text) * (CDbl(txtPorciento.Text) / 100))
        If txtCostoNuevo.Text = "" Then
            txtCostoNuevo.Text = "0.00"
        End If
        txtCostoNuevo.Text = Format(CDec(txtCostoNuevo.Text), "##,##0.00")
        If CDbl(txtCostoAnt.Text) < CDbl(txtCostoNuevo.Text) Or Not CDbl(txtCostoNuevo.Text) > ValorMin Then
            MsgBox("El costo unitario debe se menor al " + txtCostoAnt.Text + " y que no sebrepase el porcentaje autorizado de " + txtPorciento.Text, MsgBoxStyle.Information, "Sistema Contabilidad")
            txtCostoNuevo.Text = txtCostoAnt.Text
            txtCostoNuevo.BackColor = Color.Red
        Else
            txtCostoNuevo.BackColor = Color.Cornsilk
        End If
        If IsNumeric(txtCostoNuevo.Text) = True Then
            txtSubtotal.Text = Format((CDbl(txtCostoNuevo.Text) * CDbl(txtCantidad.Text)), "##,##0.00")
            txtIva.Text = Format((CDbl(txtSubtotal.Text) * (0.16)), "##,##0.00")
            txtImporte.Text = Format((CDbl(txtSubtotal.Text) + CDbl(txtIva.Text)), "##,##0.00")
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        txtIDSol.Text = ""
        txtSol.Text = ""
        txtCot.Text = ""
        txtDescripcion.Text = ""
        txtCantidad.Text = ""
        txtCostoAnt.Text = ""
        txtSubtotal.Text = ""
        txtIva.Text = ""
        txtImporte.Text = ""
        txtCostoNuevo.Text = ""
        txtCostoNuevo.ReadOnly = True
        BtnGuardar.Enabled = False
        lstCotizacion.Items.Clear()
        txtOCFolioCOT.Text = ""
        cbxCuenta.Text = ""
        cbxTipoIva.Text = ""
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtCostoNuevo.BackColor = Color.Red Then
            MsgBox("Favor de validar el costo que requiere modificar", MsgBoxStyle.Information, "Sistema Contabilidad")
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Guardar el Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim clsDB = New clsBD()
            Dim cnnConexion = New SqlConnection()

            cnnConexion = clsDB.CreaConexion()

            Dim cmd As New SqlCommand
            cmd.CommandText = "spModificarOCPrecio"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnnConexion


            cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
            cmd.Parameters.Add("@IdFolioSol", SqlDbType.VarChar).Value = txtIDSol.Text
            cmd.Parameters.Add("@FolioSol", SqlDbType.VarChar).Value = txtSol.Text
            cmd.Parameters.Add("@FolioCot", SqlDbType.VarChar).Value = txtCot.Text
            cmd.Parameters.Add("@CTO_UNI", SqlDbType.VarChar).Value = CDbl(txtCostoNuevo.Text)
            cmd.Parameters.Add("@IVA", SqlDbType.VarChar).Value = CDbl(cbxTipoIva.Text)
            cmd.Parameters.Add("@IMPORTE", SqlDbType.VarChar).Value = CDbl(txtImporte.Text)
            cmd.Parameters.Add("@CUENTA", SqlDbType.VarChar).Value = cbxCuenta.SelectedValue
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = LoginUsuario

            cmd.ExecuteNonQuery()

            MsgBox("Grabado Correctamente", MsgBoxStyle.Information)
            btnNuevo.PerformClick()
            BtnGuardar.Enabled = False
        End If
    End Sub

    Private Sub cbxTipoIva_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipoIva.SelectedIndexChanged
        If txtSubtotal.Text <> "" Then
            txtIva.Text = Format(CDbl(txtSubtotal.Text) * (CDbl(cbxTipoIva.Text) / 100), "###,###,##0.00")
            txtImporte.Text = Format((CDbl(txtSubtotal.Text) + CDbl(txtIva.Text)), "###,###,##0.00")
        End If
    End Sub
End Class