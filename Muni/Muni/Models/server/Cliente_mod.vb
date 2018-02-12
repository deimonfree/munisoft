Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.IO
Module Cliente_mod
    Public mensaje_jodido As String
    Dim WithEvents WinSockCliente As New Cliente
    Public Sub ConectarServidor()
        Try
            With WinSockCliente
                .IPDelHost = My.Settings.ServerIP
                .PuertoDelHost = My.Settings.ServerPort
                .Conectar()
                .EnviarDatos("Conexion:" & My.User.Name)
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub enviarMensajeServidor(ByVal mensaje As String)
        WinSockCliente.EnviarDatos(My.User.Name & ":" & mensaje)
    End Sub
    Public Sub cerrar_conexion(ByVal usuario As String)
        WinSockCliente.EnviarDatos("Desconexion:" & usuario)
    End Sub

    Private Sub WinSockCliente_DatosRecibidos(ByVal datos As String) Handles WinSockCliente.DatosRecibidos
        mensaje_jodido = datos
    End Sub
    Public Sub mensajeescribir(ByVal mensaje As String)
        mensaje_jodido = mensaje
    End Sub
End Module
