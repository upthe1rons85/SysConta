﻿Imports System.Data.SqlClient
Imports WindowsApplication1.clsBD
Public Class clsCierreEntrada

    Function SeleccionaListaOrdenCompra(ByVal nProveedor As String, ByVal OrdenCompra As String, ByVal FolEntrada As String, ByVal nTipo As Integer) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader


        cmd.CommandText = "sPBusEntradaEngorda"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
        cmd.Parameters.Add("@nProveedor", SqlDbType.VarChar).Value = nProveedor
        cmd.Parameters.Add("@OrdenCompra", SqlDbType.VarChar).Value = OrdenCompra
        cmd.Parameters.Add("@nEntrada", SqlDbType.VarChar).Value = FolEntrada
        cmd.Parameters.Add("@nTipo", SqlDbType.VarChar).Value = nTipo

        dr = cmd.ExecuteReader()
        SeleccionaListaOrdenCompra = dr
    End Function
    Function SeleccionaListaAnticiposPendientes(ByVal nFolio As String, ByVal FolAnti As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "sPCierreAnticipo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
        cmd.Parameters.Add("@nFolio", SqlDbType.VarChar).Value = nFolio
        cmd.Parameters.Add("@nFolioAnti", SqlDbType.VarChar).Value = FolAnti

        dr = cmd.ExecuteReader()
        SeleccionaListaAnticiposPendientes = dr
    End Function


End Class
