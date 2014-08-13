Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.mdVariables

Public Class frmPolizasManuales_Cuentas

    Private Sub frmPolizasManuales_Cuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtCuentaMayor.Text = ""
        txtCuentaNiv2.Text = ""
        txtCuentaNiv3.Text = ""
        txtDescripcion.Text = ""
        LlenarListaCuentaAyuda()
        'lstCuentaContable.Items(0).Selected = True
        txtDescripcion.Focus()

    End Sub

    Private Sub BtnBuscarMay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarMay.Click
        frmCuentasMaySeg_List.ShowDialog()
        btnBuscarN2.Enabled = True
        txtCuentaNiv2.Text = ""
        txtCuentaMayor.Text = VPCatCuentasPuente
        LlenarListaCuentaAyuda()
        'lblCuentaMayor.Text = txtCuentaMayor.Text
    End Sub

    Private Sub LlenarListaCuentaAyuda()
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasContables = New clsCuentasContables()

        dr = oclsCuentasContables.SeleccionaAyudaCtaContable(Me.txtCuentaMayor.Text, Me.txtCuentaNiv2.Text, Me.txtCuentaNiv3.Text)

        Dim dt = New DataTable()
        dt.Load(dr)
        lstCuentaContable.Items.Clear()
        If dt.Rows.Count > 0 Then
            lstCuentaContable.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("Cuenta").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstLista.SubItems.Add(rRow("Naturaleza").ToString)
                lstLista.SubItems.Add(rRow("Estatus").ToString)
                lstCuentaContable.Items.Add(lstLista)
            Next
        End If
    End Sub

    Private Sub btnBuscarN2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarN2.Click
        VPCatCuentasPuente = txtCuentaMayor.Text
        frmCuentasMayTer_List.ShowDialog()
        btnBuscarN3.Enabled = True
        txtCuentaNiv3.Text = ""
        txtCuentaNiv2.Text = VPCatCuentasPuente
        LlenarListaCuentaAyuda()
    End Sub

    Private Sub btnBuscarN3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarN3.Click
        VPCatCuentasPuente = Trim(Me.txtCuentaMayor.Text) + Trim(Me.txtCuentaNiv2.Text)
        frmCuentasContables_List.ShowDialog()
        txtCuentaNiv3.Text = VPCatCuentasPuente
        LlenarListaCuentaAyuda()
    End Sub

    Private Sub lstCuentaContable_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCuentaContable.GotFocus
        Me.lstCuentaContable.Items(0).Focused = True
        Me.lstCuentaContable.Items(0).Selected = True
    End Sub

    Private Sub lstCuentaContable_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstCuentaContable.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            VPCatCuentasPuente = lstCuentaContable.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub

    Private Sub lstCuentaContable_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstCuentaContable.MouseDoubleClick
        VPCatCuentasPuente = lstCuentaContable.SelectedItems(0).Text
        Me.Close()
    End Sub

    Private Sub txtDescripcion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasContable = New clsCuentasContables()

        dr = oclsCuentasContable.BuscaDescripcionCtaContable(Me.txtDescripcion.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstCuentaContable.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Cuenta").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstLista.SubItems.Add(rRow("Naturaleza").ToString)
            lstLista.SubItems.Add(rRow("Estatus").ToString)
            lstCuentaContable.Items.Add(lstLista)
        Next
    End Sub
    Private Sub FrmPolizasManuales_Cuentas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class