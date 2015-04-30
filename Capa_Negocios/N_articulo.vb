Imports Capa_Datos
'Imports System.Drawing
'Imports System.Windows.Forms
Imports Capa_Entidad
Public Class N_Articulo

    Dim Articulo As New D_articulo
    Public Function Listado() As DataSet
        Return Articulo.Listado()
    End Function

    Public Sub Insertar(ByVal E_Articulo As E_articulo)
        Articulo.Insertar(E_Articulo)
    End Sub

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

    Public Sub Editar(ByVal E_Articulo As E_articulo)
        Articulo.Editar(E_Articulo)
    End Sub

    Public Function Existe(ByVal ID As String) As Boolean
        Return Articulo.Existe(ID)
    End Function

   End Class
