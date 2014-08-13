Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsCuentasMayor
    Function SeleccionaCuentasMayor() As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCuentaMayor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        dr = cmd.ExecuteReader()
        SeleccionaCuentasMayor = dr
    End Function


    Sub InsertaCuentaMayor(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spInsCuentaMayor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)

    End Sub

End Class
