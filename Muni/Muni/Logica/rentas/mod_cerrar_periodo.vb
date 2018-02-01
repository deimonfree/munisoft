Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_cerrar_periodo
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetCerrar As New DataSet
    Public _dtwCerrar As New DataView
    Sub consulta_datos_cerrar_periodo_by(ByRef dato_modulo As String, ByRef dato_annio As String)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from cerrar_periodo where modulo=@modulo and annio=@annio", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@modulo", MySqlDbType.String).Value = dato_modulo
            _adaptador.SelectCommand.Parameters.Add("@annio", MySqlDbType.String).Value = dato_annio
            _adaptador.Fill(_DatasetCerrar)
            _dtwCerrar.Table = _DatasetCerrar.Tables(0)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

End Module
