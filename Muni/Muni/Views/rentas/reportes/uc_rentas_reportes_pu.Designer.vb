<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_reportes_pu
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
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxperiodo = New System.Windows.Forms.ComboBox()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.crvPu = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbFail = New System.Windows.Forms.PictureBox()
        Me.pbLoad = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblInfoReporte = New System.Windows.Forms.Label()
        Me.pbChek = New System.Windows.Forms.PictureBox()
        Me.pbnombre = New System.Windows.Forms.PictureBox()
        Me.btnShared = New System.Windows.Forms.Button()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbFail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbnombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Location = New System.Drawing.Point(24, 58)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(353, 19)
        Me.Label26.TabIndex = 492
        Me.Label26.Text = "Rellene los datos para que puede generar la ficha PU y PR"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(24, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(419, 26)
        Me.Label12.TabIndex = 490
        Me.Label12.Text = "Reporte  de Predio Urbano y Predio Rural ::"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label20.Location = New System.Drawing.Point(499, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 16)
        Me.Label20.TabIndex = 546
        Me.Label20.Text = "Seleccione el Periodo .:"
        '
        'cbxperiodo
        '
        Me.cbxperiodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbxperiodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxperiodo.FormattingEnabled = True
        Me.cbxperiodo.Location = New System.Drawing.Point(502, 68)
        Me.cbxperiodo.Name = "cbxperiodo"
        Me.cbxperiodo.Size = New System.Drawing.Size(134, 28)
        Me.cbxperiodo.TabIndex = 545
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.sidePanel.Location = New System.Drawing.Point(642, 53)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(186, 48)
        Me.sidePanel.TabIndex = 544
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(538, 164)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(291, 26)
        Me.txtDireccion.TabIndex = 570
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdentificacion.Enabled = False
        Me.txtIdentificacion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtIdentificacion.Location = New System.Drawing.Point(421, 164)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(110, 26)
        Me.txtIdentificacion.TabIndex = 569
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(115, 164)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(300, 26)
        Me.txtNombre.TabIndex = 568
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(30, 164)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(79, 26)
        Me.txtCodigo.TabIndex = 567
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(535, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 566
        Me.Label10.Text = "Dirección  ::"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(418, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 565
        Me.Label8.Text = "Doc. Iden.  ::"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(112, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 17)
        Me.Label7.TabIndex = 564
        Me.Label7.Text = "Nombres y Apellidos ::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 563
        Me.Label3.Text = "Codigo ::"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label49)
        Me.Panel7.Location = New System.Drawing.Point(29, 119)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(800, 22)
        Me.Panel7.TabIndex = 562
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Ubuntu", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(270, -1)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(245, 20)
        Me.Label49.TabIndex = 278
        Me.Label49.Text = "DATOS DE REPRESENTATE LEGAL"
        '
        'crvPu
        '
        Me.crvPu.ActiveViewIndex = -1
        Me.crvPu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvPu.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvPu.Location = New System.Drawing.Point(28, 294)
        Me.crvPu.Name = "crvPu"
        Me.crvPu.Size = New System.Drawing.Size(800, 519)
        Me.crvPu.TabIndex = 574
        Me.crvPu.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbFail)
        Me.Panel1.Controls.Add(Me.pbLoad)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.lblInfoReporte)
        Me.Panel1.Controls.Add(Me.pbChek)
        Me.Panel1.Location = New System.Drawing.Point(28, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 64)
        Me.Panel1.TabIndex = 575
        '
        'pbFail
        '
        Me.pbFail.Image = Global.Muni.My.Resources.Resources.file__fail
        Me.pbFail.Location = New System.Drawing.Point(6, 6)
        Me.pbFail.Name = "pbFail"
        Me.pbFail.Size = New System.Drawing.Size(50, 50)
        Me.pbFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFail.TabIndex = 576
        Me.pbFail.TabStop = False
        Me.pbFail.Visible = False
        '
        'pbLoad
        '
        Me.pbLoad.Image = Global.Muni.My.Resources.Resources.Double_Ring_1s_200px
        Me.pbLoad.Location = New System.Drawing.Point(0, 0)
        Me.pbLoad.Name = "pbLoad"
        Me.pbLoad.Size = New System.Drawing.Size(63, 63)
        Me.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoad.TabIndex = 574
        Me.pbLoad.TabStop = False
        Me.pbLoad.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Muni.My.Resources.Resources.google_news_greeb
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(453, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 53)
        Me.Button1.TabIndex = 572
        Me.Button1.Text = "Ficha PU"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Muni.My.Resources.Resources.google_news_greeb
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(627, 5)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 53)
        Me.Button2.TabIndex = 573
        Me.Button2.Text = "Ficha PR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblInfoReporte
        '
        Me.lblInfoReporte.AutoSize = True
        Me.lblInfoReporte.Font = New System.Drawing.Font("Ubuntu", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoReporte.Location = New System.Drawing.Point(69, 39)
        Me.lblInfoReporte.Name = "lblInfoReporte"
        Me.lblInfoReporte.Size = New System.Drawing.Size(0, 17)
        Me.lblInfoReporte.TabIndex = 278
        '
        'pbChek
        '
        Me.pbChek.Image = Global.Muni.My.Resources.Resources.file_chak
        Me.pbChek.Location = New System.Drawing.Point(6, 6)
        Me.pbChek.Name = "pbChek"
        Me.pbChek.Size = New System.Drawing.Size(50, 50)
        Me.pbChek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbChek.TabIndex = 575
        Me.pbChek.TabStop = False
        Me.pbChek.Visible = False
        '
        'pbnombre
        '
        Me.pbnombre.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbnombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbnombre.Location = New System.Drawing.Point(812, 145)
        Me.pbnombre.Name = "pbnombre"
        Me.pbnombre.Size = New System.Drawing.Size(16, 16)
        Me.pbnombre.TabIndex = 576
        Me.pbnombre.TabStop = False
        Me.pbnombre.Visible = False
        '
        'btnShared
        '
        Me.btnShared.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShared.FlatAppearance.BorderSize = 0
        Me.btnShared.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShared.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnShared.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnShared.Image = Global.Muni.My.Resources.Resources.magnifying_glass_with_two_way_arrows
        Me.btnShared.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShared.Location = New System.Drawing.Point(639, 53)
        Me.btnShared.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnShared.Name = "btnShared"
        Me.btnShared.Size = New System.Drawing.Size(189, 43)
        Me.btnShared.TabIndex = 543
        Me.btnShared.Text = "Buscar Contribuyente"
        Me.btnShared.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShared.UseVisualStyleBackColor = True
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.Muni.My.Resources.Resources.Bars
        Me.PictureBox23.Location = New System.Drawing.Point(24, 81)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(77, 30)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 491
        Me.PictureBox23.TabStop = False
        '
        'uc_rentas_reportes_pu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbnombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.crvPu)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cbxperiodo)
        Me.Controls.Add(Me.btnShared)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.Label12)
        Me.Name = "uc_rentas_reportes_pu"
        Me.Size = New System.Drawing.Size(870, 829)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbFail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbnombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cbxperiodo As ComboBox
    Friend WithEvents btnShared As Button
    Friend WithEvents sidePanel As Panel
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label49 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents crvPu As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblInfoReporte As Label
    Friend WithEvents pbLoad As PictureBox
    Friend WithEvents pbChek As PictureBox
    Friend WithEvents pbFail As PictureBox
    Friend WithEvents pbnombre As PictureBox
End Class
