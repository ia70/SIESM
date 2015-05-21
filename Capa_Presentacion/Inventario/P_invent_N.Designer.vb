<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_invent_N
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSucursal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPrecio_venta = New System.Windows.Forms.TextBox()
        Me.txtID_Articulo = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreArticulo = New System.Windows.Forms.Label()
        Me.dgvDefectuoso = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.ID_Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Defectuso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDefectuoso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label6.Size = New System.Drawing.Size(1313, 49)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Agregar Producto a Inventario"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 542)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1313, 51)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtSucursal)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1313, 57)
        Me.Panel2.TabIndex = 21
        '
        'txtSucursal
        '
        Me.txtSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSucursal.FormattingEnabled = True
        Me.txtSucursal.Location = New System.Drawing.Point(95, 19)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(225, 26)
        Me.txtSucursal.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Sucursal: "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 106)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvTabla)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Size = New System.Drawing.Size(1313, 436)
        Me.SplitContainer1.SplitterDistance = 631
        Me.SplitContainer1.TabIndex = 22
        '
        'dgvTabla
        '
        Me.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTabla.BackgroundColor = System.Drawing.Color.White
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabla.Location = New System.Drawing.Point(0, 0)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.Size = New System.Drawing.Size(627, 432)
        Me.dgvTabla.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPrecio_venta)
        Me.GroupBox1.Controls.Add(Me.txtID_Articulo)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombreArticulo)
        Me.GroupBox1.Controls.Add(Me.dgvDefectuoso)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 422)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de los artículos defectuosos"
        '
        'txtPrecio_venta
        '
        Me.txtPrecio_venta.ForeColor = System.Drawing.Color.Green
        Me.txtPrecio_venta.Location = New System.Drawing.Point(265, 95)
        Me.txtPrecio_venta.Name = "txtPrecio_venta"
        Me.txtPrecio_venta.Size = New System.Drawing.Size(118, 26)
        Me.txtPrecio_venta.TabIndex = 7
        Me.txtPrecio_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtID_Articulo
        '
        Me.txtID_Articulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID_Articulo.ForeColor = System.Drawing.Color.Red
        Me.txtID_Articulo.Location = New System.Drawing.Point(26, 95)
        Me.txtID_Articulo.Name = "txtID_Articulo"
        Me.txtID_Articulo.Size = New System.Drawing.Size(103, 28)
        Me.txtID_Articulo.TabIndex = 6
        Me.txtID_Articulo.Text = "."
        Me.txtID_Articulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(404, 93)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(165, 33)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar defectuoso"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio de venta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Articulo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNombreArticulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreArticulo.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreArticulo.Location = New System.Drawing.Point(3, 22)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(658, 37)
        Me.txtNombreArticulo.TabIndex = 2
        Me.txtNombreArticulo.Text = "Nombre del articulo"
        Me.txtNombreArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDefectuoso
        '
        Me.dgvDefectuoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDefectuoso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Articulo, Me.ID_Defectuso, Me.Precio_Venta, Me.Cantidad, Me.Nombre_Articulo})
        Me.dgvDefectuoso.Location = New System.Drawing.Point(9, 151)
        Me.dgvDefectuoso.Name = "dgvDefectuoso"
        Me.dgvDefectuoso.ReadOnly = True
        Me.dgvDefectuoso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDefectuoso.Size = New System.Drawing.Size(643, 265)
        Me.dgvDefectuoso.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(154, 98)
        Me.txtCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(60, 26)
        Me.txtCantidad.TabIndex = 9
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ID_Articulo
        '
        Me.ID_Articulo.HeaderText = "ID-Artículo"
        Me.ID_Articulo.Name = "ID_Articulo"
        Me.ID_Articulo.ReadOnly = True
        '
        'ID_Defectuso
        '
        Me.ID_Defectuso.HeaderText = "ID_Defectuso"
        Me.ID_Defectuso.Name = "ID_Defectuso"
        Me.ID_Defectuso.ReadOnly = True
        Me.ID_Defectuso.Width = 120
        '
        'Precio_Venta
        '
        Me.Precio_Venta.HeaderText = "Precio de venta"
        Me.Precio_Venta.Name = "Precio_Venta"
        Me.Precio_Venta.ReadOnly = True
        Me.Precio_Venta.Width = 150
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Nombre_Articulo
        '
        Me.Nombre_Articulo.HeaderText = "Nombre del Artículo"
        Me.Nombre_Articulo.Name = "Nombre_Articulo"
        Me.Nombre_Articulo.ReadOnly = True
        Me.Nombre_Articulo.Width = 500
        '
        'P_invent_N
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 593)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "P_invent_N"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Articulo a Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDefectuoso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvTabla As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDefectuoso As System.Windows.Forms.DataGridView
    Friend WithEvents txtNombreArticulo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtID_Articulo As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_venta As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ID_Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_Defectuso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_Venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
