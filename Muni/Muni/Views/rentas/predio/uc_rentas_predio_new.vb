Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class uc_rentas_predio_new
    'variables /*******************************************/
    Dim valor_zona As Integer
    '/***************************************/
    Dim Valor_Distrito As Integer
    Dim Valor_provincia As Integer
    Dim Valor_Departamento As Integer
    Dim valor_IdDireccion As Integer
    Dim IdContibuyente As Integer
    Dim datosDistrito As New class_datos_distrito
    Dim datosProvincia As New class_datos_provincia
    Dim datosDepartamento As New class_datos_departamento
    Dim estado_button As Boolean = True
    'variables para llenado
    Dim idServiciosBasicos As Integer
    Dim codGrupoCatastral As Integer
    Dim codContribuyente As Integer
    Dim idGrupoCatastral As Integer
    Dim estado_button_update As Integer = 0
    Dim idZona As Integer = 0
    Dim idPredio As Integer = 0
    Dim codPredio As Integer = 0
    'estado de boton
    Dim estado_boton As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblInfo.Text = "Actualizando Contribuyente"
        Dim formulario2 As New d_rentas_contribuyente_update
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            IdContibuyente = formulario2.valor_contribuyente
            txtCodContribuyente.Text = IdContibuyente
            llamada_contribuyente(formulario2.valor_contribuyente)
            'llamada_direccion_contribuyente(valor_IdDireccion)
        End If
    End Sub
    Private Sub llamada_contribuyente(valor As Integer)
        Dim datos_contribuyente As New class_datos_contribuyente
        cargar_datos_contribuyente(valor, datos_contribuyente)
        If estado_boton = 3 Or estado_boton = 2 Then
            codContribuyente = datos_contribuyente.id_contribuyente
            txtCodContribuyente.Text = datos_contribuyente.id_contribuyente
            txtNombreContribuyente.Text = LCase(datos_contribuyente.nombres_cont) + " " + UCase(datos_contribuyente.apellido_paterno_cont) + " " + UCase(datos_contribuyente.apellido_materno_cont)
            valor_IdDireccion = datos_contribuyente.id_contribuyente
            llamada_direccion_contribuyente(codContribuyente)
            'cargar datos info
            lblTitular.Text = UCase(datos_contribuyente.nombres_cont) + " " + UCase(datos_contribuyente.apellido_paterno_cont) + " " + UCase(datos_contribuyente.apellido_materno_cont)
        End If
        If estado_boton = 4 Or estado_boton = 5 Then
            lblTitular.Text = UCase(datos_contribuyente.nombres_cont) + " " + UCase(datos_contribuyente.apellido_paterno_cont) + " " + UCase(datos_contribuyente.apellido_materno_cont)
        End If
    End Sub
    Private Sub llamada_direccion_contribuyente(valor As Integer)
        Dim datos_direccion_contribuyente As New class_datos_direccion
        cargar_datos_direcContribuyente(valor, datos_direccion_contribuyente)
        txtDireccionContri.Text = datos_direccion_contribuyente.via_direccion
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim estado_button As Boolean
        estado_button = True
        If estado_button = False Then
            MessageBox.Show("desactivado")
            estado_button = True
        Else
            'busqueda de grupo catastral
            Dim formulario As New d_rentas_busquedapredio
            Dim datoRecuperado As DialogResult
            datoRecuperado = formulario.ShowDialog()
            If datoRecuperado = DialogResult.OK Then
                If formulario.valor_sector <> 0 Then
                    listar_sector(formulario.valor_sector)
                End If
                If formulario.valor_zona <> 0 Then
                    listar_zona(formulario.valor_zona)
                End If
                If formulario.valor_grupoCatastral <> 0 Then
                    'llenar valor catastral
                    llamada_grupoCatastral(formulario.valor_grupoCatastral)
                    'llenado de conbox de vias
                    llamar_vias(formulario.valor_grupoCatastral)
                End If

            End If

            estado_button = False
        End If
    End Sub
    Private Sub llamada_grupoCatastral(valor As Integer)
        Dim datos_grupoCatastral As New class_datos_grupo_catastral
        cargar_datos_grupoCatastral(valor, datos_grupoCatastral)
        txtNomMzna.Text = datos_grupoCatastral.manzana_catastral
        codGrupoCatastral = datos_grupoCatastral.cod_sector_catastral
        idGrupoCatastral = datos_grupoCatastral.idgrupo_catastral

    End Sub
    Private Sub ListarVias(ByVal valor As Integer)
        '_DatasetNomViaBox.Reset()
        consulta_datos_via_combox(valor)
        cbxVia.DataSource = _DatasetNomViaBox.Tables("via")
        cbxVia.DisplayMember = "nombre"
        cbxVia.ValueMember = "idvia"
    End Sub

    Private Sub uc_rentas_predio_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfo.Text = "Pulse cualquiera de los botones para tabajar"
        lblsubinfo.Text = "Para mayon información visite: www.munisoft.com"
    End Sub

    Private Sub llamar_vias(ByVal idcodCatastral As Integer)
        cargar_datos_viasRelacionadas(idcodCatastral)
        Dim longindex As Integer
        longindex = numeros.Length
        For index As Integer = 0 To longindex - 1
            ListarVias(numeros(index))
        Next
    End Sub
    Private Sub imp_numeros()
        For index As Integer = 0 To 3
            MessageBox.Show(numeros(index))
        Next
    End Sub


    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        'colocando button
        sidePanel.Visible = True
        sidePanel.Width = btnSave.Width
        sidePanel.Top = btnSave.Bottom
        sidePanel.Location = btnSave.Location
        '/*****************************************/
        btnOption.Text = "Guardar Contribuyente"
        btnOption.Image = My.Resources.save
        btnOption.BackColor = Color.FromArgb(150, 193, 31)
        btnOption.Enabled = True
        estado_boton = 2
        lblInfo.Text = "Agregando un nuevo predio"
        lblsubinfo.Text = "Rellene los datos correspondientes .."
        pbload.Visible = True
        activar_paneles()

    End Sub
    Private Sub listar_zona(valor As Integer)
        Dim datos_zona As New class_datos_zona
        cargar_datos_zona(valor, datos_zona)
        If datos_zona.id_zona = 1 Then
            rbRural.Checked = True
        Else
            rbUrbano.Checked = True

        End If
    End Sub
    Private Sub listar_sector(valor As Integer)
        Dim datos_sector As New class_datos_sector
        cargar_datos_sector(valor, datos_sector)
        txtcodSector.Text = datos_sector.id_sector
        txtNomSector.Text = datos_sector.nombre_sector
    End Sub

    Private Sub ckAgua_CheckedChanged(sender As Object, e As EventArgs) Handles ckAgua.CheckedChanged
        If ckAgua.Checked = True Then
            txtCodAgua.Enabled = True
        Else
            txtCodAgua.Enabled = False
            txtCodAgua.Text = "ninguno"
        End If
    End Sub

    Private Sub ckLuz_CheckedChanged(sender As Object, e As EventArgs) Handles ckLuz.CheckedChanged
        If ckLuz.Checked = True Then
            txtCodLuz.Enabled = True
        Else
            txtCodLuz.Enabled = False
            txtCodLuz.Text = "ninguno"
        End If
    End Sub
    Private Sub ckTelefono_CheckedChanged(sender As Object, e As EventArgs) Handles ckTelefono.CheckedChanged
        If ckTelefono.Checked = True Then
            txtCodtelf.Enabled = True
        Else
            txtCodtelf.Enabled = False
            txtCodtelf.Text = "ninguno"
        End If
    End Sub

    Private Function alta() As Boolean

        Dim valor_alta As Boolean = False
        pbSector.Visible = False
        PbManzana.Visible = False
        PbNumeroVia.Visible = False
        PbCuadra.Visible = False
        PbNumLote.Visible = False
        PbCodContribuyente.Visible = False
        pbContribuyente.Visible = False
        PbDireccionContribuyente.Visible = False
        Select Case ""
            Case Trim(txtNomSector.Text)
                valor_alta = True
                pbSector.Visible = True
            Case Trim(txtNomMzna.Text)
                valor_alta = True
                PbManzana.Visible = True
            Case Trim(txtNumvia.Text)
                valor_alta = True
                PbNumeroVia.Visible = True
            Case Trim(txtCuadra.Text)
                valor_alta = True
                PbCuadra.Visible = True
            Case Trim(txtCodContribuyente.Text)
                valor_alta = True
                PbCodContribuyente.Visible = True
            Case Trim(cbxVia.Text)
                valor_alta = True
                pbVia.Visible = True
            Case Trim(txtNumLote.Text)
                txtNumLote.Text = "--"
        End Select
        If ckAgua.Checked Then
            If Trim(txtCodAgua.Text) = "" Then
                pbServiciosBasicos.Visible = True
                valor_alta = True
            End If
        Else
            txtCodAgua.Text = "ninguno"
        End If
        If ckLuz.Checked Then
            If Trim(txtCodtelf.Text) = "" Then
                pbServiciosBasicos.Visible = True
                valor_alta = True
            End If
        Else
            txtCodLuz.Text = "ninguno"
        End If
        If ckTelefono.Checked Then
            If Trim(txtCodtelf.Text) = "" Then
                pbServiciosBasicos.Visible = True
                valor_alta = True
            End If
        Else
            txtCodtelf.Text = "ninguno"
        End If
        Return valor_alta
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'colocando button
        sidePanel.Width = btnUpdate.Width
        sidePanel.Top = btnUpdate.Bottom
        sidePanel.Location = btnUpdate.Location
        sidePanel.Visible = True
        lblInfo.Text = "Actualizando Zona"
        lblInfoFicha.Text = "Se esta actualizando los datos de::"
        Dim formulario2 As New d_rentas_busqueda
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            clean()
            activar_paneles()
            estado_boton = 3
            IdContibuyente = formulario2.valor_contribuyente
            idPredio = formulario2.valor_predio
            'idPredio = formulario2.valor_contribuyente
            llamada_predio(formulario2.valor_contribuyente)
            llamada_grupoCatastral(idGrupoCatastral)
            llama_serviciosBasicos(idPredio)
            btnOption.Enabled = True
            btnOption.Text = "Actualizar Datos"
            btnOption.Image = My.Resources.update_white
            btnOption.BackColor = Color.FromArgb(150, 193, 31)
        Else
            estado_button = 0
            btnOption.Enabled = False
            btnOption.Text = "Actividad no Genarada"
            btnOption.BackColor = Color.FromArgb(128, 131, 140)
            limpiar_infoPanel()
            desactivar_paneles()
            clean()
        End If
    End Sub
    Private Sub llama_serviciosBasicos(valor As Integer)
        Dim datos_serviciosBasicos As New class_datos_serviciosBasicos
        cargar_datos_ServiciosBasicos(valor, datos_serviciosBasicos)
        If estado_boton = 3 Then
            idServiciosBasicos = datos_serviciosBasicos.id_serviciosBasicos
            txtCodAgua.Text = datos_serviciosBasicos.codAgua_serviciosBasicos
            txtCodLuz.Text = datos_serviciosBasicos.codLuz_serviciosBasicos
            txtCodtelf.Text = datos_serviciosBasicos.codTelefono_serviciosBasicos
            ckAgua.Checked = True
            ckLuz.Checked = True
            ckTelefono.Checked = True
        End If

    End Sub
    Private Sub llamada_predio(valor As Integer)
        Dim datos_predio As New class_datos_predio
        cargar_datos_predio(valor, datos_predio)
        llamada_contribuyente(datos_predio.cod_contribuyente_predio)
        llamado_via(datos_predio.codVia_predio)
        If estado_boton = 3 Then
            IdContibuyente = valor
            txtcodSector.Text = datos_predio.codSector_predio
            txtNumvia.Text = datos_predio.numero_predio
            txtEnsiso.Text = datos_predio.ensisoNum_predio
            txtCuadra.Text = datos_predio.cuadra_predio
            txtNumLote.Text = datos_predio.nroLote_predio
            'ListarTipoVia(datos_predio.codVia_predio)
            listar_zona(idZona)
            idGrupoCatastral = datos_predio.cod_grupoCatastral_predio
            txtColEste.Text = datos_predio.colindaEste_predio
            txtColOeste.Text = datos_predio.colindaOeste_predio
            txtColNorte.Text = datos_predio.colindaNorte_predio
            txtColSur.Text = datos_predio.colindaSur_predio
            'carga info
            lblInfoCodPredio.Text = idPredio
            lblInfoDireccionPredio.Text = cbxVia.Text & " NRO. " & datos_predio.numero_predio & " " & datos_predio.ensisoNum_predio
        End If
        If estado_boton = 5 Or estado_boton = 4 Then
            lblInfoCodPredio.Text = idPredio
            lblInfoDireccionPredio.Text = cbxVia.Text & " NRO. " & datos_predio.numero_predio & " " & datos_predio.ensisoNum_predio
        End If

    End Sub
    Private Sub ListarTipoVia(ByVal valor As Integer)
        mod_tipoVia._DatasetViaBox.Reset()
        consulta_datos_tipovia_combox(valor)
        cbxVia.DataSource = mod_tipoVia._DatasetViaBox.Tables("tipo_via")
        cbxVia.DisplayMember = "nom_tipovia"
        cbxVia.ValueMember = "idtipo_via"
    End Sub

    Private Sub llamada_sector(valor As Integer)
        Dim datos_sector As New class_datos_sector
        cargar_datos_sector(valor, datos_sector)
        IdContibuyente = valor
        txtcodSector.Text = datos_sector.id_sector
        txtNomSector.Text = datos_sector.nombre_sector
        idZona = datos_sector.codZona_sector
        If idZona = 1 Then
            rbRural.Checked = True
            txtColEste.Text = ""
            txtColOeste.Text = ""
            txtColNorte.Text = ""
            txtColSur.Text = ""
            txtNumvia.Text = "s/n"
            txtCuadra.Text = "1"
            txtNumLote.Text = "--"
            llamada_grupoCatastral(1)
            llenar_vias(txtcodSector.Text)
        Else
            rbUrbano.Checked = True
            txtColEste.Text = "--"
            txtColOeste.Text = "--"
            txtColNorte.Text = "--"
            txtColSur.Text = "--"
            llenar_vias(txtcodSector.Text)
        End If
    End Sub

    Private Sub txtcodSector_TextChanged(sender As Object, e As EventArgs) Handles txtcodSector.TextChanged
        If LTrim(txtcodSector.Text) = "" Then
            txtNomSector.Text = "no valido"
        Else
            llamada_sector(txtcodSector.Text)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            _DatasetNomViaBox.Reset()
            consulta_datos_via_combox_all()
            cbxVia.DataSource = _DatasetNomViaBox.Tables("via")
            cbxVia.DisplayMember = "nombre"
            cbxVia.ValueMember = "idvia"
        End If
    End Sub
    Private Sub llamado_via(ByVal valor_via As Integer)
        _DatasetNomViaBox.Reset()
        consulta_datos_via_combox(valor_via)
        cbxVia.DataSource = _DatasetNomViaBox.Tables("via")
        cbxVia.DisplayMember = "nombre"
        cbxVia.ValueMember = "idvia"
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        sidePanel.Width = btnDelete.Width
        sidePanel.Top = btnDelete.Bottom
        sidePanel.Location = btnDelete.Location
        sidePanel.Visible = True
        clean()
        desactivar_paneles()
        lblInfo.Text = "Dar de baja el predio"
        Dim formulario2 As New d_rentas_busqueda
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            clean()
            activar_paneles()
            estado_boton = 4
            IdContibuyente = formulario2.valor_contribuyente
            idPredio = formulario2.valor_contribuyente
            llamada_predio(formulario2.valor_contribuyente)
            llamada_grupoCatastral(idGrupoCatastral)
            btnOption.Enabled = True
            btnOption.Text = "Dar de Baja"
            btnOption.Image = My.Resources.file_delete
            btnOption.BackColor = Color.FromArgb(255, 140, 1)
            lblInfoFicha.Text = "Ud. dara de baja el Predio ::"
        Else
            estado_button = 0
            btnOption.Enabled = False
            btnOption.Text = "Bloqueado"
            limpiar_infoPanel()
            desactivar_paneles()
        End If
    End Sub
    Private Sub clean()
        txtCodContribuyente.Text = ""
        txtNombreContribuyente.Text = ""
        txtDireccionContri.Text = ""
        txtcodSector.Text = ""
        txtNomSector.Text = ""
        txtNumvia.Text = ""
        txtEnsiso.Text = ""
        txtCuadra.Text = "0"
        txtNumLote.Text = ""
        txtColEste.Text = ""
        txtColOeste.Text = ""
        txtColNorte.Text = ""
        txtColSur.Text = ""
        txtCodAgua.Text = ""
        txtCodLuz.Text = ""
        txtCodtelf.Text = ""
    End Sub
    Private Sub validacion_numerica()
        Dim numero_cuadra As Integer
        If IsNumeric(txtCuadra.Text) Then
            numero_cuadra = codigo_via(cbxVia.Text)
            If txtCuadra.Text <= numero_cuadra Then
                lblInfoCuadra.Text = "--"
                pbCuadraInfo.Visible = False
            Else
                lblInfoCuadra.Text = "la cuadra ingrasada sobre pasa el numero de cuadras de la via: " & cbxVia.Text & " - El numero maximo de cuadras es de " & numero_cuadra
                pbCuadraInfo.Visible = True
            End If
        Else
            MessageBox.Show("el numero de cuadra insertado es incorrecto")
            txtCuadra.Text = 0
        End If
    End Sub

    Private Sub txtCuadra_TextChanged(sender As Object, e As EventArgs) Handles txtCuadra.TextChanged
        validacion_numerica()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numero_cuadra As Integer
        numero_cuadra = codigo_via(cbxVia.Text)
        lblInfoCuadra.Text = numero_cuadra
    End Sub

    Private Sub rbUrbano_CheckedChanged(sender As Object, e As EventArgs) Handles rbUrbano.CheckedChanged
        If rbUrbano.Checked = True Then
            gbRural.Enabled = False

        End If
        If rbRural.Checked = True Then
            gbRural.Enabled = True

        End If
    End Sub

    Sub llenar_vias(ByVal cod_sector As Integer)
        _DatasetNomViaBox.Reset()
        consulta_datos_via_combox_bySector(cod_sector)
        cbxVia.DataSource = _DatasetNomViaBox.Tables("via")
        cbxVia.DisplayMember = "nombre"
        cbxVia.ValueMember = "idvia"
    End Sub

    Private Sub cbxVia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxVia.SelectedIndexChanged
        Try
            If Trim(txtCuadra.Text) = "" Or txtCuadra.Text = 0 Then
            Else
                validacion_numerica()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxVia_Click(sender As Object, e As EventArgs) Handles cbxVia.Click
        llenar_vias(txtcodSector.Text)
    End Sub

    Private Sub btnOption_Click_1(sender As Object, e As EventArgs) Handles btnOption.Click
        If estado_boton = 2 Then
            Dim conexion_predio As New class_controller_predio
            Dim datos_predio As New class_datos_predio
            Dim conexion_serviciosBasicos As New class_controller_serviciosBasicos
            Dim datos_serviciosBasicos As New class_datos_serviciosBasicos
            If alta() = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 001",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                datos_predio.codVia_predio = cbxVia.SelectedValue.ToString()
                datos_predio.numero_predio = txtNumvia.Text
                datos_predio.ensisoNum_predio = txtEnsiso.Text
                datos_predio.cuadra_predio = txtCuadra.Text
                datos_predio.nroLote_predio = txtNumLote.Text
                datos_predio.cod_grupoCatastral_predio = idGrupoCatastral
                datos_predio.cod_contribuyente_predio = codContribuyente
                datos_predio.codSector_predio = txtcodSector.Text
                datos_predio.colindaEste_predio = txtColEste.Text
                datos_predio.colindaOeste_predio = txtColOeste.Text
                datos_predio.colindaNorte_predio = txtColNorte.Text
                datos_predio.colindaSur_predio = txtColSur.Text
                datos_predio.estado_predio = "Activo"
                If conexion_predio.insertarDatosPredio(datos_predio) Then
                    'recuperando el id del ultimo contibuyente insertado
                    codPredio = datos_predio.id_predio
                    'llenado servicios basicos
                    datos_serviciosBasicos.codAgua_serviciosBasicos = txtCodAgua.Text
                    datos_serviciosBasicos.codLuz_serviciosBasicos = txtCodLuz.Text
                    datos_serviciosBasicos.codTelefono_serviciosBasicos = txtCodtelf.Text
                    datos_serviciosBasicos.codPredio_serviciosBasicos = codPredio
                    If conexion_serviciosBasicos.insertarDatosServiciosBasicos(datos_serviciosBasicos) Then

                    End If
                    MessageBox.Show("Los datos fueron guardados", "información",
           MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblInfoFicha.Text = "Acaba de registrar el predio:"
                    lblInfoCodPredio.Text = "000"
                    lblInfoCodPredio.Visible = True
                    lblInfoDireccionPredio.Text = cbxVia.Text + " // " + txtNumvia.Text + " // " + txtCuadra.Text + " // " + txtNumLote.Text
                    lblInfoDireccionPredio.Visible = True
                    lblTitular.Text = txtCodContribuyente.Text
                    lblTitular.Visible = True
                    btnOption.Enabled = True
                    clean()
                    desactivar_paneles()
                Else
                    MessageBox.Show("datos no guardados")
                End If
            End If
        End If
        'actualizar
        If estado_boton = 3 Then
            If alta() = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim conexion_predio As New class_controller_predio
                Dim datos_predio As New class_datos_predio
                datos_predio.id_predio = idPredio
                datos_predio.codVia_predio = cbxVia.SelectedValue.ToString()
                datos_predio.numero_predio = txtNumvia.Text
                datos_predio.ensisoNum_predio = txtEnsiso.Text
                datos_predio.cuadra_predio = txtCuadra.Text
                datos_predio.nroLote_predio = txtNumLote.Text
                datos_predio.cod_grupoCatastral_predio = idGrupoCatastral
                datos_predio.cod_contribuyente_predio = codContribuyente
                datos_predio.codSector_predio = txtcodSector.Text
                datos_predio.colindaEste_predio = txtColEste.Text
                datos_predio.colindaOeste_predio = txtColOeste.Text
                datos_predio.colindaNorte_predio = txtColNorte.Text
                datos_predio.colindaSur_predio = txtColSur.Text
                datos_predio.estado_predio = "Activo"
                If conexion_predio.actualizarDatosPredio(datos_predio) Then
                    Dim conexion_SB As New class_controller_serviciosBasicos
                    Dim datos_SB As New class_datos_serviciosBasicos
                    datos_SB.id_serviciosBasicos = idServiciosBasicos
                    datos_SB.codAgua_serviciosBasicos = txtCodAgua.Text
                    datos_SB.codLuz_serviciosBasicos = txtCodLuz.Text
                    datos_SB.codTelefono_serviciosBasicos = txtCodtelf.Text
                    datos_SB.codPredio_serviciosBasicos = idPredio
                    If conexion_SB.actualizarDatosServiciosBasicos(datos_SB) Then

                    Else

                    End If
                    MessageBox.Show("Se Actualizaron los datos correctamente", "Informe de Actualización",
           MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clean()
                    desactivar_paneles()
                    limpiar_infoPanel()
                    estado_boton = 0
                Else
                    MessageBox.Show("No se pudieron actualizar los Datos", "Informe de Actualización",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
        If estado_boton = 5 Then
            Dim Result As DialogResult
            Result = MessageBox.Show("Estas seguro que deseas eliminar el Predio los cambios no podran ser revertidos ?", "Confimación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                'eliminar contribuyente
                Dim datos_predio As New class_datos_predio
                Dim conexion_predio As New class_controller_predio
                datos_predio.id_predio = idPredio
                If conexion_predio.eliminarDatosPredio(datos_predio) Then
                    MessageBox.Show("El Predio fue eliminado", "Información de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar_infoPanel()
                    estado_button = 0
                Else
                    MessageBox.Show("No pudimos eliminar el Predio, Intente de nuevo", "Información de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
            End If


        End If
    End Sub
    Sub activar_paneles()
        gb_datosContri.Enabled = True
        gb_ubicacionPredio.Enabled = True
        gb_ServiciosBasicos.Enabled = True
    End Sub
    Sub desactivar_paneles()
        gb_datosContri.Enabled = False
        gb_ubicacionPredio.Enabled = False
        gb_ServiciosBasicos.Enabled = False
    End Sub
    Sub limpiar_infoPanel()
        lblInfoCodPredio.Text = ""
        lblInfoDireccionPredio.Text = ""
        lblTitular.Text = ""
        btnOption.Enabled = True
        btnOption.BackColor = Color.FromArgb(128, 131, 140)
        btnOption.Text = "Sin Actividad"
        btnOption.Image = My.Resources.padlock
        sidePanel.Visible = False
        lblInfo.Text = "Pulse cualquiera de los botones para tabajar"
        lblsubinfo.Text = "Para mayon información visite: www.munisoft.com"
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        sidePanel.Width = btnDelete.Width
        sidePanel.Top = btnDelete.Bottom
        sidePanel.Location = btnDelete.Location
        sidePanel.Visible = True
        clean()
        desactivar_paneles()
        lblInfo.Text = "Eliminando Predio"
        Dim formulario2 As New d_rentas_busqueda
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            estado_boton = 5
            IdContibuyente = formulario2.valor_contribuyente
            idPredio = formulario2.valor_contribuyente
            llamada_predio(formulario2.valor_contribuyente)
            llamada_grupoCatastral(idGrupoCatastral)
            btnOption.Enabled = True
            btnOption.Text = "Eliminar Predio"
            btnOption.Image = My.Resources.file_delete
            btnOption.BackColor = Color.FromArgb(255, 140, 1)
            lblInfoFicha.Text = "Ud. Eliminara el Predio ::"
            clean()
            desactivar_paneles()
        Else
            estado_button = 0
            btnOption.Enabled = False
            btnOption.Text = "Bloqueado"
            limpiar_infoPanel()
            desactivar_paneles()
        End If
    End Sub
End Class
