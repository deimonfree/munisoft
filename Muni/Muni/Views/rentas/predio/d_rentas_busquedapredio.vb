Imports System.Windows.Forms

Public Class d_rentas_busquedapredio
    Dim idZona As Integer
    Dim idSector As Integer
    Dim idGrupoCatastral As Integer
    Dim zona As New class_datos_zonaa
    Public valor_grupoCatastral As Integer = 0
    Public valor_zona As Integer = 0
    Public valor_sector As Integer = 0
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If (valor_grupoCatastral = 0 And valor_zona = 0 And valor_sector = 0) Then
            panel_info.BackColor = Color.FromArgb(255, 140, 1)
            lblInfo.Text = "Uds. no ha elejido a una zona urbana"
            pbInfo.Image = My.Resources.attention
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgwZona_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwZona.CellClick
        Try
            Dim i As Integer
            i = dgwZona.CurrentRow.Index
            idZona = dgwZona.Item(0, i).Value()
            valor_zona = idZona
            lblInfo.Text = idZona
            _DatasetSector.Reset()
            consulta_datos_sector_by(idZona)
            dgwSector.DataSource = _dtwSector
            panel_info.BackColor = Color.FromArgb(150, 193, 31)
            pbInfo.Image = My.Resources.info_white
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgwSector_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwSector.CellClick
        Try
            Dim i As Integer
            i = dgwSector.CurrentRow.Index
            idSector = dgwSector.Item(0, i).Value()
            valor_sector = idSector
            lblInfo.Text = idSector
            _DatasetGrupoCatastral.Reset()
            consulta_datos_grupoCatastral_by(idSector)
            dgwGrupoCatastral.DataSource = _dtwGrupoCatastral
            panel_info.BackColor = Color.FromArgb(150, 193, 31)
            pbInfo.Image = My.Resources.info_white
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgwGrupoCatastral_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrupoCatastral.CellClick
        Try
            Dim i As Integer
            i = dgwGrupoCatastral.CurrentRow.Index
            valor_grupoCatastral = dgwGrupoCatastral.Item(0, i).Value()
            panel_info.BackColor = Color.FromArgb(150, 193, 31)
            pbInfo.Image = My.Resources.info_white
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnlistarall_Click(sender As Object, e As EventArgs) Handles btnlistarall.Click
        _DatasetZona.Reset()
        consulta_datos_zona_all()
        dgwZona.DataSource = _dtwZona
    End Sub

End Class
