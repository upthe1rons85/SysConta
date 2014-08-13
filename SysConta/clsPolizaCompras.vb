Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsPolizaCompras
    Function BuscarPoliza(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "sp_BusPolizas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Poliza", SqlDbType.VarChar).Value = pcodigo
        dr = cmd.ExecuteReader()
        BuscarPoliza = dr
    End Function
End Class
