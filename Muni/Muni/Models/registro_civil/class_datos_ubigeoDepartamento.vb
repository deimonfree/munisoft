﻿Public Class class_datos_ubigeoDepartamento
    Private _id As Integer
    Private _nombre As String
    Public Property id_ubigeoDepartamento() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property nombre_ubigeoDepartamento() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
