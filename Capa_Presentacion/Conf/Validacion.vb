Imports System.IO

Module Validacion

#Region "Funciones de Validación de campos"

    Public Function ToDecimal(ByVal num As Decimal) As Decimal
        Return Format((num * 1), "##,##0.##")
    End Function
    'Funcion para corregir escritura a mayusculas y minusculas
    Public Function Validar_Nombres(ByVal Tx As TextBox, ByVal e As KeyPressEventArgs) As KeyPressEventArgs
        Dim Old As Char
        Dim Tm As Integer

        If Char.IsControl(e.KeyChar) Then
            Return e
        End If

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

        If Char.IsControl(e.KeyChar) Then
            Return e
        End If

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
        If Char.IsControl(e.KeyChar) Then
            Return e
        End If

        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = ChrW(127) And Not e.KeyChar = ChrW(13) And Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
            e.KeyChar = Nothing
        End If
        Return e
    End Function

    'Función para enviar MsgBox con los diferentes tipos de alertas
    Public Sub M(ByVal Texto As String, Optional ByVal Tipo As Integer = 0)
        If Tipo = 0 Then
            MsgBox(Texto, vbInformation, "SIESM")
        ElseIf Tipo = 1 Then
            MsgBox(Texto, vbExclamation, "SIESM")
        Else
            MsgBox(Texto, vbCritical, "SIESM")
        End If

    End Sub

#End Region
#Region "Funciones de corverción de imágenes y cuadro de dialogo buscar"

    'Función para convertir de Imagen a Bytes
    Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    'Funcion para convertir de Bytes a Imagen
    Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'Funcion para abrir el cuadro de dialogo de "Buscar Imágenes"
    Public Function Abrir_Imagen() As Image
        Dim filename As String
        Dim openfiler As New OpenFileDialog
        'Definiendo propiedades al openfiledialog
        With openfiler
            'directorio inicial
            '.InitialDirectory = "C:\"
            'archivos que se pueden abrir
            .Filter = "Archivos de imágen(*.jpg)|*.jpg"
            'indice del archivo de lectura por defecto
            .FilterIndex = 1
            'restaurar el directorio al cerrar el dialogo
            .RestoreDirectory = True
        End With
        '
        'Evalua si el usuario hace click en el boton abrir
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Obteniendo la ruta completa del archivo xml
            filename = openfiler.FileName
            Return Image.FromFile(filename)
        End If
        Return Nothing
    End Function

#End Region
#Region "Obtencion de valores globales"
    Public Function getFecha() As String
        Return Date.Today.Date.ToString("yyyy.MM.dd")
    End Function

    Public Function getHora() As String
        Return String.Format("{0:HH:mm:ss tt}", DateTime.Now)
    End Function
#End Region

End Module
