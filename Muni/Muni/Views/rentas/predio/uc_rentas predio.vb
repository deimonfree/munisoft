﻿Public Class uc_rentas_predio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim Myfrm As New uc_rentas_predio_new
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
        pbload.Visible = True
        '******************************
        sidePanel.Width = Button1.Width
        sidePanel.Location = Button1.Location
        Button1.BackColor = Color.FromArgb(255, 255, 255)
        Button1.ForeColor = Color.FromArgb(6, 60, 107)
        sidePanel.Visible = True
        Button2.BackColor = Color.FromArgb(6, 60, 107)
        Button2.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        'Dim height As Integer = 0.9 * desktopSize.Height
        'Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_rentas_ficha_mant
        'Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
        '******************************
        sidePanel.Width = Button2.Width
        sidePanel.Location = Button2.Location
        Button2.BackColor = Color.FromArgb(255, 255, 255)
        Button2.ForeColor = Color.FromArgb(6, 60, 107)
        sidePanel.Visible = True
        Button1.BackColor = Color.FromArgb(6, 60, 107)
        Button1.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
End Class
