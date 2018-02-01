Imports System.Windows.Forms

Public Class d_rentas_busqueda_ficha
    Public valor_ficha As Integer
    Public valor_contribuyente As Integer
    Public valor_predio As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnlistarall_Click(sender As Object, e As EventArgs) Handles btnlistarall.Click
        If rbCOD.Checked = True Then
            _DatasetContribuyente.Reset()
            consulta_datos_contribuyente_by_codigo(txtPalabraClave.Text)
            dgwContribuyente.DataSource = _dtwContribuyente
        End If
        If rbAP.Checked = True Then
            _DatasetContribuyente.Reset()
            consulta_datos_contribuyente_by_ApellidoPeterno(txtPalabraClave.Text)
            dgwContribuyente.DataSource = _dtwContribuyente
        End If
        If rbN.Checked = True Then
            _DatasetContribuyente.Reset()
            consulta_datos_contribuyente_by_Nombre(txtPalabraClave.Text)
            dgwContribuyente.DataSource = _dtwContribuyente
        End If
        If rbDNI.Checked = True Then
            _DatasetContribuyente.Reset()
            consulta_datos_contribuyente_by_DNI(txtPalabraClave.Text)
            dgwContribuyente.DataSource = _dtwContribuyente
        End If
        If rbRZ.Checked = True Then
            _DatasetContribuyente.Reset()
            consulta_datos_contribuyente_by_RazonSocial(txtPalabraClave.Text)
            dgwContribuyente.DataSource = _dtwContribuyente
        End If
        If rbRUC.Checked = True Then
            _DatasetContribuyente.Reset()
            consulta_datos_contribuyente_by_RUC(txtPalabraClave.Text)
            dgwContribuyente.DataSource = _dtwContribuyente
        End If
    End Sub

    Private Sub dgwContribuyente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwContribuyente.CellClick
        Try
            Dim i As Integer
            Dim idContribuyente As Integer
            i = dgwContribuyente.CurrentRow.Index
            idContribuyente = dgwContribuyente.Item(0, i).Value()
            _DatasetPredio.Reset()
            consulta_datos_predio_by_esquema(idContribuyente)
            dgwPredio.DataSource = _dtwPredio
        Catch ex As Exception
        End Try
    End Sub

    Private Sub d_rentas_busqueda_ficha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetAnnioAll.Reset()
        consulta_datos_annio_all()
        cbxAnno.DataSource = _DatasetAnnioAll.Tables("anno")
        cbxAnno.DisplayMember = "anno"
        cbxAnno.ValueMember = "idanno"
    End Sub
    Private Sub dgwPredio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwPredio.CellClick
        Try
            Dim i As Integer
            Dim idPredio As Integer
            i = dgwPredio.CurrentRow.Index
            idPredio = dgwPredio.Item(0, i).Value()
            _DatasetFicha.Reset()
            consulta_datos_ficha_by_predio(idPredio, cbxAnno.SelectedValue.ToString())
            dgwFicha.DataSource = _dtwFicha
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbxAnno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAnno.SelectedIndexChanged
        Try
            Dim i As Integer
            Dim idPredio As Integer
            i = dgwPredio.CurrentRow.Index
            idPredio = dgwPredio.Item(0, i).Value()
            _DatasetFicha.Reset()
            consulta_datos_ficha_by_predio(idPredio, cbxAnno.SelectedValue.ToString())
            dgwFicha.DataSource = _dtwFicha
        Catch ex As Exception
        End Try
    End Sub

    Private Sub OK_Button_Click_1(sender As Object, e As EventArgs) Handles OK_Button.Click
        If alta() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Else
            MessageBox.Show("Uds le falta seleccionar uno o varios  de los opciones")
        End If
    End Sub
    Private Sub dgwContribuyente_Click(sender As Object, e As EventArgs) Handles dgwContribuyente.Click
        Try

            valor_contribuyente = dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgwPredio_Click(sender As Object, e As EventArgs) Handles dgwPredio.Click
        Try

            valor_predio = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgwFicha_Click(sender As Object, e As EventArgs) Handles dgwFicha.Click
        Try

            valor_ficha = dgwFicha.Rows(dgwFicha.CurrentRow.Index).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Function alta() As Boolean
        Dim valor_alta As Boolean = True
        If valor_predio = 0 Or Trim(valor_predio) = "" Then
            valor_alta = False
        End If
        If valor_contribuyente = 0 Or Trim(valor_contribuyente) = "" Then
            valor_alta = False
        End If
        If valor_ficha = 0 Or Trim(valor_ficha) = "" Then
            valor_alta = False
        End If
        Return valor_alta
    End Function

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class
