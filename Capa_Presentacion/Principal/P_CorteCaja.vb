﻿Imports Capa_Negocios
Public Class P_CorteCaja
    Private Tabla As New DataSet
    Private Elemento As New N_inventario

    Private Sub P_CorteCaja_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Tabla = Elemento.Query("SELECT SUM(cantidad), SUM(cantidad * precio_venta) FROM venta WHERE fecha='" & getFecha() & "' AND id_sucursal='" & G_Sucursal_nombre & "'")
        If Tabla.Tables(0).Rows(0)(0).ToString = "" Then
            txtInicioCaja.Text = Format(G_PuntoVenta_InicioCaja, "##,###.##")
            txtTotalVentas.Text = "0"
            txtTotalArticulosVendidos.Text = "0"
            txtTotaDineroCaja.Text = txtInicioCaja.Text
        Else
            txtInicioCaja.Text = Format(G_PuntoVenta_InicioCaja, "##,###.##")
            txtTotalVentas.Text = Format(Val(Tabla.Tables(0).Rows(0)(1).ToString), "##,###.##")
            txtTotalArticulosVendidos.Text = Tabla.Tables(0).Rows(0)(0).ToString
            On Error Resume Next
            txtTotaDineroCaja.Text = Format(CDec(txtTotalVentas.Text) + CDec(txtInicioCaja.Text), "##,###.##")
        End If
    End Sub
End Class