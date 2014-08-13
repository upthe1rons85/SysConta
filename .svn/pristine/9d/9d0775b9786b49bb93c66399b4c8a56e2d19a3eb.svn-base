
Imports System.Data.SqlClient
Public Class clsBancos
    Function SeleccionaBancos(ByVal pcodigo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusBancos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCodigoBanco", SqlDbType.VarChar).Value = pcodigo

        dr = cmd.ExecuteReader()
        SeleccionaBancos = dr
    End Function
    Sub InsertaBancos(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsBancos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub EliminaBanco(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliBanco"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub AdelantaFolioBanco(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spAdeFolioBanco"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@FolioBanco", SqlDbType.NChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function BuscaNombreBanco(ByVal pNombre As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusNombreBanco"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = pNombre

        dr = cmd.ExecuteReader()
        BuscaNombreBanco = dr

    End Function
    Function ValidaCtaBancos(ByVal xCtaContaBanco As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spValidaCtaBancos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CtaBanco", SqlDbType.NVarChar).Value = xCtaContaBanco

        dr = cmd.ExecuteReader()
        ValidaCtaBancos = dr
    End Function
    Sub ActualizaTransferencia(ByVal pBancoOrigen As String, ByVal pBancoDestino As String, ByVal pSaldo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spBancoTransferencias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@BancoOrigen", SqlDbType.NVarChar, 35).Value = pBancoOrigen
        cmd.Parameters.Add("@BancoDestino", SqlDbType.NVarChar, 35).Value = pBancoDestino
        cmd.Parameters.Add("@Saldo", SqlDbType.Decimal, 18, 4).Value = pSaldo
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaListBancos(ByVal pBanco As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spBusListBancos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Banco", SqlDbType.NVarChar, 35).Value = pBanco
        dr = cmd.ExecuteReader()
        SeleccionaListBancos = dr
    End Function

    Function SeleccionaBancosListaItem()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "[spSelBancos]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        dr = cmd.ExecuteReader()
        SeleccionaBancosListaItem = dr
    End Function

    Function SeleccionaTipoMoneda(ByVal pMoneda As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spValidaTipoMoneda"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@TipoMoneda", SqlDbType.VarChar).Value = pMoneda

        dr = cmd.ExecuteReader()
        SeleccionaTipoMoneda = dr
    End Function
End Class
