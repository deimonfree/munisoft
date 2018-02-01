<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_almacen
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
        Me.panel_sider = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.slidePanel = New System.Windows.Forms.Panel()
        Me.btnCatalogoVias = New System.Windows.Forms.Button()
        Me.btn_Arancel = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnAutovaluo = New System.Windows.Forms.Button()
        Me.btnPredio = New System.Windows.Forms.Button()
        Me.btnContribuyente = New System.Windows.Forms.Button()
        Me.panel_barra = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_body_almacen = New System.Windows.Forms.Panel()
        Me.panel_sider.SuspendLayout()
        Me.panel_barra.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_sider
        '
        Me.panel_sider.AutoScroll = True
        Me.panel_sider.BackColor = System.Drawing.Color.White
        Me.panel_sider.Controls.Add(Me.Button4)
        Me.panel_sider.Controls.Add(Me.Button2)
        Me.panel_sider.Controls.Add(Me.Button1)
        Me.panel_sider.Controls.Add(Me.slidePanel)
        Me.panel_sider.Controls.Add(Me.btnCatalogoVias)
        Me.panel_sider.Controls.Add(Me.btn_Arancel)
        Me.panel_sider.Controls.Add(Me.Button3)
        Me.panel_sider.Controls.Add(Me.btnReportes)
        Me.panel_sider.Controls.Add(Me.btnAutovaluo)
        Me.panel_sider.Controls.Add(Me.btnPredio)
        Me.panel_sider.Controls.Add(Me.btnContribuyente)
        Me.panel_sider.Controls.Add(Me.panel_barra)
        Me.panel_sider.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_sider.Location = New System.Drawing.Point(0, 0)
        Me.panel_sider.Name = "panel_sider"
        Me.panel_sider.Size = New System.Drawing.Size(240, 686)
        Me.panel_sider.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.Muni.My.Resources.Resources.dinero
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 433)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(240, 37)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "          Valor  Minimo de Base I."
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.Muni.My.Resources.Resources.profits
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 396)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(240, 37)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "          Valores  de UIT"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Muni.My.Resources.Resources.depreciacion
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 359)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(240, 37)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "          Valores  de Depreciación"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'slidePanel
        '
        Me.slidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.slidePanel.Location = New System.Drawing.Point(0, 100)
        Me.slidePanel.Name = "slidePanel"
        Me.slidePanel.Size = New System.Drawing.Size(8, 39)
        Me.slidePanel.TabIndex = 36
        '
        'btnCatalogoVias
        '
        Me.btnCatalogoVias.BackColor = System.Drawing.Color.Transparent
        Me.btnCatalogoVias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCatalogoVias.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCatalogoVias.FlatAppearance.BorderSize = 0
        Me.btnCatalogoVias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatalogoVias.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatalogoVias.ForeColor = System.Drawing.Color.Black
        Me.btnCatalogoVias.Image = Global.Muni.My.Resources.Resources.placeholder1
        Me.btnCatalogoVias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatalogoVias.Location = New System.Drawing.Point(0, 322)
        Me.btnCatalogoVias.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.btnCatalogoVias.Name = "btnCatalogoVias"
        Me.btnCatalogoVias.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCatalogoVias.Size = New System.Drawing.Size(240, 37)
        Me.btnCatalogoVias.TabIndex = 38
        Me.btnCatalogoVias.Text = "          Vias / Parcelas"
        Me.btnCatalogoVias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatalogoVias.UseVisualStyleBackColor = False
        '
        'btn_Arancel
        '
        Me.btn_Arancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_Arancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Arancel.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Arancel.FlatAppearance.BorderSize = 0
        Me.btn_Arancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Arancel.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Arancel.ForeColor = System.Drawing.Color.Black
        Me.btn_Arancel.Image = Global.Muni.My.Resources.Resources.map
        Me.btn_Arancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Arancel.Location = New System.Drawing.Point(0, 285)
        Me.btn_Arancel.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.btn_Arancel.Name = "btn_Arancel"
        Me.btn_Arancel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_Arancel.Size = New System.Drawing.Size(240, 37)
        Me.btn_Arancel.TabIndex = 35
        Me.btn_Arancel.Text = "          Valores Arancelarios"
        Me.btn_Arancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Arancel.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 248)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(240, 37)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "CATALOGOS"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.Transparent
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.Black
        Me.btnReportes.Image = Global.Muni.My.Resources.Resources.economy
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(0, 211)
        Me.btnReportes.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnReportes.Size = New System.Drawing.Size(240, 37)
        Me.btnReportes.TabIndex = 29
        Me.btnReportes.Text = "          Reportes Fichas"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnAutovaluo
        '
        Me.btnAutovaluo.BackColor = System.Drawing.Color.Transparent
        Me.btnAutovaluo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutovaluo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAutovaluo.FlatAppearance.BorderSize = 0
        Me.btnAutovaluo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutovaluo.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutovaluo.ForeColor = System.Drawing.Color.Black
        Me.btnAutovaluo.Image = Global.Muni.My.Resources.Resources.get_money
        Me.btnAutovaluo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAutovaluo.Location = New System.Drawing.Point(0, 174)
        Me.btnAutovaluo.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.btnAutovaluo.Name = "btnAutovaluo"
        Me.btnAutovaluo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAutovaluo.Size = New System.Drawing.Size(240, 37)
        Me.btnAutovaluo.TabIndex = 28
        Me.btnAutovaluo.Text = "          Autovaluo"
        Me.btnAutovaluo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAutovaluo.UseVisualStyleBackColor = False
        '
        'btnPredio
        '
        Me.btnPredio.BackColor = System.Drawing.Color.Transparent
        Me.btnPredio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPredio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPredio.FlatAppearance.BorderSize = 0
        Me.btnPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPredio.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPredio.ForeColor = System.Drawing.Color.Black
        Me.btnPredio.Image = Global.Muni.My.Resources.Resources.office_block
        Me.btnPredio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPredio.Location = New System.Drawing.Point(0, 137)
        Me.btnPredio.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.btnPredio.Name = "btnPredio"
        Me.btnPredio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnPredio.Size = New System.Drawing.Size(240, 37)
        Me.btnPredio.TabIndex = 27
        Me.btnPredio.Text = "          Predio"
        Me.btnPredio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPredio.UseVisualStyleBackColor = False
        '
        'btnContribuyente
        '
        Me.btnContribuyente.BackColor = System.Drawing.Color.Transparent
        Me.btnContribuyente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContribuyente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnContribuyente.FlatAppearance.BorderSize = 0
        Me.btnContribuyente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContribuyente.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContribuyente.ForeColor = System.Drawing.Color.Black
        Me.btnContribuyente.Image = Global.Muni.My.Resources.Resources.team
        Me.btnContribuyente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContribuyente.Location = New System.Drawing.Point(0, 100)
        Me.btnContribuyente.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.btnContribuyente.Name = "btnContribuyente"
        Me.btnContribuyente.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnContribuyente.Size = New System.Drawing.Size(240, 37)
        Me.btnContribuyente.TabIndex = 26
        Me.btnContribuyente.Text = "          Contribuyente"
        Me.btnContribuyente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContribuyente.UseVisualStyleBackColor = False
        '
        'panel_barra
        '
        Me.panel_barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.panel_barra.Controls.Add(Me.Label2)
        Me.panel_barra.Controls.Add(Me.PictureBox3)
        Me.panel_barra.Controls.Add(Me.PictureBox2)
        Me.panel_barra.Controls.Add(Me.btn_close)
        Me.panel_barra.Controls.Add(Me.Label1)
        Me.panel_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_barra.Location = New System.Drawing.Point(0, 0)
        Me.panel_barra.Name = "panel_barra"
        Me.panel_barra.Size = New System.Drawing.Size(240, 100)
        Me.panel_barra.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 20)
        Me.Label2.TabIndex = 332
        Me.Label2.Text = "REGISTRO PREDIAL ::"
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Muni.My.Resources.Resources.pencil
        Me.PictureBox3.Location = New System.Drawing.Point(155, 73)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 47
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Muni.My.Resources.Resources.settings
        Me.PictureBox2.Location = New System.Drawing.Point(181, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Image = Global.Muni.My.Resources.Resources.question
        Me.btn_close.Location = New System.Drawing.Point(207, 73)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(20, 20)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 45
        Me.btn_close.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Modulo de registro predial y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "emision de recibos"
        '
        'panel_body_almacen
        '
        Me.panel_body_almacen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_body_almacen.Location = New System.Drawing.Point(240, 0)
        Me.panel_body_almacen.Name = "panel_body_almacen"
        Me.panel_body_almacen.Size = New System.Drawing.Size(850, 686)
        Me.panel_body_almacen.TabIndex = 5
        '
        'uc_almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel_body_almacen)
        Me.Controls.Add(Me.panel_sider)
        Me.Name = "uc_almacen"
        Me.Size = New System.Drawing.Size(1090, 686)
        Me.panel_sider.ResumeLayout(False)
        Me.panel_barra.ResumeLayout(False)
        Me.panel_barra.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_sider As Panel
    Friend WithEvents panel_body_almacen As Panel
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnPredio As Button
    Friend WithEvents panel_barra As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_close As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_Arancel As Button
    Protected WithEvents btnContribuyente As Button
    Friend WithEvents slidePanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCatalogoVias As Button
    Friend WithEvents btnAutovaluo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
End Class
