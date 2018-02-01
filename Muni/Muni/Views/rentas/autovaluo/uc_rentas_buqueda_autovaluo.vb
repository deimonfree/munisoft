Public Class uc_rentas_buqueda_autovaluo
    Dim IdContibuyente As Integer
    Dim valor_IdDireccion As Integer
    Dim codContribuyente As Integer
    Dim valor_predio As Integer
    Private Sub btnShared_Click(sender As Object, e As EventArgs) Handles btnShared.Click
        'lblInfo.Text = "Actualizando Contribuyente"
        Dim formulario2 As New d_rentas_contribuyente_update
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            IdContibuyente = formulario2.valor_contribuyente
            txtCodigo.Text = IdContibuyente
            llamada_contribuyente(formulario2.valor_contribuyente)
            llamada_direccion_contribuyente(valor_IdDireccion)
            _DatasetPredio.Reset()
            consulta_datos_predio_autovaluo(IdContibuyente)
            dgwPredio.DataSource = _dtwPredio
        End If
    End Sub
    Private Sub llamada_contribuyente(valor As Integer)
        Dim datos_contribuyente As New class_datos_contribuyente
        cargar_datos_contribuyente(valor, datos_contribuyente)
        codContribuyente = datos_contribuyente.id_contribuyente
        txtCodigo.Text = datos_contribuyente.id_contribuyente
        txtNombre.Text = LCase(datos_contribuyente.nombres_cont) + " " + UCase(datos_contribuyente.apellido_paterno_cont) + " " + UCase(datos_contribuyente.apellido_materno_cont)
        txtIdentificacion.Text = datos_contribuyente.numero_doc_cont
        valor_IdDireccion = datos_contribuyente.id_contribuyente
    End Sub
    Private Sub llamada_direccion_contribuyente(valor As Integer)
        Dim datos_direccion_contribuyente As New class_datos_direccion
        cargar_datos_direcContribuyente(valor, datos_direccion_contribuyente)
        txtDireccion.Text = datos_direccion_contribuyente.via_direccion
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        '_DatasetPredio.Reset()
        'consulta_datos_predio_autovaluo(IdContibuyente)
        'dgwPredio.DataSource = _dtwPredio
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


    End Sub
    Private Sub dgwPredio_Click(sender As Object, e As EventArgs) Handles dgwPredio.Click
        Try

            valor_predio = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(0).Value
            txtDireccion.Text = valor_predio
            _DatasetFicha.Reset()
            _DatasetAutovaluo.Reset()
            ficha_ByPredio(valor_predio)
            For Each row In _DatasetDistrito.Tables(0).Rows
                consulta_datos_Autovaluo_anio(row("idficha"))
                dgwAutovaluo.DataSource = _dtwAutovaluo
            Next
            Dim cantRegistros As Integer = dgwAutovaluo.Rows.Count
            If cantRegistros > 0 Then
                Dim totalAutovalup As Double = 0
                ' Iterate through all the rows and sum up the appropriate columns.
                For counter = 0 To (dgwAutovaluo.Rows.Count - 1)
                    If Not dgwAutovaluo.Rows(counter).Cells(1).Value Is Nothing Then
                        If Not dgwAutovaluo.Rows(counter).Cells(1).Value.ToString().Length = 0 Then

                            totalAutovalup += Double.Parse(dgwAutovaluo.Rows(counter).Cells(1).Value.ToString())
                        End If
                    End If
                Next
                ' Set the labels to reflect the current state of the DataGridView.
                txtTotalAutovaluo.Text = totalAutovalup.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgwAutovaluo_Click(sender As Object, e As EventArgs) Handles dgwAutovaluo.Click
        Try

            txtCodAutovaluo.Text = dgwAutovaluo.Rows(dgwAutovaluo.CurrentRow.Index).Cells(0).Value
            txtValorAutovaluo.Text = dgwAutovaluo.Rows(dgwAutovaluo.CurrentRow.Index).Cells(1).Value
            txtAnnioAutovaluo.Text = dgwAutovaluo.Rows(dgwAutovaluo.CurrentRow.Index).Cells(2).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class
