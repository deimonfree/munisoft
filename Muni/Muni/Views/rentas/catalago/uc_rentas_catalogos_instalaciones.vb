Public Class uc_rentas_catalogos_instalaciones
    Private Sub uc_rentas_catalogos_instalaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetAnnio.Reset()
        consulta_datos_annio()
        cbxAnio.DataSource = _DatasetAnnio.Tables("annio")
        cbxAnio.DisplayMember = "anno"
        cbxAnio.ValueMember = "idanno"
    End Sub

    Private Sub cbxAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAnio.SelectedIndexChanged
        listar_tablas(cbxAnio.Text)
        Try
            Dim anio As New Integer
            Dim modulo As String
            anio = cbxAnio.Text
            modulo = "tasas"
            'Consulta si tabla de depreciacion esta abierta
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, anio)
            If _DatasetCerrar.Tables(0).Rows.Count = 0 Then
                lblinfo_tabla.Text = "tabla de Valorización no Generada"
                'btnCerrar.Visible = False
                btnNuevo.Enabled = True
                btnCerrar.Text = "Bloqueado"
                btnCerrar.Image = My.Resources.blockeado
                btnCerrar.BackColor = Color.FromArgb(128, 131, 140)
                btnCerrar.Enabled = False
                btnNuevo.Text = "Generar Datos"
                btnNuevo.Image = My.Resources.engranaje
                btnNuevo.BackColor = Color.FromArgb(150, 193, 31)
                btnNuevo.Enabled = True
            Else
                btnNuevo.Text = "Datos Generados"
                btnNuevo.Image = My.Resources.engranaje
                btnNuevo.BackColor = Color.FromArgb(128, 131, 140)
                btnNuevo.Enabled = False
                barProgres.Value = False
                For Each row In _DatasetCerrar.Tables(0).Rows
                    If row("estado") = "abierto" Then
                        btnCerrar.Visible = True
                        btnCerrar.Text = "Cerrar Valorización"
                        btnCerrar.Image = My.Resources.cerrar_white
                        btnCerrar.BackColor = Color.FromArgb(150, 193, 31)
                        btnCerrar.Enabled = True
                        lblinfo_tabla.Text = ""
                    Else
                        lblinfo_tabla.Text = "Tabla de Valorización cerrada"
                        btnCerrar.Text = "Cerrar Valorización"
                        btnCerrar.Image = My.Resources.padlock
                        btnCerrar.BackColor = Color.FromArgb(255, 140, 1)
                        btnCerrar.Enabled = False
                    End If
                Next
                btnNuevo.Enabled = False
            End If
        Catch
        End Try
    End Sub
    Sub listar_tablas(ByVal annio As String)
        Try
            _DatasetTasas.Reset()
            consulta_datos_tasas1(annio)
            dgr1.DataSource = _dtwTasas
            dgr1.Columns(0).ReadOnly = True
            dgr1.Columns(1).ReadOnly = True
            dgr1.Columns(3).ReadOnly = True


            _DatasetTasas2.Reset()
            consulta_datos_tasas2(annio)
            dgr2.DataSource = _dtwTasas2
            dgr2.Columns(0).ReadOnly = True
            dgr2.Columns(1).ReadOnly = True
            dgr2.Columns(3).ReadOnly = True

            _DatasetTasas3.Reset()
            consulta_datos_tasas3(annio)
            dgr3.DataSource = _dtwTasas3
            dgr3.Columns(0).ReadOnly = True
            dgr3.Columns(1).ReadOnly = True
            dgr3.Columns(3).ReadOnly = True

            _DatasetTasas4.Reset()
            consulta_datos_tasas4(annio)
            dgr4.DataSource = _dtwTasas4
            dgr4.Columns(0).ReadOnly = True
            dgr4.Columns(1).ReadOnly = True
            dgr4.Columns(3).ReadOnly = True

            _DatasetTasas5.Reset()
            consulta_datos_tasas5(annio)
            dgr5.DataSource = _dtwTasas5
            dgr5.Columns(0).ReadOnly = True
            dgr5.Columns(1).ReadOnly = True
            dgr5.Columns(3).ReadOnly = True

            _DatasetTasas6.Reset()
            consulta_datos_tasas6(annio)
            dgr6.DataSource = _dtwTasas6
            dgr6.Columns(0).ReadOnly = True
            dgr6.Columns(1).ReadOnly = True
            dgr6.Columns(3).ReadOnly = True

            _DatasetTasas7.Reset()
            consulta_datos_tasas7(annio)
            dgr7.DataSource = _dtwTasas7
            dgr7.Columns(0).ReadOnly = True
            dgr7.Columns(1).ReadOnly = True
            dgr7.Columns(3).ReadOnly = True
        Catch
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim datosMuros As New class_datos_vu_muros_columnas
        Dim datosTecho As New class_datos_vu_techos
        Dim datosPisos As New class_datos_vu_pisos
        Dim datosPuertas As New class_datos_vu_puertasventanas
        Dim datosRevestimiento As New class_datos_vu_revestrimiento
        Dim datosbBannios As New class_datos_vu_banios
        Dim datosInstalaciones As New class_datos_vu_electricidad
        Dim controlMuros As New class_controller_vu_muroscolumnas
        Dim controlTecho As New class_controller_vu_techos
        Dim controlPisos As New class_controller_vu_pisos
        Dim controlPuertas As New class_controller_vu_puertaventanas
        Dim controlRevestimiento As New class_controller_vu_revestimiento
        Dim controlBanios As New class_controller_vu_banios
        Dim controlInstalaciones As New class_controller_vu_electricidad
        Dim annio As String
        annio = cbxAnio.Text
        Dim modulo As String
        modulo = "tasas"
        Dim contador As New Integer
        contador = 0
        Try
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, annio)
            If _DatasetCerrar.Tables(0).Rows.Count = 0 Then
                barProgres.Visible = True
                barProgres.Maximum = 65
                barProgres.Value = 0
                lblinfo_tabla.Text = "Tabla de Valorización no Generada"
                btnNuevo.Enabled = True
                btnCerrar.Visible = False
                For i As Integer = 0 To 8
                    datosMuros.cod_categoria = i + 1
                    datosMuros.valor = 0
                    datosMuros.annio = annio
                    If controlMuros.insertarDatosMurosColumnas(datosMuros) Then
                        contador = contador + 1
                        barProgres.Value = contador
                    Else
                        MsgBox("Datos de muros y columnas no guardados..!!!")
                    End If
                    '-------------------------------------------------
                    datosTecho.cod_categoria = i + 1
                    datosTecho.valor = 0
                    datosTecho.annio = annio
                    If controlTecho.insertarDatosTechos(datosTecho) Then
                        contador = contador + 1
                        barProgres.Value = contador
                    Else
                        MsgBox("Datos de techos no guardados..!!!")
                    End If
                    '-------------------------------------------------

                    datosPisos.cod_categoria = i + 1
                    datosPisos.valor = 0
                    datosPisos.annio = annio
                    If controlPisos.insertarDatosPisos(datosPisos) Then
                        contador = contador + 1
                        barProgres.Value = contador
                    Else
                        MsgBox("Datos de pisos no guardados..!!!")
                    End If
                    '-------------------------------------------------
                    datosPuertas.cod_categoria = i + 1
                    datosPuertas.valor = 0
                    datosPuertas.annio = annio
                    If controlPuertas.insertarDatosPuertasVentanas(datosPuertas) Then
                        contador = contador + 1
                        barProgres.Value = contador
                    Else
                        MsgBox("Datos de puertas y ventanas no guardados..!!!")
                    End If
                    ' -------------------------------------------------
                    datosRevestimiento.cod_categoria = i + 1
                    datosRevestimiento.valor = 0
                    datosRevestimiento.annio = annio
                    If controlRevestimiento.insertarDatosRevestimiento(datosRevestimiento) Then
                        contador = contador + 1
                        barProgres.Value = contador
                    Else
                        MsgBox("Datos de revestimiento no guardados..!!!")
                    End If
                    '-------------------------------------------------
                    datosbBannios.cod_categoria = i + 1
                    datosbBannios.valor = 0
                    datosbBannios.annio = annio
                    If controlBanios.insertarDatosBanios(datosbBannios) Then
                        contador = contador + 1
                        barProgres.Value = contador
                    Else
                        MsgBox("Datos de baños no guardados..!!!")
                    End If
                    ' -------------------------------------------------
                    datosInstalaciones.cod_categoria = i + 1
                    datosInstalaciones.valor = 0
                    datosInstalaciones.annio = annio
                    If controlInstalaciones.insertarDatosElectricidad(datosInstalaciones) Then
                        contador = contador + 1
                        barProgres.Value = contador
                    Else
                        MsgBox("Datos de instalaciones electricas no guardados..!!!")
                    End If
                Next
                Dim datosC As New class_datos_cerrar_periodo
                Dim controlC As New class_controller_cerrar_periodo
                datosC.modulo_cerrar = "tasas"
                datosC.annio_cerrar = cbxAnio.Text
                datosC.estado_cerrar = "abierto"
                controlC.insertarDatosCerrar(datosC)
                btnNuevo.Text = "Datos Generados"
                btnNuevo.Image = My.Resources.engranaje
                btnNuevo.BackColor = Color.FromArgb(128, 131, 140)
                btnNuevo.Enabled = False
            Else
                btnNuevo.Enabled = False
                MessageBox.Show("Uds. ya ha generado una tabla para este año")
            End If

        Catch ex As Exception
        Finally
            barProgres.Value = 0
            barProgres.Visible = False
            Dim anio As New Integer
            anio = cbxAnio.Text
            modulo = "tasas"
            listar_tablas(anio)
            'Consulta si tabla de depreciacion esta abierta
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, anio)
            If _DatasetCerrar.Tables(0).Rows.Count = 0 Then
                lblinfo_tabla.Text = "tabla de Valorización no Generada"
                btnCerrar.Visible = False
            Else
                For Each row In _DatasetCerrar.Tables(0).Rows
                    If row("estado") = "abierto" Then
                        btnCerrar.Visible = True
                        lblinfo_tabla.Text = ""
                        lblinfo_tabla.Text = ""
                        btnCerrar.Text = "Cerrar Valorización"
                        btnCerrar.Image = My.Resources.cerrar_white
                        btnCerrar.BackColor = Color.FromArgb(150, 193, 31)
                    Else
                        btnCerrar.Text = "5"
                        btnCerrar.Image = My.Resources.update_white
                        btnCerrar.BackColor = Color.FromArgb(128, 131, 140)
                        lblinfo_tabla.Text = "Tabla de Valorización cerrada"
                    End If
                Next
                btnNuevo.Enabled = False
            End If
        End Try
    End Sub


    Private Sub dgr1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgr1.CellEndEdit
        Dim filas As New Integer
        Dim valor As New Decimal
        Dim codigo As New Integer
        Dim datos As New class_datos_vu_muros_columnas
        Dim control As New class_controller_vu_muroscolumnas
        Dim modulo As String
        Dim annio As String
        Try
            modulo = "tasas"
            annio = cbxAnio.Text
            'If IsNumeric(valor) Then
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, annio)
            For Each row In _DatasetCerrar.Tables(0).Rows
                If row("estado") = "abierto" Then
                    filas = dgr1.CurrentRow.Index
                    codigo = dgr1.Item(0, filas).Value
                    valor = dgr1.Item(2, filas).Value
                    If valor >= 0 Then
                        datos.id_murosycolumnas = codigo
                        datos.valor = valor
                        'listar_codigo_depreciacion(cbxAnio.Text)
                        If control.actualizarMurosColumnas(datos) Then
                            'MsgBox("Datos guardados")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                Else
                    MessageBox.Show("Uds. ha cerrado la tabla de depreciación para este año. En consecuencia ya no podra cambiarlo.", "Importante")
                End If
                listar_tablas(cbxAnio.Text)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgr2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgr2.CellEndEdit
        Dim filas As New Integer
        Dim valor As New Decimal
        Dim codigo As New Integer
        Dim datos As New class_datos_vu_techos
        Dim control As New class_controller_vu_techos
        Dim modulo As String
        Dim annio As String
        Try
            modulo = "tasas"
            annio = cbxAnio.Text
            'If IsNumeric(valor) Then
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, annio)
            For Each row In _DatasetCerrar.Tables(0).Rows
                If row("estado") = "abierto" Then
                    filas = dgr2.CurrentRow.Index
                    codigo = dgr2.Item(0, filas).Value
                    valor = dgr2.Item(2, filas).Value
                    If valor >= 0 Then
                        datos.id_techos = codigo
                        datos.valor = valor
                        'listar_codigo_depreciacion(cbxAnio.Text)
                        If control.actualizaTechos(datos) Then
                            'MsgBox("Datos guardados")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                Else
                    MessageBox.Show("Uds. ha cerrado la tabla de depreciación para este año. En consecuencia ya no podra cambiarlo.", "Importante")
                End If
                listar_tablas(cbxAnio.Text)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgr3_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgr3.CellEndEdit
        Dim filas As New Integer
        Dim valor As New Decimal
        Dim codigo As New Integer
        Dim datos As New class_datos_vu_pisos
        Dim control As New class_controller_vu_pisos
        Dim modulo As String
        Dim annio As String
        Try
            modulo = "tasas"
            annio = cbxAnio.Text
            'If IsNumeric(valor) Then
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, annio)
            For Each row In _DatasetCerrar.Tables(0).Rows
                If row("estado") = "abierto" Then
                    filas = dgr3.CurrentRow.Index
                    codigo = dgr3.Item(0, filas).Value
                    valor = dgr3.Item(2, filas).Value
                    If valor >= 0 Then
                        datos.idpisos = codigo
                        datos.valor = valor
                        'listar_codigo_depreciacion(cbxAnio.Text)
                        If control.actualizPisos(datos) Then
                            'MsgBox("Datos guardados")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                Else
                    MessageBox.Show("Uds. ha cerrado la tabla de depreciación para este año. En consecuencia ya no podra cambiarlo.", "Importante")
                End If
                listar_tablas(cbxAnio.Text)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgr4_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgr4.CellEndEdit
        Dim filas As New Integer
        Dim valor As New Decimal
        Dim codigo As New Integer
        Dim datos As New class_datos_vu_puertasventanas
        Dim control As New class_controller_vu_puertaventanas
        Dim modulo As String
        Dim annio As String
        Try
            modulo = "tasas"
            annio = cbxAnio.Text
            'If IsNumeric(valor) Then
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, annio)
            For Each row In _DatasetCerrar.Tables(0).Rows
                If row("estado") = "abierto" Then
                    filas = dgr4.CurrentRow.Index
                    codigo = dgr4.Item(0, filas).Value
                    valor = dgr4.Item(2, filas).Value
                    If valor >= 0 Then
                        datos.idpuertasventanas = codigo
                        datos.valor = valor
                        'listar_codigo_depreciacion(cbxAnio.Text)
                        If control.actualizPuertasVentanas(datos) Then
                            'MsgBox("Datos guardados")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                Else
                    MessageBox.Show("Uds. ha cerrado la tabla de depreciación para este año. En consecuencia ya no podra cambiarlo.", "Importante")
                End If
                listar_tablas(cbxAnio.Text)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgr5_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgr5.CellEndEdit
        Dim filas As New Integer
        Dim valor As New Decimal
        Dim codigo As New Integer
        Dim datos As New class_datos_vu_revestrimiento
        Dim control As New class_controller_vu_revestimiento
        Dim modulo As String
        Dim annio As String
        Try
            modulo = "tasas"
            annio = cbxAnio.Text
            'If IsNumeric(valor) Then
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, annio)
            For Each row In _DatasetCerrar.Tables(0).Rows
                If row("estado") = "abierto" Then
                    filas = dgr5.CurrentRow.Index
                    codigo = dgr5.Item(0, filas).Value
                    valor = dgr5.Item(2, filas).Value
                    If valor >= 0 Then
                        datos.idrevestimiento = codigo
                        datos.valor = valor
                        'listar_codigo_depreciacion(cbxAnio.Text)
                        If control.actualizRevestimiento(datos) Then
                            'MsgBox("Datos guardados")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                Else
                    MessageBox.Show("Uds. ha cerrado la tabla de depreciación para este año. En consecuencia ya no podra cambiarlo.", "Importante")
                End If
                listar_tablas(cbxAnio.Text)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgr6_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgr6.CellEndEdit
        Dim filas As New Integer
        Dim valor As New Decimal
        Dim codigo As New Integer
        Dim datos As New class_datos_vu_banios
        Dim control As New class_controller_vu_banios
        Dim modulo As String
        Dim annio As String
        Try
            modulo = "tasas"
            annio = cbxAnio.Text
            'If IsNumeric(valor) Then
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, annio)
            For Each row In _DatasetCerrar.Tables(0).Rows
                If row("estado") = "abierto" Then
                    filas = dgr6.CurrentRow.Index
                    codigo = dgr6.Item(0, filas).Value
                    valor = dgr6.Item(2, filas).Value
                    If valor >= 0 Then
                        datos.id_banios = codigo
                        datos.valor = valor
                        'listar_codigo_depreciacion(cbxAnio.Text)
                        If control.actualizarBanio(datos) Then
                            'MsgBox("Datos guardados")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                Else
                    MessageBox.Show("Uds. ha cerrado la tabla de depreciación para este año. En consecuencia ya no podra cambiarlo.", "Importante")
                End If
                listar_tablas(cbxAnio.Text)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgr7_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgr7.CellEndEdit
        Dim filas As New Integer
        Dim valor As New Decimal
        Dim codigo As New Integer
        Dim datos As New class_datos_vu_electricidad
        Dim control As New class_controller_vu_electricidad
        Dim modulo As String
        Dim annio As String
        Try
            modulo = "tasas"
            annio = cbxAnio.Text
            'If IsNumeric(valor) Then
            _DatasetCerrar.Reset()
            consulta_datos_cerrar_periodo_by(modulo, annio)
            For Each row In _DatasetCerrar.Tables(0).Rows
                If row("estado") = "abierto" Then
                    filas = dgr7.CurrentRow.Index
                    codigo = dgr7.Item(0, filas).Value
                    valor = dgr7.Item(2, filas).Value
                    If valor >= 0 Then
                        datos.idelectricidad = codigo
                        datos.valor = valor
                        listar_tablas(cbxAnio.Text)
                        If control.actualizarElectricidad(datos) Then
                            'MsgBox("Datos guardados")
                        Else
                            MsgBox("Datos no guardados")
                        End If
                    End If
                Else
                    MessageBox.Show("Uds. ha cerrado la tabla de categorias para este año. En consecuencia ya no podra cambiarlo.", "Importante")
                End If
                listar_tablas(cbxAnio.Text)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim datos As New class_datos_cerrar_periodo
        Dim control As New class_controller_cerrar_periodo
        datos.modulo_cerrar = "tasas"
        datos.annio_cerrar = cbxAnio.Text
        datos.estado_cerrar = "cerrado"
        If MessageBox.Show("Esta seguro que desea cerrar la tabla...!!!", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If control.actualizarDatosCerrar(datos) Then
                MsgBox("Tabla Cerrada")
                'btnCerrar.Visible = False
                lblinfo_tabla.Text = "tabla cerrada"
                barProgres.Visible = False
                btnCerrar.Text = "Depreciación Cerrada"
                btnCerrar.Image = My.Resources.padlock
                btnCerrar.BackColor = Color.FromArgb(255, 140, 1)
                btnCerrar.Enabled = False
                barProgres.Visible = False
            End If
        Else
        End If
    End Sub


End Class
