Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_sucursal_ED
    Dim Elemento As New Capa_Negocios.N_sucursal
    Dim Tabla As New DataSet

    Private Sub P_articulo_ED_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtConsulta.Focus()
    End Sub

    Private Sub dgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellContentClick
        Tabla = Elemento.Consultar(dgvTabla.Item(0, dgvTabla.CurrentRow.Index).Value)
        LlenarCampos()
        Campos(True)
    End Sub

    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If txtid_sucursal.Text = "" Or txtid_sucursal.Text = Elemento.Inicio.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Final()
            LlenarCampos()
            Campos(True)
        ElseIf Elemento.Existe(txtid_sucursal.Text) Then
            Tabla = Elemento.Atras(txtid_sucursal.Text)
            LlenarCampos()
            Campos(True)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If txtid_sucursal.Text = "" Or txtid_sucursal.Text = Elemento.Final.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Inicio()
            LlenarCampos()
            Campos(True)
        ElseIf Elemento.Existe(txtid_sucursal.Text) Then
            Tabla = Elemento.Siguiente(txtid_sucursal.Text)
            LlenarCampos()
            Campos(True)
        End If
    End Sub

#End Region

#Region "Cajas de texto"
    Private Sub txtconsulta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsulta.KeyPress
        If IsNumeric(txtConsulta.Text) Then
            If Len(txtConsulta.Text) > 4 And e.KeyChar = ChrW(13) And IsNumeric(txtConsulta.Text) Then
                Tabla = Elemento.Consultar(txtConsulta.Text)
                If Tabla.Tables(0).Rows.Count = 0 Then
                    M("El articulo solicitado no existe", 3)
                    txtConsulta.Text = ""
                    txtConsulta.Focus()
                Else
                    txtConsulta.Text = ""
                    LlenarCampos()
                    Campos(True)
                End If
            Else
                Validar_Num(e)
            End If
        End If
    End Sub

    Private Sub txtConsulta_TextChanged(sender As Object, e As EventArgs) Handles txtConsulta.TextChanged
        If Not IsNumeric(txtConsulta.Text) And Not txtConsulta.Text = "" Then
            dgvTabla.DataSource = Elemento.Filtrar(txtConsulta.Text).Tables(0)
        ElseIf txtConsulta.Text = "" Then
            dgvTabla.DataSource = ""
        End If
    End Sub

#End Region

#Region "Funciones de validacion de campos"
    Private Sub LlenarCampos()
        On Error Resume Next
        txtid_sucursal.Text = Tabla.Tables(0).Rows(0)(0).ToString()
        txtNombre.Text = Tabla.Tables(0).Rows(0)(1).ToString()
        Txtdescripcion.Text = Tabla.Tables(0).Rows(0)(3).ToString()
        txtdireccion.Text = Tabla.Tables(0).Rows(0)(2).ToString()
        txttelefono.Text = Tabla.Tables(0).Rows(0)(4).ToString()
        txtTipo.Text = Tabla.Tables(0).Rows(0)(6).ToString()
        txtfecha.Text = Date.Today
        ptrimagen.Image = Nothing
        On Error Resume Next
        ptrimagen.Image = Bytes_Imagen(Tabla.Tables(0).Rows(0)(5))
        txtConsulta.Focus()
    End Sub

    Sub Campos(ByVal Valor As Boolean)
        txtNombre.Enabled = Valor
        txtDireccion.Enabled = Valor
        txtDescripcion.Enabled = Valor
        txttelefono.Enabled = Valor
        txtTipo.Enabled = Valor
        btnlimpiar_campos.Enabled = Valor
        btnBuscar_imagen.Enabled = Valor
        btnguardar.Enabled = Valor
        txtTipo.Enabled = Valor
    End Sub

    Sub LimpiarCampos()
        txtid_sucursal.Text = ""
        txtNombre.Text = ""
        txtdireccion.Text = ""
        Txtdescripcion.Text = ""
        txttelefono.Text = ""
        txtTipo.SelectedIndex = -1
        ptrimagen.Image = Nothing
        txtfecha.Text = ""
        Campos(False)
        txtConsulta.Focus()
    End Sub
#End Region

    Private Sub ptrimagen_Click(sender As Object, e As EventArgs)
        If Not IsNothing(ptrimagen.Image) Then
            ImagenViewer.PictureBox1.Image = ptrimagen.Image
            Popup.PopupFrm(ImagenViewer, 0)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Sucursal As New E_sucursal
        _Sucursal.id_sucursal = txtid_sucursal.Text
        _Sucursal.nombre = txtNombre.Text
        _Sucursal.direccion = txtdireccion.Text
        _Sucursal.descripcion = Txtdescripcion.Text
        _Sucursal.telefono = txttelefono.Text
        _Sucursal.fecha = getFecha()
        _Sucursal.imagen = Imagen_Bytes(ptrimagen.Image)
        _Sucursal.tipo = txtTipo.Text
        If Elemento.Editar(_Sucursal) Then
            M("¡La sucursal ha sido editada con exito!", 1)
        Else
            M("¡No se ha podido editar la sucursal!", 3)
        End If

    End Sub

    Private Sub btnBuscar_imagen_Click(sender As Object, e As EventArgs) Handles btnBuscar_imagen.Click
        ptrimagen.Image = Abrir_Imagen()
    End Sub

    Private Sub ptrimagen_Click_1(sender As Object, e As EventArgs) Handles ptrimagen.Click
        If Not IsNothing(ptrimagen.Image) Then
            ImagenViewer.PictureBox1.Image = ptrimagen.Image
            Popup.PopupFrm(ImagenViewer, 0)
        End If
    End Sub

    Private Sub btnlimpiar_campos_Click(sender As Object, e As EventArgs) Handles btnlimpiar_campos.Click
        LimpiarCampos()
    End Sub
End Class