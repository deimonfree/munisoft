Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_viasRelacionadas
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetGrupoVias As New DataSet
    Public _dtwGrupoVias As New DataView
    Public numeros(3) As Integer
    Sub cargar_datos_viasRelacionadas(ByVal CodGrupoCatastral As Integer)
        Dim var As Integer
        Dim valor_tabla As Integer
        var = 0
        mod_contribuyente._DatasetContribuyente.Reset()
        Try
            conex_Global()

            _conectorMysql.SelectCommand = New MySqlCommand("select * from vias_relacionada where cod_gc= @codGrupoCatas", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@codGrupoCatas", MySqlDbType.Int32).Value = CodGrupoCatastral
            _conectorMysql.Fill(_DatasetGrupoVias)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            valor_tabla = _DatasetGrupoVias.Tables(0).Rows.Count
            ReDim numeros(valor_tabla - 1)
            For Each row In _DatasetGrupoVias.Tables(0).Rows
                numeros(var) = row("cod_via")
                var = var + 1
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub
    'Sub agregar_datos()
    '    '        numeros(0) = 1
    '    For index As Integer = 0 To 3
    '        numeros(index) = 1 + index
    '    Next
    'End Sub
    Sub imprimir_numeros()
        For index As Integer = 0 To 3
            MessageBox.Show(numeros(index))
        Next
    End Sub

End Module
