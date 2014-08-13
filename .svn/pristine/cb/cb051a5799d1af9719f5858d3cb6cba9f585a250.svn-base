Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.frmMovBancos
Public Class frmMovBancos_Transfer
    Public fecha As String
    Public CodigoProv As Integer
    Public NombreProv As String
    Public ImportePago As Decimal
    Public MetodoPago As String
    Public Banco As String
    Public NumeroTransfer As Integer
    Public TipoMoneda As String


    Private Sub frmMovBancos_Transfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblProveedor.Text = NombreProv
        lblCodigoPago.Text = CodigoProv
        lblTotalDocumento.Text = Format(CDec(ImportePago), "##,##0.00")
        txtTipoMoneda.Text = TipoMoneda

        If TipoMoneda = "DOLARES" Then
            lblCantidadLetra.Text = "(" & NumerosLetras_DLLS(Trim(lblTotalDocumento.Text), VbStrConv.ProperCase).ToUpper & ")"
        Else
            lblCantidadLetra.Text = "(" & NumerosLetras(Trim(lblTotalDocumento.Text), VbStrConv.ProperCase).ToUpper & ")"
        End If
        txtFecha.Text = fecha
        lblMetodoPago.Text = MetodoPago
        lblBanco.Text = Banco
        txtCheque.Text = Trim(NumeroTransfer)
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class