Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_tipoUrbanizacion
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetTipoUrbanizacion As New DataSet
    Public _dtwTipoUrbanizacion As New DataView
    Public _DatasetTipoUrbanizacionBox, _DatasetTipoUrbanizacionBox2 As New DataSet
    'consulta para llenado de combox por valor
    Sub consulta_datos_tipoUrbanizacion_combox_by(ByRef codigo_tipoUrb As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_urbanizacion where idtipo_urbanizacion= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_tipoUrb
            _adaptador.Fill(_DatasetTipoUrbanizacionBox, "tipo_urbanizacion")
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
    Sub consulta_datos_tipoUrbanizacion_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_urbanizacion", _conexion)
            _adaptador.Fill(_DatasetTipoUrbanizacionBox, "tipo_urbanizacion")
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
    Sub consulta_datos_tipoUrbanizacion_combox_by2(ByRef codigo_tipoUrb As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_urbanizacion where idtipo_urbanizacion= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_tipoUrb
            _adaptador.Fill(_DatasetTipoUrbanizacionBox2, "tipo_urbanizacion")
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
    Sub consulta_datos_tipoUrbanizacion_combox_all2()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_urbanizacion", _conexion)
            _adaptador.Fill(_DatasetTipoUrbanizacionBox2, "tipo_urbanizacion")
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
