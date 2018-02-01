<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_rentas_predio
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.panel_title = New System.Windows.Forms.Panel()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pbload = New System.Windows.Forms.PictureBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblcargo = New System.Windows.Forms.Label()
        Me.panel_title.SuspendLayout()
        CType(Me.pbload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_body
        '
        Me.panel_body.AutoScroll = True
        Me.panel_body.BackColor = System.Drawing.Color.White
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_body.Location = New System.Drawing.Point(0, 100)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(900, 392)
        Me.panel_body.TabIndex = 17
        '
        'panel_title
        '
        Me.panel_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.panel_title.Controls.Add(Me.sidePanel)
        Me.panel_title.Controls.Add(Me.pbload)
        Me.panel_title.Controls.Add(Me.lblname)
        Me.panel_title.Controls.Add(Me.lblcargo)
        Me.panel_title.Controls.Add(Me.Button2)
        Me.panel_title.Controls.Add(Me.Button1)
        Me.panel_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_title.Location = New System.Drawing.Point(0, 0)
        Me.panel_title.Name = "panel_title"
        Me.panel_title.Size = New System.Drawing.Size(900, 100)
        Me.panel_title.TabIndex = 16
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.sidePanel.Location = New System.Drawing.Point(-2, 63)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(128, 5)
        Me.sidePanel.TabIndex = 50
        Me.sidePanel.Visible = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(130, 70)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 30)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Registro de Construcciones"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(2, 70)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 30)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Registrar Predio"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pbload
        '
        Me.pbload.Image = Global.Muni.My.Resources.Resources.Ellipsis
        Me.pbload.Location = New System.Drawing.Point(187, 11)
        Me.pbload.Name = "pbload"
        Me.pbload.Size = New System.Drawing.Size(31, 32)
        Me.pbload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbload.TabIndex = 47
        Me.pbload.TabStop = False
        Me.pbload.Visible = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.White
        Me.lblname.Location = New System.Drawing.Point(14, 15)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(172, 25)
        Me.lblname.TabIndex = 46
        Me.lblname.Text = "Modulo de Predio"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcargo
        '
        Me.lblcargo.AutoSize = True
        Me.lblcargo.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcargo.ForeColor = System.Drawing.Color.White
        Me.lblcargo.Location = New System.Drawing.Point(14, 36)
        Me.lblcargo.Name = "lblcargo"
        Me.lblcargo.Size = New System.Drawing.Size(75, 18)
        Me.lblcargo.TabIndex = 45
        Me.lblcargo.Text = "trabajando"
        Me.lblcargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'uc_rentas_predio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_title)
        Me.Name = "uc_rentas_predio"
        Me.Size = New System.Drawing.Size(900, 492)
        Me.panel_title.ResumeLayout(False)
        Me.panel_title.PerformLayout()
        CType(Me.pbload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_body As Panel
    Friend WithEvents panel_title As Panel
    Friend WithEvents lblname As Label
    Friend WithEvents lblcargo As Label
    Friend WithEvents pbload As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents sidePanel As Panel
End Class
