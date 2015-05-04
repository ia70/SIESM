Imports Capa_Datos
Imports Capa_Entidad
Public Class N_Articulo

    Dim Articulo As New D_articulo
    Public Function Listado() As DataSet
        Return Articulo.Listado()
    End Function

    Public Function Insertar(ByVal _Articulo As E_articulo) As Boolean
        Return Articulo.Insertar(_Articulo)
    End Function

    Public Function Consultar(ByVal ID As String) As DataSet
        Return Articulo.Consulta(ID)
    End Function

    Public Function Inicio() As DataSet
        Return Articulo.GetInicio()
    End Function

    Public Function Final() As DataSet
        Return Articulo.GetFinal()
    End Function

    Public Function Siguiente(ByVal ID As String) As DataSet
        Return Articulo.GetSiguiente(ID)
    End Function

    Public Function Atras(ByVal ID As String) As DataSet
        Return Articulo.GetAnterior(ID)
    End Function
    Public Sub Eliminar(ByVal ID As String)
        Articulo.Eliminar(ID)
    End Sub

    Public Function Editar(ByVal _Articulo As E_articulo) As Boolean
        Return Articulo.Editar(_Articulo)
    End Function

    Public Function Existe(ByVal ID As String) As Boolean
        Return Articulo.Existe(ID)
    End Function

    Public Function Filtrar(ByVal ID As String) As DataSet
        Return Articulo.Filtrar(ID)
    End Function

End Class
