﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.dgwPredio = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxperiodo = New System.Windows.Forms.ComboBox()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbnombre = New System.Windows.Forms.PictureBox()
        Me.btnShared = New System.Windows.Forms.Button()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dgwPredio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbnombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbHoy)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.cbTodos)
        Me.GroupBox2.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(46, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 56)
        Me.GroupBox2.TabIndex = 553
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda por .:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 606
        Me.Label7.Text = "Fecha  ::"
        '
        'cbHoy
        '
        Me.cbHoy.AutoSize = True
        Me.cbHoy.Location = New System.Drawing.Point(668, 20)
        Me.cbHoy.Name = "cbHoy"
        Me.cbHoy.Size = New System.Drawing.Size(51, 21)
        Me.cbHoy.TabIndex = 549
        Me.cbHoy.Text = "Hoy"
        Me.cbHoy.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(87, 21)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(271, 22)
        Me.dtpFecha.TabIndex = 546
        '
        'cbTodos
        '
        Me.cbTodos.AutoSize = True
        Me.cbTodos.Location = New System.Drawing.Point(725, 20)
        Me.cbTodos.Name = "cbTodos"
        Me.cbTodos.Size = New System.Drawing.Size(63, 21)
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
        Me.Panel5.Location = New System.Drawing.Point(31, 197)
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
        'dgwPredio
        '
        Me.dgwPredio.AllowUserToAddRows = False
        Me.dgwPredio.AllowUserToDeleteRows = False
        Me.dgwPredio.AllowUserToResizeRows = False
        Me.dgwPredio.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgwPredio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwPredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwPredio.Location = New System.Drawing.Point(44, 409)
        Me.dgwPredio.MultiSelect = False
        Me.dgwPredio.Name = "dgwPredio"
        Me.dgwPredio.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwPredio.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwPredio.Size = New System.Drawing.Size(800, 296)
        Me.dgwPredio.TabIndex = 511
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label20.Location = New System.Drawing.Point(503, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 16)
        Me.Label20.TabIndex = 609
        Me.Label20.Text = "Seleccione el Periodo .:"
        '
        'cbxperiodo
        '
        Me.cbxperiodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbxperiodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxperiodo.FormattingEnabled = True
        Me.cbxperiodo.Location = New System.Drawing.Point(506, 61)
        Me.cbxperiodo.Name = "cbxperiodo"
        Me.cbxperiodo.Size = New System.Drawing.Size(134, 28)
        Me.cbxperiodo.TabIndex = 608
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.sidePanel.Location = New System.Drawing.Point(657, 46)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(186, 48)
        Me.sidePanel.TabIndex = 607
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Location = New System.Drawing.Point(39, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(392, 19)
        Me.Label26.TabIndex = 605
        Me.Label26.Text = "Rellene los datos para que puede generar la ficha de Liquidación"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(39, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(254, 26)
        Me.Label12.TabIndex = 603
        Me.Label12.Text = "Reporte  de Liquidación ::"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(553, 341)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(291, 26)
        Me.txtDireccion.TabIndex = 623
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdentificacion.Enabled = False
        Me.txtIdentificacion.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtIdentificacion.Location = New System.Drawing.Point(436, 341)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(110, 26)
        Me.txtIdentificacion.TabIndex = 622
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(130, 341)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(300, 26)
        Me.txtNombre.TabIndex = 621
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(45, 341)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(79, 26)
        Me.txtCodigo.TabIndex = 620
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(550, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 619
        Me.Label10.Text = "Dirección  ::"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(433, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 618
        Me.Label8.Text = "Doc. Iden.  ::"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 17)
        Me.Label1.TabIndex = 617
        Me.Label1.Text = "Nombres y Apellidos ::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 616
        Me.Label3.Text = "Codigo ::"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label49)
        Me.Panel7.Location = New System.Drawing.Point(44, 296)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(800, 22)
        Me.Panel7.TabIndex = 615
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(44, 380)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 22)
        Me.Panel1.TabIndex = 625
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(270, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 20)
        Me.Label2.TabIndex = 278
        Me.Label2.Text = "LISTA DE RECIBOS PAGADOS"
        '
        'pbnombre
        '
        Me.pbnombre.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbnombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbnombre.Location = New System.Drawing.Point(827, 322)
        Me.pbnombre.Name = "pbnombre"
        Me.pbnombre.Size = New System.Drawing.Size(16, 16)
        Me.pbnombre.TabIndex = 624
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
        Me.btnShared.Location = New System.Drawing.Point(654, 46)
        Me.btnShared.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnShared.Name = "btnShared"
        Me.btnShared.Size = New System.Drawing.Size(189, 43)
        Me.btnShared.TabIndex = 606
        Me.btnShared.Text = "Buscar Contribuyente"
        Me.btnShared.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShared.UseVisualStyleBackColor = True
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.Muni.My.Resources.Resources.Bars
        Me.PictureBox23.Location = New System.Drawing.Point(42, 70)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(77, 30)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 604
        Me.PictureBox23.TabStop = False
        '
        'uc_rentas_autovaluo_recibo_pagado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgwPredio)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbnombre)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cbxperiodo)
        Me.Controls.Add(Me.btnShared)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "uc_rentas_autovaluo_recibo_pagado"
        Me.Size = New System.Drawing.Size(900, 787)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.dgwPredio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbnombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents dgwPredio As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents cbxperiodo As ComboBox
    Friend WithEvents btnShared As Button
    Friend WithEvents sidePanel As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pbnombre As PictureBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label49 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
