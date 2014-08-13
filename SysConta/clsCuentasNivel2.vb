Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsCuentasNivel2
    Function SeleccionaNivel2(ByVal pCtaNivel2 As String, ByVal pCtaMayor As String) ' As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCuentaNivel2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCuentaNivel2", SqlDbType.VarChar).Value = pCtaNivel2
        cmd.Parameters.Add("@pCuentaMayor", SqlDbType.VarChar).Value = pCtaMayor


        dr = cmd.ExecuteReader()
        SeleccionaNivel2 = dr
    End Function
    Sub EliminaCuentaNiv2(ByVal pCtaMayor As String, ByVal pCtaNiv2 As String, ByVal pCtaNiv3 As String, ByVal pCtaNiv4 As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliCuentaNiv2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@cuentaMayor", SqlDbType.VarChar).Value = pCtaMayor
        cmd.Parameters.Add("@cuentaNiv2", SqlDbType.VarChar).Value = pCtaNiv2

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Sub InsertaCuentaNiv2(ByVal pDatos As String, ByVal pdatos2 As String, ByVal pdatos3 As String, ByVal pdatos4 As String, ByVal pdatos5 As String, ByVal pdatos6 As String, ByVal pdatos7 As String, ByVal pdatos8 As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsCuentaNiv2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pCuentaMayor", SqlDbType.VarChar).Value = pDatos
        cmd.Parameters.Add("@pCuentaNivel2", SqlDbType.VarChar).Value = pdatos2
        cmd.Parameters.Add("@pDescripcion", SqlDbType.VarChar).Value = pdatos3
        cmd.Parameters.Add("@pDepreciacion", SqlDbType.VarChar).Value = pdatos4
        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = pdatos5
        cmd.Parameters.Add("@TasaDepreciacion", SqlDbType.VarChar).Value = pdatos6
        cmd.Parameters.Add("@cuenta", SqlDbType.VarChar).Value = pdatos7
        cmd.Parameters.Add("@idActivo", SqlDbType.VarChar).Value = pdatos8
        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    'Sub InsertaDepreciacion(ByVal pdatos2 As String, ByVal pdatos3 As String, ByVal pdatos4 As String)
    '    Dim cnnConexion = New SqlConnection()
    '    Dim clsDB = New clsBD()
    '    cnnConexion = clsDB.CreaConexion()

    '    Dim cmd As New SqlCommand

    '    cmd.CommandText = "spInserCuentaNiv2"
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Connection = cnnConexion

    '    'cmd.Parameters.Add("@IdActivo", SqlDbType.NVarChar).Value = pDatos
    '    cmd.Parameters.Add("@Cuenta", SqlDbType.NVarChar).Value = pdatos2
    '    cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = pdatos3
    '    cmd.Parameters.Add("@TasaDepreciacion", SqlDbType.NVarChar).Value = pdatos4

    '    cmd.ExecuteNonQuery()

    '    cmd.Dispose()
    '    clsDB.CierraConexion(cnnConexion)
    'End Sub
    Function BuscaDescripcionCtaNiv2(ByVal pCuentaMayor As String, ByVal pdescripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusDescripcionCtaNiv2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CuentaMayor", SqlDbType.VarChar).Value = pCuentaMayor
        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = pdescripcion

        dr = cmd.ExecuteReader()
        BuscaDescripcionCtaNiv2 = dr
    End Function

    Sub ActualizaDescripcionCtaNivel2(ByVal pCuentaMayor As String, ByVal pCtaNivel2 As String, ByVal pDescripcion As String, ByVal pDepreciacion As String, ByVal pTasaDepreciacion As String, ByVal pDesc As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spActCuentaNiv2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pCuentaMayor", SqlDbType.VarChar).Value = pCuentaMayor
        cmd.Parameters.Add("@pCuentaNiv2", SqlDbType.VarChar).Value = pCtaNivel2
        cmd.Parameters.Add("@pdescripcion", SqlDbType.VarChar).Value = pDescripcion
        cmd.Parameters.Add("@pDepreciacion", SqlDbType.VarChar).Value = pDepreciacion
        cmd.Parameters.Add("@TasaDepreciacion", SqlDbType.NVarChar).Value = pTasaDepreciacion
        cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = pDesc

        Try
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            clsDB.CierraConexion(cnnConexion)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
        End Try
    End Sub
End Class