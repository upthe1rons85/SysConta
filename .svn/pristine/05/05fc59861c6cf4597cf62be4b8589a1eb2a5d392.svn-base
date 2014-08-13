Partial Class DSInformePolizas
End Class

Namespace DSInformePolizasTableAdapters

    Partial Public Class sp_SelInformePolizasTableAdapter
        Public WriteOnly Property CommandTimeout() As Integer
            Set(ByVal value As Integer)
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        Me.CommandCollection(i).CommandText = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property
    End Class
End Namespace
