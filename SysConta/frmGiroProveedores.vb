Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports WindowsApplication1.clsTools
Public Class frmGiroProveedores
    Dim wcodigo As String
    Private Sub frmGiroProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Proveedores " + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.MaximizeBox = False
        txtDescripcion.Enabled = False
        btnGrabar.Enabled = False
        btnModificar.Enabled = False
        btnEliminiar.Enabled = False
        llenalista2()
    End Sub
    Private Sub cargadatos()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim oclsGiroProveedores = New clsGiroProveedores()
        Dim dr As SqlDataReader
        dr = oclsGiroProveedores.SeleccionaGiroProveedores(Me.txtCodigo.Text)
        If dr.Read() Then
            Me.txtCodigo.Text = dr("IdGiroComercial").ToString()
            Me.txtDescripcion.Text = dr("Descripcion").ToString()
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnEliminiar.Enabled = True
            txtCodigo.Enabled = False
            txtDescripcion.Enabled = False
        Else
            MsgBox("Codigo no encontrado...Generar Registro Nuevo", MessageBoxIcon.Error)
            txtCodigo.Enabled = False
            txtDescripcion.Enabled = True
            btnGrabar.Enabled = True
            btnNuevo.Enabled = True
            btnModificar.Enabled = False
            btnEliminiar.Enabled = False
            'txtCodigo.Clear()
            'txtDescripcion.Clear()
            txtDescripcion.Focus()
            llenalista2()
        End If
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                txtDescripcion.Focus()
            End If
            If txtCodigo.Text <> "" Then
                cargadatos()
                'btnGrabar.Enabled = False
                'btnNuevo.Enabled = True
                'btnModificar.Enabled = True
                'btnEliminiar.Enabled = True
                'txtDescripcion.Focus()
                llenalista2()
            Else
                txtCodigo.Text = ("0000")
                'btnModificar.Enabled = True
                'btnModificar.PerformClick()
                'Dim limpiar As New clsTools
                'limpiar.LimpiarControles(Me)
                'btnGrabar.Enabled = True
                'btnNuevo.Enabled = True
                'btnModificar.Enabled = False
                'btnEliminiar.Enabled = False
                'txtDescripcion.Clear()
                'llenalista2()
            End If
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.txtCodigo.Enabled = False
        Me.txtDescripcion.Enabled = True
        btnGrabar.Enabled = True
        btnNuevo.Enabled = True
        btnModificar.Enabled = False
        btnEliminiar.Enabled = False
        Me.txtDescripcion.Focus()
        txtCodigo.Focus()
        llenalista2()
        txtProveedores.Text = "Buscar Descripcion"
        txtProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
    End Sub
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If txtCodigo.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("sp_ValidaGiroProveedor", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@IdGiroComercial", txtCodigo.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > "0" Then
                    Dim pclsGiroProveedores = New clsGiroProveedores()
                    pclsGiroProveedores.ActualizaGiroProveedores(Me.txtCodigo.Text, Me.txtDescripcion.Text)
                    MsgBox("Actualizado Correctamente  " + wcodigo, vbInformation, "Sistema Contable")
                    Dim limpiar As New clsTools
                    limpiar.LimpiarControles(Me)
                Else
                    Dim wQuery As String = ""
                    Dim LocalCommand As SqlCommand
                    Dim wCodigo As String
                    wQuery = "SELECT MAX(IdGiroComercial)+1 FROM [almacen].[dbo].[catGiroProveedor] (NOLOCK)"
                    LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                    LocalCommand.CommandType = Data.CommandType.Text
                    wCodigo = LocalCommand.ExecuteScalar()
                    If wCodigo IsNot Nothing Then
                        'MsgBox("Se Genero Consecutivo de Folio Proveedor Correctamente", vbInformation, "Sistema Contable")
                    Else
                        MsgBox("No Se Genero Consecutivo de Folio ", vbInformation, "Sistema Almacen")
                    End If
                    LocalCommand.Dispose()
                    Dim xfoliador = New clsGiroProveedores()
                    xfoliador.AvanzaFolioGiroProveedor(wCodigo)
                    ' Existencias = 0
                    Dim sXML = "<xGiroProveedor>"
                    sXML += "<IdGiroComercial>" + wCodigo + "</IdGiroComercial>"
                    sXML += "<Descripcion>" + Me.txtDescripcion.Text + "</Descripcion>"
                    sXML += "</xGiroProveedor>"
                    Dim xclsGiroProveedores = New clsGiroProveedores
                    xclsGiroProveedores.InsertaGiroProveedores(sXML)
                    MsgBox("Registrado Correctamente, Codigo de Producto " + wCodigo, vbInformation, "Sistema Contable")
                    Dim limpiar As New clsTools
                    limpiar.LimpiarControles(Me)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Almacen")
            End Try
            txtCodigo.Focus()
            txtCodigo.Enabled = True
            txtDescripcion.Enabled = False
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            btnEliminiar.Enabled = False
            btnModificar.Enabled = False
            txtCodigo.Focus()
            txtCodigo.Clear()
            txtDescripcion.Clear()
            llenalista2()
            txtProveedores.Text = "Buscar Descripcion"
            txtProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        End If
    End Sub
    Private Sub btnEliminiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminiar.Click
        If Me.txtCodigo.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Almacen")
            txtCodigo.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsGiroProveedor = New clsGiroProveedores()
                oclsGiroProveedor.EliminaGiroProveedores(Me.txtCodigo.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Almacen")
                Dim limpiar As New clsTools
                limpiar.LimpiarControles(Me)
                btnGrabar.Enabled = False
                btnNuevo.Enabled = True
                btnModificar.Enabled = False
                btnEliminiar.Enabled = False
                Me.txtCodigo.Focus()
                Me.txtCodigo.Enabled = True
                txtCodigo.Clear()
                txtDescripcion.Clear()
                llenalista2()
                txtCodigo.Focus()
                txtProveedores.Text = "Buscar Descripcion"
                txtProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
            End If
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        txtProveedores.Text = "Buscar Descripcion"
        txtProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        Me.txtCodigo.Focus()
        Me.txtCodigo.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.btnGrabar.Enabled = True
        Me.btnNuevo.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnEliminiar.Enabled = False
        txtCodigo.Clear()
        txtDescripcion.Clear()
        llenalista2()
    End Sub
    Private Sub lstProveedores_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstProveedores.MouseDoubleClick
        txtCodigo.Text = lstProveedores.SelectedItems(0).SubItems(0).Text
        txtDescripcion.Text = lstProveedores.SelectedItems(0).SubItems(1).Text
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
        btnModificar.Enabled = True
        btnGrabar.Enabled = False
        btnEliminiar.Enabled = True
        llenalista2()
    End Sub
    Private Sub txtProveedores_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProveedores.GotFocus
        txtProveedores.Text = ""
        txtProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        txtProveedores.ForeColor = Color.Gray
        llenalista2()
    End Sub
    Private Sub txtProveedores_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProveedores.KeyUp
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsGiroProveedores = New clsGiroProveedores()
        dr = oclsGiroProveedores.BuscarGiroProveedor(Me.txtProveedores.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        If dt.Rows.Count > 0 Then
            lstProveedores.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("IdGiroComercial").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstProveedores.Items.Add(lstLista)
            Next
            Refresh()
        End If
    End Sub
    Private Sub llenalista2()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "Select * from Almacen.Dbo.CatGiroProveedor(nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "CatGiroProveedor")
        Dim objListItem As New ListViewItem
        lstProveedores.Items.Clear()
        For Each drw As DataRow In ds.Tables("CatGiroProveedor").Rows
            objListItem = lstProveedores.Items.Add(drw.Item("IdGiroComercial").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
        Next
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub txtProveedores_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedores.TextChanged
        llenalista2()
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnGrabar.PerformClick()
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRPTGiroProveedores
        frm.codigo = txtCodigo.Text
        frm.Show()
    End Sub
End Class