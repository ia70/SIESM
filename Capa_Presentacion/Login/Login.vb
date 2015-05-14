
Imports Capa_Negocios


Public Class Login

    Dim usuario As New N_usuario
    Dim tabla As DataSet





    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        If usuario.Existe(txtusuario.Text) Then
            tabla = usuario.Consultar(txtusuario.Text)
            If tabla.Tables(0).Rows(0)(2).ToString() = Txtpassword.Text Then
                M("Usuario Correcto", 1)
            Else
                M("Usuario Incorrecto", 2)
            End If
        Else
            MsgBox("¡El usuario es incorrecto!", vbOKOnly + vbCritical, "SIESM")
        End If


    End Sub

    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub
End Class