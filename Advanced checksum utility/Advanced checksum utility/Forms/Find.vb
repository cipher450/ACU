Public Class Find

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim itm As ListViewItem
            With Form1.Files_List
                itm = .FindItemWithText(TextBox1.Text, CheckBox2.Checked, 0, CheckBox3.Checked)
                If Not itm Is Nothing Then
                    .Items.Item(itm.Index).Selected = True

                    Form1.Select()

                Else
                    MsgBox("Nothing found !", MsgBoxStyle.Information, "Find ")
                End If
            End With
            itm = Nothing
        Catch ex As Exception
            MsgBox("Nothing found !", MsgBoxStyle.Information, "Find ")
        End Try
       


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   
  
    Private Sub Find_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Settings.ComboBox1.SelectedIndex = 1 Then
            Franch()
        End If
        If Settings.ComboBox2.Text = "Dark" Then

            DarkTheme()
        End If
    End Sub
End Class