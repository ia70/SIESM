Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_usuario_N
    Dim Elemento As New Capa_Negocios.N_usuario
    'Funciones de control de datos y funcionamiento

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim _usuario As New E_usuario
        _usuario.id_usuario = txtid_usuario.Text
        _usuario.contrasena = txtcontrasena.Text
        _usuario.nombre = txtnombre.Text
        _usuario.apellidos = Txtapellidos.Text
        _usuario.sexo = txtsexo.Text
        _usuario.tipo = txttipo.SelectedIndex.ToString
        _usuario.imagen = Imagen_Bytes(ptrimagen.Image)
        _usuario.fecha = getFecha()
        If Elemento.Insertar(_usuario) Then
            M("¡El usuario ha sido agregado con exito!", 1)
        Else
            M("¡No se ha podido agregar el usuario!", 3)
        End If
        Call btnlimpiar_campos_Click(sender, e)
    End Sub

    Private Sub btnlimpiar_campos_Click(sender As Object, e As EventArgs) Handles btnlimpiar_campos.Click
        LimpiarCampos()
    End Sub

    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub


#Region "Funciones de validacion de campos"

    Sub LimpiarCampos()
        txtid_usuario.Text = ""
        txtcontrasena.Text = ""
        txtnombre.Text = ""
        Txtapellidos.Text = ""
        txtsexo.Text = ""
        txtTipo.SelectedIndex = 0
        Campos(False)
        txtcontrasena.Focus()
    End Sub

    Sub Campos(ByVal Valor As Boolean)
        txtid_usuario.Enabled = Not Valor
        txtcontrasena.Enabled = Valor
        txtnombre.Enabled = Valor
        Txtapellidos.Enabled = Valor
        txtsexo.Enabled = Valor
        btnBuscar_imagen.Enabled = Valor
        btnlimpiar_campos.Enabled = Valor
        btnguardar.Enabled = Valor
        txtTipo.Enabled = Valor
    End Sub
#End Region


    Private Sub txtid_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid_usuario.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtid_usuario.Text) > 2 Then
            Campos(True)
            txtcontrasena.Focus()


        End If
    End Sub

    Private Sub txtcontrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontrasena.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtnombre.Focus()

        End If
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If e.KeyChar = ChrW(13) Then
            Txtapellidos.Focus()
        Else
            Validar_Nombres(txtnombre, e)
        End If
    End Sub

    Private Sub txtapellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtapellidos.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtsexo.Focus()
        Else
            Validar_Nombres(Txtapellidos, e)
        End If
    End Sub


    Private Sub txtsexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsexo.KeyPress
        If e.KeyChar = ChrW(13) Then
            txttipo.Focus()
        Else
            Validar_Nombres(Txtapellidos, e)
        End If
    End Sub
    Private Sub txttipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttipo.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnguardar.Focus()
        End If
    End Sub

    Private Sub ptrImagen_Click(sender As Object, e As EventArgs) Handles ptrimagen.Click
        If Not IsNothing(ptrImagen.Image) Then
            ImagenViewer.PictureBox1.Image = ptrImagen.Image
            Popup.PopupFrm(ImagenViewer, 0)
        End If
    End Sub

    Private Sub btnBuscar_imagen_Click(sender As Object, e As EventArgs) Handles btnbuscar_imagen.Click
        ptrImagen.Image = Abrir_Imagen()
    End Sub

    Private Sub P_usuario_N_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txttipo.SelectedIndex = -1
        txtnombre.Focus()
    End Sub

    Private Sub txtTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txttipo.SelectedIndexChanged
        btnguardar.Focus()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint


    End Sub

    Private Sub txtid_usuario_TextChanged(sender As Object, e As EventArgs) Handles txtid_usuario.TextChanged

    End Sub

    Private Sub txtsexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtsexo.SelectedIndexChanged

    End Sub
End Class