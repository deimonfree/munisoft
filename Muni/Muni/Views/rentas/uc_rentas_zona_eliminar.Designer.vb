﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_zona_eliminar
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnlistarall = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomZona = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodZona = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OK = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgwZona = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbNom = New System.Windows.Forms.PictureBox()
        Me.pbId = New System.Windows.Forms.PictureBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.dgwZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(24, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(377, 19)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Seleccione el listado de datos de las zonas que desea eliminar"
        '
        'btnlistarall
        '
        Me.btnlistarall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnlistarall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlistarall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnlistarall.FlatAppearance.BorderSize = 0
        Me.btnlistarall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlistarall.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlistarall.ForeColor = System.Drawing.Color.White
        Me.btnlistarall.Location = New System.Drawing.Point(713, 274)
        Me.btnlistarall.Name = "btnlistarall"
        Me.btnlistarall.Size = New System.Drawing.Size(110, 40)
        Me.btnlistarall.TabIndex = 101
        Me.btnlistarall.Text = "&Listar Todos"
        Me.btnlistarall.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(295, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 19)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Nombre de zona a eliminarse"
        '
        'txtNomZona
        '
        Me.txtNomZona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomZona.Enabled = False
        Me.txtNomZona.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomZona.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtNomZona.Location = New System.Drawing.Point(299, 426)
        Me.txtNomZona.Name = "txtNomZona"
        Me.txtNomZona.Size = New System.Drawing.Size(247, 26)
        Me.txtNomZona.TabIndex = 99
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(52, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 19)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Codigo zona a eliminarse"
        '
        'txtCodZona
        '
        Me.txtCodZona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodZona.Enabled = False
        Me.txtCodZona.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodZona.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodZona.Location = New System.Drawing.Point(56, 426)
        Me.txtCodZona.Name = "txtCodZona"
        Me.txtCodZona.Size = New System.Drawing.Size(196, 26)
        Me.txtCodZona.TabIndex = 97
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(576, 418)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(247, 40)
        Me.btnActualizar.TabIndex = 96
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(51, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 26)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Zona que se eliminara"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(23, 344)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 1)
        Me.Panel1.TabIndex = 94
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.OK.FlatAppearance.BorderSize = 0
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.White
        Me.OK.Location = New System.Drawing.Point(576, 274)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(113, 40)
        Me.OK.TabIndex = 93
        Me.OK.Text = "&Buscar"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(572, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Busqueda por:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(576, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(247, 28)
        Me.ComboBox1.TabIndex = 91
        '
        'txtRuc
        '
        Me.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRuc.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtRuc.Location = New System.Drawing.Point(576, 211)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(247, 26)
        Me.txtRuc.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(580, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Palabra Clave"
        '
        'dgwZona
        '
        Me.dgwZona.AllowUserToAddRows = False
        Me.dgwZona.AllowUserToDeleteRows = False
        Me.dgwZona.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgwZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwZona.Location = New System.Drawing.Point(36, 78)
        Me.dgwZona.Name = "dgwZona"
        Me.dgwZona.ReadOnly = True
        Me.dgwZona.Size = New System.Drawing.Size(527, 236)
        Me.dgwZona.TabIndex = 88
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(23, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 1)
        Me.Panel3.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 26)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Eliminar Zona"
        '
        'pbNom
        '
        Me.pbNom.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbNom.Location = New System.Drawing.Point(530, 399)
        Me.pbNom.Name = "pbNom"
        Me.pbNom.Size = New System.Drawing.Size(16, 16)
        Me.pbNom.TabIndex = 103
        Me.pbNom.TabStop = False
        Me.pbNom.Visible = False
        '
        'pbId
        '
        Me.pbId.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbId.Location = New System.Drawing.Point(236, 399)
        Me.pbId.Name = "pbId"
        Me.pbId.Size = New System.Drawing.Size(16, 16)
        Me.pbId.TabIndex = 102
        Me.pbId.TabStop = False
        Me.pbId.Visible = False
        '
        'Button9
        '
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button9.Image = Global.Muni.My.Resources.Resources.new_file
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(576, 10)
        Me.Button9.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(56, 53)
        Me.Button9.TabIndex = 86
        Me.Button9.Text = "New"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button8.Image = Global.Muni.My.Resources.Resources.refresh
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(632, 10)
        Me.Button8.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(65, 53)
        Me.Button8.TabIndex = 85
        Me.Button8.Text = "Refresh"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button3.Image = Global.Muni.My.Resources.Resources.cancel_button_small
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(753, 10)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 53)
        Me.Button3.TabIndex = 83
        Me.Button3.Text = "Close"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button4.Image = Global.Muni.My.Resources.Resources.printer
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(697, 10)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 53)
        Me.Button4.TabIndex = 84
        Me.Button4.Text = "Print"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'uc_rentas_zona_eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pbNom)
        Me.Controls.Add(Me.pbId)
        Me.Controls.Add(Me.btnlistarall)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNomZona)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodZona)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtRuc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgwZona)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Name = "uc_rentas_zona_eliminar"
        Me.Size = New System.Drawing.Size(846, 468)
        CType(Me.dgwZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents pbNom As PictureBox
    Friend WithEvents pbId As PictureBox
    Friend WithEvents btnlistarall As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomZona As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodZona As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OK As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgwZona As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
