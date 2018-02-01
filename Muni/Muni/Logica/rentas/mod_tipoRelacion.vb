Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_tipoRelacion
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetTiporelacion As New DataSet
    Public _dtwTiporelacion As New DataView
    Public _DatasetTiporelacionBox As New DataSet
    'consulta para llenado de combox por valor
    Sub consulta_datos_tipoRelacion_combox(ByRef codigo_tipoRela As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_relacion where idtipo_relacion= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_tipoRela
            _adaptador.Fill(_DatasetTiporelacionBox, "tipo_relacion")
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
    Sub consulta_datos_tipoRelacion_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_relacion", _conexion)
            _adaptador.Fill(_DatasetTiporelacionBox, "tipo_relacion")
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
