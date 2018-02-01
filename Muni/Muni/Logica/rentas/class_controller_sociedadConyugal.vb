Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_sociedadConyugal
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetSociedadConyugal As New DataSet

    Public Function insertarDatosSociedadConyugal(ByVal datos_sociedadConyugal As class_datos_sociedadConyugal) As Boolean
        Dim estado As Boolean
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO `munisystem`.`sociedad_conyugal` (`num_identificacion`, `nombre_completo`, `cod_contribuyente`) VALUES (@num, @nombre, @codContri)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@num", MySqlDbType.VarChar, 45).Value = datos_sociedadConyugal.numIdentificacion_sociedadConyugal
            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 100).Value = datos_sociedadConyugal.nombreCompleto_sociedadConyugal
            _adaptador.InsertCommand.Parameters.Add("@codContri", MySqlDbType.Int32).Value = datos_sociedadConyugal.codContri_sociedadConyugal
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
End Class
