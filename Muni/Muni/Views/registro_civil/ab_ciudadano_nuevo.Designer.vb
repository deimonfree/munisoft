<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ab_ciudadano_nuevo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtPueblo = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtCodUbiPue = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtDist = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtCodUbiDis = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtPro = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtCodUbiPro = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtDep = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtCodUbiDep = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_b2 = New System.Windows.Forms.RadioButton()
        Me.rb_b1 = New System.Windows.Forms.RadioButton()
        Me.txt_nacionalidad = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_a4 = New System.Windows.Forms.RadioButton()
        Me.rb_a3 = New System.Windows.Forms.RadioButton()
        Me.rb_a2 = New System.Windows.Forms.RadioButton()
        Me.rb_a1 = New System.Windows.Forms.RadioButton()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtApePat = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApeMat = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblMessage)
        Me.Panel1.Controls.Add(Me.OKButton)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 61)
        Me.Panel1.TabIndex = 68
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(287, 23)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(29, 16)
        Me.lblMessage.TabIndex = 62
        Me.lblMessage.Text = "Info"
        Me.lblMessage.Visible = False
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.OKButton.BackgroundImage = Global.Muni.My.Resources.Resources.savex16
        Me.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OKButton.FlatAppearance.BorderSize = 0
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.ForeColor = System.Drawing.Color.White
        Me.OKButton.Location = New System.Drawing.Point(20, 14)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(45, 34)
        Me.OKButton.TabIndex = 39
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCancelar.BackgroundImage = Global.Muni.My.Resources.Resources.cancelx16
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(142, 14)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(39, 34)
        Me.btnCancelar.TabIndex = 47
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnLimpiar.BackgroundImage = Global.Muni.My.Resources.Resources.deletex16
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(82, 14)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(43, 34)
        Me.btnLimpiar.TabIndex = 46
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(243, 536)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(136, 13)
        Me.Label29.TabIndex = 127
        Me.Label29.Text = "* Com. Nativa o Campesina"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(151, 513)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(84, 15)
        Me.Label30.TabIndex = 126
        Me.Label30.Text = "Cent. Poblado"
        '
        'txtPueblo
        '
        Me.txtPueblo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPueblo.Location = New System.Drawing.Point(246, 507)
        Me.txtPueblo.Name = "txtPueblo"
        Me.txtPueblo.Size = New System.Drawing.Size(325, 26)
        Me.txtPueblo.TabIndex = 125
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(27, 513)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 15)
        Me.Label31.TabIndex = 124
        Me.Label31.Text = "UBG."
        '
        'txtCodUbiPue
        '
        Me.txtCodUbiPue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUbiPue.Location = New System.Drawing.Point(69, 507)
        Me.txtCodUbiPue.Name = "txtCodUbiPue"
        Me.txtCodUbiPue.Size = New System.Drawing.Size(68, 26)
        Me.txtCodUbiPue.TabIndex = 123
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(151, 474)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 15)
        Me.Label32.TabIndex = 122
        Me.Label32.Text = "Distrito"
        '
        'txtDist
        '
        Me.txtDist.Enabled = False
        Me.txtDist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDist.Location = New System.Drawing.Point(246, 468)
        Me.txtDist.Name = "txtDist"
        Me.txtDist.Size = New System.Drawing.Size(325, 26)
        Me.txtDist.TabIndex = 121
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(27, 474)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(36, 15)
        Me.Label33.TabIndex = 120
        Me.Label33.Text = "UBG."
        '
        'txtCodUbiDis
        '
        Me.txtCodUbiDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUbiDis.Location = New System.Drawing.Point(69, 468)
        Me.txtCodUbiDis.Name = "txtCodUbiDis"
        Me.txtCodUbiDis.Size = New System.Drawing.Size(68, 26)
        Me.txtCodUbiDis.TabIndex = 119
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(151, 435)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(57, 15)
        Me.Label34.TabIndex = 118
        Me.Label34.Text = "Provincia"
        '
        'txtPro
        '
        Me.txtPro.Enabled = False
        Me.txtPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPro.Location = New System.Drawing.Point(246, 429)
        Me.txtPro.Name = "txtPro"
        Me.txtPro.Size = New System.Drawing.Size(325, 26)
        Me.txtPro.TabIndex = 117
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(27, 435)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(36, 15)
        Me.Label35.TabIndex = 116
        Me.Label35.Text = "UBG."
        '
        'txtCodUbiPro
        '
        Me.txtCodUbiPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUbiPro.Location = New System.Drawing.Point(69, 429)
        Me.txtCodUbiPro.Name = "txtCodUbiPro"
        Me.txtCodUbiPro.Size = New System.Drawing.Size(68, 26)
        Me.txtCodUbiPro.TabIndex = 115
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(151, 396)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(86, 15)
        Me.Label36.TabIndex = 114
        Me.Label36.Text = "Departamento"
        '
        'txtDep
        '
        Me.txtDep.Enabled = False
        Me.txtDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDep.Location = New System.Drawing.Point(246, 390)
        Me.txtDep.Name = "txtDep"
        Me.txtDep.Size = New System.Drawing.Size(325, 26)
        Me.txtDep.TabIndex = 113
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(27, 396)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(36, 15)
        Me.Label37.TabIndex = 112
        Me.Label37.Text = "UBG."
        '
        'txtCodUbiDep
        '
        Me.txtCodUbiDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodUbiDep.Location = New System.Drawing.Point(69, 390)
        Me.txtCodUbiDep.Name = "txtCodUbiDep"
        Me.txtCodUbiDep.Size = New System.Drawing.Size(68, 26)
        Me.txtCodUbiDep.TabIndex = 111
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(28, 360)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(151, 13)
        Me.Label28.TabIndex = 110
        Me.Label28.Text = "LUGAR DE NACIMIENTO"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(467, 185)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(180, 26)
        Me.txtEstado.TabIndex = 109
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(464, 219)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 15)
        Me.Label27.TabIndex = 108
        Me.Label27.Text = "Estado Civil"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(29, 219)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(31, 15)
        Me.Label26.TabIndex = 107
        Me.Label26.Text = "Tipo"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(328, 219)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 15)
        Me.Label25.TabIndex = 106
        Me.Label25.Text = "Nacionalidad"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb_b2)
        Me.GroupBox4.Controls.Add(Me.rb_b1)
        Me.GroupBox4.Location = New System.Drawing.Point(325, 237)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(122, 67)
        Me.GroupBox4.TabIndex = 105
        Me.GroupBox4.TabStop = False
        '
        'rb_b2
        '
        Me.rb_b2.AutoSize = True
        Me.rb_b2.Location = New System.Drawing.Point(6, 43)
        Me.rb_b2.Name = "rb_b2"
        Me.rb_b2.Size = New System.Drawing.Size(88, 17)
        Me.rb_b2.TabIndex = 1
        Me.rb_b2.TabStop = True
        Me.rb_b2.Text = "2: Extrangera"
        Me.rb_b2.UseVisualStyleBackColor = True
        '
        'rb_b1
        '
        Me.rb_b1.AutoSize = True
        Me.rb_b1.Location = New System.Drawing.Point(6, 20)
        Me.rb_b1.Name = "rb_b1"
        Me.rb_b1.Size = New System.Drawing.Size(77, 17)
        Me.rb_b1.TabIndex = 0
        Me.rb_b1.TabStop = True
        Me.rb_b1.Text = "1: Peruana"
        Me.rb_b1.UseVisualStyleBackColor = True
        '
        'txt_nacionalidad
        '
        Me.txt_nacionalidad.Enabled = False
        Me.txt_nacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nacionalidad.Location = New System.Drawing.Point(325, 185)
        Me.txt_nacionalidad.Name = "txt_nacionalidad"
        Me.txt_nacionalidad.Size = New System.Drawing.Size(31, 26)
        Me.txt_nacionalidad.TabIndex = 102
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(103, 185)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(180, 26)
        Me.txtNumero.TabIndex = 104
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(105, 219)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 15)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = "Numero"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_a4)
        Me.GroupBox3.Controls.Add(Me.rb_a3)
        Me.GroupBox3.Controls.Add(Me.rb_a2)
        Me.GroupBox3.Controls.Add(Me.rb_a1)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 237)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(122, 111)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        '
        'rb_a4
        '
        Me.rb_a4.AutoSize = True
        Me.rb_a4.Location = New System.Drawing.Point(6, 88)
        Me.rb_a4.Name = "rb_a4"
        Me.rb_a4.Size = New System.Drawing.Size(62, 17)
        Me.rb_a4.TabIndex = 3
        Me.rb_a4.TabStop = True
        Me.rb_a4.Text = "4: Otros"
        Me.rb_a4.UseVisualStyleBackColor = True
        '
        'rb_a3
        '
        Me.rb_a3.AutoSize = True
        Me.rb_a3.Location = New System.Drawing.Point(6, 66)
        Me.rb_a3.Name = "rb_a3"
        Me.rb_a3.Size = New System.Drawing.Size(51, 17)
        Me.rb_a3.TabIndex = 2
        Me.rb_a3.TabStop = True
        Me.rb_a3.Text = "3: CE"
        Me.rb_a3.UseVisualStyleBackColor = True
        '
        'rb_a2
        '
        Me.rb_a2.AutoSize = True
        Me.rb_a2.Location = New System.Drawing.Point(6, 43)
        Me.rb_a2.Name = "rb_a2"
        Me.rb_a2.Size = New System.Drawing.Size(72, 17)
        Me.rb_a2.TabIndex = 1
        Me.rb_a2.TabStop = True
        Me.rb_a2.Text = "2: LM/Bol"
        Me.rb_a2.UseVisualStyleBackColor = True
        '
        'rb_a1
        '
        Me.rb_a1.AutoSize = True
        Me.rb_a1.Location = New System.Drawing.Point(6, 20)
        Me.rb_a1.Name = "rb_a1"
        Me.rb_a1.Size = New System.Drawing.Size(56, 17)
        Me.rb_a1.TabIndex = 0
        Me.rb_a1.TabStop = True
        Me.rb_a1.Text = "1: DNI"
        Me.rb_a1.UseVisualStyleBackColor = True
        '
        'txt_tipo
        '
        Me.txt_tipo.Enabled = False
        Me.txt_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipo.Location = New System.Drawing.Point(29, 185)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(31, 26)
        Me.txt_tipo.TabIndex = 100
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(28, 160)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(149, 13)
        Me.Label18.TabIndex = 99
        Me.Label18.Text = "Documento de identidad:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(640, 122)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 15)
        Me.Label20.TabIndex = 97
        Me.Label20.Text = "Segundo apellido"
        '
        'txtApePat
        '
        Me.txtApePat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApePat.Location = New System.Drawing.Point(340, 93)
        Me.txtApePat.Name = "txtApePat"
        Me.txtApePat.Size = New System.Drawing.Size(283, 26)
        Me.txtApePat.TabIndex = 96
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(339, 122)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 15)
        Me.Label21.TabIndex = 95
        Me.Label21.Text = "Primer Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(29, 93)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(283, 26)
        Me.txtNombre.TabIndex = 94
        '
        'txtApeMat
        '
        Me.txtApeMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApeMat.Location = New System.Drawing.Point(641, 93)
        Me.txtApeMat.Name = "txtApeMat"
        Me.txtApeMat.Size = New System.Drawing.Size(283, 26)
        Me.txtApeMat.TabIndex = 98
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(28, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 15)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "Prenombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(691, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 15)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Fecha de nacimiento"
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Location = New System.Drawing.Point(683, 183)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(241, 26)
        Me.dtpNacimiento.TabIndex = 129
        '
        'ab_ciudadano_nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 589)
        Me.Controls.Add(Me.dtpNacimiento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtPueblo)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtCodUbiPue)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtDist)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.txtCodUbiDis)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtPro)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtCodUbiPro)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtDep)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.txtCodUbiDep)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txt_nacionalidad)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtApePat)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApeMat)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ab_ciudadano_nuevo"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nuevo Ciudadano"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMessage As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtPueblo As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtCodUbiPue As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtDist As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtCodUbiDis As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtPro As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtCodUbiPro As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtDep As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtCodUbiDep As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rb_b2 As RadioButton
    Friend WithEvents rb_b1 As RadioButton
    Friend WithEvents txt_nacionalidad As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rb_a4 As RadioButton
    Friend WithEvents rb_a3 As RadioButton
    Friend WithEvents rb_a2 As RadioButton
    Friend WithEvents rb_a1 As RadioButton
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtApePat As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApeMat As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpNacimiento As DateTimePicker
End Class
