Module MdNumLetras_DLLS
    Private strCentenas(9) As String
    Private strDecenas(9) As String
    Private strDecenas10(9) As String
    Private strUnidades(9) As String
    Private Sub Inicializar()       'Comprueba si ya se han inicializado los valores

        If Not strCentenas(1) = "" Then
            Exit Sub
        Else

            'Asignacion de textos de las centenas 
            strCentenas(1) = "CIENTO "
            strCentenas(2) = "DOSCIENTOS "
            strCentenas(3) = "TRESCIENTOS "
            strCentenas(4) = "CUATROCIENTOS "
            strCentenas(5) = "QUINIENTOS "
            strCentenas(6) = "SEISCIENTOS "
            strCentenas(7) = "SETECIENTOS "
            strCentenas(8) = "OCHOCIENTOS "
            strCentenas(9) = "NOVECIENTOS "
            'Asignacion de textos de las decenas 
            strDecenas(1) = "DIEZ "
            strDecenas(2) = "VEINTE "
            strDecenas(3) = "TREINTA "
            strDecenas(4) = "CUARENTA "
            strDecenas(5) = "CINCUENTA "
            strDecenas(6) = "SESENTA "
            strDecenas(7) = "SETENTA "
            strDecenas(8) = "OCHENTA "
            strDecenas(9) = "NOVENTA "
            'Asignacion de textos de las decenas de diez 
            strDecenas10(0) = "DIEZ "
            strDecenas10(1) = "ONCE "
            strDecenas10(2) = "DOCE "
            strDecenas10(3) = "TRECE "
            strDecenas10(4) = "CATORCE "
            strDecenas10(5) = "QUINCE "
            strDecenas10(6) = "DIECISEIS "
            strDecenas10(7) = "DIECISIETE "
            strDecenas10(8) = "DIECIOCHO "
            strDecenas10(9) = "DIECINUEVE "
            'Asignacion de textos de las unidades   
            strUnidades(1) = "UN "
            strUnidades(2) = "DOS "
            strUnidades(3) = "TRES "
            strUnidades(4) = "CUATRO "
            strUnidades(5) = "CINCO "
            strUnidades(6) = "SEIS "
            strUnidades(7) = "SIETE "
            strUnidades(8) = "OCHO "
            strUnidades(9) = "NUEVE "
        End If
    End Sub
    Public Function NumerosLetras_DLLS(ByVal Importe As Double, ByVal FormatoTxt As VbStrConv) _
     As String
        Dim strTmp As String        'Inicializa los valores de texto 
        Inicializar()
        strTmp = ImporteLetras(Importe)
        strTmp = Trim$(Replace$(strTmp, "  ", " "))
        If strTmp = "" Then
            NumerosLetras_DLLS = StrConv("CERO DOLARES" & Centavos(Importe), FormatoTxt)
        ElseIf strTmp = "UN" Then
            NumerosLetras_DLLS = StrConv(strTmp & " DOLAR" & Centavos(Importe), FormatoTxt)
        ElseIf Right$(strTmp, 4) = "ONES" Or Right$(strTmp, 2) = "ON" Then
            NumerosLetras_DLLS = StrConv(strTmp & " DE DOLARES" & Centavos(Importe), FormatoTxt)
        Else : NumerosLetras_DLLS = StrConv(strTmp & " DOLARES" & Centavos(Importe), FormatoTxt)
        End If
    End Function
    Private Function ImporteLetras(ByVal Importe As Double) As String
        Dim strImporte As String
        Dim strTmp As String
        strImporte = Format$(Importe, "0.00")       'Checar Billones
        If Int(Importe / 1000000000000.0#) = 1 Then 'si el importe es un billon algo...
            ImporteLetras = "UN BILLON " & ImporteLetras(Right$(strImporte, 15))
        ElseIf Int(Importe / 1000000000000.0#) > 1 Then
            ImporteLetras = ImporteLetras(Int(Importe / 1000000000000.0#)) & _
                                            " BILLONES " & ImporteLetras(Right$(strImporte, 15))
        Else            'Checar Millones 
            If Int(Importe / 1000000) = 1 Then 'si el importe es un millon algo...
                ImporteLetras = "UN MILLON " & ImporteLetras(Right$(strImporte, 9))
            ElseIf Int(Importe / 1000000) > 1 Then
                ImporteLetras = ImporteLetras(Int(Importe / 1000000)) & _
                                               " MILLONES " & ImporteLetras(Right$(strImporte, 9))
            Else                'Checar Millares 
                If Importe = 1000 Then
                    ImporteLetras = " UN MIL " & ImporteLetras(Right$(strImporte, 6))
                ElseIf Int(Importe / 1000) = 1 Then
                    ImporteLetras = "MIL " & ImporteLetras(Right$(strImporte, 6))
                ElseIf Int(Importe / 1000) > 1 Then
                    ImporteLetras = ImporteLetras(Int(Importe / 1000)) & _
                                                   " MIL " & ImporteLetras(Right$(strImporte, 6))
                Else                    'Checar centenas 
                    If Digito(Importe, 3) = 1 Then
                        If Left$(Format$(Importe, "0.00"), 3) = 100 Then 'solo cuando es cien es diferente
                            strTmp = "CIEN "
                        Else
                            strTmp = strCentenas(1)
                        End If
                    Else
                        strTmp = strCentenas(Digito(Importe, 3))
                    End If                  'Checar Decenas
                    If Digito(Importe, 2) = 1 Then 'si es uno le asigna su texto a las unidades
                        strTmp = strTmp & strDecenas10(Digito(Importe, 1))
                    Else 'si no es uno asigna decenas y despues las unidades 
                        If Digito(Importe, 2) = 2 Then 'el veinte es especial
                            If Digito(Importe, 1) = 0 Then
                                strTmp = strTmp & strDecenas(2)
                            Else
                                strTmp = strTmp & "VEINTI"
                            End If
                        ElseIf Digito(Importe, 2) = 0 Then 'el cero lo ignora 
                        Else
                            If Digito(Importe, 1) = 0 Then
                                strTmp = strTmp & strDecenas(Digito(Importe, 2))
                            Else
                                strTmp = strTmp & strDecenas(Digito(Importe, 2)) & " Y "
                            End If
                        End If
                        'Si las decenas no es uno asigna unidades.
                        strTmp = strTmp & strUnidades(Digito(Importe, 1))
                    End If
                    ImporteLetras = strTmp
                End If
            End If
        End If
    End Function
    'Funcion para devolver un digito en la posicion solicitada  
    Private Function Digito(ByVal Importe As Double, ByVal Posicion As Integer) As Integer

        Dim strImporte As String
        strImporte = Format$(Importe, "0.00")
        Posicion = Posicion + 3
        If Posicion > Len(strImporte) Then
            Digito = 0 'si la posocion esta fuera de la cadena, no devuelve nada
        Else : Digito = Val(Mid$(strImporte, Len(strImporte) - Posicion + 1, 1))
        End If
    End Function
    'Funcion para poner la terminación de la cadena en centavos.
    Private Function Centavos(ByVal Importe As Double) As String

        Centavos = " " & Right$(Format$(Importe, "0.00"), 2) & "/100 USD"
    End Function

End Module
