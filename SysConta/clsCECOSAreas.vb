Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsCECOSAreas
    Function SeleccionaAreas(ByVal pClasificacion As String, ByVal pArea As String) ' As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelArea"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCve_Clas", SqlDbType.VarChar).Value = pClasificacion
        cmd.Parameters.Add("@pArea", SqlDbType.VarChar).Value = pArea

        dr = cmd.ExecuteReader()
        SeleccionaAreas = dr
    End Function
    Sub EliminaArea(ByVal pClasificacion As String, ByVal pArea As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliArea"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pCve_Clas", SqlDbType.VarChar).Value = pClasificacion
        cmd.Parameters.Add("@pArea", SqlDbType.VarChar).Value = pArea

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Sub InsertaArea(ByVal pClasificacion As String, ByVal pArea As String, ByVal pdescripcion As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsArea"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pClasificacion", SqlDbType.VarChar).Value = pClasificacion
        cmd.Parameters.Add("@pArea", SqlDbType.VarChar).Value = pArea
        cmd.Parameters.Add("@pDescripcion", SqlDbType.VarChar).Value = pdescripcion

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Function BuscaDescripcionArea(ByVal pdescripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusDescripcionArea"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = pdescripcion

        dr = cmd.ExecuteReader()
        BuscaDescripcionArea = dr
    End Function

    Sub ActualizaDescripcionArea(ByVal pClasificacion As String, ByVal pArea As String, ByVal pDescripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spActArea"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pClasificacion", SqlDbType.VarChar).Value = pClasificacion
        cmd.Parameters.Add("@pArea", SqlDbType.VarChar).Value = pArea
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
