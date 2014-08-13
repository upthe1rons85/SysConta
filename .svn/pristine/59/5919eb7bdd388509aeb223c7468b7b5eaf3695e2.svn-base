Imports WindowsApplication1.clsTools
Imports WindowsApplication1.clsBD
Imports WindowsApplication1.mdVariables
Imports System.Data.SqlClient

Public Class frmPolizasManuales
    Dim CError As Integer
    Dim MError As Integer
    Dim CCuenta As String
    Dim CMoneda As Integer
    'Dim datoConcepto As String
    Dim existe As Integer
    Dim MESCERRADO As Integer

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

            Me.MaximizeBox = False
            DtpFecha.Value = Today
        Else

            MsgBox("No tiene Derechos Sobre esta Opcion", vbCritical, "Sistema Contable")
            Me.Close()
        End If
        '---------------------------------------------------------
        '--------BUSCA EL USUARIO Y LO INGRESA EN EL TEXT---------
        If LoginUsuario <> "" Then
            Dim oclsUsuarios As New clsUsuarios
            Dim dr As SqlDataReader
            dr = oclsUsuarios.SeleccionaUsuarios(LoginUsuario)

            If dr.Read() Then

                txtUsuario.Text = dr("Nombre").ToString()
            End If
        End If

        '--------------------------------
        'Inicializa las variables de Error
        CError = 0
        MError = 0

        '--------------------------------
        'Inicializa etiqueta Estatus
        lblEstatus.Text = ""

        '--------------------------------
        'Selecciona PESOS
        cbxMoneda.SelectedIndex = 0
    End Sub

    Private Sub cbxMoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxMoneda.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            cbxTipoPoliza.Focus()
        End If
    End Sub

    Private Sub cbxMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMoneda.SelectedIndexChanged

        If cbxMoneda.Text = "1.- PESOS" Then
            CMoneda = 1
            Dim DR As SqlDataReader
            Dim oclstipocambio As New clsTipocambio
            DR = oclstipocambio.CargaTipoCambio(Format(DtpFecha.Value, "yyyyMMdd") + " 00:00:00")

            If DR.Read() Then

                txtTipoCambio.Text = DR("TipoCambio").ToString()
                'DtpFecha.Enabled = False

            Else
                txtTipoCambio.Text = "0.00"
                'MsgBox("No hay Tipo de Cambio para la fecha seleccionada", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub DGVCapturaPoliza_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCapturaPoliza.CellClick
        Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
        If Celda.ColumnIndex = 2 Then
            Dim frm As New frmPolizasManuales_Cuentas
            frm.ShowDialog()
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
        End If
        If Celda.ColumnIndex = 0 Then
            If MessageBox.Show("¿Desea eliminar Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim Fila As DataGridViewRow = Me.DGVCapturaPoliza.CurrentRow()
                DGVCapturaPoliza.Rows.Remove(Fila)
                SUMAPPOLIZA()
                DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Black
                If DGVCapturaPoliza.RowCount = 0 Then
                    gbxControles.Enabled = True
                    txtFolioDocumento.Focus()
                End If
            End If
        End If
        '------------------------------------------------------------------------------------
        '-----------------------Ayuda Para mostrar CAtalogo de CECOS-------------------------
        If Celda.ColumnIndex = 7 Then

            Dim FrmConcultaCECO As New frmPolizasManuales_CECOS
            FrmConcultaCECO.ShowDialog()

            DGVCapturaPoliza.CurrentRow.Cells(6).Value = Trim(FrmConcultaCECO.DepartamenteSelec)
            DGVCapturaPoliza.Columns(6).DefaultCellStyle.ForeColor = Color.Black
            MError = 0
        End If


    End Sub

    Private Sub DGVCapturaPoliza_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCapturaPoliza.CellEnter
        Dim Celda As DataGridViewCell = Me.DGVCapturaPoliza.CurrentCell()
        '---------------------------------------------------------------------------------------
        '------------------Valida que la cuenta contable exista---------------------------------
        'If Celda.ColumnIndex = 1 Then
        'CCuenta = CCuenta + 1
        'DGVCapturaPoliza.CurrentRow.Cells(9).Value = CCuenta

        'End If
        If Celda.ColumnIndex = 3 Then
            Dim clsBD As New clsBD()

            Dim dr As SqlDataReader
            Dim oclsCuentasContables = New clsCuentasContables()

            '-----Si la cuenta no tiene datos se le coloca un espacio "" para la consulta SQL----
            Dim ValorCelda As String = Convert.ToString(DGVCapturaPoliza.CurrentRow.Cells(1).Value)

            dr = oclsCuentasContables.BuscaContable(ValorCelda)

            Dim dt = New DataTable()
            dt.Load(dr)

            If dt.Rows.Count <> 0 Then
                Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
                DGVCapturaPoliza.CurrentRow.Cells(3).Value = CStr(row("Descripcion"))
                DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Black
                '--------------------------------------------------
                '------------Agrega el numero de linea ------------
                'CCuenta = CCuenta + 1
                'DGVCapturaPoliza.CurrentRow.Cells(9).Value = CCuenta
                CError = 0
            Else
                MsgBox("La Cuenta Contable no es Valida", MsgBoxStyle.Critical)
                DGVCapturaPoliza.CurrentRow.Cells(3).Value = "<< Cuenta NO Valida >>"
                DGVCapturaPoliza.Columns(3).DefaultCellStyle.ForeColor = Color.Red
                CError = 1
            End If
        End If
        If Celda.ColumnIndex = 7 Then

            Dim ValorCelda As String = Convert.ToString(DGVCapturaPoliza.CurrentRow.Cells(6).Value)

            If ValorCelda = "" Or ValorCelda = "      " Then

            Else
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                Dim consulta As String = "select AREA_DEPTO from VIZ_SelAreaDepto (NOLOCK) where AREA_DEPTO= " & ValorCelda
                Dim cmd As New SqlCommand(consulta, cnnConexion)
                cmd.CommandType = CommandType.Text

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MError = 0
                    DGVCapturaPoliza.Columns(6).DefaultCellStyle.ForeColor = Color.Black
                Else
                    MsgBox("EL Numero de CECO no es valido")
                    DGVCapturaPoliza.Columns(6).DefaultCellStyle.ForeColor = Color.Red
                    MError = 1
                End If
            End If
        End If
        'If Celda.ColumnIndex = 8 Then
        '    DGVCapturaPoliza.CurrentRow.Cells(8).Value = datoConcepto
        'End If

        If existe = 0 Then
            '--------------- NUEVO --------------
            If Celda.ColumnIndex = 5 Then

                If DGVCapturaPoliza.CurrentRow.Cells(4).Value = Nothing Or DGVCapturaPoliza.CurrentRow.Cells(4).ToString = "" Or DGVCapturaPoliza.CurrentRow.Cells(4).Value = vbNullString Then

                    DGVCapturaPoliza.CurrentRow.Cells(4).Value = 0.0
                Else
                    Try
                        DGVCapturaPoliza.CurrentRow.Cells(4).Value = Format(CDec(DGVCapturaPoliza.CurrentRow.Cells(4).Value), "###,###,##0.#0")
                    Catch
                        MsgBox("Formato Numerico Incorrecto. Verifique", MsgBoxStyle.Information, "Sistema Contabilidad")
                        DGVCapturaPoliza.CurrentRow.Cells(4).Value = 0.0
                    End Try
                End If
            End If

            If Celda.ColumnIndex = 6 Then

                If DGVCapturaPoliza.CurrentRow.Cells(5).Value = Nothing Or DGVCapturaPoliza.CurrentRow.Cells(5).ToString = "" Or DGVCapturaPoliza.CurrentRow.Cells(5).Value = vbNullString Then

                    DGVCapturaPoliza.CurrentRow.Cells(5).Value = 0.0
                Else
                    Try
                        DGVCapturaPoliza.CurrentRow.Cells(5).Value = Format(CDec(DGVCapturaPoliza.CurrentRow.Cells(5).Value), "###,###,##0.#0")
                    Catch
                        MsgBox("Formato Numerico Incorrecto. Verifique", MsgBoxStyle.Information, "Sistema Contabilidad")
                        DGVCapturaPoliza.CurrentRow.Cells(5).Value = 0.0

                    End Try

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

            If e.KeyChar = "-"c Then

                'If Celda.ToString <> "" Or Celda.ToString <> "0" Then

                'e.Handled = True
                If InStr(Celda.EditedFormattedValue.ToString, "-", CompareMethod.Text) > 0 Then
                    'End If                    
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else


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
            End If
    End Sub


    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFecha.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            cbxTipoCaptura.Focus()
        End If
    End Sub

    Private Sub cbxTipoCaptura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxTipoCaptura.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            cbxTipoPoliza.Focus()
        End If
    End Sub

    Private Sub cbxTipoPoliza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxTipoPoliza.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtFolioDocumento.Focus()
        End If
    End Sub

    Private Sub txtFolioDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioDocumento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If cbxTipoCaptura.Text = "" Or txtTipoCambio.Text = "" Or cbxTipoPoliza.Text = "" Then
                MsgBox("Debe de Completar Todos los Campos", MsgBoxStyle.Exclamation)
            Else

                ValidaMes()
                If MESCERRADO = 1 Then
                    MsgBox("El Mes de Captura ya se encuentra Cerrado", MsgBoxStyle.Information, "Sistema Contable")
                    Exit Sub
                End If

                If txtFolioDocumento.Text = "" Then
                    txtFolioDocumento.Text = "    *  *  *  * N *  *  *  * "
                    'MsgBox("Registro Nuevo", MsgBoxStyle.Information, "Sistema contable")
                    DGVCapturaPoliza.Enabled = True
                    DGVCapturaPoliza.Focus()
                    DGVCapturaPoliza.Rows.Add()
                    gbxControles.Enabled = False
                    DGVCapturaPoliza.FirstDisplayedScrollingColumnIndex = 0
                    DGVCapturaPoliza.CurrentRow.Cells(1).Selected = True
                    BtnGuardar.Enabled = True
                    lblEstatus.Text = "A C T I V A"


                Else


                    Dim dr As SqlDataReader
                    Dim dt As New DataTable
                    Dim fecha As String

                    Dim oclsPolizasContables = New clsPolizasContables()
                    fecha = Format(DtpFecha.Value, "yyyyMMdd")

                    dr = oclsPolizasContables.SeleccionaPolizaContable(fecha, cbxTipoPoliza.SelectedValue, txtFolioDocumento.Text)

                    Dim ds = New DataSet()


                    dt.Load(dr)


                    If dt.Rows.Count = 0 Then 'Está vacío.
                        MsgBox("No Se Encontro Numero de Poliza con el Tipo Seleccionado", MsgBoxStyle.Information, "Sistema Contable")
                        txtFolioDocumento.Focus()
                        txtFolioDocumento.SelectAll()

                    Else
                        DGVCapturaPoliza.Enabled = True
                        DGVCapturaPoliza.AutoGenerateColumns = False 'Aqui digo que las columnas no se generen automaticamente, sino que yo las lleno manualmente

                        'DGVCapturaPoliza.Columns(1).DataPropertyName = Format(CDec("Cuenta"), "###,###,##0.#0")
                        DGVCapturaPoliza.Columns(1).DataPropertyName = "Cuenta" 'Inserta la cuenta contable
                        DGVCapturaPoliza.Columns(3).DataPropertyName = "DESCuenta"
                        DGVCapturaPoliza.Columns(4).DataPropertyName = "Cargo"
                        DGVCapturaPoliza.Columns(5).DataPropertyName = "Abono"
                        DGVCapturaPoliza.Columns(6).DataPropertyName = "CECO"
                        DGVCapturaPoliza.Columns(8).DataPropertyName = "Referencia"
                        DGVCapturaPoliza.Columns(9).DataPropertyName = "Concepto"
                        DGVCapturaPoliza.Columns(10).DataPropertyName = "RefDocumento"
                        'lblEstatus.Text = dt.Rows(0).Item(17)
                        BtnEliminar.Enabled = True
                        BtnModificar.Enabled = True
                        existe = 1
                        gbxControles.Enabled = False
                        lblEstatus.Enabled = True
                        btnImprimir.Enabled = True
                        DGVCapturaPoliza.DataSource = dt
                        SUMAPPOLIZA()

                        Dim dr2 As SqlDataReader
                        dr2 = oclsPolizasContables.SeleccionaPolizaContable(fecha, cbxTipoPoliza.SelectedValue, txtFolioDocumento.Text)
                        If dr2.Read() Then

                            lblEstatus.Text = Trim(dr2("DESEstatus").ToString())

                            If lblEstatus.Text = "CANCELADA" Then
                                lblEstatus.ForeColor = Color.Red
                            End If
                        Else
                            MsgBox("No se Pudo Obtener el Estatus de la Poliza", MsgBoxStyle.Critical)
                        End If
                    End If
                End If
            End If
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
                        'row.Item("dUnidadNegocio") = "" 'Nueva
                        'row.Item("dReferencia") = "" 'Nueva
                        'row.Item("dRefDocumento") = "" 'Nueva
                        dt.Rows.Add(row)

                        DGVCapturaPoliza.DataSource = dt
                        DGVCapturaPoliza.CurrentRow.Cells("dCuenta").Selected = True
                        'DGVCapturaPoliza.CurrentRow.Cells("dUnidadNegocio").Value = ""
                        'DGVCapturaPoliza.CurrentRow.Cells("dReferencia").Value = ""
                        'DGVCapturaPoliza.CurrentRow.Cells("dRefDocumento").Value = ""


                    End If
                Else
                    Dim UltimaFila As Integer
                    UltimaFila = DGVCapturaPoliza.Rows.Count - 1
                    If DGVCapturaPoliza.CurrentRow.Index = UltimaFila Or UltimaFila = 0 Then

                        DGVCapturaPoliza.Rows.Add()
                        DGVCapturaPoliza.CurrentRow.Cells("dCuenta").Selected = True

                        'Dim Nrows As Integer = DGVCapturaPoliza.RowCount
                        'If Nrows > 1 Then

                        '    Dim FilaSeleccionada As Integer = DGVCapturaPoliza.CurrentCell.RowIndex
                        '    datoConcepto = DGVCapturaPoliza.Rows(FilaSeleccionada).Cells(8).Value
                        '    DGVCapturaPoliza.Rows(FilaSeleccionada).Cells(8).Value = datoConcepto
                        'End If
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

            cbxTipoCaptura.Text = ""
            cbxMoneda.Text = ""
            'cbxTipoPoliza.Text = ""
            lblDiferencia.Text = ""
            txtFolioDocumento.Text = ""
            gbxControles.Enabled = True
            lblEstatus.Text = ""
            'CCuenta = 0
            CError = 0
            MError = 0

            DGVCapturaPoliza.FirstDisplayedScrollingColumnIndex = 0
            existe = 0
            DGVCapturaPoliza.Enabled = False
            BtnGuardar.Enabled = False
            DtpFecha.Enabled = True
            'datoConcepto = ""
            cbxTipoCaptura.Focus()
            ' txtTipoCambio.Text = ""
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
            'FuncKeysModule(e.KeyValue)
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
        'If Celda.ColumnIndex = 5 Then
        '    If e.KeyValue = Keys.Subtract Then
        '        e.Handled = True
        '        DGVCapturaPoliza.CurrentRow.Cells(5).Value = (DGVCapturaPoliza.CurrentRow.Cells(5).Value) * (-1)
        '    End If
        '    'FuncKeysModule(e.KeyValue)

        'End If

    End Sub

    Private Sub DGVCapturaPoliza_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVCapturaPoliza.KeyUp
        'If e.KeyCode = Keys.F3 Then
        '    MsgBox("Aqui Repetir")
        'End If
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
        If MessageBox.Show("¿Desea Guardar el Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If DGVCapturaPoliza.Rows.Count < 2 Then
                MsgBox("La Poliza Debe Contener Mas de una Linea", MsgBoxStyle.Critical)

            Else
                If lblDiferencia.Text <> 0 Then
                    MsgBox("Existen Diferencias Verifique", MsgBoxStyle.Critical)
                Else
                    If CError = 1 Or MError = 1 Then
                        MsgBox("Existen Datos No Validos, Verifique", MsgBoxStyle.Critical)
                    Else
                        '-- Verificar que todas las columnas tengan datos y no haya una vacia--
                        Dim NumFilas As Integer
                        Dim CuentasTot As Long = 0
                        Dim CECO As String = ""
                        NumFilas = DGVCapturaPoliza.RowCount
                        For Each rowgrid1 As DataGridViewRow In DGVCapturaPoliza.Rows

                            If rowgrid1.Cells("dRefDocumento").Value = Nothing Then
                                rowgrid1.Cells("dRefDocumento").Value = ""
                            End If
                            If rowgrid1.Cells("dconcepto").Value = Nothing Then
                                rowgrid1.Cells("dconcepto").Value = ""
                            End If
                            If rowgrid1.Cells("dReferencia").Value = Nothing Then
                                rowgrid1.Cells("dReferencia").Value = ""
                            End If

                            CECO = rowgrid1.Cells("dUnidadNegocio").Value
                            If CECO = Nothing Then
                                CECO = ""
                            End If


                            Dim CuentaOK As Object = rowgrid1.Cells("dcuenta").Value
                            'value = rowgrid.Item("Fecha")
                            If CuentaOK > 0 Then
                                CuentasTot = CuentasTot + 1
                            End If
                        Next

                        If NumFilas <> CuentasTot Then
                            MsgBox("Existen Filas Sin Datos Verifique", MsgBoxStyle.Exclamation)
                        Else

                            '--------------------VALIDACION DE CUENTAS---------------
                            Dim dr As SqlDataReader
                            Dim dt As New DataTable
                            Dim TipoPoliza As String
                            'Dim NombreCuenta As String = ""
                            Dim Nregistros As Integer = 0
                            Dim BanderaSitiene As Integer
                            Dim oclsPolizasContables2 As New clsPolizasContables
                            TipoPoliza = Long.Parse(cbxTipoPoliza.SelectedValue).ToString("00")
                            dr = oclsPolizasContables2.SeleccionaCuentasForzadas(TipoPoliza)
                            dt.Load(dr)
                            If dt.Rows.Count > 0 Then
                                Nregistros = dt.Rows.Count '--Contiene el numero de restricciones que tiene que conincidir con las validaciones en true
                                Dim i As Integer
                                Dim RangoIni As Long
                                Dim RangoFin As Long
                                Dim NombreCuenta As String
                                'Dim row As DataRow
                                For i = 0 To dt.Rows.Count - 1
                                    RangoIni = (dt.Rows(i).Item("RangoIni"))
                                    RangoFin = (dt.Rows(i).Item("RangoFin"))
                                    NombreCuenta = Trim((dt.Rows(i).Item("Descripcion")))
                                    BanderaSitiene = 0
                                    'CStr(row("RangoFin"))
                                    For Each rowgrid As DataGridViewRow In DGVCapturaPoliza.Rows
                                        Dim value As Object = rowgrid.Cells("dcuenta").Value
                                        'value = rowgrid.Item("Fecha")
                                        If value > RangoIni And value < RangoFin Then
                                            BanderaSitiene = 1
                                            'Exit Sub
                                        End If
                                    Next
                                    If BanderaSitiene = 0 Then
                                        MsgBox("La Poliza Omite una o mas cuentas Obligatorias NO PROCEDE! Falta Cuenta Tipo: " & NombreCuenta, MsgBoxStyle.Critical, "Sistema Contable")
                                        Exit Sub
                                    End If
                                Next
                            End If

                            'If contiene = Nregistros Then ' sino coinciden las validaciones con el total de registros de la consulta de restricciones no pasa a grabar
                            'MsgBox("Faltan cuentas Obligatorias")
                            'Else
                            '--------------------------------------------------------
                            IndicaFoliosiguiente()

                            Dim clsDB = New clsBD()
                            Dim cnnConexion = New SqlConnection()

                            cnnConexion = clsDB.CreaConexion()
                            Dim transaction As SqlTransaction
                            transaction = cnnConexion.BeginTransaction

                            Try
                                Dim fecha As String
                                Dim importe As Decimal
                                Dim CarAbo As String
                                Dim linea As Integer
                                DGVCapturaPoliza.Rows(0).Selected = True
                                DGVCapturaPoliza.Rows(0).Cells(0).Selected = True
                                fecha = Format(DtpFecha.Value, "yyyyMMdd") '+ " 00:00:00"
                                linea = DGVCapturaPoliza.CurrentRow.Index
                                linea = linea + 1
                                For Each row As DataGridViewRow In DGVCapturaPoliza.Rows

                                    If row.Cells("dcargos").Value <> 0 Then
                                        importe = row.Cells("dcargos").Value
                                        CarAbo = "C"
                                    Else
                                        importe = row.Cells("dabonos").Value
                                        importe = (importe) * (-1)
                                        CarAbo = "A"
                                    End If

                                    Dim cmd As New SqlCommand

                                    cmd.CommandText = "spInsPolizaContable"
                                    cmd.CommandType = CommandType.StoredProcedure
                                    cmd.Connection = cnnConexion
                                    cmd.Transaction = transaction

                                    cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fecha
                                    cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.VarChar).Value = lblTipoMovimiento.Text
                                    cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = cbxTipoPoliza.SelectedValue
                                    cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = txtFolioDocumento.Text
                                    cmd.Parameters.Add("@pCuenta", SqlDbType.VarChar).Value = row.Cells("dcuenta").Value
                                    cmd.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = importe
                                    cmd.Parameters.Add("@pCAR_ABO", SqlDbType.VarChar).Value = CarAbo
                                    cmd.Parameters.Add("@pConcepto", SqlDbType.VarChar).Value = row.Cells("dconcepto").Value
                                    cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = row.Cells("dReferencia").Value
                                    cmd.Parameters.Add("@pRefDocumento", SqlDbType.VarChar).Value = row.Cells("dRefDocumento").Value
                                    cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = CMoneda
                                    cmd.Parameters.Add("@pEstatus", SqlDbType.VarChar).Value = " "
                                    cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = LoginUsuario
                                    'cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = "PRUEBA"
                                    cmd.Parameters.Add("@pNumeroLinea", SqlDbType.VarChar).Value = linea
                                    cmd.Parameters.Add("@pCECO", SqlDbType.VarChar).Value = CECO 'row.Cells("dUnidadNegocio").Value


                                    cmd.ExecuteNonQuery()

                                    '-----------------------

                                    'Dim oclsPolizasContables = New clsPolizasContables() 'dRefDocumento
                                    'oclsPolizasContables.InsertaPolizaContable(fecha, lblTipoMovimiento.Text, cbxTipoPoliza.SelectedValue, txtFolioDocumento.Text _
                                    '                                           , row.Cells("dcuenta").Value, importe, CarAbo, row.Cells("dconcepto").Value _
                                    '                                           , row.Cells("dReferencia").Value, row.Cells("dRefDocumento").Value, CMoneda _
                                    '                                           , " ", LoginUsuario, linea, row.Cells("dUnidadNegocio").Value)

                                    '-------------------------

                                    linea = linea + 1
                                Next
                                transaction.Commit()
                                MsgBox("Grabado Correctamente", MsgBoxStyle.Information)
                                linea = 0
                            Catch err As Exception
                                transaction.Rollback()
                                MsgBox("Ocurrio un Error al Grabar ", MsgBoxStyle.Critical)
                                MessageBox.Show("Error:" & err.Message)
                            Finally
                                btnImprimir.Enabled = True
                                btnImprimir.PerformClick()
                                cnnConexion.Dispose()
                                cnnConexion.Close()
                            End Try
                        End If
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim frm As New frmRPTPolizasManual
        frm.folio = txtFolioDocumento.Text
        frm.tipoPoliza = cbxTipoPoliza.SelectedValue
        frm.fecha = Format(DtpFecha.Value, "yyyyMMdd")
        frm.ShowDialog()
        BtnGuardar.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Desea ELIMINAR el Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim fecha As String
            fecha = Format(DtpFecha.Value, "yyyyMMdd")

            Dim oclsPolizasContables = New clsPolizasContables()
            oclsPolizasContables.EliminaPolizaContable(fecha, cbxTipoPoliza.SelectedValue, txtFolioDocumento.Text)
            MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
            btnNuevo.PerformClick()


        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If MessageBox.Show("¿Desea Actualizar el Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If lblDiferencia.Text <> 0 Then
                MsgBox("Existen Diferencias Verifique", MsgBoxStyle.Critical)
            Else
                If DGVCapturaPoliza.Rows.Count < 1 Then
                    MsgBox("La Poliza Debe Contener Mas de una Linea", MsgBoxStyle.Critical)
                Else
                    If CError = 1 Or MError = 1 Then
                        MsgBox("Existen Datos No Validos, Verifique", MsgBoxStyle.Critical)
                    Else
                        '-- Verificar que todas las columnas tengan datos y no haya una vacia--
                        Dim NumFilas As Integer
                        Dim CuentasTot As Long = 0
                        NumFilas = DGVCapturaPoliza.RowCount
                        For Each rowgrid1 As DataGridViewRow In DGVCapturaPoliza.Rows
                            Dim CuentaOK As Object = rowgrid1.Cells("dcuenta").Value
                            'value = rowgrid.Item("Fecha")
                            If CuentaOK <> "" Then
                                If CuentaOK > 0 Then
                                    CuentasTot = CuentasTot + 1
                                End If
                            End If

                        Next

                        If NumFilas <> CuentasTot Then
                            MsgBox("Existen Filas Sin Datos Verifique", MsgBoxStyle.Exclamation)
                        Else

                            '--------------------VALIDACION DE CUENTAS---------------
                            Dim dr As SqlDataReader
                            Dim dt As New DataTable
                            Dim TipoPoliza As String
                            'Dim NombreCuenta As String = ""
                            Dim Nregistros As Integer = 0
                            Dim BanderaSitiene As Integer
                            Dim oclsPolizasContables2 As New clsPolizasContables
                            TipoPoliza = Long.Parse(cbxTipoPoliza.SelectedValue).ToString("00")
                            dr = oclsPolizasContables2.SeleccionaCuentasForzadas(TipoPoliza)
                            dt.Load(dr)
                            If dt.Rows.Count > 0 Then
                                Nregistros = dt.Rows.Count '--Contiene el numero de restricciones que tiene que conincidir con las validaciones en true
                                Dim i As Integer
                                Dim RangoIni As Long
                                Dim RangoFin As Long
                                Dim NombreCuenta As String
                                'Dim row As DataRow
                                For i = 0 To dt.Rows.Count - 1
                                    RangoIni = (dt.Rows(i).Item("RangoIni"))
                                    RangoFin = (dt.Rows(i).Item("RangoFin"))
                                    NombreCuenta = Trim((dt.Rows(i).Item("Descripcion")))
                                    BanderaSitiene = 0

                                    For Each rowgrid As DataGridViewRow In DGVCapturaPoliza.Rows
                                        Dim value As Object = rowgrid.Cells("dcuenta").Value

                                        If value > RangoIni And value < RangoFin Then
                                            BanderaSitiene = 1
                                            'Exit Sub
                                        End If
                                    Next
                                    If BanderaSitiene = 0 Then
                                        MsgBox("La Poliza Omite una o mas cuentas Obligatorias NO PROCEDE! Falta Cuenta Tipo: " & NombreCuenta, MsgBoxStyle.Critical, "Sistema Contable")
                                        Exit Sub
                                    End If
                                Next
                            End If
                            '-------------------TRANSACCION------------------
                            Dim clsDB = New clsBD()
                            Dim cnnConexion = New SqlConnection()
                            Dim CECO As String = ""
                            Dim RefDocumento As String = ""

                            cnnConexion = clsDB.CreaConexion()
                            Dim transaction As SqlTransaction
                            transaction = cnnConexion.BeginTransaction

                            Try

                                Dim fecha As String
                                Dim importe As Decimal
                                Dim CarAbo As String
                                Dim linea As Integer
                                DGVCapturaPoliza.Rows(0).Selected = True
                                DGVCapturaPoliza.Rows(0).Cells(0).Selected = True
                                fecha = Format(DtpFecha.Value, "yyyyMMdd") '+ " 00:00:00"
                                linea = DGVCapturaPoliza.CurrentRow.Index
                                linea = linea + 1
                                For Each row As DataGridViewRow In DGVCapturaPoliza.Rows

                                    'RefDocumento = row.Cells("dRefDocumento").Value = vbNull
                                    If row.Cells("dRefDocumento").Value Is Nothing Then
                                        row.Cells("dRefDocumento").Value = ""
                                    End If
                                    If row.Cells("dconcepto").Value Is Nothing Then
                                        row.Cells("dconcepto").Value = ""
                                    End If
                                    If row.Cells("dReferencia").Value Is Nothing Then
                                        row.Cells("dReferencia").Value = ""
                                    End If

                                    'MsgBox("tipo" & row.Cells("dUnidadNegocio").Value & "-")
                                    'If IsNothing(row.Cells("dUnidadNegocio").Value) = False Then
                                    '    MsgBox("No hay ni mauser")
                                    'End If
                                    'If IsNothing(row.Cells("dUnidadNegocio").Value) = False Then
                                    '    CECO = ""
                                    'Else
                                    '    CECO = row.Cells("dUnidadNegocio").Value
                                    'End If

                                    Dim cargo As Decimal
                                    Dim abono As Decimal

                                    If row.Cells("dcargos").Value Is DBNull.Value Then
                                        row.Cells("dcargos").Value = 0.0
                                    Else
                                        cargo = (row.Cells("dCargos").Value)
                                    End If


                                    If row.Cells("dabonos").Value Is DBNull.Value Then
                                        row.Cells("dabonos").Value = 0.0
                                    Else
                                        abono = (row.Cells("dabonos").Value)
                                    End If

                                    'importe = cargo - abono

                                    If cargo <> 0 Then
                                        CarAbo = "C"
                                        importe = cargo
                                    Else
                                        CarAbo = "A"
                                        importe = abono * (-1)
                                    End If
                                    '------NUEVO PROCEDIMIENTO TRANSACCION--------

                                    Dim cmd As New SqlCommand

                                    cmd.CommandText = "spActPolizaContable"
                                    cmd.CommandType = CommandType.StoredProcedure
                                    cmd.Connection = cnnConexion
                                    cmd.Transaction = transaction

                                    cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fecha
                                    cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.VarChar).Value = lblTipoMovimiento.Text
                                    cmd.Parameters.Add("@pTipoPoliza", SqlDbType.VarChar).Value = cbxTipoPoliza.SelectedValue
                                    cmd.Parameters.Add("@pPoliza", SqlDbType.VarChar).Value = txtFolioDocumento.Text
                                    cmd.Parameters.Add("@pCuenta", SqlDbType.VarChar).Value = row.Cells("dcuenta").Value
                                    cmd.Parameters.Add("@pImporte", SqlDbType.VarChar).Value = importe
                                    cmd.Parameters.Add("@pCAR_ABO", SqlDbType.VarChar).Value = CarAbo
                                    cmd.Parameters.Add("@pConcepto", SqlDbType.VarChar).Value = row.Cells("dconcepto").Value
                                    cmd.Parameters.Add("@pReferencia", SqlDbType.VarChar).Value = row.Cells("dReferencia").Value
                                    cmd.Parameters.Add("@pRefDocumento", SqlDbType.VarChar).Value = row.Cells("dRefDocumento").Value
                                    cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = CMoneda
                                    cmd.Parameters.Add("@pEstatus", SqlDbType.VarChar).Value = " "
                                    cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = LoginUsuario
                                    'cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = "JOSUE.PRUEBA"
                                    cmd.Parameters.Add("@pNumeroLinea", SqlDbType.VarChar).Value = linea
                                    cmd.Parameters.Add("@pCECO", SqlDbType.VarChar).Value = row.Cells("dUnidadNegocio").Value

                                    cmd.ExecuteNonQuery()

                                    linea = linea + 1

                                Next
                                MsgBox("Grabado Correctamente", MsgBoxStyle.Information)
                                linea = 0
                                transaction.Commit()
                            Catch
                                MsgBox("Ocurrio un Error al Grabar ", MsgBoxStyle.Critical)
                                transaction.Rollback()
                            Finally
                                btnImprimir.Enabled = True
                                btnImprimir.PerformClick()
                                cnnConexion.Dispose()
                                cnnConexion.Close()
                            End Try
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cbxTipoPoliza_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipoPoliza.SelectedIndexChanged

    End Sub

    Private Sub cbxTipoPoliza_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipoPoliza.SelectedValueChanged
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        If cbxTipoPoliza.SelectedValue Is Nothing Then
            Exit Sub
        End If

        Dim TipoPoliza As String = cbxTipoPoliza.SelectedValue.ToString
        Dim consulta As String = "select TipoMovimiento from VIZ_SelTipoPoliza (NOLOCK) where tipopoliza='" & cbxTipoPoliza.SelectedValue.ToString & "'"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        Dim dr As SqlDataReader
        cmd.CommandType = CommandType.Text

        dr = cmd.ExecuteReader()

        If dr.Read() Then

            lblTipoMovimiento.Text = dr("TipoMovimiento").ToString()
        Else
            lblTipoMovimiento.Text = ""

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

            'row.Cells("dCargos").Value = Format(Decimal.TryParse(Convert.ToString(row.Cells("dCargos").Value), d), "###,###,##0.#0")


        Next

        txtTotalCargos.Text = Format(resultadoCargos, "###,###,##0.#0")

        '-------------Suma los Abonos y va sumando por registro toda la columna y la coloca en el text Total---------
        Dim resultadoAbonos As Decimal = 0D

        For Each row As DataGridViewRow In DGVCapturaPoliza.Rows
            Dim value As Object = row.Cells("dAbonos").Value

            Dim d As Decimal

            Dim bln As Boolean = Decimal.TryParse(Convert.ToString(value), d)
            resultadoAbonos += Convert.ToDecimal(d)

        Next

        txtTotalAbonos.Text = Format(resultadoAbonos, "###,###,##0.#0")

        lblDiferencia.Text = Format((resultadoCargos - resultadoAbonos), "###,###,##0.#0")

        If lblDiferencia.Text <> 0.0 Then

            lblDiferencia.ForeColor = Color.Red
        Else
            lblDiferencia.ForeColor = Color.Green

        End If



    End Sub

    Private Sub cbxTipoCaptura_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipoCaptura.LostFocus
        CargaTipoPolizas()
    End Sub

    Private Sub CargaTipoPolizas()
        '----------------------------------------
        'CARGA LISTA DE TIPOS DE POLIZAS
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        Dim tipocaptura As String = ""
        cnnConexion = clsDB.CreaConexion()

        Select Case cbxTipoCaptura.Text
            Case "1.- DIARIO"
                tipocaptura = "D"
            Case "2.- EGRESO"
                tipocaptura = "E"
            Case "3.- INGRESO"
                tipocaptura = "I"
            Case Else
                MsgBox("No Existen Tipos de Registros para el Tipo de Captura Especificado", MsgBoxStyle.Exclamation, "Sistema Contable")
        End Select

        Dim consulta As String = "select * from VIZ_SelTipoPoliza (NOLOCK) where tipopoliza<>4 and tipopoliza<>14 and clasepoliza='" & tipocaptura & "'" & "order by tipopoliza"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxTipoPoliza.ValueMember = "tipoPoliza"
        cbxTipoPoliza.DisplayMember = "TIPOPOLDES"
        cbxTipoPoliza.DataSource = dt

    End Sub

    Private Sub cbxTipoCaptura_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipoCaptura.TextChanged
        CargaTipoPolizas()
    End Sub

    Private Sub cbxMoneda_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMoneda.TextChanged
        If cbxMoneda.Text = "1.- PESOS" Then
            CMoneda = 1
            Dim DR As SqlDataReader
            Dim oclstipocambio As New clsTipocambio
            DR = oclstipocambio.CargaTipoCambio(Format(DtpFecha.Value, "yyyyMMdd") + " 00:00:00")

            If DR.Read() Then

                txtTipoCambio.Text = DR("TipoCambio").ToString()
                'DtpFecha.Enabled = False

            Else
                'MsgBox("No hay Tipo de Cambio para la fecha seleccionada", MsgBoxStyle.Critical)
                txtTipoCambio.Text = "0.00"
            End If
        End If
    End Sub

    Private Sub cbxTipoPoliza_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipoPoliza.TextChanged
        'IndicaFoliosiguiente()

    End Sub

    Private Sub IndicaFoliosiguiente()
        Dim dr As SqlDataReader
        Dim oclsPolizasContables As New clsPolizasContables

        dr = oclsPolizasContables.SeleccionaConsecutivo(cbxTipoPoliza.SelectedValue.ToString)

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
        Dim fechaMes As String

        fechaMes = Format(DtpFecha.Value, "yyyyMM01")

        cnnConexion = clsDB.CreaConexion()
        cmd.CommandText = "spValidaMesCerrado"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@MesCerrado", SqlDbType.VarChar).Value = fechaMes

        dr = cmd.ExecuteReader()


        If dr.Read() Then

            MESCERRADO = dr("cerrado").ToString()
        Else
            MsgBox("No se Encontro Estatus de Mes")
        End If
    End Sub

    Private Sub DtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFecha.LostFocus
        If cbxMoneda.Text = "1.- PESOS" Then
            CMoneda = 1
            Dim DR As SqlDataReader
            Dim oclstipocambio As New clsTipocambio
            DR = oclstipocambio.CargaTipoCambio(Format(DtpFecha.Value, "yyyyMMdd") + " 00:00:00")

            If DR.Read() Then

                txtTipoCambio.Text = DR("TipoCambio").ToString()
                'DtpFecha.Enabled = False

            Else
                txtTipoCambio.Text = "0.00"
                'MsgBox("No hay Tipo de Cambio para la fecha seleccionada", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmPolizasImportarExcel.Show()
    End Sub
End Class