Imports System.Windows.Forms

Public Class d_rentas_busqueda
    Dim title_contri As String
    Dim title_predio As String
    Dim estado_boton_avanzado As Integer = 0
    Public valor_contribuyente As Integer = 0
    Public valor_ficha As Integer = 0
    Public valor_predio As Integer = 0
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If valor_contribuyente <> 0 And valor_predio <> 0 Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            panel_info.BackColor = Color.FromArgb(255, 140, 1)
            lblInfo.Text = "Uds. no ha elejido a ningun contibuyente"
            pbInfo.Image = My.Resources.attention
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnlistarall_Click(sender As Object, e As EventArgs) Handles btnlistarall.Click
        If Trim(txtPalabraClave.Text) = "" Then
            _DatasetContribuyente.Reset()
            consulta_datos_contribuyente_all()
            dgwContribuyente.DataSource = _dtwContribuyente
        Else
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

    Private Sub dgwContribuyente_Click(sender As Object, e As EventArgs) Handles dgwContribuyente.Click
        Try
            valor_contribuyente = dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(0).Value
            title_contri = dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(4).Value & " :: " & dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(1).Value & " " & dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(2).Value & " " & dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(3).Value
            lblInfo.Text = title_contri & " - " & title_predio
            panel_info.BackColor = Color.FromArgb(150, 193, 31)
            pbInfo.Image = My.Resources.info_white
        Catch ex As Exception
            lblInfo.Text = "Hubo un error al escoger el Contribuyente"
            panel_info.BackColor = Color.FromArgb(255, 140, 1)
            pbInfo.Image = My.Resources.attention
        End Try
    End Sub
    Private Sub dgwPredio_Click(sender As Object, e As EventArgs) Handles dgwPredio.Click
        Try
            valor_predio = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(0).Value
            title_predio = dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(1).Value & " " & dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(2).Value & " NRO. " & dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(4).Value & " CDRA. " & dgwPredio.Rows(dgwPredio.CurrentRow.Index).Cells(3).Value
            lblInfo.Text = title_contri & " - " & title_predio
            panel_info.BackColor = Color.FromArgb(150, 193, 31)
            pbInfo.Image = My.Resources.info_white
        Catch ex As Exception
            lblInfo.Text = "Hubo un error al escoger el Contribuyente"
            panel_info.BackColor = Color.FromArgb(255, 140, 1)
            pbInfo.Image = My.Resources.attention
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

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub d_rentas_busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPalabraClave.Select()
    End Sub

End Class
