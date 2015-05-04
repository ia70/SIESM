Public Class PantallaOscora

    Private Sub PantallaOscora_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Me.Close()
    End Sub

    Public Sub Formulario(ByVal Frm As Form, ByVal Valor As Integer)
        If Not Valor Then
            Frm.Show()
        Else
            Frm.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class