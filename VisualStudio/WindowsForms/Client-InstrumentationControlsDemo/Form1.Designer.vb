Imports JetBrains.Annotations

Namespace InstrumentationControlsDemo
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
            Dim ColorSection13 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim ColorSection14 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim ColorSection15 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim PointerGaugeAngular2 As Iocomp.Classes.PointerGaugeAngular = New Iocomp.Classes.PointerGaugeAngular()
            Dim ColorSection16 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim ColorSection17 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim ColorSection18 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim ColorSection19 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim ColorSection20 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim ColorSection21 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim PointerGaugeLinear2 As Iocomp.Classes.PointerGaugeLinear = New Iocomp.Classes.PointerGaugeLinear()
            Dim ColorSection22 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim ColorSection23 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim ColorSection24 As Iocomp.Classes.ColorSection = New Iocomp.Classes.ColorSection()
            Dim PointerSlidingScale3 As Iocomp.Classes.PointerSlidingScale = New Iocomp.Classes.PointerSlidingScale()
            Dim PointerSlidingScale4 As Iocomp.Classes.PointerSlidingScale = New Iocomp.Classes.PointerSlidingScale()
            Dim PointerCompass2 As Iocomp.Classes.PointerCompass = New Iocomp.Classes.PointerCompass()
            Dim CompassTick9 As Iocomp.Classes.CompassTick = New Iocomp.Classes.CompassTick()
            Dim CompassTick10 As Iocomp.Classes.CompassTick = New Iocomp.Classes.CompassTick()
            Dim CompassTick11 As Iocomp.Classes.CompassTick = New Iocomp.Classes.CompassTick()
            Dim CompassTick12 As Iocomp.Classes.CompassTick = New Iocomp.Classes.CompassTick()
            Dim CompassTick13 As Iocomp.Classes.CompassTick = New Iocomp.Classes.CompassTick()
            Dim CompassTick14 As Iocomp.Classes.CompassTick = New Iocomp.Classes.CompassTick()
            Dim CompassTick15 As Iocomp.Classes.CompassTick = New Iocomp.Classes.CompassTick()
            Dim CompassTick16 As Iocomp.Classes.CompassTick = New Iocomp.Classes.CompassTick()
            Dim ScaleDiscreetItem7 As Iocomp.Classes.ScaleDiscreetItem = New Iocomp.Classes.ScaleDiscreetItem()
            Dim ScaleDiscreetItem8 As Iocomp.Classes.ScaleDiscreetItem = New Iocomp.Classes.ScaleDiscreetItem()
            Dim ScaleDiscreetItem9 As Iocomp.Classes.ScaleDiscreetItem = New Iocomp.Classes.ScaleDiscreetItem()
            Dim ModeComboBoxItem4 As Iocomp.Classes.ModeComboBoxItem = New Iocomp.Classes.ModeComboBoxItem()
            Dim ModeComboBoxItem5 As Iocomp.Classes.ModeComboBoxItem = New Iocomp.Classes.ModeComboBoxItem()
            Dim ModeComboBoxItem6 As Iocomp.Classes.ModeComboBoxItem = New Iocomp.Classes.ModeComboBoxItem()
            Dim ScaleDiscreetItem10 As Iocomp.Classes.ScaleDiscreetItem = New Iocomp.Classes.ScaleDiscreetItem()
            Dim ScaleDiscreetItem11 As Iocomp.Classes.ScaleDiscreetItem = New Iocomp.Classes.ScaleDiscreetItem()
            Dim ScaleDiscreetItem12 As Iocomp.Classes.ScaleDiscreetItem = New Iocomp.Classes.ScaleDiscreetItem()
            Dim PlotChannelTrace4 As Iocomp.Classes.PlotChannelTrace = New Iocomp.Classes.PlotChannelTrace()
            Dim PlotChannelTrace5 As Iocomp.Classes.PlotChannelTrace = New Iocomp.Classes.PlotChannelTrace()
            Dim PlotChannelTrace6 As Iocomp.Classes.PlotChannelTrace = New Iocomp.Classes.PlotChannelTrace()
            Dim PlotDataCursorXY2 As Iocomp.Classes.PlotDataCursorXY = New Iocomp.Classes.PlotDataCursorXY()
            Dim PlotDataView2 As Iocomp.Classes.PlotDataView = New Iocomp.Classes.PlotDataView()
            Dim PlotLabelBasic2 As Iocomp.Classes.PlotLabelBasic = New Iocomp.Classes.PlotLabelBasic()
            Dim PlotLegendBasic2 As Iocomp.Classes.PlotLegendBasic = New Iocomp.Classes.PlotLegendBasic()
            Dim PlotXAxis2 As Iocomp.Classes.PlotXAxis = New Iocomp.Classes.PlotXAxis()
            Dim PlotYAxis2 As Iocomp.Classes.PlotYAxis = New Iocomp.Classes.PlotYAxis()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim DaItemPoint38 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters37 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint48 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters47 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint49 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters48 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint39 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters38 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint50 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters49 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint51 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters50 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint52 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters51 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint53 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters52 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint40 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters39 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint54 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters53 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint55 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters54 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint56 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters55 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint57 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters56 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint58 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters57 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint59 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters58 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint60 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters59 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint61 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters60 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint62 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters61 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint63 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters62 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint41 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters40 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint64 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters63 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint65 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters64 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint66 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters65 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint42 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters41 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint67 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters66 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint68 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters67 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint69 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters68 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint70 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters69 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint71 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters70 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint72 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters71 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint43 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters42 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint44 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters43 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint45 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters44 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint46 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters45 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint47 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters46 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint73 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters72 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint74 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Me.bindingExtender1 = New OpcLabs.BaseLib.LiveBinding.BindingExtender(Me.components)
            Me.gaugeAngular1 = New Iocomp.Instrumentation.Standard.GaugeAngular()
            Me.displayString1 = New Iocomp.Instrumentation.Standard.DisplayString()
            Me.editDouble1 = New Iocomp.Instrumentation.Standard.EditDouble()
            Me.ledSpiral1 = New Iocomp.Instrumentation.Standard.LedSpiral()
            Me.displayDouble1 = New Iocomp.Instrumentation.Standard.DisplayDouble()
            Me.displayInteger1 = New Iocomp.Instrumentation.Standard.DisplayInteger()
            Me.sevenSegmentAnalog1 = New Iocomp.Instrumentation.Standard.SevenSegmentAnalog()
            Me.switchLed1 = New Iocomp.Instrumentation.Standard.SwitchLed()
            Me.gaugeLinear1 = New Iocomp.Instrumentation.Standard.GaugeLinear()
            Me.sevenSegmentInteger1 = New Iocomp.Instrumentation.Standard.SevenSegmentInteger()
            Me.odometer1 = New Iocomp.Instrumentation.Standard.Odometer()
            Me.slider1 = New Iocomp.Instrumentation.Standard.Slider()
            Me.thermometer1 = New Iocomp.Instrumentation.Standard.Thermometer()
            Me.led1 = New Iocomp.Instrumentation.Standard.Led()
            Me.sevenSegmentClock1 = New Iocomp.Instrumentation.Standard.SevenSegmentClock()
            Me.switchToggle1 = New Iocomp.Instrumentation.Standard.SwitchToggle()
            Me.editInteger1 = New Iocomp.Instrumentation.Standard.EditInteger()
            Me.sevenSegmentHexadecimal1 = New Iocomp.Instrumentation.Standard.SevenSegmentHexadecimal()
            Me.editString1 = New Iocomp.Instrumentation.Standard.EditString()
            Me.ledBar1 = New Iocomp.Instrumentation.Standard.LedBar()
            Me.ledArrow1 = New Iocomp.Instrumentation.Professional.LedArrow()
            Me.lcdMatrix1 = New Iocomp.Instrumentation.Professional.LcdMatrix()
            Me.tank1 = New Iocomp.Instrumentation.Professional.Tank()
            Me.slidingScale1 = New Iocomp.Instrumentation.Professional.SlidingScale()
            Me.valve1 = New Iocomp.Instrumentation.Professional.Valve()
            Me.switchRocker1 = New Iocomp.Instrumentation.Professional.SwitchRocker()
            Me.gaugeTube1 = New Iocomp.Instrumentation.Professional.GaugeTube()
            Me.switchLever1 = New Iocomp.Instrumentation.Professional.SwitchLever()
            Me.clockAnalog1 = New Iocomp.Instrumentation.Professional.ClockAnalog()
            Me.sevenSegmentClockSmpte1 = New Iocomp.Instrumentation.Professional.SevenSegmentClockSmpte()
            Me.slidingCompass1 = New Iocomp.Instrumentation.Professional.SlidingCompass()
            Me.compass1 = New Iocomp.Instrumentation.Professional.Compass()
            Me.switchRotary1 = New Iocomp.Instrumentation.Standard.SwitchRotary()
            Me.modeComboBox1 = New Iocomp.Instrumentation.Standard.ModeComboBox()
            Me.switchSlider1 = New Iocomp.Instrumentation.Standard.SwitchSlider()
            Me.switchPanel1 = New Iocomp.Instrumentation.Standard.SwitchPanel()
            Me.slider2 = New Iocomp.Instrumentation.Standard.Slider()
            Me.tabControl1 = New System.Windows.Forms.TabControl()
            Me.tabPage1 = New System.Windows.Forms.TabPage()
            Me.tabPage2 = New System.Windows.Forms.TabPage()
            Me.tabPage3 = New System.Windows.Forms.TabPage()
            Me.label1 = New System.Windows.Forms.Label()
            Me.plotToolBarStandard1 = New Iocomp.Instrumentation.Plotting.PlotToolBarStandard()
            Me.plotToolBarButton1 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton2 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton3 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton4 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton5 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton6 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton7 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton8 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton9 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton10 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton11 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton12 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton13 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton14 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton15 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton16 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton17 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton18 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton19 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton20 = New Iocomp.Classes.PlotToolBarButton()
            Me.plotToolBarButton21 = New Iocomp.Classes.PlotToolBarButton()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.plot1 = New Iocomp.Instrumentation.Plotting.Plot()
            Me.easyDAClient1 = New OpcLabs.EasyOpc.DataAccess.EasyDAClient(Me.components)
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
            Me.PointBinding11 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding12 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding13 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding14 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding15 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding16 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding17 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding18 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding19 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding20 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding21 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding22 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding23 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding24 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding25 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding26 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding27 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding28 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding29 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding30 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding31 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding32 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding33 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding34 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding35 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding36 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding37 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            CType(Me.bindingExtender1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControl1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            Me.tabPage2.SuspendLayout()
            Me.tabPage3.SuspendLayout()
            CType(Me.DaConnectivity1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'bindingExtender1
            '
            Me.bindingExtender1.OfflineEventSource.SourceComponent = Me
            Me.bindingExtender1.OfflineEventSource.SourcePath = "FormClosing"
            Me.bindingExtender1.OnlineEventSource.SourceComponent = Me
            Me.bindingExtender1.OnlineEventSource.SourcePath = "Shown"
            '
            'gaugeAngular1
            '
            Me.gaugeAngular1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.gaugeAngular1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding1, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            ColorSection13.Color = System.Drawing.Color.Lime
            ColorSection14.Color = System.Drawing.Color.Yellow
            ColorSection14.Start = 50.0R
            ColorSection14.Stop = 75.0R
            ColorSection15.Start = 75.0R
            ColorSection15.Stop = 100.0R
            Me.gaugeAngular1.ColorSections.Add(ColorSection13)
            Me.gaugeAngular1.ColorSections.Add(ColorSection14)
            Me.gaugeAngular1.ColorSections.Add(ColorSection15)
            Me.gaugeAngular1.InnerRadius = 70
            Me.gaugeAngular1.Location = New System.Drawing.Point(604, 7)
            Me.gaugeAngular1.Name = "gaugeAngular1"
            PointerGaugeAngular2.Value.AsDouble = 6.3111782073974609R
            Me.gaugeAngular1.Pointers.Add(PointerGaugeAngular2)
            Me.gaugeAngular1.Size = New System.Drawing.Size(128, 128)
            Me.gaugeAngular1.LoadingEnd()
            '
            'displayString1
            '
            Me.displayString1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.displayString1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding2, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.displayString1.Location = New System.Drawing.Point(220, 282)
            Me.displayString1.Name = "displayString1"
            Me.displayString1.Size = New System.Drawing.Size(100, 22)
            Me.displayString1.Value.AsString = "Sunday"
            Me.displayString1.LoadingEnd()
            '
            'editDouble1
            '
            Me.editDouble1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.editDouble1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding3, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.editDouble1.Location = New System.Drawing.Point(337, 110)
            Me.editDouble1.Name = "editDouble1"
            Me.editDouble1.Size = New System.Drawing.Size(100, 20)
            Me.editDouble1.TabIndex = 24
            Me.editDouble1.Value.AsDouble = 6.3111782073974609R
            Me.editDouble1.LoadingEnd()
            '
            'ledSpiral1
            '
            Me.ledSpiral1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.ledSpiral1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding4, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            ColorSection16.Color = System.Drawing.Color.Lime
            ColorSection17.Color = System.Drawing.Color.Yellow
            ColorSection17.Start = 50.0R
            ColorSection17.Stop = 75.0R
            ColorSection18.Start = 75.0R
            ColorSection18.Stop = 100.0R
            Me.ledSpiral1.ColorSections.Add(ColorSection16)
            Me.ledSpiral1.ColorSections.Add(ColorSection17)
            Me.ledSpiral1.ColorSections.Add(ColorSection18)
            Me.ledSpiral1.InnerRadius = 23
            Me.ledSpiral1.Location = New System.Drawing.Point(447, 225)
            Me.ledSpiral1.Name = "ledSpiral1"
            Me.ledSpiral1.Size = New System.Drawing.Size(78, 78)
            Me.ledSpiral1.Value.AsDouble = 6.3111782073974609R
            Me.ledSpiral1.LoadingEnd()
            '
            'displayDouble1
            '
            Me.displayDouble1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.displayDouble1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding5, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.displayDouble1.Location = New System.Drawing.Point(220, 253)
            Me.displayDouble1.Name = "displayDouble1"
            Me.displayDouble1.Size = New System.Drawing.Size(100, 22)
            Me.displayDouble1.Value.AsDouble = 6.3111782073974609R
            Me.displayDouble1.LoadingEnd()
            '
            'displayInteger1
            '
            Me.displayInteger1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.displayInteger1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding6, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.displayInteger1.Location = New System.Drawing.Point(220, 225)
            Me.displayInteger1.Name = "displayInteger1"
            Me.displayInteger1.Size = New System.Drawing.Size(100, 22)
            Me.displayInteger1.Value.AsString = "29"
            Me.displayInteger1.LoadingEnd()
            '
            'sevenSegmentAnalog1
            '
            Me.sevenSegmentAnalog1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.sevenSegmentAnalog1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding7, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.sevenSegmentAnalog1.Location = New System.Drawing.Point(464, 119)
            Me.sevenSegmentAnalog1.Name = "sevenSegmentAnalog1"
            Me.sevenSegmentAnalog1.Size = New System.Drawing.Size(108, 31)
            Me.sevenSegmentAnalog1.Value.AsDouble = 6.3111782073974609R
            Me.sevenSegmentAnalog1.LoadingEnd()
            '
            'switchLed1
            '
            Me.switchLed1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.switchLed1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding8, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.switchLed1.Location = New System.Drawing.Point(166, 225)
            Me.switchLed1.Name = "switchLed1"
            Me.switchLed1.Size = New System.Drawing.Size(48, 40)
            Me.switchLed1.TabIndex = 17
            Me.switchLed1.LoadingEnd()
            '
            'gaugeLinear1
            '
            Me.gaugeLinear1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.gaugeLinear1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding9, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            ColorSection19.Color = System.Drawing.Color.Lime
            ColorSection20.Color = System.Drawing.Color.Yellow
            ColorSection20.Start = 50.0R
            ColorSection20.Stop = 75.0R
            ColorSection21.Start = 75.0R
            ColorSection21.Stop = 100.0R
            Me.gaugeLinear1.ColorSections.Add(ColorSection19)
            Me.gaugeLinear1.ColorSections.Add(ColorSection20)
            Me.gaugeLinear1.ColorSections.Add(ColorSection21)
            Me.gaugeLinear1.Location = New System.Drawing.Point(275, 7)
            Me.gaugeLinear1.Name = "gaugeLinear1"
            PointerGaugeLinear2.Value.AsDouble = 6.3111782073974609R
            Me.gaugeLinear1.Pointers.Add(PointerGaugeLinear2)
            Me.gaugeLinear1.Size = New System.Drawing.Size(56, 200)
            Me.gaugeLinear1.LoadingEnd()
            '
            'sevenSegmentInteger1
            '
            Me.sevenSegmentInteger1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.sevenSegmentInteger1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding10, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.sevenSegmentInteger1.Location = New System.Drawing.Point(464, 82)
            Me.sevenSegmentInteger1.Name = "sevenSegmentInteger1"
            Me.sevenSegmentInteger1.Size = New System.Drawing.Size(108, 31)
            Me.sevenSegmentInteger1.Value.AsString = "29"
            Me.sevenSegmentInteger1.LoadingEnd()
            '
            'odometer1
            '
            Me.odometer1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.odometer1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding11, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.odometer1.Location = New System.Drawing.Point(337, 58)
            Me.odometer1.Name = "odometer1"
            Me.odometer1.Size = New System.Drawing.Size(93, 18)
            Me.odometer1.Value.AsDouble = 6.3111782073974609R
            Me.odometer1.LoadingEnd()
            '
            'slider1
            '
            Me.slider1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.slider1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding12, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.slider1.Location = New System.Drawing.Point(204, 7)
            Me.slider1.Name = "slider1"
            Me.slider1.Size = New System.Drawing.Size(65, 203)
            Me.slider1.TabIndex = 12
            Me.slider1.Value.AsDouble = 6.3111782073974609R
            Me.slider1.LoadingEnd()
            '
            'thermometer1
            '
            Me.thermometer1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.thermometer1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding13, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.thermometer1.Location = New System.Drawing.Point(132, 5)
            Me.thermometer1.Name = "thermometer1"
            Me.thermometer1.Size = New System.Drawing.Size(66, 203)
            Me.thermometer1.Value.AsDouble = 6.3111782073974609R
            Me.thermometer1.LoadingEnd()
            '
            'led1
            '
            Me.led1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.led1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding14, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.led1.Location = New System.Drawing.Point(41, 225)
            Me.led1.Name = "led1"
            Me.led1.Size = New System.Drawing.Size(32, 32)
            Me.led1.LoadingEnd()
            '
            'sevenSegmentClock1
            '
            Me.sevenSegmentClock1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.sevenSegmentClock1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding15, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.sevenSegmentClock1.Location = New System.Drawing.Point(464, 44)
            Me.sevenSegmentClock1.Name = "sevenSegmentClock1"
            Me.sevenSegmentClock1.Size = New System.Drawing.Size(126, 31)
            Me.sevenSegmentClock1.Value.AsDateTime = New Date(2012, 9, 9, 20, 49, 0, 631)
            Me.sevenSegmentClock1.LoadingEnd()
            '
            'switchToggle1
            '
            Me.switchToggle1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.switchToggle1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding16, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.switchToggle1.Location = New System.Drawing.Point(7, 225)
            Me.switchToggle1.Name = "switchToggle1"
            Me.switchToggle1.Size = New System.Drawing.Size(28, 52)
            Me.switchToggle1.TabIndex = 8
            Me.switchToggle1.LoadingEnd()
            '
            'editInteger1
            '
            Me.editInteger1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.editInteger1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding17, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.editInteger1.Location = New System.Drawing.Point(337, 32)
            Me.editInteger1.Name = "editInteger1"
            Me.editInteger1.Size = New System.Drawing.Size(100, 20)
            Me.editInteger1.TabIndex = 7
            Me.editInteger1.Value.AsString = "29"
            Me.editInteger1.LoadingEnd()
            '
            'sevenSegmentHexadecimal1
            '
            Me.sevenSegmentHexadecimal1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.sevenSegmentHexadecimal1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding18, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.sevenSegmentHexadecimal1.Location = New System.Drawing.Point(464, 7)
            Me.sevenSegmentHexadecimal1.Name = "sevenSegmentHexadecimal1"
            Me.sevenSegmentHexadecimal1.Size = New System.Drawing.Size(108, 31)
            Me.sevenSegmentHexadecimal1.Value.AsString = "29"
            Me.sevenSegmentHexadecimal1.LoadingEnd()
            '
            'editString1
            '
            Me.editString1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.editString1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding19, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.editString1.Location = New System.Drawing.Point(337, 6)
            Me.editString1.Name = "editString1"
            Me.editString1.Size = New System.Drawing.Size(100, 20)
            Me.editString1.TabIndex = 4
            Me.editString1.Value.AsString = "Sunday"
            Me.editString1.LoadingEnd()
            '
            'ledBar1
            '
            Me.ledBar1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.ledBar1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding20, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            ColorSection22.Color = System.Drawing.Color.Lime
            ColorSection23.Color = System.Drawing.Color.Yellow
            ColorSection23.Start = 50.0R
            ColorSection23.Stop = 75.0R
            ColorSection24.Start = 75.0R
            ColorSection24.Stop = 100.0R
            Me.ledBar1.ColorSections.Add(ColorSection22)
            Me.ledBar1.ColorSections.Add(ColorSection23)
            Me.ledBar1.ColorSections.Add(ColorSection24)
            Me.ledBar1.Location = New System.Drawing.Point(110, 7)
            Me.ledBar1.Name = "ledBar1"
            Me.ledBar1.Segments.CountDesired = 99
            Me.ledBar1.Size = New System.Drawing.Size(16, 201)
            Me.ledBar1.Value.AsDouble = 6.3111782073974609R
            Me.ledBar1.LoadingEnd()
            '
            'ledArrow1
            '
            Me.ledArrow1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.ledArrow1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding21, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.ledArrow1.Location = New System.Drawing.Point(607, 221)
            Me.ledArrow1.Name = "ledArrow1"
            Me.ledArrow1.Size = New System.Drawing.Size(48, 24)
            Me.ledArrow1.LoadingEnd()
            '
            'lcdMatrix1
            '
            Me.lcdMatrix1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.lcdMatrix1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding22, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.lcdMatrix1.Location = New System.Drawing.Point(267, 221)
            Me.lcdMatrix1.Name = "lcdMatrix1"
            Me.lcdMatrix1.Size = New System.Drawing.Size(212, 68)
            Me.lcdMatrix1.Text = "Sunday"
            Me.lcdMatrix1.LoadingEnd()
            '
            'tank1
            '
            Me.tank1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.tank1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding23, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.tank1.Color = System.Drawing.SystemColors.ButtonFace
            Me.tank1.Location = New System.Drawing.Point(167, 221)
            Me.tank1.Name = "tank1"
            Me.tank1.Size = New System.Drawing.Size(80, 152)
            Me.tank1.Value.AsDouble = 6.3111782073974609R
            Me.tank1.LoadingEnd()
            '
            'slidingScale1
            '
            Me.slidingScale1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.slidingScale1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding24, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.slidingScale1.Location = New System.Drawing.Point(68, 221)
            Me.slidingScale1.Name = "slidingScale1"
            PointerSlidingScale3.Value.AsDouble = 6.3111782073974609R
            Me.slidingScale1.Pointers.Add(PointerSlidingScale3)
            Me.slidingScale1.ScaleRange.Min = -43.688821792602539R
            Me.slidingScale1.Size = New System.Drawing.Size(93, 208)
            Me.slidingScale1.LoadingEnd()
            '
            'valve1
            '
            Me.valve1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.valve1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding25, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.valve1.Location = New System.Drawing.Point(6, 221)
            Me.valve1.Name = "valve1"
            Me.valve1.Size = New System.Drawing.Size(56, 48)
            Me.valve1.TabIndex = 8
            Me.valve1.LoadingEnd()
            '
            'switchRocker1
            '
            Me.switchRocker1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.switchRocker1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding26, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.switchRocker1.Location = New System.Drawing.Point(485, 6)
            Me.switchRocker1.Name = "switchRocker1"
            Me.switchRocker1.Size = New System.Drawing.Size(28, 52)
            Me.switchRocker1.TabIndex = 6
            Me.switchRocker1.LoadingEnd()
            '
            'gaugeTube1
            '
            Me.gaugeTube1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.gaugeTube1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding27, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.gaugeTube1.Location = New System.Drawing.Point(383, 6)
            Me.gaugeTube1.Name = "gaugeTube1"
            Me.gaugeTube1.Size = New System.Drawing.Size(96, 200)
            Me.gaugeTube1.Value.AsDouble = 6.3111782073974609R
            Me.gaugeTube1.LoadingEnd()
            '
            'switchLever1
            '
            Me.switchLever1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.switchLever1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding28, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.switchLever1.Location = New System.Drawing.Point(349, 6)
            Me.switchLever1.Name = "switchLever1"
            Me.switchLever1.Size = New System.Drawing.Size(28, 52)
            Me.switchLever1.TabIndex = 4
            Me.switchLever1.LoadingEnd()
            '
            'clockAnalog1
            '
            Me.clockAnalog1.LoadingBegin()
            Me.clockAnalog1.AutoUpdate = False
            Me.bindingExtender1.SetBindingBag(Me.clockAnalog1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding29, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.clockAnalog1.Location = New System.Drawing.Point(215, 6)
            Me.clockAnalog1.Name = "clockAnalog1"
            Me.clockAnalog1.Size = New System.Drawing.Size(128, 128)
            Me.clockAnalog1.Value.AsDateTime = New Date(2012, 9, 9, 20, 49, 0, 631)
            Me.clockAnalog1.LoadingEnd()
            '
            'sevenSegmentClockSmpte1
            '
            Me.sevenSegmentClockSmpte1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.sevenSegmentClockSmpte1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding30, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.sevenSegmentClockSmpte1.Location = New System.Drawing.Point(6, 6)
            Me.sevenSegmentClockSmpte1.Name = "sevenSegmentClockSmpte1"
            Me.sevenSegmentClockSmpte1.Size = New System.Drawing.Size(203, 31)
            Me.sevenSegmentClockSmpte1.Value.AsDateTime = New Date(2012, 9, 9, 20, 49, 0, 631)
            Me.sevenSegmentClockSmpte1.LoadingEnd()
            '
            'slidingCompass1
            '
            Me.slidingCompass1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.slidingCompass1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding31, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.slidingCompass1.Location = New System.Drawing.Point(507, 221)
            Me.slidingCompass1.Name = "slidingCompass1"
            PointerSlidingScale4.Value.AsDouble = 22.720241546630859R
            Me.slidingCompass1.Pointers.Add(PointerSlidingScale4)
            Me.slidingCompass1.ScaleRange.Min = -27.279758453369141R
            Me.slidingCompass1.Size = New System.Drawing.Size(93, 208)
            Me.slidingCompass1.LoadingEnd()
            '
            'compass1
            '
            Me.compass1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.compass1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding32, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.compass1.Location = New System.Drawing.Point(519, 6)
            Me.compass1.Name = "compass1"
            PointerCompass2.Value.AsDouble = 22.720241546630859R
            Me.compass1.Pointers.Add(PointerCompass2)
            Me.compass1.PositionDisplay.Radius = 46
            Me.compass1.Size = New System.Drawing.Size(180, 180)
            CompassTick10.Angle = 45.0R
            CompassTick10.Text = "NE"
            CompassTick11.Angle = 90.0R
            CompassTick11.Text = "E"
            CompassTick12.Angle = 135.0R
            CompassTick12.Text = "SE"
            CompassTick13.Angle = 180.0R
            CompassTick13.Text = "S"
            CompassTick14.Angle = 225.0R
            CompassTick14.Text = "SW"
            CompassTick15.Angle = 270.0R
            CompassTick15.Text = "W"
            CompassTick16.Angle = 315.0R
            CompassTick16.Text = "NW"
            Me.compass1.Ticks.Add(CompassTick9)
            Me.compass1.Ticks.Add(CompassTick10)
            Me.compass1.Ticks.Add(CompassTick11)
            Me.compass1.Ticks.Add(CompassTick12)
            Me.compass1.Ticks.Add(CompassTick13)
            Me.compass1.Ticks.Add(CompassTick14)
            Me.compass1.Ticks.Add(CompassTick15)
            Me.compass1.Ticks.Add(CompassTick16)
            Me.compass1.LoadingEnd()
            '
            'switchRotary1
            '
            Me.switchRotary1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.switchRotary1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding33, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            ScaleDiscreetItem7.Text = "Low"
            ScaleDiscreetItem8.Text = "Medium"
            ScaleDiscreetItem9.Text = "High"
            Me.switchRotary1.Items.Add(ScaleDiscreetItem7)
            Me.switchRotary1.Items.Add(ScaleDiscreetItem8)
            Me.switchRotary1.Items.Add(ScaleDiscreetItem9)
            Me.switchRotary1.Location = New System.Drawing.Point(327, 225)
            Me.switchRotary1.Name = "switchRotary1"
            Me.switchRotary1.Size = New System.Drawing.Size(113, 94)
            Me.switchRotary1.TabIndex = 22
            Me.switchRotary1.LoadingEnd()
            '
            'modeComboBox1
            '
            Me.modeComboBox1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.modeComboBox1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding34, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            ModeComboBoxItem4.Text = "Low"
            ModeComboBoxItem5.Text = "Medium"
            ModeComboBoxItem5.Value = 1.0R
            ModeComboBoxItem6.Text = "High"
            ModeComboBoxItem6.Value = 2.0R
            Me.modeComboBox1.Items.Add(ModeComboBoxItem4)
            Me.modeComboBox1.Items.Add(ModeComboBoxItem5)
            Me.modeComboBox1.Items.Add(ModeComboBoxItem6)
            Me.modeComboBox1.Location = New System.Drawing.Point(337, 82)
            Me.modeComboBox1.Name = "modeComboBox1"
            Me.modeComboBox1.Size = New System.Drawing.Size(121, 21)
            Me.modeComboBox1.TabIndex = 18
            Me.modeComboBox1.LoadingEnd()
            '
            'switchSlider1
            '
            Me.switchSlider1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.switchSlider1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding35, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            ScaleDiscreetItem10.Text = "Low"
            ScaleDiscreetItem11.Text = "Medium"
            ScaleDiscreetItem12.Text = "High"
            Me.switchSlider1.Items.Add(ScaleDiscreetItem10)
            Me.switchSlider1.Items.Add(ScaleDiscreetItem11)
            Me.switchSlider1.Items.Add(ScaleDiscreetItem12)
            Me.switchSlider1.Location = New System.Drawing.Point(79, 225)
            Me.switchSlider1.Name = "switchSlider1"
            Me.switchSlider1.Size = New System.Drawing.Size(81, 104)
            Me.switchSlider1.TabIndex = 14
            Me.switchSlider1.LoadingEnd()
            '
            'switchPanel1
            '
            Me.switchPanel1.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.switchPanel1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding36, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.switchPanel1.Location = New System.Drawing.Point(7, 7)
            Me.switchPanel1.Name = "switchPanel1"
            Me.switchPanel1.Size = New System.Drawing.Size(96, 133)
            Me.switchPanel1.TabIndex = 2
            Me.switchPanel1.LoadingEnd()
            '
            'slider2
            '
            Me.slider2.LoadingBegin()
            Me.bindingExtender1.SetBindingBag(Me.slider2, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding37, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.slider2.Location = New System.Drawing.Point(684, 35)
            Me.slider2.Name = "slider2"
            Me.slider2.ScaleRange.Min = -100.0R
            Me.slider2.ScaleRange.Span = 200.0R
            Me.slider2.Size = New System.Drawing.Size(68, 387)
            Me.slider2.TabIndex = 3
            Me.slider2.Value.Max = 100.0R
            Me.slider2.Value.Min = -100.0R
            Me.slider2.LoadingEnd()
            '
            'tabControl1
            '
            Me.tabControl1.Controls.Add(Me.tabPage1)
            Me.tabControl1.Controls.Add(Me.tabPage2)
            Me.tabControl1.Controls.Add(Me.tabPage3)
            Me.tabControl1.Location = New System.Drawing.Point(12, 94)
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(760, 464)
            Me.tabControl1.TabIndex = 1
            '
            'tabPage1
            '
            Me.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.tabPage1.Controls.Add(Me.displayString1)
            Me.tabPage1.Controls.Add(Me.editDouble1)
            Me.tabPage1.Controls.Add(Me.ledSpiral1)
            Me.tabPage1.Controls.Add(Me.switchRotary1)
            Me.tabPage1.Controls.Add(Me.displayDouble1)
            Me.tabPage1.Controls.Add(Me.displayInteger1)
            Me.tabPage1.Controls.Add(Me.sevenSegmentAnalog1)
            Me.tabPage1.Controls.Add(Me.modeComboBox1)
            Me.tabPage1.Controls.Add(Me.switchLed1)
            Me.tabPage1.Controls.Add(Me.gaugeLinear1)
            Me.tabPage1.Controls.Add(Me.sevenSegmentInteger1)
            Me.tabPage1.Controls.Add(Me.switchSlider1)
            Me.tabPage1.Controls.Add(Me.odometer1)
            Me.tabPage1.Controls.Add(Me.slider1)
            Me.tabPage1.Controls.Add(Me.thermometer1)
            Me.tabPage1.Controls.Add(Me.led1)
            Me.tabPage1.Controls.Add(Me.sevenSegmentClock1)
            Me.tabPage1.Controls.Add(Me.switchToggle1)
            Me.tabPage1.Controls.Add(Me.editInteger1)
            Me.tabPage1.Controls.Add(Me.sevenSegmentHexadecimal1)
            Me.tabPage1.Controls.Add(Me.editString1)
            Me.tabPage1.Controls.Add(Me.ledBar1)
            Me.tabPage1.Controls.Add(Me.switchPanel1)
            Me.tabPage1.Controls.Add(Me.gaugeAngular1)
            Me.tabPage1.Location = New System.Drawing.Point(4, 22)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage1.Size = New System.Drawing.Size(752, 438)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "Standard"
            '
            'tabPage2
            '
            Me.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.tabPage2.Controls.Add(Me.ledArrow1)
            Me.tabPage2.Controls.Add(Me.slidingCompass1)
            Me.tabPage2.Controls.Add(Me.lcdMatrix1)
            Me.tabPage2.Controls.Add(Me.tank1)
            Me.tabPage2.Controls.Add(Me.slidingScale1)
            Me.tabPage2.Controls.Add(Me.valve1)
            Me.tabPage2.Controls.Add(Me.compass1)
            Me.tabPage2.Controls.Add(Me.switchRocker1)
            Me.tabPage2.Controls.Add(Me.gaugeTube1)
            Me.tabPage2.Controls.Add(Me.switchLever1)
            Me.tabPage2.Controls.Add(Me.clockAnalog1)
            Me.tabPage2.Controls.Add(Me.sevenSegmentClockSmpte1)
            Me.tabPage2.Location = New System.Drawing.Point(4, 22)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage2.Size = New System.Drawing.Size(752, 438)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "Professional"
            '
            'tabPage3
            '
            Me.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.tabPage3.Controls.Add(Me.slider2)
            Me.tabPage3.Controls.Add(Me.label1)
            Me.tabPage3.Controls.Add(Me.plotToolBarStandard1)
            Me.tabPage3.Controls.Add(Me.plot1)
            Me.tabPage3.Location = New System.Drawing.Point(4, 22)
            Me.tabPage3.Name = "tabPage3"
            Me.tabPage3.Size = New System.Drawing.Size(752, 438)
            Me.tabPage3.TabIndex = 2
            Me.tabPage3.Text = "Plotting"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(3, 425)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(561, 13)
            Me.label1.TabIndex = 2
            Me.label1.Text = "A small amount of manual coding has been used on this particular page to feed the" & _
        " incoming data into the plot control."
            '
            'plotToolBarStandard1
            '
            Me.plotToolBarStandard1.LoadingBegin()
            Me.plotToolBarStandard1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
            Me.plotToolBarStandard1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.plotToolBarButton1, Me.plotToolBarButton2, Me.plotToolBarButton3, Me.plotToolBarButton4, Me.plotToolBarButton5, Me.plotToolBarButton6, Me.plotToolBarButton7, Me.plotToolBarButton8, Me.plotToolBarButton9, Me.plotToolBarButton10, Me.plotToolBarButton11, Me.plotToolBarButton12, Me.plotToolBarButton13, Me.plotToolBarButton14, Me.plotToolBarButton15, Me.plotToolBarButton16, Me.plotToolBarButton17, Me.plotToolBarButton18, Me.plotToolBarButton19, Me.plotToolBarButton20, Me.plotToolBarButton21})
            Me.plotToolBarStandard1.DropDownArrows = True
            Me.plotToolBarStandard1.ImageList = Me.imageList1
            Me.plotToolBarStandard1.Location = New System.Drawing.Point(0, 0)
            Me.plotToolBarStandard1.Name = "plotToolBarStandard1"
            Me.plotToolBarStandard1.Plot = Nothing
            Me.plotToolBarStandard1.ShowToolTips = True
            Me.plotToolBarStandard1.Size = New System.Drawing.Size(752, 28)
            Me.plotToolBarStandard1.TabIndex = 1
            Me.plotToolBarStandard1.LoadingEnd()
            '
            'plotToolBarButton1
            '
            Me.plotToolBarButton1.LoadingBegin()
            Me.plotToolBarButton1.ImageIndex = 0
            Me.plotToolBarButton1.Name = "plotToolBarButton1"
            Me.plotToolBarButton1.ToolTipText = "Tracking Resume"
            Me.plotToolBarButton1.LoadingEnd()
            '
            'plotToolBarButton2
            '
            Me.plotToolBarButton2.LoadingBegin()
            Me.plotToolBarButton2.Command = Iocomp.Types.PlotToolBarCommandStyle.TrackingPause
            Me.plotToolBarButton2.ImageIndex = 1
            Me.plotToolBarButton2.Name = "plotToolBarButton2"
            Me.plotToolBarButton2.ToolTipText = "Tracking Pause"
            Me.plotToolBarButton2.LoadingEnd()
            '
            'plotToolBarButton3
            '
            Me.plotToolBarButton3.LoadingBegin()
            Me.plotToolBarButton3.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator
            Me.plotToolBarButton3.Enabled = False
            Me.plotToolBarButton3.Name = "plotToolBarButton3"
            Me.plotToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            Me.plotToolBarButton3.LoadingEnd()
            '
            'plotToolBarButton4
            '
            Me.plotToolBarButton4.LoadingBegin()
            Me.plotToolBarButton4.Command = Iocomp.Types.PlotToolBarCommandStyle.AxesScroll
            Me.plotToolBarButton4.ImageIndex = 2
            Me.plotToolBarButton4.Name = "plotToolBarButton4"
            Me.plotToolBarButton4.ToolTipText = "Axes Scroll"
            Me.plotToolBarButton4.LoadingEnd()
            '
            'plotToolBarButton5
            '
            Me.plotToolBarButton5.LoadingBegin()
            Me.plotToolBarButton5.Command = Iocomp.Types.PlotToolBarCommandStyle.AxesZoom
            Me.plotToolBarButton5.ImageIndex = 3
            Me.plotToolBarButton5.Name = "plotToolBarButton5"
            Me.plotToolBarButton5.ToolTipText = "Axes Zoom"
            Me.plotToolBarButton5.LoadingEnd()
            '
            'plotToolBarButton6
            '
            Me.plotToolBarButton6.LoadingBegin()
            Me.plotToolBarButton6.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator
            Me.plotToolBarButton6.Enabled = False
            Me.plotToolBarButton6.Name = "plotToolBarButton6"
            Me.plotToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            Me.plotToolBarButton6.LoadingEnd()
            '
            'plotToolBarButton7
            '
            Me.plotToolBarButton7.LoadingBegin()
            Me.plotToolBarButton7.Command = Iocomp.Types.PlotToolBarCommandStyle.ZoomOut
            Me.plotToolBarButton7.ImageIndex = 4
            Me.plotToolBarButton7.Name = "plotToolBarButton7"
            Me.plotToolBarButton7.ToolTipText = "Zoom-Out"
            Me.plotToolBarButton7.LoadingEnd()
            '
            'plotToolBarButton8
            '
            Me.plotToolBarButton8.LoadingBegin()
            Me.plotToolBarButton8.Command = Iocomp.Types.PlotToolBarCommandStyle.ZoomIn
            Me.plotToolBarButton8.ImageIndex = 5
            Me.plotToolBarButton8.Name = "plotToolBarButton8"
            Me.plotToolBarButton8.ToolTipText = "Zoom-In"
            Me.plotToolBarButton8.LoadingEnd()
            '
            'plotToolBarButton9
            '
            Me.plotToolBarButton9.LoadingBegin()
            Me.plotToolBarButton9.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator
            Me.plotToolBarButton9.Enabled = False
            Me.plotToolBarButton9.Name = "plotToolBarButton9"
            Me.plotToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            Me.plotToolBarButton9.LoadingEnd()
            '
            'plotToolBarButton10
            '
            Me.plotToolBarButton10.LoadingBegin()
            Me.plotToolBarButton10.Command = Iocomp.Types.PlotToolBarCommandStyle.[Select]
            Me.plotToolBarButton10.ImageIndex = 6
            Me.plotToolBarButton10.Name = "plotToolBarButton10"
            Me.plotToolBarButton10.ToolTipText = "Select"
            Me.plotToolBarButton10.LoadingEnd()
            '
            'plotToolBarButton11
            '
            Me.plotToolBarButton11.LoadingBegin()
            Me.plotToolBarButton11.Command = Iocomp.Types.PlotToolBarCommandStyle.ZoomBox
            Me.plotToolBarButton11.ImageIndex = 7
            Me.plotToolBarButton11.Name = "plotToolBarButton11"
            Me.plotToolBarButton11.ToolTipText = "Zoom-Box"
            Me.plotToolBarButton11.LoadingEnd()
            '
            'plotToolBarButton12
            '
            Me.plotToolBarButton12.LoadingBegin()
            Me.plotToolBarButton12.Command = Iocomp.Types.PlotToolBarCommandStyle.DataCursor
            Me.plotToolBarButton12.ImageIndex = 8
            Me.plotToolBarButton12.Name = "plotToolBarButton12"
            Me.plotToolBarButton12.ToolTipText = "Data-Cursor"
            Me.plotToolBarButton12.LoadingEnd()
            '
            'plotToolBarButton13
            '
            Me.plotToolBarButton13.LoadingBegin()
            Me.plotToolBarButton13.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator
            Me.plotToolBarButton13.Enabled = False
            Me.plotToolBarButton13.Name = "plotToolBarButton13"
            Me.plotToolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            Me.plotToolBarButton13.LoadingEnd()
            '
            'plotToolBarButton14
            '
            Me.plotToolBarButton14.LoadingBegin()
            Me.plotToolBarButton14.Command = Iocomp.Types.PlotToolBarCommandStyle.Edit
            Me.plotToolBarButton14.ImageIndex = 9
            Me.plotToolBarButton14.Name = "plotToolBarButton14"
            Me.plotToolBarButton14.ToolTipText = "Edit"
            Me.plotToolBarButton14.LoadingEnd()
            '
            'plotToolBarButton15
            '
            Me.plotToolBarButton15.LoadingBegin()
            Me.plotToolBarButton15.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator
            Me.plotToolBarButton15.Enabled = False
            Me.plotToolBarButton15.Name = "plotToolBarButton15"
            Me.plotToolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            Me.plotToolBarButton15.LoadingEnd()
            '
            'plotToolBarButton16
            '
            Me.plotToolBarButton16.LoadingBegin()
            Me.plotToolBarButton16.Command = Iocomp.Types.PlotToolBarCommandStyle.Copy
            Me.plotToolBarButton16.ImageIndex = 10
            Me.plotToolBarButton16.Name = "plotToolBarButton16"
            Me.plotToolBarButton16.ToolTipText = "Copy to Clipboard"
            Me.plotToolBarButton16.LoadingEnd()
            '
            'plotToolBarButton17
            '
            Me.plotToolBarButton17.LoadingBegin()
            Me.plotToolBarButton17.Command = Iocomp.Types.PlotToolBarCommandStyle.Save
            Me.plotToolBarButton17.ImageIndex = 11
            Me.plotToolBarButton17.Name = "plotToolBarButton17"
            Me.plotToolBarButton17.ToolTipText = "Save"
            Me.plotToolBarButton17.LoadingEnd()
            '
            'plotToolBarButton18
            '
            Me.plotToolBarButton18.LoadingBegin()
            Me.plotToolBarButton18.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator
            Me.plotToolBarButton18.Enabled = False
            Me.plotToolBarButton18.Name = "plotToolBarButton18"
            Me.plotToolBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            Me.plotToolBarButton18.LoadingEnd()
            '
            'plotToolBarButton19
            '
            Me.plotToolBarButton19.LoadingBegin()
            Me.plotToolBarButton19.Command = Iocomp.Types.PlotToolBarCommandStyle.Print
            Me.plotToolBarButton19.ImageIndex = 12
            Me.plotToolBarButton19.Name = "plotToolBarButton19"
            Me.plotToolBarButton19.ToolTipText = "Print"
            Me.plotToolBarButton19.LoadingEnd()
            '
            'plotToolBarButton20
            '
            Me.plotToolBarButton20.LoadingBegin()
            Me.plotToolBarButton20.Command = Iocomp.Types.PlotToolBarCommandStyle.Preview
            Me.plotToolBarButton20.ImageIndex = 13
            Me.plotToolBarButton20.Name = "plotToolBarButton20"
            Me.plotToolBarButton20.ToolTipText = "Preview"
            Me.plotToolBarButton20.LoadingEnd()
            '
            'plotToolBarButton21
            '
            Me.plotToolBarButton21.LoadingBegin()
            Me.plotToolBarButton21.Command = Iocomp.Types.PlotToolBarCommandStyle.PageSetup
            Me.plotToolBarButton21.ImageIndex = 14
            Me.plotToolBarButton21.Name = "plotToolBarButton21"
            Me.plotToolBarButton21.ToolTipText = "Page Setup"
            Me.plotToolBarButton21.LoadingEnd()
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "")
            Me.imageList1.Images.SetKeyName(6, "")
            Me.imageList1.Images.SetKeyName(7, "")
            Me.imageList1.Images.SetKeyName(8, "")
            Me.imageList1.Images.SetKeyName(9, "")
            Me.imageList1.Images.SetKeyName(10, "")
            Me.imageList1.Images.SetKeyName(11, "")
            Me.imageList1.Images.SetKeyName(12, "")
            Me.imageList1.Images.SetKeyName(13, "")
            '
            'plot1
            '
            Me.plot1.LoadingBegin()
            PlotChannelTrace4.Color = System.Drawing.Color.Red
            PlotChannelTrace4.Name = "Channel 1"
            PlotChannelTrace4.TitleText = "Channel 1"
            PlotChannelTrace5.Color = System.Drawing.Color.Blue
            PlotChannelTrace5.Name = "Channel 2"
            PlotChannelTrace5.TitleText = "Channel 2"
            PlotChannelTrace6.Color = System.Drawing.Color.Lime
            PlotChannelTrace6.Name = "Channel 3"
            PlotChannelTrace6.TitleText = "Channel 3"
            Me.plot1.Channels.Add(PlotChannelTrace4)
            Me.plot1.Channels.Add(PlotChannelTrace5)
            Me.plot1.Channels.Add(PlotChannelTrace6)
            PlotDataCursorXY2.Hint.Fill.Pen.Color = System.Drawing.SystemColors.InfoText
            PlotDataCursorXY2.Name = "Data-Cursor 1"
            PlotDataCursorXY2.TitleText = "Data-Cursor 1"
            Me.plot1.DataCursors.Add(PlotDataCursorXY2)
            PlotDataView2.Name = "Data-View 1"
            PlotDataView2.TitleText = "Data-View 1"
            Me.plot1.DataViews.Add(PlotDataView2)
            PlotLabelBasic2.DockOrder = 0
            PlotLabelBasic2.Name = "Label 1"
            PlotLabelBasic2.TitleText = "Label 1"
            Me.plot1.Labels.Add(PlotLabelBasic2)
            PlotLegendBasic2.DockOrder = 0
            PlotLegendBasic2.Name = "Legend 1"
            PlotLegendBasic2.TitleText = "Legend 1"
            Me.plot1.Legends.Add(PlotLegendBasic2)
            Me.plot1.Location = New System.Drawing.Point(-4, 34)
            Me.plot1.Name = "plot1"
            Me.plot1.Size = New System.Drawing.Size(682, 388)
            Me.plot1.TabIndex = 0
            PlotXAxis2.DockOrder = 0
            PlotXAxis2.Name = "X-Axis 1"
            PlotXAxis2.ScaleRange.Span = 0.000694444446708076R
            PlotXAxis2.Title.Text = "X-Axis 1"
            Me.plot1.XAxes.Add(PlotXAxis2)
            PlotYAxis2.DockOrder = 0
            PlotYAxis2.Name = "Y-Axis 1"
            PlotYAxis2.Title.Text = "Y-Axis 1"
            Me.plot1.YAxes.Add(PlotYAxis2)
            Me.plot1.LoadingEnd()
            '
            'easyDAClient1
            '
            '
            'richTextBox1
            '
            Me.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.richTextBox1.Location = New System.Drawing.Point(12, 4)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(760, 84)
            Me.richTextBox1.TabIndex = 50
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
            DaItemPoint38.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint38.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding1.Point = DaItemPoint38
            DaItemPointSubscribeParameters37.RequestedUpdateRate = 100
            Me.PointBinding1.SubscribeParameters = DaItemPointSubscribeParameters37
            Me.PointBinding1.ValueTarget.TargetComponent = Me.gaugeAngular1
            Me.PointBinding1.ValueTarget.TargetPath = "Value"
            '
            'PointBinding2
            '
            Me.PointBinding2.ArgumentsPath = "Value"
            DaItemPoint48.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Weekdays (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Weekdays (10 s)"}))
            DaItemPoint48.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding2.Point = DaItemPoint48
            DaItemPointSubscribeParameters47.RequestedUpdateRate = 100
            Me.PointBinding2.SubscribeParameters = DaItemPointSubscribeParameters47
            Me.PointBinding2.ValueTarget.TargetComponent = Me.displayString1
            Me.PointBinding2.ValueTarget.TargetPath = "Value"
            '
            'PointBinding3
            '
            Me.PointBinding3.ArgumentsPath = "Value"
            DaItemPoint49.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint49.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding3.Point = DaItemPoint49
            DaItemPointSubscribeParameters48.RequestedUpdateRate = 100
            Me.PointBinding3.SubscribeParameters = DaItemPointSubscribeParameters48
            Me.PointBinding3.ValueTarget.TargetComponent = Me.editDouble1
            Me.PointBinding3.ValueTarget.TargetPath = "Value"
            '
            'PointBinding4
            '
            Me.PointBinding4.ArgumentsPath = "Value"
            DaItemPoint39.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint39.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding4.Point = DaItemPoint39
            DaItemPointSubscribeParameters38.RequestedUpdateRate = 100
            Me.PointBinding4.SubscribeParameters = DaItemPointSubscribeParameters38
            Me.PointBinding4.ValueTarget.TargetComponent = Me.ledSpiral1
            Me.PointBinding4.ValueTarget.TargetPath = "Value"
            '
            'PointBinding5
            '
            Me.PointBinding5.ArgumentsPath = "Value"
            DaItemPoint50.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint50.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding5.Point = DaItemPoint50
            DaItemPointSubscribeParameters49.RequestedUpdateRate = 100
            Me.PointBinding5.SubscribeParameters = DaItemPointSubscribeParameters49
            Me.PointBinding5.ValueTarget.TargetComponent = Me.displayDouble1
            Me.PointBinding5.ValueTarget.TargetPath = "Value"
            '
            'PointBinding6
            '
            Me.PointBinding6.ArgumentsPath = "Value"
            DaItemPoint51.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Incrementing (1 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Incrementing (1 s)"}))
            DaItemPoint51.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding6.Point = DaItemPoint51
            DaItemPointSubscribeParameters50.RequestedUpdateRate = 100
            Me.PointBinding6.SubscribeParameters = DaItemPointSubscribeParameters50
            Me.PointBinding6.ValueTarget.TargetComponent = Me.displayInteger1
            Me.PointBinding6.ValueTarget.TargetPath = "Value"
            '
            'PointBinding7
            '
            Me.PointBinding7.ArgumentsPath = "Value"
            DaItemPoint52.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint52.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding7.Point = DaItemPoint52
            DaItemPointSubscribeParameters51.RequestedUpdateRate = 100
            Me.PointBinding7.SubscribeParameters = DaItemPointSubscribeParameters51
            Me.PointBinding7.ValueTarget.TargetComponent = Me.sevenSegmentAnalog1
            Me.PointBinding7.ValueTarget.TargetPath = "Value"
            '
            'PointBinding8
            '
            Me.PointBinding8.ArgumentsPath = "Value"
            DaItemPoint53.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint53.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding8.Point = DaItemPoint53
            DaItemPointSubscribeParameters52.RequestedUpdateRate = 100
            Me.PointBinding8.SubscribeParameters = DaItemPointSubscribeParameters52
            Me.PointBinding8.ValueTarget.TargetComponent = Me.switchLed1
            Me.PointBinding8.ValueTarget.TargetPath = "Value"
            '
            'PointBinding9
            '
            Me.PointBinding9.ArgumentsPath = "Value"
            DaItemPoint40.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint40.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding9.Point = DaItemPoint40
            DaItemPointSubscribeParameters39.RequestedUpdateRate = 100
            Me.PointBinding9.SubscribeParameters = DaItemPointSubscribeParameters39
            Me.PointBinding9.ValueTarget.TargetComponent = Me.gaugeLinear1
            Me.PointBinding9.ValueTarget.TargetPath = "Value"
            '
            'PointBinding10
            '
            Me.PointBinding10.ArgumentsPath = "Value"
            DaItemPoint54.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Incrementing (1 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Incrementing (1 s)"}))
            DaItemPoint54.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding10.Point = DaItemPoint54
            DaItemPointSubscribeParameters53.RequestedUpdateRate = 100
            Me.PointBinding10.SubscribeParameters = DaItemPointSubscribeParameters53
            Me.PointBinding10.ValueTarget.TargetComponent = Me.sevenSegmentInteger1
            Me.PointBinding10.ValueTarget.TargetPath = "Value"
            '
            'PointBinding11
            '
            Me.PointBinding11.ArgumentsPath = "Value"
            DaItemPoint55.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint55.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding11.Point = DaItemPoint55
            DaItemPointSubscribeParameters54.RequestedUpdateRate = 100
            Me.PointBinding11.SubscribeParameters = DaItemPointSubscribeParameters54
            Me.PointBinding11.ValueTarget.TargetComponent = Me.odometer1
            Me.PointBinding11.ValueTarget.TargetPath = "Value"
            '
            'PointBinding12
            '
            Me.PointBinding12.ArgumentsPath = "Value"
            DaItemPoint56.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint56.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding12.Point = DaItemPoint56
            DaItemPointSubscribeParameters55.RequestedUpdateRate = 100
            Me.PointBinding12.SubscribeParameters = DaItemPointSubscribeParameters55
            Me.PointBinding12.ValueTarget.TargetComponent = Me.slider1
            Me.PointBinding12.ValueTarget.TargetPath = "Value"
            '
            'PointBinding13
            '
            Me.PointBinding13.ArgumentsPath = "Value"
            DaItemPoint57.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint57.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding13.Point = DaItemPoint57
            DaItemPointSubscribeParameters56.RequestedUpdateRate = 100
            Me.PointBinding13.SubscribeParameters = DaItemPointSubscribeParameters56
            Me.PointBinding13.ValueTarget.TargetComponent = Me.thermometer1
            Me.PointBinding13.ValueTarget.TargetPath = "Value"
            '
            'PointBinding14
            '
            Me.PointBinding14.ArgumentsPath = "Value"
            DaItemPoint58.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint58.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding14.Point = DaItemPoint58
            DaItemPointSubscribeParameters57.RequestedUpdateRate = 100
            Me.PointBinding14.SubscribeParameters = DaItemPointSubscribeParameters57
            Me.PointBinding14.ValueTarget.TargetComponent = Me.led1
            Me.PointBinding14.ValueTarget.TargetPath = "Value"
            '
            'PointBinding15
            '
            Me.PointBinding15.ArgumentsPath = "Timestamp"
            DaItemPoint59.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint59.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding15.Point = DaItemPoint59
            DaItemPointSubscribeParameters58.RequestedUpdateRate = 100
            Me.PointBinding15.SubscribeParameters = DaItemPointSubscribeParameters58
            Me.PointBinding15.ValueTarget.TargetComponent = Me.sevenSegmentClock1
            Me.PointBinding15.ValueTarget.TargetPath = "Value"
            '
            'PointBinding16
            '
            Me.PointBinding16.ArgumentsPath = "Value"
            DaItemPoint60.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint60.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding16.Point = DaItemPoint60
            DaItemPointSubscribeParameters59.RequestedUpdateRate = 100
            Me.PointBinding16.SubscribeParameters = DaItemPointSubscribeParameters59
            Me.PointBinding16.ValueTarget.TargetComponent = Me.switchToggle1
            Me.PointBinding16.ValueTarget.TargetPath = "Value"
            '
            'PointBinding17
            '
            Me.PointBinding17.ArgumentsPath = "Value"
            DaItemPoint61.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Incrementing (1 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Incrementing (1 s)"}))
            DaItemPoint61.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding17.Point = DaItemPoint61
            DaItemPointSubscribeParameters60.RequestedUpdateRate = 100
            Me.PointBinding17.SubscribeParameters = DaItemPointSubscribeParameters60
            Me.PointBinding17.ValueTarget.TargetComponent = Me.editInteger1
            Me.PointBinding17.ValueTarget.TargetPath = "Value"
            '
            'PointBinding18
            '
            Me.PointBinding18.ArgumentsPath = "Value"
            DaItemPoint62.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Incrementing (1 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Incrementing (1 s)"}))
            DaItemPoint62.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding18.Point = DaItemPoint62
            DaItemPointSubscribeParameters61.RequestedUpdateRate = 100
            Me.PointBinding18.SubscribeParameters = DaItemPointSubscribeParameters61
            Me.PointBinding18.ValueTarget.TargetComponent = Me.sevenSegmentHexadecimal1
            Me.PointBinding18.ValueTarget.TargetPath = "Value"
            '
            'PointBinding19
            '
            Me.PointBinding19.ArgumentsPath = "Value"
            DaItemPoint63.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Weekdays (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Weekdays (10 s)"}))
            DaItemPoint63.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding19.Point = DaItemPoint63
            DaItemPointSubscribeParameters62.RequestedUpdateRate = 100
            Me.PointBinding19.SubscribeParameters = DaItemPointSubscribeParameters62
            Me.PointBinding19.ValueTarget.TargetComponent = Me.editString1
            Me.PointBinding19.ValueTarget.TargetPath = "Value"
            '
            'PointBinding20
            '
            Me.PointBinding20.ArgumentsPath = "Value"
            DaItemPoint41.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint41.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding20.Point = DaItemPoint41
            DaItemPointSubscribeParameters40.RequestedUpdateRate = 100
            Me.PointBinding20.SubscribeParameters = DaItemPointSubscribeParameters40
            Me.PointBinding20.ValueTarget.TargetComponent = Me.ledBar1
            Me.PointBinding20.ValueTarget.TargetPath = "Value"
            '
            'PointBinding21
            '
            Me.PointBinding21.ArgumentsPath = "Value"
            DaItemPoint64.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint64.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding21.Point = DaItemPoint64
            DaItemPointSubscribeParameters63.RequestedUpdateRate = 100
            Me.PointBinding21.SubscribeParameters = DaItemPointSubscribeParameters63
            Me.PointBinding21.ValueTarget.TargetComponent = Me.ledArrow1
            Me.PointBinding21.ValueTarget.TargetPath = "Value"
            '
            'PointBinding22
            '
            Me.PointBinding22.ArgumentsPath = "Value"
            DaItemPoint65.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Weekdays (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Weekdays (10 s)"}))
            DaItemPoint65.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding22.Point = DaItemPoint65
            DaItemPointSubscribeParameters64.RequestedUpdateRate = 100
            Me.PointBinding22.SubscribeParameters = DaItemPointSubscribeParameters64
            Me.PointBinding22.ValueTarget.TargetComponent = Me.lcdMatrix1
            Me.PointBinding22.ValueTarget.TargetPath = "Text"
            '
            'PointBinding23
            '
            Me.PointBinding23.ArgumentsPath = "Value"
            DaItemPoint66.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint66.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding23.Point = DaItemPoint66
            DaItemPointSubscribeParameters65.RequestedUpdateRate = 100
            Me.PointBinding23.SubscribeParameters = DaItemPointSubscribeParameters65
            Me.PointBinding23.ValueTarget.TargetComponent = Me.tank1
            Me.PointBinding23.ValueTarget.TargetPath = "Value"
            '
            'PointBinding24
            '
            Me.PointBinding24.ArgumentsPath = "Value"
            DaItemPoint42.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint42.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding24.Point = DaItemPoint42
            DaItemPointSubscribeParameters41.RequestedUpdateRate = 100
            Me.PointBinding24.SubscribeParameters = DaItemPointSubscribeParameters41
            Me.PointBinding24.ValueTarget.TargetComponent = Me.slidingScale1
            Me.PointBinding24.ValueTarget.TargetPath = "Value"
            '
            'PointBinding25
            '
            Me.PointBinding25.ArgumentsPath = "Value"
            DaItemPoint67.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint67.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding25.Point = DaItemPoint67
            DaItemPointSubscribeParameters66.RequestedUpdateRate = 100
            Me.PointBinding25.SubscribeParameters = DaItemPointSubscribeParameters66
            Me.PointBinding25.ValueTarget.TargetComponent = Me.valve1
            Me.PointBinding25.ValueTarget.TargetPath = "Value"
            '
            'PointBinding26
            '
            Me.PointBinding26.ArgumentsPath = "Value"
            DaItemPoint68.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint68.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding26.Point = DaItemPoint68
            DaItemPointSubscribeParameters67.RequestedUpdateRate = 100
            Me.PointBinding26.SubscribeParameters = DaItemPointSubscribeParameters67
            Me.PointBinding26.ValueTarget.TargetComponent = Me.switchRocker1
            Me.PointBinding26.ValueTarget.TargetPath = "Value"
            '
            'PointBinding27
            '
            Me.PointBinding27.ArgumentsPath = "Value"
            DaItemPoint69.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint69.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding27.Point = DaItemPoint69
            DaItemPointSubscribeParameters68.RequestedUpdateRate = 100
            Me.PointBinding27.SubscribeParameters = DaItemPointSubscribeParameters68
            Me.PointBinding27.ValueTarget.TargetComponent = Me.gaugeTube1
            Me.PointBinding27.ValueTarget.TargetPath = "Value"
            '
            'PointBinding28
            '
            Me.PointBinding28.ArgumentsPath = "Value"
            DaItemPoint70.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint70.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding28.Point = DaItemPoint70
            DaItemPointSubscribeParameters69.RequestedUpdateRate = 100
            Me.PointBinding28.SubscribeParameters = DaItemPointSubscribeParameters69
            Me.PointBinding28.ValueTarget.TargetComponent = Me.switchLever1
            Me.PointBinding28.ValueTarget.TargetPath = "Value"
            '
            'PointBinding29
            '
            Me.PointBinding29.ArgumentsPath = "Timestamp"
            DaItemPoint71.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint71.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding29.Point = DaItemPoint71
            DaItemPointSubscribeParameters70.RequestedUpdateRate = 100
            Me.PointBinding29.SubscribeParameters = DaItemPointSubscribeParameters70
            Me.PointBinding29.ValueTarget.TargetComponent = Me.clockAnalog1
            Me.PointBinding29.ValueTarget.TargetPath = "ValueDataBind"
            '
            'PointBinding30
            '
            Me.PointBinding30.ArgumentsPath = "Timestamp"
            DaItemPoint72.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint72.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding30.Point = DaItemPoint72
            DaItemPointSubscribeParameters71.RequestedUpdateRate = 100
            Me.PointBinding30.SubscribeParameters = DaItemPointSubscribeParameters71
            Me.PointBinding30.ValueTarget.TargetComponent = Me.sevenSegmentClockSmpte1
            Me.PointBinding30.ValueTarget.TargetPath = "Value"
            '
            'PointBinding31
            '
            Me.PointBinding31.ArgumentsPath = "Value"
            DaItemPoint43.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:360 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:360 (10 s)"}))
            DaItemPoint43.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding31.Point = DaItemPoint43
            DaItemPointSubscribeParameters42.RequestedUpdateRate = 100
            Me.PointBinding31.SubscribeParameters = DaItemPointSubscribeParameters42
            Me.PointBinding31.ValueTarget.TargetComponent = Me.slidingCompass1
            Me.PointBinding31.ValueTarget.TargetPath = "Value"
            '
            'PointBinding32
            '
            Me.PointBinding32.ArgumentsPath = "Value"
            DaItemPoint44.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:360 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:360 (10 s)"}))
            DaItemPoint44.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding32.Point = DaItemPoint44
            DaItemPointSubscribeParameters43.RequestedUpdateRate = 100
            Me.PointBinding32.SubscribeParameters = DaItemPointSubscribeParameters43
            Me.PointBinding32.ValueTarget.TargetComponent = Me.compass1
            Me.PointBinding32.ValueTarget.TargetPath = "Value"
            '
            'PointBinding33
            '
            Me.PointBinding33.ArgumentsPath = "Value"
            DaItemPoint45.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Staircase 0:2 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Staircase 0:2 (10 s)"}))
            DaItemPoint45.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding33.Point = DaItemPoint45
            DaItemPointSubscribeParameters44.RequestedUpdateRate = 100
            Me.PointBinding33.SubscribeParameters = DaItemPointSubscribeParameters44
            Me.PointBinding33.ValueTarget.TargetComponent = Me.switchRotary1
            Me.PointBinding33.ValueTarget.TargetPath = "Value"
            '
            'PointBinding34
            '
            Me.PointBinding34.ArgumentsPath = "Value"
            DaItemPoint46.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Staircase 0:2 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Staircase 0:2 (10 s)"}))
            DaItemPoint46.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding34.Point = DaItemPoint46
            DaItemPointSubscribeParameters45.RequestedUpdateRate = 100
            Me.PointBinding34.SubscribeParameters = DaItemPointSubscribeParameters45
            Me.PointBinding34.ValueTarget.TargetComponent = Me.modeComboBox1
            Me.PointBinding34.ValueTarget.TargetPath = "Value"
            '
            'PointBinding35
            '
            Me.PointBinding35.ArgumentsPath = "Value"
            DaItemPoint47.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Staircase 0:2 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Staircase 0:2 (10 s)"}))
            DaItemPoint47.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding35.Point = DaItemPoint47
            DaItemPointSubscribeParameters46.RequestedUpdateRate = 100
            Me.PointBinding35.SubscribeParameters = DaItemPointSubscribeParameters46
            Me.PointBinding35.ValueTarget.TargetComponent = Me.switchSlider1
            Me.PointBinding35.ValueTarget.TargetPath = "Value"
            '
            'PointBinding36
            '
            Me.PointBinding36.ArgumentsPath = "Value"
            DaItemPoint73.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Staircase 0:2 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Staircase 0:2 (10 s)"}))
            DaItemPoint73.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding36.Point = DaItemPoint73
            DaItemPointSubscribeParameters72.RequestedUpdateRate = 100
            Me.PointBinding36.SubscribeParameters = DaItemPointSubscribeParameters72
            Me.PointBinding36.ValueTarget.TargetComponent = Me.switchPanel1
            Me.PointBinding36.ValueTarget.TargetPath = "Value"
            '
            'PointBinding37
            '
            Me.PointBinding37.ArgumentsPath = "Value"
            Me.PointBinding37.BindingOperations = CType(((OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Read Or OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Write) _
                Or OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Subscribe), OpcLabs.BaseLib.LiveBinding.PointBindingOperations)
            DaItemPoint74.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Register_R8", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Register_R8"}))
            DaItemPoint74.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding37.Point = DaItemPoint74
            Me.PointBinding37.ValueTarget.TargetComponent = Me.slider2
            Me.PointBinding37.ValueTarget.TargetPath = "Value"
            Me.PointBinding37.WriteEventSource.SourceComponent = Me.slider2
            Me.PointBinding37.WriteEventSource.SourcePath = "ValueChanged"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 570)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.tabControl1)
            Me.Name = "Form1"
            Me.Text = "Demo with Instrumentation Controls"
            CType(Me.bindingExtender1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControl1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            Me.tabPage1.PerformLayout()
            Me.tabPage2.ResumeLayout(False)
            Me.tabPage2.PerformLayout()
            Me.tabPage3.ResumeLayout(False)
            Me.tabPage3.PerformLayout()
            CType(Me.DaConnectivity1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

        Private bindingExtender1 As OpcLabs.BaseLib.LiveBinding.BindingExtender
		Private tabControl1 As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private tabPage2 As System.Windows.Forms.TabPage
		Private tabPage3 As System.Windows.Forms.TabPage
		Private sevenSegmentClockSmpte1 As Iocomp.Instrumentation.Professional.SevenSegmentClockSmpte
		Private clockAnalog1 As Iocomp.Instrumentation.Professional.ClockAnalog
		Private switchLever1 As Iocomp.Instrumentation.Professional.SwitchLever
		Private gaugeTube1 As Iocomp.Instrumentation.Professional.GaugeTube
		Private switchRocker1 As Iocomp.Instrumentation.Professional.SwitchRocker
		Private compass1 As Iocomp.Instrumentation.Professional.Compass
		Private valve1 As Iocomp.Instrumentation.Professional.Valve
		Private slidingScale1 As Iocomp.Instrumentation.Professional.SlidingScale
		Private tank1 As Iocomp.Instrumentation.Professional.Tank
		Private lcdMatrix1 As Iocomp.Instrumentation.Professional.LcdMatrix
		Private slidingCompass1 As Iocomp.Instrumentation.Professional.SlidingCompass
		Private ledArrow1 As Iocomp.Instrumentation.Professional.LedArrow
		Private switchPanel1 As Iocomp.Instrumentation.Standard.SwitchPanel
		Private ledBar1 As Iocomp.Instrumentation.Standard.LedBar
		Private sevenSegmentHexadecimal1 As Iocomp.Instrumentation.Standard.SevenSegmentHexadecimal
		Private editString1 As Iocomp.Instrumentation.Standard.EditString
		Private gaugeAngular1 As Iocomp.Instrumentation.Standard.GaugeAngular
		Private editInteger1 As Iocomp.Instrumentation.Standard.EditInteger
		Private sevenSegmentClock1 As Iocomp.Instrumentation.Standard.SevenSegmentClock
		Private switchToggle1 As Iocomp.Instrumentation.Standard.SwitchToggle
		Private led1 As Iocomp.Instrumentation.Standard.Led
		Private thermometer1 As Iocomp.Instrumentation.Standard.Thermometer
		Private slider1 As Iocomp.Instrumentation.Standard.Slider
		Private switchSlider1 As Iocomp.Instrumentation.Standard.SwitchSlider
		Private odometer1 As Iocomp.Instrumentation.Standard.Odometer
		Private sevenSegmentInteger1 As Iocomp.Instrumentation.Standard.SevenSegmentInteger
		Private gaugeLinear1 As Iocomp.Instrumentation.Standard.GaugeLinear
		Private switchLed1 As Iocomp.Instrumentation.Standard.SwitchLed
		Private modeComboBox1 As Iocomp.Instrumentation.Standard.ModeComboBox
		Private sevenSegmentAnalog1 As Iocomp.Instrumentation.Standard.SevenSegmentAnalog
		Private displayInteger1 As Iocomp.Instrumentation.Standard.DisplayInteger
		Private displayDouble1 As Iocomp.Instrumentation.Standard.DisplayDouble
		Private switchRotary1 As Iocomp.Instrumentation.Standard.SwitchRotary
		Private ledSpiral1 As Iocomp.Instrumentation.Standard.LedSpiral
		Private editDouble1 As Iocomp.Instrumentation.Standard.EditDouble
		Private displayString1 As Iocomp.Instrumentation.Standard.DisplayString
        Private plotToolBarStandard1 As Iocomp.Instrumentation.Plotting.PlotToolBarStandard
		Private plotToolBarButton1 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton2 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton3 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton4 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton5 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton6 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton7 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton8 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton9 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton10 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton11 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton12 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton13 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton14 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton15 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton16 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton17 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton18 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton19 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton20 As Iocomp.Classes.PlotToolBarButton
		Private plotToolBarButton21 As Iocomp.Classes.PlotToolBarButton
		Private imageList1 As System.Windows.Forms.ImageList
		Private plot1 As Iocomp.Instrumentation.Plotting.Plot
		Private label1 As System.Windows.Forms.Label
		Private WithEvents easyDAClient1 As OpcLabs.EasyOpc.DataAccess.EasyDAClient
		Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
		Private slider2 As Iocomp.Instrumentation.Standard.Slider
        Friend WithEvents DaConnectivity1 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAConnectivity
        Friend WithEvents PointBinder1 As OpcLabs.BaseLib.LiveBinding.PointBinder
        Friend WithEvents PointBinding2 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding3 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding4 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding33 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding5 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding6 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding7 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding34 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding8 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding9 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding10 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding35 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding11 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding12 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding13 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding14 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding15 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding16 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding17 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding18 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding19 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding20 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding36 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding1 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding21 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding31 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding22 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding23 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding24 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding25 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding32 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding26 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding27 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding28 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding29 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding30 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding37 As OpcLabs.BaseLib.LiveBinding.PointBinding

	End Class
End Namespace

