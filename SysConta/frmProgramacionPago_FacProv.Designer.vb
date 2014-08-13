<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramacionPago_FacProv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramacionPago_FacProv))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIVAProv = New System.Windows.Forms.TextBox()
        Me.txtUnidadesProv = New System.Windows.Forms.TextBox()
        Me.txtSubtotalProv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFacturaProv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.gbxFacturaProveedor = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtTotalOC = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbxTipoDescuento = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDescuentos = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtRango = New System.Windows.Forms.Label()
        Me.frmTipoMoneda = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.rdDlls = New System.Windows.Forms.RadioButton()
        Me.rdPesos = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtISRArrenda = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIVARetArrenda = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIVAImp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIVAProv11 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtIEPS = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtISRHono = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtIVARetHono = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRet4 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalProv = New System.Windows.Forms.TextBox()
        Me.dtpFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.gbxFacturaProveedor.SuspendLayout()
        Me.frmTipoMoneda.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(85, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(86, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "$"
        '
        'txtIVAProv
        '
        Me.txtIVAProv.Location = New System.Drawing.Point(100, 104)
        Me.txtIVAProv.Name = "txtIVAProv"
        Me.txtIVAProv.Size = New System.Drawing.Size(75, 20)
        Me.txtIVAProv.TabIndex = 4
        Me.txtIVAProv.Text = "0.00"
        Me.txtIVAProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnidadesProv
        '
        Me.txtUnidadesProv.Location = New System.Drawing.Point(100, 62)
        Me.txtUnidadesProv.Name = "txtUnidadesProv"
        Me.txtUnidadesProv.Size = New System.Drawing.Size(75, 20)
        Me.txtUnidadesProv.TabIndex = 2
        Me.txtUnidadesProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubtotalProv
        '
        Me.txtSubtotalProv.Location = New System.Drawing.Point(100, 83)
        Me.txtSubtotalProv.Name = "txtSubtotalProv"
        Me.txtSubtotalProv.Size = New System.Drawing.Size(75, 20)
        Me.txtSubtotalProv.TabIndex = 3
        Me.txtSubtotalProv.Text = "0.00"
        Me.txtSubtotalProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Subtotal "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 13)
        Me.Label17.TabIndex = 128
        Me.Label17.Text = "IVA Total (16%)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Unidades T. "
        '
        'txtFacturaProv
        '
        Me.txtFacturaProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFacturaProv.Location = New System.Drawing.Point(355, 29)
        Me.txtFacturaProv.Name = "txtFacturaProv"
        Me.txtFacturaProv.Size = New System.Drawing.Size(75, 20)
        Me.txtFacturaProv.TabIndex = 1
        Me.txtFacturaProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "N° Factura"
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 219
        Me.LineShape4.X2 = 12
        Me.LineShape4.Y1 = 9
        Me.LineShape4.Y2 = 9
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4})
        Me.ShapeContainer1.Size = New System.Drawing.Size(467, 326)
        Me.ShapeContainer1.TabIndex = 137
        Me.ShapeContainer1.TabStop = False
        '
        'gbxFacturaProveedor
        '
        Me.gbxFacturaProveedor.Controls.Add(Me.Label23)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label24)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtTotalOC)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label21)
        Me.gbxFacturaProveedor.Controls.Add(Me.cbxTipoDescuento)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label18)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtDescuentos)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label19)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtRango)
        Me.gbxFacturaProveedor.Controls.Add(Me.frmTipoMoneda)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label15)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtISRArrenda)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label16)
        Me.gbxFacturaProveedor.Controls.Add(Me.btnCancelar)
        Me.gbxFacturaProveedor.Controls.Add(Me.btnAceptar)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label12)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtIVARetArrenda)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label14)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label9)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label10)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtIVAImp)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label6)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label7)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtIVAProv11)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label31)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtIEPS)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label29)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtISRHono)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label28)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtIVARetHono)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label20)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtRet4)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label32)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label30)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label27)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label26)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label3)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label5)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtTotalProv)
        Me.gbxFacturaProveedor.Controls.Add(Me.dtpFechaFactura)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label2)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtFacturaProv)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label1)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label13)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label11)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label17)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label8)
        Me.gbxFacturaProveedor.Controls.Add(Me.Label4)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtIVAProv)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtSubtotalProv)
        Me.gbxFacturaProveedor.Controls.Add(Me.txtUnidadesProv)
        Me.gbxFacturaProveedor.Controls.Add(Me.ShapeContainer2)
        Me.gbxFacturaProveedor.Location = New System.Drawing.Point(12, 3)
        Me.gbxFacturaProveedor.Name = "gbxFacturaProveedor"
        Me.gbxFacturaProveedor.Size = New System.Drawing.Size(444, 311)
        Me.gbxFacturaProveedor.TabIndex = 0
        Me.gbxFacturaProveedor.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(305, 243)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 13)
        Me.Label23.TabIndex = 186
        Me.Label23.Text = "$"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(239, 243)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 13)
        Me.Label24.TabIndex = 185
        Me.Label24.Text = "TOTAL OC :"
        '
        'txtTotalOC
        '
        Me.txtTotalOC.Enabled = False
        Me.txtTotalOC.Location = New System.Drawing.Point(321, 239)
        Me.txtTotalOC.Name = "txtTotalOC"
        Me.txtTotalOC.Size = New System.Drawing.Size(108, 20)
        Me.txtTotalOC.TabIndex = 184
        Me.txtTotalOC.Text = "0.00"
        Me.txtTotalOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 261)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 12)
        Me.Label21.TabIndex = 183
        Me.Label21.Text = "Tipo de Descuento"
        '
        'cbxTipoDescuento
        '
        Me.cbxTipoDescuento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxTipoDescuento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxTipoDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDescuento.Enabled = False
        Me.cbxTipoDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoDescuento.FormattingEnabled = True
        Me.cbxTipoDescuento.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbxTipoDescuento.Items.AddRange(New Object() {""})
        Me.cbxTipoDescuento.Location = New System.Drawing.Point(9, 282)
        Me.cbxTipoDescuento.Name = "cbxTipoDescuento"
        Me.cbxTipoDescuento.Size = New System.Drawing.Size(210, 20)
        Me.cbxTipoDescuento.TabIndex = 182
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(87, 242)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 13)
        Me.Label18.TabIndex = 181
        Me.Label18.Text = "$"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.Location = New System.Drawing.Point(102, 238)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(75, 20)
        Me.txtDescuentos.TabIndex = 180
        Me.txtDescuentos.Text = "0.00"
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 242)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 13)
        Me.Label19.TabIndex = 179
        Me.Label19.Text = "Descuentos :"
        '
        'txtRango
        '
        Me.txtRango.AutoSize = True
        Me.txtRango.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtRango.Location = New System.Drawing.Point(401, 13)
        Me.txtRango.Name = "txtRango"
        Me.txtRango.Size = New System.Drawing.Size(28, 13)
        Me.txtRango.TabIndex = 178
        Me.txtRango.Text = "0.00"
        Me.txtRango.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.txtRango.Visible = False
        '
        'frmTipoMoneda
        '
        Me.frmTipoMoneda.Controls.Add(Me.Label22)
        Me.frmTipoMoneda.Controls.Add(Me.txtTipoCambio)
        Me.frmTipoMoneda.Controls.Add(Me.rdDlls)
        Me.frmTipoMoneda.Controls.Add(Me.rdPesos)
        Me.frmTipoMoneda.Location = New System.Drawing.Point(9, 168)
        Me.frmTipoMoneda.Name = "frmTipoMoneda"
        Me.frmTipoMoneda.Size = New System.Drawing.Size(202, 56)
        Me.frmTipoMoneda.TabIndex = 177
        Me.frmTipoMoneda.TabStop = False
        Me.frmTipoMoneda.Text = "Moneda"
        Me.frmTipoMoneda.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(14, 34)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 13)
        Me.Label22.TabIndex = 184
        Me.Label22.Text = "Tipo de Cambio:"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.SystemColors.Info
        Me.txtTipoCambio.Location = New System.Drawing.Point(105, 30)
        Me.txtTipoCambio.MaxLength = 40
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(70, 20)
        Me.txtTipoCambio.TabIndex = 133
        Me.txtTipoCambio.Text = "0.00"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rdDlls
        '
        Me.rdDlls.AutoSize = True
        Me.rdDlls.Location = New System.Drawing.Point(101, 12)
        Me.rdDlls.Name = "rdDlls"
        Me.rdDlls.Size = New System.Drawing.Size(61, 17)
        Me.rdDlls.TabIndex = 1
        Me.rdDlls.Text = "Dolares"
        Me.rdDlls.UseVisualStyleBackColor = True
        '
        'rdPesos
        '
        Me.rdPesos.AutoSize = True
        Me.rdPesos.Checked = True
        Me.rdPesos.Location = New System.Drawing.Point(41, 12)
        Me.rdPesos.Name = "rdPesos"
        Me.rdPesos.Size = New System.Drawing.Size(54, 17)
        Me.rdPesos.TabIndex = 0
        Me.rdPesos.TabStop = True
        Me.rdPesos.Text = "Pesos"
        Me.rdPesos.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(340, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 176
        Me.Label15.Text = "$"
        '
        'txtISRArrenda
        '
        Me.txtISRArrenda.Location = New System.Drawing.Point(355, 147)
        Me.txtISRArrenda.Name = "txtISRArrenda"
        Me.txtISRArrenda.Size = New System.Drawing.Size(75, 20)
        Me.txtISRArrenda.TabIndex = 175
        Me.txtISRArrenda.Text = "0.00"
        Me.txtISRArrenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(236, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 13)
        Me.Label16.TabIndex = 174
        Me.Label16.Text = "I.S.R. Arrendamiento"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(356, 280)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(263, 280)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(339, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 173
        Me.Label12.Text = "$"
        '
        'txtIVARetArrenda
        '
        Me.txtIVARetArrenda.Location = New System.Drawing.Point(355, 84)
        Me.txtIVARetArrenda.Name = "txtIVARetArrenda"
        Me.txtIVARetArrenda.Size = New System.Drawing.Size(75, 20)
        Me.txtIVARetArrenda.TabIndex = 172
        Me.txtIVARetArrenda.Text = "0.00"
        Me.txtIVARetArrenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(180, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(159, 13)
        Me.Label14.TabIndex = 171
        Me.Label14.Text = "IVA Ret Arrendamiento (10.67%)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(85, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 170
        Me.Label9.Text = "$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 169
        Me.Label10.Text = "IVA Importacion"
        '
        'txtIVAImp
        '
        Me.txtIVAImp.Location = New System.Drawing.Point(100, 146)
        Me.txtIVAImp.Name = "txtIVAImp"
        Me.txtIVAImp.Size = New System.Drawing.Size(75, 20)
        Me.txtIVAImp.TabIndex = 168
        Me.txtIVAImp.Text = "0.00"
        Me.txtIVAImp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "IVA Total (11%)"
        '
        'txtIVAProv11
        '
        Me.txtIVAProv11.Location = New System.Drawing.Point(100, 125)
        Me.txtIVAProv11.Name = "txtIVAProv11"
        Me.txtIVAProv11.Size = New System.Drawing.Size(75, 20)
        Me.txtIVAProv11.TabIndex = 165
        Me.txtIVAProv11.Text = "0.00"
        Me.txtIVAProv11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(340, 172)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 13)
        Me.Label31.TabIndex = 164
        Me.Label31.Text = "$"
        '
        'txtIEPS
        '
        Me.txtIEPS.Location = New System.Drawing.Point(355, 168)
        Me.txtIEPS.Name = "txtIEPS"
        Me.txtIEPS.Size = New System.Drawing.Size(74, 20)
        Me.txtIEPS.TabIndex = 163
        Me.txtIEPS.Text = "0.00"
        Me.txtIEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(340, 130)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 13)
        Me.Label29.TabIndex = 162
        Me.Label29.Text = "$"
        '
        'txtISRHono
        '
        Me.txtISRHono.Location = New System.Drawing.Point(355, 126)
        Me.txtISRHono.Name = "txtISRHono"
        Me.txtISRHono.Size = New System.Drawing.Size(75, 20)
        Me.txtISRHono.TabIndex = 161
        Me.txtISRHono.Text = "0.00"
        Me.txtISRHono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(339, 66)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 13)
        Me.Label28.TabIndex = 160
        Me.Label28.Text = "$"
        '
        'txtIVARetHono
        '
        Me.txtIVARetHono.Location = New System.Drawing.Point(355, 63)
        Me.txtIVARetHono.Name = "txtIVARetHono"
        Me.txtIVARetHono.Size = New System.Drawing.Size(75, 20)
        Me.txtIVARetHono.TabIndex = 159
        Me.txtIVARetHono.Text = "0.00"
        Me.txtIVARetHono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(339, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 13)
        Me.Label20.TabIndex = 158
        Me.Label20.Text = "$"
        '
        'txtRet4
        '
        Me.txtRet4.Location = New System.Drawing.Point(355, 105)
        Me.txtRet4.Name = "txtRet4"
        Me.txtRet4.Size = New System.Drawing.Size(75, 20)
        Me.txtRet4.TabIndex = 157
        Me.txtRet4.Text = "0.00"
        Me.txtRet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(298, 172)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(40, 13)
        Me.Label32.TabIndex = 156
        Me.Label32.Text = "I.E.P.S"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(251, 128)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(88, 13)
        Me.Label30.TabIndex = 153
        Me.Label30.Text = "I.S.R. Honorarios"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(196, 66)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(142, 13)
        Me.Label27.TabIndex = 150
        Me.Label27.Text = "IVA Ret Honorarios (10.67%)"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(240, 107)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 13)
        Me.Label26.TabIndex = 149
        Me.Label26.Text = "IVA Ret Fletes (4%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "TOTAL (Factura) :"
        '
        'txtTotalProv
        '
        Me.txtTotalProv.Location = New System.Drawing.Point(321, 204)
        Me.txtTotalProv.Name = "txtTotalProv"
        Me.txtTotalProv.Size = New System.Drawing.Size(108, 20)
        Me.txtTotalProv.TabIndex = 5
        Me.txtTotalProv.Text = "0.00"
        Me.txtTotalProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Location = New System.Drawing.Point(11, 29)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFactura.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Fecha Factura"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(438, 292)
        Me.ShapeContainer2.TabIndex = 139
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 427
        Me.LineShape1.X2 = 6
        Me.LineShape1.Y1 = 212
        Me.LineShape1.Y2 = 212
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 425
        Me.LineShape2.X2 = 2
        Me.LineShape2.Y1 = 41
        Me.LineShape2.Y2 = 42
        '
        'frmProgramacionPago_FacProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(467, 326)
        Me.Controls.Add(Me.gbxFacturaProveedor)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProgramacionPago_FacProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Factura Proveedor"
        Me.gbxFacturaProveedor.ResumeLayout(False)
        Me.gbxFacturaProveedor.PerformLayout()
        Me.frmTipoMoneda.ResumeLayout(False)
        Me.frmTipoMoneda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIVAProv As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidadesProv As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotalProv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFacturaProv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents gbxFacturaProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents dtpFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalProv As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtIEPS As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtISRHono As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtIVARetHono As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtRet4 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtIVARetArrenda As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIVAImp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIVAProv11 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtISRArrenda As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents frmTipoMoneda As System.Windows.Forms.GroupBox
    Friend WithEvents rdDlls As System.Windows.Forms.RadioButton
    Friend WithEvents rdPesos As System.Windows.Forms.RadioButton
    Friend WithEvents txtRango As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDescuentos As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoDescuento As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtTotalOC As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
