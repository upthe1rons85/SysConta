Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.ClsProveedores
Imports WindowsApplication1.clsTools
Public Class frmProveedores
    Shared Property disable As Boolean
    Private Sub frmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Perfil As String
        Perfil = "00-03-06"

        If Perfil Like "*" + Perfilesusuario + "*" Then

            Me.Text = "Mantenimiento Catálogo de Proveedores" + Space(10) + CStr(VersionCont())
            STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
            MaximizeBox = False
            CargaEstados()
            CargaCtasContables()
            CargaCbxTipoProv()
            CargaComboEstatus()
            CargaCtaAnticipo()
            llenalista()
            Me.TxtDiasCredito.Text = 0
            Me.TxtLimCredito.Text = 0
            'Me.CbxCuentaConta.DropDownStyle = ComboBoxStyle.DropDownList
        Else
            MsgBox("No tiene Derechos Sobre esta Opcion", vbCritical, "Sistema Contable")
            Me.Close()
        End If
    End Sub
    Private Sub llenalista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from Almacen.Dbo.CatProveedores(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "CatProveedores")
        Dim objListItem As New ListViewItem
        lstProveedor.Items.Clear()
        For Each drw As DataRow In ds.Tables("CatProveedores").Rows
            objListItem = lstProveedor.Items.Add(drw.Item("Codigo").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Proveedor").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub TxtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If TxtCodigo.Text <> "" Then
                cargadatos()
                BtnGrabar.Enabled = False
                BtnNuevo.Enabled = True
                btnModificar.Enabled = True
                BtnEliminar.Enabled = True
                DesCtaContable()
                DesCuenta2()
            Else
                TxtCodigo.Enabled = False
                TxtCodigo.Text = "0000"
                btnModificar.Enabled = True
                btnModificar.PerformClick()
                Limpiar()
                BtnGrabar.Enabled = True
                BtnNuevo.Enabled = True
                btnModificar.Enabled = False
                BtnEliminar.Enabled = False
            End If
        End If

        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        TxtCodigo.Enabled = False
        CbxCuentaConta.Enabled = True
        TxtProveedor.Enabled = True
        TxtDomicilio.Enabled = True
        CbxEstado.Enabled = True
        CbxCiudad.Enabled = True
        TxtRfc.Enabled = True
        TxtCp.Enabled = True
        TxtDiasCredito.Enabled = True
        TxtLimCredito.Enabled = True
        CbxEstatus.Enabled = True
        TxtBeneficiario.Enabled = True
        CbxTipoProv.Enabled = True
        TxtTelefono.Enabled = True
        CbxCtaAnticipo.Enabled = True
        TxtCuentaBan.Enabled = True
        TxtProveedor.Enabled = True
        TxtEmail.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        Gbx.Enabled = True
        TxtProveedor.Focus()
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Limpiar()
        Me.TxtCodigo.Enabled = True
        Me.TxtCodigo.Focus()
        Me.CbxCuentaConta.Enabled = False
        Me.TxtProveedor.Enabled = False
        Me.TxtDomicilio.Enabled = False
        Me.CbxEstado.Enabled = False
        Me.CbxCiudad.Enabled = False
        Me.TxtRfc.Enabled = False
        Me.TxtCp.Enabled = False
        Me.TxtDiasCredito.Enabled = False
        Me.TxtLimCredito.Enabled = False
        Me.CbxEstatus.Enabled = False
        Me.TxtBeneficiario.Enabled = False
        Me.CbxTipoProv.Enabled = False
        Me.TxtTelefono.Enabled = False
        Me.TxtCuentaBan.Enabled = False
        Me.TxtEmail.Enabled = False
        Me.BtnGrabar.Enabled = False
        Me.BtnNuevo.Enabled = False
        Me.BtnEliminar.Enabled = False
        Me.CbxCtaAnticipo.Enabled = False
        llenalista()
        CargaCtasContables()
        CargaCtaAnticipo()
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click

        If TxtProveedor.Text = "" Or CbxCuentaConta.Text = "              " Then
            MsgBox("EL Nombre del Proveedor y/o la Cuenta Contable No Pueden Quedar Vacios..!!!", vbInformation, "Sistema Contable")
            TxtProveedor.Focus()
        Else
            Try
                '---convierte a mayusculas el texto del proveedor y domicilio
                Me.TxtProveedor.Text = UCase(Me.TxtProveedor.Text)
                Me.TxtDomicilio.Text = UCase(Me.TxtDomicilio.Text)

                Dim nestatus As String = CbxEstatus.SelectedValue
                Dim ntipoproveedor As String = CbxTipoProv.SelectedValue

                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                Dim commandbus As New SqlCommand("sp_Validaproveedor", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure

                commandbus.Parameters.AddWithValue("@CODIGO", TxtCodigo.Text)

                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > "0" Then
                    Dim oclsProveedor = New ClsProveedores()
                    oclsProveedor.EliminaProveedor(TxtCodigo.Text)

                    If Me.TxtDiasCredito.Text = " " Then
                        Me.TxtDiasCredito.Text = 0
                    End If

                    Dim sXML = "<xProveedor>"
                    sXML += "<Codigo>" + Me.TxtCodigo.Text + "</Codigo>"
                    sXML += "<CuentaContable>" + Me.CbxCuentaConta.Text + "</CuentaContable>"
                    sXML += "<CuentaAnticipo>" + Me.CbxCtaAnticipo.Text + "</CuentaAnticipo>"
                    sXML += "<Proveedor>" + Me.TxtProveedor.Text + "</Proveedor>"
                    sXML += "<Domicilio>" + Me.TxtDomicilio.Text + "</Domicilio>"
                    sXML += "<Rfc>" + Me.TxtRfc.Text + "</Rfc>"
                    sXML += "<Estado>" + Me.CbxEstado.Text + "</Estado>"
                    sXML += "<Ciudad>" + Me.CbxCiudad.Text + "</Ciudad>"
                    sXML += "<Cp>" + Me.TxtCp.Text + "</Cp>"
                    sXML += "<Telefono>" + Me.TxtTelefono.Text + "</Telefono>"
                    sXML += "<Estatus>" + nestatus + "</Estatus>"
                    sXML += "<DiasCredito>" + Me.TxtDiasCredito.Text + "</DiasCredito>"
                    sXML += "<LimiteCredito>" + Me.TxtLimCredito.Text + "</LimiteCredito>"
                    sXML += "<IdGiroComercial>" + ntipoproveedor + "</IdGiroComercial>"
                    sXML += "<Beneficiario>" + Me.TxtBeneficiario.Text + "</Beneficiario>"
                    sXML += "<CuentaBancaria>" + Me.TxtCuentaBan.Text + "</CuentaBancaria>"
                    sXML += "<Email>" + Me.TxtEmail.Text + "</Email>"
                    sXML += "</xProveedor>"

                    Dim xclsProveedor = New ClsProveedores()
                    xclsProveedor.InsertaProveedor(sXML)

                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Contable")
                    Limpiar()
                    llenalista()

                Else

                    Dim wQuery As String = ""
                    Dim LocalCommand As SqlCommand
                    Dim wCodigo As String
                    wQuery = "SELECT MAX(folioproveedor)+1 FROM Almacen.dbo.parametros (NOLOCK)"

                    LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                    LocalCommand.CommandType = Data.CommandType.Text
                    wCodigo = LocalCommand.ExecuteScalar()
                    If wCodigo IsNot Nothing Then
                        'MsgBox("Se Genero Consecutivo de Folio Proveedor Correctamente", vbInformation, "Sistema Contable")
                    Else
                        MsgBox("No Se Genero Consecutivo de Folio Proveedor", vbInformation, "Sistema Contable")
                    End If
                    LocalCommand.Dispose()


                    Dim xfoliador = New ClsProveedores()
                    xfoliador.AdelantaFolioprov(wCodigo)

                    '---convierte a mayusculas el texto del proveedor y domicilio
                    Me.TxtProveedor.Text = UCase(Me.TxtProveedor.Text)
                    Me.TxtDomicilio.Text = UCase(Me.TxtDomicilio.Text)

                    Dim sXML = "<xProveedor>"
                    sXML += "<Codigo>" + wCodigo + "</Codigo>"
                    sXML += "<CuentaContable>" + Me.CbxCuentaConta.Text + "</CuentaContable>"
                    sXML += "<CuentaAnticipo>" + Me.CbxCtaAnticipo.Text + "</CuentaAnticipo>"
                    sXML += "<Proveedor>" + Me.TxtProveedor.Text + "</Proveedor>"
                    sXML += "<Domicilio>" + Me.TxtDomicilio.Text + "</Domicilio>"
                    sXML += "<Rfc>" + Me.TxtRfc.Text + "</Rfc>"
                    sXML += "<Estado>" + Me.CbxEstado.Text + "</Estado>"
                    sXML += "<Ciudad>" + Me.CbxCiudad.Text + "</Ciudad>"
                    sXML += "<Cp>" + Me.TxtCp.Text + "</Cp>"
                    sXML += "<Telefono>" + Me.TxtTelefono.Text + "</Telefono>"
                    sXML += "<Estatus>" + nestatus + "</Estatus>"
                    sXML += "<DiasCredito>" + Me.TxtDiasCredito.Text + "</DiasCredito>"
                    sXML += "<LimiteCredito>" + Me.TxtLimCredito.Text + "</LimiteCredito>"
                    sXML += "<IdGiroComercial>" + ntipoproveedor + "</IdGiroComercial>"
                    sXML += "<Beneficiario>" + Me.TxtBeneficiario.Text + "</Beneficiario>"
                    sXML += "<CuentaBancaria>" + Me.TxtCuentaBan.Text + "</CuentaBancaria>"
                    sXML += "<Email>" + Me.TxtEmail.Text + "</Email>"
                    sXML += "</xProveedor>"

                    Dim oclsProveedor = New ClsProveedores()
                    oclsProveedor.InsertaProveedor(sXML)

                    MsgBox("Registrado Correctamente, Codigo de Proveedor " + wCodigo, vbInformation, "Sistema Contable")
                    Limpiar()
                    llenalista()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
            End Try
            Me.TxtCodigo.Enabled = True
            Me.CbxCuentaConta.Enabled = False
            Me.TxtProveedor.Enabled = False
            Me.TxtDomicilio.Enabled = False
            Me.CbxEstado.Enabled = False
            Me.CbxCiudad.Enabled = False
            Me.TxtRfc.Enabled = False
            Me.TxtCp.Enabled = False
            Me.TxtDiasCredito.Enabled = False
            Me.TxtLimCredito.Enabled = False
            Me.CbxEstatus.Enabled = False
            Me.TxtBeneficiario.Enabled = False
            Me.CbxTipoProv.Enabled = False
            Me.TxtTelefono.Enabled = False
            Me.TxtCuentaBan.Enabled = False
            Me.TxtEmail.Enabled = False
            Me.BtnGrabar.Enabled = False
            Me.BtnNuevo.Enabled = False
            Me.BtnEliminar.Enabled = False
            Me.CbxCtaAnticipo.Enabled = False
            Me.CbxCtaAnticipo.Text = ""
            Me.CbxCtaAnticipo.Enabled = False
            Limpiar()
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If TxtCodigo.Text = "" Or CbxCuentaConta.Text = "" Then
            MsgBox("Debe capturar un Codigo de Proveedor", vbInformation, "Sistema Contable")
            TxtCodigo.Focus()

        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsProveedor = New ClsProveedores()
                oclsProveedor.EliminaProveedor(TxtCodigo.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
                Limpiar()
                llenalista()
                BtnGrabar.Enabled = False
                BtnNuevo.Enabled = False
                btnModificar.Enabled = True
                BtnEliminar.Enabled = True
                TxtCodigo.Focus()
            End If
        End If
    End Sub
    Private Sub CargaEstados()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select * from catEstados(nolock) order by CodigoEdo"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxEstado.ValueMember = "Estado"
        CbxEstado.DisplayMember = "Estado"
        CbxEstado.DataSource = dt
    End Sub
    Private Sub CbxEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxEstado.SelectedIndexChanged
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta2 As String = "Select municipio from catmunicipios where codestado = '" & CbxEstado.Text & "'"
        Dim cmd As New SqlCommand(consulta2, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da2 As New SqlDataAdapter(cmd)
        Dim dt2 As New DataTable

        da2.Fill(dt2)

        CbxCiudad.ValueMember = "Municipio"
        CbxCiudad.DisplayMember = "Municipio"
        CbxCiudad.DataSource = dt2
    End Sub
    Private Sub cargadatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()
        Dim oclsProveedores = New ClsProveedores()
        Dim dr As SqlDataReader

        dr = oclsProveedores.SeleccionaProveedores(Me.TxtCodigo.Text)

        If dr.Read() Then
            TxtProveedor.Text = dr("Proveedor").ToString()
            Me.CbxCuentaConta.Text = dr("CuentaContable").ToString()
            Me.CbxCtaAnticipo.Text = dr("CuentaAnticipo").ToString()
            TxtDomicilio.Text = dr("Domicilio").ToString()
            CbxEstado.Text = dr("Estado").ToString()
            CbxCiudad.Text = dr("Ciudad").ToString()
            TxtRfc.Text = dr("Rfc").ToString()
            TxtCp.Text = dr("Cp").ToString()
            CbxEstatus.Text = dr("Estatus").ToString()
            TxtDiasCredito.Text = dr("DiasCredito").ToString()
            TxtLimCredito.Text = dr("LimiteCredito").ToString()
            CbxTipoProv.Text = dr("IdGiroComercial").ToString()
            TxtBeneficiario.Text = dr("Beneficiario").ToString()
            TxtTelefono.Text = dr("Telefono").ToString()
            TxtCuentaBan.Text = dr("CuentaBancaria").ToString()
            TxtEmail.Text = dr("Email").ToString()
            CargaCtaContablexProveedor()
            CargaCtaAnticipoxProveedor()
            DesCtaContable2()
            DesCuenta2()
        Else
            MsgBox("Codigo de Proveedor no encontrado...", MessageBoxIcon.Error)
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
            Me.TxtCodigo.SelectAll()
        End If
    End Sub
    Private Sub TxtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBuscar.GotFocus
        TxtBuscar.Text = ""
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        TxtBuscar.ForeColor = Color.Black
    End Sub
    Private Sub TxtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsClientes = New ClsProveedores()
        dr = oclsClientes.BuscaNombreProveedor(Me.TxtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        lstProveedor.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("Codigo").ToString)
            lstLista.SubItems.Add(rRow("Proveedor").ToString)
            lstProveedor.Items.Add(lstLista)
        Next
    End Sub
    Private Sub CargaComboEstatus()
        Dim conn = New SqlConnection()
        Dim clsDB = New clsBD()
        conn = clsDB.CreaConexion()

        Dim consulta As String = "Select EstatusProveedor,Descripcion From Almacen.dbo.CatEstatusProveedor(nolock)"
        Dim cmd As New SqlCommand(consulta, conn)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxEstatus.ValueMember = "EstatusProveedor"
        CbxEstatus.DisplayMember = "Descripcion"
        CbxEstatus.DataSource = dt
    End Sub
    Private Sub CargaCtasContables()
        Dim conn = New SqlConnection()
        Dim clsDB = New clsBD()
        conn = clsDB.CreaConexion()

        Dim consulta As String = "DECLARE @TablaCtaContable TABLE ([Cuenta] nchar(14));insert into @TablaCtaContable values (' ');insert into @TablaCtaContable Select Cuenta from Contabilidad.dbo.CatCuentas(nolock) where cuenta like '2100160%' and cuenta not in(Select CuentaContable from almacen.dbo.catproveedores(nolock)) Order by Cuenta;Select Cuenta from @TablaCtaContable "
        Dim cmd As New SqlCommand(consulta, conn)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxCuentaConta.ValueMember = "Cuenta"
        CbxCuentaConta.DisplayMember = "Cuenta"
        CbxCuentaConta.DataSource = dt

    End Sub
    Private Sub CargaCbxTipoProv()
        Dim conn = New SqlConnection()
        Dim clsDB = New clsBD()
        conn = clsDB.CreaConexion()

        Dim consulta As String = "Select IdGiroComercial,Descripcion From [Almacen].[dbo].[CatGiroProveedor](nolock)"
        Dim cmd As New SqlCommand(consulta, conn)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxTipoProv.ValueMember = "IdGiroComercial"
        CbxTipoProv.DisplayMember = "Descripcion"
        CbxTipoProv.DataSource = dt
    End Sub
    Sub Limpiar()
        Me.TxtCodigo.Focus()
        Me.TxtCodigo.Clear()
        Me.TxtProveedor.Clear()
        Me.TxtDomicilio.Clear()
        Me.TxtCp.Clear()
        Me.TxtRfc.Clear()
        Me.TxtDiasCredito.Clear()
        Me.TxtLimCredito.Clear()
        Me.TxtBeneficiario.Clear()
        Me.TxtTelefono.Clear()
        Me.TxtCuentaBan.Clear()
        Me.TxtEmail.Clear()
        CargaEstados()
        CargaCtasContables()
        CargaCbxTipoProv()
        CargaComboEstatus()
        Me.LblCuenta.Text = ""
        Me.TxtDiasCredito.Text = 0
        Me.TxtLimCredito.Text = 0
    End Sub
    Private Sub TxtProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            CbxCuentaConta.Focus()
        End If
    End Sub
    Private Sub CbxCuentaConta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtDomicilio.Focus()
        End If
    End Sub
    Private Sub TxtDomicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDomicilio.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            CbxEstado.Focus()
        End If
    End Sub
    Private Sub CbxEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxEstado.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            CbxCiudad.Focus()
        End If
    End Sub
    Private Sub CbxCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxCiudad.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtRfc.Focus()
        End If
    End Sub
    Private Sub TxtRfc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRfc.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtCp.Focus()
        End If
    End Sub
    Private Sub TxtCp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCp.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtDiasCredito.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtDiasCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiasCredito.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtLimCredito.Focus()
        End If
    End Sub
    Private Sub TxtLimCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLimCredito.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            CbxEstatus.Focus()
        End If
    End Sub
    Private Sub CbxEstatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxEstatus.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtBeneficiario.Focus()
        End If
    End Sub
    Private Sub TxtBeneficiario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBeneficiario.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            CbxTipoProv.Focus()
        End If
    End Sub
    Private Sub CbxTipoProv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxTipoProv.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtTelefono.Focus()
        End If
    End Sub
    Private Sub TxtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtCuentaBan.Focus()
        End If
    End Sub
    Private Sub TxtCuentaBan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCuentaBan.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            TxtEmail.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmail.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            BtnGrabar.Focus()
        End If
    End Sub
    Private Sub CbxCuentaConta_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If CbxCuentaConta.Text = "Seleccione Cuenta" Then
            MsgBox("Seleccione Una Cuenta Contable.", MessageBoxIcon.Error)
            Me.CbxCuentaConta.Focus()
        Else


            Dim pclsProveedores = New ClsProveedores()
            Dim dr As SqlDataReader

            dr = pclsProveedores.ValidaCtaProv(Me.CbxCuentaConta.SelectedValue)

            If dr.Read() Then
                MsgBox("Cuenta Ya Asignada a otro Proveedor, favor de Revisar...", MessageBoxIcon.Error)
                Me.CbxCuentaConta.Focus()
            Else
                Me.TxtDomicilio.Focus()
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTInformeProveedores()
        frm.codigo = Val(TxtCodigo.Text)
        frm.Show()
    End Sub
    Private Sub lstProveedor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstProveedor.MouseDoubleClick
        TxtCodigo.Text = lstProveedor.SelectedItems(0).SubItems(0).Text
        cargadatos()
        Me.btnModificar.Enabled = True
    End Sub
    Sub CargaCtaAnticipo()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "DECLARE @TablaCtaAnti TABLE ([Cuenta] nchar(14));insert into @TablaCtaAnti values (' ');insert into @TablaCtaAnti Select Cuenta from Contabilidad.dbo.CatCuentas(nolock) where cuenta like '1100370%' and cuenta not in(Select CuentaAnticipo from almacen.dbo.catproveedores(nolock)) Order by Cuenta;Select Cuenta from @TablaCtaAnti "
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        Me.CbxCtaAnticipo.ValueMember = "Cuenta"
        Me.CbxCtaAnticipo.DisplayMember = "Cuenta"
        Me.CbxCtaAnticipo.DataSource = dt
    End Sub
    Sub CargaCtaAnticipoxProveedor()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "DECLARE @CtaAntiProveedor nchar(14);Set @CtaAntiProveedor=(Select CuentaAnticipo from almacen.dbo.catproveedores(nolock) where codigo='" & Me.TxtCodigo.Text & "');DECLARE @TablaCtaAnti TABLE ([Cuenta] nchar(14));insert into @TablaCtaAnti values (''+@CtaAntiProveedor+''); insert into @TablaCtaAnti values (' ');insert into @TablaCtaAnti Select Cuenta from Contabilidad.dbo.CatCuentas(nolock)where cuenta like '1100370%' and cuenta not in (Select CuentaAnticipo from almacen.dbo.catproveedores(nolock)) Order by Cuenta ;Select Cuenta from @TablaCtaAnti"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        Me.CbxCtaAnticipo.ValueMember = "Cuenta"
        Me.CbxCtaAnticipo.DisplayMember = "Cuenta"
        Me.CbxCtaAnticipo.DataSource = dt
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Sub CargaCtaContablexProveedor()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "DECLARE @CtaContaProveedor nchar(14);Set @CtaContaProveedor=(Select CuentaContable from almacen.dbo.catproveedores(nolock) where codigo='" & Me.TxtCodigo.Text & "');DECLARE @TablaCtaContable TABLE ([Cuenta] nchar(14));insert into @TablaCtaContable values (''+@CtaContaProveedor+''); insert into @TablaCtaContable values (' ');insert into @TablaCtaContable Select Cuenta from Contabilidad.dbo.CatCuentas(nolock)where cuenta like '2100160%' and cuenta not in (Select CuentaContable from almacen.dbo.catproveedores(nolock)) Order by Cuenta ;Select Cuenta from @TablaCtaContable"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        Me.CbxCuentaConta.ValueMember = "Cuenta"
        Me.CbxCuentaConta.DisplayMember = "Cuenta"
        Me.CbxCuentaConta.DataSource = dt
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub CbxCuentaConta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxCuentaConta.SelectedIndexChanged
        DesCtaContable()
    End Sub
    Private Sub CbxCtaAnticipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxCtaAnticipo.SelectedIndexChanged
        DesCuenta()
    End Sub
    Private Sub DesCtaContable()
        'carga la descripcion de la cuenta contable en LblCtaContable
        Dim xclsProducto = New ClsProveedores()
        Dim dr As SqlDataReader
        'se usara la misma clase que llena la cuenta descripcion de la cuenta de anticipo ya que solo va al catalogo de cuentas por 
        'la descripcion de la cuenta
        dr = xclsProducto.SelCtaAnticipo(Me.CbxCuentaConta.SelectedValue)

        If dr.Read() Then

            Me.LblCtaContable.Text = RTrim(dr("Descripcion").ToString())
        End If
    End Sub
    Private Sub DesCtaContable2()
        'carga la descripcion de la cuenta contable en LblCtaContable
        Dim xclsProducto = New ClsProveedores()
        Dim dr As SqlDataReader
        'es el mismo sub que cuando carga el combo de la cuenta contable que sirve para llenar el lblctaconta pero este es para cuando 
        'consultas un proveedor por eso el parametro es cbxcuentaconta.text y no el selectedvalue
        dr = xclsProducto.SelCtaAnticipo(Me.CbxCuentaConta.Text)

        If dr.Read() Then

            Me.LblCtaContable.Text = RTrim(dr("Descripcion").ToString())
        End If
    End Sub
    Private Sub DesCuenta()
        'carga la descripcion de la cuenta de anticipo en lblCuenta
        Dim xclsProducto = New ClsProveedores()
        Dim dr As SqlDataReader

        dr = xclsProducto.SelCtaAnticipo(Me.CbxCtaAnticipo.SelectedValue)

        If dr.Read() Then

            Me.LblCuenta.Text = RTrim(dr("Descripcion").ToString())
        End If
    End Sub
    Private Sub DesCuenta2()
        'carga la descripcion de la cuenta de anticipo en lblCuenta
        Dim clsCtaAntiProv = New ClsProveedores()
        Dim dr As SqlDataReader

        dr = clsCtaAntiProv.SelCtaAnticipo(Me.CbxCtaAnticipo.Text)

        If dr.Read() Then

            Me.LblCuenta.Text = RTrim(dr("Descripcion").ToString())
        End If
    End Sub
End Class