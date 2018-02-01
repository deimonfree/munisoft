Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_docBaseLegal
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetDocbaselegal As New DataSet
    Public Function insertarDatosDocbaselegal(ByVal datos_ficha As class_datos_docBaseLegal) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("INSERT INTO `munisystem`.`doc_base_legal` (`num_exp`, `num_resol`, `cod_ficha`) VALUES (@numExp, @numResol, @codFicha)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@numExp", MySqlDbType.VarChar, 45).Value = datos_ficha.numExpediente_docBaseLegal
            _adaptador.InsertCommand.Parameters.Add("@numResol", MySqlDbType.VarChar, 45).Value = datos_ficha.numResolucion_docBaseLegal
            _adaptador.InsertCommand.Parameters.Add("@codFicha", MySqlDbType.Int32).Value = datos_ficha.codFicha_docBaseLegal
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
