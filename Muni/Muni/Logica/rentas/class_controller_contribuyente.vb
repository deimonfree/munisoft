Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_contribuyente
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetContribuyente As New DataSet
    Public ultimoContribuyente As Integer

    Public Function insertarDatosContibuyente(ByVal datos_contribuyente As class_datos_contribuyente) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into contribuyente (numero_doc, ape_paterno, ape_materno, nombres, telefono, celular, email, cont_relacion,observacion, cod_tipodoc, cod_urbanizacion, cod_relacion,razon_social,ruc) values (@numdoc, @apepat, @apemat, @nom, @tel,@cel, @email,@contrela,@observ,@codtipocod,@codtipourb,@codtiporela,@razonSocial,@ruc)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@numdoc", MySqlDbType.VarChar, 45).Value = datos_contribuyente.numero_doc_cont
            _adaptador.InsertCommand.Parameters.Add("apepat", MySqlDbType.VarChar, 45).Value = datos_contribuyente.apellido_paterno_cont
            _adaptador.InsertCommand.Parameters.Add("@apemat", MySqlDbType.VarChar, 45).Value = datos_contribuyente.apellido_materno_cont
            _adaptador.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45).Value = datos_contribuyente.nombres_cont
            _adaptador.InsertCommand.Parameters.Add("@tel", MySqlDbType.VarChar, 45).Value = datos_contribuyente.telefono_cont
            _adaptador.InsertCommand.Parameters.Add("@cel", MySqlDbType.VarChar, 45).Value = datos_contribuyente.celular_cont
            _adaptador.InsertCommand.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = datos_contribuyente.email_contn
            _adaptador.InsertCommand.Parameters.Add("@contrela", MySqlDbType.VarChar, 45).Value = datos_contribuyente.cont_relacion_cont
            _adaptador.InsertCommand.Parameters.Add("@observ", MySqlDbType.VarChar, 45).Value = datos_contribuyente.observacion_cont
            _adaptador.InsertCommand.Parameters.Add("@codtipocod", MySqlDbType.Int32).Value = datos_contribuyente.cod_tipo_doc
            _adaptador.InsertCommand.Parameters.Add("@codtipourb", MySqlDbType.Int32).Value = datos_contribuyente.cod_urbanizacion_cont
            _adaptador.InsertCommand.Parameters.Add("@codtiporela", MySqlDbType.Int32).Value = datos_contribuyente.cod_relacion_cont
            _adaptador.InsertCommand.Parameters.Add("@razonSocial", MySqlDbType.VarChar, 45).Value = datos_contribuyente.razonSocial_cont
            _adaptador.InsertCommand.Parameters.Add("@ruc", MySqlDbType.VarChar, 11).Value = datos_contribuyente.ruc_cont
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            'obteniendo el ultimo registro

            _adaptador.SelectCommand = New MySqlCommand("SELECT DISTINCT LAST_INSERT_ID() as recc FROM contribuyente", _conexion)
            _adaptador.Fill(_DataSetContribuyente)
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
            For Each row In _DataSetContribuyente.Tables(0).Rows
                datos_contribuyente.id_contribuyente = row(0)

            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function actualizarDatoContribuyente(ByRef datos_contribuyente As class_datos_contribuyente) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("update  contribuyente set numero_doc=@numdoc,ape_paterno=@apepat,ape_materno=@apemat,nombres=@nom,telefono=@tel,celular=@cel,email=@email,cont_relacion=@contrela,razon_social=@razonSocial,ruc=@ruc,observacion=@observ,cod_tipodoc=@codtipodoc,cod_urbanizacion=@codtipourb,cod_relacion=@codtiporela
where idcontribuyente=@id;", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_contribuyente.id_contribuyente
            _adaptador.UpdateCommand.Parameters.Add("@numdoc", MySqlDbType.VarChar, 45).Value = datos_contribuyente.numero_doc_cont
            _adaptador.UpdateCommand.Parameters.Add("@apepat", MySqlDbType.VarChar, 45).Value = datos_contribuyente.apellido_paterno_cont
            _adaptador.UpdateCommand.Parameters.Add("@apemat", MySqlDbType.VarChar, 45).Value = datos_contribuyente.apellido_materno_cont
            _adaptador.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45).Value = datos_contribuyente.nombres_cont
            _adaptador.UpdateCommand.Parameters.Add("@tel", MySqlDbType.VarChar, 45).Value = datos_contribuyente.telefono_cont
            _adaptador.UpdateCommand.Parameters.Add("@cel", MySqlDbType.VarChar, 45).Value = datos_contribuyente.celular_cont
            _adaptador.UpdateCommand.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = datos_contribuyente.email_contn
            _adaptador.UpdateCommand.Parameters.Add("@contrela", MySqlDbType.VarChar, 45).Value = datos_contribuyente.cont_relacion_cont
            _adaptador.UpdateCommand.Parameters.Add("@observ", MySqlDbType.VarChar, 45).Value = datos_contribuyente.observacion_cont
            _adaptador.UpdateCommand.Parameters.Add("@codtipodoc", MySqlDbType.Int32).Value = datos_contribuyente.cod_tipo_doc
            _adaptador.UpdateCommand.Parameters.Add("@codtipourb", MySqlDbType.Int32).Value = datos_contribuyente.cod_urbanizacion_cont
            _adaptador.UpdateCommand.Parameters.Add("@codtiporela", MySqlDbType.Int32).Value = datos_contribuyente.cod_relacion_cont
            _adaptador.UpdateCommand.Parameters.Add("@razonSocial", MySqlDbType.VarChar, 45).Value = datos_contribuyente.razonSocial_cont
            _adaptador.UpdateCommand.Parameters.Add("@ruc", MySqlDbType.VarChar, 11).Value = datos_contribuyente.ruc_cont
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
    Public Function eliminarDatosContibuyente(ByVal datos_contribuyente As class_datos_contribuyente) As Boolean
        Dim estado As Boolean = True

        Try
            conex_Global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from contribuyente where idcontribuyente= @id", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_contribuyente.id_contribuyente
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
