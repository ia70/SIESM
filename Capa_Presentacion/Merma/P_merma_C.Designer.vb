<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txtid_sucursal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.Txthora = New System.Windows.Forms.TextBox()
        Me.Txtfecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtid_usuario = New System.Windows.Forms.TextBox()
        Me.Txtid_merma = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnlimpiar_campos = New System.Windows.Forms.Button()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Txtmotivo = New System.Windows.Forms.TextBox()
        Me.Txtid_articulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label6.Size = New System.Drawing.Size(662, 49)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Merma Consultar"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.Txtid_sucursal)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.btnSiguiente)
        Me.Panel3.Controls.Add(Me.btnAtras)
        Me.Panel3.Controls.Add(Me.txtConsulta)
        Me.Panel3.Controls.Add(Me.dgvTabla)
        Me.Panel3.Controls.Add(Me.Txthora)
        Me.Panel3.Controls.Add(Me.Txtfecha)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Txtid_usuario)
        Me.Panel3.Controls.Add(Me.Txtid_merma)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Txtcantidad)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnlimpiar_campos)
        Me.Panel3.Controls.Add(Me.btnterminar)
        Me.Panel3.Controls.Add(Me.btnguardar)
        Me.Panel3.Controls.Add(Me.Txtmotivo)
        Me.Panel3.Controls.Add(Me.Txtid_articulo)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(662, 537)
        Me.Panel3.TabIndex = 18
        '
        'Txtid_sucursal
        '
        Me.Txtid_sucursal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtid_sucursal.Location = New System.Drawing.Point(122, 146)
        Me.Txtid_sucursal.MaxLength = 20
        Me.Txtid_sucursal.Name = "Txtid_sucursal"
        Me.Txtid_sucursal.Size = New System.Drawing.Size(204, 26)
        Me.Txtid_sucursal.TabIndex = 94
        Me.Txtid_sucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Sucursal:"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Image = Global.Capa_Presentacion.My.Resources.Resources.Forward
        Me.btnSiguiente.Location = New System.Drawing.Point(232, 439)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(38, 36)
        Me.btnSiguiente.TabIndex = 92
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.Capa_Presentacion.My.Resources.Resources.Back2
        Me.btnAtras.Location = New System.Drawing.Point(184, 439)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(38, 36)
        Me.btnAtras.TabIndex = 91
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'txtConsulta
        '
        Me.txtConsulta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsulta.ForeColor = System.Drawing.Color.Green
        Me.txtConsulta.Location = New System.Drawing.Point(253, 3)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(174, 26)
        Me.txtConsulta.TabIndex = 90
        Me.txtConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvTabla
        '
        Me.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTabla.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Location = New System.Drawing.Point(55, 35)
        Me.dgvTabla.MultiSelect = False
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.ReadOnly = True
        Me.dgvTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabla.Size = New System.Drawing.Size(568, 99)
        Me.dgvTabla.TabIndex = 89
        '
        'Txthora
        '
        Me.Txthora.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txthora.Location = New System.Drawing.Point(122, 410)
        Me.Txthora.MaxLength = 20
        Me.Txthora.Name = "Txthora"
        Me.Txthora.Size = New System.Drawing.Size(204, 26)
        Me.Txthora.TabIndex = 44
        Me.Txthora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtfecha
        '
        Me.Txtfecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfecha.Location = New System.Drawing.Point(122, 370)
        Me.Txtfecha.MaxLength = 20
        Me.Txtfecha.Name = "Txtfecha"
        Me.Txtfecha.Size = New System.Drawing.Size(204, 26)
        Me.Txtfecha.TabIndex = 43
        Me.Txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 18)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Hora:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Fecha:"
        '
        'Txtid_usuario
        '
        Me.Txtid_usuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtid_usuario.Location = New System.Drawing.Point(122, 214)
        Me.Txtid_usuario.MaxLength = 20
        Me.Txtid_usuario.Name = "Txtid_usuario"
        Me.Txtid_usuario.Size = New System.Drawing.Size(204, 26)
        Me.Txtid_usuario.TabIndex = 40
        Me.Txtid_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtid_merma
        '
        Me.Txtid_merma.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtid_merma.Location = New System.Drawing.Point(122, 179)
        Me.Txtid_merma.MaxLength = 20
        Me.Txtid_merma.Name = "Txtid_merma"
        Me.Txtid_merma.Size = New System.Drawing.Size(204, 26)
        Me.Txtid_merma.TabIndex = 39
        Me.Txtid_merma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 18)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Usuario:"
        '
        'Txtcantidad
        '
        Me.Txtcantidad.Enabled = False
        Me.Txtcantidad.Location = New System.Drawing.Point(174, 332)
        Me.Txtcantidad.Name = "Txtcantidad"
        Me.Txtcantidad.Size = New System.Drawing.Size(78, 26)
        Me.Txtcantidad.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Cantidad:"
        '
        'btnlimpiar_campos
        '
        Me.btnlimpiar_campos.Enabled = False
        Me.btnlimpiar_campos.Location = New System.Drawing.Point(289, 445)
        Me.btnlimpiar_campos.Name = "btnlimpiar_campos"
        Me.btnlimpiar_campos.Size = New System.Drawing.Size(138, 30)
        Me.btnlimpiar_campos.TabIndex = 26
        Me.btnlimpiar_campos.Text = "Limpiar campos"
        Me.btnlimpiar_campos.UseVisualStyleBackColor = True
        '
        'btnterminar
        '
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(544, 445)
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
        Me.btnguardar.Location = New System.Drawing.Point(433, 445)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(105, 30)
        Me.btnguardar.TabIndex = 24
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'Txtmotivo
        '
        Me.Txtmotivo.Enabled = False
        Me.Txtmotivo.Location = New System.Drawing.Point(122, 280)
        Me.Txtmotivo.MaxLength = 300
        Me.Txtmotivo.Multiline = True
        Me.Txtmotivo.Name = "Txtmotivo"
        Me.Txtmotivo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtmotivo.Size = New System.Drawing.Size(269, 47)
        Me.Txtmotivo.TabIndex = 21
        '
        'Txtid_articulo
        '
        Me.Txtid_articulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtid_articulo.Location = New System.Drawing.Point(122, 246)
        Me.Txtid_articulo.MaxLength = 20
        Me.Txtid_articulo.Name = "Txtid_articulo"
        Me.Txtid_articulo.Size = New System.Drawing.Size(204, 26)
        Me.Txtid_articulo.TabIndex = 18
        Me.Txtid_articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Motivo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Artículo:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 586)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Merma Consultar"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Txtid_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents txtConsulta As System.Windows.Forms.TextBox
    Friend WithEvents dgvTabla As System.Windows.Forms.DataGridView
    Friend WithEvents Txthora As System.Windows.Forms.TextBox
    Friend WithEvents Txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtid_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Txtid_merma As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtcantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnlimpiar_campos As System.Windows.Forms.Button
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents Txtmotivo As System.Windows.Forms.TextBox
    Friend WithEvents Txtid_articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
