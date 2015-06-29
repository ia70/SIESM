
Imports Capa_Negocios

Public Class Login

    Dim usuario As New N_usuario
    Dim tabla As DataSet

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If usuario.Existe(txtusuario.Text) Then
            tabla = usuario.Consultar(txtusuario.Text)
            If tabla.Tables(0).Rows(0)(2).ToString() = Txtpassword.Text Then
                P_CajaInicio.Show()
                G_Usuario_Nombre = tabla.Tables(0).Rows(0)(3).ToString()
                G_Usuario_Apellidos = tabla.Tables(0).Rows(0)(4).ToString()
                G_Usuario_Tipo = tabla.Tables(0).Rows(0)(6).ToString()
                G_Usuario_id = txtusuario.Text
                Me.Close()
            Else
                M("Usuario Incorrecto", 2)
                Txtpassword.Text = ""
                txtusuario.Text = ""
                txtusuario.Focus()
            End If
        Else
            MsgBox("¡El usuario es incorrecto!", vbOKOnly + vbCritical, "SIESM")
        End If

    End Sub

    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        If e.KeyChar = Chr(13) Then
            Txtpassword.Focus()
        End If
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub Txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btnentrar_Click(sender, e)
        End If
    End Sub

    Private Sub Txtpassword_TextChanged(sender As Object, e As EventArgs) Handles Txtpassword.TextChanged

    End Sub
End Class