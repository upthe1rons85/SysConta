Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.frmInicializaSaldos
Public Class clsInicializaSaldos
    Sub CancelaEntrada(ByVal año As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInicializaSaldos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@año", SqlDbType.Int).Value = año

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        cnnConexion.Close()
    End Sub

End Class
