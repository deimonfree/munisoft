Public Class login
    Private UserNameEnvio As String
    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click() Handles OK.Click
        'Dim login As New class_login(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)
        pbIcon.Visible = False
        pbLoad.Visible = True
        Dim samplePrincipal As New SampleIPrincipal(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)
        Me.PasswordTextBox.Text = ""
        If (Not samplePrincipal.Identity.IsAuthenticated) Then
            ' The user is still not validated.
            pbIcon.Visible = True
            pbLoad.Visible = False
            MsgBox("El usuario o contraseña son incorrectos")

        Else
            ' Update the current principal.
            My.User.CurrentPrincipal = samplePrincipal
            If My.User.IsAuthenticated Then
                UserNameEnvio = My.User.Name
            Else
                UserNameEnvio = "User"
            End If

            'If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            '    tsmUserName.Text = "User is an Administrator"
            'Else
            '    Me.Label6.Text = "User is not an Administrator"
            'End If
            Dim formulario As New principal
            formulario.UserName = UserNameEnvio
            formulario.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim desktopSize As Size
        'desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        'Dim height As Integer = 0.87 * desktopSize.Height
        'Dim width As Integer = 0.78 * desktopSize.Width
        'Dim Myfrm As New cu_login_Newuser
        'Myfrm.Size = New System.Drawing.Size(Width, Height)
        'Myfrm.Visible = True
        'Myfrm.Show()
        'plLoad.Controls.Clear()
        'plLoad.Controls.Add(Myfrm)
    End Sub


    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load

        If My.Computer.Network.Ping("192.168.1.250") Then
            If My.Computer.Network.Ping("127.0.0.1") Then
                lblInfo.Text = "No conectado"
            Else
                lblInfo.Text = "Conectado"
            End If
        End If
    End Sub
End Class
