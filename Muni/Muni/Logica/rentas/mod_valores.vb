Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_valores
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetValores As New DataSet
    Public _dtwValores As New DataView
    Public _dtValores As New DataTable

    Sub valores_muroColumnas_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT categoria, denominacion FROM td_muroscolumnas", _conexion)
            _conectorMysql.Fill(_DatasetValores)
            _dtwValores.Table = _DatasetValores.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub valores_techos_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT categoria, denominacion FROM td_techos", _conexion)
            _conectorMysql.Fill(_DatasetValores)
            _dtwValores.Table = _DatasetValores.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub valores_pisos_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT categoria, denominacion FROM tv_pisos", _conexion)
            _conectorMysql.Fill(_DatasetValores)
            _dtwValores.Table = _DatasetValores.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub valores_puertasVentanas_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT categoria, denominacion FROM tv_puertasVentanas", _conexion)
            _conectorMysql.Fill(_DatasetValores)
            _dtwValores.Table = _DatasetValores.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub valores_revistimiento_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT categoria, denominacion FROM tv_revestimiento", _conexion)
            _conectorMysql.Fill(_DatasetValores)
            _dtwValores.Table = _DatasetValores.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub valores_banos_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT categoria, denominacion FROM tv_banos", _conexion)
            _conectorMysql.Fill(_DatasetValores)
            _dtwValores.Table = _DatasetValores.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Sub valores_electricasSanitarias_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT categoria, denominacion FROM tv_electricassanitarias", _conexion)
            _conectorMysql.Fill(_DatasetValores)
            _dtwValores.Table = _DatasetValores.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    'optener valor muros y columnas
    Function valorUnitario_murosColumnas(ByVal cod_categoria As Integer, ByVal annio As String) As Double
        Dim nuevoid As Double
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select valor from vu_muroscolumnas where cod_categoria = @idCategoria and annio= @annio", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = cod_categoria
            _conectorMysql.SelectCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = annio
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            nuevoid = Convert.ToDouble(_conectorMysql.SelectCommand.ExecuteScalar())
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
        Return nuevoid
    End Function
    'optener valor muros y columnas
    Function valorUnitario_techos(ByVal cod_categoria As Integer, ByVal annio As String) As Double
        Dim nuevoid As Double
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select valor from vu_techos where cod_categoria = @idCategoria and annio= @annio", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = cod_categoria
            _conectorMysql.SelectCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = annio
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            nuevoid = Convert.ToDouble(_conectorMysql.SelectCommand.ExecuteScalar())
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
        Return nuevoid
    End Function
    'optener valor muros y columnas
    Function valorUnitario_pisos(ByVal cod_categoria As Integer, ByVal annio As String) As Double
        Dim nuevoid As Double
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select valor from vu_pisos where cod_categoria = @idCategoria and annio= @annio", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = cod_categoria
            _conectorMysql.SelectCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = annio
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            nuevoid = Convert.ToDouble(_conectorMysql.SelectCommand.ExecuteScalar())
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
        Return nuevoid
    End Function
    'optener valor muros y columnas
    Function valorUnitario_puertasVentanas(ByVal cod_categoria As Integer, ByVal annio As String) As Double
        Dim nuevoid As Double
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select valor from vu_puertasventanas where cod_categoria = @idCategoria and annio= @annio", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = cod_categoria
            _conectorMysql.SelectCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = annio
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            nuevoid = Convert.ToDouble(_conectorMysql.SelectCommand.ExecuteScalar())
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
        Return nuevoid
    End Function
    'optener valor muros y columnas
    Function valorUnitario_revestimiento(ByVal cod_categoria As Integer, ByVal annio As String) As Double
        Dim nuevoid As Double
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select valor from vu_revestimiento where cod_categoria = @idCategoria and annio= @annio", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = cod_categoria
            _conectorMysql.SelectCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = annio
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            nuevoid = Convert.ToDouble(_conectorMysql.SelectCommand.ExecuteScalar())
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
        Return nuevoid
    End Function
    'optener valor muros y columnas
    Function valorUnitario_banios(ByVal cod_categoria As Integer, ByVal annio As String) As Double
        Dim nuevoid As Double
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select valor from vu_banio where cod_categoria = @idCategoria and annio= @annio", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = cod_categoria
            _conectorMysql.SelectCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = annio
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            nuevoid = Convert.ToDouble(_conectorMysql.SelectCommand.ExecuteScalar())
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
        Return nuevoid
    End Function
    'optener valor muros y columnas
    Function valorUnitario_elecSanitarias(ByVal cod_categoria As Integer, ByVal annio As String) As Double
        Dim nuevoid As Double
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select valor from vu_electricidadsanitarias where cod_categoria = @idCategoria and annio= @annio", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = cod_categoria
            _conectorMysql.SelectCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = annio
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            nuevoid = Convert.ToDouble(_conectorMysql.SelectCommand.ExecuteScalar())
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
        Return nuevoid
    End Function
    'cargar datos sector
    Function cargar_datos_MC(ByVal id As String) As String
        Dim valor As String = ""
        _DatasetSector.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from td_muroscolumnas where categoria= @id", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@id", MySqlDbType.VarChar, 45).Value = id
            _conectorMysql.Fill(_DatasetVia)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetVia.Tables(0).Rows
                valor = row("denominacion")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
        Return valor
    End Function
    Function cargar_datos_TE(ByVal id As String) As String
        Dim valor As String = ""
        _DatasetSector.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from td_techos where categoria= @id", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@id", MySqlDbType.VarChar, 45).Value = id
            _conectorMysql.Fill(_DatasetVia)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetVia.Tables(0).Rows
                valor = row("denominacion")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
        Return valor
    End Function
    Function cargar_datos_PI(ByVal id As String) As String
        Dim valor As String = ""
        _DatasetSector.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from tv_pisos where categoria= @id", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@id", MySqlDbType.VarChar, 45).Value = id
            _conectorMysql.Fill(_DatasetVia)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetVia.Tables(0).Rows
                valor = row("denominacion")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
        Return valor
    End Function
    Function cargar_datos_PV(ByVal id As String) As String
        Dim valor As String = ""
        _DatasetSector.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from tv_puertasventanas where categoria= @id", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@id", MySqlDbType.VarChar, 45).Value = id
            _conectorMysql.Fill(_DatasetVia)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetVia.Tables(0).Rows
                valor = row("denominacion")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
        Return valor
    End Function
    Function cargar_datos_RE(ByVal id As String) As String
        Dim valor As String = ""
        _DatasetSector.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from tv_revestimiento where categoria= @id", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@id", MySqlDbType.VarChar, 45).Value = id
            _conectorMysql.Fill(_DatasetVia)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetVia.Tables(0).Rows
                valor = row("denominacion")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
        Return valor
    End Function
    Function cargar_datos_BA(ByVal id As String) As String
        Dim valor As String = ""
        _DatasetSector.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from tv_banos where categoria= @id", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@id", MySqlDbType.VarChar, 45).Value = id
            _conectorMysql.Fill(_DatasetVia)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetVia.Tables(0).Rows
                valor = row("denominacion")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
        Return valor
    End Function
    Function cargar_datos_IE(ByVal id As String) As String
        Dim valor As String = ""
        _DatasetSector.Reset()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select * from tv_electricassanitarias where categoria= @id", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@id", MySqlDbType.VarChar, 45).Value = id
            _conectorMysql.Fill(_DatasetVia)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetVia.Tables(0).Rows
                valor = row("denominacion")
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try
        Return valor
    End Function
End Module
