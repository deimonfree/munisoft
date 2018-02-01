Public Class uc_rentas_sector_actualizar


    Private Sub btnlistarall_Click(sender As Object, e As EventArgs) Handles btnlistarall.Click
        _DatasetSector.Reset()
        consulta_datos_sector_all()
        dgwSector.DataSource = _dtwSector
    End Sub


    Private Sub ListarZona(ByVal valor As Integer)
        _DatasetZonaBox.Reset()
        consulta_datos_zona_combox(valor)
        cbxCodigoZona.DataSource = _DatasetZonaBox.Tables("zona")
        cbxCodigoZona.DisplayMember = "nombre"
        cbxCodigoZona.ValueMember = "idzona"
    End Sub


    Private Sub dgwSector_DoubleClick(sender As Object, e As EventArgs) Handles dgwSector.DoubleClick
        Try
            Dim v1 As Integer
            txtCodSector.Text = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(0).Value
            txtNomSector.Text = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(1).Value
            v1 = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(0).Value
            ListarZona(v1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxCodigoZona_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxCodigoZona.MouseClick
        _DatasetZonaBox.Reset()
        consulta_datos_zona_combox_all()
        cbxCodigoZona.DataSource = _DatasetZonaBox.Tables("zona")
        cbxCodigoZona.DisplayMember = "nombre"
        cbxCodigoZona.ValueMember = "idzona"
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim controlador As New class_controller_sector
        Dim datos As New class_datos_sector
        Dim alta As Boolean = False
        pbId.Visible = False
        pbNom.Visible = False
        pbCodZona.Visible = False
        Select Case ""
            Case Trim(txtCodSector.Text)
                alta = True
                pbId.Visible = True
            Case Trim(cbxCodigoZona.Text)
                alta = True
                pbNom.Visible = True
            Case Trim(txtCodSector.Text)
                alta = True
                pbNom.Visible = True

        End Select
        If alta = True Then
            MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            datos.id_sector = txtCodSector.Text
            datos.nombre_sector = txtNomSector.Text
            datos.codZona_sector = cbxCodigoZona.SelectedValue.ToString()
            If controlador.actualizarDatosZona(datos) Then
                MessageBox.Show("datos guardados")
                _DatasetZona.Reset()
                txtNomSector.Text = ""
                txtCodSector.Text = ""
            Else
                MessageBox.Show("datos no guardados")
            End If
        End If
    End Sub



End Class
