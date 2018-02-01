<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ab_dni_share
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
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtdni
        '
        Me.txtdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(56, 13)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(283, 26)
        Me.txtdni.TabIndex = 96
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(12, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 15)
        Me.Label22.TabIndex = 95
        Me.Label22.Text = "DNI"
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.OKButton.BackgroundImage = Global.Muni.My.Resources.Resources.savex16
        Me.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OKButton.FlatAppearance.BorderSize = 0
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.ForeColor = System.Drawing.Color.White
        Me.OKButton.Location = New System.Drawing.Point(345, 10)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(45, 34)
        Me.OKButton.TabIndex = 97
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'ab_dni_share
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 52)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label22)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ab_dni_share"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda con DNI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents OKButton As Button
End Class
