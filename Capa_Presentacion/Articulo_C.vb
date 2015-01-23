Imports Capa_Negocios
Public Class Articulo_C

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Articulo_C_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call cargaArticulos()
    End Sub

    Sub cargaArticulos()
        Dim capaNegocio As New CNarticulo
        dgvarticulos.DataSource = capaNegocio.listadoArticulos.Tables("Articulos")
    End Sub

    Private Sub dgvarticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvarticulos.CellClick
        llenarCampos()
    End Sub

    Sub llenarCampos()
        txtid_articulo.Text = dgvarticulos.Item(0, dgvarticulos.CurrentRow.Index).Value.ToString
        lblnombre_corto.Text = dgvarticulos.Item(1, dgvarticulos.CurrentRow.Index).Value.ToString
        lblnombre_largo.Text = dgvarticulos.Item(2, dgvarticulos.CurrentRow.Index).Value.ToString
        lbldescripcion.Text = dgvarticulos.Item(3, dgvarticulos.CurrentRow.Index).Value.ToString
        lblfecha_registro.Text = dgvarticulos.Item(5, dgvarticulos.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub dgvarticulos_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvarticulos.CurrentCellChanged
        llenarCampos()
    End Sub

    Private Sub txtid_articulo_TextChanged(sender As Object, e As EventArgs) Handles txtid_articulo.TextChanged

    End Sub
End Class