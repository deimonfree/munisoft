Public Class uc_rentas_vias2
    Dim estado_button_update As Integer = 0
    Dim estado_button_new As Integer = 0
    Dim idVia As Integer
    Private Sub uc_rentas_vias2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenado combox tipo de via
        _DatasetViaBox.Reset()
        consulta_datos_tipovia_combox_all()
        cbxTipoVia.DataSource = _DatasetViaBox.Tables("tipo_via")
        cbxTipoVia.DisplayMember = "nom_tipovia"
        cbxTipoVia.ValueMember = "idtipo_via"
        'llenado combox tipo de sector
        _DatasetSectorBox.Reset()
        combox_sector_all()
        cbxSector.DataSource = _DatasetSectorBox.Tables("sector")
        cbxSector.DisplayMember = "nombre"
        cbxSector.ValueMember = "idsector"
    End Sub


    Sub clear()
        txtid_via.Text = ""
        txtnom_via.Text = ""
        txtCuadra.Text = ""
        txtid_via.Select()
    End Sub
    Private Function alta() As Boolean
        Dim valor_alta As Boolean = False
        pbNombre.Visible = False
        pbCod.Visible = False
        pbTipoVia.Visible = False
        pbSector.Visible = False
        pbCuadra.Visible = False
        Select Case ""
            Case Trim(txtid_via.Text)
                valor_alta = True
                pbCod.Visible = True
            Case Trim(txtnom_via.Text)
                valor_alta = True
                pbNombre.Visible = True
            Case Trim(cbxTipoVia.Text)
                valor_alta = True
                pbTipoVia.Visible = True
            Case Trim(cbxSector.Text)
                valor_alta = True
                pbSector.Visible = True
            Case Trim(txtCuadra.Text)
                valor_alta = True
                pbCuadra.Visible = True
        End Select
        Return valor_alta
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sidePanel.Visible = True
        sidePanel.Width = btnSearch.Width
        sidePanel.Top = btnSearch.Bottom
        sidePanel.Location = btnSearch.Location
        lblInfo.Text = "Buscando Via"
        Dim formulario As New d_rentas_busqueda_sector
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            lblInfoFicha.Text = "Via encontrado!"
            idVia = formulario.valor_sector
            llamada_via(formulario.valor_sector)
        End If
    End Sub
    Private Sub llamada_via(valor As Integer)
        Dim datos_via As New class_datos_via
        cargar_datos_via(valor, datos_via)
        txtid_via.Text = datos_via.id_via
        txtnom_via.Text = datos_via.nombre_via
        txtCuadra.Text = datos_via.cuadra_via
        'lblCodigoFicha.Visible = True
        'lblCodigoFicha.Text = datos_via.id_sector
        'lblNomZonaFicha.Visible = True
        'lblNomZonaFicha.Text = datos_via.nombre_sector
        'cargar combox
        '_DatasetZonaBox.Reset()
        'consulta_datos_zona_combox(datos_via.codZona_sector)
        'cbxCodigoZona.DataSource = _DatasetZonaBox.Tables("zona")
        'cbxCodigoZona.DisplayMember = "nombre"
        'cbxCodigoZona.ValueMember = "idzona"
        'llenando combox
        ListarTipoVia(datos_via.tipo_via)
        ListarSector(datos_via.codSector_via)
    End Sub
    Private Sub ListarTipoVia(ByVal valor As Integer)
        mod_tipoVia._DatasetViaBox.Reset()
        consulta_datos_tipovia_combox(valor)
        cbxTipoVia.DataSource = mod_tipoVia._DatasetViaBox.Tables("tipo_via")
        cbxTipoVia.DisplayMember = "nom_tipovia"
        cbxTipoVia.ValueMember = "idtipo_via"
    End Sub
    Private Sub ListarSector(ByVal valor As Integer)
        _DatasetSectorBox.Reset()
        combox_sector_by(valor)
        cbxSector.DataSource = _DatasetSectorBox.Tables("sector")
        cbxSector.DisplayMember = "nombre"
        cbxSector.ValueMember = "idsector"
    End Sub

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
                Dim controller As New class_controller_via
                Dim datos As New class_datos_via
                datos.tipo_via = cbxTipoVia.SelectedValue.ToString()
                datos.nombre_via = txtnom_via.Text
                datos.codSector_via = cbxSector.SelectedValue.ToString()
                datos.cuadra_via = txtCuadra.Text
                If controller.insertarDatosVia(datos) Then
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
            lblInfo.Text = "Agregando Via ::"
            lblsubInfo.Text = "esta en la opcion de agregar::."
            txtid_via.Text = codigo_via()
            estado_button_new = 1
        End If
        If estado_button_new = 2 Then
            estado_button_new = 0
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        sidePanel.Visible = True
        sidePanel.Width = btnUpdate.Width
        sidePanel.Top = btnUpdate.Bottom
        sidePanel.Location = btnUpdate.Location
        If estado_button_update = 1 Then
            Dim controlador As New class_controller_via
            Dim datos As New class_datos_via
            If alta() = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                datos.id_via = txtid_via.Text
                datos.tipo_via = cbxTipoVia.SelectedValue.ToString()
                datos.nombre_via = txtnom_via.Text
                datos.codSector_via = cbxSector.SelectedValue.ToString()
                datos.cuadra_via = txtCuadra.Text
                If controlador.actualizarDatosVia(datos) Then
                    MessageBox.Show("datos guardados")
                    _DatasetZona.Reset()
                    clear()
                Else
                    MessageBox.Show("datos no guardados")
                End If
            End If

            estado_button_update = 2
        End If
        If estado_button_update = 0 Then
            lblInfo.Text = "Actualizando Zona"
            Dim formulario As New d_rentas_busqueda_via
            Dim datoRecuperado As DialogResult
            datoRecuperado = formulario.ShowDialog()
            If datoRecuperado = DialogResult.OK Then
                lblInfoFicha.Text = "Esta actualizando los datos de:"
                idVia = formulario.valor_via
                llamada_via(formulario.valor_via)
                estado_button_update = 1
            End If
        Else

        End If
        If estado_button_update = 2 Then
            estado_button_update = 0
        End If
    End Sub

    Private Sub cbxSector_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxSector.MouseClick
        _DatasetSectorBox.Reset()
        combox_sector_all()
        cbxSector.DataSource = _DatasetSectorBox.Tables("sector")
        cbxSector.DisplayMember = "nombre"
        cbxSector.ValueMember = "idsector"
    End Sub

    Private Sub cbxTipoVia_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxTipoVia.MouseClick
        _DatasetViaBox.Reset()
        consulta_datos_tipovia_combox_all()
        cbxTipoVia.DataSource = _DatasetViaBox.Tables("tipo_via")
        cbxTipoVia.DisplayMember = "nom_tipovia"
        cbxTipoVia.ValueMember = "idtipo_via"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        sidePanel.Visible = True
        sidePanel.Width = btnDelete.Width
        sidePanel.Top = btnDelete.Bottom
        sidePanel.Location = btnDelete.Location
    End Sub

    Private Sub cbxSector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSector.SelectedIndexChanged
        Try
            If tipo_sector(cbxSector.SelectedValue.ToString()) = 1 Then
                txtCuadra.Text = "1"
                txtCuadra.Enabled = False
            Else
                txtCuadra.Text = ""
                txtCuadra.Enabled = True

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
