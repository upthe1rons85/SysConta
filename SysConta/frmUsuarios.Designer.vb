<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblperfil = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lblpuesto = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtpuesto = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.CbxPerfil = New System.Windows.Forms.ComboBox()
        Me.CbxEstatus = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminiar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Sistema = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxSistema = New System.Windows.Forms.ComboBox()
        Me.CheckReset = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(48, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mtto. de Usuarios"
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblperfil.Location = New System.Drawing.Point(39, 248)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(50, 13)
        Me.lblperfil.TabIndex = 21
        Me.lblperfil.Text = "PERFIL :"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(39, 222)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(45, 13)
        Me.lblemail.TabIndex = 20
        Me.lblemail.Text = "EMAIL :"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.Location = New System.Drawing.Point(39, 194)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(70, 13)
        Me.lbltelefono.TabIndex = 19
        Me.lbltelefono.Text = "TELEFONO :"
        '
        'lblpuesto
        '
        Me.lblpuesto.AutoSize = True
        Me.lblpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpuesto.Location = New System.Drawing.Point(39, 168)
        Me.lblpuesto.Name = "lblpuesto"
        Me.lblpuesto.Size = New System.Drawing.Size(57, 13)
        Me.lblpuesto.TabIndex = 18
        Me.lblpuesto.Text = "PUESTO :"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(39, 142)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(60, 13)
        Me.lblnombre.TabIndex = 17
        Me.lblnombre.Text = "NOMBRE :"
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontraseña.Location = New System.Drawing.Point(39, 115)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(87, 13)
        Me.lblcontraseña.TabIndex = 16
        Me.lblcontraseña.Text = "CONTRASEÑA :"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.Location = New System.Drawing.Point(39, 88)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(62, 13)
        Me.lblusuario.TabIndex = 15
        Me.lblusuario.Text = "USUARIO :"
        '
        'txtemail
        '
        Me.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtemail.Enabled = False
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(143, 219)
        Me.txtemail.MaxLength = 40
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(174, 20)
        Me.txtemail.TabIndex = 7
        '
        'txttelefono
        '
        Me.txttelefono.Enabled = False
        Me.txttelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(143, 191)
        Me.txttelefono.MaxLength = 20
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(174, 20)
        Me.txttelefono.TabIndex = 6
        '
        'txtpuesto
        '
        Me.txtpuesto.Enabled = False
        Me.txtpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpuesto.Location = New System.Drawing.Point(143, 165)
        Me.txtpuesto.MaxLength = 20
        Me.txtpuesto.Name = "txtpuesto"
        Me.txtpuesto.Size = New System.Drawing.Size(174, 20)
        Me.txtpuesto.TabIndex = 5
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(143, 139)
        Me.txtnombre.MaxLength = 40
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(174, 20)
        Me.txtnombre.TabIndex = 4
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Enabled = False
        Me.txtcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña.Location = New System.Drawing.Point(143, 112)
        Me.txtcontraseña.MaxLength = 20
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(174, 20)
        Me.txtcontraseña.TabIndex = 3
        '
        'txtusuario
        '
        Me.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtusuario.Location = New System.Drawing.Point(143, 85)
        Me.txtusuario.MaxLength = 15
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(174, 20)
        Me.txtusuario.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtusuario, "Buscar Nombre de Usuario")
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(523, 354)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 2
        Me.LineShape2.X2 = 521
        Me.LineShape2.Y1 = 63
        Me.LineShape2.Y2 = 63
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 521
        Me.LineShape1.Y1 = 64
        Me.LineShape1.Y2 = 64
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.Location = New System.Drawing.Point(39, 275)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(63, 13)
        Me.lblEstatus.TabIndex = 22
        Me.lblEstatus.Text = "ESTATUS :"
        '
        'CbxPerfil
        '
        Me.CbxPerfil.Enabled = False
        Me.CbxPerfil.FormattingEnabled = True
        Me.CbxPerfil.Items.AddRange(New Object() {"01", "02", "03", "04", "05"})
        Me.CbxPerfil.Location = New System.Drawing.Point(143, 245)
        Me.CbxPerfil.MaxLength = 2
        Me.CbxPerfil.Name = "CbxPerfil"
        Me.CbxPerfil.Size = New System.Drawing.Size(174, 21)
        Me.CbxPerfil.TabIndex = 8
        '
        'CbxEstatus
        '
        Me.CbxEstatus.Enabled = False
        Me.CbxEstatus.FormattingEnabled = True
        Me.CbxEstatus.Location = New System.Drawing.Point(143, 272)
        Me.CbxEstatus.MaxLength = 10
        Me.CbxEstatus.Name = "CbxEstatus"
        Me.CbxEstatus.Size = New System.Drawing.Size(174, 21)
        Me.CbxEstatus.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.misc_user_936451
        Me.PictureBox1.Location = New System.Drawing.Point(361, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.Image = Global.WindowsApplication1.My.Resources.Resources.file_new_usu
        Me.btnNuevo.Location = New System.Drawing.Point(373, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.btnNuevo.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.WindowsApplication1.My.Resources.Resources.refreshx
        Me.btnModificar.Location = New System.Drawing.Point(416, 19)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(37, 38)
        Me.btnModificar.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.btnModificar, "Modificar")
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminiar
        '
        Me.btnEliminiar.Image = Global.WindowsApplication1.My.Resources.Resources.delete_usu
        Me.btnEliminiar.Location = New System.Drawing.Point(459, 19)
        Me.btnEliminiar.Name = "btnEliminiar"
        Me.btnEliminiar.Size = New System.Drawing.Size(37, 38)
        Me.btnEliminiar.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.btnEliminiar, "Eliminar")
        Me.btnEliminiar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGrabar.Image = Global.WindowsApplication1.My.Resources.Resources.save_usu
        Me.btnGrabar.Location = New System.Drawing.Point(330, 19)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(37, 38)
        Me.btnGrabar.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.btnGrabar, "Guardar")
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 332)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(523, 22)
        Me.StatusStrip1.TabIndex = 26
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
        'Sistema
        '
        Me.Sistema.AutoSize = True
        Me.Sistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sistema.Location = New System.Drawing.Point(39, 299)
        Me.Sistema.Name = "Sistema"
        Me.Sistema.Size = New System.Drawing.Size(65, 15)
        Me.Sistema.TabIndex = 23
        Me.Sistema.Text = "SISTEMA :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Reset de Contraseña"
        '
        'cbxSistema
        '
        Me.cbxSistema.Enabled = False
        Me.cbxSistema.FormattingEnabled = True
        Me.cbxSistema.Items.AddRange(New Object() {"Contabilidad", "Almacen", "Comercial", "Compras"})
        Me.cbxSistema.Location = New System.Drawing.Point(143, 298)
        Me.cbxSistema.Name = "cbxSistema"
        Me.cbxSistema.Size = New System.Drawing.Size(174, 21)
        Me.cbxSistema.TabIndex = 10
        '
        'CheckReset
        '
        Me.CheckReset.AutoSize = True
        Me.CheckReset.Enabled = False
        Me.CheckReset.Location = New System.Drawing.Point(475, 259)
        Me.CheckReset.Name = "CheckReset"
        Me.CheckReset.Size = New System.Drawing.Size(15, 14)
        Me.CheckReset.TabIndex = 25
        Me.CheckReset.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 354)
        Me.Controls.Add(Me.CheckReset)
        Me.Controls.Add(Me.cbxSistema)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Sistema)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CbxEstatus)
        Me.Controls.Add(Me.CbxPerfil)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminiar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtpuesto)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.lblperfil)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lbltelefono)
        Me.Controls.Add(Me.lblpuesto)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblperfil As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lbltelefono As System.Windows.Forms.Label
    Friend WithEvents lblpuesto As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtpuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnEliminiar As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblEstatus As System.Windows.Forms.Label

    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CbxPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents CbxEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Sistema As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxSistema As System.Windows.Forms.ComboBox
    Friend WithEvents CheckReset As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
