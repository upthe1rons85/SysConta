<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCECOSDepartamentos_List
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
        Me.txtCuenta_list = New System.Windows.Forms.TextBox()
        Me.txtDescripcion_list = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstMuestraArea = New System.Windows.Forms.ListView()
        Me.mClasificacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mArea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'txtCuenta_list
        '
        Me.txtCuenta_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta_list.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtCuenta_list.Location = New System.Drawing.Point(2, 11)
        Me.txtCuenta_list.MaxLength = 30
        Me.txtCuenta_list.Name = "txtCuenta_list"
        Me.txtCuenta_list.Size = New System.Drawing.Size(116, 22)
        Me.txtCuenta_list.TabIndex = 28
        '
        'txtDescripcion_list
        '
        Me.txtDescripcion_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion_list.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtDescripcion_list.Location = New System.Drawing.Point(124, 11)
        Me.txtDescripcion_list.MaxLength = 30
        Me.txtDescripcion_list.Name = "txtDescripcion_list"
        Me.txtDescripcion_list.Size = New System.Drawing.Size(391, 22)
        Me.txtDescripcion_list.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 9)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "BUSQUEDA"
        '
        'lstMuestraArea
        '
        Me.lstMuestraArea.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mClasificacion, Me.mArea, Me.mDescripcion})
        Me.lstMuestraArea.FullRowSelect = True
        Me.lstMuestraArea.GridLines = True
        Me.lstMuestraArea.Location = New System.Drawing.Point(0, 39)
        Me.lstMuestraArea.MultiSelect = False
        Me.lstMuestraArea.Name = "lstMuestraArea"
        Me.lstMuestraArea.Size = New System.Drawing.Size(515, 257)
        Me.lstMuestraArea.TabIndex = 25
        Me.lstMuestraArea.UseCompatibleStateImageBehavior = False
        Me.lstMuestraArea.View = System.Windows.Forms.View.Details
        '
        'mClasificacion
        '
        Me.mClasificacion.Tag = ""
        Me.mClasificacion.Text = "Clasificacion"
        Me.mClasificacion.Width = 121
        '
        'mArea
        '
        Me.mArea.Text = "Área"
        Me.mArea.Width = 94
        '
        'mDescripcion
        '
        Me.mDescripcion.Text = "Descripcion"
        Me.mDescripcion.Width = 359
        '
        'frmCECOSDepartamentos_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 297)
        Me.Controls.Add(Me.txtCuenta_list)
        Me.Controls.Add(Me.txtDescripcion_list)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstMuestraArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCECOSDepartamentos_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CECOS Deptos Lista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCuenta_list As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion_list As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstMuestraArea As System.Windows.Forms.ListView
    Friend WithEvents mClasificacion As System.Windows.Forms.ColumnHeader
    Friend WithEvents mDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents mArea As System.Windows.Forms.ColumnHeader
End Class
