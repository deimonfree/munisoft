Public Class uc_rentas_reporte_hr
    Dim IdContibuyente As Integer
    Dim valor_IdDireccion As Integer
    Dim codContribuyente As Integer
    Dim valor_predio As Integer
    Private Sub btnShared_Click(sender As Object, e As EventArgs) Handles btnShared.Click
        'lblInfo.Text = "Actualizando Contribuyente"
        Dim formulario2 As New d_rentas_contribuyente_update
        Dim datoRecuperado As DialogResult
        Dim estado As Integer
        Dim cod_autovaluo As String
        estado = 0
        datoRecuperado = formulario2.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
            Try
                limpiarCampos()
                IdContibuyente = formulario2.valor_contribuyente
                txtCodigo.Text = IdContibuyente
                llamada_contribuyente(formulario2.valor_contribuyente)
                llamada_direccion_contribuyente(valor_IdDireccion)
                _DatasetAutovaluo3.Reset()
                consulta_datos_contribuyente_anio(IdContibuyente, cbxperiodo.Text)
                For Each row In _DatasetAutovaluo3.Tables(0).Rows
                    cod_autovaluo = row("idautovaluo")
                Next
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub limpiarCampos()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtIdentificacion.Text = ""
        txtDireccion.Text = ""
        crvPu.Refresh()
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

    Private Sub uc_rentas_reportes_pu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetAnnio.Reset()
        consulta_datos_annio()
        cbxperiodo.DataSource = _DatasetAnnio.Tables("annio")
        cbxperiodo.DisplayMember = "anno"
        cbxperiodo.ValueMember = "idanno"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rep As New report_rentas_resumen_hr
        Dim codigo As String
        Dim annio As String
        pbLoad.Visible = True
        pbnombre.Visible = False
        pbChek.Visible = False
        pbFail.Visible = False
        lblInfoReporte.Text = "Se esta generando su reporte espere ..."
        Try
            codigo = txtCodigo.Text
            annio = cbxperiodo.SelectedValue
            rep.Refresh()
            crvPu.Refresh()
            rep.SetParameterValue("cod", codigo)
            rep.SetParameterValue("annio", annio)
            crvPu.ReportSource = rep
            pbLoad.Visible = False
            pbChek.Visible = True
            lblInfoReporte.Text = "Reporte generado exitosamente"
        Catch ex As Exception
            pbLoad.Visible = False
            pbFail.Visible = True
            lblInfoReporte.Text = "Error en la generación de reporte"
            pbnombre.Visible = True
        End Try
    End Sub

End Class
