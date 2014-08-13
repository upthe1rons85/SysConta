﻿Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Public Class frmSeleccionarImpresora
    Public ImpresoraSeleccionada As String
    Public Banco As Integer
    Public numcheque As Integer
    Public letra As String


    Private Sub frmSeleccionarImpresora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'For Each pr In Printers
        'cbxImpresoras.AddItem(pr.DeviceName)
        'Next
        ' 
        'Dim instance As New Printing.PrinterSettings
        'Dim impresosaPredt As String = instance.PrinterName
        'MsgBox(impresosaPredt)
        'ImpresoraSeleccionada = ""

        For Each impresora As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            cbxImpresoras.Items.Add(impresora)
        Next
        cbxImpresoras.Items.Add("PANTALLA")
        cbxImpresoras.Text = "Seleccionar impresora"
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If cbxImpresoras.Text = "PANTALLA" Then

            Dim frm As New frmRPTInformeCheque
            frm.Banco = Banco
            frm.FolioCheque = numcheque
            frm.ImporteLetra = letra
            frm.ShowDialog()

        Else

            ImpresoraSeleccionada = cbxImpresoras.Text
            Shell(String.Format("rundll32 printui.dll,PrintUIEntry /y /n ""{0}""", ImpresoraSeleccionada))
            Me.Close()

        End If
    End Sub

End Class