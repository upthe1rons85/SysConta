Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools

Public Class clsInformePolizas
    Function SeleccionaListaPolizas() As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        'Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        Dim cmd As New SqlCommand("SELECT tipoPoliza,Tipomovimiento,Descripcion FROM conTipoMovPoliza (NOLOCK) order by descripcion", cnnConexion)
        cmd.Connection = cnnConexion
        dr = cmd.ExecuteReader()
        SeleccionaListaPolizas = dr
    End Function

End Class
