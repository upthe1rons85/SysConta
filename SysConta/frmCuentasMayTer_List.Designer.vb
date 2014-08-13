<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentasMayTer_List
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
        Me.lstMuestraCtaN2 = New System.Windows.Forms.ListView()
        Me.mCtaNivel2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCuenta.Location = New System.Drawing.Point(3, 16)
        Me.txtCuenta.MaxLength = 30
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(116, 22)
        Me.txtCuenta.TabIndex = 28
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDescripcion.Location = New System.Drawing.Point(125, 16)
        Me.txtDescripcion.MaxLength = 30
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(391, 22)
        Me.txtDescripcion.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 9)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "BUSQUEDA CUENTA"
        '
        'lstMuestraCtaN2
        '
        Me.lstMuestraCtaN2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mCtaNivel2, Me.mDescripcion})
        Me.lstMuestraCtaN2.FullRowSelect = True
        Me.lstMuestraCtaN2.GridLines = True
        Me.lstMuestraCtaN2.Location = New System.Drawing.Point(1, 41)
        Me.lstMuestraCtaN2.MultiSelect = False
        Me.lstMuestraCtaN2.Name = "lstMuestraCtaN2"
        Me.lstMuestraCtaN2.Size = New System.Drawing.Size(515, 257)
        Me.lstMuestraCtaN2.TabIndex = 25
        Me.lstMuestraCtaN2.UseCompatibleStateImageBehavior = False
        Me.lstMuestraCtaN2.View = System.Windows.Forms.View.Details
        '
        'mCtaNivel2
        '
        Me.mCtaNivel2.Text = "Cuenta Nivel 2"
        Me.mCtaNivel2.Width = 161
        '
        'mDescripcion
        '
        Me.mDescripcion.Text = "Descripcion"
        Me.mDescripcion.Width = 275
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 9)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "BUSQUEDA DESCRIPCION"
        '
        'frmCuentasMayTer_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 293)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstMuestraCtaN2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCuentasMayTer_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Cuenta de 2do Nivel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstMuestraCtaN2 As System.Windows.Forms.ListView
    Friend WithEvents mDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents mCtaNivel2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
