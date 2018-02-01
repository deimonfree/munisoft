Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_usoPredio
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetUsoPredio As New DataSet
    Public _dtwUsoPredio As New DataView
    Public _DatasetUsoPredioBox As New DataSet
    'consulta para llenado de combox
    Sub consulta_datos_usoPredio_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from uso_predio", _conexion)
            _adaptador.Fill(_DatasetUsoPredioBox, "uso_predio")
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
    Sub consulta_datos_usoPredio_combox(ByRef codigo_uso As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from uso_predio where iduso_predio= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_uso
            _adaptador.Fill(_DatasetUsoPredioBox, "uso_predio")
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
