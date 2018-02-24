Public Class uc_rentas_campania_new
    Private estado_buttom As New Integer
    Dim codCampania As New Integer
    Private Sub uc_rentas_campania_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetAnnio.Reset()
        consulta_datos_annio()
        cbxAnioInf.DataSource = _DatasetAnnio.Tables("annio")
        cbxAnioInf.DisplayMember = "anno"
        cbxAnioInf.ValueMember = "idanno"
        _DatasetAnnioAll.Reset()
        consulta_datos_annio_all()
        cbxAnioLim.DataSource = _DatasetAnnioAll.Tables("anno")
        cbxAnioLim.DisplayMember = "anno"
        cbxAnioLim.ValueMember = "idanno"

        '_DatasetAnnio.Reset()
        consulta_datos_annio2()
        cbxAnioInf2.DataSource = _DatasetAnnio2.Tables("annio")
        cbxAnioInf2.DisplayMember = "anno"
        cbxAnioInf2.ValueMember = "idanno"
        '_DatasetAnnioAll.Reset()
        consulta_datos_annio_all2()
        cbxAnioLim2.DataSource = _DatasetAnnioAll2.Tables("anno")
        cbxAnioLim2.DisplayMember = "anno"
        cbxAnioLim2.ValueMember = "idanno"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If estado_buttom = 1 Then
            Dim fecha_culminacion As New Date
            _DatasetCampania.Reset()
            consulta_datos_campania_ultimo()
            For Each fila In _DatasetCampania.Tables(0).Rows
                fecha_culminacion = Date.Parse(fila("fecha_limite")).Date
            Next
            If fecha_culminacion < Date.Now.Date Then
                Dim datos As New class_datos_campania
                Dim datos2 As New class_datos_detalle_campania
                Dim control As New class_controller_campania
                Dim control2 As New class_controller_detalle_campania
                Dim fechaInicial As String
                Dim fechaFinal As String
                fechaInicial = dtpInicio.Value.Date.ToString
                fechaFinal = dtpFinal.Value.Date.ToString
                datos.nombre_campania = txtNombreCampania.Text
                datos.fecha_inicio_campania = fechaInicial
                datos.fecha_final_campania = fechaFinal
                If control.insertarDatosCampania(datos) Then
                    'MsgBox("Datos Guardados")
                    Dim codCampania As Integer = 0
                    If cbDescuento.Checked Then
                        datos2.nombre_DetCampania = "Descuento"
                        datos2.valor_DetCampania = Decimal.Parse(txtDescuento.Text)
                        If cbTodosAnios.Checked Then
                            datos2.tipo_rango_DetCampania = "Todos"
                            datos2.annio_DetCampania = "2000," + Date.Now.Year.ToString
                        End If
                        If cbannioActual.Checked Then
                            datos2.tipo_rango_DetCampania = "Actual"
                            datos2.annio_DetCampania = Date.Now.Year
                        End If
                        If cbRangoAnnios.Checked Then
                            datos2.tipo_rango_DetCampania = "Rango"
                            datos2.annio_DetCampania = cbxAnioInf.Text + "," + cbxAnioLim.Text
                        End If
                        _DatasetCampania.Reset()
                        consulta_datos_campania_ultimo()
                        For Each row In _DatasetCampania.Tables(0).Rows
                            codCampania = row("idcampania")
                        Next
                        datos2.cod_campania = codCampania
                        If control2.insertarDatosDetalleDetalleCampania(datos2) Then
                            'MsgBox("Datos guardaos")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                    If cbInteres.Checked Then
                        datos2.nombre_DetCampania = "Mora"
                        datos2.valor_DetCampania = Decimal.Parse(txtMora.Text)
                        If cbTodosAnios2.Checked Then
                            datos2.tipo_rango_DetCampania = "Todos"
                            datos2.annio_DetCampania = "2000," + Date.Now.Year.ToString
                        End If
                        If cbannioActual2.Checked Then
                            datos2.tipo_rango_DetCampania = "Actual"
                            datos2.annio_DetCampania = Date.Now.Year
                        End If
                        If cbRangoAnnios2.Checked Then
                            datos2.tipo_rango_DetCampania = "Rango"
                            datos2.annio_DetCampania = cbxAnioInf2.Text + "," + cbxAnioLim2.Text
                        End If
                        _DatasetCampania.Reset()
                        consulta_datos_campania_ultimo()
                        For Each row In _DatasetCampania.Tables(0).Rows
                            codCampania = row("idcampania")
                        Next
                        datos2.cod_campania = codCampania
                        If control2.insertarDatosDetalleDetalleCampania(datos2) Then
                            ' MsgBox("Datos guardaos")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                Else
                    MsgBox("Datos no Guardados")
                End If
            Else
                MessageBox.Show("No puede crear nueva campaña hasta que finalice la actual", "Campañas en curso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If
        If estado_buttom = 2 Then
            'MsgBox("Actualizar")
            Dim datos As New class_datos_campania
            Dim datos2 As New class_datos_detalle_campania
            Dim control As New class_controller_campania
            Dim control2 As New class_controller_detalle_campania
            Dim existe_descuento As Boolean
            Dim existe_mora As Boolean
            existe_descuento = False
            existe_mora = False
            Dim fechaFinal As String
            fechaFinal = dtpFinal.Value.Date.ToString
            datos.id_campania = codCampania
            datos.nombre_campania = txtNombreCampania.Text
            datos.fecha_final_campania = fechaFinal
            If control.actualizarDatosCampania(datos) Then
                MsgBox("Datos actualizados")
                _DatasetDetalleCampania.Reset()
                consulta_datos_DetCampania_all(codCampania)
                For Each row2 In _DatasetDetalleCampania.Tables(0).Rows
                    If row2("nombre") = "Descuento" Then
                        'MsgBox("Existe descuento")
                        Dim idDetCamapania As New Integer
                        idDetCamapania = row2("iddetalle_campania")
                        'MsgBox("IdDetalle : " + idDetCamapania.ToString)
                        existe_descuento = True
                        If cbDescuento.Checked Then
                            'MsgBox("Esta marcado descuento")
                            datos2.id_Detcampania = idDetCamapania
                            datos2.valor_DetCampania = txtDescuento.Text
                            If cbTodosAnios.Checked Then
                                datos2.tipo_rango_DetCampania = "Todos"
                                datos2.annio_DetCampania = "2000," + Date.Now.Year.ToString
                            End If
                            If cbannioActual.Checked Then
                                datos2.tipo_rango_DetCampania = "Actual"
                                datos2.annio_DetCampania = Date.Now.Year
                            End If
                            If cbRangoAnnios.Checked Then
                                datos2.tipo_rango_DetCampania = "Rango"
                                datos2.annio_DetCampania = cbxAnioInf.Text + "," + cbxAnioLim.Text
                            End If
                            If control2.actualizarDatosDetalleCampania(datos2) Then
                                MsgBox("Datos actualizados")
                            Else
                                MsgBox("Datos no actualizados")
                            End If
                        Else
                            'MsgBox("No esta marcado descuento")
                            Dim datosEliminar As New class_datos_detalle_campania
                            Dim controlEliminar As New class_controller_detalle_campania
                            datosEliminar.id_Detcampania = idDetCamapania
                            If controlEliminar.eliminarDatosDetalleCampania(datosEliminar) Then
                                'MsgBox("Datos eliminados")
                            Else
                                'MsgBox("Datos no eliminados")
                            End If
                        End If
                    End If
                    If row2("nombre") = "Mora" Then
                        'MsgBox("Existe mora")
                        Dim idDetCamapania As New Integer
                        idDetCamapania = row2("iddetalle_campania")
                        'MsgBox("IdDetalle2 : " + idDetCamapania.ToString)
                        existe_mora = True
                        If cbInteres.Checked Then
                            'MsgBox("Esta marcado mora")
                            datos2.id_Detcampania = idDetCamapania
                            datos2.valor_DetCampania = Decimal.Parse(txtMora.Text)
                            If cbTodosAnios2.Checked Then
                                datos2.tipo_rango_DetCampania = "Todos"
                                datos2.annio_DetCampania = "2000," + Date.Now.Year.ToString
                            End If
                            If cbannioActual2.Checked Then
                                datos2.tipo_rango_DetCampania = "Actual"
                                datos2.annio_DetCampania = Date.Now.Year
                            End If
                            If cbRangoAnnios2.Checked Then
                                datos2.tipo_rango_DetCampania = "Rango"
                                datos2.annio_DetCampania = cbxAnioInf2.Text + "," + cbxAnioLim2.Text
                            End If
                            If control2.actualizarDatosDetalleCampania(datos2) Then
                                MsgBox("Datos actualizados")
                            Else
                                MsgBox("Datos no actualizados")
                            End If
                        Else
                            'MsgBox("No esta marcado mora")
                            Dim datosEliminar As New class_datos_detalle_campania
                            Dim controlEliminar As New class_controller_detalle_campania
                            datosEliminar.id_Detcampania = idDetCamapania
                            If controlEliminar.eliminarDatosDetalleCampania(datosEliminar) Then
                                'MsgBox("Datos eliminados")
                            Else
                                'MsgBox("Datos no eliminados")
                            End If
                        End If
                    End If
                Next
                If existe_descuento = False Then
                    'MsgBox("No exite descuento")
                    If cbDescuento.Checked Then
                        'MsgBox("marcado para guardar")
                        datos2.nombre_DetCampania = "Descuento"
                        datos2.valor_DetCampania = Decimal.Parse(txtDescuento.Text)
                        If cbTodosAnios.Checked Then
                            datos2.tipo_rango_DetCampania = "Todos"
                            datos2.annio_DetCampania = "2000," + Date.Now.Year.ToString
                        End If
                        If cbannioActual.Checked Then
                            datos2.tipo_rango_DetCampania = "Actual"
                            datos2.annio_DetCampania = Date.Now.Year
                        End If
                        If cbRangoAnnios.Checked Then
                            datos2.tipo_rango_DetCampania = "Rango"
                            datos2.annio_DetCampania = cbxAnioInf.Text + "," + cbxAnioLim.Text
                        End If
                        datos2.cod_campania = codCampania
                        If control2.insertarDatosDetalleDetalleCampania(datos2) Then
                            MsgBox("Datos guardaos")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                End If
                If existe_mora = False Then
                    'MsgBox("No existe mora")
                    If cbInteres.Checked Then
                        'MsgBox("marca para guardar")
                        datos2.nombre_DetCampania = "Mora"
                        datos2.valor_DetCampania = Decimal.Parse(txtMora.Text)
                        If cbTodosAnios2.Checked Then
                            datos2.tipo_rango_DetCampania = "Todos"
                            datos2.annio_DetCampania = "2000," + Date.Now.Year.ToString
                        End If
                        If cbannioActual2.Checked Then
                            datos2.tipo_rango_DetCampania = "Actual"
                            datos2.annio_DetCampania = Date.Now.Year
                        End If
                        If cbRangoAnnios2.Checked Then
                            datos2.tipo_rango_DetCampania = "Rango"
                            datos2.annio_DetCampania = cbxAnioInf2.Text + "," + cbxAnioLim2.Text
                        End If
                        datos2.cod_campania = codCampania
                        If control2.insertarDatosDetalleDetalleCampania(datos2) Then
                            MsgBox("Datos guardaos")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                End If
            Else
                MsgBox("Datos no actualizados")
            End If
        End If
    End Sub

    Private Sub cbDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles cbDescuento.CheckedChanged
        If cbDescuento.Checked Then
            gbDescuento.Enabled = True
            txtDescuento.Enabled = True
            txtDescuento.Select()
        Else
            gbDescuento.Enabled = False
            txtDescuento.Enabled = False
        End If
    End Sub

    Private Sub cbInteres_CheckedChanged(sender As Object, e As EventArgs) Handles cbInteres.CheckedChanged
        If cbInteres.Checked Then
            gbMora.Enabled = True
            txtMora.Enabled = True
            txtMora.Select()
        Else
            gbMora.Enabled = False
            txtMora.Enabled = False
        End If
    End Sub

    Private Sub cbRangoAnnios_CheckedChanged(sender As Object, e As EventArgs) Handles cbRangoAnnios.CheckedChanged
        If cbRangoAnnios.Checked Then
            cbxAnioInf.Enabled = True
            cbxAnioLim.Enabled = True
        Else
            cbxAnioInf.Enabled = False
            cbxAnioLim.Enabled = False
        End If
    End Sub

    Private Sub cbRangoAnnios2_CheckedChanged(sender As Object, e As EventArgs) Handles cbRangoAnnios2.CheckedChanged
        If cbRangoAnnios2.Checked Then
            cbxAnioInf2.Enabled = True
            cbxAnioLim2.Enabled = True
        Else
            cbxAnioInf2.Enabled = False
            cbxAnioLim2.Enabled = False
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnGuardar.Text = "Actualizar"
        pnlCampania.Enabled = True
        estado_buttom = 2
        _DatasetCampania.Reset()
        consulta_datos_campania_ultimo()
        For Each row In _DatasetCampania.Tables(0).Rows
            codCampania = row("idcampania")
            txtNombreCampania.Text = row("nombre")
            dtpInicio.Text = row("fecha_inicio")
            dtpInicio.Enabled = False
            dtpFinal.Text = row("fecha_limite")
        Next
        _DatasetDetalleCampania.Reset()
        consulta_datos_DetCampania_all(codCampania)
        For Each row2 In _DatasetDetalleCampania.Tables(0).Rows
            If row2("nombre") = "Descuento" Then
                cbDescuento.Checked = True
                txtDescuento.Text = row2("valor")
                If row2("tipo_rango") = "Todos" Then
                    cbTodosAnios.Checked = True
                End If
                If row2("tipo_rango") = "Actual" Then
                    cbannioActual.Checked = True
                End If
                If row2("tipo_rango") = "Rango" Then
                    cbRangoAnnios.Checked = True
                    Dim anio_inf As String
                    Dim anio_sup As String
                    Dim cadena As String
                    Dim indice As String
                    cadena = row2("anio")
                    indice = cadena.IndexOf(",", StringComparison.Ordinal)
                    anio_inf = cadena.Substring(0, indice)
                    anio_sup = cadena.Substring(anio_inf.Length + 1)
                    cbxAnioInf.Text = anio_inf
                    cbxAnioLim.Text = anio_sup
                End If
            ElseIf row2("nombre") = "Mora" Then
                cbInteres.Checked = True
                txtMora.Text = row2("valor")
                If row2("tipo_rango") = "Todos" Then
                    cbTodosAnios2.Checked = True
                End If
                If row2("tipo_rango") = "Actual" Then
                    cbannioActual2.Checked = True
                End If
                If row2("tipo_rango") = "Rango" Then
                    cbRangoAnnios2.Checked = True
                    Dim anio_inf As String
                    Dim anio_sup As String
                    Dim cadena As String
                    Dim indice As String
                    cadena = row2("anio")
                    indice = cadena.IndexOf(",", StringComparison.Ordinal)
                    anio_inf = cadena.Substring(0, indice)
                    anio_sup = cadena.Substring(anio_inf.Length + 1)
                    cbxAnioInf2.Text = anio_inf
                    cbxAnioLim2.Text = anio_sup
                End If
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        estado_buttom = 1
        btnGuardar.Text = "Guardar"
        pnlCampania.Enabled = True
        clear()
    End Sub
    Private Sub clear()
        txtNombreCampania.Text = ""
        dtpInicio.Text = Date.Now
        dtpInicio.Enabled = True
        dtpFinal.Text = Date.Now
        cbDescuento.Checked = False
        cbInteres.Checked = False
        txtDescuento.Text = ""
        txtMora.Text = ""
        cbTodosAnios.Checked = True
        cbTodosAnios2.Checked = True
    End Sub
End Class
