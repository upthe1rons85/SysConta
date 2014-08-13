Imports System.Drawing.Printing
Public Class frmRPTInformeDepreciacionContable
    Public Mes As Integer
    Public Año As Integer
    Private Sub frmRPTInformeDepreciacionContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSDepreContable.spDepreciacionContable' Puede moverla o quitarla según sea necesario.
        Me.spDepreciacionContableTableAdapter.Fill(Me.DSDepreContable.spDepreciacionContable, Mes, Año)
      
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class