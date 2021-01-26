Imports System.Windows.Forms.CheckedListBox
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports Newtonsoft.Json

Public Class uninstall
    Dim IP As String = "IPADDRESS"
    Dim Port As String = 9000

    Dim clientSocket As New System.Net.Sockets.TcpClient()

    Dim serverEndPoint As New IPEndPoint(IPAddress.Parse(IP), Port)
    Public Shared appList As List(Of Dictionary(Of String, String))


    Function updateList()
        AppListBox.Items.Clear()

        Dim clientStream As NetworkStream = clientSocket.GetStream()
        Dim encoder As New ASCIIEncoding()
        clientSocket.ReceiveTimeout = 10000

        Dim buffer() As Byte = encoder.GetBytes("request List")

        clientStream.Write(buffer, 0, buffer.Length)

        clientStream.Flush()

        ' Receive the TcpServer.response.

        ' Buffer to store the response bytes.
        Dim data(1024) As Byte

        ' String to store the response ASCII representation.
        Dim responseData As New StringBuilder()
        clientSocket.ReceiveBufferSize = 1024
        Dim bytesToRead = 0
        Debug.Print(clientStream.DataAvailable)
        Do
            Debug.Print(clientStream.DataAvailable)
            bytesToRead = clientStream.Read(data, 0, data.Length)
            responseData.Append(System.Text.Encoding.UTF8.GetString(data, 0, bytesToRead))
        Loop While (clientStream.DataAvailable)

        appList = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(responseData.ToString)


        For x As Integer = 0 To appList.Count - 1
            AppListBox.Items.Add(appList(x)("appName"))
        Next
        AppListBox.Sorted = True

    End Function

    Private Sub uninstall_Closed(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
        clientSocket.Close()
    End Sub
    Private Sub Del_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Del.Click
        Dim checkeditemcollection1 As CheckedItemCollection = Me.AppListBox.CheckedItems
        Debug.Print(checkeditemcollection1.Count - 1)
        Debug.Print(appList.Count - 1)
        For x As Integer = 0 To checkeditemcollection1.Count - 1
            If (checkeditemcollection1.Item(x).ToString().Contains("sec") Or checkeditemcollection1.Item(x).ToString().Contains("android") Or checkeditemcollection1.Item(x).ToString().Contains("knox") Or checkeditemcollection1.Item(x).ToString().Contains("lg")) Then
                Dim res = Interaction.MsgBox("시스템 앱으로 보여 삭제하면 시스템 구동에 문제가 생길 수 있습니다. 삭제할까요?", MsgBoxStyle.YesNo, MsgBoxStyle.Information)
                If (res = DialogResult.OK) Then
                    For i As Integer = 0 To appList.Count - 1
                        If (checkeditemcollection1.Item(x) = appList(i)("appName")) Then
                            adb("shell pm uninstall -k --user 0 " + appList(i)("packageName"))
                            Interaction.MsgBox("작업이 완료되었습니다!", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

                        End If
                    Next
                End If
            Else
                For i As Integer = 0 To appList.Count - 1
                    If (checkeditemcollection1.Item(x) = appList(i)("appName")) Then
                        adb("shell pm uninstall -k --user 0 " + appList(i)("packageName"))
                        Interaction.MsgBox("작업이 완료되었습니다!", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

                    End If
                Next
            End If




        Next
        updateList()


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

    Private Sub uninstall_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        clientSocket.Connect(serverEndPoint)

        updateList()
    End Sub

End Class