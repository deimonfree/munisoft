Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_TipoPredio
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetTipoPredio As New DataSet
    Public _dtwTipoPredio As New DataView
    Public _DatasetTipoPredioBox As New DataSet
    'consulta para llenado de combox
    Sub consulta_datos_tipoPredio_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_predio ", _conexion)
            _adaptador.Fill(_DatasetTipoPredioBox, "tipo_predio")
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
    Sub consulta_datos_tipoPredio_combox(ByRef codigo_tipo As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_predio where idtipo_predio= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_tipo
            _adaptador.Fill(_DatasetTipoPredioBox, "tipo_predio")
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
