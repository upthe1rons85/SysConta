Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class ClsClientes
    Sub AdelantaFolioclie(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "sp_AdeFolioClie"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@FolioCliente", SqlDbType.NChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaCliente(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "sp_InsClientes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaClientes(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "sp_BusClientes"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCodigoCliente", SqlDbType.VarChar).Value = pcodigo

        dr = cmd.ExecuteReader()
        SeleccionaClientes = dr
    End Function
    Sub EliminaCliente(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "sp_EliCliente"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@CodigoCliente", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function BuscaRazonSocialCliente(ByVal prazonsocial As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusRazonSocialCliente"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Razonsocial", SqlDbType.VarChar).Value = prazonsocial

        dr = cmd.ExecuteReader()
        BuscaRazonSocialCliente = dr

    End Function
    Function RegresaDatosClie(ByVal pEstado As String, ByVal pciudad As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spRegresaDatosClie"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pEstado", SqlDbType.VarChar).Value = pEstado
        cmd.Parameters.Add("@pciudad", SqlDbType.VarChar).Value = pciudad
       
        dr = cmd.ExecuteReader()
        RegresaDatosClie = dr
    End Function
    Function RegresaEstatusCli(ByVal pEstatus As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr3 As SqlDataReader

        cmd.CommandText = "spRegresaEstatusCli"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pEstatus", SqlDbType.VarChar).Value = pEstatus

        dr3 = cmd.ExecuteReader()
        RegresaEstatusCli = dr3
    End Function
    Function RegresaFormaPago(ByVal pFormaPago As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spRegresaFormaPago"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFormaPago", SqlDbType.VarChar).Value = pFormaPago

        dr = cmd.ExecuteReader()
        RegresaFormaPago = dr
    End Function
End Class

