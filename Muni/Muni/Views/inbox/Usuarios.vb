Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Usuarios_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Panel1.Visible = True
    End Sub

    Private Sub Usuarios_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Panel1.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim mensaje As New Mensaje
        mensaje.lblname.Text = lblname.Text
        mensaje.lblEstado.Text = lblEstado.Text
    End Sub
End Class
