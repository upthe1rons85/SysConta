Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsTipocambio
    Function CargaFecha(ByVal pfecha As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spFechaTC"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = pfecha

        dr = cmd.ExecuteReader()
        CargaFecha = dr

    End Function
    Sub ValidaFecha(ByVal pfecha As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spValidaFechTCambio"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = pfecha

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaFecha(ByVal pDatos As String, ByVal pContraseña As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand


        cmd.CommandText = "spInsFechaTC"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@nFecha", SqlDbType.SmallDateTime).Value = pDatos
        'cmd.Parameters.Add("@nTipoCambio", SqlDbType.Decimal(18, 4)).Value = pContraseña
        cmd.Parameters.Add("@nTipoCaptacion", SqlDbType.Int).Value = pContraseña
        cmd.Parameters.Add("@nFechaModificacion", SqlDbType.SmallDateTime).Value = pContraseña
        cmd.Parameters.Add("@nUsuario", SqlDbType.VarChar, 15).Value = pContraseña

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)

    End Sub

    Function CargaTipoCambio(ByVal pfecha As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()


        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelTipoCambio"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = pfecha

        dr = cmd.ExecuteReader()
        CargaTipoCambio = dr
    End Function
End Class
