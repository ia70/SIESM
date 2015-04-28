Imports MySql.Data.MySqlClient
Imports Capa_Entidad
Public Class D_proveedor
    Dim objCon As New Conexion
    Dim cn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim Query As New MySqlCommand

    Public Function Listado() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New MySqlDataAdapter("CALL proveedor_mostrar", cn)
        da.Fill(ds, "Proveedor")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Consulta(ByVal ID As String) As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar
        da = New MySqlDataAdapter("CALL proveedor_consulta('" & ID & "')", cn)
        da.Fill(ds, "Proveedor")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    Public Function Existe(ByVal ID As String) As Boolean
        Dim ds As New DataSet
        Dim Valor As Boolean
        cn = objCon.conectar
        da = New MySqlDataAdapter("CALL proveedor_consulta('" & ID & "')", cn)
        da.Fill(ds, "Proveedor")

        If ds.Tables(0).Rows.Count Then
            Valor = True
        Else
            Valor = False
        End If
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
        Return Valor

    End Function

    Public Sub Eliminar(ByVal ID As String)
        Dim Valor As Boolean
        cn = objCon.conectar
        cn.Open()
        Query.Connection = cn
        Query.CommandText = "CALL proveedor_eliminar('" & ID & "')"
        Valor = Query.ExecuteNonQuery()

        If Valor Then
            MsgBox("¡Proveedor eliminado correctamente!", vbInformation, "SIESM")
        Else
            MsgBox("¡No se pudo eliminar el proveedor!", vbCritical, "SIESM")
        End If
        cn.Close()
        da.Dispose()
        cn.Dispose()
    End Sub

    Public Sub Insertar(ByVal objP As E_proveedor)
        Dim Exito As Integer
        cn = objCon.conectar
        Try
            cn.Open()
            da = New MySqlDataAdapter("proveedor_insertar", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("nom", MySqlDbType.VarChar).Value = objP.nombre
                .Add("dir", MySqlDbType.VarChar).Value = objP.direccion
                .Add("des", MySqlDbType.VarChar).Value = objP.descripcion
                .Add("tel", MySqlDbType.VarChar).Value = objP.telefono
                .Add("fec_reg", MySqlDbType.VarChar).Value = objP.fecha_registro
            End With
            Exito = da.SelectCommand.ExecuteNonQuery()
            MsgBox("Registro guardado correctamente!", vbInformation + vbOKOnly, "SIESM")
        Catch ex As Exception
            MsgBox("Error al agregar proveedor :" + ex.ToString, vbCritical + vbOKOnly, "SIESM")
        Finally
            da.Dispose()
            cn.Dispose()
        End Try

    End Sub

    Public Sub Editar(ByVal objP As E_proveedor)
        Dim Exito As Integer
        cn = objCon.conectar
        Try
            cn.Open()
            da = New MySqlDataAdapter("proveedor_editar", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("nom", MySqlDbType.VarChar).Value = objP.nombre
                .Add("dir", MySqlDbType.VarChar).Value = objP.direccion
                .Add("des", MySqlDbType.VarChar).Value = objP.descripcion
                .Add("tel", MySqlDbType.VarChar).Value = objP.telefono
                .Add("fec_reg", MySqlDbType.VarChar).Value = objP.fecha_registro
            End With
            Exito = da.SelectCommand.ExecuteNonQuery()
            MsgBox("Registro guardado correctamente!", vbInformation + vbOKOnly, "SIESM")
        Catch ex As Exception
            MsgBox("Error al agregar proveedor :" + ex.ToString, vbCritical + vbOKOnly, "SIESM")
        Finally
            da.Dispose()
            cn.Dispose()
        End Try

    End Sub
End Class
