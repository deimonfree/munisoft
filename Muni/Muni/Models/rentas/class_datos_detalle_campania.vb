Public Class class_datos_detalle_campania
    Private _iddetalle_campania As Integer
    Private _nombre_DetCampania As String
    Private _valor_DetCampania As Decimal
    Private _tipo_rango_DetCampania As String
    Private _anio_DetCampania As String
    Private _cod_DetCampania As Integer

    Public Property id_Detcampania As Integer
        Get
            Return _iddetalle_campania
        End Get
        Set(value As Integer)
            _iddetalle_campania = value
        End Set
    End Property
    Public Property nombre_DetCampania As String
        Get
            Return _nombre_DetCampania
        End Get
        Set(value As String)
            _nombre_DetCampania = value
        End Set
    End Property
    Public Property valor_DetCampania As Decimal
        Get
            Return _valor_DetCampania
        End Get
        Set(value As Decimal)
            _valor_DetCampania = value
        End Set
    End Property
    Public Property tipo_rango_DetCampania As String
        Get
            Return _tipo_rango_DetCampania
        End Get
        Set(value As String)
            _tipo_rango_DetCampania = value
        End Set
    End Property
    Public Property annio_DetCampania As String
        Get
            Return _anio_DetCampania
        End Get
        Set(value As String)
            _anio_DetCampania = value
        End Set
    End Property
    Public Property cod_campania As Integer
        Get
            Return _cod_DetCampania
        End Get
        Set(value As Integer)
            _cod_DetCampania = value
        End Set
    End Property
End Class
