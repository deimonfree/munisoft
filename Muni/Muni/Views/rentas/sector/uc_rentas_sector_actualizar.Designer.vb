<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_sector_actualizar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbCodZona = New System.Windows.Forms.PictureBox()
        Me.pbNom = New System.Windows.Forms.PictureBox()
        Me.pbId = New System.Windows.Forms.PictureBox()
        Me.cbxCodigoZona = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomSector = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodSector = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxbusqueda = New System.Windows.Forms.ComboBox()
        Me.txtPalabraClave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgwSector = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbCodZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwSector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(34, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 19)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Datos que seran actualizados:"
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
        Me.btnlistarall.Location = New System.Drawing.Point(564, 311)
        Me.btnlistarall.Name = "btnlistarall"
        Me.btnlistarall.Size = New System.Drawing.Size(269, 40)
        Me.btnlistarall.TabIndex = 101
        Me.btnlistarall.Text = "&Listar Todos los Sectores"
        Me.btnlistarall.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbCodZona)
        Me.Panel1.Controls.Add(Me.pbNom)
        Me.Panel1.Controls.Add(Me.pbId)
        Me.Panel1.Controls.Add(Me.cbxCodigoZona)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNomSector)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCodSector)
        Me.Panel1.Location = New System.Drawing.Point(33, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 82)
        Me.Panel1.TabIndex = 94
        '
        'pbCodZona
        '
        Me.pbCodZona.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbCodZona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCodZona.Location = New System.Drawing.Point(762, 13)
        Me.pbCodZona.Name = "pbCodZona"
        Me.pbCodZona.Size = New System.Drawing.Size(16, 16)
        Me.pbCodZona.TabIndex = 106
        Me.pbCodZona.TabStop = False
        Me.pbCodZona.Visible = False
        '
        'pbNom
        '
        Me.pbNom.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbNom.Location = New System.Drawing.Point(487, 13)
        Me.pbNom.Name = "pbNom"
        Me.pbNom.Size = New System.Drawing.Size(16, 16)
        Me.pbNom.TabIndex = 109
        Me.pbNom.TabStop = False
        Me.pbNom.Visible = False
        '
        'pbId
        '
        Me.pbId.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbId.Location = New System.Drawing.Point(193, 13)
        Me.pbId.Name = "pbId"
        Me.pbId.Size = New System.Drawing.Size(16, 16)
        Me.pbId.TabIndex = 108
        Me.pbId.TabStop = False
        Me.pbId.Visible = False
        '
        'cbxCodigoZona
        '
        Me.cbxCodigoZona.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxCodigoZona.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxCodigoZona.FormattingEnabled = True
        Me.cbxCodigoZona.Location = New System.Drawing.Point(531, 40)
        Me.cbxCodigoZona.Name = "cbxCodigoZona"
        Me.cbxCodigoZona.Size = New System.Drawing.Size(247, 28)
        Me.cbxCodigoZona.TabIndex = 92
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(527, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 20)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Zona a la que pertenece"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(252, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 20)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Nombre de Sector"
        '
        'txtNomSector
        '
        Me.txtNomSector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomSector.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomSector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtNomSector.Location = New System.Drawing.Point(256, 40)
        Me.txtNomSector.Name = "txtNomSector"
        Me.txtNomSector.Size = New System.Drawing.Size(247, 26)
        Me.txtNomSector.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 20)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Codigo de Sector"
        '
        'txtCodSector
        '
        Me.txtCodSector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSector.Enabled = False
        Me.txtCodSector.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodSector.Location = New System.Drawing.Point(13, 40)
        Me.txtCodSector.Name = "txtCodSector"
        Me.txtCodSector.Size = New System.Drawing.Size(196, 26)
        Me.txtCodSector.TabIndex = 104
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(560, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Busqueda por:"
        '
        'cbxbusqueda
        '
        Me.cbxbusqueda.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxbusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxbusqueda.FormattingEnabled = True
        Me.cbxbusqueda.Location = New System.Drawing.Point(564, 212)
        Me.cbxbusqueda.Name = "cbxbusqueda"
        Me.cbxbusqueda.Size = New System.Drawing.Size(269, 28)
        Me.cbxbusqueda.TabIndex = 91
        '
        'txtPalabraClave
        '
        Me.txtPalabraClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPalabraClave.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalabraClave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtPalabraClave.Location = New System.Drawing.Point(564, 269)
        Me.txtPalabraClave.Name = "txtPalabraClave"
        Me.txtPalabraClave.Size = New System.Drawing.Size(269, 26)
        Me.txtPalabraClave.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(567, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Palabra Clave"
        '
        'dgwSector
        '
        Me.dgwSector.AllowUserToAddRows = False
        Me.dgwSector.AllowUserToDeleteRows = False
        Me.dgwSector.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgwSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwSector.Location = New System.Drawing.Point(33, 193)
        Me.dgwSector.Name = "dgwSector"
        Me.dgwSector.ReadOnly = True
        Me.dgwSector.Size = New System.Drawing.Size(503, 104)
        Me.dgwSector.TabIndex = 88
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(33, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(650, 1)
        Me.Panel3.TabIndex = 87
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 100)
        Me.Panel2.TabIndex = 107
        '
        'btnActualizar
        '
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnActualizar.Image = Global.Muni.My.Resources.Resources.refresh
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnActualizar.Location = New System.Drawing.Point(599, 29)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(84, 53)
        Me.btnActualizar.TabIndex = 85
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 26)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Actualizar Sector"
        '
        'uc_rentas_sector_actualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnlistarall)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxbusqueda)
        Me.Controls.Add(Me.txtPalabraClave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgwSector)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uc_rentas_sector_actualizar"
        Me.Size = New System.Drawing.Size(867, 635)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbCodZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwSector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents btnlistarall As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxbusqueda As ComboBox
    Friend WithEvents txtPalabraClave As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgwSector As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxCodigoZona As ComboBox
    Friend WithEvents pbCodZona As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbNom As PictureBox
    Friend WithEvents pbId As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomSector As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodSector As TextBox
End Class
