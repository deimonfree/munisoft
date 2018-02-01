Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_tipoFicha
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetTipoFicha As New DataSet
    Public _dtwDeclaracionJuarada As New DataView
    Public _DatasetTipoFichaBox As New DataSet
    'consulta para llenado de combox
    Sub consulta_datos_tipoFicha_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_ficha", _conexion)
            _adaptador.Fill(_DatasetTipoFichaBox, "tipo_ficha")
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
    Sub consulta_datos_tipoFicha_combox(ByRef codigo_ficha As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_ficha where idtipo_ficha= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_ficha
            _adaptador.Fill(_DatasetTipoFichaBox, "tipo_ficha")
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
