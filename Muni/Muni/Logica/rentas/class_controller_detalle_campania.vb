Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_detalle_campania
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetDetCampania As New DataSet
    Public Function insertarDatosDetalleDetalleCampania(ByVal datos_DetCampania As class_datos_detalle_campania) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into detalle_campania(nombre,valor,tipo_rango,anio,cod_campania) values(@nombre, @valor,@tipo_rango,@anio,@cod_campania)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_DetCampania.nombre_DetCampania
            _adaptador.InsertCommand.Parameters.Add("@valor", MySqlDbType.Decimal).Value = datos_DetCampania.valor_DetCampania
            _adaptador.InsertCommand.Parameters.Add("@tipo_rango", MySqlDbType.VarChar, 45).Value = datos_DetCampania.tipo_rango_DetCampania
            _adaptador.InsertCommand.Parameters.Add("@anio", MySqlDbType.VarChar, 45).Value = datos_DetCampania.annio_DetCampania
            _adaptador.InsertCommand.Parameters.Add("@cod_campania", MySqlDbType.Int32).Value = datos_DetCampania.cod_campania
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
    Public Function actualizarDatosDetalleCampania(ByRef datos_Detcampania As class_datos_detalle_campania) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE `munisystem`.`detalle_campania` Set `valor`=@valor, `tipo_rango`=@tipo_rango, `anio`=@anio WHERE `iddetalle_campania`=@idDetCampania", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@idDetCampania", MySqlDbType.Int32).Value = datos_Detcampania.id_Detcampania
            _adaptador.UpdateCommand.Parameters.Add("@valor", MySqlDbType.VarChar, 45).Value = datos_Detcampania.valor_DetCampania
            _adaptador.UpdateCommand.Parameters.Add("@tipo_rango", MySqlDbType.VarChar, 45).Value = datos_Detcampania.tipo_rango_DetCampania
            _adaptador.UpdateCommand.Parameters.Add("@anio", MySqlDbType.VarChar, 45).Value = datos_Detcampania.annio_DetCampania
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
    Public Function eliminarDatosDetalleCampania(ByRef datos_Detcampania As class_datos_detalle_campania) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("delete from detalle_campania where `iddetalle_campania`=@idCampania", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@idCampania", MySqlDbType.Int32).Value = datos_Detcampania.id_Detcampania
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
