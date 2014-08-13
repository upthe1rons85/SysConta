Imports WindowsApplication1.clsTools
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.mdVariables
Public Class frmMesCerrado
    Dim n As String
    Dim mes As String
    Dim año As String
    Dim Fecha As String
    Private Sub frmMesCerrado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Cierre Ejercicio Mensual " + Space(1) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        llenalista2()
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        If cbxMes.Text = "" Or CbxAño.Text = "" Then
            MsgBox("No Deben Quedar Datos Vacios", vbInformation, "Sistema Contable")
        Else
            Fecha = "1/" & cbxMes.Text & "/" & CbxAño.Text & ""
            mes = Month(Fecha)
            año = Year(Fecha)
            Fecha = Format(CDate(Fecha), "yyyyMMdd")
            '-------------------------
            Dim yFecha As Date = "1/" & cbxMes.Text & "/" & CbxAño.Text & ""
            Dim nFecha As String = Format(yFecha, "1/M/yyyy")
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            Dim commandbus1 As New SqlCommand("spValidaMesCerrado2", cnnConexion)
            commandbus1.CommandType = CommandType.StoredProcedure
            commandbus1.Parameters.AddWithValue("@MesCerrado", nFecha)
            n = RTrim(commandbus1.ExecuteScalar())
            If MessageBox.Show("¿Esta Seguro que Desea Cerrar el Mes?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If n > "0" Then
                    Dim commandbus As New SqlCommand("spCierreMes", cnnConexion)
                    commandbus.CommandType = CommandType.StoredProcedure
                    commandbus.Parameters.AddWithValue("@MesCerrado", nFecha)
                    commandbus.Parameters.AddWithValue("@UsuarioActualizacion", LoginUsuario)
                    'commandbus.Parameters.AddWithValue("@MaquinaActualizacion", maquina)
                    n = RTrim(commandbus.ExecuteScalar())

                    '------// Inserta un 1 si el mes se cierra
                    Dim commandbus2 As New SqlCommand("spCierreMesTablas", cnnConexion)
                    commandbus2.CommandType = CommandType.StoredProcedure

                    commandbus2.Parameters.AddWithValue("@mes", mes)
                    commandbus2.Parameters.AddWithValue("@año", año)
                    commandbus2.ExecuteNonQuery()

                    '----- // Manda los saldos finales del mes que se cerro a el mes que sigue

                    Dim commandbus3 As New SqlCommand("spInsertCierreMesTablas", cnnConexion)
                    commandbus3.CommandType = CommandType.StoredProcedure

                    commandbus3.Parameters.AddWithValue("@mes", mes)
                    commandbus3.Parameters.AddWithValue("@año", año)
                    commandbus3.ExecuteNonQuery()

                    MsgBox("El Mes Fue Cerrado Correctamente", vbInformation, "Sistema Contable")
                Else
                    MsgBox("Ya Existe Mes Cerrado con la Fecha que Eligio, Revise Fecha nuevamente", vbInformation, "Sistema Contable")
                End If
            End If
            
        End If
        llenalista2()
    End Sub
    Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivar.Click
        If cbxMes.Text = "" Or CbxAño.Text = "" Then
            MsgBox("No Deben Quedar Datos Vacios", vbInformation, "Sistema Contable")
        Else
            Fecha = "1/" & cbxMes.Text & "/" & CbxAño.Text & ""
            mes = Month(Fecha)
            año = Year(Fecha)
            Fecha = Format(CDate(Fecha), "yyyyMMdd")
            '-------------------------
            Dim yFecha As Date = "1/" & cbxMes.Text & "/" & CbxAño.Text & ""
            Dim nFecha As String = Format(yFecha, "1/M/yyyy")
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            Dim commandbus1 As New SqlCommand("spValidaMesCerrado", cnnConexion)
            commandbus1.CommandType = CommandType.StoredProcedure
            commandbus1.Parameters.AddWithValue("@MesCerrado", nFecha)
            n = RTrim(commandbus1.ExecuteScalar())
            If MessageBox.Show("¿Esta Seguro que Desea Activar el Mes?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If n > "0" Then
                    Dim commandbus As New SqlCommand("spActivoMes", cnnConexion)
                    commandbus.CommandType = CommandType.StoredProcedure
                    commandbus.Parameters.AddWithValue("@MesActivo", nFecha)
                    commandbus.Parameters.AddWithValue("@UsuarioActualizacion", LoginUsuario)
                    'commandbus.Parameters.AddWithValue("@MaquinaActualizacion", maquina)
                    n = RTrim(commandbus.ExecuteScalar())
                    '------// Inserta un 0 si el mes se activa.
                    Dim commandbus2 As New SqlCommand("spActivoMesTablas", cnnConexion)
                    commandbus2.CommandType = CommandType.StoredProcedure

                    commandbus2.Parameters.AddWithValue("@mes", mes)
                    commandbus2.Parameters.AddWithValue("@año", año)
                    commandbus2.ExecuteNonQuery()
                    '---

                    MsgBox("El Mes Fue Activado Correctamente", vbInformation, "Sistema Contable")
                Else
                    MsgBox("No Existe Mes Cerrado con la Fecha que Eligio, Revise Fecha nuevamente", vbInformation, "Sistema Contable")
                End If
            End If
        End If
        llenalista2()
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from Contabilidad.Dbo.conMesCerrado(nolock) order by mesCerrado"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "conMesCerrado")
        Dim objListItem As New ListViewItem
        Me.listFecha.Items.Clear()
        For Each drw As DataRow In ds.Tables("conMesCerrado").Rows
            objListItem = listFecha.Items.Add(drw.Item("MesCerrado").ToString, 0)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
End Class