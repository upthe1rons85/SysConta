Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports System.Data.SqlClient

Public Class frmPolizasAjuste
    Dim CError As Integer
    Dim MError As Integer
    Dim CCuenta As String
    Dim CMoneda As Integer
    'Dim datoConcepto As String
    Dim existe As Integer
    Dim MESCERRADO As Integer
    Public nPoliza As Integer

    'Dim CLinea As Integer
    'Dim nCargos As String
    'Dim nAbonos As String

    Private Sub frmPolizasManuales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------VALIDA PERFIL USUARIO------------------
        Dim Perfil As String
        Perfil = "00-05-06"

        If Perfil Like "*" + Perfilesusuario + "*" Then
            Me.Text = "Pólizas Contables" + Space(10) + CStr(VersionCont())
            STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario

            'Me.MaximizeBox = False
            'DtpFecha.Value = Today
        Else

            MsgBox("No tiene Derechos Sobre esta Opcion", vbCritical, "Sistema Contable")
            Me.Close()
        End If
        DtpFecha.Value = Now.Date

        txtEntrada.Select()
        '--------------------------------
        'Inicializa las variables de Error
        CError = 0
        MError = 0

        '--------------------------------
        'Inicializa etiqueta Estatus
    End Sub

    Private Sub cbxMoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtTipoPoliza.Focus()
        End If
    End Sub

    Private Sub DGVCapturaPoliza_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCapturaPoliza.CellClick
        Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()

    End Sub

    Private Sub DGVCapturaPoliza_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCapturaPoliza.CellEnter
        Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()

        If existe = 0 Then
            '--------------- NUEVO --------------
            If Celda.ColumnIndex = 5 Then
                If DGVCapturaPoliza.CurrentRow.Cells(4).Value = Nothing Or DGVCapturaPoliza.CurrentRow.Cells(4).ToString = "" Or DGVCapturaPoliza.CurrentRow.Cells(4).Value = vbNullString Then
                    DGVCapturaPoliza.CurrentRow.Cells(4).Value = 0.0
                Else
                    DGVCapturaPoliza.CurrentRow.Cells(4).Value = Format(CDec(DGVCapturaPoliza.CurrentRow.Cells(4).Value), "###,###,##0.#0")
                End If
            End If
            If Celda.ColumnIndex = 6 Then
                If DGVCapturaPoliza.CurrentRow.Cells(5).Value = Nothing Or DGVCapturaPoliza.CurrentRow.Cells(5).ToString = "" Or DGVCapturaPoliza.CurrentRow.Cells(5).Value = vbNullString Then
                    DGVCapturaPoliza.CurrentRow.Cells(5).Value = 0.0
                Else
                    DGVCapturaPoliza.CurrentRow.Cells(5).Value = Format(CDec(DGVCapturaPoliza.CurrentRow.Cells(5).Value), "###,###,##0.#0")
                End If
            End If
        End If

    End Sub

    Private Sub DGVCapturaPoliza_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGVCapturaPoliza.CellFormatting

        If DGVCapturaPoliza.Columns(e.ColumnIndex).Name = "dCuentaHelp" Then e.Value = ". . ."
        If DGVCapturaPoliza.Columns(e.ColumnIndex).Name = "dSelCECO" Then e.Value = ". . ."

    End Sub

    Private Sub DGVCapturaPoliza_CellStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellStateChangedEventArgs) Handles DGVCapturaPoliza.CellStateChanged
        Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
        If Celda.ColumnIndex = 4 Or Celda.ColumnIndex = 5 Then
            SUMAPPOLIZA()
        End If
        Dim Celda2 As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
        If Celda2.ColumnIndex = 6 Then
            DGVCapturaPoliza.FirstDisplayedScrollingColumnIndex = 3
        End If

    End Sub

    Private Sub DGVCapturaPoliza_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGVCapturaPoliza.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf Validar_Numeros
    End Sub

    Private Sub Validar_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '---------------------------------------------------------------------------------
        'VALIDA EN LOS CAMPOS DEL GRID CUENTA,CARGOS,ABONOS SOLO SE PUEDAN ESCRIBIR NUMEROS 

        Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()

        If Celda.ColumnIndex = 1 Or Celda.ColumnIndex = 4 Or Celda.ColumnIndex = 5 Then

            If e.KeyChar = "."c Then
                If InStr(Celda.EditedFormattedValue.ToString, ".", CompareMethod.Text) > 0 Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                If Len(Trim(Celda.EditedFormattedValue.ToString)) > 0 Then
                    If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                Else
                    If e.KeyChar = "0"c Then
                        e.Handled = True
                    Else
                        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then
                            e.Handled = False
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'cbxTipoCaptura.Focus()
        End If
    End Sub

    Private Sub cbxTipoPoliza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtFolioDocumento.Focus()
        End If
    End Sub

    Private Sub txtFolioDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioDocumento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtTipoPoliza.Text = "" Or txtFolioDocumento.Text = "" Then
                MsgBox("Debe de Completar Todos los Campos", MsgBoxStyle.Exclamation)
            Else

                ObtenerPoliza()
                ObtenerPolizaAjuste()
                CargaProveedor()
                txtImporte.SelectAll()
                txtImporte.Select()
            End If
        End If
    End Sub

    Private Sub CargaProveedor()
        Dim dr As SqlDataReader
        Dim oclsPolizasAjuste = New clsPolizasAjuste()
        dr = oclsPolizasAjuste.SeleccionaProveedores(txtCuenta.Text)

        Dim ds = New DataSet()

        If dr.Read() Then
            txtProveedor.Text = Trim(dr("proveedor").ToString())
        End If
        dr.Close()
    End Sub

    Private Sub CargarPoliza()
        Dim dr As SqlDataReader
        Dim oclsPolizasAjuste = New clsPolizasAjuste()
        dr = oclsPolizasAjuste.SeleccionaPoliza(1, txtEntrada.Text)

        Dim ds = New DataSet()
        If txtEntrada.Text = "" Then
            Exit Sub
        End If
        If dr.Read() Then
            'If CDbl(dr("Estatus").ToString()) = 1 Then
            txtTipoPoliza.Text = Trim(dr("TipoPoliza").ToString())
            txtFolioDocumento.Text = Trim(dr("Poliza").ToString())
            txtCuenta.Text = Trim(dr("CodigoProveedor").ToString())

            ObtenerPoliza()
            ObtenerPolizaAjuste()
            CargaProveedor()
            txtImporte.Select()
        Else
            MsgBox("No exite poliza contable de esta orden de compra", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub ObtenerPoliza()
        ' ValidaMes()
        'If MESCERRADO = 1 Then
        'MsgBox("El Mes de Captura ya se encuentra Cerrado", MsgBoxStyle.Information, "Sistema Contable")
        'Exit Sub
        'End If

        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Dim oclsPolizasContables = New clsPolizasAjuste()

        dr = oclsPolizasContables.SeleccionaPolizaContable(txtTipoPoliza.Text, txtFolioDocumento.Text)

        Dim ds = New DataSet()
        dt.Load(dr)


        If Not dt.Rows.Count = 0 Then 'Está vacío.

            DGVCapturaPoliza.Enabled = True
            DGVCapturaPoliza.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente
            DGVCapturaPoliza.Columns(0).DataPropertyName = "NumeroLinea" 'Inserta la cuenta contable
            DGVCapturaPoliza.Columns(1).DataPropertyName = "Cuenta" 'Inserta la cuenta contable
            DGVCapturaPoliza.Columns(2).DataPropertyName = "DESCuenta"
            DGVCapturaPoliza.Columns(3).DataPropertyName = "Cargo"
            DGVCapturaPoliza.Columns(4).DataPropertyName = "Abono"
            DGVCapturaPoliza.Columns(5).DataPropertyName = "CECO"
            DGVCapturaPoliza.Columns(6).DataPropertyName = "Referencia"
            DGVCapturaPoliza.Columns(7).DataPropertyName = "Concepto"
            DGVCapturaPoliza.Columns(8).DataPropertyName = "RefDocumento"

            BtnEliminar.Enabled = True
            existe = 1
            gbxControles.Enabled = False
            btnImprimir.Enabled = True
            DGVCapturaPoliza.DataSource = dt

        End If
    End Sub
    Private Sub ObtenerPolizaAjuste()
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Dim oclsPolizasContables = New clsPolizasAjuste()

        dr = oclsPolizasContables.SeleccionaPolizaContable(txtTipoPoliza.Text, txtFolioDocumento.Text)

        Dim ds = New DataSet()
        dt.Load(dr)


        If Not dt.Rows.Count = 0 Then ' no Está vacío.
            DGVAjustePoliza.Enabled = True
            DGVAjustePoliza.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente
            DGVAjustePoliza.Columns(0).DataPropertyName = "NumeroLinea" 'Inserta la cuenta contable
            DGVAjustePoliza.Columns(1).DataPropertyName = "Cuenta" 'Inserta la cuenta contable
            DGVAjustePoliza.Columns(2).DataPropertyName = "DESCuenta"

            DGVAjustePoliza.DataSource = dt
            SUMAPPOLIZA()

        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, _
                                              ByVal keyData As System.Windows.Forms.Keys) As Boolean

        '---------REALIZA EL CAMBIO DEL ENTER POR EL TAB PARA CAMBIAR A LA SIGUIENTE COLUMNA----------------

        If (Not DGVCapturaPoliza.Focused) AndAlso _
           (Not DGVCapturaPoliza.IsCurrentCellInEditMode) Then _
           Return MyBase.ProcessCmdKey(msg, keyData)



        If (keyData <> Keys.Return) Then _
           Return MyBase.ProcessCmdKey(msg, keyData)
        Dim cell As DataGridViewCell = DGVCapturaPoliza.CurrentCell
        Dim columnIndex As Int32 = cell.ColumnIndex
        Dim rowIndex As Int32 = cell.RowIndex

        '-----------------
        '--SI ES LA ULTIMA COLUMNA VALIDARA LOS DATOS Y AGREGARA UN NUEVO REGISTRO--

        If columnIndex = 10 Then
            If CError = 1 Or MError = 1 Or _
                DGVCapturaPoliza.CurrentRow.Cells(6).ToString = "" Or DGVCapturaPoliza.CurrentRow.Cells(6).Value Is vbNullChar Or _
                DGVCapturaPoliza.CurrentRow.Cells(8).ToString = "" Or DGVCapturaPoliza.CurrentRow.Cells(8).Value Is vbNullChar Or _
                DGVCapturaPoliza.CurrentRow.Cells(9).ToString = "" Or DGVCapturaPoliza.CurrentRow.Cells(9).Value Is vbNullChar Or _
                DGVCapturaPoliza.CurrentRow.Cells(1).ToString = "" Or DGVCapturaPoliza.CurrentRow.Cells(1).Value Is vbNullChar Then
                MsgBox("Existen Datos No Validos o Incompletos, Verifique")
                DGVCapturaPoliza.CurrentRow.Cells(1).Selected = True
            Else
                If existe = 1 Then
                    Dim UltimaFila As Integer
                    UltimaFila = DGVCapturaPoliza.Rows.Count - 1
                    If DGVCapturaPoliza.CurrentRow.Index = UltimaFila Or UltimaFila = 0 Then
                        Dim dt As DataTable = DirectCast(DGVCapturaPoliza.DataSource, DataTable)

                        Dim row As DataRow = dt.NewRow()
                        row.Item("Fecha") = ""
                        row.Item("TipoMovimiento") = 0
                        row.Item("TipoMoneda") = ""
                        row.Item("DESMoneda") = ""
                        row.Item("TipoPoliza") = ""
                        row.Item("DESTipoPoliza") = ""
                        row.Item("DESEstatus") = ""
                        row.Item("Cuenta") = ""
                        row.Item("DESCuenta") = ""
                        row.Item("DESCLASE") = ""
                        dt.Rows.Add(row)

                        DGVCapturaPoliza.DataSource = dt
                        DGVCapturaPoliza.CurrentRow.Cells("dCuenta").Selected = True
                    End If
                Else
                    Dim UltimaFila As Integer
                    UltimaFila = DGVCapturaPoliza.Rows.Count - 1
                    If DGVCapturaPoliza.CurrentRow.Index = UltimaFila Or UltimaFila = 0 Then

                        DGVCapturaPoliza.Rows.Add()
                        DGVCapturaPoliza.CurrentRow.Cells("dCuenta").Selected = True
                    End If
                End If
            End If
        End If
        If columnIndex = 8 Then
            Dim Nrows As Integer = DGVCapturaPoliza.RowCount
            If Nrows > 1 Then

                Dim concepto As String
                Dim FilaSeleccionada As Integer = (DGVCapturaPoliza.CurrentCell.RowIndex) - 1
                Dim FilaActual As Integer = (DGVCapturaPoliza.CurrentCell.RowIndex)
                If FilaSeleccionada >= 0 Then

                    concepto = DGVCapturaPoliza.Rows(FilaSeleccionada).Cells(9).Value
                    DGVCapturaPoliza.Rows(FilaActual).Cells(9).Value = concepto
                End If
            End If
        End If

        '------------------------------------------------------

        If columnIndex = DGVCapturaPoliza.Columns.Count - 1 Then
            If rowIndex = DGVCapturaPoliza.Rows.Count - 1 Then
                cell = DGVCapturaPoliza.Rows(0).Cells(0)
            Else
                cell = DGVCapturaPoliza.Rows(rowIndex + 1).Cells(0)
            End If

        Else
            cell = DGVCapturaPoliza.Rows(rowIndex).Cells(columnIndex + 1)
        End If

        DGVCapturaPoliza.CurrentCell = cell

        Return True

    End Function

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        If MessageBox.Show("¿Desea Capturar un Nuevo Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            DGVCapturaPoliza.DataSource = Nothing
            DGVCapturaPoliza.Rows.Clear()
            DGVAjustePoliza.DataSource = Nothing
            DGVAjustePoliza.Rows.Clear()

            ' cbxTipoCaptura.Text = ""
            lblDiferencia.Text = ""
            txtFolioDocumento.Text = ""
            gbxControles.Enabled = True
            CError = 0
            MError = 0
            DGVCapturaPoliza.FirstDisplayedScrollingColumnIndex = 0
            existe = 0
            DGVCapturaPoliza.Enabled = False
            txtProveedor.Text = ""
            txtTipoPoliza.Text = ""
            txtEntrada.Text = ""
            txtImporte.Text = "0.00"
            txtTotalCargos.Text = "0.00"
            txtTotalAbonos.Text = "0.00"
            txtRestan.Text = "0.00"
            txtEntrada.Select()
        End If
    End Sub

    Private Sub DGVCapturaPoliza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVCapturaPoliza.KeyDown

        If e.Control Then
            If e.KeyCode = Keys.G Then
                BtnGuardar.PerformClick()
            End If
        End If
        '-----------REPITE LA CUENTA QUE SE ENCUENTRA ARRIBA CON LA TECLA F2--------------
        If e.KeyValue = Keys.F2 Then
            e.Handled = True

            Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
            Dim Nrows As Integer = DGVCapturaPoliza.RowCount
            If Celda.ColumnIndex = 2 Then

                If Nrows > 1 Then

                    Dim Cuenta As String
                    Dim FilaSeleccionada As Integer = (DGVCapturaPoliza.CurrentCell.RowIndex) - 1
                    Dim FilaActual As Integer = (DGVCapturaPoliza.CurrentCell.RowIndex)
                    Cuenta = DGVCapturaPoliza.Rows(FilaSeleccionada).Cells(1).Value
                    DGVCapturaPoliza.Rows(FilaActual).Cells(1).Value = Cuenta
                End If

            End If

        End If

    End Sub

    Private Sub DGVCapturaPoliza_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVCapturaPoliza.KeyUp
        If e.KeyCode = 112 Then
            Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
            If Celda.ColumnIndex = 2 Then
                frmPolizasManuales_Cuentas.ShowDialog()
                DGVCapturaPoliza.CurrentRow.Cells(1).Value = VPCatCuentasPuente

                '---------------------------------------------------------------------------------------
                '------------------Valida que la cuenta contable exista---------------------------------

                Dim clsBD As New clsBD()

                Dim dr As SqlDataReader
                Dim oclsCuentasContables = New clsCuentasContables()

                'Si la cuenta no tiene datos se le coloca un espacio "" para la consulta SQL
                Dim ValorCelda As String = Convert.ToString(DGVCapturaPoliza.CurrentRow.Cells(1).Value)

                dr = oclsCuentasContables.BuscaContable(ValorCelda)

                Dim dt = New DataTable()
                dt.Load(dr)

                If dt.Rows.Count <> 0 Then
                    Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
                    DGVCapturaPoliza.CurrentRow.Cells(3).Value = CStr(row("Descripcion"))
                    DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Black
                    CError = 0
                Else
                    MsgBox("La Cuenta Contable no es Valida", MsgBoxStyle.Critical)
                    DGVCapturaPoliza.CurrentRow.Cells(3).Value = "<< N° de Cuenta NO Valido >>"
                    DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Red
                    CError = 1
                End If
                '------------------------------------------------------------------------------------
                '---Eliminacion de la Fila Cuando selecciona el boton ubicado en la primer columna---

                dr.Close()
            End If
        End If
    End Sub

    Private Sub DGVCapturaPoliza_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DGVCapturaPoliza.RowsAdded

        '--- Agrega los items que provienen de la bd de Compras (depto)----

        'Dim cnnConexion = New SqlConnection()
        'Dim clsDB = New clsBD()
        'cnnConexion = clsDB.CreaConexion()

        'Dim consulta As String = "select AREA_DEPTO,AD_DESCRIPCION from VIZ_SelAreaDepto (NOLOCK)"
        'Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text

        'Dim da As New SqlDataAdapter(cmd)
        'Dim dt As New DataTable

        'da.Fill(dt)

        'dUnidadNegocio.ValueMember = "AREA_DEPTO"
        'dUnidadNegocio.DisplayMember = "AD_DESCRIPCION"
        'dUnidadNegocio.DataSource = dt

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        SUMAPPOLIZA()
        If MessageBox.Show("¿Desea Guardar el Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If CDbl(txtRestan.Text) <> 0 Then
                MsgBox("Existen Diferencias Verifique", MsgBoxStyle.Critical)
            Else
                Dim clsDB = New clsBD()
                Dim cnnConexion = New SqlConnection()
                Dim nOpcion As Integer
                Dim nTipoPoliza As Integer
                Dim CarAbo As String
                Dim CarAbo2 As String
                cnnConexion = clsDB.CreaConexion()
                Dim transaction As SqlTransaction
                If rdOp1.Checked = True Then
                    nOpcion = 1
                    nTipoPoliza = 32
                    CarAbo = "A"
                    CarAbo2 = "C"
                Else
                    nOpcion = 2
                    nTipoPoliza = 36
                    CarAbo = "C"
                    CarAbo2 = "A"
                End If
                Dim dr As SqlDataReader
                Dim oclsPolizasAjuste = New clsPolizasAjuste()
                dr = oclsPolizasAjuste.UltimoFolio(nTipoPoliza)

                Dim ds = New DataSet()

                If dr.Read() Then
                    nPoliza = Trim(dr("Folio").ToString())
                End If

                dr.Close()
                transaction = cnnConexion.BeginTransaction

                Try
                    Dim fecha As String
                    Dim linea As Integer
                    fecha = Format(DtpFecha.Value, "yyyyMMdd")
                    If nOpcion = 2 Then
                        For Each row As DataGridViewRow In DGVAjustePoliza.Rows
                            If row.Cells("importe").Value Then
                                Dim cmd As New SqlCommand
                                cmd.CommandText = "spInsPolizaAjuste"
                                cmd.CommandType = CommandType.StoredProcedure
                                cmd.Connection = cnnConexion
                                cmd.Transaction = transaction

                                cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion
                                cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fecha
                                cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = txtTipoPoliza.Text
                                cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = txtFolioDocumento.Text
                                cmd.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = row.Cells("cuenta").Value
                                cmd.Parameters.Add("@LIN", SqlDbType.VarChar).Value = row.Cells("Linea").Value
                                cmd.Parameters.Add("@CarAbo", SqlDbType.VarChar).Value = CarAbo
                                cmd.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = row.Cells("importe").Value
                                cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = LoginUsuario
                                cmd.Parameters.Add("@n_Pol", SqlDbType.Int).Value = nPoliza
                                cmd.Parameters.Add("@n_TiPol", SqlDbType.Int).Value = nTipoPoliza

                                cmd.ExecuteNonQuery()
                            End If
                            '-----------------------

                            linea = linea + 1
                        Next

                        Dim cmd2 As New SqlCommand
                        cmd2.CommandText = "spInsPolizaAjuste"
                        cmd2.CommandType = CommandType.StoredProcedure
                        cmd2.Connection = cnnConexion
                        cmd2.Transaction = transaction

                        cmd2.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion
                        cmd2.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fecha 'rEVISAR FECHA DE POLIZA 
                        cmd2.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = txtTipoPoliza.Text
                        cmd2.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = txtFolioDocumento.Text
                        cmd2.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = txtCuenta.Text
                        cmd2.Parameters.Add("@LIN", SqlDbType.Int).Value = "0"
                        cmd2.Parameters.Add("@CarAbo", SqlDbType.VarChar).Value = CarAbo2
                        cmd2.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = CDbl(txtImporte.Text)
                        cmd2.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = LoginUsuario
                        cmd2.Parameters.Add("@n_Pol", SqlDbType.Int).Value = nPoliza
                        cmd2.Parameters.Add("@n_TiPol", SqlDbType.Int).Value = nTipoPoliza

                        cmd2.ExecuteNonQuery()
                    Else
                        Dim cmd2 As New SqlCommand
                        cmd2.CommandText = "spInsPolizaAjuste"
                        cmd2.CommandType = CommandType.StoredProcedure
                        cmd2.Connection = cnnConexion
                        cmd2.Transaction = transaction

                        cmd2.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion
                        cmd2.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fecha 'rEVISAR FECHA DE POLIZA 
                        cmd2.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = txtTipoPoliza.Text
                        cmd2.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = txtFolioDocumento.Text
                        cmd2.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = txtCuenta.Text
                        cmd2.Parameters.Add("@LIN", SqlDbType.Int).Value = "0"
                        cmd2.Parameters.Add("@CarAbo", SqlDbType.VarChar).Value = CarAbo2
                        cmd2.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = CDbl(txtImporte.Text)
                        cmd2.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = LoginUsuario
                        cmd2.Parameters.Add("@n_Pol", SqlDbType.Int).Value = nPoliza
                        cmd2.Parameters.Add("@n_TiPol", SqlDbType.Int).Value = nTipoPoliza

                        cmd2.ExecuteNonQuery()

                        For Each row As DataGridViewRow In DGVAjustePoliza.Rows
                            If row.Cells("importe").Value Then
                                Dim cmd As New SqlCommand
                                cmd.CommandText = "spInsPolizaAjuste"
                                cmd.CommandType = CommandType.StoredProcedure
                                cmd.Connection = cnnConexion
                                cmd.Transaction = transaction

                                cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion
                                cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fecha
                                cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = txtTipoPoliza.Text
                                cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = txtFolioDocumento.Text
                                cmd.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = row.Cells("cuenta").Value
                                cmd.Parameters.Add("@LIN", SqlDbType.VarChar).Value = row.Cells("Linea").Value
                                cmd.Parameters.Add("@CarAbo", SqlDbType.VarChar).Value = CarAbo
                                cmd.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = row.Cells("importe").Value
                                cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = LoginUsuario
                                cmd.Parameters.Add("@n_Pol", SqlDbType.Int).Value = nPoliza
                                cmd.Parameters.Add("@n_TiPol", SqlDbType.Int).Value = nTipoPoliza

                                cmd.ExecuteNonQuery()
                            End If
                            '-----------------------

                            linea = linea + 1
                        Next


                    End If

                    Dim cmd3 As New SqlCommand
                    cmd3.CommandText = "spAjustePolizaSaldoEntrada"
                    cmd3.CommandType = CommandType.StoredProcedure
                    cmd3.Connection = cnnConexion
                    cmd3.Transaction = transaction

                    cmd3.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion
                    cmd3.Parameters.Add("@nEntrada ", SqlDbType.VarChar).Value = txtEntrada.Text
                    cmd3.Parameters.Add("@Importe", SqlDbType.VarChar).Value = CDbl(txtImporte.Text)
                    cmd3.Parameters.Add("@n_Pol", SqlDbType.Int).Value = nPoliza
                    cmd3.Parameters.Add("@n_TiPol", SqlDbType.Int).Value = nTipoPoliza

                    cmd3.ExecuteNonQuery()

                    transaction.Commit()
                    MsgBox("Grabado Correctamente", MsgBoxStyle.Information)
                    linea = 0
                    btnImprimir.Enabled = True
                    btnImprimir.PerformClick()
                    btnNuevo.PerformClick()
                Catch
                    transaction.Rollback()
                    MsgBox("Ocurrio un Error al Grabar ", MsgBoxStyle.Critical)
                Finally

                    cnnConexion.Dispose()
                    cnnConexion.Close()
                End Try
            End If
        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim tipoPoliza As Integer
        If rdOp1.Checked = True Then
            tipoPoliza = 32
        Else
            tipoPoliza = 36

        End If

        Dim frm As New frmRPTPolizasManual
        frm.folio = nPoliza
        frm.tipoPoliza = tipoPoliza
        frm.ShowDialog()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Desea ELIMINAR el Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            'Dim oclsPolizasContables = New clsPolizasContables()
            'oclsPolizasContables.EliminaPolizaContable(fecha, cbxTipoPoliza.SelectedValue, txtFolioDocumento.Text)
            MsgBox("NO SE ELIMINO REGISTRO Registro Eliminado", vbInformation, "Sistema Contable")
            'btnNuevo.PerformClick()

        End If
    End Sub

    Private Sub SUMAPPOLIZA()
        '-------------Suma los Cargos y va sumando por registro toda la columna y la coloca en el text Total---------
        'Me.DGVCapturaPoliza.Columns("UnitPrice").DefaultCellStyle.Format = "c"
        Dim resultadoCargos As Decimal = 0D

        For Each row As DataGridViewRow In DGVCapturaPoliza.Rows
            Dim value As Object = row.Cells("dCargos").Value
            Dim d As Decimal
            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultadoCargos += Convert.ToDecimal(d)

        Next
        txtTotalCargos.Text = Format(resultadoCargos, "###,###,##0.#0")

        '-------------Suma los Abonos y va sumando por registro toda la columna y la coloca en el text Total---------
        Dim resultadoAbonos As Decimal = 0D

        For Each row As DataGridViewRow In DGVAjustePoliza.Rows
            Dim value As Object = row.Cells("importe").Value
            Dim d As Decimal
            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultadoAbonos += Convert.ToDecimal(d)

        Next

        txtTotalAbonos.Text = Format(resultadoAbonos, "###,###,##0.#0")
        txtRestan.Text = Format((CDbl(txtImporte.Text) - resultadoAbonos), "###,##0.00")
        lblDiferencia.Text = Format((resultadoCargos - resultadoAbonos), "###,###,##0.#0")

        If lblDiferencia.Text <> 0.0 Then
            lblDiferencia.ForeColor = Color.Red
        Else
            lblDiferencia.ForeColor = Color.Green
        End If

    End Sub

    Private Sub cbxTipoCaptura_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'CargaTipoPolizas()
    End Sub

    Private Sub cbxTipoPoliza_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        IndicaFoliosiguiente()
    End Sub

    Private Sub IndicaFoliosiguiente()
        Dim dr As SqlDataReader
        Dim oclsPolizasContables As New clsPolizasContables

        dr = oclsPolizasContables.SeleccionaConsecutivo(txtTipoPoliza.Text.ToString)

        If dr.Read() Then
            txtFolioDocumento.Text = dr("Folio").ToString()
        Else
            txtFolioDocumento.Text = ""
        End If

    End Sub
    Private Sub ValidaMes()

        Dim cmd As New SqlCommand
        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()
        Dim dr As SqlDataReader
        'Dim fechaMes As String

        'fechaMes = Format(DtpFecha.Value, "yyyyMM01")
        cnnConexion = clsDB.CreaConexion()
        cmd.CommandText = "spValidaMesCerrado"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        'cmd.Parameters.Add("@MesCerrado", SqlDbType.VarChar).Value = fechaMes

        dr = cmd.ExecuteReader()


        If dr.Read() Then
            MESCERRADO = dr("cerrado").ToString()
        Else
            MsgBox("No se Encontro Estatus de Mes")
        End If
    End Sub

    Private Sub DGVAjustePoliza_CellStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellStateChangedEventArgs) Handles DGVAjustePoliza.CellStateChanged
        Dim Celda As DataGridViewCell = Me.DGVAjustePoliza.CurrentCell()
        If Celda.ColumnIndex = 3 Then
            SUMAPPOLIZA()
            Celda.Value = Format(CDbl(Celda.Value), "###,##0.00")
        End If

    End Sub

    Private Sub txtImporte_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.GotFocus
        SUMAPPOLIZA()
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtImporte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.LostFocus
        SUMAPPOLIZA()
        txtImporte.Text = Format(CDbl(txtImporte.Text), "###,##0.00")
    End Sub

    Private Sub cbxTipoCaptura_QueryAccessibilityHelp(ByVal sender As Object, ByVal e As System.Windows.Forms.QueryAccessibilityHelpEventArgs)
        txtTipoPoliza.Select()
    End Sub

    Private Sub txtTipoPoliza_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoPoliza.GotFocus
        txtTipoPoliza.SelectAll()
    End Sub

    Private Sub txtTipoPoliza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoPoliza.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtFolioDocumento.Select()
        End If
    End Sub

    Private Sub txtOCEngorda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntrada.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CargarPoliza()
            txtTipoPoliza.Select()
        End If
    End Sub

    Private Sub DGVAjustePoliza_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DGVAjustePoliza.CellValidating
        Select Case DGVAjustePoliza.Columns(e.ColumnIndex).Name
            Case "importe"
                'se valida que sea un dato numérico
                If Not IsNumeric(e.FormattedValue.ToString()) And Not String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                    DGVAjustePoliza.Rows(e.RowIndex).ErrorText = "Debe ingresar un valor numérico"
                    e.Cancel = True
                Else
                    DGVAjustePoliza.Rows(e.RowIndex).ErrorText = String.Empty
                End If
        End Select
    End Sub

    Private Sub DGVAjustePoliza_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVAjustePoliza.LostFocus
        SUMAPPOLIZA()
    End Sub

End Class