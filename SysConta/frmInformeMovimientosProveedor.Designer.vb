<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeMovimientosProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformeMovimientosProveedor))
        Me.lstProveedor = New System.Windows.Forms.ListView()
        Me.CodigoProveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Proveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFchIni = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFchFin = New System.Windows.Forms.DateTimePicker()
        Me.Gbx2 = New System.Windows.Forms.GroupBox()
        Me.Lblcodigo = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Gbx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstProveedor
        '
        Me.lstProveedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodigoProveedor, Me.Proveedor})
        Me.lstProveedor.FullRowSelect = True
        Me.lstProveedor.GridLines = True
        Me.lstProveedor.Location = New System.Drawing.Point(236, 106)
        Me.lstProveedor.Name = "lstProveedor"
        Me.lstProveedor.Size = New System.Drawing.Size(278, 140)
        Me.lstProveedor.TabIndex = 90
        Me.lstProveedor.UseCompatibleStateImageBehavior = False
        Me.lstProveedor.View = System.Windows.Forms.View.Details
        '
        'CodigoProveedor
        '
        Me.CodigoProveedor.Text = "CodProveedor"
        Me.CodigoProveedor.Width = 81
        '
        'Proveedor
        '
        Me.Proveedor.Text = "Proveedor"
        Me.Proveedor.Width = 173
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtBuscar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TxtBuscar.Location = New System.Drawing.Point(279, 78)
        Me.TxtBuscar.MaxLength = 90
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(235, 22)
        Me.TxtBuscar.TabIndex = 123
        Me.TxtBuscar.Text = "Buscar Proveedor"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(236, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 30)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 284)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(526, 22)
        Me.StatusStrip1.TabIndex = 125
        Me.StatusStrip1.Text = "Desarrollo de Engordas Estabuladas S.A. de C.V."
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
        Me.btnImprimir.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnImprimir.Image = Global.WindowsApplication1.My.Resources.Resources.print
        Me.btnImprimir.Location = New System.Drawing.Point(464, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(37, 38)
        Me.btnImprimir.TabIndex = 126
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir")
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 535
        Me.LineShape3.X2 = 36
        Me.LineShape3.Y1 = 53
        Me.LineShape3.Y2 = 53
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(526, 306)
        Me.ShapeContainer1.TabIndex = 127
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(32, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 24)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Informe de Movimientos de Proveedor"
        '
        'dtpFchIni
        '
        Me.dtpFchIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFchIni.Location = New System.Drawing.Point(90, 33)
        Me.dtpFchIni.Name = "dtpFchIni"
        Me.dtpFchIni.Size = New System.Drawing.Size(88, 20)
        Me.dtpFchIni.TabIndex = 193
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFchFin)
        Me.GroupBox1.Controls.Add(Me.dtpFchIni)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 113)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "FECHA FINAL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 12)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "FECHA INICIAL:"
        '
        'dtpFchFin
        '
        Me.dtpFchFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFchFin.Location = New System.Drawing.Point(90, 74)
        Me.dtpFchFin.Name = "dtpFchFin"
        Me.dtpFchFin.Size = New System.Drawing.Size(88, 20)
        Me.dtpFchFin.TabIndex = 194
        '
        'Gbx2
        '
        Me.Gbx2.Controls.Add(Me.Lblcodigo)
        Me.Gbx2.Controls.Add(Me.TxtCodigo)
        Me.Gbx2.Location = New System.Drawing.Point(21, 73)
        Me.Gbx2.Name = "Gbx2"
        Me.Gbx2.Size = New System.Drawing.Size(194, 58)
        Me.Gbx2.TabIndex = 195
        Me.Gbx2.TabStop = False
        Me.Gbx2.Text = "Codigo de Proveedor"
        '
        'Lblcodigo
        '
        Me.Lblcodigo.AutoSize = True
        Me.Lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcodigo.Location = New System.Drawing.Point(12, 27)
        Me.Lblcodigo.Name = "Lblcodigo"
        Me.Lblcodigo.Size = New System.Drawing.Size(49, 13)
        Me.Lblcodigo.TabIndex = 18
        Me.Lblcodigo.Text = "Codigo : "
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(90, 24)
        Me.TxtCodigo.MaxLength = 4
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(88, 20)
        Me.TxtCodigo.TabIndex = 0
        '
        'frmInformeMovimientosProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 306)
        Me.Controls.Add(Me.Gbx2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.lstProveedor)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformeMovimientosProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Movimientos Proveedor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gbx2.ResumeLayout(False)
        Me.Gbx2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstProveedor As System.Windows.Forms.ListView
    Friend WithEvents CodigoProveedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Proveedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFchIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFchFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Gbx2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lblcodigo As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
