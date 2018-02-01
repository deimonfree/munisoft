Public Class uc_rentas_zonas_actualizar
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnlistarall_Click(sender As Object, e As EventArgs) Handles btnlistarall.Click
        _DatasetZona.Reset()
        consulta_datos_zona_all()
        dgwZona.DataSource = _dtwZona
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
            If controlador.actualizarDatosZona(datos) Then
                MessageBox.Show("datos guardados")
                _DatasetZona.Reset()
                txtCodZona.Text = ""
                txtNomZona.Text = ""
            Else
                MessageBox.Show("datos no guardados")
            End If
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtNomZona_TextChanged(sender As Object, e As EventArgs) Handles txtNomZona.TextChanged

    End Sub

    Private Sub txtCodZona_TextChanged(sender As Object, e As EventArgs) Handles txtCodZona.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub txtRuc_TextChanged(sender As Object, e As EventArgs) Handles txtRuc.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub dgwZona_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwZona.CellContentClick

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pbNom_Click(sender As Object, e As EventArgs) Handles pbNom.Click

    End Sub

    Private Sub pbId_Click(sender As Object, e As EventArgs) Handles pbId.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class
