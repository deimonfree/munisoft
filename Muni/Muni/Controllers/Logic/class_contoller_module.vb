Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_contoller_module
    Private _adaptador As New MySqlDataAdapter
    Private _dtsModulo As New DataSet
    Public total_Modulo As New Integer
    Private lectura As New Integer
    Public Function validation_module(ByVal UserId As Integer) As Integer()
        Dim arrTemp() As Integer ' -- Array temporal 
        conex_Global()
        _dtsModulo.Reset()
        _adaptador.SelectCommand = New MySqlCommand("select * from detalle_modulo where cod_user=@codigo_usuario", _conexion)
        _adaptador.SelectCommand.Parameters.Add("@codigo_usuario", MySqlDbType.Int32).Value = UserId
        _adaptador.Fill(_dtsModulo)
        ' -- Redimensionar el arreglo para llenar algunos datos ( 100 números aleatorios)  
        ReDim arrTemp(_dtsModulo.Tables(0).Rows.Count)
        total_Modulo = _dtsModulo.Tables(0).Rows.Count
        Dim row
        lectura = 0
        For Each row In _dtsModulo.Tables(0).Rows
            arrTemp(lectura) = row("cod_modulo")
            lectura += 1
        Next
        ' -- Retornar el array a la función  
        validation_module = arrTemp
        ' -- Eliminar el array temporal  
        Erase arrTemp
    End Function
    Public Function activate_module(ByVal IdModule As Integer) As Boolean
        Dim modulo As Integer
        Dim estado As String
        conex_Global()
        _dtsModulo.Reset()
        _adaptador.SelectCommand = New MySqlCommand("select * from modulo where idmodulo=@codigo_modulo", _conexion)
        _adaptador.SelectCommand.Parameters.Add("@codigo_modulo", MySqlDbType.String).Value = IdModule
        _adaptador.Fill(_dtsModulo)
        modulo = _dtsModulo.Tables(0).Rows.Count
        If modulo > 0 Then
            Dim row
            For Each row In _dtsModulo.Tables(0).Rows
                estado = row("estado")
                If estado = "activo" Then
                    Return True
                Else
                    Return False
                End If
            Next
        End If
        Return False
    End Function
    Public Function all_module() As Integer
        Dim modulo As Integer
        conex_Global()
        _dtsModulo.Reset()
        _adaptador.SelectCommand = New MySqlCommand("select * from modulo", _conexion)
        _adaptador.Fill(_dtsModulo)
        modulo = _dtsModulo.Tables(0).Rows.Count
        Return modulo
    End Function
End Class
