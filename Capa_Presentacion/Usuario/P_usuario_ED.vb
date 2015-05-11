Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_usuario_ED
    Dim Elemento As New Capa_Negocios.N_usuario
    Dim Tabla As New DataSet

    Private Sub P_usuario_ED_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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
        If Txtid.Text = "" Or Txtid.Text = Elemento.Inicio.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Final()
            LlenarCampos()
        ElseIf Elemento.Existe(txtusuario.Text) Then
            Tabla = Elemento.Atras(Txtid.Text)
            LlenarCampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If Txtid.Text = "" Or Txtid.Text = Elemento.Final.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Inicio()
            LlenarCampos()
        ElseIf Elemento.Existe(txtusuario.Text) Then
            Tabla = Elemento.Siguiente(Txtid.Text)
            LlenarCampos()
        End If
    End Sub

#End Region

#Region "Cajas de texto"
    Private Sub txtconsulta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsulta.KeyPress
        If IsNumeric(txtConsulta.Text) Then
            If Len(txtConsulta.Text) > 4 And e.KeyChar = ChrW(13) And IsNumeric(txtConsulta.Text) Then
                Tabla = Elemento.Consultar(txtConsulta.Text)
                If Tabla.Tables(0).Rows.Count = 0 Then
                    M("El usuario solicitado no existe", 3)
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
        Txtid.Text = Tabla.Tables(0).Rows(0)(0).ToString()
        txtusuario.Text = Tabla.Tables(0).Rows(0)(1).ToString()
        txtcontraseña.Text = Tabla.Tables(0).Rows(0)(2).ToString()
        txtnombre.Text = Tabla.Tables(0).Rows(0)(3).ToString()
        Txtapellidos.Text = Tabla.Tables(0).Rows(0)(4).ToString()
        If Tabla.Tables(0).Rows(0)(5).ToString() = "F" Then
            txtsexo.SelectedIndex = 0
        Else
            txtsexo.SelectedIndex = 1
        End If
        If Tabla.Tables(0).Rows(0)(6).ToString() = "F" Then
            txttipo.SelectedIndex = 0
        Else
            txttipo.SelectedIndex = 1
        End If

        'Txtfecha.Text = Date.Today
        ptrimagen.Image = Nothing
        On Error Resume Next
        ptrimagen.Image = Bytes_Imagen(Tabla.Tables(0).Rows(0)(7))
        txtConsulta.Focus()
    End Sub

    Sub Campos(ByVal Valor As Boolean)
        txtusuario.Enabled = Valor
        txtcontraseña.Enabled = Valor
        txtnombre.Enabled = Valor
        Txtapellidos.Enabled = Valor
        txtsexo.Enabled = Valor
        txttipo.Enabled = Valor
        ptrimagen.Enabled = Valor
        Txtfecha.Enabled = Valor
        btnguardar.Enabled = Valor
    End Sub

    Sub LimpiarCampos()
        txtusuario.Text = ""
        txtcontraseña.Text = ""
        txtnombre.Text = ""
        Txtapellidos.Text = ""
        txtsexo.Text = ""
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
        Dim _Usuario As New E_usuario
        _Usuario.id_usuario = txtusuario.Text
        _Usuario.contrasena = txtcontraseña.Text
        _Usuario.nombre = txtnombre.Text
        _Usuario.apellidos = Txtapellidos.Text
        _Usuario.sexo = txtsexo.Text
        _Usuario.tipo = txttipo.SelectedIndex.ToString
        _Usuario.fecha = getFecha()
        _Usuario.imagen = Imagen_Bytes(ptrimagen.Image)
        If Elemento.Editar(_Usuario) Then
            M("¡El usuario ha sido editado con exito!", 1)
        Else
            M("¡No se ha podido editar el usuario!", 3)
        End If

    End Sub

    Private Sub ptrimagen_Click_1(sender As Object, e As EventArgs) Handles ptrimagen.Click
        If Not IsNothing(ptrimagen.Image) Then
            ImagenViewer.PictureBox1.Image = ptrimagen.Image
            Popup.PopupFrm(ImagenViewer, 0)
        End If
    End Sub

    Private Sub txttipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txttipo.SelectedIndexChanged

    End Sub
End Class