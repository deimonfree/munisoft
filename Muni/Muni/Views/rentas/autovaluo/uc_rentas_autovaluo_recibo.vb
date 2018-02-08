Public Class uc_rentas_autovaluo_recibo
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
                If _DatasetRecibo.Tables(0).Rows.Count <= 4 And _DatasetRecibo.Tables(0).Rows.Count > 0 Then
                    MessageBox.Show("El contribuyente ya cuenta con un recibo")
                    lblInfo.Text = "El contribuyente ya cuenta con un recibo"
                    lblsubInfo.Text = "Dirigirse a ventanilla de tesoreria para realizar el cobro correspondiente"
                    pbFail.Visible = True
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
                    txtAutomatizacion.Select()
                End If
            End If
        Catch
        End Try
        'lblInfo.Text = "Generando Recibo"
        'pbFail.Image = My.Resources.invoice2
        'pbFail.SizeMode = PictureBoxSizeMode.StretchImage
        'pbLoad.Visible = True
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
                    'MessageBox.Show(txtValorAutovaluo.Text + " " + cbxPago.Text + " " + txtAutomatizacion.Text + " " + txtCodAutovaluo.Text)
                    datos.monto_autovaluo = Decimal.Parse(FormatNumber(txtTotalAutovaluo.Text, 2))
                    datos.forma_pago = cbxPago.Text
                    'datos.fecha_vencimiento = dtpVenc.Text
                    datos.fecha_vencimiento = fecha_venc
                    datos.estado_recibo = "pendiente"
                    datos.automatizacion_recibo = Decimal.Parse(txtAut.Text)
                    datos.cod_autovaluo = txtCodAutovaluo.Text
                    If control.insertarDatosRecibo(datos) Then
                        MessageBox.Show("Recibo Generado..!!!")
                        '---------------LOG RECIBO-----------------'
                        Dim datosLog As New class_datos_log_recibo
                        Dim controlLog As New class_controller_log_recibo
                        Dim namepc As String
                        Dim fechaA As String
                        Dim oIp As New Net.IPAddress(Net.Dns.Resolve(My.Computer.Name).AddressList(0).GetAddressBytes)
                        'user =
                        namepc = Environment.UserName.ToString
                        fechaA = DateTime.Now.ToString
                        datosLog.user = My.User.Name
                        datosLog.namepc = namepc
                        datosLog.fecha = fechaA
                        datosLog.ip = oIp.ToString
                        datosLog.monto = Decimal.Parse(txtTotalAutovaluo.Text)
                        datosLog.cod_autovaluo = txtCodAutovaluo.Text
                        controlLog.insertarDatosLogRecibos(datosLog)
                        '------------------------------------------'
                        limpiarCampos()
                        _DatasetRecibo.Reset()
                        consulta_ultimo_recibo()
                        'For Each row In _DatasetRecibo.Tables(0).Rows
                        '    recibo_view.cod_recibo_fraccion = row("idrecibo")
                        'Next
                        ''recibo_view.Show()
                    Else
                        MessageBox.Show("Datos no guardados")
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbxPago.Text = "Fraccionado" Then
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

                ' _DatasetFrac.Reset()
                'consulta_datos_fraccionamiento_autovaluo(txtCodAutovaluo.Text)
                'If _DatasetFrac.Tables(0).Rows.Count > 0 Then
                'MessageBox.Show("Al contribuyente ya se le ha fraccionado su autovaluo...!!!")
                'Else
                If alta2 = True Then
                    MessageBox.Show("La fecha de vencimiento del fraccionamiento no puede ser vacio")
                Else
                    If alta = True Then
                        MessageBox.Show("No se puede guardar, porque hay campos vacios")
                    Else

                        'MessageBox.Show("Fraccionado")
                        Try
                            For i As Integer = 0 To 3
                                'MessageBox.Show("datos: " + dgwFraccionar.Rows(i).Cells(0).Value.ToString + " " + dgwFraccionar.Rows(i).Cells(4).Value.ToString)

                            Next
                            'MessageBox.Show("Cod. Facturacion " + cbxperiodo.SelectedValue.ToString + "00" + dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(0).Value.ToString + "00" + txtCodigo.Text.ToString)
                            Dim datos As New class_datos_recibo
                            Dim control As New class_controller_recibo
                            Dim estado_f As Integer
                            Dim fecha_data As New Date
                            estado_f = 0
                            For j As Integer = 0 To dgwFraccionar.RowCount - 1
                                'datos.id_fraccionamiento = "00" + cbxperiodo.SelectedValue.ToString + txtCodAutovaluo.Text + "00" + txtCodigo.Text + "" + j.ToString
                                datos.forma_pago = "Fraccionado"
                                datos.monto_autovaluo = dgwFraccionar.Rows(j).Cells(4).Value
                                'MessageBox.Show("Fecha : " + dgwFraccionar.Rows(j).Cells(1).Value.ToString)
                                'fecha_data = Convert.ToDateTime(dgwFraccionar.Rows(j).Cells(1).Value).Date
                                'MessageBox.Show("Fecha Celda : " + fecha_data.ToString)
                                'datos.fecha_vencimiento = fecha_data.ToString("yyy-MM-dd")
                                datos.fecha_vencimiento = dgwFraccionar.Rows(j).Cells(1).Value
                                datos.estado_recibo = "pendiente"
                                datos.automatizacion_recibo = dgwFraccionar.Rows(j).Cells(3).Value
                                datos.cod_autovaluo = txtCodAutovaluo.Text
                                If control.insertarDatosRecibo(datos) Then
                                    'MessageBox.Show("Datos guardados")
                                    estado_f = estado_f + 1
                                Else
                                    'MessageBox.Show("Datos no guardados")
                                End If
                            Next
                            If estado_f = 4 Then
                                MessageBox.Show("Recibos Generado ...!!!")
                                limpiarCampos()
                            Else
                                MessageBox.Show("Hubo un preoblema, vuelva a intentar")
                            End If
                        Catch ex As Exception
                            'MessageBox.Show(ex.Message)
                        End Try
                    End If
                End If


                'End If
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub cbxPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPago.SelectedIndexChanged
        If cbxPago.Text = "Contado" Then
            btnPrintFicha.Enabled = estado_boton
            dtpVenc.Enabled = True
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
                        dtpVenc.Enabled = False
                        Dim id_autovaluo As New Integer
                        Dim valor_autovaluo As New Decimal
                        Dim annio_autovaluo As New Integer
                        Dim annio_cod As New Integer
                        Dim cod_ficha As New Integer
                        Dim valor_fraccionado As New Decimal
                        Dim monto_total_frac As New Decimal
                        Dim monto_anual As New Decimal
                        Dim contador_cuota As New Integer
                        Dim valor_automatizacion As New Decimal
                        Dim val_automatizacion As New Decimal
                        'SECCION PARA LA AGREGAR COLUMNA DE FECHA
                        'Dim col As New CalendarColumn() 'Crear columna de tipo CalendarColumn
                        'Me.dgwFraccionar.Columns.RemoveAt(1) 'Eliminar la columna especificada
                        'Me.dgwFraccionar.Columns.Insert(1, col) 'Insertar columna de tipo CalendarColumn
                        'Me.dgwFraccionar.Columns(1).DataPropertyName = "FechaInicio" 'Asignar el nombre del campo de la base de datos a la columna especificada
                        'Me.dgwFraccionar.Columns(1).DataPropertyName = "FechaInicio" 'Asignar el nombre del campo de la base de datos a la columna especificada
                        'Me.dgwFraccionar.Columns(1).HeaderText = "Fecha de Vencimiento" 'Asignar el nombre a mostrar en la columna
                        'SECCION PARA LA AGREGAR COLUMNA DE FECHA



                        Try
                            valor_autovaluo = Convert.ToDouble(txtValorAutovaluo.Text)
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
                                    val_automatizacion = 0
                                End If
                                monto_total_frac = (valor_fraccionado) + val_automatizacion
                                dgwFraccionar.Rows.Add(contador_cuota, "", FormatNumber(valor_fraccionado, 2),
                                    val_automatizacion, FormatNumber(CDec(monto_total_frac).ToString("N1"), 2))
                                monto_anual = monto_anual + FormatNumber(CDec(monto_total_frac).ToString("N1"), 2)
                            Next
                            txtMontoAnual.Text = monto_anual
                            txtTotalAutovaluo.Text = FormatNumber(monto_anual, 2)
                        Catch
                        End Try
                    Else
                        Try
                            dgwFraccionar.Rows.Clear()
                            Dim sum As Decimal
                            sum = Decimal.Parse(txtValorAutovaluo.Text) + Decimal.Parse(txtAut.Text)
                            txtTotalAutovaluo.Text = FormatNumber(sum, 2)
                        Catch
                        End Try
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub txtAutomatizacion_TextChanged(sender As Object, e As EventArgs) Handles txtAutomatizacion.TextChanged
        Try
            Dim deuda_suma As Double

            If cbxPago.Text = "Contado" Then
                deuda_suma = Double.Parse(txtValorAutovaluo.Text) + Double.Parse(txtAutomatizacion.Text)
                'Math.Round(deuda_suma, 2)
                'MessageBox.Show("Redondeo " + deuda_suma.ToString)
                txtTotalAutovaluo.Text = deuda_suma
            End If
        Catch
        End Try
        txtAut.Text = txtAutomatizacion.Text
    End Sub

    Private Sub btnFraccionar_Click(sender As Object, e As EventArgs)
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

    Private Sub txtAutomatizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAutomatizacion.KeyPress
        ' Referenciamos el control TextBox que ha desencadeno el evento
        '
        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim separadorDecimal As String =
           Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Si en el control hay ya escrito un separador decimal, 
            ' deshechamos insertar otro separador más. 
            ' 
            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return

            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse
                  ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    ' Si no hay ningún número, insertamos un cero
                    ' antes del separador decimal.
                    tb.SelectedText = "0"
                End If

                ' Insertamos el separador decimal. 
                '
                e.KeyChar = CChar(separadorDecimal)
                Return
            End If
        End If

        If (Convert.ToInt32(e.KeyChar) = 8) Then
            ' Se ha pulsado la tecla retroceso 
            Return

        ElseIf (e.KeyChar = "-"c) Then
            ' Únicamente si no está seleccionado el texto del control 
            If (tb.SelectionLength = 0) Then
                ' Si en el control hay ya escrito un signo menos, 
                ' deshechamos todos los que posteriormente se escriban 
                If (tb.Text.IndexOf("-"c) >= 0) Then
                    e.Handled = True
                    Return
                End If

                ' Solo permito el signo menos si aparece en primera posición 
                '
                e.Handled = (tb.SelectionStart <> 0)
            End If

        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then
            ' No se ha pulsado un dígito. 
            e.Handled = True
            Return

        End If

        ' Si existe el separador decimal, no permitimos que
        ' se escriban más de dos números decimales.
        '
        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)

        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If

        ' Si el texto del control actualmente está seleccionado, 
        ' permitimos que se pueda reemplazar por el carácter tecleado.
        '
        If (tb.SelectionLength > 0) Then e.Handled = False
    End Sub
End Class
