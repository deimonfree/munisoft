Public Class uc_rentas_sectores
    Dim estado_button_update As Integer = 0
    Dim estado_button_new As Integer = 0
    Dim idSector As Integer
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        sidePanel.Visible = True
        sidePanel.Width = btnSave.Width
        sidePanel.Top = btnSave.Bottom
        sidePanel.Location = btnSave.Location
        If estado_button_new = 1 Then
            If alta() = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 001",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                estado_button_new = 1
            Else
                Dim controller As New class_controller_sector
                Dim datos As New class_datos_sector
                datos.id_sector = txtid_sector.Text
                datos.nombre_sector = txtnom_sector.Text
                datos.codZona_sector = cbxCodigoZona.SelectedValue.ToString()
                If controller.insertarDatosSector(datos) Then
                    MessageBox.Show("datos guarados")
                    clear()
                    estado_button_new = 2
                    sidePanel.Visible = False
                Else
                    MessageBox.Show("datos no guarados")
                    estado_button_new = 1
                End If

            End If


        End If
        If estado_button_new = 0 Then
            lblInfo.Text = "Agregando sector ::"
            lblsubInfo.Text = "esta en la opcion de agregar::."
            If codigo_sector() = 0 Then
                txtid_sector.Text = codigo_sector() + 1
            Else
                txtid_sector.Text = codigo_sector()
            End If
            estado_button_new = 1
        End If
        If estado_button_new = 2 Then
            estado_button_new = 0
        End If

    End Sub
    Private Function alta() As Boolean
        Dim valor_alta As Boolean = False
        pbNombre.Visible = False
        pbCod.Visible = False
        pbZona.Visible = False
        Select Case ""
            Case Trim(txtid_sector.Text)
                valor_alta = True
                pbCod.Visible = True
            Case Trim(txtnom_sector.Text)
                valor_alta = True
                pbNombre.Visible = True
            Case Trim(cbxCodigoZona.Text)
                valor_alta = True
                pbZona.Visible = True
        End Select
        Return valor_alta
    End Function


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        sidePanel.Visible = True
        sidePanel.Width = btnDelete.Width
        sidePanel.Top = btnDelete.Bottom
        sidePanel.Location = btnDelete.Location
    End Sub

    Private Sub uc_rentas_sectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetZonaBox.Reset()
        consulta_datos_zona_combox_all()
        cbxCodigoZona.DataSource = _DatasetZonaBox.Tables("zona")
        cbxCodigoZona.DisplayMember = "nombre"
        cbxCodigoZona.ValueMember = "idzona"
    End Sub

    Private Sub cbxCodigoZona_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxCodigoZona.MouseClick
        _DatasetZonaBox.Reset()
        consulta_datos_zona_combox_all()
        cbxCodigoZona.DataSource = _DatasetZonaBox.Tables("zona")
        cbxCodigoZona.DisplayMember = "nombre"
        cbxCodigoZona.ValueMember = "idzona"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        sidePanel.Visible = True
        sidePanel.Width = btnUpdate.Width
        sidePanel.Top = btnUpdate.Bottom
        sidePanel.Location = btnUpdate.Location
        If estado_button_update = 1 Then
            Dim controlador As New class_controller_sector
            Dim datos As New class_datos_sector
            If alta() = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                datos.id_sector = txtid_sector.Text
                datos.nombre_sector = txtnom_sector.Text
                datos.codZona_sector = cbxCodigoZona.SelectedValue.ToString()
                If controlador.actualizarDatosZona(datos) Then
                    MessageBox.Show("datos Actualizados")
                    _DatasetZona.Reset()
                    clear()
                    sidePanel.Visible = False
                Else
                    MessageBox.Show("datos no Actualizados")
                End If
            End If

            estado_button_update = 2
        End If
        If estado_button_update = 0 Then
            lblInfo.Text = "actualizando sector ::"
            lblsubInfo.Text = "esta en la opcion de actualizar::."
            Dim formulario As New d_rentas_busqueda_sector
            Dim datoRecuperado As DialogResult
            datoRecuperado = formulario.ShowDialog()
            If datoRecuperado = DialogResult.OK Then
                lblInfoFicha.Text = "Esta actualizando los datos de:"
                idSector = formulario.valor_sector
                llamada_sector(formulario.valor_sector)
                estado_button_update = 1
            End If
        Else

        End If
        If estado_button_update = 2 Then
            estado_button_update = 0
        End If
    End Sub
    Sub clear()
        txtid_sector.Text = ""
        txtnom_sector.Text = ""
        txtid_sector.Select()
    End Sub
    Private Sub llamada_sector(valor As Integer)
        Dim datos_sector As New class_datos_sector
        cargar_datos_sector(valor, datos_sector)
        txtid_sector.Text = datos_sector.id_sector
        txtnom_sector.Text = datos_sector.nombre_sector
        lblCodigoFicha.Visible = True
        lblCodigoFicha.Text = datos_sector.id_sector
        lblNomZonaFicha.Visible = True
        lblNomZonaFicha.Text = datos_sector.nombre_sector
        'cargar combox
        _DatasetZonaBox.Reset()
        consulta_datos_zona_combox(datos_sector.codZona_sector)
        cbxCodigoZona.DataSource = _DatasetZonaBox.Tables("zona")
        cbxCodigoZona.DisplayMember = "nombre"
        cbxCodigoZona.ValueMember = "idzona"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sidePanel.Visible = True
        sidePanel.Width = btnSearch.Width
        sidePanel.Top = btnSearch.Bottom
        sidePanel.Location = btnSearch.Location
    End Sub
End Class
