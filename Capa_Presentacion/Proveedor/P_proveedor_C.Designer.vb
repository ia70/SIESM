<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_proveedor_C
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_proveedor_C))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId_proveedor = New System.Windows.Forms.TextBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.btnterminar = New System.Windows.Forms.Button()
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
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(434, 524)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 473)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 46)
        Me.Panel2.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.txtFecha)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtId_proveedor)
        Me.Panel3.Controls.Add(Me.btnSiguiente)
        Me.Panel3.Controls.Add(Me.btnAtras)
        Me.Panel3.Controls.Add(Me.txtConsulta)
        Me.Panel3.Controls.Add(Me.dgvTabla)
        Me.Panel3.Controls.Add(Me.btnterminar)
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
        Me.Panel3.Size = New System.Drawing.Size(424, 465)
        Me.Panel3.TabIndex = 17
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(129, 339)
        Me.txtFecha.MaxLength = 30
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(269, 26)
        Me.txtFecha.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 18)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Fecha Reg. :"
        '
        'txtId_proveedor
        '
        Me.txtId_proveedor.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtId_proveedor.Enabled = False
        Me.txtId_proveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_proveedor.Location = New System.Drawing.Point(339, 165)
        Me.txtId_proveedor.MaxLength = 20
        Me.txtId_proveedor.Name = "txtId_proveedor"
        Me.txtId_proveedor.Size = New System.Drawing.Size(59, 26)
        Me.txtId_proveedor.TabIndex = 85
        Me.txtId_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Image = Global.Capa_Presentacion.My.Resources.Resources.Forward
        Me.btnSiguiente.Location = New System.Drawing.Point(190, 374)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(42, 36)
        Me.btnSiguiente.TabIndex = 84
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Image = Global.Capa_Presentacion.My.Resources.Resources.Back2
        Me.btnAtras.Location = New System.Drawing.Point(129, 374)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(42, 36)
        Me.btnAtras.TabIndex = 83
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'txtConsulta
        '
        Me.txtConsulta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsulta.ForeColor = System.Drawing.Color.Green
        Me.txtConsulta.Location = New System.Drawing.Point(129, 18)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(174, 26)
        Me.txtConsulta.TabIndex = 82
        Me.txtConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvTabla
        '
        Me.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTabla.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Location = New System.Drawing.Point(28, 50)
        Me.dgvTabla.MultiSelect = False
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.ReadOnly = True
        Me.dgvTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabla.Size = New System.Drawing.Size(370, 99)
        Me.dgvTabla.TabIndex = 81
        '
        'btnterminar
        '
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(297, 380)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(105, 30)
        Me.btnterminar.TabIndex = 25
        Me.btnterminar.Text = "Terminar"
        Me.btnterminar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(129, 269)
        Me.txtDescripcion.MaxLength = 120
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescripcion.Size = New System.Drawing.Size(269, 61)
        Me.txtDescripcion.TabIndex = 21
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(129, 235)
        Me.txtTelefono.MaxLength = 30
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(269, 26)
        Me.txtTelefono.TabIndex = 20
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(129, 200)
        Me.txtDireccion.MaxLength = 15
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(204, 26)
        Me.txtDireccion.TabIndex = 19
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(129, 165)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(204, 26)
        Me.txtNombre.TabIndex = 18
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 168)
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
        Me.Label6.Size = New System.Drawing.Size(424, 49)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Consultar proveedor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_proveedor_C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "P_proveedor_C"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar proveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents txtConsulta As System.Windows.Forms.TextBox
    Friend WithEvents dgvTabla As System.Windows.Forms.DataGridView
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtId_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
