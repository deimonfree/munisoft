Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_log_recibo
    Private _adaptador As New MySqlDataAdapter
    Public Function insertarDatosLogRecibos(ByVal datos_log_recibo As class_datos_log_recibo) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into log_recibos(user,namepc,ip,fecha,monto,cod_autovaluo) values(@user,@namepc,@ip,@fecha,@monto,@cod_autovaluo)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@user", MySqlDbType.VarChar, 70).Value = datos_log_recibo.user
            _adaptador.InsertCommand.Parameters.Add("@namepc", MySqlDbType.VarChar, 45).Value = datos_log_recibo.namepc
            _adaptador.InsertCommand.Parameters.Add("@ip", MySqlDbType.VarChar, 45).Value = datos_log_recibo.ip
            _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.VarChar, 45).Value = datos_log_recibo.fecha
            _adaptador.InsertCommand.Parameters.Add("@monto", MySqlDbType.VarChar, 45).Value = datos_log_recibo.monto
            _adaptador.InsertCommand.Parameters.Add("@cod_autovaluo", MySqlDbType.Int32).Value = datos_log_recibo.cod_autovaluo
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
