﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_catalogo
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.panel_title = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblcargo = New System.Windows.Forms.Label()
        Me.pbload = New System.Windows.Forms.PictureBox()
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
        Me.panel_body.Size = New System.Drawing.Size(844, 500)
        Me.panel_body.TabIndex = 17
        '
        'panel_title
        '
        Me.panel_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.panel_title.Controls.Add(Me.sidePanel)
        Me.panel_title.Controls.Add(Me.Button2)
        Me.panel_title.Controls.Add(Me.Button1)
        Me.panel_title.Controls.Add(Me.lblname)
        Me.panel_title.Controls.Add(Me.lblcargo)
        Me.panel_title.Controls.Add(Me.pbload)
        Me.panel_title.Controls.Add(Me.Button3)
        Me.panel_title.Controls.Add(Me.Button4)
        Me.panel_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_title.Location = New System.Drawing.Point(0, 0)
        Me.panel_title.Name = "panel_title"
        Me.panel_title.Size = New System.Drawing.Size(844, 100)
        Me.panel_title.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(426, 70)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 30)
        Me.Button4.TabIndex = 58
        Me.Button4.Text = "&Grupo de Vias"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(284, 70)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 30)
        Me.Button3.TabIndex = 57
        Me.Button3.Text = "&Vias"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.sidePanel.Location = New System.Drawing.Point(0, 66)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(140, 5)
        Me.sidePanel.TabIndex = 56
        Me.sidePanel.Visible = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(142, 70)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 30)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "&Sectores"
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
        Me.Button1.Location = New System.Drawing.Point(0, 70)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 30)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "&Zonas"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.White
        Me.lblname.Location = New System.Drawing.Point(3, 4)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(204, 25)
        Me.lblname.TabIndex = 52
        Me.lblname.Text = "Modulo de Catalagos"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcargo
        '
        Me.lblcargo.AutoSize = True
        Me.lblcargo.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcargo.ForeColor = System.Drawing.Color.White
        Me.lblcargo.Location = New System.Drawing.Point(3, 25)
        Me.lblcargo.Name = "lblcargo"
        Me.lblcargo.Size = New System.Drawing.Size(329, 18)
        Me.lblcargo.TabIndex = 51
        Me.lblcargo.Text = "Uds. esta trabajando en la pestanañ de contribuyente"
        Me.lblcargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbload
        '
        Me.pbload.Image = Global.Muni.My.Resources.Resources.Ellipsis
        Me.pbload.Location = New System.Drawing.Point(8, 36)
        Me.pbload.Name = "pbload"
        Me.pbload.Size = New System.Drawing.Size(31, 32)
        Me.pbload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbload.TabIndex = 53
        Me.pbload.TabStop = False
        Me.pbload.Visible = False
        '
        'uc_rentas_catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_title)
        Me.Name = "uc_rentas_catalogo"
        Me.Size = New System.Drawing.Size(844, 600)
        Me.panel_title.ResumeLayout(False)
        Me.panel_title.PerformLayout()
        CType(Me.pbload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_body As Panel
    Friend WithEvents panel_title As Panel
    Friend WithEvents sidePanel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblname As Label
    Friend WithEvents lblcargo As Label
    Friend WithEvents pbload As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
