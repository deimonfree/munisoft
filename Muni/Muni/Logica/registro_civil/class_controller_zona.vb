Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_zona
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetCiudadano As New DataSet
    'insercion de datos zona
    Public Function insertarDatosZona(ByVal datos_zona As class_datos_zonaa) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into zona(idzona,nombre) values(@id,@nombre)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_zona.id_zona
            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_zona.nombre_zona
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    ' actualizacion de datos zona
    Public Function actualizarDatosZona(ByRef datos_zona As class_datos_zonaa) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("update zona set nombre=@nombre where idzona=@id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_zona.id_zona
            _adaptador.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_zona.nombre_zona
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    ' eliminacion de datos de zona
    Public Function eliminarDatosZona(ByRef datos_zona As class_datos_zonaa) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from zona where idzona=@id", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_zona.id_zona
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
End Class
