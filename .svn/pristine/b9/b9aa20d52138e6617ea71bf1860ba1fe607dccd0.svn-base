Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.frmCuentasMaySeg
Imports WindowsApplication1.mdVariables


Public Class frmCuentasMaySeg_List
    Private Sub frmCuentasMaySeg_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasMayor = New clsCuentasMayor()
        dr = oclsCuentasMayor.SeleccionaCuentasMayor(txtCuenta.Text)
        VPCatCuentasPuente = ""
        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then
            lstMuestraCtaMayor.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CuentaMayor").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstMuestraCtaMayor.Items.Add(lstLista)
            Next
        End If
    End Sub

    Private Sub lstMuestraCtaMayor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstMuestraCtaMayor.DoubleClick

        VPCatCuentasPuente = lstMuestraCtaMayor.SelectedItems(0).Text

        Me.Close()

    End Sub
    Private Sub txtCuenta_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuenta.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasMayor = New clsCuentasMayor()

        dr = oclsCuentasMayor.SeleccionaCuentasMayor(Me.txtCuenta.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstMuestraCtaMayor.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CuentaMayor").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraCtaMayor.Items.Add(lstLista)
        Next
    End Sub

    Private Sub txtDescripcion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasMayor = New clsCuentasMayor()

        dr = oclsCuentasMayor.BuscaDescripcionCtaMayor(Me.txtDescripcion.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstMuestraCtaMayor.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CuentaMayor").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraCtaMayor.Items.Add(lstLista)
        Next
    End Sub

    Private Sub lstMuestraCtaMayor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstMuestraCtaMayor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If lstMuestraCtaMayor.Items(0).Selected = False Then
                MsgBox("No se ha Seleccionado Ningun Elemento", MsgBoxStyle.Exclamation)
                Return
            End If
            VPCatCuentasPuente = lstMuestraCtaMayor.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub
End Class