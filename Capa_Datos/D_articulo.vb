Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class D_articulo
    Dim objCon As New Conexion
    Dim cn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim Comando As New MySqlCommand

    Public Function Listado() As DataSet
        Return QueryC("CALL articulo_mostrar")
    End Function

    Public Function Consulta(ByVal ID As String) As DataSet
        Return QueryC("CALL articulo_consultar('" & ID & "')")
    End Function

    Public Function GetInicio() As DataSet
        Return QueryC("CALL articulo_inicio()")
    End Function

    Public Function GetFinal() As DataSet
        Return QueryC("CALL articulo_final()")
    End Function

    Public Function GetSiguiente(ByVal ID As String) As DataSet
        Return QueryC("CALL articulo_siguiente('" & ID & "')")
    End Function

    Public Function GetAnterior(ByVal ID As String) As DataSet
        Return QueryC("CALL articulo_atras('" & ID & "')")
    End Function

    Public Function Existe(ByVal ID As String) As Boolean
        Dim valor As Boolean
        If QueryC("CALL articulo_consultar('" & ID & "')").Tables(0).Rows.Count Then
            valor = True
        Else
            valor = False
        End If
        Return Valor
    End Function

    Public Sub Eliminar(ByVal ID As String)
        Dim Valor As Boolean
        cn = objCon.conectar
        cn.Open()
        Comando.Connection = cn
        Comando.CommandText = "CALL articulo_eliminar('" & ID & "')"
        Valor = Comando.ExecuteNonQuery()

        If Valor Then
            MsgBox("¡Articulo eliminado correctamente!", vbInformation, "SIESM")
        Else
            MsgBox("¡No se pudo eliminar el articulo!", vbCritical, "SIESM")
        End If
        cn.Close()
        da.Dispose()
        cn.Dispose()
    End Sub

    Public Sub Insertar(ByVal _Articulo As E_articulo)
        QueryM("articulo_insertar", _Articulo)
    End Sub

    Public Sub Editar(ByVal _Articulo As E_articulo)
        QueryM("articulo_editar", _Articulo)
    End Sub

    Public Sub QueryM(ByVal Cadena As String, ByVal _Articulo As E_articulo)
        Dim Estado As Integer
        cn = objCon.conectar
        Try
            cn.Open()
            da = New MySqlDataAdapter(Cadena, cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("id_art", MySqlDbType.VarChar).Value = _Articulo.id_articulo
                .Add("nom", MySqlDbType.VarChar).Value = _Articulo.nombre
                .Add("des", MySqlDbType.VarChar).Value = _Articulo.descripcion
                .Add("niv_cri", MySqlDbType.Int32).Value = _Articulo.nivel_critico
                .Add("uni_med", MySqlDbType.VarChar).Value = _Articulo.unidad_medida
                .Add("pre_com", MySqlDbType.Decimal).Value = _Articulo.precio_compra
                .Add("pre_ven", MySqlDbType.Decimal).Value = _Articulo.precio_venta
                .Add("ima", MySqlDbType.LongBlob).Value = _Articulo.imagen
                .Add("fec", MySqlDbType.Date).Value = _Articulo.fecha
            End With
            Estado = da.SelectCommand.ExecuteNonQuery()
            If Estado Then
                MsgBox("Registro actualizado correctamente!", vbInformation + vbOKOnly, "SIESM")
            Else
                MsgBox("¡Error al actualizar articulo!", vbCritical + vbOKOnly, "SIESM")
            End If
        Catch ex As Exception
            MsgBox("Error al actualizar articulo :" + ex.ToString, vbCritical + vbOKOnly, "SIESM")
        Finally
            da.Dispose()
            cn.Dispose()
        End Try
    End Sub

    Public Function QueryC(ByVal Cadena As String) As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New MySqlDataAdapter(Cadena, cn)
        da.Fill(ds, "Articulos")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function
End Class
