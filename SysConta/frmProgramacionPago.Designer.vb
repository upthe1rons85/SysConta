﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramacionPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramacionPago))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbxPanelPrincipal = New System.Windows.Forms.GroupBox()
        Me.chAnticipados = New System.Windows.Forms.CheckBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lstCuenta = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbxProveedor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbxProveedor = New System.Windows.Forms.GroupBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtDiascredito = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtVencimiento = New System.Windows.Forms.TextBox()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFechaRecepcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstDetCotizacion = New System.Windows.Forms.ListView()
        Me.mUnidadCot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mUnidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mCostoUni = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVACot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIvaTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mSubtotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mImpTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mObserva = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIvaRet4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtFechaRequerimiento = New System.Windows.Forms.TextBox()
        Me.txtAutorizo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lstCotizaciones = New System.Windows.Forms.ListView()
        Me.mAgregada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mFol_sol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mFol_Cot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mProveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mPiezasT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mImporte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mMoneda = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSolicito = New System.Windows.Forms.TextBox()
        Me.txtFechaSolicitud = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbxTotales = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtIEPS = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtISR = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtRet10 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRet4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cbxAgregaElimina = New System.Windows.Forms.GroupBox()
        Me.btnEliminarFac = New System.Windows.Forms.Button()
        Me.btnAgregarFactura = New System.Windows.Forms.Button()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lstFacturas = New System.Windows.Forms.ListView()
        Me.mSolicitudProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mCotizacionProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mFacturaProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mFechaProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mUnidades = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mSubtotalProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVAProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVAProv11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVAImp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVARet10H = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVARet10A = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIVARetencion4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mISRHono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mISRArren = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mIEPS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mTotalProv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dMoneda = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mDescuento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mCtaDescuento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PgsGrabar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalDocumento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ContabilidadDataSet21 = New WindowsApplication1.contabilidadDataSet2()
        Me.chkImpPoliza = New System.Windows.Forms.CheckBox()
        Me.gbxPanelPrincipal.SuspendLayout()
        Me.gbxProveedor.SuspendLayout()
        Me.gbxTotales.SuspendLayout()
        Me.cbxAgregaElimina.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ContabilidadDataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 24)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Programacion de Pagos"
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 596
        Me.LineShape3.X2 = 17
        Me.LineShape3.Y1 = 55
        Me.LineShape3.Y2 = 55
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(607, 653)
        Me.ShapeContainer1.TabIndex = 88
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 351
        Me.LineShape5.X2 = 111
        Me.LineShape5.Y1 = 611
        Me.LineShape5.Y2 = 611
        '
        'txtFolio
        '
        Me.txtFolio.BackColor = System.Drawing.SystemColors.Info
        Me.txtFolio.Location = New System.Drawing.Point(113, 12)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(75, 20)
        Me.txtFolio.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 89
        '
        'gbxPanelPrincipal
        '
        Me.gbxPanelPrincipal.Controls.Add(Me.chAnticipados)
        Me.gbxPanelPrincipal.Controls.Add(Me.lblCodigo)
        Me.gbxPanelPrincipal.Controls.Add(Me.Label15)
        Me.gbxPanelPrincipal.Controls.Add(Me.btnBuscar)
        Me.gbxPanelPrincipal.Controls.Add(Me.lstCuenta)
        Me.gbxPanelPrincipal.Controls.Add(Me.Label24)
        Me.gbxPanelPrincipal.Controls.Add(Me.txtFolio)
        Me.gbxPanelPrincipal.Controls.Add(Me.cbxProveedor)
        Me.gbxPanelPrincipal.Controls.Add(Me.Label7)
        Me.gbxPanelPrincipal.Controls.Add(Me.Label3)
        Me.gbxPanelPrincipal.Location = New System.Drawing.Point(12, 56)
        Me.gbxPanelPrincipal.Name = "gbxPanelPrincipal"
        Me.gbxPanelPrincipal.Size = New System.Drawing.Size(582, 52)
        Me.gbxPanelPrincipal.TabIndex = 0
        Me.gbxPanelPrincipal.TabStop = False
        '
        'chAnticipados
        '
        Me.chAnticipados.AutoSize = True
        Me.chAnticipados.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chAnticipados.Location = New System.Drawing.Point(262, 32)
        Me.chAnticipados.Name = "chAnticipados"
        Me.chAnticipados.Size = New System.Drawing.Size(91, 16)
        Me.chAnticipados.TabIndex = 134
        Me.chAnticipados.Text = "Pago Anticipado"
        Me.chAnticipados.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(538, 16)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(0, 13)
        Me.lblCodigo.TabIndex = 108
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(508, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "Cod :"
        '
        'btnBuscar
        '
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Location = New System.Drawing.Point(457, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(49, 20)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lstCuenta
        '
        Me.lstCuenta.AutoSize = True
        Me.lstCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCuenta.Location = New System.Drawing.Point(495, 18)
        Me.lstCuenta.Name = "lstCuenta"
        Me.lstCuenta.Size = New System.Drawing.Size(0, 9)
        Me.lstCuenta.TabIndex = 106
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 15)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(103, 13)
        Me.Label24.TabIndex = 96
        Me.Label24.Text = "Folio ContraRecibo :"
        '
        'cbxProveedor
        '
        Me.cbxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxProveedor.Enabled = False
        Me.cbxProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProveedor.FormattingEnabled = True
        Me.cbxProveedor.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbxProveedor.Location = New System.Drawing.Point(262, 12)
        Me.cbxProveedor.Name = "cbxProveedor"
        Me.cbxProveedor.Size = New System.Drawing.Size(190, 20)
        Me.cbxProveedor.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(194, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Proveedor :"
        '
        'gbxProveedor
        '
        Me.gbxProveedor.Controls.Add(Me.DtpFecha)
        Me.gbxProveedor.Controls.Add(Me.Label33)
        Me.gbxProveedor.Controls.Add(Me.txtTipoCambio)
        Me.gbxProveedor.Controls.Add(Me.Label25)
        Me.gbxProveedor.Controls.Add(Me.txtDiascredito)
        Me.gbxProveedor.Controls.Add(Me.Label19)
        Me.gbxProveedor.Controls.Add(Me.txtVencimiento)
        Me.gbxProveedor.Controls.Add(Me.lblEstatus)
        Me.gbxProveedor.Controls.Add(Me.Label18)
        Me.gbxProveedor.Controls.Add(Me.Label16)
        Me.gbxProveedor.Controls.Add(Me.txtFechaRecepcion)
        Me.gbxProveedor.Controls.Add(Me.Label5)
        Me.gbxProveedor.Controls.Add(Me.txtObservaciones)
        Me.gbxProveedor.Controls.Add(Me.Label2)
        Me.gbxProveedor.Controls.Add(Me.lstDetCotizacion)
        Me.gbxProveedor.Controls.Add(Me.Label23)
        Me.gbxProveedor.Controls.Add(Me.txtFechaRequerimiento)
        Me.gbxProveedor.Controls.Add(Me.txtAutorizo)
        Me.gbxProveedor.Controls.Add(Me.Label22)
        Me.gbxProveedor.Controls.Add(Me.lstCotizaciones)
        Me.gbxProveedor.Controls.Add(Me.Label10)
        Me.gbxProveedor.Controls.Add(Me.txtSolicito)
        Me.gbxProveedor.Controls.Add(Me.txtFechaSolicitud)
        Me.gbxProveedor.Controls.Add(Me.Label6)
        Me.gbxProveedor.Controls.Add(Me.gbxTotales)
        Me.gbxProveedor.Controls.Add(Me.cbxAgregaElimina)
        Me.gbxProveedor.Controls.Add(Me.ShapeContainer3)
        Me.gbxProveedor.Location = New System.Drawing.Point(12, 108)
        Me.gbxProveedor.Name = "gbxProveedor"
        Me.gbxProveedor.Size = New System.Drawing.Size(585, 403)
        Me.gbxProveedor.TabIndex = 1
        Me.gbxProveedor.TabStop = False
        '
        'DtpFecha
        '
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Location = New System.Drawing.Point(182, 274)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(180, 18)
        Me.DtpFecha.TabIndex = 133
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(204, 357)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 12)
        Me.Label33.TabIndex = 131
        Me.Label33.Text = "Tipo de Cambio :"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.Silver
        Me.txtTipoCambio.Location = New System.Drawing.Point(286, 352)
        Me.txtTipoCambio.MaxLength = 40
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(70, 20)
        Me.txtTipoCambio.TabIndex = 132
        Me.txtTipoCambio.Text = "0.00"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(250, 255)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 13)
        Me.Label25.TabIndex = 131
        Me.Label25.Text = "Dias Credito :"
        '
        'txtDiascredito
        '
        Me.txtDiascredito.BackColor = System.Drawing.SystemColors.Info
        Me.txtDiascredito.Enabled = False
        Me.txtDiascredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiascredito.Location = New System.Drawing.Point(326, 251)
        Me.txtDiascredito.Name = "txtDiascredito"
        Me.txtDiascredito.Size = New System.Drawing.Size(36, 20)
        Me.txtDiascredito.TabIndex = 130
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 279)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 13)
        Me.Label19.TabIndex = 129
        Me.Label19.Text = "Fecha Programada"
        '
        'txtVencimiento
        '
        Me.txtVencimiento.BackColor = System.Drawing.SystemColors.Info
        Me.txtVencimiento.Enabled = False
        Me.txtVencimiento.Location = New System.Drawing.Point(107, 275)
        Me.txtVencimiento.Name = "txtVencimiento"
        Me.txtVencimiento.Size = New System.Drawing.Size(68, 20)
        Me.txtVencimiento.TabIndex = 128
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.Font = New System.Drawing.Font("Bodoni MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.Location = New System.Drawing.Point(278, 307)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(0, 16)
        Me.lblEstatus.TabIndex = 127
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(223, 310)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 13)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "Estatus :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 256)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "Fecha Recepción"
        '
        'txtFechaRecepcion
        '
        Me.txtFechaRecepcion.BackColor = System.Drawing.SystemColors.Info
        Me.txtFechaRecepcion.Enabled = False
        Me.txtFechaRecepcion.Location = New System.Drawing.Point(107, 252)
        Me.txtFechaRecepcion.Name = "txtFechaRecepcion"
        Me.txtFechaRecepcion.Size = New System.Drawing.Size(68, 20)
        Me.txtFechaRecepcion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 9)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Info
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(11, 374)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(345, 25)
        Me.txtObservaciones.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 9)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "FECHA :"
        '
        'lstDetCotizacion
        '
        Me.lstDetCotizacion.BackColor = System.Drawing.Color.Gainsboro
        Me.lstDetCotizacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mUnidadCot, Me.mUnidad, Me.mDescripcion, Me.mCostoUni, Me.mIVACot, Me.mIvaTotal, Me.mSubtotal, Me.mImpTotal, Me.mObserva, Me.mIvaRet4})
        Me.lstDetCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDetCotizacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstDetCotizacion.FullRowSelect = True
        Me.lstDetCotizacion.Location = New System.Drawing.Point(7, 105)
        Me.lstDetCotizacion.Name = "lstDetCotizacion"
        Me.lstDetCotizacion.Size = New System.Drawing.Size(572, 82)
        Me.lstDetCotizacion.TabIndex = 4
        Me.lstDetCotizacion.UseCompatibleStateImageBehavior = False
        Me.lstDetCotizacion.View = System.Windows.Forms.View.Details
        '
        'mUnidadCot
        '
        Me.mUnidadCot.Text = "Pzas"
        Me.mUnidadCot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mUnidadCot.Width = 38
        '
        'mUnidad
        '
        Me.mUnidad.Text = "Unidad"
        Me.mUnidad.Width = 42
        '
        'mDescripcion
        '
        Me.mDescripcion.Text = "Producto"
        Me.mDescripcion.Width = 135
        '
        'mCostoUni
        '
        Me.mCostoUni.Text = "Costo U"
        Me.mCostoUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mCostoUni.Width = 79
        '
        'mIVACot
        '
        Me.mIVACot.Text = "IVA"
        Me.mIVACot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mIVACot.Width = 56
        '
        'mIvaTotal
        '
        Me.mIvaTotal.Text = "IVATotal"
        Me.mIvaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mIvaTotal.Width = 67
        '
        'mSubtotal
        '
        Me.mSubtotal.Text = "Subtotal"
        Me.mSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mSubtotal.Width = 76
        '
        'mImpTotal
        '
        Me.mImpTotal.Text = "Importe"
        Me.mImpTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mImpTotal.Width = 86
        '
        'mObserva
        '
        Me.mObserva.Text = "Observaciones"
        '
        'mIvaRet4
        '
        Me.mIvaRet4.Text = ""
        Me.mIvaRet4.Width = 20
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(179, 232)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(114, 13)
        Me.Label23.TabIndex = 113
        Me.Label23.Text = "Fec. de Requerimiento"
        '
        'txtFechaRequerimiento
        '
        Me.txtFechaRequerimiento.BackColor = System.Drawing.SystemColors.Info
        Me.txtFechaRequerimiento.Enabled = False
        Me.txtFechaRequerimiento.Location = New System.Drawing.Point(297, 228)
        Me.txtFechaRequerimiento.Name = "txtFechaRequerimiento"
        Me.txtFechaRequerimiento.Size = New System.Drawing.Size(65, 20)
        Me.txtFechaRequerimiento.TabIndex = 4
        '
        'txtAutorizo
        '
        Me.txtAutorizo.BackColor = System.Drawing.SystemColors.Info
        Me.txtAutorizo.Enabled = False
        Me.txtAutorizo.Location = New System.Drawing.Point(258, 205)
        Me.txtAutorizo.Name = "txtAutorizo"
        Me.txtAutorizo.Size = New System.Drawing.Size(104, 20)
        Me.txtAutorizo.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(252, 189)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = "Autorizó"
        '
        'lstCotizaciones
        '
        Me.lstCotizaciones.BackColor = System.Drawing.SystemColors.Info
        Me.lstCotizaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mAgregada, Me.mFol_sol, Me.mFol_Cot, Me.mProveedor, Me.mPiezasT, Me.mIVA, Me.mImporte, Me.mMoneda})
        Me.lstCotizaciones.Enabled = False
        Me.lstCotizaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCotizaciones.FullRowSelect = True
        Me.lstCotizaciones.GridLines = True
        Me.lstCotizaciones.Location = New System.Drawing.Point(5, 12)
        Me.lstCotizaciones.Name = "lstCotizaciones"
        Me.lstCotizaciones.Size = New System.Drawing.Size(573, 88)
        Me.lstCotizaciones.TabIndex = 3
        Me.lstCotizaciones.UseCompatibleStateImageBehavior = False
        Me.lstCotizaciones.View = System.Windows.Forms.View.Details
        '
        'mAgregada
        '
        Me.mAgregada.Text = "+"
        Me.mAgregada.Width = 20
        '
        'mFol_sol
        '
        Me.mFol_sol.Text = "FolSol"
        Me.mFol_sol.Width = 38
        '
        'mFol_Cot
        '
        Me.mFol_Cot.Text = "FolCot"
        Me.mFol_Cot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mFol_Cot.Width = 46
        '
        'mProveedor
        '
        Me.mProveedor.Text = "Proveedor"
        Me.mProveedor.Width = 204
        '
        'mPiezasT
        '
        Me.mPiezasT.Text = "Unidades"
        Me.mPiezasT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mPiezasT.Width = 51
        '
        'mIVA
        '
        Me.mIVA.Text = "IVA"
        Me.mIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mIVA.Width = 73
        '
        'mImporte
        '
        Me.mImporte.Text = "Importe Total"
        Me.mImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mImporte.Width = 95
        '
        'mMoneda
        '
        Me.mMoneda.Text = "Mon"
        Me.mMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mMoneda.Width = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Fecha Solicitud"
        '
        'txtSolicito
        '
        Me.txtSolicito.BackColor = System.Drawing.SystemColors.Info
        Me.txtSolicito.Enabled = False
        Me.txtSolicito.Location = New System.Drawing.Point(7, 206)
        Me.txtSolicito.Name = "txtSolicito"
        Me.txtSolicito.Size = New System.Drawing.Size(238, 20)
        Me.txtSolicito.TabIndex = 5
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.BackColor = System.Drawing.SystemColors.Info
        Me.txtFechaSolicitud.Enabled = False
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(107, 229)
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(68, 20)
        Me.txtFechaSolicitud.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Solicitó"
        '
        'gbxTotales
        '
        Me.gbxTotales.Controls.Add(Me.Label31)
        Me.gbxTotales.Controls.Add(Me.txtIEPS)
        Me.gbxTotales.Controls.Add(Me.Label32)
        Me.gbxTotales.Controls.Add(Me.Label29)
        Me.gbxTotales.Controls.Add(Me.txtISR)
        Me.gbxTotales.Controls.Add(Me.Label30)
        Me.gbxTotales.Controls.Add(Me.Label28)
        Me.gbxTotales.Controls.Add(Me.txtRet10)
        Me.gbxTotales.Controls.Add(Me.Label27)
        Me.gbxTotales.Controls.Add(Me.Label26)
        Me.gbxTotales.Controls.Add(Me.Label20)
        Me.gbxTotales.Controls.Add(Me.txtRet4)
        Me.gbxTotales.Controls.Add(Me.Label12)
        Me.gbxTotales.Controls.Add(Me.Label11)
        Me.gbxTotales.Controls.Add(Me.Label8)
        Me.gbxTotales.Controls.Add(Me.txtTotal)
        Me.gbxTotales.Controls.Add(Me.txtIVA)
        Me.gbxTotales.Controls.Add(Me.txtUnidades)
        Me.gbxTotales.Controls.Add(Me.txtSubtotal)
        Me.gbxTotales.Controls.Add(Me.Label4)
        Me.gbxTotales.Controls.Add(Me.Label21)
        Me.gbxTotales.Controls.Add(Me.Label17)
        Me.gbxTotales.Controls.Add(Me.Label13)
        Me.gbxTotales.Controls.Add(Me.ShapeContainer2)
        Me.gbxTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTotales.Location = New System.Drawing.Point(365, 184)
        Me.gbxTotales.Name = "gbxTotales"
        Me.gbxTotales.Size = New System.Drawing.Size(214, 214)
        Me.gbxTotales.TabIndex = 103
        Me.gbxTotales.TabStop = False
        Me.gbxTotales.Text = " "
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(118, 149)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 13)
        Me.Label31.TabIndex = 140
        Me.Label31.Text = "$"
        '
        'txtIEPS
        '
        Me.txtIEPS.Enabled = False
        Me.txtIEPS.Location = New System.Drawing.Point(132, 147)
        Me.txtIEPS.Name = "txtIEPS"
        Me.txtIEPS.Size = New System.Drawing.Size(75, 18)
        Me.txtIEPS.TabIndex = 139
        Me.txtIEPS.Text = "0.00"
        Me.txtIEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(66, 151)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 13)
        Me.Label32.TabIndex = 138
        Me.Label32.Text = "I.E.P.S  :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(118, 128)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 13)
        Me.Label29.TabIndex = 137
        Me.Label29.Text = "$"
        '
        'txtISR
        '
        Me.txtISR.Enabled = False
        Me.txtISR.Location = New System.Drawing.Point(132, 126)
        Me.txtISR.Name = "txtISR"
        Me.txtISR.Size = New System.Drawing.Size(75, 18)
        Me.txtISR.TabIndex = 136
        Me.txtISR.Text = "0.00"
        Me.txtISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(73, 130)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(42, 13)
        Me.Label30.TabIndex = 135
        Me.Label30.Text = "I.S.R.  :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(118, 107)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 13)
        Me.Label28.TabIndex = 134
        Me.Label28.Text = "$"
        '
        'txtRet10
        '
        Me.txtRet10.Enabled = False
        Me.txtRet10.Location = New System.Drawing.Point(132, 105)
        Me.txtRet10.Name = "txtRet10"
        Me.txtRet10.Size = New System.Drawing.Size(76, 18)
        Me.txtRet10.TabIndex = 133
        Me.txtRet10.Text = "0.00"
        Me.txtRet10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(14, 107)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(101, 13)
        Me.Label27.TabIndex = 132
        Me.Label27.Text = "IVA Retension 10%:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(17, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 13)
        Me.Label26.TabIndex = 131
        Me.Label26.Text = "IVA Retension 4% :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(118, 86)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 13)
        Me.Label20.TabIndex = 130
        Me.Label20.Text = "$"
        '
        'txtRet4
        '
        Me.txtRet4.Enabled = False
        Me.txtRet4.Location = New System.Drawing.Point(132, 84)
        Me.txtRet4.Name = "txtRet4"
        Me.txtRet4.Size = New System.Drawing.Size(75, 18)
        Me.txtRet4.TabIndex = 129
        Me.txtRet4.Text = "0.00"
        Me.txtRet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(92, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(118, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(118, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "$"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(104, 190)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(103, 18)
        Me.txtTotal.TabIndex = 124
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(132, 62)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(75, 18)
        Me.txtIVA.TabIndex = 118
        Me.txtIVA.Text = "0.00"
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnidades
        '
        Me.txtUnidades.Enabled = False
        Me.txtUnidades.Location = New System.Drawing.Point(132, 18)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(75, 18)
        Me.txtUnidades.TabIndex = 116
        Me.txtUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(132, 40)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(75, 18)
        Me.txtSubtotal.TabIndex = 124
        Me.txtSubtotal.Text = "0.00"
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Subtotal  :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 193)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 120
        Me.Label21.Text = "TOTAL"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 13)
        Me.Label17.TabIndex = 112
        Me.Label17.Text = "IVA (16, 11, Imp)  :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Unidades T.  :"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 14)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(208, 197)
        Me.ShapeContainer2.TabIndex = 122
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 206
        Me.LineShape2.X2 = -1
        Me.LineShape2.Y1 = 174
        Me.LineShape2.Y2 = 174
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 206
        Me.LineShape1.X2 = -2
        Me.LineShape1.Y1 = 169
        Me.LineShape1.Y2 = 169
        '
        'cbxAgregaElimina
        '
        Me.cbxAgregaElimina.Controls.Add(Me.btnEliminarFac)
        Me.cbxAgregaElimina.Controls.Add(Me.btnAgregarFactura)
        Me.cbxAgregaElimina.Location = New System.Drawing.Point(7, 303)
        Me.cbxAgregaElimina.Name = "cbxAgregaElimina"
        Me.cbxAgregaElimina.Size = New System.Drawing.Size(214, 51)
        Me.cbxAgregaElimina.TabIndex = 120
        Me.cbxAgregaElimina.TabStop = False
        Me.cbxAgregaElimina.Text = "Factura Proveedor"
        '
        'btnEliminarFac
        '
        Me.btnEliminarFac.Enabled = False
        Me.btnEliminarFac.Location = New System.Drawing.Point(126, 20)
        Me.btnEliminarFac.Name = "btnEliminarFac"
        Me.btnEliminarFac.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarFac.TabIndex = 1
        Me.btnEliminarFac.Text = "Eliminar"
        Me.btnEliminarFac.UseVisualStyleBackColor = True
        '
        'btnAgregarFactura
        '
        Me.btnAgregarFactura.Enabled = False
        Me.btnAgregarFactura.Location = New System.Drawing.Point(12, 20)
        Me.btnAgregarFactura.Name = "btnAgregarFactura"
        Me.btnAgregarFactura.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarFactura.TabIndex = 0
        Me.btnAgregarFactura.Text = "Agregar"
        Me.btnAgregarFactura.UseVisualStyleBackColor = True
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4})
        Me.ShapeContainer3.Size = New System.Drawing.Size(579, 384)
        Me.ShapeContainer3.TabIndex = 121
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 350
        Me.LineShape4.X2 = 8
        Me.LineShape4.Y1 = 282
        Me.LineShape4.Y2 = 282
        '
        'lstFacturas
        '
        Me.lstFacturas.BackColor = System.Drawing.SystemColors.Info
        Me.lstFacturas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mSolicitudProv, Me.mCotizacionProv, Me.mFacturaProv, Me.mFechaProv, Me.mUnidades, Me.mSubtotalProv, Me.mIVAProv, Me.mIVAProv11, Me.mIVAImp, Me.mIVARet10H, Me.mIVARet10A, Me.mIVARetencion4, Me.mISRHono, Me.mISRArren, Me.mIEPS, Me.mTotalProv, Me.dMoneda, Me.mDescuento, Me.mCtaDescuento})
        Me.lstFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFacturas.FullRowSelect = True
        Me.lstFacturas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstFacturas.Location = New System.Drawing.Point(13, 518)
        Me.lstFacturas.Name = "lstFacturas"
        Me.lstFacturas.Size = New System.Drawing.Size(585, 85)
        Me.lstFacturas.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.lstFacturas, "Doble clic para cambiar el folio de la factura")
        Me.lstFacturas.UseCompatibleStateImageBehavior = False
        Me.lstFacturas.View = System.Windows.Forms.View.Details
        '
        'mSolicitudProv
        '
        Me.mSolicitudProv.Text = "FolSol"
        Me.mSolicitudProv.Width = 46
        '
        'mCotizacionProv
        '
        Me.mCotizacionProv.Text = "FolCot"
        Me.mCotizacionProv.Width = 51
        '
        'mFacturaProv
        '
        Me.mFacturaProv.Text = "Factura"
        '
        'mFechaProv
        '
        Me.mFechaProv.Text = "Fecha"
        Me.mFechaProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mFechaProv.Width = 72
        '
        'mUnidades
        '
        Me.mUnidades.Text = "Uni"
        Me.mUnidades.Width = 32
        '
        'mSubtotalProv
        '
        Me.mSubtotalProv.Text = "Subtotal"
        Me.mSubtotalProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mSubtotalProv.Width = 72
        '
        'mIVAProv
        '
        Me.mIVAProv.Text = "IVA16"
        Me.mIVAProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mIVAProv.Width = 65
        '
        'mIVAProv11
        '
        Me.mIVAProv11.Text = "IVA11"
        Me.mIVAProv11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mIVAImp
        '
        Me.mIVAImp.Text = "IVAImp"
        Me.mIVAImp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mIVARet10H
        '
        Me.mIVARet10H.Text = "RET10%H"
        Me.mIVARet10H.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mIVARet10H.Width = 65
        '
        'mIVARet10A
        '
        Me.mIVARet10A.Text = "RET10%A"
        Me.mIVARet10A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mIVARetencion4
        '
        Me.mIVARetencion4.Text = "RET4%"
        Me.mIVARetencion4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mIVARetencion4.Width = 65
        '
        'mISRHono
        '
        Me.mISRHono.Text = "ISRHono"
        Me.mISRHono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mISRHono.Width = 65
        '
        'mISRArren
        '
        Me.mISRArren.Text = "ISRArren"
        Me.mISRArren.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mIEPS
        '
        Me.mIEPS.Text = "IEPS"
        Me.mIEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mIEPS.Width = 65
        '
        'mTotalProv
        '
        Me.mTotalProv.Text = "Importe Total"
        Me.mTotalProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mTotalProv.Width = 97
        '
        'dMoneda
        '
        Me.dMoneda.Text = "Mon"
        Me.dMoneda.Width = 33
        '
        'mDescuento
        '
        Me.mDescuento.Text = "Descuento"
        Me.mDescuento.Width = 65
        '
        'mCtaDescuento
        '
        Me.mCtaDescuento.Text = "CtaDescuento"
        Me.mCtaDescuento.Width = 100
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario, Me.PgsGrabar, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 631)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(607, 22)
        Me.StatusStrip1.TabIndex = 104
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
        Me.PgsGrabar.Size = New System.Drawing.Size(185, 16)
        Me.PgsGrabar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 15)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Image = Global.WindowsApplication1.My.Resources.Resources.delete_C_mayseg
        Me.BtnEliminar.Location = New System.Drawing.Point(559, 12)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(37, 38)
        Me.BtnEliminar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Image = Global.WindowsApplication1.My.Resources.Resources.print
        Me.btnImprimir.Location = New System.Drawing.Point(517, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(37, 38)
        Me.btnImprimir.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.WindowsApplication1.My.Resources.Resources.file_new_C_mayseg
        Me.btnNuevo.Location = New System.Drawing.Point(436, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(37, 38)
        Me.btnNuevo.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Image = Global.WindowsApplication1.My.Resources.Resources.save_C_mayseg
        Me.BtnGuardar.Location = New System.Drawing.Point(475, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(37, 38)
        Me.BtnGuardar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Guardar")
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(460, 611)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "$"
        '
        'txtTotalDocumento
        '
        Me.txtTotalDocumento.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalDocumento.Enabled = False
        Me.txtTotalDocumento.Location = New System.Drawing.Point(487, 608)
        Me.txtTotalDocumento.Name = "txtTotalDocumento"
        Me.txtTotalDocumento.Size = New System.Drawing.Size(103, 20)
        Me.txtTotalDocumento.TabIndex = 129
        Me.txtTotalDocumento.Text = "0.00"
        Me.txtTotalDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(338, 611)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 13)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "TOTAL DOCUMENTO"
        '
        'ContabilidadDataSet21
        '
        Me.ContabilidadDataSet21.DataSetName = "contabilidadDataSet2"
        Me.ContabilidadDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkImpPoliza
        '
        Me.chkImpPoliza.AutoSize = True
        Me.chkImpPoliza.Checked = True
        Me.chkImpPoliza.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImpPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImpPoliza.Location = New System.Drawing.Point(12, 610)
        Me.chkImpPoliza.Name = "chkImpPoliza"
        Me.chkImpPoliza.Size = New System.Drawing.Size(85, 16)
        Me.chkImpPoliza.TabIndex = 133
        Me.chkImpPoliza.Text = "Imprimir Poliza"
        Me.chkImpPoliza.UseVisualStyleBackColor = True
        '
        'frmProgramacionPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(607, 653)
        Me.Controls.Add(Me.chkImpPoliza)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lstFacturas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalDocumento)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.gbxPanelPrincipal)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProgramacionPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programacion de Pago"
        Me.gbxPanelPrincipal.ResumeLayout(False)
        Me.gbxPanelPrincipal.PerformLayout()
        Me.gbxProveedor.ResumeLayout(False)
        Me.gbxProveedor.PerformLayout()
        Me.gbxTotales.ResumeLayout(False)
        Me.gbxTotales.PerformLayout()
        Me.cbxAgregaElimina.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ContabilidadDataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbxPanelPrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents gbxProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents txtFechaSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSolicito As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbxTotales As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lstCotizaciones As System.Windows.Forms.ListView
    Friend WithEvents mFol_Cot As System.Windows.Forms.ColumnHeader
    Friend WithEvents mPiezasT As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVA As System.Windows.Forms.ColumnHeader
    Friend WithEvents mImporte As System.Windows.Forms.ColumnHeader
    Friend WithEvents mProveedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtAutorizo As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtFechaRequerimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents lstDetCotizacion As System.Windows.Forms.ListView
    Friend WithEvents mUnidadCot As System.Windows.Forms.ColumnHeader
    Friend WithEvents mDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents mCostoUni As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVACot As System.Windows.Forms.ColumnHeader
    Friend WithEvents mUnidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents mFol_sol As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lstFacturas As System.Windows.Forms.ListView
    Friend WithEvents mSolicitudProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents mCotizacionProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents mFacturaProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents mSubtotalProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVAProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents mTotalProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAgregarFactura As System.Windows.Forms.Button
    Friend WithEvents cbxAgregaElimina As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminarFac As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstCuenta As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents mFechaProv As System.Windows.Forms.ColumnHeader
    Friend WithEvents mUnidades As System.Windows.Forms.ColumnHeader
    Friend WithEvents mAgregada As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFechaRecepcion As System.Windows.Forms.TextBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PgsGrabar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtRet4 As System.Windows.Forms.TextBox
    Friend WithEvents ContabilidadDataSet21 As WindowsApplication1.contabilidadDataSet2
    Friend WithEvents mIVARetencion4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtVencimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtDiascredito As System.Windows.Forms.TextBox
    Friend WithEvents mMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents dMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtRet10 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtIEPS As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtISR As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents mIVARet10H As System.Windows.Forms.ColumnHeader
    Friend WithEvents mISRHono As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIEPS As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVAProv11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVAImp As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIVARet10A As System.Windows.Forms.ColumnHeader
    Friend WithEvents mISRArren As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents chkImpPoliza As System.Windows.Forms.CheckBox
    Friend WithEvents mIvaTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents mSubtotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents mImpTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents mObserva As System.Windows.Forms.ColumnHeader
    Friend WithEvents mIvaRet4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAnticipados As System.Windows.Forms.CheckBox
    Friend WithEvents mDescuento As System.Windows.Forms.ColumnHeader
    Friend WithEvents mCtaDescuento As System.Windows.Forms.ColumnHeader
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
End Class
