<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_rentas_arancel_rellenado
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCodVia = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalCua = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbMonto = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbarLlenado = New System.Windows.Forms.ProgressBar()
        Me.pbCuadra = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResCua = New System.Windows.Forms.TextBox()
        Me.cbxAnno = New System.Windows.Forms.ComboBox()
        Me.pbNom = New System.Windows.Forms.PictureBox()
        Me.pbanno = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomVia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgwSector = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxSector = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNomSector = New System.Windows.Forms.Label()
        Me.btnlistarall = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lnlNumVias = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblNumCuadras = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblNomVia = New System.Windows.Forms.Label()
        Me.lblInfoMess = New System.Windows.Forms.Label()
        Me.pbmessage = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pbSector = New System.Windows.Forms.PictureBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCuadra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbanno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwSector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.pbSector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(22, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(274, 19)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Modulo para rellenar Valores Arancelarios ::"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtCodVia)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtTotalCua)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.pbMonto)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtMonto)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.pbarLlenado)
        Me.Panel1.Controls.Add(Me.pbCuadra)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtResCua)
        Me.Panel1.Controls.Add(Me.cbxAnno)
        Me.Panel1.Controls.Add(Me.pbNom)
        Me.Panel1.Controls.Add(Me.pbanno)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNomVia)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(22, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 100)
        Me.Panel1.TabIndex = 113
        '
        'txtCodVia
        '
        Me.txtCodVia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodVia.Enabled = False
        Me.txtCodVia.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodVia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodVia.Location = New System.Drawing.Point(120, 33)
        Me.txtCodVia.Name = "txtCodVia"
        Me.txtCodVia.Size = New System.Drawing.Size(51, 26)
        Me.txtCodVia.TabIndex = 342
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Enabled = False
        Me.Label18.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Location = New System.Drawing.Point(406, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 20)
        Me.Label18.TabIndex = 341
        Me.Label18.Text = "De"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(436, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 280
        Me.Label12.Text = "Cuadra"
        '
        'txtTotalCua
        '
        Me.txtTotalCua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCua.Enabled = False
        Me.txtTotalCua.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtTotalCua.Location = New System.Drawing.Point(440, 33)
        Me.txtTotalCua.Name = "txtTotalCua"
        Me.txtTotalCua.Size = New System.Drawing.Size(36, 26)
        Me.txtTotalCua.TabIndex = 279
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Enabled = False
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNext.Image = Global.Muni.My.Resources.Resources.right_arrow
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNext.Location = New System.Drawing.Point(677, 19)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(113, 48)
        Me.btnNext.TabIndex = 278
        Me.btnNext.Text = "Siguiente"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(500, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 21)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "S/."
        '
        'pbMonto
        '
        Me.pbMonto.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbMonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMonto.Location = New System.Drawing.Point(631, 14)
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
        Me.Label9.Location = New System.Drawing.Point(531, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Monto"
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtMonto.Location = New System.Drawing.Point(535, 33)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(112, 26)
        Me.txtMonto.TabIndex = 118
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 20)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Progresion de llenado"
        '
        'pbarLlenado
        '
        Me.pbarLlenado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.pbarLlenado.Location = New System.Drawing.Point(187, 75)
        Me.pbarLlenado.Name = "pbarLlenado"
        Me.pbarLlenado.Size = New System.Drawing.Size(603, 17)
        Me.pbarLlenado.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbarLlenado.TabIndex = 116
        '
        'pbCuadra
        '
        Me.pbCuadra.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbCuadra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCuadra.Location = New System.Drawing.Point(492, 15)
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
        Me.Label2.Location = New System.Drawing.Point(363, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Cuadra"
        '
        'txtResCua
        '
        Me.txtResCua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResCua.Enabled = False
        Me.txtResCua.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResCua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtResCua.Location = New System.Drawing.Point(367, 33)
        Me.txtResCua.Name = "txtResCua"
        Me.txtResCua.Size = New System.Drawing.Size(36, 26)
        Me.txtResCua.TabIndex = 110
        '
        'cbxAnno
        '
        Me.cbxAnno.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxAnno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxAnno.FormattingEnabled = True
        Me.cbxAnno.Location = New System.Drawing.Point(17, 31)
        Me.cbxAnno.Name = "cbxAnno"
        Me.cbxAnno.Size = New System.Drawing.Size(88, 28)
        Me.cbxAnno.TabIndex = 111
        '
        'pbNom
        '
        Me.pbNom.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbNom.Location = New System.Drawing.Point(345, 14)
        Me.pbNom.Name = "pbNom"
        Me.pbNom.Size = New System.Drawing.Size(16, 16)
        Me.pbNom.TabIndex = 109
        Me.pbNom.TabStop = False
        Me.pbNom.Visible = False
        '
        'pbanno
        '
        Me.pbanno.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbanno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbanno.Location = New System.Drawing.Point(89, 14)
        Me.pbanno.Name = "pbanno"
        Me.pbanno.Size = New System.Drawing.Size(16, 16)
        Me.pbanno.TabIndex = 108
        Me.pbanno.TabStop = False
        Me.pbanno.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(117, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Nombre de Via"
        '
        'txtNomVia
        '
        Me.txtNomVia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomVia.Enabled = False
        Me.txtNomVia.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomVia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtNomVia.Location = New System.Drawing.Point(177, 33)
        Me.txtNomVia.Name = "txtNomVia"
        Me.txtNomVia.Size = New System.Drawing.Size(184, 26)
        Me.txtNomVia.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(13, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Año.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(20, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 17)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Listado de Vias ::"
        '
        'dgwSector
        '
        Me.dgwSector.AllowUserToAddRows = False
        Me.dgwSector.AllowUserToDeleteRows = False
        Me.dgwSector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwSector.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgwSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwSector.Location = New System.Drawing.Point(22, 263)
        Me.dgwSector.Name = "dgwSector"
        Me.dgwSector.ReadOnly = True
        Me.dgwSector.Size = New System.Drawing.Size(503, 146)
        Me.dgwSector.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(21, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 26)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Valores Arancelarios ::"
        '
        'cbxSector
        '
        Me.cbxSector.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxSector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxSector.FormattingEnabled = True
        Me.cbxSector.Location = New System.Drawing.Point(158, 453)
        Me.cbxSector.Name = "cbxSector"
        Me.cbxSector.Size = New System.Drawing.Size(372, 28)
        Me.cbxSector.TabIndex = 117
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(19, 453)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 17)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Seleccione Sector ::"
        '
        'lblNomSector
        '
        Me.lblNomSector.AutoSize = True
        Me.lblNomSector.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomSector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblNomSector.Location = New System.Drawing.Point(570, 284)
        Me.lblNomSector.Name = "lblNomSector"
        Me.lblNomSector.Size = New System.Drawing.Size(24, 21)
        Me.lblNomSector.TabIndex = 122
        Me.lblNomSector.Text = "--"
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
        Me.btnlistarall.Location = New System.Drawing.Point(531, 369)
        Me.btnlistarall.Name = "btnlistarall"
        Me.btnlistarall.Size = New System.Drawing.Size(288, 40)
        Me.btnlistarall.TabIndex = 124
        Me.btnlistarall.Text = "&Seleccionar Via para Llenar"
        Me.btnlistarall.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(570, 267)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 17)
        Me.Label13.TabIndex = 338
        Me.Label13.Text = "Nombre de Sector.:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Muni.My.Resources.Resources.cityscape
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(531, 264)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 339
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(738, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 341
        Me.Label3.Text = "Nº de Vias.:"
        '
        'lnlNumVias
        '
        Me.lnlNumVias.AutoSize = True
        Me.lnlNumVias.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlNumVias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lnlNumVias.Location = New System.Drawing.Point(738, 284)
        Me.lnlNumVias.Name = "lnlNumVias"
        Me.lnlNumVias.Size = New System.Drawing.Size(24, 21)
        Me.lnlNumVias.TabIndex = 340
        Me.lnlNumVias.Text = "--"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(738, 314)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 17)
        Me.Label16.TabIndex = 346
        Me.Label16.Text = "Nº de Cdrs.:"
        '
        'lblNumCuadras
        '
        Me.lblNumCuadras.AutoSize = True
        Me.lblNumCuadras.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCuadras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblNumCuadras.Location = New System.Drawing.Point(738, 331)
        Me.lblNumCuadras.Name = "lblNumCuadras"
        Me.lblNumCuadras.Size = New System.Drawing.Size(24, 21)
        Me.lblNumCuadras.TabIndex = 345
        Me.lblNumCuadras.Text = "--"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Muni.My.Resources.Resources.cityscape
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(531, 310)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 344
        Me.PictureBox4.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(570, 314)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 17)
        Me.Label19.TabIndex = 343
        Me.Label19.Text = "Nombre de Via.:"
        '
        'lblNomVia
        '
        Me.lblNomVia.AutoSize = True
        Me.lblNomVia.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomVia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lblNomVia.Location = New System.Drawing.Point(570, 331)
        Me.lblNomVia.Name = "lblNomVia"
        Me.lblNomVia.Size = New System.Drawing.Size(24, 21)
        Me.lblNomVia.TabIndex = 342
        Me.lblNomVia.Text = "--"
        '
        'lblInfoMess
        '
        Me.lblInfoMess.AutoSize = True
        Me.lblInfoMess.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoMess.Location = New System.Drawing.Point(45, 188)
        Me.lblInfoMess.Name = "lblInfoMess"
        Me.lblInfoMess.Size = New System.Drawing.Size(0, 17)
        Me.lblInfoMess.TabIndex = 382
        '
        'pbmessage
        '
        Me.pbmessage.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbmessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbmessage.Location = New System.Drawing.Point(23, 189)
        Me.pbmessage.Name = "pbmessage"
        Me.pbmessage.Size = New System.Drawing.Size(16, 16)
        Me.pbmessage.TabIndex = 381
        Me.pbmessage.TabStop = False
        Me.pbmessage.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Location = New System.Drawing.Point(22, 212)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(800, 22)
        Me.Panel4.TabIndex = 383
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Ubuntu", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(270, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(218, 20)
        Me.Label27.TabIndex = 278
        Me.Label27.Text = "LISTADO Y SELCCIÓN DE VIAS"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Location = New System.Drawing.Point(22, 425)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(800, 22)
        Me.Panel5.TabIndex = 384
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Ubuntu", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(270, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(173, 20)
        Me.Label14.TabIndex = 278
        Me.Label14.Text = "SELECCIÓN DE SECTOR"
        '
        'pbSector
        '
        Me.pbSector.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbSector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSector.Location = New System.Drawing.Point(537, 454)
        Me.pbSector.Name = "pbSector"
        Me.pbSector.Size = New System.Drawing.Size(16, 16)
        Me.pbSector.TabIndex = 385
        Me.pbSector.TabStop = False
        Me.pbSector.Visible = False
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.Muni.My.Resources.Resources.Bars
        Me.PictureBox23.Location = New System.Drawing.Point(15, 49)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(77, 30)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 386
        Me.PictureBox23.TabStop = False
        '
        'uc_rentas_arancel_rellenado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.pbSector)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblInfoMess)
        Me.Controls.Add(Me.pbmessage)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblNumCuadras)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblNomVia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lnlNumVias)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnlistarall)
        Me.Controls.Add(Me.lblNomSector)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbxSector)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgwSector)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uc_rentas_arancel_rellenado"
        Me.Size = New System.Drawing.Size(870, 503)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCuadra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbanno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwSector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.pbSector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbNom As PictureBox
    Friend WithEvents pbanno As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomVia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxAnno As ComboBox
    Friend WithEvents dgwSector As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pbMonto As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pbarLlenado As ProgressBar
    Friend WithEvents pbCuadra As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResCua As TextBox
    Friend WithEvents cbxSector As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNomSector As Label
    Friend WithEvents btnlistarall As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalCua As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lnlNumVias As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblNumCuadras As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lblNomVia As Label
    Friend WithEvents txtCodVia As TextBox
    Friend WithEvents lblInfoMess As Label
    Friend WithEvents pbmessage As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents pbSector As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
End Class
