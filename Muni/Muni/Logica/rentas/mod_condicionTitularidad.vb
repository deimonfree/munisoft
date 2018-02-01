Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_condicionTitularidad
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetConTitulo As New DataSet
    Public _dtwConTitulo As New DataView
    Public _DatasetConTituloBox As New DataSet
    'consulta para llenado de combox por valor
    Sub consulta_datos_condTitulo_combox(ByRef cod_titulo As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from condicion_titular where idcondicion_titular= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.String).Value = cod_titulo
            _adaptador.Fill(_DatasetConTituloBox, "condicion_titular")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'consulta para llenado de combox
    Sub consulta_datos_condTitulo_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from condicion_titular", _conexion)
            _adaptador.Fill(_DatasetConTituloBox, "condicion_titular")
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
