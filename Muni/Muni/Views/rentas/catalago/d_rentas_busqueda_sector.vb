Imports System.Windows.Forms

Public Class d_rentas_busqueda_sector
    Public valor_sector As Integer = 0

    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If (valor_sector = 0) Then
            MessageBox.Show("Uds. no escogio ningun tipo de Sector")
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
        lblInfo.Text = "Buscando Sector ..."
        pbload.Visible = True
        _DatasetSector.Reset()
        consulta_datos_sector_all()
        dgwContribuyente.DataSource = _dtwSector
        lblInfo.Text = "Resultados de Sector ::"
    End Sub

    Private Sub dgwContribuyente_Click(sender As Object, e As EventArgs) Handles dgwContribuyente.Click
        Try

            valor_sector = dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPalabraClave_TextChanged(sender As Object, e As EventArgs) Handles txtPalabraClave.TextChanged
        btnlistarall.Text = "Buscar"
    End Sub

    Private Sub d_rentas_busqueda_sector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
