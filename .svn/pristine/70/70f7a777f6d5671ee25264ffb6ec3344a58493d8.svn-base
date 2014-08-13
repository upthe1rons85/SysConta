Imports System.Data.SqlClient
Imports WindowsApplication1.clsBD
Public Class clsMovBancos
    Function SeleccionaCRFacturas(ByVal pCodProveedor As Integer, ByVal pFecha As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelFacturasCR"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCodProveedor", SqlDbType.Int).Value = pCodProveedor
        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = pFecha


        dr = cmd.ExecuteReader()
        SeleccionaCRFacturas = dr
    End Function

    Function SeleccionaCoordenadas(ByVal pBanco As Integer)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCoordenadasImp"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = pBanco

        dr = cmd.ExecuteReader()
        SeleccionaCoordenadas = dr
    End Function
    Function SeleccionaCheques(ByVal pBanco As Integer, ByVal pFecha As Integer)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCheques"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = pBanco
        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = pFecha


        dr = cmd.ExecuteReader()
        SeleccionaCheques = dr
    End Function

    Function SeleccionaChequesImpresion(ByVal pFolio As Integer)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelChequesIMP"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFolio", SqlDbType.Int).Value = pFolio

        dr = cmd.ExecuteReader()
        SeleccionaChequesImpresion = dr
    End Function

    Function SeleccionaChequesCancela(ByVal pFecha As String, ByVal pBanco As Integer, ByVal pCheque As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelChequesCancela"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = pFecha
        cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = pBanco
        cmd.Parameters.Add("@pCheque", SqlDbType.VarChar).Value = pCheque

        dr = cmd.ExecuteReader()
        SeleccionaChequesCancela = dr
    End Function
    Sub CancelaCheque(ByVal pFolio As Integer, ByVal pBanco As Integer, ByVal pCheque As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spCancelaCheques"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion


        cmd.Parameters.Add("@pFolio", SqlDbType.VarChar).Value = pFolio
        cmd.Parameters.Add("@pBanco", SqlDbType.VarChar).Value = pBanco
        cmd.Parameters.Add("@pCheque", SqlDbType.VarChar).Value = pCheque

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaChequesImprimeContinuo(ByVal pBanco As Integer, ByVal pFolioCheque As Integer, ByVal pImporteLetras As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spInformeCheque"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = pBanco
        cmd.Parameters.Add("@pfolioCheque", SqlDbType.VarChar).Value = pFolioCheque
        cmd.Parameters.Add("@pImporteLetras", SqlDbType.VarChar).Value = pImporteLetras

        dr = cmd.ExecuteReader()
        SeleccionaChequesImprimeContinuo = dr
    End Function

    Function SeleccionaPolizaImprimir(ByVal pTipopoliza As Integer, ByVal pPoliza As Integer, ByVal pLinea As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelPolizaImpresionCoordenadas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipopoliza", SqlDbType.Int).Value = pTipopoliza
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = pPoliza
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = pLinea

        dr = cmd.ExecuteReader()
        SeleccionaPolizaImprimir = dr
    End Function

    Function SeleccionaPolizaPrevia(ByVal pBanco As Integer, ByVal pCheque As Integer)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelPrevioPolizaCheque"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.Int).Value = pBanco
        cmd.Parameters.Add("@pfolio", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pFechaMovimiento", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pCodigoBanco", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pNumerocheque", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pCodigoProveedor", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pFolioContraRecibo", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pSubtotal", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pIVA", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pIVA11", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pIVAIMP", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pIVARetHon", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pIVARetArr", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pIvaRet4", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pISRHon", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pISRArr", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pIEPS", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pTotal", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pEstatus", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pUsuario", SqlDbType.Int).Value = pCheque
        cmd.Parameters.Add("@pMoneda", SqlDbType.Int).Value = pCheque

        dr = cmd.ExecuteReader()
        SeleccionaPolizaPrevia = dr
    End Function

    Function SeleccionaListaChequesHitorico(ByVal nBanco, ByVal nCheque, ByVal nProveedor) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "sPMovimientoBanco_HistoricoCheque"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 2
        cmd.Parameters.Add("@nBanco", SqlDbType.Int).Value = nBanco
        cmd.Parameters.Add("@nCheque", SqlDbType.Int).Value = nCheque
        cmd.Parameters.Add("@nProveedor", SqlDbType.Int).Value = nProveedor

        dr = cmd.ExecuteReader()
        SeleccionaListaChequesHitorico = dr
    End Function
    Function SeleccionaListaChequesHitoricoCRecibo(ByVal nFolio) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "sPMovimientoBanco_HistoricoChequeCRecibo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
        cmd.Parameters.Add("@nFolio", SqlDbType.Int).Value = nFolio

        dr = cmd.ExecuteReader()
        SeleccionaListaChequesHitoricoCRecibo = dr
    End Function

    Function SeleccionaListaChequesHitoricoPoliza(ByVal nPoliza, ByVal nTipoPoliza) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "sPMovimientoBanco_HistoricoChequePoliza"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
        cmd.Parameters.Add("@nPoliza", SqlDbType.Int).Value = nPoliza
        cmd.Parameters.Add("@nTipoPoliza", SqlDbType.Int).Value = nTipoPoliza


        dr = cmd.ExecuteReader()
        SeleccionaListaChequesHitoricoPoliza = dr
    End Function

    Function SeleccionaTransferencias(ByVal pBanco As Integer, ByVal pFecha As Integer)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelTransFerencias"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = pBanco
        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = pFecha


        dr = cmd.ExecuteReader()
        SeleccionaTransferencias = dr
    End Function

    Sub CancelaTransferencia(ByVal pFolio As Integer, ByVal pBanco As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spCancelaTransferencia"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion


        cmd.Parameters.Add("@pFolio", SqlDbType.VarChar).Value = pFolio
        cmd.Parameters.Add("@pBanco", SqlDbType.VarChar).Value = pBanco

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaCuentasIVA()

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCuentasIVA"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        dr = cmd.ExecuteReader()
        SeleccionaCuentasIVA = dr
    End Function
End Class
