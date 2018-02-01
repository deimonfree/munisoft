Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_grupo_catastral
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetGrupoCatastral As New DataSet
    Public ultimoContribuyente As Integer
    '    Public Function insertarDatosGrupoCatastral(ByVal datos_grupoCatastral As class_datos_grupo_catastral) As Boolean
    '        Dim estado As Boolean = True
    '        Try
    '            conex_Global()
    '            _adaptador.InsertCommand = New MySqlCommand("insert into contribuyente (numero_doc, ape_paterno, ape_materno, nombres, telefono, celular, email, cont_relacion,observacion, cod_tipodoc, cod_regimen, cod_relacion) values (@numdoc, @apepat, @apemat, @nom, @tel,@cel, @email,@contrela,@observ,@codtipocod,@codtiporeg,@codtiporela)", _conexion)
    '            _adaptador.InsertCommand.Parameters.Add("@numdoc", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.numero_doc_cont
    '            _adaptador.InsertCommand.Parameters.Add("apepat", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.apellido_paterno_cont
    '            _adaptador.InsertCommand.Parameters.Add("@apemat", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.apellido_materno_cont
    '            _adaptador.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.nombres_cont
    '            _adaptador.InsertCommand.Parameters.Add("@tel", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.telefono_cont
    '            _adaptador.InsertCommand.Parameters.Add("@cel", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.celular_cont
    '            _adaptador.InsertCommand.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.email_contn
    '            _adaptador.InsertCommand.Parameters.Add("@contrela", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.cont_relacion_cont
    '            _adaptador.InsertCommand.Parameters.Add("@observ", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.observacion_cont
    '            _adaptador.InsertCommand.Parameters.Add("@codtipocod", MySqlDbType.Int32).Value = datos_grupoCatastral.cod_tipo_doc
    '            _adaptador.InsertCommand.Parameters.Add("@codtiporeg", MySqlDbType.Int32).Value = datos_grupoCatastral.cod_regimen_cont
    '            _adaptador.InsertCommand.Parameters.Add("@codtiporela", MySqlDbType.Int32).Value = datos_grupoCatastral.cod_relacion_cont
    '            _conexion.Open()
    '            _adaptador.InsertCommand.Connection = _conexion
    '            _adaptador.InsertCommand.ExecuteNonQuery()
    '            'obteniendo el ultimo registro

    '            _adaptador.SelectCommand = New MySqlCommand("SELECT DISTINCT LAST_INSERT_ID() as recc FROM contribuyente", _conexion)
    '            _adaptador.Fill(_DataSetGrupoCatastral)
    '            _adaptador.SelectCommand.Connection = _conexion
    '            _adaptador.SelectCommand.ExecuteNonQuery()
    '            For Each row In _DataSetGrupoCatastral.Tables(0).Rows
    '                datos_grupoCatastral.id_contribuyente = row(0)

    '            Next

    '        Catch ex As MySqlException
    '            MessageBox.Show(ex.Message)
    '            estado = False
    '        Finally
    '            cerrar()
    '        End Try
    '        Return estado
    '    End Function

    '    Public Function actualizarDatoContribuyente(ByRef datos_grupoCatastral As class_datos_grupo_catastral) As Boolean
    '        Dim estado As Boolean = True
    '        Try
    '            conex_Global()
    '            '_adaptador.UpdateCommand = New MySqlCommand("update  contribuyente set numero_doc=@numdoc,ape_paterno=@apepat,ape_materno=@apemat,nombres=@nom,telefono=@tel,celular=@cel,email=@email,cont_relacion=@contrela',observacion=@observ,cod_tipodoc=@codtipodoc,cod_regimen=@codtiporeg,cod_relacion=@codtiporela where idcontribuyente=@id;", _conexion)
    '            _adaptador.UpdateCommand = New MySqlCommand("update  contribuyente set numero_doc=@numdoc,ape_paterno=@apepat,ape_materno=@apemat,nombres=@nom,telefono=@tel,celular=@cel,email=@email,cont_relacion=@contrela,observacion=@observ,cod_tipodoc=@codtipodoc,cod_regimen=@codtiporeg,cod_relacion=@codtiporela
    'where idcontribuyente=@id;", _conexion)
    '            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_grupoCatastral.id_contribuyente
    '            _adaptador.UpdateCommand.Parameters.Add("@numdoc", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.numero_doc_cont
    '            _adaptador.UpdateCommand.Parameters.Add("@apepat", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.apellido_paterno_cont
    '            _adaptador.UpdateCommand.Parameters.Add("@apemat", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.apellido_materno_cont
    '            _adaptador.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.nombres_cont
    '            _adaptador.UpdateCommand.Parameters.Add("@tel", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.telefono_cont
    '            _adaptador.UpdateCommand.Parameters.Add("@cel", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.celular_cont
    '            _adaptador.UpdateCommand.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.email_contn
    '            _adaptador.UpdateCommand.Parameters.Add("@contrela", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.cont_relacion_cont
    '            _adaptador.UpdateCommand.Parameters.Add("@observ", MySqlDbType.VarChar, 45).Value = datos_grupoCatastral.observacion_cont
    '            _adaptador.UpdateCommand.Parameters.Add("@codtipodoc", MySqlDbType.Int32).Value = datos_grupoCatastral.cod_tipo_doc
    '            _adaptador.UpdateCommand.Parameters.Add("@codtiporeg", MySqlDbType.Int32).Value = datos_grupoCatastral.cod_regimen_cont
    '            _adaptador.UpdateCommand.Parameters.Add("@codtiporela", MySqlDbType.Int32).Value = datos_grupoCatastral.cod_relacion_cont
    '            _conexion.Open()
    '            _adaptador.UpdateCommand.Connection = _conexion
    '            _adaptador.UpdateCommand.ExecuteNonQuery()
    '        Catch ex As MySqlException
    '            MessageBox.Show(ex.Message)
    '            estado = False
    '        Finally
    '            cerrar()
    '        End Try
    '        Return estado
    '    End Function
    '    Public Function eliminarDatosContibuyente(ByVal datos_contribuyente As class_datos_grupo_catastral) As Boolean
    '        Dim estado As Boolean = True

    '        Try
    '            conex_Global()
    '            _adaptador.DeleteCommand = New MySqlCommand("delete from contribuyente where idcontribuyente= @id", _conexion)
    '            _adaptador.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_contribuyente.id_contribuyente
    '            _conexion.Open()
    '            _adaptador.DeleteCommand.Connection = _conexion
    '            _adaptador.DeleteCommand.ExecuteNonQuery()
    '        Catch ex As MySqlException
    '            MessageBox.Show(ex.Message)
    '            estado = False
    '        Finally
    '            cerrar()
    '        End Try
    '        Return estado
    '    End Function

End Class
