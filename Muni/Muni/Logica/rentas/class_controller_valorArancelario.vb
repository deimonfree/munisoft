Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_valorArancelario
    Private _conectorMysql As New MySqlDataAdapter
    Private _DataSetValorArancelario As New DataSet
    'insercion de datos via
    Public Function insertarDatosValorArancelario(ByVal datos_ValorArancelario As class_datos_valorArancelario) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.InsertCommand = New MySqlCommand("insert into valor_arancelario(cod_via,cod_anno,valor,cuadra) values(@codvia,@codanno,@valor,@cuadra)", _conexion)
            _conectorMysql.InsertCommand.Parameters.Add("@codvia", MySqlDbType.Int32).Value = datos_ValorArancelario.codVia_valorArancelario
            _conectorMysql.InsertCommand.Parameters.Add("@codanno", MySqlDbType.Int32).Value = datos_ValorArancelario.codAnno_valorArancelario
            _conectorMysql.InsertCommand.Parameters.Add("@valor", MySqlDbType.Double).Value = datos_ValorArancelario.valor_valorArancelario
            _conectorMysql.InsertCommand.Parameters.Add("@cuadra", MySqlDbType.Int32).Value = datos_ValorArancelario.cuadra_valorArancelario
            _conexion.Open()
            _conectorMysql.InsertCommand.Connection = _conexion
            _conectorMysql.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
    ' actualizacion de datos via
    Public Function actualizarDatosValorArancelario(ByRef datos_ValorArancelario As class_datos_valorArancelario) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.UpdateCommand = New MySqlCommand("update valor_arancelario set cod_via=@codvia, cod_anno=@codanno, valor=@valor, cuadra=@cuadra where idvalor_aracenlario=@id", _conexion)
            _conectorMysql.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_ValorArancelario.id_valorArancelario
            _conectorMysql.UpdateCommand.Parameters.Add("@codvia", MySqlDbType.Int32).Value = datos_ValorArancelario.codVia_valorArancelario
            _conectorMysql.UpdateCommand.Parameters.Add("@codanno", MySqlDbType.Int32).Value = datos_ValorArancelario.codAnno_valorArancelario
            _conectorMysql.UpdateCommand.Parameters.Add("@valor", MySqlDbType.Double).Value = datos_ValorArancelario.valor_valorArancelario
            _conectorMysql.UpdateCommand.Parameters.Add("@cuadra", MySqlDbType.Int32).Value = datos_ValorArancelario.cuadra_valorArancelario
            _conexion.Open()
            _conectorMysql.UpdateCommand.Connection = _conexion
            _conectorMysql.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    ' eliminacion de datos de via
    Public Function eliminarDatosValorArancelario(ByRef datos_ValorArancelario As class_datos_valorArancelario) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _conectorMysql.DeleteCommand = New MySqlCommand("delete from valor_arancelario where idvalor_arancelario=@id", _conexion)
            _conectorMysql.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos_ValorArancelario.id_valorArancelario
            _conectorMysql.DeleteCommand.Connection = _conexion
            _conectorMysql.DeleteCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
End Class
