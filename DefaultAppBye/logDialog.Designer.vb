<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logDialog
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.console = New System.Windows.Forms.TextBox()
        Me.execute = New System.Windows.Forms.Button()
        Me.cmd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'console
        '
        Me.console.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.console.Location = New System.Drawing.Point(12, 12)
        Me.console.Multiline = True
        Me.console.Name = "console"
        Me.console.ReadOnly = True
        Me.console.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.console.Size = New System.Drawing.Size(776, 403)
        Me.console.TabIndex = 0
        '
        'execute
        '
        Me.execute.Location = New System.Drawing.Point(713, 440)
        Me.execute.Name = "execute"
        Me.execute.Size = New System.Drawing.Size(75, 23)
        Me.execute.TabIndex = 1
        Me.execute.Text = "실행"
        Me.execute.UseVisualStyleBackColor = True
        '
        'cmd
        '
        Me.cmd.Location = New System.Drawing.Point(12, 442)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(695, 21)
        Me.cmd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 427)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "(고급) 명령어 직접 입력"
        '
        'logDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.execute)
        Me.Controls.Add(Me.console)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "logDialog"
        Me.Text = "logDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents console As TextBox
    Friend WithEvents execute As Button
    Friend WithEvents cmd As TextBox
    Friend WithEvents Label1 As Label
End Class
