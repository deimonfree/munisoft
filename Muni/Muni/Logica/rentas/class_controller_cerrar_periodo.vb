Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_cerrar_periodo
    Private _conectorMysql As New MySqlDataAdapter
    Private _DataSetVia As New DataSet
    'insercion de datos via
    Public Function insertarDatosCerrar(ByVal datos_cerrar As class_datos_cerrar_periodo) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.InsertCommand = New MySqlCommand("insert into cerrar_periodo(modulo,annio,estado) values(@modulo,@annio,@estado)", _conexion)
            _conectorMysql.InsertCommand.Parameters.Add("@modulo", MySqlDbType.VarChar, 45).Value = datos_cerrar.modulo_cerrar
            _conectorMysql.InsertCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = datos_cerrar.annio_cerrar
            _conectorMysql.InsertCommand.Parameters.Add("@estado", MySqlDbType.VarChar, 45).Value = datos_cerrar.estado_cerrar
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
    Public Function actualizarDatosCerrar(ByRef datos_cerrar As class_datos_cerrar_periodo) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.UpdateCommand = New MySqlCommand("update cerrar_periodo set estado=@estado where modulo=@modulo and annio=@annio", _conexion)
            _conectorMysql.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_cerrar.id_cerrar_periodo
            _conectorMysql.UpdateCommand.Parameters.Add("@modulo", MySqlDbType.VarChar, 45).Value = datos_cerrar.modulo_cerrar
            _conectorMysql.UpdateCommand.Parameters.Add("@annio", MySqlDbType.Int32).Value = datos_cerrar.annio_cerrar
            _conectorMysql.UpdateCommand.Parameters.Add("@estado", MySqlDbType.VarChar, 45).Value = datos_cerrar.estado_cerrar
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
    Public Function eliminarDatosCerrar(ByRef datos_cerrar As class_datos_cerrar_periodo) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.DeleteCommand = New MySqlCommand("delete from cerrar_periodo where idcerrar_periodo=@id", _conexion)
            _conectorMysql.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_cerrar.id_cerrar_periodo
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
