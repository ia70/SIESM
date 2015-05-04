Public Class P_puntoVenta

    Private Sub InsertarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarToolStripMenuItem.Click
        P_articulo_N.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        P_articulo_C.ShowDialog()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        P_articulo_ED.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        P_articulo_EL.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Popup.Show()
        Popup.PopupFrm(ImagenViewer, 1)
    End Sub
End Class