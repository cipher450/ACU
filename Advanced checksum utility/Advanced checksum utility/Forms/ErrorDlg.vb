Public Class ErrorDlg

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Clipboard.SetText(TextBox1.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ErrorDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Settings.ComboBox1.SelectedIndex = 1 Then
            Franch()
        End If
        If Settings.ComboBox2.Text = "Dark" Then

            DarkTheme()
        End If
    End Sub
  
End Class