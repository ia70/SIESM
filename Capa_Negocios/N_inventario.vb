Imports Capa_Datos
Imports Capa_Entidad
Public Class N_inventario
    Dim Elemento As New D_inventario

    Public Function Insertar(ByVal _Elemento As E_inventario) As Boolean
        Return Elemento.Insertar(_Elemento)
    End Function

    Public Function Editar(ByVal _Elemento As E_inventario) As Boolean
        Return Elemento.Editar(_Elemento)
    End Function

    Public Function Listado(ByVal Sucursal As String) As DataSet
        Return Elemento.Listado(Sucursal)
    End Function

    Public Function Articulos(ByVal Sucursal As String) As DataSet
        Return Elemento.Articulos(Sucursal)
    End Function

    Public Function Consultar(ByVal ID As String) As DataSet
        Return Elemento.Consulta(ID)
    End Function

    Public Function Inicio(ByVal Sucursal As String) As DataSet
        Return Elemento.GetInicio(Sucursal)
    End Function

    Public Function Final(ByVal Sucursal As String) As DataSet
        Return Elemento.GetFinal(Sucursal)
    End Function

    Public Function Siguiente(ByVal ID As String) As DataSet
        Return Elemento.GetSiguiente(ID)
    End Function

    Public Function Atras(ByVal ID As String) As DataSet
        Return Elemento.GetAnterior(ID)
    End Function
    Public Sub Eliminar(ByVal ID As String)
        Elemento.Eliminar(ID)
    End Sub

    Public Function Existe(ByVal ID As String) As Boolean
        Return Elemento.Existe(ID)
    End Function

    Public Function Filtrar(ByVal ID As String) As DataSet
        Return Elemento.Filtrar(ID)
    End Function
    Public Function Query(ByVal Cadena As String) As DataSet
        Return Elemento.Query(Cadena)
    End Function
End Class
