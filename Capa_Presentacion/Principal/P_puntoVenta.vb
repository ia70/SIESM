Public Class P_PuntoVenta

    Private Sub P_PuntoVenta_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        P_NavBar.Location = New Point(22, (Me.Height - P_NavBar.Height) / 2)
        PInfoVenta.Location = New Point(Me.Width - PInfoVenta.Width, (Me.Height - PInfoVenta.Height) / 2)
        dgvTabla.Width = (Me.Width - (dgvTabla.Location.X + PInfoVenta.Width + 30))
    End Sub

    Private Sub P_PuntoVenta_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtFecha.Text = Date.Today.Date.ToString("dd/MM/yyyy")
        With dgvTabla.ColumnHeadersDefaultCellStyle
            .Font = New Font("Arial", 18, FontStyle.Bold)
            .ForeColor = Color.Black
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Yellow
            .SelectionBackColor = Color.Black
        End With
        With dgvTabla.RowsDefaultCellStyle
            .Font = New Font("Arial", 18)
            .ForeColor = Color.Black
            .BackColor = Color.White
            .SelectionForeColor = Color.White
            .SelectionBackColor = Color.LightBlue
        End With
        With dgvTabla.RowTemplate.DefaultCellStyle
            .Font = New Font("Arial", 18)
            .ForeColor = Color.Black
            .BackColor = Color.White
            .SelectionForeColor = Color.White
            .SelectionBackColor = Color.LightBlue
        End With

        txtArticulo.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtHora.Text = String.Format("{0:HH:mm:ss tt}", DateTime.Now)
    End Sub

End Class