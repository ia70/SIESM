<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_articulo_C
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtConsulta = New System.Windows.Forms.ComboBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.txtNivel_critico = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUnidad_medida = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecio_venta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecio_compra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ptrimagen = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtid_articulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtNivel_critico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptrimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(740, 448)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 397)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(730, 46)
        Me.Panel2.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.txtConsulta)
        Me.Panel3.Controls.Add(Me.btnSiguiente)
        Me.Panel3.Controls.Add(Me.btnAtras)
        Me.Panel3.Controls.Add(Me.txtNivel_critico)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtUnidad_medida)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtPrecio_venta)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtPrecio_compra)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.ptrimagen)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtdescripcion)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.txtid_articulo)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnterminar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(730, 389)
        Me.Panel3.TabIndex = 17
        '
        'txtConsulta
        '
        Me.txtConsulta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtConsulta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtConsulta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.txtConsulta.DropDownHeight = 1
        Me.txtConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.txtConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtConsulta.FormattingEnabled = True
        Me.txtConsulta.IntegralHeight = False
        Me.txtConsulta.Items.AddRange(New Object() {"Arbol galletas con fiesta", "Tornado sin remedio", "Gelleta venesolana", "Arbol en el bosque", "Sarihuella con esposa", "Niña hermosa", "Niña sin madre"})
        Me.txtConsulta.Location = New System.Drawing.Point(173, 21)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(269, 25)
        Me.txtConsulta.TabIndex = 76
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Image = Global.Capa_Presentacion.My.Resources.Resources.Forward
        Me.btnSiguiente.Location = New System.Drawing.Point(523, 296)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(42, 36)
        Me.btnSiguiente.TabIndex = 75
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.Capa_Presentacion.My.Resources.Resources.Back2
        Me.btnAtras.Location = New System.Drawing.Point(458, 296)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(42, 36)
        Me.btnAtras.TabIndex = 74
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'txtNivel_critico
        '
        Me.txtNivel_critico.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNivel_critico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNivel_critico.Enabled = False
        Me.txtNivel_critico.Location = New System.Drawing.Point(173, 299)
        Me.txtNivel_critico.Name = "txtNivel_critico"
        Me.txtNivel_critico.Size = New System.Drawing.Size(78, 26)
        Me.txtNivel_critico.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 18)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Nivel critico:"
        '
        'txtUnidad_medida
        '
        Me.txtUnidad_medida.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtUnidad_medida.Enabled = False
        Me.txtUnidad_medida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtUnidad_medida.FormattingEnabled = True
        Me.txtUnidad_medida.Items.AddRange(New Object() {"Piezas", "Metros", "Litros"})
        Me.txtUnidad_medida.Location = New System.Drawing.Point(173, 262)
        Me.txtUnidad_medida.Name = "txtUnidad_medida"
        Me.txtUnidad_medida.Size = New System.Drawing.Size(121, 26)
        Me.txtUnidad_medida.TabIndex = 70
        Me.txtUnidad_medida.Text = "Piezas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 18)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Unidad de medida:"
        '
        'txtPrecio_venta
        '
        Me.txtPrecio_venta.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtPrecio_venta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecio_venta.Enabled = False
        Me.txtPrecio_venta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_venta.Location = New System.Drawing.Point(173, 226)
        Me.txtPrecio_venta.MaxLength = 20
        Me.txtPrecio_venta.Name = "txtPrecio_venta"
        Me.txtPrecio_venta.Size = New System.Drawing.Size(121, 26)
        Me.txtPrecio_venta.TabIndex = 68
        Me.txtPrecio_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Precio de venta:"
        '
        'txtPrecio_compra
        '
        Me.txtPrecio_compra.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtPrecio_compra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecio_compra.Enabled = False
        Me.txtPrecio_compra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_compra.Location = New System.Drawing.Point(173, 190)
        Me.txtPrecio_compra.MaxLength = 20
        Me.txtPrecio_compra.Name = "txtPrecio_compra"
        Me.txtPrecio_compra.Size = New System.Drawing.Size(121, 26)
        Me.txtPrecio_compra.TabIndex = 66
        Me.txtPrecio_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 18)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Precio de compra:"
        '
        'ptrimagen
        '
        Me.ptrimagen.BackColor = System.Drawing.Color.White
        Me.ptrimagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptrimagen.Location = New System.Drawing.Point(458, 60)
        Me.ptrimagen.Name = "ptrimagen"
        Me.ptrimagen.Size = New System.Drawing.Size(256, 170)
        Me.ptrimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptrimagen.TabIndex = 64
        Me.ptrimagen.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(520, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 18)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Imágen del articulo:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Location = New System.Drawing.Point(173, 132)
        Me.txtdescripcion.MaxLength = 300
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtdescripcion.Size = New System.Drawing.Size(269, 47)
        Me.txtdescripcion.TabIndex = 62
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(173, 95)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNombre.Size = New System.Drawing.Size(269, 26)
        Me.txtNombre.TabIndex = 61
        '
        'txtid_articulo
        '
        Me.txtid_articulo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtid_articulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid_articulo.Enabled = False
        Me.txtid_articulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_articulo.Location = New System.Drawing.Point(173, 61)
        Me.txtid_articulo.MaxLength = 20
        Me.txtid_articulo.Name = "txtid_articulo"
        Me.txtid_articulo.Size = New System.Drawing.Size(204, 26)
        Me.txtid_articulo.TabIndex = 60
        Me.txtid_articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Nombre :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Código de barra:"
        '
        'btnterminar
        '
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(609, 302)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(105, 30)
        Me.btnterminar.TabIndex = 56
        Me.btnterminar.Text = "Terminar"
        Me.btnterminar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(730, 49)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Consultar articulo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_articulo_C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "P_articulo_C"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de articulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtNivel_critico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptrimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNivel_critico As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad_medida As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_venta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ptrimagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtid_articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents txtConsulta As System.Windows.Forms.ComboBox
End Class
