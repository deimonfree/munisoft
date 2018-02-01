Public Class uc_rentas_sector
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim formulario As New ab_rentas_sector_new
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            'If formulario.valor_busqueda = 0 Then
            'Else
            '    Label1.Text = "putin"
            'End If
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_rentas_sector_actualizar
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body.Controls.Clear()
        panel_body.Controls.Add(Myfrm)
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click

    End Sub
End Class
