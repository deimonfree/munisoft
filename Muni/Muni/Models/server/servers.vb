Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module servers
    Private _adaptador As New MySqlDataAdapter
    Public _dtwServidoresBox As New DataView
    Public _DatasetServidoresBox As New DataSet
    Sub Listado_Servidores()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM munisystem.servers", _conexion)
            _adaptador.Fill(_DatasetServidoresBox, "servers")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    Public Function conexion_servidor(ByVal nombre_servidor As String) As Integer
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select count(ip) FROM `munisystem`.`servers` where ip = @server", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@server", MySqlDbType.VarChar, 45).Value = nombre_servidor
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            Return _adaptador.SelectCommand.ExecuteScalar()
        Catch ex As Exception
        End Try
    End Function
End Module
