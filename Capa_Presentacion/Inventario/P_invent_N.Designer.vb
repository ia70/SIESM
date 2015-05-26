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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.ComboBox()
        Me.gbAgregar = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnAgregarArti = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtSucursal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n_Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n_Critico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n_existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio_venta = New System.Windows.Forms.TextBox()
        Me.txtID_Articulo = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreArticulo = New System.Windows.Forms.Label()
        Me.dgvDefectuoso = New System.Windows.Forms.DataGridView()
        Me.ID_Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Defectuso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbAgregar.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDefectuoso, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label6.Size = New System.Drawing.Size(1313, 51)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Agregar Producto a Inventario"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 572)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1313, 53)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.gbAgregar)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.txtSucursal)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1313, 101)
        Me.Panel2.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtProveedor)
        Me.Panel3.Location = New System.Drawing.Point(0, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(735, 42)
        Me.Panel3.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(22, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(286, 42)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Escriba X en el campo existencia para eliminar artículo del inventario."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Proveedor:"
        '
        'txtProveedor
        '
        Me.txtProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProveedor.FormattingEnabled = True
        Me.txtProveedor.Location = New System.Drawing.Point(441, 7)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(116, 27)
        Me.txtProveedor.TabIndex = 29
        '
        'gbAgregar
        '
        Me.gbAgregar.Controls.Add(Me.TextBox1)
        Me.gbAgregar.Controls.Add(Me.btnAgregarArti)
        Me.gbAgregar.Location = New System.Drawing.Point(636, 48)
        Me.gbAgregar.Name = "gbAgregar"
        Me.gbAgregar.Size = New System.Drawing.Size(616, 57)
        Me.gbAgregar.TabIndex = 26
        Me.gbAgregar.TabStop = False
        Me.gbAgregar.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(412, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 26)
        Me.TextBox1.TabIndex = 28
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregarArti
        '
        Me.btnAgregarArti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarArti.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarArti.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarArti.Location = New System.Drawing.Point(137, 14)
        Me.btnAgregarArti.Name = "btnAgregarArti"
        Me.btnAgregarArti.Size = New System.Drawing.Size(263, 33)
        Me.btnAgregarArti.TabIndex = 27
        Me.btnAgregarArti.Text = "Agregar articulo a inventario"
        Me.btnAgregarArti.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(642, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 33)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtSucursal
        '
        Me.txtSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSucursal.FormattingEnabled = True
        Me.txtSucursal.Location = New System.Drawing.Point(109, 20)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(225, 27)
        Me.txtSucursal.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Sucursal: "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 152)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1313, 420)
        Me.SplitContainer1.SplitterDistance = 700
        Me.SplitContainer1.TabIndex = 22
        '
        'dgvTabla
        '
        Me.dgvTabla.BackgroundColor = System.Drawing.Color.White
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.nombreArticulo, Me.n_Proveedor, Me.n_Critico, Me.n_existencia})
        Me.dgvTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabla.Location = New System.Drawing.Point(0, 0)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabla.Size = New System.Drawing.Size(696, 416)
        Me.dgvTabla.TabIndex = 23
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 100
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'nombreArticulo
        '
        Me.nombreArticulo.HeaderText = "Artículo"
        Me.nombreArticulo.MinimumWidth = 300
        Me.nombreArticulo.Name = "nombreArticulo"
        Me.nombreArticulo.ReadOnly = True
        Me.nombreArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nombreArticulo.Width = 300
        '
        'n_Proveedor
        '
        Me.n_Proveedor.HeaderText = "Proveedor"
        Me.n_Proveedor.MinimumWidth = 110
        Me.n_Proveedor.Name = "n_Proveedor"
        Me.n_Proveedor.ReadOnly = True
        Me.n_Proveedor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.n_Proveedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.n_Proveedor.Width = 110
        '
        'n_Critico
        '
        Me.n_Critico.HeaderText = "N. Crit."
        Me.n_Critico.MinimumWidth = 70
        Me.n_Critico.Name = "n_Critico"
        Me.n_Critico.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.n_Critico.Width = 85
        '
        'n_existencia
        '
        Me.n_existencia.HeaderText = "Exist."
        Me.n_existencia.MinimumWidth = 70
        Me.n_existencia.Name = "n_existencia"
        Me.n_existencia.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.n_existencia.Width = 76
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
        Me.GroupBox1.Size = New System.Drawing.Size(595, 406)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de los artículos defectuosos"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(154, 117)
        Me.txtCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(60, 26)
        Me.txtCantidad.TabIndex = 9
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio_venta
        '
        Me.txtPrecio_venta.ForeColor = System.Drawing.Color.Green
        Me.txtPrecio_venta.Location = New System.Drawing.Point(263, 115)
        Me.txtPrecio_venta.Name = "txtPrecio_venta"
        Me.txtPrecio_venta.Size = New System.Drawing.Size(118, 26)
        Me.txtPrecio_venta.TabIndex = 7
        Me.txtPrecio_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtID_Articulo
        '
        Me.txtID_Articulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID_Articulo.ForeColor = System.Drawing.Color.Red
        Me.txtID_Articulo.Location = New System.Drawing.Point(26, 113)
        Me.txtID_Articulo.Name = "txtID_Articulo"
        Me.txtID_Articulo.Size = New System.Drawing.Size(103, 29)
        Me.txtID_Articulo.TabIndex = 6
        Me.txtID_Articulo.Text = "."
        Me.txtID_Articulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(404, 111)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(165, 34)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar defectuoso"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio de venta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Articulo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreArticulo
        '
        Me.txtNombreArticulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreArticulo.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreArticulo.Location = New System.Drawing.Point(3, 23)
        Me.txtNombreArticulo.Name = "txtNombreArticulo"
        Me.txtNombreArticulo.Size = New System.Drawing.Size(658, 61)
        Me.txtNombreArticulo.TabIndex = 2
        Me.txtNombreArticulo.Text = "Nombre del articulo"
        Me.txtNombreArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDefectuoso
        '
        Me.dgvDefectuoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDefectuoso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Articulo, Me.ID_Defectuso, Me.Precio_Venta, Me.Cantidad, Me.Nombre_Articulo})
        Me.dgvDefectuoso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvDefectuoso.Location = New System.Drawing.Point(3, 124)
        Me.dgvDefectuoso.Name = "dgvDefectuoso"
        Me.dgvDefectuoso.ReadOnly = True
        Me.dgvDefectuoso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDefectuoso.Size = New System.Drawing.Size(589, 279)
        Me.dgvDefectuoso.TabIndex = 0
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 625)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "P_invent_N"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Articulo a Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gbAgregar.ResumeLayout(False)
        Me.gbAgregar.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDefectuoso, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ID_Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_Defectuso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_Venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents gbAgregar As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarArti As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_venta As System.Windows.Forms.TextBox
    Friend WithEvents txtID_Articulo As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreArticulo As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents n_Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents n_Critico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents n_existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
