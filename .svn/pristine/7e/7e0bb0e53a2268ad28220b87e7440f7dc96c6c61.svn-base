Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.mdVariables

Public Class frmCECOSDepartamentos
    Public modifica As Integer
    Private Sub frmCECOSDepartamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento CECOS Departamentos" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        VPCatCuentasPuente = ""
        LlenarListaDeptos()
        BtnBuscarClasificacion.Focus()
        btnNuevo.PerformClick()
        Me.MaximizeBox = False
    End Sub


    Private Sub txtDepartamento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDepartamento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtClasificacion.Text = "" Or txtArea.Text = "" Or txtDepartamento.Text = "" Then
                MsgBox("Debe Completar Todos los Campos..!!!", vbInformation, "Sistema Contable")
                Dim limpiar As New clsTools
                limpiar.LimpiarControles(Me)
                txtDepartamento.Focus()
            Else
                Dim dr As SqlDataReader
                Dim CONCATENA As String
                Dim oclsCECOSDeptos = New clsCECOSDeptos()
                txtDepartamento.Text = Long.Parse(txtDepartamento.Text).ToString("000")
                CONCATENA = Trim(Me.txtArea.Text) + Trim(Me.txtDepartamento.Text)
                'VPCatCuentasPuente = Trim(Me.txtCuentaMayor.Text) + Trim(Me.txtCuentaNiv2.Text)
                dr = oclsCECOSDeptos.SeleccionaDepartamento(Me.txtClasificacion.Text, CONCATENA)
                'Dim dt = New DataTable()
                'dt.Rows.Count > 0

                If dr.Read() Then

                    txtDescripcion.Text = dr("des_depto").ToString()
                    txtDescripcion.Enabled = False
                    txtDepartamento.Enabled = False
                    BtnGuardar.Enabled = False
                    BtnEliminar.Enabled = True
                    BtnModificar.Enabled = True

                Else
                    MsgBox("No se encontro registro, Se generara uno Nuevo", vbInformation, "Sistema Contable")
                    txtDescripcion.Enabled = True
                    txtDescripcion.Focus()
                    txtDescripcion.Text = ""
                    BtnGuardar.Enabled = True

                End If
            End If
        End If
        LlenarListaDeptos()
        REM Valida que solo numero se pueda teclar
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

 
    Private Sub BtnBuscarClasificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarClasificacion.Click
        txtArea.Text = ""
        frmCECOSAreas_List.ShowDialog()
        txtClasificacion.Text = VPCatCuentasPuente
        LlenarListaDeptos()
        btnBuscarArea.Enabled = True
    End Sub

    Private Sub btnBuscarArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarArea.Click
        frmCECOSDepartamentos_List.ShowDialog()
        txtArea.Text = VPCatCuentasPuente
        LlenarListaDeptos()
        VPCatCuentasPuente = ""
        txtDepartamento.Enabled = True
        txtDepartamento.Focus()
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGuardar.PerformClick()
        End If
    End Sub
    Private Sub LlenarListaDeptos()
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim CONCATENA As String
        Dim oclsCECOSDeptos = New clsCECOSDeptos()
        CONCATENA = Trim(Me.txtArea.Text) + Trim(Me.txtDepartamento.Text)
        dr = oclsCECOSDeptos.SeleccionaDepartamento(Me.txtClasificacion.Text, CONCATENA)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstDepartamentos.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("cve_clas").ToString)
            lstLista.SubItems.Add(rRow("area_depto").ToString)
            lstLista.SubItems.Add(rRow("des_depto").ToString)
            lstDepartamentos.Items.Add(lstLista)
        Next
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        TxtBuscar.Text = "Buscar Descripción"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        btnBuscarArea.Enabled = False
        BtnBuscarClasificacion.Enabled = True
        VPCatCuentasPuente = ""
        txtClasificacion.Text = ""
        txtArea.Text = ""
        txtDescripcion.Text = ""
        txtDepartamento.Text = ""
        BtnBuscarClasificacion.Focus()
        LlenarListaDeptos()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtClasificacion.Text = "" Or txtArea.Text = "" Or txtDepartamento.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("Debe Completar Todos los Campos..!!!", vbInformation, "Sistema Contable")
            BtnBuscarClasificacion.Focus()
        Else
            If modifica = 1 Then
                Dim oclsCECOSdeptos = New clsCECOSDeptos()
                Dim CONCATENA As String
                CONCATENA = Trim(Me.txtClasificacion.Text) + Trim(Me.txtArea.Text)
                oclsCECOSdeptos.ActualizaDescripcionDepto(txtClasificacion.Text, CONCATENA, Trim(txtDescripcion.Text))
                MsgBox("Actualizado Correctamente", vbInformation, "Sistema Contable")
                LlenarListaDeptos()
            Else
                If MessageBox.Show("¿Desea GUARDAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try

                        Dim clsBD As New clsBD()
                        Dim CONCATENA As String
                        Dim oclsCECOSdeptos = New clsCECOSDeptos()
                        CONCATENA = Trim(Me.txtArea.Text) + Trim(Me.txtDepartamento.Text)
                        oclsCECOSdeptos.InsertaDepartamentos(txtClasificacion.Text, CONCATENA, Trim(txtDescripcion.Text))

                        MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                        LlenarListaDeptos()
                        txtDepartamento.Text = ""
                        txtDescripcion.Text = ""
                        txtDepartamento.Focus()


                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If txtClasificacion.Text = "" Or txtArea.Text = "" Or txtDepartamento.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("Debe Completar Todos los Campos..!!!", vbInformation, "Sistema Contable")
            txtDepartamento.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsCECOSDeptos = New clsCECOSDeptos()
                Dim CONCATENA As String
                CONCATENA = Trim(Me.txtArea.Text) + Trim(Me.txtDepartamento.Text)
                oclsCECOSDeptos.EliminaDepartamentos(txtClasificacion.Text, CONCATENA)

                MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
                txtDepartamento.Text = ""
                txtDescripcion.Text = ""
                BtnModificar.Enabled = False
                LlenarListaDeptos()
                txtDepartamento.Focus()
            End If
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
        Dim oclsCECOSDeptos = New clsCECOSDeptos()

        dr = oclsCECOSDeptos.BuscaDescripcionDeptos(Me.TxtBuscar.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstDepartamentos.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("cve_clas").ToString)
            lstLista.SubItems.Add(rRow("area_depto").ToString)
            lstLista.SubItems.Add(rRow("des_depto").ToString)
            lstDepartamentos.Items.Add(lstLista)
        Next
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If MessageBox.Show("¿Desea ACTUALIZAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            modifica = 1
            txtDescripcion.Enabled = True
            BtnGuardar.Enabled = True
            BtnModificar.Enabled = False
        End If
    End Sub

    Private Sub lstDepartamentos_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstDepartamentos.MouseDoubleClick
        txtClasificacion.Text = lstDepartamentos.SelectedItems(0).SubItems(0).Text
        txtArea.Text = Mid((Trim(lstDepartamentos.SelectedItems(0).SubItems(1).Text)), 1, 3)
        txtDepartamento.Text = Mid((Trim(lstDepartamentos.SelectedItems(0).SubItems(1).Text)), 4, 6)
        txtDescripcion.Text = lstDepartamentos.SelectedItems(0).SubItems(2).Text

        txtArea.Enabled = False
        txtDescripcion.Enabled = False
        txtDepartamento.Enabled = False
        BtnBuscarClasificacion.Enabled = False
        BtnModificar.Enabled = True
        BtnGuardar.Enabled = False
        BtnEliminar.Enabled = True
    End Sub

    Private Sub btnImpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpresion.Click

        Dim frm As New frmRPTCuentasCECOS
        frm.ShowDialog()

    End Sub
End Class