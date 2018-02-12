<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mensaje
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
        Me.TextBoxCHAT = New System.Windows.Forms.TextBox()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pUser = New System.Windows.Forms.PictureBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCHAT
        '
        Me.TextBoxCHAT.BackColor = System.Drawing.Color.White
        Me.TextBoxCHAT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.TextBoxCHAT.Location = New System.Drawing.Point(11, 71)
        Me.TextBoxCHAT.Multiline = True
        Me.TextBoxCHAT.Name = "TextBoxCHAT"
        Me.TextBoxCHAT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxCHAT.Size = New System.Drawing.Size(310, 138)
        Me.TextBoxCHAT.TabIndex = 62
        '
        'btnMessage
        '
        Me.btnMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnMessage.FlatAppearance.BorderSize = 0
        Me.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMessage.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMessage.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMessage.Location = New System.Drawing.Point(221, 224)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(100, 35)
        Me.btnMessage.TabIndex = 61
        Me.btnMessage.Text = "Enviar"
        Me.btnMessage.UseVisualStyleBackColor = False
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(11, 224)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(204, 36)
        Me.txtMessage.TabIndex = 60
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pUser)
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Controls.Add(Me.lblEstado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 53)
        Me.Panel1.TabIndex = 59
        '
        'pUser
        '
        Me.pUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pUser.Image = Global.Muni.My.Resources.Resources.man
        Me.pUser.Location = New System.Drawing.Point(16, 9)
        Me.pUser.Name = "pUser"
        Me.pUser.Size = New System.Drawing.Size(35, 35)
        Me.pUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pUser.TabIndex = 48
        Me.pUser.TabStop = False
        '
        'lblname
        '
        Me.lblname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblname.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblname.Location = New System.Drawing.Point(57, 9)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(58, 17)
        Me.lblname.TabIndex = 50
        Me.lblname.Text = "A Todos"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEstado.Location = New System.Drawing.Point(57, 26)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(130, 18)
        Me.lblEstado.TabIndex = 49
        Me.lblEstado.Text = "Enviando Mensaje ..."
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Mensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBoxCHAT)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Mensaje"
        Me.Size = New System.Drawing.Size(340, 264)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCHAT As TextBox
    Friend WithEvents btnMessage As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pUser As PictureBox
    Friend WithEvents lblname As Label
    Friend WithEvents lblEstado As Label
End Class
