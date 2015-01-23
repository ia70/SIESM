Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Conexion
    Dim conexion As MySqlConnection

    Public Function conectar() As MySqlConnection
        Try
            conexion = New MySqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
            'MsgBox(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
            Return conexion
        Catch ex As Exception
            'MsgBox("Error al conectar a la base de datos", vbCritical + vbYes, "SIESM")
            Console.WriteLine("Error a conectar a la base de datos")

        End Try
        Return conexion
    End Function
End Class
