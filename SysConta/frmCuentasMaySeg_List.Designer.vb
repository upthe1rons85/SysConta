<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentasMaySeg_List
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
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstMuestraCtaMayor = New System.Windows.Forms.ListView()
        Me.mCuentaMayor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtCuenta.Location = New System.Drawing.Point(5, 11)
        Me.txtCuenta.MaxLength = 30
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(116, 22)
        Me.txtCuenta.TabIndex = 20
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtDescripcion.Location = New System.Drawing.Point(127, 11)
        Me.txtDescripcion.MaxLength = 30
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(391, 22)
        Me.txtDescripcion.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 9)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "BUSQUEDA"
        '
        'lstMuestraCtaMayor
        '
        Me.lstMuestraCtaMayor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mCuentaMayor, Me.mDescripcion})
        Me.lstMuestraCtaMayor.FullRowSelect = True
        Me.lstMuestraCtaMayor.GridLines = True
        Me.lstMuestraCtaMayor.Location = New System.Drawing.Point(3, 39)
        Me.lstMuestraCtaMayor.MultiSelect = False
        Me.lstMuestraCtaMayor.Name = "lstMuestraCtaMayor"
        Me.lstMuestraCtaMayor.Size = New System.Drawing.Size(515, 257)
        Me.lstMuestraCtaMayor.TabIndex = 17
        Me.lstMuestraCtaMayor.UseCompatibleStateImageBehavior = False
        Me.lstMuestraCtaMayor.View = System.Windows.Forms.View.Details
        '
        'mCuentaMayor
        '
        Me.mCuentaMayor.Tag = ""
        Me.mCuentaMayor.Text = "CuentaMayor"
        Me.mCuentaMayor.Width = 123
        '
        'mDescripcion
        '
        Me.mDescripcion.Text = "Descripcion"
        Me.mDescripcion.Width = 275
        '
        'frmCuentasMaySeg_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 299)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstMuestraCtaMayor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCuentasMaySeg_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Cuenta de Mayor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstMuestraCtaMayor As System.Windows.Forms.ListView
    Friend WithEvents mCuentaMayor As System.Windows.Forms.ColumnHeader
    Friend WithEvents mDescripcion As System.Windows.Forms.ColumnHeader
End Class
