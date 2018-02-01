Public Class class_datos_requerimiento
    Private _idrequerimiento As Integer
    Private _fecha As Date
    Private _denominacion As String
    Private _sustento_tecnico As String
    Private _cod_funcionario As Integer

    Public Property id_requerimiento As Integer
        Get
            Return _idrequerimiento
        End Get
        Set(value As Integer)
            _idrequerimiento = value
        End Set
    End Property
    Public Property fecha_requerimiento As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property denominacion_requerimiento As String
        Get
            Return _denominacion
        End Get
        Set(value As String)
            _denominacion = value
        End Set
    End Property
    Public Property sustrento_requerimiento As String
        Get
            Return _sustento_tecnico
        End Get
        Set(value As String)
            _sustento_tecnico = value
        End Set
    End Property
    Public Property codFuncionario_requerimiento As Integer
        Get
            Return _cod_funcionario
        End Get
        Set(value As Integer)
            _cod_funcionario = value
        End Set
    End Property
End Class
