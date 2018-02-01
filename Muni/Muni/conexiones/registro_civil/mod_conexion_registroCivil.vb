Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_conexion_registroCivil
    Public _cadena_registroCivil As String
    Public _conexion_registroCivil As New MySqlConnection

    'conexion global
    Public Function conex_registroCivil() As Boolean
        Dim estado As Boolean = True
        Try
            _cadena_registroCivil = ("server=192.168.1.240;user id=admin;password=s1st3m4s;database=bdmun_registro_civil")
            _conexion_registroCivil = New MySqlConnection(_cadena_registroCivil)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False

        End Try
        Return estado
    End Function

    'CERRAR CONEXION GLOBAL
    Public Sub cerrar_registroCivil()
        _conexion_registroCivil.Close()
    End Sub
End Module
