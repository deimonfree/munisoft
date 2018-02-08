Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_contribuyente
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetContribuyente As New DataSet
    Public _dtwContribuyente As New DataView
    Public _DatatableContibuyente As New DataTable
    Sub consulta_datos_contribuyente_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idcontribuyente as 'codigo', ape_paterno as 'Apellido Peterno', ape_materno as 'Apellido Materno', nombres as 'Nombre' , numero_doc 'Numero de Identificación', ruc as 'Numero de RUC', razon_social as 'Razon Social' from contribuyente", _conexion)
            _conectorMysql.Fill(_DatasetContribuyente)
            _dtwContribuyente.Table = _DatasetContribuyente.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_contribuyente_by(ByVal dni As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from contribuyente where numero_doc=" + dni, _conexion)
            _conectorMysql.Fill(_DatasetContribuyente)
            _dtwContribuyente.Table = _DatasetContribuyente.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Sub cargar_datos_contribuyente(ByVal idContribuyente As Integer, ByVal datos_contribuyente As class_datos_contribuyente)
        _DatasetContribuyente.Reset()
        Try
            conex_Global()

            _conectorMysql.SelectCommand = New MySqlCommand("select * from contribuyente where idcontribuyente= @idContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idContri", MySqlDbType.Int32).Value = idContribuyente
            _conectorMysql.Fill(_DatasetContribuyente)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetContribuyente.Tables(0).Rows
                datos_contribuyente.id_contribuyente = row("idcontribuyente")
                datos_contribuyente.numero_doc_cont = row("numero_doc").ToString
                datos_contribuyente.apellido_paterno_cont = row("ape_paterno").ToString
                datos_contribuyente.apellido_materno_cont = row("ape_materno").ToString
                datos_contribuyente.nombres_cont = row("nombres").ToString
                datos_contribuyente.telefono_cont = row("telefono").ToString
                datos_contribuyente.celular_cont = row("celular").ToString
                datos_contribuyente.email_contn = row("email").ToString
                datos_contribuyente.cont_relacion_cont = row("cont_relacion").ToString
                datos_contribuyente.observacion_cont = row("observacion").ToString
                datos_contribuyente.cod_tipo_doc = row("cod_tipodoc")
                datos_contribuyente.cod_urbanizacion_cont = row("cod_urbanizacion")
                datos_contribuyente.cod_relacion_cont = row("cod_relacion")
                datos_contribuyente.ruc_cont = row("ruc").ToString
                datos_contribuyente.razonSocial_cont = row("razon_social").ToString
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub
    Sub consulta_datos_contribuyente_by_codigo(ByVal valor As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idcontribuyente as 'codigo', ape_paterno as 'Apellido Peterno', ape_materno as 'Apellido Materno', nombres as 'Nombre' , numero_doc 'Numero de Identificación', ruc as 'Numero de RUC', razon_social as 'Razon Social' from contribuyente where idcontribuyente = @idContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@campo", MySqlDbType.VarChar, 45).Value = "ape_paterno"
            _conectorMysql.SelectCommand.Parameters.Add("@idContri", MySqlDbType.VarChar, 45).Value = valor
            _conectorMysql.Fill(_DatasetContribuyente)
            _dtwContribuyente.Table = _DatasetContribuyente.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_contribuyente_by_ApellidoPeterno(ByVal valor As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idcontribuyente as 'codigo', ape_paterno as 'Apellido Peterno', ape_materno as 'Apellido Materno', nombres as 'Nombre' , numero_doc 'Numero de Identificación', ruc as 'Numero de RUC', razon_social as 'Razon Social' from contribuyente where ape_paterno = @idContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@campo", MySqlDbType.VarChar, 45).Value = "ape_paterno"
            _conectorMysql.SelectCommand.Parameters.Add("@idContri", MySqlDbType.VarChar, 45).Value = valor
            _conectorMysql.Fill(_DatasetContribuyente)
            _dtwContribuyente.Table = _DatasetContribuyente.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_contribuyente_by_Nombre(ByVal valor As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idcontribuyente as 'codigo', ape_paterno as 'Apellido Peterno', ape_materno as 'Apellido Materno', nombres as 'Nombre' , numero_doc 'Numero de Identificación', ruc as 'Numero de RUC', razon_social as 'Razon Social' from contribuyente where nombres = @idContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@campo", MySqlDbType.VarChar, 45).Value = "ape_paterno"
            _conectorMysql.SelectCommand.Parameters.Add("@idContri", MySqlDbType.VarChar, 45).Value = valor
            _conectorMysql.Fill(_DatasetContribuyente)
            _dtwContribuyente.Table = _DatasetContribuyente.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_contribuyente_by_DNI(ByVal valor As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idcontribuyente as 'codigo', ape_paterno as 'Apellido Peterno', ape_materno as 'Apellido Materno', nombres as 'Nombre' , numero_doc 'Numero de Identificación', ruc as 'Numero de RUC', razon_social as 'Razon Social' from contribuyente where numero_doc = @idContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@campo", MySqlDbType.VarChar, 45).Value = "ape_paterno"
            _conectorMysql.SelectCommand.Parameters.Add("@idContri", MySqlDbType.VarChar, 45).Value = valor
            _conectorMysql.Fill(_DatasetContribuyente)
            _dtwContribuyente.Table = _DatasetContribuyente.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_contribuyente_by_RazonSocial(ByVal valor As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idcontribuyente as 'codigo', ape_paterno as 'Apellido Peterno', ape_materno as 'Apellido Materno', nombres as 'Nombre' , numero_doc 'Numero de Identificación', ruc as 'Numero de RUC', razon_social as 'Razon Social' from contribuyente where razon_social = @idContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@campo", MySqlDbType.VarChar, 45).Value = "ape_paterno"
            _conectorMysql.SelectCommand.Parameters.Add("@idContri", MySqlDbType.VarChar, 45).Value = valor
            _conectorMysql.Fill(_DatasetContribuyente)
            _dtwContribuyente.Table = _DatasetContribuyente.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_contribuyente_by_RUC(ByVal valor As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idcontribuyente as 'codigo', ape_paterno as 'Apellido Peterno', ape_materno as 'Apellido Materno', nombres as 'Nombre' , numero_doc 'Numero de Identificación', ruc as 'Numero de RUC', razon_social as 'Razon Social' from contribuyente where ruc = @idContri", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@campo", MySqlDbType.VarChar, 45).Value = "ape_paterno"
            _conectorMysql.SelectCommand.Parameters.Add("@idContri", MySqlDbType.VarChar, 45).Value = valor
            _conectorMysql.Fill(_DatasetContribuyente)
            _dtwContribuyente.Table = _DatasetContribuyente.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_contribuyente_by_valor(ByVal tipo As String, ByVal valor As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from contribuyente where numero_doc=@valor and cod_tipodoc=@tipo", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@tipo", MySqlDbType.VarChar, 45).Value = tipo
            _conectorMysql.SelectCommand.Parameters.Add("@valor", MySqlDbType.VarChar, 45).Value = valor
            _conectorMysql.Fill(_DatasetContribuyente)
            _dtwContribuyente.Table = _DatasetContribuyente.Tables(0)
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
