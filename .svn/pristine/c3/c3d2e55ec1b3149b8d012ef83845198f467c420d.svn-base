Imports WindowsApplication1.frmProgramacionPago
Imports WindowsApplication1.clsTools
Imports System.Data.SqlClient

Public Class frmProgramacionPago_FacProv
    Public fechaProv As String
    Public facturaProv As String
    Public UnidadesProv As Decimal
    Public subtotalProv As Decimal
    Public IvaProv As Decimal
    Public IvaProv11 As Decimal
    Public IVAImp As Decimal
    Public Ret4 As Decimal
    Public Ret10Hono As Decimal
    Public Ret10Arrenda As Decimal
    Public ISRHono As Decimal
    Public ISRArrenda As Decimal
    Public IEPS As Decimal
    Public TipoCambio As Decimal
    Public Descuento As Decimal
    Public CuentaDescuento As String

    Public TotalProv As Decimal
    Private Sub frmProgramacionPago_FacProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCtaTipoDescuento()
        CargarRangoTotalFactura()
    End Sub
    Private Sub CargarRangoTotalFactura()
        Dim oclsParametrosAdministrados = New clsParamtros()
        Dim dr As SqlDataReader
        Dim nParametro As Integer
        nParametro = 1
        dr = oclsParametrosAdministrados.ValorParametrosAdministrado(nParametro)

        If dr.Read Then
            txtRango.Text = Format(CDbl(dr("VALOR").ToString()), "###.#0")
        End If
    End Sub
    Public Sub NuevoFactura()
        txtFacturaProv.Text = ""
        txtUnidadesProv.Text = ""
        txtSubtotalProv.Text = "0.00"
        txtIVAProv.Text = "0.00"
        txtIVAProv11.Text = "0.00"
        txtIVAImp.Text = "0.00"
        txtRet4.Text = "0.00"
        txtIVARetArrenda.Text = "0.00"
        txtIVARetHono.Text = "0.00"
        txtISRHono.Text = "0.00"
        txtISRArrenda.Text = "0.00"
        txtIEPS.Text = "0.00"
        txtTotalProv.Text = "0.00"
        txtDescuentos.Text = "0.00"
        dtpFechaFactura.Value = Today
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtFacturaProv.Text = "" Or
            txtUnidadesProv.Text = "" Or
            txtSubtotalProv.Text = "" Or
            txtIVAProv.Text = "" Or
            txtIVAProv11.Text = "" Or
            txtIVAImp.Text = "" Or
            txtRet4.Text = "" Or
            txtIVARetHono.Text = "" Or
            txtIVARetArrenda.Text = "" Or
            txtISRHono.Text = "" Or
            txtISRArrenda.Text = "" Or
            txtIEPS.Text = "" Or
            txtTotalProv.Text = "" Then
            MsgBox("Favor de Completar todos los campos", MsgBoxStyle.Exclamation)
        Else
            'Dim frm As New frmProgramacionPago
            If (frmTipoMoneda.Visible = True And rdDlls.Checked = True And txtTipoCambio.Text = "0.00") Then
                MsgBox("Favor de Insertar el tipo de cambio", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtDescuentos.Text > 0 And Trim(cbxTipoDescuento.SelectedValue) = "0" Then
                MsgBox("No se ah Seleccionado el tipo de descuento", MsgBoxStyle.Critical, "Sistema Contable")
                Exit Sub
            End If

            fechaProv = Format(Me.dtpFechaFactura.Value, "dd/MM/yyyy")
            facturaProv = Me.txtFacturaProv.Text
            UnidadesProv = CDec(Me.txtUnidadesProv.Text)
            subtotalProv = Me.txtSubtotalProv.Text
            IvaProv = Me.txtIVAProv.Text
            IvaProv11 = Me.txtIVAProv11.Text ''agregado
            IVAImp = Me.txtIVAImp.Text ''agregado
            Ret4 = Me.txtRet4.Text
            Ret10Hono = Me.txtIVARetHono.Text
            Ret10Arrenda = Me.txtIVARetArrenda.Text ''agregado
            ISRHono = Me.txtISRHono.Text
            ISRArrenda = Me.txtISRArrenda.Text ''agregado
            IEPS = Me.txtIEPS.Text
            TotalProv = Me.txtTotalProv.Text
            TipoCambio = Me.txtTipoCambio.Text
            Descuento = Me.txtDescuentos.Text
            CuentaDescuento = Me.cbxTipoDescuento.SelectedValue

                Me.Close()


        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtFacturaProv.Text = ""
        txtUnidadesProv.Text = ""
        txtSubtotalProv.Text = "0.00"
        txtIVAProv.Text = "0.00"
        txtIVAProv11.Text = "0.00"
        txtIVAImp.Text = "0.00"
        txtRet4.Text = "0.00"
        txtIVARetArrenda.Text = "0.00"
        txtIVARetHono.Text = "0.00"
        txtISRHono.Text = "0.00"
        txtISRArrenda.Text = "0.00"
        txtIEPS.Text = "0.00"
        txtTotalProv.Text = "0.00"
        dtpFechaFactura.Value = Today
        'frmProgramacionPago.IvaProv = 0.0
        TotalProv = 0.0
        Me.Close()
    End Sub

    Private Sub SumaTotalFactura()
        Dim SumaTotal As Double
        SumaTotal = 0
        txtTotalProv.Text = 0.0
        SumaTotal = SumaTotal + CDbl(txtSubtotalProv.Text)
        SumaTotal = SumaTotal + CDbl(txtIVAProv.Text)
        SumaTotal = SumaTotal + CDbl(txtIVAProv11.Text)
        SumaTotal = SumaTotal + CDbl(txtIVAImp.Text)
        SumaTotal = SumaTotal - CDbl(txtRet4.Text)
        SumaTotal = SumaTotal - CDbl(txtIVARetArrenda.Text)
        SumaTotal = SumaTotal - CDbl(txtIVARetHono.Text)
        SumaTotal = SumaTotal - CDbl(txtISRHono.Text)
        SumaTotal = SumaTotal - CDbl(txtISRArrenda.Text)
        SumaTotal = SumaTotal + CDbl(txtIEPS.Text)
        'SumaTotal = SumaTotal + CDbl(txtDescuentos.Text)
        SumaTotal = SumaTotal + CDbl(txtTotalProv.Text)

        txtTotalProv.Text = Format(SumaTotal, "###,###,###.00")
        txtTotalOC.Text = CDbl(txtTotalProv.Text) + CDbl(txtDescuentos.Text) + CDbl(txtDescuentos.Text * (0.16))
        txtTotalOC.Text = Format(CDbl(txtTotalOC.Text), "###,###,###.00")

    End Sub

    Private Sub txtUnidadesProv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidadesProv.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtUnidadesProv.Text = "" Then
            End If

            txtSubtotalProv.Focus()
        End If

    End Sub

    Private Sub txtIVAProv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVAProv.Click
        txtIVAProv.SelectAll()
    End Sub

    Private Sub txtIVAProv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVAProv.DoubleClick
        txtIVAProv.Text = CDbl(txtSubtotalProv.Text) * (0.16)
        txtIVAProv.Text = Format(CDec(txtIVAProv.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtIVAProv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVAProv.GotFocus
        txtIVAProv.SelectAll()
    End Sub

    Private Sub txtIVAProv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVAProv.KeyPress
        Dim i As Integer
        i = InStr(txtIVAProv.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtIVAProv.Text = "" Then
                txtIVAProv.Text = "0.00"
            End If
            txtIVAProv.Text = Format(CDec(txtIVAProv.Text), "##,##0.00")
            txtIVAProv11.Focus()

        End If

    End Sub

    Private Sub txtTotalProv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalProv.Click
        txtTotalProv.SelectAll()
    End Sub

    Private Sub txtTotalProv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalProv.GotFocus
        txtTotalProv.SelectAll()
    End Sub

    Private Sub txtTotalProv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalProv.KeyPress


        If e.KeyChar = "+" Then
            txtSubtotalProv.Text = CDbl(txtSubtotalProv.Text) + "0.01"
            txtSubtotalProv.Text = Format(CDbl(txtSubtotalProv.Text), "###,###,###.00")
        Else
            If e.KeyChar = "-" Then
                txtSubtotalProv.Text = CDbl(txtSubtotalProv.Text) - "0.01"
                txtSubtotalProv.Text = Format(CDbl(txtSubtotalProv.Text), "###,###,###.00")
            Else
                If e.KeyChar = ChrW(Keys.Enter) Then
                    e.Handled = True
                    If txtTotalProv.Text = "" Then
                        txtTotalProv.Text = "0.00"
                    End If
                    txtTotalProv.Text = Format(CDec(txtTotalProv.Text), "##,##0.00")
                    btnAceptar.Focus()
                Else
                    MsgBox("Para modificar el importe de total favor de utilizar las Teclas + para agregar 0.01 o la Tecla de - para quitar, esto afectara al campo de subtotal", MsgBoxStyle.Information)
                End If

            End If
        End If


        e.Handled = True
        'If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
        SumaTotalFactura()
    End Sub

    Private Sub txtSubtotalProv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubtotalProv.Click
        txtSubtotalProv.SelectAll()
    End Sub

    Private Sub txtSubtotalProv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubtotalProv.GotFocus
        txtSubtotalProv.SelectAll()
    End Sub

    Private Sub txtSubtotalProv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubtotalProv.KeyPress
        Dim i As Integer
        i = InStr(txtSubtotalProv.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtSubtotalProv.Text = "" Then
                txtSubtotalProv.Text = "0.00"
            End If
            txtSubtotalProv.Text = Format(CDec(txtSubtotalProv.Text), "##,##0.00")
            txtIVAProv.Focus()
        End If
    End Sub

    Private Sub dtpFechaFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaFactura.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtFacturaProv.Focus()
        End If
    End Sub

    Private Sub txtFacturaProv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFacturaProv.Click
        txtFacturaProv.SelectAll()
    End Sub

    Private Sub txtFacturaProv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFacturaProv.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtUnidadesProv.Focus()
        End If
    End Sub

    Private Sub txtRet4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRet4.Click
        txtRet4.SelectAll()
    End Sub

    Private Sub txtRet4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRet4.DoubleClick
        txtRet4.Text = CDbl(txtSubtotalProv.Text) * (0.04)
        txtRet4.Text = Format(CDec(txtRet4.Text), "##,##0.00")
    End Sub

    Private Sub txtRet4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRet4.GotFocus
        txtRet4.SelectAll()
    End Sub

    Private Sub txtRet4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRet4.KeyPress
        Dim i As Integer
        i = InStr(txtRet4.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtRet4.Text = "" Then
                txtRet4.Text = "0.00"
            End If
            txtRet4.Text = Format(CDec(txtRet4.Text), "##,##0.00")
            txtISRHono.Focus()

        End If

    End Sub

    Private Sub txtIVARetHono_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVARetHono.Click
        txtIVARetHono.SelectAll()
    End Sub

    Private Sub txtIVARetHono_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVARetHono.DoubleClick
        txtIVARetHono.Text = CDbl(txtSubtotalProv.Text) * (0.106666)
        txtIVARetHono.Text = Format(CDec(txtIVARetHono.Text), "##,##0.00")
        txtISRHono.Text = CDbl(txtSubtotalProv.Text) * (0.1)
        txtISRHono.Text = Format(CDec(txtISRHono.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtRet10_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVARetHono.GotFocus
        txtIVARetHono.SelectAll()

    End Sub


    Private Sub txtRet10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVARetHono.KeyPress
        Dim i As Integer
        i = InStr(txtIVARetHono.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtIVARetHono.Text = "" Then
                txtIVARetHono.Text = "0.00"
            End If
            txtIVARetHono.Text = Format(CDec(txtIVARetHono.Text), "##,##0.00")
            txtIVARetArrenda.Focus()

        End If

    End Sub

    Private Sub txtISRHono_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtISRHono.Click
        txtISRHono.SelectAll()
    End Sub

    Private Sub txtISR_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtISRHono.GotFocus
        txtISRHono.SelectAll()

    End Sub

    Private Sub txtISR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtISRHono.KeyPress
        Dim i As Integer
        i = InStr(txtISRHono.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtISRHono.Text = "" Then
                txtISRHono.Text = "0.00"
            End If
            txtISRHono.Text = Format(CDec(txtISRHono.Text), "##,##0.00")
            txtISRArrenda.Focus()

        End If

    End Sub

    Private Sub txtIEPS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIEPS.Click
        txtIEPS.SelectAll()
    End Sub

    Private Sub txtIEPS_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIEPS.GotFocus
        txtIEPS.SelectAll()

    End Sub

    Private Sub txtIEPS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIEPS.KeyPress
        Dim i As Integer
        i = InStr(txtIEPS.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtIEPS.Text = "" Then
                txtIEPS.Text = "0.00"
            End If
            txtIEPS.Text = Format(CDec(txtIEPS.Text), "##,##0.00")
            txtTotalProv.Focus()

        End If

    End Sub

    Private Sub txtIVAProv11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVAProv11.Click
        txtIVAProv11.SelectAll()
    End Sub

    Private Sub txtIVAProv11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVAProv11.DoubleClick
        txtIVAProv11.Text = CDbl(txtSubtotalProv.Text) * (0.11)
        txtIVAProv11.Text = Format(CDec(txtIVAProv11.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtIVAProv11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVAProv11.KeyPress
        Dim i As Integer
        i = InStr(txtIVAProv11.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtIVAProv11.Text = "" Then
                txtIVAProv11.Text = "0.00"
            End If
            txtIVAProv11.Text = Format(CDec(txtIVAProv11.Text), "##,##0.00")
            txtIVAImp.Focus()
        End If
    End Sub

    Private Sub txtIVAImp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVAImp.Click
        txtIVAImp.SelectAll()
    End Sub

    Private Sub txtIVAImp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVAImp.KeyPress
        Dim i As Integer
        i = InStr(txtIVAImp.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtIVAImp.Text = "" Then
                txtIVAImp.Text = "0.00"
            End If
            txtIVAImp.Text = Format(CDec(txtIVAImp.Text), "##,##0.00")
            txtIVARetHono.Focus()
        End If
    End Sub

    Private Sub txtIVARetArrenda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVARetArrenda.Click
        txtIVARetArrenda.SelectAll()
    End Sub

    Private Sub txtIVARetArrenda_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVARetArrenda.DoubleClick
        txtIVARetArrenda.Text = CDbl(txtSubtotalProv.Text) * (0.106666)
        txtIVARetArrenda.Text = Format(CDec(txtIVARetArrenda.Text), "##,##0.00")
        txtISRArrenda.Text = CDbl(txtSubtotalProv.Text) * (0.1)
        txtISRArrenda.Text = Format(CDec(txtISRArrenda.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtIVARetArrenda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVARetArrenda.KeyPress
        Dim i As Integer
        i = InStr(txtIVARetArrenda.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtIVARetArrenda.Text = "" Then
                txtIVARetArrenda.Text = "0.00"
            End If
            txtIVARetArrenda.Text = Format(CDec(txtIVARetArrenda.Text), "##,##0.00")
            txtRet4.Focus()

        End If

    End Sub

    Private Sub txtISRArrenda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtISRArrenda.Click
        txtISRArrenda.SelectAll()
    End Sub

    Private Sub txtISRArrenda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtISRArrenda.KeyPress
        Dim i As Integer
        i = InStr(txtISRArrenda.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtISRArrenda.Text = "" Then
                txtISRArrenda.Text = "0.00"
            End If
            txtISRArrenda.Text = Format(CDec(txtISRArrenda.Text), "##,##0.00")
            txtIEPS.Focus()

        End If

    End Sub

    Private Sub txtIEPS_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIEPS.LostFocus
        txtIEPS.Text = Format(CDec(txtIEPS.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtRet4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRet4.LostFocus
        txtRet4.Text = Format(CDec(txtRet4.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtSubtotalProv_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubtotalProv.LostFocus
        txtSubtotalProv.Text = Format(CDec(txtSubtotalProv.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtIVARetArrenda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVARetArrenda.LostFocus
        txtIVARetArrenda.Text = Format(CDec(txtIVARetArrenda.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtIVAProv11_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVAProv11.LostFocus
        txtIVAProv11.Text = Format(CDec(txtIVAProv11.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtISRArrenda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtISRArrenda.LostFocus
        txtISRArrenda.Text = Format(CDec(txtISRArrenda.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtISRHono_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtISRHono.LostFocus
        txtISRHono.Text = Format(CDec(txtISRHono.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub txtIVAProv_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVAProv.LostFocus
        txtIVAProv.Text = Format(CDec(txtIVAProv.Text), "##,##0.00")
        SumaTotalFactura()
    End Sub

    Private Sub rdDlls_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdDlls.Click
        txtTipoCambio.Select()
    End Sub


    Private Sub txtTipoCambio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoCambio.GotFocus
        txtTipoCambio.SelectAll()
    End Sub

    Private Sub txtTipoCambio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoCambio.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtTipoCambio.Text = "" Then
                txtTipoCambio.Text = "0.00"
            End If
            txtTipoCambio.Text = Format(CDec(txtTipoCambio.Text), "##,##0.0000")

        End If
    End Sub

    Private Sub txtTipoCambio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoCambio.LostFocus
        If txtTipoCambio.Text = "" Then
            txtTipoCambio.Text = "0.00"
        End If
        txtTipoCambio.Text = Format(CDec(txtTipoCambio.Text), "##,##0.0000")
    End Sub

    Private Sub txtDescuentos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuentos.GotFocus
        txtDescuentos.SelectAll()
    End Sub

    Private Sub txtDescuentos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescuentos.KeyPress
        Dim i As Integer
        i = InStr(txtDescuentos.Text, ".")
        If i = 0 Then
            If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        Else
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtDescuentos.Text = "" Then
                txtDescuentos.Text = "0.00"
            End If
            txtDescuentos.Text = Format(CDec(txtDescuentos.Text), "##,##0.00")
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub txtDescuentos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuentos.LostFocus
        txtDescuentos.Text = Format(CDec(txtDescuentos.Text), "##,##0.00")
        If txtDescuentos.Text > 0 Then
            cbxTipoDescuento.Enabled = True
            cbxTipoDescuento.Focus()
        End If
        SumaTotalFactura()
    End Sub
    Sub CargaCtaTipoDescuento()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "DECLARE @TablaCtaDesc TABLE ([Cuenta] nchar(14),[Descripcion] Varchar(80));insert into @TablaCtaDESC values ('0','< < Seleccionar > >');insert into @TablaCtaDesc Select Cuenta,descripcion from Contabilidad.dbo.CatCuentas(nolock) where cuenta like '5800%';select cuenta,descripcion FROM @TablaCtaDesc order by Cuenta"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        Me.cbxTipoDescuento.ValueMember = "Cuenta"
        Me.cbxTipoDescuento.DisplayMember = "Descripcion"
        Me.cbxTipoDescuento.DataSource = dt
    End Sub

End Class