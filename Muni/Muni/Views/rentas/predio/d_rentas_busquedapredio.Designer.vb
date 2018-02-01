<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class d_rentas_busquedapredio
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgwSector = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.dgwZona = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnlistarall = New System.Windows.Forms.Button()
        Me.txtPalabraClave = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.panel_info = New System.Windows.Forms.Panel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.pbInfo = New System.Windows.Forms.PictureBox()
        Me.dgwGrupoCatastral = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgwSector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwZona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.panel_info.SuspendLayout()
        CType(Me.pbInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwGrupoCatastral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgwSector
        '
        Me.dgwSector.AllowUserToAddRows = False
        Me.dgwSector.AllowUserToDeleteRows = False
        Me.dgwSector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwSector.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgwSector.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwSector.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgwSector.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgwSector.Location = New System.Drawing.Point(0, 250)
        Me.dgwSector.Name = "dgwSector"
        Me.dgwSector.ReadOnly = True
        Me.dgwSector.Size = New System.Drawing.Size(787, 100)
        Me.dgwSector.TabIndex = 508
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 220)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(787, 30)
        Me.Panel3.TabIndex = 507
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Muni.My.Resources.Resources.businessman
        Me.PictureBox4.Location = New System.Drawing.Point(757, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 206
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 19)
        Me.Label3.TabIndex = 205
        Me.Label3.Text = "No se encongtraron resultados en la busqueda"
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.Muni.My.Resources.Resources.info_white
        Me.PictureBox5.Location = New System.Drawing.Point(14, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 204
        Me.PictureBox5.TabStop = False
        '
        'dgwZona
        '
        Me.dgwZona.AllowUserToAddRows = False
        Me.dgwZona.AllowUserToDeleteRows = False
        Me.dgwZona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwZona.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgwZona.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwZona.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgwZona.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgwZona.Location = New System.Drawing.Point(0, 120)
        Me.dgwZona.Name = "dgwZona"
        Me.dgwZona.ReadOnly = True
        Me.dgwZona.Size = New System.Drawing.Size(787, 100)
        Me.dgwZona.TabIndex = 506
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 30)
        Me.Panel2.TabIndex = 505
        '
        'btnlistarall
        '
        Me.btnlistarall.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnlistarall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlistarall.FlatAppearance.BorderSize = 0
        Me.btnlistarall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlistarall.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnlistarall.ForeColor = System.Drawing.Color.White
        Me.btnlistarall.Image = Global.Muni.My.Resources.Resources.luope_user
        Me.btnlistarall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlistarall.Location = New System.Drawing.Point(14, 0)
        Me.btnlistarall.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnlistarall.Name = "btnlistarall"
        Me.btnlistarall.Size = New System.Drawing.Size(147, 53)
        Me.btnlistarall.TabIndex = 600
        Me.btnlistarall.Text = "Buscar Zonas   "
        Me.btnlistarall.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlistarall.UseVisualStyleBackColor = False
        '
        'txtPalabraClave
        '
        Me.txtPalabraClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPalabraClave.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalabraClave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtPalabraClave.Location = New System.Drawing.Point(179, 12)
        Me.txtPalabraClave.Name = "txtPalabraClave"
        Me.txtPalabraClave.Size = New System.Drawing.Size(265, 26)
        Me.txtPalabraClave.TabIndex = 515
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtPalabraClave)
        Me.Panel4.Controls.Add(Me.btnlistarall)
        Me.Panel4.Controls.Add(Me.btnclose)
        Me.Panel4.Controls.Add(Me.OK_Button)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 37)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(787, 53)
        Me.Panel4.TabIndex = 504
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Ubuntu", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Image = Global.Muni.My.Resources.Resources.closed_naranja
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnclose.Location = New System.Drawing.Point(708, 0)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(79, 53)
        Me.btnclose.TabIndex = 49
        Me.btnclose.Text = "Cerrar"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'OK_Button
        '
        Me.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Ubuntu", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.OK_Button.ForeColor = System.Drawing.Color.White
        Me.OK_Button.Image = Global.Muni.My.Resources.Resources.check_mark
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.OK_Button.Location = New System.Drawing.Point(618, 0)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(90, 53)
        Me.OK_Button.TabIndex = 47
        Me.OK_Button.Text = "Seleccionar"
        Me.OK_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'panel_info
        '
        Me.panel_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.panel_info.Controls.Add(Me.lblInfo)
        Me.panel_info.Controls.Add(Me.pbInfo)
        Me.panel_info.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_info.Location = New System.Drawing.Point(0, 0)
        Me.panel_info.Name = "panel_info"
        Me.panel_info.Size = New System.Drawing.Size(787, 37)
        Me.panel_info.TabIndex = 503
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(41, 7)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(324, 19)
        Me.lblInfo.TabIndex = 520
        Me.lblInfo.Text = "No se encontraron resultados en la busqueda"
        '
        'pbInfo
        '
        Me.pbInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbInfo.Image = Global.Muni.My.Resources.Resources.info_white
        Me.pbInfo.Location = New System.Drawing.Point(12, 6)
        Me.pbInfo.Name = "pbInfo"
        Me.pbInfo.Size = New System.Drawing.Size(20, 20)
        Me.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbInfo.TabIndex = 519
        Me.pbInfo.TabStop = False
        '
        'dgwGrupoCatastral
        '
        Me.dgwGrupoCatastral.AllowUserToAddRows = False
        Me.dgwGrupoCatastral.AllowUserToDeleteRows = False
        Me.dgwGrupoCatastral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwGrupoCatastral.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgwGrupoCatastral.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwGrupoCatastral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwGrupoCatastral.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgwGrupoCatastral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwGrupoCatastral.Location = New System.Drawing.Point(0, 380)
        Me.dgwGrupoCatastral.Name = "dgwGrupoCatastral"
        Me.dgwGrupoCatastral.ReadOnly = True
        Me.dgwGrupoCatastral.Size = New System.Drawing.Size(787, 236)
        Me.dgwGrupoCatastral.TabIndex = 510
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 350)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 30)
        Me.Panel1.TabIndex = 509
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Muni.My.Resources.Resources.businessman
        Me.PictureBox1.Location = New System.Drawing.Point(757, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 206
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 19)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "No se encongtraron resultados en la busqueda"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Muni.My.Resources.Resources.info_white
        Me.PictureBox2.Location = New System.Drawing.Point(14, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 204
        Me.PictureBox2.TabStop = False
        '
        'd_rentas_busquedapredio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 616)
        Me.Controls.Add(Me.dgwGrupoCatastral)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgwSector)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgwZona)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panel_info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "d_rentas_busquedapredio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda de Zona Urbana ::"
        CType(Me.dgwSector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwZona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.panel_info.ResumeLayout(False)
        Me.panel_info.PerformLayout()
        CType(Me.pbInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwGrupoCatastral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgwSector As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents dgwZona As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnlistarall As Button
    Friend WithEvents txtPalabraClave As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnclose As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents panel_info As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents pbInfo As PictureBox
    Friend WithEvents dgwGrupoCatastral As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
