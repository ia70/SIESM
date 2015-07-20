Public Class P_usuario_EL
    Dim Elemento As New Capa_Negocios.N_usuario
    Dim Tabla As New DataSet

    Private Sub P_usuario_ED_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtConsulta.Focus()
    End Sub

    Private Sub dgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellContentClick

    End Sub

    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If txtid_usuario.Text = "" Or txtid_usuario.Text = Elemento.Inicio.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Final()
            LlenarCampos()
        ElseIf Elemento.Existe(txtid_usuario.Text) Then
            Tabla = Elemento.Atras(txtid_usuario.Text)
            LlenarCampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If txtid_usuario.Text = "" Or txtid_usuario.Text = Elemento.Final.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Inicio()
            LlenarCampos()
        ElseIf Elemento.Existe(txtid_usuario.Text) Then
            Tabla = Elemento.Siguiente(txtid_usuario.Text)
            LlenarCampos()
        End If
    End Sub

#End Region

#Region "Cajas de texto"
    Private Sub txtid_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsulta.KeyPress
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
        txtid_usuario.Text = Tabla.Tables(0).Rows(0)(1).ToString()
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

    Sub LimpiarCampos()
        txtConsulta.Text = ""
        txtid_usuario.Text = ""
        txtcontraseña.Text = ""
        txtnombre.Text = ""
        Txtapellidos.Text = ""
        txtsexo.Text = ""
        txttipo.Text = ""
        ptrimagen.Image = Nothing
        txtConsulta.Focus()
    End Sub

#End Region

   

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Elemento.Eliminar(txtid_usuario.Text)
        Call btnAtras_Click(sender, e)
        M("¡Registro eliminado correctamente", 0)
        LimpiarCampos()
    End Sub

    Private Sub txtid_usuario_TextChanged(sender As Object, e As EventArgs) Handles txtid_usuario.TextChanged
        If Not txtid_usuario.Text = "" And Not btnEliminar.Enabled = True Then
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub ptrimagen_Click(sender As Object, e As EventArgs) Handles ptrimagen.Click
        If Not IsNothing(ptrimagen.Image) Then
            ImagenViewer.PictureBox1.Image = ptrimagen.Image
            Popup.PopupFrm(ImagenViewer, 0)
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtsexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtsexo.SelectedIndexChanged


    End Sub

    Private Sub txttipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txttipo.SelectedIndexChanged


    End Sub
End Class