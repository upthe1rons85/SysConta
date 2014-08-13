
Imports System.Data.SqlClient
Public Class clsProveedorCambioPrecio

    Function SeleccionaListaCotizacion(ByVal nOpcion As Integer, ByVal FolioCot As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelOCPrecio"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion
        cmd.Parameters.Add("@FolioCot", SqlDbType.VarChar).Value = FolioCot



        dr = cmd.ExecuteReader()
        SeleccionaListaCotizacion = dr
    End Function
End Class
