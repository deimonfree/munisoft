Public Class Mensaje
    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        If Trim(txtMessage.Text) = "" Then
            txtMessage.Text = ""
            txtMessage.Select()
        Else
            enviarMensajeServidor(txtMessage.Text)
            txtMessage.Text = ""
            txtMessage.Select()
        End If
    End Sub
End Class
