Namespace FormsDocExamples._OpcBrowseControl
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UsageForm
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
            Me.opcBrowseControl1 = New OpcLabs.EasyOpc.Forms.Browsing.OpcBrowseControl()
            Me.setInputsButton = New System.Windows.Forms.Button()
            Me.getOutputsButton = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.browsingEventsTextBox = New System.Windows.Forms.TextBox()
            Me.outputsTextBox = New System.Windows.Forms.TextBox()
            Me.opcBrowseControl1.BeginInit()
            Me.SuspendLayout()
            '
            'opcBrowseControl1
            '
            Me.opcBrowseControl1.Location = New System.Drawing.Point(13, 42)
            Me.opcBrowseControl1.MinimumSize = New System.Drawing.Size(135, 150)
            Me.opcBrowseControl1.Name = "opcBrowseControl1"
            Me.opcBrowseControl1.Size = New System.Drawing.Size(450, 300)
            Me.opcBrowseControl1.TabIndex = 0
            '
            'setInputsButton
            '
            Me.setInputsButton.Location = New System.Drawing.Point(13, 13)
            Me.setInputsButton.Name = "setInputsButton"
            Me.setInputsButton.Size = New System.Drawing.Size(75, 23)
            Me.setInputsButton.TabIndex = 1
            Me.setInputsButton.Text = "&Set inputs"
            Me.setInputsButton.UseVisualStyleBackColor = True
            '
            'getOutputsButton
            '
            Me.getOutputsButton.Location = New System.Drawing.Point(13, 349)
            Me.getOutputsButton.Name = "getOutputsButton"
            Me.getOutputsButton.Size = New System.Drawing.Size(75, 23)
            Me.getOutputsButton.TabIndex = 2
            Me.getOutputsButton.Text = "&Get outputs"
            Me.getOutputsButton.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(479, 42)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(88, 13)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Browsing &events:"
            '
            'browsingEventsTextBox
            '
            Me.browsingEventsTextBox.Location = New System.Drawing.Point(482, 59)
            Me.browsingEventsTextBox.Multiline = True
            Me.browsingEventsTextBox.Name = "browsingEventsTextBox"
            Me.browsingEventsTextBox.ReadOnly = True
            Me.browsingEventsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.browsingEventsTextBox.Size = New System.Drawing.Size(482, 283)
            Me.browsingEventsTextBox.TabIndex = 4
            '
            'outputsTextBox
            '
            Me.outputsTextBox.Location = New System.Drawing.Point(13, 379)
            Me.outputsTextBox.Multiline = True
            Me.outputsTextBox.Name = "outputsTextBox"
            Me.outputsTextBox.ReadOnly = True
            Me.outputsTextBox.Size = New System.Drawing.Size(951, 68)
            Me.outputsTextBox.TabIndex = 5
            '
            'UsageForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(976, 450)
            Me.Controls.Add(Me.outputsTextBox)
            Me.Controls.Add(Me.browsingEventsTextBox)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.getOutputsButton)
            Me.Controls.Add(Me.setInputsButton)
            Me.Controls.Add(Me.opcBrowseControl1)
            Me.Name = "UsageForm"
            Me.Text = "Usage"
            Me.opcBrowseControl1.EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents opcBrowseControl1 As OpcLabs.EasyOpc.Forms.Browsing.OpcBrowseControl
        Friend WithEvents setInputsButton As Button
        Friend WithEvents getOutputsButton As Button
        Friend WithEvents label1 As Label
        Friend WithEvents browsingEventsTextBox As TextBox
        Friend WithEvents outputsTextBox As TextBox
    End Class
End Namespace