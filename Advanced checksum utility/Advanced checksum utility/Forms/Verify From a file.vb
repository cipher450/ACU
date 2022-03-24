Public Class Verify_From_a_file
    Public File As String
    Dim Trd As Threading.Thread
    Dim usedAlgo As String
    
    Sub Verf()
        Label4.Visible = True
        Dim lvp As New ListViewItem
        Dim Yes As Integer
        Dim No As Integer
        For Each File As ListViewItem In ListView1.Items
            Dim fl As New IO.FileInfo(File.Text)

            Dim GivenHash As String = File.SubItems(1).Text
            Dim ClacHash As String







            If fl.Exists = False Then
                File.SubItems(2).Text = "File not Found "
                File.ImageIndex = 1
            Else
                If CheckBox1.Checked = True Then

                    With GivenHash
                        If .Length = 8 Or .Length = 9 Or .Length = 10 Then
                            ComboBox2.SelectedIndex = 5
                            ClacHash = GetCRC32(fl.FullName)
                        End If
                        If .Length = 32 Or .Length = 33 Or .Length = 34 Or .Length = 35 Then
                            ComboBox2.SelectedIndex = 0
                            ClacHash = MD5Checksum(fl.FullName)
                        End If
                        If .Length = 40 Or .Length = 41 Or .Length = 42 Or .Length = 43 Then
                            ComboBox2.SelectedIndex = 1
                            ClacHash = hash_generator("sha1", fl.FullName)
                        End If
                        If .Length = 64 Or .Length = 65 Or .Length = 66 Or .Length = 67 Then
                            ComboBox2.SelectedIndex = 2
                            ClacHash = hash_generator("sha256", fl.FullName)
                        End If
                        If .Length = 96 Or .Length = 97 Or .Length = 98 Or .Length = 99 Or .Length = 100 Then
                            ComboBox2.SelectedIndex = 3
                            ClacHash = hash_generator("sha384", fl.FullName)
                        End If
                        If .Length = 128 Or .Length = 129 Or .Length = 130 Or .Length = 131 Then
                            ComboBox2.SelectedIndex = 4
                            ClacHash = hash_generator("sha512", fl.FullName)
                        End If
                        If .Length = 40 Or .Length = 41 Or .Length = 41 Or .Length = 41 Then
                            ComboBox2.SelectedIndex = 6
                            ClacHash = Ripemd160_File(fl.FullName)
                        End If

                    End With
                Else
                    With ComboBox2
                        If .SelectedIndex = 0 Then
                            ClacHash = MD5Checksum(fl.FullName)
                        End If
                        If .SelectedIndex = 1 Then
                            ClacHash = hash_generator("sha1", fl.FullName)
                        End If
                        If .SelectedIndex = 2 Then
                            ClacHash = hash_generator("sha256", fl.FullName)
                        End If
                        If .SelectedIndex = 3 Then
                            ClacHash = hash_generator("sha384", fl.FullName)
                        End If
                        If .SelectedIndex = 4 Then
                            ClacHash = hash_generator("sha512", fl.FullName)
                        End If
                        If .SelectedIndex = 5 Then
                            ClacHash = GetCRC32(fl.FullName)
                        End If
                        If .SelectedIndex = 6 Then
                            ClacHash = Ripemd160_File(fl.FullName)
                        End If
                    End With
                End If
                If GivenHash = ClacHash Then

                    File.SubItems(2).Text = "Hash match"
                    File.ImageIndex = 0
                    Yes = Yes + 1
                Else
                    File.SubItems(2).Text = "Hash doesn't match"
                    File.ImageIndex = 1
                    No = No + 1
                End If

            End If

        Next
        If Not No = 0 Then
            If Settings.ComboBox1.SelectedIndex = 1 Then
                Label4.Text = No & " " & "Hash ne correspond pas"
                Label4.Visible = True
            Else
                Label4.Text = No & " " & "Hash doesn't match"
                Label4.Visible = True
            End If
           
        Else
            If Settings.ComboBox1.SelectedIndex = 1 Then
                Label4.Text = "Tout les Hash correspond "
                Label4.Visible = True
            Else


                Label4.Text = "All Hash Match"
                Label4.Visible = True
            End If
        End If
    End Sub
    Private Sub Verify_From_a_file_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Settings.ComboBox1.SelectedIndex = 1 Then
            Franch()
        End If
        If Settings.ComboBox2.Text = "Dark" Then

            DarkTheme()
        End If
        Try
            Dim Lunchpath As String
            Dim lines = IO.File.ReadAllLines(File)
            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(lines)
            Dim f As New IO.FileInfo(File)
            Lunchpath = f.Directory.FullName
            Dim lvp As New ListViewItem

            For Each o As Object In ListBox1.Items
                'o = le path 
                Dim Hash As String = o.ToString.Split(" ").Last
                Dim Path As String = o.ToString.Split(" ").First
                lvp = ListView1.Items.Add(Lunchpath & "\" & Path)
                Hash = Hash.ToUpper
                With Hash
                    If .Length = 8 Or .Length = 9 Or .Length = 10 Then
                        ComboBox2.SelectedIndex = 5

                    End If
                    If .Length = 32 Or .Length = 33 Or .Length = 34 Or .Length = 35 Then
                        ComboBox2.SelectedIndex = 0

                    End If
                    If .Length = 40 Or .Length = 41 Or .Length = 42 Or .Length = 43 Then
                        ComboBox2.SelectedIndex = 1

                    End If
                    If .Length = 64 Or .Length = 65 Or .Length = 66 Or .Length = 67 Then
                        ComboBox2.SelectedIndex = 2

                    End If
                    If .Length = 96 Or .Length = 97 Or .Length = 98 Or .Length = 99 Or .Length = 100 Then
                        ComboBox2.SelectedIndex = 3

                    End If
                    If .Length = 128 Or .Length = 129 Or .Length = 130 Or .Length = 131 Then
                        ComboBox2.SelectedIndex = 4

                    End If
                    If .Length = 40 Or .Length = 41 Or .Length = 41 Or .Length = 41 Then
                        ComboBox2.SelectedIndex = 6

                    End If
                End With
                lvp.SubItems.Add(Hash)
                lvp.SubItems.Add(" ")
                lvp.ImageIndex = 2
            Next
            Me.Text = f.Name & " [BETA]"




            ListBox1.Items.Remove("")

        Catch ex As Exception
            ErrorRep(ex.Message, ex.ToString)

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Trd = New Threading.Thread(AddressOf Verf)
        Trd.SetApartmentState(Threading.ApartmentState.STA)
        Trd.IsBackground = True
        Trd.Start()
        isAlive.Start()
    End Sub

   

    Private Sub isAlive_Tick(sender As Object, e As EventArgs) Handles isAlive.Tick
        If Trd.IsAlive = True Then
            Panel2.Visible = True
            ListView1.Enabled = False
        Else
            isAlive.Stop()
            Panel2.Visible = False
            ListView1.Enabled = True
        End If
    End Sub

    

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            ComboBox2.Enabled = True
            If Settings.ComboBox2.SelectedIndex = 1 Then
                MsgBox("Vous devez utiliser le même algorithme utilisé sur le fichier de vérification.", MsgBoxStyle.Information)
            Else
                MsgBox("You must use the same algorithm used on the verification file.", MsgBoxStyle.Information)
            End If
        Else
            ComboBox2.Enabled = False
        End If

    End Sub
End Class