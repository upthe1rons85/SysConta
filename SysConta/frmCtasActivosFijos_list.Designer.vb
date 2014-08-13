<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtasActivosFijos_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtasActivosFijos_list))
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstMuestraCtaActivo = New System.Windows.Forms.ListView()
        Me.Cuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtCuenta.Location = New System.Drawing.Point(1, 12)
        Me.txtCuenta.MaxLength = 30
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(116, 22)
        Me.txtCuenta.TabIndex = 28
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtDescripcion.Location = New System.Drawing.Point(123, 12)
        Me.txtDescripcion.MaxLength = 30
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(391, 22)
        Me.txtDescripcion.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 9)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "BUSQUEDA"
        '
        'lstMuestraCtaActivo
        '
        Me.lstMuestraCtaActivo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Cuenta, Me.Descripcion})
        Me.lstMuestraCtaActivo.FullRowSelect = True
        Me.lstMuestraCtaActivo.GridLines = True
        Me.lstMuestraCtaActivo.Location = New System.Drawing.Point(-1, 40)
        Me.lstMuestraCtaActivo.MultiSelect = False
        Me.lstMuestraCtaActivo.Name = "lstMuestraCtaActivo"
        Me.lstMuestraCtaActivo.Size = New System.Drawing.Size(515, 244)
        Me.lstMuestraCtaActivo.TabIndex = 25
        Me.lstMuestraCtaActivo.UseCompatibleStateImageBehavior = False
        Me.lstMuestraCtaActivo.View = System.Windows.Forms.View.Details
        '
        'Cuenta
        '
        Me.Cuenta.Tag = ""
        Me.Cuenta.Text = "Cuenta"
        Me.Cuenta.Width = 123
        '
        'Descripcion
        '
        Me.Descripcion.Text = "Descripcion"
        Me.Descripcion.Width = 366
        '
        'frmCtasActivosFijos_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 286)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstMuestraCtaActivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCtasActivosFijos_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas Activos Fijos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstMuestraCtaActivo As System.Windows.Forms.ListView
    Friend WithEvents Cuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents Descripcion As System.Windows.Forms.ColumnHeader
End Class
