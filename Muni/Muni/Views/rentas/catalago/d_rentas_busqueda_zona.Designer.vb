<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class d_rentas_busqueda_zona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblsubInfo = New System.Windows.Forms.Label()
        Me.pbload = New System.Windows.Forms.PictureBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnclean = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnlistarall = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxbusqueda = New System.Windows.Forms.ComboBox()
        Me.txtPalabraClave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgwContribuyente = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.pbload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgwContribuyente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblsubInfo)
        Me.Panel1.Controls.Add(Me.pbload)
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnclean)
        Me.Panel1.Controls.Add(Me.OK_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 81)
        Me.Panel1.TabIndex = 113
        '
        'lblsubInfo
        '
        Me.lblsubInfo.AutoSize = True
        Me.lblsubInfo.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubInfo.ForeColor = System.Drawing.Color.White
        Me.lblsubInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblsubInfo.Location = New System.Drawing.Point(48, 49)
        Me.lblsubInfo.Name = "lblsubInfo"
        Me.lblsubInfo.Size = New System.Drawing.Size(193, 19)
        Me.lblsubInfo.TabIndex = 166
        Me.lblsubInfo.Text = "Presione el boton buscar zonas"
        '
        'pbload
        '
        Me.pbload.Image = Global.Muni.My.Resources.Resources.Bars
        Me.pbload.Location = New System.Drawing.Point(47, 48)
        Me.pbload.Name = "pbload"
        Me.pbload.Size = New System.Drawing.Size(77, 30)
        Me.pbload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbload.TabIndex = 200
        Me.pbload.TabStop = False
        Me.pbload.Visible = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInfo.Location = New System.Drawing.Point(42, 19)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(255, 26)
        Me.lblInfo.TabIndex = 53
        Me.lblInfo.Text = "Modulo de busca de Zona"
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
        'OK_Button
        '
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.OK_Button.ForeColor = System.Drawing.Color.White
        Me.OK_Button.Image = Global.Muni.My.Resources.Resources.saveicon
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.OK_Button.Location = New System.Drawing.Point(426, 10)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 58)
        Me.OK_Button.TabIndex = 47
        Me.OK_Button.Text = "Seleccionar"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Label2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnlistarall)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbxbusqueda)
        Me.GroupBox2.Controls.Add(Me.txtPalabraClave)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dgwContribuyente)
        Me.GroupBox2.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(47, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 260)
        Me.GroupBox2.TabIndex = 115
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda de zona:"
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
        Me.btnlistarall.Location = New System.Drawing.Point(475, 192)
        Me.btnlistarall.Name = "btnlistarall"
        Me.btnlistarall.Size = New System.Drawing.Size(161, 40)
        Me.btnlistarall.TabIndex = 107
        Me.btnlistarall.Text = "&Buscar"
        Me.btnlistarall.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Busqueda por:"
        '
        'cbxbusqueda
        '
        Me.cbxbusqueda.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxbusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxbusqueda.FormattingEnabled = True
        Me.cbxbusqueda.Location = New System.Drawing.Point(11, 199)
        Me.cbxbusqueda.Name = "cbxbusqueda"
        Me.cbxbusqueda.Size = New System.Drawing.Size(157, 28)
        Me.cbxbusqueda.TabIndex = 105
        '
        'txtPalabraClave
        '
        Me.txtPalabraClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPalabraClave.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalabraClave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtPalabraClave.Location = New System.Drawing.Point(184, 201)
        Me.txtPalabraClave.Name = "txtPalabraClave"
        Me.txtPalabraClave.Size = New System.Drawing.Size(269, 26)
        Me.txtPalabraClave.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Palabra Clave"
        '
        'dgwContribuyente
        '
        Me.dgwContribuyente.AllowUserToAddRows = False
        Me.dgwContribuyente.AllowUserToDeleteRows = False
        Me.dgwContribuyente.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgwContribuyente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwContribuyente.Location = New System.Drawing.Point(6, 25)
        Me.dgwContribuyente.Name = "dgwContribuyente"
        Me.dgwContribuyente.ReadOnly = True
        Me.dgwContribuyente.Size = New System.Drawing.Size(630, 137)
        Me.dgwContribuyente.TabIndex = 102
        '
        'd_rentas_busqueda_zona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 385)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "d_rentas_busqueda_zona"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "d_rentas_busqueda_zona"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgwContribuyente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblsubInfo As Label
    Friend WithEvents pbload As PictureBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents btnclean As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnlistarall As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxbusqueda As ComboBox
    Friend WithEvents txtPalabraClave As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgwContribuyente As DataGridView
End Class
