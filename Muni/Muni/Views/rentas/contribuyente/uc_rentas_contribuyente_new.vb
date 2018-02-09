Public Class uc_rentas_contribuyente_new

    Dim estado_button_update As Integer = 0
    Dim Valor_Distrito As Integer
    Dim Valor_provincia As Integer
    Dim Valor_Departamento As Integer
    Dim valor_IdDireccion As Integer
    Dim IdContibuyente As Integer
    Dim IdDireccion As Integer
    Dim IdRepreLegal As Integer
    Dim datosDistrito As New class_datos_distrito
    Dim datosProvincia As New class_datos_provincia
    Dim datosDepartamento As New class_datos_departamento
    Dim estado_button As Integer = 0
    Dim IdSociedadConyugal As Integer
    Dim numero_dni As String

    Private Sub uc_rentas_contribuyente_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'deacbihiltando conbox
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox1.Enabled = False
        'llenado combox tipo de documento
        _DatasetTipodocumentoBox.Reset()
        consulta_datos_tipoDocumento_combox_all()
        cbxtipoDocumento.DataSource = _DatasetTipodocumentoBox.Tables("tipo_doc")
        cbxtipoDocumento.DisplayMember = "descripcion_corta"
        cbxtipoDocumento.ValueMember = "idtipo_doc"
        'llenado combox tipo de via
        mod_tipoVia._DatasetViaBox.Reset()
        consulta_datos_tipovia_combox_all()
        cbxtipoVia.DataSource = mod_tipoVia._DatasetViaBox.Tables("tipo_via")
        cbxtipoVia.DisplayMember = "nom_tipovia"
        cbxtipoVia.ValueMember = "idtipo_via"
        'llenado combox tipo de relacion
        _DatasetTiporelacionBox.Reset()
        consulta_datos_tipoRelacion_combox_all()
        cbxtipoRelacion.DataSource = _DatasetTiporelacionBox.Tables("tipo_relacion")
        cbxtipoRelacion.DisplayMember = "denominacion"
        cbxtipoRelacion.ValueMember = "idtipo_relacion"
        'llenado combox tipo de urbanizacion
        _DatasetTipoUrbanizacionBox.Reset()
        consulta_datos_tipoUrbanizacion_combox_all()
        cbxTipoUrb.DataSource = _DatasetTipoUrbanizacionBox.Tables("tipo_urbanizacion")
        cbxTipoUrb.DisplayMember = "denominacion"
        cbxTipoUrb.ValueMember = "idtipo_urbanizacion"
        'cambiar label
        lblInfo.Text = "Pulse cualquiera de los botones para tabajar"
        lblsubinfo.Text = "Para mayon información visite: www.munisoft.com"


    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        sidePanel.Width = btnSave.Width
        sidePanel.Top = btnSave.Bottom
        sidePanel.Location = btnSave.Location
        '/**************************************/
        activar_paneles()
        clean()
        btnOption.Text = "Guardar Predio"
        btnOption.Image = My.Resources.save
        btnOption.BackColor = Color.FromArgb(150, 193, 31)
        btnOption.Enabled = True
        estado_button = 2
        lblInfo.Text = "Agregando un nuevo predio"
        lblsubinfo.Text = "Rellene los datos correspondientes para agregar un nuevo predio"
        pbload.Visible = True
    End Sub
    Private Sub direccion(ByVal valor As Integer)
        txtDist.Text = valor
    End Sub
    Private Sub GetDataDistrito(ByVal dato As Integer)
        Distrito_By(datosDistrito, dato)
        txtDist.Text = datosDistrito.nombre_distrito
        Valor_Distrito = datosDistrito.id_distrito
    End Sub
    Private Sub getDataProvincia(ByVal dato As Integer)
        Provincia_By(datosProvincia, dato)
        txtProv.Text = datosProvincia.nombre_provincia
        Valor_Departamento = datosProvincia.cod_departamento
    End Sub
    Private Sub getDataDepartamento(ByVal dato As Integer)
        Departamento_By(datosDepartamento, dato)
        txtDep.Text = datosDepartamento.nombre_departamento
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'colocando button
        sidePanel.Width = btnUpdate.Width
        sidePanel.Top = btnUpdate.Bottom
        sidePanel.Location = btnUpdate.Location
        activar_paneles()
        '/*****************************************/
        If estado_button_update = 0 Then
            lblInfo.Text = "Actualizando Datos de Contribuyente"
            lblInfoFicha.Text = "Se esta actualizando los Datos de::"
            Dim formulario2 As New d_rentas_contribuyente_update
            Dim datoRecuperado As DialogResult
            datoRecuperado = formulario2.ShowDialog()
            If datoRecuperado = DialogResult.OK Then
                numero_dni = ""
                estado_button = 3
                btnOption.Enabled = True
                btnOption.Image = My.Resources.update_white
                btnOption.Text = "Actualizar Datos"
                btnOption.BackColor = Color.FromArgb(150, 193, 31)
                IdContibuyente = formulario2.valor_contribuyente
                llamada_contribuyente(formulario2.valor_contribuyente)
                llamada_direccion_contribuyente(valor_IdDireccion)
                llamada_repreLegal_contribuyente(valor_IdDireccion)
                llamada_sociedadConyugal(IdContibuyente)
            Else
                btnOption.Enabled = False
                btnOption.Text = "Actividad no Genarada"
                estado_button = 0
            End If
        Else
        End If
    End Sub

    Private Sub llamada_contribuyente(valor As Integer)
        Dim datos_contribuyente As New class_datos_contribuyente
        chkDatosPersonales.Checked = True
        chkDatosEmpresariales.Checked = True
        cargar_datos_contribuyente(valor, datos_contribuyente)
        'llenado segun buton
        If estado_button = 3 Then
            IdContibuyente = valor
            txtNombre.Text = datos_contribuyente.nombres_cont
            txtApe_pat.Text = datos_contribuyente.apellido_paterno_cont
            txtApe_mat.Text = datos_contribuyente.apellido_materno_cont
            ListarTipoDoc(datos_contribuyente.cod_tipo_doc)
            txtnumeroDoc.Text = datos_contribuyente.numero_doc_cont
            txtNumTelf.Text = datos_contribuyente.telefono_cont
            txtNumCel.Text = datos_contribuyente.celular_cont
            txtEmail.Text = datos_contribuyente.email_contn
            txtNombres_conyuge.Text = datos_contribuyente.cont_relacion_cont
            txtObsv.Text = datos_contribuyente.observacion_cont
            txtNumRuc.Text = datos_contribuyente.ruc_cont
            txtRazonsocial.Text = datos_contribuyente.razonSocial_cont
            ListarUrbanizacion(datos_contribuyente.cod_urbanizacion_cont)
            ListarTipoRelacion(datos_contribuyente.cod_relacion_cont)
            valor_IdDireccion = datos_contribuyente.id_contribuyente
            If Trim(datos_contribuyente.nombres_cont) = "" Or Trim(datos_contribuyente.nombres_cont) = "--" Then
                lblCodigoContri.Text = valor
                lblContri.Text = datos_contribuyente.ruc_cont & " :: " & datos_contribuyente.razonSocial_cont
            Else

                lblCodigoContri.Text = valor
                lblContri.Text = datos_contribuyente.numero_doc_cont & " :: " & datos_contribuyente.apellido_paterno_cont & " " & datos_contribuyente.apellido_materno_cont & " " & datos_contribuyente.nombres_cont

            End If
            numero_dni = txtnumeroDoc.Text
        End If
        If estado_button = 4 Then
            If Trim(datos_contribuyente.nombres_cont) = "" Or Trim(datos_contribuyente.nombres_cont) = "--" Then
                lblCodigoContri.Text = valor
                lblContri.Text = datos_contribuyente.ruc_cont & " :: " & datos_contribuyente.razonSocial_cont
            Else

                lblCodigoContri.Text = valor
                lblContri.Text = datos_contribuyente.numero_doc_cont & " :: " & datos_contribuyente.apellido_paterno_cont & " " & datos_contribuyente.apellido_materno_cont & " " & datos_contribuyente.nombres_cont

            End If
        End If
    End Sub
    Private Sub llamada_direccion_contribuyente(valor As Integer)
        Dim datos_direccion_contribuyente As New class_datos_direccion
        cargar_datos_direcContribuyente(valor, datos_direccion_contribuyente)
        IdDireccion = datos_direccion_contribuyente.id_direccion
        txtNomSector.Text = datos_direccion_contribuyente.sector_direccion
        txtMnza.Text = datos_direccion_contribuyente.mzna_direccion
        txtNomVia.Text = datos_direccion_contribuyente.via_direccion
        txtLote.Text = datos_direccion_contribuyente.lote_direccion
        txtNumeroVia.Text = datos_direccion_contribuyente.numero_direccion
        txtNom_Dep.Text = datos_direccion_contribuyente.departamento_direccion
        txtNumeroPiso.Text = datos_direccion_contribuyente.piso_direccion
        'llenando combox
        ListarTipoVia(datos_direccion_contribuyente.codTipoVia_direccion)
        'llenado direccion zonal
        GetDataDistrito(datos_direccion_contribuyente.codDistrito_direccion)
        Valor_provincia = datosDistrito.cod_provincia
        getDataProvincia(Valor_provincia)
        Valor_Departamento = datosProvincia.cod_departamento
        getDataDepartamento(Valor_Departamento)
        'llenado info ficha 
        If Trim(datos_direccion_contribuyente.numero_direccion) = "" Or Trim(datos_direccion_contribuyente.numero_direccion) = "--" Then
            lblDirecContri.Text = datos_direccion_contribuyente.via_direccion & " NRO. " & datos_direccion_contribuyente.numero_direccion
        Else
            lblDirecContri.Text = datos_direccion_contribuyente.via_direccion & " NRO. " & datos_direccion_contribuyente.numero_direccion
        End If

    End Sub
    Private Sub llamada_repreLegal_contribuyente(valor As Integer)
        Dim datos_repreLegal_contribuyente As New class_datos_representanteLegal
        cargar_datos_RepreLegalContribuyente(valor, datos_repreLegal_contribuyente)
        IdRepreLegal = datos_repreLegal_contribuyente.id_representanteLegal
        If Trim(IdRepreLegal) <> 0 Then
            chkReprelegal.Checked = True
            MessageBox.Show(IdRepreLegal)
        Else
            chkReprelegal.Checked = False
        End If
        txtNom_rl.Text = datos_repreLegal_contribuyente.nombre_representanteLegal
        txtApepat_rl.Text = datos_repreLegal_contribuyente.apePat_representanteLegal
        txtApemat_rl.Text = datos_repreLegal_contribuyente.apeMat_representanteLegal
        txtNumDoc_rl.Text = datos_repreLegal_contribuyente.numeroDoc_representanteLegal
        txtNomvia_rl.Text = datos_repreLegal_contribuyente.nomVia_representanteLegal
        txtNumero_rl.Text = datos_repreLegal_contribuyente.numero_representanteLegal
        txtMzna_rl.Text = datos_repreLegal_contribuyente.manzana_representanteLegal
        txtLote_rl.Text = datos_repreLegal_contribuyente.lote_representanteLegal
        txtApart_rl.Text = datos_repreLegal_contribuyente.nomApart_representanteLegal
        txtNumApart_rl.Text = datos_repreLegal_contribuyente.numApart_representanteLegal
        txtUrba_rl.Text = datos_repreLegal_contribuyente.nomUrbanizacion_representanteLegal
        txtCargo_rl.Text = datos_repreLegal_contribuyente.cargo_representanteLegal
        txtTelf_rl.Text = datos_repreLegal_contribuyente.telefono_representanteLegal
        ''llenando identificaion
        ListarTipoDoc2(datos_repreLegal_contribuyente.codidentificacion_representanteLegal)
        ''llenado via
        ListarTipoVia2(datos_repreLegal_contribuyente.codVia_representanteLegal)
        ''llenado urbanizacion
        ListarUrbanizacion2(datos_repreLegal_contribuyente.codUrbanizacion_representanteLegal)
    End Sub
    Private Sub llamada_sociedadConyugal(valor As Integer)
        Dim datos_sociedadConyugal As New class_datos_sociedadConyugal
        cargar_datos_sociedadConyugal(valor, datos_sociedadConyugal)
        IdSociedadConyugal = datos_sociedadConyugal.id_sociedadConyugal
        If IdSociedadConyugal > 0 Then
            txtIden_conyuge.Text = datos_sociedadConyugal.numIdentificacion_sociedadConyugal
        End If
    End Sub
    Private Sub ListarTipoDoc(ByVal valor As Integer)
        _DatasetTipodocumentoBox.Reset()
        consulta_datos_tipoDocumento_combox(valor)
        cbxtipoDocumento.DataSource = _DatasetTipodocumentoBox.Tables("tipo_doc")
        cbxtipoDocumento.DisplayMember = "descripcion_corta"
        cbxtipoDocumento.ValueMember = "idtipo_doc"
    End Sub
    Private Sub ListarUrbanizacion(ByVal valor As Integer)
        _DatasetTipoUrbanizacionBox.Reset()
        consulta_datos_tipoUrbanizacion_combox_by(valor)
        cbxTipoUrb.DataSource = _DatasetTipoUrbanizacionBox.Tables("tipo_urbanizacion")
        cbxTipoUrb.DisplayMember = "denominacion"
        cbxTipoUrb.ValueMember = "idtipo_urbanizacion"
    End Sub
    Private Sub ListarTipoRelacion(ByVal valor As Integer)
        _DatasetTiporelacionBox.Reset()
        consulta_datos_tipoRelacion_combox(valor)
        cbxtipoRelacion.DataSource = _DatasetTiporelacionBox.Tables("tipo_relacion")
        cbxtipoRelacion.DisplayMember = "denominacion"
        cbxtipoRelacion.ValueMember = "idtipo_relacion"
    End Sub
    Private Sub ListarTipoVia(ByVal valor As Integer)
        mod_tipoVia._DatasetViaBox.Reset()
        consulta_datos_tipovia_combox(valor)
        cbxtipoVia.DataSource = mod_tipoVia._DatasetViaBox.Tables("tipo_via")
        cbxtipoVia.DisplayMember = "nom_tipovia"
        cbxtipoVia.ValueMember = "idtipo_via"
    End Sub
    Private Sub cbxtipoRelacion_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxtipoRelacion.MouseClick
        _DatasetTiporelacionBox.Reset()
        consulta_datos_tipoRelacion_combox_all()
        cbxtipoRelacion.DataSource = _DatasetTiporelacionBox.Tables("tipo_relacion")
        cbxtipoRelacion.DisplayMember = "denominacion"
        cbxtipoRelacion.ValueMember = "idtipo_relacion"
    End Sub
    Private Sub cbxtipoDocumento_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxtipoDocumento.MouseClick
        _DatasetTipodocumentoBox.Reset()
        consulta_datos_tipoDocumento_combox_all()
        cbxtipoDocumento.DataSource = _DatasetTipodocumentoBox.Tables("tipo_doc")
        cbxtipoDocumento.DisplayMember = "descripcion_corta"
        cbxtipoDocumento.ValueMember = "idtipo_doc"
    End Sub
    Private Sub cbxTipoUrb_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxTipoUrb.MouseClick
        _DatasetTipoUrbanizacionBox.Reset()
        consulta_datos_tipoUrbanizacion_combox_all()
        cbxTipoUrb.DataSource = _DatasetTipoUrbanizacionBox.Tables("tipo_urbanizacion")
        cbxTipoUrb.DisplayMember = "denominacion"
        cbxTipoUrb.ValueMember = "idtipo_urbanizacion"
    End Sub
    Private Sub cbxtipoVia_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxtipoVia.MouseClick
        mod_tipoVia._DatasetViaBox.Reset()
        consulta_datos_tipovia_combox_all()
        cbxtipoVia.DataSource = mod_tipoVia._DatasetViaBox.Tables("tipo_via")
        cbxtipoVia.DisplayMember = "nom_tipovia"
        cbxtipoVia.ValueMember = "idtipo_via"
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim conexion_contribuyente As New class_controller_contribuyente
        Dim datos_contribuyente As New class_datos_contribuyente
        datos_contribuyente.id_contribuyente = IdContibuyente
        datos_contribuyente.nombres_cont = txtNombre.Text
        datos_contribuyente.apellido_paterno_cont = txtApe_pat.Text
        datos_contribuyente.apellido_materno_cont = txtApe_mat.Text
        datos_contribuyente.cod_tipo_doc = cbxtipoDocumento.SelectedValue.ToString()
        datos_contribuyente.numero_doc_cont = txtnumeroDoc.Text
        datos_contribuyente.telefono_cont = txtNumTelf.Text
        datos_contribuyente.celular_cont = txtNumCel.Text
        datos_contribuyente.email_contn = txtEmail.Text
        datos_contribuyente.cont_relacion_cont = txtNombres_conyuge.Text
        datos_contribuyente.observacion_cont = txtObsv.Text
        datos_contribuyente.cod_urbanizacion_cont = cbxTipoUrb.SelectedValue.ToString()
        datos_contribuyente.cod_relacion_cont = cbxtipoRelacion.SelectedValue.ToString()
        If conexion_contribuyente.actualizarDatoContribuyente(datos_contribuyente) Then
            MessageBox.Show("datos guardados")
            'Clean()
        Else
            MessageBox.Show("datos no guardados")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'colocando button
        sidePanel.Visible = True
        sidePanel.Width = btnDelete.Width
        sidePanel.Top = btnDelete.Bottom
        sidePanel.Location = btnDelete.Location
        '//////////////////
        clean()
        desactivar_paneles()
        lblInfo.Text = "Eliminando Contribuyente"
        Dim formulario2 As New d_rentas_contribuyente_update
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            estado_button = 4
            IdContibuyente = formulario2.valor_contribuyente
            llamada_contribuyente(formulario2.valor_contribuyente)
            llamada_direccion_contribuyente(valor_IdDireccion)
            llamada_repreLegal_contribuyente(valor_IdDireccion)
            btnOption.Image = My.Resources.file_delete
            btnOption.Enabled = True
            btnOption.Text = "Eliminar Contribuyente"
            btnOption.BackColor = Color.FromArgb(255, 140, 1)
            lblInfoFicha.Text = "Ud. Eliminara al Contribuyente ::"
        Else
            btnOption.Enabled = False
            btnOption.Text = "Bloqueado"
            estado_button = 0

        End If

    End Sub

    Private Sub btnShared_Click(sender As Object, e As EventArgs) Handles btnShared.Click
        'colocando button
        sidePanel.Width = btnShared.Width
        sidePanel.Top = btnShared.Bottom
        sidePanel.Location = btnShared.Location
        clean()
        desactivar_paneles()
        limpiar_infoPanel()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkReprelegal.CheckedChanged
        If Not chkReprelegal.Checked Then
            GroupBox1.Enabled = False
            txtNom_rl.Text = ""
            txtApepat_rl.Text = ""
            txtApemat_rl.Text = ""
            txtNumero_rl.Text = ""
            txtNumDoc_rl.Text = ""
            txtNomvia_rl.Text = ""
            txtMzna_rl.Text = ""
            txtLote_rl.Text = ""
            txtApart_rl.Text = ""
            txtNumApart_rl.Text = ""

        Else
            GroupBox1.Enabled = True
            'llenado combox tipo de documento
            _DatasetTipodocumentoBox2.Reset()
            consulta_datos_tipoDocumento_combox_all2()
            cbTipoDoc_rl.DataSource = _DatasetTipodocumentoBox2.Tables("tipo_doc")
            cbTipoDoc_rl.DisplayMember = "descripcion_corta"
            cbTipoDoc_rl.ValueMember = "idtipo_doc"
            'llenado combox tipo de via
            mod_tipoVia._DatasetViaBox2.Reset()
            consulta_datos_tipovia_combox_all2()
            cbtipoVia_rl.DataSource = mod_tipoVia._DatasetViaBox2.Tables("tipo_via")
            cbtipoVia_rl.DisplayMember = "nom_tipovia"
            cbtipoVia_rl.ValueMember = "idtipo_via"
            'llenado combox tipo de urbanizacion
            _DatasetTipoUrbanizacionBox2.Reset()
            consulta_datos_tipoUrbanizacion_combox_all2()
            cbUrba_rl.DataSource = _DatasetTipoUrbanizacionBox2.Tables("tipo_urbanizacion")
            cbUrba_rl.DisplayMember = "denominacion"
            cbUrba_rl.ValueMember = "idtipo_urbanizacion"

        End If
    End Sub
    Private Sub cbTipoDoc_rl_MouseClick(sender As Object, e As MouseEventArgs) Handles cbTipoDoc_rl.MouseClick
        _DatasetTipodocumentoBox2.Reset()
        consulta_datos_tipoDocumento_combox_all2()
        cbTipoDoc_rl.DataSource = _DatasetTipodocumentoBox2.Tables("tipo_doc")
        cbTipoDoc_rl.DisplayMember = "descripcion_corta"
        cbTipoDoc_rl.ValueMember = "idtipo_doc"
    End Sub

    Private Sub cbtipoVia_rl_MouseClick(sender As Object, e As MouseEventArgs) Handles cbtipoVia_rl.MouseClick
        mod_tipoVia._DatasetViaBox2.Reset()
        consulta_datos_tipovia_combox_all2()
        cbtipoVia_rl.DataSource = mod_tipoVia._DatasetViaBox2.Tables("tipo_via")
        cbtipoVia_rl.DisplayMember = "nom_tipovia"
        cbtipoVia_rl.ValueMember = "idtipo_via"
    End Sub
    Private Sub cbUrba_rl_MouseClick(sender As Object, e As MouseEventArgs) Handles cbUrba_rl.MouseClick
        _DatasetTipoUrbanizacionBox2.Reset()
        consulta_datos_tipoUrbanizacion_combox_all2()
        cbUrba_rl.DataSource = _DatasetTipoUrbanizacionBox2.Tables("tipo_urbanizacion")
        cbUrba_rl.DisplayMember = "denominacion"
        cbUrba_rl.ValueMember = "idtipo_urbanizacion"
    End Sub

    Private Sub btnBuscarCiudad_Click(sender As Object, e As EventArgs) Handles btnBuscarCiudad.Click
        Dim formulario As New d_rentas_distrito_busqueda
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            GetDataDistrito(formulario.valor_dist)
            Valor_provincia = datosDistrito.cod_provincia
            getDataProvincia(Valor_provincia)
            Valor_Departamento = datosProvincia.cod_departamento
            getDataDepartamento(Valor_Departamento)
        End If
    End Sub

    Private Sub cbxtipoRelacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxtipoRelacion.SelectedIndexChanged
        Try
            If cbxtipoRelacion.SelectedValue.ToString() = 2 Then
                btnBusqueda_conyuge.Enabled = True
                lblInfoConyuge.Visible = True
                lblInfoConyuge.Text = "busque al conyugue..."
                txtIden_conyuge.Enabled = True
                txtNombres_conyuge.Enabled = True
            Else
                lblInfoConyuge.Text = "--"
                btnBusqueda_conyuge.Enabled = False
                txtIden_conyuge.Enabled = False
                txtNombres_conyuge.Enabled = False
                txtNombres_conyuge.Text = "--"
                txtIden_conyuge.Text = "--"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkDatosPersonales.CheckedChanged
        If Not chkDatosPersonales.Checked Then
            GroupBox3.Enabled = False
            txtNombre.Text = "--"
            txtApe_pat.Text = "--"
            txtApe_mat.Text = "--"
            txtnumeroDoc.Text = "--"

        Else
            GroupBox3.Enabled = True
            txtNombre.Text = ""
            txtApe_pat.Text = ""
            txtApe_mat.Text = ""
            txtnumeroDoc.Text = ""
            txtNombre.Select()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkDatosEmpresariales.CheckedChanged
        If Not chkDatosEmpresariales.Checked Then
            GroupBox2.Enabled = False
            txtNumRuc.Text = "--"
            txtRazonsocial.Text = "--"
        Else
            GroupBox2.Enabled = True
            txtNumRuc.Text = ""
            txtRazonsocial.Text = ""
            txtNumRuc.Select()
            chkReprelegal.Checked = True
        End If
    End Sub
    Private Sub ListarTipoDoc2(ByVal valor As Integer)
        _DatasetTipodocumentoBox2.Reset()
        consulta_datos_tipoDocumento_combox2(valor)
        cbTipoDoc_rl.DataSource = _DatasetTipodocumentoBox2.Tables("tipo_doc")
        cbTipoDoc_rl.DisplayMember = "descripcion_corta"
        cbTipoDoc_rl.ValueMember = "idtipo_doc"
    End Sub
    Private Sub ListarUrbanizacion2(ByVal valor As Integer)
        _DatasetTipoUrbanizacionBox2.Reset()
        consulta_datos_tipoUrbanizacion_combox_by2(valor)
        cbUrba_rl.DataSource = _DatasetTipoUrbanizacionBox2.Tables("tipo_urbanizacion")
        cbUrba_rl.DisplayMember = "denominacion"
        cbUrba_rl.ValueMember = "idtipo_urbanizacion"
    End Sub
    Private Sub ListarTipoVia2(ByVal valor As Integer)
        mod_tipoVia._DatasetViaBox2.Reset()
        consulta_datos_tipovia_combox2(valor)
        cbtipoVia_rl.DataSource = mod_tipoVia._DatasetViaBox2.Tables("tipo_via")
        cbtipoVia_rl.DisplayMember = "nom_tipovia"
        cbtipoVia_rl.ValueMember = "idtipo_via"
    End Sub
    Private Function alta2() As Boolean
        Dim valor_alta As Boolean = False
        Panel2.BackColor = Color.FromArgb(35, 148, 188)
        pbnombre.Visible = False
        pbapepaT.Visible = False
        Pbapemat.Visible = False
        pbNumeroDoc.Visible = False
        pbVia.Visible = False
        pbMzna.Visible = False
        pbSector.Visible = False
        pbDistrito.Visible = False
        pbDepartamento.Visible = False
        pbprovincia.Visible = False
        pbEmail.Visible = False
        pbNumTelf.Visible = False
        pbNumCel.Visible = False
        PbTipoRelacion.Visible = False
        pbConyuge.Visible = False
        pbObsrv.Visible = False
        pbRUC.Visible = False
        PBRazonSocial.Visible = False
        pbNomRL.Visible = False
        pbApePatRL.Visible = False
        pbApMatRL.Visible = False
        pbDocRL.Visible = False
        pbViaRL.Visible = False
        pbNumRL.Visible = False
        pbMznaRL.Visible = False
        pbLoteRL.Visible = False
        pbUrbRL.Visible = False
        pbCargoRL.Visible = False
        lblInfoVia.Visible = False
        'comprovacion de datos personales
        If chkDatosPersonales.Checked Then
            If cbxtipoDocumento.Text <> "ruc" Then
                Select Case ""
                    Case Trim(txtNombre.Text)
                        valor_alta = True
                        pbnombre.Visible = True
                    Case Trim(txtApe_pat.Text)
                        valor_alta = True
                        pbapepaT.Visible = True
                    Case Trim(txtApe_mat.Text)
                        valor_alta = True
                        Pbapemat.Visible = True
                    Case Trim(cbxtipoDocumento.Text)
                        valor_alta = True
                        pbNumeroDoc.Visible = True
                    Case Trim(txtnumeroDoc.Text)
                        valor_alta = True
                        pbNumeroDoc.Visible = True
                End Select
            End If

        Else
            txtNombre.Text = "--"
            txtApe_pat.Text = "--"
            txtApe_mat.Text = "--"
            txtnumeroDoc.Text = "--"
            valor_alta = False
        End If
        If chkDatosEmpresariales.Checked Then
            Select Case ""
                Case Trim(txtNumRuc.Text)
                    valor_alta = True
                    pbRUC.Visible = True
                Case Trim(txtRazonsocial.Text)
                    valor_alta = True
                    PBRazonSocial.Visible = True
            End Select
        Else
            txtNumRuc.Text = "--"
            txtRazonsocial.Text = "--"
            valor_alta = False
        End If
        If chkDatosPersonales.Checked Or chkDatosEmpresariales.Checked Then
            valor_alta = False
        Else
            Panel2.BackColor = Color.FromArgb(255, 140, 1)
            valor_alta = True
        End If
        'comprobacion de direccion
        If Trim(txtNumeroVia.Text) = "" Then
            Select Case ""
                Case Trim(txtMnza.Text)
                    valor_alta = True
                    pbMzna.Visible = True
                    lblInfoVia.Visible = True
                Case Trim(txtLote.Text)
                    valor_alta = True
                    pbMzna.Visible = True
                    lblInfoVia.Visible = True
            End Select
        Else
            valor_alta = False
        End If
        Select Case ""
            Case Trim(txtNomVia.Text)
                valor_alta = True
                pbVia.Visible = True
            Case Trim(cbxtipoVia.Text)
                valor_alta = True
                pbVia.Visible = True
            Case Trim(txtNomSector.Text)
                valor_alta = True
                pbSector.Visible = True
            Case Trim(txtDist.Text)
                valor_alta = True
                pbDistrito.Visible = True
        End Select
        If Trim(txtNom_Dep.Text) = "" Then
            txtNom_Dep.Text = "--"
        End If
        If Trim(txtNumeroPiso.Text) = "" Then
            txtNumeroPiso.Text = "--"
        End If
        If Trim(txtEmail.Text) = "" Then
            txtEmail.Text = "--"
        End If
        If Trim(txtNumTelf.Text) = "" Then
            txtNumTelf.Text = "--"
        End If
        If Trim(txtNumCel.Text) = "" Then
            txtNumCel.Text = "--"
        End If
        If Trim(txtObsv.Text) = "" Then
            txtObsv.Text = "ninguna"
        End If
        'comprovacion de representante legal
        If chkReprelegal.Checked Then
            Select Case ""
                Case Trim(txtNom_rl.Text)
                    valor_alta = True
                    pbNomRL.Visible = True
                Case Trim(txtApepat_rl.Text)
                    valor_alta = True
                    pbApePatRL.Visible = True
                Case Trim(txtApemat_rl.Text)
                    valor_alta = True
                    pbApMatRL.Visible = True
                Case Trim(txtNumDoc_rl.Text)
                    valor_alta = True
                    pbDocRL.Visible = True
                Case Trim(txtNomvia_rl.Text)
                    valor_alta = True
                    pbViaRL.Visible = True
                Case Trim(txtUrba_rl.Text)
                    valor_alta = True
                    pbUrbRL.Visible = True
                Case Trim(txtCargo_rl.Text)
                    valor_alta = True
                    pbCargoRL.Visible = True
            End Select
            If Trim(txtApart_rl.Text) = "" Then
                txtApart_rl.Text = "--"
            End If
            If Trim(txtNumApart_rl.Text) = "" Then
                txtNumApart_rl.Text = "--"
            End If
            If Trim(txtTelf_rl.Text) = "" Then
                txtTelf_rl.Text = "--"
            End If
            If Trim(txtNumero_rl.Text) = "" Then
                Select Case ""
                    Case Trim(txtMzna_rl.Text)
                        valor_alta = True
                        pbMznaRL.Visible = True
                    Case Trim(txtLote_rl.Text)
                        valor_alta = True
                        pbLoteRL.Visible = True
                End Select
            Else
                valor_alta = False
            End If
        End If

        'comprobacion de relacion
        If cbxtipoRelacion.SelectedValue.ToString = 2 Then
            Select Case ""
                Case Trim(txtIden_conyuge.Text)
                    valor_alta = True
                    pbConyuge.Visible = True
                Case Trim(txtNombres_conyuge.Text)
                    valor_alta = True
                    pbConyuge.Visible = True
            End Select
        Else
            If Trim(cbxtipoRelacion.SelectedValue.ToString) = "" Then
                valor_alta = True
            End If
        End If
        Return valor_alta
    End Function

    Private Sub btnPrintFicha_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        If estado_button = 2 Then
            Dim conexion_contribuyente As New class_controller_contribuyente
            Dim datos_contribuyente As New class_datos_contribuyente
            Dim datos_direccion As New class_datos_direccion
            Dim conexion_direccion As New class_controller_direccion
            Dim conexion_repreLegal As New class_controller_representanteLegal
            Dim datos_reprelegal As New class_datos_representanteLegal
            Dim datos_sociedadConyugal As New class_datos_sociedadConyugal
            Dim conexion_sociedadConyugal As New class_controller_sociedadConyugal
            Dim alta As Boolean = False
            Dim codigoContribuyente As Integer
            Dim verificado As Boolean = False
            If alta2() = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 001",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If cbxtipoDocumento.Text = "ruc" Then
                    If verificar_ruc() Then
                        verificado = True
                    End If

                Else
                    If verificar_dni() Then
                        verificado = True
                    End If
                End If

                If verificado Then
                    'MsgBox("Ya existe un contribuyente asociado a este número DNI.")
                Else
                    'guaradando datos de contribuyente 
                    datos_contribuyente.nombres_cont = txtNombre.Text
                    datos_contribuyente.apellido_paterno_cont = txtApe_pat.Text
                    datos_contribuyente.apellido_materno_cont = txtApe_mat.Text
                    datos_contribuyente.cod_tipo_doc = cbxtipoDocumento.SelectedValue.ToString()
                    datos_contribuyente.numero_doc_cont = txtnumeroDoc.Text
                    datos_contribuyente.telefono_cont = txtNumTelf.Text
                    datos_contribuyente.celular_cont = txtNumCel.Text
                    datos_contribuyente.email_contn = txtEmail.Text
                    datos_contribuyente.cont_relacion_cont = txtNombres_conyuge.Text
                    datos_contribuyente.observacion_cont = txtObsv.Text
                    datos_contribuyente.cod_urbanizacion_cont = cbxTipoUrb.SelectedValue.ToString()
                    datos_contribuyente.cod_relacion_cont = cbxtipoRelacion.SelectedValue.ToString()
                    datos_contribuyente.razonSocial_cont = txtRazonsocial.Text
                    datos_contribuyente.ruc_cont = txtNumRuc.Text

                    If conexion_contribuyente.insertarDatosContibuyente(datos_contribuyente) Then
                        'recuperando el id del ultimo contibuyente insertado
                        codigoContribuyente = datos_contribuyente.id_contribuyente
                        'datos de direecion del contribuyente
                        datos_direccion.codTipoVia_direccion = cbxtipoVia.SelectedValue.ToString()
                        datos_direccion.via_direccion = txtNomVia.Text
                        datos_direccion.numero_direccion = txtNumeroVia.Text
                        datos_direccion.mzna_direccion = txtMnza.Text
                        datos_direccion.lote_direccion = txtLote.Text
                        datos_direccion.departamento_direccion = txtNom_Dep.Text
                        datos_direccion.piso_direccion = txtNumeroPiso.Text
                        datos_direccion.sector_direccion = txtNomSector.Text
                        datos_direccion.codDistrito_direccion = Valor_Distrito
                        datos_direccion.codContribuyente_direccion = codigoContribuyente
                        If conexion_direccion.insertarDatosDireccion(datos_direccion) Then
                            'MessageBox.Show("datos guardados de direecion")
                        End If
                        'datos de representante legal
                        If chkReprelegal.Checked = True Then
                            datos_reprelegal.nombre_representanteLegal = txtNom_rl.Text
                            datos_reprelegal.apePat_representanteLegal = txtApepat_rl.Text
                            datos_reprelegal.apeMat_representanteLegal = txtApemat_rl.Text
                            datos_reprelegal.codidentificacion_representanteLegal = cbTipoDoc_rl.SelectedValue.ToString()
                            datos_reprelegal.numeroDoc_representanteLegal = txtnumeroDoc.Text
                            datos_reprelegal.codVia_representanteLegal = cbtipoVia_rl.SelectedValue.ToString()
                            datos_reprelegal.nomVia_representanteLegal = txtNomvia_rl.Text
                            datos_reprelegal.numero_representanteLegal = txtNumero_rl.Text
                            datos_reprelegal.manzana_representanteLegal = txtMzna_rl.Text
                            datos_reprelegal.lote_representanteLegal = txtLote_rl.Text
                            datos_reprelegal.nomApart_representanteLegal = txtApart_rl.Text
                            datos_reprelegal.numApart_representanteLegal = txtNumApart_rl.Text
                            datos_reprelegal.codUrbanizacion_representanteLegal = 1
                            datos_reprelegal.nomUrbanizacion_representanteLegal = txtUrba_rl.Text
                            datos_reprelegal.codContribuyente_representanteLegal = codigoContribuyente
                            datos_reprelegal.cargo_representanteLegal = txtCargo_rl.Text
                            datos_reprelegal.telefono_representanteLegal = txtTelf_rl.Text
                            If conexion_repreLegal.insertarRepresentantelegal(datos_reprelegal) Then
                                'MessageBox.Show("datos guardados de representante legal")
                            End If
                        Else
                        End If
                        'guardando datos de sociedad conyugal
                        If cbxtipoRelacion.SelectedValue.ToString() = 2 Then
                            datos_sociedadConyugal.numIdentificacion_sociedadConyugal = txtIden_conyuge.Text
                            datos_sociedadConyugal.nombreCompleto_sociedadConyugal = txtNombres_conyuge.Text
                            datos_sociedadConyugal.codContri_sociedadConyugal = codigoContribuyente
                            If conexion_sociedadConyugal.insertarDatosSociedadConyugal(datos_sociedadConyugal) Then
                                'MessageBox.Show("datos guardados")
                            End If
                        End If
                        MessageBox.Show("Los Datos se han guardado correctamente", "Mensaje de Confimación",
                   MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clean()
                        desactivar_paneles()
                    Else
                        MessageBox.Show("Lo sentimos no pudimos guardar su informacion por que huvo errores", "Error: 002",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            End If
        End If
        If estado_button = 3 Then
            Dim controlador As New class_controller_contribuyente
            Dim datos As New class_datos_contribuyente
            Dim contadorActualizacion As New Integer
            If alta2() = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If cbxtipoDocumento.Text = "ruc" Then
                    txtApe_pat.Text = ""
                    txtApe_mat.Text = ""
                    txtNombre.Text = ""
                End If
                If numero_dni = txtnumeroDoc.Text Then
                    contadorActualizacion = 0
                    Dim conexion_contribuyente As New class_controller_contribuyente
                    Dim datos_contribuyente As New class_datos_contribuyente
                    Dim datos_direccion As New class_datos_direccion
                    Dim conexion_direccion As New class_controller_direccion
                    Dim conexion_repreLegal As New class_controller_representanteLegal
                    Dim datos_reprelegal As New class_datos_representanteLegal
                    'actualizando datos personales
                    datos_contribuyente.id_contribuyente = IdContibuyente
                    datos_contribuyente.nombres_cont = txtNombre.Text
                    datos_contribuyente.apellido_paterno_cont = txtApe_pat.Text
                    datos_contribuyente.apellido_materno_cont = txtApe_mat.Text
                    datos_contribuyente.cod_tipo_doc = cbxtipoDocumento.SelectedValue.ToString()
                    datos_contribuyente.numero_doc_cont = txtnumeroDoc.Text
                    datos_contribuyente.telefono_cont = txtNumTelf.Text
                    datos_contribuyente.celular_cont = txtNumCel.Text
                    datos_contribuyente.email_contn = txtEmail.Text
                    datos_contribuyente.cont_relacion_cont = txtNombres_conyuge.Text
                    datos_contribuyente.observacion_cont = txtObsv.Text
                    datos_contribuyente.cod_urbanizacion_cont = cbxTipoUrb.SelectedValue.ToString()
                    datos_contribuyente.cod_relacion_cont = cbxtipoRelacion.SelectedValue.ToString()
                    datos_contribuyente.ruc_cont = txtNumRuc.Text
                    datos_contribuyente.razonSocial_cont = txtRazonsocial.Text
                    If conexion_contribuyente.actualizarDatoContribuyente(datos_contribuyente) Then
                        'actualizando direccion
                        contadorActualizacion += 1
                        datos_direccion.id_direccion = IdDireccion
                        datos_direccion.codTipoVia_direccion = cbxtipoVia.SelectedValue.ToString()
                        datos_direccion.via_direccion = txtNomVia.Text
                        datos_direccion.numero_direccion = txtNumeroVia.Text
                        datos_direccion.mzna_direccion = txtMnza.Text
                        datos_direccion.lote_direccion = txtLote.Text
                        datos_direccion.departamento_direccion = txtNom_Dep.Text
                        datos_direccion.piso_direccion = txtNumeroPiso.Text
                        datos_direccion.sector_direccion = txtNomSector.Text
                        datos_direccion.codDistrito_direccion = Valor_Distrito
                        datos_direccion.codContribuyente_direccion = IdContibuyente
                        If conexion_direccion.actualizarDatosDireccion(datos_direccion) Then
                            'MessageBox.Show("datos guardados de direccion")
                            contadorActualizacion += 1
                        Else
                            contadorActualizacion = 0
                        End If
                        'datos de representante legal
                        If chkReprelegal.Checked = True Then
                            datos_reprelegal.id_representanteLegal = IdRepreLegal
                            datos_reprelegal.nombre_representanteLegal = txtNom_rl.Text
                            datos_reprelegal.apePat_representanteLegal = txtApepat_rl.Text
                            datos_reprelegal.apeMat_representanteLegal = txtApemat_rl.Text
                            datos_reprelegal.codidentificacion_representanteLegal = cbTipoDoc_rl.SelectedValue.ToString()
                            datos_reprelegal.numeroDoc_representanteLegal = txtnumeroDoc.Text
                            datos_reprelegal.codVia_representanteLegal = cbtipoVia_rl.SelectedValue.ToString()
                            datos_reprelegal.nomVia_representanteLegal = txtNomvia_rl.Text
                            datos_reprelegal.numero_representanteLegal = txtNumero_rl.Text
                            datos_reprelegal.manzana_representanteLegal = txtMzna_rl.Text
                            datos_reprelegal.lote_representanteLegal = txtLote_rl.Text
                            datos_reprelegal.nomApart_representanteLegal = txtApart_rl.Text
                            datos_reprelegal.numApart_representanteLegal = txtNumApart_rl.Text
                            datos_reprelegal.codUrbanizacion_representanteLegal = 1
                            datos_reprelegal.nomUrbanizacion_representanteLegal = txtUrba_rl.Text
                            datos_reprelegal.codContribuyente_representanteLegal = IdContibuyente
                            datos_reprelegal.cargo_representanteLegal = txtCargo_rl.Text
                            datos_reprelegal.telefono_representanteLegal = txtTelf_rl.Text
                            If conexion_repreLegal.actualizarRepresentantelegal(datos_reprelegal) Then
                                MessageBox.Show("datos guardados de representante legal")
                                contadorActualizacion += 1
                            End If
                        Else
                            'eliminar representante legal
                            datos_reprelegal.id_representanteLegal = IdRepreLegal
                            If conexion_repreLegal.eliminarRepresentantelegal(datos_reprelegal) Then
                                'MessageBox.Show("Datos eliminados.")
                            Else
                                'MessageBox.Show("Datos no guardados.")
                            End If
                        End If

                    Else
                        'MessageBox.Show("datos no guardados")
                    End If
                    If contadorActualizacion = 2 Or contadorActualizacion = 3 Then
                        MessageBox.Show("Actualizacion Correcta.", "Muni", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se ha podido actualizar.", "Muni", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    If verificar_dni() Then
                        'MsgBox("Ya existe un contribuyente asociado a este número DNI.")
                    Else
                        contadorActualizacion = 0
                        Dim conexion_contribuyente As New class_controller_contribuyente
                        Dim datos_contribuyente As New class_datos_contribuyente
                        Dim datos_direccion As New class_datos_direccion
                        Dim conexion_direccion As New class_controller_direccion
                        Dim conexion_repreLegal As New class_controller_representanteLegal
                        Dim datos_reprelegal As New class_datos_representanteLegal
                        'actualizando datos personales
                        datos_contribuyente.id_contribuyente = IdContibuyente
                        datos_contribuyente.nombres_cont = txtNombre.Text
                        datos_contribuyente.apellido_paterno_cont = txtApe_pat.Text
                        datos_contribuyente.apellido_materno_cont = txtApe_mat.Text
                        datos_contribuyente.cod_tipo_doc = cbxtipoDocumento.SelectedValue.ToString()
                        datos_contribuyente.numero_doc_cont = txtnumeroDoc.Text
                        datos_contribuyente.telefono_cont = txtNumTelf.Text
                        datos_contribuyente.celular_cont = txtNumCel.Text
                        datos_contribuyente.email_contn = txtEmail.Text
                        datos_contribuyente.cont_relacion_cont = txtNombres_conyuge.Text
                        datos_contribuyente.observacion_cont = txtObsv.Text
                        datos_contribuyente.cod_urbanizacion_cont = cbxTipoUrb.SelectedValue.ToString()
                        datos_contribuyente.cod_relacion_cont = cbxtipoRelacion.SelectedValue.ToString()
                        datos_contribuyente.ruc_cont = txtNumRuc.Text
                        datos_contribuyente.razonSocial_cont = txtRazonsocial.Text
                        If conexion_contribuyente.actualizarDatoContribuyente(datos_contribuyente) Then
                            'actualizando direccion
                            contadorActualizacion += 1
                            datos_direccion.id_direccion = IdDireccion
                            datos_direccion.codTipoVia_direccion = cbxtipoVia.SelectedValue.ToString()
                            datos_direccion.via_direccion = txtNomVia.Text
                            datos_direccion.numero_direccion = txtNumeroVia.Text
                            datos_direccion.mzna_direccion = txtMnza.Text
                            datos_direccion.lote_direccion = txtLote.Text
                            datos_direccion.departamento_direccion = txtNom_Dep.Text
                            datos_direccion.piso_direccion = txtNumeroPiso.Text
                            datos_direccion.sector_direccion = txtNomSector.Text
                            datos_direccion.codDistrito_direccion = Valor_Distrito
                            datos_direccion.codContribuyente_direccion = IdContibuyente
                            If conexion_direccion.actualizarDatosDireccion(datos_direccion) Then
                                'MessageBox.Show("datos guardados de direccion")
                                contadorActualizacion += 1
                            Else
                                contadorActualizacion = 0
                            End If
                            'datos de representante legal
                            If chkReprelegal.Checked = True Then
                                datos_reprelegal.id_representanteLegal = IdRepreLegal
                                datos_reprelegal.nombre_representanteLegal = txtNom_rl.Text
                                datos_reprelegal.apePat_representanteLegal = txtApepat_rl.Text
                                datos_reprelegal.apeMat_representanteLegal = txtApemat_rl.Text
                                datos_reprelegal.codidentificacion_representanteLegal = cbTipoDoc_rl.SelectedValue.ToString()
                                datos_reprelegal.numeroDoc_representanteLegal = txtnumeroDoc.Text
                                datos_reprelegal.codVia_representanteLegal = cbtipoVia_rl.SelectedValue.ToString()
                                datos_reprelegal.nomVia_representanteLegal = txtNomvia_rl.Text
                                datos_reprelegal.numero_representanteLegal = txtNumero_rl.Text
                                datos_reprelegal.manzana_representanteLegal = txtMzna_rl.Text
                                datos_reprelegal.lote_representanteLegal = txtLote_rl.Text
                                datos_reprelegal.nomApart_representanteLegal = txtApart_rl.Text
                                datos_reprelegal.numApart_representanteLegal = txtNumApart_rl.Text
                                datos_reprelegal.codUrbanizacion_representanteLegal = 1
                                datos_reprelegal.nomUrbanizacion_representanteLegal = txtUrba_rl.Text
                                datos_reprelegal.codContribuyente_representanteLegal = IdContibuyente
                                datos_reprelegal.cargo_representanteLegal = txtCargo_rl.Text
                                datos_reprelegal.telefono_representanteLegal = txtTelf_rl.Text
                                If conexion_repreLegal.actualizarRepresentantelegal(datos_reprelegal) Then
                                    'MessageBox.Show("datos guardados de representante legal")
                                    contadorActualizacion += 1
                                End If
                            Else
                                'eliminar representante legal
                                datos_reprelegal.id_representanteLegal = IdRepreLegal
                                If conexion_repreLegal.eliminarRepresentantelegal(datos_reprelegal) Then
                                    'MessageBox.Show("Actualización Correta.")
                                Else
                                    'MessageBox.Show("Datos no guardados.")
                                End If
                            End If

                        Else
                            'MessageBox.Show("datos no guardados")
                        End If
                        If contadorActualizacion = 2 Or contadorActualizacion = 3 Then
                            MessageBox.Show("Actualizacion Correcta.", "Muni", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No se ha podido actualizar.", "Muni", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                End If
            End If
        End If
        If estado_button = 4 Then
            Dim Message As String = "Estas seguro que deseas eliminar al Contribuyente los cambios no podran ser revertidos ?"
            Dim Caption As String = "Confimación de eliminación"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim Result As DialogResult
            Result = MessageBox.Show("Estas seguro que deseas eliminar al Contribuyente los cambios no podran ser revertidos ?", "Confimación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                'eliminar contribuyente
                Dim datos_contribuyente As New class_datos_contribuyente
                Dim conexion_contribuyente As New class_controller_contribuyente
                datos_contribuyente.id_contribuyente = IdContibuyente
                If conexion_contribuyente.eliminarDatosContibuyente(datos_contribuyente) Then
                    MessageBox.Show("El Contribuyente fue eliminado", "Información de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar_infoPanel()
                    estado_button = 0
                Else
                    MessageBox.Show("No pudimos eliminar al Contribuyente, Intente de nuevo", "Información de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
            End If
        End If
    End Sub
    Private Sub clean()
        chkDatosPersonales.Checked = False
        chkDatosEmpresariales.Checked = False
        txtNomVia.Text = ""
        txtNumeroVia.Text = ""
        txtMnza.Text = ""
        txtLote.Text = ""
        txtNom_Dep.Text = ""
        txtNumeroPiso.Text = ""
        txtNomSector.Text = ""
        txtDist.Text = ""
        txtProv.Text = ""
        txtDep.Text = ""
        txtEmail.Text = ""
        txtNumTelf.Text = ""
        txtNumCel.Text = ""
        chkReprelegal.Checked = False
        txtUrba_rl.Text = ""
        txtCargo_rl.Text = ""
        txtTelf_rl.Text = ""
        txtIden_conyuge.Text = ""
        txtNombres_conyuge.Text = ""

    End Sub
    Sub activar_paneles()
        gb_contactoContribuyente.Enabled = True
        gb_datosPersonales.Enabled = True
        gb_direccionContribuyente.Enabled = True
        gb_Observaciones.Enabled = True
        gb_RepresentanteLegal.Enabled = True
        gb_TipoContribuyente.Enabled = True
    End Sub
    Sub desactivar_paneles()
        gb_contactoContribuyente.Enabled = False
        gb_datosPersonales.Enabled = False
        gb_direccionContribuyente.Enabled = False
        gb_Observaciones.Enabled = False
        gb_RepresentanteLegal.Enabled = False
        gb_TipoContribuyente.Enabled = False
    End Sub
    Sub limpiar_infoPanel()
        lblCodigoContri.Text = ""
        lblDirecContri.Text = ""
        lblContri.Text = ""
        btnOption.Enabled = True
        btnOption.BackColor = Color.FromArgb(128, 131, 140)
        btnOption.Text = "Sin Actividad"
        btnOption.Image = My.Resources.padlock
    End Sub

    Private Sub txtnumeroDoc_KeyUp(sender As Object, e As KeyEventArgs) Handles txtnumeroDoc.KeyUp
        verificar_dni()

    End Sub
    Private Function verificar_dni() As Boolean
        Dim estado_dni As Boolean = False
        If cbxtipoDocumento.Text <> "ruc" Then

            Dim tipo_doc As String
            Dim valor_doc As String
            tipo_doc = cbxtipoDocumento.SelectedValue.ToString
            valor_doc = txtnumeroDoc.Text
            _DatasetContribuyente.Reset()
            consulta_datos_contribuyente_by_valor(tipo_doc, valor_doc)
            If _DatasetContribuyente.Tables(0).Rows.Count > 0 Then
                pbNumeroDoc.Visible = True
                MsgBox("Ya existe un contribuyente asociado a este número DNI.")
                estado_dni = True
            Else
                pbNumeroDoc.Visible = False
                estado_dni = False
            End If

        End If
        Return estado_dni
    End Function


    Private Sub txtNumRuc_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNumRuc.KeyUp
        verificar_ruc()
    End Sub
    Private Function verificar_ruc() As Boolean
        Dim estado_ruc As Boolean = False
        Dim valor_ruc As String
        valor_ruc = txtNumRuc.Text
        _DatasetContribuyente.Reset()
        consulta_datos_contribuyente_by_RUC(valor_ruc)
        If _DatasetContribuyente.Tables(0).Rows.Count > 0 Then
            pbRUC.Visible = True
            MsgBox("Ya existe un contribuyente asociado a este número de RUC.")
            estado_ruc = True
        Else
            pbRUC.Visible = False
            estado_ruc = False
        End If
        Return estado_ruc
    End Function

    Private Sub cbxtipoDocumento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxtipoDocumento.SelectedValueChanged
        If cbxtipoDocumento.Text = "ruc" Then
            txtnumeroDoc.Text = ""
            txtnumeroDoc.Enabled = False
            txtApe_pat.Enabled = False
            txtApe_mat.Enabled = False
            txtNombre.Enabled = False
            chkDatosEmpresariales.Checked = True
            GroupBox2.Enabled = True
            gb_RepresentanteLegal.Enabled = True
            chkReprelegal.Checked = True
            pbNumeroDoc.Visible = False
            gb_direccionContribuyente.Enabled = False
            gb_contactoContribuyente.Enabled = False
        Else
            txtnumeroDoc.Enabled = True
            txtApe_pat.Enabled = True
            txtApe_mat.Enabled = True
            txtNombre.Enabled = True
            chkDatosEmpresariales.Checked = False
            GroupBox2.Enabled = False
            'GroupBox1.Enabled = True
            gb_RepresentanteLegal.Enabled = False
            chkReprelegal.Checked = False
            gb_direccionContribuyente.Enabled = True
            gb_contactoContribuyente.Enabled = True
        End If
    End Sub

    Private Sub btnConsultarRuc_Click(sender As Object, e As EventArgs) Handles btnConsultarRuc.Click
        Dim valor_ruc As String
        valor_ruc = txtNumRuc.Text
        _DatasetContribuyente.Reset()
        consulta_datos_contribuyente_by_RUC(valor_ruc)
        If _DatasetContribuyente.Tables(0).Rows.Count > 0 Then
            pbRUC.Visible = True
            MsgBox("Ya existe un contribuyente asociado a este número de RUC.")
        Else
            pbRUC.Visible = False
            MsgBox("Número de RUC valido.")
        End If
    End Sub

    Private Sub txtnumeroDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumeroDoc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtApe_pat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApe_pat.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtApe_mat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApe_mat.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRazonsocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonsocial.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumRuc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class
