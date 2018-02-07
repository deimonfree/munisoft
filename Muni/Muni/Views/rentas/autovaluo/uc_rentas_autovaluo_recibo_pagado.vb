Public Class uc_rentas_autovaluo_recibo_pagado
    Dim IdContibuyente As Integer
    Dim valor_IdDireccion As Integer
    Dim codContribuyente As Integer
    Private Sub uc_rentas_autovaluo_recibo_pagado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetRecibo.Reset()
        consulta_recibo_all()
        dgwPredio.DataSource = _dtwRecibo
        _DatasetAnnio.Reset()
        consulta_datos_annio()
        cbxperiodo.DataSource = _DatasetAnnio.Tables("annio")
        cbxperiodo.DisplayMember = "anno"
        cbxperiodo.ValueMember = "idanno"
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        Dim fecha As String
        fecha = dtpFecha.Value.ToShortDateString
        cbHoy.Checked = False
        cbTodos.Checked = False
        'MsgBox(fecha)
        _DatasetRecibo.Reset()
        consulta_recibo_like(fecha)
        dgwPredio.DataSource = _dtwRecibo
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles cbTodos.CheckedChanged
        If cbTodos.Checked = True Then
            cbHoy.Checked = False
            _DatasetRecibo.Reset()
            consulta_recibo_all()
            dgwPredio.DataSource = _dtwRecibo
        End If
    End Sub

    Private Sub cbHoy_CheckedChanged(sender As Object, e As EventArgs) Handles cbHoy.CheckedChanged
        Dim fecha As String
        If cbHoy.Checked = True Then
            cbTodos.Checked = False
            fecha = Date.Now.Date
            'MsgBox(fecha)
            _DatasetRecibo.Reset()
            consulta_recibo_like(fecha)
            dgwPredio.DataSource = _dtwRecibo
        End If
    End Sub

    Private Sub dgwPredio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwPredio.CellClick
        Dim cod_autovaluo As String
        Try
            txtCodRecibo.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(0).Value
            txtForma.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(1).Value
            txtCobrar.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(2).Value
            txtFeVenc.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(3).Value
            txtEstado.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(4).Value
            txtCautovaluo.Text = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(7).Value
            cod_autovaluo = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(7).Value
            Dim id_contrib As String
            id_contrib = ""
            _DatasetRecibo2.Reset()
            consulta_recibo_contribuyente(cod_autovaluo)
            For Each row In _DatasetRecibo2.Tables(0).Rows
                id_contrib = row("cod_cont")
            Next
            persona(id_contrib)
        Catch ex As Exception
        End Try
    End Sub
    Sub persona(ByVal cod_contribuyente As String)
        Try
            llamada_contribuyente(cod_contribuyente)
            llamada_direccion_contribuyente(valor_IdDireccion)
        Catch ex As Exception
            MsgBox(ex.Message)
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
        txtForma.Text = ""
        txtEstado.Text = ""
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtIdentificacion.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub btnShared_Click(sender As Object, e As EventArgs) Handles btnShared.Click
        Dim formulario2 As New d_rentas_contribuyente_update
        Dim datoRecuperado As DialogResult
        Dim cod_autovaluo As String
        cod_autovaluo = "0"
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            Try
                limpiarDatos()
                cbHoy.Checked = False
                cbTodos.Checked = False
                IdContibuyente = formulario2.valor_contribuyente
                txtCodigo.Text = IdContibuyente
            Catch ex As Exception
            End Try
        End If
        _DatasetAutovaluo3.Reset()
        consulta_datos_contribuyente_anio(IdContibuyente, cbxperiodo.Text)
        For Each row In _DatasetAutovaluo3.Tables(0).Rows
            cod_autovaluo = row("idautovaluo")
            'MsgBox(cod_autovaluo)
        Next
        _DatasetRecibo.Reset()
        consulta_recibo_canje(cod_autovaluo)
        dgwPredio.DataSource = _dtwRecibo
        persona(IdContibuyente)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub pbnombre_Click(sender As Object, e As EventArgs) Handles pbnombre.Click

    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub txtIdentificacion_TextChanged(sender As Object, e As EventArgs) Handles txtIdentificacion.TextChanged

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub cbxperiodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxperiodo.SelectedIndexChanged

    End Sub

    Private Sub dgwPredio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwPredio.CellContentClick

    End Sub

    Private Sub sidePanel_Paint(sender As Object, e As PaintEventArgs) Handles sidePanel.Paint

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class

