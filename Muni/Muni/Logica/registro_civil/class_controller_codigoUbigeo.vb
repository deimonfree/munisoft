Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_codigoUbigeo
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetUbig As New DataSet
    Public Function insertarDatosUbigeoDep(ByVal datos_UbiDep As class_datos_ubigeoDepartamento) As Boolean
        Dim estado As Boolean = True
        Try
            conex_registroCivil()
            _adaptador.InsertCommand = New MySqlCommand("insert into ubigeo_departamento (id,nombre) values (@id,@nombre)", _conexion_registroCivil)
            _adaptador.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_UbiDep.id_ubigeoDepartamento
            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_UbiDep.nombre_ubigeoDepartamento
            _conexion_registroCivil.Open()
            _adaptador.InsertCommand.Connection = _conexion_registroCivil
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar_registroCivil()
        End Try
        Return estado
    End Function
    Public Function insertarDatosUbigeoPro(ByVal datos_UbiPro As class_datos_ubigeoProvincia) As Boolean
        Dim estado As Boolean = True
        Try
            conex_registroCivil()
            _adaptador.InsertCommand = New MySqlCommand("insert into ubigeo_provincia (id,nombre,cod_departamento) values (@id,@nombre,@codDepartamento)", _conexion_registroCivil)
            _adaptador.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_UbiPro.id_ubigeoProvincia
            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_UbiPro.nombre_ubigeoProvincia
            _adaptador.InsertCommand.Parameters.Add("@codDepartamento", MySqlDbType.Int32).Value = datos_UbiPro.codDep_ubigeoProvincia
            _conexion_registroCivil.Open()
            _adaptador.InsertCommand.Connection = _conexion_registroCivil
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar_registroCivil()
        End Try
        Return estado
    End Function
    Public Function insertarDatosUbigeoDis(ByVal datos_UbiDis As class_datos_ubigeoDistrito) As Boolean
        Dim estado As Boolean = True
        Try
            conex_registroCivil()
            _adaptador.InsertCommand = New MySqlCommand("insert into ubigeo_distrito (id,nombre,cod_provincia) values (@id,@nombre,@codDistrito)", _conexion_registroCivil)
            _adaptador.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_UbiDis.id_ubigeoDistrito
            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_UbiDis.nombre_ubigeoDistrito
            _adaptador.InsertCommand.Parameters.Add("@codDistrito", MySqlDbType.Int32).Value = datos_UbiDis.codPro_ubigeoDistrito
            _conexion_registroCivil.Open()
            _adaptador.InsertCommand.Connection = _conexion_registroCivil
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar_registroCivil()
        End Try
        Return estado
    End Function
End Class
