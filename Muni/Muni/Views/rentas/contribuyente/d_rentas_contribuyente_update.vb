Imports System.Windows.Forms

Public Class d_rentas_contribuyente_update
    Public valor_contribuyente As Integer = 0

    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If (valor_contribuyente = 0) Then
            panel_info.BackColor = Color.FromArgb(255, 140, 1)
            lblInfo.Text = "Uds. no ha elejido a ningun contibuyente"
            pbInfo.Image = My.Resources.attention
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub btnlistarall_Click(sender As Object, e As EventArgs) Handles btnlistarall.Click
        lblInfo.Text = "Buscando Contribuyente ..."
        panel_info.BackColor = Color.FromArgb(65, 79, 81)
        pbInfo.Image = My.Resources.info_white
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

    Private Sub dgwContribuyente_Click(sender As Object, e As EventArgs) Handles dgwContribuyente.Click
        Try
            If dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(1).Value = "--" Then
                lblInfo.Text = dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(5).Value & " :: " & dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(6).Value
                panel_info.BackColor = Color.FromArgb(150, 193, 31)
                pbInfo.Image = My.Resources.info_white
            Else
                lblInfo.Text = dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(1).Value & " " & dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(2).Value & " " & dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(3).Value & " :: " & dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(4).Value
                panel_info.BackColor = Color.FromArgb(150, 193, 31)
                pbInfo.Image = My.Resources.info_white
            End If
            valor_contribuyente = dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(0).Value
        Catch ex As Exception
            lblInfo.Text = "Hubo un error al escoger el Contribuyente"
            panel_info.BackColor = Color.FromArgb(255, 140, 1)
            pbInfo.Image = My.Resources.attention
        End Try

    End Sub

    Private Sub txtPalabraClave_TextChanged(sender As Object, e As EventArgs)
        btnlistarall.Text = "Buscar"
    End Sub

    Private Sub d_rentas_contribuyente_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgwContribuyente.BorderStyle = BorderStyle.None
        'dgwContribuyente.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        'dgwContribuyente.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        'dgwContribuyente.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 131, 140)
        'dgwContribuyente.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        'dgwContribuyente.BackgroundColor = Color.White

        'dgwContribuyente.EnableHeadersVisualStyles = False
        'dgwContribuyente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        'dgwContribuyente.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 131, 140)
        'dgwContribuyente.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub


End Class
