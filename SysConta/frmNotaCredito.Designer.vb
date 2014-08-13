<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaCredito
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotaCredito))
        Me.cbxProveedores = New System.Windows.Forms.ComboBox()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.txtFolioSig = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DGVFacturas = New System.Windows.Forms.DataGridView()
        Me.dCodProv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dfolioRP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFechaDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFechaProg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mIVARet4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dTotDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mIVA11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mIVAIMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mIVARetHon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mIVARetArr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mISRHon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mISRArr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mIEPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mTipoCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxMoneda = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFac = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtIvaMax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkImpPoliza = New System.Windows.Forms.CheckBox()
        Me.btnAgregarFactura = New System.Windows.Forms.Button()
        Me.lstFacturas = New System.Windows.Forms.ListView()
        Me.mFacturaProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mFechaProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mUnidades = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mSubtotalProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVAProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVAProv11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVARet10H = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVARet10A = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVARetencion4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mISRHono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mISRArren = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mTotalProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dMoneda = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxConcepto = New System.Windows.Forms.ComboBox()
        Me.lstNotas = New System.Windows.Forms.ListView()
        Me.nFolio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nFolioNC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Concepto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nImporte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nTipoMov = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nTipoPol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nPoliza = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFolioContraRecibo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PgsGrabar = New System.Windows.Forms.ToolStripProgressBar()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DGVCuentas = New System.Windows.Forms.DataGridView()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtImporteNC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSumaCuenta = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DGVCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxProveedores
        '
        Me.cbxProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxProveedores.BackColor = System.Drawing.SystemColors.Info
        Me.cbxProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProveedores.FormattingEnabled = True
        Me.cbxProveedores.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbxProveedores.Location = New System.Drawing.Point(80, 15)
        Me.cbxProveedores.Name = "cbxProveedores"
        Me.cbxProveedores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxProveedores.Size = New System.Drawing.Size(222, 20)
        Me.cbxProveedores.TabIndex = 1
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.SystemColors.Control
        Me.btnBusca.Location = New System.Drawing.Point(471, 15)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(62, 20)
        Me.btnBusca.TabIndex = 3
        Me.btnBusca.Text = "Buscar"
        Me.btnBusca.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Factura:"
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(365, 15)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtFactura.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(18, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 24)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "Nota de Credito/Cargo"
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 873
        Me.LineShape3.X2 = 12
        Me.LineShape3.Y1 = 45
        Me.LineShape3.Y2 = 45
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(882, 471)
        Me.ShapeContainer1.TabIndex = 176
        Me.ShapeContainer1.TabStop = False
        '
        'txtFolioSig
        '
        Me.txtFolioSig.Enabled = False
        Me.txtFolioSig.Location = New System.Drawing.Point(816, 61)
        Me.txtFolioSig.Name = "txtFolioSig"
        Me.txtFolioSig.Size = New System.Drawing.Size(50, 20)
        Me.txtFolioSig.TabIndex = 0
        Me.txtFolioSig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxProveedores)
        Me.GroupBox1.Controls.Add(Me.btnBusca)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 48)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 227
        Me.Label7.Text = "Proveedor :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(781, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 226
        Me.Label16.Text = "Folio :"
        '
        'DGVFacturas
        '
        Me.DGVFacturas.AllowUserToAddRows = False
        Me.DGVFacturas.AllowUserToDeleteRows = False
        Me.DGVFacturas.AllowUserToResizeColumns = False
        Me.DGVFacturas.AllowUserToResizeRows = False
        Me.DGVFacturas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVFacturas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGVFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFacturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVFacturas.ColumnHeadersHeight = 20
        Me.DGVFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dCodProv, Me.dfolioRP, Me.dFechaDoc, Me.dFechaProg, Me.dFactura, Me.dSubtotal, Me.dIVA, Me.mIVARet4, Me.dTotDoc, Me.mSaldo, Me.mMoneda, Me.mIVA11, Me.mIVAIMP, Me.mIVARetHon, Me.mIVARetArr, Me.mISRHon, Me.mISRArr, Me.mIEPS, Me.mTipoCambio})
        Me.DGVFacturas.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVFacturas.DefaultCellStyle = DataGridViewCellStyle21
        Me.DGVFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGVFacturas.Enabled = False
        Me.DGVFacturas.Location = New System.Drawing.Point(7, 100)
        Me.DGVFacturas.MultiSelect = False
        Me.DGVFacturas.Name = "DGVFacturas"
        Me.DGVFacturas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGVFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFacturas.RowHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DGVFacturas.RowHeadersVisible = False
        Me.DGVFacturas.RowHeadersWidth = 20
        Me.DGVFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFacturas.Size = New System.Drawing.Size(575, 141)
        Me.DGVFacturas.TabIndex = 4
        '
        'dCodProv
        '
        Me.dCodProv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        Me.dCodProv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dCodProv.HeaderText = "COD"
        Me.dCodProv.MaxInputLength = 8
        Me.dCodProv.Name = "dCodProv"
        Me.dCodProv.ReadOnly = True
        Me.dCodProv.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dCodProv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dCodProv.Width = 40
        '
        'dfolioRP
        '
        Me.dfolioRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dfolioRP.DefaultCellStyle = DataGridViewCellStyle3
        Me.dfolioRP.HeaderText = "FOLIO"
        Me.dfolioRP.Name = "dfolioRP"
        Me.dfolioRP.ReadOnly = True
        Me.dfolioRP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dfolioRP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dfolioRP.Width = 40
        '
        'dFechaDoc
        '
        Me.dFechaDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dFechaDoc.DefaultCellStyle = DataGridViewCellStyle4
        Me.dFechaDoc.HeaderText = "FECHA DOC"
        Me.dFechaDoc.MaxInputLength = 60
        Me.dFechaDoc.Name = "dFechaDoc"
        Me.dFechaDoc.ReadOnly = True
        Me.dFechaDoc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dFechaDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dFechaDoc.Width = 70
        '
        'dFechaProg
        '
        Me.dFechaProg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.dFechaProg.DefaultCellStyle = DataGridViewCellStyle5
        Me.dFechaProg.HeaderText = "PROGRAMA"
        Me.dFechaProg.MaxInputLength = 13
        Me.dFechaProg.Name = "dFechaProg"
        Me.dFechaProg.ReadOnly = True
        Me.dFechaProg.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dFechaProg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dFechaProg.ToolTipText = "0.00"
        Me.dFechaProg.Width = 72
        '
        'dFactura
        '
        Me.dFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.dFactura.DefaultCellStyle = DataGridViewCellStyle6
        Me.dFactura.HeaderText = "FACTURA"
        Me.dFactura.MaxInputLength = 15
        Me.dFactura.Name = "dFactura"
        Me.dFactura.ReadOnly = True
        Me.dFactura.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dFactura.ToolTipText = "0.00"
        Me.dFactura.Width = 70
        '
        'dSubtotal
        '
        Me.dSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.dSubtotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.dSubtotal.HeaderText = "SUBTOTAL"
        Me.dSubtotal.MaxInputLength = 20
        Me.dSubtotal.Name = "dSubtotal"
        Me.dSubtotal.ReadOnly = True
        Me.dSubtotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dSubtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dSubtotal.Width = 80
        '
        'dIVA
        '
        Me.dIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0.00"
        Me.dIVA.DefaultCellStyle = DataGridViewCellStyle8
        Me.dIVA.HeaderText = "IVA"
        Me.dIVA.MaxInputLength = 20
        Me.dIVA.Name = "dIVA"
        Me.dIVA.ReadOnly = True
        Me.dIVA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dIVA.Width = 75
        '
        'mIVARet4
        '
        Me.mIVARet4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0.00"
        Me.mIVARet4.DefaultCellStyle = DataGridViewCellStyle9
        Me.mIVARet4.HeaderText = "IVARET4"
        Me.mIVARet4.Name = "mIVARet4"
        Me.mIVARet4.ReadOnly = True
        Me.mIVARet4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.mIVARet4.Width = 75
        '
        'dTotDoc
        '
        Me.dTotDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0.00"
        Me.dTotDoc.DefaultCellStyle = DataGridViewCellStyle10
        Me.dTotDoc.HeaderText = "TOTAL DOC"
        Me.dTotDoc.MaxInputLength = 20
        Me.dTotDoc.Name = "dTotDoc"
        Me.dTotDoc.ReadOnly = True
        Me.dTotDoc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dTotDoc.Width = 90
        '
        'mSaldo
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0.00"
        Me.mSaldo.DefaultCellStyle = DataGridViewCellStyle11
        Me.mSaldo.HeaderText = "SALDO"
        Me.mSaldo.MaxInputLength = 20
        Me.mSaldo.Name = "mSaldo"
        Me.mSaldo.ReadOnly = True
        Me.mSaldo.Width = 90
        '
        'mMoneda
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.mMoneda.DefaultCellStyle = DataGridViewCellStyle12
        Me.mMoneda.HeaderText = "MON"
        Me.mMoneda.Name = "mMoneda"
        Me.mMoneda.ReadOnly = True
        Me.mMoneda.Width = 28
        '
        'mIVA11
        '
        Me.mIVA11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = "0.00"
        Me.mIVA11.DefaultCellStyle = DataGridViewCellStyle13
        Me.mIVA11.HeaderText = "IVA11"
        Me.mIVA11.Name = "mIVA11"
        Me.mIVA11.ReadOnly = True
        Me.mIVA11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.mIVA11.Width = 75
        '
        'mIVAIMP
        '
        Me.mIVAIMP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = "0.00"
        Me.mIVAIMP.DefaultCellStyle = DataGridViewCellStyle14
        Me.mIVAIMP.HeaderText = "IVAIMP"
        Me.mIVAIMP.Name = "mIVAIMP"
        Me.mIVAIMP.ReadOnly = True
        Me.mIVAIMP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.mIVAIMP.Width = 75
        '
        'mIVARetHon
        '
        Me.mIVARetHon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = "0.00"
        Me.mIVARetHon.DefaultCellStyle = DataGridViewCellStyle15
        Me.mIVARetHon.HeaderText = "RETHON"
        Me.mIVARetHon.Name = "mIVARetHon"
        Me.mIVARetHon.ReadOnly = True
        Me.mIVARetHon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.mIVARetHon.Width = 75
        '
        'mIVARetArr
        '
        Me.mIVARetArr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = "0.00"
        Me.mIVARetArr.DefaultCellStyle = DataGridViewCellStyle16
        Me.mIVARetArr.HeaderText = "IVARETARR"
        Me.mIVARetArr.Name = "mIVARetArr"
        Me.mIVARetArr.ReadOnly = True
        Me.mIVARetArr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.mIVARetArr.Width = 75
        '
        'mISRHon
        '
        Me.mISRHon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = "0.00"
        Me.mISRHon.DefaultCellStyle = DataGridViewCellStyle17
        Me.mISRHon.HeaderText = "ISRHON"
        Me.mISRHon.Name = "mISRHon"
        Me.mISRHon.ReadOnly = True
        Me.mISRHon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.mISRHon.Width = 75
        '
        'mISRArr
        '
        Me.mISRArr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = "0.00"
        Me.mISRArr.DefaultCellStyle = DataGridViewCellStyle18
        Me.mISRArr.HeaderText = "ISRARR"
        Me.mISRArr.Name = "mISRArr"
        Me.mISRArr.ReadOnly = True
        Me.mISRArr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.mISRArr.Width = 75
        '
        'mIEPS
        '
        Me.mIEPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = "0.00"
        Me.mIEPS.DefaultCellStyle = DataGridViewCellStyle19
        Me.mIEPS.HeaderText = "IEPS"
        Me.mIEPS.Name = "mIEPS"
        Me.mIEPS.ReadOnly = True
        Me.mIEPS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.mIEPS.Width = 75
        '
        'mTipoCambio
        '
        DataGridViewCellStyle20.Format = "N2"
        DataGridViewCellStyle20.NullValue = "0.00"
        Me.mTipoCambio.DefaultCellStyle = DataGridViewCellStyle20
        Me.mTipoCambio.HeaderText = "TipoCambio"
        Me.mTipoCambio.Name = "mTipoCambio"
        Me.mTipoCambio.ReadOnly = True
        Me.mTipoCambio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label2.Location = New System.Drawing.Point(167, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 209
        Me.Label2.Text = "SubTotal :"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(224, 35)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(66, 18)
        Me.txtSubtotal.TabIndex = 210
        Me.txtSubtotal.Text = "0.00"
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label28.Location = New System.Drawing.Point(5, 61)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 13)
        Me.Label28.TabIndex = 212
        Me.Label28.Text = "TipoCabm :"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.Location = New System.Drawing.Point(70, 57)
        Me.txtTipoCambio.MaxLength = 40
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(63, 18)
        Me.txtTipoCambio.TabIndex = 211
        Me.txtTipoCambio.Text = "0.00"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label4.Location = New System.Drawing.Point(176, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = "Importe :"
        '
        'txtImporte
        '
        Me.txtImporte.Enabled = False
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(224, 13)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(66, 18)
        Me.txtImporte.TabIndex = 214
        Me.txtImporte.Text = "0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label12.Location = New System.Drawing.Point(302, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 217
        Me.Label12.Text = "Tipo Moneda :"
        '
        'cbxMoneda
        '
        Me.cbxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMoneda.Enabled = False
        Me.cbxMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMoneda.FormattingEnabled = True
        Me.cbxMoneda.Location = New System.Drawing.Point(379, 13)
        Me.cbxMoneda.Name = "cbxMoneda"
        Me.cbxMoneda.Size = New System.Drawing.Size(80, 20)
        Me.cbxMoneda.TabIndex = 218
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label9.Location = New System.Drawing.Point(19, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 219
        Me.Label9.Text = "Factura:"
        '
        'txtFac
        '
        Me.txtFac.Enabled = False
        Me.txtFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFac.Location = New System.Drawing.Point(71, 13)
        Me.txtFac.Name = "txtFac"
        Me.txtFac.Size = New System.Drawing.Size(62, 18)
        Me.txtFac.TabIndex = 220
        Me.txtFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtObs)
        Me.GroupBox2.Controls.Add(Me.txtIvaMax)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.chkImpPoliza)
        Me.GroupBox2.Controls.Add(Me.btnAgregarFactura)
        Me.GroupBox2.Controls.Add(Me.lstFacturas)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbxConcepto)
        Me.GroupBox2.Controls.Add(Me.lstNotas)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtFolioContraRecibo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtSaldo)
        Me.GroupBox2.Controls.Add(Me.txtIVA)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtImporte)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbxMoneda)
        Me.GroupBox2.Controls.Add(Me.txtFac)
        Me.GroupBox2.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(867, 205)
        Me.GroupBox2.TabIndex = 221
        Me.GroupBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 239
        Me.Label14.Text = "Obs :"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(70, 107)
        Me.txtObs.MaxLength = 45
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(306, 20)
        Me.txtObs.TabIndex = 6
        '
        'txtIvaMax
        '
        Me.txtIvaMax.Enabled = False
        Me.txtIvaMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaMax.Location = New System.Drawing.Point(379, 57)
        Me.txtIvaMax.Name = "txtIvaMax"
        Me.txtIvaMax.Size = New System.Drawing.Size(70, 18)
        Me.txtIvaMax.TabIndex = 237
        Me.txtIvaMax.Text = "0.00"
        Me.txtIvaMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label3.Location = New System.Drawing.Point(325, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 236
        Me.Label3.Text = "Max Iva :"
        '
        'chkImpPoliza
        '
        Me.chkImpPoliza.AutoSize = True
        Me.chkImpPoliza.Checked = True
        Me.chkImpPoliza.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImpPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImpPoliza.Location = New System.Drawing.Point(266, 83)
        Me.chkImpPoliza.Name = "chkImpPoliza"
        Me.chkImpPoliza.Size = New System.Drawing.Size(85, 16)
        Me.chkImpPoliza.TabIndex = 7
        Me.chkImpPoliza.Text = "Imprimir Poliza"
        Me.chkImpPoliza.UseVisualStyleBackColor = True
        '
        'btnAgregarFactura
        '
        Me.btnAgregarFactura.Enabled = False
        Me.btnAgregarFactura.Location = New System.Drawing.Point(402, 104)
        Me.btnAgregarFactura.Name = "btnAgregarFactura"
        Me.btnAgregarFactura.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarFactura.TabIndex = 8
        Me.btnAgregarFactura.Text = "Agregar"
        Me.btnAgregarFactura.UseVisualStyleBackColor = True
        '
        'lstFacturas
        '
        Me.lstFacturas.BackColor = System.Drawing.SystemColors.Info
        Me.lstFacturas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mFacturaProv, Me.mFechaProv, Me.mUnidades, Me.mSubtotalProv, Me.mIVAProv, Me.mIVAProv11, Me.ColumnHeader1, Me.mIVARet10H, Me.mIVARet10A, Me.mIVARetencion4, Me.mISRHono, Me.mISRArren, Me.ColumnHeader2, Me.mTotalProv, Me.dMoneda})
        Me.lstFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFacturas.FullRowSelect = True
        Me.lstFacturas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstFacturas.Location = New System.Drawing.Point(15, 130)
        Me.lstFacturas.Name = "lstFacturas"
        Me.lstFacturas.Size = New System.Drawing.Size(844, 69)
        Me.lstFacturas.TabIndex = 234
        Me.lstFacturas.UseCompatibleStateImageBehavior = False
        Me.lstFacturas.View = System.Windows.Forms.View.Details
        '
        'mFacturaProv
        '
        Me.mFacturaProv.Text = "Factura"
        '
        'mFechaProv
        '
        Me.mFechaProv.Text = "Fecha"
        Me.mFechaProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mFechaProv.Width = 72
        '
        'mUnidades
        '
        Me.mUnidades.Text = "Uni"
        Me.mUnidades.Width = 32
        '
        'mSubtotalProv
        '
        Me.mSubtotalProv.Text = "Subtotal"
        Me.mSubtotalProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mSubtotalProv.Width = 72
        '
        'mIVAProv
        '
        Me.mIVAProv.Text = "IVA16"
        Me.mIVAProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mIVAProv.Width = 65
        '
        'mIVAProv11
        '
        Me.mIVAProv11.Text = "IVA11"
        Me.mIVAProv11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IVAImp"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mIVARet10H
        '
        Me.mIVARet10H.Text = "RET10%H"
        Me.mIVARet10H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mIVARet10H.Width = 65
        '
        'mIVARet10A
        '
        Me.mIVARet10A.Text = "RET10%A"
        Me.mIVARet10A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mIVARetencion4
        '
        Me.mIVARetencion4.Text = "RET4%"
        Me.mIVARetencion4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mIVARetencion4.Width = 65
        '
        'mISRHono
        '
        Me.mISRHono.Text = "ISRHono"
        Me.mISRHono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mISRHono.Width = 65
        '
        'mISRArren
        '
        Me.mISRArren.Text = "ISRArren"
        Me.mISRArren.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IEPS"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 65
        '
        'mTotalProv
        '
        Me.mTotalProv.Text = "Importe Total"
        Me.mTotalProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mTotalProv.Width = 97
        '
        'dMoneda
        '
        Me.dMoneda.Text = "Mon"
        Me.dMoneda.Width = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 230
        Me.Label18.Text = "Concepto :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label6.Location = New System.Drawing.Point(523, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 231
        Me.Label6.Text = "Notas de Credito/Cargo"
        '
        'cbxConcepto
        '
        Me.cbxConcepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxConcepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxConcepto.BackColor = System.Drawing.SystemColors.Info
        Me.cbxConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxConcepto.FormattingEnabled = True
        Me.cbxConcepto.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbxConcepto.Location = New System.Drawing.Point(70, 81)
        Me.cbxConcepto.Name = "cbxConcepto"
        Me.cbxConcepto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxConcepto.Size = New System.Drawing.Size(173, 20)
        Me.cbxConcepto.TabIndex = 5
        '
        'lstNotas
        '
        Me.lstNotas.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lstNotas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nFolio, Me.nFolioNC, Me.dFecha, Me.Concepto, Me.nImporte, Me.nTipoMov, Me.nTipoPol, Me.nPoliza})
        Me.lstNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.lstNotas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstNotas.FullRowSelect = True
        Me.lstNotas.Location = New System.Drawing.Point(526, 27)
        Me.lstNotas.Name = "lstNotas"
        Me.lstNotas.Size = New System.Drawing.Size(333, 93)
        Me.lstNotas.TabIndex = 229
        Me.lstNotas.UseCompatibleStateImageBehavior = False
        Me.lstNotas.View = System.Windows.Forms.View.Details
        '
        'nFolio
        '
        Me.nFolio.Text = "ID"
        Me.nFolio.Width = 28
        '
        'nFolioNC
        '
        Me.nFolioNC.Text = "Nota"
        '
        'dFecha
        '
        Me.dFecha.Text = "Fecha"
        Me.dFecha.Width = 69
        '
        'Concepto
        '
        Me.Concepto.Text = "Concepto"
        Me.Concepto.Width = 135
        '
        'nImporte
        '
        Me.nImporte.Text = "Importe"
        Me.nImporte.Width = 71
        '
        'nTipoMov
        '
        Me.nTipoMov.Text = "TipoMov"
        Me.nTipoMov.Width = 54
        '
        'nTipoPol
        '
        Me.nTipoPol.Text = "TipoPol"
        Me.nTipoPol.Width = 49
        '
        'nPoliza
        '
        Me.nPoliza.Text = "Poliza"
        Me.nPoliza.Width = 41
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label17.Location = New System.Drawing.Point(12, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 228
        Me.Label17.Text = "Folio CR :"
        '
        'txtFolioContraRecibo
        '
        Me.txtFolioContraRecibo.Enabled = False
        Me.txtFolioContraRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolioContraRecibo.Location = New System.Drawing.Point(70, 35)
        Me.txtFolioContraRecibo.Name = "txtFolioContraRecibo"
        Me.txtFolioContraRecibo.Size = New System.Drawing.Size(63, 18)
        Me.txtFolioContraRecibo.TabIndex = 227
        Me.txtFolioContraRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label11.Location = New System.Drawing.Point(176, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 223
        Me.Label11.Text = "Saldo :"
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(224, 56)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(66, 18)
        Me.txtSaldo.TabIndex = 224
        Me.txtSaldo.Text = "0.00"
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.Enabled = False
        Me.txtIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVA.Location = New System.Drawing.Point(379, 35)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(70, 18)
        Me.txtIVA.TabIndex = 222
        Me.txtIVA.Text = "0.00"
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label13.Location = New System.Drawing.Point(349, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 221
        Me.Label13.Text = "Iva :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario, Me.PgsGrabar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 449)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(882, 22)
        Me.StatusStrip1.TabIndex = 231
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(256, 17)
        Me.ToolStripStatusLabel1.Text = "Desarrollo de Engordas Estabuladas S.A. de C.V."
        '
        'STBlblUsuario
        '
        Me.STBlblUsuario.Name = "STBlblUsuario"
        Me.STBlblUsuario.Size = New System.Drawing.Size(80, 17)
        Me.STBlblUsuario.Text = "STBlblUsuario"
        '
        'PgsGrabar
        '
        Me.PgsGrabar.Name = "PgsGrabar"
        Me.PgsGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PgsGrabar.Size = New System.Drawing.Size(185, 16)
        Me.PgsGrabar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.WindowsApplication1.My.Resources.Resources.file_new_C_mayseg
        Me.btnNuevo.Location = New System.Drawing.Point(749, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Image = Global.WindowsApplication1.My.Resources.Resources.print
        Me.btnImprimir.Location = New System.Drawing.Point(835, 3)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(37, 38)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Image = Global.WindowsApplication1.My.Resources.Resources.save_C_mayseg
        Me.BtnGuardar.Location = New System.Drawing.Point(792, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DGVCuentas
        '
        Me.DGVCuentas.AllowUserToAddRows = False
        Me.DGVCuentas.AllowUserToDeleteRows = False
        Me.DGVCuentas.AllowUserToResizeColumns = False
        Me.DGVCuentas.AllowUserToResizeRows = False
        Me.DGVCuentas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVCuentas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGVCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.5!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DGVCuentas.ColumnHeadersHeight = 20
        Me.DGVCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuenta, Me.descripcion, Me.importe})
        Me.DGVCuentas.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCuentas.DefaultCellStyle = DataGridViewCellStyle27
        Me.DGVCuentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGVCuentas.Enabled = False
        Me.DGVCuentas.Location = New System.Drawing.Point(588, 100)
        Me.DGVCuentas.MultiSelect = False
        Me.DGVCuentas.Name = "DGVCuentas"
        Me.DGVCuentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGVCuentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCuentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.DGVCuentas.RowHeadersVisible = False
        Me.DGVCuentas.RowHeadersWidth = 20
        Me.DGVCuentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCuentas.Size = New System.Drawing.Size(286, 119)
        Me.DGVCuentas.TabIndex = 232
        '
        'cuenta
        '
        Me.cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.Format = "N0"
        Me.cuenta.DefaultCellStyle = DataGridViewCellStyle24
        Me.cuenta.HeaderText = "Cuenta"
        Me.cuenta.MaxInputLength = 8
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cuenta.Width = 90
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.descripcion.DefaultCellStyle = DataGridViewCellStyle25
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.descripcion.Width = 140
        '
        'importe
        '
        Me.importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.importe.DefaultCellStyle = DataGridViewCellStyle26
        Me.importe.HeaderText = "Importe"
        Me.importe.MaxInputLength = 8
        Me.importe.Name = "importe"
        Me.importe.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.importe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.importe.Width = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label8.Location = New System.Drawing.Point(586, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 233
        Me.Label8.Text = "Importe NC :"
        '
        'txtImporteNC
        '
        Me.txtImporteNC.Enabled = False
        Me.txtImporteNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteNC.Location = New System.Drawing.Point(657, 223)
        Me.txtImporteNC.Name = "txtImporteNC"
        Me.txtImporteNC.Size = New System.Drawing.Size(59, 18)
        Me.txtImporteNC.TabIndex = 234
        Me.txtImporteNC.Text = "0.00"
        Me.txtImporteNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label10.Location = New System.Drawing.Point(726, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 235
        Me.Label10.Text = "Importe Cuen :"
        '
        'txtSumaCuenta
        '
        Me.txtSumaCuenta.Enabled = False
        Me.txtSumaCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSumaCuenta.Location = New System.Drawing.Point(808, 223)
        Me.txtSumaCuenta.Name = "txtSumaCuenta"
        Me.txtSumaCuenta.Size = New System.Drawing.Size(66, 18)
        Me.txtSumaCuenta.TabIndex = 236
        Me.txtSumaCuenta.Text = "0.00"
        Me.txtSumaCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 471)
        Me.Controls.Add(Me.txtFolioSig)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSumaCuenta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtImporteNC)
        Me.Controls.Add(Me.DGVCuentas)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGVFacturas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas Credito/Cargo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DGVCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents btnBusca As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtFolioSig As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbxMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFac As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFolioContraRecibo As System.Windows.Forms.TextBox
    Friend WithEvents dCodProv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dfolioRP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dFechaDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dFechaProg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mIVARet4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dTotDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mIVA11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mIVAIMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mIVARetHon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mIVARetArr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mISRHon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mISRArr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mIEPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mTipoCambio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbxConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lstNotas As System.Windows.Forms.ListView
    Friend WithEvents nFolio As System.Windows.Forms.ColumnHeader
    Friend WithEvents nFolioNC As System.Windows.Forms.ColumnHeader
    Friend WithEvents dFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents Concepto As System.Windows.Forms.ColumnHeader
    Friend WithEvents nImporte As System.Windows.Forms.ColumnHeader
    Friend WithEvents nTipoMov As System.Windows.Forms.ColumnHeader
    Friend WithEvents nTipoPol As System.Windows.Forms.ColumnHeader
    Friend WithEvents nPoliza As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkImpPoliza As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PgsGrabar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstFacturas As System.Windows.Forms.ListView
    Friend WithEvents mFacturaProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents mFechaProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents mUnidades As System.Windows.Forms.ColumnHeader
    Friend WithEvents mSubtotalProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVAProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVAProv11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVARet10H As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVARet10A As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVARetencion4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents mISRHono As System.Windows.Forms.ColumnHeader
    Friend WithEvents mISRArren As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents mTotalProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents dMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAgregarFactura As System.Windows.Forms.Button
    Friend WithEvents DGVCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtImporteNC As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSumaCuenta As System.Windows.Forms.TextBox
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtIvaMax As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
End Class
