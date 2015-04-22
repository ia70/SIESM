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

    'Funcion para corregir escritura a mayusculas y minusculas
    Public Function Validar_Texto(ByVal Tx As TextBox, ByVal e As KeyPressEventArgs) As KeyPressEventArgs
        Dim Old As Char
        Dim Old2 As Char
        Dim Tm As Integer

        Tm = Len(Tx.Text)
        If Tm = 0 And Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Nothing
            Return e
        End If

        If Tm > 1 Then
            Tx.Select(Tm - 1, 1)
            Old = Tx.SelectedText.ToString
            Tx.Select(Tm - 2, 1)
            Old2 = Tx.SelectedText.ToString
        ElseIf Tm Then
            Tx.Select(Tm - 1, 1)
            Old = Tx.SelectedText.ToString
        Else
            Tx.Select(1, 1)
            Old = Tx.SelectedText.ToString
        End If

        Tx.SelectionStart = Tm

        If Not Char.IsLetter(e.KeyChar) Then
            If (Old = " " And e.KeyChar = " ") Or (Old = "." And e.KeyChar = ".") Or (Old = " " And e.KeyChar = ".") Then
                e.KeyChar = Nothing
            End If
        ElseIf Old = "." Or Old = Nothing Or (Old = " " And Old2 = ".") Then
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

    Public Sub MS(ByVal Texto As String, ByVal Tipo As Integer)
        If Tipo = 1 Then
            MsgBox(Texto, vbInformation, "SIESM")
        ElseIf Tipo = 2 Then
            MsgBox(Texto, vbExclamation, "SIESM")
        Else
            MsgBox(Texto, vbCritical, "SIESM")
        End If

    End Sub

End Module
