Public Class class_dats_antiguedad
    Private _idtabla_antiguedad As Integer
    Private _ant_maxima As Integer
    Public Property id_antiguedadVivienda As Integer
        Get
            Return _idtabla_antiguedad
        End Get
        Set(value As Integer)
            _idtabla_antiguedad = value
        End Set
    End Property
    Public Property antMax_antiguedadVivienda As Integer
        Get
            Return _ant_maxima
        End Get
        Set(value As Integer)
            _ant_maxima = value

        End Set
    End Property
End Class
