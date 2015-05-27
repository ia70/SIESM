Imports Capa_Negocios
Imports Capa_Entidad
Imports System.Threading
Public Class P_invent_N
    Private Inventario As New N_inventario
    Private IE As New E_inventario
    Private Sucursal As New N_sucursal
    Private Proveedor As New N_proveedor
    Private Articulo As New N_Articulo
    Private TablaArticulos As DataSet
    Private TablaInventario As DataSet
    Private HCargarDatos As New Thread(AddressOf Llenar_Tabla)
    Private cargaCompleta As Boolean = False
    Private Sub P_invent_N_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Public Sub P_invent_N_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            txtSucursal.DataSource = Sucursal.Listado.Tables(0)
            txtSucursal.ValueMember = "ID"
            txtSucursal.DisplayMember = "Nombre"

            txtProveedor.DataSource = Proveedor.Listado.Tables(0)
            txtProveedor.ValueMember = "ID"
            txtProveedor.DisplayMember = "Proveedor"
        Catch ex As Exception
            M("Error: " + ex.ToString)
        End Try


        With dgvTabla.ColumnHeadersDefaultCellStyle
            .Font = New Font("Arial", 12, FontStyle.Bold)
            .ForeColor = Color.Black
            .BackColor = Color.LightBlue
            .SelectionForeColor = Color.Yellow
            .SelectionBackColor = Color.Black
        End With

        With dgvDefectuoso.ColumnHeadersDefaultCellStyle
            .Font = New Font("Arial", 12, FontStyle.Bold)
            .ForeColor = Color.Black
            .BackColor = Color.LightBlue
            .SelectionForeColor = Color.Yellow
            .SelectionBackColor = Color.Black
        End With
        dgvTabla.Columns(3).Width = 70
        dgvTabla.Columns(4).Width = 70
        dgvTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Llenar_Tabla()
        cargaCompleta = True
        'HCargarDatos.Start()

    End Sub
    Private Sub txtPrecio_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio_venta.KeyPress
        e = Validar_Num(e)
    End Sub
    Private Sub txtPrecio_venta_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio_venta.TextChanged
        If Not txtPrecio_venta.Text = "" Then
            btnAgregar.Enabled = True
        Else
            btnAgregar.Enabled = False
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Fila As Integer
        Fila = dgvDefectuoso.Rows.Count - 1

        dgvDefectuoso.Rows.Add()
        dgvDefectuoso.Item(0, Fila).Value = txtID_Articulo.Text
        dgvDefectuoso.Item(1, Fila).Value = "1234567"
        dgvDefectuoso.Item(2, Fila).Value = ToDecimal(txtPrecio_venta.Text).ToString
        dgvDefectuoso.Item(3, Fila).Value = txtCantidad.Value.ToString
        dgvDefectuoso.Item(4, Fila).Value = txtNombreArticulo.Text
        txtPrecio_venta.Text = ""

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim TotalElementos As Integer = 0
        Try
            'Obtener Total 
            For Each Fila As DataGridViewRow In dgvTabla.Rows
                If IsNumeric(Fila.Cells(4).Value) Then
                    TotalElementos += 1
                End If
            Next
            If TotalElementos = 0 Then
                Inventario.Query("DELETE FROM inventario WHERE id_sucursal= '" & txtSucursal.Text & "'")
                M("Inventario eliminado correctamente!")
                Llenar_Tabla()
                Exit Sub
            End If
            Inventario.Query("DELETE FROM inventario WHERE id_sucursal= '" & txtSucursal.Text & "'")
            For Each Fila As DataGridViewRow In dgvTabla.Rows
                If IsNumeric(Fila.Cells(4).Value) Then
                    IE.condicion = "Buena Condición"
                    IE.existencia = Fila.Cells(4).Value
                    IE.fecha = getFecha()
                    IE.id_articulo = Fila.Cells(0).Value.ToString
                    IE.id_inventario = 0
                    IE.id_proveedor = Fila.Cells(2).Value.ToString
                    IE.id_sucursal = txtSucursal.Text
                    IE.id_usuario = G_Usuario_id
                    IE.nivel_critico = Fila.Cells(3).Value
                    If Inventario.Insertar(IE) Then
                    Else
                        M("No se pudo insertar elemento: " + Fila.Cells(0).Value.ToString, 2)
                        Exit Sub
                    End If
                End If
            Next

            M("Registros guardados correctamente!")
            Llenar_Tabla()
        Catch ex As Exception
            M(ex.ToString, 2)
        End Try

    End Sub
    Private Sub txtSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSucursal.SelectedIndexChanged
        If cargaCompleta = True Then
            Llenar_Tabla()
            dgvTabla.Focus()
        End If
    End Sub
    Private Sub txtProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProveedor.SelectedIndexChanged
        If cargaCompleta Then
            dgvTabla.Item(2, dgvTabla.CurrentRow.Index).Value = txtProveedor.Text
        End If
    End Sub
    Private Sub dgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellContentClick

    End Sub
    Private Sub dgvTabla_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvTabla.CurrentCellChanged
        Try
            txtNombreArticulo.Text = dgvTabla.Item(1, dgvTabla.CurrentRow.Index).Value
            txtID_Articulo.Text = dgvTabla.Item(0, dgvTabla.CurrentRow.Index).Value
            If Not dgvTabla.Item(2, dgvTabla.CurrentRow.Index).Value.ToString = "" Then
                txtProveedor.Text = dgvTabla.Item(2, dgvTabla.CurrentRow.Index).Value
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtIdArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdArticulo.KeyPress
        If IsNumeric(txtIdArticulo.Text) Then
            If Len(txtIdArticulo.Text) > 4 And e.KeyChar = ChrW(13) And IsNumeric(txtIdArticulo.Text) Then
                TablaArticulos = Inventario.Query("SELECT id_articulo,descripcion FROM articulo WHERE id_articulo = '" & txtIdArticulo.Text & "'")
                If TablaArticulos.Tables(0).Rows.Count = 0 Then
                    M("El articulo solicitado no existe", 3)
                    txtIdArticulo.Text = ""
                    txtIdArticulo.Focus()
                Else
                    txtIdArticulo.Text = ""
                    LlenarCampos()
                End If
            Else
                Validar_Num(e)
            End If
        End If
    End Sub

    Private Sub LlenarCampos()
        Dim i As Integer
        i = dgvTabla.RowCount - 1

        dgvTabla.Rows.Add()
        dgvTabla.Item(0, i).Value = TablaArticulos.Tables(0).Rows(0)(0).ToString()
        dgvTabla.Item(1, i).Value = TablaArticulos.Tables(0).Rows(0)(1).ToString()
        dgvTabla.Item(2, i).Value = txtProveedor.Text
        dgvTabla.Item(3, i).Value = "2"
        dgvTabla.Item(4, i).Value = "X"
    End Sub
    Private Sub Llenar_Tabla()
        Dim TotalFilas As Integer

        TablaArticulos = Inventario.Articulos(txtSucursal.Text)
        TotalFilas = TablaArticulos.Tables(0).Rows.Count
        dgvTabla.Rows.Clear()
        If TotalFilas > 0 Then
            gbAgregar.Visible = True
            For i As Integer = 0 To TotalFilas - 1

                dgvTabla.Rows.Add()
                dgvTabla.Item(0, i).Value = TablaArticulos.Tables(0).Rows(i)(0).ToString()
                dgvTabla.Item(1, i).Value = TablaArticulos.Tables(0).Rows(i)(1).ToString()
                dgvTabla.Item(2, i).Value = TablaArticulos.Tables(0).Rows(i)(2).ToString()
                dgvTabla.Item(3, i).Value = TablaArticulos.Tables(0).Rows(i)(3).ToString()
                dgvTabla.Item(4, i).Value = TablaArticulos.Tables(0).Rows(i)(4).ToString()
            Next
        Else
            gbAgregar.Visible = False
            TablaArticulos = Inventario.Query("SELECT id_articulo,descripcion FROM articulo")
            TotalFilas = TablaArticulos.Tables(0).Rows.Count
            If TotalFilas > 0 Then
                For i As Integer = 0 To TotalFilas - 1

                    dgvTabla.Rows.Add()
                    dgvTabla.Item(0, i).Value = TablaArticulos.Tables(0).Rows(i)(0).ToString()
                    dgvTabla.Item(1, i).Value = TablaArticulos.Tables(0).Rows(i)(1).ToString()
                    dgvTabla.Item(2, i).Value = txtProveedor.Text
                    dgvTabla.Item(3, i).Value = "2"
                    dgvTabla.Item(4, i).Value = "X"
                    'M(dgvTabla.Item(1, i).Value.ToString)
                Next
            End If
        End If
        HCargarDatos.Abort()
    End Sub

    Private Sub btnAgregarArti_Click(sender As Object, e As EventArgs) Handles btnAgregarArti.Click
        TablaArticulos = Inventario.Query("SELECT id_articulo,descripcion FROM articulo WHERE id_articulo = '" & txtIdArticulo.Text & "'")
        If TablaArticulos.Tables(0).Rows.Count = 0 Then
            M("El articulo solicitado no existe", 3)
            txtIdArticulo.Text = ""
            txtIdArticulo.Focus()
        Else
            txtIdArticulo.Text = ""
            LlenarCampos()
        End If
    End Sub
End Class