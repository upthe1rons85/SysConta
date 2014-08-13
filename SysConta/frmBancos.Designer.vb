<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBancos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBancos))
        Me.LblBancos = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.LblNumCuenta = New System.Windows.Forms.Label()
        Me.LblBanco = New System.Windows.Forms.Label()
        Me.LblSucursal = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblReferencia = New System.Windows.Forms.Label()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.LblTipMoneda = New System.Windows.Forms.Label()
        Me.LblCuentaConta = New System.Windows.Forms.Label()
        Me.LblEstatus = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtBanco = New System.Windows.Forms.TextBox()
        Me.TxtSucursal = New System.Windows.Forms.TextBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtReferencia = New System.Windows.Forms.TextBox()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.Gbx = New System.Windows.Forms.GroupBox()
        Me.TxtNumCheque = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxCtaContable = New System.Windows.Forms.ComboBox()
        Me.RbDolares = New System.Windows.Forms.RadioButton()
        Me.RbPesos = New System.Windows.Forms.RadioButton()
        Me.CbxEstatus = New System.Windows.Forms.ComboBox()
        Me.TxtNumCuenta = New System.Windows.Forms.TextBox()
        Me.Gbx2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstBancos = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Banco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CuentaContable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Gbx.SuspendLayout()
        Me.Gbx2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblBancos
        '
        Me.LblBancos.AutoSize = True
        Me.LblBancos.BackColor = System.Drawing.Color.Transparent
        Me.LblBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBancos.ForeColor = System.Drawing.Color.Navy
        Me.LblBancos.Location = New System.Drawing.Point(50, 44)
        Me.LblBancos.Name = "LblBancos"
        Me.LblBancos.Size = New System.Drawing.Size(291, 29)
        Me.LblBancos.TabIndex = 1
        Me.LblBancos.Text = "Mtto. Catálogo De Bancos"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(586, 38)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.BtnNuevo.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(629, 38)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(37, 38)
        Me.btnModificar.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.btnModificar, "Modificar")
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(715, 38)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(37, 38)
        Me.BtnEliminar.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Image = CType(resources.GetObject("BtnGrabar.Image"), System.Drawing.Image)
        Me.BtnGrabar.Location = New System.Drawing.Point(543, 38)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGrabar.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.BtnGrabar, "Guardar")
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 55
        Me.LineShape1.X2 = 806
        Me.LineShape1.Y1 = 93
        Me.LineShape1.Y2 = 93
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(767, 474)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightSlateGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.SelectionColor = System.Drawing.SystemColors.InactiveCaption
        Me.LineShape2.X1 = 56
        Me.LineShape2.X2 = 808
        Me.LineShape2.Y1 = 94
        Me.LineShape2.Y2 = 94
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Location = New System.Drawing.Point(33, 28)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(46, 13)
        Me.LblCodigo.TabIndex = 29
        Me.LblCodigo.Text = "Codigo :"
        '
        'LblNumCuenta
        '
        Me.LblNumCuenta.AutoSize = True
        Me.LblNumCuenta.Location = New System.Drawing.Point(34, 56)
        Me.LblNumCuenta.Name = "LblNumCuenta"
        Me.LblNumCuenta.Size = New System.Drawing.Size(87, 13)
        Me.LblNumCuenta.TabIndex = 30
        Me.LblNumCuenta.Text = "Numero Cuenta :"
        '
        'LblBanco
        '
        Me.LblBanco.AutoSize = True
        Me.LblBanco.Location = New System.Drawing.Point(34, 30)
        Me.LblBanco.Name = "LblBanco"
        Me.LblBanco.Size = New System.Drawing.Size(44, 13)
        Me.LblBanco.TabIndex = 31
        Me.LblBanco.Text = "Banco :"
        '
        'LblSucursal
        '
        Me.LblSucursal.AutoSize = True
        Me.LblSucursal.Location = New System.Drawing.Point(34, 105)
        Me.LblSucursal.Name = "LblSucursal"
        Me.LblSucursal.Size = New System.Drawing.Size(54, 13)
        Me.LblSucursal.TabIndex = 32
        Me.LblSucursal.Text = "Sucursal :"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(33, 130)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(55, 13)
        Me.LblDomicilio.TabIndex = 33
        Me.LblDomicilio.Text = "Domicilio :"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(33, 155)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(55, 13)
        Me.LblTelefono.TabIndex = 34
        Me.LblTelefono.Text = "Telefono :"
        '
        'LblReferencia
        '
        Me.LblReferencia.AutoSize = True
        Me.LblReferencia.Location = New System.Drawing.Point(33, 80)
        Me.LblReferencia.Name = "LblReferencia"
        Me.LblReferencia.Size = New System.Drawing.Size(65, 13)
        Me.LblReferencia.TabIndex = 35
        Me.LblReferencia.Text = "Referencia :"
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.Location = New System.Drawing.Point(358, 83)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(40, 13)
        Me.LblSaldo.TabIndex = 36
        Me.LblSaldo.Text = "Saldo :"
        '
        'LblTipMoneda
        '
        Me.LblTipMoneda.AutoSize = True
        Me.LblTipMoneda.Location = New System.Drawing.Point(358, 109)
        Me.LblTipMoneda.Name = "LblTipMoneda"
        Me.LblTipMoneda.Size = New System.Drawing.Size(93, 13)
        Me.LblTipMoneda.TabIndex = 37
        Me.LblTipMoneda.Text = "Tipo De Moneda :"
        '
        'LblCuentaConta
        '
        Me.LblCuentaConta.AutoSize = True
        Me.LblCuentaConta.Location = New System.Drawing.Point(359, 135)
        Me.LblCuentaConta.Name = "LblCuentaConta"
        Me.LblCuentaConta.Size = New System.Drawing.Size(92, 13)
        Me.LblCuentaConta.TabIndex = 38
        Me.LblCuentaConta.Text = "Cuenta Contable :"
        '
        'LblEstatus
        '
        Me.LblEstatus.AutoSize = True
        Me.LblEstatus.Location = New System.Drawing.Point(359, 161)
        Me.LblEstatus.Name = "LblEstatus"
        Me.LblEstatus.Size = New System.Drawing.Size(48, 13)
        Me.LblEstatus.TabIndex = 39
        Me.LblEstatus.Text = "Estatus :"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(120, 25)
        Me.TxtCodigo.MaxLength = 10
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(70, 20)
        Me.TxtCodigo.TabIndex = 0
        '
        'TxtBanco
        '
        Me.TxtBanco.Enabled = False
        Me.TxtBanco.Location = New System.Drawing.Point(139, 27)
        Me.TxtBanco.MaxLength = 35
        Me.TxtBanco.Name = "TxtBanco"
        Me.TxtBanco.Size = New System.Drawing.Size(180, 20)
        Me.TxtBanco.TabIndex = 1
        '
        'TxtSucursal
        '
        Me.TxtSucursal.Enabled = False
        Me.TxtSucursal.Location = New System.Drawing.Point(139, 102)
        Me.TxtSucursal.MaxLength = 35
        Me.TxtSucursal.Name = "TxtSucursal"
        Me.TxtSucursal.Size = New System.Drawing.Size(181, 20)
        Me.TxtSucursal.TabIndex = 5
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Enabled = False
        Me.TxtDomicilio.Location = New System.Drawing.Point(139, 127)
        Me.TxtDomicilio.MaxLength = 50
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(181, 20)
        Me.TxtDomicilio.TabIndex = 8
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Enabled = False
        Me.TxtTelefono.Location = New System.Drawing.Point(139, 152)
        Me.TxtTelefono.MaxLength = 25
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(181, 20)
        Me.TxtTelefono.TabIndex = 10
        '
        'TxtReferencia
        '
        Me.TxtReferencia.Enabled = False
        Me.TxtReferencia.Location = New System.Drawing.Point(139, 77)
        Me.TxtReferencia.MaxLength = 40
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(181, 20)
        Me.TxtReferencia.TabIndex = 3
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Enabled = False
        Me.TxtSaldo.Location = New System.Drawing.Point(471, 80)
        Me.TxtSaldo.MaxLength = 10
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(101, 20)
        Me.TxtSaldo.TabIndex = 4
        '
        'Gbx
        '
        Me.Gbx.Controls.Add(Me.TxtNumCheque)
        Me.Gbx.Controls.Add(Me.Label1)
        Me.Gbx.Controls.Add(Me.CbxCtaContable)
        Me.Gbx.Controls.Add(Me.RbDolares)
        Me.Gbx.Controls.Add(Me.RbPesos)
        Me.Gbx.Controls.Add(Me.CbxEstatus)
        Me.Gbx.Controls.Add(Me.TxtSaldo)
        Me.Gbx.Controls.Add(Me.TxtReferencia)
        Me.Gbx.Controls.Add(Me.TxtTelefono)
        Me.Gbx.Controls.Add(Me.TxtDomicilio)
        Me.Gbx.Controls.Add(Me.TxtSucursal)
        Me.Gbx.Controls.Add(Me.TxtBanco)
        Me.Gbx.Controls.Add(Me.TxtNumCuenta)
        Me.Gbx.Controls.Add(Me.LblEstatus)
        Me.Gbx.Controls.Add(Me.LblCuentaConta)
        Me.Gbx.Controls.Add(Me.LblTipMoneda)
        Me.Gbx.Controls.Add(Me.LblSaldo)
        Me.Gbx.Controls.Add(Me.LblReferencia)
        Me.Gbx.Controls.Add(Me.LblTelefono)
        Me.Gbx.Controls.Add(Me.LblDomicilio)
        Me.Gbx.Controls.Add(Me.LblSucursal)
        Me.Gbx.Controls.Add(Me.LblBanco)
        Me.Gbx.Controls.Add(Me.LblNumCuenta)
        Me.Gbx.Location = New System.Drawing.Point(56, 244)
        Me.Gbx.Name = "Gbx"
        Me.Gbx.Size = New System.Drawing.Size(663, 205)
        Me.Gbx.TabIndex = 3
        Me.Gbx.TabStop = False
        '
        'TxtNumCheque
        '
        Me.TxtNumCheque.Enabled = False
        Me.TxtNumCheque.Location = New System.Drawing.Point(470, 53)
        Me.TxtNumCheque.MaxLength = 8
        Me.TxtNumCheque.Name = "TxtNumCheque"
        Me.TxtNumCheque.Size = New System.Drawing.Size(102, 20)
        Me.TxtNumCheque.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(358, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Numero Cheque :"
        '
        'CbxCtaContable
        '
        Me.CbxCtaContable.Enabled = False
        Me.CbxCtaContable.FormattingEnabled = True
        Me.CbxCtaContable.Location = New System.Drawing.Point(471, 131)
        Me.CbxCtaContable.Name = "CbxCtaContable"
        Me.CbxCtaContable.Size = New System.Drawing.Size(179, 21)
        Me.CbxCtaContable.TabIndex = 9
        '
        'RbDolares
        '
        Me.RbDolares.AutoSize = True
        Me.RbDolares.Enabled = False
        Me.RbDolares.Location = New System.Drawing.Point(567, 109)
        Me.RbDolares.Name = "RbDolares"
        Me.RbDolares.Size = New System.Drawing.Size(61, 17)
        Me.RbDolares.TabIndex = 7
        Me.RbDolares.TabStop = True
        Me.RbDolares.Text = "Dolares"
        Me.RbDolares.UseVisualStyleBackColor = True
        '
        'RbPesos
        '
        Me.RbPesos.AutoSize = True
        Me.RbPesos.Checked = True
        Me.RbPesos.Enabled = False
        Me.RbPesos.Location = New System.Drawing.Point(473, 108)
        Me.RbPesos.Name = "RbPesos"
        Me.RbPesos.Size = New System.Drawing.Size(54, 17)
        Me.RbPesos.TabIndex = 6
        Me.RbPesos.TabStop = True
        Me.RbPesos.Text = "Pesos"
        Me.RbPesos.UseVisualStyleBackColor = True
        '
        'CbxEstatus
        '
        Me.CbxEstatus.Enabled = False
        Me.CbxEstatus.FormattingEnabled = True
        Me.CbxEstatus.Location = New System.Drawing.Point(472, 159)
        Me.CbxEstatus.Name = "CbxEstatus"
        Me.CbxEstatus.Size = New System.Drawing.Size(179, 21)
        Me.CbxEstatus.TabIndex = 11
        '
        'TxtNumCuenta
        '
        Me.TxtNumCuenta.Enabled = False
        Me.TxtNumCuenta.Location = New System.Drawing.Point(139, 53)
        Me.TxtNumCuenta.MaxLength = 40
        Me.TxtNumCuenta.Name = "TxtNumCuenta"
        Me.TxtNumCuenta.Size = New System.Drawing.Size(180, 20)
        Me.TxtNumCuenta.TabIndex = 2
        '
        'Gbx2
        '
        Me.Gbx2.Controls.Add(Me.TxtCodigo)
        Me.Gbx2.Controls.Add(Me.LblCodigo)
        Me.Gbx2.Location = New System.Drawing.Point(56, 131)
        Me.Gbx2.Name = "Gbx2"
        Me.Gbx2.Size = New System.Drawing.Size(221, 64)
        Me.Gbx2.TabIndex = 2
        Me.Gbx2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(382, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 30)
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'lstBancos
        '
        Me.lstBancos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Banco, Me.CuentaContable})
        Me.lstBancos.FullRowSelect = True
        Me.lstBancos.GridLines = True
        Me.lstBancos.Location = New System.Drawing.Point(382, 149)
        Me.lstBancos.Name = "lstBancos"
        Me.lstBancos.Size = New System.Drawing.Size(338, 89)
        Me.lstBancos.TabIndex = 17
        Me.lstBancos.UseCompatibleStateImageBehavior = False
        Me.lstBancos.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Tag = ""
        Me.Codigo.Text = "Codigo "
        Me.Codigo.Width = 49
        '
        'Banco
        '
        Me.Banco.Text = "Banco"
        Me.Banco.Width = 178
        '
        'CuentaContable
        '
        Me.CuentaContable.Text = "Cuenta Contable"
        Me.CuentaContable.Width = 121
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtBuscar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TxtBuscar.Location = New System.Drawing.Point(421, 106)
        Me.TxtBuscar.MaxLength = 90
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(299, 22)
        Me.TxtBuscar.TabIndex = 16
        Me.TxtBuscar.Text = "Buscar Banco"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 452)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(767, 22)
        Me.StatusStrip1.TabIndex = 89
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
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.WindowsApplication1.My.Resources.Resources.print
        Me.btnImprimir.Location = New System.Drawing.Point(672, 38)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(37, 38)
        Me.btnImprimir.TabIndex = 90
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 474)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstBancos)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Gbx2)
        Me.Controls.Add(Me.Gbx)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.LblBancos)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bancos"
        Me.Gbx.ResumeLayout(False)
        Me.Gbx.PerformLayout()
        Me.Gbx2.ResumeLayout(False)
        Me.Gbx2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents LblBancos As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents LblNumCuenta As System.Windows.Forms.Label
    Friend WithEvents LblBanco As System.Windows.Forms.Label
    Friend WithEvents LblSucursal As System.Windows.Forms.Label
    Friend WithEvents LblDomicilio As System.Windows.Forms.Label
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents LblReferencia As System.Windows.Forms.Label
    Friend WithEvents LblSaldo As System.Windows.Forms.Label
    Friend WithEvents LblTipMoneda As System.Windows.Forms.Label
    Friend WithEvents LblCuentaConta As System.Windows.Forms.Label
    Friend WithEvents LblEstatus As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtBanco As System.Windows.Forms.TextBox
    Friend WithEvents TxtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents TxtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TxtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Gbx As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstBancos As System.Windows.Forms.ListView
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Banco As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents CbxEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents RbDolares As System.Windows.Forms.RadioButton
    Friend WithEvents RbPesos As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TxtNumCuenta As System.Windows.Forms.TextBox
    Friend WithEvents CbxCtaContable As System.Windows.Forms.ComboBox
    Friend WithEvents CuentaContable As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtNumCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
