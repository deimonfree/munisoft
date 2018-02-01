Public NotInheritable Class ab_dni_share
    Public dni As String

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub OKButton_Click_1(sender As Object, e As EventArgs) Handles OKButton.Click
        dni = txtdni.Text
        Me.Close()
    End Sub
End Class
