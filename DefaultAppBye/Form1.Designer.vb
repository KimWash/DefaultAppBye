<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.andVer = New System.Windows.Forms.Label()
        Me.deviceLabel = New System.Windows.Forms.Label()
        Me.deviceImage = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.uninst = New MaterialSkin.Controls.MaterialFlatButton()
        Me.codenameLabel = New System.Windows.Forms.Label()
        Me.connectionStatus = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.deviceImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'andVer
        '
        Me.andVer.AutoSize = True
        Me.andVer.Location = New System.Drawing.Point(104, 135)
        Me.andVer.Name = "andVer"
        Me.andVer.Size = New System.Drawing.Size(0, 14)
        Me.andVer.TabIndex = 1
        '
        'deviceLabel
        '
        Me.deviceLabel.AutoSize = True
        Me.deviceLabel.Location = New System.Drawing.Point(62, 87)
        Me.deviceLabel.Name = "deviceLabel"
        Me.deviceLabel.Size = New System.Drawing.Size(0, 14)
        Me.deviceLabel.TabIndex = 6
        '
        'deviceImage
        '
        Me.deviceImage.Location = New System.Drawing.Point(261, 74)
        Me.deviceImage.Name = "deviceImage"
        Me.deviceImage.Size = New System.Drawing.Size(120, 139)
        Me.deviceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.deviceImage.TabIndex = 7
        Me.deviceImage.TabStop = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(10, 85)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(45, 18)
        Me.MaterialLabel1.TabIndex = 8
        Me.MaterialLabel1.Text = "기기명:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(10, 110)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(56, 18)
        Me.MaterialLabel2.TabIndex = 9
        Me.MaterialLabel2.Text = "코드네임:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(10, 134)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(93, 18)
        Me.MaterialLabel3.TabIndex = 10
        Me.MaterialLabel3.Text = "안드로이드 버전:"
        '
        'uninst
        '
        Me.uninst.AutoSize = True
        Me.uninst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.uninst.Depth = 0
        Me.uninst.Font = New System.Drawing.Font("나눔고딕", 9.0!)
        Me.uninst.Icon = Nothing
        Me.uninst.Location = New System.Drawing.Point(10, 177)
        Me.uninst.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.uninst.MouseState = MaterialSkin.MouseState.HOVER
        Me.uninst.Name = "uninst"
        Me.uninst.Primary = False
        Me.uninst.Size = New System.Drawing.Size(59, 36)
        Me.uninst.TabIndex = 11
        Me.uninst.Text = "앱 삭제"
        Me.uninst.UseVisualStyleBackColor = True
        '
        'codenameLabel
        '
        Me.codenameLabel.AutoSize = True
        Me.codenameLabel.Location = New System.Drawing.Point(71, 111)
        Me.codenameLabel.Name = "codenameLabel"
        Me.codenameLabel.Size = New System.Drawing.Size(0, 14)
        Me.codenameLabel.TabIndex = 4
        '
        'connectionStatus
        '
        Me.connectionStatus.AutoSize = True
        Me.connectionStatus.Location = New System.Drawing.Point(146, 222)
        Me.connectionStatus.Name = "connectionStatus"
        Me.connectionStatus.Size = New System.Drawing.Size(0, 14)
        Me.connectionStatus.TabIndex = 13
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 242)
        Me.ProgressBar1.MarqueeAnimationSpeed = 20
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(372, 3)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(392, 253)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.connectionStatus)
        Me.Controls.Add(Me.uninst)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.deviceImage)
        Me.Controls.Add(Me.deviceLabel)
        Me.Controls.Add(Me.codenameLabel)
        Me.Controls.Add(Me.andVer)
        Me.Font = New System.Drawing.Font("나눔고딕", 9.0!)
        Me.Name = "Form1"
        Me.Text = "Default App Bye!"
        CType(Me.deviceImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents andVer As Label
    Friend WithEvents deviceLabel As Label
    Friend WithEvents deviceImage As PictureBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents uninst As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents codenameLabel As Label
    Friend WithEvents connectionStatus As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
