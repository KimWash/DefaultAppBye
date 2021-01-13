Imports System.Runtime.CompilerServices

Module Extensions
    <Extension()>
    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = item
    End Sub
    <Extension()>
    Public Function adb(ByVal cmd As String)
        Try
            Dim process As Process = New Process()
            process.StartInfo.CreateNoWindow = True
            process.StartInfo.RedirectStandardOutput = True
            process.StartInfo.UseShellExecute = False
            process.StartInfo.FileName = "./adb.exe"
            process.StartInfo.Arguments = cmd
            process.Start()
            Dim str As String = process.StandardOutput.ReadToEnd()
            process = Nothing
            logDialog.console.AppendText("adb " & cmd & vbCrLf)
            logDialog.console.AppendText(str & vbCrLf)
            Return str
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("adb를 찾을 수 없습니다.", MsgBoxStyle.Critical)
            Return 0
        End Try

    End Function
    Public Function fastboot(ByVal cmd As String)
        Dim process As Process = New Process()
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.UseShellExecute = False
        process.StartInfo.FileName = "./fastboot.exe"
        process.StartInfo.Arguments = cmd
        process.Start()
        Dim str As String = process.StandardOutput.ReadToEnd()
        process = Nothing
        logDialog.console.AppendText("fastboot " & cmd & vbCrLf)
        logDialog.console.AppendText(str & vbCrLf)
        Return str
    End Function
End Module
