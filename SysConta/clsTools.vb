﻿Public Class clsTools
    ''SE DECLARA EL NUMERO DE VERSION PARA SER INSERTADO EN LOS DEMAS FORMS
    Public Shared Function VersionCont() As String
        Dim ver As String

        ver = "SysCont [V 1.0.1.10]"

        Return ver
    End Function
    Public Sub LimpiarControles(ByVal frm As Form)
        For Each ctrl As Control In frm.Controls

            If (TypeOf ctrl Is TextBox) OrElse (TypeOf ctrl Is ComboBox) Then
                ctrl.Text = String.Empty
            End If
        Next

    End Sub
End Class

