Module Functions
    Function ErrorRep(ByVal message As String, ByVal Err As String) As String
        On Error Resume Next
        Dim raport As String
        Dim l As String = vbNewLine
        raport += l
        raport += "--------------------------------------------------------------------------------------------------------------------------------------------------------" & l
        raport += "Message : " & message & l
        raport += "Error   : " & Err & l
        raport += "--------------------------------------------------------------------------------------------------------------------------------------------------------" & l
        raport += "OS      : " & My.Computer.Info.OSFullName & l
        raport += "Sys Ver : " & My.Computer.Info.OSVersion & l
        raport += "Date    : " & Date.Now & l
        raport += "--------------------------------------------------------------------------------------------------------------------------------------------------------" & l
        Dim s As New ErrorDlg
        s.TextBox1.Text = raport
        s.Label1.Text = message
        s.Show()
    End Function

    Sub DarkTheme()
        Dim Drk As Color = Color.FromArgb(30, 30, 30)
        Dim Wth As Color = Color.White
        With ErrorDlg
            .BackColor = Drk
            .ForeColor = Wth
            .TextBox1.BackColor = Drk
            .TextBox1.ForeColor = Wth
        End With
        With Form1
            .BackColor = Drk
            .ForeColor = Wth
            .ContextMenuStrip1.BackColor = Drk
            .ContextMenuStrip1.ForeColor = Wth
            .Files_List.ForeColor = Wth
            .Files_List.BackColor = Drk
            .StatusStrip1.BackColor = Drk
            .StatusStrip1.ForeColor = Wth
            .MenuStrip1.BackColor = Drk
            .MenuStrip1.ForeColor = Wth
           

        End With
        With Settings
            .BackColor = Drk
            .ForeColor = Wth
            .TabPage1.BackColor = Drk
            .TabPage1.ForeColor = Wth
           
            .Button3.BackColor = Drk
            .Button4.BackColor = Drk
        End With
        With Find
            .BackColor = Drk
            .ForeColor = Wth
            .Button1.BackColor = Drk
            .Button2.BackColor = Drk
            .TextBox1.BackColor = Drk
            .TextBox1.ForeColor = Wth
        End With
        With Add_Process
            .BackColor = Drk
            .ForeColor = Wth
            .prclist.BackColor = Drk
            .prclist.ForeColor = Wth
            .ContextMenuStrip1.BackColor = Drk
            .ContextMenuStrip1.ForeColor = Wth
        End With
        With HashString
            .BackColor = Drk
            .ForeColor = Wth
            .TextBox2.BackColor = Drk
            .TextBox2.ForeColor = Wth
            .TextBox3.BackColor = Drk
            .TextBox3.ForeColor = Wth
            .MD5.BackColor = Drk
            .SHA1.BackColor = Drk
            .MD5.ForeColor = Wth
            .SHA1.ForeColor = Wth
            .ListBox1.BackColor = Drk
            .ListBox1.ForeColor = Wth
            .ListBox2.BackColor = Drk
            .ListBox2.ForeColor = Wth
            .TabPage1.BackColor = Drk
            .TabPage1.ForeColor = Wth
            .TabPage2.BackColor = Drk
            .TabPage2.ForeColor = Wth
            .GroupBox1.ForeColor = Wth
            .LinkLabel1.LinkColor = Wth
            .LinkLabel2.LinkColor = Wth
            .SHA256.BackColor = Drk
            .SHA256.ForeColor = Wth
            .SHA512.BackColor = Drk
            .SHA512.ForeColor = Wth
            .SHA384.ForeColor = Wth
            .SHA384.BackColor = Drk
            .CRC321.BackColor = Drk
            .CRC321.ForeColor = Wth
            .RIPEMD160.BackColor = Drk
            .RIPEMD160.ForeColor = Wth
            .ComboBox2.BackColor = Drk
            .ComboBox2.ForeColor = Wth
            .LinkLabel3.LinkColor = Wth

        End With
        With Verify_From_a_file
            .BackColor = Drk
            .ForeColor = Wth
            .Button1.BackColor = Drk
            .Button1.ForeColor = Wth
            .Button2.BackColor = Drk
            .Button2.ForeColor = Wth
            .ListView1.BackColor = Drk
            .ListView1.ForeColor = Wth

        End With
        With resaultDlg
            .BackColor = Drk
            .ForeColor = Wth
        End With
        With MultiHashVerify
            .BackColor = Drk
            .ForeColor = Wth
            .ListView1.BackColor = Drk
            .ListView1.ForeColor = Wth
            .GroupBox1.BackColor = Drk
            .GroupBox1.ForeColor = Wth
            .Given_384.BackColor = Drk
            .Given_384.ForeColor = Wth

            .Given_512.BackColor = Drk
            .Given_512.ForeColor = Wth
            .Given_sha256.BackColor = Drk
            .Given_sha256.ForeColor = Wth
            .Given_sha1.BackColor = Drk
            .Given_sha1.ForeColor = Wth
            .Given_md5.BackColor = Drk
            .Given_md5.ForeColor = Wth
            .Given_crc32.BackColor = Drk
            .Given_crc32.ForeColor = Wth
            .Given_RIPEMD160.BackColor = Drk
            .Given_RIPEMD160.ForeColor = Wth
        End With
        With resaultDlg
            .BackColor = Drk
            .ForeColor = Wth
        End With
        With Properties
            .BackColor = Drk
            .ForeColor = Wth
            .ListView1.BackColor = Drk
            .ListView1.ForeColor = Wth
            .Panel1.BackColor = Drk
            .Panel1.ForeColor = Wth
            .Md5.BackColor = Drk
            .Md5.ForeColor = Wth
            .Sha1.BackColor = Drk
            .Sha1.ForeColor = Wth
            .Sha256.BackColor = Drk
            .Sha256.ForeColor = Wth
            .Sha384.BackColor = Drk
            .Sha384.ForeColor = Wth
            .Sha512.BackColor = Drk
            .Sha512.ForeColor = Wth
            .Crc32.BackColor = Drk
            .Crc32.ForeColor = Wth
            .Button3.BackColor = Drk
            .Button3.ForeColor = Wth
            .Button2.BackColor = Drk
            .Button2.ForeColor = Wth
            .Filename.BackColor = Drk
            .Filename.ForeColor = Wth
            .Modiftime.BackColor = Drk
            .Modiftime.ForeColor = Wth
            .CreatedTime.BackColor = Drk
            .FileVer.BackColor = Drk
            .FileVer.ForeColor = Wth
            .FileAtri.BackColor = Drk
            .FileAtri.ForeColor = Wth
            .TextBox1.BackColor = Drk
            .TextBox1.ForeColor = Wth
            .Extension.ForeColor = Wth
            .Extension.BackColor = Drk
            .CreatedTime.BackColor = Drk
            .CreatedTime.ForeColor = Wth
            .Size.BackColor = Drk
            .Size.ForeColor = Wth
            .RIPEMD160.BackColor = Drk
            .RIPEMD160.ForeColor = Wth
        End With
      
    End Sub
End Module
