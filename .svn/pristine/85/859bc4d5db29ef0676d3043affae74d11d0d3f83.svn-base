Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.frmCuentasMaySeg
Imports WindowsApplication1.mdVariables


Public Class frmCuentasMayTer_List
    Dim Mayor As String
    Private Sub frmCuentasMayTer_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasNivel2 = New clsCuentasNivel2()

        dr = oclsCuentasNivel2.SeleccionaNivel2(txtCuenta.Text, VPCatCuentasPuente)
        Mayor = VPCatCuentasPuente
        VPCatCuentasPuente = ""

        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then
            lstMuestraCtaN2.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CtaNivel2").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstMuestraCtaN2.Items.Add(lstLista)
            Next
        Else
            lstMuestraCtaN2.Items.Clear()
        End If
    End Sub

    Private Sub lstMuestraCtaN2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstMuestraCtaN2.DoubleClick

        VPCatCuentasPuente = lstMuestraCtaN2.SelectedItems(0).Text

        Me.Close()

    End Sub

    Private Sub txtCuenta_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuenta.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasNivel2 = New clsCuentasNivel2()

        dr = oclsCuentasNivel2.SeleccionaNivel2(Me.txtCuenta.Text, Mayor)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstMuestraCtaN2.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CtaNivel2").ToString)
            'lstLista.SubItems.Add(rRow("CtaNivel2").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraCtaN2.Items.Add(lstLista)
        Next
    End Sub

    Private Sub txtDescripcion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasNivel2 = New clsCuentasNivel2()

        dr = oclsCuentasNivel2.BuscaDescripcionCtaNiv2(Mayor, Me.txtDescripcion.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        lstMuestraCtaN2.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CtaNivel2").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstMuestraCtaN2.Items.Add(lstLista)
        Next
    End Sub

    Private Sub lstMuestraCtaN2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstMuestraCtaN2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If lstMuestraCtaN2.Items(0).Selected = False Then
                MsgBox("No se ha Seleccionado Ningun Elemento", MsgBoxStyle.Exclamation)
                Return
            End If
            VPCatCuentasPuente = lstMuestraCtaN2.SelectedItems(0).Text

            Me.Close()

        End If
    End Sub

   
End Class