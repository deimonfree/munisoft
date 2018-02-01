Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_provincia
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetProvincia As New DataSet
    Public _dtwProvincia As New DataView
    Sub Provincia_By(ByRef datos_Provincia As class_datos_provincia, ByRef dato As String)
        Try
            _DatasetProvincia.Reset()
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from provincia where idprovincia =" + dato + "", _conexion)
            _conectorMysql.Fill(_DatasetProvincia)
            For Each row In _DatasetProvincia.Tables(0).Rows
                datos_Provincia.id_provincia = row("idprovincia")
                datos_Provincia.nombre_provincia = row("nombre")
                datos_Provincia.cod_departamento = row("cod_departamento")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

End Module
