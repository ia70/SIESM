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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P_NavBar = New System.Windows.Forms.Panel()
        Me.btnAdministracion = New System.Windows.Forms.Button()
        Me.btnConsultaExistencia = New System.Windows.Forms.Button()
        Me.btnConsultaPrecio = New System.Windows.Forms.Button()
        Me.btnCorteCaja = New System.Windows.Forms.Button()
        Me.P_NavBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(851, 106)
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
        Me.btnAdministracion.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.Tools
        Me.btnAdministracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdministracion.Location = New System.Drawing.Point(0, 305)
        Me.btnAdministracion.Name = "btnAdministracion"
        Me.btnAdministracion.Size = New System.Drawing.Size(96, 96)
        Me.btnAdministracion.TabIndex = 3
        Me.btnAdministracion.UseVisualStyleBackColor = True
        '
        'btnConsultaExistencia
        '
        Me.btnConsultaExistencia.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.Database
        Me.btnConsultaExistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConsultaExistencia.Location = New System.Drawing.Point(0, 204)
        Me.btnConsultaExistencia.Name = "btnConsultaExistencia"
        Me.btnConsultaExistencia.Size = New System.Drawing.Size(96, 96)
        Me.btnConsultaExistencia.TabIndex = 2
        Me.btnConsultaExistencia.UseVisualStyleBackColor = True
        '
        'btnConsultaPrecio
        '
        Me.btnConsultaPrecio.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.Search
        Me.btnConsultaPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConsultaPrecio.Location = New System.Drawing.Point(0, 102)
        Me.btnConsultaPrecio.Name = "btnConsultaPrecio"
        Me.btnConsultaPrecio.Size = New System.Drawing.Size(96, 96)
        Me.btnConsultaPrecio.TabIndex = 1
        Me.btnConsultaPrecio.UseVisualStyleBackColor = True
        '
        'btnCorteCaja
        '
        Me.btnCorteCaja.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.Key
        Me.btnCorteCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCorteCaja.Location = New System.Drawing.Point(0, 0)
        Me.btnCorteCaja.Name = "btnCorteCaja"
        Me.btnCorteCaja.Size = New System.Drawing.Size(96, 96)
        Me.btnCorteCaja.TabIndex = 0
        Me.btnCorteCaja.UseVisualStyleBackColor = True
        '
        'P_PuntoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.bg117
        Me.ClientSize = New System.Drawing.Size(851, 522)
        Me.Controls.Add(Me.P_NavBar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "P_PuntoVenta"
        Me.Text = "P_PuntoVenta"
        Me.P_NavBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents P_NavBar As System.Windows.Forms.Panel
    Friend WithEvents btnAdministracion As System.Windows.Forms.Button
    Friend WithEvents btnConsultaExistencia As System.Windows.Forms.Button
    Friend WithEvents btnConsultaPrecio As System.Windows.Forms.Button
    Friend WithEvents btnCorteCaja As System.Windows.Forms.Button
End Class
