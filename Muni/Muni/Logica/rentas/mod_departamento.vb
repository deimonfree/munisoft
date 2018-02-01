Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_departamento
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetDepartamento As New DataSet
    Public _dtwDepartamento As New DataView
    Sub Departamento_By(ByRef datos_Departamento As class_datos_departamento, ByRef dato As String)
        Try
            _DatasetDepartamento.Reset()
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from departamento where iddepartamento =" + dato + "", _conexion)
            _conectorMysql.Fill(_DatasetDepartamento)
            For Each row In _DatasetDepartamento.Tables(0).Rows
                datos_Departamento.id_departamento = row("iddepartamento")
                datos_Departamento.nombre_departamento = row("nombre")

            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
End Module
