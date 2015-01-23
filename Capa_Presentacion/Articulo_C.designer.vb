<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articulo_C
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblfecha_registro = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lblnombre_largo = New System.Windows.Forms.Label()
        Me.lblnombre_corto = New System.Windows.Forms.Label()
        Me.dgvarticulos = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ptrimagen = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtid_articulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvarticulos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(828, 492)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 441)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(818, 46)
        Me.Panel2.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.lblfecha_registro)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.lbldescripcion)
        Me.Panel3.Controls.Add(Me.lblnombre_largo)
        Me.Panel3.Controls.Add(Me.lblnombre_corto)
        Me.Panel3.Controls.Add(Me.dgvarticulos)
        Me.Panel3.Controls.Add(Me.btnSalir)
        Me.Panel3.Controls.Add(Me.ptrimagen)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtid_articulo)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(818, 433)
        Me.Panel3.TabIndex = 17
        '
        'lblfecha_registro
        '
        Me.lblfecha_registro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfecha_registro.Location = New System.Drawing.Point(171, 159)
        Me.lblfecha_registro.Name = "lblfecha_registro"
        Me.lblfecha_registro.Size = New System.Drawing.Size(357, 28)
        Me.lblfecha_registro.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 19)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Fecha de registro:"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldescripcion.Location = New System.Drawing.Point(171, 126)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(357, 28)
        Me.lbldescripcion.TabIndex = 29
        '
        'lblnombre_largo
        '
        Me.lblnombre_largo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnombre_largo.Location = New System.Drawing.Point(171, 91)
        Me.lblnombre_largo.Name = "lblnombre_largo"
        Me.lblnombre_largo.Size = New System.Drawing.Size(357, 28)
        Me.lblnombre_largo.TabIndex = 28
        '
        'lblnombre_corto
        '
        Me.lblnombre_corto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnombre_corto.Location = New System.Drawing.Point(171, 58)
        Me.lblnombre_corto.Name = "lblnombre_corto"
        Me.lblnombre_corto.Size = New System.Drawing.Size(204, 28)
        Me.lblnombre_corto.TabIndex = 27
        '
        'dgvarticulos
        '
        Me.dgvarticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvarticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvarticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvarticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvarticulos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvarticulos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvarticulos.Location = New System.Drawing.Point(0, 209)
        Me.dgvarticulos.MultiSelect = False
        Me.dgvarticulos.Name = "dgvarticulos"
        Me.dgvarticulos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvarticulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvarticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvarticulos.Size = New System.Drawing.Size(818, 224)
        Me.dgvarticulos.TabIndex = 26
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(423, 17)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(105, 30)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ptrimagen
        '
        Me.ptrimagen.BackColor = System.Drawing.Color.White
        Me.ptrimagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptrimagen.Enabled = False
        Me.ptrimagen.Location = New System.Drawing.Point(555, 33)
        Me.ptrimagen.Name = "ptrimagen"
        Me.ptrimagen.Size = New System.Drawing.Size(256, 170)
        Me.ptrimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptrimagen.TabIndex = 23
        Me.ptrimagen.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(610, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Imágen del articulo:"
        '
        'txtid_articulo
        '
        Me.txtid_articulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_articulo.Location = New System.Drawing.Point(171, 20)
        Me.txtid_articulo.MaxLength = 20
        Me.txtid_articulo.Name = "txtid_articulo"
        Me.txtid_articulo.Size = New System.Drawing.Size(204, 26)
        Me.txtid_articulo.TabIndex = 18
        Me.txtid_articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre largo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nombre corto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Código de barra:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(818, 49)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Consultar articulo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Articulo_C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Articulo_C"
        Me.Text = "Consulta de articulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvarticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptrimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ptrimagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtid_articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvarticulos As System.Windows.Forms.DataGridView
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents lblnombre_largo As System.Windows.Forms.Label
    Friend WithEvents lblnombre_corto As System.Windows.Forms.Label
    Friend WithEvents lblfecha_registro As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
