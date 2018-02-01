Public NotInheritable Class ab_rentas_distrito_busqueda
    Public valor_busqueda As Integer


    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim valor As String
        valor = txt_palabraClave.Text
        _DatasetDistrito.Reset()
        consulta_datos_Distrito_all_By(valor)
        dgwDistrito.DataSource = _dtwDistrito

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
