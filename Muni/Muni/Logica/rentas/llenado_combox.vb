Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module llenado_combox
    Private _adaptador As New MySqlDataAdapter
    Public _dtwLlenadoBox As New DataView
    Public _DatasetLlenadoBox As New DataSet
    Sub combox_all(ByVal tabla As String)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from " + tabla + " ORDER BY idanno desc", _conexion)
            _adaptador.Fill(_DatasetLlenadoBox, tabla)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
End Module
