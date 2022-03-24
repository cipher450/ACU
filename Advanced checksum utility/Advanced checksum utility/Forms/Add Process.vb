Imports System.Runtime.InteropServices
Imports System.Reflection

Public Class Add_Process
    Dim x As Integer
    Private ico As Icon = Nothing
    Dim icondufile As Bitmap
    Dim trd As Threading.Thread

    Private Sub Add_Process_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Settings.ComboBox1.SelectedIndex = 1 Then
            Franch()
        End If
        Control.CheckForIllegalCrossThreadCalls = False
        If chekadmin() = False Then
            If Settings.ComboBox1.Text = "Français" Then
                MsgBox("Pour voir plus de processus, vous devez redémarrer ce programme avec les droits d'administrateur", MsgBoxStyle.Information)
            Else
                MsgBox("To See More Process you need to restart this program with admin rights", MsgBoxStyle.Information)
            End If

        End If
        trd = New Threading.Thread(AddressOf ref)
        trd.IsBackground = True
        trd.Start()
        Timer1.Start()
        If Settings.ComboBox2.Text = "Dark" Then

            DarkTheme()
        End If
    End Sub

    <DllImport("shell32.dll")> _
    Private Shared Function ExtractAssociatedIcon(ByVal hInst As IntPtr, <MarshalAs(UnmanagedType.LPStr)> _
  ByVal lpIconPath As String, ByRef lpiIcon As Integer) As IntPtr
    End Function
    Function chekadmin() As Boolean
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            Return True
        Else
            Return False
        End If

    End Function
    Sub ref()
        On Error Resume Next
        IMG.Images.Clear()
        prclist.Items.Clear()
        Dim s As ListViewItem
        Dim litm As ListViewItem
        s.Text = "Idle"
        For Each Prc As Process In Process.GetProcesses

            Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
            Dim iIcon As Int32 = 0
            Dim hIcon As IntPtr

            If Prc.ProcessName = "Idle" Then
                litm.SubItems.Add("No Pathe To Show !")
            Else
                Dim modulfil As String = Prc.MainModule.FileName
                If modulfil.Contains("\??\") = True Then
                    litm.SubItems.Add(modulfil)

                Else
                    If Prc.MainModule.FileName = "" Or Prc.MainModule.FileName = " " Then

                    Else
                        hIcon = ExtractAssociatedIcon(hInst, Prc.MainModule.FileName, iIcon)
                        ico = Icon.FromHandle(hIcon)
                        icondufile = ico.ToBitmap
                        IMG.Images.Add(icondufile)
                        litm = prclist.Items.Add(Prc.ProcessName)
                        litm.ImageIndex = litm.Index
                        litm.SubItems.Add(Prc.MainModule.FileName)
                    End If

                End If

            End If


        Next
    End Sub
    Sub AddToList()
        For Each path1 As ListViewItem In prclist.SelectedItems
            Dim path As String = path1.SubItems(1).Text
            Dim d As New IO.FileInfo(path)
            Dim lvp As New ListViewItem


            Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
            Dim iIcon As Int32 = 0
            Dim hIcon As IntPtr

            hIcon = ExtractAssociatedIcon(hInst, path, iIcon)
            ico = Icon.FromHandle(hIcon)
            icondufile = ico.ToBitmap
            Form1.Img.Images.Add(icondufile)



            Dim list As ListView = Form1.Files_List
            lvp = list.Items.Add(d.Name)
            Dim Fileinfo As New IO.FileInfo(path)

            lvp.SubItems.Add(MD5Checksum(path))
            lvp.SubItems.Add(hash_generator("sha1", path))
            lvp.SubItems.Add(hash_generator("sha256", path))
            lvp.SubItems.Add(GetCRC32(path))
            lvp.SubItems.Add(hash_generator("sha384", path))
            lvp.SubItems.Add(hash_generator("sha512", path))
            lvp.SubItems.Add(Ripemd160_File(path))
            lvp.SubItems.Add(Fileinfo.FullName)
            lvp.SubItems.Add(Fileinfo.Extension)

            lvp.ImageIndex = lvp.Index

        Next

        Form1.Uppercashash(Form1.QSToolStripMenuItem.Checked)
    End Sub
   
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        AddToList()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If trd.IsAlive = True Then
            Panel1.Visible = True
            ProgressBar1.Increment(1)
            prclist.Enabled = False
        Else
            prclist.Enabled = True
            ProgressBar1.Value = 100
            ProgressBar1.Value = 0
            Panel1.Visible = False
            If Settings.ComboBox1.Text = "Français" Then
                Me.Text = "Ajouter processus - Nombre de processus: " & prclist.Items.Count
            Else
                Me.Text = "Add Process - Process Count : " & prclist.Items.Count
            End If

            Timer1.Stop()
        End If
    End Sub

    Private Sub prclist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prclist.SelectedIndexChanged

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        trd = New Threading.Thread(AddressOf ref)
        trd.IsBackground = True
        trd.Start()
        Timer1.Start()
    End Sub

    Private Sub prclist_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles prclist.MouseDoubleClick
        Try

            Timer1.Start()
            AddToList()
            Timer1.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class