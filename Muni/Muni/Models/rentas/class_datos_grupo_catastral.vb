Public Class class_datos_grupo_catastral
    Private _idgrupo_catastral As Integer
    Private _cod_mzna As String
    Private _manzana As String
    Private _cod_sector As Integer

    Public Property idgrupo_catastral As Integer
        Get
            Return _idgrupo_catastral
        End Get
        Set(value As Integer)
            _idgrupo_catastral = value
        End Set
    End Property

    Public Property cod_mzna_catastral As String
        Get
            Return _cod_mzna
        End Get
        Set(value As String)
            _cod_mzna = value
        End Set
    End Property
    Public Property manzana_catastral As String
        Get
            Return _manzana
        End Get
        Set(value As String)
            _manzana = value
        End Set
    End Property
    Public Property cod_sector_catastral As Integer
        Get
            Return _cod_sector
        End Get
        Set(value As Integer)
            _cod_sector = value
        End Set
    End Property
End Class
