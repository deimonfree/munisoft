Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_ubigeo
    Private _adapatador As New MySqlDataAdapter
    Public _dtsubigeoDist As New DataSet
    Public _dtsubigeoProv As New DataSet
    Public _dtsubigeoDep As New DataSet
    Public _dtvdatos As New DataView
    Sub consulta_codigo_ubigeoDist_retro(ByVal datos_codubidist As class_datos_ubigeoDistrito, ByVal valorDist As String)
        Try
            conex_registroCivil()
            _adapatador.SelectCommand = New MySqlCommand("select * from ubigeo_distrito where id =" + valorDist + "", _conexion_registroCivil)
            _adapatador.Fill(_dtsubigeoDist)
            For Each row In _dtsubigeoDist.Tables(0).Rows
                datos_codubidist.id_ubigeoDistrito = row("id")
                datos_codubidist.nombre_ubigeoDistrito = row("nombre")
                datos_codubidist.codPro_ubigeoDistrito = row("cod_provincia")
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar_registroCivil()
        End Try
    End Sub
    Sub consulta_codigo_ubigeoProv_retro(ByVal datos_codubiprov As class_datos_ubigeoProvincia, ByVal valorProv As String)
        Try
            conex_registroCivil()
            _adapatador.SelectCommand = New MySqlCommand("select * from ubigeo_provincia where id =" + valorProv + "", _conexion_registroCivil)
            _adapatador.Fill(_dtsubigeoProv)
            For Each row In _dtsubigeoProv.Tables(0).Rows
                datos_codubiprov.id_ubigeoProvincia = row("id")
                datos_codubiprov.nombre_ubigeoProvincia = row("nombre")
                datos_codubiprov.codDep_ubigeoProvincia = row("cod_departamento")
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar_registroCivil()
        End Try
    End Sub
    Sub consulta_codigo_ubigeoDep_retro(ByVal datos_codubidist As class_datos_ubigeoDistrito, ByVal valorDist As String)
        Try
            conex_registroCivil()
            _adapatador.SelectCommand = New MySqlCommand("select * from ubigeo_distrito where id =" + valorDist + "", _conexion_registroCivil)
            _adapatador.Fill(_dtsubigeoDist)
            For Each row In _dtsubigeoDist.Tables(0).Rows
                datos_codubidist.id_ubigeoDistrito = row("id")
                datos_codubidist.nombre_ubigeoDistrito = row("nombre")
                datos_codubidist.codPro_ubigeoDistrito = row("cod_provincia")
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar_registroCivil()
        End Try
    End Sub
End Module
