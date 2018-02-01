Public Class uc_rentas_catalogo
    Dim buttonnew As String
    Dim buttonold As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_rentas_zona
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
        sidePanel.Width = Button1.Width
        sidePanel.Location = Button1.Location
        Button1.BackColor = Color.FromArgb(255, 255, 255)
        Button1.ForeColor = Color.FromArgb(6, 60, 107)
        sidePanel.Visible = True
        Button2.BackColor = Color.FromArgb(6, 60, 107)
        Button2.ForeColor = Color.FromArgb(255, 255, 255)
        Button3.BackColor = Color.FromArgb(6, 60, 107)
        Button3.ForeColor = Color.FromArgb(255, 255, 255)
        Button4.BackColor = Color.FromArgb(6, 60, 107)
        Button4.ForeColor = Color.FromArgb(255, 255, 255)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_rentas_sectores
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
        sidePanel.Width = Button2.Width
        'sidePanel.Top = Button2.Top
        sidePanel.Location = Button2.Location
        Button2.BackColor = Color.FromArgb(255, 255, 255)
        Button2.ForeColor = Color.FromArgb(6, 60, 107)
        sidePanel.Visible = True
        Button1.BackColor = Color.FromArgb(6, 60, 107)
        Button1.ForeColor = Color.FromArgb(255, 255, 255)
        Button3.BackColor = Color.FromArgb(6, 60, 107)
        Button3.ForeColor = Color.FromArgb(255, 255, 255)
        Button4.BackColor = Color.FromArgb(6, 60, 107)
        Button4.ForeColor = Color.FromArgb(255, 255, 255)

    End Sub


    Private Sub btnShare_Click(sender As Object, e As EventArgs)
        Button1.BackColor = Color.FromArgb(6, 60, 107)
        Button1.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_rentas_vias2
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
        sidePanel.Visible = True
        sidePanel.Width = Button3.Width
        'sidePanel.Top = Button3.Top
        sidePanel.Location = Button3.Location
        Button3.BackColor = Color.FromArgb(255, 255, 255)
        Button3.ForeColor = Color.FromArgb(6, 60, 107)
        Button1.BackColor = Color.FromArgb(6, 60, 107)
        Button1.ForeColor = Color.FromArgb(255, 255, 255)
        Button2.BackColor = Color.FromArgb(6, 60, 107)
        Button2.ForeColor = Color.FromArgb(255, 255, 255)
        Button4.BackColor = Color.FromArgb(6, 60, 107)
        Button4.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        panel_body.Controls.Clear()
        'animacion de boton
        sidePanel.Width = Button4.Width
        sidePanel.Location = Button4.Location
        Button4.BackColor = Color.FromArgb(255, 255, 255)
        Button4.ForeColor = Color.FromArgb(6, 60, 107)
        sidePanel.Visible = True
        Button1.BackColor = Color.FromArgb(6, 60, 107)
        Button1.ForeColor = Color.FromArgb(255, 255, 255)
        Button3.BackColor = Color.FromArgb(6, 60, 107)
        Button3.ForeColor = Color.FromArgb(255, 255, 255)
        Button2.BackColor = Color.FromArgb(6, 60, 107)
        Button2.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
End Class
