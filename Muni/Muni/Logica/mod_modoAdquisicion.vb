Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_modoAdquisicion
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetModoAdq As New DataSet
    Public _dtwModoAdq As New DataView
    Public _DatasetModoAdqBox As New DataSet
    'consulta para llenado de combox por valor
    Sub consulta_datos_modoAdq_combox(ByRef cod_adq As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from modo_adq where idmodo_adq= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.String).Value = cod_adq
            _adaptador.Fill(_DatasetModoAdqBox, "modo_adq")
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
    Sub consulta_datos_modoAdq_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from modo_adq", _conexion)
            _adaptador.Fill(_DatasetModoAdqBox, "modo_adq")
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
