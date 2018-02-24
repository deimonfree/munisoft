Public Class class_datos_campania
    Private _idcampania As Integer
    Private _nombre_campania As String
    Private _fecha_inicio_campania As String
    Private _feha_final_campania As String

    Public Property id_campania As Integer
        Get
            Return _idcampania
        End Get
        Set(value As Integer)
            _idcampania = value
        End Set
    End Property
    Public Property nombre_campania As String
        Get
            Return _nombre_campania
        End Get
        Set(value As String)
            _nombre_campania = value
        End Set
    End Property
    Public Property fecha_inicio_campania As String
        Get
            Return _fecha_inicio_campania
        End Get
        Set(value As String)
            _fecha_inicio_campania = value
        End Set
    End Property
    Public Property fecha_final_campania As String
        Get
            Return _feha_final_campania
        End Get
        Set(value As String)
            _feha_final_campania = value
        End Set
    End Property
End Class
