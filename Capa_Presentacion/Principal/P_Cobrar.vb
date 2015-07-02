Public Class P_Cobrar

    Private Sub P_Cobrar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        P_PuntoVenta.NuevaVenta()
    End Sub

    Private Sub P_Cobrar_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        'P_PuntoVenta.NuevaVenta()
        'Me.Close()
    End Sub
    Private Sub P_Cobrar_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtEfectivo.Text = "$" + ToDecimal(G_PuntoVenta_Monto).ToString
        txtTotal.Text = "$" + ToDecimal(G_PuntoVenta_Total).ToString
        If CInt(G_PuntoVenta_Monto) = 0 Then
            TxtCambio.Text = "$0"
        Else
            TxtCambio.Text = "$" + ToDecimal(G_PuntoVenta_Monto - G_PuntoVenta_Total).ToString
        End If

    End Sub

End Class