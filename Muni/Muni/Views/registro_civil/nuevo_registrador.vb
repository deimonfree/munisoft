Public NotInheritable Class nuevo_registrador
    Dim valor_busqueda = 0



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim conexion As New class_controller_registrador
        Dim datos As New class_datos_registrador
        datos.nombre_registrador = txtnombre.Text
        datos.apePaterno_registrador = txtapellidoPat.Text
        datos.apeMaterno_registrador = txtapellidoMat.Text
        datos.dni_registrador = txtdni.Text
        If conexion.insertarDatosReg(datos) Then
            MessageBox.Show("Datos Guardados")
            Me.Close()
        Else
            MessageBox.Show("Datos no Guardados")
            txtnombre.Text = ""
            txtapellidoPat.Text = ""
            txtapellidoMat.Text = ""
            txtdni.Text = ""
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
