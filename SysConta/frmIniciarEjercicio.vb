Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Public Class frmIniciarEjercicio
    Dim año As String
    Private Sub frmIniciarEjercicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CbxAño.Text = 2014
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
    End Sub
    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click

        Try
            año = Me.CbxAño.SelectedItem
            'se validara que el año a Calcular saldos no este inicializado
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()

            Dim commandbus As New SqlCommand("spInicializaSaldos", cnnConexion)
            commandbus.CommandType = CommandType.StoredProcedure

            commandbus.Parameters.AddWithValue("@año", año)

            Dim Valida As Integer
            Valida = RTrim(commandbus.ExecuteScalar())
            If Valida > "0" Then
                MsgBox("Ya Se Tiene Cargado El Ejercicio Para Este Año Contable, Favor de Revisar", vbCritical, "Sistema Contable")
            Else
                MsgBox("Se Inicio Ejercicio Contable Para el Año " + año, vbInformation, "Sistema Contable")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class