Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class frmRPTInfPolizas
    Public sXML As String
    Public TiposPolizas As String
    Public fechaIni As Date
    Public fechaFin As Date
    Public PolizaIni As Integer
    Public PolizaFin As Integer
    Public Opcion As Integer
    Public nDif As Integer
    '   Me.sp_SelInformePolizasTableAdapter.Fill(Me.DSInfoPoliza.sp_SelInformePolizas, sXML, fechaIni, fechaFin)

    Private Sub frmRPTInfPolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInformesPolizas1.sp_InformePoliza_op' Puede moverla o quitarla según sea necesario.
        Me.sp_InformePoliza_opTableAdapter.Fill(Me.DSInformesPolizas1.sp_InformePoliza_op, TiposPolizas, fechaIni, fechaFin, PolizaIni, PolizaFin, Opcion, nDif)

        'Me.sp_SelInformePolizasTableAdapter.Fill(Me.DSInformePolizas.sp_SelInformePolizas, sXML, fechaIni, fechaFin, PolizaIni, PolizaFin, Opcion)
        Dim dataset1 As New DSInformesPolizas1
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class