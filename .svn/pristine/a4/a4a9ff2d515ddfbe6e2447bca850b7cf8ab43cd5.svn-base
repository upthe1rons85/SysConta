Imports System.Data.SqlClient
Imports WindowsApplication1.clsBD
Public Class clsPolizasIVA
    Function SeleccionaChequesIVA()

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.Parameters.Clear()

        cmd.CommandText = "spSelDocumentoIVA"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        'cmd.Parameters.Add("@pBanco", SqlDbType.Int).Value = pBanco
        'cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = pFecha


        dr = cmd.ExecuteReader()
        SeleccionaChequesIVA = dr
    End Function
End Class
