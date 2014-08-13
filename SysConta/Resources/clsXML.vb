Imports System.Xml
Public Class clsXML

    Public Sub accesoXML()
        Dim reader As XmlTextReader = New XmlTextReader("C:\Users\oiniguez\Downloads\PolGan.xml")

        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element 'Mostrar comienzo del elemento.
                    Console.Write("<" + reader.Name)
                    If reader.HasAttributes Then 'If attributes exist
                        While reader.MoveToNextAttribute()
                            'Mostrar valor y nombre del atributo
                            Console.Write(" {0}='{1}'", reader.Name, reader.Value)
                        End While
                    End If
                    Console.WriteLine(">")
                Case XmlNodeType.Text 'Mostrar el texto de cada elemento.
                    Console.WriteLine(reader.Value)
                Case XmlNodeType.EndElement 'Mostrar final del elemento.
                    Console.Write("</" + reader.Name)
                    Console.WriteLine(">")
            End Select
        Loop
        MsgBox(xCadena, "               SysCont [V 1.0]")
    End Sub

End Class
