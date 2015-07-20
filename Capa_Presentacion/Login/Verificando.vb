Public Class Verificando

    Private Sub Verificando_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Login.VerificarConexion()
        Me.Close()
    End Sub
End Class