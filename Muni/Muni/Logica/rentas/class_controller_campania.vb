Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_campania
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetCampania As New DataSet
    Public Function insertarDatosCampania(ByVal datos_campania As class_datos_campania) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into campania(nombre,fecha_inicio,fecha_limite) values(@nombre,@finicio,@ffinal)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_campania.nombre_campania
            _adaptador.InsertCommand.Parameters.Add("@finicio", MySqlDbType.VarChar, 45).Value = datos_campania.fecha_inicio_campania
            _adaptador.InsertCommand.Parameters.Add("@ffinal", MySqlDbType.VarChar, 45).Value = datos_campania.fecha_final_campania
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
    Public Function actualizarDatosCampania(ByRef datos_campania As class_datos_campania) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE `munisystem`.`campania` Set `nombre`=@nombre, `fecha_limite`=@fecha_final WHERE `idcampania`=@idCampania", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@idCampania", MySqlDbType.Int32).Value = datos_campania.id_campania
            _adaptador.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_campania.nombre_campania
            _adaptador.UpdateCommand.Parameters.Add("@fecha_final", MySqlDbType.VarChar, 45).Value = datos_campania.fecha_final_campania
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
End Class
