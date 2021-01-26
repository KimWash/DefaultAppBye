Imports System.Windows.Forms.CheckedListBox

Public Class Dialog1

    Private Sub del_Click(sender As Object, e As EventArgs) Handles Del.Click
        Dim checkeditemcollection1 As CheckedItemCollection = Me.CheckedListBox1.CheckedItems
        For x As Integer = 0 To checkeditemcollection1.Count

            For i As Integer = 0 To uninstall.appList.Count - 1
                If (checkeditemcollection1.Item(x) = uninstall.appList(i)("appName")) Then
                    adb("shell pm uninstall -k --user 0 " + uninstall.appList(i)("packageName"))
                    Interaction.MsgBox("작업이 완료되었습니다!", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
                    uninstall.updateList()
                End If
            Next


        Next
        Interaction.MsgBox("작업이 완료되었습니다!", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
        uninstall.updateList()
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
