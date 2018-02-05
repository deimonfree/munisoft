Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_tasas
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetTasas, _DatasetTasas2, _DatasetTasas3, _DatasetTasas4, _DatasetTasas5, _DatasetTasas6, _DatasetTasas7 As New DataSet
    Public _dtwTasas, _dtwTasas2, _dtwTasas3, _dtwTasas4, _dtwTasas5, _dtwTasas6, _dtwTasas7 As New DataView
    Sub consulta_datos_tasas(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idvvu_muroscolumnas, vu_muroscolumnas.valor as MUROS_Y_COL,
            idvu_techos, vu_techos.valor as TECHOS,
            idvu_pisos, vu_pisos.valor as PISOS,
            idvu_puertasventanas, vu_puertasventanas.valor as P_Y_V,
            idvu_revestimiento, vu_revestimiento.valor as REVEST,
            idvu_banio, vu_banio.valor as BAÑOS,
            idvu_electricidadsanitarias, vu_electricidadsanitarias.valor as INSTAL
            from vu_muroscolumnas
            join vu_techos on vu_techos.cod_categoria=vu_muroscolumnas.cod_categoria
            join vu_pisos on vu_pisos.cod_categoria=vu_muroscolumnas.cod_categoria
            join vu_puertasventanas on vu_puertasventanas.cod_categoria=vu_muroscolumnas.cod_categoria
            join vu_revestimiento on vu_revestimiento.cod_categoria=vu_muroscolumnas.cod_categoria
            join vu_banio on vu_banio.cod_categoria=vu_muroscolumnas.cod_categoria
            join vu_electricidadsanitarias on vu_electricidadsanitarias.cod_categoria=vu_muroscolumnas.cod_categoria
            where vu_muroscolumnas.annio = " + annio + " and vu_techos.annio =" + annio + " and vu_pisos.annio=" + annio + "
            and vu_puertasventanas.annio = " + annio + " and vu_revestimiento.annio=" + annio + " and vu_banio.annio=" + annio + "
            and vu_electricidadsanitarias.annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetTasas)
            _dtwTasas.Table = _DatasetTasas.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_tasas1(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idvvu_muroscolumnas as CODIGO, categoria as CATEGORIA,
            valor as VALOR, annio as AÑO from vu_muroscolumnas 
           join td_muroscolumnas on td_muroscolumnas.idtd_murosColumnas=vu_muroscolumnas.cod_categoria where annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetTasas)
            _dtwTasas.Table = _DatasetTasas.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_tasas2(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idvu_techos as CODIGO, categoria as CATEGORIA,
            valor as VALOR, annio as AÑO from vu_techos 
            join td_techos on td_techos.idtd_techos=vu_techos.cod_categoria where annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetTasas2)
            _dtwTasas2.Table = _DatasetTasas2.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_tasas3(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idvu_pisos as CODIGO, categoria as CATEGORIA,
            valor as VALOR, annio as AÑO from vu_pisos join tv_pisos on tv_pisos.idtv_pisos=vu_pisos.cod_categoria 
            where annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetTasas3)
            _dtwTasas3.Table = _DatasetTasas3.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_tasas4(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idvu_puertasventanas as CODIGO, categoria as CATEGORIA,
            valor as VALOR, annio as AÑO from vu_puertasventanas 
            join tv_puertasventanas on tv_puertasventanas.idtv_puertasVentanas=vu_puertasventanas.cod_categoria where annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetTasas4)
            _dtwTasas4.Table = _DatasetTasas4.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_tasas5(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idvu_revestimiento as CODIGO, categoria as CATEGORIA,
            valor as VALOR, annio as AÑO from vu_revestimiento
            join tv_revestimiento on tv_revestimiento.idtv_revestimiento=vu_revestimiento.cod_categoria
            where annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetTasas5)
            _dtwTasas5.Table = _DatasetTasas5.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_tasas6(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idvu_banio CODIGO, categoria as CATEGORIA,
            valor as VALOR, annio as AÑO from vu_banio
            join tv_banos on tv_banos.idtv_banos=vu_banio.cod_categoria
            where annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetTasas6)
            _dtwTasas6.Table = _DatasetTasas6.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_tasas7(ByVal annio As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select idvu_electricidadsanitarias CODIGO, categoria as CATEGORIA,
            valor as VALOR, annio as AÑO from vu_electricidadsanitarias
            join tv_electricassanitarias on tv_electricassanitarias.idtv_electricasSanitarias=vu_electricidadsanitarias.cod_categoria
            where annio=" + annio, _conexion)
            _conectorMysql.Fill(_DatasetTasas7)
            _dtwTasas7.Table = _DatasetTasas7.Tables(0)
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