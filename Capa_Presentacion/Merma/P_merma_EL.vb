Imports Capa_Negocios
Public Class P_merma_EL
    Dim Elemento As New Capa_Negocios.N_merma
    Dim Tabla As New DataSet

    Private Sub P_merma_ED_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtConsulta.Focus()
    End Sub

    Private Sub dgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellContentClick
        Tabla = Elemento.Consultar(dgvTabla.Item(0, dgvTabla.CurrentRow.Index).Value)
        LlenarCampos()
        btnEli()
    End Sub

    'Funciones de control de datos y funcionamiento

#Region "Botones"
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Elemento.Eliminar(Txtid_merma.Text)
        LimpiarCampos()
    End Sub

    Private Sub btnterminar_Click(sender As Object, e As EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Txtid_merma.Text = "" Or Len(Txtid_merma.Text) < 5 Or Txtid_merma.Text = Elemento.Inicio.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Final()
            LlenarCampos()
        ElseIf Elemento.Existe(Txtid_merma.Text) Then
            Tabla = Elemento.Atras(Txtid_merma.Text)
            LlenarCampos()
        End If
        btnEli()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If Txtid_merma.Text = "" Or Len(Txtid_merma.Text) < 5 Or Txtid_merma.Text = Elemento.Final.Tables(0).Rows(0)(0).ToString() Then
            Tabla = Elemento.Inicio()
            LlenarCampos()
        ElseIf Elemento.Existe(Txtid_merma.Text) Then
            Tabla = Elemento.Siguiente(Txtid_merma.Text)
            LlenarCampos()
        End If
        btnEli()
    End Sub

#End Region

#Region "Cajas de texto"
    Private Sub txtid_merma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtid_merma.KeyPress

    End Sub

    Private Sub txtConsulta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsulta.KeyPress
        If IsNumeric(txtConsulta.Text) Then
            If Len(txtConsulta.Text) > 0 And e.KeyChar = ChrW(13) And IsNumeric(txtConsulta.Text) Then
                Tabla = Elemento.Consultar(txtConsulta.Text)
                If Tabla.Tables(0).Rows.Count = 0 Then
                    M("El articulo solicitado no existe", 3)
                    txtConsulta.Text = ""
                    txtConsulta.Focus()
                Else
                    txtConsulta.Text = ""
                    LlenarCampos()
                    btnEli()
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
        On Error Resume Next
        txtConsulta.Focus()
    End Sub

    Sub LimpiarCampos()
        txtConsulta.Text = ""
        Txtid_merma.Text = ""
        Txtid_usuario.Text = ""
        Txtid_articulo.Text = ""
        Txtid_sucursal.Text = ""
        Txtmotivo.Text = ""
        Txtcantidad.Text = ""
        Txtfecha.Text = ""
        Txthora.Text = ""


        txtConsulta.Focus()
    End Sub

    Private Sub btnEli()
        If Not btnEliminar.Enabled Then
            btnEliminar.Enabled = True
        End If
    End Sub
#End Region

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

End Class