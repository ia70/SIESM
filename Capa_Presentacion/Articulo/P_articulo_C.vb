Imports Capa_Negocios
Public Class P_articulo_C
    Dim Elemento As New Capa_Negocios.N_Articulo
    Dim Tabla As New DataSet

    Private Sub P_articulo_ED_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtConsulta.Focus()
    End Sub

    Private Sub dgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellContentClick
        Tabla = Elemento.Consultar(dgvTabla.Item(0, dgvTabla.CurrentRow.Index).Value)
        LlenarCampos()
    End Sub

    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If txtid_articulo.Text = "" Or Len(txtid_articulo.Text) < 5 Or txtid_articulo.Text = Elemento.Inicio.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Final()
            LlenarCampos()
        ElseIf Elemento.Existe(txtid_articulo.Text) Then
            Tabla = Elemento.Atras(txtid_articulo.Text)
            LlenarCampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If txtid_articulo.Text = "" Or Len(txtid_articulo.Text) < 5 Or txtid_articulo.Text = Elemento.Final.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Inicio()
            LlenarCampos()
        ElseIf Elemento.Existe(txtid_articulo.Text) Then
            Tabla = Elemento.Siguiente(txtid_articulo.Text)
            LlenarCampos()
        End If
    End Sub

#End Region

#Region "Cajas de texto"
    Private Sub txtid_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsulta.KeyPress
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
        txtid_articulo.Text = Tabla.Tables(0).Rows(0)(0).ToString()
        txtNombre.Text = Tabla.Tables(0).Rows(0)(1).ToString()
        txtdescripcion.Text = Tabla.Tables(0).Rows(0)(2).ToString()
        txtNivel_critico.Text = Tabla.Tables(0).Rows(0)(3).ToString()
        txtUnidad_medida.Text = Tabla.Tables(0).Rows(0)(4).ToString()
        txtPrecio_compra.Text = Tabla.Tables(0).Rows(0)(5).ToString()
        txtPrecio_venta.Text = Tabla.Tables(0).Rows(0)(6).ToString()
        If Tabla.Tables(0).Rows(0)(9).ToString = "1" Then
            txtIva.Checked = True
        Else
            txtIva.Checked = False
        End If
        ptrimagen.Image = Nothing
        On Error Resume Next
        ptrimagen.Image = Bytes_Imagen(Tabla.Tables(0).Rows(0)(7))
        txtConsulta.Focus()
    End Sub
#End Region

    Private Sub ptrimagen_Click(sender As Object, e As EventArgs) Handles ptrimagen.Click
        If Not IsNothing(ptrimagen.Image) Then
            ImagenViewer.PictureBox1.Image = ptrimagen.Image
            Popup.PopupFrm(ImagenViewer, 0)
        End If
    End Sub
End Class