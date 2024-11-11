Imports JetBrains.Annotations


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
        Me.easyDAClient1 = New OpcLabs.EasyOpc.DataAccess.EasyDAClient(Me.components)
        Me.lblUpdateRate = New System.Windows.Forms.Label()
        Me.nudUpdateRate = New System.Windows.Forms.NumericUpDown()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lblFanPower = New System.Windows.Forms.Label()
        Me.txbFanPower = New System.Windows.Forms.TextBox()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStop = New System.Windows.Forms.Button()
        Me.txbHeaterPower = New System.Windows.Forms.TextBox()
        Me.lblHeaterPower = New System.Windows.Forms.Label()
        Me.txbOvenTemperature = New System.Windows.Forms.TextBox()
        Me.lblOvenTemperature = New System.Windows.Forms.Label()
        Me.txbTemperatureSetpoint = New System.Windows.Forms.TextBox()
        Me.lblTemperatureSetpoint = New System.Windows.Forms.Label()
        Me.txbNewTemperatureSetpoint = New System.Windows.Forms.TextBox()
        Me.lblNewTemperatureSetPoint = New System.Windows.Forms.Label()
        Me.btnSetTemperatureSetpoint = New System.Windows.Forms.Button()
        Me.txbHeaterTemperature = New System.Windows.Forms.TextBox()
        Me.lblHeaterTemperature = New System.Windows.Forms.Label()
        Me.txbFanSpeed = New System.Windows.Forms.TextBox()
        Me.lblFanSpeed = New System.Windows.Forms.Label()
        Me.txbExceptions = New System.Windows.Forms.TextBox()
        Me.lblExceptions = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.nudUpdateRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' easyDAClient1
        ' 
        ' 
        ' lblUpdateRate
        ' 
        Me.lblUpdateRate.AutoSize = True
        Me.lblUpdateRate.Location = New System.Drawing.Point(31, 43)
        Me.lblUpdateRate.Name = "lblUpdateRate"
        Me.lblUpdateRate.Size = New System.Drawing.Size(80, 13)
        Me.lblUpdateRate.TabIndex = 6
        Me.lblUpdateRate.Text = "Update rate [s]:"
        Me.lblUpdateRate.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' nudUpdateRate
        ' 
        Me.nudUpdateRate.Location = New System.Drawing.Point(117, 41)
        Me.nudUpdateRate.Name = "nudUpdateRate"
        Me.nudUpdateRate.Size = New System.Drawing.Size(162, 20)
        Me.nudUpdateRate.TabIndex = 7
        Me.nudUpdateRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' btnStart
        ' 
        Me.btnStart.Location = New System.Drawing.Point(469, 38)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '			Me.btnStart.Click += New System.EventHandler(Me.btnStart_Click)
        ' 
        ' panel1
        ' 
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Location = New System.Drawing.Point(13, 75)
        Me.panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(612, 1)
        Me.panel1.TabIndex = 10
        ' 
        ' lblFanPower
        ' 
        Me.lblFanPower.AutoSize = True
        Me.lblFanPower.Location = New System.Drawing.Point(51, 93)
        Me.lblFanPower.Name = "lblFanPower"
        Me.lblFanPower.Size = New System.Drawing.Size(60, 13)
        Me.lblFanPower.TabIndex = 11
        Me.lblFanPower.Text = "Fan power:"
        Me.lblFanPower.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' txbFanPower
        ' 
        Me.txbFanPower.Location = New System.Drawing.Point(117, 90)
        Me.txbFanPower.Name = "txbFanPower"
        Me.txbFanPower.ReadOnly = True
        Me.txbFanPower.Size = New System.Drawing.Size(88, 20)
        Me.txbFanPower.TabIndex = 12
        Me.txbFanPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' timer1
        ' 
        '			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
        ' 
        ' btnStop
        ' 
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(550, 38)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '			Me.btnStop.Click += New System.EventHandler(Me.btnStop_Click)
        ' 
        ' txbHeaterPower
        ' 
        Me.txbHeaterPower.Location = New System.Drawing.Point(117, 116)
        Me.txbHeaterPower.Name = "txbHeaterPower"
        Me.txbHeaterPower.ReadOnly = True
        Me.txbHeaterPower.Size = New System.Drawing.Size(88, 20)
        Me.txbHeaterPower.TabIndex = 14
        Me.txbHeaterPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' lblHeaterPower
        ' 
        Me.lblHeaterPower.AutoSize = True
        Me.lblHeaterPower.Location = New System.Drawing.Point(37, 119)
        Me.lblHeaterPower.Name = "lblHeaterPower"
        Me.lblHeaterPower.Size = New System.Drawing.Size(74, 13)
        Me.lblHeaterPower.TabIndex = 13
        Me.lblHeaterPower.Text = "Heater power:"
        Me.lblHeaterPower.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' txbOvenTemperature
        ' 
        Me.txbOvenTemperature.Location = New System.Drawing.Point(117, 142)
        Me.txbOvenTemperature.Name = "txbOvenTemperature"
        Me.txbOvenTemperature.ReadOnly = True
        Me.txbOvenTemperature.Size = New System.Drawing.Size(88, 20)
        Me.txbOvenTemperature.TabIndex = 16
        Me.txbOvenTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' lblOvenTemperature
        ' 
        Me.lblOvenTemperature.AutoSize = True
        Me.lblOvenTemperature.Location = New System.Drawing.Point(16, 145)
        Me.lblOvenTemperature.Name = "lblOvenTemperature"
        Me.lblOvenTemperature.Size = New System.Drawing.Size(95, 13)
        Me.lblOvenTemperature.TabIndex = 15
        Me.lblOvenTemperature.Text = "Oven temperature:"
        Me.lblOvenTemperature.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' txbTemperatureSetpoint
        ' 
        Me.txbTemperatureSetpoint.Location = New System.Drawing.Point(275, 142)
        Me.txbTemperatureSetpoint.Name = "txbTemperatureSetpoint"
        Me.txbTemperatureSetpoint.ReadOnly = True
        Me.txbTemperatureSetpoint.Size = New System.Drawing.Size(88, 20)
        Me.txbTemperatureSetpoint.TabIndex = 18
        Me.txbTemperatureSetpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' lblTemperatureSetpoint
        ' 
        Me.lblTemperatureSetpoint.AutoSize = True
        Me.lblTemperatureSetpoint.Location = New System.Drawing.Point(219, 145)
        Me.lblTemperatureSetpoint.Name = "lblTemperatureSetpoint"
        Me.lblTemperatureSetpoint.Size = New System.Drawing.Size(50, 13)
        Me.lblTemperatureSetpoint.TabIndex = 17
        Me.lblTemperatureSetpoint.Text = "SetPoint:"
        Me.lblTemperatureSetpoint.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' txbNewTemperatureSetpoint
        ' 
        Me.txbNewTemperatureSetpoint.Location = New System.Drawing.Point(456, 142)
        Me.txbNewTemperatureSetpoint.Name = "txbNewTemperatureSetpoint"
        Me.txbNewTemperatureSetpoint.Size = New System.Drawing.Size(88, 20)
        Me.txbNewTemperatureSetpoint.TabIndex = 20
        Me.txbNewTemperatureSetpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' lblNewTemperatureSetPoint
        ' 
        Me.lblNewTemperatureSetPoint.AutoSize = True
        Me.lblNewTemperatureSetPoint.Location = New System.Drawing.Point(378, 145)
        Me.lblNewTemperatureSetPoint.Name = "lblNewTemperatureSetPoint"
        Me.lblNewTemperatureSetPoint.Size = New System.Drawing.Size(72, 13)
        Me.lblNewTemperatureSetPoint.TabIndex = 19
        Me.lblNewTemperatureSetPoint.Text = "New setpoint:"
        Me.lblNewTemperatureSetPoint.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' btnSetTemperatureSetpoint
        ' 
        Me.btnSetTemperatureSetpoint.Location = New System.Drawing.Point(550, 142)
        Me.btnSetTemperatureSetpoint.Name = "btnSetTemperatureSetpoint"
        Me.btnSetTemperatureSetpoint.Size = New System.Drawing.Size(75, 23)
        Me.btnSetTemperatureSetpoint.TabIndex = 21
        Me.btnSetTemperatureSetpoint.Text = "Set"
        Me.btnSetTemperatureSetpoint.UseVisualStyleBackColor = True
        '			Me.btnSetTemperatureSetpoint.Click += New System.EventHandler(Me.btnSetTemperatureSetpoint_Click)
        ' 
        ' txbHeaterTemperature
        ' 
        Me.txbHeaterTemperature.Location = New System.Drawing.Point(117, 168)
        Me.txbHeaterTemperature.Name = "txbHeaterTemperature"
        Me.txbHeaterTemperature.ReadOnly = True
        Me.txbHeaterTemperature.Size = New System.Drawing.Size(88, 20)
        Me.txbHeaterTemperature.TabIndex = 23
        Me.txbHeaterTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' lblHeaterTemperature
        ' 
        Me.lblHeaterTemperature.AutoSize = True
        Me.lblHeaterTemperature.Location = New System.Drawing.Point(10, 171)
        Me.lblHeaterTemperature.Name = "lblHeaterTemperature"
        Me.lblHeaterTemperature.Size = New System.Drawing.Size(101, 13)
        Me.lblHeaterTemperature.TabIndex = 22
        Me.lblHeaterTemperature.Text = "Heater temperature:"
        Me.lblHeaterTemperature.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' txbFanSpeed
        ' 
        Me.txbFanSpeed.Location = New System.Drawing.Point(117, 194)
        Me.txbFanSpeed.Name = "txbFanSpeed"
        Me.txbFanSpeed.ReadOnly = True
        Me.txbFanSpeed.Size = New System.Drawing.Size(88, 20)
        Me.txbFanSpeed.TabIndex = 25
        Me.txbFanSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        ' 
        ' lblFanSpeed
        ' 
        Me.lblFanSpeed.AutoSize = True
        Me.lblFanSpeed.Location = New System.Drawing.Point(51, 197)
        Me.lblFanSpeed.Name = "lblFanSpeed"
        Me.lblFanSpeed.Size = New System.Drawing.Size(60, 13)
        Me.lblFanSpeed.TabIndex = 24
        Me.lblFanSpeed.Text = "Fan speed:"
        Me.lblFanSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight
        ' 
        ' txbExceptions
        ' 
        Me.txbExceptions.Location = New System.Drawing.Point(13, 240)
        Me.txbExceptions.Multiline = True
        Me.txbExceptions.Name = "txbExceptions"
        Me.txbExceptions.ReadOnly = True
        Me.txbExceptions.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txbExceptions.Size = New System.Drawing.Size(611, 81)
        Me.txbExceptions.TabIndex = 27
        Me.txbExceptions.WordWrap = False
        ' 
        ' lblExceptions
        ' 
        Me.lblExceptions.AutoSize = True
        Me.lblExceptions.Location = New System.Drawing.Point(13, 221)
        Me.lblExceptions.Name = "lblExceptions"
        Me.lblExceptions.Size = New System.Drawing.Size(62, 13)
        Me.lblExceptions.TabIndex = 26
        Me.lblExceptions.Text = "Exceptions:"
        ' 
        ' btnClose
        ' 
        Me.btnClose.Location = New System.Drawing.Point(550, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '			Me.btnClose.Click += New System.EventHandler(Me.btnClose_Click)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(345, 13)
        Me.label1.TabIndex = 30
        Me.label1.Text = "For application description, please see the Readme.txt file in the project."
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 329)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblExceptions)
        Me.Controls.Add(Me.txbExceptions)
        Me.Controls.Add(Me.txbFanSpeed)
        Me.Controls.Add(Me.lblFanSpeed)
        Me.Controls.Add(Me.txbHeaterTemperature)
        Me.Controls.Add(Me.lblHeaterTemperature)
        Me.Controls.Add(Me.btnSetTemperatureSetpoint)
        Me.Controls.Add(Me.txbNewTemperatureSetpoint)
        Me.Controls.Add(Me.lblNewTemperatureSetPoint)
        Me.Controls.Add(Me.txbTemperatureSetpoint)
        Me.Controls.Add(Me.lblTemperatureSetpoint)
        Me.Controls.Add(Me.txbOvenTemperature)
        Me.Controls.Add(Me.lblOvenTemperature)
        Me.Controls.Add(Me.txbHeaterPower)
        Me.Controls.Add(Me.lblHeaterPower)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.txbFanPower)
        Me.Controls.Add(Me.lblFanPower)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.nudUpdateRate)
        Me.Controls.Add(Me.lblUpdateRate)
        Me.Name = "Form1"
        Me.Text = "OPC Demo"
        '			Me.Load += New System.EventHandler(Me.Form1_Load)
        CType(Me.nudUpdateRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private easyDAClient1 As OpcLabs.EasyOpc.DataAccess.EasyDAClient
    Private lblUpdateRate As System.Windows.Forms.Label
    Private nudUpdateRate As System.Windows.Forms.NumericUpDown
    Private WithEvents btnStart As System.Windows.Forms.Button
    Private panel1 As System.Windows.Forms.Panel
    Private lblFanPower As System.Windows.Forms.Label
    Private txbFanPower As System.Windows.Forms.TextBox
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private WithEvents btnStop As System.Windows.Forms.Button
    Private txbHeaterPower As System.Windows.Forms.TextBox
    Private lblHeaterPower As System.Windows.Forms.Label
    Private txbOvenTemperature As System.Windows.Forms.TextBox
    Private lblOvenTemperature As System.Windows.Forms.Label
    Private txbTemperatureSetpoint As System.Windows.Forms.TextBox
    Private lblTemperatureSetpoint As System.Windows.Forms.Label
    Private txbNewTemperatureSetpoint As System.Windows.Forms.TextBox
    Private lblNewTemperatureSetPoint As System.Windows.Forms.Label
    Private WithEvents btnSetTemperatureSetpoint As System.Windows.Forms.Button
    Private txbHeaterTemperature As System.Windows.Forms.TextBox
    Private lblHeaterTemperature As System.Windows.Forms.Label
    Private txbFanSpeed As System.Windows.Forms.TextBox
    Private lblFanSpeed As System.Windows.Forms.Label
    Private txbExceptions As System.Windows.Forms.TextBox
    Private lblExceptions As System.Windows.Forms.Label
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
End Class