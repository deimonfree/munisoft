Public Class Paquete
    'Private _comando As String
    'Private _contenido As String
    Private _modulo As String
    Private _estado As String
    Private _submodulo As String
    Private _mensaje As String
    Private _variables As New ArrayList()
    Public Property modulo_paquete As String
        Get
            Return _modulo
        End Get
        Set(value As String)
            _modulo = value
        End Set
    End Property
    Public Property esatdo_paquete As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
    Public Property submodulo_paquete As String
        Get
            Return _submodulo
        End Get
        Set(value As String)
            _submodulo = value
        End Set
    End Property
    Public Property mensaje_paquete As String
        Get
            Return _mensaje
        End Get
        Set(value As String)
            _mensaje = value
        End Set
    End Property
    Public Property variables_paquete() As ArrayList
        Get
            Return _variables
        End Get
        Set(value As ArrayList)
            _variables = value
        End Set
    End Property
    Public Sub paquete(ByVal datos As String)
        Dim sepModulo As String
        Dim sepEstado As String
        Dim sepSubModulo As String
        Dim sepMensaje As String
        Dim sepVariables As String
        Dim datoCadena1 As String = ""
        Dim datoCadena2 As String = ""
        Dim datoCadena3 As String = ""
        Dim datoCadena4 As String = ""
        Dim contadorGuion As New Integer
        sepModulo = datos.IndexOf(":", StringComparison.Ordinal)
        If sepModulo <> -1 Then
            _modulo = datos.Substring(0, sepModulo)
            datoCadena1 = datos.Substring(_modulo.Length + 1)
        End If

        sepEstado = datoCadena1.IndexOf(";", StringComparison.Ordinal)
        If sepEstado <> -1 Then
            _estado = datoCadena1.Substring(0, sepEstado)
            datoCadena2 = datoCadena1.Substring(_estado.Length + 1)
        End If

        sepSubModulo = datoCadena2.IndexOf(".", StringComparison.Ordinal)
        If sepSubModulo <> -1 Then
            _submodulo = datoCadena2.Substring(0, sepSubModulo)
            datoCadena3 = datoCadena2.Substring(_submodulo.Length + 1)
        End If

        sepMensaje = datoCadena3.IndexOf(",", StringComparison.Ordinal)
        If sepMensaje <> -1 Then
            _mensaje = datoCadena3.Substring(0, sepMensaje)
            datoCadena4 = datoCadena3.Substring(_mensaje.Length + 1)
        End If
        'MsgBox(datoCadena4.IndexOf("-", StringComparison.Ordinal).ToString)

        For i As Integer = 0 To datoCadena4.Length - 1
            'MsgBox("Busca : " + datoCadena4.IndexOf("-", StringComparison.Ordinal).ToString)
            sepVariables = datoCadena4.IndexOf("-", StringComparison.Ordinal).ToString
            If datoCadena4.IndexOf("-", StringComparison.Ordinal) <> -1 Then
                contadorGuion += 1
                'MsgBox("Giones : " + contadorGuion.ToString)
                _variables.Add(datoCadena4.Substring(0, sepVariables))
                datoCadena4 = datoCadena4.Substring(datoCadena4.Substring(0, sepVariables).Length + 1)
                'MsgBox("Cadena 4 : " + datoCadena4)
            End If
        Next
    End Sub
    Public Sub encriptar() 'ByVal modulo As String, ByVal estado As String, ByVal submodulo As String, ByVal mensaje As String, ByVal variables As ArrayList())
        Dim mensajeEncriptado As String
        Dim modulo As String
        Dim estado As String
        Dim submodulo As String
        Dim mensaje As String
        Dim variables As ArrayList
        modulo = _modulo
        estado = _estado
        submodulo = _submodulo
        mensaje = _mensaje
        mensajeEncriptado = ""
        If modulo <> "" Then
            mensajeEncriptado = modulo + ":"
        End If
        If estado <> "" Then
            mensajeEncriptado = mensajeEncriptado + +estado + ";"
        End If
        If submodulo <> 0 Then
            mensajeEncriptado = mensajeEncriptado + submodulo + "."
        End If
        If mensaje <> "" Then
            mensajeEncriptado = mensajeEncriptado + mensaje + ","
        End If

        For i As Integer = 0 To variables_paquete.Count - 1
            variables = _variables
            mensajeEncriptado = mensajeEncriptado + variables(i) + "-"
        Next
        MsgBox(mensajeEncriptado)
    End Sub
End Class
