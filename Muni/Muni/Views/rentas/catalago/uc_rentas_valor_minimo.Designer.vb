<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_valor_minimo
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
        Me.gb_dgw = New System.Windows.Forms.GroupBox()
        Me.dgwPredio = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbNombre = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblInfoReporte = New System.Windows.Forms.Label()
        Me.txtValorUit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxAnnio = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.gb_dgw.SuspendLayout()
        CType(Me.dgwPredio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_dgw
        '
        Me.gb_dgw.Controls.Add(Me.dgwPredio)
        Me.gb_dgw.Location = New System.Drawing.Point(28, 216)
        Me.gb_dgw.Name = "gb_dgw"
        Me.gb_dgw.Size = New System.Drawing.Size(800, 211)
        Me.gb_dgw.TabIndex = 641
        Me.gb_dgw.TabStop = False
        '
        'dgwPredio
        '
        Me.dgwPredio.AllowUserToAddRows = False
        Me.dgwPredio.AllowUserToDeleteRows = False
        Me.dgwPredio.AllowUserToResizeRows = False
        Me.dgwPredio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwPredio.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgwPredio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwPredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwPredio.Location = New System.Drawing.Point(6, 14)
        Me.dgwPredio.Name = "dgwPredio"
        Me.dgwPredio.ReadOnly = True
        Me.dgwPredio.Size = New System.Drawing.Size(787, 170)
        Me.dgwPredio.TabIndex = 634
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbNombre)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.lblInfoReporte)
        Me.Panel1.Controls.Add(Me.txtValorUit)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cbxAnnio)
        Me.Panel1.Location = New System.Drawing.Point(28, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 64)
        Me.Panel1.TabIndex = 640
        '
        'pbNombre
        '
        Me.pbNombre.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbNombre.Location = New System.Drawing.Point(122, 11)
        Me.pbNombre.Name = "pbNombre"
        Me.pbNombre.Size = New System.Drawing.Size(16, 16)
        Me.pbNombre.TabIndex = 633
        Me.pbNombre.TabStop = False
        Me.pbNombre.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.Muni.My.Resources.Resources.money_estadistica
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(627, 5)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(166, 53)
        Me.btnSave.TabIndex = 573
        Me.btnSave.Text = "Guardar Valor de UIT"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblInfoReporte
        '
        Me.lblInfoReporte.AutoSize = True
        Me.lblInfoReporte.Font = New System.Drawing.Font("Ubuntu", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoReporte.Location = New System.Drawing.Point(69, 39)
        Me.lblInfoReporte.Name = "lblInfoReporte"
        Me.lblInfoReporte.Size = New System.Drawing.Size(0, 17)
        Me.lblInfoReporte.TabIndex = 278
        '
        'txtValorUit
        '
        Me.txtValorUit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorUit.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtValorUit.Location = New System.Drawing.Point(16, 30)
        Me.txtValorUit.Name = "txtValorUit"
        Me.txtValorUit.Size = New System.Drawing.Size(122, 26)
        Me.txtValorUit.TabIndex = 628
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 624
        Me.Label7.Text = "Valor de UIT ::"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(159, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 625
        Me.Label8.Text = "Año  ::"
        '
        'cbxAnnio
        '
        Me.cbxAnnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbxAnnio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxAnnio.FormattingEnabled = True
        Me.cbxAnnio.Location = New System.Drawing.Point(162, 28)
        Me.cbxAnnio.Name = "cbxAnnio"
        Me.cbxAnnio.Size = New System.Drawing.Size(134, 28)
        Me.cbxAnnio.TabIndex = 620
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label49)
        Me.Panel7.Location = New System.Drawing.Point(28, 188)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(800, 22)
        Me.Panel7.TabIndex = 639
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Ubuntu", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(158, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(455, 20)
        Me.Label49.TabIndex = 278
        Me.Label49.Text = "VALORES MINIMOS DE BASE IMPONIBLE DE LOS ULTIMOS AÑOS"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Location = New System.Drawing.Point(24, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(392, 19)
        Me.Label26.TabIndex = 638
        Me.Label26.Text = "Rellene los datos para que puede generar la ficha de Liquidación"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(24, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(366, 26)
        Me.Label12.TabIndex = 636
        Me.Label12.Text = "Valores Minimos de Base Imponible ::"
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.Muni.My.Resources.Resources.Bars
        Me.PictureBox23.Location = New System.Drawing.Point(24, 66)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(77, 30)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 637
        Me.PictureBox23.TabStop = False
        '
        'uc_rentas_valor_minimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gb_dgw)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.Label12)
        Me.Name = "uc_rentas_valor_minimo"
        Me.Size = New System.Drawing.Size(862, 1216)
        Me.gb_dgw.ResumeLayout(False)
        CType(Me.dgwPredio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbNombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_dgw As GroupBox
    Friend WithEvents dgwPredio As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbNombre As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblInfoReporte As Label
    Friend WithEvents txtValorUit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxAnnio As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label49 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents Label12 As Label
End Class
