Public Class uc_rentas_zona_eliminar
    Private Sub btnlistarall_Click(sender As Object, e As EventArgs) Handles btnlistarall.Click
        _DatasetZona.Reset()
        consulta_datos_zona_all()
        dgwZona.DataSource = _dtwZona
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim controlador As New class_controller_zona
        Dim datos As New class_datos_zonaa
        Dim alta As Boolean = False
        pbId.Visible = False
        pbNom.Visible = False
        Select Case ""
            Case Trim(txtCodZona.Text)
                alta = True
                pbId.Visible = True
            Case Trim(txtNomZona.Text)
                alta = True
                pbNom.Visible = True
        End Select
        If alta = True Then
            MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            datos.id_zona = txtCodZona.Text
            datos.nombre_zona = txtNomZona.Text
            If controlador.eliminarDatosZona(datos) Then
                MessageBox.Show("datos eliminados")
                _DatasetZona.Reset()
                txtCodZona.Text = ""
                txtNomZona.Text = ""
            Else
                MessageBox.Show("datos no eliminados")
            End If
        End If
    End Sub

    Private Sub dgwZona_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwZona.CellClick
        Try
            Dim i As Integer
            i = dgwZona.CurrentRow.Index
            txtCodZona.Text = dgwZona.Item(0, i).Value()
            txtNomZona.Text = dgwZona.Item(1, i).Value()
        Catch ex As Exception

        End Try
    End Sub
End Class
