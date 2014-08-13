Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsParamtros
    Function ValorParametrosAdministrado(ByVal nParametro As Integer) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelValorParametroAdmin"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.VarChar).Value = 1
        cmd.Parameters.Add("@nParametro", SqlDbType.VarChar).Value = nParametro

        dr = cmd.ExecuteReader()
        ValorParametrosAdministrado = dr
    End Function
End Class
