Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_direccion
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetDireccion As New DataSet
    Public Function insertarDatosDireccion(ByVal datos_Direccion_Contribuyente As class_datos_direccion) As Boolean
        Dim estado As Boolean
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into direccion_contribuyente(sector, manzana,via,lote,numero,departamento,piso,cod_contribuyente,cod_tipovia,cod_distrito) values(@sector,@manzana,@via,@lote,@numero,@depa,@piso,@cod_cont,@cod_tipovia,@cod_distrito)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@sector", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.sector_direccion
            _adaptador.InsertCommand.Parameters.Add("@manzana", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.mzna_direccion
            _adaptador.InsertCommand.Parameters.Add("@via", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.via_direccion
            _adaptador.InsertCommand.Parameters.Add("@lote", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.lote_direccion
            _adaptador.InsertCommand.Parameters.Add("@numero", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.numero_direccion
            _adaptador.InsertCommand.Parameters.Add("@depa", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.departamento_direccion
            _adaptador.InsertCommand.Parameters.Add("@piso", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.piso_direccion
            _adaptador.InsertCommand.Parameters.Add("@cod_cont", MySqlDbType.Int32).Value = datos_Direccion_Contribuyente.codContribuyente_direccion
            _adaptador.InsertCommand.Parameters.Add("@cod_tipovia", MySqlDbType.Int32).Value = 1
            _adaptador.InsertCommand.Parameters.Add("@cod_distrito", MySqlDbType.Int32).Value = datos_Direccion_Contribuyente.codDistrito_direccion
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function actualizarDatosDireccion(ByRef datos_Direccion_Contribuyente As class_datos_direccion) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE `munisystem`.`direccion_contribuyente` SET `sector`=@sector, `manzana`=@manzana, `via`= @via, `lote`= @lote, `numero`= @numero, `departamento`=@apart, `piso`=@piso, `cod_contribuyente`= @codContri,`cod_tipovia`=@codVia, `cod_distrito`=@codDist WHERE `iddireccion`=@id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_Direccion_Contribuyente.id_direccion
            _adaptador.UpdateCommand.Parameters.Add("@sector", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.sector_direccion
            _adaptador.UpdateCommand.Parameters.Add("@manzana", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.mzna_direccion
            _adaptador.UpdateCommand.Parameters.Add("@via", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.via_direccion
            _adaptador.UpdateCommand.Parameters.Add("@lote", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.lote_direccion
            _adaptador.UpdateCommand.Parameters.Add("@numero", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.numero_direccion
            _adaptador.UpdateCommand.Parameters.Add("@apart", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.departamento_direccion
            _adaptador.UpdateCommand.Parameters.Add("@piso", MySqlDbType.VarChar, 45).Value = datos_Direccion_Contribuyente.piso_direccion
            _adaptador.UpdateCommand.Parameters.Add("@codContri", MySqlDbType.Int32).Value = datos_Direccion_Contribuyente.codContribuyente_direccion
            _adaptador.UpdateCommand.Parameters.Add("@codVia", MySqlDbType.Int32).Value = datos_Direccion_Contribuyente.codTipoVia_direccion
            _adaptador.UpdateCommand.Parameters.Add("@codDist", MySqlDbType.Int32).Value = datos_Direccion_Contribuyente.codDistrito_direccion
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
    'Public Function eliminarDatosDireccion(ByVal datos_Direccion_Contribuyente As class_datos_direccion) As Boolean
    '    Dim estado As Boolean = True

    '    Try
    '        conex_Global()
    '        _adaptador.DeleteCommand = New MySqlCommand("delete from cliente where idcliente=@id", _conexion)
    '        _adaptador.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_Direccion_Contribuyente.id_central
    '        _conexion.Open()
    '        _adaptador.DeleteCommand.Connection = _conexion
    '        _adaptador.DeleteCommand.ExecuteNonQuery()

    '    Catch ex As MySqlException
    '        MessageBox.Show(ex.Message)
    '        estado = False
    '    Finally
    '        cerrar()
    '    End Try
    '    Return estado
    'End Function
End Class
