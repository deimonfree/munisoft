<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_rentas_sector
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
        Me.panel_body = New System.Windows.Forms.Panel()
        Me.panel_title = New System.Windows.Forms.Panel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.panel_body.Size = New System.Drawing.Size(830, 392)
        Me.panel_body.TabIndex = 11
        '
        'panel_title
        '
        Me.panel_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.panel_title.Controls.Add(Me.Button3)
        Me.panel_title.Controls.Add(Me.btn_delete)
        Me.panel_title.Controls.Add(Me.btn_update)
        Me.panel_title.Controls.Add(Me.btn_new)
        Me.panel_title.Controls.Add(Me.btnInicio)
        Me.panel_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_title.Location = New System.Drawing.Point(0, 0)
        Me.panel_title.Name = "panel_title"
        Me.panel_title.Size = New System.Drawing.Size(830, 100)
        Me.panel_title.TabIndex = 10
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Image = Global.Muni.My.Resources.Resources.trash_bin_symbol
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(309, 10)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(96, 79)
        Me.btn_delete.TabIndex = 44
        Me.btn_delete.Text = "Eliminar Sector"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Image = Global.Muni.My.Resources.Resources.update
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update.Location = New System.Drawing.Point(208, 10)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(95, 79)
        Me.btn_update.TabIndex = 41
        Me.btn_update.Text = "Actualizar Sector"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btn_new.ForeColor = System.Drawing.Color.White
        Me.btn_new.Image = Global.Muni.My.Resources.Resources.add_new_document
        Me.btn_new.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_new.Location = New System.Drawing.Point(105, 10)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(97, 79)
        Me.btn_new.TabIndex = 40
        Me.btn_new.Text = "Nueva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Sector"
        Me.btn_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = Global.Muni.My.Resources.Resources.loupe
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInicio.Location = New System.Drawing.Point(10, 10)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(89, 79)
        Me.btnInicio.TabIndex = 39
        Me.btnInicio.Text = "Buscar Sector"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button3.Image = Global.Muni.My.Resources.Resources.cancel_button_small
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(764, 10)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0, 10, 0, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 53)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "Close"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'uc_rentas_sector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel_body)
        Me.Controls.Add(Me.panel_title)
        Me.Name = "uc_rentas_sector"
        Me.Size = New System.Drawing.Size(830, 492)
        Me.panel_title.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_body As Panel
    Friend WithEvents panel_title As Panel
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents Button3 As Button
End Class
