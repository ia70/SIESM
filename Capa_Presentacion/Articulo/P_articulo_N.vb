Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_articulo_N
    Dim Articulo As New Capa_Negocios.N_Articulo

    'Funciones de captura de valores
#Region "Funciones de obtencion de valores de campos"
    Public Function getId_Articulo() As String
        Return txtid_articulo.Text
    End Function

    Public Function getNombre() As String
        Return txtnombre.Text
    End Function

    Public Function getDescripcion() As String
        Return txtdescripcion.Text
    End Function

    Public Function getNivel_Critico() As Integer
        Return txtNivel_critico.Text
    End Function

    Public Function getUnidad_Medida() As String
        Return txtUnidad_medida.Text
    End Function

    Public Function getPrecio_Compra() As String
        Return txtPrecio_compra.Text
    End Function

    Public Function getPrecio_Venta() As String
        Return txtPrecio_venta.Text
    End Function

#End Region
    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnbuscar_imagen_Click(sender As Object, e As EventArgs) Handles btnbuscar_imagen.Click
        ptrimagen.Image = Abrir_Imagen()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim _Articulo As New E_articulo
        _Articulo.id_articulo = getId_Articulo()
        _Articulo.nombre = getNombre()
        _Articulo.descripcion = getDescripcion()
        _Articulo.nivel_critico = getNivel_Critico()
        _Articulo.unidad_medida = getUnidad_Medida()
        _Articulo.precio_compra = getPrecio_Compra()
        _Articulo.precio_venta = getPrecio_Venta()
        _Articulo.imagen = Imagen_Bytes(ptrimagen.Image)
        _Articulo.fecha = getFecha()
        If Articulo.Insertar(_Articulo) Then
            M("¡El articulo ha sido guardado con exito!", 1)
        Else
            M("¡No se ha podido guardar el articulo!", 3)
        End If
        Call btnlimpiar_campos_Click(sender, e)
        Campos(False)
    End Sub

    Private Sub btnlimpiar_campos_Click(sender As Object, e As EventArgs) Handles btnlimpiar_campos.Click
        LimpiarCampos()
    End Sub

    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

#End Region

#Region "Cajas de texto"
    Private Sub txtid_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid_articulo.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtid_articulo.Text) > 4 Then
            If Articulo.Existe(txtid_articulo.Text) Then
                M("¡El articulo " + txtid_articulo.Text + " ya existe!", 3)
                txtid_articulo.Text = ""
                txtid_articulo.Focus()
            Else
                Campos(True)
                txtNombre.Focus()
            End If
        Else
            Validar_Num(e)
        End If

    End Sub

    Private Sub txtnombre_largo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtNombre.Text) > 3 Then
            txtdescripcion.Focus()
        Else
            Validar_Nombres(txtNombre, e)
        End If
    End Sub

    Private Sub txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtPrecio_compra.Focus()
        Else
            Validar_Texto(txtdescripcion, e)
        End If
    End Sub

    Private Sub txtPrecio_compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio_compra.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtPrecio_venta.Focus()
        Else
            Validar_Num(e)
        End If
    End Sub

    Private Sub txtPrecio_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio_venta.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtUnidad_medida.Focus()
        Else
            Validar_Num(e)
        End If
    End Sub


    Private Sub txtUnidad_medida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidad_medida.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtNivel_critico.Focus()
        End If
    End Sub

    Private Sub txtUnidad_medida_TextChanged(sender As Object, e As EventArgs) Handles txtUnidad_medida.TextChanged
        txtNivel_critico.Focus()
    End Sub

    Private Sub txtNivel_critico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel_critico.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnguardar.Focus()
        Else
            Validar_Num(e)
        End If
    End Sub

    Private Sub ptrimagen_Click(sender As Object, e As EventArgs) Handles ptrimagen.Click
        If Not IsNothing(ptrimagen.Image) Then
            ImagenViewer.PictureBox1.Image = ptrimagen.Image
            Popup.PopupFrm(ImagenViewer, 0)
        End If
    End Sub

#End Region

#Region "Funciones de validacion de campos"
    Sub Campos(ByVal Valor As Boolean)
        txtid_articulo.Enabled = Not Valor
        txtNombre.Enabled = Valor
        txtdescripcion.Enabled = Valor
        txtPrecio_compra.Enabled = Valor
        txtPrecio_venta.Enabled = Valor
        txtUnidad_medida.Enabled = Valor
        txtNivel_critico.Enabled = Valor
        btnlimpiar_campos.Enabled = Valor
        btnguardar.Enabled = Valor
        btnbuscar_imagen.Enabled = Valor
    End Sub

    Sub LimpiarCampos()
        txtid_articulo.Text = ""
        txtNombre.Text = ""
        txtdescripcion.Text = ""
        txtPrecio_compra.Text = ""
        txtPrecio_venta.Text = ""
        txtUnidad_medida.Text = ""
        'txtNivel_critico.Value = 0
        ptrimagen.Image = Nothing
        Campos(False)
        txtid_articulo.Focus()
    End Sub

#End Region

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class