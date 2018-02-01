Public Class vistacentral
    'Private Sub vistacentral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim anio As New Integer
    '    anio = 2017
    '    listar_codigo_depreciacion(anio)
    '    cbxAnio.Text = Year(Now)
    'End Sub

    'Private Sub lista_material()
    '    dgvMaterial1.Rows.Add("Concreto")
    '    dgvMaterial1.Rows.Add("Ladrillo")
    '    dgvMaterial1.Rows.Add("Adobe")
    '    dgvMaterial2.Rows.Add("Concreto")
    '    dgvMaterial2.Rows.Add("Ladrillo")
    '    dgvMaterial2.Rows.Add("Adobe")
    '    dgvMaterial3.Rows.Add("Concreto")
    '    dgvMaterial3.Rows.Add("Ladrillo")
    '    dgvMaterial3.Rows.Add("Adobe")
    '    dgvMaterial4.Rows.Add("Concreto")
    '    dgvMaterial4.Rows.Add("Ladrillo")
    '    dgvMaterial4.Rows.Add("Adobe")
    '    dgvMaterial5.Rows.Add("Concreto")
    '    dgvMaterial5.Rows.Add("Ladrillo")
    '    dgvMaterial5.Rows.Add("Adobe")
    '    dgvMaterial6.Rows.Add("Concreto")
    '    dgvMaterial6.Rows.Add("Ladrillo")
    '    dgvMaterial6.Rows.Add("Adobe")
    '    dgvMaterial7.Rows.Add("Concreto")
    '    dgvMaterial7.Rows.Add("Ladrillo")
    '    dgvMaterial7.Rows.Add("Adobe")
    '    dgvMaterial8.Rows.Add("Concreto")
    '    dgvMaterial8.Rows.Add("Ladrillo")
    '    dgvMaterial8.Rows.Add("Adobe")
    '    dgvMaterial9.Rows.Add("Concreto")
    '    dgvMaterial9.Rows.Add("Ladrillo")
    '    dgvMaterial9.Rows.Add("Adobe")
    '    dgvMaterial10.Rows.Add("Concreto")
    '    dgvMaterial10.Rows.Add("Ladrillo")
    '    dgvMaterial10.Rows.Add("Adobe")
    '    dgvMaterial11.Rows.Add("Concreto")
    '    dgvMaterial11.Rows.Add("Ladrillo")
    '    dgvMaterial11.Rows.Add("Adobe")
    'End Sub
    'Private Sub dgvr1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvr1.KeyDown
    '    modificar_depreciacion(1)
    'End Sub

    'Private Sub cbxAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAnio.SelectedIndexChanged
    '    Dim anio As Integer
    '    anio = cbxAnio.Text
    '    listar_codigo_depreciacion(anio)
    'End Sub

    'Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
    '    Dim conexion As New class_controller_depreciacion
    '    Dim datos, datos2, datos3, datos4, datos5, datos6, datos7, datos8, datos9, datos10, datos11, datos12, datos13, datos14, datos15, datos16 As New class_datos_depreciacion
    '    Dim estado As New Boolean

    '    For Each fila In dgvr1.Rows
    '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
    '        Try
    '            datos.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos.cod_estado = fila.Cells("codestado").Value
    '            datos.cod_material = fila.Cells("codmaterial").Value
    '            datos.valor_central = fila.Cells("valor").Value
    '            datos.annio_central = Integer.Parse(cbxAnnioShare.Text)
    '            If conexion.insertarDatosClie(datos) Then
    '                'MessageBox.Show("Correcto")
    '            Else
    '                ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr2.Rows
    '        Try
    '            datos2.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos2.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos2.cod_estado = fila.Cells("codestado").Value
    '            datos2.cod_material = fila.Cells("codmaterial").Value
    '            datos2.valor_central = fila.Cells("valor").Value
    '            datos2.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos2) Then
    '                'MessageBox.Show("Correcto")
    '            Else
    '                ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr3.Rows
    '        Try
    '            datos3.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos3.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos3.cod_estado = fila.Cells("codestado").Value
    '            datos3.cod_material = fila.Cells("codmaterial").Value
    '            datos3.valor_central = fila.Cells("valor").Value
    '            datos3.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos3) Then
    '                'MessageBox.Show("Correcto")
    '            Else
    '                ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr4.Rows
    '        'MessageBox.Show("fila " + fila.ToString)

    '        Try
    '            datos4.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos4.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos4.cod_estado = fila.Cells("codestado").Value
    '            datos4.cod_material = fila.Cells("codmaterial").Value
    '            'MessageBox.Show("fila " + fila.Cells("valor").Value.ToString)
    '            datos4.valor_central = fila.Cells("valor").Value
    '            datos4.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos4) Then
    '                'MessageBox.Show("Correcto")
    '            Else
    '                ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MessageBox.Show("Error!!! " + fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr5.Rows
    '        Try
    '            datos5.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos5.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos5.cod_estado = fila.Cells("codestado").Value
    '            datos5.cod_material = fila.Cells("codmaterial").Value
    '            datos5.valor_central = fila.Cells("valor").Value
    '            datos5.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos5) Then
    '                'MessageBox.Show("Correcto")
    '            Else
    '                ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr6.Rows
    '        Try
    '            datos6.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos6.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos6.cod_estado = fila.Cells("codestado").Value
    '            datos6.cod_material = fila.Cells("codmaterial").Value
    '            datos6.valor_central = fila.Cells("valor").Value
    '            datos6.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos6) Then
    '                'MessageBox.Show("Correcto")
    '            Else
    '                ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr7.Rows
    '        Try
    '            datos7.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos7.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos7.cod_estado = fila.Cells("codestado").Value
    '            datos7.cod_material = fila.Cells("codmaterial").Value
    '            datos7.valor_central = fila.Cells("valor").Value
    '            datos7.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos7) Then                    'MessageBox.Show("Correcto")
    '            Else                    ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr8.Rows
    '        Try
    '            datos8.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos8.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos8.cod_estado = fila.Cells("codestado").Value
    '            datos8.cod_material = fila.Cells("codmaterial").Value
    '            datos8.valor_central = fila.Cells("valor").Value
    '            datos8.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos8) Then                    'MessageBox.Show("Correcto")
    '            Else                    ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally

    '        End Try
    '    Next
    '    For Each fila In dgvr9.Rows
    '        Try
    '            datos9.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos9.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos9.cod_estado = fila.Cells("codestado").Value
    '            datos9.cod_material = fila.Cells("codmaterial").Value
    '            datos9.valor_central = fila.Cells("valor").Value
    '            datos9.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos9) Then                    'MessageBox.Show("Correcto")
    '            Else                    ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally

    '        End Try
    '    Next
    '    For Each fila In dgvr10.Rows
    '        Try
    '            datos10.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos10.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos10.cod_estado = fila.Cells("codestado").Value
    '            datos10.cod_material = fila.Cells("codmaterial").Value
    '            datos10.valor_central = fila.Cells("valor").Value
    '            datos10.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos10) Then                    'MessageBox.Show("Correcto")
    '            Else                    ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr11.Rows
    '        Try
    '            datos11.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos11.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos11.cod_estado = fila.Cells("codestado").Value
    '            datos11.cod_material = fila.Cells("codmaterial").Value
    '            datos11.valor_central = fila.Cells("valor").Value
    '            datos11.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos11) Then                    'MessageBox.Show("Correcto")
    '            Else                    ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr12.Rows
    '        Try
    '            datos12.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos12.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos12.cod_estado = fila.Cells("codestado").Value
    '            datos12.cod_material = fila.Cells("codmaterial").Value
    '            datos12.valor_central = fila.Cells("valor").Value
    '            datos12.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos12) Then                    'MessageBox.Show("Correcto")
    '            Else                    ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr13.Rows
    '        Try
    '            datos13.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos13.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos13.cod_estado = fila.Cells("codestado").Value
    '            datos13.cod_material = fila.Cells("codmaterial").Value
    '            datos13.valor_central = fila.Cells("valor").Value
    '            datos13.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos13) Then                    'MessageBox.Show("Correcto")
    '            Else                    ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr14.Rows
    '        Try
    '            datos14.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos14.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos14.cod_estado = fila.Cells("codestado").Value
    '            datos14.cod_material = fila.Cells("codmaterial").Value
    '            datos14.valor_central = fila.Cells("valor").Value
    '            datos14.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos14) Then                    'MessageBox.Show("Correcto")
    '            Else                    ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr15.Rows
    '        Try
    '            datos15.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos15.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos15.cod_estado = fila.Cells("codestado").Value
    '            datos15.cod_material = fila.Cells("codmaterial").Value
    '            datos15.valor_central = fila.Cells("valor").Value
    '            datos15.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos15) Then
    '                'MessageBox.Show("Correcto")
    '            Else
    '                ' MessageBox.Show("Mal")
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    '    For Each fila In dgvr16.Rows
    '        Try
    '            datos16.cod_vivienda = fila.Cells("codvivienda").Value
    '            datos16.cod_antiguedada = fila.Cells("codantiguedad").Value
    '            datos16.cod_estado = fila.Cells("codestado").Value
    '            datos16.cod_material = fila.Cells("codmaterial").Value
    '            datos16.valor_central = fila.Cells("valor").Value
    '            datos16.annio_central = cbxAnnioShare.Text
    '            If conexion.insertarDatosClie(datos16) Then
    '            Else                    ' 
    '            End If
    '        Catch fallo As Exception
    '            MsgBox(fallo.ToString)
    '        Finally
    '        End Try
    '    Next
    'End Sub

    ''Listamos el contenido de la base de datos en las tablas
    'Private Sub listar_codigo_depreciacion(ByVal fecha As String)
    '    _dtsdep1.Reset()
    '    consulta_datos_central_r1(fecha)
    '    dgvr1.DataSource = _dtsdep1.Tables(0)
    '    dgvr1.Columns("id").Visible = False
    '    dgvr1.Columns("codvivienda").Visible = False
    '    dgvr1.Columns("codantiguedad").Visible = False
    '    dgvr1.Columns("codestado").Visible = False
    '    dgvr1.Columns("codmaterial").Visible = False
    '    dgvr1.Columns("anio").Visible = False
    '    dgvr1.ScrollBars = ScrollBars.None
    '    dgvr1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep2.Reset()
    '    consulta_datos_central_r2(fecha)
    '    dgvr2.DataSource = _dtsdep2.Tables(0)
    '    dgvr2.Columns("id").Visible = False
    '    dgvr2.Columns("codvivienda").Visible = False
    '    dgvr2.Columns("codantiguedad").Visible = False
    '    dgvr2.Columns("codestado").Visible = False
    '    dgvr2.Columns("codmaterial").Visible = False
    '    dgvr2.Columns("anio").Visible = False
    '    dgvr2.ScrollBars = ScrollBars.None
    '    dgvr2.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep3.Reset()
    '    consulta_datos_central_r3(fecha)
    '    dgvr3.DataSource = _dtsdep3.Tables(0)
    '    dgvr3.Columns("id").Visible = False
    '    dgvr3.Columns("codvivienda").Visible = False
    '    dgvr3.Columns("codantiguedad").Visible = False
    '    dgvr3.Columns("codestado").Visible = False
    '    dgvr3.Columns("codmaterial").Visible = False
    '    dgvr3.Columns("anio").Visible = False
    '    dgvr3.ScrollBars = ScrollBars.None
    '    dgvr3.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep4.Reset()
    '    consulta_datos_central_r4(fecha)
    '    dgvr4.DataSource = _dtsdep4.Tables(0)
    '    dgvr4.Columns("id").Visible = False
    '    dgvr4.Columns("codvivienda").Visible = False
    '    dgvr4.Columns("codantiguedad").Visible = False
    '    dgvr4.Columns("codestado").Visible = False
    '    dgvr4.Columns("codmaterial").Visible = False
    '    dgvr4.Columns("anio").Visible = False
    '    dgvr4.ScrollBars = ScrollBars.None
    '    dgvr4.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep5.Reset()
    '    consulta_datos_central_r5(fecha)
    '    dgvr5.DataSource = _dtsdep5.Tables(0)
    '    dgvr5.Columns("id").Visible = False
    '    dgvr5.Columns("codvivienda").Visible = False
    '    dgvr5.Columns("codantiguedad").Visible = False
    '    dgvr5.Columns("codestado").Visible = False
    '    dgvr5.Columns("codmaterial").Visible = False
    '    dgvr5.Columns("anio").Visible = False
    '    dgvr5.ScrollBars = ScrollBars.None
    '    dgvr5.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep6.Reset()
    '    consulta_datos_central_r6(fecha)
    '    dgvr6.DataSource = _dtsdep6.Tables(0)
    '    dgvr6.Columns("id").Visible = False
    '    dgvr6.Columns("codvivienda").Visible = False
    '    dgvr6.Columns("codantiguedad").Visible = False
    '    dgvr6.Columns("codestado").Visible = False
    '    dgvr6.Columns("codmaterial").Visible = False
    '    dgvr6.Columns("anio").Visible = False
    '    dgvr6.ScrollBars = ScrollBars.None
    '    dgvr6.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep7.Reset()
    '    consulta_datos_central_r7(fecha)
    '    dgvr7.DataSource = _dtsdep7.Tables(0)
    '    dgvr7.Columns("id").Visible = False
    '    dgvr7.Columns("codvivienda").Visible = False
    '    dgvr7.Columns("codantiguedad").Visible = False
    '    dgvr7.Columns("codestado").Visible = False
    '    dgvr7.Columns("codmaterial").Visible = False
    '    dgvr7.Columns("anio").Visible = False
    '    dgvr7.ScrollBars = ScrollBars.None
    '    dgvr7.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep8.Reset()
    '    consulta_datos_central_r8(fecha)
    '    dgvr8.DataSource = _dtsdep8.Tables(0)
    '    dgvr8.Columns("id").Visible = False
    '    dgvr8.Columns("codvivienda").Visible = False
    '    dgvr8.Columns("codantiguedad").Visible = False
    '    dgvr8.Columns("codestado").Visible = False
    '    dgvr8.Columns("codmaterial").Visible = False
    '    dgvr8.Columns("anio").Visible = False
    '    dgvr8.ScrollBars = ScrollBars.None
    '    dgvr8.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep9.Reset()
    '    consulta_datos_central_r9(fecha)
    '    dgvr9.DataSource = _dtsdep9.Tables(0)
    '    dgvr9.Columns("id").Visible = False
    '    dgvr9.Columns("codvivienda").Visible = False
    '    dgvr9.Columns("codantiguedad").Visible = False
    '    dgvr9.Columns("codestado").Visible = False
    '    dgvr9.Columns("codmaterial").Visible = False
    '    dgvr9.Columns("anio").Visible = False
    '    dgvr9.ScrollBars = ScrollBars.None
    '    dgvr9.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep10.Reset()
    '    consulta_datos_central_r10(fecha)
    '    dgvr10.DataSource = _dtsdep10.Tables(0)
    '    dgvr10.Columns("id").Visible = False
    '    dgvr10.Columns("codvivienda").Visible = False
    '    dgvr10.Columns("codantiguedad").Visible = False
    '    dgvr10.Columns("codestado").Visible = False
    '    dgvr10.Columns("codmaterial").Visible = False
    '    dgvr10.Columns("anio").Visible = False
    '    dgvr10.ScrollBars = ScrollBars.None
    '    dgvr10.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep11.Reset()
    '    consulta_datos_central_r11(fecha)
    '    dgvr11.DataSource = _dtsdep11.Tables(0)
    '    dgvr11.Columns("id").Visible = False
    '    dgvr11.Columns("codvivienda").Visible = False
    '    dgvr11.Columns("codantiguedad").Visible = False
    '    dgvr11.Columns("codestado").Visible = False
    '    dgvr11.Columns("codmaterial").Visible = False
    '    dgvr11.Columns("anio").Visible = False
    '    dgvr11.ScrollBars = ScrollBars.None
    '    dgvr11.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep12.Reset()
    '    consulta_datos_central_r12(fecha)
    '    dgvr12.DataSource = _dtsdep12.Tables(0)
    '    dgvr12.Columns("id").Visible = False
    '    dgvr12.Columns("codvivienda").Visible = False
    '    dgvr12.Columns("codantiguedad").Visible = False
    '    dgvr12.Columns("codestado").Visible = False
    '    dgvr12.Columns("codmaterial").Visible = False
    '    dgvr12.Columns("anio").Visible = False
    '    dgvr12.ScrollBars = ScrollBars.None
    '    dgvr12.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep13.Reset()
    '    consulta_datos_central_r13(fecha)
    '    dgvr13.DataSource = _dtsdep13.Tables(0)
    '    dgvr13.Columns("id").Visible = False
    '    dgvr13.Columns("codvivienda").Visible = False
    '    dgvr13.Columns("codantiguedad").Visible = False
    '    dgvr13.Columns("codestado").Visible = False
    '    dgvr13.Columns("codmaterial").Visible = False
    '    dgvr13.Columns("anio").Visible = False
    '    dgvr13.ScrollBars = ScrollBars.None
    '    dgvr13.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep14.Reset()
    '    consulta_datos_central_r14(fecha)
    '    dgvr14.DataSource = _dtsdep14.Tables(0)
    '    dgvr14.Columns("id").Visible = False
    '    dgvr14.Columns("codvivienda").Visible = False
    '    dgvr14.Columns("codantiguedad").Visible = False
    '    dgvr14.Columns("codestado").Visible = False
    '    dgvr14.Columns("codmaterial").Visible = False
    '    dgvr14.Columns("anio").Visible = False
    '    dgvr14.ScrollBars = ScrollBars.None
    '    dgvr14.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep15.Reset()
    '    consulta_datos_central_r15(fecha)
    '    dgvr15.DataSource = _dtsdep15.Tables(0)
    '    dgvr15.Columns("id").Visible = False
    '    dgvr15.Columns("codvivienda").Visible = False
    '    dgvr15.Columns("codantiguedad").Visible = False
    '    dgvr15.Columns("codestado").Visible = False
    '    dgvr15.Columns("codmaterial").Visible = False
    '    dgvr15.Columns("anio").Visible = False
    '    dgvr15.ScrollBars = ScrollBars.None
    '    dgvr15.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    '-----------------------------------------------------------------'
    '    _dtsdep16.Reset()
    '    consulta_datos_central_r16(fecha)
    '    dgvr16.DataSource = _dtsdep16.Tables(0)
    '    dgvr16.Columns("id").Visible = False
    '    dgvr16.Columns("codvivienda").Visible = False
    '    dgvr16.Columns("codantiguedad").Visible = False
    '    dgvr16.Columns("codestado").Visible = False
    '    dgvr16.Columns("codmaterial").Visible = False
    '    dgvr16.Columns("anio").Visible = False
    '    dgvr16.ScrollBars = ScrollBars.None
    '    dgvr16.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
    '    lista_material()

    'End Sub
    'Private Sub modificar_depreciacion(nfila)
    '    Dim idCodigo As New Integer
    '    Dim Myfrm As New Dep_edit
    '    Dim fila As New Integer
    '    If nfila = 1 Then
    '        fila = dgvr1.CurrentRow.Index
    '    End If
    '    If nfila = 2 Then
    '        fila = dgvr2.CurrentRow.Index
    '    End If
    '    If nfila = 3 Then
    '        fila = dgvr3.CurrentRow.Index
    '    End If
    '    If nfila = 4 Then
    '        fila = dgvr4.CurrentRow.Index
    '    End If
    '    If nfila = 5 Then
    '        fila = dgvr5.CurrentRow.Index
    '    End If
    '    If nfila = 6 Then
    '        fila = dgvr6.CurrentRow.Index
    '    End If
    '    If nfila = 7 Then
    '        fila = dgvr7.CurrentRow.Index
    '    End If
    '    If nfila = 8 Then
    '        fila = dgvr8.CurrentRow.Index
    '    End If
    '    If nfila = 9 Then
    '        fila = dgvr9.CurrentRow.Index
    '    End If
    '    If nfila = 10 Then
    '        fila = dgvr10.CurrentRow.Index
    '    End If
    '    If nfila = 11 Then
    '        fila = dgvr11.CurrentRow.Index
    '    End If
    '    If nfila = 12 Then
    '        fila = dgvr12.CurrentRow.Index
    '    End If
    '    If nfila = 13 Then
    '        fila = dgvr13.CurrentRow.Index
    '    End If
    '    If nfila = 14 Then
    '        fila = dgvr14.CurrentRow.Index
    '    End If
    '    If nfila = 15 Then
    '        fila = dgvr15.CurrentRow.Index
    '    End If
    '    If nfila = 16 Then
    '        fila = dgvr16.CurrentRow.Index
    '    End If

    '    'If e.KeyCode = Keys.Enter Then
    '    'MsgBox("id " + dgvr1.Item(0, fila).Value.ToString)
    '    'End If
    '    idCodigo = dgvr1.Item(0, fila).Value
    '    Myfrm.codigoDep = idCodigo
    '    Myfrm.Visible = True
    '    Myfrm.Show()
    'End Sub

    'Private Sub dgvr2_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr2.KeyDown
    '    modificar_depreciacion(2)
    'End Sub

    'Private Sub dgvr3_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr3.KeyDown
    '    modificar_depreciacion(3)
    'End Sub

    'Private Sub dgvr4_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr4.KeyDown
    '    modificar_depreciacion(4)
    'End Sub

    'Private Sub dgvr5_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr5.KeyDown
    '    modificar_depreciacion(5)
    'End Sub

    'Private Sub dgvr6_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr6.KeyDown
    '    modificar_depreciacion(6)
    'End Sub

    'Private Sub dgvr7_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr7.KeyDown
    '    modificar_depreciacion(7)
    'End Sub

    'Private Sub dgvr8_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr8.KeyDown
    '    modificar_depreciacion(8)
    'End Sub

    'Private Sub dgvr9_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr9.KeyDown
    '    modificar_depreciacion(9)
    'End Sub

    'Private Sub dgvr10_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr10.KeyDown
    '    modificar_depreciacion(10)
    'End Sub

    'Private Sub dgvr11_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr11.KeyDown
    '    modificar_depreciacion(11)
    'End Sub

    'Private Sub dgvr12_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr12.KeyDown
    '    modificar_depreciacion(12)
    'End Sub

    'Private Sub dgvr13_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr13.KeyDown
    '    modificar_depreciacion(13)
    'End Sub

    'Private Sub dgvr14_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr14.KeyDown
    '    modificar_depreciacion(14)
    'End Sub

    'Private Sub dgvr15_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr15.KeyDown
    '    modificar_depreciacion(15)
    'End Sub

    'Private Sub dgvr16_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr16.KeyDown
    '    modificar_depreciacion(16)
    'End Sub
End Class
