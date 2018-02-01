Public Class uc_rentas_valorDepreciacion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        'Dim height As Integer = 0.9 * desktopSize.Height
        'Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_rentas_catalogo_depreciacion
        'Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
        Button1.BackColor = Color.FromArgb(255, 255, 255)
        Button1.ForeColor = Color.FromArgb(6, 60, 107)
        sidel_panel.Visible = True
    End Sub
End Class
