<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_usuario_C
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.ComboBox()
        Me.txtsexo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtapellidos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnbuscar_imagen = New System.Windows.Forms.Button()
        Me.ptrimagen = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnlimpiar_campos = New System.Windows.Forms.Button()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.ptrimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(741, 49)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Consultar usuario"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.txtfecha)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txttipo)
        Me.Panel3.Controls.Add(Me.txtsexo)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Txtapellidos)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnbuscar_imagen)
        Me.Panel3.Controls.Add(Me.ptrimagen)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnlimpiar_campos)
        Me.Panel3.Controls.Add(Me.btnterminar)
        Me.Panel3.Controls.Add(Me.btnguardar)
        Me.Panel3.Controls.Add(Me.txtnombre)
        Me.Panel3.Controls.Add(Me.txtcontraseña)
        Me.Panel3.Controls.Add(Me.txtid)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(741, 337)
        Me.Panel3.TabIndex = 20
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Location = New System.Drawing.Point(138, 278)
        Me.txtfecha.MaxLength = 500
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(204, 26)
        Me.txtfecha.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 18)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Fecha:"
        '
        'txttipo
        '
        Me.txttipo.FormattingEnabled = True
        Me.txttipo.Location = New System.Drawing.Point(138, 230)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(121, 26)
        Me.txttipo.TabIndex = 35
        '
        'txtsexo
        '
        Me.txtsexo.FormattingEnabled = True
        Me.txtsexo.Location = New System.Drawing.Point(138, 185)
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.Size = New System.Drawing.Size(121, 26)
        Me.txtsexo.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Sexo:"
        '
        'Txtapellidos
        '
        Me.Txtapellidos.Enabled = False
        Me.Txtapellidos.Location = New System.Drawing.Point(138, 144)
        Me.Txtapellidos.MaxLength = 12
        Me.Txtapellidos.Name = "Txtapellidos"
        Me.Txtapellidos.Size = New System.Drawing.Size(269, 26)
        Me.Txtapellidos.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Apellidos:"
        '
        'btnbuscar_imagen
        '
        Me.btnbuscar_imagen.Enabled = False
        Me.btnbuscar_imagen.Location = New System.Drawing.Point(457, 240)
        Me.btnbuscar_imagen.Name = "btnbuscar_imagen"
        Me.btnbuscar_imagen.Size = New System.Drawing.Size(253, 30)
        Me.btnbuscar_imagen.TabIndex = 30
        Me.btnbuscar_imagen.Text = "Buscar imágen"
        Me.btnbuscar_imagen.UseVisualStyleBackColor = True
        '
        'ptrimagen
        '
        Me.ptrimagen.BackColor = System.Drawing.Color.White
        Me.ptrimagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptrimagen.Location = New System.Drawing.Point(457, 41)
        Me.ptrimagen.Name = "ptrimagen"
        Me.ptrimagen.Size = New System.Drawing.Size(256, 170)
        Me.ptrimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptrimagen.TabIndex = 29
        Me.ptrimagen.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(515, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Imágen del articulo:"
        '
        'btnlimpiar_campos
        '
        Me.btnlimpiar_campos.Enabled = False
        Me.btnlimpiar_campos.Location = New System.Drawing.Point(369, 292)
        Me.btnlimpiar_campos.Name = "btnlimpiar_campos"
        Me.btnlimpiar_campos.Size = New System.Drawing.Size(138, 30)
        Me.btnlimpiar_campos.TabIndex = 26
        Me.btnlimpiar_campos.Text = "Limpiar campos"
        Me.btnlimpiar_campos.UseVisualStyleBackColor = True
        '
        'btnterminar
        '
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(624, 292)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(105, 30)
        Me.btnterminar.TabIndex = 25
        Me.btnterminar.Text = "Terminar"
        Me.btnterminar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnguardar.Enabled = False
        Me.btnguardar.Location = New System.Drawing.Point(513, 292)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(105, 30)
        Me.btnguardar.TabIndex = 24
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(140, 100)
        Me.txtnombre.MaxLength = 12
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(269, 26)
        Me.txtnombre.TabIndex = 20
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Enabled = False
        Me.txtcontraseña.Location = New System.Drawing.Point(140, 65)
        Me.txtcontraseña.MaxLength = 500
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(204, 26)
        Me.txtcontraseña.TabIndex = 19
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(140, 30)
        Me.txtid.MaxLength = 30
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(204, 26)
        Me.txtid.TabIndex = 18
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID:"
        '
        'P_usuario_C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 386)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "P_usuario_C"
        Me.Text = "P_usuario_C"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ptrimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtsexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txtapellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar_imagen As System.Windows.Forms.Button
    Friend WithEvents ptrimagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnlimpiar_campos As System.Windows.Forms.Button
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
