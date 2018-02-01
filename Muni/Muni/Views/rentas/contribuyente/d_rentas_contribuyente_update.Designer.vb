<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class d_rentas_contribuyente_update
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panel_info = New System.Windows.Forms.Panel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtPalabraClave = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbAP = New System.Windows.Forms.RadioButton()
        Me.rbRUC = New System.Windows.Forms.RadioButton()
        Me.rbRZ = New System.Windows.Forms.RadioButton()
        Me.rbN = New System.Windows.Forms.RadioButton()
        Me.rbDNI = New System.Windows.Forms.RadioButton()
        Me.rbCOD = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgwContribuyente = New System.Windows.Forms.DataGridView()
        Me.btnlistarall = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.pbInfo = New System.Windows.Forms.PictureBox()
        Me.panel_info.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgwContribuyente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.panel_info.TabIndex = 108
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(41, 7)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(333, 19)
        Me.lblInfo.TabIndex = 520
        Me.lblInfo.Text = "No se encongtraron resultados en la busqueda"
        '
        'txtPalabraClave
        '
        Me.txtPalabraClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPalabraClave.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalabraClave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtPalabraClave.Location = New System.Drawing.Point(25, 15)
        Me.txtPalabraClave.Name = "txtPalabraClave"
        Me.txtPalabraClave.Size = New System.Drawing.Size(519, 26)
        Me.txtPalabraClave.TabIndex = 515
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbAP)
        Me.GroupBox5.Controls.Add(Me.rbRUC)
        Me.GroupBox5.Controls.Add(Me.rbRZ)
        Me.GroupBox5.Controls.Add(Me.rbN)
        Me.GroupBox5.Controls.Add(Me.rbDNI)
        Me.GroupBox5.Controls.Add(Me.rbCOD)
        Me.GroupBox5.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(25, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox5.Size = New System.Drawing.Size(519, 44)
        Me.GroupBox5.TabIndex = 514
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo de Busqueda"
        '
        'rbAP
        '
        Me.rbAP.AutoSize = True
        Me.rbAP.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAP.Location = New System.Drawing.Point(75, 16)
        Me.rbAP.Name = "rbAP"
        Me.rbAP.Size = New System.Drawing.Size(133, 21)
        Me.rbAP.TabIndex = 414
        Me.rbAP.TabStop = True
        Me.rbAP.Text = "Apellido Paterno"
        Me.rbAP.UseVisualStyleBackColor = True
        '
        'rbRUC
        '
        Me.rbRUC.AutoSize = True
        Me.rbRUC.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRUC.Location = New System.Drawing.Point(449, 16)
        Me.rbRUC.Name = "rbRUC"
        Me.rbRUC.Size = New System.Drawing.Size(53, 21)
        Me.rbRUC.TabIndex = 413
        Me.rbRUC.TabStop = True
        Me.rbRUC.Text = "RUC"
        Me.rbRUC.UseVisualStyleBackColor = True
        '
        'rbRZ
        '
        Me.rbRZ.AutoSize = True
        Me.rbRZ.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRZ.Location = New System.Drawing.Point(343, 16)
        Me.rbRZ.Name = "rbRZ"
        Me.rbRZ.Size = New System.Drawing.Size(106, 21)
        Me.rbRZ.TabIndex = 412
        Me.rbRZ.TabStop = True
        Me.rbRZ.Text = "Razon Social"
        Me.rbRZ.UseVisualStyleBackColor = True
        '
        'rbN
        '
        Me.rbN.AutoSize = True
        Me.rbN.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbN.Location = New System.Drawing.Point(258, 16)
        Me.rbN.Name = "rbN"
        Me.rbN.Size = New System.Drawing.Size(85, 21)
        Me.rbN.TabIndex = 411
        Me.rbN.TabStop = True
        Me.rbN.Text = "Nombres"
        Me.rbN.UseVisualStyleBackColor = True
        '
        'rbDNI
        '
        Me.rbDNI.AutoSize = True
        Me.rbDNI.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDNI.Location = New System.Drawing.Point(208, 16)
        Me.rbDNI.Name = "rbDNI"
        Me.rbDNI.Size = New System.Drawing.Size(50, 21)
        Me.rbDNI.TabIndex = 410
        Me.rbDNI.TabStop = True
        Me.rbDNI.Text = "DNI"
        Me.rbDNI.UseVisualStyleBackColor = True
        '
        'rbCOD
        '
        Me.rbCOD.AutoSize = True
        Me.rbCOD.Checked = True
        Me.rbCOD.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCOD.Location = New System.Drawing.Point(5, 16)
        Me.rbCOD.Name = "rbCOD"
        Me.rbCOD.Size = New System.Drawing.Size(70, 21)
        Me.rbCOD.TabIndex = 409
        Me.rbCOD.TabStop = True
        Me.rbCOD.Text = "Codigo"
        Me.rbCOD.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel6.Controls.Add(Me.GroupBox5)
        Me.Panel6.Controls.Add(Me.btnclose)
        Me.Panel6.Controls.Add(Me.OK_Button)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 37)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(787, 53)
        Me.Panel6.TabIndex = 494
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnlistarall)
        Me.Panel3.Controls.Add(Me.txtPalabraClave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(787, 49)
        Me.Panel3.TabIndex = 495
        '
        'dgwContribuyente
        '
        Me.dgwContribuyente.AllowUserToAddRows = False
        Me.dgwContribuyente.AllowUserToDeleteRows = False
        Me.dgwContribuyente.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgwContribuyente.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwContribuyente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwContribuyente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwContribuyente.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgwContribuyente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwContribuyente.Location = New System.Drawing.Point(0, 139)
        Me.dgwContribuyente.Name = "dgwContribuyente"
        Me.dgwContribuyente.ReadOnly = True
        Me.dgwContribuyente.Size = New System.Drawing.Size(787, 445)
        Me.dgwContribuyente.TabIndex = 496
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
        Me.btnlistarall.Location = New System.Drawing.Point(583, 8)
        Me.btnlistarall.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnlistarall.Name = "btnlistarall"
        Me.btnlistarall.Size = New System.Drawing.Size(194, 33)
        Me.btnlistarall.TabIndex = 600
        Me.btnlistarall.Text = "Buscar Contribuyente"
        Me.btnlistarall.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlistarall.UseVisualStyleBackColor = False
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
        'd_rentas_contribuyente_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 584)
        Me.Controls.Add(Me.dgwContribuyente)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.panel_info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "d_rentas_contribuyente_update"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda de Contribuyentes ::"
        Me.panel_info.ResumeLayout(False)
        Me.panel_info.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgwContribuyente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_info As Panel
    Friend WithEvents btnclose As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbAP As RadioButton
    Friend WithEvents rbRUC As RadioButton
    Friend WithEvents rbRZ As RadioButton
    Friend WithEvents rbN As RadioButton
    Friend WithEvents rbDNI As RadioButton
    Friend WithEvents rbCOD As RadioButton
    Friend WithEvents txtPalabraClave As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgwContribuyente As DataGridView
    Friend WithEvents lblInfo As Label
    Friend WithEvents pbInfo As PictureBox
    Friend WithEvents btnlistarall As Button
End Class
