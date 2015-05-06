Imports Capa_Datos
Imports Capa_Entidad
Public Class N_usuario
    Dim Elemento As New D_usuario

    Public Function Insertar(ByVal _Elemento As E_usuario) As Boolean
        Return Elemento.Insertar(_Elemento)
    End Function

    Public Function Editar(ByVal _Elemento As E_usuario) As Boolean
        Return Elemento.Editar(_Elemento)
    End Function

    Public Function Listado() As DataSet
        Return Elemento.Listado()
    End Function

    Public Function Consultar(ByVal ID As String) As DataSet
        Return Elemento.Consulta(ID)
    End Function

    Public Function Inicio() As DataSet
        Return Elemento.GetInicio()
    End Function

    Public Function Final() As DataSet
        Return Elemento.GetFinal()
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
End Class
