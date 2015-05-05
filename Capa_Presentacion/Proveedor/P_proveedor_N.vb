Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_proveedor_N
    Dim Proveedor As New Capa_Negocios.N_proveedor
    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim _Proveedor As New E_proveedor
        _Proveedor.nombre = txtNombre.Text
        _Proveedor.direccion = txtDireccion.Text
        _Proveedor.descripcion = txtDescripcion.Text
        _Proveedor.telefono = txtTelefono.Text
        _Proveedor.fecha = Date.Today.ToString
        If Proveedor.Insertar(_Proveedor) Then
            M("¡El proveedor ha sido guardado con exito!", 1)
        Else
            M("¡No se ha podido guardar el proveedor!", 3)
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
    End Sub
#End Region


    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtNombre.Text) > 4 Then
            Campos(True)
            txtDireccion.Focus()
        Else
            Validar_Nombres(txtNombre, e)
        End If
    End Sub
End Class