Imports System.Windows.Forms

Public Class d_rentas_distrito_busqueda

    Public valor_dist As Integer = 0

    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim alta As Boolean = False
        lblinfo.Visible = False
        If (valor_dist = 0) Then
            lblinfo.Visible = True
            lblinfo.Text = "Uds. no escogio ningun tipo de Distrito"
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
        _DatasetDistrito.Reset()
        consulta_datos_Distrito_all()
        dgwDistrito.DataSource = _dtwDistrito
    End Sub

    Private Sub txtPalabraClave_TextChanged(sender As Object, e As EventArgs) Handles txtPalabraClave.TextChanged
        Dim valor As String
        valor = txtPalabraClave.Text
        _DatasetDistrito.Reset()
        consulta_datos_Distrito_all_By(valor)
        dgwDistrito.DataSource = _dtwDistrito
    End Sub

    Private Sub dgwDistrito_Click(sender As Object, e As EventArgs) Handles dgwDistrito.Click
        Try
            valor_dist = dgwDistrito.Rows(dgwDistrito.CurrentRow.Index).Cells(0).Value
            lblSeleccion.Text = dgwDistrito.Rows(dgwDistrito.CurrentRow.Index).Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub
End Class
