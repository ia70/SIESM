Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class D_articulo
    Dim objCon As New Conexion
    Dim cn As MySqlConnection
    Dim da As MySqlDataAdapter

    Public Function Listado() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New MySqlDataAdapter("CALL articulo_mostrar", cn)
        da.Fill(ds, "Articulos")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Consulta(ByVal ID As String) As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New MySqlDataAdapter("CALL articulo_consultar('" & ID & "')", cn)
        da.Fill(ds, "Articulos")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Sub Insertar(ByVal objP As E_articulo)
        Dim Exito As Integer
        cn = objCon.conectar
        Try
            'cn.Open()
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
            Exito = da.SelectCommand.ExecuteNonQuery()
            MsgBox("Registro guardado correctamente!", vbInformation + vbOKOnly, "SIESM")
        Catch ex As Exception
            MsgBox("Error al agregar articulo :" + ex.ToString, vbCritical + vbOKOnly, "SIESM")
        Finally
            da.Dispose()
            cn.Dispose()
        End Try

    End Sub
End Class
