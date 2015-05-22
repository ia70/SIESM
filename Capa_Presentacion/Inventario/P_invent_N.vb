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
    Private HInventario As New Thread(AddressOf CargarInventario)
    Private Sub P_invent_N_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    public Sub P_invent_N_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        HInventario.Start()
        txtSucursal.DataSource = Sucursal.Listado.Tables(0)
        txtSucursal.ValueMember = "ID"
        txtSucursal.DisplayMember = "Nombre"
        TablaInventario = Inventario.Articulos(txtSucursal.SelectedItem.ToString)
        If TablaInventario.Tables(0).Rows.Count > 0 Then

        End If


        Dim txtProveedor As New DataGridViewComboBoxColumn
        Dim txtExistencia As New DataGridViewTextBoxColumn
        txtProveedor.DataSource = Proveedor.Listado.Tables(0)
        txtProveedor.DisplayMember = "Proveedor"
        txtProveedor.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
        txtExistencia.HeaderText = "Existenca"
        Try
            With dgvTabla
                .Columns.Add(txtProveedor)
                .Columns.Add(txtExistencia)
                .Columns(0).HeaderText = "ID"
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(1).Width = 300
                .Columns(1).HeaderText = "Artículo"
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(2).Width = 100
                .Columns(2).HeaderText = "Proveedor"
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(3).Width = 100
                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True

            End With
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
            dgvTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Catch ex As Exception
            M("Error: " + ex.ToString, 2)
        End Try

    End Sub

    Public Sub CargarInventario()
        TablaInventario = Inventario.Listado
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

    Private Sub dgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellContentClick

    End Sub

    Private Sub dgvTabla_Click(sender As Object, e As EventArgs) Handles dgvTabla.Click
        txtNombreArticulo.Text = dgvTabla.Item(1, dgvTabla.CurrentRow.Index).Value
        txtID_Articulo.Text = dgvTabla.Item(0, dgvTabla.CurrentRow.Index).Value
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Fila As Integer
        Fila = dgvDefectuoso.Rows.Count - 1
        If TablaArticulos.Tables(0).Rows.Count > 0 Then
            dgvDefectuoso.Rows.Add()
            dgvDefectuoso.Item(0, Fila).Value = txtID_Articulo.Text
            dgvDefectuoso.Item(1, Fila).Value = TablaArticulos.Tables(0).Rows(0)(2).ToString
            dgvDefectuoso.Item(2, Fila).Value = ToDecimal(txtPrecio_venta.Text).ToString
            dgvDefectuoso.Item(3, Fila).Value = txtCantidad.Value.ToString
            dgvDefectuoso.Item(4, Fila).Value = txtNombreArticulo.Text
            txtPrecio_venta.Text = ""

        End If
    End Sub


End Class