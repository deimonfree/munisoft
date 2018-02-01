Public NotInheritable Class ab_rentas_sector_new


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

    End Sub


    Private Sub cbxCodigoZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCodigoZona.SelectedIndexChanged


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim formulario As New ab_rentas_zona_new
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            'If formulario.valor_busqueda = 0 Then
            'Else
            '    Label1.Text = "putin"
            'End If
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim controller As New class_controller_sector
        Dim datos As New class_datos_sector
        datos.id_sector = txtid_sector.Text
        datos.nombre_sector = txtNombreZona.Text
        datos.codZona_sector = cbxCodigoZona.Text
        If controller.insertarDatosSector(datos) Then
            MessageBox.Show("datos guarados")
            Me.Close()
        Else
            MessageBox.Show("datos no guarados")
            txtid_sector.Text = ""
            txtNombreZona.Text = ""
            txtid_sector.Select()
        End If
    End Sub
End Class
