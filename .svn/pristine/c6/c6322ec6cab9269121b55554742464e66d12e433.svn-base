Imports System.Data.SqlClient
Public Class frmProgramacionPago_PendientePago

    Private Sub txtFolioSol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioSol.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTPendientesPagovb
        If txtFolioSol.Text = "" Then
            frm.FolSol = 0
        Else
            frm.FolSol = txtFolioSol.Text
        End If
        frm.FolCot = txtFolioCot.Text
        If cbxProveedores.SelectedValue = 0 Then
            frm.Proveedor = ""
        Else
            frm.Proveedor = cbxProveedores.SelectedValue
        End If

        frm.FechaIni = dtpFchIni.Value
        frm.FechaFin = dtpFchFin.Value
        frm.Show()
    End Sub

    Private Sub frmProgramacionPago_PendientePago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFchIni.Value = DateAdd(DateInterval.Month, -5, Now)
        MaximizeBox = False
        CargaProveedores()
    End Sub
    Private Sub CargaProveedores()
        Dim dr As SqlDataReader
        Dim oclsProveedor As New ClsProveedores
        Dim dt As New DataTable
        dr = oclsProveedor.SeleccionaProveedoresListaItem()

        dt.Load(dr)

        cbxProveedores.ValueMember = Trim("codigo")
        cbxProveedores.DisplayMember = Trim("proveedor")
        cbxProveedores.DataSource = dt

    End Sub

    Private Sub cbxProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxProveedores.SelectedIndexChanged

    End Sub
End Class