Imports Capa_Negocios
Imports Capa_Entidad
Public Class Articulo_N
    Dim Articulo As New Capa_Negocios.CNarticulo

    'Codigo de los botones y componentes del formulario
    Private Sub btnlimpiar_campos_Click(sender As Object, e As EventArgs) Handles btnlimpiar_campos.Click
        LimpiarCampos()
    End Sub
    Sub LimpiarCampos()
        'txtdescripcion.Text = ""
        txtid_articulo.Text = ""
        txtnombre_corto.Text = ""
        txtnombre_largo.Text = ""
        ptrimagen.Image = Nothing
        txtid_articulo.Focus()
    End Sub

    'Funciones de captura de valores

    Public Function getid_articulo() As String
        Return txtid_articulo.Text
    End Function

    Public Function getnombre_corto() As String
        Return txtnombre_corto.Text
    End Function

    Public Function getnombre_largo() As String
        Return txtnombre_largo.Text
    End Function

    Public Function getdescripcion() As String
        Return txtdescripcion.Text
    End Function

    Public Function getimagen() As String
        Return txtid_articulo.Text
    End Function

    Public Function getfecha_registro() As String
        Return Date.Today.ToString
    End Function

    'Funciones de control de datos y funcionamiento

    Private Sub btnbuscar_imagen_Click(sender As Object, e As EventArgs) Handles btnbuscar_imagen.Click
        ptrimagen.Image = Articulo.abrir_imagen
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim objeto As New CEarticulo
        objeto.id_articulo = getid_articulo()
        objeto.nombre_corto = getnombre_corto()
        objeto.nombre_largo = getnombre_largo()
        objeto.descripcion = getdescripcion()
        objeto.imagen = Articulo.Imagen_Bytes(ptrimagen.Image)
        objeto.fecha_registro = Date.Today.Date.ToString("yyyy.MM.dd")
        Articulo.nuevoArticulo(objeto)
    End Sub

End Class