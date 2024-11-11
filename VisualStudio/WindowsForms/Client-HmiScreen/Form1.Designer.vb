' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
Namespace HmiScreen
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
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.easyDAClient1 = New OpcLabs.EasyOpc.DataAccess.EasyDAClient(Me.components)
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.textBox3 = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.writeValueTextBox = New System.Windows.Forms.TextBox()
            Me.textBox5 = New System.Windows.Forms.TextBox()
            Me.writeButton = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(12, 29)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(150, 20)
            Me.textBox1.TabIndex = 0
            Me.textBox1.Tag = "Simulation.Ramp (1 s)"
            '
            'easyDAClient1
            '
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(12, 55)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ReadOnly = True
            Me.textBox2.Size = New System.Drawing.Size(150, 20)
            Me.textBox2.TabIndex = 1
            Me.textBox2.Tag = "Simulation.Random"
            '
            'textBox3
            '
            Me.textBox3.Location = New System.Drawing.Point(12, 81)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.ReadOnly = True
            Me.textBox3.Size = New System.Drawing.Size(150, 20)
            Me.textBox3.TabIndex = 2
            Me.textBox3.Tag = "Simulation.Incrementing (1 s)"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(13, 13)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(85, 13)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Read-only items:"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(9, 114)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(77, 13)
            Me.label2.TabIndex = 4
            Me.label2.Text = "Writeable item:"
            '
            'writeValueTextBox
            '
            Me.writeValueTextBox.Location = New System.Drawing.Point(12, 131)
            Me.writeValueTextBox.Name = "writeValueTextBox"
            Me.writeValueTextBox.Size = New System.Drawing.Size(100, 20)
            Me.writeValueTextBox.TabIndex = 5
            Me.writeValueTextBox.Tag = "Simulation.Register_R8"
            '
            'textBox5
            '
            Me.textBox5.Location = New System.Drawing.Point(180, 131)
            Me.textBox5.Name = "textBox5"
            Me.textBox5.ReadOnly = True
            Me.textBox5.Size = New System.Drawing.Size(100, 20)
            Me.textBox5.TabIndex = 6
            Me.textBox5.Tag = "Simulation.Register_R8"
            '
            'writeButton
            '
            Me.writeButton.Location = New System.Drawing.Point(116, 131)
            Me.writeButton.Name = "writeButton"
            Me.writeButton.Size = New System.Drawing.Size(58, 20)
            Me.writeButton.TabIndex = 7
            Me.writeButton.Text = "&Write"
            Me.writeButton.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(292, 266)
            Me.Controls.Add(Me.writeButton)
            Me.Controls.Add(Me.textBox5)
            Me.Controls.Add(Me.writeValueTextBox)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.textBox3)
            Me.Controls.Add(Me.textBox2)
            Me.Controls.Add(Me.textBox1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private textBox1 As TextBox
		Private WithEvents easyDAClient1 As OpcLabs.EasyOpc.DataAccess.EasyDAClient
		Private textBox2 As TextBox
		Private textBox3 As TextBox
		Private label1 As Label
		Private label2 As Label
		Private writeValueTextBox As TextBox
		Private textBox5 As TextBox
		Private WithEvents writeButton As Button
	End Class
End Namespace

