Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_regimen
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetTiporegimen As New DataSet
    Public _dtwTiporegimen As New DataView
    Public _DatasetTiporegimenBox As New DataSet
    'consulta para llenado de combox por valor
    Sub consulta_datos_tipoRegimen_combox(ByRef codigo_tipoRegimen As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from regimen where idregimen= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.String).Value = codigo_tipoRegimen
            _adaptador.Fill(_DatasetTiporegimenBox, "regimen")
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
    Sub consulta_datos_tipoRegimen_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from regimen", _conexion)
            _adaptador.Fill(_DatasetTiporegimenBox, "regimen")
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
