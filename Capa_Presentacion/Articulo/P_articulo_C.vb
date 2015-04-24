Imports Capa_Negocios
Public Class P_articulo_C
    Dim Articulo As New N_articulo
    Dim Tabla As New DataSet
    Private Sub txtid_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtconsulta.KeyPress
        If Len(txtconsulta.Text) > 4 And e.KeyChar = ChrW(13) Then
            Tabla = Articulo.Consulta(txtconsulta.Text)
            txtconsulta.Text = ""
            If Tabla.Tables(0).Rows.Count = 0 Then
                M("El articulo solicitado no existe", 3)
            Else
                txtIdarticulo.Text = Tabla.Tables(0).Rows(0)(0).ToString()
                txtnombre_corto.Text = Tabla.Tables(0).Rows(0)(1).ToString()
                txtnombre_largo.Text = Tabla.Tables(0).Rows(0)(2).ToString()
                txtdescripcion.Text = Tabla.Tables(0).Rows(0)(3).ToString()
                ptrimagen.Image = Nothing
                On Error Resume Next
                ptrimagen.Image = Articulo.Bytes_Imagen(Tabla.Tables(0).Rows(0)(4))
                txtFecha.Text = Tabla.Tables(0).Rows(0)(5).ToString()
                txtconsulta.Focus()
            End If
            'ElseIf (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Not Char.IsControl(e.KeyChar) Then
            'e.KeyChar = Nothing
        Else
            Validar_Num(e)
        End If
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub P_articulo_C_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtconsulta.Focus()
    End Sub

    Private Sub Articulo_C_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call cargaArticulos()
    End Sub

    Sub cargaArticulos()
        Dim capaNegocio As New N_articulo
        dgvarticulos.DataSource = capaNegocio.Listado.Tables("Articulos")
    End Sub

    Private Sub dgvarticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvarticulos.CellClick
        llenarCampos()
    End Sub

    Sub llenarCampos()
        Try
            txtIdArticulo.Text = dgvarticulos.Item(0, dgvarticulos.CurrentRow.Index).Value.ToString
            txtnombre_corto.Text = dgvarticulos.Item(1, dgvarticulos.CurrentRow.Index).Value.ToString
            txtnombre_largo.Text = dgvarticulos.Item(2, dgvarticulos.CurrentRow.Index).Value.ToString
            txtdescripcion.Text = dgvarticulos.Item(3, dgvarticulos.CurrentRow.Index).Value.ToString
            txtFecha.Text = dgvarticulos.Item(5, dgvarticulos.CurrentRow.Index).Value.ToString
            ptrimagen.Image = Nothing
            ptrimagen.Image = Articulo.Bytes_Imagen(dgvarticulos.Item(4, dgvarticulos.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvarticulos_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvarticulos.CurrentCellChanged
        llenarCampos()
        txtconsulta.Focus()
    End Sub

    Private Sub txtid_articulo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub P_articulo_C_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtconsulta.Focus()
    End Sub
End Class