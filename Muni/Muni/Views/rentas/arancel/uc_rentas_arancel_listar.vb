Public Class uc_rentas_arancel_listar
    Dim via As Integer
    Dim anio As Integer
    Private Sub btnlistarall_Click(sender As Object, e As EventArgs) Handles btnlistarall.Click
        Try
            via = cbxVia.SelectedValue.ToString()
            anio = cbxAnno.SelectedValue.ToString()
            _DatasetValorArancelario.Reset()
            consulta_datos_valorArancelario_by(via, anio)
            dgwValorArancelario.DataSource = _dtwValorArancelario

        Catch ex As Exception

        End Try
    End Sub

    Private Sub uc_rentas_arancel_listar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dato As String
        dato = cbxSector.SelectedValue.ToString()
        'llenado de sectores
        _DatasetNomViaBox.Reset()
        consulta_datos_via_combox_by(dato)
        cbxVia.DataSource = _DatasetNomViaBox.Tables("via")
        cbxVia.DisplayMember = "nombre"
        cbxVia.ValueMember = "idvia"
    End Sub
    Private Sub dgwValorArancelario_Click(sender As Object, e As EventArgs) Handles dgwValorArancelario.Click
        Try
            Dim v1 As Integer
            txtCodVia.Text = dgwValorArancelario.Rows(dgwValorArancelario.CurrentRow.Index).Cells(0).Value
            txtNomVia.Text = StrConv(dgwValorArancelario.Rows(dgwValorArancelario.CurrentRow.Index).Cells(1).Value, VbStrConv.ProperCase) + " " + StrConv(dgwValorArancelario.Rows(dgwValorArancelario.CurrentRow.Index).Cells(2).Value, VbStrConv.ProperCase)
            txtCuadra.Text = dgwValorArancelario.Rows(dgwValorArancelario.CurrentRow.Index).Cells(3).Value
            txtMonto.Text = dgwValorArancelario.Rows(dgwValorArancelario.CurrentRow.Index).Cells(4).Value
            txtAnio.Text = dgwValorArancelario.Rows(dgwValorArancelario.CurrentRow.Index).Cells(5).Value

        Catch ex As Exception

        End Try
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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim controlador As New class_controller_valorArancelario
        Dim datos As New class_datos_valorArancelario
        If alta() = True Then
            MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 123",
       MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            datos.id_valorArancelario = txtCodVia.Text
            datos.codVia_valorArancelario = via
            datos.codAnno_valorArancelario = anio
            datos.valor_valorArancelario = txtMonto.Text
            datos.cuadra_valorArancelario = txtCuadra.Text
            If controlador.actualizarDatosValorArancelario(datos) Then
                MessageBox.Show("datos guardados")
                clean()
                consultaVias()
            Else
                MessageBox.Show("datos no guardados")
            End If
        End If
    End Sub
    Private Function alta() As Boolean
        Dim valor_alta As Boolean = False
        pbMonto.Visible = False
        Select Case ""
            Case Trim(txtMonto.Text)
                valor_alta = True
                pbMonto.Visible = True
        End Select
        Return valor_alta
    End Function
    Private Sub clean()
        txtCodVia.Text = ""
        txtNomVia.Text = ""
        txtAnio.Text = ""
        txtCuadra.Text = ""
        txtMonto.Text = ""
    End Sub
    Private Sub consultaVias()
        via = cbxVia.SelectedValue.ToString()
        anio = cbxAnno.SelectedValue.ToString()
        _DatasetValorArancelario.Reset()
        consulta_datos_valorArancelario_by(via, anio)
        dgwValorArancelario.DataSource = _dtwValorArancelario
    End Sub
End Class
