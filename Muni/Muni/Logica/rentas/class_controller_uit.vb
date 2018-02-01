Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_uit
    Private _conectorMysql As New MySqlDataAdapter
    Private _DataSetUit As New DataSet
    'insercion de datos via
    Public Function insertarDatosUit(ByVal datos_uit As class_datos_uit) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.InsertCommand = New MySqlCommand("insert into uit(valor_uit,annio) values(@val,@annio)", _conexion)
            _conectorMysql.InsertCommand.Parameters.Add("@val", MySqlDbType.Decimal).Value = datos_uit.val_uit
            _conectorMysql.InsertCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = datos_uit.annio
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
    Public Function actualizarDatosUit(ByRef datos_uit As class_datos_uit) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.UpdateCommand = New MySqlCommand("update uit set valor_uit=@val, annio=@annio where iduit=@id", _conexion)
            _conectorMysql.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_uit.id_uit
            _conectorMysql.UpdateCommand.Parameters.Add("@val", MySqlDbType.Decimal).Value = datos_uit.val_uit
            _conectorMysql.UpdateCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = datos_uit.annio
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
    Public Function eliminarDatosUit(ByRef datos_uit As class_datos_uit) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.DeleteCommand = New MySqlCommand("delete from uit where iduit=@id", _conexion)
            _conectorMysql.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_uit.id_uit
            _conexion.Open()
            _conectorMysql.DeleteCommand.Connection = _conexion
            _conectorMysql.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
End Class
