' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
Namespace EasyOpcNetDemo
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
            Me.components = New System.ComponentModel.Container
            Dim ServerDescriptor1 As OpcLabs.EasyOpc.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor
            Dim ServerDescriptor2 As OpcLabs.EasyOpc.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor
            Me.easyDAClient1 = New OpcLabs.EasyOpc.DataAccess.EasyDAClient(Me.components)
            Me.valueTextBox = New System.Windows.Forms.TextBox
            Me.subscribeItemButton = New System.Windows.Forms.Button
            Me.qualityTextBox = New System.Windows.Forms.TextBox
            Me.timestampTextBox = New System.Windows.Forms.TextBox
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.exceptionTextBox = New System.Windows.Forms.TextBox
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.machineNameTextBox = New System.Windows.Forms.TextBox
            Me.browseServersButton = New System.Windows.Forms.Button
            Me.serverClassTextBox = New System.Windows.Forms.TextBox
            Me.label7 = New System.Windows.Forms.Label
            Me.unsubscribeItemButton = New System.Windows.Forms.Button
            Me.itemIdTextBox = New System.Windows.Forms.TextBox
            Me.requestedUpdateRateNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.label8 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.browseItemsButton = New System.Windows.Forms.Button
            Me.readItemButton = New System.Windows.Forms.Button
            Me.browsePropertiesButton = New System.Windows.Forms.Button
            Me.getPropertyValueButton = New System.Windows.Forms.Button
            Me.propertyIdMaskedTextBox = New System.Windows.Forms.MaskedTextBox
            Me.label10 = New System.Windows.Forms.Label
            Me.propertyValueTextBox = New System.Windows.Forms.TextBox
            Me.label11 = New System.Windows.Forms.Label
            Me.changeItemSubscriptionButton = New System.Windows.Forms.Button
            Me.percentDeadbandNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.label6 = New System.Windows.Forms.Label
            Me.writeItemValueButton = New System.Windows.Forms.Button
            Me.valueToWriteTextBox = New System.Windows.Forms.TextBox
            Me.label12 = New System.Windows.Forms.Label
            Me.browseMachinesButton = New System.Windows.Forms.Button
            Me.aboutButton = New System.Windows.Forms.Button
            Me.computerBrowserDialog1 = New OpcLabs.BaseLib.Forms.Browsing.Specialized.ComputerBrowserDialog(Me.components)
            Me.opcServerDialog1 = New OpcLabs.EasyOpc.Forms.Browsing.OpcServerDialog(Me.components)
            Me.opcDAPropertyDialog1 = New OpcLabs.EasyOpc.DataAccess.Forms.Browsing.DAPropertyDialog(Me.components)
            Me.opcDAItemDialog1 = New OpcLabs.EasyOpc.DataAccess.Forms.Browsing.DAItemDialog(Me.components)
            Me.closeButton = New System.Windows.Forms.Button
            Me.panel1 = New System.Windows.Forms.Panel
            Me.hintLabel = New System.Windows.Forms.Label
            CType(Me.requestedUpdateRateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.percentDeadbandNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'easyDAClient1
            '
            '
            'valueTextBox
            '
            Me.valueTextBox.Location = New System.Drawing.Point(436, 193)
            Me.valueTextBox.Name = "valueTextBox"
            Me.valueTextBox.ReadOnly = True
            Me.valueTextBox.Size = New System.Drawing.Size(200, 20)
            Me.valueTextBox.TabIndex = 0
            '
            'subscribeItemButton
            '
            Me.subscribeItemButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.subscribeItemButton.Location = New System.Drawing.Point(218, 191)
            Me.subscribeItemButton.Name = "subscribeItemButton"
            Me.subscribeItemButton.Size = New System.Drawing.Size(118, 23)
            Me.subscribeItemButton.TabIndex = 1
            Me.subscribeItemButton.Text = "Su&bscribe item"
            Me.subscribeItemButton.UseVisualStyleBackColor = True
            '
            'qualityTextBox
            '
            Me.qualityTextBox.Location = New System.Drawing.Point(436, 252)
            Me.qualityTextBox.Name = "qualityTextBox"
            Me.qualityTextBox.ReadOnly = True
            Me.qualityTextBox.Size = New System.Drawing.Size(200, 20)
            Me.qualityTextBox.TabIndex = 2
            '
            'timestampTextBox
            '
            Me.timestampTextBox.Location = New System.Drawing.Point(436, 222)
            Me.timestampTextBox.Name = "timestampTextBox"
            Me.timestampTextBox.ReadOnly = True
            Me.timestampTextBox.Size = New System.Drawing.Size(200, 20)
            Me.timestampTextBox.TabIndex = 3
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(393, 196)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(37, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Value:"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(369, 225)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(61, 13)
            Me.label2.TabIndex = 5
            Me.label2.Text = "Timestamp:"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(388, 255)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(42, 13)
            Me.label3.TabIndex = 6
            Me.label3.Text = "Quality:"
            '
            'exceptionTextBox
            '
            Me.exceptionTextBox.Location = New System.Drawing.Point(5, 294)
            Me.exceptionTextBox.Multiline = True
            Me.exceptionTextBox.Name = "exceptionTextBox"
            Me.exceptionTextBox.ReadOnly = True
            Me.exceptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.exceptionTextBox.Size = New System.Drawing.Size(755, 60)
            Me.exceptionTextBox.TabIndex = 7
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(2, 278)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(57, 13)
            Me.label4.TabIndex = 8
            Me.label4.Text = "Exception:"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(26, 49)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(80, 13)
            Me.label5.TabIndex = 9
            Me.label5.Text = "&Machine name:"
            '
            'machineNameTextBox
            '
            Me.machineNameTextBox.Location = New System.Drawing.Point(112, 46)
            Me.machineNameTextBox.Name = "machineNameTextBox"
            Me.machineNameTextBox.Size = New System.Drawing.Size(224, 20)
            Me.machineNameTextBox.TabIndex = 10
            '
            'browseServersButton
            '
            Me.browseServersButton.Location = New System.Drawing.Point(342, 70)
            Me.browseServersButton.Name = "browseServersButton"
            Me.browseServersButton.Size = New System.Drawing.Size(118, 23)
            Me.browseServersButton.TabIndex = 11
            Me.browseServersButton.Text = "< Browse &servers..."
            Me.browseServersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.browseServersButton.UseVisualStyleBackColor = True
            '
            'serverClassTextBox
            '
            Me.serverClassTextBox.Location = New System.Drawing.Point(112, 72)
            Me.serverClassTextBox.Name = "serverClassTextBox"
            Me.serverClassTextBox.Size = New System.Drawing.Size(224, 20)
            Me.serverClassTextBox.TabIndex = 14
            Me.serverClassTextBox.Text = "OPCLabs.KitServer.2"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(38, 75)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(68, 13)
            Me.label7.TabIndex = 15
            Me.label7.Text = "Server &class:"
            '
            'unsubscribeItemButton
            '
            Me.unsubscribeItemButton.Enabled = False
            Me.unsubscribeItemButton.Location = New System.Drawing.Point(218, 249)
            Me.unsubscribeItemButton.Name = "unsubscribeItemButton"
            Me.unsubscribeItemButton.Size = New System.Drawing.Size(118, 23)
            Me.unsubscribeItemButton.TabIndex = 16
            Me.unsubscribeItemButton.Text = "&Unsubscribe item"
            Me.unsubscribeItemButton.UseVisualStyleBackColor = True
            '
            'itemIdTextBox
            '
            Me.itemIdTextBox.Location = New System.Drawing.Point(112, 99)
            Me.itemIdTextBox.Name = "itemIdTextBox"
            Me.itemIdTextBox.Size = New System.Drawing.Size(224, 20)
            Me.itemIdTextBox.TabIndex = 17
            Me.itemIdTextBox.Text = "Demo.Ramp"
            '
            'requestedUpdateRateNumericUpDown
            '
            Me.requestedUpdateRateNumericUpDown.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.requestedUpdateRateNumericUpDown.Location = New System.Drawing.Point(112, 191)
            Me.requestedUpdateRateNumericUpDown.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.requestedUpdateRateNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.requestedUpdateRateNumericUpDown.Name = "requestedUpdateRateNumericUpDown"
            Me.requestedUpdateRateNumericUpDown.Size = New System.Drawing.Size(100, 20)
            Me.requestedUpdateRateNumericUpDown.TabIndex = 18
            Me.requestedUpdateRateNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.requestedUpdateRateNumericUpDown.ThousandsSeparator = True
            Me.requestedUpdateRateNumericUpDown.Value = New Decimal(New Integer() {50, 0, 0, 0})
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(62, 102)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(44, 13)
            Me.label8.TabIndex = 19
            Me.label8.Text = "Item &ID:"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(18, 193)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(88, 13)
            Me.label9.TabIndex = 20
            Me.label9.Text = "Update &rate (ms):"
            '
            'browseItemsButton
            '
            Me.browseItemsButton.Location = New System.Drawing.Point(342, 96)
            Me.browseItemsButton.Name = "browseItemsButton"
            Me.browseItemsButton.Size = New System.Drawing.Size(118, 23)
            Me.browseItemsButton.TabIndex = 21
            Me.browseItemsButton.Text = "< &Browse items..."
            Me.browseItemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.browseItemsButton.UseVisualStyleBackColor = True
            '
            'readItemButton
            '
            Me.readItemButton.Location = New System.Drawing.Point(218, 158)
            Me.readItemButton.Name = "readItemButton"
            Me.readItemButton.Size = New System.Drawing.Size(118, 23)
            Me.readItemButton.TabIndex = 22
            Me.readItemButton.Text = "&Read item"
            Me.readItemButton.UseVisualStyleBackColor = True
            '
            'browsePropertiesButton
            '
            Me.browsePropertiesButton.Location = New System.Drawing.Point(218, 127)
            Me.browsePropertiesButton.Name = "browsePropertiesButton"
            Me.browsePropertiesButton.Size = New System.Drawing.Size(118, 23)
            Me.browsePropertiesButton.TabIndex = 23
            Me.browsePropertiesButton.Text = "< Browse &properties..."
            Me.browsePropertiesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.browsePropertiesButton.UseVisualStyleBackColor = True
            '
            'getPropertyValueButton
            '
            Me.getPropertyValueButton.Location = New System.Drawing.Point(342, 127)
            Me.getPropertyValueButton.Name = "getPropertyValueButton"
            Me.getPropertyValueButton.Size = New System.Drawing.Size(118, 23)
            Me.getPropertyValueButton.TabIndex = 24
            Me.getPropertyValueButton.Text = "&Get property value"
            Me.getPropertyValueButton.UseVisualStyleBackColor = True
            '
            'propertyIdMaskedTextBox
            '
            Me.propertyIdMaskedTextBox.Location = New System.Drawing.Point(112, 128)
            Me.propertyIdMaskedTextBox.Mask = "0000000000"
            Me.propertyIdMaskedTextBox.Name = "propertyIdMaskedTextBox"
            Me.propertyIdMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.propertyIdMaskedTextBox.Size = New System.Drawing.Size(100, 20)
            Me.propertyIdMaskedTextBox.TabIndex = 25
            Me.propertyIdMaskedTextBox.Text = "1"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(43, 131)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(63, 13)
            Me.label10.TabIndex = 26
            Me.label10.Text = "Property I&D:"
            '
            'propertyValueTextBox
            '
            Me.propertyValueTextBox.Location = New System.Drawing.Point(560, 127)
            Me.propertyValueTextBox.Name = "propertyValueTextBox"
            Me.propertyValueTextBox.ReadOnly = True
            Me.propertyValueTextBox.Size = New System.Drawing.Size(200, 20)
            Me.propertyValueTextBox.TabIndex = 27
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Location = New System.Drawing.Point(476, 132)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(78, 13)
            Me.label11.TabIndex = 4
            Me.label11.Text = "Property value:"
            '
            'changeItemSubscriptionButton
            '
            Me.changeItemSubscriptionButton.Enabled = False
            Me.changeItemSubscriptionButton.Location = New System.Drawing.Point(218, 220)
            Me.changeItemSubscriptionButton.Name = "changeItemSubscriptionButton"
            Me.changeItemSubscriptionButton.Size = New System.Drawing.Size(118, 23)
            Me.changeItemSubscriptionButton.TabIndex = 28
            Me.changeItemSubscriptionButton.Text = "C&hange subscription"
            Me.changeItemSubscriptionButton.UseVisualStyleBackColor = True
            '
            'percentDeadbandNumericUpDown
            '
            Me.percentDeadbandNumericUpDown.DecimalPlaces = 3
            Me.percentDeadbandNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.percentDeadbandNumericUpDown.Location = New System.Drawing.Point(112, 220)
            Me.percentDeadbandNumericUpDown.Name = "percentDeadbandNumericUpDown"
            Me.percentDeadbandNumericUpDown.Size = New System.Drawing.Size(100, 20)
            Me.percentDeadbandNumericUpDown.TabIndex = 29
            Me.percentDeadbandNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(8, 225)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(98, 13)
            Me.label6.TabIndex = 30
            Me.label6.Text = "Percent deadba&nd:"
            '
            'writeItemValueButton
            '
            Me.writeItemValueButton.Location = New System.Drawing.Point(642, 156)
            Me.writeItemValueButton.Name = "writeItemValueButton"
            Me.writeItemValueButton.Size = New System.Drawing.Size(118, 23)
            Me.writeItemValueButton.TabIndex = 31
            Me.writeItemValueButton.Text = "&Write item value"
            Me.writeItemValueButton.UseVisualStyleBackColor = True
            '
            'valueToWriteTextBox
            '
            Me.valueToWriteTextBox.Location = New System.Drawing.Point(436, 158)
            Me.valueToWriteTextBox.Name = "valueToWriteTextBox"
            Me.valueToWriteTextBox.Size = New System.Drawing.Size(200, 20)
            Me.valueToWriteTextBox.TabIndex = 32
            Me.valueToWriteTextBox.Text = "1"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Location = New System.Drawing.Point(356, 161)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(74, 13)
            Me.label12.TabIndex = 33
            Me.label12.Text = "&Value to write:"
            '
            'browseMachinesButton
            '
            Me.browseMachinesButton.Location = New System.Drawing.Point(342, 43)
            Me.browseMachinesButton.Name = "browseMachinesButton"
            Me.browseMachinesButton.Size = New System.Drawing.Size(118, 23)
            Me.browseMachinesButton.TabIndex = 34
            Me.browseMachinesButton.Text = "< Browse m&achines..."
            Me.browseMachinesButton.UseVisualStyleBackColor = True
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
            'computerBrowserDialog1
            '
            Me.computerBrowserDialog1.Description = "Select machine where the OPC Server is located."
            '
            'opcServerDialog1
            '
            Me.opcServerDialog1.Location = ""
            '
            'opcDAPropertyDialog1
            '
            ServerDescriptor1.MachineName = ""
            ServerDescriptor1.ServerClass = ""
            Me.opcDAPropertyDialog1.ServerDescriptor = ServerDescriptor1
            '
            'opcDAItemDialog1
            '
            ServerDescriptor2.MachineName = ""
            ServerDescriptor2.ServerClass = ""
            Me.opcDAItemDialog1.ServerDescriptor = ServerDescriptor2
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
            Me.hintLabel.Size = New System.Drawing.Size(379, 13)
            Me.hintLabel.TabIndex = 37
            Me.hintLabel.Text = "Hint: Press the ""Subscribe item"" button to see dynamically changing OPC data."
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.closeButton
            Me.ClientSize = New System.Drawing.Size(772, 360)
            Me.Controls.Add(Me.hintLabel)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.closeButton)
            Me.Controls.Add(Me.aboutButton)
            Me.Controls.Add(Me.browseMachinesButton)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.valueToWriteTextBox)
            Me.Controls.Add(Me.writeItemValueButton)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.percentDeadbandNumericUpDown)
            Me.Controls.Add(Me.changeItemSubscriptionButton)
            Me.Controls.Add(Me.propertyValueTextBox)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.propertyIdMaskedTextBox)
            Me.Controls.Add(Me.getPropertyValueButton)
            Me.Controls.Add(Me.browsePropertiesButton)
            Me.Controls.Add(Me.readItemButton)
            Me.Controls.Add(Me.browseItemsButton)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.requestedUpdateRateNumericUpDown)
            Me.Controls.Add(Me.itemIdTextBox)
            Me.Controls.Add(Me.unsubscribeItemButton)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.serverClassTextBox)
            Me.Controls.Add(Me.browseServersButton)
            Me.Controls.Add(Me.machineNameTextBox)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.exceptionTextBox)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label11)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.timestampTextBox)
            Me.Controls.Add(Me.qualityTextBox)
            Me.Controls.Add(Me.subscribeItemButton)
            Me.Controls.Add(Me.valueTextBox)
            Me.MaximizeBox = False
            Me.Name = "MainForm"
            Me.Text = "EasyOPC.NET Demo Application"
            CType(Me.requestedUpdateRateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.percentDeadbandNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private WithEvents easyDAClient1 As OpcLabs.EasyOpc.DataAccess.EasyDAClient
		Private valueTextBox As System.Windows.Forms.TextBox
		Private WithEvents subscribeItemButton As System.Windows.Forms.Button
		Private qualityTextBox As System.Windows.Forms.TextBox
		Private timestampTextBox As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private exceptionTextBox As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private machineNameTextBox As System.Windows.Forms.TextBox
		Private WithEvents browseServersButton As System.Windows.Forms.Button
		Private serverClassTextBox As System.Windows.Forms.TextBox
		Private label7 As System.Windows.Forms.Label
		Private WithEvents unsubscribeItemButton As System.Windows.Forms.Button
		Private itemIdTextBox As System.Windows.Forms.TextBox
		Private requestedUpdateRateNumericUpDown As System.Windows.Forms.NumericUpDown
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private WithEvents browseItemsButton As System.Windows.Forms.Button
		Private WithEvents readItemButton As System.Windows.Forms.Button
		Private WithEvents browsePropertiesButton As System.Windows.Forms.Button
		Private WithEvents getPropertyValueButton As System.Windows.Forms.Button
		Private propertyIdMaskedTextBox As System.Windows.Forms.MaskedTextBox
		Private label10 As System.Windows.Forms.Label
		Private propertyValueTextBox As System.Windows.Forms.TextBox
		Private label11 As System.Windows.Forms.Label
		Private WithEvents changeItemSubscriptionButton As System.Windows.Forms.Button
		Private percentDeadbandNumericUpDown As System.Windows.Forms.NumericUpDown
		Private label6 As System.Windows.Forms.Label
		Private WithEvents writeItemValueButton As System.Windows.Forms.Button
		Private valueToWriteTextBox As System.Windows.Forms.TextBox
		Private label12 As System.Windows.Forms.Label
		Private WithEvents browseMachinesButton As System.Windows.Forms.Button
		Private WithEvents aboutButton As System.Windows.Forms.Button
        Private computerBrowserDialog1 As OpcLabs.BaseLib.Forms.Browsing.Specialized.ComputerBrowserDialog
        Private opcServerDialog1 As OpcLabs.EasyOpc.Forms.Browsing.OpcServerDialog
        Private opcDAPropertyDialog1 As OpcLabs.EasyOpc.DataAccess.Forms.Browsing.DAPropertyDialog
        Private opcDAItemDialog1 As OpcLabs.EasyOpc.DataAccess.Forms.Browsing.DAItemDialog
		Private WithEvents closeButton As System.Windows.Forms.Button
		Private panel1 As System.Windows.Forms.Panel
		Private hintLabel As System.Windows.Forms.Label
	End Class
End Namespace

