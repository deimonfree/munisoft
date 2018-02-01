Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class cu_almacen
    Dim _adaptador, _adaptador2, _adaptador3 As New MySqlDataAdapter
    Dim _ds, _ds2, _ds3 As New DataSet
    Dim lectura As Integer
    Dim total As Integer
    Dim usuario As New class_controller_usuario

    Private Sub model2_Click(sender As Object, e As EventArgs)
        MDI_registro_civil.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        MDI_registro_civil.Show()
    End Sub

    Dim data_user As New class_data_user
    Dim modulo As New class_contoller_module

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cu_modulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim all_module As Integer
        Dim i As Integer
        usuario.user_data(data_user, My.User.Name)
        all_module = modulo.all_module()
        Dim arrValues() As Integer
        ' -- Llama a la función y retorna el arreglo  
        arrValues = modulo.validation_module(data_user.iduser_user)
        ' -- rrecorrer todos los modulos
        For i = LBound(arrValues) To UBound(arrValues)
            Dim nombre As String
            nombre = "model" & CStr(arrValues(i))
            Select Case nombre
                Case Trim(model1.Name)
                    model1.Enabled = False
                Case Trim(model2.Name)
                    model2.Enabled = False
            End Select
        Next
        Erase arrValues
    End Sub
End Class
