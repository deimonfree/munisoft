Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_campania
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetCampania, _DatasetDetalleCampania As New DataSet
    Public _dtwCampania, _dtwDetalleCampania As New DataView
    Sub consulta_datos_campania_ultimo()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from campania order by idcampania desc limit 1", _conexion)
            _conectorMysql.Fill(_DatasetCampania)
            _dtwCampania.Table = _DatasetCampania.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_DetCampania_all(ByVal codCampania As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from detalle_campania where cod_campania=@cod", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@cod", MySqlDbType.Int32).Value = codCampania
            _conectorMysql.Fill(_DatasetDetalleCampania)
            _dtwDetalleCampania.Table = _DatasetDetalleCampania.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
End Module
