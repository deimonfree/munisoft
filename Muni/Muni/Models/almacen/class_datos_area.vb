Public Class class_datos_area
    Private _idarea As Integer
    Private _description As String
    Public Property id_area() As Integer
        Get
            Return _idarea
        End Get
        Set(value As Integer)
            _idarea = value
        End Set
    End Property
    Public Property description_area() As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

End Class
