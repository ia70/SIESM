Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_sucursal_N
    Dim Sucursal As New Capa_Negocios.N_sucursal
    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim _Sucursal As New E_sucursal
        _Sucursal.nombre = txtNombre.Text
        _Sucursal.direccion = txtDireccion.Text
        _Sucursal.descripcion = txtDescripcion.Text
        _Sucursal.telefono = txtTelefono.Text
        _Sucursal.fecha = getFecha()
        _Sucursal.imagen = Imagen_Bytes(ptrImagen.Image)
        _Sucursal.tipo = txtTipo.Text
        If Sucursal.Insertar(_Sucursal) Then
            M("¡La sucursal ha sido guardada con exito!", 1)
        Else
            M("¡No se ha podido guardar la sucursal!", 3)
        End If
        Call btnlimpiar_campos_Click(sender, e)
    End Sub

    Private Sub btnlimpiar_campos_Click(sender As Object, e As EventArgs) Handles btnlimpiar_campos.Click
        LimpiarCampos()
    End Sub

    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

#End Region


#Region "Funciones de validacion de campos"

    Sub LimpiarCampos()
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtDescripcion.Text = ""
        txtTelefono.Text = ""
        txtTipo.SelectedIndex = 0
        Campos(False)
        txtNombre.Focus()
    End Sub

    Sub Campos(ByVal Valor As Boolean)
        txtNombre.Enabled = Not Valor
        txtDireccion.Enabled = Valor
        txtDescripcion.Enabled = Valor
        txtTelefono.Enabled = Valor
        btnlimpiar_campos.Enabled = Valor
        btnguardar.Enabled = Valor
        txtTipo.Enabled = Valor
    End Sub
#End Region


    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtNombre.Text) > 2 Then
            Campos(True)
            txtDireccion.Focus()
        Else
            Validar_Nombres(txtNombre, e)
        End If
    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtTelefono.Focus()
        Else
            Validar_Nombres(txtDireccion, e)
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtDescripcion.Focus()
        Else
            Validar_Num(e)
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnguardar.Focus()
        Else
            Validar_Texto(txtDescripcion, e)
        End If
    End Sub

    Private Sub ptrImagen_Click(sender As Object, e As EventArgs) Handles ptrImagen.Click
        If Not IsNothing(ptrImagen.Image) Then
            ImagenViewer.PictureBox1.Image = ptrImagen.Image
            Popup.PopupFrm(ImagenViewer, 0)
        End If
    End Sub

    Private Sub btnBuscar_imagen_Click(sender As Object, e As EventArgs) Handles btnBuscar_imagen.Click
        ptrImagen.Image = Abrir_Imagen()
    End Sub

    Private Sub P_sucursal_N_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtTipo.SelectedIndex = 0
        txtNombre.Focus()
    End Sub

    Private Sub txtTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTipo.SelectedIndexChanged
        btnguardar.Focus()
    End Sub
End Class