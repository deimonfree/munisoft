Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_depreciacion
    Private _adapatador As New MySqlDataAdapter
    Public _dtsdep, _dtsdep1, _dtsdep2, _dtsdep3, _dtsdep4, _dtsdep5, _dtsdep6, _dtsdep7, _dtsdep8, _dtsdep9, _dtsdep10, _dtsdep11, _dtsdep12, _dtsdep13, _dtsdep14, _dtsdep15, _dtsdep16 As New DataSet
    Public _dtvdep, _dtvdep1, _dtvdep2, _dtvdep3, _dtvdep4, _dtvdep5, _dtvdep6, _dtvdep7, _dtvdep8, _dtvdep9, _dtvdep10, _dtvdep11, _dtvdep12, _dtvdep13, _dtvdep14, _dtvdep15, _dtvdep16 As New DataView

    Sub consulta_datos_central_r1(ByRef anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=1 and cod_conservacion=1 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep1)
            _dtvdep1.Table = _dtsdep1.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r2(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=1 and cod_conservacion=2 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep2)
            _dtvdep2.Table = _dtsdep2.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r3(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=1 and cod_conservacion=3 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep3)
            _dtvdep3.Table = _dtsdep3.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r4(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=1 and cod_conservacion=4 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep4)
            _dtvdep4.Table = _dtsdep4.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    ' Codigo de consulta para el segundo bloque
    Sub consulta_datos_central_r5(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=2 and cod_conservacion=1 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep5)
            _dtvdep5.Table = _dtsdep5.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r6(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=2 and cod_conservacion=2 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep6)
            _dtvdep6.Table = _dtsdep6.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r7(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=2 and cod_conservacion=3 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep7)
            _dtvdep7.Table = _dtsdep7.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r8(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=2 and cod_conservacion=4 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep8)
            _dtvdep8.Table = _dtsdep8.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    ' Codigo de consulta para el tercer bloque
    Sub consulta_datos_central_r9(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=3 and cod_conservacion=1 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep9)
            _dtvdep9.Table = _dtsdep9.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r10(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=3 and cod_conservacion=2 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep10)
            _dtvdep10.Table = _dtsdep10.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r11(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=3 and cod_conservacion=3 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep11)
            _dtvdep11.Table = _dtsdep11.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r12(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=3 and cod_conservacion=4 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep12)
            _dtvdep12.Table = _dtsdep12.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    'Codigo de consulta para el cuarto bloque
    Sub consulta_datos_central_r13(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=4 and cod_conservacion=1 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep13)
            _dtvdep13.Table = _dtsdep13.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r14(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=4 and cod_conservacion=2 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep14)
            _dtvdep14.Table = _dtsdep14.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r15(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=4 and cod_conservacion=3 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep15)
            _dtvdep15.Table = _dtsdep15.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub consulta_datos_central_r16(ByVal anio As String)
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select * from depreciacion  where cod_clasificacion=4 and cod_conservacion=4 and anno=" + anio + ";", _conexion)
            _adapatador.Fill(_dtsdep16)
            _dtvdep16.Table = _dtsdep16.Tables(0)
            _conexion.Open()
            _adapatador.SelectCommand.Connection = _conexion
            _adapatador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

End Module
