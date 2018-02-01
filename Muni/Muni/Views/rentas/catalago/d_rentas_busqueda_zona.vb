Imports System.Windows.Forms

Public Class d_rentas_busqueda_zona

    Public valor_zona As Integer = 0

    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If (valor_zona = 0) Then
            MessageBox.Show("Uds. no escogio ninguna zona")
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
        lblInfo.Text = "Buscando Zona ..."
        pbload.Visible = True
        lblsubInfo.Visible = False
        _DatasetZona.Reset()
        consulta_datos_zona_all()
        dgwContribuyente.DataSource = _dtwZona
    End Sub

    Private Sub dgwContribuyente_Click(sender As Object, e As EventArgs) Handles dgwContribuyente.Click
        Try

            valor_zona = dgwContribuyente.Rows(dgwContribuyente.CurrentRow.Index).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub d_rentas_contribuyente_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
