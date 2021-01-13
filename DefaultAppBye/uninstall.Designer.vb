<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uninstall
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.AppListBox = New System.Windows.Forms.CheckedListBox()
        Me.Log = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Del = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.search = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.searchValue = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'AppListBox
        '
        Me.AppListBox.FormattingEnabled = True
        Me.AppListBox.Location = New System.Drawing.Point(12, 113)
        Me.AppListBox.Name = "AppListBox"
        Me.AppListBox.Size = New System.Drawing.Size(510, 452)
        Me.AppListBox.TabIndex = 0
        '
        'Log
        '
        Me.Log.AutoSize = True
        Me.Log.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Log.Depth = 0
        Me.Log.Icon = Nothing
        Me.Log.Location = New System.Drawing.Point(452, 71)
        Me.Log.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Log.MouseState = MaterialSkin.MouseState.HOVER
        Me.Log.Name = "Log"
        Me.Log.Primary = False
        Me.Log.Size = New System.Drawing.Size(70, 36)
        Me.Log.TabIndex = 5
        Me.Log.Text = "로그 보기"
        Me.Log.UseVisualStyleBackColor = True
        '
        'Del
        '
        Me.Del.AutoSize = True
        Me.Del.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Del.Depth = 0
        Me.Del.Icon = Nothing
        Me.Del.Location = New System.Drawing.Point(12, 571)
        Me.Del.MouseState = MaterialSkin.MouseState.HOVER
        Me.Del.Name = "Del"
        Me.Del.Primary = True
        Me.Del.Size = New System.Drawing.Size(45, 36)
        Me.Del.TabIndex = 6
        Me.Del.Text = "삭제"
        Me.Del.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.AutoSize = True
        Me.search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.search.Depth = 0
        Me.search.Icon = Nothing
        Me.search.Location = New System.Drawing.Point(401, 71)
        Me.search.MouseState = MaterialSkin.MouseState.HOVER
        Me.search.Name = "search"
        Me.search.Primary = True
        Me.search.Size = New System.Drawing.Size(44, 36)
        Me.search.TabIndex = 7
        Me.search.Text = "검색"
        Me.search.UseVisualStyleBackColor = True
        '
        'searchValue
        '
        Me.searchValue.Depth = 0
        Me.searchValue.Font = New System.Drawing.Font("나눔고딕", 17.0!)
        Me.searchValue.Hint = ""
        Me.searchValue.Location = New System.Drawing.Point(12, 79)
        Me.searchValue.MaxLength = 32767
        Me.searchValue.MouseState = MaterialSkin.MouseState.HOVER
        Me.searchValue.Name = "searchValue"
        Me.searchValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchValue.SelectedText = ""
        Me.searchValue.SelectionLength = 0
        Me.searchValue.SelectionStart = 0
        Me.searchValue.Size = New System.Drawing.Size(383, 19)
        Me.searchValue.TabIndex = 8
        Me.searchValue.TabStop = False
        Me.searchValue.UseSystemPasswordChar = False
        '
        'uninstall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 615)
        Me.Controls.Add(Me.searchValue)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Del)
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.AppListBox)
        Me.Font = New System.Drawing.Font("나눔고딕", 9.0!)
        Me.Name = "uninstall"
        Me.Text = "Uninstall"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AppListBox As CheckedListBox
    Friend WithEvents Log As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Del As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents search As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents searchValue As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
