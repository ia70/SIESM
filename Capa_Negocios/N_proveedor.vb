Imports Capa_Datos
Imports Capa_Entidad
Public Class N_proveedor
    Dim Proveedor As New D_proveedor
    Public Function Listado() As DataSet
        Return Proveedor.Listado()
    End Function

    Public Sub Insertar(ByVal _Proveedor As E_proveedor)
        Proveedor.Insertar(_Proveedor)
    End Sub

    Public Function Consulta(ByVal ID As String) As DataSet
        Return Proveedor.Consulta(ID)
    End Function

    Public Sub Eliminar(ByVal ID As String)
        Proveedor.Eliminar(ID)
    End Sub

    Public Sub Editar(ByVal _Proveedor As E_proveedor)
        Proveedor.Editar(_Proveedor)
    End Sub

    Public Function Existe(ByVal ID As String) As Boolean
        Return Proveedor.Existe(ID)
    End Function

End Class
