<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GFlags = New System.Windows.Forms.ImageList(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(349, 253)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.PictureBox10)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(341, 227)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 138)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(188, 19)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Add to windows context menu"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(39, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 38)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "More options will be available in the next version "
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Advanced_checksum_utility.My.MySettings.Default, "Theme", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.DropDownWidth = 150
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Dark", "White"})
        Me.ComboBox2.Location = New System.Drawing.Point(65, 88)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(227, 23)
        Me.ComboBox2.TabIndex = 15
        Me.ComboBox2.Text = Global.Advanced_checksum_utility.My.MySettings.Default.Theme
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Theme : "
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Advanced_checksum_utility.My.MySettings.Default, "Languge", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.DropDownWidth = 150
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"English", "Français"})
        Me.ComboBox1.Location = New System.Drawing.Point(65, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(227, 23)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.Text = Global.Advanced_checksum_utility.My.MySettings.Default.Languge
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select your language :"
        '
        'GFlags
        '
        Me.GFlags.ImageStream = CType(resources.GetObject("GFlags.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.GFlags.TransparentColor = System.Drawing.Color.Transparent
        Me.GFlags.Images.SetKeyName(0, "Angola.png")
        Me.GFlags.Images.SetKeyName(1, "Argentina.png")
        Me.GFlags.Images.SetKeyName(2, "Australia.png")
        Me.GFlags.Images.SetKeyName(3, "Bangladesh.png")
        Me.GFlags.Images.SetKeyName(4, "Belarus.png")
        Me.GFlags.Images.SetKeyName(5, "Brazil.png")
        Me.GFlags.Images.SetKeyName(6, "Cambodia.png")
        Me.GFlags.Images.SetKeyName(7, "Cameroon.png")
        Me.GFlags.Images.SetKeyName(8, "Croatia.png")
        Me.GFlags.Images.SetKeyName(9, "Czech Republic.png")
        Me.GFlags.Images.SetKeyName(10, "Ecuador.png")
        Me.GFlags.Images.SetKeyName(11, "France.png")
        Me.GFlags.Images.SetKeyName(12, "Germany.png")
        Me.GFlags.Images.SetKeyName(13, "Hong Kong.png")
        Me.GFlags.Images.SetKeyName(14, "Iceland.png")
        Me.GFlags.Images.SetKeyName(15, "India.png")
        Me.GFlags.Images.SetKeyName(16, "Indonesia.png")
        Me.GFlags.Images.SetKeyName(17, "Ireland.png")
        Me.GFlags.Images.SetKeyName(18, "Italy.png")
        Me.GFlags.Images.SetKeyName(19, "Japan.png")
        Me.GFlags.Images.SetKeyName(20, "Kyrgyzstan.png")
        Me.GFlags.Images.SetKeyName(21, "Latvia.png")
        Me.GFlags.Images.SetKeyName(22, "Lithuania.png")
        Me.GFlags.Images.SetKeyName(23, "Malaysia.png")
        Me.GFlags.Images.SetKeyName(24, "Mali.png")
        Me.GFlags.Images.SetKeyName(25, "Mexico.png")
        Me.GFlags.Images.SetKeyName(26, "Mongolia.png")
        Me.GFlags.Images.SetKeyName(27, "Mozambique.png")
        Me.GFlags.Images.SetKeyName(28, "Nepal.png")
        Me.GFlags.Images.SetKeyName(29, "Netherlands.png")
        Me.GFlags.Images.SetKeyName(30, "Nigeria.png")
        Me.GFlags.Images.SetKeyName(31, "Pakistan.png")
        Me.GFlags.Images.SetKeyName(32, "Paraguay.png")
        Me.GFlags.Images.SetKeyName(33, "Peru.png")
        Me.GFlags.Images.SetKeyName(34, "Philippines.png")
        Me.GFlags.Images.SetKeyName(35, "Poland.png")
        Me.GFlags.Images.SetKeyName(36, "Russian Federation.png")
        Me.GFlags.Images.SetKeyName(37, "Seychelles.png")
        Me.GFlags.Images.SetKeyName(38, "Singapore.png")
        Me.GFlags.Images.SetKeyName(39, "Slovakia.png")
        Me.GFlags.Images.SetKeyName(40, "South Africa.png")
        Me.GFlags.Images.SetKeyName(41, "Spain.png")
        Me.GFlags.Images.SetKeyName(42, "Sweden.png")
        Me.GFlags.Images.SetKeyName(43, "Taiwan.png")
        Me.GFlags.Images.SetKeyName(44, "Thailand.png")
        Me.GFlags.Images.SetKeyName(45, "United Kingdom.png")
        Me.GFlags.Images.SetKeyName(46, "Venezuela.png")
        Me.GFlags.Images.SetKeyName(47, "Yemen.png")
        Me.GFlags.Images.SetKeyName(48, "Serbia.png")
        Me.GFlags.Images.SetKeyName(49, "United States.png")
        Me.GFlags.Images.SetKeyName(50, "Costa Rica.png")
        Me.GFlags.Images.SetKeyName(51, "Romania.png")
        Me.GFlags.Images.SetKeyName(52, "Macau.png")
        Me.GFlags.Images.SetKeyName(53, "Chile.png")
        Me.GFlags.Images.SetKeyName(54, "Somalia.png")
        Me.GFlags.Images.SetKeyName(55, "Bulgaria.png")
        Me.GFlags.Images.SetKeyName(56, "Iran, Islamic Republic of.png")
        Me.GFlags.Images.SetKeyName(57, "Korea, Republic of.png")
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Advanced_checksum_utility.My.Resources.Resources.Big_Yes
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(176, 255)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 32)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "&Save"
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Advanced_checksum_utility.My.Resources.Resources.Big_No
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(4, 255)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(166, 32)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(200, 139)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(20, 17)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 22
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Visible = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 292)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GFlags As System.Windows.Forms.ImageList
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
