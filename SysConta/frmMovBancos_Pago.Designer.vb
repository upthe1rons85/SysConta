<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovBancos_Pago
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
        Me.gbxPagoProveedor = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.lblMetodoPago = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblCantidadLetra = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblCodigoPago = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblTotalDocumento = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtTipoMoneda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbxPagoProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPagoProveedor
        '
        Me.gbxPagoProveedor.BackColor = System.Drawing.Color.Silver
        Me.gbxPagoProveedor.Controls.Add(Me.txtTipoMoneda)
        Me.gbxPagoProveedor.Controls.Add(Me.Label3)
        Me.gbxPagoProveedor.Controls.Add(Me.txtFecha)
        Me.gbxPagoProveedor.Controls.Add(Me.txtCheque)
        Me.gbxPagoProveedor.Controls.Add(Me.Label2)
        Me.gbxPagoProveedor.Controls.Add(Me.lblBanco)
        Me.gbxPagoProveedor.Controls.Add(Me.lblMetodoPago)
        Me.gbxPagoProveedor.Controls.Add(Me.btnOK)
        Me.gbxPagoProveedor.Controls.Add(Me.Label1)
        Me.gbxPagoProveedor.Controls.Add(Me.Label25)
        Me.gbxPagoProveedor.Controls.Add(Me.Label26)
        Me.gbxPagoProveedor.Controls.Add(Me.lblCantidadLetra)
        Me.gbxPagoProveedor.Controls.Add(Me.Label24)
        Me.gbxPagoProveedor.Controls.Add(Me.lblCodigoPago)
        Me.gbxPagoProveedor.Controls.Add(Me.Label20)
        Me.gbxPagoProveedor.Controls.Add(Me.lblTotalDocumento)
        Me.gbxPagoProveedor.Controls.Add(Me.lblProveedor)
        Me.gbxPagoProveedor.Controls.Add(Me.Label21)
        Me.gbxPagoProveedor.Controls.Add(Me.Label22)
        Me.gbxPagoProveedor.Controls.Add(Me.Label23)
        Me.gbxPagoProveedor.Controls.Add(Me.Label12)
        Me.gbxPagoProveedor.Controls.Add(Me.ShapeContainer1)
        Me.gbxPagoProveedor.Location = New System.Drawing.Point(5, 7)
        Me.gbxPagoProveedor.Name = "gbxPagoProveedor"
        Me.gbxPagoProveedor.Size = New System.Drawing.Size(530, 191)
        Me.gbxPagoProveedor.TabIndex = 152
        Me.gbxPagoProveedor.TabStop = False
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.DarkGray
        Me.txtFecha.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtFecha.Location = New System.Drawing.Point(434, 39)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(87, 20)
        Me.txtFecha.TabIndex = 186
        Me.txtFecha.Text = "11/04/2014"
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCheque
        '
        Me.txtCheque.BackColor = System.Drawing.Color.DarkGray
        Me.txtCheque.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCheque.Location = New System.Drawing.Point(434, 16)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.ReadOnly = True
        Me.txtCheque.Size = New System.Drawing.Size(87, 20)
        Me.txtCheque.TabIndex = 185
        Me.txtCheque.Text = "00"
        Me.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 12)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "Cheque N°"
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblBanco.Location = New System.Drawing.Point(239, 153)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(42, 14)
        Me.lblBanco.TabIndex = 183
        Me.lblBanco.Text = "BANCO"
        Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMetodoPago
        '
        Me.lblMetodoPago.AutoSize = True
        Me.lblMetodoPago.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetodoPago.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMetodoPago.Location = New System.Drawing.Point(12, 153)
        Me.lblMetodoPago.Name = "lblMetodoPago"
        Me.lblMetodoPago.Size = New System.Drawing.Size(49, 14)
        Me.lblMetodoPago.TabIndex = 182
        Me.lblMetodoPago.Text = "METODO"
        Me.lblMetodoPago.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.Location = New System.Drawing.Point(427, 161)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 179
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 12)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Fecha"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(240, 132)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 12)
        Me.Label25.TabIndex = 174
        Me.Label25.Text = "Banco"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(11, 132)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 12)
        Me.Label26.TabIndex = 172
        Me.Label26.Text = "Metodo de Pago"
        '
        'lblCantidadLetra
        '
        Me.lblCantidadLetra.AutoSize = True
        Me.lblCantidadLetra.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadLetra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblCantidadLetra.Location = New System.Drawing.Point(11, 110)
        Me.lblCantidadLetra.Name = "lblCantidadLetra"
        Me.lblCantidadLetra.Size = New System.Drawing.Size(217, 14)
        Me.lblCantidadLetra.TabIndex = 170
        Me.lblCantidadLetra.Text = "(QUINIENTOS PESOS 00/100 M.N.)"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 90)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(82, 12)
        Me.Label24.TabIndex = 169
        Me.Label24.Text = "Cantidad con Letra"
        '
        'lblCodigoPago
        '
        Me.lblCodigoPago.AutoSize = True
        Me.lblCodigoPago.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoPago.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblCodigoPago.Location = New System.Drawing.Point(12, 51)
        Me.lblCodigoPago.Name = "lblCodigoPago"
        Me.lblCodigoPago.Size = New System.Drawing.Size(21, 14)
        Me.lblCodigoPago.TabIndex = 168
        Me.lblCodigoPago.Text = "00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(13, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 12)
        Me.Label20.TabIndex = 167
        Me.Label20.Text = "Codigo "
        '
        'lblTotalDocumento
        '
        Me.lblTotalDocumento.AutoSize = True
        Me.lblTotalDocumento.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDocumento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTotalDocumento.Location = New System.Drawing.Point(295, 72)
        Me.lblTotalDocumento.Name = "lblTotalDocumento"
        Me.lblTotalDocumento.Size = New System.Drawing.Size(35, 14)
        Me.lblTotalDocumento.TabIndex = 166
        Me.lblTotalDocumento.Text = "0.00"
        Me.lblTotalDocumento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblProveedor.Location = New System.Drawing.Point(59, 51)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(147, 14)
        Me.lblProveedor.TabIndex = 165
        Me.lblProveedor.Text = "PROVEEDOR S.A DE C.V"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(60, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 12)
        Me.Label21.TabIndex = 164
        Me.Label21.Text = "Proveedor "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(11, 73)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(224, 12)
        Me.Label22.TabIndex = 162
        Me.Label22.Text = "Total Documento . . . . . . . . . . . . . . . . . . . . . . . . . . . . .  "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(236, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 13)
        Me.Label23.TabIndex = 163
        Me.Label23.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 12)
        Me.Label12.TabIndex = 151
        Me.Label12.Text = "PAGO A PROVEEDOR"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(524, 172)
        Me.ShapeContainer1.TabIndex = 181
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 411
        Me.LineShape3.X2 = 10
        Me.LineShape3.Y1 = 159
        Me.LineShape3.Y2 = 159
        '
        'txtTipoMoneda
        '
        Me.txtTipoMoneda.BackColor = System.Drawing.Color.DarkGray
        Me.txtTipoMoneda.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTipoMoneda.Location = New System.Drawing.Point(434, 63)
        Me.txtTipoMoneda.Name = "txtTipoMoneda"
        Me.txtTipoMoneda.ReadOnly = True
        Me.txtTipoMoneda.Size = New System.Drawing.Size(87, 20)
        Me.txtTipoMoneda.TabIndex = 190
        Me.txtTipoMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(372, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 12)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "Tipo Moneda"
        '
        'frmMovBancos_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(541, 206)
        Me.Controls.Add(Me.gbxPagoProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMovBancos_Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        Me.gbxPagoProveedor.ResumeLayout(False)
        Me.gbxPagoProveedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPagoProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblCantidadLetra As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblCodigoPago As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDocumento As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents lblMetodoPago As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoMoneda As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
