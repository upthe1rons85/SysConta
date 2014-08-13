<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CATALOGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosGeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CECOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClasificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasDeMayorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cuentas2NivelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cuentas3erNivelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasContToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeCambioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerifilesDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetDeContraseñasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POLIZASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PolizaManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarPolizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConciliaciónContToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFORMESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoDeResultadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldosIncialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbandonarElSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AYUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INDICEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CATALOGOSToolStripMenuItem, Me.POLIZASToolStripMenuItem, Me.INFORMESToolStripMenuItem, Me.SALIDAToolStripMenuItem, Me.AYUDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(11, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CATALOGOSToolStripMenuItem
        '
        Me.CATALOGOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametrosGeneralesToolStripMenuItem, Me.CuentasToolStripMenuItem, Me.BancosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.TipoDeCambioToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.CATALOGOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CATALOGOSToolStripMenuItem.Name = "CATALOGOSToolStripMenuItem"
        Me.CATALOGOSToolStripMenuItem.Size = New System.Drawing.Size(112, 25)
        Me.CATALOGOSToolStripMenuItem.Text = "CATALOGOS"
        '
        'ParametrosGeneralesToolStripMenuItem
        '
        Me.ParametrosGeneralesToolStripMenuItem.Name = "ParametrosGeneralesToolStripMenuItem"
        Me.ParametrosGeneralesToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ParametrosGeneralesToolStripMenuItem.Text = "Parametros Generales"
        '
        'CuentasToolStripMenuItem
        '
        Me.CuentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CECOSToolStripMenuItem, Me.CuentasDeMayorToolStripMenuItem, Me.Cuentas2NivelToolStripMenuItem, Me.Cuentas3erNivelToolStripMenuItem, Me.CuentasContToolStripMenuItem})
        Me.CuentasToolStripMenuItem.Name = "CuentasToolStripMenuItem"
        Me.CuentasToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.CuentasToolStripMenuItem.Text = "Cuentas"
        '
        'CECOSToolStripMenuItem
        '
        Me.CECOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClasificaciónToolStripMenuItem, Me.AreasToolStripMenuItem, Me.DepartamentosToolStripMenuItem})
        Me.CECOSToolStripMenuItem.Name = "CECOSToolStripMenuItem"
        Me.CECOSToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.CECOSToolStripMenuItem.Text = "CECOS"
        '
        'ClasificaciónToolStripMenuItem
        '
        Me.ClasificaciónToolStripMenuItem.Name = "ClasificaciónToolStripMenuItem"
        Me.ClasificaciónToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.ClasificaciónToolStripMenuItem.Text = "Clasificación"
        '
        'AreasToolStripMenuItem
        '
        Me.AreasToolStripMenuItem.Name = "AreasToolStripMenuItem"
        Me.AreasToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.AreasToolStripMenuItem.Text = "Areas"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'CuentasDeMayorToolStripMenuItem
        '
        Me.CuentasDeMayorToolStripMenuItem.Name = "CuentasDeMayorToolStripMenuItem"
        Me.CuentasDeMayorToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.CuentasDeMayorToolStripMenuItem.Text = "Cuentas de Mayor"
        '
        'Cuentas2NivelToolStripMenuItem
        '
        Me.Cuentas2NivelToolStripMenuItem.Name = "Cuentas2NivelToolStripMenuItem"
        Me.Cuentas2NivelToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.Cuentas2NivelToolStripMenuItem.Text = "Cuentas 2° Nivel"
        '
        'Cuentas3erNivelToolStripMenuItem
        '
        Me.Cuentas3erNivelToolStripMenuItem.Name = "Cuentas3erNivelToolStripMenuItem"
        Me.Cuentas3erNivelToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.Cuentas3erNivelToolStripMenuItem.Text = "Cuentas 3er. Nivel"
        '
        'CuentasContToolStripMenuItem
        '
        Me.CuentasContToolStripMenuItem.Name = "CuentasContToolStripMenuItem"
        Me.CuentasContToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.CuentasContToolStripMenuItem.Text = "Cuentas Contable"
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'TipoDeCambioToolStripMenuItem
        '
        Me.TipoDeCambioToolStripMenuItem.Name = "TipoDeCambioToolStripMenuItem"
        Me.TipoDeCambioToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TipoDeCambioToolStripMenuItem.Text = "Tipo de Cambio"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientToolStripMenuItem, Me.PerifilesDeUsuarioToolStripMenuItem, Me.ResetDeContraseñasToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'MantenimientToolStripMenuItem
        '
        Me.MantenimientToolStripMenuItem.Name = "MantenimientToolStripMenuItem"
        Me.MantenimientToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.MantenimientToolStripMenuItem.Text = "Mantenimiento"
        '
        'PerifilesDeUsuarioToolStripMenuItem
        '
        Me.PerifilesDeUsuarioToolStripMenuItem.Name = "PerifilesDeUsuarioToolStripMenuItem"
        Me.PerifilesDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.PerifilesDeUsuarioToolStripMenuItem.Text = "Perifiles de Usuario"
        '
        'ResetDeContraseñasToolStripMenuItem
        '
        Me.ResetDeContraseñasToolStripMenuItem.Name = "ResetDeContraseñasToolStripMenuItem"
        Me.ResetDeContraseñasToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ResetDeContraseñasToolStripMenuItem.Text = "Reset de Contraseñas"
        '
        'POLIZASToolStripMenuItem
        '
        Me.POLIZASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PolizaManualToolStripMenuItem, Me.ImportarPolizaToolStripMenuItem, Me.ConciliaciónContToolStripMenuItem})
        Me.POLIZASToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POLIZASToolStripMenuItem.Name = "POLIZASToolStripMenuItem"
        Me.POLIZASToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.POLIZASToolStripMenuItem.Text = "POLIZAS"
        '
        'PolizaManualToolStripMenuItem
        '
        Me.PolizaManualToolStripMenuItem.Name = "PolizaManualToolStripMenuItem"
        Me.PolizaManualToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.PolizaManualToolStripMenuItem.Text = "Poliza Manual"
        '
        'ImportarPolizaToolStripMenuItem
        '
        Me.ImportarPolizaToolStripMenuItem.Name = "ImportarPolizaToolStripMenuItem"
        Me.ImportarPolizaToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ImportarPolizaToolStripMenuItem.Text = "Importar Poliza"
        '
        'ConciliaciónContToolStripMenuItem
        '
        Me.ConciliaciónContToolStripMenuItem.Name = "ConciliaciónContToolStripMenuItem"
        Me.ConciliaciónContToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ConciliaciónContToolStripMenuItem.Text = "Conciliación Contable"
        '
        'INFORMESToolStripMenuItem
        '
        Me.INFORMESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BalanceToolStripMenuItem, Me.EstadoDeResultadoToolStripMenuItem, Me.SaldosIncialesToolStripMenuItem})
        Me.INFORMESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INFORMESToolStripMenuItem.Name = "INFORMESToolStripMenuItem"
        Me.INFORMESToolStripMenuItem.Size = New System.Drawing.Size(99, 25)
        Me.INFORMESToolStripMenuItem.Text = "INFORMES"
        '
        'BalanceToolStripMenuItem
        '
        Me.BalanceToolStripMenuItem.Name = "BalanceToolStripMenuItem"
        Me.BalanceToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.BalanceToolStripMenuItem.Text = "Balance"
        '
        'EstadoDeResultadoToolStripMenuItem
        '
        Me.EstadoDeResultadoToolStripMenuItem.Name = "EstadoDeResultadoToolStripMenuItem"
        Me.EstadoDeResultadoToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.EstadoDeResultadoToolStripMenuItem.Text = "Estado de Resultado"
        '
        'SaldosIncialesToolStripMenuItem
        '
        Me.SaldosIncialesToolStripMenuItem.Name = "SaldosIncialesToolStripMenuItem"
        Me.SaldosIncialesToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.SaldosIncialesToolStripMenuItem.Text = "Saldos Inciales"
        '
        'SALIDAToolStripMenuItem
        '
        Me.SALIDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.AbandonarElSistemaToolStripMenuItem})
        Me.SALIDAToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALIDAToolStripMenuItem.Name = "SALIDAToolStripMenuItem"
        Me.SALIDAToolStripMenuItem.Size = New System.Drawing.Size(74, 25)
        Me.SALIDAToolStripMenuItem.Text = "SALIDA"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'AbandonarElSistemaToolStripMenuItem
        '
        Me.AbandonarElSistemaToolStripMenuItem.Name = "AbandonarElSistemaToolStripMenuItem"
        Me.AbandonarElSistemaToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.AbandonarElSistemaToolStripMenuItem.Text = "Abandonar el Sistema"
        '
        'AYUDAToolStripMenuItem
        '
        Me.AYUDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INDICEToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AYUDAToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AYUDAToolStripMenuItem.Name = "AYUDAToolStripMenuItem"
        Me.AYUDAToolStripMenuItem.Size = New System.Drawing.Size(73, 25)
        Me.AYUDAToolStripMenuItem.Text = "AYUDA"
        '
        'INDICEToolStripMenuItem
        '
        Me.INDICEToolStripMenuItem.Name = "INDICEToolStripMenuItem"
        Me.INDICEToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.INDICEToolStripMenuItem.Text = "Indice"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de.."
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.DENES5
        Me.PictureBox1.Location = New System.Drawing.Point(967, 426)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 83)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(747, 523)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desarrollo de Engordas Estabuladas S.A. de C.V"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 538)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CATALOGOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParametrosGeneralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CECOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClasificaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasDeMayorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cuentas2NivelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cuentas3erNivelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasContToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BancosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeCambioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerifilesDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetDeContraseñasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POLIZASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PolizaManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarPolizaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConciliaciónContToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INFORMESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoDeResultadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldosIncialesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbandonarElSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AYUDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INDICEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
