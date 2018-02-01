Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_zona
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetZona, _dtscbox As New DataSet
    Public _dtwZona As New DataView
    Public _DatasetZonaBox As New DataSet
    'consulta de todas las zonas
    Sub consulta_datos_zona_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from zona", _conexion)
            _adaptador.Fill(_DatasetZona)
            _dtwZona.Table = _DatasetZona.Tables(0)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'consulta de datos de zona por valor
    Sub consulta_datos_zona_detalle_by(ByRef dato_zona As String)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from zona where nombre= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.String).Value = dato_zona
            _adaptador.Fill(_DatasetZona)
            _dtwZona.Table = _DatasetZona.Tables(0)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'consulta de datos de zona por dinamico
    Sub consulta_datos_zona_detalle_by_dinamic(ByRef valor_dinamico As String)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM zona where nombre like '%" + valor_dinamico + "%'", _conexion)
            _adaptador.Fill(_DatasetZona)
            _dtwZona.Table = _DatasetZona.Tables(0)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'consulta para llenado de combox por valor
    Sub consulta_datos_zona_combox(ByRef codigo_zona As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from zona where idzona= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.String).Value = codigo_zona
            _adaptador.Fill(_DatasetZonaBox, "zona")
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
    Sub consulta_datos_zona_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from zona ", _conexion)
            _adaptador.Fill(_DatasetZonaBox, "zona")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'cargar datos zona
    Sub cargar_datos_zona(ByVal idZona As Integer, ByVal datos_zona As class_datos_zona)
        _DatasetContribuyente.Reset()
        Try
            conex_Global()

            _adaptador.SelectCommand = New MySqlCommand("select * from zona where idzona= @idZona", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@idZona", MySqlDbType.Int32).Value = idZona
            _adaptador.Fill(_DatasetContribuyente)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetContribuyente.Tables(0).Rows
                datos_zona.id_zona = row("idzona")
                datos_zona.nombre_zona = row("nombre")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub

End Module
