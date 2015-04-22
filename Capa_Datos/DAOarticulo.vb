Imports MySql.Data.MySqlClient
Imports Capa_Entidad
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

    Public Sub nuevoArticulo(ByVal objP As CEarticulo)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New MySqlDataAdapter("articulo_insertar", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("id_art", MySqlDbType.VarChar).Value = objP.id_articulo
                .Add("nom_cor", MySqlDbType.VarChar).Value = objP.nombre_corto
                .Add("nom_lar", MySqlDbType.VarChar).Value = objP.nombre_largo
                .Add("des", MySqlDbType.VarChar).Value = objP.descripcion
                .Add("ima", MySqlDbType.LongBlob).Value = objP.imagen
                .Add("fec_reg", MySqlDbType.Date).Value = objP.fecha_registro
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Registro guardado correctamente!", vbInformation + vbOKOnly, "SIESM")
        Catch ex As Exception
            MsgBox("Error al agregar articulo :" + ex.ToString, vbCritical + vbOKOnly, "SIESM")
        Finally
            da.Dispose()
            cn.Dispose()
        End Try

    End Sub
End Class
