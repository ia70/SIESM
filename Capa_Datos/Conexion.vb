Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Conexion
    Dim conexion As MySqlConnection

    Public Function conectar() As MySqlConnection
        conexion = New MySqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
        Return conexion
    End Function
End Class
