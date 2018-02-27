Public Class uc_rentas_autovaluo_generar
    Dim IdContibuyente As Integer
    Dim valor_IdDireccion As Integer
    Dim codContribuyente As Integer
    Dim valor_predio As Integer
    Dim valor_minimo As Decimal
    Public valorNombreAG As String
    Sub dato_base_imponible()
        Dim datos As New class_datos_contribuyente
        Dim annio As String
        Dim valor_afecto As Decimal
        Dim valor_base As Decimal
        Dim annio_ficha As String
        Dim deducion As String

        annio = cbxperiodo.SelectedValue
        annio_ficha = ""
        deducion = "0"
        Try
            _DatasetAutovaluo2.Reset()
            consulta_datos_Autovaluo_by(IdContibuyente, annio)
            dgwPredios.DataSource = _dtwAutovaluo2
            For Each row1 In _dtwAutovaluo2.Table.Rows
                valor_afecto = valor_afecto + row1("total_base_imponible")
                valor_base = valor_base + row1("base_imponible")
                annio_ficha = row1("año")
                deducion = row1("valor_deduccion")
            Next
            txtTotalAfecto.Text = valor_afecto
            txtBaseTotal.Text = valor_afecto
            txtBaseimponible.Text = valor_base
            txtanio.Text = annio_ficha
            'txtDeduccion.Text = deducion

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub impuesto()
        Dim valorAuto As Decimal = 0.00
        Dim restov1 As Decimal = 0.00
        Dim restov2 As Decimal = 0.00
        Dim val_uit As Decimal = 0.00
        Dim impuesto_predial As Decimal = 0.00
        Dim annio As Integer
        Dim valor_m As Decimal = 0.00
        Try
            _DatasetMinimo.Reset()
            consulta_datos_valor_minimo(cbxperiodo.Text)
            For Each row In _DatasetMinimo.Tables(0).Rows
                valor_m = row("valor")
                'MsgBox(valor_m.ToString)
            Next

            annio = cbxperiodo.Text
            impuesto_predial = 0.00
            FormatNumber(impuesto_predial, 2)
            'valor_m = 15000.0
            _DatasetUit.Reset()
            consulta_datos_iut(annio)
            For Each row In _DatasetUit.Tables(0).Rows
                val_uit = row("valor_uit")
            Next
            If val_uit = 0 Then
            Else
                txtuit_valor.Text = val_uit
            End If
            valorAuto = Decimal.Parse(txtBaseTotal.Text)
            If _DatasetUit.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No existe un valor de UIT para este año", "Valores de UIT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If valorAuto > valor_m Then
                    'MessageBox.Show("Valor autovaluo " + valorAuto.ToString)
                    'MessageBox.Show("Valor uit " + val_uit.ToString)
                    If valorAuto < (15 * val_uit) Then
                        'MessageBox.Show("Menor a 15 UIT")
                        'MessageBox.Show("Menor a 15 UIT " + (0.002 * valorAuto).ToString)
                        impuesto_predial = (0.002 * valorAuto)
                        'MessageBox.Show("Valor total impuesto 1: " + impuesto_predial.ToString)
                    ElseIf valorAuto > (15 * val_uit) Then
                        'MessageBox.Show("Mayor a 15 UIT")
                        restov1 = valorAuto - (15 * val_uit)
                        impuesto_predial = (15 * val_uit) * 0.002
                        'MessageBox.Show("Valor total impuesto 2.1: " + impuesto_predial.ToString)
                        If restov1 < (60 * val_uit) Then
                            impuesto_predial = impuesto_predial + (restov1 * 0.006)
                            'MessageBox.Show("Valor total impuesto 2.2: " + impuesto_predial.ToString)
                        ElseIf restov1 > (60 * val_uit) Then
                            restov2 = restov1 - (60 * val_uit) ' problema con el signo
                            impuesto_predial = impuesto_predial + (0.006 * valorAuto)
                            ' MessageBox.Show("Valor total impuesto 2.3: " + impuesto_predial.ToString)
                            If restov2 > 0 Then
                                impuesto_predial = impuesto_predial + (restov2 * 0.01)
                                'MessageBox.Show("Valor total impuesto 2.4: " + FormatNumber(impuesto_predial, 2).ToString)
                            End If
                        End If
                        'MessageBox.Show("Valor total impuesto 2" + impuesto_predial.ToString)
                    End If

                ElseIf valorAuto = 0 Then
                    impuesto_predial = 0.0
                Else
                    impuesto_predial = 30.0
                End If
                txtImp.Text = FormatNumber(CDec(impuesto_predial).ToString("N1"), 2)
            End If
            'txtImp.Text = impuesto_predial
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim alta As Boolean = False
        Try
            Select Case ""
                Case Trim(txtImp.Text)
                    alta = True
                Case Trim(txtBaseimponible.Text)
                    alta = True
                Case Trim(txtBaseTotal.Text)
                    alta = True
                Case Trim(txtanio.Text)
                    alta = True
                Case Trim(txtuit_valor.Text)
                    alta = True
                Case Trim(txtCodigo.Text)
                    alta = True
            End Select
            Dim result As Integer = MessageBox.Show("Desea guardar el autovaluo", "Impuesto Predial", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                If alta = True Then
                    MessageBox.Show("No se puede guardar. Hay campos vacio---!!!", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    _DatasetAutovaluo3.Reset()
                    consulta_datos_contribuyente_anio(IdContibuyente, txtanio.Text)
                    If _DatasetAutovaluo3.Tables(0).Rows.Count > 0 Then
                        MessageBox.Show("Uds. ya ha generado el impuesto para este contribuyente", "Impuesto predial ya existe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim controller As New class_controller_autovaluo
                        Dim datos As New class_datos_autovaluo
                        ' MessageBox.Show("" + FormatNumber(impuesto, "#0.#0").ToString)
                        datos.valor_autovaluo = Decimal.Parse(txtImp.Text)
                        datos.annio_autovaluo = cbxperiodo.Text
                        datos.estado_autovaluo = "pendiente"
                        datos.cod_ficaha_autovaluo = txtCodigo.Text
                        datos.fecha_creacion_autovaluo = Date.Now.Date
                        If controller.insertarDatosAutovaluo(datos) Then
                            MessageBox.Show("Impuesto Predial Generado ....!!!", "Generado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            '-----------LOG AUTOVALUO---------------------------'
                            Dim datosLog As New class_datos_log_autovaluo
                            Dim controlLog As New class_controller_log_autovaluo
                            Dim namepc As String
                            Dim fechaA As String
                            Dim oIp As New Net.IPAddress(Net.Dns.Resolve(My.Computer.Name).AddressList(0).GetAddressBytes)
                            namepc = Environment.UserName.ToString
                            fechaA = DateTime.Now.ToString
                            datosLog.user = My.User.Name
                            datosLog.namepc = namepc
                            datosLog.fecha = fechaA
                            datosLog.ip = oIp.ToString
                            datosLog.base = txtImp.Text
                            datosLog.annio = txtanio.Text
                            datosLog.cod_contri = txtCodigo.Text
                            controlLog.insertarDatosLogAutovaluo(datosLog)
                            '---------------------------------------------------'                        limpiarCampos()
                        Else
                            MessageBox.Show("No se ha podido generar", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                End If
            Else
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgwPredios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwPredios.CellDoubleClick
        Dim predio As String = ""
        predio = dgwPredios.Rows(dgwPredios.CurrentRow.Index).Cells(0).Value
        _DatasetAutovaluo.Reset()
        consulta_datos_predio_ficha(predio)
        'dgwAutovaluo.DataSource = _dtwAutovaluo
    End Sub

    Private Sub uc_rentas_autovaluo_generar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetAnnio.Reset()
        consulta_datos_annio()
        cbxperiodo.DataSource = _DatasetAnnio.Tables("annio")
        cbxperiodo.DisplayMember = "anno"
        cbxperiodo.ValueMember = "idanno"
    End Sub

    Private Sub btnShared_Click(sender As Object, e As EventArgs) Handles btnShared.Click
        'lblInfo.Text = "Actualizando Contribuyente"
        Dim formulario2 As New d_rentas_contribuyente_update
        Dim datoRecuperado As DialogResult
        Dim suma_deuda As Decimal
        Dim suma_total As Decimal
        Dim estado As Integer
        Dim cod_predio As String
        Dim contador_predios As New Integer
        Dim contador_fichas As New Integer
        Dim contador_cerrar As New Integer
        estado = 0
        suma_deuda = 0
        suma_total = 0
        cod_predio = 0
        contador_predios = 0
        contador_predios = 0
        contador_cerrar = 0
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            limpiarCampos()
            IdContibuyente = formulario2.valor_contribuyente
            txtCodigo.Text = IdContibuyente
            llamada_contribuyente(formulario2.valor_contribuyente)
            llamada_direccion_contribuyente(valor_IdDireccion)
            '_DatasetAutovaluo2.Reset()
            'consulta_datos_Autovaluo_by(IdContibuyente, cbxperiodo.SelectedValue)
            _DatasetPredio.Reset()
            consulta_datos_predio_by(IdContibuyente)
            contador_predios = _DatasetPredio.Tables(0).Rows.Count
            If contador_predios > 0 Then
                For Each row In _DatasetPredio.Tables(0).Rows
                    '_DatasetDistrito.Reset()
                    'ficha_ByPredio(row("idpredio"))
                    cod_predio = row("idpredio")
                    _DatasetFicha.Reset()
                    consulta_datos_ficha_by_predio(cod_predio, cbxperiodo.SelectedValue)
                    For Each row1 In _DatasetFicha.Tables(0).Rows
                        If row1("estado") = "cerrado" Then
                            contador_cerrar = contador_cerrar + 1
                        End If
                    Next
                    contador_fichas = contador_fichas + _DatasetFicha.Tables(0).Rows.Count
                Next
                _DatasetMinimo.Reset()
                consulta_datos_valor_minimo(cbxperiodo.Text)
                If _DatasetMinimo.Tables(0).Rows.Count = 0 Then
                    MessageBox.Show("No existe un valor minimo para impuesto predial. Vaye al modulo de catalogos de valores minimos para impuesto predial y complete los datos.", "Valores Minimos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'MsgBox(contador_predios.ToString + " " + contador_fichas.ToString)
                    If contador_predios = contador_fichas Then
                        If contador_cerrar = contador_fichas Then
                            dato_base_imponible()
                            impuesto()
                        Else
                            MessageBox.Show("No se puede generar el impuesto predial. Aun no ha cerrado algunas fichas.", "Cerrar Fichas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Aun no ha generado algunas fichas para estos predios. Registre estas fichas y vuelva a intentar...", "Fichas faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Else
                MessageBox.Show("El contribuyente no tiene asociado ningun predio.", "Sin Predios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Sub limpiarCampos()
        txtImp.Text = ""
        txtBaseimponible.Text = ""
        txtBaseTotal.Text = ""
        txtanio.Text = ""
        txtuit_valor.Text = ""
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtIdentificacion.Text = ""
        txtDireccion.Text = ""
        dgwPredios.DataSource = vbEmpty
        txtTotalAfecto.Text = ""
    End Sub
    Private Sub llamada_contribuyente(valor As Integer)
        Dim datos_contribuyente As New class_datos_contribuyente
        cargar_datos_contribuyente(valor, datos_contribuyente)
        If datos_contribuyente.numero_doc_cont = "" Then
            codContribuyente = datos_contribuyente.id_contribuyente
            txtCodigo.Text = datos_contribuyente.id_contribuyente
            txtNombre.Text = UCase(datos_contribuyente.razonSocial_cont)
            txtIdentificacion.Text = datos_contribuyente.ruc_cont
            valor_IdDireccion = datos_contribuyente.id_contribuyente
        Else
            codContribuyente = datos_contribuyente.id_contribuyente
            txtCodigo.Text = datos_contribuyente.id_contribuyente
            txtNombre.Text = UCase(datos_contribuyente.nombres_cont) + " " + UCase(datos_contribuyente.apellido_paterno_cont) + " " + UCase(datos_contribuyente.apellido_materno_cont)
            txtIdentificacion.Text = datos_contribuyente.numero_doc_cont
            valor_IdDireccion = datos_contribuyente.id_contribuyente
        End If

    End Sub
    Private Sub llamada_direccion_contribuyente(valor As Integer)
        Dim datos_direccion_contribuyente As New class_datos_direccion
        cargar_datos_direcContribuyente(valor, datos_direccion_contribuyente)
        _DatasetViaBox2.Reset()
        consulta_datos_tipovia_combox2(datos_direccion_contribuyente.codTipoVia_direccion)
        For Each row In _DatasetViaBox2.Tables("tipo_via").Rows
            txtDireccion.Text = UCase(row("nom_tipovia") + " " + datos_direccion_contribuyente.via_direccion) + " N° " + datos_direccion_contribuyente.numero_direccion
        Next


    End Sub

    Private Sub cbxperiodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxperiodo.KeyPress
        e.Handled = True
    End Sub
End Class