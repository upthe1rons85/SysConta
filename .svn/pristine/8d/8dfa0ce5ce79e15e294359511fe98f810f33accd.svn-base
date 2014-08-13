Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.mdVariables

Public Class frmCECOSClasifica
    Dim modifica As Integer
    Private Sub fmrCECOSClasifica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento CECOS Clasificacion" + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        LlenarListaClasifica()
        Me.MaximizeBox = False
    End Sub
    Private Sub LlenarListaClasifica()
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCECOSClasificacion = New clsCECOSClasificacion()

        dr = oclsCECOSClasificacion.SeleccionaCECOSClasificacion(Me.txtClasificacion.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then
            lstCECOSClasificacion.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CVE_CLAS").ToString)
                lstLista.SubItems.Add(rRow("DES_CLAS").ToString)
                lstCECOSClasificacion.Items.Add(lstLista)
            Next
        End If

    End Sub

    Private Sub SendKeys(ByVal p1 As String)
        Throw New NotImplementedException
    End Sub

    Private Sub txtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LlenarListaClasifica()
    End Sub
    Private Sub BtnGuardar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        BtnGuardar.Text = ""
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        TxtBuscar.Text = "Buscar Descripción"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        LlenarListaClasifica()
        txtClasificacion.Focus()
        txtClasificacion.Enabled = True
        BtnModificar.Enabled = False

    End Sub

    Private Sub txtClasificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClasificacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtClasificacion.Text = "" Or txtDescripcion.Text = "" Then
                MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
                txtClasificacion.Focus()

            Else
                Dim dr As SqlDataReader
                Dim oclsCECOSClasificacion = New clsCECOSClasificacion()
                'txtCuenta.Text = Format(txtCuenta.Text, "0000")
                txtClasificacion.Text = Long.Parse(txtClasificacion.Text).ToString("000")
                dr = oclsCECOSClasificacion.SeleccionaCECOSClasificacion(Me.txtClasificacion.Text)
                'Dim dt = New DataTable()
                'dt.Rows.Count > 0
                If dr.Read Then
                    txtDescripcion.Text = dr("DES_CLAS").ToString()
                    txtDescripcion.Enabled = False
                    BtnEliminar.Enabled = True
                    BtnGuardar.Enabled = False
                    txtClasificacion.Focus()
                    BtnModificar.Enabled = True

                Else

                    MsgBox("No se encontro registro, Se generara uno Nuevo", vbInformation, "Sistema Contable")
                    txtDescripcion.Enabled = True
                    txtDescripcion.Focus()
                    txtDescripcion.Text = ""
                    BtnGuardar.Enabled = True


                End If

            End If
            REM Valida que solo numero se pueda teclar
            If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtClasificacion.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
            txtClasificacion.Focus()

        Else
            If modifica = 1 Then
                Dim oclsCECOSClasificacion = New clsCECOSClasificacion()
                oclsCECOSClasificacion.ActualizaDescripcionclasifica(txtClasificacion.Text, txtDescripcion.Text)
                MsgBox("Registro Actualizado Correctamente", vbInformation, "Sistema Contable")
                txtClasificacion.Enabled = False
                txtDescripcion.Enabled = False
                LlenarListaClasifica()

            Else
                If MessageBox.Show("¿Desea GUARDAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        Dim clsBD As New clsBD()
                        Dim oclsCECOSClasificacion = New clsCECOSClasificacion()
                        oclsCECOSClasificacion.InsertaClasificacion(txtClasificacion.Text, txtDescripcion.Text)
                        MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                        LlenarListaClasifica()
                        btnNuevo.PerformClick()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If txtClasificacion.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta", vbInformation, "Sistema Contable")
            txtClasificacion.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsCECOSClasificacion = New clsCECOSClasificacion()
                oclsCECOSClasificacion.EliminaCECOSClasificacion(txtClasificacion.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
                txtClasificacion.Text = ""
                txtDescripcion.Text = ""
                LlenarListaClasifica()
                btnNuevo.Focus()
                txtClasificacion.Focus()

            End If
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGuardar.PerformClick()
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
        Dim oclsCECOSClasificacion = New clsCECOSClasificacion()

        dr = oclsCECOSClasificacion.BuscaDescripcionCECOSClasifica(Me.TxtBuscar.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstCECOSClasificacion.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CVE_CLAS").ToString)
            lstLista.SubItems.Add(rRow("DES_CLAS").ToString)
            lstCECOSClasificacion.Items.Add(lstLista)
        Next
    End Sub

    Private Sub lstCECOSClasificacion_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstCECOSClasificacion.MouseDoubleClick
        txtClasificacion.Text = lstCECOSClasificacion.SelectedItems(0).SubItems(0).Text
        txtDescripcion.Text = lstCECOSClasificacion.SelectedItems(0).SubItems(1).Text
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
        txtClasificacion.Enabled = False
        txtDescripcion.Enabled = False

    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If txtClasificacion.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("Debe Capturar Todos los Campos..!!!", vbInformation, "Sistema Contable")
            txtClasificacion.Focus()
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
        Dim frm As New frmRPTClasificacion
        frm.ShowDialog()
    End Sub
End Class