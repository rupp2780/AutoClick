<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TXT_Interval = New System.Windows.Forms.TextBox()
        Me.BT_Stop = New System.Windows.Forms.Button()
        Me.BT_Start = New System.Windows.Forms.Button()
        Me.TXT_StartKey = New System.Windows.Forms.TextBox()
        Me.TXT_StopKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CHK_RandClick = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_RandMax = New System.Windows.Forms.TextBox()
        Me.TXT_RandMin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_CountTo = New System.Windows.Forms.TextBox()
        Me.TXT_Test = New System.Windows.Forms.TextBox()
        Me.BT_Test = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BT_ChangeStop = New System.Windows.Forms.Button()
        Me.BT_ChangeStart = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BT_Reset = New System.Windows.Forms.Button()
        Me.BTN_SaveSettings = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'TXT_Interval
        '
        resources.ApplyResources(Me.TXT_Interval, "TXT_Interval")
        Me.TXT_Interval.Name = "TXT_Interval"
        '
        'BT_Stop
        '
        Me.BT_Stop.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.BT_Stop, "BT_Stop")
        Me.BT_Stop.Name = "BT_Stop"
        Me.BT_Stop.UseVisualStyleBackColor = True
        '
        'BT_Start
        '
        Me.BT_Start.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.BT_Start, "BT_Start")
        Me.BT_Start.Name = "BT_Start"
        Me.BT_Start.UseVisualStyleBackColor = True
        '
        'TXT_StartKey
        '
        resources.ApplyResources(Me.TXT_StartKey, "TXT_StartKey")
        Me.TXT_StartKey.Name = "TXT_StartKey"
        '
        'TXT_StopKey
        '
        resources.ApplyResources(Me.TXT_StopKey, "TXT_StopKey")
        Me.TXT_StopKey.Name = "TXT_StopKey"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'CHK_RandClick
        '
        resources.ApplyResources(Me.CHK_RandClick, "CHK_RandClick")
        Me.CHK_RandClick.Name = "CHK_RandClick"
        Me.CHK_RandClick.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_SaveSettings)
        Me.GroupBox1.Controls.Add(Me.TXT_RandMax)
        Me.GroupBox1.Controls.Add(Me.TXT_RandMin)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CHK_RandClick)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'TXT_RandMax
        '
        resources.ApplyResources(Me.TXT_RandMax, "TXT_RandMax")
        Me.TXT_RandMax.Name = "TXT_RandMax"
        '
        'TXT_RandMin
        '
        resources.ApplyResources(Me.TXT_RandMin, "TXT_RandMin")
        Me.TXT_RandMin.Name = "TXT_RandMin"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'TXT_CountTo
        '
        resources.ApplyResources(Me.TXT_CountTo, "TXT_CountTo")
        Me.TXT_CountTo.Name = "TXT_CountTo"
        '
        'TXT_Test
        '
        resources.ApplyResources(Me.TXT_Test, "TXT_Test")
        Me.TXT_Test.Name = "TXT_Test"
        '
        'BT_Test
        '
        Me.BT_Test.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.BT_Test, "BT_Test")
        Me.BT_Test.Name = "BT_Test"
        Me.BT_Test.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BT_ChangeStop)
        Me.GroupBox2.Controls.Add(Me.BT_ChangeStart)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TXT_Interval)
        Me.GroupBox2.Controls.Add(Me.TXT_StartKey)
        Me.GroupBox2.Controls.Add(Me.TXT_StopKey)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'BT_ChangeStop
        '
        resources.ApplyResources(Me.BT_ChangeStop, "BT_ChangeStop")
        Me.BT_ChangeStop.Name = "BT_ChangeStop"
        Me.BT_ChangeStop.UseVisualStyleBackColor = True
        '
        'BT_ChangeStart
        '
        resources.ApplyResources(Me.BT_ChangeStart, "BT_ChangeStart")
        Me.BT_ChangeStart.Name = "BT_ChangeStart"
        Me.BT_ChangeStart.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BT_Reset)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.BT_Start)
        Me.GroupBox3.Controls.Add(Me.TXT_Test)
        Me.GroupBox3.Controls.Add(Me.BT_Stop)
        Me.GroupBox3.Controls.Add(Me.BT_Test)
        Me.GroupBox3.Controls.Add(Me.TXT_CountTo)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'BT_Reset
        '
        resources.ApplyResources(Me.BT_Reset, "BT_Reset")
        Me.BT_Reset.Name = "BT_Reset"
        Me.BT_Reset.UseVisualStyleBackColor = True
        '
        'BTN_SaveSettings
        '
        resources.ApplyResources(Me.BTN_SaveSettings, "BTN_SaveSettings")
        Me.BTN_SaveSettings.Name = "BTN_SaveSettings"
        Me.BTN_SaveSettings.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TXT_Interval As TextBox
    Friend WithEvents BT_Stop As Button
    Friend WithEvents BT_Start As Button
    Friend WithEvents TXT_StartKey As TextBox
    Friend WithEvents TXT_StopKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CHK_RandClick As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_RandMax As TextBox
    Friend WithEvents TXT_RandMin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_CountTo As TextBox
    Friend WithEvents TXT_Test As TextBox
    Friend WithEvents BT_Test As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BT_ChangeStart As Button
    Friend WithEvents BT_ChangeStop As Button
    Friend WithEvents BT_Reset As Button
    Friend WithEvents BTN_SaveSettings As Button
End Class
