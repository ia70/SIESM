Imports MySql.Data.MySqlClient

Public Class DAOarticulo
    Dim objCon As New Conexion
    Dim cn As MySqlConnection
    Dim da As MySqlDataAdapter

    Public Function listadoArticulos() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        'da = New MySqlDataAdapter("SELECT id_articulo, nombre_corto, nombre_largo, descripcion FROM siesm.articulo", cn)
        da = New MySqlDataAdapter("CALL articulo_mostrar", cn)
        da.Fill(ds, "Articulos")

        Return ds

        ds.Dispose()
        da.Dispose()
        cn.Dispose()

    End Function
End Class
