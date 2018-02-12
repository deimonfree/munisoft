<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUp
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
        Me.components = New System.ComponentModel.Container()
        Me.panel_header = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelMessage = New System.Windows.Forms.Panel()
        Me.contMessage = New System.Windows.Forms.Label()
        Me.titlemessage = New System.Windows.Forms.Label()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbMessage = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_header.SuspendLayout()
        Me.panelFooter.SuspendLayout()
        Me.panelMessage.SuspendLayout()
        CType(Me.pbMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_header
        '
        Me.panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.panel_header.Controls.Add(Me.PictureBox3)
        Me.panel_header.Controls.Add(Me.lblUser)
        Me.panel_header.Controls.Add(Me.lblEstado)
        Me.panel_header.Controls.Add(Me.PictureBox1)
        Me.panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_header.Location = New System.Drawing.Point(0, 0)
        Me.panel_header.Name = "panel_header"
        Me.panel_header.Size = New System.Drawing.Size(325, 43)
        Me.panel_header.TabIndex = 2
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUser.Location = New System.Drawing.Point(43, 3)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(101, 17)
        Me.lblUser.TabIndex = 45
        Me.lblUser.Text = "User Munisoft"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEstado.Location = New System.Drawing.Point(43, 20)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(48, 18)
        Me.lblEstado.TabIndex = 44
        Me.lblEstado.Text = "Online"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelFooter
        '
        Me.panelFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.panelFooter.Controls.Add(Me.btnClose)
        Me.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFooter.Location = New System.Drawing.Point(0, 111)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(325, 43)
        Me.panelFooter.TabIndex = 53
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(218, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 35)
        Me.btnClose.TabIndex = 50
        Me.btnClose.Text = "Ver"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'panelMessage
        '
        Me.panelMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.panelMessage.Controls.Add(Me.pbMessage)
        Me.panelMessage.Controls.Add(Me.contMessage)
        Me.panelMessage.Controls.Add(Me.titlemessage)
        Me.panelMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMessage.Location = New System.Drawing.Point(0, 43)
        Me.panelMessage.Name = "panelMessage"
        Me.panelMessage.Size = New System.Drawing.Size(325, 65)
        Me.panelMessage.TabIndex = 54
        '
        'contMessage
        '
        Me.contMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contMessage.AutoSize = True
        Me.contMessage.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contMessage.ForeColor = System.Drawing.Color.White
        Me.contMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.contMessage.Location = New System.Drawing.Point(97, 33)
        Me.contMessage.Name = "contMessage"
        Me.contMessage.Size = New System.Drawing.Size(125, 16)
        Me.contMessage.TabIndex = 50
        Me.contMessage.Text = "Texto de la Notificación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.contMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'titlemessage
        '
        Me.titlemessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titlemessage.AutoSize = True
        Me.titlemessage.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlemessage.ForeColor = System.Drawing.Color.White
        Me.titlemessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.titlemessage.Location = New System.Drawing.Point(97, 10)
        Me.titlemessage.Name = "titlemessage"
        Me.titlemessage.Size = New System.Drawing.Size(182, 20)
        Me.titlemessage.TabIndex = 49
        Me.titlemessage.Text = "Titulo de La Notificación"
        Me.titlemessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 108)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(325, 3)
        Me.panelBody.TabIndex = 55
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'pbMessage
        '
        Me.pbMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMessage.Location = New System.Drawing.Point(46, 10)
        Me.pbMessage.Name = "pbMessage"
        Me.pbMessage.Size = New System.Drawing.Size(45, 45)
        Me.pbMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMessage.TabIndex = 51
        Me.pbMessage.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Muni.My.Resources.Resources.cancel_button_small
        Me.PictureBox3.Location = New System.Drawing.Point(303, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 46
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Muni.My.Resources.Resources.man
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'PopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 154)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.panelMessage)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.panel_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PopUp"
        Me.Text = "PopUp"
        Me.panel_header.ResumeLayout(False)
        Me.panel_header.PerformLayout()
        Me.panelFooter.ResumeLayout(False)
        Me.panelMessage.ResumeLayout(False)
        Me.panelMessage.PerformLayout()
        CType(Me.pbMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_header As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelFooter As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents panelMessage As Panel
    Friend WithEvents pbMessage As PictureBox
    Friend WithEvents contMessage As Label
    Friend WithEvents titlemessage As Label
    Friend WithEvents panelBody As Panel
    Friend WithEvents Timer1 As Timer
End Class
