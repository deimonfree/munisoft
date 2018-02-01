Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_baseLegal
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetBaseLegal As New DataSet
    Public _dtwBaseLegal As New DataView
    Public _DatasetBaseLegalBox As New DataSet
    'consulta para llenado de combox por valor
    Sub consulta_datos_baseLegal_combox(ByRef cod_regExo As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from base_legal where cod_regExone = @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.String).Value = cod_regExo
            _adaptador.Fill(_DatasetBaseLegalBox, "base_legal")
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
    Sub consulta_datos_baseLegal_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from base_legal", _conexion)
            _adaptador.Fill(_DatasetBaseLegalBox, "base_legal")
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
