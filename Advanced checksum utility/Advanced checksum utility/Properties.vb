Public Class Properties

  
    Private Sub Properties_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      
    End Sub
    Sub GetHash(ByVal Path As String)
        Dim FilePathe As String = Filename.Text
        TextBox1.Text = FilePathe
        Md5.Text = MD5Checksum(FilePathe)
        Sha1.Text = hash_generator("sha1", FilePathe)
        Sha256.Text = hash_generator("sha256", FilePathe)
        Sha512.Text = hash_generator("sha512", FilePathe)
        Sha384.Text = hash_generator("sha384", FilePathe)
        Crc32.Text = GetCRC32(FilePathe)
        Dim Fileinfo As New IO.FileInfo(FilePathe)
        FileAtri.Text = Fileinfo.Attributes.ToString
        Extension.Text = Fileinfo.Extension
        Modiftime.Text = Fileinfo.LastWriteTime
        CreatedTime.Text = Fileinfo.CreationTime
        Filename.Text = Fileinfo.Name
        Size.Text = roundObjectSize(Fileinfo.Length)
        If My.Settings.Prprfrm_Lower = True Then
            Lower()

        End If
        If My.Settings.Prprfrm_Upper = True Then
            Upper()

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim allinfo As String
        Dim L As String = vbNewLine
        allinfo += "------------------------------------------------" & L
        allinfo += " Generated Using Advanced checksum utility 2.0 " & L
        allinfo += "------------------------------------------------" & L
        allinfo += "======================================================================================" & L & L
        allinfo += "File Name          : " & Filename.Text & L
        allinfo += "MD5                : " & Md5.Text & L
        allinfo += "SHA-1              : " & Sha1.Text + L
        allinfo += "CRC32              : " & Crc32.Text + L
        allinfo += "SHA-256            : " & Sha256.Text + L
        allinfo += "SHA 512            : " & Sha512.Text + L
        allinfo += "SHA 384            : " & Sha384.Text + L
        allinfo += "Modified Time      : " & Modiftime.Text + L
        allinfo += "Created Time       : " & CreatedTime.Text + L
        allinfo += "File Version       : " & FileVer.Text + L
        allinfo += "File Size          : " & Size.Text + L
        allinfo += "Full Path          : " & TextBox1.Text + L
        allinfo += "Extension          : " & Extension.Text + L
        allinfo += "File Attributes    : " & FileAtri.Text + L & L
        allinfo += "======================================================================================" & L & L

        Dim g As New SaveFileDialog
        g.Filter = "Text File |*.txt"
        If g.ShowDialog = Windows.Forms.DialogResult.OK Then

            IO.File.WriteAllText(g.FileName, allinfo)
        End If
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

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            My.Settings.Prprfrm_Upper = True
            Upper()
        Else
            My.Settings.Prprfrm_Upper = False
        End If
    End Sub
    Sub Upper()
        Md5.Text = Md5.Text.ToUpper()
        Sha1.Text = Sha1.Text.ToUpper()
        Sha384.Text = Sha384.Text.ToUpper()
        Sha256.Text = Sha384.Text.ToUpper
        Sha512.Text = Sha512.Text.ToUpper()
        Crc32.Text = Crc32.Text.ToUpper()
    End Sub
    Sub Lower()
        Md5.Text = Md5.Text.ToLower()
        Sha1.Text = Sha1.Text.ToLower()
        Sha384.Text = Sha384.Text.ToLower()
        Sha256.Text = Sha384.Text.ToLower()
        Sha512.Text = Sha512.Text.ToLower()
        Crc32.Text = Crc32.Text.ToLower()
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            My.Settings.Prprfrm_Lower = True
            Lower()
        Else
            My.Settings.Prprfrm_Lower = False
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        For Each File As ListViewItem In ListView1.SelectedItems
            GetHash(File.SubItems(1).Text)
        Next
    End Sub
End Class