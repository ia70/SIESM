Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Conexion
    Dim conexion As New MySqlConnection

    Public Function conectar() As MySqlConnection
        conexion.ConnectionString = ConfigurationManager.ConnectionStrings(DBIP).ConnectionString
        Return conexion
    End Function
End Class
