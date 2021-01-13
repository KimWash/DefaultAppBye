Imports System.Windows.Forms.CheckedListBox

Public Class uninstall
    Private Sub uninstall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1 As Integer = (AppListBox.Items.Count - 1)
        Dim num2 As Integer = 0
        Do While (num2 <= num1)
            AppListBox.Items.RemoveAt(0)
            num2 = (num2 + 1)
        Loop
        Dim AppListString As String = adb("shell pm list packages -f")
        'adb -s 0019cbc shell 사용
        Dim AppListEachLines As String() = AppListString.Split(vbCrLf)
        Dim AppList As String() = {}
        For i As Integer = 0 To AppListEachLines.Length - 2
            Dim splitedList As String() = Split(AppListEachLines(i), ".apk=")
            AppListBox.Items.Add(splitedList(1))
        Next
        AppListBox.Sorted = True
    End Sub
    Private Sub uninstall_Closed(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub
    Private Sub Del_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Del.Click
        Dim checkeditemcollection1 As CheckedItemCollection = Me.AppListBox.CheckedItems
        Dim num1 As Integer = (checkeditemcollection1.Count - 1)
        Dim num2 As Integer = 0
        Do While (num2 <= num1)
            adb("shell pm uninstall -k --user 0 " + checkeditemcollection1.Item(num2))
            num2 = (num2 + 1)

        Loop
        Interaction.MsgBox("작업이 완료되었습니다!", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)
        AppListBox.Items.Remove(AppListBox.SelectedItem)

    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        For i As Integer = 0 To AppListBox.Items.Count - 1
            If AppListBox.Items(i).Contains(searchValue.Text) Then
                Dialog1.CheckedListBox1.Items.Add(AppListBox.Items(i))
            End If
        Next
        Dialog1.ShowDialog()

    End Sub

    Private Sub Log_Click(sender As Object, e As EventArgs) Handles Log.Click
        logDialog.Show()
    End Sub
    Private Sub searchValue_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles searchValue.KeyDown
        If (e.KeyCode = 13) Then
            Me.search_Click(sender, e)
        End If
    End Sub


End Class