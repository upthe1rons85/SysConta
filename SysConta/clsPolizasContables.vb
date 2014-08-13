Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsPolizasContables
    Sub InsertaPolizaContable(ByVal pFecha As String, ByVal pTipoMovimiento As String, ByVal pTipoPoliza As String, ByVal pPoliza As String, ByVal pCuenta As String _
                              , ByVal pImporte As Decimal, ByVal pCAR_ABO As String, ByVal pConcepto As String, ByVal pReferencia As String, ByVal pRefDocumento As String _
                              , ByVal pTipoMoneda As String, ByVal pEstatus As String, ByVal pUsuario As String _
                              , ByVal pNumeroLinea As String, ByVal pCECO As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsPolizaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = pFecha
        cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.VarChar).Value = pTipoMovimiento
        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = pTipoPoliza
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = pPoliza
        cmd.Parameters.Add("@pCuenta", SqlDbType.VarChar).Value = pCuenta
        cmd.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = pImporte
        cmd.Parameters.Add("@pCAR_ABO", SqlDbType.VarChar).Value = pCAR_ABO
        cmd.Parameters.Add("@pConcepto", SqlDbType.VarChar).Value = pConcepto
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = pReferencia
        cmd.Parameters.Add("@pRefDocumento", SqlDbType.VarChar).Value = pRefDocumento
        cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = pTipoMoneda
        cmd.Parameters.Add("@pEstatus", SqlDbType.VarChar).Value = pEstatus
        cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = pUsuario
        cmd.Parameters.Add("@pNumeroLinea", SqlDbType.VarChar).Value = pNumeroLinea
        cmd.Parameters.Add("@pCECO", SqlDbType.VarChar).Value = pCECO

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Function SeleccionaPolizaContable(ByVal pFecha As String, ByVal pTipoPoliza As String, _
                                      ByVal pPoliza As String) As SqlDataReader

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelPolizaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = pFecha
        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = pTipoPoliza
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = pPoliza

        dr = cmd.ExecuteReader()
        SeleccionaPolizaContable = dr
    End Function
    Sub EliminaPolizaContable(ByVal pFecha As String, ByVal pTipoPoliza As String, _
                                      ByVal pPoliza As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliPolizaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = pFecha
        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = pTipoPoliza
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = pPoliza

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Sub ActualizaPolizaContable(ByVal pFecha As String, ByVal pTipoMovimiento As String, ByVal pTipoPoliza As String, ByVal pPoliza As String, ByVal pCuenta As String _
                           , ByVal pImporte As Decimal, ByVal pCAR_ABO As String, ByVal pConcepto As String, ByVal pReferencia As String, ByVal pRefDocumento As String _
                           , ByVal pTipoMoneda As String, ByVal pEstatus As String, ByVal pUsuario As String _
                           , ByVal pNumeroLinea As String, ByVal pCECO As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spActPolizaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = pFecha
        cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.VarChar).Value = pTipoMovimiento
        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = pTipoPoliza
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = pPoliza
        cmd.Parameters.Add("@pCuenta", SqlDbType.VarChar).Value = pCuenta
        cmd.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = pImporte
        cmd.Parameters.Add("@pCAR_ABO", SqlDbType.VarChar).Value = pCAR_ABO
        cmd.Parameters.Add("@pConcepto", SqlDbType.VarChar).Value = pConcepto
        cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = pReferencia
        cmd.Parameters.Add("@pRefDocumento", SqlDbType.VarChar).Value = pRefDocumento
        cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = pTipoMoneda
        cmd.Parameters.Add("@pEstatus", SqlDbType.VarChar).Value = pEstatus
        cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = pUsuario
        'cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = "JOSUE.PRUEBA"
        cmd.Parameters.Add("@pNumeroLinea", SqlDbType.VarChar).Value = pNumeroLinea
        cmd.Parameters.Add("@pCECO", SqlDbType.VarChar).Value = pCECO

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaCuentasForzadas(ByVal pTipoPoliza As String) As SqlDataReader

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spValidaCuentaManual"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = pTipoPoliza
        'cmd.Parameters.Add("@pCuentaContable", SqlDbType.VarChar).Value = pCuentaContable


        dr = cmd.ExecuteReader()
        SeleccionaCuentasForzadas = dr
        'clsDB.CierraConexion(cnnConexion)
    End Function
    Function SeleccionaConsecutivo(ByVal pTipoPoliza As String) As SqlDataReader

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelFolioPolizaManual"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@TipoPoliza", SqlDbType.VarChar).Value = pTipoPoliza

        dr = cmd.ExecuteReader()
        SeleccionaConsecutivo = dr
        'clsDB.CierraConexion(cnnConexion)
    End Function

    Function BuscaTipoPoliza(ByVal tPoliza As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spBusTipoPoliza"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tPoliza
        dr = cmd.ExecuteReader()
        BuscaTipoPoliza = dr
    End Function

End Class
