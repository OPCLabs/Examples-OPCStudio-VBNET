Namespace UAFormsDocExamples
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Form1
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
            Me.menuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'menuStrip1
            '
            Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.toolStripMenuItem8, Me.toolStripMenuItem2, Me.toolStripMenuItem3, Me.toolStripMenuItem9, Me.toolStripMenuItem4, Me.toolStripMenuItem7, Me.toolStripMenuItem5, Me.toolStripMenuItem6})
            Me.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
            Me.menuStrip1.Location = New System.Drawing.Point(2, 2)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
            Me.menuStrip1.Size = New System.Drawing.Size(300, 193)
            Me.menuStrip1.TabIndex = 0
            Me.menuStrip1.Text = "menuStrip1"
            '
            'toolStripMenuItem1
            '
            Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
            Me.toolStripMenuItem1.Size = New System.Drawing.Size(256, 19)
            Me.toolStripMenuItem1.Text = "_ComputerBrowserDialog.ShowDialog.Main1"
            '
            'toolStripMenuItem8
            '
            Me.toolStripMenuItem8.Name = "toolStripMenuItem8"
            Me.toolStripMenuItem8.Size = New System.Drawing.Size(181, 19)
            Me.toolStripMenuItem8.Text = "_UABrowseControl.UsageForm"
            '
            'toolStripMenuItem2
            '
            Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
            Me.toolStripMenuItem2.Size = New System.Drawing.Size(214, 19)
            Me.toolStripMenuItem2.Text = "_UABrowseDialog.ShowDialog.Main1"
            '
            'toolStripMenuItem3
            '
            Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
            Me.toolStripMenuItem3.Size = New System.Drawing.Size(240, 19)
            Me.toolStripMenuItem3.Text = "_UABrowseDialog.ShowDialog.MultiSelect"
            '
            'toolStripMenuItem9
            '
            Me.toolStripMenuItem9.Name = "toolStripMenuItem9"
            Me.toolStripMenuItem9.Size = New System.Drawing.Size(288, 19)
            Me.toolStripMenuItem9.Text = "_UABrowseDialog.ShowDialog.SelectionDescriptors"
            '
            'toolStripMenuItem4
            '
            Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
            Me.toolStripMenuItem4.Size = New System.Drawing.Size(200, 19)
            Me.toolStripMenuItem4.Text = "_UADataDialog.ShowDialog.Main1"
            '
            'toolStripMenuItem7
            '
            Me.toolStripMenuItem7.Name = "toolStripMenuItem7"
            Me.toolStripMenuItem7.Size = New System.Drawing.Size(226, 19)
            Me.toolStripMenuItem7.Text = "_UADataDialog.ShowDialog.MultiSelect"
            '
            'toolStripMenuItem5
            '
            Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
            Me.toolStripMenuItem5.Size = New System.Drawing.Size(224, 19)
            Me.toolStripMenuItem5.Text = "_UAEndpointDialog.ShowDialog.Main1"
            '
            'toolStripMenuItem6
            '
            Me.toolStripMenuItem6.Name = "toolStripMenuItem6"
            Me.toolStripMenuItem6.Size = New System.Drawing.Size(271, 19)
            Me.toolStripMenuItem6.Text = "_UAHostAndEndpointDialog.ShowDialog.Main1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(304, 197)
            Me.Controls.Add(Me.menuStrip1)
            Me.MainMenuStrip = Me.menuStrip1
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(2)
            Me.Text = "UAFormsDocExamples"
            Me.menuStrip1.ResumeLayout(False)
            Me.menuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents menuStrip1 As MenuStrip
        Friend WithEvents toolStripMenuItem1 As ToolStripMenuItem
        Friend WithEvents toolStripMenuItem8 As ToolStripMenuItem
        Friend WithEvents toolStripMenuItem2 As ToolStripMenuItem
        Friend WithEvents toolStripMenuItem3 As ToolStripMenuItem
        Friend WithEvents toolStripMenuItem9 As ToolStripMenuItem
        Friend WithEvents toolStripMenuItem4 As ToolStripMenuItem
        Friend WithEvents toolStripMenuItem7 As ToolStripMenuItem
        Friend WithEvents toolStripMenuItem5 As ToolStripMenuItem
        Friend WithEvents toolStripMenuItem6 As ToolStripMenuItem
    End Class
End Namespace