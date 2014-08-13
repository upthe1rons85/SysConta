<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovBancos_Elimina
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovBancos_Elimina))
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbxBancos = New System.Windows.Forms.ComboBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DGVEliminaCheque = New System.Windows.Forms.DataGridView()
        Me.dfolioKardex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dFechaDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dTipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dIVARet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dSelecciona = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGVEliminaCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 51)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 12)
        Me.Label25.TabIndex = 192
        Me.Label25.Text = "Banco"
        '
        'cbxBancos
        '
        Me.cbxBancos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxBancos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBancos.FormattingEnabled = True
        Me.cbxBancos.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbxBancos.Items.AddRange(New Object() {""})
        Me.cbxBancos.Location = New System.Drawing.Point(7, 65)
        Me.cbxBancos.Name = "cbxBancos"
        Me.cbxBancos.Size = New System.Drawing.Size(173, 20)
        Me.cbxBancos.TabIndex = 191
        '
        'txtCheque
        '
        Me.txtCheque.BackColor = System.Drawing.SystemColors.Info
        Me.txtCheque.Location = New System.Drawing.Point(385, 66)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(100, 20)
        Me.txtCheque.TabIndex = 193
        Me.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(383, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 12)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "N° Cheque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(7, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 24)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "Cancelacion Documentos"
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 868
        Me.LineShape3.X2 = 14
        Me.LineShape3.Y1 = 46
        Me.LineShape3.Y2 = 46
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(876, 271)
        Me.ShapeContainer1.TabIndex = 196
        Me.ShapeContainer1.TabStop = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.WindowsApplication1.My.Resources.Resources.delete_C_mayseg
        Me.BtnEliminar.Location = New System.Drawing.Point(832, 8)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(37, 38)
        Me.BtnEliminar.TabIndex = 197
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'DGVEliminaCheque
        '
        Me.DGVEliminaCheque.AllowUserToAddRows = False
        Me.DGVEliminaCheque.AllowUserToDeleteRows = False
        Me.DGVEliminaCheque.AllowUserToResizeColumns = False
        Me.DGVEliminaCheque.AllowUserToResizeRows = False
        Me.DGVEliminaCheque.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVEliminaCheque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVEliminaCheque.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGVEliminaCheque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVEliminaCheque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVEliminaCheque.ColumnHeadersHeight = 20
        Me.DGVEliminaCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVEliminaCheque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dfolioKardex, Me.dFechaDoc, Me.dBanco, Me.dTipoDoc, Me.dDocumento, Me.dProveedor, Me.dSubtotal, Me.dIVA, Me.dIVARet, Me.dTotal, Me.dSelecciona})
        Me.DGVEliminaCheque.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVEliminaCheque.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGVEliminaCheque.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGVEliminaCheque.Enabled = False
        Me.DGVEliminaCheque.Location = New System.Drawing.Point(7, 97)
        Me.DGVEliminaCheque.MultiSelect = False
        Me.DGVEliminaCheque.Name = "DGVEliminaCheque"
        Me.DGVEliminaCheque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGVEliminaCheque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVEliminaCheque.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGVEliminaCheque.RowHeadersVisible = False
        Me.DGVEliminaCheque.RowHeadersWidth = 20
        Me.DGVEliminaCheque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVEliminaCheque.Size = New System.Drawing.Size(864, 167)
        Me.DGVEliminaCheque.TabIndex = 198
        '
        'dfolioKardex
        '
        Me.dfolioKardex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dfolioKardex.DefaultCellStyle = DataGridViewCellStyle2
        Me.dfolioKardex.HeaderText = "N°ID"
        Me.dfolioKardex.Name = "dfolioKardex"
        Me.dfolioKardex.ReadOnly = True
        Me.dfolioKardex.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dfolioKardex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dfolioKardex.Width = 50
        '
        'dFechaDoc
        '
        Me.dFechaDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFechaDoc.DefaultCellStyle = DataGridViewCellStyle3
        Me.dFechaDoc.HeaderText = "FECHA"
        Me.dFechaDoc.MaxInputLength = 60
        Me.dFechaDoc.Name = "dFechaDoc"
        Me.dFechaDoc.ReadOnly = True
        Me.dFechaDoc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dFechaDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dFechaDoc.Width = 70
        '
        'dBanco
        '
        Me.dBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.dBanco.DefaultCellStyle = DataGridViewCellStyle4
        Me.dBanco.HeaderText = "BANCO"
        Me.dBanco.MaxInputLength = 13
        Me.dBanco.Name = "dBanco"
        Me.dBanco.ReadOnly = True
        Me.dBanco.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dBanco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dBanco.ToolTipText = "0.00"
        Me.dBanco.Width = 45
        '
        'dTipoDoc
        '
        Me.dTipoDoc.HeaderText = "TIPO"
        Me.dTipoDoc.Name = "dTipoDoc"
        Me.dTipoDoc.Width = 70
        '
        'dDocumento
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dDocumento.DefaultCellStyle = DataGridViewCellStyle5
        Me.dDocumento.HeaderText = "NUM"
        Me.dDocumento.Name = "dDocumento"
        Me.dDocumento.ReadOnly = True
        Me.dDocumento.Width = 50
        '
        'dProveedor
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dProveedor.DefaultCellStyle = DataGridViewCellStyle6
        Me.dProveedor.HeaderText = "PROVEEDOR"
        Me.dProveedor.Name = "dProveedor"
        Me.dProveedor.ReadOnly = True
        Me.dProveedor.Width = 147
        '
        'dSubtotal
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dSubtotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.dSubtotal.HeaderText = "SUBTOTAL"
        Me.dSubtotal.Name = "dSubtotal"
        Me.dSubtotal.ReadOnly = True
        Me.dSubtotal.Width = 88
        '
        'dIVA
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dIVA.DefaultCellStyle = DataGridViewCellStyle8
        Me.dIVA.HeaderText = "IVA"
        Me.dIVA.Name = "dIVA"
        Me.dIVA.ReadOnly = True
        Me.dIVA.Width = 88
        '
        'dIVARet
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dIVARet.DefaultCellStyle = DataGridViewCellStyle9
        Me.dIVARet.HeaderText = "IVA Ret"
        Me.dIVARet.Name = "dIVARet"
        Me.dIVARet.ReadOnly = True
        Me.dIVARet.Width = 88
        '
        'dTotal
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dTotal.DefaultCellStyle = DataGridViewCellStyle10
        Me.dTotal.HeaderText = "TOTAL"
        Me.dTotal.Name = "dTotal"
        Me.dTotal.ReadOnly = True
        Me.dTotal.Width = 88
        '
        'dSelecciona
        '
        Me.dSelecciona.HeaderText = "T"
        Me.dSelecciona.Name = "dSelecciona"
        Me.dSelecciona.Width = 40
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(515, 66)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 20)
        Me.btnBuscar.TabIndex = 199
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DTPFecha
        '
        Me.DTPFecha.Location = New System.Drawing.Point(186, 66)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(193, 20)
        Me.DTPFecha.TabIndex = 200
        '
        'frmMovBancos_Elimina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(876, 271)
        Me.Controls.Add(Me.DTPFecha)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DGVEliminaCheque)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCheque)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cbxBancos)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovBancos_Elimina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancela Documentos"
        CType(Me.DGVEliminaCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbxBancos As System.Windows.Forms.ComboBox
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents DGVEliminaCheque As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dfolioKardex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dFechaDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dTipoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dIVARet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dSelecciona As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
