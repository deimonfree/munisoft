Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_sociedadConyuge
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetSociedadConyuge As New DataSet
    Public _dtwSociedadConyuge As New DataView
    Public _DatatableSociedadConyuge As New DataTable
    Sub cargar_datos_sociedadConyugal(ByVal idContribuyente As Integer, ByVal datos_contribuyente As class_datos_sociedadConyugal)
        _DatasetSociedadConyuge.Reset()
        Try
            conex_Global()

            _conectorMysql.SelectCommand = New MySqlCommand("select * from sociedad_conyugal where cod_contribuyente= @idContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idContri", MySqlDbType.Int32).Value = idContribuyente
            _conectorMysql.Fill(_DatasetSociedadConyuge)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetSociedadConyuge.Tables(0).Rows
                datos_contribuyente.id_sociedadConyugal = row("idsociedad_conyugal")
                datos_contribuyente.numIdentificacion_sociedadConyugal = row("num_identificacion").ToString
                datos_contribuyente.nombreCompleto_sociedadConyugal = row("nombre_completo").ToString
                datos_contribuyente.codContri_sociedadConyugal = row("cod_contribuyente").ToString
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub
End Module
