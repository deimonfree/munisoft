Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_serviciosBasicos
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetServiciosBasicos As New DataSet
    Public Function insertarDatosServiciosBasicos(ByVal datos_serviciosBasicos As class_datos_serviciosBasicos) As Boolean
        Dim estado As Boolean
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO `munisystem`.`servicios_basicos` (`codigo_agua`, `codigo_luz`, `codigo_telefono`, `cod_predio`) VALUES (@codAgua, @codLuz, @codTelf, @cod_predio)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@codAgua", MySqlDbType.VarChar, 45).Value = datos_serviciosBasicos.codAgua_serviciosBasicos
            _adaptador.InsertCommand.Parameters.Add("@codLuz", MySqlDbType.VarChar, 45).Value = datos_serviciosBasicos.codLuz_serviciosBasicos
            _adaptador.InsertCommand.Parameters.Add("@codTelf", MySqlDbType.VarChar, 45).Value = datos_serviciosBasicos.codTelefono_serviciosBasicos
            _adaptador.InsertCommand.Parameters.Add("@cod_predio", MySqlDbType.Int32).Value = datos_serviciosBasicos.codPredio_serviciosBasicos
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
    Public Function actualizarDatosServiciosBasicos(ByRef datos_sb As class_datos_serviciosBasicos) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("UPDATE `munisystem`.`servicios_basicos` SET  `codigo_agua`=@codAgua, `codigo_luz`=@codLuz, `codigo_telefono`=@codTelf, `cod_predio`=@codPredio WHERE `idservicios_basicos`=@idSB", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@idSB", MySqlDbType.Int32).Value = datos_sb.id_serviciosBasicos
            _adaptador.UpdateCommand.Parameters.Add("@codAgua", MySqlDbType.VarChar, 45).Value = datos_sb.codAgua_serviciosBasicos
            _adaptador.UpdateCommand.Parameters.Add("@codLuz", MySqlDbType.VarChar, 45).Value = datos_sb.codLuz_serviciosBasicos
            _adaptador.UpdateCommand.Parameters.Add("@codTelf", MySqlDbType.VarChar, 45).Value = datos_sb.codTelefono_serviciosBasicos
            _adaptador.UpdateCommand.Parameters.Add("@codPredio", MySqlDbType.VarChar, 45).Value = datos_sb.codPredio_serviciosBasicos
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
    ' eliminacion de servicios basicos
    Public Function eliminarDatosServiciosBasicos(ByRef datos_SB As class_datos_serviciosBasicos) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM `munisystem`.`servicios_basicos` WHERE `idservicios_basicos`=@id", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_SB.id_serviciosBasicos
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
End Class
