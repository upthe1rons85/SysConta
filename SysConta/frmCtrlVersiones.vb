Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class frmCtrlVersiones

    Private Sub frmCtrlVersiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarListaVersiones()
    End Sub

    Private Sub LlenarListaVersiones()
        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()

        cnnConexion = clsDB.CreaConexion()

        Dim wQuery As String = ""
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim dt = New DataTable()
        'Dim transaction As SqlTransaction


        wQuery = "SELECT TOP 50 CONVERT(CHAR(10), Fecha, 103)as Fecha,version,Modulo,descripcion,nombre from SysVersiones (NOLOCK) Order by Fecha DESC"
        cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
        cmd.CommandType = Data.CommandType.Text

        cmd.Connection = cnnConexion

        dr = cmd.ExecuteReader()
        dt.Load(dr)

        lstVersiones.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Fecha").ToString)
            lstLista.SubItems.Add(rRow("Version").ToString)
            lstLista.SubItems.Add(rRow("Modulo").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstLista.SubItems.Add(rRow("Nombre").ToString)
            lstVersiones.Items.Add(lstLista)
        Next
    End Sub
End Class