<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_CajaInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_CajaInicio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInicioCaja = New System.Windows.Forms.TextBox()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 78)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Efectivo con el que se iniciará la caja:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInicioCaja
        '
        Me.txtInicioCaja.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicioCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtInicioCaja.Location = New System.Drawing.Point(69, 120)
        Me.txtInicioCaja.MaxLength = 10
        Me.txtInicioCaja.Name = "txtInicioCaja"
        Me.txtInicioCaja.Size = New System.Drawing.Size(197, 41)
        Me.txtInicioCaja.TabIndex = 1
        Me.txtInicioCaja.Text = "0.00"
        Me.txtInicioCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnContinuar
        '
        Me.btnContinuar.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnContinuar.Location = New System.Drawing.Point(69, 173)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(197, 49)
        Me.btnContinuar.TabIndex = 2
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'P_CajaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(340, 232)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.txtInicioCaja)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "P_CajaInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInicioCaja As System.Windows.Forms.TextBox
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
End Class
