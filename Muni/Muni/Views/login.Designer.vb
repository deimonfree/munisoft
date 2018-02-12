<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class login
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.gbServidores = New System.Windows.Forms.GroupBox()
        Me.lblPUERTO = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbLoad = New System.Windows.Forms.PictureBox()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.cbxServidores = New System.Windows.Forms.ComboBox()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.lblInfoFotter = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPortServer = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrintFicha = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.chkPass = New System.Windows.Forms.CheckBox()
        Me.gbStatusServer = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnConfServer = New System.Windows.Forms.Button()
        Me.lblServerInfo = New System.Windows.Forms.Label()
        Me.lblInfoServer = New System.Windows.Forms.Label()
        Me.gbServidores.SuspendLayout()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFooter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbStatusServer.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbServidores
        '
        Me.gbServidores.Controls.Add(Me.lblPUERTO)
        Me.gbServidores.Controls.Add(Me.lblIP)
        Me.gbServidores.Controls.Add(Me.Label9)
        Me.gbServidores.Controls.Add(Me.Label4)
        Me.gbServidores.Controls.Add(Me.pbLoad)
        Me.gbServidores.Controls.Add(Me.btnMessage)
        Me.gbServidores.Controls.Add(Me.lblInfo)
        Me.gbServidores.Controls.Add(Me.cbxServidores)
        Me.gbServidores.Enabled = False
        Me.gbServidores.Location = New System.Drawing.Point(749, 212)
        Me.gbServidores.Name = "gbServidores"
        Me.gbServidores.Size = New System.Drawing.Size(210, 152)
        Me.gbServidores.TabIndex = 730
        Me.gbServidores.TabStop = False
        '
        'lblPUERTO
        '
        Me.lblPUERTO.AutoSize = True
        Me.lblPUERTO.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPUERTO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblPUERTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPUERTO.Location = New System.Drawing.Point(85, 80)
        Me.lblPUERTO.Name = "lblPUERTO"
        Me.lblPUERTO.Size = New System.Drawing.Size(0, 17)
        Me.lblPUERTO.TabIndex = 713
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblIP.Location = New System.Drawing.Point(85, 63)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(0, 17)
        Me.lblIP.TabIndex = 712
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(6, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 711
        Me.Label9.Text = "Puerto ::"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 710
        Me.Label4.Text = "Direccion ::"
        '
        'pbLoad
        '
        Me.pbLoad.Image = Global.Muni.My.Resources.Resources.server
        Me.pbLoad.Location = New System.Drawing.Point(6, 19)
        Me.pbLoad.Name = "pbLoad"
        Me.pbLoad.Size = New System.Drawing.Size(32, 32)
        Me.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoad.TabIndex = 414
        Me.pbLoad.TabStop = False
        '
        'btnMessage
        '
        Me.btnMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnMessage.FlatAppearance.BorderSize = 0
        Me.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMessage.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMessage.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMessage.Location = New System.Drawing.Point(47, 110)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(148, 30)
        Me.btnMessage.TabIndex = 709
        Me.btnMessage.Text = "Conectar"
        Me.btnMessage.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(42, 14)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(158, 17)
        Me.lblInfo.TabIndex = 421
        Me.lblInfo.Text = "Listado de Servidores ::"
        '
        'cbxServidores
        '
        Me.cbxServidores.Font = New System.Drawing.Font("Ubuntu", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxServidores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.cbxServidores.FormattingEnabled = True
        Me.cbxServidores.Location = New System.Drawing.Point(44, 34)
        Me.cbxServidores.Name = "cbxServidores"
        Me.cbxServidores.Size = New System.Drawing.Size(152, 24)
        Me.cbxServidores.TabIndex = 706
        '
        'panelFooter
        '
        Me.panelFooter.BackColor = System.Drawing.Color.White
        Me.panelFooter.Controls.Add(Me.lblInfoFotter)
        Me.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFooter.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelFooter.ForeColor = System.Drawing.Color.White
        Me.panelFooter.Location = New System.Drawing.Point(386, 524)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(584, 25)
        Me.panelFooter.TabIndex = 728
        '
        'lblInfoFotter
        '
        Me.lblInfoFotter.AutoSize = True
        Me.lblInfoFotter.Location = New System.Drawing.Point(14, 5)
        Me.lblInfoFotter.Name = "lblInfoFotter"
        Me.lblInfoFotter.Size = New System.Drawing.Size(13, 16)
        Me.lblInfoFotter.TabIndex = 4
        Me.lblInfoFotter.Text = "-"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Ubuntu", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(386, 549)
        Me.Panel2.TabIndex = 727
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(118, 489)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(148, 19)
        Me.LinkLabel1.TabIndex = 418
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.munisoft.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(341, 96)
        Me.Label3.TabIndex = 417
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(89, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 26)
        Me.Label2.TabIndex = 416
        Me.Label2.Text = "MODULO DE  RENTA"
        '
        'lblPortServer
        '
        Me.lblPortServer.AutoSize = True
        Me.lblPortServer.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortServer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblPortServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPortServer.Location = New System.Drawing.Point(901, 153)
        Me.lblPortServer.Name = "lblPortServer"
        Me.lblPortServer.Size = New System.Drawing.Size(0, 17)
        Me.lblPortServer.TabIndex = 726
        '
        'btn_close
        '
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Image = Global.Muni.My.Resources.Resources.close_button1
        Me.btn_close.Location = New System.Drawing.Point(937, 8)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(24, 24)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 712
        Me.btn_close.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Muni.My.Resources.Resources.logo_MUNI
        Me.PictureBox1.Location = New System.Drawing.Point(537, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 725
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnPrintFicha)
        Me.Panel1.Location = New System.Drawing.Point(740, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 380)
        Me.Panel1.TabIndex = 724
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
        Me.btnPrintFicha.Location = New System.Drawing.Point(682, 5)
        Me.btnPrintFicha.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnPrintFicha.Name = "btnPrintFicha"
        Me.btnPrintFicha.Size = New System.Drawing.Size(108, 53)
        Me.btnPrintFicha.TabIndex = 277
        Me.btnPrintFicha.Text = "Imprimir Ficha"
        Me.btnPrintFicha.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintFicha.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(404, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 32)
        Me.Label8.TabIndex = 723
        Me.Label8.Text = "Es nuevo en " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el sistema"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(404, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 32)
        Me.Label7.TabIndex = 722
        Me.Label7.Text = "Olvido su " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contaseña?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(404, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 721
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(417, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 720
        Me.Label5.Text = "Usuario"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(495, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 40)
        Me.Button2.TabIndex = 719
        Me.Button2.Text = "Crear nuevo usuario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(495, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 40)
        Me.Button1.TabIndex = 717
        Me.Button1.Text = "Recuperar  contraseña "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(492, 193)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(223, 22)
        Me.UsernameTextBox.TabIndex = 713
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(492, 231)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(223, 22)
        Me.PasswordTextBox.TabIndex = 714
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(441, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 26)
        Me.Label1.TabIndex = 718
        Me.Label1.Text = "Un Buen dia para empezar!"
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
        Me.OK.Location = New System.Drawing.Point(495, 297)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(220, 42)
        Me.OK.TabIndex = 715
        Me.OK.Text = "&Entrar"
        Me.OK.UseVisualStyleBackColor = False
        '
        'chkPass
        '
        Me.chkPass.AutoSize = True
        Me.chkPass.ForeColor = System.Drawing.Color.Gray
        Me.chkPass.Location = New System.Drawing.Point(492, 262)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(107, 17)
        Me.chkPass.TabIndex = 716
        Me.chkPass.Text = "Recordar usuario"
        Me.chkPass.UseVisualStyleBackColor = True
        '
        'gbStatusServer
        '
        Me.gbStatusServer.Controls.Add(Me.Button3)
        Me.gbStatusServer.Controls.Add(Me.btnConfServer)
        Me.gbStatusServer.Controls.Add(Me.lblServerInfo)
        Me.gbStatusServer.Controls.Add(Me.lblInfoServer)
        Me.gbStatusServer.Location = New System.Drawing.Point(749, 130)
        Me.gbStatusServer.Name = "gbStatusServer"
        Me.gbStatusServer.Size = New System.Drawing.Size(210, 76)
        Me.gbStatusServer.TabIndex = 729
        Me.gbStatusServer.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(47, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 30)
        Me.Button3.TabIndex = 710
        Me.Button3.Text = "Configurar Servidor"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnConfServer
        '
        Me.btnConfServer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfServer.FlatAppearance.BorderSize = 0
        Me.btnConfServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfServer.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnConfServer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnConfServer.Image = Global.Muni.My.Resources.Resources.server1
        Me.btnConfServer.Location = New System.Drawing.Point(3, 14)
        Me.btnConfServer.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnConfServer.Name = "btnConfServer"
        Me.btnConfServer.Size = New System.Drawing.Size(36, 32)
        Me.btnConfServer.TabIndex = 423
        Me.btnConfServer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConfServer.UseVisualStyleBackColor = True
        '
        'lblServerInfo
        '
        Me.lblServerInfo.AutoSize = True
        Me.lblServerInfo.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblServerInfo.Location = New System.Drawing.Point(42, 10)
        Me.lblServerInfo.Name = "lblServerInfo"
        Me.lblServerInfo.Size = New System.Drawing.Size(74, 17)
        Me.lblServerInfo.TabIndex = 426
        Me.lblServerInfo.Text = "Servidor ::"
        '
        'lblInfoServer
        '
        Me.lblInfoServer.AutoSize = True
        Me.lblInfoServer.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoServer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblInfoServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInfoServer.Location = New System.Drawing.Point(114, 10)
        Me.lblInfoServer.Name = "lblInfoServer"
        Me.lblInfoServer.Size = New System.Drawing.Size(16, 17)
        Me.lblInfoServer.TabIndex = 422
        Me.lblInfoServer.Text = "::"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 549)
        Me.Controls.Add(Me.gbServidores)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblPortServer)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.chkPass)
        Me.Controls.Add(Me.gbStatusServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.gbServidores.ResumeLayout(False)
        Me.gbServidores.PerformLayout()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFooter.ResumeLayout(False)
        Me.panelFooter.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gbStatusServer.ResumeLayout(False)
        Me.gbStatusServer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbServidores As GroupBox
    Friend WithEvents lblPUERTO As Label
    Friend WithEvents lblIP As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pbLoad As PictureBox
    Friend WithEvents btnMessage As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents cbxServidores As ComboBox
    Friend WithEvents panelFooter As Panel
    Friend WithEvents lblInfoFotter As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPortServer As Label
    Friend WithEvents btn_close As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrintFicha As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OK As Button
    Friend WithEvents chkPass As CheckBox
    Friend WithEvents gbStatusServer As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnConfServer As Button
    Friend WithEvents lblServerInfo As Label
    Friend WithEvents lblInfoServer As Label
End Class
