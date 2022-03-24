Imports System.Runtime.InteropServices
Imports System.Reflection

Public Class MultiHashVerify
    Private ico As Icon = Nothing
    Dim icondufile As Bitmap
    Dim trd As Threading.Thread
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

    Sub HideHash(ByVal Yes? As Boolean)
        If Yes = False Then
            original_crc32.Visible = False
            original_sha1.Visible = False
            original_sha256.Visible = False
            original_sha384.Visible = False
            original_sha512.Visible = False
            original_md5.Visible = False
        Else
            original_crc32.Visible = True
            original_sha1.Visible = True
            original_sha256.Visible = True
            original_sha384.Visible = True
            original_sha512.Visible = True
            original_md5.Visible = True
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        HideHash(CheckBox1.Checked)
    End Sub

    Sub GetHash()
        On Error Resume Next
        For Each File As ListViewItem In ListView1.SelectedItems

            Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
            Dim iIcon As Int32 = 0
            Dim hIcon As IntPtr



            Dim SelFile As String = File.SubItems(1).Text
            Dim fileinfo As New IO.FileInfo(SelFile)
            Label2.Text = fileinfo.Name
            Label3.Text = fileinfo.FullName


            hIcon = ExtractAssociatedIcon(hInst, fileinfo.FullName, iIcon)
            ico = Icon.FromHandle(hIcon)
            icondufile = ico.ToBitmap
            PictureBox1.Image = icondufile

            original_md5.Text = MD5Checksum(fileinfo.FullName)
            original_sha1.Text = hash_generator("sha1", fileinfo.FullName)
            original_sha256.Text = hash_generator("sha256", fileinfo.FullName)
            original_sha384.Text = hash_generator("sha384", fileinfo.FullName)
            original_sha512.Text = hash_generator("sha512", fileinfo.FullName)
            original_crc32.Text = GetCRC32(fileinfo.FullName)
            original_crc32.Text = original_crc32.Text.ToLower
            trd.Abort()
        Next


    End Sub

    <DllImport("shell32.dll")> _
    Private Shared Function ExtractAssociatedIcon(ByVal hInst As IntPtr, <MarshalAs(UnmanagedType.LPStr)> _
  ByVal lpIconPath As String, ByRef lpiIcon As Integer) As IntPtr
    End Function
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        trd = New Threading.Thread(AddressOf GetHash)
        trd.IsBackground = True
        trd.SetApartmentState(Threading.ApartmentState.STA)
        trd.Start()
        isAlive.Start()
    End Sub

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        If ListView1.Items.Count = 0 Then
            Label2.Text = ""
            Label3.Text = ""

            original_md5.Text = ""
            original_sha1.Text = ""
            original_sha256.Text = ""
            original_sha384.Text = ""
            original_sha512.Text = ""
            original_crc32.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
      
    End Sub
    Function Compare(ByVal Str1 As String, ByVal Str2 As String) As Boolean
        If Str1 = Str2 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function ToLow(ByVal Str As String) As String
        Return Str = Str.ToLower
    End Function

    Private Sub Given_sha1_TextChanged(sender As Object, e As EventArgs) Handles Given_sha1.TextChanged
        Given_sha1.Text = Given_sha1.Text.ToLower
   
    End Sub

    Private Sub Given_sha256_TextChanged(sender As Object, e As EventArgs) Handles Given_sha256.TextChanged
        Given_sha256.Text = Given_sha256.Text.ToLower
      
    End Sub

    Private Sub Given_512_TextChanged(sender As Object, e As EventArgs) Handles Given_512.TextChanged
        Given_512.Text = Given_512.Text.ToLower
    End Sub

    Private Sub Given_384_TextChanged(sender As Object, e As EventArgs) Handles Given_384.TextChanged
        Given_384.Text = Given_384.Text.ToLower
    End Sub

    Private Sub Given_md5_TextChanged(sender As Object, e As EventArgs) Handles Given_md5.TextChanged
        Given_md5.Text = Given_md5.Text.ToLower
    End Sub

    Private Sub Given_crc32_TextChanged(sender As Object, e As EventArgs) Handles Given_crc32.TextChanged
        Given_crc32.Text = Given_crc32.Text.ToLower
    End Sub

    Private Sub MultiHashVerify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Me.Text = "Hash Verify | Files Count : " & ListView1.Items.Count
    End Sub

    Private Sub isAlive_Tick(sender As Object, e As EventArgs) Handles isAlive.Tick
        If trd.IsAlive = True Then
            Panel2.Visible = True
            Button1.Enabled = False
        Else

            Button1.Enabled = True
            Panel2.Visible = False
            Panel1.Enabled = True
            Timer1.Stop()
        End If
    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            If resaultDlg.Visible = True Then
                resaultDlg.Close()
            End If
            With resaultDlg
                Dim YesCount As Integer
                Dim NoCount As Integer
                If Not Given_md5.Text = Nothing Then
                    If Compare(original_md5.Text, Given_md5.Text) = True Then
                        .Md5_Pic.Image = My.Resources.Mini_Yes
                        YesCount = YesCount + 1
                    Else
                        .Md5_Pic.Image = My.Resources.Mini_No
                        NoCount = NoCount + 1
                    End If
                Else
                    .Md5_Pic.Image = Nothing
                    .Label1.Enabled = False
                End If
                If Not Given_sha1.Text = Nothing Then
                    If Compare(original_sha1.Text, Given_sha1.Text) = True Then
                        .Sha1_Pic.Image = My.Resources.Mini_Yes
                        YesCount = YesCount + 1
                    Else
                        .Sha1_Pic.Image = My.Resources.Mini_No
                        NoCount = NoCount + 1
                    End If
                Else
                    .Sha1_Pic.Image = Nothing
                    .Label3.Enabled = False
                End If
                If Not Given_sha256.Text = Nothing Then
                    If Compare(original_sha256.Text, Given_sha256.Text) = True Then
                        .Sha256_Pic.Image = My.Resources.Mini_Yes
                        YesCount = YesCount + 1
                    Else
                        .Sha256_Pic.Image = My.Resources.Mini_No
                        NoCount = NoCount + 1
                    End If
                Else
                    .Sha256_Pic.Image = Nothing
                    .Label4.Enabled = False
                End If


                If Not Given_384.Text = Nothing Then
                    If Compare(original_sha384.Text, Given_384.Text) = True Then
                        .Sha384_Pic.Image = My.Resources.Mini_Yes
                        YesCount = YesCount + 1
                    Else
                        .Sha384_Pic.Image = My.Resources.Mini_No
                        NoCount = NoCount + 1
                    End If
                Else
                    .Sha384_Pic.Image = Nothing
                    .Label2.Enabled = False
                End If

                If Not Given_512.Text = Nothing Then
                    If Compare(original_sha512.Text, Given_512.Text) = True Then
                        .SHA512_Pic.Image = My.Resources.Mini_Yes
                        YesCount = YesCount + 1
                    Else
                        .SHA512_Pic.Image = My.Resources.Mini_No
                        NoCount = NoCount + 1
                    End If
                Else
                    .SHA512_Pic.Image = Nothing
                    .Label5.Enabled = False
                End If


                If Not Given_crc32.Text = Nothing Then
                    If Compare(original_crc32.Text, Given_crc32.Text) = True Then
                        .CRC32_Pic.Image = My.Resources.Mini_Yes
                        YesCount = YesCount + 1
                    Else
                        .CRC32_Pic.Image = My.Resources.Mini_No
                        NoCount = NoCount + 1
                    End If
                Else
                    .CRC32_Pic = Nothing
                    .Label7.Enabled = False
                End If

                If Not NoCount = 0 Then
                    .PictureBox1.Image = My.Resources.Big_No
                    .Label6.Text = NoCount & " Hash dos not match !"
                Else
                    If Not YesCount = 0 Then
                        .PictureBox1.Image = My.Resources.Big_Yes
                        .Label6.Text = "All Hash Matches "
                    End If
                  
                End If
                .Show()
            End With

        Catch ex As Exception

        End Try


    End Sub
End Class