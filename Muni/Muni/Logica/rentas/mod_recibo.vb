Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_recibo
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetRecibo, _DatasetRecibo2 As New DataSet
    Public _dtwRecibo, _dtwRecibo2 As New DataView
    Sub consulta_ultimo_recibo()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from recibo  order by idrecibo desc limit 1", _conexion)
            _conectorMysql.Fill(_DatasetRecibo)
            'For Each row In _DatasetDistrito.Tables(0).Rows
            '    datos_Distrito.id_distrito = row("iddistrito")
            '    datos_Distrito.nombre_distrito = row("nombre")
            '    datos_Distrito.cod_provincia = row("cod_provincia")
            'Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Sub consulta_recibo_canje(ByVal cod As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from recibo where cod_autovaluo=" + cod, _conexion)
            _conectorMysql.Fill(_DatasetRecibo)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_recibo_contribuyente(ByVal cod As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from recibo inner join autovaluo on autovaluo.idautovaluo=recibo.cod_autovaluo where cod_autovaluo=" + cod, _conexion)
            _conectorMysql.Fill(_DatasetRecibo2)
            _dtwRecibo2.Table = _DatasetRecibo2.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    '##############################################################################################
    Sub consulta_recibo_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from recibo where fecha_pago!=''", _conexion)
            _conectorMysql.Fill(_DatasetRecibo)
            _dtwRecibo.Table = _DatasetRecibo.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_recibo_like(ByVal fecha As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from recibo where fecha_pago like '" + fecha + "%'", _conexion)
            _conectorMysql.Fill(_DatasetRecibo)
            _dtwRecibo.Table = _DatasetRecibo.Tables(0)
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
