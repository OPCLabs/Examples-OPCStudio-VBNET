' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

Partial Public Class MainForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.valueTextBox = New System.Windows.Forms.TextBox()
        Me.subscribeMonitoredItemButton = New System.Windows.Forms.Button()
        Me.statusTextBox = New System.Windows.Forms.TextBox()
        Me.serverTimestampTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.exceptionTextBox = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.serverUriTextBox = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.unsubscribeMonitoredItemButton = New System.Windows.Forms.Button()
        Me.nodeIdTextBox = New System.Windows.Forms.TextBox()
        Me.samplingIntervalNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.readButton = New System.Windows.Forms.Button()
        Me.changeMonitoredItemSubscriptionButton = New System.Windows.Forms.Button()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.hintLabel = New System.Windows.Forms.Label()
        Me.easyUAClient1 = New OpcLabs.EasyOpc.UA.EasyUAClient(Me.components)
        Me.sourceTimestampTextBox = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.valueToWriteTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.writeValueButton = New System.Windows.Forms.Button()
        Me.uaDataDialog1 = New OpcLabs.EasyOpc.UA.Forms.Browsing.UADataDialog(Me.components)
        Me.discoverServersButton = New System.Windows.Forms.Button()
        Me.browseDataButton = New System.Windows.Forms.Button()
        Me.uaHostAndEndpointDialog1 = New OpcLabs.EasyOpc.UA.Forms.Browsing.UAHostAndEndpointDialog(Me.components)
        CType(Me.samplingIntervalNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uaDataDialog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'valueTextBox
        '
        Me.valueTextBox.Location = New System.Drawing.Point(460, 147)
        Me.valueTextBox.Name = "valueTextBox"
        Me.valueTextBox.ReadOnly = True
        Me.valueTextBox.Size = New System.Drawing.Size(176, 20)
        Me.valueTextBox.TabIndex = 0
        '
        'subscribeMonitoredItemButton
        '
        Me.subscribeMonitoredItemButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subscribeMonitoredItemButton.Location = New System.Drawing.Point(218, 171)
        Me.subscribeMonitoredItemButton.Name = "subscribeMonitoredItemButton"
        Me.subscribeMonitoredItemButton.Size = New System.Drawing.Size(118, 23)
        Me.subscribeMonitoredItemButton.TabIndex = 1
        Me.subscribeMonitoredItemButton.Text = "Su&bscribe"
        Me.subscribeMonitoredItemButton.UseVisualStyleBackColor = True
        '
        'statusTextBox
        '
        Me.statusTextBox.Location = New System.Drawing.Point(460, 174)
        Me.statusTextBox.Name = "statusTextBox"
        Me.statusTextBox.ReadOnly = True
        Me.statusTextBox.Size = New System.Drawing.Size(176, 20)
        Me.statusTextBox.TabIndex = 2
        '
        'serverTimestampTextBox
        '
        Me.serverTimestampTextBox.Location = New System.Drawing.Point(460, 232)
        Me.serverTimestampTextBox.Name = "serverTimestampTextBox"
        Me.serverTimestampTextBox.ReadOnly = True
        Me.serverTimestampTextBox.Size = New System.Drawing.Size(176, 20)
        Me.serverTimestampTextBox.TabIndex = 3
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(417, 150)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Value:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(363, 235)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(91, 13)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Server timestamp:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(414, 176)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(40, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Status:"
        '
        'exceptionTextBox
        '
        Me.exceptionTextBox.Location = New System.Drawing.Point(5, 299)
        Me.exceptionTextBox.Multiline = True
        Me.exceptionTextBox.Name = "exceptionTextBox"
        Me.exceptionTextBox.ReadOnly = True
        Me.exceptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.exceptionTextBox.Size = New System.Drawing.Size(755, 90)
        Me.exceptionTextBox.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(2, 283)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(57, 13)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Exception:"
        '
        'serverUriTextBox
        '
        Me.serverUriTextBox.Location = New System.Drawing.Point(72, 44)
        Me.serverUriTextBox.Name = "serverUriTextBox"
        Me.serverUriTextBox.Size = New System.Drawing.Size(284, 20)
        Me.serverUriTextBox.TabIndex = 14
        Me.serverUriTextBox.Text = "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(9, 47)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(57, 13)
        Me.label7.TabIndex = 15
        Me.label7.Text = "Server &Uri:"
        '
        'unsubscribeMonitoredItemButton
        '
        Me.unsubscribeMonitoredItemButton.Enabled = False
        Me.unsubscribeMonitoredItemButton.Location = New System.Drawing.Point(218, 229)
        Me.unsubscribeMonitoredItemButton.Name = "unsubscribeMonitoredItemButton"
        Me.unsubscribeMonitoredItemButton.Size = New System.Drawing.Size(118, 23)
        Me.unsubscribeMonitoredItemButton.TabIndex = 16
        Me.unsubscribeMonitoredItemButton.Text = "&Unsubscribe"
        Me.unsubscribeMonitoredItemButton.UseVisualStyleBackColor = True
        '
        'nodeIdTextBox
        '
        Me.nodeIdTextBox.Location = New System.Drawing.Point(72, 73)
        Me.nodeIdTextBox.Name = "nodeIdTextBox"
        Me.nodeIdTextBox.Size = New System.Drawing.Size(284, 20)
        Me.nodeIdTextBox.TabIndex = 17
        Me.nodeIdTextBox.Text = "nsu=http://test.org/UA/Data/ ;i=10854"
        '
        'samplingIntervalNumericUpDown
        '
        Me.samplingIntervalNumericUpDown.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.samplingIntervalNumericUpDown.Location = New System.Drawing.Point(132, 171)
        Me.samplingIntervalNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.samplingIntervalNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.samplingIntervalNumericUpDown.Name = "samplingIntervalNumericUpDown"
        Me.samplingIntervalNumericUpDown.Size = New System.Drawing.Size(80, 20)
        Me.samplingIntervalNumericUpDown.TabIndex = 18
        Me.samplingIntervalNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.samplingIntervalNumericUpDown.ThousandsSeparator = True
        Me.samplingIntervalNumericUpDown.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(18, 75)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(48, 13)
        Me.label8.TabIndex = 19
        Me.label8.Text = "Node &Id:"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(14, 173)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(112, 13)
        Me.label9.TabIndex = 20
        Me.label9.Text = "Sampling interval (ms):"
        '
        'readButton
        '
        Me.readButton.Location = New System.Drawing.Point(218, 112)
        Me.readButton.Name = "readButton"
        Me.readButton.Size = New System.Drawing.Size(118, 23)
        Me.readButton.TabIndex = 22
        Me.readButton.Text = "&Read"
        Me.readButton.UseVisualStyleBackColor = True
        '
        'changeMonitoredItemSubscriptionButton
        '
        Me.changeMonitoredItemSubscriptionButton.Enabled = False
        Me.changeMonitoredItemSubscriptionButton.Location = New System.Drawing.Point(218, 200)
        Me.changeMonitoredItemSubscriptionButton.Name = "changeMonitoredItemSubscriptionButton"
        Me.changeMonitoredItemSubscriptionButton.Size = New System.Drawing.Size(118, 23)
        Me.changeMonitoredItemSubscriptionButton.TabIndex = 28
        Me.changeMonitoredItemSubscriptionButton.Text = "C&hange subscription"
        Me.changeMonitoredItemSubscriptionButton.UseVisualStyleBackColor = True
        '
        'aboutButton
        '
        Me.aboutButton.Location = New System.Drawing.Point(685, 44)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(75, 23)
        Me.aboutButton.TabIndex = 35
        Me.aboutButton.Text = "&About..."
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeButton.Location = New System.Drawing.Point(685, 70)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 35
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Location = New System.Drawing.Point(5, 32)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(754, 1)
        Me.panel1.TabIndex = 36
        '
        'hintLabel
        '
        Me.hintLabel.AutoSize = True
        Me.hintLabel.Location = New System.Drawing.Point(2, 9)
        Me.hintLabel.Name = "hintLabel"
        Me.hintLabel.Size = New System.Drawing.Size(357, 13)
        Me.hintLabel.TabIndex = 37
        Me.hintLabel.Text = "Hint: Press the ""Subscribe"" button to see dynamically changing OPC data."
        '
        'easyUAClient1
        '
        '
        'sourceTimestampTextBox
        '
        Me.sourceTimestampTextBox.Location = New System.Drawing.Point(460, 202)
        Me.sourceTimestampTextBox.Name = "sourceTimestampTextBox"
        Me.sourceTimestampTextBox.ReadOnly = True
        Me.sourceTimestampTextBox.Size = New System.Drawing.Size(176, 20)
        Me.sourceTimestampTextBox.TabIndex = 3
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(360, 205)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(94, 13)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Source timestamp:"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(234, 150)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(79, 13)
        Me.label10.TabIndex = 38
        Me.label10.Text = "Monitored item:"
        '
        'valueToWriteTextBox
        '
        Me.valueToWriteTextBox.Location = New System.Drawing.Point(460, 115)
        Me.valueToWriteTextBox.Name = "valueToWriteTextBox"
        Me.valueToWriteTextBox.Size = New System.Drawing.Size(176, 20)
        Me.valueToWriteTextBox.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(380, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Value to write:"
        '
        'writeValueButton
        '
        Me.writeValueButton.Location = New System.Drawing.Point(642, 112)
        Me.writeValueButton.Name = "writeValueButton"
        Me.writeValueButton.Size = New System.Drawing.Size(118, 23)
        Me.writeValueButton.TabIndex = 22
        Me.writeValueButton.Text = "&Write value"
        Me.writeValueButton.UseVisualStyleBackColor = True
        '
        'discoverServersButton
        '
        Me.discoverServersButton.Location = New System.Drawing.Point(362, 42)
        Me.discoverServersButton.Name = "discoverServersButton"
        Me.discoverServersButton.Size = New System.Drawing.Size(112, 23)
        Me.discoverServersButton.TabIndex = 39
        Me.discoverServersButton.Text = "< Browse servers..."
        Me.discoverServersButton.UseVisualStyleBackColor = True
        '
        'browseDataButton
        '
        Me.browseDataButton.Location = New System.Drawing.Point(362, 71)
        Me.browseDataButton.Name = "browseDataButton"
        Me.browseDataButton.Size = New System.Drawing.Size(112, 23)
        Me.browseDataButton.TabIndex = 40
        Me.browseDataButton.Text = "< Browse data..."
        Me.browseDataButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.closeButton
        Me.ClientSize = New System.Drawing.Size(772, 394)
        Me.Controls.Add(Me.browseDataButton)
        Me.Controls.Add(Me.discoverServersButton)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.hintLabel)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.changeMonitoredItemSubscriptionButton)
        Me.Controls.Add(Me.writeValueButton)
        Me.Controls.Add(Me.readButton)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.samplingIntervalNumericUpDown)
        Me.Controls.Add(Me.nodeIdTextBox)
        Me.Controls.Add(Me.unsubscribeMonitoredItemButton)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.serverUriTextBox)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.exceptionTextBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.sourceTimestampTextBox)
        Me.Controls.Add(Me.serverTimestampTextBox)
        Me.Controls.Add(Me.statusTextBox)
        Me.Controls.Add(Me.subscribeMonitoredItemButton)
        Me.Controls.Add(Me.valueToWriteTextBox)
        Me.Controls.Add(Me.valueTextBox)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "EasyOPC-UA Demo Application"
        CType(Me.samplingIntervalNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uaDataDialog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents easyUAClient1 As OpcLabs.EasyOpc.UA.EasyUAClient
    Private valueTextBox As System.Windows.Forms.TextBox
    Private WithEvents subscribeMonitoredItemButton As System.Windows.Forms.Button
    Private statusTextBox As System.Windows.Forms.TextBox
    Private serverTimestampTextBox As System.Windows.Forms.TextBox
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private exceptionTextBox As System.Windows.Forms.TextBox
    Private label4 As System.Windows.Forms.Label
    Private serverUriTextBox As System.Windows.Forms.TextBox
    Private label7 As System.Windows.Forms.Label
    Private WithEvents unsubscribeMonitoredItemButton As System.Windows.Forms.Button
    Private nodeIdTextBox As System.Windows.Forms.TextBox
    Private samplingIntervalNumericUpDown As System.Windows.Forms.NumericUpDown
    Private label8 As System.Windows.Forms.Label
    Private label9 As System.Windows.Forms.Label
    Private WithEvents readButton As System.Windows.Forms.Button
    Private WithEvents changeMonitoredItemSubscriptionButton As System.Windows.Forms.Button
    Private WithEvents aboutButton As System.Windows.Forms.Button
    'private OpcLabs.EasyOpc.DataAccess.Forms.ComputerBrowserDialog computerBrowserDialog1;
    'private OpcLabs.EasyOpc.DataAccess.Forms.OpcServerDialog opcServerDialog1;
    'private OpcLabs.EasyOpc.DataAccess.Forms.OpcDAPropertyDialog opcDAPropertyDialog1;
    'private OpcLabs.EasyOpc.DataAccess.Forms.OpcDAItemDialog opcDAItemDialog1;
    Private WithEvents closeButton As System.Windows.Forms.Button
    Private panel1 As System.Windows.Forms.Panel
    Private hintLabel As System.Windows.Forms.Label
    Private sourceTimestampTextBox As System.Windows.Forms.TextBox
    Private label5 As System.Windows.Forms.Label
    Private label10 As System.Windows.Forms.Label
    Private WithEvents valueToWriteTextBox As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents writeValueButton As System.Windows.Forms.Button
    Friend WithEvents uaDataDialog1 As OpcLabs.EasyOpc.UA.Forms.Browsing.UADataDialog
    Friend WithEvents discoverServersButton As System.Windows.Forms.Button
    Friend WithEvents browseDataButton As System.Windows.Forms.Button
    Friend WithEvents uaHostAndEndpointDialog1 As OpcLabs.EasyOpc.UA.Forms.Browsing.UAHostAndEndpointDialog
End Class