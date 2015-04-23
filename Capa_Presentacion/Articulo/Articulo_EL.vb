Imports Capa_Negocios
Public Class Articulo_EL
    Dim Articulo As New CNarticulo
    Dim Tabla As New DataSet
    Private Sub txtid_articulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtconsulta.KeyPress
        If Len(txtconsulta.Text) > 4 And e.KeyChar = ChrW(13) Then
            Tabla = Articulo.consultarArticulo(txtconsulta.Text)
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
        Else
            Validar_Num(e)
        End If
    End Sub


    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        End
    End Sub
End Class