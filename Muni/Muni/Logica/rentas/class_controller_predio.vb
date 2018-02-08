Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_predio
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetPredio As New DataSet
    Public ultimoPredio As Integer

    Public Function insertarDatosPredio(ByVal datos_predio As class_datos_predio) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into predio (cod_via,numero,ensiso_numeracion,cuadra,nro_lote,cod_gc,cod_contribuyente,cod_sector,estado,col_este,col_oeste,col_norte,col_sur) values (@codVia,@numero,@ensisoNum,@cuadra,@nroLote,@codGrupoCatastral,@codContri,@codSector,@estado,@este,@oeste,@norte,@sur)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@codVia", MySqlDbType.Int32).Value = datos_predio.codVia_predio
            _adaptador.InsertCommand.Parameters.Add("@numero", MySqlDbType.VarChar, 45).Value = datos_predio.numero_predio
            _adaptador.InsertCommand.Parameters.Add("@ensisoNum", MySqlDbType.VarChar, 45).Value = datos_predio.ensisoNum_predio
            _adaptador.InsertCommand.Parameters.Add("@cuadra", MySqlDbType.VarChar, 45).Value = datos_predio.cuadra_predio
            _adaptador.InsertCommand.Parameters.Add("@nroLote", MySqlDbType.VarChar, 45).Value = datos_predio.nroLote_predio
            _adaptador.InsertCommand.Parameters.Add("@codContri", MySqlDbType.Int32).Value = datos_predio.cod_contribuyente_predio
            _adaptador.InsertCommand.Parameters.Add("@codGrupoCatastral", MySqlDbType.Int32).Value = datos_predio.cod_grupoCatastral_predio
            _adaptador.InsertCommand.Parameters.Add("@codSector", MySqlDbType.Int32).Value = datos_predio.codSector_predio
            _adaptador.InsertCommand.Parameters.Add("@estado", MySqlDbType.VarChar, 45).Value = datos_predio.estado_predio
            _adaptador.InsertCommand.Parameters.Add("@este", MySqlDbType.VarChar, 100).Value = datos_predio.colindaEste_predio
            _adaptador.InsertCommand.Parameters.Add("@oeste", MySqlDbType.VarChar, 100).Value = datos_predio.colindaOeste_predio
            _adaptador.InsertCommand.Parameters.Add("@norte", MySqlDbType.VarChar, 45).Value = datos_predio.colindaNorte_predio
            _adaptador.InsertCommand.Parameters.Add("@sur", MySqlDbType.VarChar, 45).Value = datos_predio.colindaSur_predio
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            'obteniendo el ultimo registro
            _adaptador.SelectCommand = New MySqlCommand("SELECT DISTINCT LAST_INSERT_ID() as recc FROM contribuyente", _conexion)
            _adaptador.Fill(_DataSetPredio)
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            For Each row In _DataSetPredio.Tables(0).Rows
                datos_predio.id_predio = row(0)
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function actualizarDatosPredio(ByRef datos_predio As class_datos_predio) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE `munisystem`.`predio` SET `cod_via`=@codVia, `ensiso_numeracion`=@ensiso, `cuadra`=@cuadra, `nro_lote`=@lote, `cod_gc`=@gc, `cod_contribuyente`=@contibuyente, `cod_sector`=@sector, `numero`=@numero, `estado`=@estado,`col_este`=@este, `col_oeste`=@oeste, `col_norte`=@norte, `col_sur`=@sur WHERE `idpredio`=@id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_predio.id_predio
            _adaptador.UpdateCommand.Parameters.Add("@codVia", MySqlDbType.Int32).Value = datos_predio.codVia_predio
            _adaptador.UpdateCommand.Parameters.Add("@numero", MySqlDbType.VarChar, 45).Value = datos_predio.numero_predio
            _adaptador.UpdateCommand.Parameters.Add("@ensiso", MySqlDbType.VarChar, 45).Value = datos_predio.ensisoNum_predio
            _adaptador.UpdateCommand.Parameters.Add("@cuadra", MySqlDbType.VarChar, 45).Value = datos_predio.cuadra_predio
            _adaptador.UpdateCommand.Parameters.Add("@lote", MySqlDbType.VarChar, 45).Value = datos_predio.nroLote_predio
            _adaptador.UpdateCommand.Parameters.Add("@gc", MySqlDbType.Int32).Value = datos_predio.cod_grupoCatastral_predio
            _adaptador.UpdateCommand.Parameters.Add("@contibuyente", MySqlDbType.Int32).Value = datos_predio.cod_contribuyente_predio
            _adaptador.UpdateCommand.Parameters.Add("@sector", MySqlDbType.Int32).Value = datos_predio.codSector_predio
            _adaptador.UpdateCommand.Parameters.Add("@estado", MySqlDbType.VarChar, 45).Value = datos_predio.estado_predio
            _adaptador.UpdateCommand.Parameters.Add("@este", MySqlDbType.VarChar, 100).Value = datos_predio.colindaEste_predio
            _adaptador.UpdateCommand.Parameters.Add("@oeste", MySqlDbType.VarChar, 100).Value = datos_predio.colindaOeste_predio
            _adaptador.UpdateCommand.Parameters.Add("@norte", MySqlDbType.VarChar, 45).Value = datos_predio.colindaNorte_predio
            _adaptador.UpdateCommand.Parameters.Add("@sur", MySqlDbType.VarChar, 45).Value = datos_predio.colindaSur_predio
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
    Public Function eliminarDatosPredio(ByVal datos_predio As class_datos_predio) As Boolean
        Dim estado As Boolean = True

        Try
            conex_Global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from predio where idpredio= @id", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_predio.id_predio
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
    Public Function actualizarDatosPredioBaja(ByVal codPredio As String, ByVal estadoPredio As String) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE `munisystem`.`predio` SET `estado`=@estadoPredio WHERE `idpredio`=@id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.VarChar, 45).Value = codPredio
            _adaptador.UpdateCommand.Parameters.Add("@estadoPredio", MySqlDbType.VarChar, 45).Value = estadoPredio
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
End Class
