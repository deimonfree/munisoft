Public Class uc_rentas_valor_minimo
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'sidePanel.Visible = True
        'sidePanel.Width = btnSave.Width
        'sidePanel.Top = btnSave.Bottom
        'sidePanel.Location = btnSave.Location
        Dim ultimo_annio As String
        ultimo_annio = cbxAnnio.Text
        _DatasetMinimo.Reset()
        consulta_datos_valor_minimo(ultimo_annio)
        If _DatasetMinimo.Tables(0).Rows.Count > 0 Then
            MessageBox.Show("Uds. ya ha generado el valores minimos para el " + ultimo_annio.ToString)
        Else
            If alta() = True Then
                MessageBox.Show("Lo sentimos no podemos procesar su información debido a que hay campos vacios", "Error: 001",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim controller As New class_controller_valor_minimo
                Dim datos As New class_datos_valor_minimo
                datos.val_minimo = txtValorUit.Text
                datos.annio = cbxAnnio.Text
                If controller.insertarDatosValorMinimo(datos) Then
                    MessageBox.Show("Datos guardados...!!!", "Valor minimo de impuesto predial")
                    cargar_valores_minimos()
                    clear()
                    'sidePanel.Visible = False
                Else
                    MessageBox.Show("Datos no guarados :(")
                End If
            End If
        End If
    End Sub
    Private Function alta() As Boolean
        Dim valor_alta As Boolean = False
        pbNombre.Visible = False
        pbNombre.Visible = False
        Select Case ""
            Case Trim(txtValorUit.Text)
                valor_alta = True
                pbNombre.Visible = True
            Case Trim(cbxAnnio.Text)
                valor_alta = True
                pbNombre.Visible = True
        End Select
        Return valor_alta
    End Function
    Sub clear()
        txtValorUit.Text = ""
        txtValorUit.Select()
    End Sub

    Private Sub uc_rentas_valor_minimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _DatasetAnnio.Reset()
        consulta_datos_annio()
        cbxAnnio.DataSource = _DatasetAnnio.Tables("annio")
        cbxAnnio.DisplayMember = "anno"
        cbxAnnio.ValueMember = "idanno"
        cargar_valores_minimos()
    End Sub
    Sub cargar_valores_minimos()
        _DatasetMinimo.Reset()
        consulta_datos_valor_minimo_all()
        dgwPredio.DataSource = _dtwMinimo
    End Sub

    Private Sub txtValorUit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorUit.KeyPress
        ' Referenciamos el control TextBox que ha desencadeno el evento
        '
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' Carácter separador decimal existente actualmente
        ' en la configuración regional de windows. 
        ' 
        Dim separadorDecimal As String =
           Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Si en el control hay ya escrito un separador decimal, 
            ' deshechamos insertar otro separador más. 
            ' 
            If (tb.Text.IndexOf(separadorDecimal) >= 0) And Not (tb.SelectionLength <> 0) Then
                e.Handled = True
                Return

            Else
                If ((tb.TextLength = 0) OrElse (tb.SelectionLength > 0) OrElse
                  ((tb.TextLength = 1) And (tb.Text.Chars(0) = "-"c))) Then
                    ' Si no hay ningún número, insertamos un cero
                    ' antes del separador decimal.
                    tb.SelectedText = "0"
                End If

                ' Insertamos el separador decimal. 
                '
                e.KeyChar = CChar(separadorDecimal)
                Return
            End If
        End If

        If (Convert.ToInt32(e.KeyChar) = 8) Then
            ' Se ha pulsado la tecla retroceso 
            Return

        ElseIf (e.KeyChar = "-"c) Then
            ' Únicamente si no está seleccionado el texto del control 
            If (tb.SelectionLength = 0) Then
                ' Si en el control hay ya escrito un signo menos, 
                ' deshechamos todos los que posteriormente se escriban 
                If (tb.Text.IndexOf("-"c) >= 0) Then
                    e.Handled = True
                    Return
                End If

                ' Solo permito el signo menos si aparece en primera posición 
                '
                e.Handled = (tb.SelectionStart <> 0)
            End If

        ElseIf (Not (Char.IsDigit(e.KeyChar))) Then
            ' No se ha pulsado un dígito. 
            e.Handled = True
            Return

        End If

        ' Si existe el separador decimal, no permitimos que
        ' se escriban más de dos números decimales.
        '
        Dim index As Integer = tb.Text.IndexOf(separadorDecimal)

        If (index >= 0) Then
            Dim decimales As String = tb.Text.Substring(index + 1)
            e.Handled = (decimales.Length = 2)
        End If

        ' Si el texto del control actualmente está seleccionado, 
        ' permitimos que se pueda reemplazar por el carácter tecleado.
        '
        If (tb.SelectionLength > 0) Then e.Handled = False
    End Sub
End Class
