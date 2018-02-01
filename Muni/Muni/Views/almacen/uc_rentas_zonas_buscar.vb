Public Class uc_rentas_zonas_buscar
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim dato_dinamico As String
        dato_dinamico = txtRuc.Text
        _DatasetZona.Reset()
        consulta_datos_zona_detalle_by(dato_dinamico)
        dgwVista.DataSource = _dtwZona
    End Sub

    Private Sub btn_show_all_Click(sender As Object, e As EventArgs) Handles btn_show_all.Click
        _DatasetZona.Reset()
        consulta_datos_zona_all()
        dgwVista.DataSource = _dtwZona
    End Sub

    Private Sub txtRuc_TextChanged(sender As Object, e As EventArgs) Handles txtRuc.TextChanged
        Dim dato_dinamico As String
        dato_dinamico = txtRuc.Text
        _DatasetZona.Reset()
        consulta_datos_zona_detalle_by_dinamic(dato_dinamico)
        dgwVista.DataSource = _dtwZona
    End Sub
End Class
