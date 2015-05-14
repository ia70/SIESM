Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_merma_N
    Dim Elemento As New Capa_Negocios.N_merma
    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim _merma As New E_merma
        _merma.id_articulo = txtid_articulo.Text
        _merma.id_sucursal = txtid_sucursal.Text
        _merma.id_usuario = "paco"
        _merma.motivo = txtmotivo.Text
        _merma.cantidad = txtcantidad.Text
        _merma.fecha = getFecha()
        _merma.hora = Now.ToString("HH:mm:ss")
        If Elemento.Insertar(_merma) Then
            M("¡El articulo ha sido agregado con exito!", 1)
        Else
            M("¡No se ha podido agregar el articulo!", 3)
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
        txtid_articulo.Text = ""
        txtid_sucursal.Text = ""
        txtmotivo.Text = ""
        txtcantidad.Text = ""
        Campos(False)
        txtid_articulo.Focus()
    End Sub

    Sub Campos(ByVal Valor As Boolean)
        txtid_articulo.Enabled = Not Valor
        txtid_sucursal.Enabled = Not Valor
        txtmotivo.Enabled = Valor
        txtcantidad.Enabled = Valor       
        btnlimpiar_campos.Enabled = Valor
        btnguardar.Enabled = Valor
    End Sub
#End Region

    Private Sub txtid_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid_articulo.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtid_articulo.Text) > 2 Then
            Campos(True)
            txtid_sucursal.Focus()
        End If
    End Sub
    Private Sub txtid_sucusal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid_sucursal.KeyPress
        If e.KeyChar = ChrW(13) And Len(txtid_sucursal.Text) > 2 Then
            Campos(True)
            txtmotivo.Focus()
        End If
    End Sub

    Private Sub txtmotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmotivo.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtcantidad.Focus()
        Else
            Validar_Texto(txtmotivo, e)
        End If
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnguardar.Focus()
        End If
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

End Class