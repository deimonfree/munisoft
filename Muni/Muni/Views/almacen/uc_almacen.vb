Public Class uc_almacen
    Private Sub model1_Click_1(sender As Object, e As EventArgs) Handles btnContribuyente.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 900
        Dim Myfrm As New uc_rentas_contribuyente
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body_almacen.Controls.Clear()
        panel_body_almacen.Controls.Add(Myfrm)
        slidePanel.Height = btnContribuyente.Height
        slidePanel.Top = btnContribuyente.Top
        'slidePanel.Location = Button2.Location
    End Sub


    Private Sub btn_Arancel_Click(sender As Object, e As EventArgs) Handles btn_Arancel.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 900
        Dim Myfrm As New uc_rentas_arancel
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body_almacen.Controls.Clear()
        panel_body_almacen.Controls.Add(Myfrm)
        slidePanel.Height = btn_Arancel.Height
        slidePanel.Top = btn_Arancel.Top
    End Sub

    Private Sub btnPredio_Click(sender As Object, e As EventArgs) Handles btnPredio.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 900
        Dim Myfrm As New uc_rentas_predio
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body_almacen.Controls.Clear()
        panel_body_almacen.Controls.Add(Myfrm)
        slidePanel.Height = btnPredio.Height
        slidePanel.Top = btnPredio.Top
    End Sub

    Private Sub btnAutovaluo_Click(sender As Object, e As EventArgs) Handles btnAutovaluo.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 900
        Dim Myfrm As New uc_rentas_autovaluo
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body_almacen.Controls.Clear()
        panel_body_almacen.Controls.Add(Myfrm)
        slidePanel.Height = btnAutovaluo.Height
        slidePanel.Top = btnAutovaluo.Top
    End Sub

    Private Sub btnCatalogoVias_Click(sender As Object, e As EventArgs) Handles btnCatalogoVias.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 900
        Dim Myfrm As New uc_rentas_catalogo
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body_almacen.Controls.Clear()
        panel_body_almacen.Controls.Add(Myfrm)
        slidePanel.Height = btnCatalogoVias.Height
        slidePanel.Top = btnCatalogoVias.Top
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 900
        Dim Myfrm As New uc_rentas_reportes
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body_almacen.Controls.Clear()
        panel_body_almacen.Controls.Add(Myfrm)
        slidePanel.Height = btnReportes.Height
        slidePanel.Top = btnReportes.Top
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 900
        Dim Myfrm As New uc_rentas_valorDepreciacion
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body_almacen.Controls.Clear()
        panel_body_almacen.Controls.Add(Myfrm)
        slidePanel.Height = Button1.Height
        slidePanel.Top = Button1.Top
        'slidePanel.Location = Button2.Location
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 900
        Dim Myfrm As New uc_rentas_valor_UIT
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body_almacen.Controls.Clear()
        panel_body_almacen.Controls.Add(Myfrm)
        slidePanel.Height = Button2.Height
        slidePanel.Top = Button2.Top
        'slidePanel.Location = Button2.Location
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 900
        Dim Myfrm As New uc_rentas_baseImponible_Minimo
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        panel_body_almacen.Controls.Clear()
        panel_body_almacen.Controls.Add(Myfrm)
        slidePanel.Height = Button4.Height
        slidePanel.Top = Button4.Top
        'slidePanel.Location = Button2.Location
    End Sub
End Class
