<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_campania_new
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbDescuento = New System.Windows.Forms.CheckBox()
        Me.cbInteres = New System.Windows.Forms.CheckBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxAnioLim = New System.Windows.Forms.ComboBox()
        Me.cbxAnioInf = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbDescuento = New System.Windows.Forms.GroupBox()
        Me.cbRangoAnnios = New System.Windows.Forms.RadioButton()
        Me.cbannioActual = New System.Windows.Forms.RadioButton()
        Me.cbTodosAnios = New System.Windows.Forms.RadioButton()
        Me.gbMora = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbRangoAnnios2 = New System.Windows.Forms.RadioButton()
        Me.cbannioActual2 = New System.Windows.Forms.RadioButton()
        Me.cbTodosAnios2 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxAnioLim2 = New System.Windows.Forms.ComboBox()
        Me.cbxAnioInf2 = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreCampania = New System.Windows.Forms.TextBox()
        Me.txtMora = New System.Windows.Forms.TextBox()
        Me.pnlCampania = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDescuento.SuspendLayout()
        Me.gbMora.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlCampania.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.PictureBox23)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 110)
        Me.Panel1.TabIndex = 0
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
        Me.btnSave.Location = New System.Drawing.Point(515, 28)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(69, 53)
        Me.btnSave.TabIndex = 555
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
        Me.btnUpdate.Location = New System.Drawing.Point(620, 28)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(149, 53)
        Me.btnUpdate.TabIndex = 554
        Me.btnUpdate.Text = "Actualizar Ultima Campaña"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Location = New System.Drawing.Point(17, 37)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(439, 19)
        Me.Label26.TabIndex = 489
        Me.Label26.Text = "Rellene los datos para que puede generar el autovaluo Correspondiente"
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.Muni.My.Resources.Resources.Bars
        Me.PictureBox23.Location = New System.Drawing.Point(21, 68)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(77, 30)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 488
        Me.PictureBox23.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(16, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(231, 26)
        Me.Label12.TabIndex = 487
        Me.Label12.Text = "Modulo de Campañas ::"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Location = New System.Drawing.Point(18, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 19)
        Me.Label15.TabIndex = 307
        Me.Label15.Text = "Fecha de Inicio ::"
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(22, 89)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(270, 20)
        Me.dtpInicio.TabIndex = 308
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(318, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 309
        Me.Label1.Text = "Fecha de Término ::"
        '
        'dtpFinal
        '
        Me.dtpFinal.Location = New System.Drawing.Point(322, 89)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(345, 20)
        Me.dtpFinal.TabIndex = 310
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(18, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 19)
        Me.Label2.TabIndex = 311
        Me.Label2.Text = "Opciones de Campaña  ::"
        '
        'cbDescuento
        '
        Me.cbDescuento.AutoSize = True
        Me.cbDescuento.Location = New System.Drawing.Point(22, 148)
        Me.cbDescuento.Name = "cbDescuento"
        Me.cbDescuento.Size = New System.Drawing.Size(78, 17)
        Me.cbDescuento.TabIndex = 312
        Me.cbDescuento.Text = "Descuento"
        Me.cbDescuento.UseVisualStyleBackColor = True
        '
        'cbInteres
        '
        Me.cbInteres.AutoSize = True
        Me.cbInteres.Location = New System.Drawing.Point(22, 172)
        Me.cbInteres.Name = "cbInteres"
        Me.cbInteres.Size = New System.Drawing.Size(114, 17)
        Me.cbInteres.TabIndex = 313
        Me.cbInteres.Text = "Interes Moratorio 0"
        Me.cbInteres.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(142, 148)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(142, 20)
        Me.txtDescuento.TabIndex = 314
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "De.:"
        '
        'cbxAnioLim
        '
        Me.cbxAnioLim.Enabled = False
        Me.cbxAnioLim.FormattingEnabled = True
        Me.cbxAnioLim.Location = New System.Drawing.Point(208, 103)
        Me.cbxAnioLim.Name = "cbxAnioLim"
        Me.cbxAnioLim.Size = New System.Drawing.Size(81, 21)
        Me.cbxAnioLim.TabIndex = 4
        '
        'cbxAnioInf
        '
        Me.cbxAnioInf.Enabled = False
        Me.cbxAnioInf.FormattingEnabled = True
        Me.cbxAnioInf.Location = New System.Drawing.Point(75, 103)
        Me.cbxAnioInf.Name = "cbxAnioInf"
        Me.cbxAnioInf.Size = New System.Drawing.Size(77, 21)
        Me.cbxAnioInf.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hasta .:"
        '
        'gbDescuento
        '
        Me.gbDescuento.Controls.Add(Me.cbRangoAnnios)
        Me.gbDescuento.Controls.Add(Me.cbannioActual)
        Me.gbDescuento.Controls.Add(Me.cbTodosAnios)
        Me.gbDescuento.Controls.Add(Me.Label4)
        Me.gbDescuento.Controls.Add(Me.Label3)
        Me.gbDescuento.Controls.Add(Me.cbxAnioLim)
        Me.gbDescuento.Controls.Add(Me.cbxAnioInf)
        Me.gbDescuento.Enabled = False
        Me.gbDescuento.Location = New System.Drawing.Point(36, 233)
        Me.gbDescuento.Name = "gbDescuento"
        Me.gbDescuento.Size = New System.Drawing.Size(322, 190)
        Me.gbDescuento.TabIndex = 316
        Me.gbDescuento.TabStop = False
        Me.gbDescuento.Text = "Opciones de Descuento"
        '
        'cbRangoAnnios
        '
        Me.cbRangoAnnios.AutoSize = True
        Me.cbRangoAnnios.Location = New System.Drawing.Point(17, 79)
        Me.cbRangoAnnios.Name = "cbRangoAnnios"
        Me.cbRangoAnnios.Size = New System.Drawing.Size(98, 17)
        Me.cbRangoAnnios.TabIndex = 363
        Me.cbRangoAnnios.TabStop = True
        Me.cbRangoAnnios.Text = "Rango de años"
        Me.cbRangoAnnios.UseVisualStyleBackColor = True
        '
        'cbannioActual
        '
        Me.cbannioActual.AutoSize = True
        Me.cbannioActual.Location = New System.Drawing.Point(17, 56)
        Me.cbannioActual.Name = "cbannioActual"
        Me.cbannioActual.Size = New System.Drawing.Size(76, 17)
        Me.cbannioActual.TabIndex = 362
        Me.cbannioActual.TabStop = True
        Me.cbannioActual.Text = "Año actual"
        Me.cbannioActual.UseVisualStyleBackColor = True
        '
        'cbTodosAnios
        '
        Me.cbTodosAnios.AutoSize = True
        Me.cbTodosAnios.Checked = True
        Me.cbTodosAnios.Location = New System.Drawing.Point(17, 33)
        Me.cbTodosAnios.Name = "cbTodosAnios"
        Me.cbTodosAnios.Size = New System.Drawing.Size(97, 17)
        Me.cbTodosAnios.TabIndex = 361
        Me.cbTodosAnios.TabStop = True
        Me.cbTodosAnios.Text = "Todos los años"
        Me.cbTodosAnios.UseVisualStyleBackColor = True
        '
        'gbMora
        '
        Me.gbMora.Controls.Add(Me.Panel3)
        Me.gbMora.Enabled = False
        Me.gbMora.Location = New System.Drawing.Point(378, 229)
        Me.gbMora.Name = "gbMora"
        Me.gbMora.Size = New System.Drawing.Size(322, 149)
        Me.gbMora.TabIndex = 317
        Me.gbMora.TabStop = False
        Me.gbMora.Text = "Opciones de Mora"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbRangoAnnios2)
        Me.Panel3.Controls.Add(Me.cbannioActual2)
        Me.Panel3.Controls.Add(Me.cbTodosAnios2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cbxAnioLim2)
        Me.Panel3.Controls.Add(Me.cbxAnioInf2)
        Me.Panel3.Location = New System.Drawing.Point(6, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 123)
        Me.Panel3.TabIndex = 315
        '
        'cbRangoAnnios2
        '
        Me.cbRangoAnnios2.AutoSize = True
        Me.cbRangoAnnios2.Location = New System.Drawing.Point(15, 60)
        Me.cbRangoAnnios2.Name = "cbRangoAnnios2"
        Me.cbRangoAnnios2.Size = New System.Drawing.Size(98, 17)
        Me.cbRangoAnnios2.TabIndex = 366
        Me.cbRangoAnnios2.TabStop = True
        Me.cbRangoAnnios2.Text = "Rango de años"
        Me.cbRangoAnnios2.UseVisualStyleBackColor = True
        '
        'cbannioActual2
        '
        Me.cbannioActual2.AutoSize = True
        Me.cbannioActual2.Location = New System.Drawing.Point(15, 37)
        Me.cbannioActual2.Name = "cbannioActual2"
        Me.cbannioActual2.Size = New System.Drawing.Size(76, 17)
        Me.cbannioActual2.TabIndex = 365
        Me.cbannioActual2.TabStop = True
        Me.cbannioActual2.Text = "Año actual"
        Me.cbannioActual2.UseVisualStyleBackColor = True
        '
        'cbTodosAnios2
        '
        Me.cbTodosAnios2.AutoSize = True
        Me.cbTodosAnios2.Checked = True
        Me.cbTodosAnios2.Location = New System.Drawing.Point(15, 14)
        Me.cbTodosAnios2.Name = "cbTodosAnios2"
        Me.cbTodosAnios2.Size = New System.Drawing.Size(97, 17)
        Me.cbTodosAnios2.TabIndex = 364
        Me.cbTodosAnios2.TabStop = True
        Me.cbTodosAnios2.Text = "Todos los años"
        Me.cbTodosAnios2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Hasta .:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "De.:"
        '
        'cbxAnioLim2
        '
        Me.cbxAnioLim2.Enabled = False
        Me.cbxAnioLim2.FormattingEnabled = True
        Me.cbxAnioLim2.Location = New System.Drawing.Point(206, 84)
        Me.cbxAnioLim2.Name = "cbxAnioLim2"
        Me.cbxAnioLim2.Size = New System.Drawing.Size(81, 21)
        Me.cbxAnioLim2.TabIndex = 4
        '
        'cbxAnioInf2
        '
        Me.cbxAnioInf2.Enabled = False
        Me.cbxAnioInf2.FormattingEnabled = True
        Me.cbxAnioInf2.Location = New System.Drawing.Point(73, 84)
        Me.cbxAnioInf2.Name = "cbxAnioInf2"
        Me.cbxAnioInf2.Size = New System.Drawing.Size(77, 21)
        Me.cbxAnioInf2.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Gray
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(485, 40)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(154, 38)
        Me.btnGuardar.TabIndex = 360
        Me.btnGuardar.Text = "&Sin actividad"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(17, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 19)
        Me.Label7.TabIndex = 361
        Me.Label7.Text = "Nombre de Campaña ::"
        '
        'txtNombreCampania
        '
        Me.txtNombreCampania.Location = New System.Drawing.Point(183, 19)
        Me.txtNombreCampania.Name = "txtNombreCampania"
        Me.txtNombreCampania.Size = New System.Drawing.Size(483, 20)
        Me.txtNombreCampania.TabIndex = 362
        '
        'txtMora
        '
        Me.txtMora.Enabled = False
        Me.txtMora.Location = New System.Drawing.Point(142, 169)
        Me.txtMora.Name = "txtMora"
        Me.txtMora.Size = New System.Drawing.Size(142, 20)
        Me.txtMora.TabIndex = 363
        '
        'pnlCampania
        '
        Me.pnlCampania.Controls.Add(Me.Label7)
        Me.pnlCampania.Controls.Add(Me.gbMora)
        Me.pnlCampania.Controls.Add(Me.txtMora)
        Me.pnlCampania.Controls.Add(Me.gbDescuento)
        Me.pnlCampania.Controls.Add(Me.txtNombreCampania)
        Me.pnlCampania.Controls.Add(Me.btnGuardar)
        Me.pnlCampania.Controls.Add(Me.Label15)
        Me.pnlCampania.Controls.Add(Me.txtDescuento)
        Me.pnlCampania.Controls.Add(Me.dtpInicio)
        Me.pnlCampania.Controls.Add(Me.cbInteres)
        Me.pnlCampania.Controls.Add(Me.Label1)
        Me.pnlCampania.Controls.Add(Me.cbDescuento)
        Me.pnlCampania.Controls.Add(Me.dtpFinal)
        Me.pnlCampania.Controls.Add(Me.Label2)
        Me.pnlCampania.Enabled = False
        Me.pnlCampania.Location = New System.Drawing.Point(12, 140)
        Me.pnlCampania.Name = "pnlCampania"
        Me.pnlCampania.Size = New System.Drawing.Size(769, 464)
        Me.pnlCampania.TabIndex = 365
        '
        'uc_rentas_campania_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlCampania)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_rentas_campania_new"
        Me.Size = New System.Drawing.Size(976, 518)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDescuento.ResumeLayout(False)
        Me.gbDescuento.PerformLayout()
        Me.gbMora.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlCampania.ResumeLayout(False)
        Me.pnlCampania.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFinal As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cbDescuento As CheckBox
    Friend WithEvents cbInteres As CheckBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxAnioLim As ComboBox
    Friend WithEvents cbxAnioInf As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gbDescuento As GroupBox
    Friend WithEvents gbMora As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxAnioLim2 As ComboBox
    Friend WithEvents cbxAnioInf2 As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cbannioActual As RadioButton
    Friend WithEvents cbTodosAnios As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombreCampania As TextBox
    Friend WithEvents txtMora As TextBox
    Friend WithEvents cbRangoAnnios As RadioButton
    Friend WithEvents cbRangoAnnios2 As RadioButton
    Friend WithEvents cbannioActual2 As RadioButton
    Friend WithEvents cbTodosAnios2 As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents pnlCampania As Panel
End Class
