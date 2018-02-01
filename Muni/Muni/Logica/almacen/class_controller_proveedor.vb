Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class class_controller_proveedor
    Private _adaptador As New MySqlDataAdapter
    Private _datasetProveedor As New DataSet
    'insercion de datos de provvedor
    Public Function insertarDatosProveedor(ByVal datos_proveedor As class_datos_proveedor) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into proveedor (ruc,razon_social,direction) values (@ruc,@razon_social,@direction)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@ruc", MySqlDbType.VarChar, 45).Value = datos_proveedor.ruc_proveedor
            _adaptador.InsertCommand.Parameters.Add("@razon_social", MySqlDbType.VarChar, 45).Value = datos_proveedor.razon_social_proveedor
            _adaptador.InsertCommand.Parameters.Add("@direction", MySqlDbType.VarChar, 45).Value = datos_proveedor.direction_proveedor
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
