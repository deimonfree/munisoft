Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_fraccionamiento
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetConstruccion As New DataSet
    Public ultimoConstruccion As Integer
    Public Function insertarDatosFraccionamiento(ByVal datos_fraccionamiento As class_datos_fraccionamiento) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into fraccionamiento(idfraccionamiento, periodo, fecha_vencimiento, monto_insoluto, derecho_emision, monto_total,estado_fraccionamiento,automatizacion_valor, cod_autovaluo) values(@idfrac,@periodo,@fven,@m_insoluto,@d_emision,@monto_total,@e_frac,@auto,@cod_autovaluo)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@idfrac", MySqlDbType.VarChar, 45).Value = datos_fraccionamiento.id_fraccionamiento
            _adaptador.InsertCommand.Parameters.Add("@periodo", MySqlDbType.VarChar, 45).Value = datos_fraccionamiento.periodo_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@fven", MySqlDbType.VarChar, 45).Value = datos_fraccionamiento.fecha_vencimiento_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@m_insoluto", MySqlDbType.Decimal).Value = datos_fraccionamiento.monto_insoluto_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@d_emision", MySqlDbType.Decimal).Value = datos_fraccionamiento.derecho_emision_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@monto_total", MySqlDbType.Decimal).Value = datos_fraccionamiento.monto_total_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@e_frac", MySqlDbType.VarChar, 45).Value = datos_fraccionamiento.estado_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@auto", MySqlDbType.Decimal).Value = datos_fraccionamiento.automatizacion_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@cod_autovaluo", MySqlDbType.Int32).Value = datos_fraccionamiento.cod_autovaluo
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

End Class
