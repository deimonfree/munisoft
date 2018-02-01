Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_tipoVia
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetTipovia As New DataSet
    Public _dtwTipovia As New DataView
    Public _DatasetViaBox2 As New DataSet
    Public _DatasetViaBox As New DataSet
    'consulta para llenado de combox
    Sub consulta_datos_tipovia_combox_all2()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_via ", _conexion)
            _adaptador.Fill(_DatasetViaBox2, "tipo_via")
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
    Sub consulta_datos_tipovia_combox2(ByRef codigo_via As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_via where idtipo_via= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_via
            _adaptador.Fill(_DatasetViaBox2, "tipo_via")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    Sub consulta_datos_tipovia_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_via ", _conexion)
            _adaptador.Fill(_DatasetViaBox, "tipo_via")
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
    Sub consulta_datos_tipovia_combox(ByRef codigo_via As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_via where idtipo_via= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_via
            _adaptador.Fill(_DatasetViaBox, "tipo_via")
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
