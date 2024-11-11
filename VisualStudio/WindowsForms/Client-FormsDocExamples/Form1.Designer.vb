Namespace FormsDocExamples
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
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem9, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
            Me.MenuStrip1.Location = New System.Drawing.Point(2, 2)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
            Me.MenuStrip1.Size = New System.Drawing.Size(299, 199)
            Me.MenuStrip1.TabIndex = 0
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ToolStripMenuItem5
            '
            Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
            Me.ToolStripMenuItem5.Size = New System.Drawing.Size(247, 19)
            Me.ToolStripMenuItem5.Text = "_AEAreaOrSourceDialog.ShowDialog.Main1"
            '
            'ToolStripMenuItem6
            '
            Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
            Me.ToolStripMenuItem6.Size = New System.Drawing.Size(221, 19)
            Me.ToolStripMenuItem6.Text = "_AEAttributeDialog.ShowDialog.Main1"
            '
            'ToolStripMenuItem7
            '
            Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
            Me.ToolStripMenuItem7.Size = New System.Drawing.Size(275, 19)
            Me.ToolStripMenuItem7.Text = "_AECategoryConditionDialog.ShowDialog.Main1"
            '
            'ToolStripMenuItem8
            '
            Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
            Me.ToolStripMenuItem8.Size = New System.Drawing.Size(222, 19)
            Me.ToolStripMenuItem8.Text = "_AECategoryDialog.ShowDialog.Main1"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(256, 19)
            Me.ToolStripMenuItem1.Text = "_ComputerBrowserDialog.ShowDialog.Main1"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(200, 19)
            Me.ToolStripMenuItem2.Text = "_DAItemDialog.ShowDialog.Main1"
            '
            'ToolStripMenuItem9
            '
            Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
            Me.ToolStripMenuItem9.Size = New System.Drawing.Size(187, 19)
            Me.ToolStripMenuItem9.Text = "_OpcBrowseControl.UsageForm"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(220, 19)
            Me.ToolStripMenuItem3.Text = "_OpcBrowseDialog.ShowDialog.Main1"
            '
            'ToolStripMenuItem4
            '
            Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
            Me.ToolStripMenuItem4.Size = New System.Drawing.Size(214, 19)
            Me.ToolStripMenuItem4.Text = "_OpcServerDialog.ShowDialog.Main1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(303, 203)
            Me.Controls.Add(Me.MenuStrip1)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(2)
            Me.Text = "FormsDocExamples"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents MenuStrip1 As MenuStrip
        Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    End Class
End Namespace