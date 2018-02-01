Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_fraccionamiento
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetFrac, _DatasetFrac2 As New DataSet
    Public _dtwFrac, _dtwFrac2 As New DataView
    Public _DatatableFrac As New DataTable
    Sub consulta_datos_fraccionamiento_autovaluo(ByVal cod As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from fraccionamiento where cod_autovaluo=" + cod, _conexion)
            _conectorMysql.Fill(_DatasetFrac)
            _dtwFrac.Table = _DatasetFrac.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Sub consulta_datos_fraccionamiento_by(ByVal cod As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from fraccionamiento where idfraccionamiento=" + cod, _conexion)
            _conectorMysql.Fill(_DatasetFrac2)
            _dtwFrac2.Table = _DatasetFrac2.Tables(0)
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
