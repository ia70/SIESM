<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articulo_N
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
        Me.btbuscar_imagen = New System.Windows.Forms.Button()
        Me.btlimpiar_campos = New System.Windows.Forms.Button()
        Me.btterminar = New System.Windows.Forms.Button()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.pcimagen = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txdescripcion = New System.Windows.Forms.TextBox()
        Me.txnombre_largo = New System.Windows.Forms.TextBox()
        Me.txnombre_corto = New System.Windows.Forms.TextBox()
        Me.txid_articulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pcimagen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 0
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
        Me.Panel3.Controls.Add(Me.btbuscar_imagen)
        Me.Panel3.Controls.Add(Me.btlimpiar_campos)
        Me.Panel3.Controls.Add(Me.btterminar)
        Me.Panel3.Controls.Add(Me.btguardar)
        Me.Panel3.Controls.Add(Me.pcimagen)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txdescripcion)
        Me.Panel3.Controls.Add(Me.txnombre_largo)
        Me.Panel3.Controls.Add(Me.txnombre_corto)
        Me.Panel3.Controls.Add(Me.txid_articulo)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(730, 389)
        Me.Panel3.TabIndex = 17
        '
        'btbuscar_imagen
        '
        Me.btbuscar_imagen.Enabled = False
        Me.btbuscar_imagen.Location = New System.Drawing.Point(465, 247)
        Me.btbuscar_imagen.Name = "btbuscar_imagen"
        Me.btbuscar_imagen.Size = New System.Drawing.Size(253, 30)
        Me.btbuscar_imagen.TabIndex = 27
        Me.btbuscar_imagen.Text = "Buscar imágen"
        Me.btbuscar_imagen.UseVisualStyleBackColor = True
        '
        'btlimpiar_campos
        '
        Me.btlimpiar_campos.Enabled = False
        Me.btlimpiar_campos.Location = New System.Drawing.Point(358, 303)
        Me.btlimpiar_campos.Name = "btlimpiar_campos"
        Me.btlimpiar_campos.Size = New System.Drawing.Size(138, 30)
        Me.btlimpiar_campos.TabIndex = 26
        Me.btlimpiar_campos.Text = "Limpiar campos"
        Me.btlimpiar_campos.UseVisualStyleBackColor = True
        '
        'btterminar
        '
        Me.btterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btterminar.Location = New System.Drawing.Point(613, 303)
        Me.btterminar.Name = "btterminar"
        Me.btterminar.Size = New System.Drawing.Size(105, 30)
        Me.btterminar.TabIndex = 25
        Me.btterminar.Text = "Terminar"
        Me.btterminar.UseVisualStyleBackColor = True
        '
        'btguardar
        '
        Me.btguardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btguardar.Enabled = False
        Me.btguardar.Location = New System.Drawing.Point(502, 303)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(105, 30)
        Me.btguardar.TabIndex = 24
        Me.btguardar.Text = "Guardar"
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'pcimagen
        '
        Me.pcimagen.BackColor = System.Drawing.Color.White
        Me.pcimagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcimagen.Enabled = False
        Me.pcimagen.Location = New System.Drawing.Point(462, 65)
        Me.pcimagen.Name = "pcimagen"
        Me.pcimagen.Size = New System.Drawing.Size(256, 170)
        Me.pcimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcimagen.TabIndex = 23
        Me.pcimagen.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(524, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Imágen del articulo:"
        '
        'txdescripcion
        '
        Me.txdescripcion.Enabled = False
        Me.txdescripcion.Location = New System.Drawing.Point(169, 134)
        Me.txdescripcion.MaxLength = 120
        Me.txdescripcion.Multiline = True
        Me.txdescripcion.Name = "txdescripcion"
        Me.txdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txdescripcion.Size = New System.Drawing.Size(269, 101)
        Me.txdescripcion.TabIndex = 21
        '
        'txnombre_largo
        '
        Me.txnombre_largo.Enabled = False
        Me.txnombre_largo.Location = New System.Drawing.Point(169, 99)
        Me.txnombre_largo.MaxLength = 30
        Me.txnombre_largo.Name = "txnombre_largo"
        Me.txnombre_largo.Size = New System.Drawing.Size(269, 26)
        Me.txnombre_largo.TabIndex = 20
        '
        'txnombre_corto
        '
        Me.txnombre_corto.Enabled = False
        Me.txnombre_corto.Location = New System.Drawing.Point(169, 65)
        Me.txnombre_corto.MaxLength = 15
        Me.txnombre_corto.Name = "txnombre_corto"
        Me.txnombre_corto.Size = New System.Drawing.Size(204, 26)
        Me.txnombre_corto.TabIndex = 19
        '
        'txid_articulo
        '
        Me.txid_articulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txid_articulo.Location = New System.Drawing.Point(169, 30)
        Me.txid_articulo.MaxLength = 20
        Me.txid_articulo.Name = "txid_articulo"
        Me.txid_articulo.Size = New System.Drawing.Size(204, 26)
        Me.txid_articulo.TabIndex = 18
        Me.txid_articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre largo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nombre corto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 18)
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
        Me.Label6.Size = New System.Drawing.Size(730, 49)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Agregar articulo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Articulo_N
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Articulo_N"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIESM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pcimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btlimpiar_campos As System.Windows.Forms.Button
    Friend WithEvents btterminar As System.Windows.Forms.Button
    Friend WithEvents btguardar As System.Windows.Forms.Button
    Friend WithEvents pcimagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txnombre_largo As System.Windows.Forms.TextBox
    Friend WithEvents txnombre_corto As System.Windows.Forms.TextBox
    Friend WithEvents txid_articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btbuscar_imagen As System.Windows.Forms.Button
End Class
