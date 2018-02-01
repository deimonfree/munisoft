Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_valor_minimo
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetMinimo As New DataSet
    Public _dtwMinimo As New DataView
    Sub consulta_datos_valor_minimo(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from  valor_minimo where annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetMinimo)
            _dtwMinimo.Table = _DatasetMinimo.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_valor_minimo_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idvalor_minimo as CODIGO, valor as VALOR_MINIMO, annio as AÑO  from  valor_minimo", _conexion)
            _conectorMysql.Fill(_DatasetMinimo)
            _dtwMinimo.Table = _DatasetMinimo.Tables(0)
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
