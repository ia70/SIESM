Imports Capa_Negocios
Imports System.IO
Public Class VerificacionSucursal
    Private Sucursal As New N_sucursal
    Dim tabla As DataSet
    Dim VSucursal As New N_sucursal

    Private Sub VerificacionSucursal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            txtSucursal.DataSource = Sucursal.Listado.Tables(0)
            txtSucursal.ValueMember = "ID"
            txtSucursal.DisplayMember = "Nombre"
        Catch ex As Exception
            M("¡Error al intentar obtener lista de sucursales!", 2)
        End Try
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Archivo As StreamReader
        Dim sLine As String = ""
        Dim arrText As New ArrayList()
        Dim oSW As StreamWriter

        Try
            oSW = New StreamWriter(Application.StartupPath.ToString & "\sucinf.dll")
            sLine = txtSucursal.Text & Chr(13) & DBIP
            oSW.WriteLine(sLine)
            oSW.Flush()
            oSW.Close()
        Catch ex As Exception
            oSW.Flush()
            oSW.Close()
        End Try



        If File.Exists(Application.StartupPath.ToString & "\sucinf.dll") Then
            Archivo = New StreamReader(Application.StartupPath.ToString & "\sucinf.dll")

            'Do
            sLine = Archivo.ReadLine()
            If Not sLine Is Nothing Then
                G_Sucursal_nombre = sLine
                tabla = VSucursal.Consultar(G_Sucursal_nombre)
                If tabla.Tables(0).Rows.Count > 0 Then
                    G_Sucursal_Calle = tabla.Tables(0).Rows(0)(2).ToString()
                    G_Sucursal_id = tabla.Tables(0).Rows(0)(0).ToString()
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

        End If

    End Sub
End Class