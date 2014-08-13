Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsUsuarios
Imports WindowsApplication1.mdVariables
Imports WindowsApplication1.clsTools
Public Class frmUsuarios
    Dim xFechaSegura As String
    Dim nEstatus As String
    Dim nPerfil As String
    Dim nCodigo As String
    Dim yFecha As Date = Now
    Dim zFecha2 As Date = Now
    Dim nFecha As String = Format(yFecha, "M/d/yyyy H:mm")
    Dim ComputerName As String
    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaEstatus()
        cargadatosPerfil()
        'CargaSistema()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        Me.Text = "Mantenimiento de Usuarios" + Space(5) + CStr(VersionCont())
        CbxEstatus.Text = "Seleccione Estatus"
        CbxPerfil.Text = "Seleccione Perfil"
        cbxSistema.Text = "Seleccione Sistema"
        btnEliminiar.Enabled = False
        btnModificar.Enabled = False
        btnGrabar.Enabled = True
        btnNuevo.Enabled = True
    End Sub
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If txtusuario.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Contable")
            txtusuario.Focus()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("sp_MantenimientoUsuario", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@usuario", txtusuario.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > 0 Then
                    Dim oclsUsuarios = New clsUsuarios()
                    oclsUsuarios.EliminaUsuarios(txtusuario.Text)
                    nEstatus = CbxEstatus.SelectedValue
                    Dim sXML = "<xUsuario>"
                    sXML += "<Usuario>" + Me.txtusuario.Text + "</Usuario>"
                    sXML += "<Contraseña>" + Me.txtcontraseña.Text + "</Contraseña>"
                    sXML += "<Nombre>" + Me.txtnombre.Text + "</Nombre>"
                    sXML += "<Puesto>" + Me.txtpuesto.Text + "</Puesto>"
                    sXML += "<Telefono>" + Me.txttelefono.Text + "</Telefono>"
                    sXML += "<Email>" + Me.txtemail.Text + "</Email>"
                    sXML += "<FechaSegura>" + nFecha + "</FechaSegura>"
                    sXML += "<Perfil>" + Me.CbxPerfil.SelectedValue + "</Perfil>"
                    sXML += "<Estatus>" + nEstatus + "</Estatus>"
                    sXML += "<FechaAlta>" + nFecha + "</FechaAlta>"
                    sXML += "<FechaBaja>" + nFecha + "</FechaBaja>"
                    sXML += "<Sistema>" + Me.cbxSistema.Text + "</Sistema>"
                    sXML += "</xUsuario>"
                    Dim xclsUsuarios = New clsUsuarios()
                    xclsUsuarios.InsertaUsuarios(sXML)
                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Contable")
                    Dim limpiar As New clsTools
                    limpiar.LimpiarControles(Me)
                Else
                    nEstatus = CbxEstatus.SelectedValue
                    Dim sXML = "<xUsuario>"
                    sXML += "<Usuario>" + Me.txtusuario.Text + "</Usuario>"
                    sXML += "<Contraseña>" + Me.txtcontraseña.Text + "</Contraseña>"
                    sXML += "<Nombre>" + Me.txtnombre.Text + "</Nombre>"
                    sXML += "<Puesto>" + Me.txtpuesto.Text + "</Puesto>"
                    sXML += "<Telefono>" + Me.txttelefono.Text + "</Telefono>"
                    sXML += "<Email>" + Me.txtemail.Text + "</Email>"
                    'sXML += "<FechaSegura>" + nFecha + "</FechaSegura>" 
                    sXML += "<Perfil>" + Me.CbxPerfil.SelectedValue + "</Perfil>"
                    sXML += "<Estatus>" + nEstatus + "</Estatus>"
                    sXML += "<FechaAlta>" + nFecha + "</FechaAlta>"
                    sXML += "<FechaBaja>" + nFecha + "</FechaBaja>"
                    sXML += "<Sistema>" + Me.cbxSistema.Text + "</Sistema>"
                    sXML += "</xUsuario>"
                    Dim oclsUsuarios = New clsUsuarios()
                    oclsUsuarios.InsertaUsuarios(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                    Dim limpiar As New clsTools
                    limpiar.LimpiarControles(Me)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
            End Try

            txtusuario.Enabled = True
            txtcontraseña.Enabled = False
            txtnombre.Enabled = False
            txtpuesto.Enabled = False
            txttelefono.Enabled = False
            txtemail.Enabled = False
            txtemail.Enabled = False
            CbxPerfil.Enabled = False
            CbxEstatus.Enabled = False
            cbxSistema.Enabled = False
            CheckReset.Enabled = False
            btnGrabar.Enabled = True
            btnNuevo.Enabled = True
            btnEliminiar.Enabled = False
            CheckReset.Enabled = False
            btnModificar.Enabled = False
            btnModificar.Enabled = False
            CbxEstatus.Text = "Seleccione Estatus"
            CbxPerfil.Text = "Seleccione Perfil"
            cbxSistema.Text = "Seleccione Sistema"
            txtusuario.Focus()
        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminiar.Click
        If txtusuario.Text = "" Then
            MsgBox("Debe capturar el Usuario", vbInformation, "Sistema Contable")
            txtusuario.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsusuario = New clsUsuarios()
                oclsusuario.EliminaUsuarios(txtusuario.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
                Dim limpiar As New clsTools
                limpiar.LimpiarControles(Me)
                btnGrabar.Enabled = False
                btnNuevo.Enabled = True
                btnModificar.Enabled = False
                btnEliminiar.Enabled = True
                txtusuario.Enabled = True
                txtcontraseña.Enabled = False
                txtnombre.Enabled = False
                txtpuesto.Enabled = False
                txttelefono.Enabled = False
                txtemail.Enabled = False
                txtemail.Enabled = False
                CbxPerfil.Enabled = False
                CbxEstatus.Enabled = False
                cbxSistema.Enabled = False
                CheckReset.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        txtusuario.Enabled = False
        txtcontraseña.Enabled = True
        txtnombre.Enabled = True
        txtpuesto.Enabled = True
        txttelefono.Enabled = True
        txtemail.Enabled = True
        CbxPerfil.Enabled = True
        CbxEstatus.Enabled = True
        cbxSistema.Enabled = True
        CheckReset.Enabled = True
        btnGrabar.Enabled = True
        btnNuevo.Enabled = True
        btnModificar.Enabled = False
        btnEliminiar.Enabled = False
        txtcontraseña.Focus()
    End Sub
    Private Sub btnGrabar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnGrabar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            cargardatos()
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        txtusuario.Enabled = True
        txtcontraseña.Enabled = False
        txtnombre.Enabled = False
        txtpuesto.Enabled = False
        txttelefono.Enabled = False
        txtemail.Enabled = False
        CbxPerfil.Enabled = False
        CbxEstatus.Enabled = False
        cbxSistema.Enabled = False
        CheckReset.Enabled = False
        btnGrabar.Enabled = True
        btnNuevo.Enabled = True
        btnModificar.Enabled = False
        btnEliminiar.Enabled = False
        CbxEstatus.Text = "Seleccione Estatus"
        CbxPerfil.Text = "Seleccione Perfil"
        cbxSistema.Text = "Seleccione Sistema"
        txtusuario.Focus()
    End Sub
    Private Sub txtusuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtusuario.Text <> "" Then
                cargardatos()
            End If
        End If
    End Sub
    Private Sub cargardatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim oclsUsuarios = New clsUsuarios()
        Dim dr As SqlDataReader
        'Dim dt = New DataTable()
        dr = oclsUsuarios.SeleccionaUsuarios(Me.txtusuario.Text)
        If dr.Read() Then
            nEstatus = dr("Estatus").ToString()
            Dim dr2 As SqlDataReader
            Dim xclsUsuario = New clsUsuarios()
            dr2 = xclsUsuario.RegresaEstatus(nEstatus)
            If dr2.Read Then
                nEstatus = dr2("Descripcion").ToString()
            End If
       
            txtusuario.Text = dr("Usuario").ToString()
            txtcontraseña.Text = dr("Contraseña").ToString()
            txtnombre.Text = dr("Nombre").ToString()
            txtpuesto.Text = dr("Puesto").ToString()
            txttelefono.Text = dr("Telefono").ToString()
            txtemail.Text = dr("Email").ToString()
            'xFechaSegura = dr("FechaSegura").ToString()
            CbxPerfil.Text = dr("Perfil").ToString()
            'yFecha = dr("FechaAlta").ToString()
            'zFecha2 = (dr("FechaBaja").ToString())
            cbxSistema.Text = dr("Sistema").ToString()
            CbxEstatus.Text = nEstatus
            'CheckReset.Checked = xFechaSegura
            'CbxBuscar.Text = nCodigo
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnEliminiar.Enabled = True
        Else
            MsgBox("Usuario no encontrado...Se Generara Nuevo Registro de Usuario", MessageBoxIcon.Error)
            txtusuario.Enabled = True
            txtcontraseña.Enabled = True
            txtusuario.Enabled = True
            txtnombre.Enabled = True
            txtpuesto.Enabled = True
            txtemail.Enabled = True
            txttelefono.Enabled = True
            CbxEstatus.Enabled = True
            CbxPerfil.Enabled = True
            cbxSistema.Enabled = True
            btnGrabar.Enabled = True
            btnNuevo.Enabled = True
            btnModificar.Enabled = False
            btnEliminiar.Enabled = False
            txtcontraseña.Focus()

        End If
    End Sub
    Private Sub txtcontraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontraseña.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtnombre.Focus()
        End If
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtpuesto.Focus()
        End If
    End Sub

    Private Sub txtpuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpuesto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txttelefono.Focus()
        End If
    End Sub

    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtemail.Focus()
        End If
    End Sub

    Private Sub txtemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CbxPerfil.Focus()
        End If
    End Sub

    Private Sub CbxPerfil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxPerfil.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            CbxEstatus.Focus()
        End If
    End Sub

    Private Sub CbxEstatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxEstatus.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            cbxSistema.Focus()
        End If
    End Sub
    Private Sub cbxSistema_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxSistema.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnGrabar.PerformClick()
        End If
    End Sub
    Private Sub cargadatosPerfil()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim consulta As String = "Select Perfil,Descripcion from Perfiles(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        CbxPerfil.ValueMember = "Perfil"
        CbxPerfil.DisplayMember = "Descripcion"
        CbxPerfil.DataSource = dt
    End Sub
    Private Sub CargaEstatus()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        'Se esta tomando el estatus del la tabla Usuarios
        Dim consulta As String = "Select Estatus,Descripcion from CatEstatusUsuario(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        CbxEstatus.ValueMember = "Estatus"
        CbxEstatus.DisplayMember = "Descripcion"
        CbxEstatus.DataSource = dt
    End Sub
    'Private Sub CargaSistema()
    '    Dim cnnConexion = New SqlConnection()
    '    Dim clsDB = New clsBD()
    '    cnnConexion = clsDB.CreaConexion()
    '    'Se esta tomando el estatus del la tabla Usuarios
    '    Dim consulta As String = "Select usuario,sistema from usuarios(nolock)"
    '    Dim cmd As New SqlCommand(consulta, cnnConexion)
    '    cmd.CommandType = CommandType.Text
    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    cbxSistema.ValueMember = "usuario"
    '    cbxSistema.DisplayMember = "sistema"
    '    cbxSistema.DataSource = dt
    'End Sub
End Class