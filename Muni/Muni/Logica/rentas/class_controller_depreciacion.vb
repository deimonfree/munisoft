Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_depreciacion
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetClie As New DataSet
    Public Function insertarDatosDepreciacion(ByVal datos_dep As class_datos_depreciacion) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into depreciacion (cod_clasificacion,cod_antiguedad,cod_material,cod_conservacion,valor,anno) values (@codviv,@codant,@codmat,@codest,@valor,@anio)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@codviv", MySqlDbType.Int32).Value = datos_dep.clasificacion_depreciacion
            _adaptador.InsertCommand.Parameters.Add("@codant", MySqlDbType.Int32).Value = datos_dep.antiguedad_depreciacion
            _adaptador.InsertCommand.Parameters.Add("@codmat", MySqlDbType.Int32).Value = datos_dep.material_depreciacion
            _adaptador.InsertCommand.Parameters.Add("@codest", MySqlDbType.Int32).Value = datos_dep.conservacion_depreciacion
            _adaptador.InsertCommand.Parameters.Add("@valor", MySqlDbType.VarChar, 45).Value = datos_dep.valor_depreciacion
            _adaptador.InsertCommand.Parameters.Add("@anio", MySqlDbType.Int32).Value = datos_dep.annio_depreciacion
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

    Public Function actualizarDatoDepreciacion(ByRef datos_dep As class_datos_depreciacion) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("update depreciacion set valor=@valor where iddepreciacion=@id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_dep.id_depreciacion
            _adaptador.UpdateCommand.Parameters.Add("@valor", MySqlDbType.VarChar, 45).Value = datos_dep.valor_depreciacion
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
    Public Function eliminarDatosDepreciacion(ByVal datos_dep As class_datos_depreciacion) As Boolean
        Dim estado As Boolean = True

        Try
            conex_Global()
            _adaptador.DeleteCommand = New MySqlCommand("delete from cliente where idcliente=@id", _conexion)
            '_adaptador.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_dep.id_central
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
