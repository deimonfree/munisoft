Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_construcciones
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetConstruccion As New DataSet
    Public ultimoConstruccion As Integer
    Public Function insertarDatosConstrucciones(ByVal datos_const As class_datos_construcciones) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO `munisystem`.`construccion` (`piso`, `antiguedad`, `codigo_clasificacion`, `clasificacion`, `codigo-material`, `material`, `codigo_estadoconservacion`, `estado_conservacion`,`categoria`, `valor_unitario`, `inc_5x100`, `x100_dep`, `val_dep`, `val_unidaddep`, `area_construida`, `total`, `cod_ficha`,`predio`) VALUES (@piso, @antiguedad, @codClasi, @clasi, @codMat, @mat, @codEstConsv, @estConsv,@categoria, @valUnit, @inc, @dep, @valDep, @valUnitDep, @areaConst, @total, @codFicha,@predio)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@piso", MySqlDbType.Int32).Value = datos_const.piso_construccion
            _adaptador.InsertCommand.Parameters.Add("@antiguedad", MySqlDbType.Int32).Value = datos_const.antiguedad_construccion
            _adaptador.InsertCommand.Parameters.Add("@codClasi", MySqlDbType.Int32).Value = datos_const.codClasificacion_construccion
            _adaptador.InsertCommand.Parameters.Add("@clasi", MySqlDbType.VarChar, 45).Value = datos_const.clasificacion_construccion
            _adaptador.InsertCommand.Parameters.Add("@codMat", MySqlDbType.Int32).Value = datos_const.codMaterial_construccion
            _adaptador.InsertCommand.Parameters.Add("@mat", MySqlDbType.VarChar, 45).Value = datos_const.material_construccion
            _adaptador.InsertCommand.Parameters.Add("@codEstConsv", MySqlDbType.Int32).Value = datos_const.codEstConserv_construccion
            _adaptador.InsertCommand.Parameters.Add("@estConsv", MySqlDbType.VarChar, 45).Value = datos_const.estConserv_construccion
            _adaptador.InsertCommand.Parameters.Add("@categoria", MySqlDbType.VarChar, 45).Value = datos_const.categoria_construccion
            _adaptador.InsertCommand.Parameters.Add("@valUnit", MySqlDbType.Double).Value = datos_const.valorUnitario_construccion
            _adaptador.InsertCommand.Parameters.Add("@inc", MySqlDbType.Double).Value = datos_const.inc5x100_construccion
            _adaptador.InsertCommand.Parameters.Add("@dep", MySqlDbType.Double).Value = datos_const.x100_dep_construccion
            _adaptador.InsertCommand.Parameters.Add("@valDep", MySqlDbType.Double).Value = datos_const.valDepreciacion_construccion
            _adaptador.InsertCommand.Parameters.Add("@valUnitDep", MySqlDbType.Double).Value = datos_const.valUnitDep_construccion
            _adaptador.InsertCommand.Parameters.Add("@areaConst", MySqlDbType.Double).Value = datos_const.areaConst_construccion
            _adaptador.InsertCommand.Parameters.Add("@total", MySqlDbType.Double).Value = datos_const.total_construccion
            _adaptador.InsertCommand.Parameters.Add("@codFicha", MySqlDbType.Int32).Value = datos_const.cod_ficha_construccion
            _adaptador.InsertCommand.Parameters.Add("@predio", MySqlDbType.VarChar, 45).Value = datos_const.predio_construccion
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

    Public Function actualizarDatosConstrucciones(ByRef datos_const As class_datos_construcciones) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE `munisystem`.`construccion` SET  `piso`=@piso, `antiguedad`=@antiguedad, `codigo_clasificacion`=@codClasi, `clasificacion`=@clasi, `codigo-material`=@codMat, `material`=@mat, `codigo_estadoconservacion`=@codEstConsv, `estado_conservacion`=@estConsv, `categoria`=@categoria, `valor_unitario`=@valUnit, `inc_5x100`=@inc, `x100_dep`=@dep, `val_dep`=@valDep, `val_unidaddep`=@valUnitDep, `area_construida`=@areaConst, `total`=@total, `cod_ficha`=@codFicha, `predio`=@predio WHERE `idconstruccion`=@idConst", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@idConst", MySqlDbType.Int32).Value = datos_const.id_construccion
            _adaptador.UpdateCommand.Parameters.Add("@piso", MySqlDbType.Int32).Value = datos_const.piso_construccion
            _adaptador.UpdateCommand.Parameters.Add("@antiguedad", MySqlDbType.Int32).Value = datos_const.antiguedad_construccion
            _adaptador.UpdateCommand.Parameters.Add("@codClasi", MySqlDbType.Int32).Value = datos_const.codClasificacion_construccion
            _adaptador.UpdateCommand.Parameters.Add("@clasi", MySqlDbType.VarChar, 45).Value = datos_const.clasificacion_construccion
            _adaptador.UpdateCommand.Parameters.Add("@codMat", MySqlDbType.Int32).Value = datos_const.codMaterial_construccion
            _adaptador.UpdateCommand.Parameters.Add("@mat", MySqlDbType.VarChar, 45).Value = datos_const.material_construccion
            _adaptador.UpdateCommand.Parameters.Add("@codEstConsv", MySqlDbType.Int32).Value = datos_const.codEstConserv_construccion
            _adaptador.UpdateCommand.Parameters.Add("@estConsv", MySqlDbType.VarChar, 45).Value = datos_const.estConserv_construccion
            _adaptador.UpdateCommand.Parameters.Add("@categoria", MySqlDbType.VarChar, 45).Value = datos_const.categoria_construccion
            _adaptador.UpdateCommand.Parameters.Add("@valUnit", MySqlDbType.Double).Value = datos_const.valorUnitario_construccion
            _adaptador.UpdateCommand.Parameters.Add("@inc", MySqlDbType.Double).Value = datos_const.inc5x100_construccion
            _adaptador.UpdateCommand.Parameters.Add("@dep", MySqlDbType.Double).Value = datos_const.x100_dep_construccion
            _adaptador.UpdateCommand.Parameters.Add("@valDep", MySqlDbType.Double).Value = datos_const.valDepreciacion_construccion
            _adaptador.UpdateCommand.Parameters.Add("@valUnitDep", MySqlDbType.Double).Value = datos_const.valUnitDep_construccion
            _adaptador.UpdateCommand.Parameters.Add("@areaConst", MySqlDbType.Double).Value = datos_const.areaConst_construccion
            _adaptador.UpdateCommand.Parameters.Add("@total", MySqlDbType.Double).Value = datos_const.total_construccion
            _adaptador.UpdateCommand.Parameters.Add("@codFicha", MySqlDbType.Int32).Value = datos_const.cod_ficha_construccion
            _adaptador.UpdateCommand.Parameters.Add("@predio", MySqlDbType.VarChar, 45).Value = datos_const.predio_construccion
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
    Public Function eliminarDatosConstrucciones(ByVal datos_const As class_datos_construcciones) As Boolean
        Dim estado As Boolean = True

        Try
            conex_Global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from construccion where idconstruccion= @id", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_const.id_construccion
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
