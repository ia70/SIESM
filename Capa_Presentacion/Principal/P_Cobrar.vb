Public Class P_Cobrar

    Private Sub P_Cobrar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        P_PuntoVenta.NuevaVenta()
    End Sub

    Private Sub P_Cobrar_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        'P_PuntoVenta.NuevaVenta()
        'Me.Close()
    End Sub
    Private Sub P_Cobrar_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TxtCambio.Text = "$" + G_PuntoVenta_Cambio
        txtTotal.Text = "$" + ToDecimal(G_PuntoVenta_Total).ToString
        txtEfectivo.Text = "$" + ToDecimal(G_PuntoVenta_Monto).ToString
    End Sub

End Class