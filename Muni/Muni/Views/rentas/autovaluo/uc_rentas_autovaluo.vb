Public Class uc_rentas_autovaluo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_rentas_autovaluo_generar
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_rentas_autovaluo_recibo
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
    End Sub


End Class
