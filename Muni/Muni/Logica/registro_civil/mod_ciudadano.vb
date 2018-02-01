Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_ciudadano
    Private _adapatador As New MySqlDataAdapter
    Public _dtsbox, _dtsbox2, _dtsbox3, _dtsCiudadano As New DataSet
    Public _dtvdatos As New DataView
    Sub consulta_codigo_ubigeoDep(ByVal datos_codubidep As class_datos_ubigeoDepartamento, ByVal valorDep As String)
        Try
            conex_registroCivil()
            _adapatador.SelectCommand = New MySqlCommand("select * from ubigeo_departamento where id=" + valorDep + "", _conexion_registroCivil)
            _adapatador.Fill(_dtsbox)
            For Each row In _dtsbox.Tables(0).Rows
                datos_codubidep.id_ubigeoDepartamento = row("id")
                datos_codubidep.nombre_ubigeoDepartamento = row("nombre")
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar_registroCivil()
        End Try
    End Sub
    Sub consulta_codigo_ubigeoProv(ByVal datos_codubipro As class_datos_ubigeoProvincia, ByVal valorPro As String, ByVal valorDep As String)
        Try
            conex_registroCivil()
            _adapatador.SelectCommand = New MySqlCommand("select * from ubigeo_provincia where id =" + valorPro + " and cod_departamento = " + valorDep + "", _conexion_registroCivil)
            _adapatador.Fill(_dtsbox2)
            For Each row In _dtsbox2.Tables(0).Rows
                datos_codubipro.id_ubigeoProvincia = row("id")
                datos_codubipro.nombre_ubigeoProvincia = row("nombre")
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar_registroCivil()
        End Try
    End Sub
    Sub consulta_codigo_ubigeoDist(ByVal datos_codubidist As class_datos_ubigeoDistrito, ByVal valorDist As String, ByVal valorProv As String)
        Try
            conex_registroCivil()
            _adapatador.SelectCommand = New MySqlCommand("select * from ubigeo_distrito where id =" + valorDist + " and cod_provincia = " + valorProv + "", _conexion_registroCivil)
            _adapatador.Fill(_dtsbox3)
            For Each row In _dtsbox3.Tables(0).Rows
                datos_codubidist.id_ubigeoDistrito = row("id")
                datos_codubidist.nombre_ubigeoDistrito = row("nombre")
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar_registroCivil()
        End Try
    End Sub
    Sub consulta_show_ciudadano(ByVal datos_ciudadano As class_datos_zonas, ByVal valordni As String)
        Try
            conex_registroCivil()
            _adapatador.SelectCommand = New MySqlCommand("select * from ciudadano where dni =" + valordni + "", _conexion_registroCivil)
            _adapatador.Fill(_dtsCiudadano)
            For Each row In _dtsCiudadano.Tables(0).Rows
                datos_ciudadano.nombre_ciudadano = row("nombre")
                datos_ciudadano.apePat_ciudadano = row("ape_paterno")
                datos_ciudadano.apeMat_ciudadano = row("ape_materno")
                datos_ciudadano.tipoDoc_ciudadano = row("tipo_doc")
                datos_ciudadano.dni_ciudadano = row("dni")
                datos_ciudadano.nacionalidad_ciudadano = row("nacionalidad")
                datos_ciudadano.estadoCivil_ciudadano = row("estado_civil")
                datos_ciudadano.fechaNac_ciudadano = row("fecha_nac")
                datos_ciudadano.centroPobla_ciudadano = row("centro_poblado")
                datos_ciudadano.distrito_ciudadano = row("distrito")
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar_registroCivil()
        End Try
    End Sub
End Module
