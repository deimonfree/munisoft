Public Class uc_rentas_via_update
    Private Sub btnlistarall_Click(sender As Object, e As EventArgs) Handles btnlistarall.Click
        _DatasetVia.Reset()
        consulta_datos_via_all()
        dgwVia.DataSource = _dtwVia
    End Sub

    Private Sub cbxCodigoVia_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxCodigoVia.MouseClick
        mod_tipoVia._DatasetViaBox2.Reset()
        consulta_datos_tipovia_combox_all()
        cbxCodigoVia.DataSource = mod_tipoVia._DatasetViaBox2.Tables("tipo_via")
        cbxCodigoVia.DisplayMember = "nom_tipovia"
        cbxCodigoVia.ValueMember = "idtipo_via"
    End Sub

    Private Sub dgwVia_DoubleClick(sender As Object, e As EventArgs) Handles dgwVia.DoubleClick
        Try
            Dim v1 As Integer
            txtCodVia.Text = dgwVia.Rows(dgwVia.CurrentRow.Index).Cells(0).Value
            txtNomVia.Text = dgwVia.Rows(dgwVia.CurrentRow.Index).Cells(1).Value
            v1 = dgwVia.Rows(dgwVia.CurrentRow.Index).Cells(2).Value
            ListarVia(v1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ListarVia(ByVal valor As Integer)
        mod_tipoVia._DatasetViaBox2.Reset()
        consulta_datos_tipovia_combox(valor)
        cbxCodigoVia.DataSource = mod_tipoVia._DatasetViaBox2.Tables("tipo_via")
        cbxCodigoVia.DisplayMember = "nom_tipovia"
        cbxCodigoVia.ValueMember = "idtipo_via"
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim controlador As New class_controller_via
        Dim datos As New class_datos_via
        Dim alta As Boolean = False
        pbId.Visible = False
        pbNom.Visible = False
        pbCodZona.Visible = False
        Select Case ""
            Case Trim(txtCodVia.Text)
                alta = True
                pbId.Visible = True
            Case Trim(cbxCodigoVia.Text)
                alta = True
                pbNom.Visible = True
            Case Trim(txtNomVia.Text)
                alta = True
                pbNom.Visible = True

        End Select
        If alta = True Then
            MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            datos.id_via = txtCodVia.Text
            datos.nombre_via = txtNomVia.Text
            datos.tipo_via = cbxCodigoVia.SelectedValue.ToString()
            If controlador.actualizarDatosVia(datos) Then
                MessageBox.Show("datos guardados")
                _DatasetZona.Reset()
                txtCodVia.Text = ""
                txtNomVia.Text = ""
            Else
                MessageBox.Show("datos no guardados")
            End If
        End If
    End Sub
End Class
