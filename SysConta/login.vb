Imports System.Data.SqlClient
Imports System.Data
Imports WindowsApplication1.clsUsuarios
Imports WindowsApplication1.mdVariables
Public Class login
    Private acum As Integer = 0
    Dim loginuser As String
    Dim cont3 As String
    Dim ClientesToolStripMenuItem As Object
    Dim ProveedoresToolStripMenuItem As Object
    Private Sub BtnAcceso_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAcceso.Click
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        Dim commandbus As New SqlCommand("sp_ValidaUsuario", cnnConexion)
        commandbus.CommandType = CommandType.StoredProcedure
        commandbus.Parameters.AddWithValue("@usuario", txtusuario.Text)
        commandbus.Parameters.AddWithValue("@contraseña", txtcontraseña.Text)
        Dim returnValue As New SqlParameter("@usuario", txtusuario.Text)
        returnValue.Direction = ParameterDirection.ReturnValue
        commandbus.Parameters.Add(returnValue)
        loginuser = txtusuario.Text
        cont3 = 0
        Try
            commandbus.Connection = clsDB.CreaConexion
            Dim n As String
            n = RTrim(commandbus.ExecuteScalar())
            txtusuario.Text = RTrim(n)
            txtusuario.Focus()
            If n = "0" Then
                txtusuario.Text = ""
                txtcontraseña.Text = ""
                MsgBox("Usuario o contraseña incorrecta", vbInformation, "Sistema Contable")
                acum = Val(acum) + 1
                If Val(acum) > 2 Then
                    MsgBox("A superado 3 intentos fallidos,El sistema se cerrara...", MessageBoxIcon.Error)
                    Me.Close()
                    End
                End If
                cont3 = 1
            Else
                LoginUsuario = loginuser
                Dim commandbus2 As New SqlCommand("spValidaFechaSegura", cnnConexion)
                commandbus2.CommandType = CommandType.StoredProcedure
                commandbus2.Connection = clsDB.CreaConexion
                commandbus2.Parameters.AddWithValue("@Usuario", LoginUsuario)
                Dim n2 As Integer
                n2 = RTrim(commandbus2.ExecuteScalar())
                If n2 >= "1" Then
                    Me.Hide()
                    frmCambiarContraseña.Show()
                    cont3 = 1
                Else
                    If cont3 = "0" Then
                        Me.Hide()
                        frmBienvenida.ShowDialog()
                        frmPrincipal.Show()
                    End If
                End If
            End If
            Perfilesusuario = n
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        txtcontraseña.Text = ""
        txtusuario.Text = ""
        txtusuario.Focus()
        If cont3 = "0" Then
            frmPrincipal.Show()
        End If
    End Sub
    Private Sub txtcontraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontraseña.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnAcceso.PerformClick()
        End If
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End
    End Sub
    Private Sub txtusuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtcontraseña.Focus()
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NoRepetirInstancia()

    End Sub
End Class
