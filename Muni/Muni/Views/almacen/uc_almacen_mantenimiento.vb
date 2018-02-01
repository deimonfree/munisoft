Public Class uc_almacen_mantenimiento

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_alamacen_transaccion
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
    End Sub

    Private Sub panel_body_Paint(sender As Object, e As PaintEventArgs) Handles panel_body.Paint

    End Sub
End Class
