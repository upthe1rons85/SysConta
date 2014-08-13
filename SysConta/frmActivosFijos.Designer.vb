<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivosFijos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivosFijos))
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.LblBancos = New System.Windows.Forms.Label()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabDetalle = New System.Windows.Forms.TabControl()
        Me.TabGeneral = New System.Windows.Forms.TabPage()
        Me.CbxCecos = New System.Windows.Forms.ComboBox()

        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxTipoActivoDet = New System.Windows.Forms.ComboBox()
        Me.GbxAdquisicion = New System.Windows.Forms.GroupBox()
        Me.DtpFechaUso = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaAdquisicion = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDedInvAnual = New System.Windows.Forms.TextBox()
        Me.LblDeduccionInvAnual = New System.Windows.Forms.Label()
        Me.GbxCuentas = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtPorcDepr = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LstDatos = New System.Windows.Forms.ListView()
        Me.Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Depto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeduccionInvAnuall = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MontoOriginal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaAdqusicion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaUso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CuentaActivo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CuentaDepreciacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cecos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GbxTipo = New System.Windows.Forms.GroupBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxTipoActivoGen = New System.Windows.Forms.ComboBox()
        Me.TbcControl = New System.Windows.Forms.TabControl()
        Me.STBlblUsuario = New System.Windows.Forms.StatusStrip()

        Me.BtnCtaActivo = New System.Windows.Forms.Button()
        Me.BtnCtaDepreciacion = New System.Windows.Forms.Button()
        Me.TxtCtaDepreciacion = New System.Windows.Forms.TextBox()
        Me.TxtCtaActivo = New System.Windows.Forms.TextBox()

        Me.TabPage2.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        Me.GbxAdquisicion.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GbxCuentas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GbxTipo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbcControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(542, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.BtnNuevo.TabIndex = 17
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(585, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(37, 38)
        Me.btnModificar.TabIndex = 18
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(628, 12)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(37, 38)
        Me.BtnEliminar.TabIndex = 19
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Enabled = False
        Me.BtnGrabar.Image = CType(resources.GetObject("BtnGrabar.Image"), System.Drawing.Image)
        Me.BtnGrabar.Location = New System.Drawing.Point(499, 12)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGrabar.TabIndex = 16
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'LblBancos
        '
        Me.LblBancos.AutoSize = True
        Me.LblBancos.BackColor = System.Drawing.Color.Transparent
        Me.LblBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBancos.ForeColor = System.Drawing.Color.Navy
        Me.LblBancos.Location = New System.Drawing.Point(39, 21)
        Me.LblBancos.Name = "LblBancos"
        Me.LblBancos.Size = New System.Drawing.Size(192, 29)
        Me.LblBancos.TabIndex = 20
        Me.LblBancos.Text = "Catalogo Activos"
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightSlateGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.SelectionColor = System.Drawing.SystemColors.InactiveCaption
        Me.LineShape2.X1 = 34
        Me.LineShape2.X2 = 717
        Me.LineShape2.Y1 = 62
        Me.LineShape2.Y2 = 62
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 33
        Me.LineShape1.X2 = 715
        Me.LineShape1.Y1 = 61
        Me.LineShape1.Y2 = 61
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(708, 362)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabDetalle)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(671, 201)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.TabGeneral)
        Me.TabDetalle.Controls.Add(Me.TabPage5)
        Me.TabDetalle.Location = New System.Drawing.Point(6, 16)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.SelectedIndex = 0
        Me.TabDetalle.Size = New System.Drawing.Size(662, 185)
        Me.TabDetalle.TabIndex = 0
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.CbxCecos)
        Me.TabGeneral.Controls.Add(Me.Label2)
        Me.TabGeneral.Controls.Add(Me.CbxTipoActivoDet)
        Me.TabGeneral.Controls.Add(Me.GbxAdquisicion)
        Me.TabGeneral.Controls.Add(Me.TxtDescripcion)
        Me.TabGeneral.Controls.Add(Me.Label5)
        Me.TabGeneral.Controls.Add(Me.Label4)
        Me.TabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGeneral.Size = New System.Drawing.Size(654, 159)
        Me.TabGeneral.TabIndex = 0
        Me.TabGeneral.Text = "Datos Generales"
        Me.TabGeneral.UseVisualStyleBackColor = True
        '
        'CbxCecos
        '
        Me.CbxCecos.Enabled = False
        Me.CbxCecos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCecos.FormattingEnabled = True
        Me.CbxCecos.Location = New System.Drawing.Point(100, 94)
        Me.CbxCecos.Name = "CbxCecos"
        Me.CbxCecos.Size = New System.Drawing.Size(211, 20)
        Me.CbxCecos.TabIndex = 6
        '
        'cbxCecos
        '
        Me.cbxCecos.Enabled = False
        Me.cbxCecos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCecos.FormattingEnabled = True
        Me.cbxCecos.Location = New System.Drawing.Point(100, 94)
        Me.cbxCecos.Name = "cbxCecos"
        Me.cbxCecos.Size = New System.Drawing.Size(211, 20)
        Me.cbxCecos.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cecos :"
        '
        'CbxTipoActivoDet
        '
        Me.CbxTipoActivoDet.Enabled = False
        Me.CbxTipoActivoDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxTipoActivoDet.FormattingEnabled = True
        Me.CbxTipoActivoDet.Location = New System.Drawing.Point(100, 42)
        Me.CbxTipoActivoDet.Name = "CbxTipoActivoDet"
        Me.CbxTipoActivoDet.Size = New System.Drawing.Size(211, 20)
        Me.CbxTipoActivoDet.TabIndex = 1
        '
        'GbxAdquisicion
        '
        Me.GbxAdquisicion.Controls.Add(Me.DtpFechaUso)
        Me.GbxAdquisicion.Controls.Add(Me.DtpFechaAdquisicion)
        Me.GbxAdquisicion.Controls.Add(Me.Label8)
        Me.GbxAdquisicion.Controls.Add(Me.Label7)
        Me.GbxAdquisicion.Enabled = False
        Me.GbxAdquisicion.Location = New System.Drawing.Point(333, 30)
        Me.GbxAdquisicion.Name = "GbxAdquisicion"
        Me.GbxAdquisicion.Size = New System.Drawing.Size(282, 91)
        Me.GbxAdquisicion.TabIndex = 4
        Me.GbxAdquisicion.TabStop = False
        Me.GbxAdquisicion.Text = "Adquisicion"
        '
        'DtpFechaUso
        '
        Me.DtpFechaUso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaUso.Location = New System.Drawing.Point(155, 50)
        Me.DtpFechaUso.Name = "DtpFechaUso"
        Me.DtpFechaUso.Size = New System.Drawing.Size(112, 20)
        Me.DtpFechaUso.TabIndex = 3
        '
        'DtpFechaAdquisicion
        '
        Me.DtpFechaAdquisicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaAdquisicion.Location = New System.Drawing.Point(155, 22)
        Me.DtpFechaAdquisicion.Name = "DtpFechaAdquisicion"
        Me.DtpFechaAdquisicion.Size = New System.Drawing.Size(112, 20)
        Me.DtpFechaAdquisicion.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha Uso :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fecha Adquisicion :"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(100, 68)
        Me.TxtDescripcion.MaxLength = 80
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(211, 20)
        Me.TxtDescripcion.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tipo Activo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descripcion :"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TxtMonto)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.TxtDedInvAnual)
        Me.TabPage5.Controls.Add(Me.LblDeduccionInvAnual)
        Me.TabPage5.Controls.Add(Me.GbxCuentas)
        Me.TabPage5.Controls.Add(Me.TxtPorcDepr)
        Me.TabPage5.Controls.Add(Me.Label12)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(654, 159)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Datos Contables"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TxtMonto
        '
        Me.TxtMonto.Enabled = False
        Me.TxtMonto.Location = New System.Drawing.Point(521, 42)
        Me.TxtMonto.MaxLength = 22
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(85, 20)
        Me.TxtMonto.TabIndex = 33
        Me.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(421, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Monto :"
        '
        'TxtDedInvAnual
        '
        Me.TxtDedInvAnual.Enabled = False
        Me.TxtDedInvAnual.Location = New System.Drawing.Point(546, 98)
        Me.TxtDedInvAnual.MaxLength = 22
        Me.TxtDedInvAnual.Name = "TxtDedInvAnual"
        Me.TxtDedInvAnual.Size = New System.Drawing.Size(60, 20)
        Me.TxtDedInvAnual.TabIndex = 31
        Me.TxtDedInvAnual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblDeduccionInvAnual
        '
        Me.LblDeduccionInvAnual.AutoSize = True
        Me.LblDeduccionInvAnual.Location = New System.Drawing.Point(421, 101)
        Me.LblDeduccionInvAnual.Name = "LblDeduccionInvAnual"
        Me.LblDeduccionInvAnual.Size = New System.Drawing.Size(119, 13)
        Me.LblDeduccionInvAnual.TabIndex = 30
        Me.LblDeduccionInvAnual.Text = "Deduccion Inv. Anual : "
        '
        'GbxCuentas
        '
        Me.GbxCuentas.Controls.Add(Me.BtnCtaDepreciacion)
        Me.GbxCuentas.Controls.Add(Me.BtnCtaActivo)
        Me.GbxCuentas.Controls.Add(Me.TxtCtaDepreciacion)
        Me.GbxCuentas.Controls.Add(Me.TxtCtaActivo)
        Me.GbxCuentas.Controls.Add(Me.Label15)
        Me.GbxCuentas.Controls.Add(Me.Label14)
        Me.GbxCuentas.Enabled = False
        Me.GbxCuentas.Location = New System.Drawing.Point(13, 28)
        Me.GbxCuentas.Name = "GbxCuentas"
        Me.GbxCuentas.Size = New System.Drawing.Size(363, 114)
        Me.GbxCuentas.TabIndex = 28
        Me.GbxCuentas.TabStop = False
        Me.GbxCuentas.Text = "Cuentas "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Cuenta Depreciacion :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Cuenta Activo :"
        '
        'TxtPorcDepr
        '
        Me.TxtPorcDepr.Enabled = False
        Me.TxtPorcDepr.Location = New System.Drawing.Point(554, 70)
        Me.TxtPorcDepr.MaxLength = 22
        Me.TxtPorcDepr.Name = "TxtPorcDepr"
        Me.TxtPorcDepr.Size = New System.Drawing.Size(52, 20)
        Me.TxtPorcDepr.TabIndex = 25
        Me.TxtPorcDepr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(421, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Porc. Depreciacion :"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LstDatos)
        Me.TabPage1.Controls.Add(Me.GbxTipo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(671, 201)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LstDatos
        '
        Me.LstDatos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Descripcion, Me.Depto, Me.DeduccionInvAnuall, Me.MontoOriginal, Me.FechaAdqusicion, Me.FechaUso, Me.CuentaActivo, Me.CuentaDepreciacion, Me.Cecos})
        Me.LstDatos.Location = New System.Drawing.Point(10, 53)
        Me.LstDatos.Name = "LstDatos"
        Me.LstDatos.Size = New System.Drawing.Size(651, 138)
        Me.LstDatos.TabIndex = 6
        Me.LstDatos.UseCompatibleStateImageBehavior = False
        Me.LstDatos.View = System.Windows.Forms.View.Details
        '
        'Descripcion
        '
        Me.Descripcion.Text = "Descripcion"
        Me.Descripcion.Width = 100
        '
        'Depto
        '
        Me.Depto.Text = "Departamento"
        Me.Depto.Width = 80
        '
        'DeduccionInvAnuall
        '
        Me.DeduccionInvAnuall.Text = "Ded. Inv.Anual"
        Me.DeduccionInvAnuall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DeduccionInvAnuall.Width = 95
        '
        'MontoOriginal
        '
        Me.MontoOriginal.Text = "Monto"
        Me.MontoOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FechaAdqusicion
        '
        Me.FechaAdqusicion.Text = "Fecha Adqusicion"
        Me.FechaAdqusicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FechaAdqusicion.Width = 100
        '
        'FechaUso
        '
        Me.FechaUso.Text = "Fecha Uso"
        Me.FechaUso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FechaUso.Width = 95
        '
        'CuentaActivo
        '
        Me.CuentaActivo.Text = "Cuenta Activo"
        Me.CuentaActivo.Width = 100
        '
        'CuentaDepreciacion
        '
        Me.CuentaDepreciacion.Text = "Cuenta Depreciacion"
        Me.CuentaDepreciacion.Width = 100
        '
        'Cecos
        '
        Me.Cecos.Text = "Centro Costos"
        Me.Cecos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Cecos.Width = 80
        '
        'GbxTipo
        '
        Me.GbxTipo.Controls.Add(Me.TxtBuscar)
        Me.GbxTipo.Controls.Add(Me.PictureBox1)
        Me.GbxTipo.Controls.Add(Me.Label1)
        Me.GbxTipo.Controls.Add(Me.CbxTipoActivoGen)
        Me.GbxTipo.Location = New System.Drawing.Point(10, 6)
        Me.GbxTipo.Name = "GbxTipo"
        Me.GbxTipo.Size = New System.Drawing.Size(653, 41)
        Me.GbxTipo.TabIndex = 4
        Me.GbxTipo.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtBuscar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TxtBuscar.Location = New System.Drawing.Point(393, 14)
        Me.TxtBuscar.MaxLength = 80
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(251, 22)
        Me.TxtBuscar.TabIndex = 90
        Me.TxtBuscar.Text = "Buscar Descripcion  Activo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(350, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 24)
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de Activo :"
        '
        'CbxTipoActivoGen
        '
        Me.CbxTipoActivoGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxTipoActivoGen.FormattingEnabled = True
        Me.CbxTipoActivoGen.Location = New System.Drawing.Point(97, 15)
        Me.CbxTipoActivoGen.Name = "CbxTipoActivoGen"
        Me.CbxTipoActivoGen.Size = New System.Drawing.Size(227, 20)
        Me.CbxTipoActivoGen.TabIndex = 0
        '
        'TbcControl
        '
        Me.TbcControl.Controls.Add(Me.TabPage1)
        Me.TbcControl.Controls.Add(Me.TabPage2)
        Me.TbcControl.Location = New System.Drawing.Point(17, 100)
        Me.TbcControl.Name = "TbcControl"
        Me.TbcControl.SelectedIndex = 0
        Me.TbcControl.Size = New System.Drawing.Size(679, 227)
        Me.TbcControl.TabIndex = 0
        '
        'STBlblUsuario
        '
        Me.STBlblUsuario.Location = New System.Drawing.Point(0, 340)
        Me.STBlblUsuario.Name = "STBlblUsuario"
        Me.STBlblUsuario.Size = New System.Drawing.Size(708, 22)
        Me.STBlblUsuario.TabIndex = 22
        Me.STBlblUsuario.Text = "StatusStrip1"
        '
        'BtnCtaActivo
        '
        Me.BtnCtaActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCtaActivo.Location = New System.Drawing.Point(286, 23)
        Me.BtnCtaActivo.Name = "BtnCtaActivo"
        Me.BtnCtaActivo.Size = New System.Drawing.Size(60, 20)
        Me.BtnCtaActivo.TabIndex = 34
        Me.BtnCtaActivo.Text = "Consultar"
        Me.BtnCtaActivo.UseVisualStyleBackColor = True
        '
        'BtnCtaDepreciacion
        '
        Me.BtnCtaDepreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCtaDepreciacion.Location = New System.Drawing.Point(286, 65)
        Me.BtnCtaDepreciacion.Name = "BtnCtaDepreciacion"
        Me.BtnCtaDepreciacion.Size = New System.Drawing.Size(60, 20)
        Me.BtnCtaDepreciacion.TabIndex = 35
        Me.BtnCtaDepreciacion.Text = "Consultar"
        Me.BtnCtaDepreciacion.UseVisualStyleBackColor = True
        '
        'TxtCtaDepreciacion
        '
        Me.TxtCtaDepreciacion.Location = New System.Drawing.Point(135, 66)
        Me.TxtCtaDepreciacion.MaxLength = 14
        Me.TxtCtaDepreciacion.Name = "TxtCtaDepreciacion"
        Me.TxtCtaDepreciacion.Size = New System.Drawing.Size(138, 20)
        Me.TxtCtaDepreciacion.TabIndex = 33
        '
        'TxtCtaActivo
        '
        Me.TxtCtaActivo.Location = New System.Drawing.Point(135, 24)
        Me.TxtCtaActivo.MaxLength = 14
        Me.TxtCtaActivo.Name = "TxtCtaActivo"
        Me.TxtCtaActivo.Size = New System.Drawing.Size(138, 20)
        Me.TxtCtaActivo.TabIndex = 33
        '
        'frmActivosFijos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 362)
        Me.Controls.Add(Me.STBlblUsuario)
        Me.Controls.Add(Me.LblBancos)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.TbcControl)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmActivosFijos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activos Fijos"
        Me.TabPage2.ResumeLayout(False)
        Me.TabDetalle.ResumeLayout(False)
        Me.TabGeneral.ResumeLayout(False)
        Me.TabGeneral.PerformLayout()
        Me.GbxAdquisicion.ResumeLayout(False)
        Me.GbxAdquisicion.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GbxCuentas.ResumeLayout(False)
        Me.GbxCuentas.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GbxTipo.ResumeLayout(False)
        Me.GbxTipo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbcControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents LblBancos As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabDetalle As System.Windows.Forms.TabControl
    Friend WithEvents TabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents CbxTipoActivoDet As System.Windows.Forms.ComboBox
    Friend WithEvents GbxAdquisicion As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaUso As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaAdquisicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TxtDedInvAnual As System.Windows.Forms.TextBox
    Friend WithEvents LblDeduccionInvAnual As System.Windows.Forms.Label
    Friend WithEvents GbxCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtPorcDepr As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GbxTipo As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbxTipoActivoGen As System.Windows.Forms.ComboBox
    Friend WithEvents TbcControl As System.Windows.Forms.TabControl
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents STBlblUsuario As System.Windows.Forms.StatusStrip
    Friend WithEvents LstDatos As System.Windows.Forms.ListView
    Friend WithEvents Descripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeduccionInvAnuall As System.Windows.Forms.ColumnHeader
    Friend WithEvents Depto As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaAdqusicion As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaUso As System.Windows.Forms.ColumnHeader
    Friend WithEvents CuentaActivo As System.Windows.Forms.ColumnHeader
    Friend WithEvents CuentaDepreciacion As System.Windows.Forms.ColumnHeader
    Friend WithEvents MontoOriginal As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxCecos As System.Windows.Forms.ComboBox
    Friend WithEvents Cecos As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnCtaDepreciacion As System.Windows.Forms.Button
    Friend WithEvents BtnCtaActivo As System.Windows.Forms.Button
    Friend WithEvents TxtCtaDepreciacion As System.Windows.Forms.TextBox
    Friend WithEvents TxtCtaActivo As System.Windows.Forms.TextBox
End Class
