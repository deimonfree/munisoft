Imports System.Windows.Forms
Public Class principal
    Public UserName As String
    Dim valor_server As Integer = 0
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
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim height As Integer = 0.9 * desktopSize.Height
        Dim width As Integer = 0.76 * desktopSize.Width
        'Dim Myfrm As New cu_almacen
        'Myfrm.Size = New System.Drawing.Size(width, height)
        'Myfrm.Visible = True
        'Myfrm.Show()
        'pnlContenedor.Controls.Clear()
        'pnlContenedor.Controls.Add(Myfrm)
        'añandir el monbre de usuario
        lblname.Text = My.User.Name
        Timer1.Start()
        Timer1.Enabled = True
        Timer1.Interval = 1000

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        valor_server += 1
        Select Case valor_server
            Case 1
                pb_server.Image = My.Resources.server_1
            Case 2
                pb_server.Image = My.Resources.server2
            Case 3
                pb_server.Image = My.Resources.server3
        End Select
        If valor_server = 3 Then
            valor_server = 0
        End If
    End Sub

End Class