Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_predio
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetPredio As New DataSet
    Public _dtwPredio As New DataView
    Public _DatatablePredio As New DataTable
    Sub consulta_datos_predio_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from predio", _conexion)
            _conectorMysql.Fill(_DatasetPredio)
            _dtwPredio.Table = _DatasetPredio.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_predio_by(ByVal cont As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from predio where cod_contribuyente=@cod", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@cod", MySqlDbType.Int32).Value = cont
            _conectorMysql.Fill(_DatasetPredio)
            _dtwPredio.Table = _DatasetPredio.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Sub cargar_datos_predio(ByVal idPredio As Integer, ByVal datos_predio As class_datos_predio)
        _DatasetPredio.Reset()
        Try
            conex_Global()

            _conectorMysql.SelectCommand = New MySqlCommand("select * from predio where idpredio= @idPredio", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idPredio", MySqlDbType.Int32).Value = idPredio
            _conectorMysql.Fill(_DatasetPredio)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetPredio.Tables(0).Rows
                datos_predio.id_predio = row("idpredio")
                datos_predio.codVia_predio = row("cod_via")
                datos_predio.numero_predio = row("numero")
                datos_predio.ensisoNum_predio = row("ensiso_numeracion")
                datos_predio.cuadra_predio = row("cuadra")
                datos_predio.nroLote_predio = row("nro_lote")
                datos_predio.cod_grupoCatastral_predio = row("cod_gc")
                datos_predio.cod_contribuyente_predio = row("cod_contribuyente")
                datos_predio.codSector_predio = row("cod_sector")
                datos_predio.colindaEste_predio = row("col_este")
                datos_predio.colindaOeste_predio = row("col_oeste")
                datos_predio.colindaNorte_predio = row("col_norte")
                datos_predio.colindaSur_predio = row("col_sur")

            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub
    'comprobar si existe valores en la cosnulta
    Public Function comprobar_predio(ByVal idpredio As Integer) As Integer
        conex_Global()
        _conectorMysql.SelectCommand = New MySqlCommand("select * from predio where idpredio= @idPredio", _conexion)
        _conectorMysql.SelectCommand.Parameters.Add("@idPredio", MySqlDbType.Int32).Value = idpredio
        _conexion.Open()
        _conectorMysql.SelectCommand.Connection = _conexion
        Return _conectorMysql.SelectCommand.ExecuteScalar()
        'Int result = Convert.ToInt32(cmd.ExecusteScalar());
        Return 0
    End Function
    Sub consulta_datos_predio_autovaluo(ByVal codContribuyente As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select predio.idpredio, via.nombre as via, predio.numero, predio.ensiso_numeracion, predio.cuadra, predio.nro_lote from via inner join predio on via.idvia= predio.cod_via where predio.cod_contribuyente = @cod", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@cod", MySqlDbType.Int32).Value = codContribuyente
            _conectorMysql.Fill(_DatasetPredio)
            _dtwPredio.Table = _DatasetPredio.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_predio_by_esquema(ByVal cont As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select predio.idpredio as 'Codigo de Predio', tipo_via.nom_tipovia as 'Tipo de Via', via.nombre as 'Nombre de Via',predio.cuadra as 'Cuadra', predio.numero as 'Numero' from predio inner join via on predio.cod_via = via.idvia inner join tipo_via on via.tipo = tipo_via.idtipo_via where predio.cod_contribuyente = @cod", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@cod", MySqlDbType.Int32).Value = cont
            _conectorMysql.Fill(_DatasetPredio)
            _dtwPredio.Table = _DatasetPredio.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
End Module
