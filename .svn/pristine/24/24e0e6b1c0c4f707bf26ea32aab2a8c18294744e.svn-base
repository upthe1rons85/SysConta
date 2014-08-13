Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Public Class frmRPTCuentasNiv3
    Public pCuentaNiv3 As String
    Public pCuentaNiv2 As String
    Public pCuentaMayor As String
               
    Private Sub frmRPTCuentasNiv3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSCuentasNiv3.spSelCuentaNiv3' Puede moverla o quitarla según sea necesario.
        Me.spSelCuentaNiv3TableAdapter.Fill(Me.DSCuentasNiv3.spSelCuentaNiv3, pCuentaNiv3, pCuentaNiv2, pCuentaMayor)
        Me.Text = "Informe Cuenta Nivel 3 " + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class