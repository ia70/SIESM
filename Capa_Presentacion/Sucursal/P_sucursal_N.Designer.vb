<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_sucursal_N
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_sucursal_N))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTipo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscar_imagen = New System.Windows.Forms.Button()
        Me.ptrImagen = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnlimpiar_campos = New System.Windows.Forms.Button()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ptrImagen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(720, 423)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 372)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(710, 46)
        Me.Panel2.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.txtTipo)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnBuscar_imagen)
        Me.Panel3.Controls.Add(Me.ptrImagen)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnlimpiar_campos)
        Me.Panel3.Controls.Add(Me.btnterminar)
        Me.Panel3.Controls.Add(Me.btnguardar)
        Me.Panel3.Controls.Add(Me.txtDescripcion)
        Me.Panel3.Controls.Add(Me.txtTelefono)
        Me.Panel3.Controls.Add(Me.txtDireccion)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(710, 364)
        Me.Panel3.TabIndex = 17
        '
        'txtTipo
        '
        Me.txtTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipo.Enabled = False
        Me.txtTipo.FormattingEnabled = True
        Me.txtTipo.Items.AddRange(New Object() {"Sucursal", "Bodega"})
        Me.txtTipo.Location = New System.Drawing.Point(140, 204)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(172, 26)
        Me.txtTipo.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Tipo:"
        '
        'btnBuscar_imagen
        '
        Me.btnBuscar_imagen.Enabled = False
        Me.btnBuscar_imagen.Location = New System.Drawing.Point(436, 224)
        Me.btnBuscar_imagen.Name = "btnBuscar_imagen"
        Me.btnBuscar_imagen.Size = New System.Drawing.Size(253, 30)
        Me.btnBuscar_imagen.TabIndex = 30
        Me.btnBuscar_imagen.Text = "Buscar imágen"
        Me.btnBuscar_imagen.UseVisualStyleBackColor = True
        '
        'ptrImagen
        '
        Me.ptrImagen.BackColor = System.Drawing.Color.White
        Me.ptrImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptrImagen.Location = New System.Drawing.Point(433, 42)
        Me.ptrImagen.Name = "ptrImagen"
        Me.ptrImagen.Size = New System.Drawing.Size(256, 170)
        Me.ptrImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptrImagen.TabIndex = 29
        Me.ptrImagen.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(481, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Imágen de la sucursal"
        '
        'btnlimpiar_campos
        '
        Me.btnlimpiar_campos.Enabled = False
        Me.btnlimpiar_campos.Location = New System.Drawing.Point(297, 272)
        Me.btnlimpiar_campos.Name = "btnlimpiar_campos"
        Me.btnlimpiar_campos.Size = New System.Drawing.Size(138, 30)
        Me.btnlimpiar_campos.TabIndex = 26
        Me.btnlimpiar_campos.Text = "Limpiar campos"
        Me.btnlimpiar_campos.UseVisualStyleBackColor = True
        '
        'btnterminar
        '
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(584, 272)
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
        Me.btnguardar.Location = New System.Drawing.Point(473, 272)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(105, 30)
        Me.btnguardar.TabIndex = 24
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(140, 137)
        Me.txtDescripcion.MaxLength = 300
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescripcion.Size = New System.Drawing.Size(269, 57)
        Me.txtDescripcion.TabIndex = 21
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(140, 100)
        Me.txtTelefono.MaxLength = 12
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(269, 26)
        Me.txtTelefono.TabIndex = 20
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(140, 65)
        Me.txtDireccion.MaxLength = 500
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(204, 26)
        Me.txtDireccion.TabIndex = 19
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(140, 30)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(204, 26)
        Me.txtNombre.TabIndex = 18
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(710, 49)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Agregar sucursal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_sucursal_N
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 423)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "P_sucursal_N"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar sucursal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ptrImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnlimpiar_campos As System.Windows.Forms.Button
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_imagen As System.Windows.Forms.Button
    Friend WithEvents ptrImagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
