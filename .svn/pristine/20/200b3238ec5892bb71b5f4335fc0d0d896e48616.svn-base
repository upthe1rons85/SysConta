Imports System.Data.SqlClient
Public Class frmInformeIva

    Private Sub frmInformeIva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtpFchIni.Value = Format(Now.Date, "01/MM/yyyy")
        cbxEstatus.Text = "<<Seleccionar>>"
        CargarBancos()
    End Sub

    Private Sub CargarBancos()

        Dim dr As SqlDataReader
        Dim oclsbancos As New clsBancos
        Dim dt As New DataTable
        dr = oclsbancos.SeleccionaBancosListaItem()

        dt.Load(dr)

        cbxBancos.ValueMember = Trim("codigo")
        cbxBancos.DisplayMember = Trim("Banco")
        cbxBancos.DataSource = dt

    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTInformeIVA()
        If cbxEstatus.Text = "<<Seleccionar>>" Then
            frm.nEstatus = 99
        Else
            frm.nEstatus = cbxEstatus.SelectedIndex
        End If
        If txtPolizaRec.Text = "" Then
            frm.nPoliza = 0
        Else
            frm.nPoliza = txtPolizaRec.Text
        End If
        frm.nBanco = cbxBancos.SelectedValue
        frm.fechafin = dtpFchFin.Value
        frm.fechainicio = dtpFchIni.Value
        frm.Show()
    End Sub
End Class