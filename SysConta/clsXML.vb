Imports System.Xml
Public Class clsXML
    Sub accesoXML()
        Dim reader As XmlTextReader = New XmlTextReader("C:\Users\oiniguez\Downloads\PolGan.xml")
        Dim xCadena As String
        xCadena = ""
        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element 'Mostrar comienzo del elemento.
                    xCadena = xCadena + ("<" + reader.Name)
                    If reader.HasAttributes Then 'If attributes exist
                        While reader.MoveToNextAttribute()
                            'Mostrar valor y nombre del atributo
                            'Console.Write(" {0}='{1}'", reader.Name, reader.Value)
                            xCadena = xCadena + reader.Name + reader.Name
                        End While
                    End If
                    xCadena = xCadena + (">")
                Case XmlNodeType.Text 'Mostrar el texto de cada elemento.
                    xCadena = xCadena + (reader.Value)
                Case XmlNodeType.EndElement 'Mostrar final del elemento.
                    xCadena = xCadena + ("</" + reader.Name)
                    xCadena = xCadena + (">")
            End Select
        Loop
    End Sub
End Class
