Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.frmMovBancos
Public Class frmMovBancos_Pago

    Public fecha As String
    Public CodigoProv As Integer
    Public NombreProv As String
    Public ImportePago As Decimal
    Public MetodoPago As String
    Public Banco As String
    Public NumeroCheque As Integer
    Public tipoMoneda As String



    'Dim wCheque As Integer
    'Dim wCodigo As Integer


    Private Sub frmMovBancos_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MaximizeBox = False
        lblProveedor.Text = NombreProv
        lblCodigoPago.Text = CodigoProv
        lblTotalDocumento.Text = Format(CDec(ImportePago), "##,##0.00")
        txtTipoMoneda.Text = Trim(tipoMoneda)

        If Trim(tipoMoneda) = "DOLARES" Then
            lblCantidadLetra.Text = "(" & NumerosLetras_DLLS(Trim(lblTotalDocumento.Text), VbStrConv.ProperCase).ToUpper & ")"
        Else
            lblCantidadLetra.Text = "(" & NumerosLetras(Trim(lblTotalDocumento.Text), VbStrConv.ProperCase).ToUpper & ")"
        End If
        txtFecha.Text = fecha
        lblMetodoPago.Text = MetodoPago
        lblBanco.Text = Banco
        txtCheque.Text = Trim(NumeroCheque)

    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim frm As New frmMovBancos
        'frm.Acepta = 1

        Me.Close()

    End Sub
End Class