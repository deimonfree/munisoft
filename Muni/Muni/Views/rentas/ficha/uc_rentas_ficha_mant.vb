Public Class uc_rentas_ficha_mant
    'estado de botones
    Dim estado_boton As Integer = 0
    'id de ficha 
    Dim idFicha As Integer = 0
    'codigo de ficha
    Dim codigoFicha As Integer = 0
    Dim totu As Integer = 0
    Dim valorfila As Integer = 0
    Dim valorfila_agregado As Integer = 0
    Dim valor_unit_depre As Double = 0
    Dim porcen_depreciacion As Double = 0
    Dim valor_depre As Double = 0
    Dim idVia As Integer
    Dim idZona As Integer
    Dim IdPredio As Integer
    Dim idCategoria As String
    Dim valorterreno As Double
    Dim valorConst As Double
    Dim baseImponible As Double
    Dim fila As Integer
    Dim columna As Integer
    Dim chipi As Integer = 0
    Dim annio_antiguedad_terreno As Integer = 0
    Dim valor_unitario_terreno As Double = 0
    Dim valor_categoria As Integer = 0
    'variables de deducción
    Dim valor_deduccion As Double
    Dim tipo_deducion As String
    Dim opcionExoneracion As Integer
    Dim total_base_imponible As Double
    'variable ficha
    Dim codFicha As Integer = 0
    'variable de fichas
    Dim idContribuyente As Integer = 0
    'variables para el datagrid
    Dim valor_fila As Integer = 0
    Dim valor_columna As Integer = 0
    'valor de indice de construcciones
    Dim idconstrucciones(10) As Integer
    'valor de filas actuales de constucciones
    Dim filas_actual As Integer = 0

    Private Sub uc_rentas_ficha_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valorterreno = 0.00
        valorConst = 0.00
        txtValorterreno.Text = valorterreno
        txtValorConst.Text = valorConst
        baseImponible = valorConst + valorterreno
        txtBaseImponible.Text = baseImponible

        'llenado anio
        _DatasetLlenadoBox.Reset()
        llenado_combox.combox_all("anno")
        cbxAnno.DataSource = _DatasetLlenadoBox.Tables("anno")
        cbxAnno.DisplayMember = "anno"
        cbxAnno.ValueMember = "idanno"

        'llenado de estado predio
        _DatasetEstadoPredioBox.Reset()
        consulta_datos_estadoPredio_combox_all()
        cbxEstadoPredio.DataSource = _DatasetEstadoPredioBox.Tables("estado_predio")
        cbxEstadoPredio.DisplayMember = "denominacion"
        cbxEstadoPredio.ValueMember = "idestado_predio"

        'llenado de tipo predio
        _DatasetTipoPredioBox.Reset()
        consulta_datos_tipoPredio_combox_all()
        cbxTipoPredio.DataSource = _DatasetTipoPredioBox.Tables("tipo_predio")
        cbxTipoPredio.DisplayMember = "denominacion"
        cbxTipoPredio.ValueMember = "idtipo_predio"

        'llenado de tipo predio
        _DatasetUsoPredioBox.Reset()
        consulta_datos_usoPredio_combox_all()
        cbxusoPredio.DataSource = _DatasetUsoPredioBox.Tables("uso_predio")
        cbxusoPredio.DisplayMember = "denominacion"
        cbxusoPredio.ValueMember = "iduso_predio"

        'llenado de tipo ficha
        _DatasetTipoFichaBox.Reset()
        consulta_datos_tipoFicha_combox_all()
        cbxTipoFicha.DataSource = _DatasetTipoFichaBox.Tables("tipo_ficha")
        cbxTipoFicha.DisplayMember = "nombre"
        cbxTipoFicha.ValueMember = "idtipo_ficha"

        'llenado de condicion de titular
        _DatasetConTituloBox.Reset()
        consulta_datos_condTitulo_combox_all()
        cbxCondTitular.DataSource = _DatasetConTituloBox.Tables("condicion_titular")
        cbxCondTitular.DisplayMember = "denominacion"
        cbxCondTitular.ValueMember = "idcondicion_titular"

        'llenado de condicion de modo de adquisicion
        _DatasetModoAdqBox.Reset()
        consulta_datos_modoAdq_combox_all()
        cbxModoAdq.DataSource = _DatasetModoAdqBox.Tables("modo_adq")
        cbxModoAdq.DisplayMember = "denominacion"
        cbxModoAdq.ValueMember = "idmodo_adq"

        'llenado de condicion de regimen de exoneracion
        _DatasetTiporegimenBox.Reset()
        consulta_datos_tipoRegimen_combox_all()
        cbxRegExoneracion.DataSource = _DatasetTiporegimenBox.Tables("regimen")
        cbxRegExoneracion.DisplayMember = "nombre"
        cbxRegExoneracion.ValueMember = "idregimen"
        'estableciendo mascara de date

        mtFecha.ValidatingType = GetType(System.DateTime)
    End Sub

    Private Sub txtValorConst_TextChanged(sender As Object, e As EventArgs) Handles txtValorConst.TextChanged
        calcular_baseimponible()
    End Sub

    Private Sub txtValorterreno_TextChanged(sender As Object, e As EventArgs) Handles txtValorterreno.TextChanged
        calcular_baseimponible()
    End Sub
    Private Sub calcular_baseimponible()
        Dim alta As Boolean = False
        Select Case ""
            Case Trim(txtValorConst.Text)
                alta = True
            Case Trim(txtValorterreno.Text)
                alta = True
        End Select
        If alta = True Then
        Else
            valorterreno = txtValorConst.Text
            valorConst = txtValorterreno.Text
            baseImponible = valorConst + valorterreno
            txtBaseImponible.Text = baseImponible
            Try
                Select Case cbxRegExoneracion.SelectedValue.ToString
                    Case 0
                        total_base_imponible = baseImponible
                        txtBaseImponibleExo.Text = total_base_imponible
                    Case 1
                        total_base_imponible = baseImponible * 0
                        txtBaseImponibleExo.Text = total_base_imponible
                    Case 2
                        If baseImponible - txtExoneracion.Text < 0 Then
                            txtBaseImponibleExo.Text = 0
                            total_base_imponible = 0
                        Else
                            txtBaseImponibleExo.Text = baseImponible - txtExoneracion.Text
                            total_base_imponible = baseImponible - txtExoneracion.Text
                        End If

                    Case 3
                        total_base_imponible = (baseImponible * txtExoneracion.Text) / 100
                        txtBaseImponibleExo.Text = total_base_imponible
                    Case 4
                        total_base_imponible = (baseImponible * txtExoneracion.Text) / 100
                        txtBaseImponibleExo.Text = total_base_imponible
                    Case 5
                        total_base_imponible = (baseImponible * txtExoneracion.Text) / 100
                        txtBaseImponibleExo.Text = total_base_imponible
                End Select
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub llamada_sector(valor As Integer)
        Dim datos_sector As New class_datos_sector
        Dim datos_zona As New class_datos_zona
        cargar_datos_sector(valor, datos_sector)
        'IdContibuyente = valor
        txtSector.Text = datos_sector.nombre_sector
        cargar_datos_zona(datos_sector.codZona_sector, datos_zona)
        txtZona.Text = datos_zona.nombre_zona
        idZona = datos_zona.id_zona
    End Sub
    Private Sub llamada_via(valor As Integer)
        Dim datos_via As New class_datos_via
        cargar_datos_via(valor, datos_via)
        idVia = datos_via.id_via
        txtVia.Text = datos_via.nombre_via
    End Sub
    'Private Sub llamada_tipovia(valor As Integer)
    '    Dim datos_sector As New class_datos_tipo_via
    '    cargar_datos_sector(valor, datos_sector)
    '    'IdContibuyente = valor
    '    txtSector.Text = datos_sector.nombre_sector
    '    idZona = datos_sector.codZona_sector
    'End Sub
    Private Sub calcular_Arancel(ByVal idvia As Integer, ByVal idcuadra As Integer, ByVal anno As Integer)
        Dim datosArancel As New class_datos_valorArancelario
        Dim alta As Boolean = False
        Select Case ""
            Case Trim(txtVia.Text)
                alta = True
            Case Trim(txtCuadra.Text)
                alta = True
        End Select
        If alta = True Then
            MessageBox.Show("mrd  rellana los datos")
        Else
            cargar_datos_Arancelarios(idvia, idcuadra, anno, datosArancel)
            txtArancel.Text = datosArancel.valor_valorArancelario

        End If

    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles txtAreaTerreno.TextChanged
        Try
            If LTrim(txtAreaTerreno.Text) = "" Then
                txtValorArancel.Text = 0
            Else
                If IsNumeric(txtAreaTerreno.Text) Then
                    txtValorArancel.Text = txtArancel.Text * txtAreaTerreno.Text
                Else
                    MessageBox.Show("el numero de cuadra insertado es incorrecto")
                    txtAreaTerreno.Text = 0
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtValorArancel_TextChanged(sender As Object, e As EventArgs) Handles txtValorArancel.TextChanged
        txtValorterreno.Text = txtValorArancel.Text
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        fila = e.RowIndex
        columna = e.ColumnIndex
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        calcular_total_pisos()
    End Sub

    Private Sub RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs)

        ' Update the balance column whenever rows are deleted.
        UpdateBalance()
    End Sub
    Private Sub CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)

        ' Update the balance column whenever the values of any cell changes.
        'UpdateBalance()
        'Dim valor As String
        'valor = Me.dgwConstruciones.Rows(2).Cells(1).Value
        Dim celda As Integer
        Try
            Dim msg As String = String.Format("{0}, {1}", dgwConstruciones.CurrentCell.RowIndex, dgwConstruciones.CurrentCell.ColumnIndex)
            'MessageBox.Show(msg, "Current Cell")
            Dim sNombres As String()
            sNombres = msg.Split(",")
            'MessageBox.Show(sNombres(1))
            'Dim sCelda As String()
            'sCelda = sNombres(1).Split(" ")

            celda = sNombres(1)
            'MessageBox.Show(celda)
            valor_celda(celda)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UpdateBalance()
        Try
            chipi = +1
            dgwConstruciones.Rows(0).Cells("total").Value = chipi.ToString()
        Catch ex As Exception

        End Try
    End Sub
    Sub valor_celda(ByVal valor_celda As Integer)
        Select Case valor_celda
            Case 0
            Case 1
                'rellenando incremento
                Dim piso As Integer
                piso = Me.dgwConstruciones.Rows(valor_fila).Cells("piso").Value
                If piso < 5 Then
                    dgwConstruciones.Rows(valor_fila).Cells("inc5").Value = 0
                Else
                    dgwConstruciones.Rows(valor_fila).Cells("inc5").Value = 0.05
                End If
                dgwConstruciones.Rows(valor_fila).Cells("predio").Value = UCase(Me.dgwConstruciones.Rows(valor_fila).Cells("predio").Value)
            Case 2
                Dim valor_antiguedad As Integer
                valor_antiguedad = Me.dgwConstruciones.Rows(valor_fila).Cells("antiguedad").Value
                annio_antiguedad_terreno = antiguedadPredio(valor_antiguedad)
                calculo_depreciacion()
            Case 3
                Dim clasificacionVivienda As New class_datos_clasificacion
                Dim valor As Integer
                valor = Me.dgwConstruciones.Rows(valor_fila).Cells("cod_clasificacion").Value
                cargar_datos_clasificacionVivienda(valor, clasificacionVivienda)
                dgwConstruciones.Rows(valor_fila).Cells("nom_clasificacion").Value = clasificacionVivienda.id_clasificacion & " -" & clasificacionVivienda.denominacion_clasificacion
                calculo_depreciacion()
                dgwConstruciones.Rows(valor_fila).Cells("nom_clasificacion").ReadOnly = True
            Case 4

            Case 5
                Dim materialVivienda As New class_datos_material
                Dim valor As Integer
                valor = Me.dgwConstruciones.Rows(valor_fila).Cells("material_clasificacion").Value
                cargar_datos_materialVivienda(valor, materialVivienda)
                dgwConstruciones.Rows(valor_fila).Cells("nom_material").Value = materialVivienda.id_materialVivienda & " -" & materialVivienda.denominacion_materialVivienda
                calculo_depreciacion()
                dgwConstruciones.Rows(valor_fila).Cells("nom_material").ReadOnly = True
            Case 6
            Case 7
                Dim conservacionVivienda As New class_datos_conservacion
                Dim valor As Integer
                valor = Me.dgwConstruciones.Rows(valor_fila).Cells("cod_estadoConsv").Value
                cargar_datos_conservacionVivienda(valor, conservacionVivienda)
                dgwConstruciones.Rows(valor_fila).Cells("nom_estadoConsv").Value = conservacionVivienda.id_conservacionVivienda & " -" & conservacionVivienda.denominacion_conservacionVivienda
                calculo_depreciacion()
                dgwConstruciones.Rows(valor_fila).Cells("nom_estadoConsv").ReadOnly = True
            Case 8
            Case 9
                dgwConstruciones.Rows(valor_fila).Cells("categoria").ReadOnly = True
            Case 10
                valorDepreciacion()
            Case 15
                Dim area As Double
                Dim valor_dep As Double
                Dim total As Double
                Dim incremento As Double
                area = Me.dgwConstruciones.Rows(valor_fila).Cells("area_construccion").Value
                If area > txtAreaTerreno.Text Then
                    MessageBox.Show("el area de terreno es menor que el area de construcción")
                    dgwConstruciones.Rows(valor_fila).Cells("area_construccion").Value = 0
                Else
                    incremento = Me.dgwConstruciones.Rows(valor_fila).Cells("inc5").Value
                    valor_dep = Me.dgwConstruciones.Rows(valor_fila).Cells("valor_unitario_depreciacion").Value
                    total = area * valor_dep
                    total = (incremento * total) + total
                    dgwConstruciones.Rows(valor_fila).Cells("total").Value = total
                End If

        End Select
    End Sub
    Sub calculo_categoria(ByVal cadena As String)
        Dim valor_anio As String = ""
        valor_anio = cbxAnno.Text
        valor_unitario_terreno = 0
        'leendo caracteres
        Dim recorrido As Integer = 1
        cadena = idCategoria
        Try
            For i As Integer = 0 To cadena.Length
                If recorrido = 1 Then
                    Select Case cadena.Substring(i, 1)
                        Case "A"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(1, valor_anio)
                        Case "B"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(2, valor_anio)
                        Case "C"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(3, valor_anio)
                        Case "D"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(4, valor_anio)
                        Case "E"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(5, valor_anio)
                        Case "F"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(6, valor_anio)
                        Case "G"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(7, valor_anio)
                        Case "H"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(8, valor_anio)
                        Case "I"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(9, valor_anio)
                    End Select
                Else
                    If recorrido = 2 Then
                        Select Case cadena.Substring(i, 1)
                            Case "A"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(1, valor_anio)
                            Case "B"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(2, valor_anio)
                            Case "C"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(3, valor_anio)
                            Case "D"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(4, valor_anio)
                            Case "E"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(5, valor_anio)
                            Case "F"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(6, valor_anio)
                            Case "G"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(7, valor_anio)
                            Case "H"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(8, valor_anio)
                            Case "I"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(9, valor_anio)
                        End Select
                    Else
                        If recorrido = 3 Then
                            Select Case cadena.Substring(i, 1)
                                Case "A"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(1, valor_anio)
                                Case "B"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(2, valor_anio)
                                Case "C"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(3, valor_anio)
                                Case "D"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(4, valor_anio)
                                Case "E"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(5, valor_anio)
                                Case "F"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(6, valor_anio)
                                Case "G"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(7, valor_anio)
                                Case "H"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(8, valor_anio)
                                Case "I"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(9, valor_anio)
                            End Select
                        Else
                            If recorrido = 4 Then
                                Select Case cadena.Substring(i, 1)
                                    Case "A"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(1, valor_anio)
                                    Case "B"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(2, valor_anio)
                                    Case "C"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(3, valor_anio)
                                    Case "D"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(4, valor_anio)
                                    Case "E"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(5, valor_anio)
                                    Case "F"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(6, valor_anio)
                                    Case "G"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(7, valor_anio)
                                    Case "H"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(8, valor_anio)
                                    Case "I"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(9, valor_anio)
                                End Select
                            Else
                                If recorrido = 5 Then
                                    Select Case cadena.Substring(i, 1)
                                        Case "A"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(1, valor_anio)
                                        Case "B"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(2, valor_anio)
                                        Case "C"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(3, valor_anio)
                                        Case "D"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(4, valor_anio)
                                        Case "E"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(5, valor_anio)
                                        Case "F"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(6, valor_anio)
                                        Case "G"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(7, valor_anio)
                                        Case "H"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(8, valor_anio)
                                        Case "I"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(9, valor_anio)
                                    End Select
                                Else
                                    If recorrido = 6 Then
                                        Select Case cadena.Substring(i, 1)
                                            Case "A"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(1, valor_anio)
                                            Case "B"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(2, valor_anio)
                                            Case "C"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(3, valor_anio)
                                            Case "D"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(4, valor_anio)
                                            Case "E"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(5, valor_anio)
                                            Case "F"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(6, valor_anio)
                                            Case "G"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(7, valor_anio)
                                            Case "H"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(8, valor_anio)
                                            Case "I"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(9, valor_anio)
                                        End Select
                                    Else
                                        If recorrido = 7 Then
                                            Select Case cadena.Substring(i, 1)
                                                Case "A"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(1, valor_anio)
                                                Case "B"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(2, valor_anio)
                                                Case "C"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(3, valor_anio)
                                                Case "D"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(4, valor_anio)
                                                Case "E"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(5, valor_anio)
                                                Case "F"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(6, valor_anio)
                                                Case "G"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(7, valor_anio)
                                                Case "H"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(8, valor_anio)
                                                Case "I"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(9, valor_anio)
                                            End Select
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If

                End If
                recorrido = recorrido + 1
            Next
        Catch ex As Exception

        End Try
        If valor_unitario_terreno <> 0 Then
            dgwConstruciones.Rows(valor_fila).Cells("valor_unitario").Value = valor_unitario_terreno
        Else
            MessageBox.Show("rellene bien las categorias")
        End If
        If porcen_depreciacion <> 0 Then
            valorDepreciacion()
        Else
            valorDepreciacion()
        End If
        If valor_depre <> 0 Then
            val_U_dep()
        Else
            val_U_dep()
        End If
    End Sub
    Sub calculo_depreciacion()
        Dim datos_depreciacion As New class_datos_depreciacion
        Dim antiguedad As Integer
        Dim clasificacion As Integer
        Dim material As Integer
        Dim conservacion As Integer
        Dim anio As Integer
        anio = cbxAnno.Text
        antiguedad = annio_antiguedad_terreno
        clasificacion = Me.dgwConstruciones.Rows(valor_fila).Cells("cod_clasificacion").Value
        material = Me.dgwConstruciones.Rows(valor_fila).Cells("material_clasificacion").Value
        conservacion = Me.dgwConstruciones.Rows(valor_fila).Cells("cod_estadoConsv").Value
        Dim alta As Boolean = False
        Select Case 0
            Case Trim(antiguedad)
                alta = True
            Case Trim(clasificacion)
                alta = True
            Case Trim(material)
                alta = True
            Case Trim(conservacion)
                alta = True
        End Select
        If alta = True Then
            dgwConstruciones.Rows(valor_fila).Cells("depreciacion").Value = 0
        Else
            cargar_datos_depreciacion(clasificacion, antiguedad, material, conservacion, anio, datos_depreciacion)
            dgwConstruciones.Rows(valor_fila).Cells("depreciacion").Value = datos_depreciacion.valor_depreciacion
            porcen_depreciacion = datos_depreciacion.valor_depreciacion
        End If
    End Sub
    Sub valorDepreciacion()
        Dim valorUnitario As Double
        Dim depreciacion As Double
        valorUnitario = Me.dgwConstruciones.Rows(valor_fila).Cells("valor_unitario").Value
        depreciacion = Me.dgwConstruciones.Rows(valor_fila).Cells("depreciacion").Value
        'valor_depre = Math.Round(((valorUnitario * depreciacion) / 100), 2)
        valor_depre = (valorUnitario * depreciacion) / 100
        dgwConstruciones.Rows(valor_fila).Cells("valor_depreciacion").Value = valor_depre
    End Sub
    Private Sub val_U_dep()
        valor_unit_depre = 0
        Dim valorDepre As Double
        Dim valorUnit As Double
        valorDepre = Me.dgwConstruciones.Rows(valor_fila).Cells("valor_depreciacion").Value
        valorUnit = Me.dgwConstruciones.Rows(valor_fila).Cells("valor_unitario").Value
        valor_unit_depre = valorUnit - valorDepre
        dgwConstruciones.Rows(valor_fila).Cells("valor_unitario_depreciacion").Value = valor_unit_depre
    End Sub
    Function antiguedadPredio(ByVal annio_predio As Integer) As Integer
        If annio_predio <= 5 Then
            Return 1

        Else
            If annio_predio <= 10 Then
                Return 2

            Else
                If annio_predio <= 15 Then
                    Return 3

                Else
                    If annio_predio <= 20 Then
                        Return 4

                    Else
                        If annio_predio <= 25 Then
                            Return 5

                        Else
                            If annio_predio <= 30 Then
                                Return 6

                            Else
                                If annio_predio <= 35 Then
                                    Return 7

                                Else
                                    If annio_predio <= 40 Then
                                        Return 8

                                    Else
                                        If annio_predio <= 45 Then
                                            Return 9

                                        Else
                                            If annio_predio <= 50 Then
                                                Return 10

                                            Else
                                                Return 11

                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Function
    Private Function verificacion_celda() As Boolean
        Dim valorRetornado As Boolean
        ' Recorremos las filas
        For Each row As DataGridViewRow In dgwConstruciones.Rows

            ' Recorremos las celdas de cada fila
            '
            For Each col As DataGridViewCell In row.Cells

                ' Obtenemos el valor de la celda
                '
                Dim value As Object = col.Value

                If ((value Is Nothing) OrElse (value Is DBNull.Value)) Then

                    ' Al menos una celda está vacía.
                    '
                    Dim rowIndex As Integer = row.Index
                    Dim columnIndex As Integer = col.ColumnIndex

                    ' Seleccionamos la celda vacía.
                    '
                    dgwConstruciones.CurrentCell = dgwConstruciones.Rows(rowIndex).Cells(columnIndex)

                    Dim msg As String = String.Format("La columna {0} perteneciente a la fila {1} está vacía.", columnIndex, rowIndex)

                    MessageBox.Show(msg)

                    ' Abandonamos el procedimiento
                    Return valorRetornado = True

                End If

            Next

        Next

        ' Si hemos llegado hasta aquí, es porque todas las
        ' celdas del control DataGridView tienen un valor.
        '
        'MessageBox.Show("Todas las celdas tienen un valor.")
        Return valorRetornado = False

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If verificacion_celda() Then
            dgwConstruciones.Rows.Add()
            dgwConstruciones.CurrentCell = dgwConstruciones.Rows(dgwConstruciones.Rows.Count - 1).Cells(0)
            dgwConstruciones.Rows(valorfila_agregado).Cells("piso").Value = valorfila_agregado + 1
            valorfila_agregado = valorfila_agregado + 1
            totu = dgwConstruciones.Rows().Count
            If totu = 0 Then
                valorfila = totu
            Else
                valorfila = totu - 1
            End If
        Else
        End If

    End Sub

    Private Sub btnDelet_Click(sender As Object, e As EventArgs) Handles btnDelet.Click
        Dim mrd As Integer
        mrd = dgwConstruciones.Rows.Count - 1
        Me.dgwConstruciones.Rows.Remove(Me.dgwConstruciones.Rows(mrd))
        valorfila_agregado = valorfila_agregado - 1
    End Sub


    Private Sub dgwConstruciones_KeyUp(sender As Object, e As KeyEventArgs) Handles dgwConstruciones.KeyUp
        Select Case e.KeyCode
            Case Keys.F1
                Dim formulario2 As New d_rentas_categoria
                Dim datoRecuperado As DialogResult
                datoRecuperado = formulario2.ShowDialog()
                If datoRecuperado = DialogResult.OK Then
                    idCategoria = formulario2.valor_categoria
                    dgwConstruciones.Rows(valor_fila).Cells("categoria").Value = idCategoria
                    'mierda mierda mierda
                    calculo_categoria(idCategoria)
                End If
            Case Keys.F2
                MessageBox.Show("presionastes f2")
            Case Keys.F3
                MessageBox.Show("presionastes f3")
            Case Keys.F4
                MessageBox.Show("presionastes f4")
        End Select
    End Sub
    'cambiando vlaor de las celdas
    Private Sub dgwConstruciones_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgwConstruciones.CellValueChanged
        Try
            posicion_celdas()
            valor_celda(valor_columna)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearch_predio_Click(sender As Object, e As EventArgs) Handles btnSearch_predio.Click
        lblInfo.Text = "Actualizando Contribuyente"
        Dim formulario2 As New d_rentas_busqueda
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            txtCodPredio.Text = formulario2.valor_contribuyente
        End If
    End Sub
    Private Sub busqueda_predio(valor As Integer)
        Dim datos_predio As New class_datos_predio
        Dim datos_contribuyente As New class_datos_contribuyente
        Dim datos_direcContri As New class_datos_direccion
        cargar_datos_predio(valor, datos_predio)
        txtCuadra.Text = datos_predio.cuadra_predio
        'llamada via
        llamada_via(datos_predio.codVia_predio)
        txtLote.Text = datos_predio.nroLote_predio
        txtNumVia.Text = datos_predio.numero_predio
        txtEnsisoVia.Text = datos_predio.ensisoNum_predio

        'llamar contibuyente
        cargar_datos_contribuyente(datos_predio.cod_contribuyente_predio, datos_contribuyente)
        txtIdContribuyente.Text = datos_contribuyente.id_contribuyente
        txtNomContribuyente.Text = LCase(datos_contribuyente.nombres_cont) + " " + UCase(datos_contribuyente.apellido_paterno_cont) + " " + UCase(datos_contribuyente.apellido_materno_cont)
        'llamar direccion 
        cargar_datos_direcContribuyente(datos_contribuyente.id_contribuyente, datos_direcContri)
        txtDirecContry.Text = datos_direcContri.via_direccion
        'llamar sector
        llamada_sector(datos_predio.codSector_predio)
        'calcular valor arancelario //////////////////////////////
        Try
            calcular_Arancel(idVia, txtCuadra.Text, cbxAnno.SelectedValue.ToString())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodPredio_TextChanged(sender As Object, e As EventArgs) Handles txtCodPredio.TextChanged
        If LTrim(txtCodPredio.Text) <> "" Then
            If comprobar_predio(txtCodPredio.Text) > 0 Then
                busqueda_predio(txtCodPredio.Text)
                cod_ficha()
            Else
                txtCodPredio.Text = "0"
            End If
        Else
            txtCodPredio.Text = "0"
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        sidePanel.Width = btnDelete.Width
        sidePanel.Top = btnDelete.Bottom
        sidePanel.Location = btnDelete.Location
        sidePanel.Visible = True
        clear()
        desactivar_paneles()
        lblInfo.Text = "Actualizando Datos de Ficha"
        lblsubinfo.Text = "Se esta actualizando los Datos de::"
        Dim formulario2 As New d_rentas_busqueda_ficha
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            estado_boton = 4
            btnOption.Enabled = True
            btnOption.Image = My.Resources.file_delete
            btnOption.Text = "Eliminar Ficha"
            btnOption.BackColor = Color.FromArgb(255, 140, 1)
            idContribuyente = formulario2.valor_contribuyente
            txtCodPredio.Text = formulario2.valor_predio
            idFicha = formulario2.valor_ficha
            llamada_ficha(idFicha)
            desactivar_paneles()
        Else
            sidePanel.Visible = False
            estado_boton = 0
            btnOption.Enabled = False
            btnOption.Text = "Bloqueado"
            btnOption.Image = My.Resources.padlock
            btnOption.BackColor = Color.FromArgb(128, 131, 140)
            'limpiar_infoPanel()
            desactivar_paneles()
            clear()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        sidePanel.Visible = True
        sidePanel.Width = btnSave.Width
        sidePanel.Top = btnSave.Bottom
        sidePanel.Location = btnSave.Location
        '/**************************************/
        activar_paneles()
        clear()
        btnOption.Text = "Guardar Contribuyente"
        btnOption.Image = My.Resources.save
        btnOption.BackColor = Color.FromArgb(150, 193, 31)
        btnOption.Enabled = True
        estado_boton = 2
        lblInfo.Text = "Agregando un nuevo contribuyente"
        lblsubinfo.Text = "Rellene los datos correspondientes para agregar un nuevo contribuyente"
        pbload.Visible = True
        '********************************************
    End Sub
    Private Function alta() As Boolean
        Dim valor_alta = False
        pbCodPredio.Visible = False
        pbFicha.Visible = False
        pbArancel.Visible = False
        pbValor.Visible = False
        pbFechaAdq.Visible = False
        pbAT.Visible = False
        pbAC.Visible = False
        pbAF.Visible = False
        pbHabitantes.Visible = False
        Select Case ""
            Case Trim(txtCodPredio.Text)
                valor_alta = True
                pbCodPredio.Visible = True
            Case Trim(txtNumFicha.Text)
                valor_alta = True
                pbFicha.Visible = True
            Case Trim(txtArancel.Text)
                valor_alta = True
                pbArancel.Visible = True
            Case Trim(txtValorArancel.Text)
                valor_alta = True
                pbValor.Visible = True
            Case Trim(mtFecha.Text)
                valor_alta = True
                pbFechaAdq.Visible = True
            Case Trim(txtAreaTerreno.Text)
                valor_alta = True
                pbAT.Visible = True
            Case Trim(txtAreaComun.Text)
                valor_alta = True
                pbAC.Visible = True
            Case Trim(txtAreaFrentera.Text)
                valor_alta = True
                pbAF.Visible = True
            Case Trim(txtNumHabitantes.Text)
                valor_alta = True
                pbHabitantes.Visible = True
                'falta registro de pisos
        End Select

        Return valor_alta
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbxRegExoneracion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRegExoneracion.SelectedIndexChanged
        Try
            opcionExoneracion = cbxRegExoneracion.SelectedValue.ToString()
            _DatasetBaseLegalBox.Reset()
            consulta_datos_baseLegal_combox(opcionExoneracion)
            cbxBaseLegal.DataSource = _DatasetBaseLegalBox.Tables("base_legal")
            cbxBaseLegal.DisplayMember = "denominacion"
            cbxBaseLegal.ValueMember = "idbase_legal"
            If opcionExoneracion = 0 Then
                txtNumeroExpediente.Text = "--"
                txtResolMuni.Text = "--"
                txtExoneracion.Text = 0
                lblinfoExo.Text = "% de Infectacion a la " + vbLf + " base imponible"
                valor_deduccion = 0
                tipo_deducion = "Afectación"
                txtExoneracion.Enabled = False
            Else
                txtNumeroExpediente.Text = ""
                txtResolMuni.Text = ""
            End If
            If opcionExoneracion = 1 Then
                txtNumeroExpediente.Text = "--"
                txtResolMuni.Text = "--"
                txtExoneracion.Text = 100
                lblinfoExo.Text = "% de Infectacion a la " + vbLf + " base imponible"
                valor_deduccion = 100
                tipo_deducion = "Infectación"
                txtExoneracion.Enabled = False

            End If
            If opcionExoneracion = 2 Then
                Dim annio As Integer
                annio = 2017
                _DatasetUit.Reset()
                consulta_datos_iut(annio)
                For Each row In _DatasetUit.Tables(0).Rows
                    txtExoneracion.Text = row("valor_uit") * 50
                Next
                valor_deduccion = 50
                tipo_deducion = "Pensionistas"
                lblinfoExo.Text = "ó 50 UTI de deducción" + vbLf + "de la base imponible"
                txtExoneracion.Enabled = False
            End If
            If opcionExoneracion = 3 Then
                txtExoneracion.Text = 50
                valor_deduccion = txtExoneracion.Text
                tipo_deducion = "Predios Rusticos"
                lblinfoExo.Text = "% de deducción de por ser" + vbLf + "predios rusticos"
                txtExoneracion.Enabled = False
            End If
            If opcionExoneracion = 4 Then
                txtExoneracion.Text = 50
                valor_deduccion = txtExoneracion.Text
                tipo_deducion = "Predio Urbano"
                lblinfoExo.Text = "% de deducción de por ser" + vbLf + "predios urbanos"
                txtExoneracion.Enabled = False
            End If
            If opcionExoneracion = 5 Then
                txtExoneracion.Text = 50
                valor_deduccion = txtExoneracion.Text
                tipo_deducion = "Predio de la Amazonia"
                lblinfoExo.Text = "ingrese el % de deducción" + vbLf + "de por ser predios de la" + vbLf + " amazonia"
                txtExoneracion.Enabled = True
                txtExoneracion.Text = 0
                txtExoneracion.Select()
            End If
        Catch ex As Exception

        End Try
        calcular_baseimponible()
    End Sub

    Private Sub btnShared_Click(sender As Object, e As EventArgs) Handles btnShared.Click
        lblInfo.Text = "Actualizando Contribuyente"
        Dim formulario2 As New d_rentas_busqueda_ficha
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            idContribuyente = formulario2.valor_contribuyente
            txtCodPredio.Text = formulario2.valor_predio
            llamada_ficha(formulario2.valor_ficha)
        End If
    End Sub

    Private Sub MaskedTextBox1_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles mtFecha.TypeValidationCompleted
        If Not e.IsValidInput Then
            MessageBox.Show("error de fecha")
            e.Cancel = True
        End If
    End Sub
    Private Function fecha_formato(ByVal valor_fecha As String) As String
        Dim fechaformato As String
        Dim fecha As String
        fecha = valor_fecha
        fechaformato = Format(CDate(fecha), "yyyy/MM/dd")
        Return fechaformato
    End Function
    Private Function fecha_formato_invertido(ByVal valor_fecha As String) As String
        Dim fechaformato As String
        Dim fecha As String
        fecha = valor_fecha
        fechaformato = Format(CDate(fecha), "dd/MM/yyyy")
        Return fechaformato
    End Function

    Private Sub cbxAnno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAnno.SelectedIndexChanged
        If LTrim(txtCodPredio.Text) <> "" Then
            If comprobar_predio(txtCodPredio.Text) > 0 Then
                busqueda_predio(txtCodPredio.Text)
                cod_ficha()
            Else
                txtCodPredio.Text = "0"
            End If
        Else
            txtCodPredio.Text = "0"
        End If
    End Sub
    Private Sub cod_ficha()

        If codigo_ficha() = 0 Then
            codFicha = txtCodPredio.Text & cbxAnno.Text & txtCuadra.Text & codigo_ficha() + 1
        Else
            codFicha = txtCodPredio.Text & cbxAnno.Text & txtCuadra.Text & codigo_ficha()
        End If
    End Sub
    Private Sub clear()
        txtValorterreno.Text = 0
        txtValorConst.Text = 0
        txtBaseImponible.Text = 0
        txtBaseImponibleExo.Text = ""
        txtAreaConst.Text = ""
        txtCodPredio.Text = 0
        txtNumFicha.Text = ""
        txtNumDDJJ.Text = ""
        txtZona.Text = ""
        txtSector.Text = ""
        txtVia.Text = ""
        txtEnsisoVia.Text = ""
        txtNumVia.Text = ""
        txtManzana.Text = ""
        txtLote.Text = ""
        txtCuadra.Text = ""
        txtIdContribuyente.Text = ""
        txtNomContribuyente.Text = ""
        txtDirecContry.Text = ""
        txtArancel.Text = ""
        txtValorArancel.Text = ""
        txtNumeroExpediente.Text = ""
        txtResolMuni.Text = ""
        mtFecha.Text = ""
        txtAreaTerreno.Text = ""
        txtAreaComun.Text = ""
        txtAreaFrentera.Text = ""
        txtDistParque.Text = ""
        txtNumHabitantes.Text = ""
        dgwConstruciones.Rows.Clear()
        valor_columna = 0
        valor_fila = 0
        valorfila_agregado = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'colocando button
        sidePanel.Visible = True
        sidePanel.Width = btnUpdate.Width
        sidePanel.Top = btnUpdate.Bottom
        sidePanel.Location = btnUpdate.Location
        '/*****************************************/
        lblInfo.Text = "Actualizando Datos de Ficha"
        lblsubinfo.Text = "Se esta actualizando los Datos de::"
        Dim formulario2 As New d_rentas_busqueda_ficha
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            estado_boton = 3
            btnOption.Enabled = True
            btnOption.Image = My.Resources.update_white
            btnOption.Text = "Actualizar Datos"
            btnOption.BackColor = Color.FromArgb(150, 193, 31)
            idContribuyente = formulario2.valor_contribuyente
            txtCodPredio.Text = formulario2.valor_predio
            idFicha = formulario2.valor_ficha
            llamada_ficha(idFicha)
            btnOption.Enabled = True
            btnOption.Text = "Actualizar Datos"
            activar_paneles()
        Else
            sidePanel.Visible = False
            estado_boton = 0
            btnOption.Enabled = False
            btnOption.Text = "Bloqueado"
            btnOption.Image = My.Resources.padlock
            btnOption.BackColor = Color.FromArgb(128, 131, 140)
            'limpiar_infoPanel()
            desactivar_paneles()
            clear()
        End If
    End Sub
    Private Sub llamada_ficha(valor As Integer)
        Dim datos_ficha As New class_datos_ficha
        cargar_datos_ficha(valor, datos_ficha)
        idFicha = datos_ficha.id_ficha
        'codigo de ficha
        codigoFicha = datos_ficha.codigo_ficha
        txtNumFicha.Text = datos_ficha.numero_ficha
        txtNumDDJJ.Text = datos_ficha.numero_djj_ficha
        'actualización de año de cobro y tipo de ddjj
        _DatasetAnnio.Reset()
        consulta_datos_annio_by(datos_ficha.anno_ficha)
        cbxAnno.DataSource = _DatasetAnnio.Tables("anno")
        cbxAnno.DisplayMember = "anno"
        cbxAnno.ValueMember = "idanno"
        '/*********************/
        _DatasetTipoFichaBox.Reset()
        consulta_datos_tipoFicha_combox(datos_ficha.cod_tipo_ficha)
        cbxTipoFicha.DataSource = _DatasetTipoFichaBox.Tables("tipo_ficha")
        cbxTipoFicha.DisplayMember = "nombre"
        cbxTipoFicha.ValueMember = "idtipo_ficha"
        'actualizando exoneración 
        _DatasetTiporegimenBox.Reset()
        consulta_datos_tipoRegimen_combox(datos_ficha.codDeduccion_ficha)
        cbxRegExoneracion.DataSource = _DatasetTiporegimenBox.Tables("regimen")
        cbxRegExoneracion.DisplayMember = "nombre"
        cbxRegExoneracion.ValueMember = "idregimen"
        'actualizando condicion de propiedad
        _DatasetConTituloBox.Reset()
        consulta_datos_condTitulo_combox(datos_ficha.condicion_titular_fichas)
        cbxCondTitular.DataSource = _DatasetConTituloBox.Tables("condicion_titular")
        cbxCondTitular.DisplayMember = "denominacion"
        cbxCondTitular.ValueMember = "idcondicion_titular"
        'actualizando modo de adquisicion
        _DatasetModoAdqBox.Reset()
        consulta_datos_modoAdq_combox(datos_ficha.modo_adquisicion_ficha)
        cbxModoAdq.DataSource = _DatasetModoAdqBox.Tables("modo_adq")
        cbxModoAdq.DisplayMember = "denominacion"
        cbxModoAdq.ValueMember = "idmodo_adq"
        'actualizar fecha
        mtFecha.Text = fecha_formato_invertido(datos_ficha.fecha_adquisicion_fichas)
        'actualizando  uso de predio
        _DatasetUsoPredioBox.Reset()
        consulta_datos_usoPredio_combox(datos_ficha.uso_predial_ficha)
        cbxusoPredio.DataSource = _DatasetUsoPredioBox.Tables("uso_predio")
        cbxusoPredio.DisplayMember = "denominacion"
        cbxusoPredio.ValueMember = "iduso_predio"
        'actualizando  estado de predio
        _DatasetEstadoPredioBox.Reset()
        consulta_datos_estadoPredio_combox(datos_ficha.estadoPredio_ficha)
        cbxEstadoPredio.DataSource = _DatasetEstadoPredioBox.Tables("estado_predio")
        cbxEstadoPredio.DisplayMember = "denominacion"
        cbxEstadoPredio.ValueMember = "idestado_predio"
        'actualizando  tipo de predio
        _DatasetTipoPredioBox.Reset()
        consulta_datos_tipoPredio_combox(datos_ficha.tipoPredio_ficha)
        cbxTipoPredio.DataSource = _DatasetTipoPredioBox.Tables("tipo_predio")
        cbxTipoPredio.DisplayMember = "denominacion"
        cbxTipoPredio.ValueMember = "idtipo_predio"
        txtAreaTerreno.Text = datos_ficha.area_terreno_ficha
        txtAreaComun.Text = datos_ficha.area_comun_ficha
        txtAreaFrentera.Text = datos_ficha.area_frentera_fichas
        txtDistParque.Text = datos_ficha.distancia_parque_ficha
        txtNumHabitantes.Text = datos_ficha.numero_habitante_ficha
        'llenado las construcciones
        llenado_construcciones(datos_ficha.id_ficha)

    End Sub
    Sub llenado_construcciones(ByVal cod_fichas As Integer)
        ReDim idconstrucciones(cantidad_construccion_by_ficha(cod_fichas) - 1)
        _DatasetConstrucciones.Reset()
        Dim datos As New class_datos_construcciones
        contrucciones_By_Codigo(datos, cod_fichas)
        Dim mrdd As Integer
        For Each row As DataRow In _DatasetConstrucciones.Tables(0).Rows
            dgwConstruciones.Rows.Add()
            mrdd = Convert.ToInt32(row("idconstruccion"))
            idconstrucciones(filas_actual) = mrdd
            filas_actual += 1
            dgwConstruciones.Rows(valorfila_agregado).Cells("piso").Value = row("piso")
            dgwConstruciones.Rows(valorfila_agregado).Cells("predio").Value = row("predio")
            dgwConstruciones.Rows(valorfila_agregado).Cells("antiguedad").Value = row("antiguedad")
            dgwConstruciones.Rows(valorfila_agregado).Cells("cod_clasificacion").Value = row("codigo_clasificacion")
            dgwConstruciones.Rows(valorfila_agregado).Cells("nom_clasificacion").Value = row("clasificacion")
            dgwConstruciones.Rows(valorfila_agregado).Cells("material_clasificacion").Value = row("codigo-material")
            dgwConstruciones.Rows(valorfila_agregado).Cells("nom_material").Value = row("material")
            dgwConstruciones.Rows(valorfila_agregado).Cells("cod_estadoConsv").Value = row("codigo_estadoconservacion")
            dgwConstruciones.Rows(valorfila_agregado).Cells("nom_estadoConsv").Value = row("estado_conservacion")
            dgwConstruciones.Rows(valorfila_agregado).Cells("categoria").Value = row("categoria")
            dgwConstruciones.Rows(valorfila_agregado).Cells("valor_unitario").Value = row("valor_unitario")
            dgwConstruciones.Rows(valorfila_agregado).Cells("inc5").Value = row("inc_5x100")
            dgwConstruciones.Rows(valorfila_agregado).Cells("depreciacion").Value = row("x100_dep")
            dgwConstruciones.Rows(valorfila_agregado).Cells("valor_depreciacion").Value = row("val_dep")
            dgwConstruciones.Rows(valorfila_agregado).Cells("valor_unitario_depreciacion").Value = row("val_unidaddep")
            dgwConstruciones.Rows(valorfila_agregado).Cells("area_construccion").Value = row("area_construida")
            dgwConstruciones.Rows(valorfila_agregado).Cells("total").Value = row("total")
            Me.valorfila_agregado = Me.valorfila_agregado + 1
        Next
        calcular_total_pisos()
    End Sub
    Sub calcular_total_pisos()
        Dim BaseImponibleTotal As Double = 0
        Dim TotalAreaConstruida As Double = 0
        Dim SelectedCellTotal As Integer = 0
        Dim counter As Integer

        ' Iterate through all the rows and sum up the appropriate columns.
        For counter = 0 To (dgwConstruciones.Rows.Count - 1)
            If Not dgwConstruciones.Rows(counter).Cells("total").Value Is Nothing Then
                If Not dgwConstruciones.Rows(counter).Cells("total").Value.ToString().Length = 0 Then

                    BaseImponibleTotal += Double.Parse(dgwConstruciones.Rows(counter).Cells("total").Value.ToString())
                End If
            End If
        Next
        For counter = 0 To (dgwConstruciones.Rows.Count - 1)
            If Not dgwConstruciones.Rows(counter).Cells("area_construccion").Value Is Nothing Then
                If Not dgwConstruciones.Rows(counter).Cells("area_construccion").Value.ToString().Length = 0 Then
                    TotalAreaConstruida += Double.Parse(dgwConstruciones.Rows(counter).Cells("area_construccion").Value.ToString())
                End If
            End If
        Next
        'guardando datos en casilleros
        txtValorConst.Text = BaseImponibleTotal.ToString()
        txtAreaConst.Text = TotalAreaConstruida.ToString()
    End Sub

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        'agregar ficha
        If estado_boton = 2 Then
            Dim conexion_ficha As New class_controller_ficha
            Dim datos_fichas As New class_datos_ficha
            If alta() Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 001",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                datos_fichas.codigo_ficha = codFicha
                datos_fichas.anno_ficha = cbxAnno.SelectedValue.ToString()
                datos_fichas.numero_ficha = txtNumFicha.Text
                datos_fichas.numero_djj_ficha = txtNumDDJJ.Text
                datos_fichas.arancel_ficha = txtArancel.Text
                datos_fichas.valor_ficha = txtValorArancel.Text
                datos_fichas.condicion_titular_fichas = cbxCondTitular.SelectedValue.ToString()
                datos_fichas.modo_adquisicion_ficha = cbxModoAdq.SelectedValue.ToString()
                datos_fichas.fecha_adquisicion_fichas = fecha_formato(mtFecha.Text)
                datos_fichas.area_terreno_ficha = txtAreaTerreno.Text
                datos_fichas.area_comun_ficha = txtAreaComun.Text
                datos_fichas.area_construida_fichas = 0
                datos_fichas.area_frentera_fichas = txtAreaFrentera.Text
                datos_fichas.uso_predial_ficha = cbxusoPredio.SelectedValue.ToString()
                datos_fichas.distancia_parque_ficha = txtDistParque.Text
                datos_fichas.numero_habitante_ficha = txtNumHabitantes.Text
                datos_fichas.cod_predio = txtCodPredio.Text
                datos_fichas.cod_tipo_ficha = cbxTipoFicha.SelectedValue.ToString()
                datos_fichas.valorTerreno_ficha = txtValorterreno.Text
                datos_fichas.valorConstruccion_ficha = txtValorConst.Text
                datos_fichas.baseImponible_ficha = txtBaseImponible.Text
                datos_fichas.valorDeduccion_ficha = valor_deduccion
                datos_fichas.tipoDeduccion_ficha = tipo_deducion
                datos_fichas.totalBaseimpDeduccion_ficha = total_base_imponible
                datos_fichas.estadoPredio_ficha = cbxEstadoPredio.SelectedValue.ToString()
                datos_fichas.tipoPredio_ficha = cbxTipoPredio.SelectedValue.ToString()
                datos_fichas.codDeduccion_ficha = cbxRegExoneracion.SelectedValue.ToString()
                If conexion_ficha.insertarDatosContibuyente(datos_fichas) Then

                    idFicha = datos_fichas.id_ficha
                    'MessageBox.Show(idFicha)
                    Try
                        For Each row As DataGridViewRow In dgwConstruciones.Rows
                            Dim datos As New class_datos_construcciones
                            Dim conexion As New class_controller_construcciones
                            Dim piso As Integer
                            Dim antiguedad As Integer
                            Dim codClas As Integer
                            Dim clasi As String
                            Dim codmat As Integer
                            Dim material As String
                            Dim codConserv As Integer
                            Dim conserv As String
                            Dim categoria As String
                            Dim valUnit As Double
                            Dim inc As Double
                            Dim dep As Double
                            Dim valDep As Double
                            Dim valUnitDep As Double
                            Dim area As Double
                            Dim total As Double
                            Dim codFicha As Integer
                            Dim predio As String
                            piso = Convert.ToString(row.Cells(0).Value)
                            datos.piso_construccion = piso
                            'MessageBox.Show(piso)

                            predio = Convert.ToString(row.Cells(1).Value)
                            datos.predio_construccion = predio
                            'MessageBox.Show(piso)

                            antiguedad = Convert.ToString(row.Cells(2).Value)
                            datos.antiguedad_construccion = antiguedad
                            'MessageBox.Show(antiguedad)

                            codClas = Convert.ToString(row.Cells(3).Value)
                            datos.codClasificacion_construccion = codClas
                            'MessageBox.Show(codClas)

                            clasi = Convert.ToString(row.Cells(4).Value)
                            datos.clasificacion_construccion = clasi
                            'MessageBox.Show(clasi)

                            codmat = Convert.ToString(row.Cells(5).Value)
                            datos.codMaterial_construccion = codmat
                            'MessageBox.Show(codmat)

                            material = Convert.ToString(row.Cells(6).Value)
                            datos.material_construccion = material
                            'MessageBox.Show(material)

                            codConserv = Convert.ToString(row.Cells(7).Value)
                            datos.codEstConserv_construccion = codConserv
                            'MessageBox.Show(codConserv)

                            conserv = Convert.ToString(row.Cells(8).Value)
                            datos.estConserv_construccion = conserv
                            'MessageBox.Show(conserv)

                            categoria = Convert.ToString(row.Cells(9).Value)
                            datos.categoria_construccion = categoria
                            'MessageBox.Show(categoria)

                            valUnit = Convert.ToString(row.Cells(10).Value)
                            datos.valorUnitario_construccion = valUnit
                            'MessageBox.Show(valUnit)

                            inc = Convert.ToString(row.Cells(11).Value)
                            datos.inc5x100_construccion = inc
                            'MessageBox.Show(inc)

                            dep = Convert.ToString(row.Cells(12).Value)
                            datos.x100_dep_construccion = dep
                            'MessageBox.Show(dep)

                            valDep = Convert.ToString(row.Cells(13).Value)
                            datos.valDepreciacion_construccion = valDep
                            'MessageBox.Show(valDep)

                            valUnitDep = Convert.ToString(row.Cells(14).Value)
                            datos.valUnitDep_construccion = valUnitDep
                            'MessageBox.Show(valUnitDep)

                            area = Convert.ToString(row.Cells(15).Value)
                            datos.areaConst_construccion = area
                            'MessageBox.Show(area)

                            total = Convert.ToString(row.Cells(16).Value)
                            datos.total_construccion = total
                            'MessageBox.Show(total)

                            codFicha = idFicha
                            datos.cod_ficha_construccion = codFicha
                            'MessageBox.Show(codFicha)

                            If conexion.insertarDatosConstrucciones(datos) Then
                                'MessageBox.Show("datos guardados")
                            Else
                                'MessageBox.Show("datos no guardados")
                            End If

                        Next
                        'guardando documentos de base legal
                        Dim datos_doc As New class_datos_docBaseLegal
                        Dim conexion_doc As New class_controller_docBaseLegal
                        datos_doc.numExpediente_docBaseLegal = cbxBaseLegal.SelectedValue.ToString()
                        datos_doc.numExpediente_docBaseLegal = txtNumeroExpediente.Text
                        datos_doc.numResolucion_docBaseLegal = txtResolMuni.Text
                        datos_doc.codFicha_docBaseLegal = idFicha
                        If conexion_doc.insertarDatosDocbaselegal(datos_doc) Then
                            'MessageBox.Show("datos guardados")
                        Else
                            'MessageBox.Show("datos no guardados")
                        End If

                    Catch ex As Exception
                        MessageBox.Show("los datos ingresados no son los correctos")
                    End Try
                    MessageBox.Show("Se han guardado los datos correctamente", "Datos Guardados de la Ficha",
               MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sidePanel.Visible = False
                    estado_boton = 0
                    btnOption.Enabled = False
                    btnOption.Text = "Bloqueado"
                    btnOption.Image = My.Resources.padlock
                    btnOption.BackColor = Color.FromArgb(128, 131, 140)
                    desactivar_paneles()
                    clear()
                Else
                    MessageBox.Show("Lo sentimos no podemos pudimos guardar sus datos verefique los datos ingresados", "Error: 002",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
        'actualizar ficha
        If estado_boton = 3 Then
            If alta() = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim conexion_fichas As New class_controller_ficha
                Dim datos_fichas As New class_datos_ficha
                'actualizando datos ficha
                datos_fichas.id_ficha = idFicha
                datos_fichas.codigo_ficha = codigoFicha
                datos_fichas.anno_ficha = cbxAnno.SelectedValue.ToString()
                datos_fichas.numero_ficha = txtNumFicha.Text
                datos_fichas.numero_djj_ficha = txtNumDDJJ.Text
                datos_fichas.arancel_ficha = txtArancel.Text
                datos_fichas.valor_ficha = txtValorArancel.Text
                datos_fichas.condicion_titular_fichas = cbxCondTitular.SelectedValue.ToString()
                datos_fichas.modo_adquisicion_ficha = cbxModoAdq.SelectedValue.ToString()
                datos_fichas.fecha_adquisicion_fichas = fecha_formato(mtFecha.Text)
                datos_fichas.area_terreno_ficha = txtAreaTerreno.Text
                datos_fichas.area_comun_ficha = txtAreaComun.Text
                datos_fichas.area_construida_fichas = 0
                datos_fichas.area_frentera_fichas = txtAreaFrentera.Text
                datos_fichas.uso_predial_ficha = cbxusoPredio.SelectedValue.ToString()
                datos_fichas.distancia_parque_ficha = txtDistParque.Text
                datos_fichas.numero_habitante_ficha = txtNumHabitantes.Text
                datos_fichas.cod_predio = txtCodPredio.Text
                datos_fichas.cod_tipo_ficha = cbxTipoFicha.SelectedValue.ToString()
                datos_fichas.valorTerreno_ficha = txtValorterreno.Text
                datos_fichas.valorConstruccion_ficha = txtValorConst.Text
                datos_fichas.baseImponible_ficha = txtBaseImponible.Text
                datos_fichas.valorDeduccion_ficha = valor_deduccion
                datos_fichas.tipoDeduccion_ficha = tipo_deducion
                datos_fichas.totalBaseimpDeduccion_ficha = total_base_imponible
                datos_fichas.estadoPredio_ficha = cbxEstadoPredio.SelectedValue.ToString()
                datos_fichas.tipoPredio_ficha = cbxTipoPredio.SelectedValue.ToString()
                datos_fichas.codDeduccion_ficha = cbxRegExoneracion.SelectedValue.ToString()

                If conexion_fichas.actualizarDatosFicha(datos_fichas) Then
                    Dim datos As New class_datos_construcciones
                    Dim conexion As New class_controller_construcciones
                    Dim piso As Integer
                    Dim antiguedad As Integer
                    Dim codClas As Integer
                    Dim clasi As String
                    Dim codmat As Integer
                    Dim material As String
                    Dim codConserv As Integer
                    Dim conserv As String
                    Dim categoria As String
                    Dim valUnit As Double
                    Dim inc As Double
                    Dim dep As Double
                    Dim valDep As Double
                    Dim valUnitDep As Double
                    Dim area As Double
                    Dim total As Double
                    Dim codFicha As Integer
                    Dim predio As String
                    'variable para hallar
                    Dim contador As Integer = 0
                    If dgwConstruciones.Rows.Count > cantidad_construccion_by_ficha(codFicha) Or dgwConstruciones.Rows.Count = cantidad_construccion_by_ficha(codFicha) Then
                        For Each row As DataGridViewRow In dgwConstruciones.Rows

                            piso = Convert.ToString(row.Cells(0).Value)
                            datos.piso_construccion = piso
                            'MessageBox.Show(piso)

                            predio = Convert.ToString(row.Cells(1).Value)
                            datos.predio_construccion = predio
                            'MessageBox.Show(codFicha)

                            antiguedad = Convert.ToString(row.Cells(2).Value)
                            datos.antiguedad_construccion = antiguedad
                            'MessageBox.Show(antiguedad)

                            codClas = Convert.ToString(row.Cells(3).Value)
                            datos.codClasificacion_construccion = codClas
                            'MessageBox.Show(codClas)

                            clasi = Convert.ToString(row.Cells(4).Value)
                            datos.clasificacion_construccion = clasi
                            'MessageBox.Show(clasi)

                            codmat = Convert.ToString(row.Cells(5).Value)
                            datos.codMaterial_construccion = codmat
                            'MessageBox.Show(codmat)

                            material = Convert.ToString(row.Cells(6).Value)
                            datos.material_construccion = material
                            'MessageBox.Show(material)

                            codConserv = Convert.ToString(row.Cells(7).Value)
                            datos.codEstConserv_construccion = codConserv
                            'MessageBox.Show(codConserv)

                            conserv = Convert.ToString(row.Cells(8).Value)
                            datos.estConserv_construccion = conserv
                            'MessageBox.Show(conserv)

                            categoria = Convert.ToString(row.Cells(9).Value)
                            datos.categoria_construccion = categoria
                            'MessageBox.Show(categoria)

                            valUnit = Convert.ToString(row.Cells(10).Value)
                            datos.valorUnitario_construccion = valUnit
                            'MessageBox.Show(valUnit)

                            inc = Convert.ToString(row.Cells(11).Value)
                            datos.inc5x100_construccion = inc
                            'MessageBox.Show(inc)

                            dep = Convert.ToString(row.Cells(12).Value)
                            datos.x100_dep_construccion = dep
                            'MessageBox.Show(dep)

                            valDep = Convert.ToString(row.Cells(13).Value)
                            datos.valDepreciacion_construccion = valDep
                            'MessageBox.Show(valDep)

                            valUnitDep = Convert.ToString(row.Cells(14).Value)
                            datos.valUnitDep_construccion = valUnitDep
                            'MessageBox.Show(valUnitDep)

                            area = Convert.ToString(row.Cells(15).Value)
                            datos.areaConst_construccion = area
                            'MessageBox.Show(area)

                            total = Convert.ToString(row.Cells(16).Value)
                            datos.total_construccion = total
                            'MessageBox.Show(total)

                            codFicha = idFicha
                            datos.cod_ficha_construccion = codFicha
                            If contador <= idconstrucciones.Length - 1 Then
                                If cantidad_construccion_by(idconstrucciones(contador)) > 0 Then
                                    datos.id_construccion = idconstrucciones(contador)
                                    contador += 1
                                    If conexion.actualizarDatosConstrucciones(datos) Then
                                        MessageBox.Show("datos guardados construcciones")
                                    Else
                                        MessageBox.Show("datos no guardados construcciones")
                                    End If

                                Else

                                    If conexion.insertarDatosConstrucciones(datos) Then
                                        MessageBox.Show("datos guardados construcciones")
                                    Else
                                        MessageBox.Show("datos no guardados construcciones")
                                    End If

                                End If

                            Else

                                If conexion.insertarDatosConstrucciones(datos) Then
                                    MessageBox.Show("datos guardados construcciones")
                                    contador += 1
                                Else
                                    MessageBox.Show("datos no guardados construcciones")
                                End If

                            End If
                        Next
                        For index As Integer = contador To idconstrucciones.Length - 1
                            datos.id_construccion = idconstrucciones(contador)
                            contador += 1
                            If conexion.eliminarDatosConstrucciones(datos) Then
                                MessageBox.Show("datos eleminados")
                            Else
                                MessageBox.Show("datos no eliminados")
                            End If

                        Next
                        MessageBox.Show("datos guardados ficha")
                        estado_boton = 0
                        clear()
                        btnOption.Enabled = False
                    End If
                Else
                    MessageBox.Show("datos no guardados ficha")
                End If
            End If
        End If
        If estado_boton = 4 Then
            Dim Result As DialogResult
            Result = MessageBox.Show("Estas seguro que deseas eliminar la Ficha los cambios no podran ser revertidos ?", "Confimación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                'eliminar ficha
                Dim datos_ficha As New class_datos_ficha
                Dim conexion_ficha As New class_controller_ficha
                datos_ficha.id_ficha = idFicha
                If conexion_ficha.eliminarDatosFicha(datos_ficha) Then
                    MessageBox.Show("El Predio fue eliminado", "Información de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'limpiar_infoPanel()
                    estado_boton = 0
                Else
                    MessageBox.Show("No pudimos eliminar el Predio, Intente de nuevo", "Información de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
            End If


        End If
    End Sub

    Private Sub dgwConstruciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwConstruciones.CellClick
        posicion_celdas()
    End Sub
    Private Sub posicion_celdas()
        valor_columna = String.Format("{1}", dgwConstruciones.CurrentCell.RowIndex, dgwConstruciones.CurrentCell.ColumnIndex)
        'MessageBox.Show(valor_columna)
        valor_fila = String.Format("{0}", dgwConstruciones.CurrentCell.RowIndex, dgwConstruciones.CurrentCell.ColumnIndex)
        'MessageBox.Show(valor_fila)
    End Sub


    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        MessageBox.Show(idconstrucciones.Length)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        For index As Integer = 0 To idconstrucciones.Length - 1
            MessageBox.Show(idconstrucciones(index))
        Next
    End Sub
    Private Sub activar_paneles()
        gbTipo.Enabled = True
        gb_arancel.Enabled = True
        gb_construcciones.Enabled = True
        gb_ficha.Enabled = True
        gb_regimen.Enabled = True
        gb_titular.Enabled = True
        gb_titularidad.Enabled = True
        gb_ubicacion.Enabled = True
    End Sub
    Private Sub desactivar_paneles()
        gbTipo.Enabled = False
        gb_arancel.Enabled = False
        gb_construcciones.Enabled = False
        gb_ficha.Enabled = False
        gb_regimen.Enabled = False
        gb_titular.Enabled = False
        gb_titularidad.Enabled = False
        gb_ubicacion.Enabled = False
    End Sub


End Class
