Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_representanteLegal
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetRepresentanteLegal As New DataSet
    Public Function insertarRepresentantelegal(ByVal datos_representanteLegal As class_datos_representanteLegal) As Boolean
        Dim estado As Boolean
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into representante_legal(nombre,ape_paterno,ape_materno, cod_identificacion, numero_identificacion, cod_tipovia, nombre_via, numero,manzana,lote,nombre_apartamento,numero_apartamento, cod_urbanizacion, nombre_urbanizacion, cod_contribuyente,cargo,telefono) values(@nombre,@apepat, @apemat,@tipodoc,@numdoc,@tipovia,@nomvia,@numero,@mzna,@lote,@nomdepa,@numdepa,@codurb,@nomurb,@codcontri,@cargo,@telefono)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.nombre_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@apepat", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.apePat_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@apemat", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.apeMat_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@tipodoc", MySqlDbType.Int32).Value = datos_representanteLegal.codidentificacion_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@numdoc", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.numeroDoc_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@tipovia", MySqlDbType.Int32).Value = datos_representanteLegal.codVia_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@nomvia", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.nomVia_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@numero", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.numero_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@mzna", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.manzana_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@lote", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.lote_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@nomdepa", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.nomApart_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@numdepa", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.numApart_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@codurb", MySqlDbType.Int32).Value = datos_representanteLegal.codUrbanizacion_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@nomurb", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.nomUrbanizacion_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@codcontri", MySqlDbType.Int32).Value = datos_representanteLegal.codContribuyente_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@cargo", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.cargo_representanteLegal
            _adaptador.InsertCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.telefono_representanteLegal
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

    Public Function actualizarRepresentantelegal(ByRef datos_representanteLegal As class_datos_representanteLegal) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE `munisystem`.`representante_legal` SET `nombre`=@nombre, `ape_paterno`=@apepat, `ape_materno`=@apemat, `cod_identificacion`=@tipodoc, `numero_identificacion`=@numdoc , `cod_tipovia`=@tipovia, `nombre_via`=@nomvia, `numero`=@numero, `manzana`=@mzna, `lote`=@lote, `nombre_apartamento`=@nomdepa, `numero_apartamento`=@numdepa, `cod_urbanizacion`=@codurb, `nombre_urbanizacion`=@nomurb, `cod_contribuyente`=@codcontri, `cargo`=@cargo, `telefono`=@telefono WHERE `idrepresentante_legal`=@id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_representanteLegal.id_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.nombre_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@apepat", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.apePat_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@apemat", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.apeMat_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@tipodoc", MySqlDbType.Int32).Value = datos_representanteLegal.codidentificacion_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@numdoc", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.numeroDoc_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@tipovia", MySqlDbType.Int32).Value = datos_representanteLegal.codVia_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@nomvia", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.nomVia_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@numero", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.numero_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@mzna", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.manzana_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@lote", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.lote_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@nomdepa", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.nomApart_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@numdepa", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.numApart_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@codurb", MySqlDbType.Int32).Value = datos_representanteLegal.codUrbanizacion_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@nomurb", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.nomUrbanizacion_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@codcontri", MySqlDbType.Int32).Value = datos_representanteLegal.codContribuyente_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@cargo", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.cargo_representanteLegal
            _adaptador.UpdateCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 45).Value = datos_representanteLegal.telefono_representanteLegal
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
    Public Function eliminarRepresentantelegal(ByVal datos_representanteLegal As class_datos_representanteLegal) As Boolean
        Dim estado As Boolean = True

        Try
            conex_Global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from representante_legal where idrepresentante_legal= @id", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_representanteLegal.id_representanteLegal
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
