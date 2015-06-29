Public Class P_CajaInicio

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If txtInicioCaja.Text = "" Then
            G_PuntoVenta_InicioCaja = 0.0
        Else
            G_PuntoVenta_InicioCaja = Val(txtInicioCaja.Text)
        End If
        P_PuntoVenta.Show()
        Me.Close()
    End Sub

    Private Sub txtInicioCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInicioCaja.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btnContinuar_Click(sender, e)
        End If
    End Sub

    Private Sub txtInicioCaja_TextChanged(sender As Object, e As EventArgs) Handles txtInicioCaja.TextChanged

    End Sub
End Class