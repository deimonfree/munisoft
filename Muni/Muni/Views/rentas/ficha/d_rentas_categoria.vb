Imports System.Windows.Forms

Public Class d_rentas_categoria
    Public valor_categoria As String
    Dim murosycolumnas As DataTable

    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If alta() Then
            valor_categoria = txtCod_murosColumnas.Text & txtCod_techos.Text & txtCod_pisos.Text & txtCod_puertasVentanas.Text & txtCod_revestimiento.Text & txtCod_banos.Text & txtCod_elecSanitarias.Text
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Else
            MessageBox.Show("Uds no ha seleccionado ninguna categoria ó falta completar las categorias")
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgwMurosColumnas_Click(sender As Object, e As EventArgs) Handles dgwMurosColumnas.Click
        Try
            txtCod_murosColumnas.Text = UCase(dgwMurosColumnas.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(0).Value)
            txtnom_murosColumnas.Text = dgwMurosColumnas.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(1).Value

        Catch ex As Exception

        End Try

    End Sub
    Private Sub dgwTechos_Click(sender As Object, e As EventArgs) Handles dgwTechos.Click
        Try
            txtCod_techos.Text = UCase(dgwTechos.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(0).Value)
            txtNom_techos.Text = dgwTechos.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(1).Value

        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgwPisos_Click(sender As Object, e As EventArgs) Handles dgwPisos.Click
        Try
            txtCod_pisos.Text = UCase(dgwPisos.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(0).Value)
            txtNom_pisos.Text = dgwPisos.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgwPuertasVentanas_Click(sender As Object, e As EventArgs) Handles dgwPuertasVentanas.Click
        Try
            txtCod_puertasVentanas.Text = UCase(dgwPuertasVentanas.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(0).Value)
            txtNom_puertasVentanas.Text = dgwPuertasVentanas.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgwRevestimiento_Click(sender As Object, e As EventArgs) Handles dgwRevestimiento.Click
        Try
            txtCod_revestimiento.Text = UCase(dgwRevestimiento.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(0).Value)
            txtNom_revestimiento.Text = dgwRevestimiento.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgwBanos_Click(sender As Object, e As EventArgs) Handles dgwBanos.Click
        Try
            txtCod_banos.Text = UCase(dgwBanos.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(0).Value)
            txtNom_banos.Text = dgwBanos.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgwElectricidadSanitarias_Click(sender As Object, e As EventArgs) Handles dgwElectricidadSanitarias.Click
        Try
            txtCod_elecSanitarias.Text = UCase(dgwElectricidadSanitarias.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(0).Value)
            txtNom_elecSanitarias.Text = dgwElectricidadSanitarias.Rows(dgwMurosColumnas.CurrentRow.Index).Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        dgwMurosColumnas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        _DatasetValores.Reset()
        valores_muroColumnas_all()
        dgwMurosColumnas.DataSource = _dtwValores

    End Sub
    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        dgwTechos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        _DatasetValores.Reset()
        valores_techos_all()
        dgwTechos.DataSource = _dtwValores

    End Sub
    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        dgwPisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        _DatasetValores.Reset()
        valores_pisos_all()
        dgwPisos.DataSource = _dtwValores
    End Sub

    Private Sub TabPage4_Enter(sender As Object, e As EventArgs) Handles TabPage4.Enter
        dgwPuertasVentanas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        _DatasetValores.Reset()
        valores_puertasVentanas_all()
        dgwPuertasVentanas.DataSource = _dtwValores
    End Sub

    Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter
        dgwRevestimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        _DatasetValores.Reset()
        valores_revistimiento_all()
        dgwRevestimiento.DataSource = _dtwValores
    End Sub

    Private Sub TabPage6_Enter(sender As Object, e As EventArgs) Handles TabPage6.Enter
        dgwBanos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        _DatasetValores.Reset()
        valores_banos_all()
        dgwBanos.DataSource = _dtwValores
    End Sub

    Private Sub TabPage7_Enter(sender As Object, e As EventArgs) Handles TabPage7.Enter
        dgwElectricidadSanitarias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        _DatasetValores.Reset()
        valores_electricasSanitarias_all()
        dgwElectricidadSanitarias.DataSource = _dtwValores
    End Sub

    Private Sub txtCod_murosColumnas_TextChanged(sender As Object, e As EventArgs) Handles txtCod_murosColumnas.TextChanged
        valor_categoria = valor_categoria & txtCod_murosColumnas.Text
        lblv1.Text = txtCod_murosColumnas.Text
        txtnom_murosColumnas.Text = cargar_datos_MC(lblv1.Text)
    End Sub

    Private Sub txtCod_techos_TextChanged(sender As Object, e As EventArgs) Handles txtCod_techos.TextChanged
        valor_categoria = valor_categoria & txtCod_techos.Text
        lblv2.Text = txtCod_techos.Text
        txtNom_techos.Text = cargar_datos_TE(lblv2.Text)
    End Sub

    Private Sub txtCod_pisos_TextChanged(sender As Object, e As EventArgs) Handles txtCod_pisos.TextChanged
        valor_categoria = valor_categoria & txtCod_pisos.Text
        lblv3.Text = txtCod_pisos.Text
        txtNom_pisos.Text = cargar_datos_PI(lblv3.Text)
    End Sub

    Private Sub txtCod_puertasVentanas_TextChanged(sender As Object, e As EventArgs) Handles txtCod_puertasVentanas.TextChanged
        valor_categoria = valor_categoria & txtCod_puertasVentanas.Text
        lblv4.Text = txtCod_puertasVentanas.Text
        txtNom_puertasVentanas.Text = cargar_datos_PV(lblv4.Text)
    End Sub

    Private Sub txtCod_revestimiento_TextChanged(sender As Object, e As EventArgs) Handles txtCod_revestimiento.TextChanged
        valor_categoria = valor_categoria & txtCod_revestimiento.Text
        lblv5.Text = txtCod_revestimiento.Text
        txtNom_revestimiento.Text = cargar_datos_RE(lblv5.Text)
    End Sub

    Private Sub txtCod_banos_TextChanged(sender As Object, e As EventArgs) Handles txtCod_banos.TextChanged
        valor_categoria = valor_categoria & txtCod_banos.Text
        lblv6.Text = txtCod_banos.Text
        txtNom_banos.Text = cargar_datos_BA(lblv6.Text)
    End Sub

    Private Sub txtCod_elecSanitarias_TextChanged(sender As Object, e As EventArgs) Handles txtCod_elecSanitarias.TextChanged
        valor_categoria = valor_categoria & txtCod_elecSanitarias.Text
        lblv7.Text = txtCod_elecSanitarias.Text
        txtNom_elecSanitarias.Text = cargar_datos_IE(lblv7.Text)
    End Sub

    Private Function alta() As Boolean
        Dim valor_alta As Boolean = True
        If Trim(lblv1.Text) = "-" Then
            valor_alta = False
        End If
        If Trim(lblv2.Text) = "-" Then
            valor_alta = False
        End If
        If Trim(lblv3.Text) = "-" Then
            valor_alta = False
        End If
        If Trim(lblv4.Text) = "-" Then
            valor_alta = False
        End If
        If Trim(lblv5.Text) = "-" Then
            valor_alta = False
        End If
        If Trim(lblv6.Text) = "-" Then
            valor_alta = False
        End If
        If Trim(lblv7.Text) = "-" Then
            valor_alta = False
        End If
        Return valor_alta
    End Function
    Sub calculo_categoria()
        'leendo caracteres
        Dim recorrido As Integer = 1
        Dim cadena As String
        cadena = txtPalabraClave.Text

        If cadena.Length = 7 Then
            For i As Integer = 0 To cadena.Length
                If recorrido = 1 Then
                    txtCod_murosColumnas.Text = cadena.Substring(i, 1)
                Else
                    If recorrido = 2 Then
                        txtCod_techos.Text = cadena.Substring(i, 1)
                    Else
                        If recorrido = 3 Then
                            txtCod_pisos.Text = cadena.Substring(i, 1)
                        Else
                            If recorrido = 4 Then
                                txtCod_puertasVentanas.Text = cadena.Substring(i, 1)
                            Else
                                If recorrido = 5 Then
                                    txtCod_revestimiento.Text = cadena.Substring(i, 1)
                                Else
                                    If recorrido = 6 Then
                                        txtCod_banos.Text = cadena.Substring(i, 1)
                                    Else
                                        If recorrido = 7 Then
                                            txtCod_elecSanitarias.Text = cadena.Substring(i, 1)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If

                End If
                recorrido = recorrido + 1
            Next
        Else
            MessageBox.Show("no hay datos")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        calculo_categoria()
    End Sub

    Private Sub txtPalabraClave_TextChanged(sender As Object, e As EventArgs) Handles txtPalabraClave.TextChanged
        txtPalabraClave.Text = UCase(txtPalabraClave.Text)
    End Sub

End Class
