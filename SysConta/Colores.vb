Public Class Colores
    Inherits ToolStripProfessionalRenderer

    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        Try
            Dim rc As New Rectangle(Point.Empty, e.Item.Size)
            Dim c As Color = IIf(e.Item.Selected, Color.DarkSeaGreen, Color.White)
            Using brush As New SolidBrush(c)
                e.Graphics.FillRectangle(brush, rc)
            End Using
        Catch ex As Exception

        End Try

    End Sub
End Class
