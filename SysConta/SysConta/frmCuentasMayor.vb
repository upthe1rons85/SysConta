Imports WindowsApplication1.clsBD
Imports System.Data.SqlClient
Imports WindowsApplication1.clsCuentasMayor

Public Class frmCuentasMayor

    Private Property StringFormat As String

    Private Sub frmCuentasMayor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarLista()
        Me.txtCuenta.MaxLength = 4
        Me.txtDescripcion.MaxLength = 30
    End Sub
    Private Sub LlenarLista()
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsCuentasMayor = New clsCuentasMayor()

        dr = oclsCuentasMayor.SeleccionaCuentasMayor()

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

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim clsBD As New clsBD()

        Dim sXML = "<xCuentasMay>"
        sXML += "<CuentaMayor>" + Me.txtCuenta.Text + "</CuentaMayor>"
        sXML += "<Descripcion>" + Me.txtDescripcion.Text + "</Descripcion>"
        sXML += "</xCuentasMay>"


        Dim oclsCuentasMayor = New clsCuentasMayor()
        oclsCuentasMayor.InsertaCuentaMayor(sXML)

        LlenarLista()
    End Sub


    Private Sub SendKeys(ByVal p1 As String)
        Throw New NotImplementedException
    End Sub

 
    Private Sub txtCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress
        REM Valida que solo numero se pueda teclar

        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        REM  If Char.IsLower(e.KeyChar) Then
        REM 'Convert to uppercase, and put at the caret position in the TextBox.
        REM Me.txtDescripcion.SelectedText = Char.ToUpper(e.KeyChar)
        REM e.Handled = True
        REM End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.TextChanged

    End Sub
End Class