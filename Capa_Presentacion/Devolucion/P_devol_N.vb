Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_devol_N
    Dim Elemento As New Capa_Negocios.N_devolucion
    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim _devolucion As New E_devolucion
        _devolucion.id_venta = txtid_venta.Text
        _devolucion.id_articulo = txtid_articulo.Text
        _devolucion.motivo = txtmotivo.Text
        _devolucion.accion = Txtaccion.Text
        _devolucion.descripcion = Txtdescripcion.Text
        If Elemento.Insertar(_devolucion) Then
            M("¡El articulo ha sido agregado con exito!", 1)
        Else
            M("¡No se ha podido agregar el producto!", 3)
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
        txtid_venta.Text = ""
        txtid_articulo.Text = ""
        txtmotivo.Text = ""
        Txtaccion.Text = ""
        Txtdescripcion.Text = ""
        txtcantidad.Text = ""
        Campos(False)
        txtid_venta.Focus()
    End Sub

    Sub Campos(ByVal Valor As Boolean)
        txtid_venta.Enabled = Not Valor
        txtid_articulo.Enabled = Valor
        txtmotivo.Enabled = Valor
        Txtaccion.Enabled = Valor
        Txtdescripcion.Enabled = Valor
        txtcantidad.Enabled = Valor
        btnlimpiar_campos.Enabled = Valor
        btnguardar.Enabled = Valor
    End Sub
#End Region


    Private Sub txtid_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid_venta.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtid_venta.Text) > 2 Then
            Campos(True)
            txtid_articulo.Focus()


        End If
    End Sub

    Private Sub txtid_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid_articulo.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtid_articulo.Text) > 2 Then
            Campos(True)
            txtmotivo.Focus()


        End If
    End Sub

    Private Sub txtmotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmotivo.KeyPress
        If e.KeyChar = ChrW(13) Then
            Txtaccion.Focus()
        Else
            Validar_Texto(txtmotivo, e)
        End If
    End Sub

    Private Sub txtaccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtaccion.KeyPress
        If e.KeyChar = ChrW(13) Then
            Txtdescripcion.Focus()
        Else
            Validar_Texto(Txtaccion, e)
        End If
    End Sub


    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdescripcion.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnguardar.Focus()
        Else
            Validar_Texto(Txtdescripcion, e)
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

End Class