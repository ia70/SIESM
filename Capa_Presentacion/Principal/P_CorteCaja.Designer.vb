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
        Me.txtTotalArticulosVendidos = New System.Windows.Forms.Label()
        Me.txtTotaDineroCaja = New System.Windows.Forms.Label()
        Me.txtTotalVentas = New System.Windows.Forms.Label()
        Me.txtInicioCaja = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCorte = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.Panel1.Size = New System.Drawing.Size(487, 314)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 263)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(477, 46)
        Me.Panel2.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
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
        Me.Panel3.Controls.Add(Me.btnCorte)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(5, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(477, 255)
        Me.Panel3.TabIndex = 17
        '
        'txtTotalArticulosVendidos
        '
        Me.txtTotalArticulosVendidos.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalArticulosVendidos.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalArticulosVendidos.Location = New System.Drawing.Point(302, 109)
        Me.txtTotalArticulosVendidos.Name = "txtTotalArticulosVendidos"
        Me.txtTotalArticulosVendidos.Size = New System.Drawing.Size(136, 32)
        Me.txtTotalArticulosVendidos.TabIndex = 8
        Me.txtTotalArticulosVendidos.Text = "."
        '
        'txtTotaDineroCaja
        '
        Me.txtTotaDineroCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotaDineroCaja.ForeColor = System.Drawing.Color.Red
        Me.txtTotaDineroCaja.Location = New System.Drawing.Point(315, 81)
        Me.txtTotaDineroCaja.Name = "txtTotaDineroCaja"
        Me.txtTotaDineroCaja.Size = New System.Drawing.Size(136, 28)
        Me.txtTotaDineroCaja.TabIndex = 7
        Me.txtTotaDineroCaja.Text = "."
        '
        'txtTotalVentas
        '
        Me.txtTotalVentas.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVentas.ForeColor = System.Drawing.Color.Black
        Me.txtTotalVentas.Location = New System.Drawing.Point(315, 50)
        Me.txtTotalVentas.Name = "txtTotalVentas"
        Me.txtTotalVentas.Size = New System.Drawing.Size(136, 31)
        Me.txtTotalVentas.TabIndex = 6
        Me.txtTotalVentas.Text = "."
        '
        'txtInicioCaja
        '
        Me.txtInicioCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicioCaja.ForeColor = System.Drawing.Color.Green
        Me.txtInicioCaja.Location = New System.Drawing.Point(315, 22)
        Me.txtInicioCaja.Name = "txtInicioCaja"
        Me.txtInicioCaja.Size = New System.Drawing.Size(136, 28)
        Me.txtInicioCaja.TabIndex = 5
        Me.txtInicioCaja.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total de dinero en caja:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total ventas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inicio de caja:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total de articulos vendidos:"
        '
        'btnCorte
        '
        Me.btnCorte.Location = New System.Drawing.Point(316, 161)
        Me.btnCorte.Name = "btnCorte"
        Me.btnCorte.Size = New System.Drawing.Size(135, 31)
        Me.btnCorte.TabIndex = 0
        Me.btnCorte.Text = "Hacer corte"
        Me.btnCorte.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(477, 49)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Corte de caja"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(302, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "$"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(302, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 29)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "$"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(302, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 29)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "$"
        '
        'P_CorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 314)
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
    Friend WithEvents btnCorte As System.Windows.Forms.Button
    Friend WithEvents txtTotalArticulosVendidos As System.Windows.Forms.Label
    Friend WithEvents txtTotaDineroCaja As System.Windows.Forms.Label
    Friend WithEvents txtTotalVentas As System.Windows.Forms.Label
    Friend WithEvents txtInicioCaja As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
