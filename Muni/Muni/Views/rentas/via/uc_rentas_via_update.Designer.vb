<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_via_update
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxCodigoVia = New System.Windows.Forms.ComboBox()
        Me.btnlistarall = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomVia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodVia = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OK = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxbusqueda = New System.Windows.Forms.ComboBox()
        Me.txtPalabraClave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgwVia = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbCodZona = New System.Windows.Forms.PictureBox()
        Me.pbNom = New System.Windows.Forms.PictureBox()
        Me.pbId = New System.Windows.Forms.PictureBox()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        CType(Me.dgwVia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCodZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(34, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(345, 19)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Modulo donde uds podra actualizar los datos de las vias"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Tipo de Via"
        '
        'cbxCodigoVia
        '
        Me.cbxCodigoVia.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxCodigoVia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxCodigoVia.FormattingEnabled = True
        Me.cbxCodigoVia.Location = New System.Drawing.Point(308, 443)
        Me.cbxCodigoVia.Name = "cbxCodigoVia"
        Me.cbxCodigoVia.Size = New System.Drawing.Size(189, 28)
        Me.cbxCodigoVia.TabIndex = 117
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
        Me.btnlistarall.Location = New System.Drawing.Point(723, 292)
        Me.btnlistarall.Name = "btnlistarall"
        Me.btnlistarall.Size = New System.Drawing.Size(110, 40)
        Me.btnlistarall.TabIndex = 128
        Me.btnlistarall.Text = "&Listar Todos"
        Me.btnlistarall.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(528, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 20)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Nombre de Via"
        '
        'txtNomVia
        '
        Me.txtNomVia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomVia.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomVia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtNomVia.Location = New System.Drawing.Point(532, 441)
        Me.txtNomVia.Name = "txtNomVia"
        Me.txtNomVia.Size = New System.Drawing.Size(301, 26)
        Me.txtNomVia.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Codigo de Via"
        '
        'txtCodVia
        '
        Me.txtCodVia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodVia.Enabled = False
        Me.txtCodVia.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodVia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCodVia.Location = New System.Drawing.Point(66, 444)
        Me.txtCodVia.Name = "txtCodVia"
        Me.txtCodVia.Size = New System.Drawing.Size(196, 26)
        Me.txtCodVia.TabIndex = 124
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(585, 501)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(247, 40)
        Me.btnActualizar.TabIndex = 123
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(61, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 26)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Actualizar Zona"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(33, 362)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 1)
        Me.Panel1.TabIndex = 121
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.OK.FlatAppearance.BorderSize = 0
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.White
        Me.OK.Location = New System.Drawing.Point(586, 292)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(113, 40)
        Me.OK.TabIndex = 120
        Me.OK.Text = "&Entrar"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(582, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Busqueda por:"
        '
        'cbxbusqueda
        '
        Me.cbxbusqueda.Font = New System.Drawing.Font("Ubuntu", 12.0!)
        Me.cbxbusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxbusqueda.FormattingEnabled = True
        Me.cbxbusqueda.Location = New System.Drawing.Point(586, 134)
        Me.cbxbusqueda.Name = "cbxbusqueda"
        Me.cbxbusqueda.Size = New System.Drawing.Size(247, 28)
        Me.cbxbusqueda.TabIndex = 116
        '
        'txtPalabraClave
        '
        Me.txtPalabraClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPalabraClave.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPalabraClave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtPalabraClave.Location = New System.Drawing.Point(586, 229)
        Me.txtPalabraClave.Name = "txtPalabraClave"
        Me.txtPalabraClave.Size = New System.Drawing.Size(247, 26)
        Me.txtPalabraClave.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(590, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Palabra Clave"
        '
        'dgwVia
        '
        Me.dgwVia.AllowUserToAddRows = False
        Me.dgwVia.AllowUserToDeleteRows = False
        Me.dgwVia.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgwVia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwVia.Location = New System.Drawing.Point(46, 96)
        Me.dgwVia.Name = "dgwVia"
        Me.dgwVia.ReadOnly = True
        Me.dgwVia.Size = New System.Drawing.Size(527, 236)
        Me.dgwVia.TabIndex = 113
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(33, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 1)
        Me.Panel3.TabIndex = 112
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(33, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 26)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Actualizar Via"
        '
        'pbCodZona
        '
        Me.pbCodZona.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbCodZona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCodZona.Location = New System.Drawing.Point(481, 422)
        Me.pbCodZona.Name = "pbCodZona"
        Me.pbCodZona.Size = New System.Drawing.Size(16, 16)
        Me.pbCodZona.TabIndex = 132
        Me.pbCodZona.TabStop = False
        Me.pbCodZona.Visible = False
        '
        'pbNom
        '
        Me.pbNom.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbNom.Location = New System.Drawing.Point(763, 414)
        Me.pbNom.Name = "pbNom"
        Me.pbNom.Size = New System.Drawing.Size(16, 16)
        Me.pbNom.TabIndex = 130
        Me.pbNom.TabStop = False
        Me.pbNom.Visible = False
        '
        'pbId
        '
        Me.pbId.BackgroundImage = Global.Muni.My.Resources.Resources.exclamation2
        Me.pbId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbId.Location = New System.Drawing.Point(246, 417)
        Me.pbId.Name = "pbId"
        Me.pbId.Size = New System.Drawing.Size(16, 16)
        Me.pbId.TabIndex = 129
        Me.pbId.TabStop = False
        Me.pbId.Visible = False
        '
        'btn_new
        '
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btn_new.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_new.Image = Global.Muni.My.Resources.Resources.new_file
        Me.btn_new.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_new.Location = New System.Drawing.Point(586, 28)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(56, 53)
        Me.btn_new.TabIndex = 111
        Me.btn_new.Text = "New"
        Me.btn_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.FlatAppearance.BorderSize = 0
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_refresh.Image = Global.Muni.My.Resources.Resources.refresh
        Me.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_refresh.Location = New System.Drawing.Point(642, 28)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(65, 53)
        Me.btn_refresh.TabIndex = 110
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_close.Image = Global.Muni.My.Resources.Resources.cancel_button_small
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_close.Location = New System.Drawing.Point(763, 28)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(56, 53)
        Me.btn_close.TabIndex = 108
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print.FlatAppearance.BorderSize = 0
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btn_print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_print.Image = Global.Muni.My.Resources.Resources.printer
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_print.Location = New System.Drawing.Point(707, 28)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(56, 53)
        Me.btn_print.TabIndex = 109
        Me.btn_print.Text = "Print"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'uc_rentas_via_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbCodZona)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pbNom)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbxCodigoVia)
        Me.Controls.Add(Me.pbId)
        Me.Controls.Add(Me.btnlistarall)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNomVia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodVia)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxbusqueda)
        Me.Controls.Add(Me.txtPalabraClave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgwVia)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_print)
        Me.Name = "uc_rentas_via_update"
        Me.Size = New System.Drawing.Size(867, 635)
        CType(Me.dgwVia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCodZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbCodZona As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pbNom As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxCodigoVia As ComboBox
    Friend WithEvents pbId As PictureBox
    Friend WithEvents btnlistarall As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomVia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodVia As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OK As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxbusqueda As ComboBox
    Friend WithEvents txtPalabraClave As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgwVia As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_print As Button
End Class
