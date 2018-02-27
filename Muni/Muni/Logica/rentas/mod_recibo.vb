Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_recibo
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetRecibo, _DatasetRecibo2, _DatasetReciboTesoreria As New DataSet
    Public _dtwRecibo, _dtwRecibo2, _dtwReciboTesoreria As New DataView
    Sub consulta_ultimo_recibo()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from recibo  order by idrecibo desc limit 1", _conexion)
            _conectorMysql.Fill(_DatasetRecibo)
            'For Each row In _DatasetDistrito.Tables(0).Rows
            '    datos_Distrito.id_distrito = row("iddistrito")
            '    datos_Distrito.nombre_distrito = row("nombre")
            '    datos_Distrito.cod_provincia = row("cod_provincia")
            'Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Sub consulta_recibo_canje(ByVal cod As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from recibo where cod_autovaluo=" + cod, _conexion)
            _conectorMysql.Fill(_DatasetRecibo)
            _dtwRecibo.Table = _DatasetRecibo.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_recibo_contribuyente(ByVal cod As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from recibo inner join autovaluo on autovaluo.idautovaluo=recibo.cod_autovaluo where cod_autovaluo=" + cod, _conexion)
            _conectorMysql.Fill(_DatasetRecibo2)
            _dtwRecibo2.Table = _DatasetRecibo2.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    '##############################################################################################
    Sub consulta_recibo_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select
            idrecibo_tesoreria as 'CODIGO RECIBO',
            recibo_tesoreria.fecha_pago as 'FECHA DE PAGO',
            monto_fijo as 'MONTO AUTOVALUO',
            descuento_campania as '% DESC. CAMPAÑA',
            incremento_mora as 'INCR. MORA',
            descuento_mora as '% DESC. MORA',
            monto_pagado as 'MONTO PAGADO',
            cobrado as 'COBRADO POR',
            cod_recibo as 'CODIGO DE TICKET',
            cod_autovaluo as 'CODIGO DE AUTOVALUO',
            fecha_vencimiento as 'FECHA DE VENCIMIENTO'
            from recibo_tesoreria
            inner join recibo on recibo.idrecibo=recibo_tesoreria.cod_recibo
            where recibo_tesoreria.fecha_pago !=''", _conexion)
            _conectorMysql.Fill(_DatasetRecibo)
            _dtwRecibo.Table = _DatasetRecibo.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_recibo_like(ByVal fecha As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select
            idrecibo_tesoreria as 'CODIGO RECIBO',
            recibo_tesoreria.fecha_pago as 'FECHA DE PAGO',
            monto_fijo as 'MONTO DE AUTOVALUO',
            descuento_campania as '% DESC. CAMPAÑA',
            incremento_mora as 'INCR. MORA',
            descuento_mora as '% DESC. MORA',
            monto_pagado as 'MONTO PAGADO',
            cobrado as 'COBRADO POR',
            cod_recibo as 'CODIGO DE TICKET',
            cod_autovaluo as 'CODIGO DE AUTOVALUO',
            fecha_vencimiento as 'FECHA DE VENCIMIENTO'
            from recibo_tesoreria
            inner join recibo on recibo.idrecibo=recibo_tesoreria.cod_recibo
            where recibo_tesoreria.fecha_pago like '" + fecha + "%'", _conexion)
            _conectorMysql.Fill(_DatasetRecibo)
            _dtwRecibo.Table = _DatasetRecibo.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_recibo_tesoreria_autovaluo(ByVal codAutovaluo As String)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select
            idrecibo_tesoreria as 'CODIGO RECIBO',
            recibo_tesoreria.fecha_pago as 'FECHA DE PAGO',
            monto_fijo as 'MONTO DE AUTOVALUO',
            descuento_campania as '% DESC. CAMPAÑA',
            incremento_mora as 'INCR. MORA',
            descuento_mora as '% DESC. MORA',
            monto_pagado as 'MONTO PAGADO',
            cobrado as 'COBRADO POR',
            cod_recibo as 'CODIGO DE TICKET',
            cod_autovaluo as 'CODIGO DE AUTOVALUO',
            fecha_vencimiento as 'FECHA DE VENCIMIENTO'
            from recibo_tesoreria
            inner join recibo on recibo.idrecibo=recibo_tesoreria.cod_recibo
            where cod_autovaluo=" + codAutovaluo, _conexion)
            _conectorMysql.Fill(_DatasetReciboTesoreria)
            _dtwReciboTesoreria.Table = _DatasetReciboTesoreria.Tables(0)
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
