Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class class_controller_registrador
    Private _adaptador As New MySqlDataAdapter
    Private _DataSetReg As New DataSet
    Public Function insertarDatosReg(ByVal datos_Reg As class_datos_registrador) As Boolean
        Dim estado As Boolean = True
        Try
            conex_registroCivil()
            _adaptador.InsertCommand = New MySqlCommand("insert into registrador (prenombre,ape_paterno,ape_materno,dni) values (@nom,@ape_pat,@ape_mat,@dni)", _conexion_registroCivil)
            _adaptador.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45).Value = datos_Reg.nombre_registrador
            _adaptador.InsertCommand.Parameters.Add("@ape_pat", MySqlDbType.VarChar, 45).Value = datos_Reg.apePaterno_registrador
            _adaptador.InsertCommand.Parameters.Add("@ape_mat", MySqlDbType.VarChar, 45).Value = datos_Reg.apeMaterno_registrador
            _adaptador.InsertCommand.Parameters.Add("@dni", MySqlDbType.VarChar, 9).Value = datos_Reg.dni_registrador
            _conexion_registroCivil.Open()
            _adaptador.InsertCommand.Connection = _conexion_registroCivil
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar_registroCivil()
        End Try
        Return estado
    End Function
End Class
