Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsProgramacionPago
    Function SeleccionaFolioSolCompra(ByVal pFolioSol As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelFolioSol"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFolioSol", SqlDbType.VarChar).Value = pFolioSol

        dr = cmd.ExecuteReader()
        SeleccionaFolioSolCompra = dr
    End Function

    Function SeleccionaContraRecibo(ByVal pContrarecibo As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCotProveedorCOTSOL"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFolioContraRecibo", SqlDbType.VarChar).Value = pContrarecibo


        dr = cmd.ExecuteReader()
        SeleccionaContraRecibo = dr
    End Function

    Function ExisteFolioContrarecibo(ByVal pContrarecibo As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spExisteFolioContraRecibo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFolioContraRecibo", SqlDbType.VarChar).Value = pContrarecibo

        dr = cmd.ExecuteReader()
        ExisteFolioContrarecibo = dr
    End Function
    Function SeleccionarTipoPoliza(ByVal Fol_Sol As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spTipoPolizaFlete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@nFolio", SqlDbType.Int).Value = Fol_Sol

        dr = cmd.ExecuteReader()
        SeleccionarTipoPoliza = dr
    End Function

    Function SeleccionaCotizacion(ByVal pSolicitud As String, ByVal pCotizacion As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCotizacion"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFolioSol", SqlDbType.VarChar).Value = pSolicitud
        cmd.Parameters.Add("@pFolioCot", SqlDbType.VarChar).Value = pCotizacion

        dr = cmd.ExecuteReader()
        SeleccionaCotizacion = dr
    End Function
    Function SeleccionaDetalleCotizacion(ByVal pSolicitud As String, ByVal pCotizacion As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelDetCotizacion"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFolioSol", SqlDbType.VarChar).Value = pSolicitud
        cmd.Parameters.Add("@pFolioCot", SqlDbType.VarChar).Value = pCotizacion

        dr = cmd.ExecuteReader()
        SeleccionaDetalleCotizacion = dr
    End Function
    Function SeleccionaCotProveedor(ByVal pcuentaProveedor As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCotProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCuentaProveedor", SqlDbType.VarChar).Value = pcuentaProveedor

        dr = cmd.ExecuteReader()
        SeleccionaCotProveedor = dr
    End Function
    Sub InsertaContrarecibo(ByVal pFolioContraRecibo As String, ByVal pFechaContra As String, ByVal pCodProveedor As String, ByVal pFechaRecepcion As String, ByVal pFacturaProveedor As String _
                                 , ByVal pFechaFactura As String, ByVal pFolioSol As String, ByVal pFolioCot As String, ByVal pSubtotal As String, ByVal pIVA As String _
                                 , ByVal pIVARetencion As String, ByVal pImporte As String, ByVal pEstatus As Integer, ByVal pUsuarioModificacion As String _
                                 , ByVal pPoliza As String, ByVal pObservaciones As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        'Dim transaction As SqlTransaction
        'transaction = cnnConexion.BeginTransaction
        Dim cmd As New SqlCommand
        'cmd.Transaction = transaction

        cmd.CommandText = "spInsProgramacionPago"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pFolioContraRecibo", SqlDbType.VarChar).Value = pFolioContraRecibo
        cmd.Parameters.Add("@pFechaContra", SqlDbType.VarChar).Value = pFechaContra
        cmd.Parameters.Add("@pCodProveedor", SqlDbType.VarChar).Value = pCodProveedor
        cmd.Parameters.Add("@pFechaRecepcion", SqlDbType.VarChar).Value = pFechaRecepcion
        cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = pFacturaProveedor
        cmd.Parameters.Add("@pFechaFactura", SqlDbType.VarChar).Value = pFechaFactura
        cmd.Parameters.Add("@pFolioSol", SqlDbType.VarChar).Value = pFolioSol
        cmd.Parameters.Add("@pFolioCot", SqlDbType.VarChar).Value = pFolioCot
        cmd.Parameters.Add("@pSubtotal", SqlDbType.VarChar).Value = pSubtotal
        cmd.Parameters.Add("@pIVA", SqlDbType.VarChar).Value = pIVA
        cmd.Parameters.Add("@pIVARetencion", SqlDbType.VarChar).Value = pIVARetencion
        cmd.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = pImporte
        cmd.Parameters.Add("@pEstatus", SqlDbType.VarChar).Value = pEstatus
        cmd.Parameters.Add("@pUsuarioModificacion", SqlDbType.VarChar).Value = pUsuarioModificacion
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = pPoliza
        cmd.Parameters.Add("@pObservaciones", SqlDbType.VarChar).Value = pObservaciones


        cmd.ExecuteNonQuery()


        'transaction.Rollback()


        'cmd.Dispose()
        'clsDB.CierraConexion(cnnConexion)
    End Sub

    Function SeleccionaCodigoProveedor(ByVal pCuenta As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCodigoProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCUENTA", SqlDbType.VarChar).Value = pCuenta

        dr = cmd.ExecuteReader()
        SeleccionaCodigoProveedor = dr
    End Function

    Function ValidarCuentaAnticipoProveedor(ByVal pCuenta As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spCuentaAnticipoProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
        cmd.Parameters.Add("@pCUENTA", SqlDbType.VarChar).Value = pCuenta

        dr = cmd.ExecuteReader()
        ValidarCuentaAnticipoProveedor = dr
    End Function
    Sub AdelantaFolioContrarecibo(ByVal pFolio As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "sp_AdeFolioContraRecibo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@FoliocontraRecibo", SqlDbType.Float).Value = pFolio

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        cnnConexion.Close()
    End Sub
    Function SeleccionaFechaRecepcion(ByVal pFolioSol As String, ByVal pFolioCot As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelFecRecepcionCOT"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFolioSol", SqlDbType.VarChar).Value = pFolioSol
        cmd.Parameters.Add("@pFolioCot", SqlDbType.VarChar).Value = pFolioCot

        dr = cmd.ExecuteReader()
        SeleccionaFechaRecepcion = dr
    End Function

    Sub InsertaObservacionContrarecibo(ByVal pFolio As Integer, ByVal pObservacion As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsObsContrarecibo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pFoliocontraRecibo", SqlDbType.VarChar).Value = pFolio
        cmd.Parameters.Add("@pObservaciones", SqlDbType.VarChar).Value = pObservacion

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        cnnConexion.Close()
    End Sub

    Function SeleccionaObservacionContraRecibo(ByVal pFolioContraRecibo As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelContraReciboObservacion"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFolioContraRecibo", SqlDbType.VarChar).Value = pFolioContraRecibo


        dr = cmd.ExecuteReader()
        SeleccionaObservacionContraRecibo = dr
    End Function
    Function SeleccionaFacturasContraRecibo(ByVal pFolioContraRecibo As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelContraRecibo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pContraRecibo", SqlDbType.VarChar).Value = pFolioContraRecibo

        dr = cmd.ExecuteReader()
        SeleccionaFacturasContraRecibo = dr
    End Function
    Sub CancelaContrarecibo(ByVal pFolioContraRecibo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliProgramacionPago"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pContraRecibo", SqlDbType.VarChar).Value = pFolioContraRecibo

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Function SeleccionaEstatusContraRecibo(ByVal pFolioContraRecibo As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelEstatusContraRecibo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFolioContraRecibo", SqlDbType.VarChar).Value = pFolioContraRecibo

        dr = cmd.ExecuteReader()
        SeleccionaEstatusContraRecibo = dr
    End Function

    Function VerificaFactura(ByVal pCodProveedor As String, ByVal pFacturaProveedor As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelExisteFactura"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCodProveedor", SqlDbType.VarChar).Value = pCodProveedor
        cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = pFacturaProveedor

        dr = cmd.ExecuteReader()
        VerificaFactura = dr
    End Function
End Class
