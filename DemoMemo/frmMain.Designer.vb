<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.txtEditor = New System.Windows.Forms.TextBox()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(800, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'txtEditor
        '
        Me.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEditor.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.txtEditor.Location = New System.Drawing.Point(0, 24)
        Me.txtEditor.Multiline = True
        Me.txtEditor.Name = "txtEditor"
        Me.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEditor.Size = New System.Drawing.Size(800, 426)
        Me.txtEditor.TabIndex = 1
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(70, 20)
        Me.mnuFile.Text = "ファイル (&F)"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileOpen.Text = "開く (&O)"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileSave.Text = "上書き保存 (&S)"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileSaveAs.Text = "名前をつけて保存 (&A)"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileExit.Text = "終了 (&X)"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(60, 20)
        Me.mnuEdit.Text = "編集 (&E)"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.Size = New System.Drawing.Size(180, 22)
        Me.mnuEditCut.Text = "切り取り (&T)"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.Size = New System.Drawing.Size(180, 22)
        Me.mnuEditCopy.Text = "コピー (&C)"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.Size = New System.Drawing.Size(180, 22)
        Me.mnuEditPaste.Text = "貼り付け (&P)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtEditor)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "DemoMemo"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents txtEditor As TextBox
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
End Class
