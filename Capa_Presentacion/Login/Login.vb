Imports System.IO
Imports System.Collections
Imports System
Imports Capa_Negocios
Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class Login

    Dim usuario As New N_usuario
    Dim VSucursal As New N_sucursal
    Dim tabla As DataSet
    Dim conexion As New MySqlConnection


    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim Archivo As StreamReader
        Dim sLine As String = ""
        Dim arrText As New ArrayList()
        'Dim oSW As StreamWriter

        If usuario.Existe(txtusuario.Text) Then
            tabla = usuario.Consultar(txtusuario.Text)
            If tabla.Tables(0).Rows(0)(2).ToString() = Txtpassword.Text Then

                G_Usuario_Nombre = tabla.Tables(0).Rows(0)(3).ToString()
                G_Usuario_Apellidos = tabla.Tables(0).Rows(0)(4).ToString()
                G_Usuario_Tipo = tabla.Tables(0).Rows(0)(6).ToString()
                G_Usuario_id = txtusuario.Text
                On Error Resume Next
                G_Usuario_Imagen = tabla.Tables(0).Rows(0)(8)
                tabla = Nothing

                If File.Exists(Application.StartupPath.ToString & "\core\sucinf.dll") Then
                    Archivo = New StreamReader(Application.StartupPath.ToString & "\core\sucinf.dll")

                    'Do
                    sLine = Archivo.ReadLine()
                    If Not sLine Is Nothing Then
                        G_Sucursal_nombre = sLine
                        tabla = VSucursal.Consultar(G_Sucursal_nombre)
                        If tabla.Tables(0).Rows.Count > 0 Then
                            G_Sucursal_Calle = tabla.Tables(0).Rows(0)(2).ToString()
                            G_Sucursal_id = tabla.Tables(0).Rows(0)(0)
                            G_Sucursal_Telefono = tabla.Tables(0).Rows(0)(4).ToString()

                        Else
                            M("¡Error al cargar los datos de la sucursal!", 2)
                            Exit Sub
                        End If
                    End If
                    'Loop Until sLine Is Nothing


                    Archivo.Close()
                    P_CajaInicio.Show()
                    Me.Close()
                Else
                    VerificacionSucursal.Show()
                    Me.Close()
                End If
            Else
                M("Usuario Incorrecto", 2)
                Txtpassword.Text = ""
                txtusuario.Text = ""
                txtusuario.Focus()
            End If

        Else
            MsgBox("¡El usuario es incorrecto!", vbOKOnly + vbCritical, "SIESM")
        End If

    End Sub
    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        If e.KeyChar = Chr(13) Then
            Txtpassword.Focus()
        End If
    End Sub
    Private Sub Txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btnentrar_Click(sender, e)
        End If
    End Sub
    Public Sub VerificarConexion()
        Dim EstadoConexion As Boolean = True
        Dim Archivo As StreamReader
        Dim sLine As String = ""

        If File.Exists(Application.StartupPath.ToString & "\core\sucinf.dll") Then
            Archivo = New StreamReader(Application.StartupPath.ToString & "\core\sucinf.dll")

            sLine = Archivo.ReadLine()
            sLine = Archivo.ReadLine()
            DBIP = sLine
            Archivo.Close()


            Try
                conexion.ConnectionString = ConfigurationManager.ConnectionStrings(DBIP).ConnectionString
                conexion.Open()
            Catch ex As Exception
                EstadoConexion = False
            End Try


            If Not EstadoConexion Then
                MsgBox("¡Imposible estableser conexión con el servidor!" + Chr(13) + Chr(13) + "Posibles causas:" + Chr(13) + "* El servidor está apagado" + Chr(13) + "* El servidor no tiene acceso a internet" + Chr(13) + "* Esta computadora no tiene acceso a internet" + Chr(13) + "* La VPN del servidor está apagada" + Chr(13) + "* La VPN de esta computadora está apagada", vbOKOnly + vbCritical, "SIESM")
                conexion = Nothing
            Else
                VSucursal.AsignarBD(DBIP)
                M("¡Conexión establecida correctamente!", 0)
                conexion.Close()
            End If



        Else


            Try
                conexion.ConnectionString = ConfigurationManager.ConnectionStrings("ConexionLocal").ConnectionString
                conexion.Open()
                DBIP = "ConexionLocal"
            Catch ex As Exception
                EstadoConexion = False
            End Try

            If EstadoConexion = False Then
                Try
                    conexion.ConnectionString = ConfigurationManager.ConnectionStrings("ConexionVPN").ConnectionString
                    conexion.Open()
                    EstadoConexion = True
                    DBIP = "ConexionVPN"
                Catch ex As Exception
                    EstadoConexion = False
                End Try
            End If

            If Not EstadoConexion Then
                MsgBox("¡Imposible estableser conexión con el servidor!" + Chr(13) + Chr(13) + "Posibles causas:" + Chr(13) + "* El servidor está apagado" + Chr(13) + "* El servidor no tiene acceso a internet" + Chr(13) + "* Esta computadora no tiene acceso a internet" + Chr(13) + "* La VPN del servidor está apagada" + Chr(13) + "* La VPN de esta computadora está apagada", vbOKOnly + vbCritical, "SIESM")
                conexion = Nothing
            Else
                M("¡Conexión establecida correctamente!", 0)
            End If
            Try
                conexion.Close()
                VSucursal.AsignarBD(DBIP)
            Catch ex As Exception
                MsgBox("Aplicación terminada", vbYes + vbCritical, "SIESM")
                End
            End Try


        End If


    End Sub
    Private Sub Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'VerificarConexion()
        Verificando.Show()
    End Sub
End Class