Public Class Cliente_mensajes
#Region "VARIABLES"

#End Region
#Region "EVENTOS"
    Public Event Datosibox(ByVal datos As String)
#End Region
#Region "METODOS"
    Public Sub inbox(ByVal dato As String)
        RaiseEvent Datosibox(dato)
    End Sub
#End Region
End Class
