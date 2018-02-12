Imports System.Windows.Forms
Public Class principal
    Inherits System.Windows.Forms.Form
    Dim WithEvents inboox As New Cliente_mensajes
    Dim numeross As Integer = 0
    'variables de entrono
    Public UserName As String
    Dim valor_server As Integer = 0
    '********************** variables de socket **********************
    Public estado_servidor As Boolean = True
    Public cliente As String
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub


    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Private Sub principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        lblname.Text = My.User.Name
        tmAnimacion.Start()
        tmAnimacion.Enabled = True
        tmAnimacion.Interval = 1000
        lblServer.Text = "Online"
        ConectarServidor()
        tmAnimacion.Start()
    End Sub
    Private Sub Minimizar()
        Me.WindowState = FormWindowState.Minimized
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip("3000", "Información", "la aplicación se esta ejacutando en segundo plano", ToolTipIcon.Info)
        End If

    End Sub


    Private Sub btnInicio_Click_1(sender As Object, e As EventArgs)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.87 * desktopSize.Height
        Dim width As Integer = 0.78 * desktopSize.Width
        Dim Myfrm As New Form1
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(Myfrm)
    End Sub

    Private Sub btnCliente_Click_1(sender As Object, e As EventArgs)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.87 * desktopSize.Height
        Dim width As Integer = 0.78 * desktopSize.Width
        Dim Myfrm As New Form1
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(Myfrm)
    End Sub

    Private Sub btnConexion_Click(sender As Object, e As EventArgs)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.87 * desktopSize.Height
        Dim width As Integer = 0.78 * desktopSize.Width
        Dim Myfrm As New Form1
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(Myfrm)
    End Sub

    Private Sub btnServicio_Click_1(sender As Object, e As EventArgs)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.87 * desktopSize.Height
        Dim width As Integer = 0.78 * desktopSize.Width
        Dim Myfrm As New Form1
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(Myfrm)
    End Sub

    Private Sub btnFactura_Click_1(sender As Object, e As EventArgs)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.87 * desktopSize.Height
        Dim width As Integer = 0.78 * desktopSize.Width
        Dim Myfrm As New Form1
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(Myfrm)
    End Sub

    Private Sub btnCobro_Click(sender As Object, e As EventArgs)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.87 * desktopSize.Height
        Dim width As Integer = 0.78 * desktopSize.Width
        Dim Myfrm As New Form1
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(Myfrm)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.87 * desktopSize.Height
        Dim width As Integer = 0.78 * desktopSize.Width
        Dim Myfrm As New Form1
        Myfrm.Size = New Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(Myfrm)
    End Sub

    Private Sub ConfigurarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.87 * desktopSize.Height
        Dim width As Integer = 0.8 * desktopSize.Width
        Dim Myfrm As New Form1
        Myfrm.Size = New System.Drawing.Size(width, height)
        Myfrm.Visible = True
        Myfrm.Show()
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(Myfrm)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Call Minimizar()

    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub OcultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OcultarToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        NotifyIcon1.Visible = False
        End
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs)
        End
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        Dim Myfrm As New uc_almacen
        Myfrm.Size = New System.Drawing.Size(Width, Height)
        Myfrm.Visible = True
        Myfrm.Show()
        pnlContenedor.Controls.Clear()
        pnlContenedor.Controls.Add(Myfrm)
    End Sub

    Private Sub desconeccion_server()
        pnlHeader.BackColor = Color.FromArgb(255, 140, 1)
        tmAnimacion.Stop()
        lblServer.Text = "Sin Conexion"
        pnlMenu.Enabled = False
        pnlContenedor.Enabled = False
        lblServer.Text = My.Settings.ServerIP
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        cerrar_conexion(My.User.Name)
        System.Environment.Exit(System.Environment.ExitCode)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmAnimacion.Tick, Timer1.Tick
        If mensaje_jodido <> "" Then
            cliente = mensaje_jodido
            inboox.inbox(cliente)
            mensaje_jodido = ""
        Else
        End If
    End Sub
    Private Sub recuperar_inbox(ByVal dato As String) Handles inboox.Datosibox
        Dim paquete As New Paquete
        paquete.paquete(dato)

        Select Case paquete.comando_paquete.ToString()
            Case "Conexion"
                Dim paneluser As New Usuarios
                paneluser.lblname.Text = paquete.contenido_paquete.ToString
                paneluser.lblEstado.Text = "En Linea"
                flpContenedor.Controls.Add(paneluser)
            Case "Desconexion"

        End Select
        lblInfoFotter.Text = dato
        Dim USUARIO As String
        Select Case dato.StartsWith("Servidor:")
            Case True
                Dim MENSAJE As String = lblInfoFotter.Text
                USUARIO = MENSAJE.Remove(0, MENSAJE.IndexOf(":") + 1)
                USUARIO = USUARIO.Trim("")
                If MENSAJE.StartsWith("Conexion:") Then
                    Label1.Text = USUARIO

                ElseIf MENSAJE.StartsWith("Desconexion:") Then
                    Label1.Text = USUARIO

                ElseIf MENSAJE.StartsWith("deimonfree:") Then
                    Dim Cadena As String = Me.lblInfoFotter.Text
                    Dim split As String() = Cadena.Split(New [Char]() {":"c, CChar(vbLf), Nothing})
                    For i = 1 To split.Count - 1
                        Dim SentenciaSQL As String = Trim(split(i))
                        If SentenciaSQL = "100" Then
                            lblServer.Text = "100"
                        Else
                            lblServer.Text = "00"
                        End If
                    Next
                    TextBoxCHAT.AppendText(vbCrLf & MENSAJE)
                ElseIf MENSAJE.StartsWith("Servidor:") Then
                    Dim Cadena As String = Me.lblInfoFotter.Text
                    Dim split As String() = Cadena.Split(New [Char]() {":"c, CChar(vbLf), Nothing})
                    For i = 1 To split.Count - 1
                        Dim SentenciaSQL As String = Trim(split(i))
                        If SentenciaSQL = "100" Then
                            lblServer.Text = "100"
                        Else
                            lblServer.Text = "00"
                        End If
                    Next
                    TextBoxCHAT.AppendText(vbCrLf & MENSAJE)
                Else
                    Dim Cadena As String = Me.lblInfoFotter.Text
                    Dim split As String() = Cadena.Split(New [Char]() {":"c, CChar(vbLf), Nothing})
                    For i = 1 To split.Count - 1
                        Dim SentenciaSQL As String = Trim(split(i))
                        If SentenciaSQL = "100" Then
                            lblServer.Text = "100"
                        Else
                            lblServer.Text = "00"
                        End If
                    Next
                End If
                TextBoxCHAT.AppendText(vbCrLf & MENSAJE)
                Dim popup As New PopUp
                server_message("Mensaje de Servidor:", "Servidor se suspendera", "Cerrar")
                popup.Show()
            Case False
        End Select

    End Sub
    Public Event Agregar(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private Sub btnServidores_Click(sender As Object, e As EventArgs) Handles btnServidores.Click
        sidePanelChat.Width = btnServidores.Width
        sidePanelChat.Location = btnServidores.Location
        btnServidores.BackColor = Color.FromArgb(255, 255, 255)
        btnServidores.ForeColor = Color.FromArgb(6, 60, 107)
        sidePanelChat.Visible = True
        btnComunicador.BackColor = Color.FromArgb(232, 232, 236)
        btnComunicador.ForeColor = Color.FromArgb(6, 60, 107)
        Me.TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btnComunicador_Click(sender As Object, e As EventArgs) Handles btnComunicador.Click
        sidePanelChat.Width = btnComunicador.Width
        sidePanelChat.Location = btnComunicador.Location
        btnComunicador.BackColor = Color.FromArgb(255, 255, 255)
        btnComunicador.ForeColor = Color.FromArgb(6, 60, 107)
        sidePanelChat.Visible = True
        btnServidores.BackColor = Color.FromArgb(232, 232, 236)
        btnServidores.ForeColor = Color.FromArgb(6, 60, 107)
        Me.TabControl1.SelectedTab = TabPage2
    End Sub

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