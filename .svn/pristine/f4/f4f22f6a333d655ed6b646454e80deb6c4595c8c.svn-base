Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsCuentasNivel3
    Function SeleccionaNivel3(ByVal PCtaNivel3 As String, ByVal pCtaNivel2 As String, ByVal pCtaMayor As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCuentaNiv3"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCuentaNiv3", SqlDbType.VarChar).Value = PCtaNivel3
        cmd.Parameters.Add("@pCuentaNiv2", SqlDbType.VarChar).Value = pCtaNivel2
        cmd.Parameters.Add("@pCuentaMayor", SqlDbType.VarChar).Value = pCtaMayor

        dr = cmd.ExecuteReader()
        SeleccionaNivel3 = dr
    End Function
    Sub EliminaCuentaNiv3(ByVal pCtaNiv3 As String, ByVal pCtaNiv2 As String, ByVal pCtaMayor As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliCuentaNiv3"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@cuentaNiv3", SqlDbType.VarChar).Value = pCtaNiv3
        cmd.Parameters.Add("@cuentaNiv2", SqlDbType.VarChar).Value = pCtaNiv2
        cmd.Parameters.Add("@cuentaMayor", SqlDbType.VarChar).Value = pCtaMayor

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Sub InsertaCuentaNiv3(ByVal pDatos As String, ByVal pdatos2 As String, ByVal pdatos3 As String, ByVal pdatos4 As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsCuentaNiv3"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pCuentaMayor", SqlDbType.VarChar).Value = pDatos
        cmd.Parameters.Add("@pCuentaNivel2", SqlDbType.VarChar).Value = pdatos2
        cmd.Parameters.Add("@pCuentaNivel3", SqlDbType.VarChar).Value = pdatos3
        cmd.Parameters.Add("@pDescripcion", SqlDbType.VarChar).Value = pdatos4

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Function BuscaDescripcionCtaNiv3(ByVal pdescripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusDescripcionCtaNiv3"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = pdescripcion

        dr = cmd.ExecuteReader()
        BuscaDescripcionCtaNiv3 = dr
    End Function
    Sub ActualizaDescripcionNivel3(ByVal pCuentaMayor As String, ByVal pCtaNivel2 As String, ByVal pCtaNivel3 As String, ByVal pDescripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spActCuentaNiv3"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pCuentaMayor", SqlDbType.VarChar).Value = pCuentaMayor
        cmd.Parameters.Add("@pCuentaNiv2", SqlDbType.VarChar).Value = pCtaNivel2
        cmd.Parameters.Add("@pCuentaNiv3", SqlDbType.VarChar).Value = pCtaNivel3
        cmd.Parameters.Add("@pdescripcion", SqlDbType.VarChar).Value = pDescripcion

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
