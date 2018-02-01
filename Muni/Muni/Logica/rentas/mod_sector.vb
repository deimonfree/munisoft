Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_sector
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetSector, _DatasetSectorBox As New DataSet
    Public _dtwSector As New DataView
    Sub consulta_datos_sector_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from sector", _conexion)
            _conectorMysql.Fill(_DatasetSector)
            _dtwSector.Table = _DatasetSector.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'consulta de la de sector por idzona
    Sub consulta_datos_sector_by(ByVal dato As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from sector where cod_zona=@idzona", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idzona", MySqlDbType.Int32).Value = dato
            _conectorMysql.Fill(_DatasetSector)
            _dtwSector.Table = _DatasetSector.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    'consulta de de relacion de zona por id
    Sub zona_By(ByVal datos_zona As class_datos_zonaa, ByVal dato As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from zona where idzona =" + dato + "", _conexion)
            _conectorMysql.Fill(_DatasetSector)
            For Each row In _DatasetSector.Tables(0).Rows
                datos_zona.id_zona = row("idzona")
                datos_zona.nombre_zona = row("nombre")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'llenado de combobox all
    Sub combox_sector_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from sector ORDER BY idsector desc", _conexion)
            _conectorMysql.Fill(_DatasetSectorBox, "sector")
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'llenado de combox por by
    Sub combox_sector_by(ByRef codigo_sector As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from sector where idsector = @idSector", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idSector", MySqlDbType.String).Value = codigo_sector
            _conectorMysql.Fill(_DatasetSectorBox, "sector")
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'consulta de sector by
    Sub sector_By(ByVal dato As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select via.idvia, tipo_via.nom_tipovia, via.nombre, via.cuadras from via inner join tipo_via on via.tipo = tipo_via.idtipo_via
where cod_sector = " + dato + "", _conexion)
            _conectorMysql.Fill(_DatasetSector)
            _dtwSector.Table = _DatasetSector.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'cargar datos sector
    Sub cargar_datos_sector(ByVal idsector As Integer, ByVal datos_sector As class_datos_sector)
        _DatasetSector.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from sector where idsector= @idSector", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idSector", MySqlDbType.Int32).Value = idsector
            _conectorMysql.Fill(_DatasetSector)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetSector.Tables(0).Rows
                datos_sector.id_sector = row("idsector")
                datos_sector.nombre_sector = row("nombre")
                datos_sector.codZona_sector = row("cod_zona")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
    End Sub
    'ultimo registro sector
    Public Function codigo_sector() As Integer
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT MAX(idsector)+1 idsector FROM sector ", _conexion)
            '_conectorMysql.SelectCommand.Parameters.Add("@idPredio", MySqlDbType.Int32).Value = idpredio
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            Return _conectorMysql.SelectCommand.ExecuteScalar()
        Catch ex As Exception

        End Try
    End Function
    ' tipo de sector
    Public Function tipo_sector(ByVal idzona As Integer) As Integer
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select zona.idzona from sector inner join zona on sector.cod_zona=zona.idzona where sector.idsector=@idzona ", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idzona", MySqlDbType.Int32).Value = idzona
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            Return _conectorMysql.SelectCommand.ExecuteScalar()
        Catch ex As Exception

        End Try
    End Function

End Module
