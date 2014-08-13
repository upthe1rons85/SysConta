Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.clsCuentasMayor
Imports WindowsApplication1.clsTools

Public Class frmCuentasMayor
    Public modifica As Integer
    Private Property StringFormat As String

    Private Sub frmCuentasMayor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Catálogo de Cuentas de Mayor " + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        '-----------COMENTARIOS------------------
        Dim toolTipEliminar As New ToolTip()
        toolTipEliminar.SetToolTip(Me.BtnEliminar, "Eliminar")

        Dim toolTipGuardar As New ToolTip()
        toolTipGuardar.SetToolTip(Me.BtnGuardar, "Guardar")

        Dim toolTipNuevo As New ToolTip()
        toolTipNuevo.SetToolTip(Me.btnNuevo, "Nuevo")

        Dim toolTipImprimir As New ToolTip()
        toolTipImprimir.SetToolTip(Me.btnImprimir, "Imprimir")

        Dim toolTipModificar As New ToolTip()
        toolTipModificar.SetToolTip(Me.BtnModificar, "Modificar")
        '-----------------------------------------
        Me.MaximizeBox = False
        LlenarLista()
    End Sub
    Private Sub LlenarLista()
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasMayor = New clsCuentasMayor()

        dr = oclsCuentasMayor.SeleccionaCuentasMayor(Me.txtCuenta.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then
            lstCuentasMayor.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CuentaMayor").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstCuentasMayor.Items.Add(lstLista)
            Next
        End If

    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtCuenta.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
            txtCuenta.Focus()
        Else
            If modifica = 1 Then
                Dim oclsCuentasMayor = New clsCuentasMayor()
                oclsCuentasMayor.ActualizaDescripcionMayor(txtCuenta.Text, txtDescripcion.Text)
                MsgBox("Registro Actualizado Correctamente", vbInformation, "Sistema Contable")
                modifica = 0
                LlenarLista()
            Else
                If MessageBox.Show("¿Desea GUARDAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try

                        Dim clsBD As New clsBD()

                        Dim sXML = "<xCuentasMay>"
                        sXML += "<CuentaMayor>" + Me.txtCuenta.Text + "</CuentaMayor>"
                        sXML += "<Descripcion>" + Me.txtDescripcion.Text + "</Descripcion>"
                        sXML += "</xCuentasMay>"


                        Dim oclsCuentasMayor = New clsCuentasMayor()
                        oclsCuentasMayor.InsertaCuentaMayor(sXML)

                        MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                        btnNuevo.PerformClick()
                        LlenarLista()


                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
                    End Try
                End If
            End If
            End If
    End Sub


    Private Sub SendKeys(ByVal p1 As String)
        Throw New NotImplementedException
    End Sub


    Private Sub txtCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Dim dr As SqlDataReader
            Dim oclsCuentasMayor = New clsCuentasMayor()
            'txtCuenta.Text = Format(txtCuenta.Text, "0000")
            txtCuenta.Text = Long.Parse(txtCuenta.Text).ToString("0000")
            dr = oclsCuentasMayor.SeleccionaCuentasMayor(Me.txtCuenta.Text)
            'Dim dt = New DataTable()
            'dt.Rows.Count > 0
            If dr.Read Then
                txtDescripcion.Text = dr("descripcion").ToString()
                txtDescripcion.Enabled = False
                BtnEliminar.Enabled = True
                BtnGuardar.Enabled = False
                BtnModificar.Enabled = True

                txtCuenta.Focus()
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

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If txtCuenta.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta", vbInformation, "Sistema Contable")
            txtCuenta.Focus()
        Else
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            Dim commandbus2 As New SqlCommand("spValidaCuentaMayor", cnnConexion)
            commandbus2.CommandType = CommandType.StoredProcedure
            commandbus2.Parameters.AddWithValue("@CuentaMayor", txtCuenta.Text)
            'commandbus2.ExecuteNonQuery()
            Dim n As Integer
            n = RTrim(commandbus2.ExecuteScalar())

            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If n > 0 Then
                    Dim oclsCuentasMayor = New clsCuentasMayor()
                    oclsCuentasMayor.EliminaCuentaMayor(txtCuenta.Text)
                    MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
                    txtCuenta.Text = ""
                    txtDescripcion.Text = ""
                    LlenarLista()
                    btnNuevo.Focus()
                Else
                    MsgBox("Esta Cuenta Ya Existe en otros Niveles,No se Puede Eliminar", vbCritical, "Sistema Contable")
                End If
            End If
        End If
    End Sub


    Private Sub txtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.TextChanged
        'LlenarLista()
    End Sub
    Private Sub TxtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBuscar.GotFocus
        TxtBuscar.Text = ""
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        TxtBuscar.ForeColor = Color.Black
    End Sub
    Private Sub BtnGuardar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGuardar.GotFocus
        BtnGuardar.Text = ""

    End Sub

    Private Sub TxtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasMayor = New clsCuentasMayor()

        dr = oclsCuentasMayor.BuscaDescripcionCtaMayor(Me.TxtBuscar.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstCuentasMayor.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CuentaMayor").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstCuentasMayor.Items.Add(lstLista)
        Next
        ' End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGuardar.PerformClick()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        txtCuenta.Enabled = True
        TxtBuscar.Text = "Buscar Descripción"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtCuenta.Enabled = True
        txtCuenta.Focus()
        LlenarLista()
        modifica = 0
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frm As New frmRptCuentasMayor
        frm.Show()
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If txtCuenta.Text = "" Or txtDescripcion.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
            txtCuenta.Focus()
        Else
            If MessageBox.Show("¿Desea ACTUALIZAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                modifica = 1
                txtDescripcion.Enabled = True
                BtnGuardar.Enabled = True
                BtnModificar.Enabled = False
                txtCuenta.Enabled = False
            End If
        End If
    End Sub

    Private Sub lstCuentasMayor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstCuentasMayor.MouseDoubleClick
        txtCuenta.Text = lstCuentasMayor.SelectedItems(0).SubItems(0).Text
        txtDescripcion.Text = lstCuentasMayor.SelectedItems(0).SubItems(1).Text

        txtCuenta.Enabled = False
        txtDescripcion.Enabled = False
        BtnModificar.Enabled = True
        BtnGuardar.Enabled = False
        BtnEliminar.Enabled = True
    End Sub

End Class