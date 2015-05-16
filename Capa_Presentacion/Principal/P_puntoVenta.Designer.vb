<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PuntoVenta
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.P_NavBar = New System.Windows.Forms.Panel()
        Me.btnAdministracion = New System.Windows.Forms.Button()
        Me.btnConsultaExistencia = New System.Windows.Forms.Button()
        Me.btnConsultaPrecio = New System.Windows.Forms.Button()
        Me.btnCorteCaja = New System.Windows.Forms.Button()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarTodaLaTablaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PInfoVenta = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipo_Pago = New System.Windows.Forms.ComboBox()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PFooter = New System.Windows.Forms.Panel()
        Me.PFecha = New System.Windows.Forms.Panel()
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.Label()
        Me.txtSucursal_Correo = New System.Windows.Forms.Label()
        Me.txtSucursal_Telefono = New System.Windows.Forms.Label()
        Me.txtSucursal_Ciudad = New System.Windows.Forms.Label()
        Me.txtSucursal_Colonia = New System.Windows.Forms.Label()
        Me.txtSucursal_Calle = New System.Windows.Forms.Label()
        Me.PHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TTCorteCaja = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTransacción = New System.Windows.Forms.ComboBox()
        Me.P_NavBar.SuspendLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cMenu.SuspendLayout()
        Me.PInfoVenta.SuspendLayout()
        Me.PFooter.SuspendLayout()
        Me.PFecha.SuspendLayout()
        Me.PHeader.SuspendLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_NavBar
        '
        Me.P_NavBar.BackColor = System.Drawing.Color.Transparent
        Me.P_NavBar.Controls.Add(Me.btnAdministracion)
        Me.P_NavBar.Controls.Add(Me.btnConsultaExistencia)
        Me.P_NavBar.Controls.Add(Me.btnConsultaPrecio)
        Me.P_NavBar.Controls.Add(Me.btnCorteCaja)
        Me.P_NavBar.Location = New System.Drawing.Point(22, 90)
        Me.P_NavBar.Name = "P_NavBar"
        Me.P_NavBar.Size = New System.Drawing.Size(98, 403)
        Me.P_NavBar.TabIndex = 1
        '
        'btnAdministracion
        '
        Me.btnAdministracion.BackColor = System.Drawing.Color.White
        Me.btnAdministracion.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.Tools
        Me.btnAdministracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdministracion.Location = New System.Drawing.Point(0, 305)
        Me.btnAdministracion.Name = "btnAdministracion"
        Me.btnAdministracion.Size = New System.Drawing.Size(96, 96)
        Me.btnAdministracion.TabIndex = 3
        Me.TTCorteCaja.SetToolTip(Me.btnAdministracion, "Administración")
        Me.btnAdministracion.UseVisualStyleBackColor = False
        '
        'btnConsultaExistencia
        '
        Me.btnConsultaExistencia.BackColor = System.Drawing.Color.White
        Me.btnConsultaExistencia.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.Database
        Me.btnConsultaExistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConsultaExistencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConsultaExistencia.Location = New System.Drawing.Point(0, 204)
        Me.btnConsultaExistencia.Name = "btnConsultaExistencia"
        Me.btnConsultaExistencia.Size = New System.Drawing.Size(96, 96)
        Me.btnConsultaExistencia.TabIndex = 2
        Me.TTCorteCaja.SetToolTip(Me.btnConsultaExistencia, "Consultar existencia de articulo en tiendas")
        Me.btnConsultaExistencia.UseVisualStyleBackColor = False
        '
        'btnConsultaPrecio
        '
        Me.btnConsultaPrecio.BackColor = System.Drawing.Color.White
        Me.btnConsultaPrecio.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.Search
        Me.btnConsultaPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConsultaPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConsultaPrecio.Location = New System.Drawing.Point(0, 102)
        Me.btnConsultaPrecio.Name = "btnConsultaPrecio"
        Me.btnConsultaPrecio.Size = New System.Drawing.Size(96, 96)
        Me.btnConsultaPrecio.TabIndex = 1
        Me.TTCorteCaja.SetToolTip(Me.btnConsultaPrecio, "Consultar precio de un artículo")
        Me.btnConsultaPrecio.UseVisualStyleBackColor = False
        '
        'btnCorteCaja
        '
        Me.btnCorteCaja.BackColor = System.Drawing.Color.White
        Me.btnCorteCaja.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.Key
        Me.btnCorteCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCorteCaja.Location = New System.Drawing.Point(0, 0)
        Me.btnCorteCaja.Name = "btnCorteCaja"
        Me.btnCorteCaja.Size = New System.Drawing.Size(96, 96)
        Me.btnCorteCaja.TabIndex = 0
        Me.TTCorteCaja.SetToolTip(Me.btnCorteCaja, "Corte de Caja" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnCorteCaja.UseVisualStyleBackColor = False
        '
        'dgvTabla
        '
        Me.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTabla.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Articulo, Me.Cantidad, Me.Precio, Me.Subtotal})
        Me.dgvTabla.ContextMenuStrip = Me.cMenu
        Me.dgvTabla.Location = New System.Drawing.Point(143, 256)
        Me.dgvTabla.MultiSelect = False
        Me.dgvTabla.Name = "dgvTabla"
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTabla.RowsDefaultCellStyle = DataGridViewCellStyle32
        Me.dgvTabla.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabla.Size = New System.Drawing.Size(735, 339)
        Me.dgvTabla.TabIndex = 2
        Me.TTCorteCaja.SetToolTip(Me.dgvTabla, "Listado de los articulos que se están vendiendo." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Presiona click derecho si des" & _
        "eas borrar uno o todos los registros.")
        '
        'ID
        '
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.DefaultCellStyle = DataGridViewCellStyle22
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 80
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 80
        '
        'Articulo
        '
        Me.Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Articulo.DefaultCellStyle = DataGridViewCellStyle28
        Me.Articulo.Frozen = True
        Me.Articulo.HeaderText = "Nombre del Articulo"
        Me.Articulo.MinimumWidth = 500
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        Me.Articulo.Width = 500
        '
        'Cantidad
        '
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle29
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 80
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ToolTipText = "Para modificar la cantidad has doble click en el campo cantidad de la fila desead" & _
    "a."
        Me.Cantidad.Width = 97
        '
        'Precio
        '
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle30
        Me.Precio.Frozen = True
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 80
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 80
        '
        'Subtotal
        '
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle31
        Me.Subtotal.Frozen = True
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.MinimumWidth = 80
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 90
        '
        'cMenu
        '
        Me.cMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarRegistroToolStripMenuItem, Me.BorrarTodaLaTablaToolStripMenuItem})
        Me.cMenu.Name = "ContextMenuStrip1"
        Me.cMenu.Size = New System.Drawing.Size(175, 48)
        '
        'EliminarRegistroToolStripMenuItem
        '
        Me.EliminarRegistroToolStripMenuItem.Name = "EliminarRegistroToolStripMenuItem"
        Me.EliminarRegistroToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.EliminarRegistroToolStripMenuItem.Text = "Borrar registro"
        '
        'BorrarTodaLaTablaToolStripMenuItem
        '
        Me.BorrarTodaLaTablaToolStripMenuItem.Name = "BorrarTodaLaTablaToolStripMenuItem"
        Me.BorrarTodaLaTablaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.BorrarTodaLaTablaToolStripMenuItem.Text = "Borrar toda la tabla"
        '
        'PInfoVenta
        '
        Me.PInfoVenta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PInfoVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PInfoVenta.Controls.Add(Me.Label6)
        Me.PInfoVenta.Controls.Add(Me.txtTipo_Pago)
        Me.PInfoVenta.Controls.Add(Me.btnCobrar)
        Me.PInfoVenta.Controls.Add(Me.txtEfectivo)
        Me.PInfoVenta.Controls.Add(Me.Label3)
        Me.PInfoVenta.Controls.Add(Me.txtTotal)
        Me.PInfoVenta.Controls.Add(Me.Label2)
        Me.PInfoVenta.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PInfoVenta.Location = New System.Drawing.Point(884, 154)
        Me.PInfoVenta.Name = "PInfoVenta"
        Me.PInfoVenta.Size = New System.Drawing.Size(214, 417)
        Me.PInfoVenta.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 32)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tipo de pago:"
        Me.TTCorteCaja.SetToolTip(Me.Label6, "Efectivo con el que está pagando el cliente")
        '
        'txtTipo_Pago
        '
        Me.txtTipo_Pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipo_Pago.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo_Pago.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtTipo_Pago.FormattingEnabled = True
        Me.txtTipo_Pago.Items.AddRange(New Object() {"Efectivo", "Cheque"})
        Me.txtTipo_Pago.Location = New System.Drawing.Point(21, 143)
        Me.txtTipo_Pago.Name = "txtTipo_Pago"
        Me.txtTipo_Pago.Size = New System.Drawing.Size(166, 40)
        Me.txtTipo_Pago.TabIndex = 5
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCobrar.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.CAJON_DINERO_FRONT_RS51581
        Me.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCobrar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCobrar.Location = New System.Drawing.Point(22, 316)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(165, 92)
        Me.btnCobrar.TabIndex = 4
        Me.btnCobrar.Text = "Cobrar"
        Me.TTCorteCaja.SetToolTip(Me.btnCobrar, "Cobrar venta")
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'txtEfectivo
        '
        Me.txtEfectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEfectivo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.ForeColor = System.Drawing.Color.Green
        Me.txtEfectivo.Location = New System.Drawing.Point(21, 242)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(165, 39)
        Me.txtEfectivo.TabIndex = 3
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TTCorteCaja.SetToolTip(Me.txtEfectivo, "Efectivo con el que está pagando el cliente")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(47, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Monto:"
        Me.TTCorteCaja.SetToolTip(Me.Label3, "Efectivo con el que está pagando el cliente")
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtTotal.Location = New System.Drawing.Point(22, 47)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotal.Size = New System.Drawing.Size(165, 35)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TTCorteCaja.SetToolTip(Me.txtTotal, "Total de la venta")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(57, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total:"
        Me.TTCorteCaja.SetToolTip(Me.Label2, "Total de la venta")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(149, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Articulo:"
        '
        'txtArticulo
        '
        Me.txtArticulo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulo.Location = New System.Drawing.Point(143, 194)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(146, 39)
        Me.txtArticulo.TabIndex = 6
        Me.txtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TTCorteCaja.SetToolTip(Me.txtArticulo, "Clave del artículo")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PFooter
        '
        Me.PFooter.BackColor = System.Drawing.Color.Silver
        Me.PFooter.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.metal5
        Me.PFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PFooter.Controls.Add(Me.PFecha)
        Me.PFooter.Controls.Add(Me.txtSucursal_Correo)
        Me.PFooter.Controls.Add(Me.txtSucursal_Telefono)
        Me.PFooter.Controls.Add(Me.txtSucursal_Ciudad)
        Me.PFooter.Controls.Add(Me.txtSucursal_Colonia)
        Me.PFooter.Controls.Add(Me.txtSucursal_Calle)
        Me.PFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PFooter.Location = New System.Drawing.Point(0, 575)
        Me.PFooter.Name = "PFooter"
        Me.PFooter.Size = New System.Drawing.Size(1097, 75)
        Me.PFooter.TabIndex = 4
        '
        'PFecha
        '
        Me.PFecha.BackColor = System.Drawing.Color.Transparent
        Me.PFecha.Controls.Add(Me.txtFecha)
        Me.PFecha.Controls.Add(Me.txtHora)
        Me.PFecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.PFecha.Location = New System.Drawing.Point(808, 0)
        Me.PFecha.Name = "PFecha"
        Me.PFecha.Size = New System.Drawing.Size(285, 71)
        Me.PFecha.TabIndex = 5
        '
        'txtFecha
        '
        Me.txtFecha.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.Black
        Me.txtFecha.Location = New System.Drawing.Point(0, 39)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(285, 32)
        Me.txtFecha.TabIndex = 1
        Me.txtFecha.Text = "Fecha"
        Me.txtFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHora
        '
        Me.txtHora.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtHora.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.ForeColor = System.Drawing.Color.Black
        Me.txtHora.Location = New System.Drawing.Point(0, 0)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(285, 32)
        Me.txtHora.TabIndex = 0
        Me.txtHora.Text = "Hora"
        Me.txtHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSucursal_Correo
        '
        Me.txtSucursal_Correo.BackColor = System.Drawing.Color.Transparent
        Me.txtSucursal_Correo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSucursal_Correo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal_Correo.ForeColor = System.Drawing.Color.Black
        Me.txtSucursal_Correo.Location = New System.Drawing.Point(329, 23)
        Me.txtSucursal_Correo.Name = "txtSucursal_Correo"
        Me.txtSucursal_Correo.Size = New System.Drawing.Size(409, 24)
        Me.txtSucursal_Correo.TabIndex = 4
        Me.txtSucursal_Correo.Text = "E-mail: plasticos_y_derivados@hotmail.com"
        '
        'txtSucursal_Telefono
        '
        Me.txtSucursal_Telefono.BackColor = System.Drawing.Color.Transparent
        Me.txtSucursal_Telefono.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSucursal_Telefono.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal_Telefono.ForeColor = System.Drawing.Color.Black
        Me.txtSucursal_Telefono.Location = New System.Drawing.Point(329, 2)
        Me.txtSucursal_Telefono.Name = "txtSucursal_Telefono"
        Me.txtSucursal_Telefono.Size = New System.Drawing.Size(300, 24)
        Me.txtSucursal_Telefono.TabIndex = 3
        Me.txtSucursal_Telefono.Text = "Tel. 314-99-06"
        '
        'txtSucursal_Ciudad
        '
        Me.txtSucursal_Ciudad.BackColor = System.Drawing.Color.Transparent
        Me.txtSucursal_Ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSucursal_Ciudad.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal_Ciudad.ForeColor = System.Drawing.Color.Black
        Me.txtSucursal_Ciudad.Location = New System.Drawing.Point(15, 46)
        Me.txtSucursal_Ciudad.Name = "txtSucursal_Ciudad"
        Me.txtSucursal_Ciudad.Size = New System.Drawing.Size(300, 24)
        Me.txtSucursal_Ciudad.TabIndex = 2
        Me.txtSucursal_Ciudad.Text = "Villahermosa Tab. Mex."
        '
        'txtSucursal_Colonia
        '
        Me.txtSucursal_Colonia.BackColor = System.Drawing.Color.Transparent
        Me.txtSucursal_Colonia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSucursal_Colonia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal_Colonia.ForeColor = System.Drawing.Color.Black
        Me.txtSucursal_Colonia.Location = New System.Drawing.Point(15, 24)
        Me.txtSucursal_Colonia.Name = "txtSucursal_Colonia"
        Me.txtSucursal_Colonia.Size = New System.Drawing.Size(300, 24)
        Me.txtSucursal_Colonia.TabIndex = 1
        Me.txtSucursal_Colonia.Text = "Colonia Centro, C.P. 86000"
        '
        'txtSucursal_Calle
        '
        Me.txtSucursal_Calle.BackColor = System.Drawing.Color.Transparent
        Me.txtSucursal_Calle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSucursal_Calle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal_Calle.ForeColor = System.Drawing.Color.Black
        Me.txtSucursal_Calle.Location = New System.Drawing.Point(15, 2)
        Me.txtSucursal_Calle.Name = "txtSucursal_Calle"
        Me.txtSucursal_Calle.Size = New System.Drawing.Size(300, 24)
        Me.txtSucursal_Calle.TabIndex = 0
        Me.txtSucursal_Calle.Text = "Calle Lino Merino #226"
        '
        'PHeader
        '
        Me.PHeader.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.metal5
        Me.PHeader.Controls.Add(Me.Label1)
        Me.PHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PHeader.Location = New System.Drawing.Point(0, 0)
        Me.PHeader.Name = "PHeader"
        Me.PHeader.Size = New System.Drawing.Size(1097, 148)
        Me.PHeader.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1097, 148)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ACEROS INOXIDABLES, REFACCIONES Y EQUIPOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(313, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(344, 194)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txtCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(65, 39)
        Me.txtCantidad.TabIndex = 9
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(490, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 32)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Transacción:"
        '
        'txtTransacción
        '
        Me.txtTransacción.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTransacción.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransacción.FormattingEnabled = True
        Me.txtTransacción.Items.AddRange(New Object() {"Venta", "Cotización"})
        Me.txtTransacción.Location = New System.Drawing.Point(498, 194)
        Me.txtTransacción.Name = "txtTransacción"
        Me.txtTransacción.Size = New System.Drawing.Size(166, 40)
        Me.txtTransacción.TabIndex = 11
        '
        'P_PuntoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.fondos14
        Me.ClientSize = New System.Drawing.Size(1097, 650)
        Me.Controls.Add(Me.txtTransacción)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PHeader)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PFooter)
        Me.Controls.Add(Me.PInfoVenta)
        Me.Controls.Add(Me.dgvTabla)
        Me.Controls.Add(Me.P_NavBar)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(690, 382)
        Me.Name = "P_PuntoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P_PuntoVenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.P_NavBar.ResumeLayout(False)
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cMenu.ResumeLayout(False)
        Me.PInfoVenta.ResumeLayout(False)
        Me.PInfoVenta.PerformLayout()
        Me.PFooter.ResumeLayout(False)
        Me.PFecha.ResumeLayout(False)
        Me.PHeader.ResumeLayout(False)
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P_NavBar As System.Windows.Forms.Panel
    Friend WithEvents btnAdministracion As System.Windows.Forms.Button
    Friend WithEvents btnConsultaExistencia As System.Windows.Forms.Button
    Friend WithEvents btnConsultaPrecio As System.Windows.Forms.Button
    Friend WithEvents btnCorteCaja As System.Windows.Forms.Button
    Friend WithEvents dgvTabla As System.Windows.Forms.DataGridView
    Friend WithEvents PInfoVenta As System.Windows.Forms.Panel
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents PFooter As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtSucursal_Calle As System.Windows.Forms.Label
    Friend WithEvents txtSucursal_Ciudad As System.Windows.Forms.Label
    Friend WithEvents txtSucursal_Colonia As System.Windows.Forms.Label
    Friend WithEvents txtSucursal_Telefono As System.Windows.Forms.Label
    Friend WithEvents txtSucursal_Correo As System.Windows.Forms.Label
    Friend WithEvents PFecha As System.Windows.Forms.Panel
    Friend WithEvents txtFecha As System.Windows.Forms.Label
    Friend WithEvents txtHora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PHeader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarTodaLaTablaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TTCorteCaja As System.Windows.Forms.ToolTip
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTipo_Pago As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTransacción As System.Windows.Forms.ComboBox
End Class
