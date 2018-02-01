Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_usuario
    Private _adaptador As New MySqlDataAdapter
    Private _dtsUsuario As New DataSet
    Public user_name As String

    Sub user_data(ByVal data_user As class_data_user, ByVal UserName As String)
        Try
            conex_Global()
            _adaptador.SelectCommand = New MySqlCommand("select * from user where usuario =@usuario", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@usuario", MySqlDbType.VarChar, 45).Value = UserName
            _adaptador.Fill(_dtsUsuario)
            For Each row In _dtsUsuario.Tables(0).Rows
                data_user.iduser_user = row("iduser")
                data_user.usuario_user = row("usuario")
                data_user.password_user = row("password")
            Next
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
End Class
