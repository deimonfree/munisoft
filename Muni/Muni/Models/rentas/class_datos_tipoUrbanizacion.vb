Public Class class_datos_tipoUrbanizacion
    Private _idtipo_urbanizacion As Integer
    Private _denominacion As String
    Public Property id_tipoUrbanizaciON As Integer
        Get
            Return _idtipo_urbanizacion
        End Get
        Set(value As Integer)
            _idtipo_urbanizacion = value
        End Set
    End Property
    Public Property denominacion_tipoUrbanizacion As String
        Get
            Return _denominacion
        End Get
        Set(value As String)
            _denominacion = value
        End Set
    End Property
End Class
