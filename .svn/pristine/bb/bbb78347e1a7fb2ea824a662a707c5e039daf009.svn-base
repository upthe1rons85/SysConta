Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.mdVariables

Public Class frmCuentasMayTer
    Dim modifica As Integer
    Private Sub frmCuentasMayTer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Catálogo de Cuentas 3er Nivel " + Space(10) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        VPCatCuentasPuente = ""
        LlenarListaNiv3()
        BtnBuscar.Focus()
        btnNuevo.PerformClick()
        Me.MaximizeBox = False
    End Sub

    Private Sub txtCuentaNiv2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaNiv2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtCuentaNiv3.Focus()
        End If
        REM Valida que solo numero se pueda teclar
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCuentaMayor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaMayor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtCuentaNiv2.Focus()
        End If
        REM Valida que solo numero se pueda teclar
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        txtCuentaNiv2.Text = ""
        frmCuentasMaySeg_List.ShowDialog()
        txtCuentaMayor.Text = VPCatCuentasPuente
        'txtCuentaMayor.Text = listamayoreo
        LlenarListaNiv3()
        If txtCuentaMayor.Text <> "" Then
            btnBuscarN2.Enabled = True
            'BtnBuscar.Enabled = False
        End If
    End Sub

    Private Sub btnBuscarN2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarN2.Click
        VPCatCuentasPuente = txtCuentaMayor.Text
        frmCuentasMayTer_List.ShowDialog()
        If VPCatCuentasPuente = "" Then
            VPCatCuentasPuente = txtCuentaMayor.Text
        Else
            txtCuentaNiv2.Text = VPCatCuentasPuente
        End If
        If txtCuentaNiv2.Text <> "" Then
            LlenarListaNiv3()
            VPCatCuentasPuente = ""
            'btnBuscarN2.Enabled = False
            txtCuentaNiv3.Enabled = True
            txtCuentaNiv3.Focus()
        End If
    End Sub

    Private Sub txtCuentaNiv3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaNiv3.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtCuentaMayor.Text = "" Or txtCuentaNiv2.Text = "" Or txtCuentaNiv3.Text = "" Then
                MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
                Dim limpiar As New clsTools
                limpiar.LimpiarControles(Me)
                txtCuentaNiv3.Focus()
            Else
                Dim dr As SqlDataReader
                Dim oclsCuentasNivel3 = New clsCuentasNivel3()
                txtCuentaNiv3.Text = Long.Parse(txtCuentaNiv3.Text).ToString("000")
                dr = oclsCuentasNivel3.SeleccionaNivel3(Me.txtCuentaNiv3.Text, Me.txtCuentaNiv2.Text, Me.txtCuentaMayor.Text)
                'Dim dt = New DataTable()
                'dt.Rows.Count > 0

                If dr.Read() Then

                    txtDescripcion.Text = dr("descripcion").ToString()
                    txtDescripcion.Enabled = False
                    BtnGuardar.Enabled = False
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
        LlenarListaNiv3()
        REM Valida que solo numero se pueda teclar
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGuardar.PerformClick()
        End If

    End Sub
    Private Sub LlenarListaNiv3()
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasNiv3 = New clsCuentasNivel3()

        dr = oclsCuentasNiv3.SeleccionaNivel3(Me.txtCuentaNiv3.Text, txtCuentaNiv2.Text, txtCuentaMayor.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstCuentasMayor.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CuentaMayor").ToString)
            lstLista.SubItems.Add(rRow("CtaNivel2").ToString)
            lstLista.SubItems.Add(rRow("CtaNivel3").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstCuentasMayor.Items.Add(lstLista)
        Next
        'End If
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        TxtBuscar.Text = "Buscar Descripción"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        VPCatCuentasPuente = ""
        txtCuentaMayor.Text = ""
        txtCuentaNiv3.Text = ""
        txtDescripcion.Text = ""
        BtnBuscar.Focus()
        LlenarListaNiv3()
        BtnBuscar.Enabled = True

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtCuentaMayor.Text = "" Or txtDescripcion.Text = "" Or txtCuentaNiv2.Text = "" Or txtCuentaNiv3.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
            txtCuentaNiv3.Focus()
        Else
            If modifica = 1 Then
                Dim oclsCuentasNivel3 = New clsCuentasNivel3()
                oclsCuentasNivel3.ActualizaDescripcionNivel3(txtCuentaMayor.Text, txtCuentaNiv2.Text, txtCuentaNiv3.Text, txtDescripcion.Text)
                MsgBox("Registro Actualizado Correctamente", vbInformation, "Sistema Contable")
                LlenarListaNiv3()
                txtCuentaMayor.Enabled = False
                txtCuentaNiv2.Enabled = False
                txtCuentaNiv3.Enabled = False
                txtDescripcion.Enabled = False
            Else
                If MessageBox.Show("¿Desea GUARDAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try

                        Dim clsBD As New clsBD()

                        Dim oclsCuentasNiv3 = New clsCuentasNivel3()
                        oclsCuentasNiv3.InsertaCuentaNiv3(txtCuentaMayor.Text, txtCuentaNiv2.Text, txtCuentaNiv3.Text, txtDescripcion.Text)

                        MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                        LlenarListaNiv3()
                        txtCuentaNiv3.Text = ""
                        txtDescripcion.Text = ""
                        txtCuentaNiv3.Focus()
                        'btnNuevo.PerformClick()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If txtCuentaNiv3.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta", vbInformation, "Sistema Contable")
            txtCuentaNiv3.Focus()
        Else
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            Dim commandbus2 As New SqlCommand("spValidaCuentaMayor3", cnnConexion)
            commandbus2.CommandType = CommandType.StoredProcedure
            commandbus2.Parameters.AddWithValue("@CuentaMayor", txtCuentaMayor.Text)
            commandbus2.Parameters.AddWithValue("@CtaNivel2", txtCuentaNiv2.Text)
            'commandbus2.ExecuteNonQuery()
            Dim n As Integer
            n = RTrim(commandbus2.ExecuteScalar())
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If n > 0 Then
                    Dim oclsCuentasNivel3 = New clsCuentasNivel3()
                    oclsCuentasNivel3.EliminaCuentaNiv3(txtCuentaNiv3.Text, txtCuentaNiv2.Text, txtCuentaMayor.Text)
                    MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
                    'btnNuevo.PerformClick()
                    txtCuentaNiv3.Text = ""
                    txtDescripcion.Text = ""
                    LlenarListaNiv3()
                    txtCuentaNiv3.Enabled = True
                    txtCuentaNiv3.Focus()
                Else
                    MsgBox("Esta Cuenta Ya Existe en otros Niveles,No se Puede Eliminar", vbCritical, "Sistema Contable")
                End If
            End If
            End If
    End Sub

    Private Sub txtCuentaNiv3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuentaNiv3.TextChanged
        'LlenarListaNiv3()
    End Sub

    Private Sub TxtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBuscar.GotFocus
        TxtBuscar.Text = ""
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0F)
        TxtBuscar.ForeColor = Color.Black
    End Sub

    Private Sub TxtBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuscar.KeyUp
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasNiv3 = New clsCuentasNivel3()

        dr = oclsCuentasNiv3.BuscaDescripcionCtaNiv3(Me.TxtBuscar.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstCuentasMayor.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CuentaMayor").ToString)
            lstLista.SubItems.Add(rRow("CtaNivel2").ToString)
            lstLista.SubItems.Add(rRow("CtaNivel3").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstCuentasMayor.Items.Add(lstLista)
        Next
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lstCuentasMayor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstCuentasMayor.MouseDoubleClick
        txtCuentaMayor.Text = lstCuentasMayor.SelectedItems(0).SubItems(0).Text
        txtCuentaNiv2.Text = lstCuentasMayor.SelectedItems(0).SubItems(1).Text
        txtCuentaNiv3.Text = lstCuentasMayor.SelectedItems(0).SubItems(2).Text
        txtDescripcion.Text = lstCuentasMayor.SelectedItems(0).SubItems(3).Text
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
        txtCuentaMayor.Enabled = False
        txtCuentaNiv2.Enabled = False
        txtCuentaNiv3.Enabled = False
        txtDescripcion.Enabled = False
        BtnBuscar.Enabled = False
        btnBuscarN2.Enabled = False
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If txtCuentaMayor.Text = "" Or txtDescripcion.Text = "" Or txtCuentaNiv2.Text = "" Or txtCuentaNiv3.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
            txtCuentaNiv3.Focus()
        Else
            If MessageBox.Show("¿Desea ACTUALIZAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                modifica = 1
                txtDescripcion.Enabled = True
                BtnGuardar.Enabled = True
                BtnModificar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim frm As New frmRPTCuentasNiv3
        frm.pCuentaNiv3 = Trim(txtCuentaNiv3.Text)
        frm.pCuentaNiv2 = Trim(txtCuentaNiv2.Text)
        frm.pCuentaMayor = Trim(txtCuentaMayor.Text)
        frm.ShowDialog()
    End Sub
End Class