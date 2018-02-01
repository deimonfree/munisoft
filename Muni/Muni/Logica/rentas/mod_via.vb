Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_via
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetVia As New DataSet
    Public _dtwVia As New DataView
    Public _DatasetNomViaBox As New DataSet
    Sub consulta_datos_via_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from via", _conexion)
            _conectorMysql.Fill(_DatasetVia)
            _dtwVia.Table = _DatasetVia.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'consulta para llenado de combox
    Sub consulta_datos_via_combox_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from via", _conexion)
            _conectorMysql.Fill(_DatasetNomViaBox, "via")
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'consulta para llenado de combox por valor
    Sub consulta_datos_via_combox(ByRef codigo_via As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from via where idvia= @valor", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_via
            _conectorMysql.Fill(_DatasetNomViaBox, "via")
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'cargar datos sector
    Sub cargar_datos_via(ByVal idvia As Integer, ByVal datos_via As class_datos_via)
        _DatasetSector.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from via where idvia= @idVia", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idVia", MySqlDbType.Int32).Value = idvia
            _conectorMysql.Fill(_DatasetVia)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetVia.Tables(0).Rows
                datos_via.id_via = row("idvia")
                datos_via.nombre_via = row("nombre")
                datos_via.tipo_via = row("tipo")
                datos_via.cuadra_via = row("cuadras")
                datos_via.codSector_via = row("cod_sector")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
    End Sub
    'ultimo registro sector
    Public Function codigo_via() As Integer
        conex_Global()
        _conectorMysql.SelectCommand = New MySqlCommand("SELECT MAX(idvia)+1 idvia FROM via ", _conexion)
        '_conectorMysql.SelectCommand.Parameters.Add("@idPredio", MySqlDbType.Int32).Value = idpredio
        _conexion.Open()
        _conectorMysql.SelectCommand.Connection = _conexion
        Return _conectorMysql.SelectCommand.ExecuteScalar()
    End Function
    'consulta para llenado de combox por valor
    Sub consulta_datos_via_combox_by(ByRef codigo_sector As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from via where cod_sector= @valor", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_sector
            _conectorMysql.Fill(_DatasetNomViaBox, "via")
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    Public Function codigo_via(ByVal nombre_via As String) As Integer
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select  cuadras from via where nombre= @nomVia ", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@nomVia", MySqlDbType.VarChar, 45).Value = nombre_via
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            Return _conectorMysql.SelectCommand.ExecuteScalar()
        Catch ex As Exception

        End Try
    End Function
    'consulta vias por sector
    Sub consulta_datos_via_combox_bySector(ByRef codigo_sector As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from  via where cod_sector = @valor", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@valor", MySqlDbType.Int32).Value = codigo_sector
            _conectorMysql.Fill(_DatasetNomViaBox, "via")
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
End Module
