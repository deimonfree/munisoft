Module modulo_popup
#Region "variables"
    Private user As String
    Private sub_titulo As String
    Private titulo As String
    Private message As String
    Private img_message As String
    Private text_button As String
    Private tipo As String
    Private colorboton As String
    Private colorBody As String
    Private colorSeparador As String

#End Region
    Public Property usuario_message As String
        Get
            Return user
        End Get
        Set(value As String)
            user = value
        End Set
    End Property
    Public Property titulo_message As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property
    Public Property mensaje_message As String
        Get
            Return message
        End Get
        Set(value As String)
            message = value
        End Set
    End Property
    Public Property boton_message As String
        Get
            Return text_button
        End Get
        Set(value As String)
            text_button = value
        End Set
    End Property
    Public Property colorSeparador_message As String
        Get
            Return colorSeparador
        End Get
        Set(value As String)
            colorSeparador = value
        End Set
    End Property
    Public Property colorBody_message As String
        Get
            Return colorBody
        End Get
        Set(value As String)
            colorBody = value
        End Set
    End Property
    Public Property colorButon_message As String
        Get
            Return colorboton
        End Get
        Set(value As String)
            colorboton = value
        End Set
    End Property
    Public Property estado_message As String
        Get
            Return sub_titulo
        End Get
        Set(value As String)
            sub_titulo = value
        End Set
    End Property
#Region "Colores de popUp"
    Sub server_message(ByVal tituloMessage As String, ByVal mensaje As String, ByVal textBoton As String)
        user = "Servidor"
        sub_titulo = "Online"
        titulo = tituloMessage
        message = mensaje
        img_message = textBoton
        text_button = "Cerrar"
        colorboton = "139, 172, 36"
        colorBody = "150, 193, 31"
        colorSeparador = "139, 172, 36"
    End Sub
#End Region
End Module
