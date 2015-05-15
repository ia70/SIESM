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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P_NavBar = New System.Windows.Forms.Panel()
        Me.btnAdministracion = New System.Windows.Forms.Button()
        Me.btnConsultaExistencia = New System.Windows.Forms.Button()
        Me.btnConsultaPrecio = New System.Windows.Forms.Button()
        Me.btnCorteCaja = New System.Windows.Forms.Button()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.PInfoVenta = New System.Windows.Forms.Panel()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PFooter = New System.Windows.Forms.Panel()
        Me.PFecha = New System.Windows.Forms.Panel()
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.Label()
        Me.txtSucursal_Correo = New System.Windows.Forms.Label()
        Me.txtSucursal_Telefono = New System.Windows.Forms.Label()
        Me.txtSucursal_Ciudad = New System.Windows.Forms.Label()
        Me.txtSucursal_Colonia = New System.Windows.Forms.Label()
        Me.txtSucursal_Calle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.P_NavBar.SuspendLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PInfoVenta.SuspendLayout()
        Me.PFooter.SuspendLayout()
        Me.PFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(851, 149)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ACEROS INOXIDABLES, REFACCIONES Y EQUIPOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnCorteCaja.UseVisualStyleBackColor = False
        '
        'dgvTabla
        '
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Location = New System.Drawing.Point(143, 227)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTabla.Size = New System.Drawing.Size(472, 368)
        Me.dgvTabla.TabIndex = 2
        '
        'PInfoVenta
        '
        Me.PInfoVenta.BackColor = System.Drawing.Color.White
        Me.PInfoVenta.Controls.Add(Me.btnCobrar)
        Me.PInfoVenta.Controls.Add(Me.txtEfectivo)
        Me.PInfoVenta.Controls.Add(Me.Label3)
        Me.PInfoVenta.Controls.Add(Me.txtTotal)
        Me.PInfoVenta.Controls.Add(Me.Label2)
        Me.PInfoVenta.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PInfoVenta.Location = New System.Drawing.Point(637, 12)
        Me.PInfoVenta.Name = "PInfoVenta"
        Me.PInfoVenta.Size = New System.Drawing.Size(214, 449)
        Me.PInfoVenta.TabIndex = 3
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCobrar.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.CAJON_DINERO_FRONT_RS5158
        Me.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCobrar.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCobrar.Location = New System.Drawing.Point(22, 323)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(165, 113)
        Me.btnCobrar.TabIndex = 4
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'txtEfectivo
        '
        Me.txtEfectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEfectivo.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.ForeColor = System.Drawing.Color.Green
        Me.txtEfectivo.Location = New System.Drawing.Point(22, 242)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(165, 44)
        Me.txtEfectivo.TabIndex = 3
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Efectivo:"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal.Location = New System.Drawing.Point(22, 86)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(165, 44)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total:"
        '
        'PFooter
        '
        Me.PFooter.BackColor = System.Drawing.Color.Transparent
        Me.PFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PFooter.Controls.Add(Me.PFecha)
        Me.PFooter.Controls.Add(Me.txtSucursal_Correo)
        Me.PFooter.Controls.Add(Me.txtSucursal_Telefono)
        Me.PFooter.Controls.Add(Me.txtSucursal_Ciudad)
        Me.PFooter.Controls.Add(Me.txtSucursal_Colonia)
        Me.PFooter.Controls.Add(Me.txtSucursal_Calle)
        Me.PFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PFooter.Location = New System.Drawing.Point(0, 412)
        Me.PFooter.Name = "PFooter"
        Me.PFooter.Size = New System.Drawing.Size(851, 75)
        Me.PFooter.TabIndex = 4
        '
        'PFecha
        '
        Me.PFecha.BackColor = System.Drawing.Color.Transparent
        Me.PFecha.Controls.Add(Me.txtFecha)
        Me.PFecha.Controls.Add(Me.txtHora)
        Me.PFecha.Dock = System.Windows.Forms.DockStyle.Right
        Me.PFecha.Location = New System.Drawing.Point(562, 0)
        Me.PFecha.Name = "PFecha"
        Me.PFecha.Size = New System.Drawing.Size(285, 71)
        Me.PFecha.TabIndex = 5
        '
        'txtFecha
        '
        Me.txtFecha.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.White
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
        Me.txtHora.ForeColor = System.Drawing.Color.White
        Me.txtHora.Location = New System.Drawing.Point(0, 0)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(285, 32)
        Me.txtHora.TabIndex = 0
        Me.txtHora.Text = "Hora"
        Me.txtHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSucursal_Correo
        '
        Me.txtSucursal_Correo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSucursal_Correo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal_Correo.ForeColor = System.Drawing.Color.White
        Me.txtSucursal_Correo.Location = New System.Drawing.Point(329, 23)
        Me.txtSucursal_Correo.Name = "txtSucursal_Correo"
        Me.txtSucursal_Correo.Size = New System.Drawing.Size(388, 24)
        Me.txtSucursal_Correo.TabIndex = 4
        Me.txtSucursal_Correo.Text = "E-mail: plasticos_y_derivados@hotmail.com"
        '
        'txtSucursal_Telefono
        '
        Me.txtSucursal_Telefono.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSucursal_Telefono.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal_Telefono.ForeColor = System.Drawing.Color.White
        Me.txtSucursal_Telefono.Location = New System.Drawing.Point(329, 2)
        Me.txtSucursal_Telefono.Name = "txtSucursal_Telefono"
        Me.txtSucursal_Telefono.Size = New System.Drawing.Size(300, 24)
        Me.txtSucursal_Telefono.TabIndex = 3
        Me.txtSucursal_Telefono.Text = "Tel. 314-99-06"
        '
        'txtSucursal_Ciudad
        '
        Me.txtSucursal_Ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSucursal_Ciudad.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal_Ciudad.ForeColor = System.Drawing.Color.White
        Me.txtSucursal_Ciudad.Location = New System.Drawing.Point(15, 46)
        Me.txtSucursal_Ciudad.Name = "txtSucursal_Ciudad"
        Me.txtSucursal_Ciudad.Size = New System.Drawing.Size(300, 24)
        Me.txtSucursal_Ciudad.TabIndex = 2
        Me.txtSucursal_Ciudad.Text = "Villahermosa Tab. Mex."
        '
        'txtSucursal_Colonia
        '
        Me.txtSucursal_Colonia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSucursal_Colonia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal_Colonia.ForeColor = System.Drawing.Color.White
        Me.txtSucursal_Colonia.Location = New System.Drawing.Point(15, 24)
        Me.txtSucursal_Colonia.Name = "txtSucursal_Colonia"
        Me.txtSucursal_Colonia.Size = New System.Drawing.Size(300, 24)
        Me.txtSucursal_Colonia.TabIndex = 1
        Me.txtSucursal_Colonia.Text = "Colonia Centro, C.P. 86000"
        '
        'txtSucursal_Calle
        '
        Me.txtSucursal_Calle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSucursal_Calle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal_Calle.ForeColor = System.Drawing.Color.White
        Me.txtSucursal_Calle.Location = New System.Drawing.Point(15, 2)
        Me.txtSucursal_Calle.Name = "txtSucursal_Calle"
        Me.txtSucursal_Calle.Size = New System.Drawing.Size(300, 24)
        Me.txtSucursal_Calle.TabIndex = 0
        Me.txtSucursal_Calle.Text = "Calle Lino Merino #226"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(137, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 36)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Articulo:"
        '
        'txtArticulo
        '
        Me.txtArticulo.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulo.Location = New System.Drawing.Point(273, 162)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(188, 44)
        Me.txtArticulo.TabIndex = 6
        Me.txtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'P_PuntoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.bg117
        Me.ClientSize = New System.Drawing.Size(851, 487)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PFooter)
        Me.Controls.Add(Me.PInfoVenta)
        Me.Controls.Add(Me.dgvTabla)
        Me.Controls.Add(Me.P_NavBar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(690, 382)
        Me.Name = "P_PuntoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P_PuntoVenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.P_NavBar.ResumeLayout(False)
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PInfoVenta.ResumeLayout(False)
        Me.PInfoVenta.PerformLayout()
        Me.PFooter.ResumeLayout(False)
        Me.PFecha.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
End Class
