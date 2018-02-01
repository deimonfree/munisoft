<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cu_almacen
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
        Me.btn_close = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.model2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.model1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 100)
        Me.Panel1.TabIndex = 2
        '
        'btn_close
        '
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.Image = Global.Muni.My.Resources.Resources.close_button
        Me.btn_close.Location = New System.Drawing.Point(13, 14)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(15, 15)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 38
        Me.btn_close.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.model2)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.model1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 277)
        Me.Panel2.TabIndex = 3
        '
        'model2
        '
        Me.model2.BackColor = System.Drawing.Color.Transparent
        Me.model2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.model2.Dock = System.Windows.Forms.DockStyle.Top
        Me.model2.FlatAppearance.BorderSize = 0
        Me.model2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.model2.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.model2.ForeColor = System.Drawing.Color.Black
        Me.model2.Image = Global.Muni.My.Resources.Resources.warehouse2
        Me.model2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.model2.Location = New System.Drawing.Point(0, 111)
        Me.model2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.model2.Name = "model2"
        Me.model2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.model2.Size = New System.Drawing.Size(345, 37)
        Me.model2.TabIndex = 24
        Me.model2.Text = "          Almacen"
        Me.model2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.model2.UseVisualStyleBackColor = False
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
        Me.Button2.Image = Global.Muni.My.Resources.Resources.warehouse2
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 74)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(345, 37)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "          Semapac"
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
        Me.Button1.Image = Global.Muni.My.Resources.Resources.warehouse2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 37)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(345, 37)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "          Registro Civil"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'model1
        '
        Me.model1.BackColor = System.Drawing.Color.Transparent
        Me.model1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.model1.Dock = System.Windows.Forms.DockStyle.Top
        Me.model1.FlatAppearance.BorderSize = 0
        Me.model1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.model1.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.model1.ForeColor = System.Drawing.Color.Black
        Me.model1.Image = Global.Muni.My.Resources.Resources.warehouse2
        Me.model1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.model1.Location = New System.Drawing.Point(0, 0)
        Me.model1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.model1.Name = "model1"
        Me.model1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.model1.Size = New System.Drawing.Size(345, 37)
        Me.model1.TabIndex = 21
        Me.model1.Text = "          Almacen"
        Me.model1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.model1.UseVisualStyleBackColor = False
        '
        'cu_almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "cu_almacen"
        Me.Size = New System.Drawing.Size(345, 482)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_close As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents model1 As Button
    Friend WithEvents model2 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
