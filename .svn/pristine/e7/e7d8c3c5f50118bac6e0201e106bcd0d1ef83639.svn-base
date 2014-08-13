Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsBancos
Imports WindowsApplication1.clsTools
Public Class frmBancos
    Dim nEstatus As String
    Dim RbValor As String
    Private Sub frmBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Catálogo de Bancos" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        CargaEstatus()
        CargaCtaContable()
        llenalista()
    End Sub
    Private Sub TxtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If TxtCodigo.Text <> "" Then
                cargadatos()
                BtnGrabar.Enabled = False
                BtnNuevo.Enabled = False
                btnModificar.Enabled = True
                BtnEliminar.Enabled = True
            Else
                TxtCodigo.Enabled = False
                btnModificar.Enabled = True
                btnModificar.PerformClick()
                BtnGrabar.Enabled = True
                BtnNuevo.Enabled = False
                btnModificar.Enabled = False
                BtnEliminar.Enabled = False
                limpiar()
                TxtCodigo.Text = "0000"
            End If
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cargadatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()
        Dim oclsBancos = New clsBancos()
        Dim dr As SqlDataReader

        dr = oclsBancos.SeleccionaBancos(Me.TxtCodigo.Text)

        If dr.Read() Then
            'carga el check en el Radio Button
            RbValor = dr(Trim("TipoMoneda")).ToString()
            If RbValor = "PESOS          " Then
                RbPesos.Checked = True
                RbDolares.Checked = False
            Else
                RbPesos.Checked = False
                RbDolares.Checked = True
            End If

            TxtBanco.Text = dr("Banco").ToString()
            TxtNumCuenta.Text = dr("NumeroCuenta").ToString()
            TxtNumCheque.Text = dr("NumeroCheque").ToString()
            TxtReferencia.Text = dr("Domicilio").ToString()
            TxtSaldo.Text = dr("Saldo").ToString()
            TxtSucursal.Text = dr("Sucursal").ToString()
            TxtDomicilio.Text = dr("Domicilio").ToString()
            CbxCtaContable.Text = dr("CuentaContable").ToString()
            TxtTelefono.Text = dr("Telefono").ToString()
            CbxEstatus.Text = dr("Descripcion").ToString()
        Else

            MsgBox("Codigo de Banco no encontrado...", MessageBoxIcon.Error)
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
            Me.TxtCodigo.SelectAll()
            Me.TxtCodigo.Focus()
        End If
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If TxtCodigo.Text = "" Or TxtBanco.Text = "" Or TxtNumCuenta.Text = "" Or Me.CbxCtaContable.Text = "Seleccione Cuenta" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Contable")
            Me.TxtBanco.Focus()
        Else
            Me.TxtBanco.Text = UCase(Me.TxtBanco.Text)
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                Dim commandbus As New SqlCommand("spValidaBanco", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure

                commandbus.Parameters.AddWithValue("@Codigo", TxtCodigo.Text)

                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > "0" Then

                    Dim oclsCliente = New clsBancos()
                    oclsCliente.EliminaBanco(TxtCodigo.Text)

                    nEstatus = CbxEstatus.SelectedValue

                    'carga el check en el Radio Button
                    If Me.RbPesos.Checked Then
                        RbValor = 1
                    End If
                    If Me.RbDolares.Checked Then
                        RbValor = 2
                    End If

                    Dim sXML = "<xBanco>"
                    sXML += "<Codigo>" + Me.TxtCodigo.Text + "</Codigo>"
                    sXML += "<NumeroCuenta>" + Me.TxtNumCuenta.Text + "</NumeroCuenta>"
                    sXML += "<NumeroCheque>" + Me.TxtNumCheque.Text + "</NumeroCheque>"
                    sXML += "<Banco>" + Me.TxtBanco.Text + "</Banco>"
                    sXML += "<Sucursal>" + Me.TxtSucursal.Text + "</Sucursal>"
                    sXML += "<Domicilio>" + Me.TxtDomicilio.Text + "</Domicilio>"
                    sXML += "<Telefono>" + Me.TxtTelefono.Text + "</Telefono >"
                    sXML += "<Referencia>" + Me.TxtReferencia.Text + "</Referencia>"
                    sXML += "<Saldo>" + Me.TxtSaldo.Text + "</Saldo>"
                    sXML += "<TipoMoneda>" + RbValor + "</TipoMoneda>"
                    sXML += "<CuentaContable>" + CbxCtaContable.Text + "</CuentaContable>"
                    sXML += "<Estatus>" + nEstatus + "</Estatus>"
                    sXML += "</xBanco>"

                    Dim xclsBanco = New clsBancos()
                    xclsBanco.InsertaBancos(sXML)

                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Contable")
                    limpiar()

                Else
                    nEstatus = CbxEstatus.SelectedValue

                    Dim wQuery As String = ""
                    Dim LocalCommand As SqlCommand
                    Dim wCodigo As String
                    wQuery = "SELECT MAX(FolioBanco)+1 FROM Parametros(NoLock)"

                    LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                    LocalCommand.CommandType = Data.CommandType.Text
                    wCodigo = LocalCommand.ExecuteScalar()
                    If wCodigo IsNot Nothing Then
                        'MsgBox("Se Genero Consecutivo de Folio Proveedor Correctamente", vbInformation, "Sistema Contable")
                    Else
                        MsgBox("No Se Genero Consecutivo de Folio Banco", vbInformation, "Sistema Contable")
                    End If
                    LocalCommand.Dispose()
                    cnnConexion.Close()

                    Dim xfolio = New clsBancos()
                    xfolio.AdelantaFolioBanco(wCodigo)

                    'carga el check en el Radio Button
                    If Me.RbPesos.Checked Then
                        RbValor = 1
                    End If
                    If Me.RbDolares.Checked Then
                        RbValor = 2
                    End If

                    Dim sXML = "<xBanco>"
                    sXML += "<Codigo>" + wCodigo + "</Codigo>"
                    sXML += "<NumeroCuenta>" + Me.TxtNumCuenta.Text + "</NumeroCuenta>"
                    sXML += "<NumeroCheque>" + Me.TxtNumCheque.Text + "</NumeroCheque>"
                    sXML += "<Banco>" + Me.TxtBanco.Text + "</Banco>"
                    sXML += "<Sucursal>" + Me.TxtSucursal.Text + "</Sucursal>"
                    sXML += "<Domicilio>" + Me.TxtDomicilio.Text + "</Domicilio>"
                    sXML += "<Telefono>" + Me.TxtTelefono.Text + "</Telefono >"
                    sXML += "<Referencia>" + Me.TxtReferencia.Text + "</Referencia>"
                    sXML += "<Saldo>" + Me.TxtSaldo.Text + "</Saldo>"
                    sXML += "<TipoMoneda>" + RbValor + "</TipoMoneda>"
                    sXML += "<CuentaContable>" + CbxCtaContable.Text + "</CuentaContable>"
                    sXML += "<Estatus>" + nEstatus + "</Estatus>"
                    sXML += "</xBanco>"

                    Dim oclsBancos = New clsBancos()
                    oclsBancos.InsertaBancos(sXML)

                    MsgBox("Registrado Correctamente, Codigo de Banco " + wCodigo, vbInformation, "Sistema Contable")
                    limpiar()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
            End Try
            TxtCodigo.Enabled = True
            TxtBanco.Enabled = False
            TxtNumCuenta.Enabled = False
            TxtNumCheque.Enabled = False
            TxtReferencia.Enabled = False
            TxtSaldo.Enabled = False
            TxtSucursal.Enabled = False
            RbPesos.Enabled = False
            RbDolares.Enabled = False
            TxtDomicilio.Enabled = False
            CbxCtaContable.Enabled = False
            TxtTelefono.Enabled = False
            CbxEstatus.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = False
            BtnEliminar.Enabled = False
            TxtCodigo.Focus()
            llenalista()
            CargaCtaContable()
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If TxtCodigo.Text = "" Then
            MsgBox("Debe Capturar Un Codigo de Banco", vbInformation, "Sistema Contable")
            TxtCodigo.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsBanco = New clsBancos()
                oclsBanco.EliminaBanco(TxtCodigo.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
                limpiar()
                BtnGrabar.Enabled = False
                BtnNuevo.Enabled = False
                btnModificar.Enabled = True
                BtnEliminar.Enabled = True
                TxtBanco.Focus()
                llenalista()
                CargaCtaContable()
            End If
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiar()
        TxtBanco.Focus()
        TxtCodigo.Enabled = False
        TxtCodigo.Text = "0000"
        TxtBanco.Enabled = True
        TxtNumCuenta.Enabled = True
        TxtNumCheque.Enabled = True
        TxtReferencia.Enabled = True
        TxtSaldo.Enabled = False
        TxtSucursal.Enabled = True
        RbPesos.Enabled = True
        RbDolares.Enabled = True
        TxtDomicilio.Enabled = True
        CbxCtaContable.Enabled = True
        TxtTelefono.Enabled = True
        CbxEstatus.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = False
        btnModificar.Enabled = True
        BtnEliminar.Enabled = False
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        TxtBanco.Enabled = True
        TxtNumCuenta.Enabled = True
        TxtNumCheque.Enabled = True
        TxtReferencia.Enabled = True
        TxtSaldo.Enabled = False
        TxtSucursal.Enabled = True
        RbPesos.Enabled = True
        RbDolares.Enabled = True
        TxtDomicilio.Enabled = True
        CbxCtaContable.Enabled = True
        TxtTelefono.Enabled = True
        CbxEstatus.Enabled = True
        TxtBanco.Focus()
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub
    Private Sub TxtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBuscar.GotFocus
        TxtBuscar.Text = ""
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        TxtBuscar.ForeColor = Color.Black
    End Sub
    Private Sub TxtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsBancos = New clsBancos()

        dr = oclsBancos.BuscaNombreBanco(Me.TxtBuscar.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        lstBancos.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Codigo").ToString)
            lstLista.SubItems.Add(rRow("Banco").ToString)
            lstBancos.Items.Add(lstLista)
        Next
    End Sub
    Sub CargaEstatus()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        'Se esta tomando el estatus del la tabla CatClientes
        Dim consulta As String = "Select EstatusBanco,Descripcion from Contabilidad.DBO.CatEstatusBanco(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxEstatus.ValueMember = "EstatusBanco"
        CbxEstatus.DisplayMember = "Descripcion"
        CbxEstatus.DataSource = dt
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub CargaCtaContable()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        'Se esta tomando el estatus del la tabla CatClientes
        Dim consulta As String = "select Cuenta,Descripcion from catcuentas(nolock) where cuenta between (select RangoIni from catcuentasparametros(nolock) where idtipocuenta=2) and (select RangoFin from catcuentasparametros(nolock) where idtipocuenta=2)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        Me.CbxCtaContable.ValueMember = "Cuenta"
        Me.CbxCtaContable.DisplayMember = "Cuenta"
        Me.CbxCtaContable.DataSource = dt
        Me.CbxCtaContable.Text = "Seleccione Cuenta"
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub limpiar()
        Me.TxtCodigo.Clear()
        Me.TxtBanco.Clear()
        Me.TxtNumCuenta.Clear()
        Me.TxtNumCheque.Clear()
        Me.TxtReferencia.Clear()
        Me.TxtSaldo.Clear()
        Me.TxtSucursal.Clear()
        Me.RbPesos.Checked = True
        Me.RbDolares.Checked = False
        Me.TxtDomicilio.Clear()
        Me.TxtTelefono.Clear()
        Me.CbxCtaContable.Text = "Seleccione Cuenta"
    End Sub
    Private Sub llenalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select * From Contabilidad.dbo.CatBancos(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "CatBancos")


        Dim objListItem As New ListViewItem
        Me.lstBancos.Items.Clear()

        For Each drw As DataRow In ds.Tables("CatBancos").Rows
            objListItem = lstBancos.Items.Add(drw.Item("Codigo").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Banco").ToString)
            objListItem.SubItems.Add(drw.Item("CuentaContable").ToString)
        Next
    End Sub
    Private Sub CbxCtaContable_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxCtaContable.Leave
        If Me.CbxCtaContable.Text = "Seleccione Cuenta" Then
            MsgBox("Seleccione Cuenta Contable para el Banco.", MessageBoxIcon.Error)
            Me.CbxCtaContable.Focus()
        Else

            Dim pclsBancos = New clsBancos()
            Dim dr As SqlDataReader

            dr = pclsBancos.ValidaCtaBancos(Me.CbxCtaContable.SelectedValue)

            If dr.Read() Then
                MsgBox("Cuenta Contable ya Asignada a otro Banco, favor de Revisar...", MessageBoxIcon.Error)
                Me.CbxCtaContable.Focus()
            Else
                Me.TxtTelefono.Focus()
            End If
        End If
    End Sub
    Private Sub TxtBanco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBanco.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtNumCuenta.Focus()
        End If
    End Sub
    Private Sub TxtNumCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumCuenta.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtNumCheque.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtNumCheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumCheque.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtReferencia.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtReferencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReferencia.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtSucursal.Focus()
        End If
    End Sub
    Private Sub TxtSaldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSaldo.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtSucursal.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtSucursal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSucursal.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.RbPesos.Focus()
        End If
    End Sub
    Private Sub RbDolares_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbDolares.CheckedChanged
        Me.TxtDomicilio.Focus()
    End Sub
    Private Sub TxtDomicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDomicilio.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.CbxCtaContable.Focus()
        End If
    End Sub
    Private Sub CbxCtaContable_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxCtaContable.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtTelefono.Focus()
        End If
    End Sub
    Private Sub TxtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.CbxEstatus.Focus()
        End If
    End Sub
    Private Sub lstBancos_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstBancos.MouseDoubleClick
        TxtCodigo.Text = lstBancos.SelectedItems(0).SubItems(0).Text
        cargadatos()
        Me.BtnEliminar.Enabled = True
        Me.btnModificar.Enabled = True
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTBancos
        frm.ShowDialog()
    End Sub
End Class