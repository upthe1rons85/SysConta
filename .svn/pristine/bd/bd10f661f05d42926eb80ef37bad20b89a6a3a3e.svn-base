Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports System.Data.SqlClient
Public Class frmPolizasManuales_CECOS

    Public DepartamenteSelec As String

    Private Sub frmPolizasManuales_CECOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Llenalista()
        lstCECOS.Items(0).Selected = True
    End Sub

    Private Sub Llenalista()
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCECOSDeptos = New clsCECOSDeptos

        dr = oclsCECOSDeptos.SeleccionaDepartamentoLista()

        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then
            lstCECOS.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("Area_Depto").ToString)
                lstLista.SubItems.Add(rRow("Des_Depto").ToString)
                lstCECOS.Items.Add(lstLista)
            Next
        End If

    End Sub

    Private Sub lstCECOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstCECOS.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'If lstCECOS.SelectedItems(0).Text = "" Then
            '    lstCECOS.SelectedItems(0).Text = 0
            'End If
            DepartamenteSelec = lstCECOS.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub

    Private Sub lstCECOS_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstCECOS.MouseDoubleClick
        DepartamenteSelec = lstCECOS.SelectedItems(0).Text
        Me.Close()
    End Sub

    Private Sub FrmPolizasManuales_CECOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class