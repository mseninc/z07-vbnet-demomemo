Public Class frmMain
    Public CurrentFilename As String = ""
    Public IsDirty As Boolean = False

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        Using dialog As New OpenFileDialog With {
            .Filter = "テキストファイル (*.txt)|*.txt|All Files (*.*)|*.*",
            .FilterIndex = 1,
            .Title = "ファイルを開く"
        }
            If dialog.ShowDialog() = DialogResult.OK Then
                Using sr As New IO.StreamReader(dialog.FileName)
                    txtEditor.Text = sr.ReadToEnd()
                End Using
                CurrentFilename = dialog.FileName
            End If
        End Using
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        If String.IsNullOrEmpty(CurrentFilename) Then
            mnuFileSaveAs.PerformClick()
        Else
            Using sw As New IO.StreamWriter(CurrentFilename)
                sw.Write(txtEditor.Text)
            End Using
            IsDirty = False
        End If
    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        Using dialog As New SaveFileDialog With {
            .Filter = "テキストファイル (*.txt)|*.txt|All Files (*.*)|*.*",
            .FilterIndex = 1,
            .Title = "ファイルを保存"
        }
            If dialog.ShowDialog() = DialogResult.OK Then
                Using sw As New IO.StreamWriter(dialog.FileName)
                    sw.Write(txtEditor.Text)
                End Using
                CurrentFilename = dialog.FileName
                IsDirty = False
            End If
        End Using
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        If IsDirty Then
            Dim result As DialogResult = MessageBox.Show("変更を保存しますか？", "確認", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                mnuFileSave.PerformClick()
            ElseIf result = DialogResult.Cancel Then
                Return
            End If
        End If
        Close()
    End Sub

    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        Clipboard.SetText(txtEditor.SelectedText)
        txtEditor.SelectedText = ""
    End Sub

    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        Clipboard.SetText(txtEditor.SelectedText)
    End Sub

    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        txtEditor.SelectedText = Clipboard.GetText()
    End Sub

    Private Sub txtEditor_TextChanged(sender As Object, e As EventArgs) Handles txtEditor.TextChanged
        IsDirty = True
    End Sub
End Class
