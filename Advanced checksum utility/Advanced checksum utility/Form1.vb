Imports System.Runtime.InteropServices
Imports System.Reflection

Public Class Form1
    Private ico As Icon = Nothing
    Dim icondufile As Bitmap
    Dim trd As Threading.Thread



    <DllImport("shell32.dll")> _
    Private Shared Function ExtractAssociatedIcon(ByVal hInst As IntPtr, <MarshalAs(UnmanagedType.LPStr)> _
  ByVal lpIconPath As String, ByRef lpiIcon As Integer) As IntPtr
    End Function
   
    Sub AddFolder()
        On Error Resume Next
        Dim dir As New FolderBrowserDialog
        Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
        Dim iIcon As Int32 = 0
        Dim hIcon As IntPtr
        Dim lvp As New ListViewItem
      
        If dir.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim files As String() = IO.Directory.GetFiles(dir.SelectedPath)
            For Each file As String In files

                hIcon = ExtractAssociatedIcon(hInst, file, iIcon)
                ico = Icon.FromHandle(hIcon)
                icondufile = ico.ToBitmap
                Img.Images.Add(icondufile)
               


        Dim C_File As New IO.FileInfo(file)

        Dim ItemFile As ListViewItem = New ListViewItem(C_File.Name)
        lvp = Files_List.Items.Add(ItemFile)
        lvp.SubItems.Add(MD5Checksum(file))
        lvp.SubItems.Add(hash_generator("sha1", file))
        lvp.SubItems.Add(hash_generator("sha256", file))
        lvp.SubItems.Add(GetCRC32(file))
        lvp.SubItems.Add(hash_generator("sha384", file))
        lvp.SubItems.Add(hash_generator("sha512", file))
        lvp.SubItems.Add(C_File.FullName)
        lvp.SubItems.Add(C_File.Extension)

                lvp.ImageIndex = lvp.Index





                ItemFile = Nothing

            Next
            Uppercashash(QSToolStripMenuItem.Checked)
        End If
    End Sub
    Private Sub AddFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFolderToolStripMenuItem.Click
        trd = New Threading.Thread(AddressOf AddFolder)
        trd.IsBackground = True
        trd.SetApartmentState(Threading.ApartmentState.STA)
        trd.Start()
        isAlive.Start()
    End Sub

   

    Private Sub AddProsesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProsesToolStripMenuItem.Click
        Add_Process.Show()
    End Sub
    Function toChek(ByVal SmallIcon As Boolean, ByVal Tile As Boolean, ByVal LargeIcon As Boolean, ByVal List As Boolean, ByVal Details As Boolean)
        View_Details.Checked = Details
        My.Settings.View_Details = Details
        View_SmallIcon.Checked = SmallIcon
        My.Settings.View_Smallicon = SmallIcon
        View_LargeIcon.Checked = LargeIcon
        My.Settings.View_LargeIcon = LargeIcon
        View_List.Checked = List
        My.Settings.View_List = List
        View_Tile.Checked = Tile
        My.Settings.View_Tile = Tile
    End Function
    Sub LoadSettings()
        My.Settings.Reload()
        With My.Settings
            If .Viwe_TopMost = True Then
                AlwaysOnTop.Checked = True
                Me.TopMost = True
            End If
            If .Viwe_GridLines = True Then
                GridLines.Enabled = True
                Files_List.GridLines = True
            End If
            If .View_Details = True Then
                Files_List.View = View.Details
                View_Details.Checked = True
            End If
            If .View_LargeIcon = True Then
                Files_List.View = View.LargeIcon
                View_LargeIcon.Checked = True
            End If
            If .View_List = True Then
                Files_List.View = View.List
                View_List.Checked = True
            End If
            If .View_Smallicon = True Then
                Files_List.View = View.SmallIcon
                View_SmallIcon.Checked = True
            End If
            If .View_Tile = True Then
                Files_List.View = View.Tile
                View_Tile.Checked = True
            End If
            If .Opet_Uppercasehash = True Then
                QSToolStripMenuItem.Checked = True
            Else
                QSToolStripMenuItem.Checked = False
            End If
            If .Viwe_AutoResizeColum = True Then
                AutoResizeColumnsToolStripMenuItem.Checked = True
            Else
                AutoResizeColumnsToolStripMenuItem.Checked = False
            End If
            If .Viwe_IconTray = True Then
                icontray.Checked = True
                NotifyIcon1.Visible = icontray.Checked
                NotifyIcon1.ShowBalloonTip(100)
            Else
                icontray.Checked = False
                NotifyIcon1.Visible = False
            End If
        End With
    End Sub
  
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Sub addFiles()
        On Error Resume Next
        Dim ofg As New OpenFileDialog
        Dim lvp As New ListViewItem

        ofg.Multiselect = True
        ofg.Filter = "All Files|*.*"
        Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
        Dim iIcon As Int32 = 0
        Dim hIcon As IntPtr
        If ofg.ShowDialog = Windows.Forms.DialogResult.OK Then

            For Each File As String In ofg.FileNames

                hIcon = ExtractAssociatedIcon(hInst, File, iIcon)
                ico = Icon.FromHandle(hIcon)
                icondufile = ico.ToBitmap
                Img.Images.Add(icondufile)




                Dim C_File As New IO.FileInfo(File)

                Dim ItemFile As ListViewItem = New ListViewItem(C_File.Name)
                lvp = Files_List.Items.Add(ItemFile)

                lvp.SubItems.Add(MD5Checksum(File))
                lvp.SubItems.Add(hash_generator("sha1", File))
                lvp.SubItems.Add(hash_generator("sha256", File))
                lvp.SubItems.Add(GetCRC32(File))
                lvp.SubItems.Add(hash_generator("sha384", File))
                lvp.SubItems.Add(hash_generator("sha512", File))
                lvp.SubItems.Add(C_File.FullName)
                lvp.SubItems.Add(C_File.Extension)

                lvp.ImageIndex = lvp.Index



                ItemFile = Nothing

            Next
            Uppercashash(QSToolStripMenuItem.Checked)
        End If
    End Sub
    Private Sub AddFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFilesToolStripMenuItem.Click
        trd = New Threading.Thread(AddressOf addFiles)
        trd.IsBackground = True
        trd.SetApartmentState(Threading.ApartmentState.STA)
        trd.Start()
        isAlive.Start()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Try
            Files_List.Items.Clear()
            Img.Images.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveSelectedItmeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedItmeToolStripMenuItem.Click
        Try
            For Each item As ListViewItem In Files_List.SelectedItems
                Files_List.Items(item.Index).Remove()
                Img.Images.RemoveAt(item.Index)
            Next

        Catch ex As Exception

        End Try

    End Sub

   

    Private Sub OpenInVirusTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInVirusTotalToolStripMenuItem.Click
        Try
            Dim hash As String = Files_List.FocusedItem.SubItems(3).Text
            Process.Start("https://www.virustotal.com/en/file/" & hash & "/analysis/")
        Catch ex As Exception

        End Try
    End Sub
   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Statue.Text = Files_List.Items.Count & " File(s)"
        If Not Files_List.Items.Count = 0 Then
            If Files_List.SelectedItems.Count = 1 Then
                CopyToolStripMenuItem.Enabled = True
                CopyMD5ToolStripMenuItem.Enabled = True
                CopySHA1ToolStripMenuItem.Enabled = True
                CopyCRC32ToolStripMenuItem.Enabled = True
                CopySelectedItmeToolStripMenuItem.Enabled = True
            Else
                CopyToolStripMenuItem.Enabled = False
                CopyMD5ToolStripMenuItem.Enabled = False
                CopySHA1ToolStripMenuItem.Enabled = False
                CopyCRC32ToolStripMenuItem.Enabled = False
                CopySelectedItmeToolStripMenuItem.Enabled = False
            End If
        Else
            CopyToolStripMenuItem.Enabled = False
            CopyMD5ToolStripMenuItem.Enabled = False
            CopySHA1ToolStripMenuItem.Enabled = False
            CopyCRC32ToolStripMenuItem.Enabled = False
            CopySelectedItmeToolStripMenuItem.Enabled = False
        End If
        ToolStripStatusLabel2.Text = "Selected (" & Files_List.SelectedItems.Count & ")"
    End Sub

    Private Sub FsdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FsdToolStripMenuItem.Click
        Try
            If MessageBox.Show("Your about to delete " & Files_List.FocusedItem.SubItems(7).Text & " Do you want to countu", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Try
                    For Each File As ListViewItem In Files_List.SelectedItems
                        IO.File.Delete(File.SubItems(7).Text)
                        Files_List.Items(File.Index).Remove()
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Faild")
                End Try
            End If

        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub


    Private Sub PropriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropriToolStripMenuItem.Click
     
    End Sub
#Region "Copy Hash"
    Function CopyHash(ByVal Index As Integer)
        Try
            Clipboard.SetText(Files_List.FocusedItem.SubItems(Index).Text)
        Catch ex As Exception

        End Try
    End Function
    Private Sub CopyMD5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyMD5ToolStripMenuItem.Click

        CopyHash(1)


    End Sub
    Private Sub SHA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHA1ToolStripMenuItem.Click
        CopyHash(2)

    End Sub

    Private Sub SHA256ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHA256ToolStripMenuItem.Click
        CopyHash(3)
    End Sub

    Private Sub CopyCRC32ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCRC32ToolStripMenuItem.Click
        CopyHash(4)
    End Sub


    Private Sub SHA512ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHA512ToolStripMenuItem.Click
        CopyHash(6)
    End Sub

    Private Sub SHA384ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHA384ToolStripMenuItem.Click
        CopyHash(5)
    End Sub
#End Region
  

   

    Private Sub Files_List_DragEnter(sender As Object, e As DragEventArgs) Handles Files_List.DragEnter

        e.Effect = DragDropEffects.All

    End Sub
    Dim Path As String
    Sub DropFolder(ByVal Folder As String)
        Folder = Path
        Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
        Dim iIcon As Int32 = 0
        Dim hIcon As IntPtr
        Dim lvp As New ListViewItem
        Dim files As String() = IO.Directory.GetFiles(Folder)
        For Each file As String In files
            Panel1.Visible = True

            hIcon = ExtractAssociatedIcon(hInst, file, iIcon)
            ico = Icon.FromHandle(hIcon)
            icondufile = ico.ToBitmap
            Img.Images.Add(icondufile)


            Dim C_File As New IO.FileInfo(file)

            Dim ItemFile As ListViewItem = New ListViewItem(C_File.Name)
            lvp = Files_List.Items.Add(ItemFile)
            lvp.SubItems.Add(MD5Checksum(file))
            lvp.SubItems.Add(hash_generator("sha1", file))
            lvp.SubItems.Add(hash_generator("sha256", file))
            lvp.SubItems.Add(GetCRC32(file))
            lvp.SubItems.Add(hash_generator("sha384", file))
            lvp.SubItems.Add(hash_generator("sha512", file))
            lvp.SubItems.Add(C_File.FullName)
            lvp.SubItems.Add(C_File.Extension)

            lvp.ImageIndex = lvp.Index



            ItemFile = Nothing

        Next
        Uppercashash(QSToolStripMenuItem.Checked)

    End Sub
   
    Private Sub Files_List_DragDrop(sender As Object, e As DragEventArgs) Handles Files_List.DragDrop
      

        On Error Resume Next
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim filez As String = e.Data.GetData(DataFormats.FileDrop)(0)

            If IO.Directory.Exists(filez) = True Then
                Path = filez
                trd = New Threading.Thread(AddressOf DropFolder)
                trd.SetApartmentState(Threading.ApartmentState.MTA)
                trd.Start()
                isAlive.Start()

            Else
                Dim File As String = filez

                Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
                Dim iIcon As Int32 = 0
                Dim hIcon As IntPtr
                hIcon = ExtractAssociatedIcon(hInst, File, iIcon)
                ico = Icon.FromHandle(hIcon)
                icondufile = ico.ToBitmap
                Img.Images.Add(icondufile)

                Dim lvp As New ListViewItem
                Dim C_File As New IO.FileInfo(File)
                Dim ItemFile As ListViewItem = New ListViewItem(C_File.Name)
                lvp = Files_List.Items.Add(ItemFile)
                lvp.SubItems.Add(MD5Checksum(File))
                lvp.SubItems.Add(hash_generator("sha1", File))
                lvp.SubItems.Add(hash_generator("sha256", File))
                lvp.SubItems.Add(GetCRC32(File))
                lvp.SubItems.Add(hash_generator("sha384", File))
                lvp.SubItems.Add(hash_generator("sha512", File))
                lvp.SubItems.Add(C_File.FullName)
                lvp.SubItems.Add(C_File.Extension)

                lvp.ImageIndex = lvp.Index

              

                Uppercashash(QSToolStripMenuItem.Checked)

            End If
        End If











       



    End Sub



    Private Sub isAlive_Tick(sender As Object, e As EventArgs) Handles isAlive.Tick
        If trd.IsAlive = True Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

  

  
    Private Sub CopySelectedItmeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySelectedItmeToolStripMenuItem.Click
        Try
            Dim Str As String
            Dim L As String = vbNewLine
            Str += "------------------------------------------------" & L
            Str += " Created Using Advanced checksum utility 2.0 " & L
            Str += "------------------------------------------------" & L
            Str += "======================================================================================" & L & L
            Str += ""
            Str += "File name : " & Files_List.FocusedItem.SubItems(0).Text & L
            Str += "MD5       : " & Files_List.FocusedItem.SubItems(1).Text & L
            Str += "SHA-1     : " & Files_List.FocusedItem.SubItems(2).Text & L
            Str += "SHA-256   : " & Files_List.FocusedItem.SubItems(3).Text & L
            Str += "CRC32     : " & Files_List.FocusedItem.SubItems(4).Text & L
            Str += "SHA-384   : " & Files_List.FocusedItem.SubItems(5).Text & L
            Str += "SHA-512   : " & Files_List.FocusedItem.SubItems(6).Text & L
            Str += "Full Path : " & Files_List.FocusedItem.SubItems(7).Text & L
            Str += "Extension : " & Files_List.FocusedItem.SubItems(8).Text & L & L
            Str += "======================================================================================" & L & L
            Clipboard.SetText(Str)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Find.Show()
        Find.Select()
    End Sub

   

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
      
    End Sub

    Private Sub UnMarkitmeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Files_List.FocusedItem.BackColor = Color.Transparent
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddFilesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddFilesToolStripMenuItem1.Click
        trd = New Threading.Thread(AddressOf addFiles)
        trd.IsBackground = True
        trd.SetApartmentState(Threading.ApartmentState.STA) ''You can set MTA or STA
        trd.Start()
        isAlive.Start()
    End Sub

    Private Sub AddFolderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddFolderToolStripMenuItem1.Click
        trd = New Threading.Thread(AddressOf AddFolder)
        trd.IsBackground = True
        trd.SetApartmentState(Threading.ApartmentState.STA) ''You can set MTA or STA
        trd.Start()
        isAlive.Start()
    End Sub


    Private Sub AddProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProcessToolStripMenuItem.Click
        Add_Process.Show()
    End Sub

    Private Sub TextHashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextHashToolStripMenuItem.Click
        HashString.Show()
    End Sub


    

    Private Sub View_SmallIcon_Click(sender As Object, e As EventArgs) Handles View_SmallIcon.Click
        toChek(True, False, False, False, False)
        Files_List.View = View.SmallIcon
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub View_Details_Click(sender As Object, e As EventArgs) Handles View_Details.Click
        toChek(False, False, False, False, True)
        Files_List.View = View.Details
    End Sub

    Private Sub View_Tile_Click(sender As Object, e As EventArgs) Handles View_Tile.Click
        toChek(False, True, False, False, False)
        Files_List.View = View.Tile
    End Sub

    Private Sub View_LargeIcon_Click(sender As Object, e As EventArgs) Handles View_LargeIcon.Click
        toChek(False, False, True, False, False)


        Files_List.View = View.LargeIcon
    End Sub

    Private Sub View_List_Click(sender As Object, e As EventArgs) Handles View_List.Click
        toChek(False, False, False, True, False)
        Files_List.View = View.List
    End Sub

    Private Sub AutoResizeColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GfhToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox(My.Settings.Viwe_GridLines)

    End Sub

    Private Sub SelectedItmeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedItmeToolStripMenuItem.Click
        Try
            For Each item As ListViewItem In Files_List.SelectedItems
                Files_List.Items(item.Index).Remove()
                Img.Images.RemoveAt(item.Index)
            Next
            If Files_List.Items.Count = 0 Then
                Img.Images.Clear()
            End If

        Catch ex As Exception
        End Try
    End Sub

    

    
    
    Private Sub CopyMD5ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CopyMD5ToolStripMenuItem2.Click
        Try
                CopyHash(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

    End Sub

    Private Sub SHA1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SHA1ToolStripMenuItem2.Click
      CopyHash(2)
    End Sub

    Private Sub SHA256ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SHA256ToolStripMenuItem2.Click
         CopyHash(3)
    End Sub

    Private Sub SHA512ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SHA512ToolStripMenuItem2.Click
        CopyHash(6)
    End Sub

    Private Sub SHA384ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SHA384ToolStripMenuItem2.Click
        CopyHash(5)
    End Sub

    Private Sub CopyCRC32ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CopyCRC32ToolStripMenuItem2.Click
       CopyHash(4)
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionToolStripMenuItem.Click

    End Sub

    Private Sub VerifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerifyToolStripMenuItem.Click
        Try
           For Each file As ListViewItem In Files_List.SelectedItems

                Dim fil As New IO.FileInfo(file.SubItems(7).Text)


                Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
                Dim iIcon As Int32 = 0
                Dim hIcon As IntPtr

                hIcon = ExtractAssociatedIcon(hInst, file.SubItems(7).Text, iIcon)
                ico = Icon.FromHandle(hIcon)
                icondufile = ico.ToBitmap
                MultiHashVerify.IMG.Images.Add(icondufile)
                Dim lvp As New ListViewItem
                Dim ItemFile As ListViewItem = New ListViewItem(fil.Name)
                lvp = MultiHashVerify.ListView1.Items.Add(ItemFile)
                lvp.SubItems.Add(fil.FullName)
                lvp.ImageIndex = lvp.Index
                MultiHashVerify.Show()
            Next
           

        Catch ex As Exception
            ErrorDlg.Label1.Text = ex.Message
            ErrorDlg.TextBox1.Text += "Err Msg : "
            ErrorDlg.TextBox1.Text += "Err : " & ex.ToString
            ErrorDlg.Show()
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

  
    Private Sub ClearAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem1.Click
        Try
            Files_List.Items.Clear()
            Img.Images.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Files_List_DoubleClick(sender As Object, e As EventArgs) Handles Files_List.DoubleClick
        Try
            Dim PropFrm As New Properties

            PropFrm.Filename.Text = Files_List.FocusedItem.SubItems(7).Text
            PropFrm.Text = "Properties Of " & Files_List.FocusedItem.SubItems(0).Text
            PropFrm.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub OpenInVirusTotalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenInVirusTotalToolStripMenuItem1.Click
        Try
            For Each item As ListViewItem In Files_List.SelectedItems
                Dim hash As String = item.SubItems(3).Text
                '  Process.Start("https://www.virustotal.com/en/file/" & hash & "/analysis/")
                Process.Start("ghfgh")
            Next
        Catch ex As Exception

            ErrorDlg.Label1.Text = ex.Message
            Dim err As String
            err += "Message : " & ex.Message & vbNewLine
            err += "--------------------------------------------------------------------------------------------------------------------------------------------------------"
            err += "" &
            ErrorDlg.TextBox1.Text = ex.ToString
            ErrorDlg.Show()
        End Try
    End Sub

    Private Sub CopySelectedItmeToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CopySelectedItmeToolStripMenuItem2.Click
        Try

            Dim Str As String
            Dim L As String = vbNewLine

            Str += "------------------------------------------------" & L
            Str += " Created Using Advanced checksum utility 2.0 " & L
            Str += "------------------------------------------------" & L
            Str += "======================================================================================" & L & L
            Str += ""
            Str += "File name : " & Files_List.FocusedItem.SubItems(0).Text & L
            Str += "MD5       : " & Files_List.FocusedItem.SubItems(1).Text & L
            Str += "SHA-1     : " & Files_List.FocusedItem.SubItems(2).Text & L
            Str += "SHA-256   : " & Files_List.FocusedItem.SubItems(3).Text & L
            Str += "CRC32     : " & Files_List.FocusedItem.SubItems(4).Text & L
            Str += "SHA-384   : " & Files_List.FocusedItem.SubItems(5).Text & L
            Str += "SHA-512   : " & Files_List.FocusedItem.SubItems(6).Text & L
            Str += "Full Path : " & Files_List.FocusedItem.SubItems(7).Text & L
            Str += "Extension : " & Files_List.FocusedItem.SubItems(8).Text & L
            Str += "======================================================================================" & L & L
            Clipboard.SetText(Str)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.Visible = True Then
            Me.Visible = False
        Else
            Me.Visible = True
        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
     
    End Sub
    Sub SaveSelected()
        Try
            Dim sfd As New SaveFileDialog
            Dim Table As String = My.Resources.Table2
            sfd.Filter = "HTML File|*.html"
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                For Each lvi As ListViewItem In Files_List.SelectedItems
                    Dim Filename As String = lvi.SubItems(0).Text
                    Dim MD5 As String = lvi.SubItems(1).Text
                    Dim SHA1 As String = lvi.SubItems(2).Text
                    Dim SHA256 As String = lvi.SubItems(3).Text
                    Dim CRC32 As String = lvi.SubItems(4).Text
                    Dim SHA384 As String = lvi.SubItems(5).Text
                    Dim SHA512 As String = lvi.SubItems(6).Text
                    Dim FullPath As String = lvi.SubItems(7).Text
                    Dim Extension As String = lvi.SubItems(8).Text

                    Dim TableItm As String = "<tr><td bgcolor=#FFFFFF nowrap>#Filename#<td bgcolor=#FFFFFF nowrap>#MD5#<td bgcolor=#FFFFFF nowrap>#SHA1#<td bgcolor=#FFFFFF nowrap>#SHA-256#<td bgcolor=#FFFFFF nowrap>#CRC32#<td bgcolor=#FFFFFF nowrap>#SHA384#<td bgcolor=#FFFFFF nowrap>#SHA512#<td bgcolor=#FFFFFF nowrap>#FULLPATH#<td bgcolor=#FFFFFF nowrap>#Extension#"
                    TableItm = TableItm.Replace("#Filename#", Filename)
                    TableItm = TableItm.Replace("#MD5#", MD5)
                    TableItm = TableItm.Replace("#SHA1#", SHA1)
                    TableItm = TableItm.Replace("#SHA-256#", SHA256)
                    TableItm = TableItm.Replace("#CRC32#", CRC32)

                    TableItm = TableItm.Replace("#SHA384#", SHA384)
                    TableItm = TableItm.Replace("#SHA512#", SHA512)
                    TableItm = TableItm.Replace("#FULLPATH#", FullPath)
                    TableItm = TableItm.Replace("#Extension#", Extension)
                    Table += TableItm & vbNewLine

                Next
                Table += "</table>"

                IO.File.WriteAllText(sfd.FileName, Table)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub SaveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSelectedToolStripMenuItem.Click
        SaveSelected()
    End Sub
    Sub SaveAll()
        Try
            Dim sfd As New SaveFileDialog
            Dim Table As String = My.Resources.Table2
            sfd.Filter = "HTML File|*.html"
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                For Each lvi As ListViewItem In Files_List.Items
                    Dim Filename As String = lvi.SubItems(0).Text
                    Dim MD5 As String = lvi.SubItems(1).Text
                    Dim SHA1 As String = lvi.SubItems(2).Text
                    Dim SHA256 As String = lvi.SubItems(3).Text
                    Dim CRC32 As String = lvi.SubItems(4).Text
                    Dim SHA384 As String = lvi.SubItems(5).Text
                    Dim SHA512 As String = lvi.SubItems(6).Text
                    Dim FullPath As String = lvi.SubItems(7).Text
                    Dim Extension As String = lvi.SubItems(8).Text

                    Dim TableItm As String = "<tr><td bgcolor=#FFFFFF nowrap>#Filename#<td bgcolor=#FFFFFF nowrap>#MD5#<td bgcolor=#FFFFFF nowrap>#SHA1#<td bgcolor=#FFFFFF nowrap>#SHA-256#<td bgcolor=#FFFFFF nowrap>#CRC32#<td bgcolor=#FFFFFF nowrap>#SHA384#<td bgcolor=#FFFFFF nowrap>#SHA512#<td bgcolor=#FFFFFF nowrap>#FULLPATH#<td bgcolor=#FFFFFF nowrap>#Extension#"
                    TableItm = TableItm.Replace("#Filename#", Filename)
                    TableItm = TableItm.Replace("#MD5#", MD5)
                    TableItm = TableItm.Replace("#SHA1#", SHA1)
                    TableItm = TableItm.Replace("#SHA-256#", SHA256)
                    TableItm = TableItm.Replace("#CRC32#", CRC32)

                    TableItm = TableItm.Replace("#SHA384#", SHA384)
                    TableItm = TableItm.Replace("#SHA512#", SHA512)
                    TableItm = TableItm.Replace("#FULLPATH#", FullPath)
                    TableItm = TableItm.Replace("#Extension#", Extension)
                    Table += TableItm & vbNewLine

                Next
                Table += "</table>"

                IO.File.WriteAllText(sfd.FileName, Table)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        

    End Sub
    Private Sub SaveAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAllToolStripMenuItem.Click

        SaveAll()
    End Sub
    Public Sub Uppercashash(bol As Boolean)
        If bol = True Then
            For Each item As ListViewItem In Files_List.Items
                item.SubItems(1).Text = item.SubItems(1).Text.ToUpper()
                item.SubItems(2).Text = item.SubItems(2).Text.ToUpper()
                item.SubItems(3).Text = item.SubItems(3).Text.ToUpper()
                item.SubItems(4).Text = item.SubItems(4).Text.ToUpper()
                item.SubItems(5).Text = item.SubItems(5).Text.ToUpper()
                item.SubItems(6).Text = item.SubItems(6).Text.ToUpper()

            Next
        Else
            For Each item As ListViewItem In Files_List.Items
                item.SubItems(1).Text = item.SubItems(1).Text.ToLower
                item.SubItems(2).Text = item.SubItems(2).Text.ToLower
                item.SubItems(3).Text = item.SubItems(3).Text.ToLower
                item.SubItems(4).Text = item.SubItems(4).Text.ToLower
                item.SubItems(5).Text = item.SubItems(5).Text.ToLower
                item.SubItems(6).Text = item.SubItems(6).Text.ToLower

            Next
        End If
    End Sub
    Private Sub QSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QSToolStripMenuItem.Click
        On Error Resume Next
        Uppercashash(QSToolStripMenuItem.Checked)
        My.Settings.Opet_Uppercasehash = QSToolStripMenuItem.Checked
    End Sub

    Private Sub icontray_Click_1(sender As Object, e As EventArgs) Handles icontray.Click
        My.Settings.Viwe_IconTray = icontray.Checked
        NotifyIcon1.Visible = icontray.Checked
        NotifyIcon1.ShowBalloonTip(100)
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AlwaysOnTop.Click
        If AlwaysOnTop.Checked = True Then
            Me.TopMost = True
            My.Settings.Viwe_TopMost = True
        Else
            Me.TopMost = False
            My.Settings.Viwe_TopMost = False
        End If
    End Sub

    Private Sub GridLinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridLines.Click
        Files_List.GridLines = GridLines.Checked
        My.Settings.Viwe_GridLines = GridLines.Checked
    End Sub

    Private Sub AutoResizeColumnsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AutoResizeColumnsToolStripMenuItem.Click
        If AutoResizeColumnsToolStripMenuItem.Checked = True Then
            Files_List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            My.Settings.Viwe_AutoResizeColum = True
        Else
            Files_List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None)
            My.Settings.Viwe_AutoResizeColum = False
        End If

    End Sub

    Private Sub SaveSelectedFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSelectedFileToolStripMenuItem.Click
        SaveSelected()
    End Sub

    Private Sub SaveAllFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAllFilesToolStripMenuItem.Click
        SaveAll()
    End Sub


    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        On Error Resume Next
        For Each item As ListViewItem In Files_List.Items
            item.Selected = True
        Next
    End Sub

    Private Sub UnSelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnSelectAllToolStripMenuItem.Click
        On Error Resume Next
        For Each item As ListViewItem In Files_List.Items
            item.Selected = False
        Next
    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        Try

            Dim Prv As String = IO.Path.GetTempPath & "\Peview.exe"
            Dim Commandline As String
            Commandline = "C:\Program Files\Process Hacker 2\peview.exe" & "C:\Windows\System32\zipfldr.dll"



            If Not IO.File.Exists(Prv) Then
                IO.File.WriteAllBytes(Prv, My.Resources.peview)

                For Each file As ListViewItem In Files_List.SelectedItems
                    Dim Supported As String = "exe|dll|ocx|sys|scr|cpl|EXE"

                    Dim File1 As New IO.FileInfo(file.SubItems(7).Text)
                    If Supported.Contains(File1.Extension) Then
                        Shell("""" & Prv & """" & " " & """" & File1.FullName & """", AppWinStyle.NormalFocus, False, 999)
                    Else
                        MsgBox(File1.Extension & " files are not Supprted !", MsgBoxStyle.Exclamation)
                    End If

                Next
            Else

                For Each file As ListViewItem In Files_List.SelectedItems
                    Dim Supported As String = ".exe|.dll|.ocx|.sys|.scr|.cpl"

                    Dim File1 As New IO.FileInfo(file.SubItems(7).Text)
                    If Supported.Contains(File1.Extension) Then
                        Shell("""" & Prv & """" & " " & """" & File1.FullName & """", AppWinStyle.NormalFocus, False, 999)
                    Else
                        MsgBox(File1.Extension & " files are not Supprted !", MsgBoxStyle.Exclamation)
                    End If

                Next

            End If
        Catch ex As Exception
            ErrorDlg.Label1.Text = ex.Message
            ErrorDlg.TextBox1.Text = ex.ToString
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            For Each file As ListViewItem In Files_List.SelectedItems

                Dim fil As New IO.FileInfo(file.SubItems(7).Text)


                Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
                Dim iIcon As Int32 = 0
                Dim hIcon As IntPtr

                hIcon = ExtractAssociatedIcon(hInst, file.SubItems(7).Text, iIcon)
                ico = Icon.FromHandle(hIcon)
                icondufile = ico.ToBitmap
                Properties.IMG.Images.Add(icondufile)
                Dim lvp As New ListViewItem
                Dim ItemFile As ListViewItem = New ListViewItem(fil.Name)
                lvp = Properties.ListView1.Items.Add(ItemFile)
                lvp.SubItems.Add(fil.FullName)
                lvp.ImageIndex = lvp.Index
                Properties.Show()
            Next


        Catch ex As Exception
            ErrorDlg.Label1.Text = ex.Message
            ErrorDlg.TextBox1.Text += "Err Msg : "
            ErrorDlg.TextBox1.Text += "Err : " & ex.ToString
            ErrorDlg.Show()
        End Try
    End Sub

    Private Sub BasicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BasicToolStripMenuItem.Click
        Try

            For Each item As ListViewItem In Files_List.SelectedItems
                Dim PropFrm As New Properties
                PropFrm.Filename.Text = item.SubItems(7).Text
                PropFrm.Text = "Properties Of " & item.SubItems(0).Text
                PropFrm.Show()
            Next

        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        VerifyToolStripMenuItem.Image.Save("C:\Users\Proxy-Hacker\Desktop\Experiment lab\12.png")
    End Sub
End Class
