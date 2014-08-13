Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.ClsClientes
Imports WindowsApplication1.clsTools
Public Class FrmClientes
    Dim xFecha As Date = Now
    Dim fechaAlta As String = Format(xFecha, "M/d/yyyy H:mm")
    Dim fechaAlta2 As Date
    Dim nEstado As String
    Dim nCiudad As String
    Dim nEstatus As String
    Dim nFormaPago As String
    Dim nCuentaConta As String
    Dim RbValor As String
    Private Sub FrmClientes_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Catálogo de Clientes" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        CargaCombo()
        CargaCombo2()
        cargacombo3()
        CargaCombo4()
        Cargalst()
        RbContado.Checked = True
        RbCredito.Checked = False
        TxtCodigoClie.Focus()
        Me.MaximizeBox = False
    End Sub
    Private Sub cargadatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()
        Dim oclsCliente = New ClsClientes()
        Dim dr As SqlDataReader

        dr = oclsCliente.SeleccionaClientes(Me.TxtCodigoClie.Text)

        If dr.Read() Then
            'Regresara la conversion de los datos numericos a String(Descripcion) de los sig. 4 campos de la tabla CatClientes()
            nEstado = dr("Estado").ToString()
            nCiudad = dr("Ciudad").ToString()
            nEstatus = dr("Estatus").ToString()
            nFormaPago = dr("FormaPago").ToString()

            Dim dr2 As SqlDataReader
            Dim oclsClientes = New ClsClientes()

            dr2 = oclsClientes.RegresaDatosClie(nEstado, nCiudad)
            If dr2.Read Then
                nEstado = dr2("Estado").ToString()
                nCiudad = dr2("Municipio").ToString()
            End If

            Dim dr3 As SqlDataReader
            Dim pclsClientes = New ClsClientes()

            dr3 = pclsClientes.RegresaEstatusCli(nEstatus)
            If dr3.Read Then
                nEstatus = dr3("Descripcion").ToString()
            End If

            Dim dr4 As SqlDataReader
            Dim qclsClientes = New ClsClientes()

            dr4 = qclsClientes.RegresaFormaPago(nFormaPago)
            If dr4.Read Then
                nFormaPago = dr4("Descripcion").ToString()
            End If

            'carga el check en el Radio Button
            RbValor = dr("TipoCliente").ToString()
            If RbValor = 0 Then
                RbContado.Checked = True
                RbCredito.Checked = False
            Else
                RbContado.Checked = False
                RbCredito.Checked = True
            End If
            TxtRazonSoc.Text = dr("RazonSocial").ToString()
            TxtCalle.Text = dr("Calle").ToString()
            TxtNumero.Text = dr("Numero").ToString()
            TxtColonia.Text = dr("Colonia").ToString()
            TxtTelefono.Text = dr("Telefono").ToString()
            TxtContacto.Text = dr("Contacto").ToString()
            CbxEstado.Text = nEstado
            CbxCiudad.Text = nCiudad
            CbxPais.Text = dr("Pais").ToString()
            TxtRfc.Text = dr("Rfc").ToString()
            fechaAlta2 = (dr("FechaAlta").ToString())
            TxtLimiteCre.Text = dr("LimiteCredito").ToString()
            TxtDiasCredito.Text = dr("DiasCredito").ToString()
            TxtDiasColch.Text = dr("DiasColchon").ToString()
            TxtDiasCobra.Text = dr("DiasCobranza").ToString()
            TxtVendedor.Text = dr("Vendedor").ToString()
            TxtRuta.Text = dr("Ruta").ToString()
            TxtDomFiscal.Text = dr("DomicilioFiscal").ToString()
            CbxEstatus.Text = nEstatus
            TxtSucursal.Text = dr("Sucursal").ToString()
            TxtDomentrega.Text = dr("DomicilioEntrega").ToString()
            TxtBanco.Text = dr("Banco").ToString()
            CbxCuentaConta.Text = dr("CuentaContable").ToString()
            CbxCuentaAnti.Text = dr("CuentaAnticipo").ToString()
            CbxCuentaDlls.Text = dr("CuentaDolares").ToString()
            CbxFormaPago.Text = nFormaPago
            TxtDomFiscal.Text = dr("DomicilioFiscal").ToString()
            TxtEmail.Text = dr("Email").ToString()
        Else

            MsgBox("Codigo de Cliente no encontrado...", MessageBoxIcon.Error)
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            btnModificar.Enabled = False
            BtnEliminar.Enabled = False
        End If
    End Sub
    Private Sub CargaCombo()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim ConEstados As String = "Select CodigoEdo,Estado from catEstados(nolock) order by codigoedo"
        Dim cmd As New SqlCommand(ConEstados, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxEstado.ValueMember = "CodigoEdo"
        CbxEstado.DisplayMember = "Estado"
        CbxEstado.DataSource = dt
    End Sub
    Private Sub CargaCombo2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select EstatusCliente,Descripcion from Comercial.dbo.CatEstatusCliente(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxEstatus.ValueMember = "EstatusCliente"
        CbxEstatus.DisplayMember = "Descripcion"
        'CbxEstatus.Text = "Seleccione un Nombre..."
        CbxEstatus.DataSource = dt
    End Sub
    Private Sub cargacombo3()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select formaPago,Descripcion from comercial.dbo.CATFORMAPAGO(nolock) "
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxFormaPago.ValueMember = "FormaPago"
        CbxFormaPago.DisplayMember = "Descripcion"
        CbxFormaPago.DataSource = dt
    End Sub
    Private Sub CargaCombo4()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select cuenta from catcuentas(nolock) order by cuenta"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxCuentaConta.ValueMember = "Cuenta"
        CbxCuentaConta.DisplayMember = "Cuenta"
        CbxCuentaConta.DataSource = dt

    End Sub
    Private Sub CargaCombo5()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "Select * From [Contabilidad].[DBO].[CatCuentas](nolock) Where Descripcion like '%Anticipo%' Order by Cuenta"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxCuentaAnti.ValueMember = "Cuenta"
        CbxCuentaAnti.DisplayMember = "Cuenta"
        CbxCuentaAnti.DataSource = dt
    End Sub
    Private Sub CargaCombo6()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select * from [Contabilidad].[DBO].[CatCuentas](nolock) Where Descripcion like '%dola%' Order by Cuenta"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        CbxCuentaDlls.ValueMember = "Cuenta"
        CbxCuentaDlls.DisplayMember = "Cuenta"
        CbxCuentaDlls.DataSource = dt
    End Sub
    Private Sub Cargalst()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "select * from [Comercial].[DBO].[catClientesDoc](nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "catClientesDoc")


        Dim objListItem As New ListViewItem
        Me.lstTipoDoc.Items.Clear()

        For Each drw As DataRow In ds.Tables("catClientesDoc").Rows
            objListItem = lstTipoDoc.Items.Add(drw.Item("CodigoCliente").ToString, 0)
            objListItem.SubItems.Add(drw.Item("CodigoDocumento").ToString)
            objListItem.SubItems.Add(drw.Item("Valor").ToString)
            objListItem.SubItems.Add(drw.Item("Observaciones").ToString)
        Next

    End Sub
    Private Sub TxtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigoClie.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If TxtCodigoClie.Text <> "" Then
                cargadatos()
                BtnGrabar.Enabled = False
                BtnNuevo.Enabled = False
                btnModificar.Enabled = True
                BtnEliminar.Enabled = True
            Else
                Me.TxtCodigoClie.Enabled = False
                Me.TxtCodigoClie.Text = "0000"
                Me.btnModificar.Enabled = True
                Me.btnModificar.PerformClick()
                Me.BtnGrabar.Enabled = True
                Me.BtnNuevo.Enabled = True
                Me.btnModificar.Enabled = False
                Me.BtnEliminar.Enabled = False
                Me.TxtRazonSoc.Enabled = True
                Me.TxtCalle.Enabled = True
                Me.TxtNumero.Enabled = True
                Me.TxtColonia.Enabled = True
                Me.TxtTelefono.Enabled = True
                Me.TxtContacto.Enabled = True
                Me.CbxEstado.Enabled = True
                Me.CbxCiudad.Enabled = True
                Me.CbxPais.Enabled = True
                Me.TxtRfc.Enabled = True
                Me.TxtLimiteCre.Enabled = True
                Me.TxtDiasCredito.Enabled = True
                Me.TxtDiasColch.Enabled = True
                Me.TxtDiasCobra.Enabled = True
                Me.TxtVendedor.Enabled = True
                Me.RbContado.Enabled = True
                Me.RbCredito.Enabled = False
                Me.TxtRuta.Enabled = True
                Me.TxtDomFiscal.Enabled = True
                Me.CbxEstatus.Enabled = True
                Me.TxtSucursal.Enabled = True
                Me.TxtDomentrega.Enabled = True
                Me.TxtBanco.Enabled = True
                Me.CbxCuentaConta.Enabled = True
                Me.CkbCtaAnti.Enabled = True
                Me.CkbCtaDlls.Enabled = True
                Me.TxtDomFiscal.Enabled = True
                Me.TxtEmail.Enabled = True
                Me.BtnGrabar.Enabled = True
                Me.BtnNuevo.Enabled = False
                Me.btnModificar.Enabled = False
                Me.BtnEliminar.Enabled = False
                limpiar()
                Me.TxtRazonSoc.Focus()
            End If
            If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
            End If
        End If
    End Sub
    Private Sub CbxEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxEstado.SelectedIndexChanged
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta2 As String = "Select codigoMun,municipio from catmunicipios where codestado = '" & CbxEstado.Text & "'"
        Dim cmd As New SqlCommand(consulta2, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da2 As New SqlDataAdapter(cmd)
        Dim dt2 As New DataTable

        da2.Fill(dt2)

        CbxCiudad.ValueMember = "CodigoMun"
        CbxCiudad.DisplayMember = "Municipio"
        CbxCiudad.DataSource = dt2
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiar()
        Me.TxtCodigoClie.Enabled = False
        Me.TxtCodigoClie.Text = "0000"
        Me.TxtRazonSoc.Enabled = True
        Me.TxtCalle.Enabled = True
        Me.TxtNumero.Enabled = True
        Me.TxtColonia.Enabled = True
        Me.TxtTelefono.Enabled = True
        Me.TxtContacto.Enabled = True
        Me.CbxEstado.Enabled = True
        Me.CbxCiudad.Enabled = True
        Me.CbxPais.Enabled = True
        Me.TxtRfc.Enabled = True
        Me.TxtLimiteCre.Enabled = True
        Me.TxtDiasCredito.Enabled = True
        Me.TxtDiasColch.Enabled = True
        Me.TxtDiasCobra.Enabled = True
        Me.TxtVendedor.Enabled = True
        Me.RbContado.Enabled = True
        Me.RbCredito.Enabled = True
        Me.TxtRuta.Enabled = True
        Me.TxtDomFiscal.Enabled = True
        Me.CbxEstatus.Enabled = True
        Me.TxtSucursal.Enabled = True
        Me.TxtDomentrega.Enabled = True
        Me.TxtBanco.Enabled = True
        Me.CbxCuentaConta.Enabled = True
        Me.CkbCtaAnti.Enabled = True
        Me.CkbCtaDlls.Enabled = True
        Me.CbxFormaPago.Enabled = True
        Me.TxtDomFiscal.Enabled = True
        Me.TxtEmail.Enabled = True
        Me.BtnGrabar.Enabled = True
        Me.BtnNuevo.Enabled = True
        Me.btnModificar.Enabled = False
        Me.BtnEliminar.Enabled = False
        Me.TxtRazonSoc.Focus()
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If TxtRazonSoc.Text = "" Or TxtCalle.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Contable")
            TxtRazonSoc.Focus()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()

                Dim commandbus As New SqlCommand("sp_ValidaCliente", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure

                commandbus.Parameters.AddWithValue("@CodigoCliente", TxtCodigoClie.Text)

                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > "0" Then

                    Dim oclsCliente = New ClsClientes()
                    oclsCliente.EliminaCliente(TxtCodigoClie.Text)

                    nEstado = CbxEstado.SelectedValue
                    nCiudad = CbxCiudad.SelectedValue
                    nEstatus = CbxEstatus.SelectedValue
                    nFormaPago = CbxFormaPago.SelectedValue



                    'asignar valor a radio Buttom para pasar a base de datos
                    If Me.RbContado.Checked Then
                        RbValor = 0
                    End If
                    If Me.RbCredito.Checked Then
                        RbValor = 1
                    End If

                    Dim sXML = "<xCliente>"
                    sXML += "<CodigoCliente>" + Me.TxtCodigoClie.Text + "</CodigoCliente>"
                    sXML += "<RazonSocial>" + Me.TxtRazonSoc.Text + "</RazonSocial>"
                    sXML += "<Calle>" + Me.TxtCalle.Text + "</Calle>"
                    sXML += "<Numero>" + Me.TxtNumero.Text + "</Numero>"
                    sXML += "<Colonia>" + Me.TxtColonia.Text + "</Colonia >"
                    sXML += "<Telefono>" + Me.TxtTelefono.Text + "</Telefono>"
                    sXML += "<Contacto>" + Me.TxtContacto.Text + "</Contacto>"
                    sXML += "<Estado>" + nEstado + "</Estado>"
                    sXML += "<Ciudad>" + nCiudad + "</Ciudad>"
                    sXML += "<Pais>" + Me.CbxPais.Text + "</Pais>"
                    sXML += "<Rfc>" + Me.TxtRfc.Text + "</Rfc>"
                    sXML += "<LimiteCredito>" + Me.TxtLimiteCre.Text + "</LimiteCredito>"
                    sXML += "<DiasCredito>" + Me.TxtDiasCredito.Text + "</DiasCredito>"
                    sXML += "<DiasColchon>" + Me.TxtDiasColch.Text + "</DiasColchon>"
                    sXML += "<DiasCobranza>" + Me.TxtDiasCobra.Text + "</DiasCobranza>"
                    sXML += "<Vendedor>" + Me.TxtVendedor.Text + "</Vendedor>"
                    sXML += "<TipoCliente>" + RbValor + "</TipoCliente>"
                    sXML += "<Ruta>" + Me.TxtRuta.Text + "</Ruta>"
                    sXML += "<DomicilioFiscal>" + Me.TxtDomFiscal.Text + "</DomicilioFiscal>"
                    sXML += "<FechaAlta>" + Format(fechaAlta2, "M/d/yyyy H:mm") + "</FechaAlta>"
                    sXML += "<UsuarioModifico>" + LoginUsuario + "</UsuarioModifico>"
                    sXML += "<Estatus>" + nEstatus + "</Estatus>"
                    sXML += "<Sucursal>" + Me.TxtSucursal.Text + "</Sucursal>"
                    sXML += "<DomicilioEntrega>" + Me.TxtDomentrega.Text + "</DomicilioEntrega>"
                    sXML += "<Banco>" + Me.TxtBanco.Text + "</Banco>"
                    sXML += "<CuentaContable>" + Me.CbxCuentaConta.Text + "</CuentaContable>"
                    sXML += "<CuentaAnticipo>" + Me.CbxCuentaAnti.Text + "</CuentaAnticipo>"
                    sXML += "<CuentaDolares>" + Me.CbxCuentaDlls.Text + "</CuentaDolares>"
                    sXML += "<formapago>" + nFormaPago + "</formapago>"
                    sXML += "<Email>" + Me.TxtEmail.Text + "</Email>"
                    sXML += "</xCliente>"

                    Dim xclsCliente = New ClsClientes()
                    xclsCliente.InsertaCliente(sXML)

                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Contable")
                    'limpiar()
                Else
                    nEstado = CbxEstado.SelectedValue
                    nCiudad = CbxCiudad.SelectedValue
                    nEstatus = CbxEstatus.SelectedValue
                    nFormaPago = CbxFormaPago.SelectedValue

                    Dim wQuery As String = ""
                    Dim LocalCommand As SqlCommand
                    Dim wCodigo As String
                    wQuery = "SELECT MAX(foliocliente)+1 FROM comercial.dbo.parametros (NOLOCK)"

                    LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                    LocalCommand.CommandType = Data.CommandType.Text
                    wCodigo = LocalCommand.ExecuteScalar()
                    If wCodigo IsNot Nothing Then
                        'MsgBox("Se Genero Consecutivo de Folio Proveedor Correctamente", vbInformation, "Sistema Contable")
                    Else
                        MsgBox("No Se Genero Consecutivo de Folio Cliente", vbInformation, "Sistema Contable")
                    End If
                    LocalCommand.Dispose()

                    Dim xfolio = New ClsClientes()
                    xfolio.AdelantaFolioclie(wCodigo)

                    'asignar valor a radio Buttom para pasar a base de datos
                    If Me.RbContado.Checked Then
                        RbValor = 0
                    End If
                    If Me.RbCredito.Checked Then
                        RbValor = 1
                    End If

                    Dim sXML = "<xCliente>"
                    sXML += "<CodigoCliente>" + wCodigo + "</CodigoCliente>"
                    sXML += "<RazonSocial>" + Me.TxtRazonSoc.Text + "</RazonSocial>"
                    sXML += "<Calle>" + Me.TxtCalle.Text + "</Calle>"
                    sXML += "<Numero>" + Me.TxtNumero.Text + "</Numero>"
                    sXML += "<Colonia>" + Me.TxtColonia.Text + "</Colonia >"
                    sXML += "<Telefono>" + Me.TxtTelefono.Text + "</Telefono>"
                    sXML += "<Contacto>" + Me.TxtContacto.Text + "</Contacto>"
                    sXML += "<Estado>" + nEstado + "</Estado>"
                    sXML += "<Ciudad>" + nCiudad + "</Ciudad>"
                    sXML += "<Pais>" + Me.CbxPais.Text + "</Pais>"
                    sXML += "<Rfc>" + Me.TxtRfc.Text + "</Rfc>"
                    sXML += "<LimiteCredito>" + Me.TxtLimiteCre.Text + "</LimiteCredito>"
                    sXML += "<DiasCredito>" + Me.TxtDiasCredito.Text + "</DiasCredito>"
                    sXML += "<DiasColchon>" + Me.TxtDiasColch.Text + "</DiasColchon>"
                    sXML += "<DiasCobranza>" + Me.TxtDiasCobra.Text + "</DiasCobranza>"
                    sXML += "<Vendedor>" + Me.TxtVendedor.Text + "</Vendedor>"
                    sXML += "<TipoCliente>" + RbValor + "</TipoCliente>"
                    sXML += "<Ruta>" + Me.TxtRuta.Text + "</Ruta>"
                    sXML += "<DomicilioFiscal>" + Me.TxtDomFiscal.Text + "</DomicilioFiscal>"
                    sXML += "<FechaAlta>" + fechaAlta + "</FechaAlta>"
                    sXML += "<UsuarioModifico>" + LoginUsuario + "</UsuarioModifico>"
                    sXML += "<Estatus>" + nEstatus + "</Estatus>"
                    sXML += "<Sucursal>" + Me.TxtSucursal.Text + "</Sucursal>"
                    sXML += "<DomicilioEntrega>" + Me.TxtDomentrega.Text + "</DomicilioEntrega>"
                    sXML += "<Banco>" + Me.TxtBanco.Text + "</Banco>"
                    sXML += "<CuentaContable>" + Me.CbxCuentaConta.Text + "</CuentaContable>"
                    sXML += "<CuentaAnticipo>" + Me.CbxCuentaAnti.Text + "</CuentaAnticipo>"
                    sXML += "<CuentaDolares>" + Me.CbxCuentaDlls.Text + "</CuentaDolares>"
                    sXML += "<formapago>" + nFormaPago + "</formapago>"
                    sXML += "<Email>" + Me.TxtEmail.Text + "</Email>"
                    sXML += "</xCliente>"

                    Dim oclscliente = New ClsClientes()
                    oclscliente.InsertaCliente(sXML)

                    MsgBox("Registrado Correctamente, Codigo de Cliente " + wCodigo, vbInformation, "Sistema Contable")
                    'limpiar()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
            End Try
            Me.TxtCodigoClie.Enabled = True
            Me.TxtRazonSoc.Enabled = False
            Me.TxtCalle.Enabled = False
            Me.TxtNumero.Enabled = False
            Me.TxtColonia.Enabled = False
            Me.TxtTelefono.Enabled = False
            Me.TxtContacto.Enabled = False
            Me.CbxEstado.Enabled = False
            Me.CbxCiudad.Enabled = False
            Me.CbxPais.Enabled = False
            Me.TxtRfc.Enabled = False
            Me.TxtLimiteCre.Enabled = False
            Me.TxtDiasCredito.Enabled = False
            Me.TxtDiasColch.Enabled = False
            Me.TxtDiasCobra.Enabled = False
            Me.TxtVendedor.Enabled = False
            Me.RbContado.Enabled = False
            Me.RbCredito.Enabled = False
            Me.TxtRuta.Enabled = False
            Me.TxtDomFiscal.Enabled = False
            Me.CbxEstatus.Enabled = False
            Me.TxtSucursal.Enabled = False
            Me.TxtDomentrega.Enabled = False
            Me.TxtBanco.Enabled = False
            Me.CbxCuentaConta.Enabled = False
            Me.CbxCuentaAnti.Enabled = False
            Me.CbxCuentaDlls.Enabled = False
            Me.CbxFormaPago.Enabled = False
            Me.TxtDomFiscal.Enabled = False
            Me.TxtEmail.Enabled = False
            Me.BtnGrabar.Enabled = False
            Me.BtnNuevo.Enabled = False
            Me.BtnEliminar.Enabled = False
            Me.CkbCtaAnti.Enabled = False
            Me.CkbCtaDlls.Enabled = False
            Me.TxtCodigoClie.Focus()
        End If

        If RbValor = 1 Then
            

            
        End If
        limpiar()
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click


        TxtRazonSoc.Enabled = True
        TxtCalle.Enabled = True
        TxtNumero.Enabled = True
        TxtColonia.Enabled = True
        TxtTelefono.Enabled = True
        TxtContacto.Enabled = True
        CbxEstado.Enabled = True
        CbxCiudad.Enabled = True
        CbxPais.Enabled = True
        TxtRfc.Enabled = True
        TxtLimiteCre.Enabled = True
        TxtDiasCredito.Enabled = True
        TxtDiasColch.Enabled = True
        TxtDiasCobra.Enabled = True
        TxtVendedor.Enabled = True
        RbContado.Enabled = True
        RbCredito.Enabled = True
        TxtRuta.Enabled = True
        TxtDomFiscal.Enabled = True
        CbxEstatus.Enabled = True
        TxtSucursal.Enabled = True
        TxtDomentrega.Enabled = True
        TxtBanco.Enabled = True
        CbxCuentaConta.Enabled = True
        Me.CkbCtaAnti.Enabled = True
        Me.CkbCtaDlls.Enabled = True
        CbxFormaPago.Enabled = True
        TxtDomFiscal.Enabled = True
        TxtEmail.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = False
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If TxtCodigoClie.Text = "" Then
            MsgBox("Debe capturar un Codigo de Cliente", vbInformation, "Sistema Contable")
            Me.TxtCodigoClie.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsCliente = New ClsClientes()
                oclsCliente.EliminaCliente(TxtCodigoClie.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
                limpiar()
                Me.BtnGrabar.Enabled = False
                Me.BtnNuevo.Enabled = False
                Me.btnModificar.Enabled = True
                Me.BtnEliminar.Enabled = True
            End If
        End If
    End Sub
    Private Sub TxtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBuscar.GotFocus
        Me.TxtBuscar.Text = ""
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        Me.TxtBuscar.ForeColor = Color.Black
    End Sub
    Private Sub TxtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyUp
        Dim dr As SqlDataReader
        Dim oclsClientes = New ClsClientes()

        dr = oclsClientes.BuscaRazonSocialCliente(Me.TxtBuscar.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        lstClientes.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CodigoCliente").ToString)
            lstLista.SubItems.Add(rRow("RazonSocial").ToString)
            lstClientes.Items.Add(lstLista)
        Next
    End Sub

    Private Sub TxtLimiteCre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLimiteCre.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtDiasCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiasCredito.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtDiasColch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiasColch.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtDiasCobra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiasCobra.KeyPress
        'If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
        'e.KeyChar = ""
        'End If
    End Sub

    Private Sub TxtRuta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRuta.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Sub limpiar()
        Me.TxtCodigoClie.Text = ""
        Me.TxtRazonSoc.Text = ""
        Me.TxtCalle.Text = ""
        Me.TxtNumero.Text = ""
        Me.TxtColonia.Text = ""
        Me.TxtTelefono.Text = ""
        Me.TxtContacto.Text = ""
        Me.TxtRfc.Text = ""
        Me.TxtLimiteCre.Text = ""
        Me.TxtDiasCredito.Text = ""
        Me.TxtDiasColch.Text = ""
        Me.TxtDiasCobra.Text = ""
        Me.TxtVendedor.Text = ""
        Me.TxtRuta.Text = ""
        Me.TxtDomFiscal.Text = ""
        Me.TxtSucursal.Text = ""
        Me.TxtDomentrega.Text = ""
        Me.TxtBanco.Text = ""
        Me.TxtDomFiscal.Text = ""
        Me.TxtEmail.Text = ""
        Me.txtObs.Clear()
        Me.txtCodDoc.Clear()
        Me.txtValor.Clear()
        Me.TxtCodigoClie.Focus()
    End Sub
    Private Sub CkbCtaAnti_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CkbCtaAnti.Click
        If CkbCtaAnti.Checked = True Then
            Me.CbxCuentaAnti.Enabled = True
            CargaCombo5()
        ElseIf CkbCtaAnti.Checked = False Then
            Me.CbxCuentaAnti.Enabled = False
            Me.CbxCuentaAnti.SelectedValue = " "
            Me.CbxCuentaAnti.DisplayMember = " "
        End If
    End Sub
    Private Sub CkbCtaDlls_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CkbCtaDlls.Click
        If CkbCtaDlls.Checked = True Then
            Me.CbxCuentaDlls.Enabled = True
            CargaCombo6()
        ElseIf CkbCtaDlls.Checked = False Then
            Me.CbxCuentaDlls.Enabled = False
            Me.CbxCuentaDlls.SelectedValue = " "
            Me.CbxCuentaDlls.DisplayMember = " "
        End If
    End Sub

    Private Sub RbCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbCredito.CheckedChanged

        If RbCredito.Checked Then
            lstTipoDoc.Enabled = True
            txtCodDoc.Enabled = True
            txtValor.Enabled = True
            txtObs.Enabled = True
            btnSave.Enabled = True
            btnMod.Enabled = True
            btnDel.Enabled = True
            btnNew.Enabled = True
        Else
            lstTipoDoc.Enabled = False
            txtCodDoc.Enabled = False
            txtValor.Enabled = False
            txtObs.Enabled = False
            btnSave.Enabled = False
            btnMod.Enabled = False
            btnDel.Enabled = False
            btnNew.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtCodDoc.Text = "" Or txtValor.Text = "" Or txtObs.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Contable")
            txtCodDoc.Focus()
            Cargalst()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("spValidaDocumento", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@CodigoCliente", TxtCodigoClie.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > 0 Then
                    Dim pclsTm = New clsTipoDocumento()
                    pclsTm.ActualizaDocClie(txtValor.Text, txtObs.Text)
                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Contable")
                    limpiar()
                Else
                    Dim sXML = "<xTipoDocument>"
                    sXML += "<CodigoCliente>" + TxtCodigoClie.Text + "</CodigoCliente>"
                    sXML += "<CodigoDocumento>" + txtCodDoc.Text + "</CodigoDocumento>"
                    sXML += "<Valor>" + txtValor.Text + "</Valor>"
                    sXML += "<Observaciones>" + txtObs.Text + "</Observaciones>"
                    sXML += "</xTipoDocument>"
                    Dim oclstipodoc = New clsTipoDocumento()
                    oclstipodoc.InsertaDocClie(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                    limpiar()
                    Cargalst()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
            End Try
            txtCodDoc.Enabled = True
            Cargalst()
            limpiar()
            txtCodDoc.Focus()
        End If
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If MessageBox.Show("¿Desea Modificar Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            Dim cmd As New SqlCommand("Update [COMERCIAL].[DBO].[CatClientesDoc] Set CodigoDocumento=@CodigoDocumento, Valor=@Valor, Observaciones=@Observaciones Where CodigoCliente=@Cod", cnnConexion)
            cmd.Parameters.AddWithValue("@Cod", TxtCodigoClie.Text)
            cmd.Parameters.AddWithValue("@CodigoDocumento", txtCodDoc.Text)
            cmd.Parameters.AddWithValue("@Valor", txtValor.Text)
            cmd.Parameters.AddWithValue("@Observaciones", txtObs.Text)
            cmd.ExecuteNonQuery()
            cmd.Connection = cnnConexion
            cmd.Dispose()
            clsDB.CierraConexion(cnnConexion)
            MsgBox("Registro Modificado", vbInformation, "Sistema Contable")
        End If
        Cargalst()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If txtCodDoc.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Contable")
            txtCodDoc.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsTd = New clsTipoDocumento()
                oclsTd.EliminaDocClie(txtCodDoc.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
            End If
        End If
        txtCodDoc.Focus()
        Cargalst()
        limpiar()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim frm As New frmTipoDocumento
        frm.ShowDialog()
    End Sub

    Private Sub lstTipoDoc_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstTipoDoc.MouseDoubleClick
        txtCodDoc.Text = lstTipoDoc.SelectedItems(0).SubItems(1).Text
        txtValor.Text = lstTipoDoc.SelectedItems(0).SubItems(2).Text
        txtObs.Text = lstTipoDoc.SelectedItems(0).SubItems(3).Text
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRptClientes
        frm.codigo = TxtCodigoClie.Text
        frm.Show()
    End Sub
End Class