Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_ficha
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetFicha As New DataSet
    Public _dtwFicha As New DataView
    Sub ficha_ByPredio(ByVal codPredio As String)
        Try
            _DatasetDistrito.Reset()
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idficha from  ficha where cod_predio =" + codPredio + "", _conexion)
            _conectorMysql.Fill(_DatasetDistrito)
            'For Each row In _DatasetDistrito.Tables(0).Rows
            '    datos_Distrito.id_distrito = row("iddistrito")
            '    datos_Distrito.nombre_distrito = row("nombre")
            '    datos_Distrito.cod_provincia = row("cod_provincia")
            'Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_ficha_by_predio(ByVal valor As Integer, ByVal anio As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from  ficha where cod_predio = @cod and anio_fecha = @anio", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@cod", MySqlDbType.Int32).Value = valor
            _conectorMysql.SelectCommand.Parameters.Add("@anio", MySqlDbType.Int32).Value = anio
            _conectorMysql.Fill(_DatasetFicha)
            _dtwFicha.Table = _DatasetFicha.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Public Function codigo_ficha() As Integer
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT MAX(idficha)+1 idficha FROM ficha ", _conexion)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            Return _conectorMysql.SelectCommand.ExecuteScalar()
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Sub cargar_datos_ficha(ByVal idFicha As Integer, ByVal datos_Ficha As class_datos_ficha)
        _DatasetContribuyente.Reset()
        Try
            conex_Global()

            _conectorMysql.SelectCommand = New MySqlCommand("select * from ficha where idficha= @idContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idContri", MySqlDbType.Int32).Value = idFicha
            _conectorMysql.Fill(_DatasetFicha)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetFicha.Tables(0).Rows
                datos_Ficha.id_ficha = row("idficha")
                datos_Ficha.codigo_ficha = row("codigo_ficha").ToString
                datos_Ficha.anno_ficha = row("anio_fecha").ToString
                datos_Ficha.numero_ficha = row("numero_ficha").ToString
                datos_Ficha.numero_djj_ficha = row("numero_ddjj").ToString
                datos_Ficha.arancel_ficha = row("arancel").ToString
                datos_Ficha.valor_ficha = row("valor").ToString
                datos_Ficha.condicion_titular_fichas = row("condicion_titular").ToString
                datos_Ficha.modo_adquisicion_ficha = row("modo_adq").ToString
                datos_Ficha.fecha_adquisicion_fichas = row("fecha_adq").ToString
                datos_Ficha.area_terreno_ficha = row("area_terreno")
                datos_Ficha.area_comun_ficha = row("area_comun")
                datos_Ficha.area_construida_fichas = row("area_construida")
                datos_Ficha.area_frentera_fichas = row("area_frentera").ToString
                datos_Ficha.uso_predial_ficha = row("uso_predial").ToString
                datos_Ficha.distancia_parque_ficha = row("distancia_parque").ToString
                datos_Ficha.numero_habitante_ficha = row("num_habitantes").ToString
                datos_Ficha.cod_predio = row("cod_predio").ToString
                datos_Ficha.cod_tipo_ficha = row("cod_tipoficha").ToString
                datos_Ficha.valorTerreno_ficha = row("valor_terreno").ToString
                datos_Ficha.valorConstruccion_ficha = row("valor_construccion").ToString
                datos_Ficha.baseImponible_ficha = row("base_imponible").ToString
                datos_Ficha.valorDeduccion_ficha = row("valor_deduccion").ToString
                datos_Ficha.tipoDeduccion_ficha = row("tipo_deducion").ToString
                datos_Ficha.totalBaseimpDeduccion_ficha = row("total_base_imponible").ToString
                datos_Ficha.estadoPredio_ficha = row("estado_predial").ToString
                datos_Ficha.tipoPredio_ficha = row("tipo_predial").ToString
                datos_Ficha.codDeduccion_ficha = row("cod_deduccion").ToString
            Next
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_ficha_by_idficha(ByVal codFicha As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from ficha where idficha=" + codFicha, _conexion)
            _conectorMysql.Fill(_DatasetFicha)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
        Catch ex As Exception
        End Try
    End Sub
End Module
