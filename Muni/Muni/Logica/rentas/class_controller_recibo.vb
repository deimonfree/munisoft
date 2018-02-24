Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_recibo
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetConstruccion As New DataSet
    Public ultimoConstruccion As Integer

    Public Function insertarDatosRecibo(ByVal datos_recibo As class_datos_recibo) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into recibo(forma_pago, monto_recibo, fecha_vencimiento, fecha_pago, estado,automatizacion,cod_autovaluo,fecha_creacion,estado_campanias,estado_mora) values(@f_pago,@m_recibo,@f_venc,@fe_pago,@estado,@auto,@cod,@fecha_creacion,@e_campania,@e_moras)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@f_pago", MySqlDbType.VarChar, 45).Value = datos_recibo.forma_pago
            _adaptador.InsertCommand.Parameters.Add("@m_recibo", MySqlDbType.VarChar, 45).Value = datos_recibo.monto_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@f_venc", MySqlDbType.VarChar, 45).Value = datos_recibo.fecha_vencimiento
            _adaptador.InsertCommand.Parameters.Add("@fe_pago", MySqlDbType.VarChar, 45).Value = datos_recibo.fecha_pago
            _adaptador.InsertCommand.Parameters.Add("@estado", MySqlDbType.VarChar, 45).Value = datos_recibo.estado_recibo
            _adaptador.InsertCommand.Parameters.Add("@auto", MySqlDbType.VarChar, 45).Value = datos_recibo.automatizacion_recibo
            _adaptador.InsertCommand.Parameters.Add("@cod", MySqlDbType.Int32).Value = datos_recibo.cod_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@fecha_creacion", MySqlDbType.TinyText).Value = datos_recibo.fecha_creacion
            _adaptador.InsertCommand.Parameters.Add("@e_campania", MySqlDbType.TinyText).Value = datos_recibo.estado_campania
            _adaptador.InsertCommand.Parameters.Add("@e_moras", MySqlDbType.TinyText).Value = datos_recibo.estado_moras
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

    Public Function actualizarDatosRecibo(ByRef datos_recibo As class_datos_recibo) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("update recibo set fecha_pago=@fecha_pago, estado=@estado where idrecibo=@id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_recibo.id_recibo
            _adaptador.UpdateCommand.Parameters.Add("@fecha_pago", MySqlDbType.VarChar, 45).Value = datos_recibo.fecha_pago
            _adaptador.UpdateCommand.Parameters.Add("@estado", MySqlDbType.VarChar, 45).Value = datos_recibo.estado_recibo
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
    Public Function actualizarDatosRecibo2(ByRef datos_recibo As class_datos_recibo) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("update recibo set estado_campanias=@estado_campanias, estado_mora=@estado_mora where idrecibo=@id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_recibo.id_recibo
            _adaptador.UpdateCommand.Parameters.Add("@estado_campanias", MySqlDbType.TinyText).Value = datos_recibo.estado_campania
            _adaptador.UpdateCommand.Parameters.Add("@estado_mora", MySqlDbType.TinyText).Value = datos_recibo.estado_moras
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
End Class
