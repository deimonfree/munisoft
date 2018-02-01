Public NotInheritable Class ab_proveedor

    Private Sub ab_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub OKButton_Click_1(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim conexion As New class_controller_proveedor
        Dim datos As New class_datos_proveedor
        datos.ruc_proveedor = txtRuc.Text
        datos.razon_social_proveedor = txtRazonSocial.Text
        datos.direction_proveedor = txtDirection.Text
        If conexion.insertarDatosProveedor(datos) Then
            MessageBox.Show("Datos Guardados")
            Me.Close()
        Else
            MessageBox.Show("Datos no Guardados")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
