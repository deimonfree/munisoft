Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_depreciasion
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetDepreciasion As New DataSet
    Public _dtwDepreciasion As New DataView
    Public _DatatableDepreciasion As New DataTable
    'cargar clasificacion
    Sub cargar_datos_clasificacionVivienda(ByVal idClasificacion As Integer, ByVal datos_clasificacion As class_datos_clasificacion)
        _DatasetDepreciasion.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from tabla_usovivienda where idtabla_usovivienda= @idClasificacion", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idClasificacion", MySqlDbType.Int32).Value = idClasificacion
            _conectorMysql.Fill(_DatasetDepreciasion)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetDepreciasion.Tables(0).Rows
                datos_clasificacion.id_clasificacion = row("idtabla_usoVivienda")
                datos_clasificacion.denominacion_clasificacion = row("denominacion")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub
    'cargar materiales
    Sub cargar_datos_materialVivienda(ByVal idMaterial As Integer, ByVal datos_material As class_datos_material)
        _DatasetDepreciasion.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from tabla_material where idtabla_material= @idMaterial", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idMaterial", MySqlDbType.Int32).Value = idMaterial
            _conectorMysql.Fill(_DatasetDepreciasion)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetDepreciasion.Tables(0).Rows
                datos_material.id_materialVivienda = row("idtabla_material")
                datos_material.denominacion_materialVivienda = row("denominacion")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub
    'cargar estado de conservacion
    Sub cargar_datos_conservacionVivienda(ByVal idConservacion As Integer, ByVal datos_conservacion As class_datos_conservacion)
        _DatasetDepreciasion.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from tabla_conservacion where idtabla_conservacion= @idConservacion", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idConservacion", MySqlDbType.Int32).Value = idConservacion
            _conectorMysql.Fill(_DatasetDepreciasion)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetDepreciasion.Tables(0).Rows
                datos_conservacion.id_conservacionVivienda = row("idtabla_conservacion")
                datos_conservacion.denominacion_conservacionVivienda = row("denominacion")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub
    'cargar depreciacion
    Sub cargar_datos_depreciacion(ByVal idclasificacion As Integer, ByVal idantiguedad As Integer, ByVal idmaterial As Integer, ByVal idconservacion As Integer, ByVal anno As Integer, ByVal datos_depreciacion As class_datos_depreciacion)
        _DatasetDepreciasion.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT * FROM depreciacion where cod_clasificacion= @idClasificacion and cod_antiguedad= @idAntiguedad and cod_material= @idMaterial and cod_conservacion= @idConservacion and anno = @idAnno", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idClasificacion", MySqlDbType.Int32).Value = idclasificacion
            _conectorMysql.SelectCommand.Parameters.Add("@idAntiguedad", MySqlDbType.Int32).Value = idantiguedad
            _conectorMysql.SelectCommand.Parameters.Add("@idMaterial", MySqlDbType.Int32).Value = idmaterial
            _conectorMysql.SelectCommand.Parameters.Add("@idConservacion", MySqlDbType.Int32).Value = idconservacion
            _conectorMysql.SelectCommand.Parameters.Add("@idAnno", MySqlDbType.Int32).Value = anno
            _conectorMysql.Fill(_DatasetDepreciasion)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetDepreciasion.Tables(0).Rows
                datos_depreciacion.id_depreciacion = row("iddepreciacion")
                datos_depreciacion.clasificacion_depreciacion = row("cod_clasificacion")
                datos_depreciacion.antiguedad_depreciacion = row("cod_antiguedad")
                datos_depreciacion.material_depreciacion = row("cod_material")
                datos_depreciacion.conservacion_depreciacion = row("cod_conservacion")
                datos_depreciacion.valor_depreciacion = row("valor")
                datos_depreciacion.annio_depreciacion = row("anno")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
    End Sub
    '###################################################################
    Sub consulta_depreciacion_by_annio(ByRef dato_annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from depreciacion where anno =" + dato_annio + "", _conexion)
            _conectorMysql.Fill(_DatasetDepreciasion)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

End Module
