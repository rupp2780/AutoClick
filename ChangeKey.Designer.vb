<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeKey
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
        Me.TXT_SetKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_SetKey
        '
        Me.TXT_SetKey.Location = New System.Drawing.Point(92, 128)
        Me.TXT_SetKey.Name = "TXT_SetKey"
        Me.TXT_SetKey.Size = New System.Drawing.Size(100, 20)
        Me.TXT_SetKey.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Press your preferred key, then click OK."
        '
        'BT_OK
        '
        Me.BT_OK.Location = New System.Drawing.Point(105, 153)
        Me.BT_OK.Name = "BT_OK"
        Me.BT_OK.Size = New System.Drawing.Size(75, 23)
        Me.BT_OK.TabIndex = 2
        Me.BT_OK.Text = "OK"
        Me.BT_OK.UseVisualStyleBackColor = True
        '
        'ChangeKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.BT_OK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_SetKey)
        Me.Name = "ChangeKey"
        Me.Text = "ChangeKey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_SetKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_OK As Button
End Class
