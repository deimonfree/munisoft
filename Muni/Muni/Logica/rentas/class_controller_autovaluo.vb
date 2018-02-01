Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_autovaluo
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetConstruccion As New DataSet
    Public ultimoConstruccion As Integer
    Public Function insertarDatosAutovaluo(ByVal datos_autovaluo As class_datos_autovaluo) As Boolean
        Dim estado As Boolean
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into autovaluo(valor_autovaluo,annio,estado,cod_cont) values(@val,@annio,@estado,@cod_ficha)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@val", MySqlDbType.VarChar, 45).Value = datos_autovaluo.valor_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = datos_autovaluo.annio_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@estado", MySqlDbType.VarChar, 45).Value = datos_autovaluo.estado_autovaluo
            _adaptador.InsertCommand.Parameters.Add("@cod_ficha", MySqlDbType.VarChar, 45).Value = datos_autovaluo.cod_ficaha_autovaluo
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
