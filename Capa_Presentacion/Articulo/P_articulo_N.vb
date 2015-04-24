Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_articulo_N
    Dim Articulo As New Capa_Negocios.N_articulo

    'Codigo de los botones y componentes del formulario
    Private Sub btnlimpiar_campos_Click(sender As Object, e As EventArgs) Handles btnlimpiar_campos.Click
        LimpiarCampos()
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
        Dim objeto As New E_articulo
        objeto.id_articulo = getid_articulo()
        objeto.nombre_corto = getnombre_corto()
        objeto.nombre_largo = getnombre_largo()
        objeto.descripcion = getdescripcion()
        objeto.imagen = Articulo.Imagen_Bytes(ptrimagen.Image)
        objeto.fecha_registro = Date.Today.Date.ToString("yyyy.MM.dd")
        Articulo.Insertar(objeto)
        Call btnlimpiar_campos_Click(sender, e)
        Campos(False)
    End Sub

    Private Sub txtid_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid_articulo.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtid_articulo.Text) > 3 Then
            Campos(True)
            txtnombre_corto.Focus()
        Else
            Validar_Num(e)
        End If

    End Sub

    Private Sub txtnombre_corto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre_corto.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtnombre_corto.Text) > 3 Then
            txtnombre_largo.Focus()
        Else
            Validar_Nombres(txtnombre_corto, e)
        End If

    End Sub

    Private Sub txtnombre_largo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre_largo.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtnombre_largo.Text) > 3 Then
            txtdescripcion.Focus()
        Else
            Validar_Nombres(txtnombre_largo, e)
        End If
    End Sub

    Private Sub txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtdescripcion.Text) > 3 Then
            btnguardar.Focus()
        Else
            Validar_Texto(txtdescripcion, e)
        End If
    End Sub

    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        End
    End Sub

    Private Sub txtid_articulo_TextChanged(sender As Object, e As EventArgs) Handles txtid_articulo.TextChanged

    End Sub

    Sub Campos(ByVal Valor As Boolean)
        txtid_articulo.Enabled = Not Valor
        txtnombre_corto.Enabled = Valor
        txtnombre_largo.Enabled = Valor
        txtdescripcion.Enabled = Valor
        btnlimpiar_campos.Enabled = Valor
        btnguardar.Enabled = Valor
        btnbuscar_imagen.Enabled = Valor
    End Sub

    Sub LimpiarCampos()
        txtid_articulo.Text = ""
        txtnombre_corto.Text = ""
        txtnombre_largo.Text = ""
        txtdescripcion.Text = ""
        ptrimagen.Image = Nothing
        Campos(False)
        txtid_articulo.Focus()
    End Sub
End Class