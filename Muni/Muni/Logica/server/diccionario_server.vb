Module diccionario_server
    Public Sub modulo_server(ByVal modulo As String)
        Dim opcionMostrarMensaje As String
        opcionMostrarMensaje = "ningun Mensaje"
        If modulo = "Rentas" Then
            opcionMostrarMensaje = "Actualizar Recibo"
        End If
    End Sub

End Module
