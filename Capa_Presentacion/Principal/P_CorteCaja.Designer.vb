<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_CorteCaja
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnInformeDetallado = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalArticulosVendidos = New System.Windows.Forms.Label()
        Me.txtTotaDineroCaja = New System.Windows.Forms.Label()
        Me.txtTotalVentas = New System.Windows.Forms.Label()
        Me.txtInicioCaja = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInformeSencillo = New System.Windows.Forms.Button()
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
        Me.Panel1.Size = New System.Drawing.Size(659, 391)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 340)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 46)
        Me.Panel2.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.btnSalir)
        Me.Panel3.Controls.Add(Me.btnInformeDetallado)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtTotalArticulosVendidos)
        Me.Panel3.Controls.Add(Me.txtTotaDineroCaja)
        Me.Panel3.Controls.Add(Me.txtTotalVentas)
        Me.Panel3.Controls.Add(Me.txtInicioCaja)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnInformeSencillo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(649, 332)
        Me.Panel3.TabIndex = 17
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(541, 233)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(85, 47)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnInformeDetallado
        '
        Me.btnInformeDetallado.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeDetallado.Location = New System.Drawing.Point(35, 186)
        Me.btnInformeDetallado.Name = "btnInformeDetallado"
        Me.btnInformeDetallado.Size = New System.Drawing.Size(281, 41)
        Me.btnInformeDetallado.TabIndex = 12
        Me.btnInformeDetallado.Text = "Informe detallado"
        Me.btnInformeDetallado.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(436, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 29)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "$"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(436, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 29)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "$"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(436, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "$"
        '
        'txtTotalArticulosVendidos
        '
        Me.txtTotalArticulosVendidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalArticulosVendidos.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalArticulosVendidos.ForeColor = System.Drawing.Color.Olive
        Me.txtTotalArticulosVendidos.Location = New System.Drawing.Point(463, 124)
        Me.txtTotalArticulosVendidos.Name = "txtTotalArticulosVendidos"
        Me.txtTotalArticulosVendidos.Size = New System.Drawing.Size(136, 32)
        Me.txtTotalArticulosVendidos.TabIndex = 8
        Me.txtTotalArticulosVendidos.Text = "."
        '
        'txtTotaDineroCaja
        '
        Me.txtTotaDineroCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotaDineroCaja.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotaDineroCaja.ForeColor = System.Drawing.Color.Red
        Me.txtTotaDineroCaja.Location = New System.Drawing.Point(463, 90)
        Me.txtTotaDineroCaja.Name = "txtTotaDineroCaja"
        Me.txtTotaDineroCaja.Size = New System.Drawing.Size(136, 34)
        Me.txtTotaDineroCaja.TabIndex = 7
        Me.txtTotaDineroCaja.Text = "."
        '
        'txtTotalVentas
        '
        Me.txtTotalVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotalVentas.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVentas.ForeColor = System.Drawing.Color.Black
        Me.txtTotalVentas.Location = New System.Drawing.Point(463, 56)
        Me.txtTotalVentas.Name = "txtTotalVentas"
        Me.txtTotalVentas.Size = New System.Drawing.Size(136, 34)
        Me.txtTotalVentas.TabIndex = 6
        Me.txtTotalVentas.Text = "."
        '
        'txtInicioCaja
        '
        Me.txtInicioCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInicioCaja.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicioCaja.ForeColor = System.Drawing.Color.Green
        Me.txtInicioCaja.Location = New System.Drawing.Point(463, 22)
        Me.txtInicioCaja.Name = "txtInicioCaja"
        Me.txtInicioCaja.Size = New System.Drawing.Size(136, 34)
        Me.txtInicioCaja.TabIndex = 5
        Me.txtInicioCaja.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 34)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total de dinero en caja:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 34)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total ventas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inicio de caja:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total de articulos vendidos:"
        '
        'btnInformeSencillo
        '
        Me.btnInformeSencillo.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeSencillo.Location = New System.Drawing.Point(345, 186)
        Me.btnInformeSencillo.Name = "btnInformeSencillo"
        Me.btnInformeSencillo.Size = New System.Drawing.Size(281, 41)
        Me.btnInformeSencillo.TabIndex = 0
        Me.btnInformeSencillo.Text = "Informe sencillo"
        Me.btnInformeSencillo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(649, 49)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Corte de caja"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_CorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "P_CorteCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corte de Caja"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInformeSencillo As System.Windows.Forms.Button
    Friend WithEvents txtTotalArticulosVendidos As System.Windows.Forms.Label
    Friend WithEvents txtTotaDineroCaja As System.Windows.Forms.Label
    Friend WithEvents txtTotalVentas As System.Windows.Forms.Label
    Friend WithEvents txtInicioCaja As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnInformeDetallado As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
