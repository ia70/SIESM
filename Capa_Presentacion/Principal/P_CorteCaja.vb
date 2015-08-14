Imports Capa_Negocios
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class P_CorteCaja
    Private Tabla As New DataSet
    Private Elemento As New N_inventario

    'Private Sub P_CorteCaja_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    '   Tabla = Elemento.Query("SELECT SUM(cantidad), SUM(cantidad * precio_venta) FROM venta WHERE fecha='" & getFecha() & "' AND id_sucursal='" & G_Sucursal_nombre & "'")
    '  If Tabla.Tables(0).Rows(0)(0).ToString = "" Then
    '     txtInicioCaja.Text = Format(G_PuntoVenta_InicioCaja, "##,###.##")
    '    txtTotalVentas.Text = "0"
    '   txtTotalArticulosVendidos.Text = "0"
    '  txtTotaDineroCaja.Text = txtInicioCaja.Text
    'Else
    '   txtInicioCaja.Text = Format(G_PuntoVenta_InicioCaja, "##,###.##")
    '  txtTotalVentas.Text = Format(Val(Tabla.Tables(0).Rows(0)(1).ToString), "##,###.##")
    ' txtTotalArticulosVendidos.Text = Tabla.Tables(0).Rows(0)(0).ToString
    'On Error Resume Next
    'txtTotaDineroCaja.Text = Format(CDec(txtTotalVentas.Text) + CDec(txtInicioCaja.Text), "##,###.##")
    'End If
    'End Sub
    Private Sub btnInformeSencillo_Click(sender As Object, e As EventArgs) Handles btnInformeSencillo.Click
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 40, 40, 42, 42)
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("Reporte.pdf", FileMode.Create))
        Dim Linea As Paragraph
        doc.Open()

        Dim FTitulo1 As New Font(BaseFont.CreateFont("c:/windows/fonts/Arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED), 20)
        Dim FTitulo2 As New Font(BaseFont.CreateFont("c:/windows/fonts/Arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED), 14)
        Dim FTitulo3 As New Font(BaseFont.CreateFont("c:/windows/fonts/Arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED), 12)
        Dim imagen As iTextSharp.text.Image
        imagen = iTextSharp.text.Image.GetInstance(My.Application.Info.DirectoryPath & "\core\titulo.png") 'nombre y ruta de la imagen a insertar
        'imagen.ScalePercent(100) 'escala al tamaño de la imagen
        'imagen.SetAbsolutePosition(40, 670) 'posición en la que se inserta. 40 (de izquierda a derecha). 500 (de abajo hacia arriba)
        doc.Add(imagen)

        '********************************************************************************


        Linea = New Paragraph("Corte de caja", FTitulo1)
        doc.Add(Linea)
        Linea.Clear()
        Linea = New Paragraph("_______________________________________________", FTitulo1)
        doc.Add(Linea)


        



        



        doc.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class