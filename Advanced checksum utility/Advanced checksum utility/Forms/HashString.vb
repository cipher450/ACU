Imports System.Text
Imports System.IO
Imports System.Threading
Imports System.Security.Cryptography

Public Class HashString
    Dim trd As Thread
#Region "Text Hash"
    Function GetTextHash(ByVal Text As String) As String

        If CheckBox5.Checked = True Then
            MD5.Text = MD5_txt(Text)
        End If
        If CheckBox1.Checked = True Then
            SHA1.Text = getSHA1Hash(Text)
        End If
        If CheckBox3.Checked = True Then
            SHA256.Text = getSHA256Hash(Text)
        End If
        If CheckBox4.Checked = True Then
            SHA512.Text = getSHA512Hash(Text)
        End If
        If CheckBox6.Checked = True Then
            SHA384.Text = getSHA384Hash(Text)
        End If
        If CheckBox2.Checked = True Then
            Dim BensCrc32 As New crc32()
            CRC321.Text = BensCrc32.Crc32CalcString(Text)
        End If
        If CheckBox8.Checked = True Then
            RIPEMD160.Text = Ripemd160_crp(Text)
        End If

    End Function
#End Region


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox3.Text = TextBox2.Text.Length
        TextBox3.Text = TextBox2.Text.Length
        Try
            If Not TextBox2.Text = Nothing Then
                If CheckBox7.Checked = True Then


                    HMAC1(TextBox2.Text, Key1.Text)
                Else
                    GetTextHash(TextBox2.Text)
                End If


            Else
                SHA1.Text = ""
                SHA256.Text = ""
                SHA512.Text = ""
                SHA384.Text = ""
                MD5.Text = ""
                CRC321.Text = ""
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Not TextBox2.Text = Nothing Then
            If CheckBox1.Checked = True Then
                SHA1.Text = getSHA1Hash(TextBox2.Text)
            Else
                SHA1.Clear()
            End If
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If Not TextBox2.Text = Nothing Then
            If CheckBox3.Checked = True Then
                SHA256.Text = getSHA256Hash(TextBox2.Text)
            Else
                SHA256.Clear()
            End If
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If Not TextBox2.Text = Nothing Then
            If CheckBox4.Checked = True Then
                SHA512.Text = getSHA512Hash(TextBox2.Text)
            Else
                SHA512.Clear()
            End If
        End If

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If Not TextBox2.Text = Nothing Then
            If CheckBox6.Checked = True Then
                SHA384.Text = getSHA384Hash(TextBox2.Text)
            Else
                SHA384.Clear()
            End If
        End If

    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Not TextBox2.Text = Nothing Then
            If CheckBox2.Checked = True Then
                Dim BensCrc32 As New crc32()
                CRC321.Text = BensCrc32.Crc32CalcString(TextBox2.Text)
            Else
                CRC321.Clear()
            End If

        End If


    End Sub
    Public Class crc32


        Private TLookup = {&H0, &H77073096, &HEE0E612C, &H990951BA, &H76DC419, &H706AF48F,
        &HE963A535, &H9E6495A3, &HEDB8832, &H79DCB8A4, &HE0D5E91E, &H97D2D988,
        &H9B64C2B, &H7EB17CBD, &HE7B82D07, &H90BF1D91, &H1DB71064, &H6AB020F2,
        &HF3B97148, &H84BE41DE, &H1ADAD47D, &H6DDDE4EB, &HF4D4B551, &H83D385C7,
        &H136C9856, &H646BA8C0, &HFD62F97A, &H8A65C9EC, &H14015C4F, &H63066CD9,
        &HFA0F3D63, &H8D080DF5, &H3B6E20C8, &H4C69105E, &HD56041E4, &HA2677172,
        &H3C03E4D1, &H4B04D447, &HD20D85FD, &HA50AB56B, &H35B5A8FA, &H42B2986C,
        &HDBBBC9D6, &HACBCF940, &H32D86CE3, &H45DF5C75, &HDCD60DCF, &HABD13D59,
        &H26D930AC, &H51DE003A, &HC8D75180, &HBFD06116, &H21B4F4B5, &H56B3C423,
        &HCFBA9599, &HB8BDA50F, &H2802B89E, &H5F058808, &HC60CD9B2, &HB10BE924,
        &H2F6F7C87, &H58684C11, &HC1611DAB, &HB6662D3D, &H76DC4190, &H1DB7106,
        &H98D220BC, &HEFD5102A, &H71B18589, &H6B6B51F, &H9FBFE4A5, &HE8B8D433,
        &H7807C9A2, &HF00F934, &H9609A88E, &HE10E9818, &H7F6A0DBB, &H86D3D2D,
        &H91646C97, &HE6635C01, &H6B6B51F4, &H1C6C6162, &H856530D8, &HF262004E,
        &H6C0695ED, &H1B01A57B, &H8208F4C1, &HF50FC457, &H65B0D9C6, &H12B7E950,
        &H8BBEB8EA, &HFCB9887C, &H62DD1DDF, &H15DA2D49, &H8CD37CF3, &HFBD44C65,
        &H4DB26158, &H3AB551CE, &HA3BC0074, &HD4BB30E2, &H4ADFA541, &H3DD895D7,
        &HA4D1C46D, &HD3D6F4FB, &H4369E96A, &H346ED9FC, &HAD678846, &HDA60B8D0,
        &H44042D73, &H33031DE5, &HAA0A4C5F, &HDD0D7CC9, &H5005713C, &H270241AA,
        &HBE0B1010, &HC90C2086, &H5768B525, &H206F85B3, &HB966D409, &HCE61E49F,
        &H5EDEF90E, &H29D9C998, &HB0D09822, &HC7D7A8B4, &H59B33D17, &H2EB40D81,
        &HB7BD5C3B, &HC0BA6CAD, &HEDB88320, &H9ABFB3B6, &H3B6E20C, &H74B1D29A,
        &HEAD54739, &H9DD277AF, &H4DB2615, &H73DC1683, &HE3630B12, &H94643B84,
        &HD6D6A3E, &H7A6A5AA8, &HE40ECF0B, &H9309FF9D, &HA00AE27, &H7D079EB1,
        &HF00F9344, &H8708A3D2, &H1E01F268, &H6906C2FE, &HF762575D, &H806567CB,
        &H196C3671, &H6E6B06E7, &HFED41B76, &H89D32BE0, &H10DA7A5A, &H67DD4ACC,
        &HF9B9DF6F, &H8EBEEFF9, &H17B7BE43, &H60B08ED5, &HD6D6A3E8, &HA1D1937E,
        &H38D8C2C4, &H4FDFF252, &HD1BB67F1, &HA6BC5767, &H3FB506DD, &H48B2364B,
        &HD80D2BDA, &HAF0A1B4C, &H36034AF6, &H41047A60, &HDF60EFC3, &HA867DF55,
        &H316E8EEF, &H4669BE79, &HCB61B38C, &HBC66831A, &H256FD2A0, &H5268E236,
        &HCC0C7795, &HBB0B4703, &H220216B9, &H5505262F, &HC5BA3BBE, &HB2BD0B28,
        &H2BB45A92, &H5CB36A04, &HC2D7FFA7, &HB5D0CF31, &H2CD99E8B, &H5BDEAE1D,
        &H9B64C2B0, &HEC63F226, &H756AA39C, &H26D930A, &H9C0906A9, &HEB0E363F,
        &H72076785, &H5005713, &H95BF4A82, &HE2B87A14, &H7BB12BAE, &HCB61B38,
        &H92D28E9B, &HE5D5BE0D, &H7CDCEFB7, &HBDBDF21, &H86D3D2D4, &HF1D4E242,
        &H68DDB3F8, &H1FDA836E, &H81BE16CD, &HF6B9265B, &H6FB077E1, &H18B74777,
        &H88085AE6, &HFF0F6A70, &H66063BCA, &H11010B5C, &H8F659EFF, &HF862AE69,
        &H616BFFD3, &H166CCF45, &HA00AE278, &HD70DD2EE, &H4E048354, &H3903B3C2,
        &HA7672661, &HD06016F7, &H4969474D, &H3E6E77DB, &HAED16A4A, &HD9D65ADC,
        &H40DF0B66, &H37D83BF0, &HA9BCAE53, &HDEBB9EC5, &H47B2CF7F, &H30B5FFE9,
        &HBDBDF21C, &HCABAC28A, &H53B39330, &H24B4A3A6, &HBAD03605, &HCDD70693,
        &H54DE5729, &H23D967BF, &HB3667A2E, &HC4614AB8, &H5D681B02, &H2A6F2B94,
        &HB40BBE37, &HC30C8EA1, &H5A05DF1B, &H2D02EF8D}

        Public Function Crc32CalcString(ByVal source As String) As String
            Dim crc As Integer = &HFFFFFFFF
            Dim x As Integer = 0
            Dim c As Byte = 0

            'Loop though the string.
            While x <= source.Length - 1
                'Get byte from char
                c = Asc(source(x))
                'This is the magic stuff that get the crc value.
                crc = (((crc And &HFFFFFF00) >> 8) And &HFFFFFF) Xor (TLookup((crc And 255) Xor c))
                'INC Counter
                x += 1
            End While

            crc = (Not crc)
            'Return hex value or crc value.
            Return Hex(crc)
        End Function

    End Class

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If Not TextBox2.Text = Nothing Then
            If CheckBox5.Checked = True Then
                MD5.Text = MD5_txt(TextBox2.Text)
            Else
                MD5.Clear()
            End If
        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Text File|*.txt"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim txt As String = IO.File.ReadAllText(ofd.FileName)
            TextBox2.Text = txt

        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim allinfo As String
        Dim L As String = vbNewLine
        allinfo += "------------------------------------------------" & L
        allinfo += " Created Using Advanced checksum utility 3.0 " & L
        allinfo += "------------------------------------------------" & L
        allinfo += "======================================================================================" & L & L
        allinfo += "Text               : " & TextBox2.Text & L
        allinfo += "MD5                : " & MD5.Text & L
        allinfo += "SHA-1              : " & SHA1.Text + L
        allinfo += "CRC32              : " & CRC321.Text + L
        allinfo += "SHA-256            : " & SHA256.Text + L
        allinfo += "SHA 512            : " & SHA512.Text + L
        allinfo += "SHA 384            : " & SHA384.Text + L + L
        allinfo += "======================================================================================" & L & L
        Dim g As New SaveFileDialog
        g.Filter = "Text File |*.txt"
        If g.ShowDialog = Windows.Forms.DialogResult.OK Then

            IO.File.WriteAllText(g.FileName, allinfo)
        End If
    End Sub


    Sub ClearPanel()
        ProgressBar1.Value = "0"
    End Sub
    Private Sub HashString_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        If Settings.ComboBox1.SelectedIndex = 1 Then
            Franch()
        End If
        If Settings.ComboBox2.Text = "Dark" Then

            DarkTheme()
        End If
    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics
        Dim sText As String
        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF
        Dim ctlTab As TabControl

        ctlTab = CType(sender, TabControl)

        g = e.Graphics

        sText = ctlTab.TabPages(e.Index).Text
        sizeText = g.MeasureString(sText, ctlTab.Font)
        iX = e.Bounds.Left + 6
        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2
        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY)
    End Sub
    Function HMAC1(ByVal Message As String, ByVal Key As String)
        Dim getmessage As String
        Dim getkey As String
        getkey = Key
        getmessage = Message
        Dim encoding As New System.Text.ASCIIEncoding()
        Dim getkeyByte As Byte() = encoding.GetBytes(getkey)
        Dim gethmacmd5 As New HMACMD5(getkeyByte)
        Dim gethmacsha1 As New HMACSHA1(getkeyByte)
        Dim gethmacsha256 As New HMACSHA256(getkeyByte)
        Dim gethmacsha384 As New HMACSHA384(getkeyByte)
        Dim gethmacsha512 As New HMACSHA512(getkeyByte)
        Dim gethmacrimped160 As New HMACRIPEMD160(getkeyByte)
        Dim getmessageBytes As Byte() = encoding.GetBytes(getmessage)
        Dim hashmessage As Byte() = gethmacmd5.ComputeHash(getmessageBytes)
        MD5.Text = ByteToString(hashmessage)
        hashmessage = gethmacsha1.ComputeHash(getmessageBytes)
        SHA1.Text = ByteToString(hashmessage)
        hashmessage = gethmacsha256.ComputeHash(getmessageBytes)
        SHA256.Text = ByteToString(hashmessage)
        hashmessage = gethmacsha384.ComputeHash(getmessageBytes)
        SHA384.Text = ByteToString(hashmessage)
        hashmessage = gethmacsha512.ComputeHash(getmessageBytes)
        SHA512.Text = ByteToString(hashmessage)
        hashmessage = gethmacrimped160.ComputeHash(getmessageBytes)
        RIPEMD160.Text = ByteToString(hashmessage)
    End Function
   
    Public Shared Function ByteToString(buff As Byte()) As String
        Dim getbinary As String = ""
        For i As Integer = 0 To buff.Length - 1
            getbinary += buff(i).ToString("X2")
        Next
        Return (getbinary)
    End Function
    Sub AddNewList()
        Try
            Disabel(False)
            Dim ofd As New OpenFileDialog
            ofd.Filter = "Text File|*.txt"
            ListBox1.Items.Clear()
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim s As String = vbNewLine

                Dim lines() As String = IO.File.ReadAllLines(ofd.FileName)
                ListBox1.Items.AddRange(lines)
            End If
            ListBox1.Refresh()
            Disabel(True)
        Catch ex As Exception
            'TO DO :  Add Err Report
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub HashIt()
        Dim sb As New System.Text.StringBuilder()
        For Each o As Object In ListBox1.Items
            sb.AppendLine(o)
            With ComboBox2
                If .Text = "MD5" Then
                    ListBox2.Items.Add(MD5_txt(o.ToString))
                End If
                If .Text = "SHA-1" Then
                    ListBox2.Items.Add(getSHA1Hash(o.ToString))
                End If
                If .Text = "SHA-256" Then
                    ListBox2.Items.Add(getSHA256Hash(o.ToString))
                End If
                If .Text = "SHA-384" Then
                    ListBox2.Items.Add(getSHA384Hash(o.ToString))
                End If
                If .Text = "SHA-512" Then
                    ListBox2.Items.Add(getSHA512Hash(o.ToString))
                End If
                If .Text = "CRC32" Then
                    Dim BensCrc32 As New crc32()
                    ListBox2.Items.Add(BensCrc32.Crc32CalcString(o.ToString))
                End If
                If .Text = "RIPEMD-160" Then
                    ListBox2.Items.Add(Ripemd160_crp(o.ToString))
                End If
            End With
        Next
        If ListBox2.Items.Count = ListBox1.Items.Count Then
            trd.Abort()
            isAlive.Stop()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        trd = New Thread(AddressOf AddNewList)
        trd.SetApartmentState(ApartmentState.STA)
        trd.IsBackground = True
        trd.Start()
        isAlive2.Start()



    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.Items.Clear()
        trd = New Thread(AddressOf HashIt)
        trd.SetApartmentState(ApartmentState.STA)
        trd.IsBackground = True
        trd.Start()
        isAlive.Start()



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

    End Sub
    Sub Disabel(ByVal Yes? As Boolean)
        ListBox1.Enabled = Yes
        ListBox2.Enabled = Yes
        Button1.Enabled = Yes
        Button2.Enabled = Yes

        Button5.Enabled = Yes
        Button3.Enabled = Yes
    End Sub
    Private Sub isAlive_Tick(sender As Object, e As EventArgs) Handles isAlive.Tick

        If trd.IsAlive = True Then
            Timer1.Enabled = False
            Panel2.Visible = True
            HashedWrd.Visible = True
            Dim TotalWords As Integer = ListBox1.Items.Count
            Dim Hashed As Integer = ListBox2.Items.Count
            ProgressBar1.Maximum = TotalWords
            ProgressBar1.Value = Hashed
            HashedWrd.Text = Hashed & " Of " & TotalWords
            Disabel(False)

        Else
            Timer1.Enabled = True
            Panel2.Visible = False
            Disabel(True)
            isAlive.Enabled = False
        End If
    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs)
        trd.Abort()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Label10.Text = ListBox1.Items.Count
            Label11.Text = ListBox2.Items.Count
            If ListBox2.Items.Count = 0 Then
                Button2.Enabled = False
            Else
                Button2.Enabled = True
            End If
            If ListBox1.Items.Count = 0 Then
                Button3.Enabled = False
            Else
                Button3.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub isAlive2_Tick(sender As Object, e As EventArgs) Handles isAlive2.Tick
        If trd.IsAlive = True Then
            Timer1.Enabled = False
            ClearPanel()
            Panel1.Visible = True
            HashedWrd.Visible = False
            ProgressBar1.Maximum = ListBox1.Items.Count
            ProgressBar1.Value = ListBox1.Items.Count
            Disabel(False)

        Else
            Timer1.Enabled = True
            Disabel(True)
            Panel2.Visible = False
            isAlive2.Stop()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text File|*.txt"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sb As New System.Text.StringBuilder()

            For Each o As Object In ListBox2.Items
                sb.AppendLine(o)
            Next

            System.IO.File.WriteAllText(sfd.FileName, sb.ToString())
        End If
    End Sub

    Private Sub AddAWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAWordToolStripMenuItem.Click
        Try
            ListBox1.Items.Add(InputBox("Entre a word ", "Add a word"))
        Catch ex As Exception
            ErrorRep(ex.Message, ex.ToString)
        End Try

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Try
            ListBox1.Items.Clear()
        Catch ex As Exception
            ErrorRep(ex.Message, ex.ToString)
        End Try

    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        Try
            ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopySelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySelectedToolStripMenuItem.Click
        Try
            Clipboard.SetText(ListBox2.SelectedItem)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        Try
            ListBox2.Items.Clear()
        Catch ex As Exception
            ErrorRep(ex.Message, ex.ToString)
        End Try

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            ListBox2.Items.Remove(ListBox2.SelectedItem.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged

        If CheckBox7.Checked = True Then
            If MessageBox.Show("Enabling HMAC Text hashing Will have different results as normal hashing , Are you sure you want enable HMAC ?", "HMAC", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Dim key As String = InputBox("Entre your key :", "HMAC Key", Environment.UserName)
                Key1.Text = key
                If Key1.Text = Nothing Then
                    CheckBox7.Checked = False


                End If
            Else
                CheckBox7.Checked = False
            End If
           
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub CRC321_TextChanged(sender As Object, e As EventArgs) Handles CRC321.TextChanged

    End Sub

    Private Sub SHA512_TextChanged(sender As Object, e As EventArgs) Handles SHA512.TextChanged

    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If Not TextBox2.Text = Nothing Then
            If CheckBox8.Checked = True Then
                RIPEMD160.Text = Ripemd160_crp(TextBox2.Text)
            Else
                RIPEMD160.Clear()
            End If
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        TextBox3.Text = TextBox2.Text.Length
        TextBox3.Text = TextBox2.Text.Length
        Try
            If Not TextBox2.Text = Nothing Then
                If CheckBox7.Checked = True Then


                    HMAC1(TextBox2.Text, Key1.Text)
                Else
                    GetTextHash(TextBox2.Text)
                End If


            Else
                SHA1.Text = ""
                SHA256.Text = ""
                SHA512.Text = ""
                SHA384.Text = ""
                MD5.Text = ""
                CRC321.Text = ""
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged

        If CheckBox10.Checked = True Then
            SHA512.Text = SHA512.Text.ToUpper()
            SHA1.Text = SHA1.Text.ToUpper()
            SHA384.Text = SHA384.Text.ToUpper()
            SHA256.Text = SHA256.Text.ToUpper()
            MD5.Text = MD5.Text.ToUpper()
            RIPEMD160.Text = RIPEMD160.Text.ToUpper()
            CRC321.Text = CRC321.Text.ToUpper()
        Else
            SHA512.Text = SHA512.Text.ToLower
            SHA1.Text = SHA1.Text.ToLower
            SHA384.Text = SHA384.Text.ToLower
            SHA256.Text = SHA256.Text.ToLower
            MD5.Text = MD5.Text.ToLower
            RIPEMD160.Text = RIPEMD160.Text.ToLower
            CRC321.Text = CRC321.Text.ToLower
        End If
    End Sub
End Class
