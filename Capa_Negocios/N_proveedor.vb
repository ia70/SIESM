Imports Capa_Datos
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Capa_Entidad
Public Class N_proveedor
    Dim objArt As New D_proveedor
    Public Function Listado() As DataSet
        Return objArt.Listado()
    End Function

    Public Sub Insertar(ByVal objP As E_proveedor)
        objArt.Insertar(objP)
    End Sub

    Public Function Consulta(ByVal ID As String) As DataSet
        Return objArt.Consulta(ID)
    End Function

    Public Sub Eliminar(ByVal ID As String)
        objArt.Eliminar(ID)
    End Sub

    Public Sub Editar(ByVal objP As E_proveedor)
        objArt.Editar(objP)
    End Sub

    Public Function Existe(ByVal ID As String) As Boolean
        Return objArt.Existe(ID)
    End Function

End Class
