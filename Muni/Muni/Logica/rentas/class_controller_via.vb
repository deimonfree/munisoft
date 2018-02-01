Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_via
    Private _conectorMysql As New MySqlDataAdapter
    Private _DataSetVia As New DataSet
    'insercion de datos via
    Public Function insertarDatosVia(ByVal datos_via As class_datos_via) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.InsertCommand = New MySqlCommand("insert into via(nombre,tipo,cuadras,cod_sector) values(@nombre,@tipo,@cuadra,@sector)", _conexion)
            _conectorMysql.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_via.nombre_via
            _conectorMysql.InsertCommand.Parameters.Add("@tipo", MySqlDbType.Int32).Value = datos_via.tipo_via
            _conectorMysql.InsertCommand.Parameters.Add("@cuadra", MySqlDbType.VarChar, 45).Value = datos_via.cuadra_via
            _conectorMysql.InsertCommand.Parameters.Add("@sector", MySqlDbType.VarChar, 45).Value = datos_via.codSector_via
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
    Public Function actualizarDatosVia(ByRef datos_via As class_datos_via) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.UpdateCommand = New MySqlCommand("update via set nombre=@nombre, tipo=@tipo, cuadras=@cuadra, cod_sector=@sector where idvia=@id", _conexion)
            _conectorMysql.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_via.id_via
            _conectorMysql.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_via.nombre_via
            _conectorMysql.UpdateCommand.Parameters.Add("@tipo", MySqlDbType.Int32).Value = datos_via.tipo_via
            _conectorMysql.UpdateCommand.Parameters.Add("@cuadra", MySqlDbType.VarChar, 45).Value = datos_via.cuadra_via
            _conectorMysql.UpdateCommand.Parameters.Add("@sector", MySqlDbType.VarChar, 45).Value = datos_via.codSector_via
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
    Public Function eliminarDatosVia(ByRef datos_via As class_datos_via) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.DeleteCommand = New MySqlCommand("delete from via where idvia=@id", _conexion)
            _conectorMysql.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_via.id_via
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
