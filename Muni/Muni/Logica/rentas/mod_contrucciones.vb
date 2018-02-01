Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_contrucciones
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetConstrucciones As New DataSet
    Public _dtwConstrucciones As New DataView
    Sub contrucciones_By_Codigo(ByRef datos_Construciones As class_datos_construcciones, ByRef dato As String)
        Try
            _DatasetConstrucciones.Reset()
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from  construccion where cod_ficha = " + dato + "", _conexion)
            _conectorMysql.Fill(_DatasetConstrucciones)
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'saber si existe construccion
    Public Function cantidad_construccion_by(ByVal idConst As Integer) As Integer
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select count(*) as total from construccion where idconstruccion= @idConstuc ", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idConstuc", MySqlDbType.Int32).Value = idConst
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            Return _conectorMysql.SelectCommand.ExecuteScalar()
        Catch ex As Exception

        End Try
    End Function
    'cantidad de construcciones
    Public Function cantidad_construccion_by_ficha(ByVal idFicha As Integer) As Integer
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select count(*) as total from construccion where cod_ficha= @idFicha ", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idFicha", MySqlDbType.Int32).Value = idFicha
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            Return _conectorMysql.SelectCommand.ExecuteScalar()
        Catch ex As Exception

        End Try
    End Function
End Module
