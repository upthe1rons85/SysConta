Imports System.Drawing.Printing
Public Class frmRPTInformeDepreciacionFiscal
    Public Mes As Integer
    Public Año As Integer
    Private Sub frmRPTInformeDepreciacionFiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSDepreFiscal.spDepreciacionFiscal' Puede moverla o quitarla según sea necesario.
        Me.spDepreciacionFiscalTableAdapter.Fill(Me.DSDepreFiscal.spDepreciacionFiscal, Mes, Año)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class