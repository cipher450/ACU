Public Class ErrorDlg

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Clipboard.SetText(TextBox1.Text)

        Catch ex As Exception

        End Try
    End Sub
End Class