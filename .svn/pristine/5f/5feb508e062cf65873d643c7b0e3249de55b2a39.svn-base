
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Public Class frmPerfilesUsuario

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
        'Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsUsuarios = New clsUsuarios()
        dr = oclsUsuarios.BuscaPerfil(Me.txtBuscar.Text)
        Dim dt = New DataTable()
        'txtBuscar.Focus()
        dt.Load(dr)
        lstPerfil.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Perfil").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstLista.SubItems.Add(rRow("Usuario").ToString)
            lstPerfil.Items.Add(lstLista)
        Next
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "select US.usuario,US.perfil,PER.Descripcion from contabilidad.dbo.usuarioperfil US inner join Contabilidad.dbo.perfiles PER on Per.perfil=US.Perfil where usuario=US.usuario union select US.usuario,US.perfil,PER.Descripcion from almacen.dbo.usuarioperfil US inner join almacen.dbo.perfiles PER on Per.perfil=US.Perfil where usuario=US.usuario union select US.usuario,US.perfil,PER.Descripcion from Compras.dbo.usuarioperfil US inner join Compras.dbo.perfiles PER on Per.perfil=US.Perfil where usuario=US.usuario union select US.usuario,US.perfil,PER.Descripcion from Comercial.dbo.usuarioperfil US inner join Comercial.dbo.perfiles PER on Per.perfil=US.Perfil where usuario=US.usuario order by Perfil asc "

        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "usuarioperfil,Perfiles")
        Dim objListItem As New ListViewItem
        Me.lstPerfil.Items.Clear()
        For Each drw As DataRow In ds.Tables("usuarioperfil,Perfiles").Rows
            objListItem = lstPerfil.Items.Add(drw.Item("Perfil").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("Usuario").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Private Sub frmPerfilesUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenalista2()
        MaximizeBox = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        llenalista2()
        txtBuscar.Text = "Buscar Perfil"
        txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75F, FontStyle.Italic)
    End Sub
    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.Text = ""
        txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtBuscar.ForeColor = Color.Gray
    End Sub
End Class