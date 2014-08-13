Imports Microsoft.Reporting.WinForms
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class frmRPTTransferencia

    Public FolioTransferencia As Integer

    Private Sub frmRPTTransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSTransferencia.spSelInfTransferencia' Puede moverla o quitarla según sea necesario.
        Me.spSelInfTransferenciaTableAdapter.Fill(Me.DSTransferencia.spSelInfTransferencia, FolioTransferencia)
        'Me.spSelInfTransferenciaTableAdapter.Fill(Me.DSTransferencia.spSelInfTransferencia, 28)
        'Me.spSelInfTransferenciaTableAdapter.Fill(Me.DSTransferencia.spSelInfTransferencia, 12)
        Me.WindowState = FormWindowState.Maximized
        Me.Focus()
        'TODO: esta línea de código carga datos en la tabla 'DSInfCheques.spInformeCheque' Puede moverla o quitarla según sea necesario.
        '
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 25
    End Sub
End Class