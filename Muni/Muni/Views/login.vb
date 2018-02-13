Public Class login
    ' clase cliente para conexion con servidor
    Inherits System.Windows.Forms.Form
    Dim IPserver As String
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
        'pbIcon.Visible = False
        pbLoad.Visible = True
        Dim samplePrincipal As New SampleIPrincipal(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)
        Me.PasswordTextBox.Text = ""
        If (Not samplePrincipal.Identity.IsAuthenticated) Then
            ' The user is still not validated.
            'pbIcon.Visible = True
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
            Dim datos As New class_datos_log_login
            Dim control As New class_controller_log_usuarios
            Dim namepc As String
            Dim fecha As String
            Dim oIp As New Net.IPAddress(Net.Dns.Resolve(My.Computer.Name).AddressList(0).GetAddressBytes)
            'user =
            namepc = Environment.UserName.ToString
            fecha = DateTime.Now.ToString
            datos.user = UserNameEnvio
            datos.namepc = namepc
            datos.fecha = fecha
            datos.ip = oIp.ToString
            control.insertarDatosLogUsuarios(datos)
            'If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            '    tsmUserName.Text = "User is an Administrator"
            'Else
            '    Me.Label6.Text = "User is not an Administrator"
            'End If
            Dim formulario As New principal
            formulario.UserName = UserNameEnvio
            formulario.Show()
            If chkPass.Checked Then
                My.Settings.Usuario = UsernameTextBox.Text
                My.Settings.Pass = PasswordTextBox.Text
                My.Settings.Login = 1
                My.Settings.Save()
            Else
            End If
            Me.Close()
        End If
    End Sub


    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargar_servidores()
        verificar_servidor()
    End Sub
    Sub verificar_servidor()
        If My.Settings.EstaConfServ = 0 Then
            OK.Enabled = False
            panelFooter.BackColor = Color.FromArgb(150, 193, 31)
            lblInfoFotter.Text = "Conexión con Servidor no Configurado > Seleccione el servidor al que deseas conectarte"
            OK.Text = "Configurar Servidor"
            gbServidores.Enabled = True
        Else
            If conexion_servidor(My.Settings.ServerIP) = 0 Then
                lblInfoServer.Text = "No Conectado"
                OK.Enabled = True
                panelFooter.BackColor = Color.FromArgb(255, 140, 0)
                lblInfoFotter.Text = "Sin Conexión con el Servidor :: Escoge otro servidor " & My.Settings.ServerIP
                OK.Text = "Ingresar"
                gbServidores.Enabled = True
            ElseIf conexion_servidor(My.Settings.ServerIP) = 1 Then
                lblInfoServer.Text = "Conectado"
                gbServidores.Enabled = False
                OK.Enabled = True
                panelFooter.BackColor = Color.FromArgb(0, 122, 204)
                lblInfoFotter.Text = "Conectado con Servidor: " & My.Settings.ServerIP
                OK.Text = "Ingresar"
            Else
                lblInfoServer.Text = "Error"
                gbServidores.Enabled = False
                OK.Enabled = False
                panelFooter.BackColor = Color.FromArgb(220, 48, 75)
                lblInfoFotter.Text = "Colisión de Servidores :: Pongase en contacto con el personal de Soporte" & My.Settings.ServerIP
                OK.Text = "Ingresar"
            End If


        End If
    End Sub

    Private Sub cbxServidores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxServidores.SelectedIndexChanged
        If gbServidores.Enabled = False Then
            lblIP.Text = My.Settings.ServerIP
            lblPUERTO.Text = My.Settings.ServerPort
        Else
            Try
                lblIP.Text = cbxServidores.Text
                lblPUERTO.Text = cbxServidores.SelectedValue.ToString()
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        My.Settings.ServerIP = lblIP.Text
        My.Settings.ServerPort = lblPUERTO.Text
        verificar_servidor()
        My.Settings.EstaConfServ = 1
        My.Settings.Save()
    End Sub
    Sub cargar_servidores()
        Try
            _DatasetServidoresBox.Reset()
            Listado_Servidores()
            cbxServidores.DataSource = _DatasetServidoresBox.Tables("servers")
            cbxServidores.DisplayMember = "ip"
            cbxServidores.ValueMember = "puerto"
            verificar_servidor()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxServidores_Click(sender As Object, e As EventArgs) Handles cbxServidores.Click
        cargar_servidores()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        gbServidores.Enabled = True
    End Sub
End Class
