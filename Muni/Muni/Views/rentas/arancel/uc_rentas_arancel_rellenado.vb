Public Class uc_rentas_arancel_rellenado
    Dim totalCuadras As Integer
    Dim restCuadras As Integer
    Private Sub uc_rentas_arancel_rellenado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetLlenadoBox.Reset()
        llenado_combox.combox_all("anno")
        cbxAnno.DataSource = _DatasetLlenadoBox.Tables("anno")
        cbxAnno.DisplayMember = "anno"
        cbxAnno.ValueMember = "idanno"
        'llenado de sectores
        _DatasetSectorBox.Reset()
        combox_sector_all()
        cbxSector.DataSource = _DatasetSectorBox.Tables("sector")
        cbxSector.DisplayMember = "nombre"
        cbxSector.ValueMember = "idsector"
    End Sub


    Private Sub cbxSector_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxSector.SelectionChangeCommitted
        pbSector.Visible = False
        Dim dato As String
        dato = cbxSector.SelectedValue.ToString()
        _DatasetSector.Reset()
        sector_By(dato)
        dgwSector.DataSource = _dtwSector
    End Sub

    Private Sub btnlistarall_Click_1(sender As Object, e As EventArgs) Handles btnlistarall.Click
        Dim valor_via As Integer
        Dim valor_anno As Integer
        Try
            valor_via = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(0).Value
            valor_anno = cbxAnno.SelectedValue.ToString()
        Catch ex As Exception
            MessageBox.Show("Seleccione el Sector; del cual desea ver el listado de Vias ", "Error: 002",
               MessageBoxButtons.OK, MessageBoxIcon.Information)
            pbSector.Visible = True
        End Try

        If contarDatos_ValorArancelario(valor_via, valor_anno) <> 0 Then
            Dim valorVia As Integer
            Dim valorAnno As Integer
            Dim ultimaCuadra As Integer
            Dim totalCuadra As Integer
            valorVia = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(0).Value
            txtCodVia.Text = valorVia
            valorAnno = cbxAnno.SelectedValue.ToString()
            totalCuadra = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(3).Value
            txtTotalCua.Text = totalCuadra
            ultimaCuadra = ultimoDato_ValorArancelario(valorVia, valorAnno)
            pbarLlenado.Maximum = totalCuadra
            pbarLlenado.Minimum = 0
            pbarLlenado.Increment(1)
            If totalCuadra = ultimaCuadra Then
                lblInfoMess.Text = "Los datos de la Cuadra estan actualizados"
                pbmessage.Visible = True
                btnNext.Enabled = False
                txtResCua.Text = ultimaCuadra
                pbarLlenado.Value = ultimaCuadra
            Else
                restCuadras = ultimaCuadra + 1
                lblInfoMess.Text = ""
                pbmessage.Visible = False
                txtResCua.Text = ultimaCuadra + 1
                txtNomVia.Text = StrConv(dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(1).Value, VbStrConv.ProperCase) + " " + StrConv(dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(2).Value, VbStrConv.ProperCase)
                btnNext.Enabled = True
                totalCuadras = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(3).Value
                pbarLlenado.Value = ultimaCuadra
            End If

        Else

            Try
                lblInfoMess.Text = ""
                pbmessage.Visible = False
                txtCodVia.Text = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(0).Value
                txtNomVia.Text = StrConv(dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(1).Value, VbStrConv.ProperCase) + " " + StrConv(dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(2).Value, VbStrConv.ProperCase)
                txtTotalCua.Text = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(3).Value
                btnNext.Enabled = True
                totalCuadras = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(3).Value
                restCuadras = 1
                txtResCua.Text = restCuadras
                pbarLlenado.Value = 0

            Catch ex As Exception

            End Try
        End If
    End Sub



    Private Sub dgwSector_Click(sender As Object, e As EventArgs) Handles dgwSector.Click
        Try
            Dim v1 As Integer
            lblNomVia.Text = StrConv(dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(1).Value, VbStrConv.ProperCase) + " " + StrConv(dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(2).Value, VbStrConv.ProperCase)
            lblNumCuadras.Text = dgwSector.Rows(dgwSector.CurrentRow.Index).Cells(3).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If totalCuadras >= restCuadras Then
            txtResCua.Text = restCuadras
            pbarLlenado.Maximum = totalCuadras
            pbarLlenado.Minimum = 0
            Dim conexion_valoresArancelario As New class_controller_valorArancelario
            Dim datos_valoresarancelario As New class_datos_valorArancelario
            Dim alta As Boolean = False
            pbMonto.Visible = False
            Select Case ""
                Case Trim(txtMonto.Text)
                    alta = True
                    pbMonto.Visible = True
            End Select
            If alta = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 001",
               MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                datos_valoresarancelario.codVia_valorArancelario = txtCodVia.Text
                datos_valoresarancelario.codAnno_valorArancelario = cbxAnno.SelectedValue.ToString()
                datos_valoresarancelario.valor_valorArancelario = txtMonto.Text
                datos_valoresarancelario.cuadra_valorArancelario = txtResCua.Text
                If conexion_valoresArancelario.insertarDatosValorArancelario(datos_valoresarancelario) Then
                    MessageBox.Show("datos guardados")
                    txtMonto.Text = ""
                    restCuadras = restCuadras + 1
                    txtResCua.Text = restCuadras
                    pbarLlenado.Increment(1)
                Else
                    MessageBox.Show("datos no guardados")
                End If
            End If

        Else
            btnNext.Enabled = False
        End If

    End Sub


    Private Sub txtMonto_LostFocus(sender As Object, e As EventArgs) Handles txtMonto.LostFocus
        Dim val As Decimal = 0
        If Decimal.TryParse(txtMonto.Text, val) Then

            txtMonto.Text = val.ToString("N2")

        Else

            txtMonto.Text = ""

        End If
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar =
            Threading.Thread.CurrentThread.
            CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If

    End Sub

End Class
