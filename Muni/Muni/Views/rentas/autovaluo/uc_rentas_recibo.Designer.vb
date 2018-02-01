<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_recibo
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
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.txtAut = New System.Windows.Forms.TextBox()
        Me.txtAnnioAutovaluo = New System.Windows.Forms.TextBox()
        Me.txtValorAutovaluo = New System.Windows.Forms.TextBox()
        Me.txtCodAutovaluo = New System.Windows.Forms.TextBox()
        Me.txtTotalAutovaluo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFraccionar = New System.Windows.Forms.Button()
        Me.btnPrintFicha = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnShared = New System.Windows.Forms.Button()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxperiodo = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.dgwPredio = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpVenc = New System.Windows.Forms.DateTimePicker()
        Me.cbxPago = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAutomatizacion = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgwFraccionar = New System.Windows.Forms.DataGridView()
        Me.periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto_insoluto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.derecho_emsion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.automatizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMontoAnual = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgwPredio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgwFraccionar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Location = New System.Drawing.Point(18, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(439, 19)
        Me.Label26.TabIndex = 489
        Me.Label26.Text = "Rellene los datos para que puede generar el autovaluo Correspondiente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(17, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(268, 26)
        Me.Label12.TabIndex = 487
        Me.Label12.Text = "Generación de Autovaluo ::"
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.Muni.My.Resources.Resources.Bars
        Me.PictureBox23.Location = New System.Drawing.Point(11, 63)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(77, 30)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 488
        Me.PictureBox23.TabStop = False
        '
        'txtAut
        '
        Me.txtAut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAut.Enabled = False
        Me.txtAut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtAut.Location = New System.Drawing.Point(279, 84)
        Me.txtAut.Name = "txtAut"
        Me.txtAut.Size = New System.Drawing.Size(132, 26)
        Me.txtAut.TabIndex = 537
        '
        'txtAnnioAutovaluo
        '
        Me.txtAnnioAutovaluo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnnioAutovaluo.Enabled = False
        Me.txtAnnioAutovaluo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnnioAutovaluo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtAnnioAutovaluo.Location = New System.Drawing.Point(424, 84)
        Me.txtAnnioAutovaluo.Name = "txtAnnioAutovaluo"
        Me.txtAnnioAutovaluo.Size = New System.Drawing.Size(71, 26)
        Me.txtAnnioAutovaluo.TabIndex = 535
        '
        'txtValorAutovaluo
        '
        Me.txtValorAutovaluo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorAutovaluo.Enabled = False
        Me.txtValorAutovaluo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorAutovaluo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtValorAutovaluo.Location = New System.Drawing.Point(136, 84)
        Me.txtValorAutovaluo.Name = "txtValorAutovaluo"
        Me.txtValorAutovaluo.Size = New System.Drawing.Size(130, 26)
        Me.txtValorAutovaluo.TabIndex = 534
        '
        'txtCodAutovaluo
        '
        Me.txtCodAutovaluo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodAutovaluo.Enabled = False
        Me.txtCodAutovaluo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodAutovaluo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodAutovaluo.Location = New System.Drawing.Point(16, 84)
        Me.txtCodAutovaluo.Name = "txtCodAutovaluo"
        Me.txtCodAutovaluo.Size = New System.Drawing.Size(107, 26)
        Me.txtCodAutovaluo.TabIndex = 533
        '
        'txtTotalAutovaluo
        '
        Me.txtTotalAutovaluo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAutovaluo.Enabled = False
        Me.txtTotalAutovaluo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAutovaluo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtTotalAutovaluo.Location = New System.Drawing.Point(115, 19)
        Me.txtTotalAutovaluo.Name = "txtTotalAutovaluo"
        Me.txtTotalAutovaluo.Size = New System.Drawing.Size(134, 26)
        Me.txtTotalAutovaluo.TabIndex = 532
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnFraccionar)
        Me.Panel1.Controls.Add(Me.btnPrintFicha)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtTotalAutovaluo)
        Me.Panel1.Controls.Add(Me.txtCodAutovaluo)
        Me.Panel1.Controls.Add(Me.txtAnnioAutovaluo)
        Me.Panel1.Controls.Add(Me.txtAut)
        Me.Panel1.Controls.Add(Me.txtValorAutovaluo)
        Me.Panel1.Location = New System.Drawing.Point(22, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 120)
        Me.Panel1.TabIndex = 538
        '
        'btnFraccionar
        '
        Me.btnFraccionar.BackColor = System.Drawing.Color.Teal
        Me.btnFraccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFraccionar.Enabled = False
        Me.btnFraccionar.FlatAppearance.BorderSize = 0
        Me.btnFraccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFraccionar.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnFraccionar.ForeColor = System.Drawing.Color.White
        Me.btnFraccionar.Image = Global.Muni.My.Resources.Resources.printer
        Me.btnFraccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFraccionar.Location = New System.Drawing.Point(632, 63)
        Me.btnFraccionar.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnFraccionar.Name = "btnFraccionar"
        Me.btnFraccionar.Size = New System.Drawing.Size(155, 47)
        Me.btnFraccionar.TabIndex = 553
        Me.btnFraccionar.Text = "Fraccionar Monto"
        Me.btnFraccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFraccionar.UseVisualStyleBackColor = False
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
        Me.btnPrintFicha.Location = New System.Drawing.Point(632, 10)
        Me.btnPrintFicha.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnPrintFicha.Name = "btnPrintFicha"
        Me.btnPrintFicha.Size = New System.Drawing.Size(155, 47)
        Me.btnPrintFicha.TabIndex = 553
        Me.btnPrintFicha.Text = "Generar Recibo Anual"
        Me.btnPrintFicha.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintFicha.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(424, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 553
        Me.Label2.Text = "Periodo ::"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(279, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 19)
        Me.Label1.TabIndex = 552
        Me.Label1.Text = "Automatización ::"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(136, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 19)
        Me.Label6.TabIndex = 551
        Me.Label6.Text = "Valor de Autovaluo ::"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 34)
        Me.Label4.TabIndex = 549
        Me.Label4.Text = "Pago Total de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Autovaluo ::"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(16, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 550
        Me.Label5.Text = "Cod. Autovaluo ::"
        '
        'btnShared
        '
        Me.btnShared.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShared.FlatAppearance.BorderSize = 0
        Me.btnShared.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShared.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnShared.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnShared.Image = Global.Muni.My.Resources.Resources.printer
        Me.btnShared.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnShared.Location = New System.Drawing.Point(719, 40)
        Me.btnShared.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnShared.Name = "btnShared"
        Me.btnShared.Size = New System.Drawing.Size(90, 53)
        Me.btnShared.TabIndex = 539
        Me.btnShared.Text = "Buscar"
        Me.btnShared.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnShared.UseVisualStyleBackColor = True
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.sidePanel.Location = New System.Drawing.Point(719, 40)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(90, 58)
        Me.sidePanel.TabIndex = 540
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label20.Location = New System.Drawing.Point(576, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(121, 13)
        Me.Label20.TabIndex = 542
        Me.Label20.Text = "Busqueda por Periodo .:"
        '
        'cbxperiodo
        '
        Me.cbxperiodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbxperiodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxperiodo.FormattingEnabled = True
        Me.cbxperiodo.Location = New System.Drawing.Point(579, 69)
        Me.cbxperiodo.Name = "cbxperiodo"
        Me.cbxperiodo.Size = New System.Drawing.Size(134, 28)
        Me.cbxperiodo.TabIndex = 541
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label49)
        Me.Panel7.Location = New System.Drawing.Point(22, 242)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(800, 22)
        Me.Panel7.TabIndex = 553
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(528, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 557
        Me.Label10.Text = "Dirección  ::"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(411, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 556
        Me.Label8.Text = "Doc. Iden.  ::"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(105, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 17)
        Me.Label7.TabIndex = 555
        Me.Label7.Text = "Nombres y Apellidos ::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 554
        Me.Label3.Text = "Codigo ::"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(531, 287)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(291, 26)
        Me.txtDireccion.TabIndex = 561
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdentificacion.Enabled = False
        Me.txtIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtIdentificacion.Location = New System.Drawing.Point(414, 287)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(110, 26)
        Me.txtIdentificacion.TabIndex = 560
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(108, 287)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(300, 26)
        Me.txtNombre.TabIndex = 559
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(23, 287)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(79, 26)
        Me.txtCodigo.TabIndex = 558
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label36)
        Me.Panel6.Location = New System.Drawing.Point(22, 319)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(435, 22)
        Me.Panel6.TabIndex = 562
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Ubuntu", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(136, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(160, 20)
        Me.Label36.TabIndex = 278
        Me.Label36.Text = "LISTADO DE PREDIOS"
        '
        'dgwPredio
        '
        Me.dgwPredio.AllowUserToAddRows = False
        Me.dgwPredio.AllowUserToDeleteRows = False
        Me.dgwPredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwPredio.Location = New System.Drawing.Point(22, 347)
        Me.dgwPredio.Name = "dgwPredio"
        Me.dgwPredio.Size = New System.Drawing.Size(435, 185)
        Me.dgwPredio.TabIndex = 563
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpVenc)
        Me.GroupBox1.Controls.Add(Me.cbxPago)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtAutomatizacion)
        Me.GroupBox1.Location = New System.Drawing.Point(472, 319)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 213)
        Me.GroupBox1.TabIndex = 564
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Recibo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 16)
        Me.Label9.TabIndex = 523
        Me.Label9.Text = "Fecha de Vencimiento ::"
        '
        'dtpVenc
        '
        Me.dtpVenc.Location = New System.Drawing.Point(9, 47)
        Me.dtpVenc.Name = "dtpVenc"
        Me.dtpVenc.Size = New System.Drawing.Size(200, 20)
        Me.dtpVenc.TabIndex = 522
        '
        'cbxPago
        '
        Me.cbxPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxPago.FormattingEnabled = True
        Me.cbxPago.Items.AddRange(New Object() {"Contado", "Fraccionado"})
        Me.cbxPago.Location = New System.Drawing.Point(16, 174)
        Me.cbxPago.Name = "cbxPago"
        Me.cbxPago.Size = New System.Drawing.Size(121, 21)
        Me.cbxPago.TabIndex = 526
        Me.cbxPago.Text = "Contado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 16)
        Me.Label11.TabIndex = 528
        Me.Label11.Text = "Automatización  ::"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 16)
        Me.Label13.TabIndex = 525
        Me.Label13.Text = "Tipo de Pago  ::"
        '
        'txtAutomatizacion
        '
        Me.txtAutomatizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAutomatizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutomatizacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtAutomatizacion.Location = New System.Drawing.Point(13, 106)
        Me.txtAutomatizacion.Name = "txtAutomatizacion"
        Me.txtAutomatizacion.Size = New System.Drawing.Size(165, 26)
        Me.txtAutomatizacion.TabIndex = 527
        Me.txtAutomatizacion.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(22, 538)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 22)
        Me.Panel2.TabIndex = 565
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Ubuntu", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(270, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(268, 20)
        Me.Label14.TabIndex = 278
        Me.Label14.Text = "FRACCIONAMIENTO DE AUTOVALUO"
        '
        'dgwFraccionar
        '
        Me.dgwFraccionar.AllowUserToAddRows = False
        Me.dgwFraccionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwFraccionar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.periodo, Me.fecha_vencimiento, Me.monto_insoluto, Me.derecho_emsion, Me.automatizacion, Me.monto_total})
        Me.dgwFraccionar.Location = New System.Drawing.Point(22, 566)
        Me.dgwFraccionar.Name = "dgwFraccionar"
        Me.dgwFraccionar.Size = New System.Drawing.Size(800, 159)
        Me.dgwFraccionar.TabIndex = 566
        '
        'periodo
        '
        Me.periodo.HeaderText = "Periodo"
        Me.periodo.Name = "periodo"
        Me.periodo.ReadOnly = True
        '
        'fecha_vencimiento
        '
        Me.fecha_vencimiento.HeaderText = "Fecha de Vencimiento"
        Me.fecha_vencimiento.Name = "fecha_vencimiento"
        '
        'monto_insoluto
        '
        Me.monto_insoluto.HeaderText = "Monto Insoluto S/"
        Me.monto_insoluto.Name = "monto_insoluto"
        '
        'derecho_emsion
        '
        Me.derecho_emsion.HeaderText = "Derecho de Emisión S/"
        Me.derecho_emsion.Name = "derecho_emsion"
        '
        'automatizacion
        '
        Me.automatizacion.HeaderText = "Automatización"
        Me.automatizacion.Name = "automatizacion"
        '
        'monto_total
        '
        Me.monto_total.HeaderText = "Monto Total S/"
        Me.monto_total.Name = "monto_total"
        '
        'txtMontoAnual
        '
        Me.txtMontoAnual.Location = New System.Drawing.Point(718, 731)
        Me.txtMontoAnual.Name = "txtMontoAnual"
        Me.txtMontoAnual.Size = New System.Drawing.Size(104, 20)
        Me.txtMontoAnual.TabIndex = 567
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(611, 731)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 34)
        Me.Label15.TabIndex = 568
        Me.Label15.Text = "Monto Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anual  ::"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Muni.My.Resources.Resources.printer
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(339, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(279, 46)
        Me.Button1.TabIndex = 532
        Me.Button1.Text = "Liquidación de impuesto Predial"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uc_rentas_recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtMontoAnual)
        Me.Controls.Add(Me.dgwFraccionar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgwPredio)
        Me.Controls.Add(Me.Panel6)
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
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.Label12)
        Me.Name = "uc_rentas_recibo"
        Me.Size = New System.Drawing.Size(870, 851)
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgwPredio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgwFraccionar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAut As TextBox
    Friend WithEvents txtAnnioAutovaluo As TextBox
    Friend WithEvents txtValorAutovaluo As TextBox
    Friend WithEvents txtCodAutovaluo As TextBox
    Friend WithEvents txtTotalAutovaluo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnShared As Button
    Friend WithEvents sidePanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cbxperiodo As ComboBox
    Friend WithEvents btnFraccionar As Button
    Friend WithEvents btnPrintFicha As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label49 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents dgwPredio As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpVenc As DateTimePicker
    Friend WithEvents cbxPago As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAutomatizacion As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents dgwFraccionar As DataGridView
    Friend WithEvents periodo As DataGridViewTextBoxColumn
    Friend WithEvents fecha_vencimiento As DataGridViewTextBoxColumn
    Friend WithEvents monto_insoluto As DataGridViewTextBoxColumn
    Friend WithEvents derecho_emsion As DataGridViewTextBoxColumn
    Friend WithEvents automatizacion As DataGridViewTextBoxColumn
    Friend WithEvents monto_total As DataGridViewTextBoxColumn
    Friend WithEvents txtMontoAnual As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
End Class
