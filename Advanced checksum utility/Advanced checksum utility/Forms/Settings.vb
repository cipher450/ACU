Imports Microsoft.Win32

Public Class Settings
    Dim OldValue As String = 0
    Dim NewValue As String = 0
    Dim OldValue2 As String = 0
    Dim NewValue2 As String = 0

    Private Const MenuName As String = "Folder\shell\NewMenuOption"
    Private Const Command As String = "Folder\shell\NewMenuOption\command"

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBox1.Text = "Français" Then
            Franch()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBox2.Text = "Dark" Then
            DarkTheme()
        End If
    End Sub
    Function chekadmin() As Boolean
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            Return True
        Else
            Return False
        End If

    End Function
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If chekadmin() = True Then
            CheckBox1.Enabled = True
            PictureBox10.Visible = False
        Else
            CheckBox1.Enabled = False
            PictureBox10.Visible = True
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Me.Text = "Paramètres"
        Else
            Me.Text = "Settings"
        End If
        If Me.ComboBox1.SelectedIndex = 1 Then
            Franch()
        End If
        If Me.ComboBox2.Text = "Dark" Then

            DarkTheme()
        End If
        NewValue = ComboBox1.SelectedIndex
        If Me.ComboBox2.Text = "Dark" Then

            DarkTheme()
        End If
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Visible = False

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        NewValue = ComboBox1.SelectedIndex
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button3.BackgroundImage.Save("C:\Users\hadja\Desktop\123\img1.png")

        If Not OldValue = NewValue Or Not OldValue2 = NewValue2 Then
            If ComboBox1.SelectedIndex = 1 Then
                MsgBox("Vous devez redémarrer l'application pour appliquer ces modifications", MsgBoxStyle.Exclamation)
            Else
                MsgBox("You must restart the application to apply these changes", MsgBoxStyle.Exclamation)

            End If

        End If

        If ComboBox1.SelectedIndex = 1 Then
            Franch()
        End If
        If ComboBox2.SelectedIndex = 0 Then
            DarkTheme()
        End If
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.BackgroundImage.Save("C:\Users\hadja\Desktop\123\img2.png")

        Me.Close()
    End Sub
    Sub AddToReg()
        Dim regmenu As RegistryKey = Nothing
        Dim regcmd As RegistryKey = Nothing
        Try
            regmenu = Registry.ClassesRoot.CreateSubKey(MenuName)
            If regmenu IsNot Nothing Then
                regmenu.SetValue("", "Hashit")
            End If
            regcmd = Registry.ClassesRoot.CreateSubKey(Command)
            If regcmd IsNot Nothing Then
                regcmd.SetValue("", Application.ExecutablePath & " " & """%1""")
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.ToString())
        Finally
            If regmenu IsNot Nothing Then
                regmenu.Close()
            End If
            If regcmd IsNot Nothing Then
                regcmd.Close()
            End If
        End Try
    End Sub
    Sub RemoveReg()
        Try
            Dim reg As RegistryKey = Registry.ClassesRoot.OpenSubKey(Command)
            If reg IsNot Nothing Then
                reg.Close()
                Registry.ClassesRoot.DeleteSubKey(Command)
            End If
            reg = Registry.ClassesRoot.OpenSubKey(MenuName)
            If reg IsNot Nothing Then
                reg.Close()
                Registry.ClassesRoot.DeleteSubKey(MenuName)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.ToString())
        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            AddToReg()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\*\shell\Hashit", "Hashit", "Hashit")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\*\shell\Hashit\command", "", Application.ExecutablePath & " " & """%1""")
        Else
            RemoveReg()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\*\shell\Hashit", "Hashit", "Hashit")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Classes\*\shell\Hashit\command", "", Application.ExecutablePath & " " & """%1""")
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub
End Class