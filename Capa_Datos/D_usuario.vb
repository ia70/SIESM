Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class D_usuario
    Dim objCon As New Conexion
    Dim cn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim Comando As New MySqlCommand

    'Obtiene el listado de todos los articulos en la tabla articulo
    Public Function Listado() As DataSet
        Return QueryC("CALL usuario_mostrar")
    End Function

    'Devuelve la consulta de un articulo en especifico
    Public Function Consulta(ByVal ID As String) As DataSet
        Return QueryC("CALL usuario_consultar('" & ID & "')")
    End Function

    'Devuelve el primer articulo que aparece en la tabla de articulos
    Public Function GetInicio() As DataSet
        Return QueryC("CALL usuario_inicio()")
    End Function

    'Devuelve el ultimo articulo que aparece en la tabla articulo
    Public Function GetFinal() As DataSet
        Return QueryC("CALL usuario_final()")
    End Function

    'Devuelve el siguiente articulo en la tabla articulo en base al que se especifica
    Public Function GetSiguiente(ByVal ID As String) As DataSet
        Return QueryC("CALL usuario_siguiente('" & ID & "')")
    End Function

    'Devuelve el articulo anterior en la tabla articulo en base al que se especifica
    Public Function GetAnterior(ByVal ID As String) As DataSet
        Return QueryC("CALL usuario_atras('" & ID & "')")
    End Function

    'Consulta la existencia de un articulo y devuelve SI o No 
    Public Function Existe(ByVal ID As String) As Boolean
        Dim valor As Boolean = False
        If QueryC("CALL usuario_consultar('" & ID & "')").Tables(0).Rows.Count Then
            valor = True
        End If
        Return Valor
    End Function

    'Elimina un articulo especificado
    Public Sub Eliminar(ByVal ID As String)
        QueryC("CALL usuario_eliminar('" & ID & "')")
        MsgBox("Usuario eliminado correctamente!", vbOKOnly + vbInformation, "SIESM")
    End Sub

    'Inserta un articulo en la base de datos
    Public Function Insertar(ByVal _Proveedor As E_proveedor) As Boolean
        Return QueryM("usuario_insertar", _Proveedor)
    End Function

    'Edita un articulo
    Public Function Editar(ByVal _Articulo As E_proveedor) As Boolean
        Return QueryM("usuario_editar", _Articulo)
    End Function

    'Devuelve los primeros 5 registros que coinciden con el filtro/busqueda
    Public Function Filtrar(ByVal Cadena As String) As DataSet
        Return QueryC("CALL usuario_filtrar('" & Cadena.Replace(" ", "%").ToString & "')")
    End Function

    'Esta funcion contiene los datos de coneccion y consulta a la Base de datos
    Private Function QueryC(ByVal Cadena As String) As DataSet
        Dim ds As New DataSet
        Try
            cn = objCon.conectar
            cn.Open()
            da = New MySqlDataAdapter(Cadena, cn)
            da.Fill(ds, "Usuario")
            da.Dispose()
            cn.Close()
            cn.Dispose()
            Return ds
            ds.Dispose()
        Catch ex As Exception
            MsgBox("¡Error al intentar conectarse a la base de datos! : " + ex.ToString, vbOKOnly + vbCritical, "SIESM")
            Return Nothing
        End Try

    End Function

    'Esta funcion se encarga de agregar, editar registros en la tabla articulo
    Private Function QueryM(ByVal Cadena As String, ByVal _Proveedor As E_proveedor) As Boolean
        cn = objCon.conectar
        Dim Estado As Boolean = False
        Try
            cn.Open()
            da = New MySqlDataAdapter(Cadena, cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("nom", MySqlDbType.VarChar).Value = _Proveedor.nombre
                .Add("dir", MySqlDbType.VarChar).Value = _Proveedor.direccion
                .Add("des", MySqlDbType.VarChar).Value = _Proveedor.descripcion
                .Add("tel", MySqlDbType.VarChar).Value = _Proveedor.telefono
                .Add("fec", MySqlDbType.Date).Value = _Proveedor.fecha
            End With
            Estado = da.SelectCommand.ExecuteNonQuery
        Catch ex As Exception
            MsgBox("Error al actualizar la Base de Datos :" + ex.ToString, vbCritical + vbOKOnly, "SIESM")
        Finally
            da.Dispose()
            cn.Dispose()
        End Try
        Return Estado
    End Function
End Class
