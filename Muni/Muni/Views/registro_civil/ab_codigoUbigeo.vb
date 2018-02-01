Public NotInheritable Class ab_codigoUbigeo
    Dim valorSave As String
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipo.SelectedIndexChanged
        Dim index As Integer
        index = cbxTipo.SelectedIndex
        Select Case index
            Case 0
                valorSave = "dist"
                lblInfo.Text = "Estas creando un Distrito"
                lblOption.Text = "Pertenece a la Provincia de:"
                txtCodDependencia.Enabled = True
            Case 1
                valorSave = "prov"
                lblInfo.Text = "Estas creando una Provincia"
                lblOption.Text = "Pertenece al Departamento de:"
                txtCodDependencia.Enabled = True
            Case 2
                valorSave = "depa"
                lblInfo.Text = "Estas creando un Departamento"
                lblOption.Text = "Sin opcion alguna:"
                txtCodDependencia.Enabled = False
        End Select

    End Sub


    Private Sub OKButton_Click_1(sender As Object, e As EventArgs) Handles OKButton.Click
        Select Case valorSave
            Case "dist"
                Dim conexion As New class_controller_codigoUbigeo
                Dim datos As New class_datos_ubigeoDistrito
                datos.id_ubigeoDistrito = txtCodigo.Text
                datos.nombre_ubigeoDistrito = txtNombre.Text
                datos.codPro_ubigeoDistrito = txtCodDependencia.Text
                If conexion.insertarDatosUbigeoDis(datos) Then
                    MessageBox.Show("Datos Guardados")
                    Me.Close()
                Else
                    MessageBox.Show("Datos no Guardados")
                    txtCodigo.Text = ""
                    txtNombre.Text = ""
                End If
            Case "prov"
                Dim conexion As New class_controller_codigoUbigeo
                Dim datos As New class_datos_ubigeoProvincia
                datos.id_ubigeoProvincia = txtCodigo.Text
                datos.nombre_ubigeoProvincia = txtNombre.Text
                datos.codDep_ubigeoProvincia = txtCodDependencia.Text
                If conexion.insertarDatosUbigeoPro(datos) Then
                    MessageBox.Show("Datos Guardados")
                    Me.Close()
                Else
                    MessageBox.Show("Datos no Guardados")
                    txtCodigo.Text = ""
                    txtNombre.Text = ""
                End If
            Case "depa"
                Dim conexion As New class_controller_codigoUbigeo
                Dim datos As New class_datos_ubigeoDepartamento
                datos.id_ubigeoDepartamento = txtCodigo.Text
                datos.nombre_ubigeoDepartamento = txtNombre.Text
                If conexion.insertarDatosUbigeoDep(datos) Then
                    MessageBox.Show("Datos Guardados")
                    Me.Close()
                Else
                    MessageBox.Show("Datos no Guardados")
                    txtCodigo.Text = ""
                    txtNombre.Text = ""
                End If
        End Select

    End Sub
End Class
