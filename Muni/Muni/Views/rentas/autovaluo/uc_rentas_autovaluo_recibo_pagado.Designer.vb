<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_autovaluo_recibo_pagado
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
        Me.btnShared = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxperiodo = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbHoy = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbTodos = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtCautovaluo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtForma = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtCobrar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCodRecibo = New System.Windows.Forms.TextBox()
        Me.txtFeVenc = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgwPredio = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgwPredio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnShared)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbxperiodo)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.PictureBox23)
        Me.Panel1.Location = New System.Drawing.Point(14, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 105)
        Me.Panel1.TabIndex = 491
        '
        'btnShared
        '
        Me.btnShared.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShared.FlatAppearance.BorderSize = 0
        Me.btnShared.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShared.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnShared.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnShared.Image = Global.Muni.My.Resources.Resources.magnifying_glass_with_two_way_arrows
        Me.btnShared.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShared.Location = New System.Drawing.Point(596, 57)
        Me.btnShared.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnShared.Name = "btnShared"
        Me.btnShared.Size = New System.Drawing.Size(209, 34)
        Me.btnShared.TabIndex = 483
        Me.btnShared.Text = "Buscar"
        Me.btnShared.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnShared.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label20.Location = New System.Drawing.Point(436, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 16)
        Me.Label20.TabIndex = 607
        Me.Label20.Text = "Seleccione el Periodo .:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 479
        Me.Label1.Text = "Recibos Pagados"
        '
        'cbxperiodo
        '
        Me.cbxperiodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbxperiodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxperiodo.FormattingEnabled = True
        Me.cbxperiodo.Location = New System.Drawing.Point(439, 64)
        Me.cbxperiodo.Name = "cbxperiodo"
        Me.cbxperiodo.Size = New System.Drawing.Size(134, 28)
        Me.cbxperiodo.TabIndex = 546
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Location = New System.Drawing.Point(24, 42)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(327, 16)
        Me.Label26.TabIndex = 485
        Me.Label26.Text = "Modulo en el que podra verificar los recibos pagados"
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.Muni.My.Resources.Resources.Bars
        Me.PictureBox23.Location = New System.Drawing.Point(27, 64)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(77, 30)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 484
        Me.PictureBox23.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.cbHoy)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.cbTodos)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(832, 56)
        Me.GroupBox2.TabIndex = 553
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda por .:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label23.Location = New System.Drawing.Point(13, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 13)
        Me.Label23.TabIndex = 547
        Me.Label23.Text = "Fecha de Pago .:"
        '
        'cbHoy
        '
        Me.cbHoy.AutoSize = True
        Me.cbHoy.Location = New System.Drawing.Point(364, 24)
        Me.cbHoy.Name = "cbHoy"
        Me.cbHoy.Size = New System.Drawing.Size(45, 17)
        Me.cbHoy.TabIndex = 549
        Me.cbHoy.Text = "Hoy"
        Me.cbHoy.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(134, 20)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(190, 20)
        Me.dtpFecha.TabIndex = 546
        '
        'cbTodos
        '
        Me.cbTodos.AutoSize = True
        Me.cbTodos.Location = New System.Drawing.Point(431, 24)
        Me.cbTodos.Name = "cbTodos"
        Me.cbTodos.Size = New System.Drawing.Size(56, 17)
        Me.cbTodos.TabIndex = 550
        Me.cbTodos.Text = "Todos"
        Me.cbTodos.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel5.Controls.Add(Me.txtEstado)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.txtCautovaluo)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.txtForma)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.txtCodRecibo)
        Me.Panel5.Controls.Add(Me.txtFeVenc)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(14, 197)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(830, 75)
        Me.Panel5.TabIndex = 554
        '
        'txtEstado
        '
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtEstado.Location = New System.Drawing.Point(263, 34)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(189, 26)
        Me.txtEstado.TabIndex = 548
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(267, 15)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 16)
        Me.Label24.TabIndex = 549
        Me.Label24.Text = "Pagado  ::"
        '
        'txtCautovaluo
        '
        Me.txtCautovaluo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCautovaluo.Enabled = False
        Me.txtCautovaluo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCautovaluo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCautovaluo.Location = New System.Drawing.Point(716, 37)
        Me.txtCautovaluo.Name = "txtCautovaluo"
        Me.txtCautovaluo.Size = New System.Drawing.Size(87, 26)
        Me.txtCautovaluo.TabIndex = 545
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label22.Location = New System.Drawing.Point(714, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 13)
        Me.Label22.TabIndex = 544
        Me.Label22.Text = "Cod. Autoval.:"
        '
        'txtForma
        '
        Me.txtForma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtForma.Enabled = False
        Me.txtForma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtForma.Location = New System.Drawing.Point(458, 35)
        Me.txtForma.Name = "txtForma"
        Me.txtForma.Size = New System.Drawing.Size(113, 26)
        Me.txtForma.TabIndex = 525
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(455, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 529
        Me.Label16.Text = "F.de Pago  ::"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightGray
        Me.Panel9.Controls.Add(Me.txtCobrar)
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Controls.Add(Me.Label21)
        Me.Panel9.Location = New System.Drawing.Point(12, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(145, 61)
        Me.Panel9.TabIndex = 543
        '
        'txtCobrar
        '
        Me.txtCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCobrar.Enabled = False
        Me.txtCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCobrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCobrar.Location = New System.Drawing.Point(25, 19)
        Me.txtCobrar.Name = "txtCobrar"
        Me.txtCobrar.Size = New System.Drawing.Size(102, 26)
        Me.txtCobrar.TabIndex = 341
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(22, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 16)
        Me.Label13.TabIndex = 344
        Me.Label13.Text = "Monto Pagado ::"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label21.Location = New System.Drawing.Point(-2, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 24)
        Me.Label21.TabIndex = 345
        Me.Label21.Text = "S/."
        '
        'txtCodRecibo
        '
        Me.txtCodRecibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodRecibo.Enabled = False
        Me.txtCodRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodRecibo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodRecibo.Location = New System.Drawing.Point(166, 34)
        Me.txtCodRecibo.Name = "txtCodRecibo"
        Me.txtCodRecibo.Size = New System.Drawing.Size(91, 26)
        Me.txtCodRecibo.TabIndex = 542
        '
        'txtFeVenc
        '
        Me.txtFeVenc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFeVenc.Enabled = False
        Me.txtFeVenc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeVenc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtFeVenc.Location = New System.Drawing.Point(582, 36)
        Me.txtFeVenc.Name = "txtFeVenc"
        Me.txtFeVenc.Size = New System.Drawing.Size(121, 26)
        Me.txtFeVenc.TabIndex = 536
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(579, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 16)
        Me.Label17.TabIndex = 537
        Me.Label17.Text = "F. Vencimiento  ::"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(163, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 16)
        Me.Label15.TabIndex = 528
        Me.Label15.Text = "Cod. Recibo"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.txtCodigo)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.txtIdentificacion)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtDireccion)
        Me.Panel3.Location = New System.Drawing.Point(14, 290)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(832, 106)
        Me.Panel3.TabIndex = 555
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel7.Controls.Add(Me.CheckBox2)
        Me.Panel7.Controls.Add(Me.Label49)
        Me.Panel7.Location = New System.Drawing.Point(12, 14)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(800, 22)
        Me.Panel7.TabIndex = 526
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(782, 5)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 405
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(270, -1)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(286, 18)
        Me.Label49.TabIndex = 278
        Me.Label49.Text = "DATOS DE REPRESENTATE LEGAL"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(12, 62)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(79, 26)
        Me.txtCodigo.TabIndex = 523
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(97, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(300, 26)
        Me.txtNombre.TabIndex = 524
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdentificacion.Enabled = False
        Me.txtIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtIdentificacion.Location = New System.Drawing.Point(403, 62)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(110, 26)
        Me.txtIdentificacion.TabIndex = 525
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 527
        Me.Label5.Text = "Codigo ::"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 16)
        Me.Label4.TabIndex = 528
        Me.Label4.Text = "Nombres y Apellidos ::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 529
        Me.Label3.Text = "Doc. Iden.  ::"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(517, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 530
        Me.Label2.Text = "Dirección  ::"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(520, 62)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(292, 26)
        Me.txtDireccion.TabIndex = 531
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgwPredio)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Location = New System.Drawing.Point(12, 411)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(832, 358)
        Me.Panel6.TabIndex = 556
        '
        'dgwPredio
        '
        Me.dgwPredio.AllowUserToAddRows = False
        Me.dgwPredio.AllowUserToDeleteRows = False
        Me.dgwPredio.AllowUserToResizeRows = False
        Me.dgwPredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwPredio.Location = New System.Drawing.Point(18, 43)
        Me.dgwPredio.MultiSelect = False
        Me.dgwPredio.Name = "dgwPredio"
        Me.dgwPredio.ReadOnly = True
        Me.dgwPredio.Size = New System.Drawing.Size(795, 296)
        Me.dgwPredio.TabIndex = 511
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label27)
        Me.Panel8.Location = New System.Drawing.Point(18, 15)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(794, 22)
        Me.Panel8.TabIndex = 510
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(251, 4)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(241, 18)
        Me.Label27.TabIndex = 278
        Me.Label27.Text = "LISTADO RECIBOS PAGADOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(99, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(207, 16)
        Me.Label9.TabIndex = 509
        Me.Label9.Text = "Busqueda de Contribuyente::"
        '
        'uc_rentas_autovaluo_recibo_pagado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_rentas_autovaluo_recibo_pagado"
        Me.Size = New System.Drawing.Size(859, 787)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgwPredio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnShared As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxperiodo As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cbHoy As CheckBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cbTodos As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtCautovaluo As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtForma As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtCobrar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtCodRecibo As TextBox
    Friend WithEvents txtFeVenc As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label49 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dgwPredio As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label9 As Label
End Class
