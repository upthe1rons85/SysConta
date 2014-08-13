Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsPolizasAjuste
    Function SeleccionaPolizaContable(ByVal pTipoPoliza As String, _
                                     ByVal pPoliza As String) As SqlDataReader

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelPolizaContableAjuste"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = pTipoPoliza
        cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = pPoliza

        dr = cmd.ExecuteReader()
        SeleccionaPolizaContable = dr
    End Function
    Function SeleccionaProveedores(ByVal nCuenta As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusProveedorPol"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = nCuenta

        dr = cmd.ExecuteReader()
        SeleccionaProveedores = dr
    End Function
    Function SeleccionaPoliza(ByVal nOpcion As Integer, ByVal OCEngorda As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusPolizaAjuste"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion
        cmd.Parameters.Add("@nFolio", SqlDbType.VarChar).Value = OCEngorda

        dr = cmd.ExecuteReader()
        SeleccionaPoliza = dr
    End Function
    Function UltimoFolio(ByVal nTipoPoliza As Integer) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spPolizaAjusteUltimoFolio"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@nTipoPoliza", SqlDbType.Int).Value = nTipoPoliza

        dr = cmd.ExecuteReader()
        UltimoFolio = dr
    End Function
End Class
