<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_sectores
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
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblsubInfo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblInfoDireccionPredio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomZonaFicha = New System.Windows.Forms.Label()
        Me.lblCodigoFicha = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblInfoFicha = New System.Windows.Forms.Label()
        Me.btnPrintFicha = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtnom_sector = New System.Windows.Forms.TextBox()
        Me.txtid_sector = New System.Windows.Forms.TextBox()
        Me.cbxCodigoZona = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbZona = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pbNombre = New System.Windows.Forms.PictureBox()
        Me.pbCod = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.sidePanel.Location = New System.Drawing.Point(480, 25)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(90, 58)
        Me.sidePanel.TabIndex = 564
        Me.sidePanel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 563
        Me.Label3.Text = "Nombre ::"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(18, 199)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 17)
        Me.Label28.TabIndex = 562
        Me.Label28.Text = "Codigo ::"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Location = New System.Drawing.Point(21, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 22)
        Me.Panel2.TabIndex = 561
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Ubuntu", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(343, 2)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(164, 20)
        Me.Label27.TabIndex = 278
        Me.Label27.Text = "DATOS DE LA SECTOR"
        '
        'lblsubInfo
        '
        Me.lblsubInfo.AutoSize = True
        Me.lblsubInfo.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblsubInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblsubInfo.Location = New System.Drawing.Point(17, 36)
        Me.lblsubInfo.Name = "lblsubInfo"
        Me.lblsubInfo.Size = New System.Drawing.Size(234, 19)
        Me.lblsubInfo.TabIndex = 560
        Me.lblsubInfo.Text = "Rellene los datos para crear un sector"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblInfoDireccionPredio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblNomZonaFicha)
        Me.Panel1.Controls.Add(Me.lblCodigoFicha)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblInfoFicha)
        Me.Panel1.Controls.Add(Me.btnPrintFicha)
        Me.Panel1.Location = New System.Drawing.Point(21, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 64)
        Me.Panel1.TabIndex = 559
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(489, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 19)
        Me.Label5.TabIndex = 548
        Me.Label5.Text = "fecha de creacion: 24/12/2017"
        '
        'lblInfoDireccionPredio
        '
        Me.lblInfoDireccionPredio.AutoSize = True
        Me.lblInfoDireccionPredio.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoDireccionPredio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblInfoDireccionPredio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInfoDireccionPredio.Location = New System.Drawing.Point(277, 22)
        Me.lblInfoDireccionPredio.Name = "lblInfoDireccionPredio"
        Me.lblInfoDireccionPredio.Size = New System.Drawing.Size(229, 20)
        Me.lblInfoDireccionPredio.TabIndex = 311
        Me.lblInfoDireccionPredio.Text = "Jr. Tarma // 104 // Carhuamayo"
        Me.lblInfoDireccionPredio.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(151, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 19)
        Me.Label1.TabIndex = 310
        Me.Label1.Text = "Direccion de Predio::"
        '
        'lblNomZonaFicha
        '
        Me.lblNomZonaFicha.AutoSize = True
        Me.lblNomZonaFicha.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomZonaFicha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblNomZonaFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNomZonaFicha.Location = New System.Drawing.Point(127, 42)
        Me.lblNomZonaFicha.Name = "lblNomZonaFicha"
        Me.lblNomZonaFicha.Size = New System.Drawing.Size(186, 20)
        Me.lblNomZonaFicha.TabIndex = 309
        Me.lblNomZonaFicha.Text = "Jherson CAMPOS REYES"
        Me.lblNomZonaFicha.Visible = False
        '
        'lblCodigoFicha
        '
        Me.lblCodigoFicha.AutoSize = True
        Me.lblCodigoFicha.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoFicha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblCodigoFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCodigoFicha.Location = New System.Drawing.Point(104, 22)
        Me.lblCodigoFicha.Name = "lblCodigoFicha"
        Me.lblCodigoFicha.Size = New System.Drawing.Size(45, 20)
        Me.lblCodigoFicha.TabIndex = 308
        Me.lblCodigoFicha.Text = "0001"
        Me.lblCodigoFicha.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(3, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 307
        Me.Label2.Text = "Nombre de Zona ::"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(3, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 306
        Me.Label4.Text = "Codigo de Via ::"
        '
        'lblInfoFicha
        '
        Me.lblInfoFicha.AutoSize = True
        Me.lblInfoFicha.Font = New System.Drawing.Font("Ubuntu", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoFicha.Location = New System.Drawing.Point(4, 5)
        Me.lblInfoFicha.Name = "lblInfoFicha"
        Me.lblInfoFicha.Size = New System.Drawing.Size(193, 17)
        Me.lblInfoFicha.TabIndex = 278
        Me.lblInfoFicha.Text = "Uds. esta registrando una zona"
        '
        'btnPrintFicha
        '
        Me.btnPrintFicha.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnPrintFicha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintFicha.Enabled = False
        Me.btnPrintFicha.FlatAppearance.BorderSize = 0
        Me.btnPrintFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintFicha.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnPrintFicha.ForeColor = System.Drawing.Color.White
        Me.btnPrintFicha.Image = Global.Muni.My.Resources.Resources.printer
        Me.btnPrintFicha.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrintFicha.Location = New System.Drawing.Point(686, 5)
        Me.btnPrintFicha.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnPrintFicha.Name = "btnPrintFicha"
        Me.btnPrintFicha.Size = New System.Drawing.Size(108, 53)
        Me.btnPrintFicha.TabIndex = 277
        Me.btnPrintFicha.Text = "Imprimir Ficha"
        Me.btnPrintFicha.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintFicha.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInfo.Location = New System.Drawing.Point(16, 10)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(204, 26)
        Me.lblInfo.TabIndex = 550
        Me.lblInfo.Text = "Agregando Sectores"
        '
        'txtnom_sector
        '
        Me.txtnom_sector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnom_sector.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom_sector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtnom_sector.Location = New System.Drawing.Point(152, 219)
        Me.txtnom_sector.Name = "txtnom_sector"
        Me.txtnom_sector.Size = New System.Drawing.Size(461, 26)
        Me.txtnom_sector.TabIndex = 566
        '
        'txtid_sector
        '
        Me.txtid_sector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid_sector.Enabled = False
        Me.txtid_sector.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_sector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtid_sector.Location = New System.Drawing.Point(21, 219)
        Me.txtid_sector.Name = "txtid_sector"
        Me.txtid_sector.Size = New System.Drawing.Size(121, 26)
        Me.txtid_sector.TabIndex = 565
        '
        'cbxCodigoZona
        '
        Me.cbxCodigoZona.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxCodigoZona.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxCodigoZona.FormattingEnabled = True
        Me.cbxCodigoZona.Location = New System.Drawing.Point(619, 217)
        Me.cbxCodigoZona.Name = "cbxCodigoZona"
        Me.cbxCodigoZona.Size = New System.Drawing.Size(202, 28)
        Me.cbxCodigoZona.TabIndex = 567
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(614, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 17)
        Me.Label7.TabIndex = 570
        Me.Label7.Text = "Codigo de Zona ::"
        '
        'pbZona
        '
        Me.pbZona.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbZona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbZona.Location = New System.Drawing.Point(805, 198)
        Me.pbZona.Name = "pbZona"
        Me.pbZona.Size = New System.Drawing.Size(16, 16)
        Me.pbZona.TabIndex = 574
        Me.pbZona.TabStop = False
        Me.pbZona.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button3.Image = Global.Muni.My.Resources.Resources.user_with_adding_sign
        Me.Button3.Location = New System.Drawing.Point(772, 258)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 31)
        Me.Button3.TabIndex = 572
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.Muni.My.Resources.Resources.Bars
        Me.PictureBox23.Location = New System.Drawing.Point(22, 59)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(77, 30)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 558
        Me.PictureBox23.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSearch.Image = Global.Muni.My.Resources.Resources.loupe2
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.Location = New System.Drawing.Point(480, 25)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 53)
        Me.btnSearch.TabIndex = 557
        Me.btnSearch.Text = "Buscar"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pbNombre
        '
        Me.pbNombre.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbNombre.Location = New System.Drawing.Point(597, 200)
        Me.pbNombre.Name = "pbNombre"
        Me.pbNombre.Size = New System.Drawing.Size(16, 16)
        Me.pbNombre.TabIndex = 556
        Me.pbNombre.TabStop = False
        Me.pbNombre.Visible = False
        '
        'pbCod
        '
        Me.pbCod.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbCod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCod.Location = New System.Drawing.Point(129, 199)
        Me.pbCod.Name = "pbCod"
        Me.pbCod.Size = New System.Drawing.Size(16, 16)
        Me.pbCod.TabIndex = 555
        Me.pbCod.TabStop = False
        Me.pbCod.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSave.Image = Global.Muni.My.Resources.Resources.new_file
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(574, 25)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(69, 53)
        Me.btnSave.TabIndex = 553
        Me.btnSave.Text = "Agregar"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnUpdate.Image = Global.Muni.My.Resources.Resources.refresh
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUpdate.Location = New System.Drawing.Point(647, 25)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(79, 53)
        Me.btnUpdate.TabIndex = 552
        Me.btnUpdate.Text = "Actualizar"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnDelete.Image = Global.Muni.My.Resources.Resources.rubbish
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(730, 25)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 53)
        Me.btnDelete.TabIndex = 551
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'uc_rentas_sectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbZona)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtnom_sector)
        Me.Controls.Add(Me.txtid_sector)
        Me.Controls.Add(Me.cbxCodigoZona)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblsubInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.pbNombre)
        Me.Controls.Add(Me.pbCod)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.sidePanel)
        Me.Name = "uc_rentas_sectores"
        Me.Size = New System.Drawing.Size(844, 385)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sidePanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents lblsubInfo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblInfoDireccionPredio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomZonaFicha As Label
    Friend WithEvents lblCodigoFicha As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblInfoFicha As Label
    Friend WithEvents btnPrintFicha As Button
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents pbNombre As PictureBox
    Friend WithEvents pbCod As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtnom_sector As TextBox
    Friend WithEvents txtid_sector As TextBox
    Friend WithEvents cbxCodigoZona As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents pbZona As PictureBox
End Class
