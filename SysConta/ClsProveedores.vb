Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class ClsProveedores
    Function SeleccionaProveedores(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spbusproveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = pcodigo

        dr = cmd.ExecuteReader()
        SeleccionaProveedores = dr
    End Function
    Sub InsertaProveedor(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)

    End Sub
    Sub EliminaProveedor(ByVal pDatos As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub AdelantaFolioprov(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spAdeFolioProv"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@folioproveedor", SqlDbType.NChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)

    End Sub
    Function BuscaNombreProveedor(ByVal pNombreProv As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusNombreProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@NombreProv", SqlDbType.VarChar).Value = pNombreProv

        dr = cmd.ExecuteReader()
        BuscaNombreProveedor = dr
    End Function
    Function ValidaCtaProv(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spValidaCtaProv"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CuentaConta", SqlDbType.NVarChar).Value = pcodigo

        dr = cmd.ExecuteReader()
        ValidaCtaProv = dr
    End Function
    Function SeleccionaProveedoresListaItem()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        dr = cmd.ExecuteReader()
        SeleccionaProveedoresListaItem = dr
    End Function
    Function SelCtaAnticipo(ByVal pcuenta As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusCtaAnticipo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pcuenta", SqlDbType.VarChar).Value = pcuenta

        dr = cmd.ExecuteReader()
        SelCtaAnticipo = dr
    End Function
End Class
