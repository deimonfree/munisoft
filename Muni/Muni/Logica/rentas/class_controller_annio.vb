Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_annio
    Public _adaptador As New MySqlDataAdapter
    Private _DataSetAnnio As New DataSet
    'n00000000000
    Public Function insertarDatosAnnio(ByVal datos_annio As anno) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into anno(idanno,anno) values(@id,@annio)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id", MySqlDbType.Double).Value = datos_annio.Id_anno
            _adaptador.InsertCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = datos_annio.Anno_anno
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
