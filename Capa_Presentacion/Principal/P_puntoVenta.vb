Imports Capa_Negocios
Imports Libersoft
Imports Capa_Entidad
Public Class P_PuntoVenta
    Private Tabla As DataSet
    Private Venta As New N_venta
    Private VentaEntidad As New E_venta
    Private Elemento As New N_inventario
    Public Barcode As New cBarCode

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


        txtSucursal_Direccion.Text = G_Sucursal_Calle
        txtSucursal_Telefono.Text = G_Sucursal_Telefono



        txtTipo_Pago.SelectedIndex = 0
        txtTransacción.SelectedIndex = 0
        txtVendedor.Text = G_Usuario_Nombre + " " + G_Usuario_Apellidos
        txtArticulo.Focus()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtHora.Text = String.Format("{0:HH:mm:ss tt}", DateTime.Now)
    End Sub
    Private Sub LlenarCampos()
        Dim Fila As Integer
        Fila = dgvTabla.Rows.Count - 1
        If Tabla.Tables(0).Rows.Count > 0 Then

            dgvTabla.Rows.Add()
            txtCantidad.Value = 1
            dgvTabla.Item(0, Fila).Value = Tabla.Tables(0).Rows(0)(0).ToString()
            dgvTabla.Item("nombre_articulo", Fila).Value = Tabla.Tables(0).Rows(0)(1).ToString()
            dgvTabla.Item("cantidad", Fila).Value = "1"
            dgvTabla.Item("precio", Fila).Value = ToDecimal(Tabla.Tables(0).Rows(0)(2).ToString()).ToString
            dgvTabla.Item("nombre_corto", Fila).Value = Tabla.Tables(0).Rows(0)(4).ToString()
            dgvTabla.Item("precio_compra", Fila).Value = Tabla.Tables(0).Rows(0)(5).ToString()
            'MsgBox(dgvTabla.Item(0, 0).Value.ToString)
            Subtotales()
        End If

    End Sub
    Private Sub Subtotales()
        Dim Filas As Integer
        Filas = dgvTabla.Rows.Count
        G_PuntoVenta_Total = 0
        G_PuntoVenta_Descuento = "0"
        For i As Integer = 0 To (Filas - 1)
            If Not dgvTabla.Item("id_articulo", i).Value = "" Then
                On Error Resume Next
                If dgvTabla.Item("cantidad", i).Value = 0 Or dgvTabla.Item("cantidad", i).Value.ToString = "" Or Not IsNumeric(dgvTabla.Item("cantidad", i).Value) Then
                    dgvTabla.Item("cantidad", i).Value = "1"
                    If dgvTabla.Item("descuento", i).Value.ToString = "" Or Val(dgvTabla.Item("descuento", i).Value) = 0 Then
                        dgvTabla.Item("descuento", i).Value = ""
                        dgvTabla.Item("subtotal", i).Value = ToDecimal(Val(dgvTabla.Item("cantidad", i).Value) * Val(dgvTabla.Item("precio", i).Value))
                    Else
                        dgvTabla.Item("subtotal", i).Value = ToDecimal(Val(dgvTabla.Item("cantidad", i).Value) * Val(dgvTabla.Item("descuento", i).Value)).ToString
                        G_PuntoVenta_Descuento = Val((Val(dgvTabla.Item("precio", i).Value) - Val(dgvTabla.Item("descuento", i).Value)) * Val(dgvTabla.Item("cantidad", i).Value)).ToString
                    End If
                    G_PuntoVenta_Total += dgvTabla.Item("subtotal", i).Value
                Else
                    If Elemento.Query("SELECT existencia FROM inventario WHERE id_articulo = '" & dgvTabla.Item("id_articulo", i).Value & "' && id_sucursal = '" & G_Sucursal_nombre & "'").Tables(0).Rows(0)(0) < dgvTabla.Item("cantidad", i).Value Then
                        M("¡Existencia insuficiente del artículo!", 1)
                        dgvTabla.Item("cantidad", i).Value = Elemento.Query("SELECT existencia FROM inventario WHERE id_articulo = '" & dgvTabla.Item("id_articulo", i).Value & "' && id_sucursal = '" & G_Sucursal_nombre & "'").Tables(0).Rows(0)(0)
                    End If
                    If dgvTabla.Item("descuento", i).Value.ToString = "" Or Val(dgvTabla.Item("descuento", i).Value) = 0 Then
                        dgvTabla.Item("subtotal", i).Value = ToDecimal(Val(dgvTabla.Item("cantidad", i).Value) * Val(dgvTabla.Item("precio", i).Value)).ToString
                    Else
                        dgvTabla.Item("subtotal", i).Value = ToDecimal(Val(dgvTabla.Item("cantidad", i).Value) * Val(dgvTabla.Item("descuento", i).Value)).ToString
                        G_PuntoVenta_Descuento = Val((Val(dgvTabla.Item("precio", i).Value) - Val(dgvTabla.Item("descuento", i).Value)) * Val(dgvTabla.Item("cantidad", i).Value)).ToString
                    End If
                    G_PuntoVenta_Total += dgvTabla.Item("subtotal", i).Value
                End If
            End If
        Next
        txtTotal.Text = ToDecimal(G_PuntoVenta_Total)
    End Sub
    Private Sub dgvTabla_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellEndEdit
        Subtotales()
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
    Private Sub txtCantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidad.ValueChanged
        If dgvTabla.Rows.Count > 1 Then
            dgvTabla.Item("cantidad", (dgvTabla.Rows.Count - 2)).Value = txtCantidad.Value.ToString
            Subtotales()
        End If
        txtArticulo.Focus()
    End Sub
    Private Sub txtTransacción_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTransacción.SelectedIndexChanged
        If txtTransacción.SelectedIndex = 0 Then
            lbl_monto.Visible = True
            LblTipo_pago.Visible = True
            txtEfectivo.Visible = True
            txtTipo_Pago.Visible = True
            btnCobrar.Text = "Cobrar"
            txtFactura.Visible = True
        Else
            lbl_monto.Visible = False
            LblTipo_pago.Visible = False
            txtEfectivo.Visible = False
            txtTipo_Pago.Visible = False
            txtFactura.Visible = False
            btnCobrar.Text = "Cotizar"
        End If
        G_PuntoVenta_Transacción = txtTransacción.SelectedItem.ToString
    End Sub
    Private Sub txtTipo_Pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTipo_Pago.SelectedIndexChanged
        If txtTipo_Pago.SelectedIndex = 1 Then
            txtEfectivo.Text = txtTotal.Text
            txtEfectivo.Enabled = False
            G_PuntoVenta_Cambio = "0.00"
            btnCobrar.Focus()
        Else
            txtEfectivo.Enabled = True
            txtEfectivo.Focus()
        End If
    End Sub
    Private Sub txtEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEfectivo.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btnCobrar_Click(sender, e)
        End If
    End Sub
    Private Sub txtEfectivo_LostFocus(sender As Object, e As EventArgs) Handles txtEfectivo.LostFocus
        If Val(txtEfectivo.Text) > Val(txtTotal.Text) Then
            G_PuntoVenta_Cambio = ToDecimal(Val(txtEfectivo.Text) - Val(txtTotal.Text))
        ElseIf Val(txtEfectivo.Text) = Val(txtTotal.Text) Then
            G_PuntoVenta_Cambio = "0.00"
        End If
    End Sub
    Private Sub txtArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArticulo.KeyPress
        Dim existe As Boolean = True
        If e.KeyChar = Chr(13) And txtArticulo.Text = "" And dgvTabla.RowCount > 1 And txtTransacción.Text = "Cotización" Then
            Call btnCobrar_Click(sender, e)
            Exit Sub
        End If
        If e.KeyChar = Chr(13) And txtArticulo.Text = "" And dgvTabla.RowCount > 1 And txtTipo_Pago.Text = "Efectivo" Then
            txtEfectivo.Focus()
            Exit Sub
        ElseIf e.KeyChar = Chr(13) And txtArticulo.Text = "" And dgvTabla.RowCount > 1 And txtTipo_Pago.Text = "Cheque" Then
            btnCobrar_Click(sender, e)
            Exit Sub
        End If
        If Len(txtArticulo.Text) > 4 And e.KeyChar = ChrW(13) And IsNumeric(txtArticulo.Text) Then
            For i As Integer = 0 To dgvTabla.Rows.Count - 1
                If dgvTabla.Item("id_articulo", i).Value = txtArticulo.Text And Not txtArticulo.Text = "" Then
                    existe = False
                    dgvTabla.Item("cantidad", i).Value += 1
                    txtArticulo.Text = ""
                    txtArticulo.Focus()
                End If
            Next
            If existe Then
                Tabla = Elemento.Query("SELECT inventario.id_articulo,articulo.descripcion,articulo.precio_venta,inventario.existencia, articulo.nombre, articulo.precio_compra FROM inventario INNER JOIN articulo ON articulo.id_articulo = inventario.id_articulo WHERE inventario.id_articulo = '" & txtArticulo.Text & "' && id_sucursal = '" & G_Sucursal_nombre & "'")
                If Tabla.Tables(0).Rows.Count = 0 Then
                    M("¡El articulo solicitado no está dentro del inventario de esta sucursal!", 3)
                    txtArticulo.Text = ""
                    txtArticulo.Focus()
                ElseIf Tabla.Tables(0).Rows(0)(3).ToString = "0" Or Tabla.Tables(0).Rows(0)(3).ToString = "" Or Tabla.Tables(0).Rows(0)(3) = 0 Or Tabla.Tables(0).Rows(0)(3) = vbNull Then
                    M("¡Artículo agotado!", 1)
                    txtArticulo.Text = ""
                    txtArticulo.Focus()
                Else
                    txtArticulo.Text = ""
                    btnCobrar.Enabled = True
                    LlenarCampos()
                End If
            Else
                Subtotales()
            End If
            'Else
            '   Validar_Num(e)
        End If
    End Sub
    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        Dim Codigo As String
        Dim Ticket As New cTicket
        G_PuntoVenta_Transacción = txtTransacción.Text
        G_PuntoVenta_NumeroTicket = GenerarNumeroVenta()
        G_PuntoVenta_Monto = Val(txtEfectivo.Text)
        G_PuntoVenta_Total = Val(txtTotal.Text)
        G_PuntoVenta_Fecha = getFecha()
        G_PuntoVenta_Hora = getHora()
        If Val(txtEfectivo.Text) >= Val(txtTotal.Text) Then
            Codigo = GenerarNumeroVenta()
            'G_PuntoVenta_Monto = txtEfectivo.Text
            Ticket.BarCode_Ima = Barcode.CodigoDeBarra(G_PuntoVenta_NumeroTicket)
            Ticket.BarCode_Text = G_PuntoVenta_NumeroTicket
            Ticket.Transaccion = G_PuntoVenta_Transacción
            Ticket.TipoPago = txtTipo_Pago.Text
            Ticket.Tabla = dgvTabla
            Ticket.Logotipo = Image.FromFile("logotipo.bmp")
            Ticket.Efectivo = G_PuntoVenta_Monto
            Ticket.Descuento = G_PuntoVenta_Descuento
            Ticket.Fecha = G_PuntoVenta_Fecha
            Ticket.Hora = G_PuntoVenta_Hora
            Popup.PopupFrm(P_Cobrar)
            Ticket.ImprimirTicket()
            RegistrarVenta()
            'NuevaVenta()
        ElseIf txtTransacción.SelectedIndex = 1 Then
            Ticket.Transaccion = txtTransacción.Text
            Ticket.Tabla = dgvTabla
            Ticket.Fecha = G_PuntoVenta_Fecha
            Ticket.Hora = G_PuntoVenta_Hora
            Ticket.Descuento = G_PuntoVenta_Descuento
            Ticket.Logotipo = Image.FromFile("logotipo.bmp")
            Popup.PopupFrm(P_Cobrar)
            Ticket.ImprimirTicket()
            'NuevaVenta()
        Else
            M("¡Monto insuficiente para cubrir el total de la venta!", 1)
            txtEfectivo.Text = ""
            txtEfectivo.Focus()
        End If
        Ticket = Nothing
    End Sub
    Public Sub NuevaVenta()
        dgvTabla.Rows.Clear()
        btnCobrar.Text = "Cobrar"
        btnCobrar.Enabled = False
        txtEfectivo.Text = ""
        txtTotal.Text = ""
        txtTipo_Pago.SelectedIndex = 0
        txtTransacción.SelectedIndex = 0
        txtCantidad.Value = 1
        G_PuntoVenta_Monto = 0
        G_PuntoVenta_Total = 0
        G_PuntoVenta_Cambio = 0
        G_PuntoVenta_CantdadArticulos = 0
        G_PuntoVenta_TipoPago = "Efectivo"
        G_PuntoVenta_Transacción = "Venta"
        G_PuntoVenta_Descuento = ""
        txtArticulo.Focus()
    End Sub
    Private Function GenerarNumeroVenta() As String
        Dim Valor As String
        If Elemento.Query("SELECT id_reg FROM venta WHERE id_sucursal='" & G_Sucursal_nombre & "'").Tables(0).Rows.Count > 0 Then
            Valor = Format(Val(Venta.Final(G_Sucursal_nombre).Tables(0).Rows(0)(0) + 1), "00000").ToString
        Else
            Valor = Format(1, "00000").ToString
        End If

        Return Valor
    End Function
    Private Sub RegistrarVenta()
        Dim Existencia_ As Decimal
        Try
            If txtFactura.Checked = True Then
                txtFactura.Checked = False
                For i = 0 To dgvTabla.RowCount - 2
                    Existencia_ = Val(Elemento.Query("SELECT existencia FROM inventario WHERE id_articulo='" & dgvTabla.Item(0, i).Value & "' AND id_sucursal='" & G_Sucursal_nombre & "'").Tables(0).Rows(0)(0))
                    Existencia_ = Existencia_ - Val(dgvTabla.Item(2, i).Value)
                    Elemento.Query("UPDATE inventario SET existencia = " & Existencia_ & " WHERE id_articulo='" & dgvTabla.Item(0, i).Value & "' AND id_sucursal='" & G_Sucursal_nombre & "'")
                Next
            Else
                For i = 0 To dgvTabla.RowCount - 2
                    If dgvTabla.Item(4, i).Value = "" Then
                        Elemento.Query("INSERT INTO venta (id_venta, id_usuario, id_sucursal, id_articulo, transaccion, cantidad, precio_compra, precio_venta, fecha, hora) VALUES ('" & G_PuntoVenta_NumeroTicket.ToString & "', '" & G_Usuario_id.ToString & "', '" & G_Sucursal_nombre.ToString & "', '" & dgvTabla.Item(0, i).Value & "', '" & txtTransacción.Text & "', '" & dgvTabla.Item(2, i).Value & "', '" & dgvTabla.Item(7, i).Value & "', '" & dgvTabla.Item(3, i).Value & "', '" & G_PuntoVenta_Fecha & "', '" & G_PuntoVenta_Hora & "')")
                    Else
                        Elemento.Query("INSERT INTO venta (id_venta, id_usuario, id_sucursal, id_articulo, transaccion, cantidad, precio_compra, precio_venta, fecha, hora) VALUES ('" & G_PuntoVenta_NumeroTicket.ToString & "', '" & G_Usuario_id.ToString & "', '" & G_Sucursal_nombre.ToString & "', '" & dgvTabla.Item(0, i).Value & "', '" & txtTransacción.Text & "', '" & dgvTabla.Item(2, i).Value & "', '" & dgvTabla.Item(7, i).Value & "', '" & dgvTabla.Item(4, i).Value & "', '" & G_PuntoVenta_Fecha & "', '" & G_PuntoVenta_Hora & "')")
                    End If
                    Existencia_ = Val(Elemento.Query("SELECT existencia FROM inventario WHERE id_articulo='" & dgvTabla.Item(0, i).Value & "' AND id_sucursal='" & G_Sucursal_nombre & "'").Tables(0).Rows(0)(0))
                    Existencia_ = Existencia_ - Val(dgvTabla.Item(2, i).Value)
                    Elemento.Query("UPDATE inventario SET existencia = " & Existencia_ & " WHERE id_articulo='" & dgvTabla.Item(0, i).Value & "' AND id_sucursal='" & G_Sucursal_nombre & "'")
                Next
            End If
        Catch ex As Exception
            M("Error al registrar venta: " + ex.ToString)
        End Try
    End Sub
    Private Sub txtArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtArticulo.TextChanged
        If Not IsNumeric(txtArticulo.Text) And Not txtArticulo.Text = "" Then
            dgvConsulta.DataSource = Elemento.Filtrar(txtArticulo.Text, G_Sucursal_nombre).Tables(0)
        ElseIf txtArticulo.Text = "" Then
            dgvConsulta.DataSource = ""
        End If
    End Sub
    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If txtTipo_Pago.Text = "Cheque" Then
            txtEfectivo.Text = txtTotal.Text
        End If
    End Sub
    Private Sub dgvConsulta_DoubleClick(sender As Object, e As EventArgs) Handles dgvConsulta.DoubleClick
        Tabla = Elemento.Query("SELECT inventario.id_articulo,articulo.descripcion,articulo.precio_venta,inventario.existencia, articulo.nombre, articulo.precio_compra FROM inventario INNER JOIN articulo ON articulo.id_articulo = inventario.id_articulo WHERE inventario.id_articulo = '" & dgvConsulta.Item(0, dgvConsulta.CurrentRow.Index).Value & "' && inventario.id_sucursal = '" & G_Sucursal_nombre & "'")
        If Tabla.Tables(0).Rows.Count = 0 Then
            M("¡El articulo solicitado no está dentro del inventario de esta sucursal!", 3)
            txtArticulo.Text = ""
            txtArticulo.Focus()
        ElseIf Tabla.Tables(0).Rows(0)(3).ToString = "0.00" Then
            M("¡Artículo agotado o fuera del inventario de la tienda!", 1)
            'txtArticulo.Text = ""
            txtArticulo.Focus()
        Else
            txtArticulo.Text = ""
            btnCobrar.Enabled = True
            LlenarCampos()
        End If
    End Sub
    Private Sub btnCorteCaja_Click(sender As Object, e As EventArgs) Handles btnCorteCaja.Click
        Popup.PopupFrm(P_CorteCaja)
    End Sub
    Private Sub btnAdministracion_Click(sender As Object, e As EventArgs) Handles btnAdministracion.Click
        Administracion.Show()
    End Sub
    Private Sub btnConsultaPrecio_Click(sender As Object, e As EventArgs) Handles btnConsultaPrecio.Click
        Popup.PopupFrm(P_articulo_C)
    End Sub
End Class