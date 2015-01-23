Imports Capa_Datos
Public Class CNarticulo
    Dim objArt As New DAOarticulo
    Public Function listadoArticulos() As DataSet
        Return objArt.listadoArticulos()
    End Function

End Class
