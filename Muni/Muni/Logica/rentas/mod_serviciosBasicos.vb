Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_serviciosBasicos
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetServiciosBasicos As New DataSet
    Public _dtwServiciosBasicos As New DataView
    Sub cargar_datos_ServiciosBasicos(ByVal idPredio As Integer, ByVal datos_ServiciosBasicos As class_datos_serviciosBasicos)
        _DatasetContribuyente.Reset()
        Try
            conex_Global()

            _conectorMysql.SelectCommand = New MySqlCommand("select * from servicios_basicos where cod_predio= @idPredio", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idPredio", MySqlDbType.Int32).Value = idPredio
            _conectorMysql.Fill(_DatasetServiciosBasicos)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetServiciosBasicos.Tables(0).Rows
                datos_ServiciosBasicos.id_serviciosBasicos = row("idservicios_basicos")
                datos_ServiciosBasicos.codAgua_serviciosBasicos = row("codigo_agua").ToString
                datos_ServiciosBasicos.codLuz_serviciosBasicos = row("codigo_luz").ToString
                datos_ServiciosBasicos.codTelefono_serviciosBasicos = row("codigo_telefono").ToString
                datos_ServiciosBasicos.codPredio_serviciosBasicos = row("cod_predio").ToString
            Next
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub
End Module
