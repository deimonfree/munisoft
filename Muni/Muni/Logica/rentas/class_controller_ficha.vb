Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_ficha
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetFicha As New DataSet
    Public ultimoFicha As Integer
    Public Function insertarDatosContibuyente(ByVal datos_ficha As class_datos_ficha) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            ' _adaptador.InsertCommand = New MySqlCommand("insert into ficha(codigo_ficha, anio_fecha,numero_ficha,numero_ddjj, arancel, valor,condicion_titular, modo_adq, fecha_adq, area_terreno,area_comun,area_construida,area_frentera,uso_predial,distancia_parque,num_habitantes,cod_predio,cod_tipoficha,valor_terreno,valor_construccion,base_imponible,valor_deduccion,tipo_deduccion,total_base_imponible) values(@codFicha,@year, @numFicha, @numDDJJ,@arancel, @valor,@conTitural,@modoAdq,@fechaAdq,@areaTerreno,@areaComun,@areaConstruida,@areaFrentera,@usoPredial,@distParque,@numHab,@codPredio,@codTipoFicha,@valorTerreno,@valorConst,@baseImponible,@valorDeduccion,@tipoDeducion,@totalBaseimponible)", _conexion)
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO `munisystem`.`ficha` (`codigo_ficha`, `anio_fecha`, `numero_ficha`, `numero_ddjj`, `arancel`, `valor`, `condicion_titular`, `modo_adq`, `fecha_adq`, `area_terreno`, `area_comun`, `area_construida`, `area_frentera`, `uso_predial`, `distancia_parque`, `num_habitantes`, `cod_predio`, `cod_tipoficha`, `valor_terreno`, `valor_construccion`, `base_imponible`, `valor_deduccion`, `tipo_deducion`, `total_base_imponible`,`estado_predial`, `tipo_predial`, `cod_deduccion`) VALUES (@codFicha, @year, @numFicha, @numDDJJ, @arancel, @valor, @conTitural, @modoAdq, @fechaAdq, @areaTerreno, @areaComun, @areaConstruida, @areaFrentera, @usoPredial, @distParque, @numHab, @codPredio, @codTipoFicha, @valorTerreno, @valorConst, @baseImponible, @valorDeduccion, @tipoDeducion, @totalBaseimponible,@estadoPredial,@tipoPredial,@codDeduccion)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@codFicha", MySqlDbType.VarChar, 45).Value = datos_ficha.codigo_ficha
            _adaptador.InsertCommand.Parameters.Add("@year", MySqlDbType.Int32).Value = datos_ficha.anno_ficha
            _adaptador.InsertCommand.Parameters.Add("@numFicha", MySqlDbType.VarChar, 45).Value = datos_ficha.numero_ficha
            _adaptador.InsertCommand.Parameters.Add("@numDDJJ", MySqlDbType.VarChar, 45).Value = datos_ficha.numero_djj_ficha
            _adaptador.InsertCommand.Parameters.Add("@arancel", MySqlDbType.Double).Value = datos_ficha.arancel_ficha
            _adaptador.InsertCommand.Parameters.Add("@valor", MySqlDbType.Double).Value = datos_ficha.valor_ficha
            _adaptador.InsertCommand.Parameters.Add("@conTitural", MySqlDbType.VarChar, 45).Value = datos_ficha.condicion_titular_fichas
            _adaptador.InsertCommand.Parameters.Add("@modoAdq", MySqlDbType.VarChar, 45).Value = datos_ficha.modo_adquisicion_ficha
            _adaptador.InsertCommand.Parameters.Add("@fechaAdq", MySqlDbType.Date).Value = datos_ficha.fecha_adquisicion_fichas
            _adaptador.InsertCommand.Parameters.Add("@areaTerreno", MySqlDbType.Double).Value = datos_ficha.area_terreno_ficha
            _adaptador.InsertCommand.Parameters.Add("@areaComun", MySqlDbType.Double).Value = datos_ficha.area_comun_ficha
            _adaptador.InsertCommand.Parameters.Add("@areaConstruida", MySqlDbType.Double).Value = datos_ficha.area_construida_fichas
            _adaptador.InsertCommand.Parameters.Add("@areaFrentera", MySqlDbType.Double).Value = datos_ficha.area_frentera_fichas
            _adaptador.InsertCommand.Parameters.Add("@usoPredial", MySqlDbType.Int32).Value = datos_ficha.uso_predial_ficha
            _adaptador.InsertCommand.Parameters.Add("@distParque", MySqlDbType.Double).Value = datos_ficha.distancia_parque_ficha
            _adaptador.InsertCommand.Parameters.Add("@numHab", MySqlDbType.Int32).Value = datos_ficha.numero_habitante_ficha
            _adaptador.InsertCommand.Parameters.Add("@codPredio", MySqlDbType.Int32).Value = datos_ficha.cod_predio
            _adaptador.InsertCommand.Parameters.Add("@codTipoFicha", MySqlDbType.Int32).Value = datos_ficha.cod_tipo_ficha
            _adaptador.InsertCommand.Parameters.Add("@valorTerreno", MySqlDbType.Double).Value = datos_ficha.valorTerreno_ficha
            _adaptador.InsertCommand.Parameters.Add("@valorConst", MySqlDbType.Double).Value = datos_ficha.valorConstruccion_ficha
            _adaptador.InsertCommand.Parameters.Add("@baseImponible", MySqlDbType.Double).Value = datos_ficha.baseImponible_ficha
            _adaptador.InsertCommand.Parameters.Add("@valorDeduccion", MySqlDbType.Double).Value = datos_ficha.valorDeduccion_ficha
            _adaptador.InsertCommand.Parameters.Add("@tipoDeducion", MySqlDbType.VarChar, 45).Value = datos_ficha.tipoDeduccion_ficha
            _adaptador.InsertCommand.Parameters.Add("@totalBaseimponible", MySqlDbType.Double).Value = datos_ficha.totalBaseimpDeduccion_ficha
            _adaptador.InsertCommand.Parameters.Add("@estadoPredial", MySqlDbType.Int32).Value = datos_ficha.estadoPredio_ficha
            _adaptador.InsertCommand.Parameters.Add("@tipoPredial", MySqlDbType.Int32).Value = datos_ficha.tipoPredio_ficha
            _adaptador.InsertCommand.Parameters.Add("@codDeduccion", MySqlDbType.Int32).Value = datos_ficha.codDeduccion_ficha
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            'obteniendo el ultimo registro
            _adaptador.SelectCommand = New MySqlCommand("SELECT DISTINCT LAST_INSERT_ID() as recc FROM ficha", _conexion)
            _adaptador.Fill(_DataSetFicha)
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            For Each row In _DataSetFicha.Tables(0).Rows
                datos_ficha.id_ficha = row(0)
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function actualizarDatosFicha(ByRef datos_ficha As class_datos_ficha) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE `munisystem`.`ficha` Set `codigo_ficha`=@codFicha, `anio_fecha`=@year, `numero_ficha`=@numFicha, `numero_ddjj`=@numDDJJ, `arancel`=@arancel, `valor`=@valor, `condicion_titular`=@conTitural, `modo_adq`=@modoAdq, `fecha_adq`=@fechaAdq, `area_terreno`=@areaTerreno, `area_comun`=@areaComun, `area_construida`=@areaConstruida, `area_frentera`=@areaFrentera, `uso_predial`=@usoPredial, `distancia_parque`=@distParque, `num_habitantes`=@numHab, `cod_predio`=@codPredio, `cod_tipoficha`=@codTipoFicha, `valor_terreno`=@valorTerreno, `valor_construccion`=@valorConst, `base_imponible`=@baseImponible, `valor_deduccion`=@valorDeduccion, `tipo_deducion`=@tipoDeducion, `total_base_imponible`=@totalBaseimponible, `estado_predial`=@estadoPredial, `tipo_predial`=@tipoPredial, `cod_deduccion`=@codDeduccion WHERE `idficha`=@idFicha", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@idFicha", MySqlDbType.Int32).Value = datos_ficha.id_ficha
            _adaptador.UpdateCommand.Parameters.Add("@codFicha", MySqlDbType.VarChar, 45).Value = datos_ficha.codigo_ficha
            _adaptador.UpdateCommand.Parameters.Add("@year", MySqlDbType.Int32).Value = datos_ficha.anno_ficha
            _adaptador.UpdateCommand.Parameters.Add("@numFicha", MySqlDbType.VarChar, 45).Value = datos_ficha.numero_ficha
            _adaptador.UpdateCommand.Parameters.Add("@numDDJJ", MySqlDbType.VarChar, 45).Value = datos_ficha.numero_djj_ficha
            _adaptador.UpdateCommand.Parameters.Add("@arancel", MySqlDbType.Double).Value = datos_ficha.arancel_ficha
            _adaptador.UpdateCommand.Parameters.Add("@valor", MySqlDbType.Double).Value = datos_ficha.valor_ficha
            _adaptador.UpdateCommand.Parameters.Add("@conTitural", MySqlDbType.VarChar, 45).Value = datos_ficha.condicion_titular_fichas
            _adaptador.UpdateCommand.Parameters.Add("@modoAdq", MySqlDbType.VarChar, 45).Value = datos_ficha.modo_adquisicion_ficha
            _adaptador.UpdateCommand.Parameters.Add("@fechaAdq", MySqlDbType.Date).Value = datos_ficha.fecha_adquisicion_fichas
            _adaptador.UpdateCommand.Parameters.Add("@areaTerreno", MySqlDbType.Double).Value = datos_ficha.area_terreno_ficha
            _adaptador.UpdateCommand.Parameters.Add("@areaComun", MySqlDbType.Double).Value = datos_ficha.area_comun_ficha
            _adaptador.UpdateCommand.Parameters.Add("@areaConstruida", MySqlDbType.Double).Value = datos_ficha.area_construida_fichas
            _adaptador.UpdateCommand.Parameters.Add("@areaFrentera", MySqlDbType.Double).Value = datos_ficha.area_frentera_fichas
            _adaptador.UpdateCommand.Parameters.Add("@usoPredial", MySqlDbType.Int32).Value = datos_ficha.uso_predial_ficha
            _adaptador.UpdateCommand.Parameters.Add("@distParque", MySqlDbType.Double).Value = datos_ficha.distancia_parque_ficha
            _adaptador.UpdateCommand.Parameters.Add("@numHab", MySqlDbType.Int32).Value = datos_ficha.numero_habitante_ficha
            _adaptador.UpdateCommand.Parameters.Add("@codPredio", MySqlDbType.Int32).Value = datos_ficha.cod_predio
            _adaptador.UpdateCommand.Parameters.Add("@codTipoFicha", MySqlDbType.Int32).Value = datos_ficha.cod_tipo_ficha
            _adaptador.UpdateCommand.Parameters.Add("@valorTerreno", MySqlDbType.Double).Value = datos_ficha.valorTerreno_ficha
            _adaptador.UpdateCommand.Parameters.Add("@valorConst", MySqlDbType.Double).Value = datos_ficha.valorConstruccion_ficha
            _adaptador.UpdateCommand.Parameters.Add("@baseImponible", MySqlDbType.Double).Value = datos_ficha.baseImponible_ficha
            _adaptador.UpdateCommand.Parameters.Add("@valorDeduccion", MySqlDbType.Double).Value = datos_ficha.valorDeduccion_ficha
            _adaptador.UpdateCommand.Parameters.Add("@tipoDeducion", MySqlDbType.VarChar, 45).Value = datos_ficha.tipoDeduccion_ficha
            _adaptador.UpdateCommand.Parameters.Add("@totalBaseimponible", MySqlDbType.Double).Value = datos_ficha.totalBaseimpDeduccion_ficha
            _adaptador.UpdateCommand.Parameters.Add("@estadoPredial", MySqlDbType.Int32).Value = datos_ficha.estadoPredio_ficha
            _adaptador.UpdateCommand.Parameters.Add("@tipoPredial", MySqlDbType.Int32).Value = datos_ficha.tipoPredio_ficha
            _adaptador.UpdateCommand.Parameters.Add("@codDeduccion", MySqlDbType.Int32).Value = datos_ficha.codDeduccion_ficha
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
    Public Function eliminarDatosFicha(ByRef datos_ficha As class_datos_ficha) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from `munisystem`.`ficha` where `idficha`= @idFicha", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@idFicha", MySqlDbType.Int32).Value = datos_ficha.id_ficha
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
End Class
