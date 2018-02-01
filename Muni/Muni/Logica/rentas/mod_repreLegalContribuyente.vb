Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_repreLegalContribuyente
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetRepreLegalContribuyente As New DataSet
    Public _dtwRepreLegalContribuyente As New DataView
    Public _DatatableRepreLegalContribuyente As New DataTable
    Sub cargar_datos_RepreLegalContribuyente(ByVal idDirecContribuyente As Integer, ByVal datos_reprelegal As class_datos_representanteLegal)
        _DatasetRepreLegalContribuyente.Reset()
        Try
            conex_Global()

            _conectorMysql.SelectCommand = New MySqlCommand("select * from representante_legal where cod_contribuyente= @idDirecContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idDirecContri", MySqlDbType.Int32).Value = idDirecContribuyente
            _conectorMysql.Fill(_DatasetRepreLegalContribuyente)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetRepreLegalContribuyente.Tables(0).Rows
                datos_reprelegal.id_representanteLegal = row("idrepresentante_legal")
                datos_reprelegal.nombre_representanteLegal = row("nombre")
                datos_reprelegal.apePat_representanteLegal = row("ape_paterno")
                datos_reprelegal.apeMat_representanteLegal = row("ape_materno")
                datos_reprelegal.codidentificacion_representanteLegal = row("cod_identificacion")
                datos_reprelegal.numeroDoc_representanteLegal = row("numero_identificacion")
                datos_reprelegal.codVia_representanteLegal = row("cod_tipovia")
                datos_reprelegal.nomVia_representanteLegal = row("nombre_via")
                datos_reprelegal.numero_representanteLegal = row("numero")
                datos_reprelegal.manzana_representanteLegal = row("manzana")
                datos_reprelegal.lote_representanteLegal = row("lote")
                datos_reprelegal.nomApart_representanteLegal = row("nombre_apartamento")
                datos_reprelegal.numApart_representanteLegal = row("numero_apartamento")
                datos_reprelegal.codUrbanizacion_representanteLegal = row("cod_urbanizacion")
                datos_reprelegal.nomUrbanizacion_representanteLegal = row("nombre_urbanizacion")
                datos_reprelegal.codContribuyente_representanteLegal = row("cod_contribuyente")
                datos_reprelegal.cargo_representanteLegal = row("cargo")
                datos_reprelegal.telefono_representanteLegal = row("telefono")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub

End Module
