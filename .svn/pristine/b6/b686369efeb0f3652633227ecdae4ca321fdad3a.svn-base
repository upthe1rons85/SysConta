Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.mdVariables
Public Class frmCECOSDepartamentos_List
  
    Private Sub frmCECOSDepartamentos_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCECOSAreas = New clsCECOSAreas()

        dr = oclsCECOSAreas.SeleccionaAreas(VPCatCuentasPuente, txtCuenta_list.Text)
        VPCatCuentasPuente = ""
        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then
            lstMuestraArea.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("cve_clas").ToString)
                lstLista.SubItems.Add(rRow("area").ToString)
                lstLista.SubItems.Add(rRow("des_area").ToString)
                lstMuestraArea.Items.Add(lstLista)
            Next
        End If

        txtCuenta_list.Text = "Cuenta"
        txtCuenta_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtDescripcion_list.Text = "Descripción"
        txtDescripcion_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
    End Sub

    Private Sub lstMuestraArea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstMuestraArea.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            VPCatCuentasPuente = lstMuestraArea.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub

    Private Sub lstMuestraArea_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstMuestraArea.MouseDoubleClick
        VPCatCuentasPuente = lstMuestraArea.SelectedItems(0).SubItems(1).Text
        Me.Close()
    End Sub

    Private Sub txtCuenta_list_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuenta_list.GotFocus
        txtDescripcion_list.Text = "Descripción"
        txtDescripcion_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtCuenta_list.Text = ""
        txtCuenta_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtCuenta_list.ForeColor = Color.Black
    End Sub

    Private Sub txtDescripcion_list_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion_list.GotFocus
        txtCuenta_list.Text = "Cuenta"
        txtCuenta_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtDescripcion_list.Text = ""
        txtDescripcion_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtDescripcion_list.ForeColor = Color.Black
    End Sub

    Private Sub txtCuenta_list_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuenta_list.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCECOSAreas = New clsCECOSAreas()

        dr = oclsCECOSAreas.SeleccionaAreas(VPCatCuentasPuente, txtCuenta_list.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        lstMuestraArea.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("cve_clas").ToString)
            lstLista.SubItems.Add(rRow("area").ToString)
            lstLista.SubItems.Add(rRow("des_area").ToString)
            lstMuestraArea.Items.Add(lstLista)
        Next
    End Sub

    Private Sub txtDescripcion_list_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion_list.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCECOSAreas = New clsCECOSAreas()

        dr = oclsCECOSAreas.BuscaDescripcionArea(Me.txtDescripcion_list.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstMuestraArea.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("cve_clas").ToString)
            lstLista.SubItems.Add(rRow("cve_des").ToString)
            lstMuestraArea.Items.Add(lstLista)
        Next
    End Sub
End Class