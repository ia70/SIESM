Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class D_inventario
    Dim objCon As New Conexion
    Dim cn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim Comando As New MySqlCommand

    '--Modificar lo de abajo ******************************************************
    Dim Tabla As String = "inventario"


    'Inserta un articulo en la base de datos
    Public Function Insertar(ByVal _Elemento As E_inventario) As Boolean
        Return QueryM(Tabla & "_insertar", _Elemento)
    End Function

    'Edita un articulo
    Public Function Editar(ByVal _Elemento As E_inventario) As Boolean
        Return QueryM(Tabla & "_editar", _Elemento)
    End Function

    'Esta funcion se encarga de agregar, editar registros en la tabla articulo
    Private Function QueryM(ByVal Cadena As String, ByVal _Elemento As E_inventario) As Boolean
        cn = objCon.conectar
        Dim Estado As Boolean = False
        Try
            cn.Open()
            da = New MySqlDataAdapter(Cadena, cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("id", MySqlDbType.Int32).Value = _Elemento.id_inventario
                .Add("id_suc", MySqlDbType.VarChar).Value = _Elemento.id_sucursal
                .Add("id_pro", MySqlDbType.VarChar).Value = _Elemento.id_proveedor
                .Add("id_usu", MySqlDbType.VarChar).Value = _Elemento.id_usuario
                .Add("id_art", MySqlDbType.VarChar).Value = _Elemento.id_articulo
                .Add("exi", MySqlDbType.Decimal).Value = _Elemento.existencia
                .Add("niv_cri", MySqlDbType.Int32).Value = _Elemento.nivel_critico
                .Add("con", MySqlDbType.VarChar).Value = _Elemento.condicion
                .Add("fec", MySqlDbType.Date).Value = _Elemento.fecha
            End With
            Estado = da.SelectCommand.ExecuteNonQuery
        Catch ex As Exception
            MsgBox("Error al actualizar " & Tabla & " :" + ex.ToString, vbCritical + vbOKOnly, "SIESM")
        Finally
            da.Dispose()
            cn.Close()
            'cn.Dispose()
        End Try
        Return Estado
    End Function

    'Obtiene el listado de todos los articulos en la tabla articulo
    Public Function Listado(ByVal Sucursal As String) As DataSet
        Return QueryC("CALL " & Tabla & "_mostrar('" & Sucursal & "')")
    End Function

    Public Function Articulos(ByVal Sucursal As String) As DataSet
        Return QueryC("CALL inventario_articulo('" & Sucursal & "')")
    End Function

    'Devuelve la consulta de un articulo en especifico
    Public Function Consulta(ByVal ID As String) As DataSet
        Return QueryC("CALL " & Tabla & "_consultar('" & ID & "')")
    End Function

    'Devuelve el primer articulo que aparece en la tabla de articulos
    Public Function GetInicio(ByVal Sucursal As String) As DataSet
        Return QueryC("CALL " & Tabla & "_inicio('" & Sucursal & "')")
    End Function

    'Devuelve el ultimo articulo que aparece en la tabla articulo
    Public Function GetFinal(ByVal Sucursal As String) As DataSet
        Return QueryC("CALL " & Tabla & "_final('" & Sucursal & "')")
    End Function

    'Devuelve el siguiente articulo en la tabla articulo en base al que se especifica
    Public Function GetSiguiente(ByVal ID As String) As DataSet
        Return QueryC("CALL " & Tabla & "_siguiente('" & ID & "')")
    End Function

    'Devuelve el articulo anterior en la tabla articulo en base al que se especifica
    Public Function GetAnterior(ByVal ID As String) As DataSet
        Return QueryC("CALL " & Tabla & "_atras('" & ID & "')")
    End Function

    'Consulta la existencia de un articulo y devuelve SI o No 
    Public Function Existe(ByVal ID As String) As Boolean
        Dim valor As Boolean = False
        If QueryC("CALL " & Tabla & "_consultar('" & ID & "')").Tables(0).Rows.Count Then
            valor = True
        End If
        Return Valor
    End Function

    'Elimina un articulo especificado
    Public Sub Eliminar(ByVal ID As String)
        QueryC("CALL " & Tabla & "_eliminar('" & ID & "')")
        MsgBox(StrConv(Tabla, 3) & " eliminado correctamente!", vbOKOnly + vbInformation, "SIESM")
    End Sub

    'Devuelve los primeros 5 registros que coinciden con el filtro/busqueda
    Public Function Filtrar(ByVal Cadena As String, ByVal Sucursal As String) As DataSet
        Return QueryC("CALL " & Tabla & "_filtrar('" & Cadena.Replace(" ", "%").ToString & "', '" & Sucursal & "')")
    End Function

    'Esta funcion contiene los datos de coneccion y consulta a la Base de datos
    Private Function QueryC(ByVal Cadena As String) As DataSet
        Dim ds As New DataSet
        Try
            cn = objCon.conectar
            cn.Open()
            da = New MySqlDataAdapter(Cadena, cn)
            da.Fill(ds, StrConv(Tabla, 3))
            da.Dispose()
            cn.Close()
            'cn.Dispose()
            Return ds
            ds.Dispose()
        Catch ex As Exception
            MsgBox("¡Error al intentar conectarse a la base de datos! : " + ex.ToString, vbOKOnly + vbCritical, "SIESM")
            Return Nothing
        End Try

    End Function

    Public Function Query(ByVal Cadena As String) As DataSet
        Dim ds As New DataSet
        Try

            cn = objCon.conectar
            cn.Open()
            da = New MySqlDataAdapter(Cadena, cn)
            da.Fill(ds, "Tabla")
            da.Dispose()
            cn.Close()
            'cn.Dispose()
            Return ds
            ds.Dispose()
        Catch ex As Exception
            MsgBox("¡Error al intentar conectarse a la base de datos! : " + ex.ToString, vbOKOnly + vbCritical, "SIESM")
            Return Nothing
        End Try
    End Function

End Class
