Namespace FormsDocExamples
    Public Class Form1
        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
            _ComputerBrowserDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
            _DAItemDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
            _OpcBrowseDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
            _OpcServerDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
            _AEAreaOrSourceDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
            _AEAttributeDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
            _AECategoryConditionDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
            _AECategoryDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
            Dim dialogResult = New _OpcBrowseControl.UsageForm().ShowDialog(Me)
        End Sub
    End Class
End Namespace