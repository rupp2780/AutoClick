Imports System.IO

Public Class Form1
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)

    'Establish Keyboard hook
    Private WithEvents kbHook As New KeyboardHook

    'Save settings
    Dim settingsFileDirectory As String = "C:\temp\AutoClickSettings\"
    Dim settingsFileLocation As String = "C:\temp\AutoClickSettings\config.ini"

    'Set values for setting amt of clicks
    Dim ClickCount As Integer = 0
    Dim ClickTo As Integer = 0

    'Get key when pressed
    Private Sub kbHook_KeyDown(ByVal Key As Keys) Handles kbHook.KeyDown

        If Key.ToString = TXT_StartKey.Text Then 'Set Start key, default F4

            'Start timer and disable interface to avoid user messing up settings inadvertantly
            Timer1.Start()
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            BT_Start.Enabled = False
            TXT_CountTo.Enabled = False
            BT_Reset.Enabled = False
        ElseIf Key.ToString = TXT_StopKey.Text Then 'Set Stop key, default F3

            'Stop timer and re-enable interface
            Timer1.Stop()
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            BT_Start.Enabled = True
            TXT_CountTo.Enabled = True
            BT_Reset.Enabled = True
        End If
    End Sub

    'Execute click on tick
    Private Sub MyMethod()
        Cursor.Position = New Point(Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1) 'cursor will go down (like a click)
        mouse_event(&H4, 0, 0, 0, 1) ' cursor goes up again
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Get interval on every tick
        Timer1.Interval = GetInterval()

        'Click count logic
        If CType(TXT_CountTo.Text, Integer) > 0 Then
            ClickTo = CType(TXT_CountTo.Text, Integer) 'Set Clickto to userval

            If ClickCount = ClickTo Then
                Timer1.Stop() 'Stop timer
                ClickCount = 0 'Reset clickcount
            Else
                MyMethod()
                ClickCount += 1
            End If

        Else
            MyMethod()
            ClickCount += 1
        End If
    End Sub

    'Start clicker manually
    Private Sub BT_Start_Click(sender As Object, e As EventArgs) Handles BT_Start.Click
        Timer1.Start()
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        BT_Start.Enabled = False
        TXT_CountTo.Enabled = False
        BT_Reset.Enabled = False
    End Sub

    'Stop clicker manually
    Private Sub BT_Stop_Click(sender As Object, e As EventArgs) Handles BT_Stop.Click
        Timer1.Stop()
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        BT_Start.Enabled = True
        TXT_CountTo.Enabled = True
        BT_Reset.Enabled = True
    End Sub

    'Set click speed
    Public Function GetInterval() As Integer
        Dim ClickSpeed As Integer

        If CHK_RandClick.Checked = True Then 'Random is checked
            ClickSpeed = GetRandom(TXT_RandMin.Text, TXT_RandMax.Text)
        Else 'Random is not checked
            If TXT_Interval.Text = ("") Or TXT_Interval.Text = ("0") Or TXT_Interval.Text = (" ") Then
                MsgBox("Please, put a valid number value", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
            Else
                ClickSpeed = ((TXT_Interval.Text) * (1))
            End If
        End If
        Debug.WriteLine("Clickspeed = " & ClickSpeed)
        Return ClickSpeed
    End Function

    'Test click speed
    Private Sub BT_Test_Click(sender As Object, e As EventArgs) Handles BT_Test.Click
        TXT_Test.Text = TXT_Test.Text + 1
    End Sub

    'Get random value for click duration
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As Random = New Random()
        Return Generator.Next(Min, Max)
    End Function

    'Show interface for user to set start key
    Private Sub BT_ChangeStart_Click(sender As Object, e As EventArgs) Handles BT_ChangeStart.Click
        ChangeKey.FieldChange = "Start"
        ChangeKey.Show()
        Enabled = False
    End Sub

    'Show interface for user to set stop key
    Private Sub BT_ChangeStop_Click(sender As Object, e As EventArgs) Handles BT_ChangeStop.Click
        ChangeKey.FieldChange = "Stop"
        ChangeKey.Show()
        Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load settings file
        LoadSettings()

        TXT_StartKey.ReadOnly = True
        TXT_StartKey.Enabled = False
        TXT_StopKey.ReadOnly = True
        TXT_StopKey.Enabled = False
        TXT_Test.Enabled = False
    End Sub

    Private Sub BT_Reset_Click(sender As Object, e As EventArgs) Handles BT_Reset.Click
        TXT_Test.Text = 0
    End Sub

    'Load settings from file
    Private Sub LoadSettings()
        'Check if settings file exists
        If Not File.Exists(settingsFileLocation) Then Exit Sub

        'Read file and set controls to settings
        Using sr As New StreamReader(settingsFileLocation)
            Dim Line As String = sr.ReadLine
            Do While Line IsNot Nothing

                Select Case True
                    Case Line.Contains("StartKey=")
                        TXT_StartKey.Text = Line.Replace("StartKey=", "")
                    Case Line.Contains("StopKey=")
                        TXT_StopKey.Text = Line.Replace("StopKey=", "")
                    Case Line.Contains("Interval=")
                        TXT_Interval.Text = Line.Replace("Interval=", "")
                    Case Line.Contains("RandMax=")
                        TXT_RandMax.Text = Line.Replace("RandMax=", "")
                    Case Line.Contains("RandMin=")
                        TXT_RandMin.Text = Line.Replace("RandMin=", "")
                    Case Line.Contains("UseRandom=")
                        CHK_RandClick.Checked = Line.Replace("UseRandom=", "")
                    Case Else
                        Exit Sub
                End Select

                Line = sr.ReadLine()
            Loop
        End Using
    End Sub

    'Save settings to file
    Private Sub SaveSettings()
        Directory.CreateDirectory(settingsFileDirectory)
        'File.Create(settingsFileLocation)

        Dim settingsWriter As New StreamWriter(settingsFileLocation)
        Using settingsWriter
            settingsWriter.WriteLine("StartKey=" & TXT_StartKey.Text)
            settingsWriter.WriteLine("StopKey=" & TXT_StopKey.Text)
            settingsWriter.WriteLine("Interval=" & TXT_Interval.Text)
            settingsWriter.WriteLine("RandMax=" & TXT_RandMax.Text)
            settingsWriter.WriteLine("RandMin=" & TXT_RandMin.Text)
            settingsWriter.WriteLine("UseRandom=" & CHK_RandClick.Checked)
        End Using
    End Sub

    Private Sub BTN_SaveSettings_Click(sender As Object, e As EventArgs) Handles BTN_SaveSettings.Click
        SaveSettings()
    End Sub
End Class
