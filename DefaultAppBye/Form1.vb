Imports MaterialSkin

Public Class Form1
    Private Sub uninst_Click(sender As Object, e As EventArgs) Handles uninst.Click
        uninstall.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim getDeviceThread As New System.Threading.Thread(AddressOf getDevices)
        getDeviceThread.Start()

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Function refreshDevice()
        Timer1.Interval = 5000
        Timer1.Enabled = True
    End Function

    Private Delegate Sub DoStuffDelegate()
    Sub getDevices()
        Dim deviceString = adb("devices -l")
        Try
            If deviceString = 0 Then
                Close()
            End If
        Catch ex As System.InvalidCastException

        End Try
        Dim deviceInfo As String() = deviceString.split(":")
        Dim deviceId As String() = {}
        Dim codename As String() = {}
        Dim model As String() = {}
        Try

            For i As Integer = 0 To deviceString.Split(vbCrLf).Length - 4
                deviceId.Add(deviceInfo(0 + 4 * i).Split(vbCrLf)(1).Split(" ")(0))
                model.Add(deviceInfo(2 + 4 * i).Split(" ")(0))
                codename.Add(deviceInfo(3 + 4 * i).Split(" ")(0))
            Next
        Catch ex As Exception
            MsgBox("기기 정보를 불러올 수 없습니다.", MsgBoxStyle.Critical)
            Exit Sub
        End Try


        If Me.InvokeRequired Then
            Me.Invoke(New DoStuffDelegate(AddressOf getDevices))
        Else
            Try
                Me.deviceLabel.Text = model(0)
                Me.codenameLabel.Text = codename(0)
                Me.andVer.Text = adb("shell getprop ro.build.version.release").split(vbCrLf)(0) & "  *API LEVEL: " & adb("shell getprop ro.build.version.sdk")
                connectionStatus.Text = "USB를 통해 연결됨"
                'adb -s 0019cbc shell 사용
                Try
                    deviceImage.Load("https://yoon-lab.xyz/adb-tool/images/" & codename(0) & ".png")
                Catch webexception1 As Exception
                    MsgBox("사진을 불러올 수 없습니다.", MsgBoxStyle.Critical)
                End Try
                adb("forward tcp:9000 tcp:9000")
            Catch ex As IndexOutOfRangeException
                MsgBox("기기가 연결되어 있지 않습니다.", MsgBoxStyle.Critical)
                connectionStatus.Text = "연결 해제"
                refreshDevice()
                Exit Sub
            End Try
        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        getDevices()
    End Sub
End Class
