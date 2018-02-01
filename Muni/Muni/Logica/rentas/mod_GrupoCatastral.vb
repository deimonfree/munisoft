Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_GrupoCatastral
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetGrupoCatastral As New DataSet
    Public _dtwGrupoCatastral As New DataView
    Sub consulta_datos_grupoCatastral_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from grupo_catastral", _conexion)
            _conectorMysql.Fill(_DatasetGrupoCatastral)
            _dtwGrupoCatastral.Table = _DatasetGrupoCatastral.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_grupoCatastral_by(ByVal dato As Integer)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from grupo_catastral where cod_sector=@idsector", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idsector", MySqlDbType.Int32).Value = dato
            _conectorMysql.Fill(_DatasetGrupoCatastral)
            _dtwGrupoCatastral.Table = _DatasetGrupoCatastral.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub cargar_datos_grupoCatastral(ByVal sector_grupoCatastral As Integer, ByVal datos_grupoCatastral As class_datos_grupo_catastral)
        _DatasetGrupoCatastral.Reset()
        Try
            conex_Global()

            _conectorMysql.SelectCommand = New MySqlCommand("select * from grupo_catastral where idgrupo_catastral=@idSector", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idsector", MySqlDbType.Int32).Value = sector_grupoCatastral
            _conectorMysql.Fill(_DatasetGrupoCatastral)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetGrupoCatastral.Tables(0).Rows
                datos_grupoCatastral.idgrupo_catastral = row("idgrupo_catastral")
                datos_grupoCatastral.cod_mzna_catastral = row("cod_mzna")
                datos_grupoCatastral.manzana_catastral = row("nom_mzna")
                datos_grupoCatastral.cod_sector_catastral = row("cod_sector")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub
End Module
