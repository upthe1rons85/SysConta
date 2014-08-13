Imports WindowsApplication1.mdVariables
Public Class frmResetContraseña
    Shared Property disable As Boolean
    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        Dim cont = 0
        If txtNueva.Text = "" Or txtConfirmar.Text = "" Then
            MsgBox("Todos los campos tienen que estar llenos")
            txtNueva.Text = ""
            txtConfirmar.Text = ""
            txtNueva.Focus()
        Else
            If txtNueva.Text <> txtConfirmar.Text Then
                MsgBox("No Coinciden los Datos")
                txtNueva.Text = ""
                txtConfirmar.Text = ""
                txtNueva.Focus()
                frmPrincipal.Show()
                Me.Hide()
            Else
                cont = 1
            End If
            Do While cont = 1
                Dim oclsUsuarios = New clsUsuarios()
                oclsUsuarios.CambiaContraseñaUsuario(LoginUsuario, txtNueva.Text)
                cont = 2
                MsgBox("Cambio Exitoso", vbInformation, "Sistema Contable")
                Me.Close()
            Loop
        End If
    End Sub
    Private Sub txtNueva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNueva.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtNueva.Focus()
        End If
    End Sub
    Private Sub txtConfirmar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnCambiar.PerformClick()
        End If
    End Sub
    Private Sub frmResetContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
    End Sub
End Class