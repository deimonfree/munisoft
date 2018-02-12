Public Class Paquete
    Private _comando As String
    Private _contenido As String
    Public Property comando_paquete As String
        Get
            Return _comando
        End Get
        Set(value As String)
            _comando = value
        End Set
    End Property
    Public Property contenido_paquete As String
        Get
            Return _contenido
        End Get
        Set(value As String)
            _contenido = value
        End Set
    End Property
    Public Sub paquete(ByVal datos As String)
        Dim sepIndex As String
        sepIndex = datos.IndexOf(":", StringComparison.Ordinal)
        _comando = datos.Substring(0, sepIndex)
        _contenido = datos.Substring(_comando.Length + 1)
    End Sub
End Class
