Imports Microsoft.Reporting.WinForms
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class frmRPTInformeCheque

    Public Banco As Integer
    Public FolioCheque As Integer
    Public ImporteLetra As String

    Private Sub frmRPTInformeCheque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Focus()
        'TODO: esta línea de código carga datos en la tabla 'DSInfCheques.spInformeCheque' Puede moverla o quitarla según sea necesario.
        Me.spInformeChequeTableAdapter.Fill(Me.DSInfCheques.spInformeCheque, Banco, FolioCheque, ImporteLetra)
        'Me.spInformeChequeTableAdapter.Fill(Me.DSInfCheques.spInformeCheque, 12, 2, "MIL OCHENTA PESOS 00/100 M.N.")
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 25
    End Sub
End Class