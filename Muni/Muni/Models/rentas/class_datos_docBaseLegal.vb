Public Class class_datos_docBaseLegal
    Private _iddoc_base_legal As Integer
    Private _num_exp As String
    Private _num_resol As String
    Private _cod_ficha As Integer
    Public Property id_docBaseLegal As Integer
        Get
            Return _iddoc_base_legal
        End Get
        Set(value As Integer)
            _iddoc_base_legal = value
        End Set
    End Property
    Public Property numExpediente_docBaseLegal As String
        Get
            Return _num_exp
        End Get
        Set(value As String)
            _num_exp = value
        End Set
    End Property
    Public Property numResolucion_docBaseLegal As String
        Get
            Return _num_resol
        End Get
        Set(value As String)
            _num_resol = value
        End Set
    End Property

    Public Property codFicha_docBaseLegal As Integer
        Get
            Return _cod_ficha
        End Get
        Set(value As Integer)
            _cod_ficha = value
        End Set
    End Property
End Class
