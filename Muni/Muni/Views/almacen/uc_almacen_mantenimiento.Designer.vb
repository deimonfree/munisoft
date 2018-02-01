<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_almacen_mantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uc_almacen_mantenimiento))
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.panel_title = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.panel_title.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_body
        '
        Me.panel_body.AutoScroll = True
        Me.panel_body.BackColor = System.Drawing.Color.White
        Me.panel_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_body.Location = New System.Drawing.Point(0, 100)
        Me.panel_body.Name = "panel_body"
        Me.panel_body.Size = New System.Drawing.Size(800, 400)
        Me.panel_body.TabIndex = 7
        '
        'panel_title
        '
        Me.panel_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.panel_title.Controls.Add(Me.Button7)
        Me.panel_title.Controls.Add(Me.Button6)
        Me.panel_title.Controls.Add(Me.Button5)
        Me.panel_title.Controls.Add(Me.Button2)
        Me.panel_title.Controls.Add(Me.Button1)
        Me.panel_title.Controls.Add(Me.btnInicio)
        Me.panel_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_title.Location = New System.Drawing.Point(0, 0)
        Me.panel_title.Name = "panel_title"
        Me.panel_title.Size = New System.Drawing.Size(800, 100)
        Me.panel_title.TabIndex = 6
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(510, 10)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 79)
        Me.Button7.TabIndex = 46
        Me.Button7.Text = "% I.G.V."
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(414, 10)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 79)
        Me.Button6.TabIndex = 45
        Me.Button6.Text = "Catalagos de Servicios"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(309, 10)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 79)
        Me.Button5.TabIndex = 44
        Me.Button5.Text = "Catalagos de Articulos"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(208, 10)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 79)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Linea de Productos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(105, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 79)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Transaciones"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInicio.Location = New System.Drawing.Point(10, 10)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(89, 79)
        Me.btnInicio.TabIndex = 39
        Me.btnInicio.Text = "Almacenes"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'uc_almacen_almacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_title)
        Me.Name = "uc_almacen_almacenes"
        Me.Size = New System.Drawing.Size(800, 500)
        Me.panel_title.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_body As Panel
    Friend WithEvents panel_title As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
End Class
