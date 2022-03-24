Imports System.Runtime.InteropServices
Imports System.Reflection

Public Class Properties
    Private ico As Icon = Nothing
    Dim icondufile As Bitmap
    Dim trd As Threading.Thread

    Private Sub Properties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Settings.ComboBox1.SelectedIndex = 1 Then
            Franch()
        End If
        If Settings.ComboBox2.Text = "Dark" Then

            DarkTheme()
        End If
        Control.CheckForIllegalCrossThreadCalls = False
        Me.ListView1.Items(0).Focused = True
        Me.ListView1.Items(0).Selected = True
    End Sub
    <DllImport("shell32.dll")> _
    Private Shared Function ExtractAssociatedIcon(ByVal hInst As IntPtr, <MarshalAs(UnmanagedType.LPStr)> _
  ByVal lpIconPath As String, ByRef lpiIcon As Integer) As IntPtr
    End Function
    Sub GetHash()
        Dim FilePathe As String = fl


        Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
        Dim iIcon As Int32 = 0
        Dim hIcon As IntPtr
        hIcon = ExtractAssociatedIcon(hInst, FilePathe, iIcon)
        ico = Icon.FromHandle(hIcon)
        icondufile = ico.ToBitmap
        PictureBox1.Image = icondufile

        TextBox1.Text = FilePathe
        Md5.Text = MD5Checksum(FilePathe)
        Sha1.Text = hash_generator("sha1", FilePathe)
        Sha256.Text = hash_generator("sha256", FilePathe)
        Sha512.Text = hash_generator("sha512", FilePathe)
        Sha384.Text = hash_generator("sha384", FilePathe)
        Crc32.Text = GetCRC32(FilePathe)
        RIPEMD160.Text = Ripemd160_File(FilePathe)
        Dim Fileinfo As New IO.FileInfo(FilePathe)
        FileAtri.Text = Fileinfo.Attributes.ToString
        Extension.Text = Fileinfo.Extension
        Modiftime.Text = Fileinfo.LastWriteTime
        CreatedTime.Text = Fileinfo.CreationTime
        Filename.Text = Fileinfo.Name

        Size.Text = roundObjectSize(Fileinfo.Length)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    
    Private Function checkIfValueIsDecimal(ByVal value As String) As String
        Dim result As String
        If value.Contains(",") Then : result = CDbl(value).ToString("###.##")
        Else : result = CDbl(value).ToString("###.00") : End If
        Return result
    End Function

    Private Function roundObjectSize(ByVal ObjectSize As String) As String
        Dim oneByte As Integer = 1
        Dim kiloByte As Integer = 1024
        Dim megaByte As Integer = 1048576
        Dim gigaByte As Integer = 1073741824
        Dim terraByte As Long = 1099511627776
        Dim pettaByte As Long = 1125899906842624

        Select Case CLng(ObjectSize)
            Case 0 To kiloByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / oneByte))) >= 1000) = False Then
                    ObjectSize = CStr(CInt(ObjectSize) / 1) + " Bytes"
                Else : ObjectSize = "1,00 KB" : End If

            Case kiloByte To megaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / kiloByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / kiloByte)) + " KB"
                Else : ObjectSize = "1,00 MB" : End If

            Case megaByte To gigaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / megaByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / megaByte)) + " MB"
                Else : ObjectSize = "1,00 GB" : End If

            Case gigaByte To terraByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / gigaByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / gigaByte)) + " GB"
                Else : ObjectSize = "1,00 TB" : End If

            Case terraByte To pettaByte - 1
                If (CDbl(checkIfValueIsDecimal(CStr(CDec(ObjectSize) / terraByte))) >= 1000) = False Then
                    ObjectSize = checkIfValueIsDecimal(CStr(CDec(ObjectSize) / terraByte)) + " TB"
                Else : ObjectSize = "1,00 PB" : End If
        End Select
        Return ObjectSize
    End Function


    Sub Upper()
        Md5.Text = Md5.Text.ToUpper()
        Sha1.Text = Sha1.Text.ToUpper()
        Sha384.Text = Sha384.Text.ToUpper()
        Sha256.Text = Sha384.Text.ToUpper
        Sha512.Text = Sha512.Text.ToUpper()
        Crc32.Text = Crc32.Text.ToUpper()
        RIPEMD160.Text = RIPEMD160.Text.ToUpper
    End Sub
    Sub Lower()
        Md5.Text = Md5.Text.ToLower()
        Sha1.Text = Sha1.Text.ToLower()
        Sha384.Text = Sha384.Text.ToLower()
        Sha256.Text = Sha384.Text.ToLower()
        Sha512.Text = Sha512.Text.ToLower()
        Crc32.Text = Crc32.Text.ToLower()
        RIPEMD160.Text = RIPEMD160.Text.ToLower
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Dim fl As String
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        For Each File As ListViewItem In ListView1.SelectedItems
            fl = File.SubItems(1).Text
            trd = New Threading.Thread(AddressOf GetHash)
            trd.IsBackground = True
            trd.SetApartmentState(Threading.ApartmentState.STA)
            trd.Start()
            isAlive.Start()
            If Settings.ComboBox1.Text = "Français" Then

                Me.Text = "Propriétés de " & File.SubItems(0).Text
            Else

                Me.Text = "Properties of " & File.SubItems(0).Text
            End If

        Next
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Upper()
        Else
            Lower()
        End If
    End Sub

    Private Sub isAlive_Tick(sender As Object, e As EventArgs) Handles isAlive.Tick
        If trd.IsAlive = True Then
            Panel2.Visible = True
            ListView1.Enabled = False
        Else

            Button3.Enabled = True
            Panel2.Visible = False
            ListView1.Enabled = True
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            Dim sfd As New SaveFileDialog
            sfd.Filter = "PNG|*.png"
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png)
            End If
        Catch ex As Exception
            ErrorRep(ex.Message, ex.ToString)
        End Try

    End Sub

    Private Sub FileAtri_TextChanged(sender As Object, e As EventArgs) Handles FileAtri.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Md5.Text = Nothing Or TextBox1.Text = Nothing Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim allinfo As String
            Dim L As String = vbNewLine


            If Settings.ComboBox1.Text = "Français" Then


                allinfo += "---------------------------------------------------" & L
                allinfo += " Généré en utilisant Advanced checksum utility 3.0 " & L
                allinfo += "---------------------------------------------------" & L
                allinfo += "======================================================================================" & L & L
                allinfo += "Nom du fichier       : " & Filename.Text & L
                allinfo += "MD5                  : " & Md5.Text & L
                allinfo += "SHA-1                : " & Sha1.Text + L
                allinfo += "CRC32                : " & Crc32.Text + L
                allinfo += "SHA-256              : " & Sha256.Text + L
                allinfo += "SHA-512              : " & Sha512.Text + L
                allinfo += "SHA-384              : " & Sha384.Text + L
                allinfo += "RIPEMD-160           : " & RIPEMD160.Text + L
                allinfo += "Date de modification : " & Modiftime.Text + L
                allinfo += "Date de création     : " & CreatedTime.Text + L
                allinfo += "Version du fichier   : " & FileVer.Text + L
                allinfo += "Taille du fichier    : " & Size.Text + L
                allinfo += "Chemin complet       : " & TextBox1.Text + L
                allinfo += "Extension            : " & Extension.Text + L
                allinfo += "Attributs du fichier : " & FileAtri.Text + L & L
                allinfo += "======================================================================================" & L & L
            Else

                allinfo += "------------------------------------------------" & L
                allinfo += " Generated Using Advanced checksum utility 3.0 " & L
                allinfo += "------------------------------------------------" & L
                allinfo += "======================================================================================" & L & L
                allinfo += "File Name          : " & Filename.Text & L
                allinfo += "MD5                : " & Md5.Text & L
                allinfo += "SHA-1              : " & Sha1.Text + L
                allinfo += "CRC32              : " & Crc32.Text + L
                allinfo += "SHA-256            : " & Sha256.Text + L
                allinfo += "SHA-512            : " & Sha512.Text + L
                allinfo += "SHA-384            : " & Sha384.Text + L
                allinfo += "RIPEMD-160         : " & RIPEMD160.Text + L
                allinfo += "Modification date  : " & Modiftime.Text + L
                allinfo += "Creation date      : " & CreatedTime.Text + L
                allinfo += "File Version       : " & FileVer.Text + L
                allinfo += "File Size          : " & Size.Text + L
                allinfo += "Full Path          : " & TextBox1.Text + L
                allinfo += "Extension          : " & Extension.Text + L
                allinfo += "File Attributes    : " & FileAtri.Text + L & L
                allinfo += "======================================================================================" & L & L
            End If


            Dim g As New SaveFileDialog
            g.Filter = "Text File |*.txt"
            If g.ShowDialog = Windows.Forms.DialogResult.OK Then

                IO.File.WriteAllText(g.FileName, allinfo)
            End If
        Catch ex As Exception
            ErrorRep(ex.Message, ex.ToString)
        End Try
       
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Sha256_TextChanged(sender As Object, e As EventArgs) Handles Sha256.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class