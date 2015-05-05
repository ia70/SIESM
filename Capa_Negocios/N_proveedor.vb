Imports Capa_Datos
Imports Capa_Entidad
Public Class N_proveedor
    Dim Proveedor As New D_proveedor
    Public Function Listado() As DataSet
        Return Proveedor.Listado()
    End Function

    Public Function Insertar(ByVal _Proveedor As E_proveedor) As Boolean
        Return Proveedor.Insertar(_Proveedor)
    End Function

    Public Function Consultar(ByVal ID As String) As DataSet
        Return Proveedor.Consulta(ID)
    End Function

    Public Function Inicio() As DataSet
        Return Proveedor.GetInicio()
    End Function

    Public Function Final() As DataSet
        Return Proveedor.GetFinal()
    End Function

    Public Function Siguiente(ByVal ID As String) As DataSet
        Return Proveedor.GetSiguiente(ID)
    End Function

    Public Function Atras(ByVal ID As String) As DataSet
        Return Proveedor.GetAnterior(ID)
    End Function
    Public Sub Eliminar(ByVal ID As String)
        Proveedor.Eliminar(ID)
    End Sub

    Public Function Editar(ByVal _Articulo As E_proveedor) As Boolean
        Return Proveedor.Editar(_Articulo)
    End Function

    Public Function Existe(ByVal ID As String) As Boolean
        Return Proveedor.Existe(ID)
    End Function

    Public Function Filtrar(ByVal ID As String) As DataSet
        Return Proveedor.Filtrar(ID)
    End Function

End Class
