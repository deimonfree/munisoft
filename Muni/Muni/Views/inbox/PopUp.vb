Public Class PopUp
    Dim altura As Integer = 0
    Dim x As Integer = 0
    Dim sonido As System.Media.SoundPlayer

    Private Sub PopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(
            Screen.PrimaryScreen.Bounds.Width - 330,
            Screen.PrimaryScreen.Bounds.Height
            )
        lblUser.Text = usuario_message
        lblEstado.Text = estado_message
        titlemessage.Text = titulo_message
        contMessage.Text = mensaje_message
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity = 0 Then Me.Close()
        If x = 55 Then
            'sonido = New System.Media.SoundPlayer(My.Application.Info.DirectoryPath + "/WirelessChargingStarted.wav")
            'sonido.Play()
        End If
        If x = 2000 Then
            Me.Opacity -= 0.02
        End If
        If Not Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Height - 154 Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 2)
        End If
        If Not x = 2000 Then x += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Timer1.Stop()
        Me.Height = 500
        Me.Location = New Point(Me.Location.X, Me.Location.Y - 346)
    End Sub
    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class