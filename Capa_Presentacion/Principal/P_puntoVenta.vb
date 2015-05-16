Imports Capa_Negocios
Public Class P_PuntoVenta
    Private Tabla As DataSet
    Private Elemento As New N_Articulo
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
        dgvTabla.ScrollBars = ScrollBars.Both

        txtTipo_Pago.SelectedIndex = 0
        txtTransacción.SelectedIndex = 0

        txtArticulo.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtHora.Text = String.Format("{0:HH:mm:ss tt}", DateTime.Now)
    End Sub

    Private Sub txtArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArticulo.KeyPress
        Dim existe As Boolean = True
        If Len(txtArticulo.Text) > 4 And e.KeyChar = ChrW(13) And IsNumeric(txtArticulo.Text) Then
            For i As Integer = 0 To dgvTabla.Rows.Count - 1
                If dgvTabla.Item(0, i).Value = txtArticulo.Text Then
                    existe = False
                    dgvTabla.Item(2, i).Value += 1
                    txtArticulo.Text = ""
                    txtArticulo.Focus()
                End If
            Next
            If existe Then
                Tabla = Elemento.Consultar(txtArticulo.Text)
                If Tabla.Tables(0).Rows.Count = 0 Then
                    M("El articulo solicitado no existe", 3)
                    txtArticulo.Text = ""
                    txtArticulo.Focus()
                Else
                    txtArticulo.Text = ""
                    LlenarCampos()
                End If
            Else
                Subtotales()
            End If
        Else
            Validar_Num(e)
        End If
    End Sub

    Private Sub LlenarCampos()
        Dim Fila As Integer
        Fila = dgvTabla.Rows.Count - 1
        If Tabla.Tables(0).Rows.Count > 0 Then
            dgvTabla.Rows.Add()
            txtCantidad.Value = 1
            dgvTabla.Item(0, Fila).Value = Tabla.Tables(0).Rows(0)(0).ToString()
            dgvTabla.Item(1, Fila).Value = Tabla.Tables(0).Rows(0)(2).ToString()
            dgvTabla.Item(2, Fila).Value = "1"
            dgvTabla.Item(3, Fila).Value = Tabla.Tables(0).Rows(0)(6).ToString()
            Subtotales()
        End If

    End Sub

    Private Sub Subtotales()
        Dim Filas As Integer
        Filas = dgvTabla.Rows.Count
        G_PuntoVenta_Total = 0
        For i As Integer = 0 To (Filas - 1)
            If Not dgvTabla.Item(0, i).Value = "" Then
                If dgvTabla.Item(2, i).Value = 0 Or dgvTabla.Item(2, i).Value.ToString = "" Then
                    dgvTabla.Item(2, i).Value = "1"
                    dgvTabla.Item(4, i).Value = ToDecimal(CDec(dgvTabla.Item(2, i).Value) * CDec(dgvTabla.Item(3, i).Value)).ToString
                    G_PuntoVenta_Total += dgvTabla.Item(4, i).Value
                Else
                    dgvTabla.Item(4, i).Value = ToDecimal(CDec(dgvTabla.Item(2, i).Value) * CDec(dgvTabla.Item(3, i).Value)).ToString
                    G_PuntoVenta_Total += dgvTabla.Item(4, i).Value
                End If
            End If
        Next
        txtTotal.Text = ToDecimal(G_PuntoVenta_Total)
    End Sub

    Private Sub dgvTabla_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellEndEdit
        Subtotales()
    End Sub

    Private Sub dgvTabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvTabla.KeyPress
        e = Validar_Num(e)
    End Sub

    Private Sub dgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellContentClick

    End Sub

    Private Sub dgvTabla_LostFocus(sender As Object, e As EventArgs) Handles dgvTabla.LostFocus

    End Sub

    Private Sub EliminarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRegistroToolStripMenuItem.Click
        On Error Resume Next
        dgvTabla.Rows.Remove(dgvTabla.CurrentRow)
        Subtotales()
    End Sub

    Private Sub BorrarTodaLaTablaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodaLaTablaToolStripMenuItem.Click
        dgvTabla.Rows.Clear()
        G_PuntoVenta_Total = 0
        txtTotal.Text = "0.00"
    End Sub

    Private Sub txtArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtArticulo.TextChanged

    End Sub

    Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.ValueChanged
        If dgvTabla.Rows.Count > 1 Then
            dgvTabla.Item(2, (dgvTabla.Rows.Count - 2)).Value = txtCantidad.Value.ToString
            Subtotales()
        End If
        txtArticulo.Focus()
    End Sub
End Class