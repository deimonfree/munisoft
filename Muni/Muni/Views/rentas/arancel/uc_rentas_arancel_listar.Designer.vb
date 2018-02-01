<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_rentas_arancel_listar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnlistarall = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxSector = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodVia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCuadra = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbMonto = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.pbCuadra = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.pbNom = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomVia = New System.Windows.Forms.TextBox()
        Me.dgwValorArancelario = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbxVia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxAnno = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCuadra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwValorArancelario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.Muni.My.Resources.Resources.Bars
        Me.PictureBox23.Location = New System.Drawing.Point(32, 60)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(77, 30)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 410
        Me.PictureBox23.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Location = New System.Drawing.Point(39, 296)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(800, 22)
        Me.Panel4.TabIndex = 407
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Ubuntu", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(270, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(184, 20)
        Me.Label27.TabIndex = 278
        Me.Label27.Text = "LISTADO DE ARANCELES"
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
        Me.btnlistarall.Location = New System.Drawing.Point(625, 234)
        Me.btnlistarall.Name = "btnlistarall"
        Me.btnlistarall.Size = New System.Drawing.Size(214, 40)
        Me.btnlistarall.TabIndex = 395
        Me.btnlistarall.Text = "&Listar Arancel"
        Me.btnlistarall.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(40, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 17)
        Me.Label11.TabIndex = 393
        Me.Label11.Text = "Seleccione Sector ::"
        '
        'cbxSector
        '
        Me.cbxSector.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxSector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxSector.FormattingEnabled = True
        Me.cbxSector.Location = New System.Drawing.Point(40, 245)
        Me.cbxSector.Name = "cbxSector"
        Me.cbxSector.Size = New System.Drawing.Size(199, 28)
        Me.cbxSector.TabIndex = 392
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(39, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 19)
        Me.Label6.TabIndex = 391
        Me.Label6.Text = "Modulo para actualizar valores arancelarios ::"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtCodVia)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtCuadra)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.pbMonto)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtMonto)
        Me.Panel1.Controls.Add(Me.pbCuadra)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAnio)
        Me.Panel1.Controls.Add(Me.pbNom)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNomVia)
        Me.Panel1.Location = New System.Drawing.Point(39, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 86)
        Me.Panel1.TabIndex = 390
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(86, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 17)
        Me.Label15.TabIndex = 343
        Me.Label15.Text = "Via  ::"
        '
        'txtCodVia
        '
        Me.txtCodVia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodVia.Enabled = False
        Me.txtCodVia.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodVia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodVia.Location = New System.Drawing.Point(16, 33)
        Me.txtCodVia.Name = "txtCodVia"
        Me.txtCodVia.Size = New System.Drawing.Size(60, 26)
        Me.txtCodVia.TabIndex = 342
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(366, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 17)
        Me.Label12.TabIndex = 280
        Me.Label12.Text = "Cuadra ::"
        '
        'txtCuadra
        '
        Me.txtCuadra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuadra.Enabled = False
        Me.txtCuadra.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuadra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCuadra.Location = New System.Drawing.Point(370, 32)
        Me.txtCuadra.Name = "txtCuadra"
        Me.txtCuadra.Size = New System.Drawing.Size(59, 26)
        Me.txtCuadra.TabIndex = 279
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.Image = Global.Muni.My.Resources.Resources.right_arrow
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUpdate.Location = New System.Drawing.Point(677, 19)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(113, 48)
        Me.btnUpdate.TabIndex = 278
        Me.btnUpdate.Text = "Actualizar"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(433, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 21)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "S/."
        '
        'pbMonto
        '
        Me.pbMonto.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbMonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMonto.Location = New System.Drawing.Point(564, 14)
        Me.pbMonto.Name = "pbMonto"
        Me.pbMonto.Size = New System.Drawing.Size(16, 16)
        Me.pbMonto.TabIndex = 120
        Me.pbMonto.TabStop = False
        Me.pbMonto.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(464, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Monto ::"
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtMonto.Location = New System.Drawing.Point(468, 33)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(112, 26)
        Me.txtMonto.TabIndex = 118
        '
        'pbCuadra
        '
        Me.pbCuadra.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbCuadra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCuadra.Location = New System.Drawing.Point(435, 14)
        Me.pbCuadra.Name = "pbCuadra"
        Me.pbCuadra.Size = New System.Drawing.Size(16, 16)
        Me.pbCuadra.TabIndex = 112
        Me.pbCuadra.TabStop = False
        Me.pbCuadra.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(285, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Año ::"
        '
        'txtAnio
        '
        Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnio.Enabled = False
        Me.txtAnio.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtAnio.Location = New System.Drawing.Point(285, 32)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(69, 26)
        Me.txtAnio.TabIndex = 110
        '
        'pbNom
        '
        Me.pbNom.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbNom.Location = New System.Drawing.Point(254, 14)
        Me.pbNom.Name = "pbNom"
        Me.pbNom.Size = New System.Drawing.Size(16, 16)
        Me.pbNom.TabIndex = 109
        Me.pbNom.TabStop = False
        Me.pbNom.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(13, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Codigo ::"
        '
        'txtNomVia
        '
        Me.txtNomVia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomVia.Enabled = False
        Me.txtNomVia.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomVia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtNomVia.Location = New System.Drawing.Point(86, 32)
        Me.txtNomVia.Name = "txtNomVia"
        Me.txtNomVia.Size = New System.Drawing.Size(184, 26)
        Me.txtNomVia.TabIndex = 106
        '
        'dgwValorArancelario
        '
        Me.dgwValorArancelario.AllowUserToAddRows = False
        Me.dgwValorArancelario.AllowUserToDeleteRows = False
        Me.dgwValorArancelario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwValorArancelario.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgwValorArancelario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwValorArancelario.Location = New System.Drawing.Point(39, 324)
        Me.dgwValorArancelario.Name = "dgwValorArancelario"
        Me.dgwValorArancelario.ReadOnly = True
        Me.dgwValorArancelario.Size = New System.Drawing.Size(800, 146)
        Me.dgwValorArancelario.TabIndex = 388
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(38, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 26)
        Me.Label1.TabIndex = 387
        Me.Label1.Text = "Actualización de Valores Arancelarios ::"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(40, 193)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 22)
        Me.Panel2.TabIndex = 411
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(270, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 20)
        Me.Label8.TabIndex = 278
        Me.Label8.Text = "LISTADO Y SELCCIÓN DE VIAS"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(256, 225)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 17)
        Me.Label17.TabIndex = 413
        Me.Label17.Text = "Seleccione Via ::"
        '
        'cbxVia
        '
        Me.cbxVia.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxVia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxVia.FormattingEnabled = True
        Me.cbxVia.Location = New System.Drawing.Point(256, 245)
        Me.cbxVia.Name = "cbxVia"
        Me.cbxVia.Size = New System.Drawing.Size(257, 28)
        Me.cbxVia.TabIndex = 412
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(39, 473)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 19)
        Me.Label3.TabIndex = 414
        Me.Label3.Text = "* Seleccione el arancel que desea modificar"
        '
        'cbxAnno
        '
        Me.cbxAnno.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxAnno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxAnno.FormattingEnabled = True
        Me.cbxAnno.Location = New System.Drawing.Point(531, 245)
        Me.cbxAnno.Name = "cbxAnno"
        Me.cbxAnno.Size = New System.Drawing.Size(88, 28)
        Me.cbxAnno.TabIndex = 416
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(527, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 415
        Me.Label4.Text = "Año.:"
        '
        'uc_rentas_arancel_listar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbxAnno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cbxVia)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnlistarall)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbxSector)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgwValorArancelario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uc_rentas_arancel_listar"
        Me.Size = New System.Drawing.Size(870, 525)
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCuadra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwValorArancelario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents btnlistarall As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cbxSector As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCodVia As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCuadra As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents pbMonto As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents pbCuadra As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents pbNom As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomVia As TextBox
    Friend WithEvents dgwValorArancelario As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cbxVia As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxAnno As ComboBox
    Friend WithEvents Label4 As Label
End Class
