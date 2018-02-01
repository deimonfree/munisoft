Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_recibo
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetRecibo As New DataSet
    Public _dtwRecibo As New DataView
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
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
End Module
