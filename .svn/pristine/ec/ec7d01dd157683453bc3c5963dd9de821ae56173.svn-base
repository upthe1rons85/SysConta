Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.mdVariables

Public Class frmCECOSAreas
    Public modifica As Integer

    Private Sub frmCECOSAreas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento CECOS Departamentos" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        VPCatCuentasPuente = ""
        Me.MaximizeBox = False
        LlenarListaAreas()
    End Sub

    Private Sub txtArea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArea.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtClasificacion.Text = "" Or txtArea.Text = "" Then
                MsgBox("Debe capturar un numero de Area y/o Clasificacion!!!", vbInformation, "Sistema Contable")
                txtArea.Focus()
            Else
                Dim dr As SqlDataReader
                Dim oclsCECOSAreas = New clsCECOSAreas()
                txtArea.Text = Long.Parse(txtArea.Text).ToString("000")
                dr = oclsCECOSAreas.SeleccionaAreas(Me.txtClasificacion.Text, Me.txtArea.Text)
                If dr.Read() Then
                    txtDescripcion.Text = dr("des_area").ToString()
                    txtDescripcion.Enabled = False
                    BtnGuardar.Enabled = False
                    BtnEliminar.Enabled = True
                    BtnModificar.Enabled = True
                Else
                    MsgBox("No se encontro registro, Se generara uno Nuevo", vbInformation, "Sistema Contable")
                    txtDescripcion.Enabled = True
                    txtDescripcion.Focus()
                    txtDescripcion.Text = ""
                    BtnGuardar.Enabled = True
                    BtnModificar.Enabled = True
                End If
            End If
        End If
        LlenarListaAreas()
        REM Valida que solo numero se pueda teclar
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        modifica = 0
        TxtBuscar.Text = "Buscar Descripción"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        VPCatCuentasPuente = ""
        BtnBuscar.Enabled = True
        BtnBuscar.Focus()
        BtnModificar.Enabled = False
        LlenarListaAreas()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If txtClasificacion.Text = "" Or txtArea.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta", vbInformation, "Sistema Contable")
            txtArea.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsCECOSAreas = New clsCECOSAreas()
                oclsCECOSAreas.EliminaArea(txtClasificacion.Text, txtArea.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
                txtClasificacion.Text = ""
                txtDescripcion.Text = ""
                btnNuevo.PerformClick()
            End If
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtClasificacion.Text = "" Or txtDescripcion.Text = "" Or txtArea.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
            txtArea.Focus()
        Else
            If modifica = 1 Then
                Dim oclsCECOSAreas = New clsCECOSAreas()
                oclsCECOSAreas.ActualizaDescripcionArea(txtClasificacion.Text, txtArea.Text, txtDescripcion.Text)
                MsgBox("Registro Actualizado Correctamente", vbInformation, "Sistema Contable")
                LlenarListaAreas()
            Else
                If MessageBox.Show("¿Desea GUARDAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        Dim clsBD As New clsBD()
                        Dim oclsCECOSAreas = New clsCECOSAreas()
                        oclsCECOSAreas.InsertaArea(txtClasificacion.Text, txtArea.Text, txtDescripcion.Text)
                        MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                        LlenarListaAreas()
                        modifica = 0
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
                    End Try
                End If
            End If
            btnNuevo.PerformClick()
        End If
    End Sub

    Private Sub LlenarListaAreas()
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsCECOSAreas = New clsCECOSAreas()
        dr = oclsCECOSAreas.SeleccionaAreas(Me.txtClasificacion.Text, Me.txtArea.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        lstCECOSAreas.Items.Clear()
        If dt.Rows.Count > 0 Then
            lstCECOSAreas.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("cve_clas").ToString)
                lstLista.SubItems.Add(rRow("area").ToString)
                lstLista.SubItems.Add(rRow("des_area").ToString)
                lstCECOSAreas.Items.Add(lstLista)
            Next
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
        Dim oclsCECOSAreas = New clsCECOSAreas()
        dr = oclsCECOSAreas.BuscaDescripcionArea(Me.TxtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        'If dt.Rows.Count > 0 Then
        lstCECOSAreas.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("cve_clas").ToString)
            lstLista.SubItems.Add(rRow("area").ToString)
            lstLista.SubItems.Add(rRow("Des_area").ToString)
            lstCECOSAreas.Items.Add(lstLista)
        Next
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGuardar.PerformClick()
        End If
    End Sub

    Private Sub txtArea_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArea.TextChanged
        'LlenarListaAreas()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        frmCECOSAreas_List.ShowDialog()
        txtClasificacion.Text = VPCatCuentasPuente
        LlenarListaAreas()
        'listamayoreo = ""
    End Sub

    Private Sub lstCECOSAreas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstCECOSAreas.MouseDoubleClick
        txtClasificacion.Text = lstCECOSAreas.SelectedItems(0).SubItems(0).Text
        txtArea.Text = lstCECOSAreas.SelectedItems(0).SubItems(1).Text
        txtDescripcion.Text = lstCECOSAreas.SelectedItems(0).SubItems(2).Text
        txtArea.Enabled = False
        txtDescripcion.Enabled = False
        BtnBuscar.Enabled = False
        BtnModificar.Enabled = True
        BtnGuardar.Enabled = False
        BtnEliminar.Enabled = True
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If txtClasificacion.Text = "" Or txtDescripcion.Text = "" Or txtArea.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
            txtArea.Focus()
        Else
            If MessageBox.Show("¿Desea ACTUALIZAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                modifica = 1
                txtDescripcion.Enabled = True
                BtnGuardar.Enabled = True
                BtnModificar.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmRPTAreas
        frm.ShowDialog()

    End Sub
End Class