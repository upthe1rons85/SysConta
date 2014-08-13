Public Class frmRPTInfAjusteEntrada
    Public ocengorda As Integer
    Public folioentrada As Integer
    Public fechainicio As Date
    Public fechafin As Date
    Public codigoProveedor As Integer

    Private Sub frmRPTInfAjusteEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSInfAjusteEntrada.spinfAjusteEntradaCArgoAbono' Puede moverla o quitarla según sea necesario.
        Me.WindowState = FormWindowState.Maximized
        DSInfAjusteEntrada.EnforceConstraints = False
        If (fechainicio = Nothing) Then
            Me.spinfAjusteEntradaCArgoAbonoTableAdapter.Fill(Me.DSInfAjusteEntrada.spinfAjusteEntradaCArgoAbono, ocengorda, folioentrada, Nothing, Nothing, codigoProveedor)
        Else
            Me.spinfAjusteEntradaCArgoAbonoTableAdapter.Fill(Me.DSInfAjusteEntrada.spinfAjusteEntradaCArgoAbono, ocengorda, folioentrada, fechainicio.ToShortDateString(), fechafin.ToShortDateString(), codigoProveedor)
        End If


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class