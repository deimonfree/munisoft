Public Class uc_rentas_contribuyente
    Private Sub btnShare_Click(sender As Object, e As EventArgs)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        'Dim height As Integer = 0.9 * desktopSize.Height
        'Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_rentas_contribuyente_mostrar
        'Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        'Dim height As Integer = 0.9 * desktopSize.Height
        'Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_rentas_contribuyente_new
        'Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)

    End Sub

    Private Sub panel_body_Paint(sender As Object, e As PaintEventArgs) Handles panel_body.Paint


    End Sub
End Class
