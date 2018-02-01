<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class d_rentas_distrito_busqueda
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
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPalabraClave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnlistarall = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.lblSeleccion = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgwDistrito = New System.Windows.Forms.DataGridView()
        Me.pbload = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgwDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblinfo.Location = New System.Drawing.Point(95, 584)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(40, 20)
        Me.lblinfo.TabIndex = 54
        Me.lblinfo.Text = "Uds."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnlistarall)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 179)
        Me.Panel1.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(16, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 17)
        Me.Label6.TabIndex = 208
        Me.Label6.Text = "rellene el nombre de la ciudad  o liste todos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(14, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 24)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Busqueda de Ciudades ::"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(600, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Busque Avanzada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(600, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "Configuración"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Muni.My.Resources.Resources.pencil
        Me.PictureBox3.Location = New System.Drawing.Point(578, 139)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 204
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Muni.My.Resources.Resources.settings
        Me.PictureBox2.Location = New System.Drawing.Point(578, 113)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 203
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtPalabraClave)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(13, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 95)
        Me.Panel2.TabIndex = 201
        '
        'txtPalabraClave
        '
        Me.txtPalabraClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPalabraClave.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalabraClave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtPalabraClave.Location = New System.Drawing.Point(23, 14)
        Me.txtPalabraClave.Name = "txtPalabraClave"
        Me.txtPalabraClave.Size = New System.Drawing.Size(504, 26)
        Me.txtPalabraClave.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 17)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "01 resultados encontrados !"
        '
        'btnlistarall
        '
        Me.btnlistarall.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlistarall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlistarall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnlistarall.FlatAppearance.BorderSize = 0
        Me.btnlistarall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlistarall.Font = New System.Drawing.Font("Ubuntu Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlistarall.ForeColor = System.Drawing.Color.White
        Me.btnlistarall.Location = New System.Drawing.Point(578, 66)
        Me.btnlistarall.Name = "btnlistarall"
        Me.btnlistarall.Size = New System.Drawing.Size(191, 40)
        Me.btnlistarall.TabIndex = 107
        Me.btnlistarall.Text = "&Buscar Todos"
        Me.btnlistarall.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Ubuntu", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Image = Global.Muni.My.Resources.Resources.cross_close_or_delete_circular_interface_button_symbol
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnclose.Location = New System.Drawing.Point(684, 182)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(90, 50)
        Me.btnclose.TabIndex = 205
        Me.btnclose.Text = "Cerrar"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'OK_Button
        '
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Ubuntu", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.ForeColor = System.Drawing.Color.Black
        Me.OK_Button.Image = Global.Muni.My.Resources.Resources.check_mark
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.OK_Button.Location = New System.Drawing.Point(594, 182)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(90, 50)
        Me.OK_Button.TabIndex = 204
        Me.OK_Button.Text = "Seleccionar"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'lblSeleccion
        '
        Me.lblSeleccion.AutoSize = True
        Me.lblSeleccion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblSeleccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSeleccion.Location = New System.Drawing.Point(15, 183)
        Me.lblSeleccion.Name = "lblSeleccion"
        Me.lblSeleccion.Size = New System.Drawing.Size(287, 20)
        Me.lblSeleccion.TabIndex = 209
        Me.lblSeleccion.Text = "Jherson Campos Reyes :: Seleccionado"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.dgwDistrito)
        Me.GroupBox2.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 298)
        Me.GroupBox2.TabIndex = 207
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "..."
        '
        'dgwDistrito
        '
        Me.dgwDistrito.AllowUserToAddRows = False
        Me.dgwDistrito.AllowUserToDeleteRows = False
        Me.dgwDistrito.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dgwDistrito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwDistrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDistrito.Location = New System.Drawing.Point(6, 25)
        Me.dgwDistrito.Name = "dgwDistrito"
        Me.dgwDistrito.ReadOnly = True
        Me.dgwDistrito.Size = New System.Drawing.Size(751, 260)
        Me.dgwDistrito.TabIndex = 102
        '
        'pbload
        '
        Me.pbload.Image = Global.Muni.My.Resources.Resources.Bars
        Me.pbload.Location = New System.Drawing.Point(0, 537)
        Me.pbload.Name = "pbload"
        Me.pbload.Size = New System.Drawing.Size(77, 30)
        Me.pbload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbload.TabIndex = 208
        Me.pbload.TabStop = False
        Me.pbload.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(14, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 22)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Resultado de Contribuyentes ::"
        '
        'd_rentas_distrito_busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 570)
        Me.Controls.Add(Me.lblSeleccion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pbload)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblinfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "d_rentas_distrito_busqueda"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda de Ciudades ::"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgwDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinfo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPalabraClave As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnlistarall As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents lblSeleccion As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgwDistrito As DataGridView
    Friend WithEvents pbload As PictureBox
    Friend WithEvents Label7 As Label
End Class
