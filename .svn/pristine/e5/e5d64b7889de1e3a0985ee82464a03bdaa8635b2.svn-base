Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports WindowsApplication1.frmProgramacionPago_FacProv
Imports System.Data.SqlClient
Imports System.Windows.Forms.ListView
Imports System.Drawing
Imports System.Collections

Public Class frmEntradasCierre
    Public FolioOCompra As Integer
    Public cuentaProv As String
    Public nPoliza As Integer


    Private Sub frmEntradasCierre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta As String = "select * from almacen.dbo.catProveedores (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxProveedor.ValueMember = "cuentacontable"
        cbxProveedor.DisplayMember = "proveedor"

        cbxProveedor.DataSource = dt
        '--------------------------------
        cbxProveedor.Text = ""

        cbxTipo.SelectedIndex = 0
    End Sub

    Private Sub CargarProveedores()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta As String = "SELECT * FROM catCuentas (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxProveedor.ValueMember = "Descripcion"
        cbxProveedor.DisplayMember = "Cuenta"

        cbxProveedor.DataSource = dt
        '--------------------------------
        cbxProveedor.Text = ""
    End Sub

    Private Sub CargarCampoOC()

        If txtFolioAnticipo.Text = "" Then
            btnNuevo.PerformClick()
            Exit Sub
        End If
        Dim cnnConexion = New SqlConnection()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim FolioAnti As String
        FolioAnti = txtFolioAnticipo.Text
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        cmd.CommandText = "SELECT * FROM conEntradasEngorda (NOLOCK) WHERE FolioAnticipo = " & FolioAnti
        cmd.CommandType = CommandType.Text
        cmd.Connection = cnnConexion

        'cnnConexion.Open()

        dr = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        If dr.Read Then
            txtOCEngorda.Text = dr("OCEngorda").ToString
            txtEntrada.Text = ""
            btnBuscar.PerformClick()
        Else
            btnNuevo.PerformClick()
            txtFolioAnticipo.Text = FolioAnti
        End If
        cnnConexion.Close()

    End Sub

    Private Sub CargarOrdenesCompra()
        lstAnticipos.Items.Clear()
        lstPagos.Items.Clear()
        lstOrdenes.Items.Clear()
        txtSaldo.Text = "0.00"
        txtDiferencia.Text = "0.00"
        txtPagos.Text = "0.00"
        txtMoneda.Text = ""
        Dim dr As SqlDataReader
        Dim oclsMovientosBanco = New clsCierreEntrada

        Dim nProveedor As String
        Dim nOrdenCompra As String
        Dim nEntrada As String
        Dim nTipo As Integer
        txtSaldo.Text = "0.00"
        txtDiferencia.Text = "0.00"
        txtPagos.Text = "0.00"
        If cbxProveedor.Text = "" Then
            nProveedor = ""
        Else
            nProveedor = cbxProveedor.SelectedValue
        End If
        If txtEntrada.Text = "" Then
            nEntrada = 0
        Else
            nEntrada = txtEntrada.Text
        End If

        nOrdenCompra = txtOCEngorda.Text

        Select Case cbxTipo.SelectedIndex
            Case 0
                nTipo = 30
            Case 1
                nTipo = 33
            Case Else
                nTipo = 0
        End Select


        dr = oclsMovientosBanco.SeleccionaListaOrdenCompra(nProveedor, nOrdenCompra, nEntrada, nTipo)

        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then

            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("OCEngorda").ToString)
                lstLista.SubItems.Add(rRow("FolioEntrada").ToString)
                lstLista.SubItems.Add(rRow("proveedor").ToString)
                lstLista.SubItems.Add(Format(CDec(rRow("SubTotal").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDec(rRow("IVA16").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDec(rRow("IVA11").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDec(rRow("IVARet4").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDec(rRow("Importe").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(Format(CDec(rRow("Saldo").ToString), "###,###,##0.00"))
                lstLista.SubItems.Add(rRow("TipoMoneda").ToString)
                lstLista.SubItems.Add(rRow("TipoCambio").ToString)
                lstLista.SubItems.Add(rRow("CodigoProveedor").ToString)
                lstLista.SubItems.Add(rRow("cuentaanticipo").ToString)
                lstLista.SubItems.Add(rRow("FechaEntrada").ToString)
                lstOrdenes.Items.Add(lstLista)

            Next
            '-----------------FIN CARGAR GRID
        End If
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        CargarOrdenesCompra()
    End Sub

    Private Sub txtOCEngorda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOCEngorda.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CargarOrdenesCompra()
        End If
    End Sub

    Private Sub cbxProveedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxProveedor.Click

    End Sub

    Private Sub txtEntrada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntrada.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CargarOrdenesCompra()
        End If
    End Sub

    Private Sub LlenarLSTAnticipos(ByVal nFolio As String, ByVal FolioAnti As String)
        Dim dr As SqlDataReader
        Dim oclsMovientosBanco = New clsCierreEntrada()
        'txtCuenta.Text = Format(txtCuenta.Text, "0000")
        dr = oclsMovientosBanco.SeleccionaListaAnticiposPendientes(nFolio, FolioAnti)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstAnticipos.Items.Clear()

            ' checkbox en list
            'lstAnticipos.RightToLeftLayout = True
            'lstAnticipos.RightToLeft = Windows.Forms.RightToLeft.Yes
            'lstAnticipos.View = View.Details
            'lstAnticipos.CheckBoxes = True

            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("FolioContraRecibo").ToString)
                lstLista.SubItems.Add(Trim(rRow("FacturaProveedor").ToString))
                lstLista.SubItems.Add(Trim(Mid(rRow("FechaFactura").ToString, 1, 10)))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("ant_Saldo").ToString), "###,###,##0.00")))
                lstLista.SubItems.Add(Trim(rRow("TipoMoneda").ToString))
                lstLista.SubItems.Add(Trim(Format(CDec(rRow("TipoCambio").ToString), "##0.0000")))
                lstAnticipos.Items.Add(lstLista)

            Next

        End If
    End Sub

    Private Sub lstOrdenes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstOrdenes.Click
        If Not lstOrdenes.SelectedItems(0).SubItems(12).Text = "" Then
            Dim FolAnti As String
            lstAnticipos.Items.Clear()
            lstPagos.Items.Clear()
            txtDiferencia.Text = "0.00"
            txtPagos.Text = "0.00"
            If txtFolioAnticipo.Text = "" Then
                FolAnti = 0
            Else
                FolAnti = txtFolioAnticipo.Text
            End If
            LlenarLSTAnticipos(Trim(lstOrdenes.SelectedItems(0).SubItems(0).Text), FolAnti)
            FolioOCompra = Trim(lstOrdenes.SelectedItems(0).SubItems(0).Text)
            txtOCEngorda.Text = Trim(lstOrdenes.SelectedItems(0).SubItems(0).Text)
            txtEntrada.Text = Trim(lstOrdenes.SelectedItems(0).SubItems(1).Text)
            txtTipoCambio.Text = Trim(lstOrdenes.SelectedItems(0).SubItems(10).Text)
            txtSaldo.Text = Format(CDbl(lstOrdenes.SelectedItems(0).SubItems(8).Text), "###,###,##0.00")
            txtDiferencia.Text = Format(CDbl(lstOrdenes.SelectedItems(0).SubItems(8).Text), "###,###,##0.00")
            cuentaProv = Trim(lstOrdenes.SelectedItems(0).SubItems(11).Text)
            lstAnticipos.Enabled = True
            If CDbl(lstOrdenes.SelectedItems(0).SubItems(9).Text) = 2 Then
                txtMoneda.Text = "DOLARES"
            Else
                txtMoneda.Text = "PESOS"
            End If
        Else
            MsgBox("El proveedor no cuenta con anticipo, favor de revisarlo con administrador ", vbInformation, "Sistema Contable")
        End If
    End Sub

    Private Sub lstAnticipos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstAnticipos.DoubleClick
        Dim mImporte As Double
        Dim mPago As Double
        Dim mDiferencia As Double
        Dim rowImpo As Double
        Dim mSaldo As Double
        Dim TipoMoneda As String

        If lstAnticipos.SelectedItems(0).SubItems(4).Text = 2 Then
            TipoMoneda = "DOLARES"
        Else
            TipoMoneda = "PESOS"
        End If
        If TipoMoneda <> txtMoneda.Text Then
            MsgBox("El anticipo se encuentra dado de alta con diferente moneda, no procede la operacion", MsgBoxStyle.Critical, "Sistemas Contable")
            Exit Sub
        End If

        For i As Integer = 0 To lstPagos.Items.Count - 1
            If lstPagos.Items(i).SubItems(0).Text = lstAnticipos.SelectedItems(0).SubItems(0).Text _
               And lstPagos.Items(i).SubItems(2).Text = lstAnticipos.SelectedItems(0).SubItems(2).Text Then
                MsgBox("Elemento ya se encuentra Agregado", MsgBoxStyle.Information)
                Exit Sub
            End If
        Next

        rowImpo = CDbl(lstAnticipos.SelectedItems(0).SubItems(3).Text)
        mSaldo = CDbl(txtSaldo.Text)
        mPago = CDbl(txtPagos.Text)
        mDiferencia = CDbl(txtDiferencia.Text)
        If (rowImpo + mPago) > mSaldo Then
            rowImpo = mSaldo - mPago
        End If

        Dim lstLista As New ListViewItem(lstAnticipos.SelectedItems(0).SubItems(0).Text)
        lstLista.SubItems.Add(lstAnticipos.SelectedItems(0).SubItems(1).Text)
        lstLista.SubItems.Add(lstAnticipos.SelectedItems(0).SubItems(2).Text)
        lstLista.SubItems.Add(Format(CDbl(rowImpo.ToString), "###,###,##0.00"))
        lstLista.SubItems.Add(lstAnticipos.SelectedItems(0).SubItems(4).Text)
        lstLista.SubItems.Add(lstAnticipos.SelectedItems(0).SubItems(5).Text)
        lstPagos.Items.Add(lstLista)

        lstAnticipos.SelectedItems(0).Remove()
        mImporte = mPago + rowImpo
        txtPagos.Text = Format(mImporte, "###,###,##0.00")
        txtDiferencia.Text = Format(mSaldo - (mPago + rowImpo), "###,###,##0.00")
        ValidarInformacion()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        lstAnticipos.Items.Clear()
        lstPagos.Items.Clear()
        lstOrdenes.Items.Clear()
        txtSaldo.Text = "0.00"
        txtDiferencia.Text = "0.00"
        txtPagos.Text = "0.00"
        txtOCEngorda.Text = ""
        txtEntrada.Text = ""
        cbxProveedor.Text = ""
        lstAnticipos.Enabled = True
        txtFolioAnticipo.Text = ""
        chOrdenCompra.Checked = False
        txtMoneda.Text = ""
    End Sub

    Private Sub lstPagos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPagos.DoubleClick
        Dim mImporte As Double
        Dim mPago As Double
        Dim mDiferencia As Double
        Dim rowImpo As Double
        Dim mSaldo As Double
        For i As Integer = 0 To lstAnticipos.Items.Count - 1
            If lstAnticipos.Items(i).SubItems(0).Text = lstPagos.SelectedItems(0).SubItems(0).Text _
               And lstAnticipos.Items(i).SubItems(2).Text = lstPagos.SelectedItems(0).SubItems(2).Text Then
                MsgBox("Elemento ya se encuentra Agregado", MsgBoxStyle.Information)
                Exit Sub
            End If
        Next

        rowImpo = CDbl(lstPagos.SelectedItems(0).SubItems(3).Text)
        mSaldo = CDbl(txtSaldo.Text)
        mPago = CDbl(txtPagos.Text)
        mDiferencia = CDbl(txtDiferencia.Text)


        Dim lstLista As New ListViewItem(lstPagos.SelectedItems(0).SubItems(0).Text)
        lstLista.SubItems.Add(lstPagos.SelectedItems(0).SubItems(1).Text)
        lstLista.SubItems.Add(lstPagos.SelectedItems(0).SubItems(2).Text)
        lstLista.SubItems.Add(Format(CDbl(lstPagos.SelectedItems(0).SubItems(3).Text), "###,###,##0.00"))
        lstLista.SubItems.Add(lstPagos.SelectedItems(0).SubItems(4).Text)
        lstLista.SubItems.Add(lstPagos.SelectedItems(0).SubItems(5).Text)
        lstAnticipos.Items.Add(lstLista)

        mImporte = mPago - rowImpo
        txtPagos.Text = Format(mImporte, "###,###,##0.00")
        lstPagos.SelectedItems(0).Remove()
        txtDiferencia.Text = Format(mSaldo - (mPago + rowImpo), "###,###,##0.00")
        ValidarInformacion()
    End Sub

    Private Sub ValidarInformacion()
        If CDbl(txtDiferencia.Text = 0) Then
            lstAnticipos.Enabled = False
        Else
            lstAnticipos.Enabled = True

        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim mensaje As String
        mensaje = ""
        If txtOCEngorda.Text = "" Or txtEntrada.Text = "" Then
            MsgBox("Favor de seleccionar la orden de compra y/o entrada", vbInformation, "Sistema Contable")
            Exit Sub
        End If
        If CDbl(txtSaldo.Text) = "0" Then
            Exit Sub
        End If
        If CDbl(txtDiferencia.Text) <> 0 And chOrdenCompra.Checked = True Then
            mensaje = "  Se generara orden de compra, ya que tiene diferencias importes de $ " & txtDiferencia.Text
        End If
        If CDbl(txtDiferencia.Text) <> 0 And chOrdenCompra.Checked = False Then
            mensaje = " Se cerrara entrada con diferencias $ " & txtDiferencia.Text
        End If
        If MessageBox.Show("¿Desea Guardar el Registro?" & mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim clsDB = New clsBD()
            Dim cnnConexion = New SqlConnection()

            cnnConexion = clsDB.CreaConexion()
            Dim transaction As SqlTransaction
            Dim dr As SqlDataReader
            Dim oclsPolizasAjuste = New clsPolizasAjuste()
            dr = oclsPolizasAjuste.UltimoFolio(84)

            Dim ds = New DataSet()

            If dr.Read() Then
                nPoliza = Trim(dr("Folio").ToString())
            End If

            dr.Close()
            transaction = cnnConexion.BeginTransaction

            Try

                For i As Integer = 0 To lstPagos.Items.Count - 1

                    Dim cmd As New SqlCommand
                    cmd.CommandText = "sPCierreAnticipoPago"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = cnnConexion
                    cmd.Transaction = transaction

                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
                    cmd.Parameters.Add("@FolioEntrada", SqlDbType.VarChar).Value = txtEntrada.Text
                    cmd.Parameters.Add("@FolioCR", SqlDbType.VarChar).Value = lstPagos.Items(i).SubItems(0).Text
                    cmd.Parameters.Add("@importe", SqlDbType.VarChar).Value = CDbl(lstPagos.Items(i).SubItems(3).Text)
                    cmd.Parameters.Add("@factura", SqlDbType.VarChar).Value = lstPagos.Items(i).SubItems(1).Text
                    cmd.Parameters.Add("@TipoCambio", SqlDbType.VarChar).Value = lstPagos.Items(i).SubItems(5).Text

                    cmd.ExecuteNonQuery()
                Next

                If txtDiferencia.Text <> 0 And chOrdenCompra.Checked = True Then
                    'GENERAR MOVIMIENTO EN INVENTARIOS
                    Dim cmd3 As New SqlCommand
                    cmd3.CommandText = "sPCierreAnticipoPago"
                    cmd3.CommandType = CommandType.StoredProcedure
                    cmd3.Connection = cnnConexion
                    cmd3.Transaction = transaction

                    cmd3.Parameters.Add("@Opcion", SqlDbType.Int).Value = 2
                    cmd3.Parameters.Add("@FolioEntrada", SqlDbType.VarChar).Value = txtEntrada.Text
                    cmd3.Parameters.Add("@FolioCR", SqlDbType.VarChar).Value = 0
                    cmd3.Parameters.Add("@importe", SqlDbType.VarChar).Value = CDbl(txtDiferencia.Text)
                    cmd3.Parameters.Add("@factura", SqlDbType.VarChar).Value = ""
                    cmd3.Parameters.Add("@TipoCambio", SqlDbType.VarChar).Value = 0

                    cmd3.ExecuteNonQuery()

                    'GENEREAR ORDEN COMPRA

                    Dim cmd2 As New SqlCommand
                    cmd2.CommandText = "spGeneraSolicitudCompraGanado"
                    cmd2.CommandType = CommandType.StoredProcedure
                    cmd2.Connection = cnnConexion
                    cmd2.Transaction = transaction

                    cmd2.Parameters.Add("@TipoMovimiento", SqlDbType.Int).Value = 6
                    cmd2.Parameters.Add("@FolioEntrada", SqlDbType.VarChar).Value = txtEntrada.Text

                    cmd2.ExecuteNonQuery()

                End If
                'GENERAR POLIZA
                For i As Integer = 0 To lstPagos.Items.Count - 1
                    Dim cmd4 As New SqlCommand
                    cmd4.CommandText = "sPIncPolizaCierreEntrada"
                    cmd4.CommandType = CommandType.StoredProcedure
                    cmd4.Connection = cnnConexion
                    cmd4.Transaction = transaction

                    cmd4.Parameters.Add("@cuentaPro", SqlDbType.VarChar).Value = cuentaProv
                    cmd4.Parameters.Add("@importe", SqlDbType.VarChar).Value = CDbl(lstPagos.Items(i).SubItems(3).Text)
                    cmd4.Parameters.Add("@tipoMov", SqlDbType.VarChar).Value = 84
                    cmd4.Parameters.Add("@tipoPoli", SqlDbType.VarChar).Value = 84
                    cmd4.Parameters.Add("@FolioEntrada", SqlDbType.VarChar).Value = txtEntrada.Text
                    cmd4.Parameters.Add("@usuario", SqlDbType.VarChar).Value = LoginUsuario
                    cmd4.Parameters.Add("@Poliza", SqlDbType.Int).Value = nPoliza
                    cmd4.Parameters.Add("@FolioContra", SqlDbType.Int).Value = CInt(lstPagos.Items(i).SubItems(0).Text)

                    cmd4.ExecuteNonQuery()
                Next

                MsgBox("Grabado Correctamente", MsgBoxStyle.Information)

                transaction.Commit()
                btnImprimir.Enabled = True
                btnImprimir.PerformClick()
                txtEntrada.Text = ""
                btnBuscar.PerformClick()

            Catch
                MsgBox("Ocurrio un Error al Grabar ", MsgBoxStyle.Critical)
                transaction.Rollback()

            Finally

                cnnConexion.Dispose()
                cnnConexion.Close()
            End Try
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim frm As New frmRPTPolizasManual
        frm.folio = nPoliza
        frm.fecha = Now
        frm.tipoPoliza = 84
        frm.ShowDialog()
    End Sub

    Private Sub txtFolioAnticipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioAnticipo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CargarCampoOC()
        End If
    End Sub

    Private Sub lstOrdenes_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstOrdenes.ColumnClick

        '
        ' ========================================
        ' Usando la clase ListViewColumnSortSimple
        ' ========================================
        '
        ' Crear una instancia de la clase que realizará la comparación
        Dim oCompare As New clsListViewColumnSortSimple()
        '
        ' Asignar el orden de clasificación
        If lstOrdenes.Sorting = SortOrder.Ascending Then
            oCompare.Sorting = SortOrder.Descending
        Else
            oCompare.Sorting = SortOrder.Ascending
        End If
        lstOrdenes.Sorting = oCompare.Sorting
        '
        ' La columna en la que se ha pulsado
        oCompare.ColumnIndex = e.Column
        ' Asignar la clase que implementa IComparer
        ' y que se usará para realizar la comparación de cada elemento
        lstOrdenes.ListViewItemSorter = oCompare
        '
        ' Cuando se asigna ListViewItemSorter no es necesario llamar al método Sort
        'ListView1.Sort()
    End Sub

    Private Sub cbxProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxProveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            '-----
            btnBuscar.PerformClick()
        End If
    End Sub

    Private Sub cbxProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxProveedor.SelectedValueChanged
        btnBuscar.Select()
    End Sub

    Private Sub cbxTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipo.SelectedIndexChanged
        If cbxTipo.SelectedIndex = 0 Then
            chOrdenCompra.Checked = True
        Else
            chOrdenCompra.Checked = False
        End If
    End Sub


    Private Sub cbxTipo_ValueMemberChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipo.ValueMemberChanged
        
    End Sub
End Class