Public Class uc_ciudadano
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        AxAcroPDF1.LoadFile(OpenFileDialog1.FileName)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim NOMBRE As String = OpenFileDialog1.FileName
            NOMBRE = NOMBRE.Remove(0, NOMBRE.LastIndexOf("\"))
            SaveFileDialog1.FileName = "puk.pdf"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Try
                    My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, SaveFileDialog1.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.FileSystem.CopyFile("D:\prueba\maqueta.pdf", "W:\registro_civil\maqueta.pdf")
    End Sub
End Class
