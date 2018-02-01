Public NotInheritable Class ab_ciudadano_nuevo
    Dim Codprov As String
    Dim CodDep As String
    Dim CodDist As String
    Private Sub ab_ciudadano_nuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub rb_a1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_a1.CheckedChanged
        txt_tipo.Text = 1
    End Sub

    Private Sub rb_a2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_a2.CheckedChanged
        txt_tipo.Text = 2
    End Sub

    Private Sub rb_a3_CheckedChanged(sender As Object, e As EventArgs) Handles rb_a3.CheckedChanged
        txt_tipo.Text = 3
    End Sub

    Private Sub rb_a4_CheckedChanged(sender As Object, e As EventArgs) Handles rb_a4.CheckedChanged
        txt_tipo.Text = 4
    End Sub

    Private Sub rb_b1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_b1.CheckedChanged
        txt_nacionalidad.Text = 1

    End Sub

    Private Sub rb_b2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_b2.CheckedChanged
        txt_nacionalidad.Text = 2
    End Sub

    Private Sub txtCodUbiDep_TextChanged(sender As Object, e As EventArgs) Handles txtCodUbiDep.TextChanged
        Dim datos As New class_datos_ubigeoDepartamento
        CodDep = txtCodUbiDep.Text
        _dtsbox.Reset()
        consulta_codigo_ubigeoDep(datos, CodDep)
        txtDep.Text = datos.nombre_ubigeoDepartamento
        'valor = txtCodUbiDep.Text
        'If valor = "10" Then
        '    txtDep.Text = "tonto"
        'Else
        '    txtDep.Text = "no tonto"
        'End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub OKButton_Click_1(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim conexion As New class_controller_ciudadano
        Dim datos As New class_datos_zonas
        datos.nombre_ciudadano = txtNombre.Text
        datos.apePat_ciudadano = txtApePat.Text
        datos.apeMat_ciudadano = txtApeMat.Text
        datos.tipoDoc_ciudadano = txt_tipo.Text
        datos.dni_ciudadano = txtNumero.Text
        datos.nacionalidad_ciudadano = txt_nacionalidad.Text
        datos.estadoCivil_ciudadano = txtEstado.Text
        datos.fechaNac_ciudadano = dtpNacimiento.Text
        datos.centroPobla_ciudadano = txtCodUbiPue.Text
        datos.distrito_ciudadano = txtCodUbiDis.Text
        If conexion.insertarDatosCiudadano(datos) Then
            MessageBox.Show("Datos Guardados")
            Me.Close()
        Else
            MessageBox.Show("Datos no Guardados")
        End If
    End Sub

    Private Sub txtCodUbiPro_TextChanged(sender As Object, e As EventArgs) Handles txtCodUbiPro.TextChanged
        Dim datos As New class_datos_ubigeoProvincia
        Codprov = txtCodUbiPro.Text
        CodDep = txtCodUbiDep.Text
        _dtsbox2.Reset()
        consulta_codigo_ubigeoProv(datos, CodProv, CodDep)
        txtPro.Text = datos.nombre_ubigeoProvincia
    End Sub

    Private Sub txtCodUbiDis_TextChanged(sender As Object, e As EventArgs) Handles txtCodUbiDis.TextChanged
        Dim datos As New class_datos_ubigeoDistrito
        Codprov = txtCodUbiPro.Text
        CodDist = txtCodUbiDis.Text
        _dtsbox3.Reset()
        consulta_codigo_ubigeoDist(datos, CodDist, Codprov)
        txtDist.Text = datos.nombre_ubigeoDistrito
    End Sub
End Class
