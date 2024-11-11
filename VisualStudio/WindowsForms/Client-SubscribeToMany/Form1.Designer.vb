Namespace SubscribeToMany
	Partial Public Class Form1
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
			Me.valuesListView = New ListView()
			Me.startButton = New Button()
			Me.easyDAClient1 = New OpcLabs.EasyOpc.DataAccess.EasyDAClient(Me.components)
			Me.changeCountTextBox = New TextBox()
			Me.label1 = New Label()
			Me.elapsedTimeTextBox = New TextBox()
			Me.label2 = New Label()
			Me.label3 = New Label()
			Me.changesPerSecondTextBox = New TextBox()
			Me.timer1 = New Timer(Me.components)
			Me.numberOfItemsNumericUpDown = New NumericUpDown()
			Me.label4 = New Label()
			Me.label5 = New Label()
			CType(Me.numberOfItemsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' valuesListView
			' 
			Me.valuesListView.Location = New Point(12, 41)
			Me.valuesListView.Name = "valuesListView"
			Me.valuesListView.Size = New Size(568, 363)
			Me.valuesListView.TabIndex = 0
			Me.valuesListView.UseCompatibleStateImageBehavior = False
			' 
			' startButton
			' 
			Me.startButton.Location = New Point(505, 12)
			Me.startButton.Name = "startButton"
			Me.startButton.Size = New Size(75, 23)
			Me.startButton.TabIndex = 1
			Me.startButton.Text = "&Start"
			Me.startButton.UseVisualStyleBackColor = True
'			Me.startButton.Click += New System.EventHandler(Me.startButton_Click)
			' 
			' easyDAClient1
			' 
            '			Me.easyDAClient1.ItemChanged += New System.EventHandler(Of OpcLabs.EasyOpc.DataAccess.EasyDAItemChangedEventArgs)(Me.easyDAClient1_ItemChanged)
			' 
			' changeCountTextBox
			' 
			Me.changeCountTextBox.Location = New Point(630, 57)
			Me.changeCountTextBox.Name = "changeCountTextBox"
			Me.changeCountTextBox.ReadOnly = True
			Me.changeCountTextBox.Size = New Size(100, 20)
			Me.changeCountTextBox.TabIndex = 2
			Me.changeCountTextBox.TextAlign = HorizontalAlignment.Right
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New Point(627, 41)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(77, 13)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Change count:"
			' 
			' elapsedTimeTextBox
			' 
			Me.elapsedTimeTextBox.Location = New Point(630, 100)
			Me.elapsedTimeTextBox.Name = "elapsedTimeTextBox"
			Me.elapsedTimeTextBox.ReadOnly = True
			Me.elapsedTimeTextBox.Size = New Size(100, 20)
			Me.elapsedTimeTextBox.TabIndex = 4
			Me.elapsedTimeTextBox.TextAlign = HorizontalAlignment.Right
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New Point(630, 84)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(84, 13)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Elapsed time [s]:"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New Point(630, 127)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(92, 13)
			Me.label3.TabIndex = 6
			Me.label3.Text = "Changes/second:"
			' 
			' changesPerSecondTextBox
			' 
			Me.changesPerSecondTextBox.Location = New Point(630, 144)
			Me.changesPerSecondTextBox.Name = "changesPerSecondTextBox"
			Me.changesPerSecondTextBox.ReadOnly = True
			Me.changesPerSecondTextBox.Size = New Size(100, 20)
			Me.changesPerSecondTextBox.TabIndex = 7
			Me.changesPerSecondTextBox.TextAlign = HorizontalAlignment.Right
			' 
			' timer1
			' 
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
			' 
			' numberOfItemsNumericUpDown
			' 
			Me.numberOfItemsNumericUpDown.Increment = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.numberOfItemsNumericUpDown.Location = New Point(146, 12)
			Me.numberOfItemsNumericUpDown.Maximum = New Decimal(New Integer() { 50000, 0, 0, 0})
			Me.numberOfItemsNumericUpDown.Name = "numberOfItemsNumericUpDown"
			Me.numberOfItemsNumericUpDown.Size = New Size(100, 20)
			Me.numberOfItemsNumericUpDown.TabIndex = 8
			Me.numberOfItemsNumericUpDown.TextAlign = HorizontalAlignment.Right
			Me.numberOfItemsNumericUpDown.Value = New Decimal(New Integer() { 1000, 0, 0, 0})
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New Point(54, 14)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(86, 13)
			Me.label4.TabIndex = 9
			Me.label4.Text = "&Number of items:"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New Point(252, 14)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(212, 13)
			Me.label5.TabIndex = 10
			Me.label5.Text = "(each item triggers one change per second)"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(742, 416)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.numberOfItemsNumericUpDown)
			Me.Controls.Add(Me.changesPerSecondTextBox)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.elapsedTimeTextBox)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.changeCountTextBox)
			Me.Controls.Add(Me.startButton)
			Me.Controls.Add(Me.valuesListView)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.numberOfItemsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private valuesListView As ListView
		Private WithEvents startButton As Button
		Private WithEvents easyDAClient1 As OpcLabs.EasyOpc.DataAccess.EasyDAClient
		Private changeCountTextBox As TextBox
		Private label1 As Label
		Private elapsedTimeTextBox As TextBox
		Private label2 As Label
		Private label3 As Label
		Private changesPerSecondTextBox As TextBox
		Private WithEvents timer1 As Timer
		Private numberOfItemsNumericUpDown As NumericUpDown
		Private label4 As Label
		Private label5 As Label
	End Class
End Namespace

