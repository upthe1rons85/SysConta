<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovBancos_Historico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovBancos_Historico))
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbxBancos = New System.Windows.Forms.ComboBox()
        Me.gbxPagoProveedor = New System.Windows.Forms.GroupBox()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.cbxProveedores = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbxProveedor = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSumaPoliza = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstPolizas = New System.Windows.Forms.ListView()
        Me.pNumeroLinea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pTipoPoliza = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pPoliza = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pConcepto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pCargoAbono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pImporte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pCECO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pRefDocumento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pReferencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstContraRecibo = New System.Windows.Forms.ListView()
        Me.dFecCR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dFechaRec = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mFactura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dFecFac = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nFolio_Sol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nFolio_Cot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mSubtotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cIVA16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cIVA11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cIvaImp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cIVARetHon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cIVARetArr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cIVARet4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cISRHon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cISRArr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cIEPS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cImporte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cSaldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dFechaProg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cPoliza = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstCheques = New System.Windows.Forms.ListView()
        Me.nCheque = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Beneficiario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nFolioContra = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sFactura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nSubTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVA11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVAIMP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVARetHon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVARetArr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVARet4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mISRHon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mISRArr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIEPS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mTotalDlls = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sTipoMoneda = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nTipoPoliza = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nPoliza = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbxPagoProveedor.SuspendLayout()
        Me.gbxProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 752
        Me.LineShape3.X2 = 6
        Me.LineShape3.Y1 = 42
        Me.LineShape3.Y2 = 42
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(765, 553)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Historico de Cheques"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(542, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 12)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "N° Cheque :"
        '
        'txtCheque
        '
        Me.txtCheque.BackColor = System.Drawing.SystemColors.Info
        Me.txtCheque.Location = New System.Drawing.Point(603, 19)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(54, 20)
        Me.txtCheque.TabIndex = 197
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 12)
        Me.Label25.TabIndex = 196
        Me.Label25.Text = "Banco :"
        '
        'cbxBancos
        '
        Me.cbxBancos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxBancos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBancos.FormattingEnabled = True
        Me.cbxBancos.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbxBancos.Items.AddRange(New Object() {""})
        Me.cbxBancos.Location = New System.Drawing.Point(50, 19)
        Me.cbxBancos.Name = "cbxBancos"
        Me.cbxBancos.Size = New System.Drawing.Size(173, 20)
        Me.cbxBancos.TabIndex = 195
        '
        'gbxPagoProveedor
        '
        Me.gbxPagoProveedor.Controls.Add(Me.btnBusca)
        Me.gbxPagoProveedor.Controls.Add(Me.cbxProveedores)
        Me.gbxPagoProveedor.Controls.Add(Me.Label25)
        Me.gbxPagoProveedor.Controls.Add(Me.Label7)
        Me.gbxPagoProveedor.Controls.Add(Me.Label2)
        Me.gbxPagoProveedor.Controls.Add(Me.cbxBancos)
        Me.gbxPagoProveedor.Controls.Add(Me.txtCheque)
        Me.gbxPagoProveedor.Location = New System.Drawing.Point(6, 51)
        Me.gbxPagoProveedor.Name = "gbxPagoProveedor"
        Me.gbxPagoProveedor.Size = New System.Drawing.Size(756, 53)
        Me.gbxPagoProveedor.TabIndex = 199
        Me.gbxPagoProveedor.TabStop = False
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.SystemColors.Control
        Me.btnBusca.Location = New System.Drawing.Point(685, 19)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(62, 20)
        Me.btnBusca.TabIndex = 203
        Me.btnBusca.Text = "Buscar"
        Me.btnBusca.UseVisualStyleBackColor = False
        '
        'cbxProveedores
        '
        Me.cbxProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxProveedores.BackColor = System.Drawing.SystemColors.Info
        Me.cbxProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProveedores.FormattingEnabled = True
        Me.cbxProveedores.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbxProveedores.Location = New System.Drawing.Point(314, 19)
        Me.cbxProveedores.Name = "cbxProveedores"
        Me.cbxProveedores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxProveedores.Size = New System.Drawing.Size(222, 20)
        Me.cbxProveedores.TabIndex = 201
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(255, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "Proveedor :"
        '
        'gbxProveedor
        '
        Me.gbxProveedor.Controls.Add(Me.Label6)
        Me.gbxProveedor.Controls.Add(Me.txtSumaPoliza)
        Me.gbxProveedor.Controls.Add(Me.Label5)
        Me.gbxProveedor.Controls.Add(Me.Label4)
        Me.gbxProveedor.Controls.Add(Me.lstPolizas)
        Me.gbxProveedor.Controls.Add(Me.lstContraRecibo)
        Me.gbxProveedor.Controls.Add(Me.lstCheques)
        Me.gbxProveedor.Location = New System.Drawing.Point(6, 110)
        Me.gbxProveedor.Name = "gbxProveedor"
        Me.gbxProveedor.Size = New System.Drawing.Size(756, 440)
        Me.gbxProveedor.TabIndex = 200
        Me.gbxProveedor.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(557, 424)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 12)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "Suma Importe Poliza :"
        '
        'txtSumaPoliza
        '
        Me.txtSumaPoliza.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSumaPoliza.Enabled = False
        Me.txtSumaPoliza.Location = New System.Drawing.Point(656, 420)
        Me.txtSumaPoliza.Name = "txtSumaPoliza"
        Me.txtSumaPoliza.Size = New System.Drawing.Size(91, 20)
        Me.txtSumaPoliza.TabIndex = 201
        Me.txtSumaPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "Contra Recibo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 197
        Me.Label4.Text = "Polizas :"
        '
        'lstPolizas
        '
        Me.lstPolizas.BackColor = System.Drawing.SystemColors.Info
        Me.lstPolizas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.pNumeroLinea, Me.pFecha, Me.pTipoPoliza, Me.pPoliza, Me.pCuenta, Me.pConcepto, Me.pCargoAbono, Me.pImporte, Me.pCECO, Me.pRefDocumento, Me.pReferencia})
        Me.lstPolizas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPolizas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstPolizas.FullRowSelect = True
        Me.lstPolizas.Location = New System.Drawing.Point(5, 299)
        Me.lstPolizas.Name = "lstPolizas"
        Me.lstPolizas.Size = New System.Drawing.Size(742, 115)
        Me.lstPolizas.TabIndex = 5
        Me.lstPolizas.UseCompatibleStateImageBehavior = False
        Me.lstPolizas.View = System.Windows.Forms.View.Details
        '
        'pNumeroLinea
        '
        Me.pNumeroLinea.Text = "Lin"
        Me.pNumeroLinea.Width = 30
        '
        'pFecha
        '
        Me.pFecha.Text = "Fecha"
        Me.pFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pFecha.Width = 72
        '
        'pTipoPoliza
        '
        Me.pTipoPoliza.Text = "TipoPoliza"
        Me.pTipoPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pTipoPoliza.Width = 45
        '
        'pPoliza
        '
        Me.pPoliza.Text = "Poliza"
        Me.pPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pPoliza.Width = 42
        '
        'pCuenta
        '
        Me.pCuenta.Text = "Cuenta"
        Me.pCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pCuenta.Width = 123
        '
        'pConcepto
        '
        Me.pConcepto.Text = "Concepto"
        Me.pConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pConcepto.Width = 135
        '
        'pCargoAbono
        '
        Me.pCargoAbono.Text = "C/A"
        Me.pCargoAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pCargoAbono.Width = 57
        '
        'pImporte
        '
        Me.pImporte.Text = "Importe"
        Me.pImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pImporte.Width = 65
        '
        'pCECO
        '
        Me.pCECO.Text = "CECO"
        Me.pCECO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pCECO.Width = 45
        '
        'pRefDocumento
        '
        Me.pRefDocumento.Text = "RefDoc"
        Me.pRefDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pRefDocumento.Width = 45
        '
        'pReferencia
        '
        Me.pReferencia.Text = "Referencia"
        Me.pReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstContraRecibo
        '
        Me.lstContraRecibo.BackColor = System.Drawing.Color.Gainsboro
        Me.lstContraRecibo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.dFecCR, Me.dFechaRec, Me.mFactura, Me.dFecFac, Me.nFolio_Sol, Me.nFolio_Cot, Me.mSubtotal, Me.cIVA16, Me.cIVA11, Me.cIvaImp, Me.cIVARetHon, Me.cIVARetArr, Me.cIVARet4, Me.cISRHon, Me.cISRArr, Me.cIEPS, Me.cImporte, Me.cSaldo, Me.dFechaProg, Me.cPoliza})
        Me.lstContraRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstContraRecibo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstContraRecibo.FullRowSelect = True
        Me.lstContraRecibo.Location = New System.Drawing.Point(5, 163)
        Me.lstContraRecibo.Name = "lstContraRecibo"
        Me.lstContraRecibo.Size = New System.Drawing.Size(742, 115)
        Me.lstContraRecibo.TabIndex = 4
        Me.lstContraRecibo.UseCompatibleStateImageBehavior = False
        Me.lstContraRecibo.View = System.Windows.Forms.View.Details
        '
        'dFecCR
        '
        Me.dFecCR.Text = "Fecha CR"
        Me.dFecCR.Width = 71
        '
        'dFechaRec
        '
        Me.dFechaRec.Text = "Fecha Rec"
        Me.dFechaRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dFechaRec.Width = 67
        '
        'mFactura
        '
        Me.mFactura.Text = "Factura"
        Me.mFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mFactura.Width = 71
        '
        'dFecFac
        '
        Me.dFecFac.Text = "Fecha Fac"
        Me.dFecFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dFecFac.Width = 58
        '
        'nFolio_Sol
        '
        Me.nFolio_Sol.Text = "Folio Sol"
        Me.nFolio_Sol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nFolio_Sol.Width = 47
        '
        'nFolio_Cot
        '
        Me.nFolio_Cot.Text = "Folio Cot"
        Me.nFolio_Cot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nFolio_Cot.Width = 49
        '
        'mSubtotal
        '
        Me.mSubtotal.Text = "Subtotal"
        Me.mSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mSubtotal.Width = 57
        '
        'cIVA16
        '
        Me.cIVA16.Text = "Iva16"
        Me.cIVA16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cIVA16.Width = 52
        '
        'cIVA11
        '
        Me.cIVA11.Text = "Iva11"
        Me.cIVA11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cIVA11.Width = 45
        '
        'cIvaImp
        '
        Me.cIvaImp.Text = "Iva Imp"
        Me.cIvaImp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cIvaImp.Width = 45
        '
        'cIVARetHon
        '
        Me.cIVARetHon.Text = "Iva RetH"
        Me.cIVARetHon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cIVARetHon.Width = 45
        '
        'cIVARetArr
        '
        Me.cIVARetArr.Text = "IVARetA"
        Me.cIVARetArr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cIVARetArr.Width = 45
        '
        'cIVARet4
        '
        Me.cIVARet4.Text = "IvaRet4"
        Me.cIVARet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cIVARet4.Width = 45
        '
        'cISRHon
        '
        Me.cISRHon.Text = "ISR H"
        Me.cISRHon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cISRHon.Width = 45
        '
        'cISRArr
        '
        Me.cISRArr.Text = "ISR A"
        Me.cISRArr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cISRArr.Width = 45
        '
        'cIEPS
        '
        Me.cIEPS.Text = "IEPS"
        Me.cIEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cIEPS.Width = 45
        '
        'cImporte
        '
        Me.cImporte.Text = "Importe"
        Me.cImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cSaldo
        '
        Me.cSaldo.Text = "Saldo"
        Me.cSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dFechaProg
        '
        Me.dFechaProg.Text = "Fec Pro. Pag."
        Me.dFechaProg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cPoliza
        '
        Me.cPoliza.Text = "Poliza"
        Me.cPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cPoliza.Width = 30
        '
        'lstCheques
        '
        Me.lstCheques.BackColor = System.Drawing.SystemColors.Info
        Me.lstCheques.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nCheque, Me.Beneficiario, Me.nFolioContra, Me.sFactura, Me.nSubTotal, Me.mIVA, Me.mIVA11, Me.mIVAIMP, Me.mIVARetHon, Me.mIVARetArr, Me.mIVARet4, Me.mISRHon, Me.mISRArr, Me.mIEPS, Me.mTotal, Me.mTotalDlls, Me.sTipoMoneda, Me.nTipoPoliza, Me.nPoliza})
        Me.lstCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCheques.FullRowSelect = True
        Me.lstCheques.GridLines = True
        Me.lstCheques.Location = New System.Drawing.Point(5, 14)
        Me.lstCheques.Name = "lstCheques"
        Me.lstCheques.Size = New System.Drawing.Size(742, 128)
        Me.lstCheques.TabIndex = 3
        Me.lstCheques.UseCompatibleStateImageBehavior = False
        Me.lstCheques.View = System.Windows.Forms.View.Details
        '
        'nCheque
        '
        Me.nCheque.Text = "Cheque"
        Me.nCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nCheque.Width = 40
        '
        'Beneficiario
        '
        Me.Beneficiario.Text = "BENEFICIARIO"
        Me.Beneficiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Beneficiario.Width = 162
        '
        'nFolioContra
        '
        Me.nFolioContra.Text = "FOLIO CR"
        Me.nFolioContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nFolioContra.Width = 59
        '
        'sFactura
        '
        Me.sFactura.Text = "FACTURA"
        Me.sFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.sFactura.Width = 55
        '
        'nSubTotal
        '
        Me.nSubTotal.Text = "SUBTOTAL"
        Me.nSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nSubTotal.Width = 51
        '
        'mIVA
        '
        Me.mIVA.Text = "IVA"
        Me.mIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mIVA.Width = 51
        '
        'mIVA11
        '
        Me.mIVA11.Text = "IVA11"
        Me.mIVA11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mIVA11.Width = 62
        '
        'mIVAIMP
        '
        Me.mIVAIMP.Text = "IVAIMP"
        Me.mIVAIMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mIVAIMP.Width = 51
        '
        'mIVARetHon
        '
        Me.mIVARetHon.Text = "IVARetHon"
        '
        'mIVARetArr
        '
        Me.mIVARetArr.Text = "IVARetArr"
        Me.mIVARetArr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mIVARet4
        '
        Me.mIVARet4.Text = "IVARet4"
        Me.mIVARet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mISRHon
        '
        Me.mISRHon.Text = "ISR H"
        Me.mISRHon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mISRArr
        '
        Me.mISRArr.Text = "ISR A"
        Me.mISRArr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mIEPS
        '
        Me.mIEPS.Text = "IEPS"
        Me.mIEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mTotal
        '
        Me.mTotal.Text = "Total"
        '
        'mTotalDlls
        '
        Me.mTotalDlls.Text = "TotalDlls"
        Me.mTotalDlls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sTipoMoneda
        '
        Me.sTipoMoneda.Text = "MONED"
        Me.sTipoMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nTipoPoliza
        '
        Me.nTipoPoliza.Text = "TipoPoliza"
        Me.nTipoPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nPoliza
        '
        Me.nPoliza.Text = "Poliza"
        Me.nPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMovBancos_Historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(765, 553)
        Me.Controls.Add(Me.gbxProveedor)
        Me.Controls.Add(Me.gbxPagoProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovBancos_Historico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historico de Cheques"
        Me.gbxPagoProveedor.ResumeLayout(False)
        Me.gbxPagoProveedor.PerformLayout()
        Me.gbxProveedor.ResumeLayout(False)
        Me.gbxProveedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbxBancos As System.Windows.Forms.ComboBox
    Friend WithEvents gbxPagoProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents gbxProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents lstContraRecibo As System.Windows.Forms.ListView
    Friend WithEvents dFecCR As System.Windows.Forms.ColumnHeader
    Friend WithEvents dFechaRec As System.Windows.Forms.ColumnHeader
    Friend WithEvents mFactura As System.Windows.Forms.ColumnHeader
    Friend WithEvents dFecFac As System.Windows.Forms.ColumnHeader
    Friend WithEvents nFolio_Sol As System.Windows.Forms.ColumnHeader
    Friend WithEvents nFolio_Cot As System.Windows.Forms.ColumnHeader
    Friend WithEvents mSubtotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIVA16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIVA11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstCheques As System.Windows.Forms.ListView
    Friend WithEvents Beneficiario As System.Windows.Forms.ColumnHeader
    Friend WithEvents nFolioContra As System.Windows.Forms.ColumnHeader
    Friend WithEvents sFactura As System.Windows.Forms.ColumnHeader
    Friend WithEvents nSubTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVA As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVA11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVAIMP As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVARetArr As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVARet4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents mISRHon As System.Windows.Forms.ColumnHeader
    Friend WithEvents mISRArr As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIEPS As System.Windows.Forms.ColumnHeader
    Friend WithEvents mTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents mTotalDlls As System.Windows.Forms.ColumnHeader
    Friend WithEvents sTipoMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents nTipoPoliza As System.Windows.Forms.ColumnHeader
    Friend WithEvents nPoliza As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVARetHon As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIvaImp As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIVARetHon As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIVARetArr As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIVARet4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cISRHon As System.Windows.Forms.ColumnHeader
    Friend WithEvents cISRArr As System.Windows.Forms.ColumnHeader
    Friend WithEvents cIEPS As System.Windows.Forms.ColumnHeader
    Friend WithEvents cImporte As System.Windows.Forms.ColumnHeader
    Friend WithEvents cSaldo As System.Windows.Forms.ColumnHeader
    Friend WithEvents dFechaProg As System.Windows.Forms.ColumnHeader
    Friend WithEvents cPoliza As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstPolizas As System.Windows.Forms.ListView
    Friend WithEvents pNumeroLinea As System.Windows.Forms.ColumnHeader
    Friend WithEvents pFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents pTipoPoliza As System.Windows.Forms.ColumnHeader
    Friend WithEvents pPoliza As System.Windows.Forms.ColumnHeader
    Friend WithEvents pCuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents pConcepto As System.Windows.Forms.ColumnHeader
    Friend WithEvents pCargoAbono As System.Windows.Forms.ColumnHeader
    Friend WithEvents pImporte As System.Windows.Forms.ColumnHeader
    Friend WithEvents pCECO As System.Windows.Forms.ColumnHeader
    Friend WithEvents pRefDocumento As System.Windows.Forms.ColumnHeader
    Friend WithEvents pReferencia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSumaPoliza As System.Windows.Forms.TextBox
    Friend WithEvents cbxProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBusca As System.Windows.Forms.Button
    Friend WithEvents nCheque As System.Windows.Forms.ColumnHeader
End Class
