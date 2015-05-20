Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_invent_N
    Private Inventario As New N_inventario
    Private IE As New E_inventario
    Private Sucursal As New N_sucursal
    Private Proveedor As New N_proveedor
    Private Articulo As New N_Articulo
    Private Tabla As DataSet



    Private Sub P_invent_N_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Tabla = Sucursal.Listado
        txtSucursal.DataSource = Tabla.Tables(0)
        txtSucursal.ValueMember = "ID"
        txtSucursal.DisplayMember = "Nombre"
    End Sub
End Class