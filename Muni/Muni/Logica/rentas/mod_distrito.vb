Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_distrito
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetDistrito As New DataSet
    Public _dtwDistrito As New DataView
    Sub consulta_datos_Distrito_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT distrito.nombre as Distrito, provincia.nombre as Provincia, departamento.nombre as Departamento 
from departamento inner join provincia on departamento.iddepartamento = provincia.cod_departamento 
inner join distrito on provincia.idprovincia = distrito.cod_provincia", _conexion)
            _conectorMysql.Fill(_DatasetDistrito)
            _dtwDistrito.Table = _DatasetDistrito.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_Distrito_all_By(ByVal datos_distrito As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT distrito.iddistrito as IDDistrito,distrito.nombre as Distrito, provincia.nombre as Provincia, departamento.nombre as Departamento 
from departamento inner join provincia on departamento.iddepartamento = provincia.cod_departamento 
inner join distrito on provincia.idprovincia = distrito.cod_provincia where distrito.nombre = '" + datos_distrito + "'", _conexion)
            _conectorMysql.Fill(_DatasetDistrito)
            _dtwDistrito.Table = _DatasetDistrito.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub Distrito_By(ByRef datos_Distrito As class_datos_distrito, ByRef dato As String)
        Try
            _DatasetDistrito.Reset()
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from distrito where iddistrito =" + dato + "", _conexion)
            _conectorMysql.Fill(_DatasetDistrito)
            For Each row In _DatasetDistrito.Tables(0).Rows
                datos_Distrito.id_distrito = row("iddistrito")
                datos_Distrito.nombre_distrito = row("nombre")
                datos_Distrito.cod_provincia = row("cod_provincia")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
End Module
