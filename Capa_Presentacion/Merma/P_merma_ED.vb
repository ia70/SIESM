Imports Capa_Negocios
Imports Capa_Entidad
Public Class P_merma_ED
    Dim Elemento As New Capa_Negocios.N_sucursal
    Dim Tabla As New DataSet

    Private Sub P_merma_ED_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtConsulta.Focus()
    End Sub

    Private Sub dgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellContentClick

    End Sub

    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Txtid_merma.Text = "" Or Txtid_merma.Text = Elemento.Inicio.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Final()
            LlenarCampos()
            Campos(True)
        ElseIf Elemento.Existe(Txtid_merma.Text) Then
            Tabla = Elemento.Atras(Txtid_merma.Text)
            LlenarCampos()
            Campos(True)
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If Txtid_merma.Text = "" Or Txtid_merma.Text = Elemento.Final.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Inicio()
            LlenarCampos()
            Campos(True)
        ElseIf Elemento.Existe(Txtid_merma.Text) Then
            Tabla = Elemento.Siguiente(Txtid_merma.Text)
            LlenarCampos()
            Campos(True)
        End If
    End Sub

#End Region

#Region "Cajas de texto"
    Private Sub txtconsulta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsulta.KeyPress
        If IsNumeric(txtConsulta.Text) Then
            If Len(txtConsulta.Text) > 4 And e.KeyChar = ChrW(13) And IsNumeric(txtConsulta.Text) Then
                Tabla = Elemento.Consultar(txtConsulta.Text)
                If Tabla.Tables(0).Rows.Count = 0 Then
                    M("El registro de merma solicitado no existe", 3)
                    txtConsulta.Text = ""
                    txtConsulta.Focus()
                Else
                    txtConsulta.Text = ""
                    LlenarCampos()
                    Campos(True)
                End If
            Else
                Validar_Num(e)
            End If
        End If
    End Sub

    Private Sub txtConsulta_TextChanged(sender As Object, e As EventArgs) Handles txtConsulta.TextChanged
        If Not IsNumeric(txtConsulta.Text) And Not txtConsulta.Text = "" Then
            dgvTabla.DataSource = Elemento.Filtrar(txtConsulta.Text).Tables(0)
        ElseIf txtConsulta.Text = "" Then
            dgvTabla.DataSource = ""
        End If
    End Sub

#End Region

#Region "Funciones de validacion de campos"
    Private Sub LlenarCampos()
        Txtid_merma.Text = Tabla.Tables(0).Rows(0)(0).ToString()
        Txtid_usuario.Text = Tabla.Tables(0).Rows(0)(1).ToString()
        Txtid_articulo.Text = Tabla.Tables(0).Rows(0)(2).ToString()
        Txtid_sucursal.Text = Tabla.Tables(0).Rows(0)(3).ToString()
        Txtmotivo.Text = Tabla.Tables(0).Rows(0)(4).ToString()
        Txtcantidad.Text = Tabla.Tables(0).Rows(0)(5).ToString()
        Txtfecha.Text = Tabla.Tables(0).Rows(0)(7).ToString()
        Txthora.Text = Tabla.Tables(0).Rows(0)(6).ToString()
        txtConsulta.Focus()
    End Sub

    Sub Campos(ByVal Valor As Boolean)
        txtConsulta.Text = ""
        Txtid_merma.Text = ""
        Txtid_usuario.Text = ""
        Txtid_articulo.Text = ""
        Txtid_sucursal.Text = ""
        Txtmotivo.Text = ""
        Txtcantidad.Text = ""
        Txtfecha.Text = ""
        Txthora.Text = ""
    End Sub

    Sub LimpiarCampos()
        Txtid_merma.Text = ""
        Txtid_usuario.Text = ""
        Txtid_articulo.Text = ""
        Txtid_sucursal.Text = ""
        Txtmotivo.Text = ""
        Txtcantidad.Text = ""
        Txtfecha.Text = ""
        Txthora.Text = ""
        Campos(False)
        txtConsulta.Focus()
    End Sub
#End Region

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim _merma As New E_sucursal
        Txtid_merma.Text = Tabla.Tables(0).Rows(0)(0).ToString()
        Txtid_usuario.Text = Tabla.Tables(0).Rows(0)(1).ToString()
        Txtid_articulo.Text = Tabla.Tables(0).Rows(0)(2).ToString()
        Txtid_sucursal.Text = Tabla.Tables(0).Rows(0)(3).ToString()
        Txtmotivo.Text = Tabla.Tables(0).Rows(0)(4).ToString()
        Txtcantidad.Text = Tabla.Tables(0).Rows(0)(5).ToString()
        Txtfecha.Text = Tabla.Tables(0).Rows(0)(7).ToString()
        Txthora.Text = Tabla.Tables(0).Rows(0)(6).ToString()
        On Error Resume Next
        txtConsulta.Focus()
        If Elemento.Editar(_merma) Then
            M("¡El articulo ha sido agregado a merma con exito!", 1)
        Else
            M("¡No se ha podido agregar el articulo a merma!", 3)
        End If

    End Sub

    Private Sub btnlimpiar_campos_Click(sender As Object, e As EventArgs) Handles btnlimpiar_campos.Click
        LimpiarCampos()
    End Sub
End Class