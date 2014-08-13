Imports System.Data.SqlClient

Public Enum ConceptosNotaCreditoEnum
    concepto1 = 1
    Concepto2 = 2
    NCredito = 3
    NDebito = 4
End Enum

Public Class ClsNotaCredito
    Function SeleccionaCRFacturas(ByVal pCodProveedor As Integer, ByVal factura As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelFacturasNotaCred"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCodProveedor", SqlDbType.Int).Value = pCodProveedor
        cmd.Parameters.Add("@pfactura", SqlDbType.VarChar).Value = factura


        dr = cmd.ExecuteReader()
        SeleccionaCRFacturas = dr
    End Function

    Function SelCuentaProveedor(ByVal nFolio As Integer)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCuentaProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@nFolio", SqlDbType.Int).Value = nFolio


        dr = cmd.ExecuteReader()
        SelCuentaProveedor = dr
    End Function

    Function SeleccionaCuentasCR(ByVal nOpcion As Integer, ByVal nFolio As Integer)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelPolNotaCred"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion
        cmd.Parameters.Add("@nFolio", SqlDbType.VarChar).Value = nFolio

        dr = cmd.ExecuteReader()
        SeleccionaCuentasCR = dr
    End Function

    Function SeleccionarNC(ByVal nFolio As String, ByVal nOpcion As Integer) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelNotaCred"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion
        cmd.Parameters.Add("@nFolioContra", SqlDbType.Int).Value = nFolio

        dr = cmd.ExecuteReader()
        SeleccionarNC = dr
    End Function
    Sub CancelaNC(ByVal pFolio As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spCancelarNotaCred"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
        cmd.Parameters.Add("@nFolio", SqlDbType.Int).Value = pFolio

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function VerificaFacturaNotaCredito(ByVal pCodProveedor As String, ByVal pFacturaProveedor As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelExisteFacturaNC"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCodProveedor", SqlDbType.VarChar).Value = pCodProveedor
        cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = pFacturaProveedor

        dr = cmd.ExecuteReader()
        VerificaFacturaNotaCredito = dr
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
End Class
