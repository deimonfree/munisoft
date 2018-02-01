Public Class uc_rentas_ficha_new
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
        'llenado de estado de predio
        MessageBox.Show("llenando ")
        _DatasetEstadoPredioBox.Reset()
        consulta_datos_estadoPredio_combox_all()
        cbxEstadoPredio.DataSource = _DatasetEstadoPredioBox.Tables("estado_predio")
        cbxEstadoPredio.DisplayMember = "denominacion"
        cbxEstadoPredio.ValueMember = "idestado_predio"
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
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim datos_predio As New class_datos_predio
        Dim datos_contribuyente As New class_datos_contribuyente
        lblInfo.Text = "Actualizando Contribuyente"
        Dim formulario2 As New d_rentas_busqueda
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            IdPredio = formulario2.valor_contribuyente
            cargar_datos_predio(IdPredio, datos_predio)
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
            'llamar sector
            llamada_sector(datos_predio.codSector_predio)
            'calcular valor arancelario //////////////////////////////
            calcular_Arancel(idVia, txtCuadra.Text, cbxAnno.SelectedValue.ToString())
        End If
    End Sub
    Private Sub llamada_sector(valor As Integer)
        Dim datos_sector As New class_datos_sector
        cargar_datos_sector(valor, datos_sector)
        'IdContibuyente = valor
        txtSector.Text = datos_sector.nombre_sector
        idZona = datos_sector.codZona_sector
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
        If LTrim(txtAreaTerreno.Text) = "" Then
            txtValorArancel.Text = 0
        Else
            txtValorArancel.Text = txtArancel.Text * txtAreaTerreno.Text
        End If
    End Sub

    Private Sub txtValorArancel_TextChanged(sender As Object, e As EventArgs) Handles txtValorArancel.TextChanged
        txtValorterreno.Text = txtValorArancel.Text
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        fila = e.RowIndex
        columna = e.ColumnIndex
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim WithdrawalTotal As Double = 0
        Dim DepositTotal As Integer = 0
        Dim SelectedCellTotal As Integer = 0
        Dim counter As Integer

        ' Iterate through all the rows and sum up the appropriate columns.
        For counter = 0 To (dgwConstruciones2.Rows.Count - 1)
            If Not dgwConstruciones2.Rows(counter).Cells("total2").Value Is Nothing Then
                If Not dgwConstruciones2.Rows(counter).Cells("total2").Value.ToString().Length = 0 Then

                    WithdrawalTotal += Double.Parse(dgwConstruciones2.Rows(counter).Cells("total2").Value.ToString())
                End If
            End If

            If Not dgwConstruciones2.Rows(counter).Cells("antiguedad").Value Is Nothing Then

                If Not dgwConstruciones2.Rows(counter).Cells("antiguedad").Value.ToString().Length = 0 Then

                    DepositTotal += Integer.Parse(dgwConstruciones2.Rows(counter).Cells("antiguedad").Value.ToString())
                End If
            End If
        Next

        ' Iterate through the SelectedCells collection and sum up the values.
        For counter = 0 To (dgwConstruciones2.SelectedCells.Count - 1)
            If dgwConstruciones2.SelectedCells(counter).FormattedValueType Is
        Type.GetType("System.String") Then

                Dim value As String = Nothing

                ' If the cell contains a value that has not been commited,
                ' use the modified value.
                If (dgwConstruciones2.IsCurrentCellDirty = True) Then

                    value = dgwConstruciones2.SelectedCells(counter).EditedFormattedValue.ToString()
                Else

                    value = dgwConstruciones2.SelectedCells(counter).FormattedValue.ToString()
                End If

                If value IsNot Nothing Then

                    ' Ignore cells in the Description column.
                    If Not dgwConstruciones2.SelectedCells(counter).ColumnIndex = dgwConstruciones2.Columns("total2").Index Then

                        If Not value.Length = 0 Then
                            SelectedCellTotal += Integer.Parse(value)
                        End If
                    End If
                End If
            End If

        Next

        ' Set the labels to reflect the current state of the DataGridView.
        txtValorConst.Text = WithdrawalTotal.ToString()

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
            Dim msg As String = String.Format("{0}, {1}", dgwConstruciones2.CurrentCell.RowIndex, dgwConstruciones2.CurrentCell.ColumnIndex)
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
            dgwConstruciones2.Rows(0).Cells("total2").Value = chipi.ToString()
        Catch ex As Exception

        End Try
    End Sub
    Sub valor_celda(ByVal valor_celda As Integer)
        Select Case valor_celda
            Case 0
                dgwConstruciones2.Rows(valorfila).Cells("inc52").Value = 0.00
                dgwConstruciones2.Rows(valorfila).Cells("categoria2").Value = "PRES-F1"
            Case 1
                Dim valor_antiguedad As Integer
                valor_antiguedad = Me.dgwConstruciones2.Rows(valorfila).Cells("antiguedad2").Value
                annio_antiguedad_terreno = antiguedadPredio(valor_antiguedad)
                calculo_depreciacion()
            Case 2
                Dim clasificacionVivienda As New class_datos_clasificacion
                Dim valor As Integer
                valor = Me.dgwConstruciones2.Rows(valorfila).Cells("cod_clasificacion2").Value
                cargar_datos_clasificacionVivienda(valor, clasificacionVivienda)
                dgwConstruciones2.Rows(valorfila).Cells("nom_clasificacion2").Value = clasificacionVivienda.id_clasificacion & " -" & clasificacionVivienda.denominacion_clasificacion
                calculo_depreciacion()
                dgwConstruciones2.Rows(valorfila).Cells("nom_clasificacion2").ReadOnly = True
            Case 3

            Case 4
                Dim materialVivienda As New class_datos_material
                Dim valor As Integer
                valor = Me.dgwConstruciones2.Rows(valorfila).Cells("material_clasificacion2").Value
                cargar_datos_materialVivienda(valor, materialVivienda)
                dgwConstruciones2.Rows(valorfila).Cells("nom_material2").Value = materialVivienda.id_materialVivienda & " -" & materialVivienda.denominacion_materialVivienda
                calculo_depreciacion()
                dgwConstruciones2.Rows(valorfila).Cells("nom_material2").ReadOnly = True
            Case 5
            Case 6
                Dim conservacionVivienda As New class_datos_conservacion
                Dim valor As Integer
                valor = Me.dgwConstruciones2.Rows(valorfila).Cells("cod_estadoConsv2").Value
                cargar_datos_conservacionVivienda(valor, conservacionVivienda)
                dgwConstruciones2.Rows(valorfila).Cells("nom_estadoConsv2").Value = conservacionVivienda.id_conservacionVivienda & " -" & conservacionVivienda.denominacion_conservacionVivienda
                calculo_depreciacion()
                dgwConstruciones2.Rows(valorfila).Cells("nom_estadoConsv2").ReadOnly = True
            Case 7
            Case 8
                dgwConstruciones2.Rows(valorfila).Cells("categoria2").ReadOnly = True
            Case 9
                valorDepreciacion()
            Case 14
                Dim area As Double
                Dim valor_dep As Double
                Dim total As Double
                area = Me.dgwConstruciones2.Rows(valorfila).Cells("area_construccion2").Value
                valor_dep = Me.dgwConstruciones2.Rows(valorfila).Cells("valor_unitario_depreciacion2").Value
                total = area * valor_dep
                dgwConstruciones2.Rows(valorfila).Cells("total2").Value = total
        End Select
    End Sub
    Sub calculo_categoria(ByVal cadena As String)
        valor_unitario_terreno = 0
        'leendo caracteres
        Dim recorrido As Integer = 1
        cadena = idCategoria
        Try
            For i As Integer = 0 To cadena.Length
                If recorrido = 1 Then
                    Select Case cadena.Substring(i, 1)
                        Case "a"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(1, "2016")
                        Case "b"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(2, "2016")
                        Case "c"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(3, "2016")
                        Case "d"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(4, "2016")
                        Case "e"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(5, "2016")
                        Case "f"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(6, "2016")
                        Case "g"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(7, "2016")
                        Case "h"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(8, "2016")
                        Case "i"
                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_murosColumnas(9, "2016")
                    End Select
                Else
                    If recorrido = 2 Then
                        Select Case cadena.Substring(i, 1)
                            Case "a"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(1, "2016")
                            Case "b"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(2, "2016")
                            Case "c"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(3, "2016")
                            Case "d"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(4, "2016")
                            Case "e"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(5, "2016")
                            Case "f"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(6, "2016")
                            Case "g"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(7, "2016")
                            Case "h"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(8, "2016")
                            Case "i"
                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_techos(9, "2016")
                        End Select
                    Else
                        If recorrido = 3 Then
                            Select Case cadena.Substring(i, 1)
                                Case "a"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(1, "2016")
                                Case "b"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(2, "2016")
                                Case "c"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(3, "2016")
                                Case "d"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(4, "2016")
                                Case "e"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(5, "2016")
                                Case "f"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(6, "2016")
                                Case "g"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(7, "2016")
                                Case "h"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(8, "2016")
                                Case "i"
                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_pisos(9, "2016")
                            End Select
                        Else
                            If recorrido = 4 Then
                                Select Case cadena.Substring(i, 1)
                                    Case "a"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(1, "2016")
                                    Case "b"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(2, "2016")
                                    Case "c"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(3, "2016")
                                    Case "d"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(4, "2016")
                                    Case "e"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(5, "2016")
                                    Case "f"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(6, "2016")
                                    Case "g"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(7, "2016")
                                    Case "h"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(8, "2016")
                                    Case "i"
                                        valor_unitario_terreno = valor_unitario_terreno + valorUnitario_puertasVentanas(9, "2016")
                                End Select
                            Else
                                If recorrido = 5 Then
                                    Select Case cadena.Substring(i, 1)
                                        Case "a"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(1, "2016")
                                        Case "b"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(2, "2016")
                                        Case "c"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(3, "2016")
                                        Case "d"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(4, "2016")
                                        Case "e"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(5, "2016")
                                        Case "f"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(6, "2016")
                                        Case "g"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(7, "2016")
                                        Case "h"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(8, "2016")
                                        Case "i"
                                            valor_unitario_terreno = valor_unitario_terreno + valorUnitario_revestimiento(9, "2016")
                                    End Select
                                Else
                                    If recorrido = 6 Then
                                        Select Case cadena.Substring(i, 1)
                                            Case "a"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(1, "2016")
                                            Case "b"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(2, "2016")
                                            Case "c"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(3, "2016")
                                            Case "d"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(4, "2016")
                                            Case "e"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(5, "2016")
                                            Case "f"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(6, "2016")
                                            Case "g"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(7, "2016")
                                            Case "h"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(8, "2016")
                                            Case "i"
                                                valor_unitario_terreno = valor_unitario_terreno + valorUnitario_banios(9, "2016")
                                        End Select
                                    Else
                                        If recorrido = 7 Then
                                            Select Case cadena.Substring(i, 1)
                                                Case "a"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(1, "2016")
                                                Case "b"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(2, "2016")
                                                Case "c"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(3, "2016")
                                                Case "d"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(4, "2016")
                                                Case "e"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(5, "2016")
                                                Case "f"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(6, "2016")
                                                Case "g"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(7, "2016")
                                                Case "h"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(8, "2016")
                                                Case "i"
                                                    valor_unitario_terreno = valor_unitario_terreno + valorUnitario_elecSanitarias(9, "2016")
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
            dgwConstruciones2.Rows(valorfila).Cells("valor_unitario2").Value = valor_unitario_terreno
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
        antiguedad = annio_antiguedad_terreno
        clasificacion = Me.dgwConstruciones2.Rows(valorfila).Cells("cod_clasificacion2").Value
        material = Me.dgwConstruciones2.Rows(valorfila).Cells("material_clasificacion2").Value
        conservacion = Me.dgwConstruciones2.Rows(valorfila).Cells("cod_estadoConsv2").Value
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
            dgwConstruciones2.Rows(valorfila).Cells("depreciacion2").Value = 0
        Else
            cargar_datos_depreciacion(clasificacion, antiguedad, material, conservacion, 2016, datos_depreciacion)
            dgwConstruciones2.Rows(valorfila).Cells("depreciacion2").Value = datos_depreciacion.valor_depreciacion
            porcen_depreciacion = datos_depreciacion.valor_depreciacion
        End If
    End Sub
    Sub valorDepreciacion()
        Dim valorUnitario As Double
        Dim depreciacion As Double
        valorUnitario = Me.dgwConstruciones2.Rows(valorfila).Cells("valor_unitario2").Value
        depreciacion = Me.dgwConstruciones2.Rows(valorfila).Cells("depreciacion2").Value
        valor_depre = (valorUnitario * depreciacion) / 100
        dgwConstruciones2.Rows(valorfila).Cells("valor_depreciacion2").Value = valor_depre
    End Sub
    Private Sub val_U_dep()
        valor_unit_depre = 0
        Dim valorDepre As Double
        Dim valorUnit As Double
        valorDepre = Me.dgwConstruciones2.Rows(valorfila).Cells("valor_depreciacion2").Value
        valorUnit = Me.dgwConstruciones2.Rows(valorfila).Cells("valor_unitario2").Value
        valor_unit_depre = valorUnit - valorDepre
        dgwConstruciones2.Rows(valorfila).Cells("valor_unitario_depreciacion2").Value = valor_unit_depre
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
    Private Sub dgwConstruciones_KeyUp(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.F1
                Dim formulario2 As New d_rentas_categoria
                Dim datoRecuperado As DialogResult
                datoRecuperado = formulario2.ShowDialog()
                If datoRecuperado = DialogResult.OK Then
                    idCategoria = formulario2.valor_categoria
                    dgwConstruciones2.Rows(valorfila).Cells("categoria2").Value = idCategoria
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If verificacion_celda() Then
            dgwConstruciones2.Rows.Add()
            dgwConstruciones2.CurrentCell = dgwConstruciones2.Rows(dgwConstruciones2.Rows.Count - 1).Cells(0)
            dgwConstruciones2.Rows(valorfila_agregado).Cells("piso2").Value = valorfila_agregado + 1
            valorfila_agregado = valorfila_agregado + 1
            totu = dgwConstruciones2.Rows().Count
            If totu = 0 Then
                valorfila = totu
            Else
                valorfila = totu - 1
            End If
        Else
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mrd As Integer
        mrd = dgwConstruciones2.Rows.Count - 1
        Me.dgwConstruciones2.Rows.Remove(Me.dgwConstruciones2.Rows(mrd))
        valorfila_agregado = valorfila_agregado - 1
    End Sub

    Private Function verificacion_celda() As Boolean
        Dim valorRetornado As Boolean
        ' Recorremos las filas
        For Each row As DataGridViewRow In dgwConstruciones2.Rows

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
                    dgwConstruciones2.CurrentCell = dgwConstruciones2.Rows(rowIndex).Cells(columnIndex)

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

End Class
