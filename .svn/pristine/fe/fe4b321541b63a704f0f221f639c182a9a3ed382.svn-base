Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmRPTPolizasManual
    Public folio As String
    Public tipoPoliza As String
    Public fecha As String

    Private Sub frmRPTPolizasManual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmRPTPolizasManual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSPolizasContables.spSelPolizaContable' Puede moverla o quitarla según sea necesario.
        DSPolizasContables.EnforceConstraints = False
        Me.spSelPolizaContableTableAdapter.Fill(Me.DSPolizasContables.spSelPolizaContable, fecha, tipoPoliza, folio)
        Me.WindowState = FormWindowState.Maximized
        Me.Focus()

        Me.RVPolizaContable.SetDisplayMode(DisplayMode.PrintLayout)
        Me.RVPolizaContable.ZoomMode = ZoomMode.Percent
        Me.RVPolizaContable.ZoomPercent = 25
        Me.RVPolizaContable.RefreshReport()
    End Sub

    Private Sub RVPolizaContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RVPolizaContable.Load

    End Sub
End Class