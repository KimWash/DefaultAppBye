Public Class logDialog
    Private Sub execute_Click(ByVal sender As Object, ByVal e As EventArgs) Handles execute.Click
        If (Me.cmd.Text = "") Then
            Interaction.MsgBox("커맨드를 입력해주세요.", MsgBoxStyle.OkOnly, CType(16, MsgBoxStyle))
        ElseIf (Me.cmd.Text = "adb shell") Then
            Interaction.MsgBox("shell은 지원되지 않습니다. 매게변수까지 직접 입력해주세요.", MsgBoxStyle.OkOnly, CType(16, MsgBoxStyle))
        Else
            Dim command As String() = Me.cmd.Text.Split(" ")
            Me.console.AppendText(Me.cmd.Text & vbCrLf)
            If command(0) = "adb" Then
                Me.console.AppendText(adb(command(1)))
            ElseIf command(0) = "fastboot" Then
                Me.console.AppendText(fastboot(command(1)))
            Else
                MsgBox("adb와 fastboot만 사용 가능합니다.", MsgBoxStyle.OkOnly, CType(16, MsgBoxStyle))
            End If

            Me.cmd.Text = ""
        End If
    End Sub

    Private Sub logDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("이 콘솔은 로그를 보는 용도 제외 제대로 쓰기에는 부적합합니다.")
    End Sub
    Private Sub cmd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmd.KeyDown
        If (e.KeyCode = 13) Then
            Me.execute_Click(sender, e)
        End If
    End Sub

End Class