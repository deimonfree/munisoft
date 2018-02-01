Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_ciudadano
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetCiudadano As New DataSet
    Public Function insertarDatosCiudadano(ByVal datos_UbiCiudadano As class_datos_zonas) As Boolean
        Dim estado As Boolean = True
        Try
            conex_registroCivil()
            _adaptador.InsertCommand = New MySqlCommand("insert into ciudadano (nombre,ape_paterno,ape_materno,tipo_doc,dni,nacionalidad,estado_civil,fecha_nac,centro_poblado,distrito) values (@nombre,@apepat,@apemat,@tipodoc,@dni,@nacionalidad,@estadocivil,@fechanac,@centropo,@distrito)", _conexion_registroCivil)
            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 45).Value = datos_UbiCiudadano.nombre_ciudadano
            _adaptador.InsertCommand.Parameters.Add("@apepat", MySqlDbType.VarChar, 45).Value = datos_UbiCiudadano.apePat_ciudadano
            _adaptador.InsertCommand.Parameters.Add("@apemat", MySqlDbType.VarChar, 45).Value = datos_UbiCiudadano.apeMat_ciudadano
            _adaptador.InsertCommand.Parameters.Add("@tipodoc", MySqlDbType.VarChar, 2).Value = datos_UbiCiudadano.tipoDoc_ciudadano
            _adaptador.InsertCommand.Parameters.Add("@dni", MySqlDbType.VarChar, 8).Value = datos_UbiCiudadano.dni_ciudadano
            _adaptador.InsertCommand.Parameters.Add("@nacionalidad", MySqlDbType.VarChar, 2).Value = datos_UbiCiudadano.nacionalidad_ciudadano
            _adaptador.InsertCommand.Parameters.Add("@estadocivil", MySqlDbType.VarChar, 45).Value = datos_UbiCiudadano.estadoCivil_ciudadano
            _adaptador.InsertCommand.Parameters.Add("@fechanac", MySqlDbType.Date).Value = datos_UbiCiudadano.fechaNac_ciudadano
            _adaptador.InsertCommand.Parameters.Add("@centropo", MySqlDbType.VarChar, 45).Value = datos_UbiCiudadano.centroPobla_ciudadano
            _adaptador.InsertCommand.Parameters.Add("@distrito", MySqlDbType.VarChar, 45).Value = datos_UbiCiudadano.distrito_ciudadano
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
