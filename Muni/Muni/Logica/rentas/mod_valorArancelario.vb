Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_valorArancelario
    Private _conectorMysql As New MySqlDataAdapter
    Public _DatasetValorArancelario As New DataSet
    Public _dtwValorArancelario As New DataView
    Sub consulta_datos_valorArancelario_all()
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select valor_arancelario.idvalor_aracenlario, tipo_via.nom_tipovia, via.nombre, valor_arancelario.cuadra, valor_arancelario.valor , anno.anno from tipo_via inner join via on tipo_via.idtipo_via = via.tipo inner join  valor_arancelario 	on via.idvia = valor_arancelario.cod_via inner join anno on  valor_arancelario.cod_anno= anno.idanno ", _conexion)
            _conectorMysql.Fill(_DatasetValorArancelario)
            _dtwValorArancelario.Table = _DatasetValorArancelario.Tables(0)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Public Function contarDatos_ValorArancelario(codVia As Integer, codAnno As Integer) As Integer

        Dim newProdID As Int32 = 0
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT COUNT(idvalor_aracenlario) AS total FROM valor_arancelario where cod_via= @codVia and cod_anno= @codAnno", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@codVia", MySqlDbType.Int32).Value = codVia
            _conectorMysql.SelectCommand.Parameters.Add("@codAnno", MySqlDbType.Int32).Value = codAnno
            _conectorMysql.Fill(_DatasetValorArancelario)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            newProdID = Convert.ToInt32(_conectorMysql.SelectCommand.ExecuteScalar())
            'obteniendo el ultimo registro

            '_adaptador.SelectCommand = New MySqlCommand("SELECT DISTINCT LAST_INSERT_ID() as recc FROM contribuyente", _conexion)
            '_adaptador.Fill(_DatasetContribuyente)
            '_adaptador.SelectCommand.Connection = _conexion
            '_adaptador.SelectCommand.ExecuteNonQuery()
            'For Each row In _DatasetContribuyente.Tables(0).Rows
            '    datos_contribuyente.id_contribuyente = row(0)

            'Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            newProdID = 0
        Finally
            cerrar()
        End Try
        Return newProdID
    End Function
    Sub cargar_datos_Arancelarios(ByVal idvia As Integer, ByVal idcuadra As Integer, ByVal idanno As Integer, ByVal datos_arancel As class_datos_valorArancelario)
        _DatasetValorArancelario.Reset()
        Try
            conex_Global()

            _conectorMysql.SelectCommand = New MySqlCommand("select * from valor_arancelario where cod_via= @via and cod_anno = @anno and cuadra=@cuadra", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@via", MySqlDbType.Int32).Value = idvia
            _conectorMysql.SelectCommand.Parameters.Add("@anno", MySqlDbType.Int32).Value = idanno
            _conectorMysql.SelectCommand.Parameters.Add("@cuadra", MySqlDbType.Int32).Value = idcuadra
            _conectorMysql.Fill(_DatasetValorArancelario)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            _conectorMysql.SelectCommand.ExecuteNonQuery()
            For Each row In _DatasetValorArancelario.Tables(0).Rows
                datos_arancel.id_valorArancelario = row("idvalor_aracenlario")
                datos_arancel.codVia_valorArancelario = row("cod_via")
                datos_arancel.codAnno_valorArancelario = row("cod_anno")
                datos_arancel.valor_valorArancelario = row("valor")
                datos_arancel.cuadra_valorArancelario = row("cuadra")

            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            cerrar()
        End Try

    End Sub
    Public Function ultimoDato_ValorArancelario(codVia As Integer, codAnno As Integer) As Integer

        Dim ultimaCuadra As Int32 = 0
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("SELECT cuadra FROM munisystem.valor_arancelario where cod_anno= @codAnno and cod_via= @codVia order by cuadra desc limit 1", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@codVia", MySqlDbType.Int32).Value = codVia
            _conectorMysql.SelectCommand.Parameters.Add("@codAnno", MySqlDbType.Int32).Value = codAnno
            _conectorMysql.Fill(_DatasetValorArancelario)
            _conexion.Open()
            _conectorMysql.SelectCommand.Connection = _conexion
            ultimaCuadra = Convert.ToInt32(_conectorMysql.SelectCommand.ExecuteScalar())

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            ultimaCuadra = 1
        Finally
            cerrar()
        End Try
        Return ultimaCuadra
    End Function
    Sub consulta_datos_valorArancelario_by(ByVal codVia, ByVal codAnio)
        Try
            conex_Global()
            _conectorMysql.SelectCommand = New MySqlCommand("select valor_arancelario.idvalor_aracenlario, tipo_via.nom_tipovia, via.nombre, valor_arancelario.cuadra, valor_arancelario.valor , anno.anno from tipo_via inner join via on tipo_via.idtipo_via = via.tipo inner join  valor_arancelario on via.idvia = valor_arancelario.cod_via inner join anno on  valor_arancelario.cod_anno= anno.idanno where valor_arancelario.cod_via = @codvia and anno.idanno = @codanio  ", _conexion)
            _conectorMysql.SelectCommand.Parameters.Add("@codvia", MySqlDbType.Int32).Value = codVia
            _conectorMysql.SelectCommand.Parameters.Add("@codanio", MySqlDbType.Int32).Value = codAnio
            _conectorMysql.Fill(_DatasetValorArancelario)
            _dtwValorArancelario.Table = _DatasetValorArancelario.Tables(0)
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

