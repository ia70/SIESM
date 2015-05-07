<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_sucursal_C
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
        Me.Textfecha = New System.Windows.Forms.TextBox()
        Me.Txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.txtid_sucursal = New System.Windows.Forms.TextBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ptrimagen = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptrimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(733, 49)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Consultar Sucursal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.UseCompatibleTextRendering = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.Textfecha)
        Me.Panel3.Controls.Add(Me.Txtdescripcion)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtConsulta)
        Me.Panel3.Controls.Add(Me.dgvTabla)
        Me.Panel3.Controls.Add(Me.txtid_sucursal)
        Me.Panel3.Controls.Add(Me.btnSiguiente)
        Me.Panel3.Controls.Add(Me.btnAtras)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txttelefono)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnterminar)
        Me.Panel3.Controls.Add(Me.btnEliminar)
        Me.Panel3.Controls.Add(Me.ptrimagen)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtdireccion)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(733, 460)
        Me.Panel3.TabIndex = 19
        '
        'Textfecha
        '
        Me.Textfecha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Textfecha.Enabled = False
        Me.Textfecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textfecha.Location = New System.Drawing.Point(173, 416)
        Me.Textfecha.MaxLength = 20
        Me.Textfecha.Name = "Textfecha"
        Me.Textfecha.Size = New System.Drawing.Size(121, 26)
        Me.Textfecha.TabIndex = 84
        Me.Textfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtdescripcion
        '
        Me.Txtdescripcion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Txtdescripcion.Enabled = False
        Me.Txtdescripcion.Location = New System.Drawing.Point(173, 312)
        Me.Txtdescripcion.MaxLength = 300
        Me.Txtdescripcion.Multiline = True
        Me.Txtdescripcion.Name = "Txtdescripcion"
        Me.Txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtdescripcion.Size = New System.Drawing.Size(269, 47)
        Me.Txtdescripcion.TabIndex = 83
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(28, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(691, 10)
        Me.Label10.TabIndex = 82
        '
        'txtConsulta
        '
        Me.txtConsulta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsulta.ForeColor = System.Drawing.Color.Green
        Me.txtConsulta.Location = New System.Drawing.Point(277, 6)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(174, 26)
        Me.txtConsulta.TabIndex = 81
        Me.txtConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvTabla
        '
        Me.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTabla.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Location = New System.Drawing.Point(28, 35)
        Me.dgvTabla.MultiSelect = False
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.ReadOnly = True
        Me.dgvTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabla.Size = New System.Drawing.Size(691, 113)
        Me.dgvTabla.TabIndex = 80
        '
        'txtid_sucursal
        '
        Me.txtid_sucursal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtid_sucursal.Enabled = False
        Me.txtid_sucursal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_sucursal.Location = New System.Drawing.Point(173, 189)
        Me.txtid_sucursal.MaxLength = 20
        Me.txtid_sucursal.Name = "txtid_sucursal"
        Me.txtid_sucursal.Size = New System.Drawing.Size(204, 26)
        Me.txtid_sucursal.TabIndex = 78
        Me.txtid_sucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Image = Global.Capa_Presentacion.My.Resources.Resources.Forward
        Me.btnSiguiente.Location = New System.Drawing.Point(409, 419)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(42, 36)
        Me.btnSiguiente.TabIndex = 59
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.Capa_Presentacion.My.Resources.Resources.Back2
        Me.btnAtras.Location = New System.Drawing.Point(347, 422)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(42, 36)
        Me.btnAtras.TabIndex = 58
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Fecha:"
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txttelefono.Enabled = False
        Me.txttelefono.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(173, 378)
        Me.txttelefono.MaxLength = 20
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(121, 26)
        Me.txttelefono.TabIndex = 52
        Me.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Descripción:"
        '
        'btnterminar
        '
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(614, 422)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(105, 30)
        Me.btnterminar.TabIndex = 46
        Me.btnterminar.Text = "Terminar"
        Me.btnterminar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(503, 422)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(105, 30)
        Me.btnEliminar.TabIndex = 45
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ptrimagen
        '
        Me.ptrimagen.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ptrimagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptrimagen.Location = New System.Drawing.Point(463, 223)
        Me.ptrimagen.Name = "ptrimagen"
        Me.ptrimagen.Size = New System.Drawing.Size(256, 170)
        Me.ptrimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptrimagen.TabIndex = 44
        Me.ptrimagen.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(525, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 18)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Imágen De Sucursal:"
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Location = New System.Drawing.Point(173, 259)
        Me.txtdireccion.MaxLength = 300
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtdireccion.Size = New System.Drawing.Size(269, 47)
        Me.txtdireccion.TabIndex = 42
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(173, 222)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNombre.Size = New System.Drawing.Size(269, 26)
        Me.txtNombre.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Nombre :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Dirección:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "ID:"
        '
        'P_sucursal_C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 509)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "P_sucursal_C"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P_sucursal_C"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptrimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Textfecha As System.Windows.Forms.TextBox
    Friend WithEvents Txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtConsulta As System.Windows.Forms.TextBox
    Friend WithEvents dgvTabla As System.Windows.Forms.DataGridView
    Friend WithEvents txtid_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents ptrimagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
