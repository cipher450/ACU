<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Properties
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Filename = New System.Windows.Forms.TextBox()
        Me.Md5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sha1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Crc32 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Sha256 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Sha512 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Sha384 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Modiftime = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CreatedTime = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FileVer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Size = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Extension = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FileAtri = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.isAlive = New System.Windows.Forms.Timer(Me.components)
        Me.IMG = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filename  :"
        '
        'Filename
        '
        Me.Filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Filename.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Filename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Filename.Location = New System.Drawing.Point(121, 13)
        Me.Filename.Name = "Filename"
        Me.Filename.ReadOnly = True
        Me.Filename.Size = New System.Drawing.Size(270, 24)
        Me.Filename.TabIndex = 1
        '
        'Md5
        '
        Me.Md5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Md5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Md5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Md5.Location = New System.Drawing.Point(121, 43)
        Me.Md5.Name = "Md5"
        Me.Md5.ReadOnly = True
        Me.Md5.Size = New System.Drawing.Size(270, 24)
        Me.Md5.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MD5 :"
        '
        'Sha1
        '
        Me.Sha1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sha1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Sha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Sha1.Location = New System.Drawing.Point(121, 72)
        Me.Sha1.Name = "Sha1"
        Me.Sha1.ReadOnly = True
        Me.Sha1.Size = New System.Drawing.Size(270, 24)
        Me.Sha1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SHA1 :"
        '
        'Crc32
        '
        Me.Crc32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crc32.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Crc32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Crc32.Location = New System.Drawing.Point(121, 102)
        Me.Crc32.Name = "Crc32"
        Me.Crc32.ReadOnly = True
        Me.Crc32.Size = New System.Drawing.Size(270, 24)
        Me.Crc32.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CRC32 :"
        '
        'Sha256
        '
        Me.Sha256.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sha256.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Sha256.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Sha256.Location = New System.Drawing.Point(121, 131)
        Me.Sha256.Name = "Sha256"
        Me.Sha256.ReadOnly = True
        Me.Sha256.Size = New System.Drawing.Size(270, 24)
        Me.Sha256.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SHA-256 :"
        '
        'Sha512
        '
        Me.Sha512.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sha512.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Sha512.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Sha512.Location = New System.Drawing.Point(121, 161)
        Me.Sha512.Name = "Sha512"
        Me.Sha512.ReadOnly = True
        Me.Sha512.Size = New System.Drawing.Size(270, 24)
        Me.Sha512.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "SHA-512 :"
        '
        'Sha384
        '
        Me.Sha384.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sha384.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Sha384.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Sha384.Location = New System.Drawing.Point(121, 190)
        Me.Sha384.Name = "Sha384"
        Me.Sha384.ReadOnly = True
        Me.Sha384.Size = New System.Drawing.Size(270, 24)
        Me.Sha384.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "SHA-384 :"
        '
        'Modiftime
        '
        Me.Modiftime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Modiftime.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Modiftime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Modiftime.Location = New System.Drawing.Point(121, 219)
        Me.Modiftime.Name = "Modiftime"
        Me.Modiftime.ReadOnly = True
        Me.Modiftime.Size = New System.Drawing.Size(270, 24)
        Me.Modiftime.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Modified Time :"
        '
        'CreatedTime
        '
        Me.CreatedTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CreatedTime.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CreatedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.CreatedTime.Location = New System.Drawing.Point(121, 248)
        Me.CreatedTime.Name = "CreatedTime"
        Me.CreatedTime.ReadOnly = True
        Me.CreatedTime.Size = New System.Drawing.Size(270, 24)
        Me.CreatedTime.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Created Time : "
        '
        'FileVer
        '
        Me.FileVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileVer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FileVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FileVer.Location = New System.Drawing.Point(121, 279)
        Me.FileVer.Name = "FileVer"
        Me.FileVer.ReadOnly = True
        Me.FileVer.Size = New System.Drawing.Size(270, 24)
        Me.FileVer.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "File Version :"
        '
        'Size
        '
        Me.Size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Size.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Size.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Size.Location = New System.Drawing.Point(121, 311)
        Me.Size.Name = "Size"
        Me.Size.ReadOnly = True
        Me.Size.Size = New System.Drawing.Size(270, 24)
        Me.Size.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 310)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "File Size :"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.TextBox1.Location = New System.Drawing.Point(121, 340)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(270, 24)
        Me.TextBox1.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 339)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Full Path :"
        '
        'Extension
        '
        Me.Extension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Extension.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Extension.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Extension.Location = New System.Drawing.Point(121, 369)
        Me.Extension.Name = "Extension"
        Me.Extension.ReadOnly = True
        Me.Extension.Size = New System.Drawing.Size(270, 24)
        Me.Extension.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 18)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Extension :"
        '
        'FileAtri
        '
        Me.FileAtri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileAtri.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FileAtri.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FileAtri.Location = New System.Drawing.Point(121, 399)
        Me.FileAtri.Name = "FileAtri"
        Me.FileAtri.ReadOnly = True
        Me.FileAtri.Size = New System.Drawing.Size(270, 24)
        Me.FileAtri.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 398)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 18)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "File Attributes :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 424)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(392, 18)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "________________________________________________"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(204, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 25)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(302, 450)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 25)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "&OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = Global.Advanced_hasher_2._1.My.MySettings.Default.Prprfrm_Lower
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Advanced_hasher_2._1.My.MySettings.Default, "Prprfrm_Lower", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton2.Location = New System.Drawing.Point(95, 453)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton2.TabIndex = 32
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "To Lower"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = Global.Advanced_hasher_2._1.My.MySettings.Default.Prprfrm_Upper
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Advanced_hasher_2._1.My.MySettings.Default, "Prprfrm_Upper", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton1.Location = New System.Drawing.Point(10, 453)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton1.TabIndex = 31
        Me.RadioButton1.Text = "To Upper"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'isAlive
        '
        Me.isAlive.Interval = 1
        '
        'IMG
        '
        Me.IMG.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.IMG.ImageSize = New System.Drawing.Size(30, 30)
        Me.IMG.TransparentColor = System.Drawing.Color.Transparent
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Control
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.LargeImageList = Me.IMG
        Me.ListView1.Location = New System.Drawing.Point(3, 1)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(245, 335)
        Me.ListView1.SmallImageList = Me.IMG
        Me.ListView1.TabIndex = 33
        Me.ListView1.TileSize = New System.Drawing.Size(195, 30)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Filename"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FullPath"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Size"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(61, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Filename)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.Md5)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Sha1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Crc32)
        Me.Panel1.Controls.Add(Me.FileAtri)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Sha256)
        Me.Panel1.Controls.Add(Me.Extension)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Sha512)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Sha384)
        Me.Panel1.Controls.Add(Me.Size)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Modiftime)
        Me.Panel1.Controls.Add(Me.FileVer)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.CreatedTime)
        Me.Panel1.Location = New System.Drawing.Point(254, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 335)
        Me.Panel1.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(146, 463)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 18)
        Me.Label16.TabIndex = 33
        '
        'Properties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 340)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Properties"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Properties of "
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Filename As System.Windows.Forms.TextBox
    Friend WithEvents Md5 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Sha1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Crc32 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Sha256 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Sha512 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Sha384 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Modiftime As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CreatedTime As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FileVer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Size As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Extension As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents FileAtri As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents isAlive As System.Windows.Forms.Timer
    Friend WithEvents IMG As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
