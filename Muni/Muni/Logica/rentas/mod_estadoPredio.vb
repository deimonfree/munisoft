Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_estadoPredio
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetEstadoPredio As New DataSet
    Public _dtwEstadoPredio As New DataView
    Public _DatasetEstadoPredioBox As New DataSet
    'consulta para llenado de combox
    Sub consulta_datos_estadoPredio_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from estado_predio ", _conexion)
            _adaptador.Fill(_DatasetEstadoPredioBox, "estado_predio")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'consulta para llenado de combox por valor
    Sub consulta_datos_estadoPredio_combox(ByRef codigo_estado As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from estado_predio where idestado_predio= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_estado
            _adaptador.Fill(_DatasetEstadoPredioBox, "estado_predio")
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
