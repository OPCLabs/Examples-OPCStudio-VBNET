Imports OpcLabs.EasyOpc.UA.Forms.Application
Imports OpcLabs.EasyOpc.UA.Forms.Browsing.ComTypes

Namespace UAFormsDocExamples
    Public Class Form1
        Private Sub toolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem1.Click
            _ComputerBrowserDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub toolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem2.Click
            _UABrowseDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub toolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem3.Click
            _UABrowseDialog.ShowDialog.MultiSelect(Me)
        End Sub

        Private Sub toolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem4.Click
            _UADataDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub toolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem5.Click
            _UAEndpointDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub toolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem6.Click
            _UAHostAndEndpointDialog.ShowDialog.Main1(Me)
        End Sub

        Private Sub toolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem7.Click
            _UADataDialog.ShowDialog.MultiSelect(Me)
        End Sub

        Private Sub toolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem8.Click
            _UABrowseControl.UsageForm.ShowDialog(Me)
        End Sub

        Private Sub toolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem9.Click
            _UABrowseDialog.ShowDialog.SelectionDescriptors(Me)
        End Sub
        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
            EasyUAFormsApplication.Instance.AddToSystemMenu(Me)
        End Sub

    End Class
End Namespace
