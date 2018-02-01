Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_sector
    Private _conectorMysql As New MySqlDataAdapter
    Private _DataSetSector As New DataSet
    'insercion de datos sector
    Public Function insertarDatosSector(ByVal datos_sector As class_datos_sector) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.InsertCommand = New MySqlCommand("insert into sector(idsector,nombre,cod_zona) values(@id,@nombre,@codigozona)", _conexion)
            _conectorMysql.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_sector.id_sector
            _conectorMysql.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_sector.nombre_sector
            _conectorMysql.InsertCommand.Parameters.Add("@codigozona", MySqlDbType.Int32).Value = datos_sector.codZona_sector
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
    ' actualizacion de datos sector
    Public Function actualizarDatosZona(ByRef datos_sector As class_datos_sector) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.UpdateCommand = New MySqlCommand("update sector set nombre=@nombre, cod_zona=@codigozona where idsector=@id", _conexion)
            _conectorMysql.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_sector.id_sector
            _conectorMysql.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_sector.nombre_sector
            _conectorMysql.UpdateCommand.Parameters.Add("@codigozona", MySqlDbType.Int32).Value = datos_sector.codZona_sector
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

    ' eliminacion de datos de sector
    Public Function eliminarDatosZona(ByRef datos_sector As class_datos_sector) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.DeleteCommand = New MySqlCommand("delete from sector where idsector=@id", _conexion)
            _conectorMysql.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_sector.id_sector
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
