Public Class uc_rentas_zona
    Dim idZona As Integer
    Dim estado_button_update As Integer = 0
    Dim controller As New class_controller_zona
    Dim datos As New class_datos_zonaa
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If alta() = True Then
            MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 001",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            datos.id_zona = txtCodigo_zona.Text
            datos.nombre_zona = txtNom_zona.Text
            If controller.insertarDatosZona(datos) Then
                MessageBox.Show("datos guarados")
                lblInfoFicha.Text = "uds. acaba de crear una zona con los siguientes datos:"
                clean()
            Else
                MessageBox.Show("datos no guarados")

            End If
        End If



    End Sub

    Private Sub clean()
        txtCodigo_zona.Text = ""
        txtNom_zona.Text = ""
        txtCodigo_zona.Select()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If estado_button_update = 1 Then
            Dim controlador As New class_controller_zona
            Dim datos As New class_datos_zonaa
            If alta() = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                datos.id_zona = txtCodigo_zona.Text
                datos.nombre_zona = txtNom_zona.Text
                If controlador.actualizarDatosZona(datos) Then
                    MessageBox.Show("datos guardados")
                    _DatasetZona.Reset()
                    clean()
                Else
                    MessageBox.Show("datos no guardados")
                End If
            End If

            estado_button_update = 2
        End If
        If estado_button_update = 0 Then
            lblInfo.Text = "Actualizando Zona"
            Dim formulario As New d_rentas_busqueda_zona
            Dim datoRecuperado As DialogResult
            datoRecuperado = formulario.ShowDialog()
            If datoRecuperado = DialogResult.OK Then
                lblInfoFicha.Text = "Esta actualizando los datos de:"
                idZona = formulario.valor_zona
                llamada_zona(formulario.valor_zona)
                estado_button_update = 1
            End If
        Else

        End If
        If estado_button_update = 2 Then
            estado_button_update = 0
        End If
    End Sub
    Private Sub llamada_zona(valor As Integer)
        Dim datos_zona As New class_datos_zona
        cargar_datos_zona(valor, datos_zona)
        txtCodigo_zona.Text = datos_zona.id_zona
        txtNom_zona.Text = datos_zona.nombre_zona
        lblCodigoFicha.Visible = True
        lblCodigoFicha.Text = datos_zona.id_zona
        lblNomZonaFicha.Visible = True
        lblNomZonaFicha.Text = datos_zona.nombre_zona
    End Sub

    Private Function alta() As Boolean
        Dim valor_alta As Boolean = False
        pbCod.Visible = False
        pbNombre.Visible = False
        Select Case ""
            Case Trim(txtCodigo_zona.Text)
                valor_alta = True
                pbCod.Visible = True
            Case Trim(txtNom_zona.Text)
                valor_alta = True
                pbNombre.Visible = True
        End Select
        Return valor_alta
    End Function
End Class
