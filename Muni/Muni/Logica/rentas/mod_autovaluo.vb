Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_autovaluo
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetAutovaluo, _DatasetUit, _DatasetAutovaluo2, _DatasetAutovaluo3, _DatasetAutovaluo4 As New DataSet
    Public _dtwAutovaluo, _dtwAutovaluo2, _dtwAutovaluo3, _dtwUIT As New DataView
    Public _DatatableAutovaluo As New DataTable

    Sub consulta_datos_predio_ficha(ByVal predio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idficha, anio_fecha, numero_ficha, arancel, cod_predio, base_imponible from ficha where cod_predio=" + predio, _conexion)
            _conectorMysql.Fill(_DatasetAutovaluo)
            _dtwAutovaluo.Table = _DatasetAutovaluo.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    '##################################################'
    Sub consulta_datos_uit_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select iduit as CODIGO, valor_uit as VALOR, annio as AÑO from uit order by annio desc", _conexion)
            _conectorMysql.Fill(_DatasetAutovaluo)
            _dtwAutovaluo.Table = _DatasetAutovaluo.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_iut(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from uit where annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetUit)
            _dtwUIT.Table = _DatasetUit.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    '######################################################'
    Sub consulta_datos_iut2(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select iduit as CODIGO, valor_uit as VALOR, annio as AÑO from uit where annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetUit)
            _dtwUIT.Table = _DatasetUit.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Sub consulta_datos_Autovaluo_anio(ByVal ficha As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from  autovaluo where cod_ficha =" + ficha, _conexion)
            _conectorMysql.Fill(_DatasetAutovaluo)
            _dtwAutovaluo.Table = _DatasetAutovaluo.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Sub consulta_datos_Autovaluo_Contribuyente(ByVal opcion As String, ByVal valor As String, ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select *
            from contribuyente
            inner join predio on predio.cod_contribuyente=contribuyente.idcontribuyente
            inner join ficha on ficha.cod_predio=predio.idpredio
            where contribuyente." + opcion + "=" + valor + " and ficha.anio_fecha=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetAutovaluo)
            _dtwAutovaluo.Table = _DatasetAutovaluo.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    '###############################
    Sub consulta_datos_Autovaluo_by(ByVal valor As String, ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select 		predio.idpredio as Cod_Predio,
			concat(tipo_via.nom_tipovia,' ',via.nombre,' NRO. ', predio.numero) as Direccion,
			base_imponible, total_base_imponible, anno as año, valor_deduccion,
            tipo_deducion
            from contribuyente
            inner join predio on predio.cod_contribuyente=contribuyente.idcontribuyente
            inner join ficha on ficha.cod_predio=predio.idpredio
            inner join anno on anno.idanno=ficha.anio_fecha
            inner join via on via.idvia=predio.cod_via
            inner join tipo_via on tipo_via.idtipo_via=via.tipo
            where contribuyente.idcontribuyente=" + valor + " and ficha.anio_fecha=" + annio + " and predio.estado='Activo'", _conexion)
            _conectorMysql.Fill(_DatasetAutovaluo2)
            _dtwAutovaluo2.Table = _DatasetAutovaluo2.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    '#######################################

    Sub consulta_datos_contribuyente_anio(ByVal cod As String, ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from autovaluo where annio=" + annio + " and cod_cont=" + cod, _conexion)
            _conectorMysql.Fill(_DatasetAutovaluo3)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Sub consulta_datos_autovaluo_fraccionamiento(ByVal cod As String, ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select autovaluo.idautovaluo as Cod_Autovaluo,
            autovaluo.cod_cont as Cod_Contribuyente,
            fraccionamiento.idfraccionamiento as Cod_frac,
            fraccionamiento.periodo as N°_Cuota,
            fraccionamiento.fecha_vencimiento as F_Vencimiento,
            fraccionamiento.monto_total as Monto_Total,
            fraccionamiento.estado_fraccionamiento as Estado,
            fraccionamiento.automatizacion_valor as Automatizacion
            from autovaluo
            inner join fraccionamiento on fraccionamiento.cod_autovaluo=autovaluo.idautovaluo
            where cod_cont=" + cod + " and autovaluo.annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetAutovaluo)
            _dtwAutovaluo.Table = _DatasetAutovaluo.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Sub consulta_datos_autovaluo_recibo(ByVal cod As String, ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from autovaluo
            inner join recibo on recibo.cod_autovaluo=autovaluo.idautovaluo
            where cod_cont=" + cod + " and autovaluo.annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetAutovaluo4)
            _dtwAutovaluo3.Table = _DatasetAutovaluo4.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

End Module
