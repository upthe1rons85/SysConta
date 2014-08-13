Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Public Class frmInicializaSaldos
    Dim mes As String
    Dim año As String
    Dim Fecha As String
    Private Sub InicializaSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtpFecha.Value = Today
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
    End Sub
    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click
        txtAviso.Visible = True
        Fecha = Me.DtpFecha.Value.ToShortDateString
        mes = Month(Fecha)
        año = Year(Fecha)
        Fecha = Format(CDate(Fecha), "yyyyMMdd")
        BtnIniciar.Enabled = False
        Try
            
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()

            Dim commandbus As New SqlCommand("spCalcularSaldos", cnnConexion)
            commandbus.CommandType = CommandType.StoredProcedure

            commandbus.Parameters.AddWithValue("@mes", mes)
            commandbus.Parameters.AddWithValue("@año", año)
            commandbus.Parameters.AddWithValue("@fecha", Fecha)


            Dim Valida As Integer
            Valida = RTrim(commandbus.ExecuteScalar())
            If Valida > "0" Then

                MsgBox("No se ah Inicializado los saldos para este año " + año, vbCritical, "Sistema Contable")

            End If

            Dim commandbus2 As New SqlCommand("SPCalcularSaldoCECOS", cnnConexion)
            commandbus2.CommandType = CommandType.StoredProcedure
            commandbus2.Parameters.Add("@mes", SqlDbType.VarChar).Value = mes
            commandbus2.Parameters.Add("@anio", SqlDbType.VarChar).Value = año
            commandbus2.Parameters.Add("@fecha", SqlDbType.VarChar).Value = Fecha

            commandbus2.ExecuteScalar()


            MsgBox("Termino el Proceso de Calcular Saldos...", vbInformation, "Sistema Contable")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        txtAviso.Visible = False
        BtnIniciar.Enabled = True

    End Sub
End Class