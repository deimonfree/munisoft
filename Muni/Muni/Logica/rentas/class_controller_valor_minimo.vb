Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_valor_minimo
    Private _conectorMysql As New MySqlDataAdapter
    Private _DataSetValorMinimo As New DataSet
    'insercion de datos via
    Public Function insertarDatosValorMinimo(ByVal datos_valor_minimo As class_datos_valor_minimo) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.InsertCommand = New MySqlCommand("insert into valor_minimo(valor,annio) values(@val,@annio)", _conexion)
            _conectorMysql.InsertCommand.Parameters.Add("@val", MySqlDbType.Decimal).Value = datos_valor_minimo.val_minimo
            _conectorMysql.InsertCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = datos_valor_minimo.annio
            _conexion.Open()
            _conectorMysql.InsertCommand.Connection = _conexion
            _conectorMysql.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
    ' actualizacion de datos via
    Public Function actualizarDatosValorMinimo(ByRef datos_valor_minimo As class_datos_valor_minimo) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.UpdateCommand = New MySqlCommand("update valor_minimo set valor=@val where annio=@annio", _conexion)
            _conectorMysql.UpdateCommand.Parameters.Add("@val", MySqlDbType.Decimal).Value = datos_valor_minimo.val_minimo
            _conectorMysql.UpdateCommand.Parameters.Add("@annio", MySqlDbType.Decimal).Value = datos_valor_minimo.annio
            _conexion.Open()
            _conectorMysql.UpdateCommand.Connection = _conexion
            _conectorMysql.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    ' eliminacion de datos de via
    'Public Function eliminarDatosUit(ByRef datos_uit As class_datos_uit) As Boolean
    '    Dim estado As Boolean = True
    '    Try
    '        conex_Global()
    '        _conectorMysql.DeleteCommand = New MySqlCommand("delete from uit where iduit=@id", _conexion)
    '        _conectorMysql.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_uit.id_uit
    '        _conexion.Open()
    '        _conectorMysql.DeleteCommand.Connection = _conexion
    '        _conectorMysql.DeleteCommand.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        estado = False
    '    Finally
    '        cerrar()
    '    End Try
    '    Return estado
    'End Function
End Class
