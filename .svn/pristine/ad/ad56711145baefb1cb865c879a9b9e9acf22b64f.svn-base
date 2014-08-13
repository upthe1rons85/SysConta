Imports System.Data.SqlClient
Public Class frmInformeHistorialCuenta
    Private Sub lstCuentas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCuentas.DoubleClick
        'For i As Integer = 0 To lstInforme.Items.Count - 1
        '    If lstInforme.Items(i).SubItems(0).Text = lstCuentas.SelectedItems(0).SubItems(0).Text _
        '       And lstInforme.Items(i).SubItems(1).Text = lstCuentas.SelectedItems(0).SubItems(1).Text Then
        '        MsgBox("Elemento ya se encuentra Agregado", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If
        'Next

        'Dim lstLista As New ListViewItem(lstCuentas.SelectedItems(0).SubItems(0).Text)
        'lstLista.SubItems.Add(lstCuentas.SelectedItems(0).SubItems(1).Text)
        'lstInforme.Items.Add(lstLista)
        lstCuentas.SelectedItems(0).Remove()
    End Sub

    Private Sub lstSeleccionada_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstInforme.DoubleClick
        'For i As Integer = 0 To lstCuentas.Items.Count - 1
        '    If lstCuentas.Items(i).SubItems(0).Text = lstInforme.SelectedItems(0).SubItems(0).Text _
        '       And lstCuentas.Items(i).SubItems(1).Text = lstInforme.SelectedItems(0).SubItems(1).Text Then
        '        MsgBox("Elemento ya se encuentra Agregado", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If
        'Next

        'Dim lstLista As New ListViewItem(lstInforme.SelectedItems(0).SubItems(0).Text)
        'lstLista.SubItems.Add(lstInforme.SelectedItems(0).SubItems(1).Text)
        'lstCuentas.Items.Add(lstLista)
        If lstCuentas.Items.Count > 0 Then
            Dim frmPoliza As New frmRPTPolizasManual
            frmPoliza.fecha = lstInforme.SelectedItems(0).SubItems(0).Text
            frmPoliza.folio = lstInforme.SelectedItems(0).SubItems(5).Text
            frmPoliza.tipoPoliza = lstInforme.SelectedItems(0).SubItems(6).Text

            frmPoliza.ShowDialog()
        End If

    End Sub

    Private Sub AgregarCuentaLista()
        Dim oclsInformePolizas As New clsCuentasContables
        Dim dr As SqlDataReader
        Dim dt = New DataTable()
        dr = oclsInformePolizas.BuscaContable(txtCuenta.Text)
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            'lstCuentas.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("cuenta").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                'lstLista.SubItems.Add(rRow("TipoMovimiento").ToString)
                lstCuentas.Items.Add(lstLista)
            Next
            txtCuenta.Text = ""
        Else
            MsgBox("No exixte cuenta contable " & txtCuenta.Text, MsgBoxStyle.Information, "Sistema Contabilidad")
        End If
    End Sub
    Private Sub AgregarCuentaListaInforme()
        Dim oclsInformePolizas As New clsCuentasContables
        Dim dr As SqlDataReader
        Dim dt = New DataTable()
        Dim TotalCuentas As String

        TotalCuentas = "0"
        For i As Integer = 0 To lstCuentas.Items.Count - 1
            TotalCuentas += "," + lstCuentas.Items(i).SubItems(0).Text
        Next

        dr = oclsInformePolizas.ObtenerHistorialCuentas(TotalCuentas, dtpFechaIni.Value.Date, dtpfechafin.Value.Date)
        dt.Load(dr)

        If dt.Rows.Count > 0 Then
            lstInforme.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("Fecha").ToString)
                lstLista.SubItems.Add(rRow("cuenta").ToString)
                lstLista.SubItems.Add(rRow("DescCuen").ToString)
                lstLista.SubItems.Add(Format(CDbl(rRow("cargo").ToString), "###,###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDbl(rRow("abono").ToString) * (-1), "###,###,###,##0.00"))
                lstLista.SubItems.Add(rRow("Poliza").ToString)
                lstLista.SubItems.Add(rRow("TipoPoliza").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstLista.SubItems.Add(rRow("tipoMovimiento").ToString)
                lstLista.SubItems.Add(rRow("Concepto").ToString)
                lstLista.SubItems.Add(rRow("Referencia").ToString)
                lstLista.SubItems.Add(rRow("NumeroLinea").ToString)
                lstInforme.Items.Add(lstLista)
            Next
            txtSumaCargo.Text = "0.00"
            txtSumaAbono.Text = "0.00"
            For i As Integer = 0 To lstInforme.Items.Count - 1
                txtSumaCargo.Text = Format((CDbl(txtSumaCargo.Text) + CDbl(lstInforme.Items(i).SubItems(3).Text)), "###,###,###,##0.00")
                txtSumaAbono.Text = Format(CDbl(txtSumaAbono.Text) + CDbl(lstInforme.Items(i).SubItems(4).Text), "###,###,###,##0.00")
            Next
            dr.Close()
            dt.Clear()
        End If

        dr = oclsInformePolizas.ObtenerHistorialCuentasSaldo(TotalCuentas, dtpFechaIni.Value.Date, dtpfechafin.Value.Date)
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstSaldos.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("cuenta").ToString)
                lstLista.SubItems.Add(Format(CDbl(rRow("saldo").ToString), "###,###,###,##0.00"))

                lstSaldos.Items.Add(lstLista)
            Next
            dr.Close()
        End If

    End Sub
    Private Sub frmInformeHistorialCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Not txtCuenta.Text = "" Then
            AgregarCuentaLista()

            bntCargar.Enabled = True
        End If

    End Sub

    Private Sub bntCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntCuenta.Click
        frmPolizasManuales_Cuentas.ShowDialog()
        txtCuenta.Text = VPCatCuentasPuente
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        lstCuentas.Items.Clear()
        lstInforme.Items.Clear()
        lstSaldos.Items.Clear()
        bntCargar.Enabled = False
    End Sub

    Private Sub bntCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntCargar.Click
        AgregarCuentaListaInforme()
    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            AgregarCuentaLista()
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If lstInforme.Items.Count > 0 Then
            Dim frm As New frmRPTInformeHistorialCuentas
            Dim TotalCuentas As String

            TotalCuentas = "0"
            For i As Integer = 0 To lstCuentas.Items.Count - 1
                TotalCuentas += "," + lstCuentas.Items(i).SubItems(0).Text
            Next
            TotalCuentas = Mid(TotalCuentas, 3, Len(TotalCuentas))
            frm.TotalCuentas = TotalCuentas
            frm.dFechaIni = dtpFechaIni.Value
            frm.dFechaFin = dtpfechafin.Value
            frm.ShowDialog()
        End If
    End Sub
End Class