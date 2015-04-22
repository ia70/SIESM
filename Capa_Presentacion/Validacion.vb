Module Validacion

    'Funcion para corregir escritura a mayusculas y minusculas
    Public Function Validar_Nombres(ByVal Tx As TextBox, ByVal e As KeyPressEventArgs) As KeyPressEventArgs
        Dim Old As Char
        Dim Tm As Integer

        Tm = Len(Tx.Text)
        If Tm = 0 And Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Nothing
            Return e
        End If

        If Tm Then
            Tx.Select(Tm - 1, 1)
        Else
            Tx.Select(1, 1)
        End If

        Old = Tx.SelectedText.ToString
        Tx.SelectionStart = Tm

        If Not Char.IsLetter(e.KeyChar) Then
            If (Old = " " And e.KeyChar = " ") Or (Old = "." And e.KeyChar = ".") Or (Old = " " And e.KeyChar = ".") Then
                e.KeyChar = Nothing
            End If
        ElseIf Old = " " Or Old = "." Or Old = Nothing Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
            Old = e.KeyChar
        Else
            e.KeyChar = Char.ToLower(e.KeyChar)
            Old = e.KeyChar
        End If

        Return e
    End Function


    'Función para validacion de Números generales
    Public Function Validar_Num(ByVal e As KeyPressEventArgs) As KeyPressEventArgs
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(127) And Not e.KeyChar = ChrW(13) And Not e.KeyChar = ChrW(8) Then
            e.KeyChar = Nothing
        End If
        Return e
    End Function


End Module
