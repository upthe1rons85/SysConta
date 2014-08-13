Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsImpresoras
    Sub InsertaImpresora(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsImpresoras"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub EliminaImpresora(ByVal pDatos As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliImpresora"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub ActualizaImpresora(ByVal cod As Integer, ByVal desc As String, ByVal model As String, ByVal FchX As String, ByVal FchY As String,
                           ByVal nomX As String, ByVal nomY As String, ByVal MnNumX As String, ByVal MnNumY As String,
                           ByVal MnLtrX As String, ByVal MnLtrY As String, ByVal ConcptX As String, ByVal ConcptY As String,
                           ByVal ConcptInfX As String, ByVal ConcptInfY As String, ByVal ConcptImpX As String, ByVal ConcptImpY As String,
                           ByVal PolizaX As String, ByVal PolizaY As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spActImpresora"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = cod
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = desc
        cmd.Parameters.Add("@Marca_Modelo", SqlDbType.VarChar).Value = model
        cmd.Parameters.Add("@FechaX", SqlDbType.NVarChar).Value = FchX
        cmd.Parameters.Add("@FechaY", SqlDbType.NVarChar).Value = FchY
        cmd.Parameters.Add("@NombreX", SqlDbType.NVarChar).Value = nomX
        cmd.Parameters.Add("@NombreY", SqlDbType.NVarChar).Value = nomY
        cmd.Parameters.Add("@MontoNumX", SqlDbType.NVarChar).Value = MnNumX
        cmd.Parameters.Add("@MontoNumY", SqlDbType.NVarChar).Value = MnNumY
        cmd.Parameters.Add("@MontoLtrX", SqlDbType.NVarChar).Value = MnLtrX
        cmd.Parameters.Add("@MontoLtrY", SqlDbType.NVarChar).Value = MnLtrY
        cmd.Parameters.Add("@ConceptoX", SqlDbType.NVarChar).Value = ConcptX
        cmd.Parameters.Add("@ConceptoY", SqlDbType.NVarChar).Value = ConcptY
        cmd.Parameters.Add("@ConceptoInfX", SqlDbType.NVarChar).Value = ConcptInfX
        cmd.Parameters.Add("@ConceptoInfY", SqlDbType.NVarChar).Value = ConcptInfY
        cmd.Parameters.Add("@ConceptoImpX", SqlDbType.NVarChar).Value = ConcptImpX
        cmd.Parameters.Add("@ConceptoImpY", SqlDbType.NVarChar).Value = ConcptImpY
        cmd.Parameters.Add("@PolizaX", SqlDbType.NVarChar).Value = PolizaX
        cmd.Parameters.Add("@PolizaY", SqlDbType.NVarChar).Value = PolizaY
        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Function BuscaNombreImpresora(ByVal pNombre As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusNombreImpresora"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = pNombre

        dr = cmd.ExecuteReader()
        BuscaNombreImpresora = dr

    End Function
End Class
