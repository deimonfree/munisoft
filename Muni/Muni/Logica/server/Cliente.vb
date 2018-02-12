Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.IO
Public Class Cliente
#Region "VARIABLES"
    Private NS As NetworkStream 'Utilizado para enviar datos al Servidor y recibir datos del mismo
    Private m_IPDelHost As String 'Direccion del objeto de la clase Servidor
    Private m_PuertoDelHost As String 'Puerto donde escucha el objeto de la clase Servidor
    Dim CLIENTE As TcpClient
    Dim HILO As Thread 'Se encarga de escuchar mensajes enviados por el Servidor
    Dim mensaje As String
    Dim estado_servidor As Boolean

#End Region

#Region "EVENTOS"
    Public Event ConexionTerminada()
    Public Event DatosRecibidos(ByVal datos As String)
#End Region
#Region "PROPIEDADES"
    Public Property IPDelHost() As String
        Get
            IPDelHost = m_IPDelHost
        End Get
        Set(ByVal Value As String)
            m_IPDelHost = Value
        End Set
    End Property

    Public Property PuertoDelHost() As String
        Get
            PuertoDelHost = m_PuertoDelHost
        End Get
        Set(ByVal Value As String)
            m_PuertoDelHost = Value
        End Set

    End Property
#End Region

#Region "METODOS"
    Public Sub Conectar()
        Try
            CLIENTE = New TcpClient()
            CLIENTE.Connect(IPDelHost, PuertoDelHost)
            NS = CLIENTE.GetStream() 'Creo e inicio un thread para que escuche los mensajes enviados por el Servidor
            HILO = New Thread(AddressOf leerSocket)
            HILO.Start()
        Catch ex As Exception
            MessageBox.Show("servidor no encontrado")
        End Try
    End Sub
    Public Sub EnviarDatos(ByVal Datos As String)
        Try
            Dim BufferDeEscritura() As Byte
            BufferDeEscritura = Encoding.ASCII.GetBytes(Datos)
            If Not (NS Is Nothing) Then
                'Envio los datos al Servidor
                NS.Write(BufferDeEscritura, 0, BufferDeEscritura.Length)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "FUNCIONES PRIVADAS"
    Private Sub leerSocket()
        Dim BufferDeLectura() As Byte
        While True
            Try
                BufferDeLectura = New Byte(100) {}
                NS.Read(BufferDeLectura, 0, BufferDeLectura.Length)
                Dim MENSAJE As String = Encoding.ASCII.GetString(BufferDeLectura)
                Dim MISPLIT As New ArrayList(MENSAJE.Split(":"))
                If MISPLIT(0) = "Servidor" Then
                    RaiseEvent DatosRecibidos(MENSAJE)
                Else
                    RaiseEvent DatosRecibidos(MENSAJE)
                    'ElseIf MISPLIT(0).ToString.Contains("Privado") Then
                    'RaiseEvent DatosRecibidos(Encoding.ASCII.GetString(BufferDeLectura))
                End If
            Catch e As Exception
                HILO.Abort()
                CLIENTE.Close()
                Exit While
            End Try
        End While
        RaiseEvent ConexionTerminada()
        HILO.Abort()
        CLIENTE.Close()
    End Sub
#End Region
End Class
