Public Class Popup
    Private Valor_estate As Integer
    Private Sub PantallaOscora_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If Not Valor_estate Then
            Valor_estate = 10
            Me.Close()
        End If

    End Sub

    Public Sub PopupFrm(ByVal Frm As Form, ByVal Valor As Integer)
        Me.Show()
        If Not Valor Then
            Valor_estate = 0
            Frm.Show()
        Else
            Valor_estate = 1
            Frm.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class