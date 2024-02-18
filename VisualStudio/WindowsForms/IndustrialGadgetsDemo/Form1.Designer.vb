Namespace IndustrialGadgetsDemo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim DaItemPoint11 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters11 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint12 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters12 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint13 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters13 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint14 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters14 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint15 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters15 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint16 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters16 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint17 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters17 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint18 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters18 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint19 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters19 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint20 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters20 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Me.netIllumButtonCtrl1 = New NetGadgetLib1.NetIllumButtonCtrl()
            Me.bindingExtender1 = New OpcLabs.BaseLib.LiveBinding.BindingExtender(Me.components)
            Me.netLEDDisplayCtrl1 = New NetGadgetLib2.NetLEDDisplayCtrl()
            Me.netSliderCtrl1 = New NetGadgetLib2.NetSliderCtrl()
            Me.netMeterCtrl1 = New NetGadgetLib2.NetMeterCtrl()
            Me.net3PosSwitchCtrl1 = New NetGadgetLib1.Net3PosSwitchCtrl()
            Me.netPanelCtrl1 = New NetGadgetLib1.NetPanelCtrl()
            Me.net2PosSwitchCtrl1 = New NetGadgetLib1.Net2PosSwitchCtrl()
            Me.netButtonCtrl1 = New NetGadgetLib1.NetButtonCtrl()
            Me.netLightCtrl1 = New NetGadgetLib1.NetLightCtrl()
            Me.netDisplayCtrl1 = New NetGadgetLib2.NetDisplayCtrl()
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.DaConnectivity1 = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAConnectivity(Me.components)
            Me.PointBinder1 = New OpcLabs.BaseLib.LiveBinding.PointBinder(Me.components)
            Me.PointBinding1 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding2 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding3 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding4 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding5 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding6 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding7 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding8 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding9 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding10 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            CType(Me.netIllumButtonCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingExtender1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.netLEDDisplayCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.netSliderCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.netMeterCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.net3PosSwitchCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.netPanelCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.net2PosSwitchCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.netButtonCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.netLightCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.netDisplayCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DaConnectivity1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'netIllumButtonCtrl1
            '
            Me.netIllumButtonCtrl1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.netIllumButtonCtrl1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.bindingExtender1.SetBindingBag(Me.netIllumButtonCtrl1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding1, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.netIllumButtonCtrl1.ButtonDown = False
            Me.netIllumButtonCtrl1.ControlHeight = CType(0, Long)
            Me.netIllumButtonCtrl1.ControlType = CType(1, Long)
            Me.netIllumButtonCtrl1.ControlWidth = CType(0, Long)
            Me.netIllumButtonCtrl1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
            Me.netIllumButtonCtrl1.GadgetID = CType(0, Long)
            Me.netIllumButtonCtrl1.LampMode = NetGadgetLib1.LampModeOptions.Independent
            Me.netIllumButtonCtrl1.Location = New System.Drawing.Point(13, 118)
            Me.netIllumButtonCtrl1.Name = "netIllumButtonCtrl1"
            Me.netIllumButtonCtrl1.Size = New System.Drawing.Size(120, 86)
            Me.netIllumButtonCtrl1.Stretch = False
            Me.netIllumButtonCtrl1.Style = CType(0, Long)
            Me.netIllumButtonCtrl1.TabIndex = 0
            Me.netIllumButtonCtrl1.Text1 = "Line 1"
            Me.netIllumButtonCtrl1.Text2 = "Line 2"
            Me.netIllumButtonCtrl1.Text3 = "Line 3"
            Me.netIllumButtonCtrl1.TextColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netIllumButtonCtrl1.TextLines = CType(3, Long)
            Me.netIllumButtonCtrl1.Value = False
            '
            'bindingExtender1
            '
            Me.bindingExtender1.OfflineEventSource.SourceComponent = Me
            Me.bindingExtender1.OfflineEventSource.SourcePath = "FormClosing"
            Me.bindingExtender1.OnlineEventSource.SourceComponent = Me
            Me.bindingExtender1.OnlineEventSource.SourcePath = "Shown"
            '
            'netLEDDisplayCtrl1
            '
            Me.netLEDDisplayCtrl1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.netLEDDisplayCtrl1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.bindingExtender1.SetBindingBag(Me.netLEDDisplayCtrl1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding2, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.netLEDDisplayCtrl1.ControlHeight = CType(0, Long)
            Me.netLEDDisplayCtrl1.ControlType = CType(2, Long)
            Me.netLEDDisplayCtrl1.ControlWidth = CType(0, Long)
            Me.netLEDDisplayCtrl1.Digits = CType(5, Long)
            Me.netLEDDisplayCtrl1.FrameGap = CType(4, Long)
            Me.netLEDDisplayCtrl1.GadgetID = CType(0, Long)
            Me.netLEDDisplayCtrl1.IntegerValue = CType(0, Long)
            Me.netLEDDisplayCtrl1.IntegerValueMax = CType(100, Long)
            Me.netLEDDisplayCtrl1.IntegerValueMin = CType(0, Long)
            Me.netLEDDisplayCtrl1.IsGrabbing = False
            Me.netLEDDisplayCtrl1.LeadingZeroes = CType(1, Long)
            Me.netLEDDisplayCtrl1.Location = New System.Drawing.Point(534, 276)
            Me.netLEDDisplayCtrl1.Name = "netLEDDisplayCtrl1"
            Me.netLEDDisplayCtrl1.Size = New System.Drawing.Size(137, 60)
            Me.netLEDDisplayCtrl1.Style = CType(0, Long)
            Me.netLEDDisplayCtrl1.TabIndex = 9
            Me.netLEDDisplayCtrl1.Text1 = "Line 1"
            Me.netLEDDisplayCtrl1.Text2 = "Line 2"
            Me.netLEDDisplayCtrl1.TextColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
            Me.netLEDDisplayCtrl1.TextLines = CType(0, Long)
            Me.netLEDDisplayCtrl1.UsePersistedBitmap = True
            Me.netLEDDisplayCtrl1.Value = 39.665460586547852R
            Me.netLEDDisplayCtrl1.ValueMax = 100.0R
            Me.netLEDDisplayCtrl1.ValueMin = 0.0R
            '
            'netSliderCtrl1
            '
            Me.netSliderCtrl1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.netSliderCtrl1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.bindingExtender1.SetBindingBag(Me.netSliderCtrl1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding3, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.netSliderCtrl1.ControlHeight = CType(0, Long)
            Me.netSliderCtrl1.ControlType = CType(3, Long)
            Me.netSliderCtrl1.ControlWidth = CType(0, Long)
            Me.netSliderCtrl1.DisabledText = "This Control Has Been Disabled For Operator Input"
            Me.netSliderCtrl1.GadgetID = CType(0, Long)
            Me.netSliderCtrl1.IntegerValue = CType(0, Long)
            Me.netSliderCtrl1.IntegerValueMax = CType(100, Long)
            Me.netSliderCtrl1.IntegerValueMin = CType(0, Long)
            Me.netSliderCtrl1.IsGrabbing = False
            Me.netSliderCtrl1.LabelColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netSliderCtrl1.LabelEvery = CType(2, Long)
            Me.netSliderCtrl1.LabelFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
            Me.netSliderCtrl1.Location = New System.Drawing.Point(14, 276)
            Me.netSliderCtrl1.Name = "netSliderCtrl1"
            Me.netSliderCtrl1.Size = New System.Drawing.Size(100, 280)
            Me.netSliderCtrl1.Style = CType(0, Long)
            Me.netSliderCtrl1.TabIndex = 6
            Me.netSliderCtrl1.TickColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netSliderCtrl1.TicksMajor = CType(10, Long)
            Me.netSliderCtrl1.TicksMinor = CType(5, Long)
            Me.netSliderCtrl1.TitleColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netSliderCtrl1.TitleFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
            Me.netSliderCtrl1.UsePersistedBitmap = False
            Me.netSliderCtrl1.Value = 39.665460586547852R
            Me.netSliderCtrl1.ValueColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netSliderCtrl1.ValueFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
            Me.netSliderCtrl1.ValueMax = 100.0R
            Me.netSliderCtrl1.ValueMin = 0.0R
            '
            'netMeterCtrl1
            '
            Me.netMeterCtrl1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.netMeterCtrl1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.bindingExtender1.SetBindingBag(Me.netMeterCtrl1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding4, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.netMeterCtrl1.ControlHeight = CType(0, Long)
            Me.netMeterCtrl1.ControlType = CType(0, Long)
            Me.netMeterCtrl1.ControlWidth = CType(0, Long)
            Me.netMeterCtrl1.GadgetID = CType(0, Long)
            Me.netMeterCtrl1.IntegerValue = CType(0, Long)
            Me.netMeterCtrl1.IntegerValueMax = CType(100, Long)
            Me.netMeterCtrl1.IntegerValueMin = CType(0, Long)
            Me.netMeterCtrl1.IsGrabbing = False
            Me.netMeterCtrl1.LabelColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netMeterCtrl1.LabelEvery = CType(2, Long)
            Me.netMeterCtrl1.LabelFont = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
            Me.netMeterCtrl1.LabelPosition = CType(100, Long)
            Me.netMeterCtrl1.Location = New System.Drawing.Point(328, 276)
            Me.netMeterCtrl1.Name = "netMeterCtrl1"
            Me.netMeterCtrl1.NeedleColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
            Me.netMeterCtrl1.NeedleWidth = CType(2, Long)
            Me.netMeterCtrl1.Size = New System.Drawing.Size(200, 200)
            Me.netMeterCtrl1.SmoothTicks = True
            Me.netMeterCtrl1.TabIndex = 8
            Me.netMeterCtrl1.TickColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netMeterCtrl1.TicksMajor = CType(10, Long)
            Me.netMeterCtrl1.TicksMinor = CType(5, Long)
            Me.netMeterCtrl1.TitleColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netMeterCtrl1.TitleFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
            Me.netMeterCtrl1.UsePersistedBitmap = True
            Me.netMeterCtrl1.Value = 39.665460586547852R
            Me.netMeterCtrl1.ValueColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netMeterCtrl1.ValueFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
            Me.netMeterCtrl1.ValueMax = 100.0R
            Me.netMeterCtrl1.ValueMin = 0.0R
            '
            'net3PosSwitchCtrl1
            '
            Me.net3PosSwitchCtrl1.AutoOn = False
            Me.net3PosSwitchCtrl1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.net3PosSwitchCtrl1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.bindingExtender1.SetBindingBag(Me.net3PosSwitchCtrl1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding5, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.net3PosSwitchCtrl1.ControlHeight = CType(0, Long)
            Me.net3PosSwitchCtrl1.ControlType = CType(4, Long)
            Me.net3PosSwitchCtrl1.ControlWidth = CType(0, Long)
            Me.net3PosSwitchCtrl1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
            Me.net3PosSwitchCtrl1.GadgetID = CType(0, Long)
            Me.net3PosSwitchCtrl1.HandOn = False
            Me.net3PosSwitchCtrl1.Location = New System.Drawing.Point(140, 118)
            Me.net3PosSwitchCtrl1.Name = "net3PosSwitchCtrl1"
            Me.net3PosSwitchCtrl1.Size = New System.Drawing.Size(120, 140)
            Me.net3PosSwitchCtrl1.Stretch = False
            Me.net3PosSwitchCtrl1.Style = CType(0, Long)
            Me.net3PosSwitchCtrl1.TabIndex = 1
            Me.net3PosSwitchCtrl1.Text1 = "OFF"
            Me.net3PosSwitchCtrl1.Text2 = "HAND   AUTO"
            Me.net3PosSwitchCtrl1.Text3 = "Line 3"
            Me.net3PosSwitchCtrl1.TextColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.net3PosSwitchCtrl1.TextLines = CType(2, Long)
            '
            'netPanelCtrl1
            '
            Me.netPanelCtrl1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.netPanelCtrl1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.bindingExtender1.SetBindingBag(Me.netPanelCtrl1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding6, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.netPanelCtrl1.ControlHeight = CType(0, Long)
            Me.netPanelCtrl1.ControlType = CType(5, Long)
            Me.netPanelCtrl1.ControlWidth = CType(0, Long)
            Me.netPanelCtrl1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
            Me.netPanelCtrl1.GadgetID = CType(0, Long)
            Me.netPanelCtrl1.Location = New System.Drawing.Point(267, 118)
            Me.netPanelCtrl1.Name = "netPanelCtrl1"
            Me.netPanelCtrl1.Size = New System.Drawing.Size(140, 60)
            Me.netPanelCtrl1.Stretch = True
            Me.netPanelCtrl1.Style = CType(0, Long)
            Me.netPanelCtrl1.TabIndex = 2
            Me.netPanelCtrl1.Text1 = "Tuesday"
            Me.netPanelCtrl1.Text2 = "Line 2"
            Me.netPanelCtrl1.Text3 = "Line 3"
            Me.netPanelCtrl1.TextColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netPanelCtrl1.TextLines = CType(2, Long)
            '
            'net2PosSwitchCtrl1
            '
            Me.net2PosSwitchCtrl1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.net2PosSwitchCtrl1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.bindingExtender1.SetBindingBag(Me.net2PosSwitchCtrl1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding7, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.net2PosSwitchCtrl1.ControlHeight = CType(0, Long)
            Me.net2PosSwitchCtrl1.ControlType = CType(3, Long)
            Me.net2PosSwitchCtrl1.ControlWidth = CType(0, Long)
            Me.net2PosSwitchCtrl1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
            Me.net2PosSwitchCtrl1.GadgetID = CType(0, Long)
            Me.net2PosSwitchCtrl1.Location = New System.Drawing.Point(414, 118)
            Me.net2PosSwitchCtrl1.Name = "net2PosSwitchCtrl1"
            Me.net2PosSwitchCtrl1.Size = New System.Drawing.Size(32, 64)
            Me.net2PosSwitchCtrl1.Stretch = False
            Me.net2PosSwitchCtrl1.Style = CType(0, Long)
            Me.net2PosSwitchCtrl1.SwitchOn = False
            Me.net2PosSwitchCtrl1.TabIndex = 3
            Me.net2PosSwitchCtrl1.Text1 = "ON"
            Me.net2PosSwitchCtrl1.Text2 = "OFF"
            Me.net2PosSwitchCtrl1.Text3 = ""
            Me.net2PosSwitchCtrl1.Text4 = ""
            Me.net2PosSwitchCtrl1.TextColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
            Me.net2PosSwitchCtrl1.TextLines = CType(2, Long)
            '
            'netButtonCtrl1
            '
            Me.netButtonCtrl1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.netButtonCtrl1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.bindingExtender1.SetBindingBag(Me.netButtonCtrl1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding8, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.netButtonCtrl1.ButtonDown = False
            Me.netButtonCtrl1.ControlHeight = CType(0, Long)
            Me.netButtonCtrl1.ControlType = CType(0, Long)
            Me.netButtonCtrl1.ControlWidth = CType(0, Long)
            Me.netButtonCtrl1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
            Me.netButtonCtrl1.GadgetID = CType(0, Long)
            Me.netButtonCtrl1.Location = New System.Drawing.Point(453, 118)
            Me.netButtonCtrl1.Name = "netButtonCtrl1"
            Me.netButtonCtrl1.Size = New System.Drawing.Size(120, 140)
            Me.netButtonCtrl1.Stretch = False
            Me.netButtonCtrl1.Style = CType(0, Long)
            Me.netButtonCtrl1.TabIndex = 4
            Me.netButtonCtrl1.Text1 = "Line 1"
            Me.netButtonCtrl1.Text2 = "Line 2"
            Me.netButtonCtrl1.Text3 = "Line 3"
            Me.netButtonCtrl1.TextColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netButtonCtrl1.TextLines = CType(3, Long)
            Me.netButtonCtrl1.Value = False
            '
            'netLightCtrl1
            '
            Me.netLightCtrl1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.netLightCtrl1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.bindingExtender1.SetBindingBag(Me.netLightCtrl1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding9, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.netLightCtrl1.ControlHeight = CType(0, Long)
            Me.netLightCtrl1.ControlType = CType(2, Long)
            Me.netLightCtrl1.ControlWidth = CType(0, Long)
            Me.netLightCtrl1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
            Me.netLightCtrl1.GadgetID = CType(0, Long)
            Me.netLightCtrl1.Location = New System.Drawing.Point(580, 118)
            Me.netLightCtrl1.Name = "netLightCtrl1"
            Me.netLightCtrl1.Size = New System.Drawing.Size(120, 140)
            Me.netLightCtrl1.Stretch = False
            Me.netLightCtrl1.TabIndex = 5
            Me.netLightCtrl1.Text1 = "Line 1"
            Me.netLightCtrl1.Text2 = "Line 2"
            Me.netLightCtrl1.Text3 = "Line 3"
            Me.netLightCtrl1.Text4 = ""
            Me.netLightCtrl1.Text5 = ""
            Me.netLightCtrl1.TextColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.netLightCtrl1.TextLines = CType(3, Long)
            '
            'netDisplayCtrl1
            '
            Me.netDisplayCtrl1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.netDisplayCtrl1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.bindingExtender1.SetBindingBag(Me.netDisplayCtrl1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding10, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.netDisplayCtrl1.ControlHeight = CType(0, Long)
            Me.netDisplayCtrl1.ControlType = CType(1, Long)
            Me.netDisplayCtrl1.ControlWidth = CType(0, Long)
            Me.netDisplayCtrl1.FaceColor = System.Drawing.Color.Black
            Me.netDisplayCtrl1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
            Me.netDisplayCtrl1.GadgetID = CType(0, Long)
            Me.netDisplayCtrl1.IsGrabbing = False
            Me.netDisplayCtrl1.Location = New System.Drawing.Point(122, 276)
            Me.netDisplayCtrl1.Name = "netDisplayCtrl1"
            Me.netDisplayCtrl1.Size = New System.Drawing.Size(200, 86)
            Me.netDisplayCtrl1.Stretch = True
            Me.netDisplayCtrl1.TabIndex = 7
            Me.netDisplayCtrl1.Text1 = "Tuesday"
            Me.netDisplayCtrl1.Text2 = "Line 2"
            Me.netDisplayCtrl1.Text3 = "Line 3"
            Me.netDisplayCtrl1.Text4 = "Line 4"
            Me.netDisplayCtrl1.Text5 = "Line 5"
            Me.netDisplayCtrl1.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(17, Byte), Integer))
            Me.netDisplayCtrl1.TextLines = CType(2, Long)
            '
            'richTextBox1
            '
            Me.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.richTextBox1.Location = New System.Drawing.Point(12, 12)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(692, 90)
            Me.richTextBox1.TabIndex = 49
            Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
            '
            'PointBinder1
            '
            Me.PointBinder1.BindingExtender = Me.bindingExtender1
            Me.PointBinder1.Connectivity = Me.DaConnectivity1
            '
            'PointBinding1
            '
            Me.PointBinding1.ArgumentsPath = "Value"
            DaItemPoint11.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint11.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding1.Point = DaItemPoint11
            DaItemPointSubscribeParameters11.RequestedUpdateRate = 100
            Me.PointBinding1.SubscribeParameters = DaItemPointSubscribeParameters11
            Me.PointBinding1.ValueTarget.TargetComponent = Me.netIllumButtonCtrl1
            Me.PointBinding1.ValueTarget.TargetPath = "LampOn"
            '
            'PointBinding2
            '
            Me.PointBinding2.ArgumentsPath = "Value"
            DaItemPoint12.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint12.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding2.Point = DaItemPoint12
            DaItemPointSubscribeParameters12.RequestedUpdateRate = 100
            Me.PointBinding2.SubscribeParameters = DaItemPointSubscribeParameters12
            Me.PointBinding2.ValueTarget.TargetComponent = Me.netLEDDisplayCtrl1
            Me.PointBinding2.ValueTarget.TargetPath = "Value"
            '
            'PointBinding3
            '
            Me.PointBinding3.ArgumentsPath = "Value"
            DaItemPoint13.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint13.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding3.Point = DaItemPoint13
            DaItemPointSubscribeParameters13.RequestedUpdateRate = 100
            Me.PointBinding3.SubscribeParameters = DaItemPointSubscribeParameters13
            Me.PointBinding3.ValueTarget.TargetComponent = Me.netSliderCtrl1
            Me.PointBinding3.ValueTarget.TargetPath = "Value"
            '
            'PointBinding4
            '
            Me.PointBinding4.ArgumentsPath = "Value"
            DaItemPoint14.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint14.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding4.Point = DaItemPoint14
            DaItemPointSubscribeParameters14.RequestedUpdateRate = 100
            Me.PointBinding4.SubscribeParameters = DaItemPointSubscribeParameters14
            Me.PointBinding4.ValueTarget.TargetComponent = Me.netMeterCtrl1
            Me.PointBinding4.ValueTarget.TargetPath = "Value"
            '
            'PointBinding5
            '
            Me.PointBinding5.ArgumentsPath = "Value"
            DaItemPoint15.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint15.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding5.Point = DaItemPoint15
            DaItemPointSubscribeParameters15.RequestedUpdateRate = 100
            Me.PointBinding5.SubscribeParameters = DaItemPointSubscribeParameters15
            Me.PointBinding5.ValueTarget.TargetComponent = Me.net3PosSwitchCtrl1
            Me.PointBinding5.ValueTarget.TargetPath = "HandOn"
            '
            'PointBinding6
            '
            Me.PointBinding6.ArgumentsPath = "Value"
            DaItemPoint16.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Weekdays (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Weekdays (10 s)"}))
            DaItemPoint16.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding6.Point = DaItemPoint16
            DaItemPointSubscribeParameters16.RequestedUpdateRate = 100
            Me.PointBinding6.SubscribeParameters = DaItemPointSubscribeParameters16
            Me.PointBinding6.ValueTarget.TargetComponent = Me.netPanelCtrl1
            Me.PointBinding6.ValueTarget.TargetPath = "Text1"
            '
            'PointBinding7
            '
            Me.PointBinding7.ArgumentsPath = "Value"
            DaItemPoint17.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint17.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding7.Point = DaItemPoint17
            DaItemPointSubscribeParameters17.RequestedUpdateRate = 100
            Me.PointBinding7.SubscribeParameters = DaItemPointSubscribeParameters17
            Me.PointBinding7.ValueTarget.TargetComponent = Me.net2PosSwitchCtrl1
            Me.PointBinding7.ValueTarget.TargetPath = "SwitchOn"
            '
            'PointBinding8
            '
            Me.PointBinding8.ArgumentsPath = "Value"
            DaItemPoint18.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint18.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding8.Point = DaItemPoint18
            DaItemPointSubscribeParameters18.RequestedUpdateRate = 100
            Me.PointBinding8.SubscribeParameters = DaItemPointSubscribeParameters18
            Me.PointBinding8.ValueTarget.TargetComponent = Me.netButtonCtrl1
            Me.PointBinding8.ValueTarget.TargetPath = "ButtonDown"
            '
            'PointBinding9
            '
            Me.PointBinding9.ArgumentsPath = "Value"
            DaItemPoint19.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint19.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding9.Point = DaItemPoint19
            DaItemPointSubscribeParameters19.RequestedUpdateRate = 100
            Me.PointBinding9.SubscribeParameters = DaItemPointSubscribeParameters19
            Me.PointBinding9.ValueTarget.TargetComponent = Me.netLightCtrl1
            Me.PointBinding9.ValueTarget.TargetPath = "LampOn"
            '
            'PointBinding10
            '
            Me.PointBinding10.ArgumentsPath = "Value"
            DaItemPoint20.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Weekdays (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Weekdays (10 s)"}))
            DaItemPoint20.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding10.Point = DaItemPoint20
            DaItemPointSubscribeParameters20.RequestedUpdateRate = 100
            Me.PointBinding10.SubscribeParameters = DaItemPointSubscribeParameters20
            Me.PointBinding10.ValueTarget.TargetComponent = Me.netDisplayCtrl1
            Me.PointBinding10.ValueTarget.TargetPath = "Text1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(715, 571)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.netLEDDisplayCtrl1)
            Me.Controls.Add(Me.netMeterCtrl1)
            Me.Controls.Add(Me.netDisplayCtrl1)
            Me.Controls.Add(Me.netSliderCtrl1)
            Me.Controls.Add(Me.netLightCtrl1)
            Me.Controls.Add(Me.netButtonCtrl1)
            Me.Controls.Add(Me.net2PosSwitchCtrl1)
            Me.Controls.Add(Me.netPanelCtrl1)
            Me.Controls.Add(Me.net3PosSwitchCtrl1)
            Me.Controls.Add(Me.netIllumButtonCtrl1)
            Me.Name = "Form1"
            Me.Text = "Demo with Industrial Gadgets .NET"
            CType(Me.netIllumButtonCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingExtender1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.netLEDDisplayCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.netSliderCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.netMeterCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.net3PosSwitchCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.netPanelCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.net2PosSwitchCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.netButtonCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.netLightCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.netDisplayCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DaConnectivity1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private netIllumButtonCtrl1 As NetGadgetLib1.NetIllumButtonCtrl
        Private bindingExtender1 As OpcLabs.BaseLib.LiveBinding.BindingExtender
		Private netLEDDisplayCtrl1 As NetGadgetLib2.NetLEDDisplayCtrl
		Private netMeterCtrl1 As NetGadgetLib2.NetMeterCtrl
		Private netDisplayCtrl1 As NetGadgetLib2.NetDisplayCtrl
		Private netSliderCtrl1 As NetGadgetLib2.NetSliderCtrl
		Private netLightCtrl1 As NetGadgetLib1.NetLightCtrl
		Private netButtonCtrl1 As NetGadgetLib1.NetButtonCtrl
		Private net2PosSwitchCtrl1 As NetGadgetLib1.Net2PosSwitchCtrl
		Private netPanelCtrl1 As NetGadgetLib1.NetPanelCtrl
		Private net3PosSwitchCtrl1 As NetGadgetLib1.Net3PosSwitchCtrl
        Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
        Friend WithEvents DaConnectivity1 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAConnectivity
        Friend WithEvents PointBinder1 As OpcLabs.BaseLib.LiveBinding.PointBinder
        Friend WithEvents PointBinding2 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding4 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding10 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding3 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding9 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding8 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding7 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding6 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding5 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding1 As OpcLabs.BaseLib.LiveBinding.PointBinding
	End Class
End Namespace

