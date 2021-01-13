Imports System.Windows.Forms.CheckedListBox

Public Class Dialog1
    Private Sub del_Click(sender As Object, e As EventArgs) Handles Del.Click
        Dim checkeditemcollection1 As CheckedItemCollection = Me.CheckedListBox1.CheckedItems
        Dim num1 As Integer = (checkeditemcollection1.Count - 1)
        Dim num2 As Integer = 0
        Do While (num2 <= num1)
            adb("shell pm uninstall -k --user 0 " + checkeditemcollection1.Item(num2))
            num2 = (num2 + 1)

        Loop
        Interaction.MsgBox("작업이 완료되었습니다!", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
        CheckedListBox1.Items.Remove(Me.CheckedListBox1.SelectedItem)
    End Sub

    Private Sub Dialog1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub Dialog1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If CheckedListBox1.Items.Count = 0 Then
            CheckedListBox1.Items.Add("검색결과가 없습니다!")
            Del.Enabled = False
        End If
    End Sub

    Private Sub Dialog1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = 27) Then
            Me.Close()
        End If
    End Sub
End Class
