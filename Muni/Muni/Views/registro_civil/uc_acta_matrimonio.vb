Public Class uc_acta_matrimonio
    Dim Codprov As String
    Dim CodDep As String
    Dim CodDist As String
    Private Sub btn_archivo_Click(sender As Object, e As EventArgs) Handles btn_archivo.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim NOMBRE As String = OpenFileDialog1.FileName
            NOMBRE = NOMBRE.Remove(0, NOMBRE.LastIndexOf("\"))
            txtArchivoDigital.Text = NOMBRE
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SaveFileDialog1.FileName = "puk.pdf"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, SaveFileDialog1.FileName)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub rb_a1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_a1.CheckedChanged
        txtTipoDon.Text = 1
    End Sub

    Private Sub rb_a2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_a2.CheckedChanged
        txtTipoDon.Text = 2
    End Sub

    Private Sub rb_a3_CheckedChanged(sender As Object, e As EventArgs) Handles rb_a3.CheckedChanged
        txtTipoDon.Text = 3
    End Sub

    Private Sub rb_a4_CheckedChanged(sender As Object, e As EventArgs) Handles rb_a4.CheckedChanged
        txtTipoDon.Text = 4
    End Sub

    Private Sub rb_b1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_b1.CheckedChanged
        txtNacionalidadDon.Text = 1
    End Sub

    Private Sub rb_b2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_b2.CheckedChanged
        txtNacionalidadDon.Text = 2
    End Sub

    Private Sub txtCodUbiDep1_TextChanged(sender As Object, e As EventArgs) Handles txtCodUbiDep1.TextChanged
        Dim datos As New class_datos_ubigeoDepartamento
        CodDep = txtCodUbiDep1.Text
        _dtsbox.Reset()
        consulta_codigo_ubigeoDep(datos, CodDep)
        txtDep1.Text = datos.nombre_ubigeoDepartamento
    End Sub

    Private Sub txtCodUbiProv1_TextChanged(sender As Object, e As EventArgs) Handles txtCodUbiProv1.TextChanged
        Dim datos As New class_datos_ubigeoProvincia
        Codprov = txtCodUbiProv1.Text
        CodDep = txtCodUbiDep1.Text
        _dtsbox2.Reset()
        consulta_codigo_ubigeoProv(datos, CodProv, CodDep)
        txtProv1.Text = datos.nombre_ubigeoProvincia
    End Sub

    Private Sub txtCodUbiDist1_TextChanged(sender As Object, e As EventArgs) Handles txtCodUbiDist1.TextChanged
        Dim datos As New class_datos_ubigeoDistrito
        Codprov = txtCodUbiProv1.Text
        CodDist = txtCodUbiDist1.Text
        _dtsbox3.Reset()
        consulta_codigo_ubigeoDist(datos, CodDist, Codprov)
        txtDist1.Text = datos.nombre_ubigeoDistrito
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim formulario As New ab_dni_share
        Dim datoRecuperado As DialogResult
        datoRecuperado = formulario.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
        Else
            txtDniRegistrador.Text = formulario.dni
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim datosUbigeoDist As New class_datos_ubigeoDistrito
        Dim datosUbigeoProv As New class_datos_ubigeoDistrito
        Dim datosUbigeoDep As New class_datos_ubigeoDistrito
        Dim datos As New class_datos_zonas
        Dim formulario As New ab_dni_share
        Dim datoRecuperado As DialogResult
        Dim dni As String
        Dim annoactual As Integer
        Dim mesactual As Integer
        Dim edad, edadMes As Integer
        datoRecuperado = formulario.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
        Else
            dni = formulario.dni
            _dtsbox2.Reset()
            consulta_show_ciudadano(datos, dni)
            txtNomDon.Text = datos.nombre_ciudadano
            txtApePatDon.Text = datos.apePat_ciudadano
            txtApeMatDon.Text = datos.apeMat_ciudadano
            txtTipoDon.Text = datos.tipoDoc_ciudadano
            txtNumeroDon.Text = datos.dni_ciudadano
            If datos.nacionalidad_ciudadano = 1 Then
                txtNacionalidadDon.Text = datos.nacionalidad_ciudadano
                txtNacionomDon.Text = "Peruana"
            Else
                txtNacionalidadDon.Text = datos.nacionalidad_ciudadano
                txtNacionomDon.Text = "Extrangera"
            End If
            txtEstadocivilDon.Text = datos.estadoCivil_ciudadano
            edad = Year(datos.fechaNac_ciudadano)
            edadMes = Month(datos.fechaNac_ciudadano)
            annoactual = Year(DateTime.Now.ToString)
            mesactual = Month(DateTime.Now.ToString)

            If (edadMes - mesactual) <= 0 Then
                txtEdadDon.Text = Str(annoactual - edad)
            Else
                txtEdadDon.Text = Str((annoactual - edad) - 1)
            End If
            txtPoDon.Text = datos.centroPobla_ciudadano
            'hallando distrito
            CodDist = datos.distrito_ciudadano
            _dtsubigeoDist.Reset()
            consulta_codigo_ubigeoDist_retro(datosUbigeoDist, CodDist)
            txtDistDon.Text = datosUbigeoDist.nombre_ubigeoDistrito
            txtCodUbiDistDon.Text = datos.distrito_ciudadano
            'hallando provincia
            Codprov = datosUbigeoDist.codPro_ubigeoDistrito

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim datos As New class_datos_registrador
        Dim formulario As New ab_dni_share
        Dim datoRecuperado As DialogResult
        Dim dni As String
        datoRecuperado = formulario.ShowDialog()
        If datoRecuperado = DialogResult.OK Then
        Else
            dni = formulario.dni
            _dtsregistrador.Reset()
            consulta_show_resgistrador(datos, dni)
            txtNomRegistrador.Text = datos.nombre_registrador
            txtApePatRegistrador.Text = datos.apePaterno_registrador
            txtApeMatRegistrador.Text = datos.apeMaterno_registrador
            txtDniRegistrador.Text = datos.dni_registrador

        End If
    End Sub
End Class
