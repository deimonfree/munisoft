﻿Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_vu_revestimiento
    Public _adaptador As New MySqlDataAdapter
    Public Function insertarDatosRevestimiento(ByVal datos As class_datos_vu_revestrimiento) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into vu_revestimiento(cod_categoria,valor,annio) values (@categoria,@valor,@annio)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@categoria", MySqlDbType.Int32).Value = datos.cod_categoria
            _adaptador.InsertCommand.Parameters.Add("@valor", MySqlDbType.Decimal).Value = datos.valor
            _adaptador.InsertCommand.Parameters.Add("@annio", MySqlDbType.VarChar, 45).Value = datos.annio
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function actualizRevestimiento(ByRef datos As class_datos_vu_revestrimiento) As Boolean
        Dim estado As Boolean = True
        Try
            conex_Global()
            _adaptador.UpdateCommand = New MySqlCommand("update vu_revestimiento set valor=@valor where idvu_revestimiento=@id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = datos.idrevestimiento
            _adaptador.UpdateCommand.Parameters.Add("@valor", MySqlDbType.VarChar, 45).Value = datos.valor
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
End Class
