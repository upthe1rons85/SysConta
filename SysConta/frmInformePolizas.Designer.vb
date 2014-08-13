<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformePolizas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformePolizas))
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.brnDesTodo = New System.Windows.Forms.Button()
        Me.brnSelTodo = New System.Windows.Forms.Button()
        Me.lstSeleccionados = New System.Windows.Forms.ListView()
        Me.mTipoMovimientoSel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mDescripcionSel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mTipoMovSel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstTiposMovimiento = New System.Windows.Forms.ListView()
        Me.mTipoMovimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mTipoMov = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PgsGrabar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpfechafin = New System.Windows.Forms.DateTimePicker()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtPolizaIni = New System.Windows.Forms.TextBox()
        Me.txtPolizaFin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rFecha = New System.Windows.Forms.RadioButton()
        Me.rPoliza = New System.Windows.Forms.RadioButton()
        Me.chPolizaDif = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 460
        Me.LineShape3.X2 = 7
        Me.LineShape3.Y1 = 50
        Me.LineShape3.Y2 = 50
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(481, 337)
        Me.ShapeContainer1.TabIndex = 93
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Informe de Polizas"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(106, 81)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaIni.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 12)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "FECHA INICIAL:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.brnDesTodo)
        Me.GroupBox1.Controls.Add(Me.brnSelTodo)
        Me.GroupBox1.Controls.Add(Me.lstSeleccionados)
        Me.GroupBox1.Controls.Add(Me.lstTiposMovimiento)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 175)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO DE MOVIMIENTO"
        '
        'brnDesTodo
        '
        Me.brnDesTodo.BackColor = System.Drawing.Color.White
        Me.brnDesTodo.Location = New System.Drawing.Point(209, 117)
        Me.brnDesTodo.Name = "brnDesTodo"
        Me.brnDesTodo.Size = New System.Drawing.Size(38, 23)
        Me.brnDesTodo.TabIndex = 11
        Me.brnDesTodo.Text = "<Todo"
        Me.brnDesTodo.UseVisualStyleBackColor = False
        '
        'brnSelTodo
        '
        Me.brnSelTodo.BackColor = System.Drawing.Color.White
        Me.brnSelTodo.Location = New System.Drawing.Point(209, 146)
        Me.brnSelTodo.Name = "brnSelTodo"
        Me.brnSelTodo.Size = New System.Drawing.Size(38, 23)
        Me.brnSelTodo.TabIndex = 12
        Me.brnSelTodo.Text = "Todo>"
        Me.brnSelTodo.UseVisualStyleBackColor = False
        '
        'lstSeleccionados
        '
        Me.lstSeleccionados.BackColor = System.Drawing.SystemColors.Info
        Me.lstSeleccionados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mTipoMovimientoSel, Me.mDescripcionSel, Me.mTipoMovSel})
        Me.lstSeleccionados.FullRowSelect = True
        Me.lstSeleccionados.GridLines = True
        Me.lstSeleccionados.Location = New System.Drawing.Point(252, 16)
        Me.lstSeleccionados.Name = "lstSeleccionados"
        Me.lstSeleccionados.Size = New System.Drawing.Size(197, 153)
        Me.lstSeleccionados.TabIndex = 1
        Me.lstSeleccionados.UseCompatibleStateImageBehavior = False
        Me.lstSeleccionados.View = System.Windows.Forms.View.Details
        '
        'mTipoMovimientoSel
        '
        Me.mTipoMovimientoSel.Tag = ""
        Me.mTipoMovimientoSel.Text = "Cod"
        Me.mTipoMovimientoSel.Width = 30
        '
        'mDescripcionSel
        '
        Me.mDescripcionSel.Text = "Descripcion"
        Me.mDescripcionSel.Width = 160
        '
        'mTipoMovSel
        '
        Me.mTipoMovSel.Text = "TipMovSel"
        '
        'lstTiposMovimiento
        '
        Me.lstTiposMovimiento.BackColor = System.Drawing.SystemColors.Info
        Me.lstTiposMovimiento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mTipoMovimiento, Me.mDescripcion, Me.mTipoMov})
        Me.lstTiposMovimiento.FullRowSelect = True
        Me.lstTiposMovimiento.GridLines = True
        Me.lstTiposMovimiento.Location = New System.Drawing.Point(6, 17)
        Me.lstTiposMovimiento.Name = "lstTiposMovimiento"
        Me.lstTiposMovimiento.Size = New System.Drawing.Size(197, 152)
        Me.lstTiposMovimiento.TabIndex = 8
        Me.lstTiposMovimiento.UseCompatibleStateImageBehavior = False
        Me.lstTiposMovimiento.View = System.Windows.Forms.View.Details
        '
        'mTipoMovimiento
        '
        Me.mTipoMovimiento.Tag = ""
        Me.mTipoMovimiento.Text = "Cod"
        Me.mTipoMovimiento.Width = 30
        '
        'mDescripcion
        '
        Me.mDescripcion.Text = "Descripcion"
        Me.mDescripcion.Width = 149
        '
        'mTipoMov
        '
        Me.mTipoMov.Text = "TipMov"
        Me.mTipoMov.Width = 30
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario, Me.PgsGrabar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 315)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(481, 22)
        Me.StatusStrip1.TabIndex = 119
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
        Me.PgsGrabar.Size = New System.Drawing.Size(130, 16)
        Me.PgsGrabar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "FECHA FINAL:"
        '
        'dtpfechafin
        '
        Me.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafin.Location = New System.Drawing.Point(312, 81)
        Me.dtpfechafin.Name = "dtpfechafin"
        Me.dtpfechafin.Size = New System.Drawing.Size(106, 20)
        Me.dtpfechafin.TabIndex = 5
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Image = Global.WindowsApplication1.My.Resources.Resources.print
        Me.btnImprimir.Location = New System.Drawing.Point(427, 8)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(37, 38)
        Me.btnImprimir.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir")
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Image = Global.WindowsApplication1.My.Resources.Resources.file_new_C_mayor
        Me.btnNuevo.Location = New System.Drawing.Point(384, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.btnNuevo.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo")
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtPolizaIni
        '
        Me.txtPolizaIni.BackColor = System.Drawing.SystemColors.Info
        Me.txtPolizaIni.Enabled = False
        Me.txtPolizaIni.Location = New System.Drawing.Point(106, 107)
        Me.txtPolizaIni.Name = "txtPolizaIni"
        Me.txtPolizaIni.Size = New System.Drawing.Size(75, 20)
        Me.txtPolizaIni.TabIndex = 6
        Me.txtPolizaIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPolizaFin
        '
        Me.txtPolizaFin.BackColor = System.Drawing.SystemColors.Info
        Me.txtPolizaFin.Enabled = False
        Me.txtPolizaFin.Location = New System.Drawing.Point(312, 108)
        Me.txtPolizaFin.Name = "txtPolizaFin"
        Me.txtPolizaFin.Size = New System.Drawing.Size(75, 20)
        Me.txtPolizaFin.TabIndex = 7
        Me.txtPolizaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(234, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 12)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "POLIZA FINAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 12)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "POLIZA INICIAL:"
        '
        'rFecha
        '
        Me.rFecha.AutoSize = True
        Me.rFecha.Checked = True
        Me.rFecha.Location = New System.Drawing.Point(21, 58)
        Me.rFecha.Name = "rFecha"
        Me.rFecha.Size = New System.Drawing.Size(90, 17)
        Me.rFecha.TabIndex = 0
        Me.rFecha.TabStop = True
        Me.rFecha.Text = "Rango Fecha"
        Me.rFecha.UseVisualStyleBackColor = True
        '
        'rPoliza
        '
        Me.rPoliza.AutoSize = True
        Me.rPoliza.Location = New System.Drawing.Point(133, 58)
        Me.rPoliza.Name = "rPoliza"
        Me.rPoliza.Size = New System.Drawing.Size(93, 17)
        Me.rPoliza.TabIndex = 2
        Me.rPoliza.Text = "Rango Polizas"
        Me.rPoliza.UseVisualStyleBackColor = True
        '
        'chPolizaDif
        '
        Me.chPolizaDif.AutoSize = True
        Me.chPolizaDif.Location = New System.Drawing.Point(312, 58)
        Me.chPolizaDif.Name = "chPolizaDif"
        Me.chPolizaDif.Size = New System.Drawing.Size(123, 17)
        Me.chPolizaDif.TabIndex = 133
        Me.chPolizaDif.Text = "Solo Polizas con Dif."
        Me.chPolizaDif.UseVisualStyleBackColor = True
        '
        'frmInformePolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(481, 337)
        Me.Controls.Add(Me.chPolizaDif)
        Me.Controls.Add(Me.rPoliza)
        Me.Controls.Add(Me.rFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPolizaFin)
        Me.Controls.Add(Me.txtPolizaIni)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpfechafin)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformePolizas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Pólizas"
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTiposMovimiento As System.Windows.Forms.ListView
    Friend WithEvents mTipoMovimiento As System.Windows.Forms.ColumnHeader
    Friend WithEvents mDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PgsGrabar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lstSeleccionados As System.Windows.Forms.ListView
    Friend WithEvents mTipoMovimientoSel As System.Windows.Forms.ColumnHeader
    Friend WithEvents mDescripcionSel As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpfechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents brnSelTodo As System.Windows.Forms.Button
    Friend WithEvents mTipoMov As System.Windows.Forms.ColumnHeader
    Friend WithEvents mTipoMovSel As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPolizaIni As System.Windows.Forms.TextBox
    Friend WithEvents txtPolizaFin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents brnDesTodo As System.Windows.Forms.Button
    Friend WithEvents rFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rPoliza As System.Windows.Forms.RadioButton
    Friend WithEvents chPolizaDif As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
