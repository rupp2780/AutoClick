Public Class ChangeKey
    'Establish Keyboard hook
    Private WithEvents kbHook As New KeyboardHook

    'Selected keycode to be sent back to form1
    Dim KeyCode As String = ""

    'Which command is being changed
    Public FieldChange As String = ""

    Private Sub ChangeKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set textbox to disabled
        TXT_SetKey.ReadOnly = True
        TXT_SetKey.Enabled = False
    End Sub

    Private Sub kbHook_KeyDown(ByVal Key As Keys) Handles kbHook.KeyDown
        TXT_SetKey.Text = Key.ToString
        KeyCode = Key.ToString
    End Sub

    Private Sub BT_OK_Click(sender As Object, e As EventArgs) Handles BT_OK.Click
        Form1.Enabled = True

        If FieldChange = "Start" Then
            Form1.TXT_StartKey.Text = KeyCode
        ElseIf FieldChange = "Stop" Then
            Form1.TXT_StopKey.Text = KeyCode
        End If
        Close()
    End Sub
End Class