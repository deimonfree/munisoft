Public NotInheritable Class ab_rentas_zona_new
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnclean_Click(sender As Object, e As EventArgs) Handles btnclean.Click
        txtid_zona.Text = ""
        txtnom_zona.Text = ""
        txtid_zona.Select()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim controller As New class_controller_zona
        Dim datos As New class_datos_zonaa
        datos.id_zona = txtid_zona.Text
        datos.nombre_zona = txtnom_zona.Text
        If controller.insertarDatosZona(datos) Then
            MessageBox.Show("datos guarados")
            Me.Close()
        Else
            MessageBox.Show("datos no guarados")
            txtid_zona.Text = ""
            txtnom_zona.Text = ""
            txtid_zona.Select()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New vistacentral
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
    End Sub
End Class
