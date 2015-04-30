Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_articulo_ED
    Dim Articulo As New Capa_Negocios.N_Articulo
    Dim Tabla As New DataSet
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

    Public Function getPrecio_Compra() As Decimal
        Return txtPrecio_compra.Text
    End Function

    Public Function getPrecio_Venta() As Decimal
        Return txtPrecio_venta.Text
    End Function

    Public Function getImagen() As String
        Return txtid_articulo.Text
    End Function

    Public Function getFecha_Registro() As String
        Return Date.Today.ToString
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
        _Articulo.fecha = Date.Today.Date.ToString("yyyy.MM.dd")
        Articulo.Insertar(_Articulo)
        Call btnlimpiar_campos_Click(sender, e)
        Campos(False)
    End Sub

    Private Sub btnlimpiar_campos_Click(sender As Object, e As EventArgs) Handles btnlimpiar_campos.Click
        LimpiarCampos()
    End Sub

    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If txtid_articulo.Text = "" Or Len(txtid_articulo.Text) < 5 Or txtid_articulo.Text = Articulo.Inicio.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Articulo.Final()
            LlenarCampos()
        ElseIf Articulo.Existe(txtid_articulo.Text) Then
            Tabla = Articulo.Atras(txtid_articulo.Text)
            LlenarCampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If txtid_articulo.Text = "" Or Len(txtid_articulo.Text) < 5 Or txtid_articulo.Text = Articulo.Final.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Articulo.Inicio()
            LlenarCampos()
        ElseIf Articulo.Existe(txtid_articulo.Text) Then
            Tabla = Articulo.Siguiente(txtid_articulo.Text)
            LlenarCampos()
        End If
    End Sub

#End Region

#Region "Cajas de texto"
    Private Sub txtid_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid_articulo.KeyPress
        If Len(txtid_articulo.Text) > 4 And e.KeyChar = ChrW(13) Then
            Tabla = Articulo.Consultar(txtid_articulo.Text)
            If Tabla.Tables(0).Rows.Count = 0 Then
                M("El articulo solicitado no existe", 3)
                txtid_articulo.Text = ""
                txtid_articulo.Focus()
            Else
                LlenarCampos()
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

    Private Sub txtNivel_critico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel_critico.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnguardar.Focus()
        Else
            Validar_Num(e)
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

    Private Sub LlenarCampos()
        txtid_articulo.Text = Tabla.Tables(0).Rows(0)(0).ToString()
        txtNombre.Text = Tabla.Tables(0).Rows(0)(1).ToString()
        txtdescripcion.Text = Tabla.Tables(0).Rows(0)(2).ToString()
        txtNivel_critico.Text = Tabla.Tables(0).Rows(0)(3).ToString()
        txtUnidad_medida.Text = Tabla.Tables(0).Rows(0)(4).ToString()
        txtPrecio_compra.Text = Tabla.Tables(0).Rows(0)(5).ToString()
        txtPrecio_venta.Text = Tabla.Tables(0).Rows(0)(6).ToString()
        ptrimagen.Image = Nothing
        On Error Resume Next
        ptrimagen.Image = Bytes_Imagen(Tabla.Tables(0).Rows(0)(7))
        txtNombre.Focus()
        Campos(True)
    End Sub

#End Region

End Class