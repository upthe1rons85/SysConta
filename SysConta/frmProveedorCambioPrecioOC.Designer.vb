﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedorCambioPrecioOC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedorCambioPrecioOC))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.cbxAgregaElimina = New System.Windows.Forms.GroupBox()
        Me.lstCotizacion = New System.Windows.Forms.ListView()
        Me.IDSOL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FolioSol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FolioCot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DESCRIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CTO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TipoIva = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Iva = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AntCto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Usuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtOCFolioCOT = New System.Windows.Forms.TextBox()
        Me.txtPorciento = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxCuenta = New System.Windows.Forms.ComboBox()
        Me.cbxTipoIva = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCostoNuevo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCostoAnt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCot = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDSol = New System.Windows.Forms.TextBox()
        Me.cbxAgregaElimina.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 24)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Mantenimiento Menor OC"
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 637
        Me.LineShape3.X2 = 9
        Me.LineShape3.Y1 = 53
        Me.LineShape3.Y2 = 53
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(646, 362)
        Me.ShapeContainer1.TabIndex = 89
        Me.ShapeContainer1.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.WindowsApplication1.My.Resources.Resources.file_new_C_mayseg
        Me.btnNuevo.Location = New System.Drawing.Point(560, 7)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.btnNuevo.TabIndex = 90
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Image = Global.WindowsApplication1.My.Resources.Resources.save_C_mayseg
        Me.BtnGuardar.Location = New System.Drawing.Point(599, 7)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGuardar.TabIndex = 91
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'cbxAgregaElimina
        '
        Me.cbxAgregaElimina.Controls.Add(Me.lstCotizacion)
        Me.cbxAgregaElimina.Location = New System.Drawing.Point(9, 116)
        Me.cbxAgregaElimina.Name = "cbxAgregaElimina"
        Me.cbxAgregaElimina.Size = New System.Drawing.Size(628, 133)
        Me.cbxAgregaElimina.TabIndex = 234
        Me.cbxAgregaElimina.TabStop = False
        '
        'lstCotizacion
        '
        Me.lstCotizacion.BackColor = System.Drawing.Color.Cornsilk
        Me.lstCotizacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDSOL, Me.FolioSol, Me.FolioCot, Me.Cuenta, Me.DESCRIP, Me.Cant, Me.CTO, Me.SubTotal, Me.TipoIva, Me.Iva, Me.Total, Me.AntCto, Me.Usuario})
        Me.lstCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCotizacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstCotizacion.FullRowSelect = True
        Me.lstCotizacion.Location = New System.Drawing.Point(6, 15)
        Me.lstCotizacion.Name = "lstCotizacion"
        Me.lstCotizacion.Size = New System.Drawing.Size(616, 106)
        Me.lstCotizacion.TabIndex = 234
        Me.lstCotizacion.UseCompatibleStateImageBehavior = False
        Me.lstCotizacion.View = System.Windows.Forms.View.Details
        '
        'IDSOL
        '
        Me.IDSOL.Text = "ID"
        Me.IDSOL.Width = 24
        '
        'FolioSol
        '
        Me.FolioSol.Text = "SOL"
        Me.FolioSol.Width = 45
        '
        'FolioCot
        '
        Me.FolioCot.Text = "COT"
        Me.FolioCot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FolioCot.Width = 59
        '
        'Cuenta
        '
        Me.Cuenta.Text = "CUENTA"
        '
        'DESCRIP
        '
        Me.DESCRIP.Text = "DESCRIPCION"
        Me.DESCRIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DESCRIP.Width = 139
        '
        'Cant
        '
        Me.Cant.Text = "CANT"
        Me.Cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cant.Width = 42
        '
        'CTO
        '
        Me.CTO.Text = "CSTO"
        Me.CTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CTO.Width = 58
        '
        'SubTotal
        '
        Me.SubTotal.Text = "SUBTOTAL"
        Me.SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubTotal.Width = 80
        '
        'TipoIva
        '
        Me.TipoIva.Text = "TIva"
        '
        'Iva
        '
        Me.Iva.Text = "IVA"
        Me.Iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Iva.Width = 57
        '
        'Total
        '
        Me.Total.Text = "TOTAL"
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Total.Width = 80
        '
        'AntCto
        '
        Me.AntCto.Text = "AntCto"
        '
        'Usuario
        '
        Me.Usuario.Text = "Usuario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBusca)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtOCFolioCOT)
        Me.GroupBox1.Controls.Add(Me.txtPorciento)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 49)
        Me.GroupBox1.TabIndex = 235
        Me.GroupBox1.TabStop = False
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.SystemColors.Control
        Me.btnBusca.Location = New System.Drawing.Point(138, 18)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(62, 20)
        Me.btnBusca.TabIndex = 242
        Me.btnBusca.Text = "Buscar"
        Me.btnBusca.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 241
        Me.Label14.Text = "Folio Cot :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(570, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 13)
        Me.Label12.TabIndex = 261
        Me.Label12.Text = "% :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOCFolioCOT
        '
        Me.txtOCFolioCOT.Location = New System.Drawing.Point(66, 18)
        Me.txtOCFolioCOT.MaxLength = 45
        Me.txtOCFolioCOT.Name = "txtOCFolioCOT"
        Me.txtOCFolioCOT.Size = New System.Drawing.Size(51, 20)
        Me.txtOCFolioCOT.TabIndex = 240
        Me.txtOCFolioCOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPorciento
        '
        Me.txtPorciento.Location = New System.Drawing.Point(597, 18)
        Me.txtPorciento.MaxLength = 45
        Me.txtPorciento.Name = "txtPorciento"
        Me.txtPorciento.ReadOnly = True
        Me.txtPorciento.Size = New System.Drawing.Size(25, 20)
        Me.txtPorciento.TabIndex = 260
        Me.txtPorciento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxCuenta)
        Me.GroupBox2.Controls.Add(Me.cbxTipoIva)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtImporte)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtIva)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCostoNuevo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCostoAnt)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCot)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSol)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtIDSol)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(628, 100)
        Me.GroupBox2.TabIndex = 236
        Me.GroupBox2.TabStop = False
        '
        'cbxCuenta
        '
        Me.cbxCuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxCuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxCuenta.BackColor = System.Drawing.Color.Cornsilk
        Me.cbxCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCuenta.FormattingEnabled = True
        Me.cbxCuenta.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbxCuenta.Items.AddRange(New Object() {"16.000", "10.670", "10.666", "00.000"})
        Me.cbxCuenta.Location = New System.Drawing.Point(369, 44)
        Me.cbxCuenta.Name = "cbxCuenta"
        Me.cbxCuenta.Size = New System.Drawing.Size(250, 20)
        Me.cbxCuenta.TabIndex = 264
        '
        'cbxTipoIva
        '
        Me.cbxTipoIva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxTipoIva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxTipoIva.BackColor = System.Drawing.Color.Cornsilk
        Me.cbxTipoIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoIva.FormattingEnabled = True
        Me.cbxTipoIva.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbxTipoIva.Items.AddRange(New Object() {"16.000", "10.670", "10.666", "00.000"})
        Me.cbxTipoIva.Location = New System.Drawing.Point(426, 18)
        Me.cbxTipoIva.Name = "cbxTipoIva"
        Me.cbxTipoIva.Size = New System.Drawing.Size(73, 20)
        Me.cbxTipoIva.TabIndex = 262
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(316, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 263
        Me.Label11.Text = "Cuenta :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(113, 18)
        Me.txtDescripcion.MaxLength = 45
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(215, 20)
        Me.txtDescripcion.TabIndex = 258
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(491, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 257
        Me.Label10.Text = "Importe :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(545, 70)
        Me.txtImporte.MaxLength = 45
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(75, 20)
        Me.txtImporte.TabIndex = 256
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(335, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 255
        Me.Label9.Text = "Iva :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(369, 18)
        Me.txtIva.MaxLength = 45
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(51, 20)
        Me.txtIva.TabIndex = 254
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(311, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 253
        Me.Label8.Text = "Subtotal :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(369, 70)
        Me.txtSubtotal.MaxLength = 45
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(72, 20)
        Me.txtSubtotal.TabIndex = 252
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(158, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 251
        Me.Label7.Text = "Costo Nue :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostoNuevo
        '
        Me.txtCostoNuevo.BackColor = System.Drawing.Color.Cornsilk
        Me.txtCostoNuevo.Location = New System.Drawing.Point(227, 70)
        Me.txtCostoNuevo.MaxLength = 45
        Me.txtCostoNuevo.Name = "txtCostoNuevo"
        Me.txtCostoNuevo.Size = New System.Drawing.Size(73, 20)
        Me.txtCostoNuevo.TabIndex = 250
        Me.txtCostoNuevo.Text = "0.00"
        Me.txtCostoNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 249
        Me.Label6.Text = "Costo Ant :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostoAnt
        '
        Me.txtCostoAnt.Location = New System.Drawing.Point(77, 70)
        Me.txtCostoAnt.MaxLength = 45
        Me.txtCostoAnt.Name = "txtCostoAnt"
        Me.txtCostoAnt.ReadOnly = True
        Me.txtCostoAnt.Size = New System.Drawing.Size(73, 20)
        Me.txtCostoAnt.TabIndex = 248
        Me.txtCostoAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(505, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 247
        Me.Label5.Text = "Cant :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(545, 17)
        Me.txtCantidad.MaxLength = 45
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(46, 20)
        Me.txtCantidad.TabIndex = 246
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "Cotizacion :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCot
        '
        Me.txtCot.Location = New System.Drawing.Point(227, 44)
        Me.txtCot.MaxLength = 45
        Me.txtCot.Name = "txtCot"
        Me.txtCot.ReadOnly = True
        Me.txtCot.Size = New System.Drawing.Size(51, 20)
        Me.txtCot.TabIndex = 244
        Me.txtCot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 243
        Me.Label3.Text = "Solicitud :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSol
        '
        Me.txtSol.Location = New System.Drawing.Point(77, 44)
        Me.txtSol.MaxLength = 45
        Me.txtSol.Name = "txtSol"
        Me.txtSol.ReadOnly = True
        Me.txtSol.Size = New System.Drawing.Size(51, 20)
        Me.txtSol.TabIndex = 242
        Me.txtSol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 241
        Me.Label2.Text = "ID :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIDSol
        '
        Me.txtIDSol.Location = New System.Drawing.Point(77, 18)
        Me.txtIDSol.MaxLength = 45
        Me.txtIDSol.Name = "txtIDSol"
        Me.txtIDSol.ReadOnly = True
        Me.txtIDSol.Size = New System.Drawing.Size(30, 20)
        Me.txtIDSol.TabIndex = 240
        Me.txtIDSol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmProveedorCambioPrecioOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 362)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbxAgregaElimina)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProveedorCambioPrecioOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Menor OC"
        Me.cbxAgregaElimina.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents cbxAgregaElimina As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOCFolioCOT As System.Windows.Forms.TextBox
    Friend WithEvents lstCotizacion As System.Windows.Forms.ListView
    Friend WithEvents IDSOL As System.Windows.Forms.ColumnHeader
    Friend WithEvents FolioSol As System.Windows.Forms.ColumnHeader
    Friend WithEvents FolioCot As System.Windows.Forms.ColumnHeader
    Friend WithEvents DESCRIP As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cant As System.Windows.Forms.ColumnHeader
    Friend WithEvents CTO As System.Windows.Forms.ColumnHeader
    Friend WithEvents SubTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents Iva As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBusca As System.Windows.Forms.Button
    Friend WithEvents AntCto As System.Windows.Forms.ColumnHeader
    Friend WithEvents Usuario As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCostoNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCostoAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCot As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSol As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIDSol As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPorciento As System.Windows.Forms.TextBox
    Friend WithEvents Cuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents TipoIva As System.Windows.Forms.ColumnHeader
    Friend WithEvents cbxTipoIva As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxCuenta As System.Windows.Forms.ComboBox
End Class
