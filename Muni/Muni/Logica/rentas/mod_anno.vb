Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_anno
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetAnnio As New DataSet
    Public _dtwAnnio As New DataView
    Public _DatatableAnnio As New DataTable
    Public _DatasetAnnioAll As New DataSet
    Sub consulta_datos_annio()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from  anno order by idanno desc", _conexion)
            _adaptador.Fill(_DatasetAnnio, "annio")
            _dtwAnnio.Table = _DatasetAnnio.Tables(0)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'consulta para llenado de combox all
    Sub consulta_datos_annio_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from anno order by idanno desc", _conexion)
            _adaptador.Fill(_DatasetAnnioAll, "anno")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'consulta para llenado de combox por año
    Sub consulta_datos_annio_by(ByVal idAnio As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from anno  where  idanno= @anio ", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@anio", MySqlDbType.Int32).Value = idAnio
            _adaptador.Fill(_DatasetAnnio, "anno")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
End Module
