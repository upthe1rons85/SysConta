Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
'Imports WindowsApplication1.clsTipocambio
Imports WindowsApplication1.clsTools
Public Class frmPolizasDepreciacion
    Dim mes As String
    Dim año As String
    Dim Fecha As String
    Private Sub frmPolizasDepreciacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtpFecha.Value = Today
        Me.Text = "Generar Polizas Depreciacion" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
    End Sub
    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        Fecha = Me.DtpFecha.Value.ToShortDateString
        mes = Month(Fecha)
        año = Year(Fecha)
        Fecha = Format(CDate(Fecha), "yyyyMMdd")
        Try
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()

            Dim commandbus As New SqlCommand("spGeneraPolizasDepreciacion", cnnConexion)
            commandbus.CommandType = CommandType.StoredProcedure

            commandbus.Parameters.AddWithValue("@mes", mes)
            commandbus.Parameters.AddWithValue("@año", año)
            commandbus.Parameters.AddWithValue("@usuario", LoginUsuario)

            'se declara variable para indicar cuantas polizas se generaron
            Dim PolizasGeneradas As String
            PolizasGeneradas = RTrim(commandbus.ExecuteScalar())

            MsgBox("Termino el Proceso de Generacion de Polizas, Se Generaron " + PolizasGeneradas + " Polizas.", vbInformation, "Sistema Contable")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class