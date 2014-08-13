Public Class frmBienvenida

    'Private Sub frmBienvenida_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    System.Threading.Thread.Sleep(1500)
    'End Sub


    Private Sub frmBienvenida_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Opacidad As Decimal
        Opacidad = 0
        Me.Opacity = 0.0
        Me.Show()
        Me.TopMost = True
        Do While Opacidad < 1.0
            Me.Opacity = Opacidad
            Opacidad = Opacidad + 0.05
            System.Threading.Thread.Sleep(10)
        Loop

        System.Threading.Thread.Sleep(700)

        Do While Opacidad > 0.0
            Me.Opacity = Opacidad
            Opacidad = Opacidad - 0.05
            System.Threading.Thread.Sleep(10)
        Loop
        Me.Close()
    End Sub

End Class