Public Class uc_rentas_catalogo_depreciacion
    Private Sub cbxAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAnio.SelectedIndexChanged
        Try
            Dim anio As New Integer
            Dim modulo As String
            anio = cbxAnio.Text
            modulo = "depreciacion"
            listar_codigo_depreciacion(anio)
            'Consulta si tabla de depreciacion esta abierta
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, anio)
            If _DatasetCerrar.Tables(0).Rows.Count = 0 Then
                lblinfo_tabla.Text = ""
                btnCerrar.Text = "Bloqueado"
                btnCerrar.Image = My.Resources.blockeado
                btnCerrar.BackColor = Color.FromArgb(128, 131, 140)
                btnCerrar.Enabled = False
            Else
                For Each row In _DatasetCerrar.Tables(0).Rows
                    If row("estado") = "abierto" Then

                        btnCerrar.Visible = True
                        btnCerrar.Text = "Cerrar Depreciación"
                        btnCerrar.Image = My.Resources.cerrar_white
                        btnCerrar.BackColor = Color.FromArgb(150, 193, 31)
                        btnCerrar.Enabled = True
                        lblinfo_tabla.Text = ""
                    Else
                        lblinfo_tabla.Text = "Tabla de depreciación cerrada"
                        btnCerrar.Text = "Cerrar Depreciación"
                        btnCerrar.Image = My.Resources.padlock
                        btnCerrar.BackColor = Color.FromArgb(255, 140, 1)
                        btnCerrar.Enabled = False
                    End If
                Next
            End If
            _DatasetDepreciasion.Reset()
            consulta_depreciacion_by_annio(cbxAnio.Text)
            If _DatasetDepreciasion.Tables(0).Rows.Count > 0 Then
                btnNuevo.Text = "Datos Generados"
                btnNuevo.Image = My.Resources.engranaje
                btnNuevo.BackColor = Color.FromArgb(128, 131, 140)
                btnNuevo.Enabled = False
                barProgres.Value = False
            Else
                btnNuevo.Text = "Generar Datos"
                btnNuevo.Image = My.Resources.engranaje
                btnNuevo.BackColor = Color.FromArgb(150, 193, 31)
                btnNuevo.Enabled = True
            End If
            barProgres.Value = False
        Catch
        End Try
    End Sub
    Public Sub listar_codigo_depreciacion(ByVal fecha As String)
        _dtsdep1.Reset()
        consulta_datos_central_r1(fecha)
        dgvr1.DataSource = _dtsdep1.Tables(0)
        dgvr1.Columns("iddepreciacion").Visible = False
        dgvr1.Columns("cod_clasificacion").Visible = False
        dgvr1.Columns("cod_antiguedad").Visible = False
        dgvr1.Columns("cod_material").Visible = False
        dgvr1.Columns("cod_conservacion").Visible = False
        dgvr1.Columns("anno").Visible = False
        dgvr1.ScrollBars = ScrollBars.None
        dgvr1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr1.ClearSelection()
        Dim contador As New Integer
        contador = 0
        For Each row In _dtsdep1.Tables(0).Rows
            contador = contador + 1
            If contador < 3 Then
                'dgvr1.Rows(dgvr1.CurrentCell.RowIndex).Cells = Color.Azure
            End If
        Next
        '-----------------------------------------------------------------'
        _dtsdep2.Reset()
        consulta_datos_central_r2(fecha)
        dgvr2.DataSource = _dtsdep2.Tables(0)
        dgvr2.Columns("iddepreciacion").Visible = False
        dgvr2.Columns("cod_clasificacion").Visible = False
        dgvr2.Columns("cod_antiguedad").Visible = False
        dgvr2.Columns("cod_material").Visible = False
        dgvr2.Columns("cod_conservacion").Visible = False
        dgvr2.Columns("anno").Visible = False
        dgvr2.ScrollBars = ScrollBars.None
        dgvr2.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr2.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep3.Reset()
        consulta_datos_central_r3(fecha)
        dgvr3.DataSource = _dtsdep3.Tables(0)
        dgvr3.Columns("iddepreciacion").Visible = False
        dgvr3.Columns("cod_clasificacion").Visible = False
        dgvr3.Columns("cod_antiguedad").Visible = False
        dgvr3.Columns("cod_material").Visible = False
        dgvr3.Columns("cod_conservacion").Visible = False
        dgvr3.Columns("anno").Visible = False
        dgvr3.ScrollBars = ScrollBars.None
        dgvr3.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr3.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep4.Reset()
        consulta_datos_central_r4(fecha)
        dgvr4.DataSource = _dtsdep4.Tables(0)
        dgvr4.Columns("iddepreciacion").Visible = False
        dgvr4.Columns("cod_clasificacion").Visible = False
        dgvr4.Columns("cod_antiguedad").Visible = False
        dgvr4.Columns("cod_material").Visible = False
        dgvr4.Columns("cod_conservacion").Visible = False
        dgvr4.Columns("anno").Visible = False
        dgvr4.ScrollBars = ScrollBars.None
        dgvr4.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr4.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep5.Reset()
        consulta_datos_central_r5(fecha)
        dgvr5.DataSource = _dtsdep5.Tables(0)
        dgvr5.Columns("iddepreciacion").Visible = False
        dgvr5.Columns("cod_clasificacion").Visible = False
        dgvr5.Columns("cod_antiguedad").Visible = False
        dgvr5.Columns("cod_material").Visible = False
        dgvr5.Columns("cod_conservacion").Visible = False
        dgvr5.Columns("anno").Visible = False
        dgvr5.ScrollBars = ScrollBars.None
        dgvr5.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr5.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep6.Reset()
        consulta_datos_central_r6(fecha)
        dgvr6.DataSource = _dtsdep6.Tables(0)
        dgvr6.Columns("iddepreciacion").Visible = False
        dgvr6.Columns("cod_clasificacion").Visible = False
        dgvr6.Columns("cod_antiguedad").Visible = False
        dgvr6.Columns("cod_material").Visible = False
        dgvr6.Columns("cod_conservacion").Visible = False
        dgvr6.Columns("anno").Visible = False
        dgvr6.ScrollBars = ScrollBars.None
        dgvr6.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr6.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep7.Reset()
        consulta_datos_central_r7(fecha)
        dgvr7.DataSource = _dtsdep7.Tables(0)
        dgvr7.Columns("iddepreciacion").Visible = False
        dgvr7.Columns("cod_clasificacion").Visible = False
        dgvr7.Columns("cod_antiguedad").Visible = False
        dgvr7.Columns("cod_material").Visible = False
        dgvr7.Columns("cod_conservacion").Visible = False
        dgvr7.Columns("anno").Visible = False
        dgvr7.ScrollBars = ScrollBars.None
        dgvr7.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr7.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep8.Reset()
        consulta_datos_central_r8(fecha)
        dgvr8.DataSource = _dtsdep8.Tables(0)
        dgvr8.Columns("iddepreciacion").Visible = False
        dgvr8.Columns("cod_clasificacion").Visible = False
        dgvr8.Columns("cod_antiguedad").Visible = False
        dgvr8.Columns("cod_material").Visible = False
        dgvr8.Columns("cod_conservacion").Visible = False
        dgvr8.Columns("anno").Visible = False
        dgvr8.ScrollBars = ScrollBars.None
        dgvr8.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr8.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep9.Reset()
        consulta_datos_central_r9(fecha)
        dgvr9.DataSource = _dtsdep9.Tables(0)
        dgvr9.Columns("iddepreciacion").Visible = False
        dgvr9.Columns("cod_clasificacion").Visible = False
        dgvr9.Columns("cod_antiguedad").Visible = False
        dgvr9.Columns("cod_material").Visible = False
        dgvr9.Columns("cod_conservacion").Visible = False
        dgvr9.Columns("anno").Visible = False
        dgvr9.ScrollBars = ScrollBars.None
        dgvr9.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr9.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep10.Reset()
        consulta_datos_central_r10(fecha)
        dgvr10.DataSource = _dtsdep10.Tables(0)
        dgvr10.Columns("iddepreciacion").Visible = False
        dgvr10.Columns("cod_clasificacion").Visible = False
        dgvr10.Columns("cod_antiguedad").Visible = False
        dgvr10.Columns("cod_material").Visible = False
        dgvr10.Columns("cod_conservacion").Visible = False
        dgvr10.Columns("anno").Visible = False
        dgvr10.ScrollBars = ScrollBars.None
        dgvr10.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr10.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep11.Reset()
        consulta_datos_central_r11(fecha)
        dgvr11.DataSource = _dtsdep11.Tables(0)
        dgvr11.Columns("iddepreciacion").Visible = False
        dgvr11.Columns("cod_clasificacion").Visible = False
        dgvr11.Columns("cod_antiguedad").Visible = False
        dgvr11.Columns("cod_material").Visible = False
        dgvr11.Columns("cod_conservacion").Visible = False
        dgvr11.Columns("anno").Visible = False
        dgvr11.ScrollBars = ScrollBars.None
        dgvr11.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr11.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep12.Reset()
        consulta_datos_central_r12(fecha)
        dgvr12.DataSource = _dtsdep12.Tables(0)
        dgvr12.Columns("iddepreciacion").Visible = False
        dgvr12.Columns("cod_clasificacion").Visible = False
        dgvr12.Columns("cod_antiguedad").Visible = False
        dgvr12.Columns("cod_material").Visible = False
        dgvr12.Columns("cod_conservacion").Visible = False
        dgvr12.Columns("anno").Visible = False
        dgvr12.ScrollBars = ScrollBars.None
        dgvr12.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr12.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep13.Reset()
        consulta_datos_central_r13(fecha)
        dgvr13.DataSource = _dtsdep13.Tables(0)
        dgvr13.Columns("iddepreciacion").Visible = False
        dgvr13.Columns("cod_clasificacion").Visible = False
        dgvr13.Columns("cod_antiguedad").Visible = False
        dgvr13.Columns("cod_material").Visible = False
        dgvr13.Columns("cod_conservacion").Visible = False
        dgvr13.Columns("anno").Visible = False
        dgvr13.ScrollBars = ScrollBars.None
        dgvr13.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr13.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep14.Reset()
        consulta_datos_central_r14(fecha)
        dgvr14.DataSource = _dtsdep14.Tables(0)
        dgvr14.Columns("iddepreciacion").Visible = False
        dgvr14.Columns("cod_clasificacion").Visible = False
        dgvr14.Columns("cod_antiguedad").Visible = False
        dgvr14.Columns("cod_material").Visible = False
        dgvr14.Columns("cod_conservacion").Visible = False
        dgvr14.Columns("anno").Visible = False
        dgvr14.ScrollBars = ScrollBars.None
        dgvr14.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr14.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep15.Reset()
        consulta_datos_central_r15(fecha)
        dgvr15.DataSource = _dtsdep15.Tables(0)
        dgvr15.Columns("iddepreciacion").Visible = False
        dgvr15.Columns("cod_clasificacion").Visible = False
        dgvr15.Columns("cod_antiguedad").Visible = False
        dgvr15.Columns("cod_material").Visible = False
        dgvr15.Columns("cod_conservacion").Visible = False
        dgvr15.Columns("anno").Visible = False
        dgvr15.ScrollBars = ScrollBars.None
        dgvr15.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr15.ClearSelection()
        '-----------------------------------------------------------------'
        _dtsdep16.Reset()
        consulta_datos_central_r16(fecha)
        dgvr16.DataSource = _dtsdep16.Tables(0)
        dgvr16.Columns("iddepreciacion").Visible = False
        dgvr16.Columns("cod_clasificacion").Visible = False
        dgvr16.Columns("cod_antiguedad").Visible = False
        dgvr16.Columns("cod_material").Visible = False
        dgvr16.Columns("cod_conservacion").Visible = False
        dgvr16.Columns("anno").Visible = False
        dgvr16.ScrollBars = ScrollBars.None
        dgvr16.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 7)
        dgvr16.ClearSelection()
        lista_material()
    End Sub
    Private Sub lista_material()
        dgvMaterial1.Rows.Add("Concreto")
        dgvMaterial1.Rows.Add("Ladrillo")
        dgvMaterial1.Rows.Add("Adobe")
        dgvMaterial1.ClearSelection()
        dgvMaterial2.Rows.Add("Concreto")
        dgvMaterial2.Rows.Add("Ladrillo")
        dgvMaterial2.Rows.Add("Adobe")
        dgvMaterial2.ClearSelection()
        dgvMaterial3.Rows.Add("Concreto")
        dgvMaterial3.Rows.Add("Ladrillo")
        dgvMaterial3.Rows.Add("Adobe")
        dgvMaterial3.ClearSelection()
        dgvMaterial4.Rows.Add("Concreto")
        dgvMaterial4.Rows.Add("Ladrillo")
        dgvMaterial4.Rows.Add("Adobe")
        dgvMaterial4.ClearSelection()
        dgvMaterial5.Rows.Add("Concreto")
        dgvMaterial5.Rows.Add("Ladrillo")
        dgvMaterial5.Rows.Add("Adobe")
        dgvMaterial5.ClearSelection()
        dgvMaterial6.Rows.Add("Concreto")
        dgvMaterial6.Rows.Add("Ladrillo")
        dgvMaterial6.Rows.Add("Adobe")
        dgvMaterial6.ClearSelection()
        dgvMaterial7.Rows.Add("Concreto")
        dgvMaterial7.Rows.Add("Ladrillo")
        dgvMaterial7.Rows.Add("Adobe")
        dgvMaterial7.ClearSelection()
        dgvMaterial8.Rows.Add("Concreto")
        dgvMaterial8.Rows.Add("Ladrillo")
        dgvMaterial8.Rows.Add("Adobe")
        dgvMaterial8.ClearSelection()
        dgvMaterial9.Rows.Add("Concreto")
        dgvMaterial9.Rows.Add("Ladrillo")
        dgvMaterial9.Rows.Add("Adobe")
        dgvMaterial9.ClearSelection()
        dgvMaterial10.Rows.Add("Concreto")
        dgvMaterial10.Rows.Add("Ladrillo")
        dgvMaterial10.Rows.Add("Adobe")
        dgvMaterial10.ClearSelection()
        dgvMaterial11.Rows.Add("Concreto")
        dgvMaterial11.Rows.Add("Ladrillo")
        dgvMaterial11.Rows.Add("Adobe")
        dgvMaterial11.ClearSelection()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        '_DatasetDepreciasion.Reset()
        'consulta_depreciacion_by_annio(cbxAnnioGenerar.Text)
        'If _DatasetDepreciasion.Tables(0).Rows.Count > 0 Then
        '    MessageBox.Show("Uds. ya ha generado una tabla de depreciacion para este año")
        'Else
        '    Dim conexion As New class_controller_depreciacion
        '    Dim datos, datos2, datos3, datos4, datos5, datos6, datos7, datos8, datos9, datos10, datos11, datos12, datos13, datos14, datos15, datos16 As New class_datos_depreciacion
        '    Dim estado As New Boolean
        '    For Each fila In dgvr1.Rows
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos.material_depreciacion = fila.Cells("cod_material").Value
        '            datos.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos.valor_depreciacion = fila.Cells("valor").Value
        '            datos.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos) Then
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
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos2.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos2.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos2.material_depreciacion = fila.Cells("cod_material").Value
        '            datos2.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos2.valor_depreciacion = fila.Cells("valor").Value
        '            datos2.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos2) Then
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
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos3.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos3.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos3.material_depreciacion = fila.Cells("cod_material").Value
        '            datos3.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos3.valor_depreciacion = fila.Cells("valor").Value
        '            datos3.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos3) Then
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
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos4.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos4.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos4.material_depreciacion = fila.Cells("cod_material").Value
        '            datos4.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos4.valor_depreciacion = fila.Cells("valor").Value
        '            datos4.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos4) Then
        '                'MessageBox.Show("Correcto")
        '            Else
        '                ' MessageBox.Show("Mal")
        '            End If
        '        Catch fallo As Exception
        '            MsgBox(fallo.ToString)
        '        Finally
        '        End Try
        '    Next
        '    For Each fila In dgvr5.Rows
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos5.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos5.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos5.material_depreciacion = fila.Cells("cod_material").Value
        '            datos5.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos5.valor_depreciacion = fila.Cells("valor").Value
        '            datos5.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos5) Then
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
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos6.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos6.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos6.material_depreciacion = fila.Cells("cod_material").Value
        '            datos6.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos6.valor_depreciacion = fila.Cells("valor").Value
        '            datos6.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos6) Then
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
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos7.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos7.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos7.material_depreciacion = fila.Cells("cod_material").Value
        '            datos7.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos7.valor_depreciacion = fila.Cells("valor").Value
        '            datos7.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos7) Then
        '                'MessageBox.Show("Correcto")
        '            Else
        '                ' MessageBox.Show("Mal")
        '            End If
        '        Catch fallo As Exception
        '            MsgBox(fallo.ToString)
        '        Finally
        '        End Try
        '    Next
        '    For Each fila In dgvr8.Rows
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos8.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos8.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos8.material_depreciacion = fila.Cells("cod_material").Value
        '            datos8.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos8.valor_depreciacion = fila.Cells("valor").Value
        '            datos8.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos8) Then
        '                'MessageBox.Show("Correcto")
        '            Else
        '                ' MessageBox.Show("Mal")
        '            End If
        '        Catch fallo As Exception
        '            MsgBox(fallo.ToString)
        '        Finally
        '        End Try
        '    Next
        '    For Each fila In dgvr9.Rows
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos9.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos9.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos9.material_depreciacion = fila.Cells("cod_material").Value
        '            datos9.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos9.valor_depreciacion = fila.Cells("valor").Value
        '            datos9.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos9) Then
        '                'MessageBox.Show("Correcto")
        '            Else
        '                ' MessageBox.Show("Mal")
        '            End If
        '        Catch fallo As Exception
        '            MsgBox(fallo.ToString)
        '        Finally
        '        End Try
        '    Next
        '    For Each fila In dgvr10.Rows
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos10.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos10.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos10.material_depreciacion = fila.Cells("cod_material").Value
        '            datos10.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos10.valor_depreciacion = fila.Cells("valor").Value
        '            datos10.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos10) Then
        '                'MessageBox.Show("Correcto")
        '            Else
        '                ' MessageBox.Show("Mal")
        '            End If
        '        Catch fallo As Exception
        '            MsgBox(fallo.ToString)
        '        Finally
        '        End Try
        '    Next
        '    For Each fila In dgvr11.Rows
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos11.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos11.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos11.material_depreciacion = fila.Cells("cod_material").Value
        '            datos11.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos11.valor_depreciacion = fila.Cells("valor").Value
        '            datos11.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos11) Then
        '                'MessageBox.Show("Correcto")
        '            Else
        '                ' MessageBox.Show("Mal")
        '            End If
        '        Catch fallo As Exception
        '            MsgBox(fallo.ToString)
        '        Finally
        '        End Try
        '    Next
        '    For Each fila In dgvr12.Rows
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos12.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos12.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos12.material_depreciacion = fila.Cells("cod_material").Value
        '            datos12.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos12.valor_depreciacion = fila.Cells("valor").Value
        '            datos12.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos12) Then
        '                'MessageBox.Show("Correcto")
        '            Else
        '                ' MessageBox.Show("Mal")
        '            End If
        '        Catch fallo As Exception
        '            MsgBox(fallo.ToString)
        '        Finally
        '        End Try
        '    Next
        '    For Each fila In dgvr13.Rows
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos13.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos13.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos13.material_depreciacion = fila.Cells("cod_material").Value
        '            datos13.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos13.valor_depreciacion = fila.Cells("valor").Value
        '            datos13.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos13) Then
        '                'MessageBox.Show("Correcto")
        '            Else
        '                ' MessageBox.Show("Mal")
        '            End If
        '        Catch fallo As Exception
        '            MsgBox(fallo.ToString)
        '        Finally
        '        End Try
        '    Next
        '    For Each fila In dgvr14.Rows
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos14.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos14.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos14.material_depreciacion = fila.Cells("cod_material").Value
        '            datos14.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos14.valor_depreciacion = fila.Cells("valor").Value
        '            datos14.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos14) Then
        '                'MessageBox.Show("Correcto")
        '            Else
        '                ' MessageBox.Show("Mal")
        '            End If
        '        Catch fallo As Exception
        '            MsgBox(fallo.ToString)
        '        Finally
        '        End Try
        '    Next
        '    For Each fila In dgvr15.Rows
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos15.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos15.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos15.material_depreciacion = fila.Cells("cod_material").Value
        '            datos15.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos15.valor_depreciacion = fila.Cells("valor").Value
        '            datos15.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos15) Then
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
        '        'MessageBox.Show("fila " + dgvr1.Rows.Count.ToString)
        '        Try
        '            datos16.clasificacion_depreciacion = fila.Cells("cod_clasificacion").Value
        '            datos16.antiguedad_depreciacion = fila.Cells("cod_antiguedad").Value
        '            datos16.material_depreciacion = fila.Cells("cod_material").Value
        '            datos16.conservacion_depreciacion = fila.Cells("cod_conservacion").Value
        '            datos16.valor_depreciacion = fila.Cells("valor").Value
        '            datos16.annio_depreciacion = Integer.Parse(cbxAnnioGenerar.Text)
        '            If conexion.insertarDatosDepreciacion(datos16) Then
        '                'MessageBox.Show("Correcto")
        '            Else
        '                ' MessageBox.Show("Mal")
        '            End If
        '        Catch fallo As Exception
        '            MsgBox(fallo.ToString)
        '        Finally
        '        End Try
        '    Next
        '    Dim datosC As New class_datos_cerrar_periodo
        '    Dim controlC As New class_controller_cerrar_periodo
        '    datosC.modulo_cerrar = "depreciacion"
        '    datosC.annio_cerrar = cbxAnnioGenerar.Text
        '    datosC.estado_cerrar = "abierto"
        '    controlC.insertarDatosCerrar(datosC)
        'End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        'If CheckBox1.Checked = True Then
        '    GroupBox2.Enabled = True
        '    dgvr1.ReadOnly = False
        '    dgvr2.ReadOnly = False
        '    dgvr3.ReadOnly = False
        '    dgvr4.ReadOnly = False
        '    dgvr5.ReadOnly = False
        '    dgvr6.ReadOnly = False
        '    dgvr7.ReadOnly = False
        '    dgvr8.ReadOnly = False
        '    dgvr9.ReadOnly = False
        '    dgvr10.ReadOnly = False
        '    dgvr11.ReadOnly = False
        '    dgvr12.ReadOnly = False
        '    dgvr13.ReadOnly = False
        '    dgvr14.ReadOnly = False
        '    dgvr15.ReadOnly = False
        '    dgvr16.ReadOnly = False
        'Else
        '    GroupBox2.Enabled = False
        '    dgvr1.ReadOnly = True
        '    dgvr2.ReadOnly = True
        '    dgvr3.ReadOnly = True
        '    dgvr4.ReadOnly = True
        '    dgvr5.ReadOnly = True
        '    dgvr6.ReadOnly = True
        '    dgvr7.ReadOnly = True
        '    dgvr8.ReadOnly = True
        '    dgvr9.ReadOnly = True
        '    dgvr10.ReadOnly = True
        '    dgvr11.ReadOnly = True
        '    dgvr12.ReadOnly = True
        '    dgvr13.ReadOnly = True
        '    dgvr14.ReadOnly = True
        '    dgvr15.ReadOnly = True
        '    dgvr16.ReadOnly = True
        'End If
    End Sub

    Private Sub modificar_depreciacion(nfila)
        Dim idCodigo As New Integer
        Dim datoRecuperado As DialogResult
        Dim Myfrm As New Dep_edit
        Dim fila As New Integer
        Dim valor As Integer
        valor = 0
        If nfila = 1 Then
            fila = dgvr1.CurrentRow.Index
            idCodigo = dgvr1.Item(0, fila).Value
            valor = dgvr1.Item(5, fila).Value
        End If
        If nfila = 2 Then
            fila = dgvr2.CurrentRow.Index
            'MessageBox.Show("" + fila.ToString)
            idCodigo = dgvr2.Item(0, fila).Value
            valor = dgvr2.Item(5, fila).Value
        End If
        If nfila = 3 Then
            fila = dgvr3.CurrentRow.Index
            idCodigo = dgvr3.Item(0, fila).Value
            valor = dgvr3.Item(5, fila).Value
        End If
        If nfila = 4 Then
            fila = dgvr4.CurrentRow.Index
            idCodigo = dgvr4.Item(0, fila).Value
            valor = dgvr4.Item(5, fila).Value
        End If
        If nfila = 5 Then
            fila = dgvr5.CurrentRow.Index
            idCodigo = dgvr5.Item(0, fila).Value
            valor = dgvr5.Item(5, fila).Value
        End If
        If nfila = 6 Then
            fila = dgvr6.CurrentRow.Index
            idCodigo = dgvr6.Item(0, fila).Value
            valor = dgvr6.Item(5, fila).Value
        End If
        If nfila = 7 Then
            fila = dgvr7.CurrentRow.Index
            idCodigo = dgvr7.Item(0, fila).Value
            valor = dgvr7.Item(5, fila).Value
        End If
        If nfila = 8 Then
            fila = dgvr8.CurrentRow.Index
            idCodigo = dgvr8.Item(0, fila).Value
            valor = dgvr8.Item(5, fila).Value
        End If
        If nfila = 9 Then
            fila = dgvr9.CurrentRow.Index
            idCodigo = dgvr9.Item(0, fila).Value
            valor = dgvr9.Item(5, fila).Value
        End If
        If nfila = 10 Then
            fila = dgvr10.CurrentRow.Index
            idCodigo = dgvr10.Item(0, fila).Value
            valor = dgvr10.Item(5, fila).Value
        End If
        If nfila = 11 Then
            fila = dgvr11.CurrentRow.Index
            idCodigo = dgvr11.Item(0, fila).Value
            valor = dgvr11.Item(5, fila).Value
        End If
        If nfila = 12 Then
            fila = dgvr12.CurrentRow.Index
            idCodigo = dgvr12.Item(0, fila).Value
            valor = dgvr12.Item(5, fila).Value
        End If
        If nfila = 13 Then
            fila = dgvr13.CurrentRow.Index
            idCodigo = dgvr13.Item(0, fila).Value
            valor = dgvr13.Item(5, fila).Value
        End If
        If nfila = 14 Then
            fila = dgvr14.CurrentRow.Index
            idCodigo = dgvr14.Item(0, fila).Value
            valor = dgvr14.Item(5, fila).Value
        End If
        If nfila = 15 Then
            fila = dgvr15.CurrentRow.Index
            idCodigo = dgvr15.Item(0, fila).Value
            valor = dgvr15.Item(5, fila).Value
        End If
        If nfila = 16 Then
            fila = dgvr16.CurrentRow.Index
            idCodigo = dgvr16.Item(0, fila).Value
            valor = dgvr16.Item(5, fila).Value
        End If
        'MsgBox("" + valor.ToString)
        'If e.KeyCode = Keys.Enter Then
        'MsgBox("id " + idCodigo.ToString)
        'End If
        'idCodigo = dgvr1.Item(0, fila).Value
        'If CheckBox1.Checked = False Then
        actualizar_depreciacion(idCodigo, Integer.Parse(valor))
        'Myfrm.codigoDep = idCodigo
        'Myfrm.datos_annio = cbxAnio.Text
        'datoRecuperado = Myfrm.ShowDialog
        'If datoRecuperado = DialogResult.OK Then
        'listar_codigo_depreciacion(cbxAnio.Text)
        'End If
        'End If
    End Sub
    Sub actualizar_depreciacion(ByVal codigo As String, ByVal valor As Integer)
        Dim conexion As New class_controller_depreciacion
        Dim datos As New class_datos_depreciacion
        Dim modulo As String
        Dim annio As String
        modulo = "depreciacion"
        annio = cbxAnio.Text
        'If IsNumeric(valor) Then
        _DatasetCerrar.Reset()
        consulta_datos_cerrar_periodo_by(modulo, annio)
        For Each row In _DatasetCerrar.Tables(0).Rows
            If row("estado") = "abierto" Then
                'MessageBox.Show("Tabla esta abierto")
                ' If txtValor.Text = "" Then
                ' MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
                ' MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Else
                datos.id_depreciacion = codigo
                datos.valor_depreciacion = valor
                If conexion.actualizarDatoDepreciacion(datos) Then
                    'MessageBox.Show("Datos guardados")
                    listar_codigo_depreciacion(cbxAnio.Text)
                Else
                    MessageBox.Show("Datos no guardados")
                End If
                'End If
            Else
                MessageBox.Show("Uds. ha cerrado la tabla de depreciación para este año. En consecuencia ya no podra cambiarlo.", "Importante")
            End If
        Next
        'Else
        '   MsgBox("Ingrese solo numeros, no se admite letras.")
        'End If
    End Sub
    'Private Sub dgvr1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvr1.KeyDown

    '    If e.KeyCode = Keys.Enter Then
    '        modificar_depreciacion(1)
    '    End If
    'End Sub
    Private Sub dgvr2_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr2.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(2)
        End If
    End Sub

    Private Sub dgvr3_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr3.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(3)
        End If
    End Sub

    Private Sub dgvr4_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr4.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(4)
        End If
    End Sub

    Private Sub dgvr5_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr5.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(5)
        End If
    End Sub

    Private Sub dgvr6_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr6.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(6)
        End If
    End Sub

    Private Sub dgvr7_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr7.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(7)
        End If
    End Sub

    Private Sub dgvr8_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr8.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(8)
        End If
    End Sub

    Private Sub dgvr9_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr9.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(9)
        End If
    End Sub

    Private Sub dgvr10_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr10.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(10)
        End If
    End Sub

    Private Sub dgvr11_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr11.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(11)
        End If
    End Sub

    Private Sub dgvr12_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr12.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(12)
        End If
    End Sub

    Private Sub dgvr13_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr13.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(13)
        End If
    End Sub

    Private Sub dgvr14_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr14.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(14)
        End If
    End Sub

    Private Sub dgvr15_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr15.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(15)
        End If
    End Sub

    Private Sub dgvr16_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvr16.KeyDown
        If e.KeyCode = Keys.Enter Then
            modificar_depreciacion(16)
        End If
    End Sub

    Private Sub dgvr2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr2.CellClick
        dgvr1.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim datos As New class_datos_cerrar_periodo
        Dim control As New class_controller_cerrar_periodo
        datos.modulo_cerrar = "depreciacion"
        datos.annio_cerrar = cbxAnio.Text
        datos.estado_cerrar = "cerrado"
        If MessageBox.Show("Esta seguro que desea cerrar la tabla de de depreciación...!!!", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If control.actualizarDatosCerrar(datos) Then
                MsgBox("Tabla Cerrada")
                btnCerrar.Text = "Depreciación Cerrada"
                btnCerrar.Image = My.Resources.padlock
                btnCerrar.BackColor = Color.FromArgb(255, 140, 1)
                btnCerrar.Enabled = False
                lblinfo_tabla.Text = "tabla de depreciación cerrada"
                barProgres.Visible = False
            End If
        Else
        End If

    End Sub

    Private Sub dgvr1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr1.CellClick
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()

    End Sub

    Private Sub dgvr3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr3.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()

    End Sub

    Private Sub dgvr4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr4.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()

    End Sub

    Private Sub dgvr5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr5.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()

    End Sub

    Private Sub dgvr6_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr6.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()

    End Sub

    Private Sub dgvr7_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr7.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()

    End Sub

    Private Sub dgvr8_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr8.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()

    End Sub

    Private Sub dgvr9_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr9.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()

    End Sub

    Private Sub dgvr10_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr10.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()
    End Sub

    Private Sub dgvr11_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr11.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()
    End Sub

    Private Sub dgvr12_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr12.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()
    End Sub

    Private Sub dgvr13_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr13.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()
    End Sub

    Private Sub dgvr14_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr14.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr15.ClearSelection()
        dgvr16.ClearSelection()
    End Sub

    Private Sub dgvr15_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr15.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr16.ClearSelection()
    End Sub

    Private Sub dgvr16_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr16.CellClick
        dgvr1.ClearSelection()
        dgvr2.ClearSelection()
        dgvr3.ClearSelection()
        dgvr4.ClearSelection()
        dgvr5.ClearSelection()
        dgvr6.ClearSelection()
        dgvr7.ClearSelection()
        dgvr8.ClearSelection()
        dgvr9.ClearSelection()
        dgvr10.ClearSelection()
        dgvr11.ClearSelection()
        dgvr12.ClearSelection()
        dgvr13.ClearSelection()
        dgvr14.ClearSelection()
        dgvr15.ClearSelection()
    End Sub

    Private Sub uc_rentas_catalogo_depreciacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetAnnio.Reset()
        consulta_datos_annio()
        cbxAnio.DataSource = _DatasetAnnio.Tables("annio")
        cbxAnio.DisplayMember = "anno"
        cbxAnio.ValueMember = "idanno"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim datos As New class_datos_depreciacion
        Dim control As New class_controller_depreciacion
        Dim contador As New Integer
        contador = 0
        Try
            _DatasetDepreciasion.Reset()
            consulta_depreciacion_by_annio(cbxAnio.Text)
            If _DatasetDepreciasion.Tables(0).Rows.Count > 0 Then
                MessageBox.Show("Uds. ya ha generado una tabla de depreciacion para este año")
            Else
                barProgres.Visible = True
                barProgres.Maximum = 530
                barProgres.Value = 0
                For i As Integer = 1 To 4
                    For j As Integer = 1 To 11
                        For h As Integer = 1 To 3
                            For k As Integer = 1 To 4
                                'MsgBox("" + i.ToString + j.ToString + h.ToString + k.ToString)
                                contador = contador + 1
                                datos.clasificacion_depreciacion = i
                                datos.antiguedad_depreciacion = j
                                datos.material_depreciacion = h
                                datos.conservacion_depreciacion = k
                                datos.valor_depreciacion = 0
                                datos.annio_depreciacion = cbxAnio.Text
                                control.insertarDatosDepreciacion(datos)
                                barProgres.Value = contador
                            Next
                        Next
                    Next
                Next
                Dim datosC As New class_datos_cerrar_periodo
                Dim controlC As New class_controller_cerrar_periodo
                datosC.modulo_cerrar = "depreciacion"
                datosC.annio_cerrar = cbxAnio.Text
                datosC.estado_cerrar = "abierto"
                controlC.insertarDatosCerrar(datosC)
                'desabilitar boton
                btnNuevo.Text = "Datos Generados"
                btnNuevo.Image = My.Resources.engranaje
                btnNuevo.BackColor = Color.FromArgb(128, 131, 140)
                btnNuevo.Enabled = False
            End If
        Catch ex As Exception
        Finally
            listar_codigo_depreciacion(cbxAnio.Text)
            barProgres.Value = 0
            barProgres.Visible = False
            Dim anio As New Integer
            Dim modulo As String
            anio = cbxAnio.Text
            modulo = "depreciacion"
            listar_codigo_depreciacion(anio)
            'Consulta si tabla de depreciacion esta abierta
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, anio)
            If _DatasetCerrar.Tables(0).Rows.Count = 0 Then
                lblinfo_tabla.Text = ""
                btnCerrar.Visible = False
                btnCerrar.Text = "5"
            Else
                For Each row In _DatasetCerrar.Tables(0).Rows
                    If row("estado") = "abierto" Then
                        btnCerrar.Visible = True
                        lblinfo_tabla.Text = ""
                    Else
                        btnCerrar.Text = "5"
                        btnCerrar.Image = My.Resources.update_white
                        btnCerrar.BackColor = Color.FromArgb(128, 131, 140)
                        lblinfo_tabla.Text = "Tabla de depreciación cerrada"
                    End If
                Next
            End If
        End Try
    End Sub


    Private Sub dgvr1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr1.CellEndEdit
        modificar_depreciacion(1)
    End Sub

    Private Sub dgvr2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr2.CellEndEdit
        modificar_depreciacion(2)
    End Sub

    Private Sub dgvr3_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr3.CellEndEdit
        modificar_depreciacion(3)
    End Sub

    Private Sub dgvr4_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr4.CellEndEdit
        modificar_depreciacion(4)
    End Sub

    Private Sub dgvr5_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr5.CellEndEdit
        modificar_depreciacion(5)
    End Sub

    Private Sub dgvr6_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr6.CellEndEdit
        modificar_depreciacion(6)
    End Sub

    Private Sub dgvr7_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr7.CellEndEdit
        modificar_depreciacion(7)
    End Sub

    Private Sub dgvr8_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr8.CellEndEdit
        modificar_depreciacion(8)
    End Sub

    Private Sub dgvr9_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr9.CellEndEdit
        modificar_depreciacion(9)
    End Sub

    Private Sub dgvr10_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr10.CellEndEdit
        modificar_depreciacion(10)
    End Sub

    Private Sub dgvr11_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr11.CellEndEdit
        modificar_depreciacion(11)
    End Sub

    Private Sub dgvr12_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr12.CellEndEdit
        modificar_depreciacion(12)
    End Sub

    Private Sub dgvr13_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr13.CellEndEdit
        modificar_depreciacion(13)
    End Sub

    Private Sub dgvr14_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr14.CellEndEdit
        modificar_depreciacion(14)
    End Sub

    Private Sub dgvr15_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr15.CellEndEdit
        modificar_depreciacion(15)
    End Sub

    Private Sub dgvr16_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvr16.CellEndEdit
        modificar_depreciacion(16)
    End Sub

End Class
