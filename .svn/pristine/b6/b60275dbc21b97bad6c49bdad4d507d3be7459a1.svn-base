Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient

Public Class clsCECOSDeptos
    Function SeleccionaDepartamento(ByVal pClasificacion As String, ByVal pArea_Depto As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelDeptos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCve_Clas", SqlDbType.VarChar).Value = pClasificacion
        cmd.Parameters.Add("@pArea_Depto", SqlDbType.VarChar).Value = pArea_Depto

        dr = cmd.ExecuteReader()
        SeleccionaDepartamento = dr
    End Function
    Sub EliminaDepartamentos(ByVal pClasificacion As String, ByVal pArea_Depto As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliDeptos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCve_Clas", SqlDbType.VarChar).Value = pClasificacion
        cmd.Parameters.Add("@pArea_Depto", SqlDbType.VarChar).Value = pArea_Depto

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Sub InsertaDepartamentos(ByVal pclasificacion As String, ByVal pArea_depto As String, ByVal pdescripcion As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsDeptos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pclasificacion", SqlDbType.VarChar).Value = pclasificacion
        cmd.Parameters.Add("@pArea_depto", SqlDbType.VarChar).Value = pArea_depto
        cmd.Parameters.Add("@pdescripcion", SqlDbType.VarChar).Value = pdescripcion

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function BuscaDescripcionDeptos(ByVal pdescripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusDescripcionDepto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = pdescripcion

        dr = cmd.ExecuteReader()
        BuscaDescripcionDeptos = dr
    End Function

    Sub ActualizaDescripcionDepto(ByVal pClasificacion As String, ByVal pAreaDepto As String, ByVal pDescripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spActDepto"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pClasificacion", SqlDbType.VarChar).Value = pClasificacion
        cmd.Parameters.Add("@pArea_Depto", SqlDbType.VarChar).Value = pAreaDepto
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

    Function SeleccionaDepartamentoLista() As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelDeptosLista"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        dr = cmd.ExecuteReader()
        SeleccionaDepartamentoLista = dr
    End Function
End Class
