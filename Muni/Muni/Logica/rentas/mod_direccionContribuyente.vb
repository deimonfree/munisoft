Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_direccionContribuyente
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetDirecContribuyente As New DataSet
    Public _dtwDirecContribuyente As New DataView
    Public _DatatableDirecContribuyente As New DataTable
    Sub cargar_datos_direcContribuyente(ByVal idDirecContribuyente As Integer, ByVal datos_direcContri As class_datos_direccion)
        _DatasetDirecContribuyente.Reset()
        Try
            conex_Global()

            _conectorMysql.SelectCommand = New MySqlCommand("select * from direccion_contribuyente where cod_contribuyente= @idDirecContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idDirecContri", MySqlDbType.Int32).Value = idDirecContribuyente
            _conectorMysql.Fill(_DatasetDirecContribuyente)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetDirecContribuyente.Tables(0).Rows
                datos_direcContri.id_direccion = row("iddireccion")
                datos_direcContri.sector_direccion = row("sector")
                datos_direcContri.mzna_direccion = row("manzana")
                datos_direcContri.via_direccion = row("via")
                datos_direcContri.lote_direccion = row("lote")
                datos_direcContri.numero_direccion = row("numero")
                datos_direcContri.departamento_direccion = row("departamento")
                datos_direcContri.piso_direccion = row("piso")
                datos_direcContri.codContribuyente_direccion = row("cod_contribuyente")
                datos_direcContri.codTipoVia_direccion = row("cod_tipovia")
                datos_direcContri.codDistrito_direccion = row("cod_distrito")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub

End Module
