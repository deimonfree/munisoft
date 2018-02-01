Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_registrador
    Private _adapatador As New MySqlDataAdapter
    Public _dtsregistrador As New DataSet
    Public _dtvdatos As New DataView
    Sub consulta_show_resgistrador(ByVal datos_registrador As class_datos_registrador, ByVal valordni As String)
        Try
            conex_registroCivil()
            _adapatador.SelectCommand = New MySqlCommand("select * from registrador where dni =" + valordni + "", _conexion_registroCivil)
            _adapatador.Fill(_dtsregistrador)
            For Each row In _dtsregistrador.Tables(0).Rows
                datos_registrador.nombre_registrador = row("prenombre")
                datos_registrador.apePaterno_registrador = row("ape_paterno")
                datos_registrador.apeMaterno_registrador = row("ape_materno")
                datos_registrador.dni_registrador = row("dni")
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cerrar_registroCivil()
        End Try
    End Sub
End Module
