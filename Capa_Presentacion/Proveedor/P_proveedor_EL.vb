Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_proveedor_EL
    Dim Proveedor As New Capa_Negocios.N_proveedor
    Dim Tabla As New DataSet
    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If txtId_proveedor.Text = "" Or txtId_proveedor.Text = Proveedor.Inicio.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Proveedor.Final()
            LlenarCampos()
        ElseIf Proveedor.Existe(txtId_proveedor.Text) Then
            Tabla = Proveedor.Atras(txtId_proveedor.Text)
            LlenarCampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If txtId_proveedor.Text = "" Or txtId_proveedor.Text = Proveedor.Final.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Proveedor.Inicio()
            LlenarCampos()
        ElseIf Proveedor.Existe(txtId_proveedor.Text) Then
            Tabla = Proveedor.Siguiente(txtId_proveedor.Text)
            LlenarCampos()
        End If
    End Sub

#End Region

#Region "Funciones de validacion de campos"

    Private Sub LlenarCampos()
        txtId_proveedor.Text = Tabla.Tables(0).Rows(0)(0).ToString()
        txtNombre.Text = Tabla.Tables(0).Rows(0)(1).ToString()
        txtDireccion.Text = Tabla.Tables(0).Rows(0)(2).ToString()
        txtDescripcion.Text = Tabla.Tables(0).Rows(0)(3).ToString()
        txtTelefono.Text = Tabla.Tables(0).Rows(0)(4).ToString()
        txtFecha.Text = Tabla.Tables(0).Rows(0)(5).ToString()
    End Sub
#End Region

#Region "Cajas de texto"
    Private Sub txtConsulta_TextChanged(sender As Object, e As EventArgs) Handles txtConsulta.TextChanged
        If Not IsNumeric(txtConsulta.Text) And Not txtConsulta.Text = "" Then
            dgvTabla.DataSource = Proveedor.Filtrar(txtConsulta.Text).Tables(0)
        ElseIf txtConsulta.Text = "" Then
            dgvTabla.DataSource = ""
        End If
    End Sub

    Private Sub dgvTabla_Click(sender As Object, e As EventArgs) Handles dgvTabla.Click
        Tabla = Proveedor.Consultar(dgvTabla.Item(0, dgvTabla.CurrentRow.Index).Value)
        LlenarCampos()
    End Sub

#End Region

    Private Sub txtId_proveedor_TextChanged(sender As Object, e As EventArgs) Handles txtId_proveedor.TextChanged
        If txtId_proveedor.Text = "" Then
            btnEliminar.Enabled = False
        Else
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        btnAtras_Click(sender, e)
        Proveedor.Eliminar(txtId_proveedor.Text)
        txtConsulta.Text = ""
        txtConsulta.Focus()
    End Sub

End Class