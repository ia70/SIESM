<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_proveedor_EL
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
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.Label()
        Me.txtnombre_largo = New System.Windows.Forms.Label()
        Me.txtnombre_corto = New System.Windows.Forms.Label()
        Me.txtIdArticulo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnterminar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtconsulta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel1.TabIndex = 2
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
        Me.Panel3.Controls.Add(Me.txtFecha)
        Me.Panel3.Controls.Add(Me.txtdescripcion)
        Me.Panel3.Controls.Add(Me.txtnombre_largo)
        Me.Panel3.Controls.Add(Me.txtnombre_corto)
        Me.Panel3.Controls.Add(Me.txtIdArticulo)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnterminar)
        Me.Panel3.Controls.Add(Me.btnEliminar)
        Me.Panel3.Controls.Add(Me.txtconsulta)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(730, 389)
        Me.Panel3.TabIndex = 17
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(171, 227)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(273, 25)
        Me.txtFecha.TabIndex = 33
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(171, 187)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(285, 25)
        Me.txtdescripcion.TabIndex = 32
        '
        'txtnombre_largo
        '
        Me.txtnombre_largo.Location = New System.Drawing.Point(171, 152)
        Me.txtnombre_largo.Name = "txtnombre_largo"
        Me.txtnombre_largo.Size = New System.Drawing.Size(285, 25)
        Me.txtnombre_largo.TabIndex = 31
        '
        'txtnombre_corto
        '
        Me.txtnombre_corto.Location = New System.Drawing.Point(171, 118)
        Me.txtnombre_corto.Name = "txtnombre_corto"
        Me.txtnombre_corto.Size = New System.Drawing.Size(285, 25)
        Me.txtnombre_corto.TabIndex = 30
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(171, 83)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(285, 25)
        Me.txtIdArticulo.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Código de barra:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 19)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Fecha registro:"
        '
        'btnterminar
        '
        Me.btnterminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnterminar.Location = New System.Drawing.Point(613, 303)
        Me.btnterminar.Name = "btnterminar"
        Me.btnterminar.Size = New System.Drawing.Size(105, 30)
        Me.btnterminar.TabIndex = 25
        Me.btnterminar.Text = "Terminar"
        Me.btnterminar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(502, 303)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(105, 30)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtconsulta
        '
        Me.txtconsulta.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtconsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtconsulta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtconsulta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconsulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtconsulta.Location = New System.Drawing.Point(214, 33)
        Me.txtconsulta.MaxLength = 20
        Me.txtconsulta.Name = "txtconsulta"
        Me.txtconsulta.Size = New System.Drawing.Size(123, 26)
        Me.txtconsulta.TabIndex = 18
        Me.txtconsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre largo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nombre corto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripción:"
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
        Me.Label6.Text = "Eliminar proveedor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_proveedor_EL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "P_proveedor_EL"
        Me.Text = "Eliminar proveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtFecha As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.Label
    Friend WithEvents txtnombre_largo As System.Windows.Forms.Label
    Friend WithEvents txtnombre_corto As System.Windows.Forms.Label
    Friend WithEvents txtIdArticulo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnterminar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtconsulta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
