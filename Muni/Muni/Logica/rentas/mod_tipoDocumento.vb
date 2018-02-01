Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_tipoDocumento
    Private _adaptador As New MySqlDataAdapter
    Public _DatasetTipodocumento As New DataSet
    Public _dtwTipodocumento As New DataView
    Public _DatasetTipodocumentoBox As New DataSet
    Public _DatasetTipodocumentoBox2 As New DataSet
    'consulta de todas las zonas
    Sub consulta_datos_tipoDocumento_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_doc", _conexion)
            _adaptador.Fill(_DatasetTipodocumento)
            _dtwTipodocumento.Table = _DatasetTipodocumento.Tables(0)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'consulta de datos de zona por valor
    Sub consulta_datos_tipoDocumento_detalle_by(ByRef dato_tipoDocumento As String)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tippo_doc where nombre= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.String).Value = dato_tipoDocumento
            _adaptador.Fill(_DatasetTipodocumento)
            _dtwTipodocumento.Table = _DatasetTipodocumento.Tables(0)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'consulta de datos de zona por dinamico
    Sub consulta_datos_tipoDocumento_detalle_by_dinamic(ByRef valor_dinamico As String)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("SELECT * FROM tipo_doc where nombre like '%" + valor_dinamico + "%'", _conexion)
            _adaptador.Fill(_DatasetTipodocumento)
            _dtwTipodocumento.Table = _DatasetTipodocumento.Tables(0)
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'consulta para llenado de combox por valor
    Sub consulta_datos_tipoDocumento_combox(ByRef codigo_TipoDoc As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_doc where idtipo_doc= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.String).Value = codigo_TipoDoc
            _adaptador.Fill(_DatasetTipodocumentoBox, "tipo_doc")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'consulta para llenado de combox
    Sub consulta_datos_tipoDocumento_combox_all()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_doc", _conexion)
            _adaptador.Fill(_DatasetTipodocumentoBox, "tipo_doc")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'consulta para llenado de combox por valor
    Sub consulta_datos_tipoDocumento_combox2(ByRef codigo_TipoDoc As Integer)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_doc where idtipo_doc= @valor", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@valor", MySqlDbType.String).Value = codigo_TipoDoc
            _adaptador.Fill(_DatasetTipodocumentoBox2, "tipo_doc")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
    'consulta para llenado de combox
    Sub consulta_datos_tipoDocumento_combox_all2()
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from tipo_doc", _conexion)
            _adaptador.Fill(_DatasetTipodocumentoBox2, "tipo_doc")
            _conexion.Open()
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try

    End Sub
End Module
