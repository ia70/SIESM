﻿Imports System.IO
Imports System.Collections
Imports System
Imports Capa_Negocios

Public Class Login

    Dim usuario As New N_usuario
    Dim VSucursal As New N_sucursal
    Dim tabla As DataSet

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim Archivo As StreamReader
        Dim sLine As String = ""
        Dim arrText As New ArrayList()
        Dim oSW As StreamWriter

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
    Private Sub VerificarSucursal()

    End Sub
    
End Class