Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_proveedor_ED
    Dim Elemento As New Capa_Negocios.N_proveedor
    Dim Tabla As New DataSet
    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim _Proveedor As New E_proveedor
        _Proveedor.id_proveedor = txtConsulta.Text
        _Proveedor.nombre = txtNombre.Text
        _Proveedor.direccion = txtDireccion.Text
        _Proveedor.descripcion = txtDescripcion.Text
        _Proveedor.telefono = txtTelefono.Text
        _Proveedor.fecha = getFecha()
        If Elemento.Editar(_Proveedor) Then
            M("¡El proveedor ha sido editado con exito!")
        Else
            M("¡No se ha podido editar el proveedor!", 2)
        End If
        Call btnlimpiar_campos_Click(sender, e)
    End Sub

    Private Sub btnlimpiar_campos_Click(sender As Object, e As EventArgs) Handles btnlimpiar_campos.Click
        LimpiarCampos()
    End Sub

    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If txtConsulta.Text = "" Or txtConsulta.Text = Elemento.Inicio.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Final()
            LlenarCampos()
        ElseIf Elemento.Existe(txtConsulta.Text) Then
            Tabla = Elemento.Atras(txtConsulta.Text)
            LlenarCampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If txtConsulta.Text = "" Or txtConsulta.Text = Elemento.Final.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Inicio()
            LlenarCampos()
        ElseIf Elemento.Existe(txtConsulta.Text) Then
            Tabla = Elemento.Siguiente(txtConsulta.Text)
            LlenarCampos()
        End If
    End Sub

#End Region
#Region "Funciones de validacion de campos"

    Sub LimpiarCampos()
        txtConsulta.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtDescripcion.Text = ""
        txtTelefono.Text = ""
        Campos(False)
        txtConsulta.Focus()
    End Sub

    Sub Campos(ByVal Valor As Boolean)
        txtConsulta.Enabled = Not Valor
        txtNombre.Enabled = Valor
        txtDireccion.Enabled = Valor
        txtDescripcion.Enabled = Valor
        txtTelefono.Enabled = Valor
        btnlimpiar_campos.Enabled = Valor
        btnguardar.Enabled = Valor
    End Sub

    Private Sub LlenarCampos()
        txtConsulta.Text = Tabla.Tables(0).Rows(0)(0).ToString()
        txtNombre.Text = Tabla.Tables(0).Rows(0)(1).ToString()
        txtDireccion.Text = Tabla.Tables(0).Rows(0)(2).ToString()
        txtDescripcion.Text = Tabla.Tables(0).Rows(0)(3).ToString()
        txtTelefono.Text = Tabla.Tables(0).Rows(0)(4).ToString()
        txtNombre.Focus()
        Campos(True)
    End Sub
#End Region
#Region "Cajas de texto"
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


    Private Sub txtConsulta_TextChanged(sender As Object, e As EventArgs) Handles txtConsulta.TextChanged
        If Not IsNumeric(txtConsulta.Text) And Not txtConsulta.Text = "" Then
            dgvTabla.DataSource = Elemento.Filtrar(txtConsulta.Text).Tables(0)
        ElseIf txtConsulta.Text = "" Then
            dgvTabla.DataSource = ""
        End If
    End Sub

    Private Sub dgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellContentClick

    End Sub

    Private Sub dgvTabla_Click(sender As Object, e As EventArgs) Handles dgvTabla.Click
        Tabla = Elemento.Consultar(dgvTabla.Item(0, dgvTabla.CurrentRow.Index).Value)
        LlenarCampos()
    End Sub

#End Region

End Class