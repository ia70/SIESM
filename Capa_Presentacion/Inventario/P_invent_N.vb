Imports Capa_Negocios
Public Class P_invent_N
    Private Inventario As New N_inventario
    Private Sucursal As New N_sucursal
    Private Proveedor As New N_proveedor
    Private Articulo As New N_Articulo
    Private Tabla As DataSet


    Private Sub P_invent_N_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Tabla = Sucursal.Listado
        If Tabla.Tables(0).Rows.Count > 0 Then
            For Each Fila As DataRow In Tabla.Tables(0).Rows
                txtsucursal.Items.Add(Fila(1))
            Next
            txtsucursal.SelectedIndex = 0
        End If
        Tabla = Proveedor.Listado
        If Tabla.Tables(0).Rows.Count > 0 Then
            For Each Fila As DataRow In Tabla.Tables(0).Rows
                txtproveedor.Items.Add(Fila(1))
            Next
            txtproveedor.SelectedIndex = 0
        End If
        txtcondicion.SelectedIndex = 0

        Txtarticulo.Focus()
    End Sub

    Private Sub Txtarticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtarticulo.KeyPress
        If e.KeyChar = Chr(13) Then
            If Articulo.Existe(Txtarticulo.Text) Then
                Tabla = Articulo.Consultar(Txtarticulo.Text)
                dgvTabla.DataSource = Tabla.Tables(0)
            Else
                M("¡El articulo no existe en la base de datos!", 2)
                Txtarticulo.Text = ""
                Txtarticulo.Focus()
            End If
        Else
            e = Validar_Num(e)
        End If
    End Sub

    Private Sub Txtarticulo_TextChanged(sender As Object, e As EventArgs) Handles Txtarticulo.TextChanged

    End Sub
End Class