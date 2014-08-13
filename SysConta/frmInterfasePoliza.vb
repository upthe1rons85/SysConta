Imports WindowsApplication1.clsXML

Public Class frmInterfasePoliza

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmInterfasePoliza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.picImagen.Visible = False
        Me.Letrero.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.picImagen.Visible = True
        Me.Letrero.Visible = True
        Dim rXLM = New clsXML
        rXLM.accesoXML()

    End Sub

    Private Sub picImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picImagen.Click

    End Sub

End Class