Public Class Popup
    Private Valor_estate As Integer
    Private Formulario As Form
    Private Sub PantallaOscora_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If Not Valor_estate Then
            Valor_estate = 10
            Formulario.Close()
            Me.Close()
        End If

    End Sub
    ''' <summary>
    ''' Muestra un formulario resaltado
    ''' </summary>
    ''' <param name="Frm">Formulario</param>
    ''' <param name="Valor">0 - Cerrar con clic fuera, 1- Cerrar hasta que dialogo se sierre</param>
    ''' <remarks></remarks>
    Public Sub PopupFrm(ByVal Frm As Form, Optional ByVal Valor As Integer = 0)
        Formulario = Frm
        Me.Show()
        If Not Valor Then
            Valor_estate = 0
            Formulario.Show()
        Else
            Valor_estate = 1
            Formulario.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class