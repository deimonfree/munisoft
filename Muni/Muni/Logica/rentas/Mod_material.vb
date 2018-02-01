Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module Mod_material
    Private _adapatador As New MySqlDataAdapter
    Public _dtsMaterial As New DataSet
    Public _dtvTmaterial As New DataView
    Sub consulta_datos_depMaterial_name()
        Try
            conex_Global()
            _adapatador.SelectCommand = New MySqlCommand("select nombre from dep_material;", _conexion)
            _adapatador.Fill(_dtsMaterial)
            _dtvTmaterial.Table = _dtsMaterial.Tables(0)
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
