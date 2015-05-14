Public Class P_PuntoVenta

    Private Sub P_PuntoVenta_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        P_NavBar.Location = New Point(22, (Me.Height - P_NavBar.Height) / 2)
    End Sub

End Class