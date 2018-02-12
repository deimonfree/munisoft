<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pUser = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 51)
        Me.Panel1.TabIndex = 61
        Me.Panel1.Visible = False
        '
        'lblname
        '
        Me.lblname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblname.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblname.Location = New System.Drawing.Point(71, 7)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(101, 17)
        Me.lblname.TabIndex = 59
        Me.lblname.Text = "User Munisoft"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEstado.Location = New System.Drawing.Point(71, 24)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(48, 18)
        Me.lblEstado.TabIndex = 58
        Me.lblEstado.Text = "Online"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Muni.My.Resources.Resources.chat
        Me.PictureBox2.Location = New System.Drawing.Point(227, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Muni.My.Resources.Resources.paper_plane
        Me.PictureBox1.Location = New System.Drawing.Point(271, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'pUser
        '
        Me.pUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pUser.Image = Global.Muni.My.Resources.Resources.man
        Me.pUser.Location = New System.Drawing.Point(30, 7)
        Me.pUser.Name = "pUser"
        Me.pUser.Size = New System.Drawing.Size(35, 35)
        Me.pUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pUser.TabIndex = 57
        Me.pUser.TabStop = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.pUser)
        Me.Name = "Usuarios"
        Me.Size = New System.Drawing.Size(304, 51)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblname As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents pUser As PictureBox
End Class
