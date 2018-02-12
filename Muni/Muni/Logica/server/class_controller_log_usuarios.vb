Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_log_usuarios
    Private _adaptador As New MySqlDataAdapter

    Public Function insertarDatosLogUsuarios(ByVal datos_log_usuario As class_datos_log_login) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into log_usuarios(user,namepc,fecha,ip) values(@user,@namepc,@fecha,@ip)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@user", MySqlDbType.VarChar, 70).Value = datos_log_usuario.user
            _adaptador.InsertCommand.Parameters.Add("@namepc", MySqlDbType.VarChar, 45).Value = datos_log_usuario.namepc
            _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.VarChar, 45).Value = datos_log_usuario.fecha
            _adaptador.InsertCommand.Parameters.Add("@ip", MySqlDbType.VarChar, 45).Value = datos_log_usuario.ip
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
End Class
