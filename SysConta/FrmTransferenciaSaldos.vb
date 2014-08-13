Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.mdVariables
Imports WindowsApplication1.clsBancos
Imports WindowsApplication1.clsTools
Public Class FrmTransferenciaSaldos
    Friend cTabla As String
    Private Sub cargadatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        'Se esta tomando el el Banco y NumeroCuenta de la tabla CatBancos Para que al cargar el combobox traiga automaticamente el numeroCuenta
        Dim consulta As String = "Select Codigo,Banco,NumeroCuenta from CatBancos(nolock) order by banco"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cbxBanco.ValueMember = "Codigo"
        cbxBanco.DisplayMember = "Banco"
        cbxBanco.DataSource = dt
    End Sub
    Private Sub cargadatos2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        '
        Dim consulta As String = "Select Codigo,Banco,NumeroCuenta from CatBancos(nolock) order by banco"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cbxBanco2.ValueMember = "Codigo"
        cbxBanco2.DisplayMember = "Banco"
        cbxBanco2.DataSource = dt
    End Sub
    Private Sub cargadatos3()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta As String = "Select TipoMoneda,Descripcion from catMonedas(nolock) order by Descripcion"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cbxMoneda1.ValueMember = "TipoMoneda"
        cbxMoneda1.DisplayMember = "Descripcion"
        cbxMoneda1.DataSource = dt
    End Sub
    Private Sub cargadatos4()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta As String = "Select TipoMoneda,Descripcion from catMonedas(nolock) order by Descripcion"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt1 As New DataTable
        da.Fill(dt1)
        cbxMoneda2.ValueMember = "TipoMoneda"
        cbxMoneda2.DisplayMember = "Descripcion"
        cbxMoneda2.DataSource = dt1
    End Sub
    Private Sub btnTransferir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferir.Click
        Dim Monda1 As String = cbxMoneda1.Text
        Dim Moneda2 As String = cbxMoneda2.Text
        'If Monda1 = Moneda2 Then
        '    'MsgBox("Tipo de Moneda diferente, Revise para continuar", vbInformation, "Sistema Contable")
        'Else
        '    If Monda1 <> Moneda2 Then
        '        cbxBanco2.Text = "Seleccione Banco"
        '        cbxMoneda2.Text = "Seleccione Moneda"
        '        lblCuenta2.Text = ""
        '        cbxBanco.Focus()
        '        MsgBox("Tipo de Moneda diferente,Revise para poder hacer la transferencia", vbInformation, "Sistema Contable")
        '    End If
        'End If
        If Monda1 <> Moneda2 Or cbxBanco.Text = "" Or lblCuenta.Text = "" Or txtSaldo.Text = "" Or cbxMoneda1.Text = "" Or cbxBanco2.Text = "" Or lblCuenta2.Text = "" Or cbxMoneda2.Text = "" Then
            MsgBox("El Tipo de Moneda es Diferente ó Hay Datos Vacios, Favor de Revisar la Transferencia..!!!", vbInformation, "Sistema Contable")
            cbxBanco.Focus()
        Else
            Dim saldo As Decimal = txtSaldo.Text
            Dim bfecha As String = dtpFecha.Text
            Dim busuario As String = LoginUsuario
            Dim bancoOrigen As String = Me.cbxBanco.SelectedValue
            Dim bancoDestino As String = Me.cbxBanco2.SelectedValue
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            Dim commandbus As New SqlCommand("spValidaTransferencia", cnnConexion)
            commandbus.CommandType = CommandType.StoredProcedure
            commandbus.Parameters.AddWithValue("@CodigoBanco", Me.cbxBanco.SelectedValue)
            commandbus.Parameters.AddWithValue("@Saldo", saldo)
            Dim n As Integer
            n = RTrim(commandbus.ExecuteScalar())
            If n > "0" Then
                If MessageBox.Show("¿Esta Seguro que desea hacer esta Transferencia?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim XError As String
                    Dim clsDB2 = New clsBD()
                    Dim cnnConexion2 = New SqlConnection()
                    cnnConexion2 = clsDB2.CreaConexion()
                    Dim wQuery As String = ""
                    Dim cmd As SqlCommand
                    Dim wFolio As String = 0
                    Dim wMovimiento As String = 0
                    Dim dr As SqlDataReader
                    Dim transaction As SqlTransaction

                    wQuery = "SELECT Foliobantras+1 as Folio FROM parametros"
                    XError = "Error al obtener Folio Consecutivo"
                    cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                    cmd.CommandType = Data.CommandType.Text
                    transaction = cnnConexion.BeginTransaction
                    cmd.Connection = cnnConexion
                    cmd.Transaction = transaction
                    Try
                        dr = cmd.ExecuteReader()
                        If dr.Read Then
                            wFolio = dr("Folio").ToString()
                        Else
                            MsgBox("No Se Genero Consecutivo de Folio")
                        End If
                        dr.Close()

                        Dim fechaAct As String = Format(Me.dtpFecha.Value, "dd/MM/yyyy")

                        'For Each row As DataGridViewRow In DGVFacturaPagos.Rows
                        XError = "Error al Grabar Detalle de Transferencia"
                        cmd.Parameters.Clear()
                        'If row.Cells("mCantPago").Value > 0 Then

                        cmd.CommandText = "spInsMovTransferencias"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion
                        cmd.Transaction = transaction

                        cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.Int).Value = 13
                        cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
                        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fechaAct
                        cmd.Parameters.Add("@pCodigoBanco", SqlDbType.Int).Value = cbxBanco.SelectedValue
                        cmd.Parameters.Add("@pNumeroCheque", SqlDbType.Int).Value = 0
                        cmd.Parameters.Add("@pCodigoProveedor", SqlDbType.VarChar).Value = 0
                        cmd.Parameters.Add("@pFolioContrarecibo", SqlDbType.Int).Value = 0
                        cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = vbNullChar
                        cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = txtSaldo.Text

                        cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = 0

                        cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = txtSaldo.Text
                        cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = txtSaldo.Text
                        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = 14
                        cmd.Parameters.Add("@pPoliza", SqlDbType.Int).Value = 0
                        cmd.Parameters.Add("@pUsuarioModificacion", SqlDbType.VarChar).Value = LoginUsuario
                        cmd.Parameters.Add("@pBeneficiario", SqlDbType.VarChar).Value = ""
                        cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = cbxMoneda1.SelectedValue
                        cmd.ExecuteNonQuery()

                        ''---REGISTRO BANCO RECIBE

                        cmd.Parameters.Clear()
                        'If row.Cells("mCantPago").Value > 0 Then

                        cmd.CommandText = "spInsMovTransferencias"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion
                        cmd.Transaction = transaction

                        cmd.Parameters.Add("@pTipoMovimiento", SqlDbType.Int).Value = 12
                        cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
                        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar).Value = fechaAct
                        cmd.Parameters.Add("@pCodigoBanco", SqlDbType.Int).Value = cbxBanco2.SelectedValue
                        cmd.Parameters.Add("@pNumeroCheque", SqlDbType.Int).Value = 0
                        cmd.Parameters.Add("@pCodigoProveedor", SqlDbType.VarChar).Value = 0
                        cmd.Parameters.Add("@pFolioContrarecibo", SqlDbType.Int).Value = 0
                        cmd.Parameters.Add("@pFacturaProveedor", SqlDbType.VarChar).Value = vbNullChar
                        cmd.Parameters.Add("@pSubtotal", SqlDbType.Decimal).Value = txtSaldo.Text

                        cmd.Parameters.Add("@pIVA16", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIVA11", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIVAImp", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIVARetHon", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIVARetArr", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIVARet4", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pISRHon", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pISRArr", SqlDbType.Decimal).Value = 0
                        cmd.Parameters.Add("@pIEPS", SqlDbType.Decimal).Value = 0

                        cmd.Parameters.Add("@pTotal", SqlDbType.Decimal).Value = txtSaldo.Text
                        cmd.Parameters.Add("@pTotalAbono", SqlDbType.Decimal).Value = txtSaldo.Text
                        cmd.Parameters.Add("@pTipoPoliza", SqlDbType.Int).Value = 14
                        cmd.Parameters.Add("@pPoliza", SqlDbType.Int).Value = 0
                        cmd.Parameters.Add("@pUsuarioModificacion", SqlDbType.VarChar).Value = LoginUsuario
                        cmd.Parameters.Add("@pBeneficiario", SqlDbType.VarChar).Value = ""
                        cmd.Parameters.Add("@pTipoMoneda", SqlDbType.VarChar).Value = cbxMoneda2.SelectedValue
                        cmd.ExecuteNonQuery()

                        cmd.Parameters.Clear()
                        cmd.CommandText = "spBancoTransferencias"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion
                        cmd.Parameters.Add("@BancoOrigen", SqlDbType.NVarChar, 35).Value = bancoOrigen
                        cmd.Parameters.Add("@BancoDestino", SqlDbType.NVarChar, 35).Value = bancoDestino
                        cmd.Parameters.Add("@Saldo", SqlDbType.Decimal, 18, 4).Value = Me.txtSaldo.Text

                        cmd.ExecuteNonQuery()

                        cmd.Parameters.Clear()
                        cmd.CommandText = "spInsPolizaTransferencia"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion
                        cmd.Parameters.Add("@pFolio", SqlDbType.Int).Value = wFolio
                        cmd.Parameters.Add("@pFecha", SqlDbType.VarChar, 15).Value = fechaAct
                        cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar, 20).Value = busuario
                        cmd.Parameters.Add("@pMoneda", SqlDbType.Char, 1).Value = cbxMoneda1.Text

                        cmd.ExecuteNonQuery()

                        cmd.Parameters.Clear()
                        cmd.CommandText = "spInsConceptoTransferencia"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion
                        cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = wFolio
                        cmd.Parameters.Add("@pConcepto", SqlDbType.VarChar).Value = Trim(txtConcepto.Text)
                        cmd.Parameters.Add("@pConcepto2", SqlDbType.VarChar).Value = Trim(txtConcepto2.Text)
                        cmd.Parameters.Add("@pConcepto3", SqlDbType.VarChar).Value = Trim(txtConcepto3.Text)
                        cmd.Parameters.Add("@pConcepto4", SqlDbType.VarChar).Value = Trim(txtConcepto4.Text)
                        cmd.Parameters.Add("@pConcepto5", SqlDbType.VarChar).Value = Trim(txtConcepto5.Text)
                        cmd.Parameters.Add("@pConcepto6", SqlDbType.VarChar).Value = Trim(txtConcepto6.Text)

                        cmd.ExecuteNonQuery()

                        MsgBox("Tranferencia Exitosa...Numero de Poliza : " + wFolio, vbInformation, "Sistema Contable")

                        '----Adelanta folio de Movimiento en los parametros
                        XError = "Error al Actualizar Parametro Foliador consecutivo "
                        cmd.Parameters.Clear()
                        cmd.CommandText = "spAdeFolioBcoTransferencia"
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnnConexion
                        cmd.Parameters.Add("@FoliobanTras", SqlDbType.NVarChar).Value = wFolio
                        cmd.ExecuteNonQuery()

                        transaction.Commit()

                        Dim frm As New frmRPTPolizasManual
                        frm.folio = wFolio
                        frm.tipoPoliza = 14
                        frm.fecha = Format(dtpFecha.Value, "yyyyMMdd")
                        frm.ShowDialog()

                        'Dim frm As New frmRPTTrasSaldo
                        'folio = wFolio
                        'referencia = folio
                        'frm.ShowDialog()

                        Dim limpiar As New clsTools
                        limpiar.LimpiarControles(Me)
                        txtBancos.Text = "BUSCAR BANCO"
                        cbxBanco.Text = "Seleccione Banco"
                        cbxBanco2.Text = "Seleccione Banco"
                        cbxMoneda1.Text = "Seleccione Moneda"
                        cbxMoneda2.Text = "Seleccione Moneda"
                        lblCuenta.Text = ""
                        lblCuenta2.Text = ""
                        txtSaldo.Clear()
                        llenalista2()
                        cbxBanco.Focus()
                    Catch err As Exception
                        transaction.Rollback()
                        MsgBox("Ocurrio un Error al Grabar la Transferencia", MsgBoxStyle.Critical, "Sistema Contable")
                        MessageBox.Show("Error:" & err.Message)
                    Finally
                    End Try
                End If
            Else
                MsgBox("No Existe Saldo Suficiente para Realizar la Transferencia, Favor de Revisar.", vbInformation, "Sistema Contable")
                Me.cbxBanco.Focus()
            End If
        End If
    End Sub
    Private Sub FrmTransferenciaSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Transferencia InterBancaria " + Space(5) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        cargadatos()
        cargadatos2()
        cargadatos3()
        cargadatos4()
        txtBancos.Text = "BUSCAR BANCO"
        cbxBanco.Text = "Seleccione Banco"
        cbxBanco2.Text = "Seleccione Banco"
        cbxMoneda1.Text = "Seleccione Moneda"
        cbxMoneda2.Text = "Seleccione Moneda"
        lblCuenta.Text = " "
        lblCuenta2.Text = " "
        llenalista2()
        cbxBanco.Focus()
    End Sub
    Private Sub cbxBanco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxBanco.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtSaldo.Focus()
        End If
        If InStr(1, "" & CDec(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cbxBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxBanco.SelectedIndexChanged
        Dim dr As SqlDataReader
        Dim aclsBancos = New clsBancos()
        dr = aclsBancos.SeleccionaBancos(Me.cbxBanco.SelectedValue)

        If dr.Read() Then
            lblCuenta.Text = dr("NumeroCuenta").ToString()
            cbxMoneda1.Text = dr("TipoMoneda").ToString()
        End If
    End Sub

    Private Sub cbxBanco2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxBanco2.KeyPress
        If InStr(1, "" & CDec(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cbxBanco2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxBanco2.SelectedIndexChanged
        Dim dr As SqlDataReader
        Dim aclsBancos = New clsBancos()
        dr = aclsBancos.SeleccionaBancos(Me.cbxBanco2.SelectedValue)

        If dr.Read() Then
            lblCuenta2.Text = dr("NumeroCuenta").ToString()
            cbxMoneda2.Text = dr("TipoMoneda").ToString()
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        txtBancos.Text = "BUSCAR BANCO"
        txtBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        Me.cbxBanco.Enabled = True
        Me.btnTransferir.Enabled = True
        Me.btnNuevo.Enabled = True
        cbxBanco.Text = "Seleccione Banco"
        cbxBanco2.Text = "Seleccione Banco"
        cbxMoneda1.Text = "Seleccione Moneda"
        cbxMoneda2.Text = "Seleccione Moneda"
        lblCuenta.Text = " "
        lblCuenta2.Text = " "
        txtSaldo.Clear()
        llenalista2()
        Me.cbxBanco.Focus()
    End Sub
    Private Sub txtSaldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Or InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True

            e.KeyChar = ""
            cbxBanco2.Focus()
        End If
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from Contabilidad.Dbo.CatBancos(nolock) order by Banco"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "CatBancos")
        Dim objListItem As New ListViewItem
        Me.listBancos.Items.Clear()
        For Each drw As DataRow In ds.Tables("CatBancos").Rows
            objListItem = listBancos.Items.Add(drw.Item("Banco").ToString, 0)
            objListItem.SubItems.Add(drw.Item("NumeroCuenta").ToString)
            objListItem.SubItems.Add(drw.Item("Saldo").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub txtBancos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBancos.GotFocus
        txtBancos.Text = ""
        txtBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtBancos.ForeColor = Color.Gray
    End Sub
    Private Sub txtBancos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBancos.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsBancos = New clsBancos()
        dr = oclsBancos.SeleccionaListBancos(Me.txtBancos.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            listBancos.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("Banco").ToString)
                lstLista.SubItems.Add(rRow("NumeroCuenta").ToString)
                lstLista.SubItems.Add(rRow("Saldo").ToString)
                listBancos.Items.Add(lstLista)
            Next
        End If
    End Sub
    Private Sub txtSaldo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSaldo.LostFocus
        If txtSaldo.Text = "" Then
            'MsgBox("No deben quedar datos vacios,revise la transferencia", vbInformation, "Sistema Contable")
            'txtSaldo.Focus()
        Else
            txtSaldo.Text = Format(CDec(txtSaldo.Text), "##,##0.00")
        End If
    End Sub
End Class