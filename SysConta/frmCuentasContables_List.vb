Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.frmCuentasMaySeg
Imports WindowsApplication1.mdVariables
Public Class frmCuentasContables_List
    Dim Cuenta

    Private Sub frmCuentasContables_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasNivel3 = New clsCuentasNivel3()

        dr = oclsCuentasNivel3.SeleccionaNivel3(txtCuenta.Text, Mid(VPCatCuentasPuente, 5, 3), Mid(VPCatCuentasPuente, 1, 4))
        VPCatCuentasPuente = ""
        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then
            lstMuestraCtaN3.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CtaNivel3").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstMuestraCtaN3.Items.Add(lstLista)
            Next
        Else
            lstMuestraCtaN3.Items.Clear()
        End If
        txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtDescripcion.Text = "Descripción"
        txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
    End Sub

    Private Sub lstMuestraCtaN3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstMuestraCtaN3.DoubleClick

        VPCatCuentasPuente = lstMuestraCtaN3.SelectedItems(0).Text

        Me.Close()

    End Sub

    Private Sub txtCuenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuenta.GotFocus
        txtDescripcion.Text = "Descripción"
        txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtCuenta.Text = ""
        txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtCuenta.ForeColor = Color.Black
    End Sub

    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.GotFocus
        txtCuenta.Text = "Cuenta"
        txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtDescripcion.Text = ""
        txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtDescripcion.ForeColor = Color.Black
    End Sub

    Private Sub txtCuenta_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuenta.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasNivel3 = New clsCuentasNivel3()

        dr = oclsCuentasNivel3.SeleccionaNivel3(Me.txtCuenta.Text, Mid(VPCatCuentasPuente, 5, 3), Mid(VPCatCuentasPuente, 1, 4))

        Dim dt = New DataTable()
        dt.Load(dr)

        lstMuestraCtaN3.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CtaNivel2").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraCtaN3.Items.Add(lstLista)
        Next
    End Sub

    Private Sub txtDescripcion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasNivel3 = New clsCuentasNivel3()

        dr = oclsCuentasNivel3.BuscaDescripcionCtaNiv3(Me.txtDescripcion.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        lstMuestraCtaN3.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CuentaMayor").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraCtaN3.Items.Add(lstLista)
        Next
    End Sub


    Private Sub lstMuestraCtaN3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstMuestraCtaN3.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If lstMuestraCtaN3.Items(0).Selected = False Then
                MsgBox("No se ha Seleccionado Ningun Elemento", MsgBoxStyle.Exclamation)
                Return
            End If
            VPCatCuentasPuente = lstMuestraCtaN3.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub
End Class