<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ab_rentas_via_new
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnclean = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.cbxCodigoVia = New System.Windows.Forms.ComboBox()
        Me.txtnom_Via = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnclean)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 81)
        Me.Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu Light", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(43, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Rellene los datos y validados para poder crear una nueva via"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(42, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 26)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Creción de una nueva via"
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Image = Global.Muni.My.Resources.Resources.exit_to_app_button
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnclose.Location = New System.Drawing.Point(624, 10)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(95, 58)
        Me.btnclose.TabIndex = 49
        Me.btnclose.Text = "Cerrar"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnclean
        '
        Me.btnclean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclean.FlatAppearance.BorderSize = 0
        Me.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclean.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnclean.ForeColor = System.Drawing.Color.White
        Me.btnclean.Image = Global.Muni.My.Resources.Resources.trash_bin_symbol
        Me.btnclean.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnclean.Location = New System.Drawing.Point(521, 10)
        Me.btnclean.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnclean.Name = "btnclean"
        Me.btnclean.Size = New System.Drawing.Size(97, 58)
        Me.btnclean.TabIndex = 48
        Me.btnclean.Text = "Limpiar"
        Me.btnclean.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclean.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = Global.Muni.My.Resources.Resources.saveicon
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsave.Location = New System.Drawing.Point(426, 10)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(89, 58)
        Me.btnsave.TabIndex = 47
        Me.btnsave.Text = "Guardar"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'cbxCodigoVia
        '
        Me.cbxCodigoVia.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxCodigoVia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxCodigoVia.FormattingEnabled = True
        Me.cbxCodigoVia.Location = New System.Drawing.Point(213, 112)
        Me.cbxCodigoVia.Name = "cbxCodigoVia"
        Me.cbxCodigoVia.Size = New System.Drawing.Size(93, 28)
        Me.cbxCodigoVia.TabIndex = 92
        '
        'txtnom_Via
        '
        Me.txtnom_Via.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnom_Via.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom_Via.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtnom_Via.Location = New System.Drawing.Point(213, 162)
        Me.txtnom_Via.Name = "txtnom_Via"
        Me.txtnom_Via.Size = New System.Drawing.Size(265, 26)
        Me.txtnom_Via.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Nombre de Via"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Tipo de Via"
        '
        'ab_rentas_via_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 281)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtnom_Via)
        Me.Controls.Add(Me.cbxCodigoVia)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ab_rentas_via_new"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "modulo para crear vias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents btnclean As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents cbxCodigoVia As ComboBox
    Friend WithEvents txtnom_Via As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
