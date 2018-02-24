Public Class uc_rentas_exonerar_moras
    Dim IdContibuyente As Integer
    Dim valor_IdDireccion As Integer
    Dim codContribuyente As Integer
    Dim valor_predio As Integer
    Dim cod_autovaluo As String
    Dim indice_tabla As New Integer
    Private Sub uc_rentas_autovaluo_canjear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetAnnio.Reset()
        consulta_datos_annio()
        cbxperiodo.DataSource = _DatasetAnnio.Tables("annio")
        cbxperiodo.DisplayMember = "anno"
        cbxperiodo.ValueMember = "idanno"
    End Sub

    Private Sub btnShared_Click(sender As Object, e As EventArgs) Handles btnShared.Click
        persona()
    End Sub

    Sub persona()
        'lblInfo.Text = "Actualizando Contribuyente"
        Dim formulario2 As New d_rentas_contribuyente_update
        Dim datoRecuperado As DialogResult
        Dim suma_deuda As New Decimal
        Dim suma_total As New Decimal
        Dim estado As New Integer
        Dim suma_auto As New Decimal
        estado = 0
        suma_deuda = 0.00
        suma_total = 0.00
        suma_auto = 0.00
        cod_autovaluo = "0"
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            Try
                limpiarDatos()
                IdContibuyente = formulario2.valor_contribuyente
                txtCodigo.Text = IdContibuyente
                llamada_contribuyente(formulario2.valor_contribuyente)
                llamada_direccion_contribuyente(valor_IdDireccion)
                _DatasetAutovaluo3.Reset()
                consulta_datos_contribuyente_anio(IdContibuyente, cbxperiodo.Text)
                For Each row In _DatasetAutovaluo3.Tables(0).Rows
                    cod_autovaluo = row("idautovaluo")
                Next
                'MessageBox.Show("Cod autovaluo : " + cod_autovaluo.ToString)
                If cod_autovaluo = "0" Then
                    MessageBox.Show("El usuario no cuenta con autovaluo")
                End If
                _DatasetRecibo.Reset()
                consulta_recibo_canje(cod_autovaluo)
                dgwPredio.DataSource = _dtwRecibo
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub limpiarCampos()
        Try
            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtIdentificacion.Text = ""
            txtDireccion.Text = ""
            dgwPredio.DataSource = vbEmpty
        Catch ex As Exception
        End Try
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
    Sub limpiarDatos()
        txtCobrar.Text = ""
        txtCodRecibo.Text = ""
        txtCautovaluo.Text = ""
        txtFeVenc.Text = ""
        txtautom.Text = ""
        txtForma.Text = ""
        txtEstado.Text = ""
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtIdentificacion.Text = ""
        txtDireccion.Text = ""
        dgwPredio.DataSource = vbEmpty
    End Sub

    Private Sub txtIdRecibo_TextChanged(sender As Object, e As EventArgs) Handles txtIdRecibo.TextChanged
        Try
            Dim cod_recibo As Integer
            Dim id_contrib As String
            Dim suma_deuda As Decimal
            Dim suma_total As Decimal
            Dim suma_auto As Decimal
            id_contrib = ""
            limpiarDatos()
            'limpiarEncabezado(())
            cod_autovaluo = Integer.Parse(txtIdRecibo.Text)
            _DatasetRecibo.Reset()
            consulta_recibo_canje(cod_autovaluo)
            dgwPredio.DataSource = _dtwRecibo

            _DatasetRecibo2.Reset()
            consulta_recibo_contribuyente(cod_recibo.ToString)
            For Each row In _DatasetRecibo2.Tables(0).Rows
                id_contrib = row("cod_cont")
                cod_autovaluo = row("idautovaluo")
                suma_total = suma_total + row("monto_recibo")
                suma_auto = suma_auto + row("automatizacion")
                If row("estado") = "pendiente" Then
                    suma_deuda = suma_deuda + row("monto_recibo")
                End If
            Next
            llamada_contribuyente(id_contrib)
            llamada_direccion_contribuyente(valor_IdDireccion)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgwPredio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwPredio.CellClick
        Try
            Dim campania As New Integer
            Dim moras As New Integer
            'MessageBox.Show("Recibo seleccionado...")
            indice_tabla = -1
            indice_tabla = dgwPredio.CurrentRow.Index
            txtCodRecibo.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(0).Value
            txtForma.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(1).Value
            txtCobrar.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(2).Value
            txtFeVenc.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(3).Value
            txtEstado.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(5).Value
            txtautom.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(6).Value
            txtCautovaluo.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(7).Value
            campania = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(9).Value
            moras = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(10).Value
            If campania = -1 Then
                cbCampanias.Checked = True
            Else
                cbCampanias.Checked = False
            End If
            If moras = -1 Then
                cbExonerar.Checked = False
            Else
                cbExonerar.Checked = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim datos As New class_datos_recibo
        Dim control As New class_controller_recibo
        datos.id_recibo = txtCodRecibo.Text

        If cbCampanias.Checked Then
            datos.estado_campania = 1
        Else
            datos.estado_campania = 0
        End If
        If cbExonerar.Checked Then
            datos.estado_moras = 0
        Else
            datos.estado_moras = 1
        End If
        If control.actualizarDatosRecibo2(datos) Then
            MessageBox.Show("Actualización correcta.", "Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizar_tabla()
        Else
            MessageBox.Show("No se pudo actualizar.", "Recibos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub actualizar_tabla()
        _DatasetRecibo.Reset()
        consulta_recibo_canje(cod_autovaluo)
        dgwPredio.DataSource = _dtwRecibo
    End Sub
End Class
