<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resaultDlg
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Md5_Pic = New System.Windows.Forms.PictureBox()
        Me.Sha1_Pic = New System.Windows.Forms.PictureBox()
        Me.Sha256_Pic = New System.Windows.Forms.PictureBox()
        Me.SHA512_Pic = New System.Windows.Forms.PictureBox()
        Me.Sha384_Pic = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CRC32_Pic = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Md5_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sha1_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sha256_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHA512_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sha384_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRC32_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MD5 Hash"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SHA-384 Hash"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SHA-1 Hash"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SHA-256 Hash"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "SHA-512 Hash"
        '
        'Md5_Pic
        '
        Me.Md5_Pic.Location = New System.Drawing.Point(174, 82)
        Me.Md5_Pic.Name = "Md5_Pic"
        Me.Md5_Pic.Size = New System.Drawing.Size(17, 16)
        Me.Md5_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Md5_Pic.TabIndex = 6
        Me.Md5_Pic.TabStop = False
        '
        'Sha1_Pic
        '
        Me.Sha1_Pic.Location = New System.Drawing.Point(174, 104)
        Me.Sha1_Pic.Name = "Sha1_Pic"
        Me.Sha1_Pic.Size = New System.Drawing.Size(17, 16)
        Me.Sha1_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Sha1_Pic.TabIndex = 7
        Me.Sha1_Pic.TabStop = False
        '
        'Sha256_Pic
        '
        Me.Sha256_Pic.Location = New System.Drawing.Point(174, 126)
        Me.Sha256_Pic.Name = "Sha256_Pic"
        Me.Sha256_Pic.Size = New System.Drawing.Size(17, 16)
        Me.Sha256_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Sha256_Pic.TabIndex = 8
        Me.Sha256_Pic.TabStop = False
        '
        'SHA512_Pic
        '
        Me.SHA512_Pic.Location = New System.Drawing.Point(174, 148)
        Me.SHA512_Pic.Name = "SHA512_Pic"
        Me.SHA512_Pic.Size = New System.Drawing.Size(17, 16)
        Me.SHA512_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SHA512_Pic.TabIndex = 9
        Me.SHA512_Pic.TabStop = False
        '
        'Sha384_Pic
        '
        Me.Sha384_Pic.Location = New System.Drawing.Point(174, 169)
        Me.Sha384_Pic.Name = "Sha384_Pic"
        Me.Sha384_Pic.Size = New System.Drawing.Size(17, 16)
        Me.Sha384_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Sha384_Pic.TabIndex = 10
        Me.Sha384_Pic.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(83, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 51)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Add Some Hash To Verify"
        '
        'CRC32_Pic
        '
        Me.CRC32_Pic.Location = New System.Drawing.Point(174, 189)
        Me.CRC32_Pic.Name = "CRC32_Pic"
        Me.CRC32_Pic.Size = New System.Drawing.Size(17, 16)
        Me.CRC32_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CRC32_Pic.TabIndex = 13
        Me.CRC32_Pic.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CRC32"
        '
        'resaultDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 210)
        Me.Controls.Add(Me.CRC32_Pic)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Sha384_Pic)
        Me.Controls.Add(Me.SHA512_Pic)
        Me.Controls.Add(Me.Sha256_Pic)
        Me.Controls.Add(Me.Sha1_Pic)
        Me.Controls.Add(Me.Md5_Pic)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "resaultDlg"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resault"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Md5_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sha1_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sha256_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHA512_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sha384_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRC32_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Md5_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Sha1_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Sha256_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents SHA512_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Sha384_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CRC32_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
