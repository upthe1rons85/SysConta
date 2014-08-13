Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.clsTools
Imports WindowsApplication1.mdVariables

Public Class frmCuentasMaySeg
    Dim modifica As Integer
    Dim Cuenta As Integer
    Dim wCodigo As String
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmCuentasMaySeg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mantenimiento Catálogo de Cuentas 2do Nivel" + Space(10) + CStr(VersionCont())
        'MsgBox("Valor de lista  " + listamayoreo, vbInformation, "Sistema Contable")
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        VPCatCuentasPuente = ""
        Me.MaximizeBox = False
        LlenarListaNiv2()
        BtnBuscar.Focus()
        txtDepreciacion.Enabled = False
    End Sub

    Private Sub txtCuentaN2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuentaN2.GotFocus
        'LlenarListaNiv2()
    End Sub

    Private Sub txtCuentaN2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaN2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtCuentaN2.Text = "" Or txtCuenta.Text = "" Then
                MsgBox("Debe capturar un numero de cuenta de Mayor y/o Cuenta Nivel 2!!!", vbInformation, "Sistema Contable")
                txtCuentaN2.Focus()
            Else
                Dim dr As SqlDataReader
                Dim oclsCuentasNivel2 = New clsCuentasNivel2()
                txtCuentaN2.Text = Long.Parse(txtCuentaN2.Text).ToString("000")
                dr = oclsCuentasNivel2.SeleccionaNivel2(Me.txtCuentaN2.Text, Me.txtCuenta.Text)
                'Dim dt = New DataTable()
                'dt.Rows.Count > 0
                If dr.Read() Then

                    txtDescripcion.Text = dr("descripcion").ToString()
                    txtCuentaN2.Enabled = False
                    txtDescripcion.Enabled = False
                    txtDepreciacion.Enabled = False
                    BtnGuardar.Enabled = False
                    BtnModificar.Enabled = True
                Else
                    MsgBox("No se Encontro Registro, Se generara uno Nuevo", vbInformation, "Sistema Contable")
                    txtDescripcion.Enabled = True
                    txtDescripcion.Focus()
                    txtDescripcion.Text = ""
                    BtnGuardar.Enabled = True
                    txtDepreciacion.Enabled = False

                End If
            End If
        End If
        LlenarListaNiv2()
        REM Valida que solo numero se pueda teclar
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        frmCuentasMaySeg_List.ShowDialog()
        Me.Refresh()
        txtCuenta.Text = VPCatCuentasPuente
        LlenarListaNiv2()
        'listamayoreo = ""
    End Sub

    Private Sub btnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim limpiar As New clsTools
        limpiar.LimpiarControles(Me)
        TxtBuscar.Text = "Buscar Descripción"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        VPCatCuentasPuente = ""
        BtnBuscar.Enabled = True
        BtnBuscar.Focus()
        LlenarListaNiv2()
        txtCuentaN2.Enabled = True
        txtDescripcion.Enabled = False
        txtDepreciacion.Enabled = False
        txtDepreciacion.Clear()
    End Sub

    Private Sub BtnEliminar_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If txtCuenta.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta", vbInformation, "Sistema Contable")
            txtCuenta.Focus()
        Else
            Dim cnnConexion = New SqlConnection()
            Dim clsDB = New clsBD()
            cnnConexion = clsDB.CreaConexion()
            Dim commandbus2 As New SqlCommand("spValidaCuentaMayor2", cnnConexion)
            commandbus2.CommandType = CommandType.StoredProcedure
            commandbus2.Parameters.AddWithValue("@CuentaMayor", txtCuenta.Text)
            commandbus2.Parameters.AddWithValue("@CtaNivel2", txtCuentaN2.Text)
            'commandbus2.ExecuteNonQuery()
            Dim n As Integer
            n = RTrim(commandbus2.ExecuteScalar())
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If n > 0 Then
                    Dim oclsCuentasNivel2 = New clsCuentasNivel2()
                    oclsCuentasNivel2.EliminaCuentaNiv2(txtCuenta.Text, txtCuentaN2.Text, wCodigo, Cuenta)
                    MsgBox("Registro Eliminado", vbInformation, "Sistema Contable")
                    txtCuenta.Text = ""
                    txtDescripcion.Text = ""
                    txtDepreciacion.Enabled = False
                    btnNuevo.PerformClick()
                Else
                    MsgBox("Esta Cuenta Ya Existe en otros Niveles,No se Puede Eliminar", vbCritical, "Sistema Contable")
                End If
            End If
        End If
    End Sub

    Private Sub BtnGuardar_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If txtCuenta.Text = "" Or txtDescripcion.Text = "" Or txtCuentaN2.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
            txtCuentaN2.Focus()
        Else

            If modifica = 1 Then
                Dim oclsCuentasNivel2 = New clsCuentasNivel2()
                oclsCuentasNivel2.ActualizaDescripcionCtaNivel2(txtCuenta.Text, txtCuentaN2.Text, txtDescripcion.Text, txtDepreciacion.Text, txtDepreciacion.Text, txtDescripcion.Text)
                MsgBox("Registro Actualizado Correctamente", vbInformation, "Sistema Contable")
                LlenarListaNiv2()
                txtCuenta.Enabled = False
                txtCuentaN2.Enabled = True
                txtDescripcion.Enabled = False
                txtDepreciacion.Enabled = False
                'txtDepreciacion.Clear()
                Dim limpiar As New clsTools
                limpiar.LimpiarControles(Me)
            Else
                If MessageBox.Show("¿Desea GUARDAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try

                        Dim clsDB = New clsBD()
                        Dim cnnConexion = New SqlConnection()
                        cnnConexion = clsDB.CreaConexion()
                        Dim wQuery As String = ""
                        Dim LocalCommand As SqlCommand
                        Dim wCodigo As String
                        wQuery = "SELECT MAX(idActivo)+1 FROM contabilidad.dbo.catdeptosdepreciacion (NOLOCK)"

                        LocalCommand = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
                        LocalCommand.CommandType = Data.CommandType.Text
                        wCodigo = LocalCommand.ExecuteScalar()
                        LocalCommand.Dispose()

                        'Dim xfoliador = New clsCuentasNivel2()
                        'xfoliador.AdelantaFolioDepreciacion(wCodigo)

                        Dim oclsCuentasNiv2 = New clsCuentasNivel2()
                        oclsCuentasNiv2.InsertaCuentaNiv2(txtCuenta.Text, txtCuentaN2.Text, txtDescripcion.Text, txtDepreciacion.Text, txtDescripcion.Text, txtDepreciacion.Text, Cuenta, wCodigo)

                        'Dim xoclsCuentasNiv2 = New clsCuentasNivel2()
                        'oclsCuentasNiv2.InsertaDepreciacion(txtCuentaN2.Text, txtDescripcion.Text, txtDepreciacion.Text)

                        MsgBox("Registrado Correctamente", vbInformation, "Sistema Contable")
                        LlenarListaNiv2()
                        txtDepreciacion.Clear()


                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        MsgBox("Ocurrio un Error", vbInformation, "Sistema Contable")
                    End Try
                End If
                btnNuevo.PerformClick()
            End If
        End If
    End Sub
    Private Sub LlenarListaNiv2()
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasNiv2 = New clsCuentasNivel2()

        dr = oclsCuentasNiv2.SeleccionaNivel2(Me.txtCuentaN2.Text, txtCuenta.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then
            lstCuentasMayor.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("CuentaMayor").ToString)
                lstLista.SubItems.Add(rRow("CtaNivel2").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstCuentasMayor.Items.Add(lstLista)
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
        Dim oclsCuentasNiv2 = New clsCuentasNivel2()

        dr = oclsCuentasNiv2.BuscaDescripcionCtaNiv2(Me.txtCuenta.Text, Me.TxtBuscar.Text)

        Dim dt = New DataTable()
        dt.Load(dr)

        'If dt.Rows.Count > 0 Then
        lstCuentasMayor.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CuentaMayor").ToString)
            lstLista.SubItems.Add(rRow("CtaNivel2").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstCuentasMayor.Items.Add(lstLista)
        Next
        ' End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'txtDepreciacion.Enabled = False
            'txtDepreciacion.Focus()
            'BtnGuardar.PerformClick()
            If txtCuenta.Text = "1200" Then
                txtDepreciacion.Enabled = True
                'txtDescripcion.Text = "DEP." & ""
                txtDepreciacion.Focus()
                If txtCuenta.Text <> "1200" Then
                    txtDepreciacion.Enabled = False
                    BtnGuardar.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub txtCuentaN2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuentaN2.TextChanged
        'LlenarListaNiv2()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim frm As New FrmRPTInformeCuentasNivel2
    '    frm.Show()
    '    txtDepreciacion.Enabled = False
    '    Dim limpiar As New clsTools
    '    limpiar.LimpiarControles(Me)
    'End Sub

    Private Sub lstCuentasMayor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstCuentasMayor.MouseDoubleClick

        txtCuenta.Text = lstCuentasMayor.SelectedItems(0).SubItems(0).Text
        txtCuentaN2.Text = lstCuentasMayor.SelectedItems(0).SubItems(1).Text
        txtDescripcion.Text = lstCuentasMayor.SelectedItems(0).SubItems(2).Text
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
        txtCuentaN2.Enabled = False
        txtDescripcion.Enabled = False
        txtDepreciacion.Enabled = False
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click

        If txtCuenta.Text = "" Or txtDescripcion.Text = "" Or txtCuentaN2.Text = "" Then
            MsgBox("Debe capturar un numero de cuenta y/o Descripcion..!!!", vbInformation, "Sistema Contable")
            txtCuentaN2.Focus()
        Else
            If MessageBox.Show("¿Desea ACTUALIZAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                modifica = 1
                txtDescripcion.Enabled = True
                BtnGuardar.Enabled = True
                BtnModificar.Enabled = False
                'txtDepreciacion.Enabled = False

                If txtCuenta.Text = "1200" Then
                    'txtDepreciacion.Enabled = True
                    txtDepreciacion.Focus()
                    txtDepreciacion.Enabled = True
                    If txtCuenta.Text <> "1200" Then
                        BtnGuardar.PerformClick()
                        txtDepreciacion.Enabled = False
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub txtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.TextChanged
        'Dim cnnConexion = New SqlConnection()
        'Dim clsDB = New clsBD()
        'cnnConexion = clsDB.CreaConexion()
        'Dim commandbus As New SqlCommand("spCuentaDepreciacion", cnnConexion)
        'commandbus.CommandType = CommandType.StoredProcedure
        'commandbus.Parameters.AddWithValue("@cuentamayordepreciacion", txtDepreciacion.Text)
        'Dim n As String
        'n = RTrim(commandbus.ExecuteScalar())
        'If txtCuenta.Text = "1200" Then
        '    txtDepreciacion.Enabled = True
        'Else
        '    If txtCuenta.Text <> "1200" Then
        '        txtDepreciacion.Enabled = False
        '    End If
        'End If
    End Sub

    Private Sub txtDepreciacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDepreciacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnGuardar.PerformClick()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmRptCuentasN2
        frm.ShowDialog()
    End Sub
End Class