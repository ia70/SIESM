Imports Capa_Datos
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Capa_Entidad
Public Class N_articulo

    Dim objArt As New D_articulo
    Public Function Listado() As DataSet
        Return objArt.Listado()
    End Function

    Public Sub Insertar(ByVal objP As E_articulo)
        objArt.Insertar(objP)
    End Sub

    Public Function Consulta(ByVal ID As String) As DataSet
        Return objArt.Consulta(ID)
    End Function

    Public Sub Eliminar(ByVal ID As String)
        objArt.Eliminar(ID)
    End Sub

    Public Sub Editar()

    End Sub

    Public Function Existe(ByVal ID As String) As Boolean
        Return objArt.Existe(ID)
    End Function
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
End Class
