Public Class uc_rentas_recibo
    Dim IdContibuyente As Integer
    Dim valor_IdDireccion As Integer
    Dim codContribuyente As Integer
    Dim valor_predio As Integer
    Dim cont_tipo As New Integer
    Dim estado_boton As Boolean
    Private Sub uc_rentas_autovaluo_recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetAnnio.Reset()
        consulta_datos_annio()
        cbxperiodo.DataSource = _DatasetAnnio.Tables("annio")
        cbxperiodo.DisplayMember = "anno"
        cbxperiodo.ValueMember = "idanno"
        cont_tipo = 0
        cont_tipo = cont_tipo + 1
    End Sub

    Private Sub btnShared_Click(sender As Object, e As EventArgs) Handles btnShared.Click
        Dim formulario2 As New d_rentas_contribuyente_update
        Dim datoRecuperado As DialogResult
        Dim suma As Decimal
        Dim cod_autovaluo As String
        cod_autovaluo = "0"
        btnPrintFicha.Enabled = False
        estado_boton = False
        btnFraccionar.Enabled = False
        Try

            datoRecuperado = formulario2.ShowDialog()
            If datoRecuperado = DialogResult.OK Then
                limpiarCampos()
                IdContibuyente = formulario2.valor_contribuyente
                txtCodigo.Text = IdContibuyente
                llamada_contribuyente(formulario2.valor_contribuyente)
                llamada_direccion_contribuyente(valor_IdDireccion)
                _DatasetPredio.Reset()
                consulta_datos_predio_autovaluo(IdContibuyente)
                dgwPredio.DataSource = _dtwPredio
                _DatasetAutovaluo3.Reset()
                consulta_datos_contribuyente_anio(IdContibuyente, cbxperiodo.Text)
                For Each row In _DatasetAutovaluo3.Tables(0).Rows
                    cod_autovaluo = row("idautovaluo")
                Next
                ' MessageBox.Show("123 " + cod_autovaluo.ToString)
                If cod_autovaluo = "0" Then
                    MessageBox.Show("El usuario no cuenta con autovaluo")
                    btnPrintFicha.Enabled = False
                    estado_boton = False
                End If
                _DatasetRecibo.Reset()
                consulta_recibo_canje(cod_autovaluo)
                'MessageBox.Show("NUMERO DE FILAS : " + _DatasetRecibo.Tables(0).Rows.Count.ToString)
                If _DatasetRecibo.Tables(0).Rows.Count > 0 Then
                    MessageBox.Show("El contribuyente ya cuenta con un recibo")
                    btnPrintFicha.Enabled = False
                    estado_boton = False
                ElseIf cod_autovaluo > 0 Then
                    ' Rellenar los campos
                    btnPrintFicha.Enabled = True
                    estado_boton = True
                    _DatasetAutovaluo3.Reset()
                    consulta_datos_contribuyente_anio(IdContibuyente, cbxperiodo.Text)
                    For Each row In _DatasetAutovaluo3.Tables(0).Rows
                        txtCodAutovaluo.Text = row("idautovaluo")
                        txtValorAutovaluo.Text = row("valor_autovaluo")
                        txtAnnioAutovaluo.Text = row("annio")
                    Next
                    suma = Decimal.Parse(txtValorAutovaluo.Text) + Decimal.Parse(txtAut.Text)
                    txtTotalAutovaluo.Text = suma
                End If
            End If
        Catch
        End Try
    End Sub

    Sub limpiarCampos()
        txtTotalAutovaluo.Text = ""
        txtCodAutovaluo.Text = ""
        txtValorAutovaluo.Text = ""
        txtAut.Text = ""
        txtAnnioAutovaluo.Text = ""
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtIdentificacion.Text = ""
        txtDireccion.Text = ""
        txtAutomatizacion.Text = "0"
        txtMontoAnual.Text = ""
        dgwPredio.DataSource = vbEmpty
        dgwFraccionar.Rows.Clear()
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

    Private Sub btnPrintFicha_Click(sender As Object, e As EventArgs) Handles btnPrintFicha.Click
        If cbxPago.Text = "Contado" Then
            'MessageBox.Show("Contado")
            Dim alta = False
            Try

                Select Case ""
                    Case Trim(txtTotalAutovaluo.Text)
                        alta = True
                    Case Trim(txtCodAutovaluo.Text)
                        alta = True
                    Case Trim(txtValorAutovaluo.Text)
                        alta = True
                    Case Trim(txtAut.Text)
                        alta = True
                    Case Trim(txtAnnioAutovaluo.Text)
                        alta = True
                End Select
                _DatasetFrac.Reset()
                consulta_datos_fraccionamiento_autovaluo(txtCodAutovaluo.Text)
                If _DatasetFrac.Tables(0).Rows.Count > 0 Then
                    MessageBox.Show("El contribuyente ha fraccionado su deuda. Si desea canjear los tickets vaye  a la siguiente pestaña...!!!")
                Else
                    If alta = True Then
                        MessageBox.Show("No se puede guardar, porque hay campos vacios")
                        txtAutomatizacion.Select()
                    Else
                        Dim datos As New class_datos_recibo
                        Dim control As New class_controller_recibo
                        'Dim recibo_view As New report_fraccion
                        Dim fecha As Date = dtpVenc.Value.Date
                        Dim fecha_venc As String = ""
                        fecha_venc = fecha.ToString("yyy-MM-dd")
                        MessageBox.Show(txtValorAutovaluo.Text + " " + cbxPago.Text + " " + txtAutomatizacion.Text + " " + txtCodAutovaluo.Text)
                        datos.monto_autovaluo = Decimal.Parse(FormatNumber(txtTotalAutovaluo.Text, 2))
                        datos.forma_pago = cbxPago.Text
                        'datos.fecha_vencimiento = dtpVenc.Text
                        datos.fecha_vencimiento = fecha_venc
                        datos.estado_recibo = "pendiente"
                        datos.automatizacion_recibo = Decimal.Parse(txtAut.Text)
                        datos.cod_autovaluo = txtCodAutovaluo.Text
                        If control.insertarDatosRecibo(datos) Then
                            MessageBox.Show("Recibo Generado..!!!")
                            limpiarCampos()
                            _DatasetRecibo.Reset()
                            consulta_ultimo_recibo()
                            For Each row In _DatasetRecibo.Tables(0).Rows
                                'recibo_view.cod_recibo_fraccion = row("idrecibo")
                            Next
                            btnPrintFicha.Enabled = False
                            'recibo_view.Show()
                        Else
                            MessageBox.Show("Datos no guardados")
                        End If
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
        End If

    End Sub

    Private Sub cbxPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPago.SelectedIndexChanged
        If cbxPago.Text = "Contado" Then
            btnPrintFicha.Enabled = estado_boton
            btnFraccionar.Enabled = False
        End If
        txtTotalAutovaluo.Text = ""
        If cont_tipo > 0 Then
            If txtCodAutovaluo.Text = "" Then
                MessageBox.Show("El Contribuyente no cuenta con autovaluo o ya se le ha fraccionado su deuda...!!!")
            Else
                If txtAut.Text = "" Then
                    MessageBox.Show("Ingrese un monto de automatización")
                    txtAutomatizacion.Select()
                Else
                    If cbxPago.Text = "Fraccionado" Then
                        btnPrintFicha.Enabled = False
                        btnFraccionar.Enabled = True
                        Dim id_autovaluo As New Integer
                        Dim valor_autovaluo As New Decimal
                        Dim annio_autovaluo As New Integer
                        Dim annio_cod As New Integer
                        Dim cod_ficha As New Integer
                        Dim valor_fraccionado As New Decimal
                        Dim derecho_emision As New Decimal
                        Dim monto_total_frac As New Decimal
                        Dim monto_anual As New Decimal
                        Dim contador_cuota As New Integer
                        Dim valor_automatizacion As New Decimal
                        Dim val_automatizacion As New Decimal
                        Try
                            valor_autovaluo = Decimal.Parse(txtValorAutovaluo.Text)
                            derecho_emision = 4.16
                            txtTotalAutovaluo.Text = ""
                            monto_anual = 0.00
                            contador_cuota = 0
                            annio_cod = txtAnnioAutovaluo.Text
                            valor_fraccionado = valor_autovaluo / 4
                            valor_automatizacion = FormatNumber(txtAutomatizacion.Text, 2)
                            val_automatizacion = FormatNumber(valor_automatizacion, 2)
                            For i As Integer = 0 To 3
                                monto_total_frac = 0.00
                                contador_cuota = contador_cuota + 1
                                If i <> 0 Then
                                    derecho_emision = 0
                                    val_automatizacion = 0
                                End If
                                monto_total_frac = (valor_fraccionado + derecho_emision) + val_automatizacion
                                ' MessageBox.Show("Valor total : " + monto_total_frac.ToString)
                                dgwFraccionar.Rows.Add(contador_cuota, "", FormatNumber(valor_fraccionado, 2),
                                                   derecho_emision, val_automatizacion, FormatNumber(monto_total_frac, 2))
                                monto_anual = monto_anual + monto_total_frac
                            Next
                            txtMontoAnual.Text = monto_anual
                            txtTotalAutovaluo.Text = monto_anual
                        Catch
                        End Try
                    Else
                        Try
                            dgwFraccionar.Rows.Clear()
                            Dim sum As Decimal
                            sum = Decimal.Parse(txtValorAutovaluo.Text) + Decimal.Parse(txtAut.Text)
                            txtTotalAutovaluo.Text = sum
                        Catch
                        End Try
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub txtAutomatizacion_TextChanged(sender As Object, e As EventArgs) Handles txtAutomatizacion.TextChanged
        Try
            Dim deuda_suma As Decimal
            If cbxPago.Text = "Contado" Then
                deuda_suma = Decimal.Parse(txtValorAutovaluo.Text) + Decimal.Parse(txtAutomatizacion.Text)
                txtTotalAutovaluo.Text = deuda_suma
            End If
        Catch
        End Try
        txtAut.Text = txtAutomatizacion.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim liquidacion As New report_liquidacion
        Dim cod_contribuyente As String
        Dim cod_annio As String
        Dim annio As String
        cod_contribuyente = txtCodigo.Text
        cod_annio = cbxperiodo.SelectedValue.ToString
        annio = cbxperiodo.Text
    End Sub

    Private Sub btnFraccionar_Click(sender As Object, e As EventArgs) Handles btnFraccionar.Click
        Dim alta = False
        Dim alta2 = False
        Try
            Select Case ""
                Case Trim(txtTotalAutovaluo.Text)
                    alta = True
                Case Trim(txtCodAutovaluo.Text)
                    alta = True
                Case Trim(txtValorAutovaluo.Text)
                    alta = True
                Case Trim(txtAut.Text)
                    alta = True
                Case Trim(txtAnnioAutovaluo.Text)
                    alta = True
            End Select
            For h As Integer = 0 To dgwFraccionar.RowCount - 1

                If dgwFraccionar.Rows(h).Cells(1).Value = "" Then
                    alta2 = True
                End If
            Next

            _DatasetFrac.Reset()
            consulta_datos_fraccionamiento_autovaluo(txtCodAutovaluo.Text)
            If _DatasetFrac.Tables(0).Rows.Count > 0 Then
                MessageBox.Show("Al contribuyente ya se le ha fraccionado su autovaluo...!!!")
            Else
                If alta2 = True Then
                    MessageBox.Show("La fecha de vencimiento del fraccionamiento no puede ser vacio")
                Else
                    If alta = True Then
                        MessageBox.Show("No se puede guardar, porque hay campos vacios")
                    Else

                        MessageBox.Show("Fraccionado")
                        Try
                            For i As Integer = 0 To 3
                                'MessageBox.Show("datos: " + dgwFraccionar.Rows(i).Cells(0).Value.ToString + " " + dgwFraccionar.Rows(i).Cells(4).Value.ToString)

                            Next
                            'MessageBox.Show("Cod. Facturacion " + cbxperiodo.SelectedValue.ToString + "00" + dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(0).Value.ToString + "00" + txtCodigo.Text.ToString)
                            Dim datos As New class_datos_fraccionamiento
                            Dim control As New class_controller_fraccionamiento
                            Dim estado_f As Integer
                            estado_f = 0
                            For j As Integer = 0 To dgwFraccionar.RowCount - 1
                                datos.id_fraccionamiento = "00" + cbxperiodo.SelectedValue.ToString + txtCodAutovaluo.Text + "00" + txtCodigo.Text + "" + j.ToString
                                datos.periodo_autovaluo = dgwFraccionar.Rows(j).Cells(0).Value
                                datos.fecha_vencimiento_autovaluo = dgwFraccionar.Rows(j).Cells(1).Value
                                datos.monto_insoluto_autovaluo = dgwFraccionar.Rows(j).Cells(2).Value
                                datos.derecho_emision_autovaluo = dgwFraccionar.Rows(j).Cells(3).Value
                                datos.automatizacion_autovaluo = dgwFraccionar.Rows(j).Cells(4).Value
                                datos.monto_total_autovaluo = dgwFraccionar.Rows(j).Cells(5).Value
                                datos.estado_autovaluo = "pendiente"
                                datos.cod_autovaluo = txtCodAutovaluo.Text
                                If control.insertarDatosFraccionamiento(datos) Then
                                    'MessageBox.Show("Datos guardados")
                                    estado_f = estado_f + 1
                                Else
                                    'MessageBox.Show("Datos no guardados")
                                End If
                            Next
                            If estado_f = 4 Then
                                MessageBox.Show("Monto de impuesto Fraccionado")
                                limpiarCampos()
                            Else
                                MessageBox.Show("Hubo un preoblema, vuelva a intentar")
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
                End If


            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
