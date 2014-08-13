Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Public Class clsCECOSClasificacion
    Function SeleccionaCECOSClasificacion(ByVal pClasificacion As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCtasClasi"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCve_Clas", SqlDbType.VarChar).Value = pClasificacion

        dr = cmd.ExecuteReader()
        SeleccionaCECOSClasificacion = dr
    End Function


    Sub InsertaClasificacion(ByVal pClasificacion As String, ByVal pDescripcion As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsClasificacion"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pClasificacion", SqlDbType.VarChar).Value = pClasificacion
        cmd.Parameters.Add("@pDescripcion", SqlDbType.VarChar).Value = pDescripcion

        cmd.ExecuteNonQuery()

        cmd.Dispose()

        clsDB.CierraConexion(cnnConexion)

    End Sub
    Sub EliminaCECOSClasificacion(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spEliCtasClasi"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pcve_clas", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Function BuscaDescripcionCECOSClasifica(ByVal pdescripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusDescripcionClasificacion"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = pdescripcion

        dr = cmd.ExecuteReader()
        BuscaDescripcionCECOSClasifica = dr

    End Function
    Sub ActualizaDescripcionclasifica(ByVal pClasificacion As String, ByVal pDescripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spActClasificacion"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pClasificacion", SqlDbType.VarChar).Value = pClasificacion
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
