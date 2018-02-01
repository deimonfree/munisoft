Public NotInheritable Class ab_rentas_via_new



    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim controller As New class_controller_via
        Dim datos As New class_datos_via
        datos.nombre_via = txtnom_Via.Text
        datos.tipo_via = cbxCodigoVia.SelectedValue.ToString()
        If controller.insertarDatosVia(datos) Then
            MessageBox.Show("datos guarados")
            Me.Close()
        Else
            MessageBox.Show("datos no guarados")
            txtnom_Via.Text = ""
            txtnom_Via.Select()
        End If
    End Sub

    Private Sub ab_rentas_via_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mod_tipoVia._DatasetViaBox2.Reset()
        consulta_datos_tipovia_combox_all()
        cbxCodigoVia.DataSource = mod_tipoVia._DatasetViaBox2.Tables("tipo_via")
        cbxCodigoVia.DisplayMember = "nom_tipovia"
        cbxCodigoVia.ValueMember = "idtipo_via"
    End Sub
End Class
