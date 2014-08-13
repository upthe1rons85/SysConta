Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient

Public Class clsCuentasContables
    Function SeleccionaContable(ByVal PCtaContable As String, ByVal PCtaNivel3 As String, ByVal pCtaNivel2 As String, ByVal pCtaMayor As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelCuentaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCuentaMayor", SqlDbType.VarChar).Value = pCtaMayor
        cmd.Parameters.Add("@pCuentaNiv2", SqlDbType.VarChar).Value = pCtaNivel2
        cmd.Parameters.Add("@pCuentaNiv3", SqlDbType.VarChar).Value = PCtaNivel3
        cmd.Parameters.Add("@pCuentaContable", SqlDbType.VarChar).Value = PCtaContable

        dr = cmd.ExecuteReader()
        SeleccionaContable = dr
    End Function

    Function SeleccionaListaCuentas(ByVal nOpcion As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSeleccionarListaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@nOpcion", SqlDbType.VarChar).Value = nOpcion

        dr = cmd.ExecuteReader()
        SeleccionaListaCuentas = dr
    End Function
    Function BuscaContable(ByVal PCtaCompleta As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusCuentaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCuentaCompleta", SqlDbType.VarChar).Value = PCtaCompleta

        dr = cmd.ExecuteReader()
        BuscaContable = dr
    End Function

    Function ObtenerHistorialCuentas(ByVal PCtaCompleta As String, ByVal FechaIni As String, ByVal FechaFin As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spInformePolizasxCuenta"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCuentaCompleta", SqlDbType.VarChar).Value = PCtaCompleta
        cmd.Parameters.Add("@FechaIni", SqlDbType.VarChar).Value = FechaIni
        cmd.Parameters.Add("@FechaFin", SqlDbType.VarChar).Value = FechaFin

        dr = cmd.ExecuteReader()
        ObtenerHistorialCuentas = dr
    End Function
    Function ObtenerHistorialCuentasSaldo(ByVal PCtaCompleta As String, ByVal FechaIni As String, ByVal FechaFin As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spInformeCuentaSaldo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCuentaCompleta", SqlDbType.VarChar).Value = PCtaCompleta
        cmd.Parameters.Add("@FechaIni", SqlDbType.VarChar).Value = FechaIni
        cmd.Parameters.Add("@FechaFin", SqlDbType.VarChar).Value = FechaFin

        dr = cmd.ExecuteReader()
        ObtenerHistorialCuentasSaldo = dr
    End Function

    Sub EliminaCuentaContable(ByVal pCtaMayor As String, ByVal pCtaNiv2 As String, ByVal pCtaNiv3 As String, ByVal pCtaContable As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim pCuentacompleta As String

        pCuentacompleta = pCtaMayor + pCtaNiv2 + pCtaNiv3 + pCtaContable

        cmd.CommandText = "dbo.spEliCuentaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCuentacompleta", SqlDbType.VarChar).Value = pCuentacompleta
        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Sub InsertaCuentaContable(ByVal pCuenta As String, ByVal pDescripcion As String, ByVal pNaturaleza As String, ByVal pEstatus As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsCuentaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pCuenta", SqlDbType.VarChar).Value = pCuenta
        cmd.Parameters.Add("@pDescripcion", SqlDbType.VarChar).Value = pDescripcion
        cmd.Parameters.Add("@pNaturaleza", SqlDbType.VarChar).Value = pNaturaleza
        cmd.Parameters.Add("@pEstatus", SqlDbType.VarChar).Value = pEstatus

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub InsertaTablaSaldos(ByVal pCuenta As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsTablaSaldos"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pCuenta", SqlDbType.VarChar).Value = pCuenta
        'cmd.Parameters.Add("@año", SqlDbType.NChar).Value = pfecha

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Function BuscaDescripcionCtaContable(ByVal pdescripcion As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusDescripcionCtaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = pdescripcion

        dr = cmd.ExecuteReader()
        BuscaDescripcionCtaContable = dr
    End Function
    Function SeleccionaBuscarContable(ByVal PCtaContable As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusCuentaCtaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@CuentaCompleta", SqlDbType.VarChar).Value = PCtaContable

        dr = cmd.ExecuteReader()
        SeleccionaBuscarContable = dr
    End Function

    Function SeleccionaPerfil(ByVal p1 As String) As SqlDataReader
        Throw New NotImplementedException
    End Function

    Sub ActualizaDescripcionCtacontable(ByVal pCuentaCompleta As String, ByVal pDescripcion As String, ByVal pNaturaleza As String, ByVal pEstatus As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spActCuentaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@pCuentacompleta", SqlDbType.VarChar).Value = pCuentaCompleta
        cmd.Parameters.Add("@pdescripcion", SqlDbType.VarChar).Value = pDescripcion
        cmd.Parameters.Add("@pNaturaleza", SqlDbType.VarChar).Value = pNaturaleza
        cmd.Parameters.Add("@pEstatus", SqlDbType.VarChar).Value = pEstatus

        Try
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            clsDB.CierraConexion(cnnConexion)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
        End Try
    End Sub
    Function SeleccionaAyudaCtaContable(ByVal pCtaMayor As String, ByVal pCtaNivel2 As String, ByVal PCtaNivel3 As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelAyudaCtaContable"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pCuentaMayor", SqlDbType.VarChar).Value = pCtaMayor
        cmd.Parameters.Add("@pCuentaNiv2", SqlDbType.VarChar).Value = pCtaNivel2
        cmd.Parameters.Add("@pCuentaNiv3", SqlDbType.VarChar).Value = PCtaNivel3

        dr = cmd.ExecuteReader()
        SeleccionaAyudaCtaContable = dr
    End Function
End Class
