Imports System.ComponentModel
Imports OpcLabs.BaseLib.Forms
Imports OpcLabs.EasyOpc.UA.Forms.PubSub
Imports OpcLabs.EasyOpc.UA.PubSub

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.subscribeButton = New System.Windows.Forms.Button()
        Me.errorTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.readyMadeSettingsComboBox = New System.Windows.Forms.ComboBox()
        Me.infoLabel = New System.Windows.Forms.Label()
        Me.unsubscribeButton = New System.Windows.Forms.Button()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.subscribeDataSetArgumentsControl = New OpcLabs.BaseLib.Forms.AutomaticValueControl()
        Me.uaDataSetDataControl1 = New OpcLabs.EasyOpc.UA.Forms.PubSub.UADataSetDataControl()
        Me.label2 = New System.Windows.Forms.Label()
        Me.easyUASubscriber1 = New OpcLabs.EasyOpc.UA.PubSub.EasyUASubscriber(Me.components)
        CType(Me.subscribeDataSetArgumentsControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'subscribeButton
        '
        Me.subscribeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subscribeButton.Location = New System.Drawing.Point(602, 89)
        Me.subscribeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.subscribeButton.Name = "subscribeButton"
        Me.subscribeButton.Size = New System.Drawing.Size(90, 25)
        Me.subscribeButton.TabIndex = 5
        Me.subscribeButton.Text = "&Subscribe"
        Me.subscribeButton.UseVisualStyleBackColor = True
        '
        'errorTextBox
        '
        Me.errorTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.errorTextBox.Location = New System.Drawing.Point(11, 583)
        Me.errorTextBox.Multiline = True
        Me.errorTextBox.Name = "errorTextBox"
        Me.errorTextBox.ReadOnly = True
        Me.errorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.errorTextBox.Size = New System.Drawing.Size(685, 54)
        Me.errorTextBox.TabIndex = 8
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(109, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "&Ready-made settings:"
        '
        'readyMadeSettingsComboBox
        '
        Me.readyMadeSettingsComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.readyMadeSettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.readyMadeSettingsComboBox.FormattingEnabled = True
        Me.readyMadeSettingsComboBox.Items.AddRange(New Object() {"None (custom)", "JSON messages over MQTT transport, demo publisher on the Internet", "UADP messages over Ethernet transport, data from capture file on disk", "UADP messages over Ethernet transport, demo publisher on the local network", "UADP messages over MQTT transport, demo publisher on the Internet", "UADP messages over UDP transport, demo publisher on the local network", "Resolving information from a PubSub binary configuration file"})
        Me.readyMadeSettingsComboBox.Location = New System.Drawing.Point(126, 10)
        Me.readyMadeSettingsComboBox.Name = "readyMadeSettingsComboBox"
        Me.readyMadeSettingsComboBox.Size = New System.Drawing.Size(439, 21)
        Me.readyMadeSettingsComboBox.TabIndex = 2
        '
        'infoLabel
        '
        Me.infoLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoLabel.BackColor = System.Drawing.SystemColors.Info
        Me.infoLabel.Location = New System.Drawing.Point(11, 37)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(554, 28)
        Me.infoLabel.TabIndex = 3
        '
        'unsubscribeButton
        '
        Me.unsubscribeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.unsubscribeButton.Enabled = False
        Me.unsubscribeButton.Location = New System.Drawing.Point(602, 119)
        Me.unsubscribeButton.Name = "unsubscribeButton"
        Me.unsubscribeButton.Size = New System.Drawing.Size(90, 23)
        Me.unsubscribeButton.TabIndex = 6
        Me.unsubscribeButton.Text = "&Unsubscribe"
        Me.unsubscribeButton.UseVisualStyleBackColor = True
        '
        'aboutButton
        '
        Me.aboutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aboutButton.Location = New System.Drawing.Point(602, 8)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(90, 23)
        Me.aboutButton.TabIndex = 0
        Me.aboutButton.Text = "&About..."
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'subscribeDataSetArgumentsControl
        '
        Me.subscribeDataSetArgumentsControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subscribeDataSetArgumentsControl.EditTypeName = "OpcLabs.EasyOpc.UA.PubSub.OperationModel.UASubscribeDataSetArguments, OpcLabs.EasyOpcUA"
        Me.subscribeDataSetArgumentsControl.Location = New System.Drawing.Point(11, 89)
        Me.subscribeDataSetArgumentsControl.Margin = New System.Windows.Forms.Padding(2)
        Me.subscribeDataSetArgumentsControl.Name = "subscribeDataSetArgumentsControl"
        Me.subscribeDataSetArgumentsControl.Size = New System.Drawing.Size(554, 53)
        Me.subscribeDataSetArgumentsControl.TabIndex = 4
        '
        'uaDataSetDataControl1
        '
        Me.uaDataSetDataControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uaDataSetDataControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.uaDataSetDataControl1.Location = New System.Drawing.Point(11, 154)
        Me.uaDataSetDataControl1.Margin = New System.Windows.Forms.Padding(1)
        Me.uaDataSetDataControl1.MinimumSize = New System.Drawing.Size(685, 131)
        Me.uaDataSetDataControl1.Name = "uaDataSetDataControl1"
        Me.uaDataSetDataControl1.PreciseTimeFormat = True
        Me.uaDataSetDataControl1.RequestReadWrite = False
        Me.uaDataSetDataControl1.Size = New System.Drawing.Size(685, 429)
        Me.uaDataSetDataControl1.SizingGrip = False
        Me.uaDataSetDataControl1.TabIndex = 7
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(11, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(106, 13)
        Me.label2.TabIndex = 9
        Me.label2.Text = "&Dataset subscription:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 649)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.unsubscribeButton)
        Me.Controls.Add(Me.infoLabel)
        Me.Controls.Add(Me.readyMadeSettingsComboBox)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.subscribeDataSetArgumentsControl)
        Me.Controls.Add(Me.uaDataSetDataControl1)
        Me.Controls.Add(Me.subscribeButton)
        Me.Controls.Add(Me.errorTextBox)
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(720, 480)
        Me.Text = "EasyOPC-UA PubSub Demo Application"
        CType(Me.subscribeDataSetArgumentsControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents subscribeButton As Button
    Friend WithEvents uaDataSetDataControl1 As UADataSetDataControl
    Friend WithEvents subscribeDataSetArgumentsControl As AutomaticValueControl
    Friend WithEvents errorTextBox As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents readyMadeSettingsComboBox As ComboBox
    Friend WithEvents infoLabel As Label
    Friend WithEvents unsubscribeButton As Button
    Friend WithEvents aboutButton As Button
    Friend WithEvents label2 As Label
    Friend WithEvents easyUASubscriber1 As EasyUASubscriber
End Class
