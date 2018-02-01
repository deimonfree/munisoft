Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_log_autovaluo
    Private _adaptador As New MySqlDataAdapter
    Public Function insertarDatosLogAutovaluo(ByVal datos_log_autovaluo As class_datos_log_autovaluo) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into log_autovaluo(user,namepc,ip,fecha,base,annio,cod_contri) values(@user,@namepc,@ip,@fecha,@base,@annio,@cod_contri)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@user", MySqlDbType.VarChar, 70).Value = datos_log_autovaluo.user
            _adaptador.InsertCommand.Parameters.Add("@namepc", MySqlDbType.VarChar, 45).Value = datos_log_autovaluo.namepc
            _adaptador.InsertCommand.Parameters.Add("@ip", MySqlDbType.VarChar, 45).Value = datos_log_autovaluo.ip
            _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.VarChar, 45).Value = datos_log_autovaluo.fecha
            _adaptador.InsertCommand.Parameters.Add("@base", MySqlDbType.VarChar, 45).Value = datos_log_autovaluo.base
            _adaptador.InsertCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = datos_log_autovaluo.annio
            _adaptador.InsertCommand.Parameters.Add("@cod_contri", MySqlDbType.Int32).Value = datos_log_autovaluo.cod_contri
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

