Imports JetBrains.Annotations

Namespace LiveBindingDemo
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
            Dim DaItemPoint1 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters1 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint2 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters2 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint3 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters3 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint4 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters4 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint5 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters5 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint6 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters6 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint7 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters7 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint8 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters8 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint9 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters9 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint10 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters10 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
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
            Dim DaItemPoint21 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters21 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint22 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters22 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint23 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters23 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint24 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters24 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint25 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters25 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint26 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters26 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint27 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters27 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint28 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters28 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint29 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters29 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint30 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters30 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaItemPoint31 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint()
            Dim DaItemPointSubscribeParameters31 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters()
            Dim DaPropertyPoint1 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAPropertyPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAPropertyPoint()
            Dim DaPropertyPoint2 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAPropertyPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAPropertyPoint()
            Dim DaPropertyPoint3 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAPropertyPoint = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAPropertyPoint()
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.tabControl1 = New System.Windows.Forms.TabControl()
            Me.tabPage1 = New System.Windows.Forms.TabPage()
            Me.richTextBox2 = New System.Windows.Forms.RichTextBox()
            Me.groupBox5 = New System.Windows.Forms.GroupBox()
            Me.textBox11 = New System.Windows.Forms.TextBox()
            Me.readOnCustomEventLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.textBox8 = New System.Windows.Forms.TextBox()
            Me.readButton = New System.Windows.Forms.Button()
            Me.groupBox4 = New System.Windows.Forms.GroupBox()
            Me.automaticReadLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.textBox5 = New System.Windows.Forms.TextBox()
            Me.textBox9 = New System.Windows.Forms.TextBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.automaticSubscriptionLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.label3 = New System.Windows.Forms.Label()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.trackBar1 = New System.Windows.Forms.TrackBar()
            Me.progressBar1 = New System.Windows.Forms.ProgressBar()
            Me.label2 = New System.Windows.Forms.Label()
            Me.textBox7 = New System.Windows.Forms.TextBox()
            Me.textBox6 = New System.Windows.Forms.TextBox()
            Me.tabPage4 = New System.Windows.Forms.TabPage()
            Me.groupBox10 = New System.Windows.Forms.GroupBox()
            Me.textBox13 = New System.Windows.Forms.TextBox()
            Me.errorProviderLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.textBox12 = New System.Windows.Forms.TextBox()
            Me.groupBox9 = New System.Windows.Forms.GroupBox()
            Me.changeBackgroundLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.textBox25 = New System.Windows.Forms.TextBox()
            Me.textBox22 = New System.Windows.Forms.TextBox()
            Me.groupBox8 = New System.Windows.Forms.GroupBox()
            Me.extendersLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.textBox26 = New System.Windows.Forms.TextBox()
            Me.textBox23 = New System.Windows.Forms.TextBox()
            Me.groupBox7 = New System.Windows.Forms.GroupBox()
            Me.bindingKindsLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.label14 = New System.Windows.Forms.Label()
            Me.label13 = New System.Windows.Forms.Label()
            Me.label12 = New System.Windows.Forms.Label()
            Me.textBox21 = New System.Windows.Forms.TextBox()
            Me.textBox20 = New System.Windows.Forms.TextBox()
            Me.label11 = New System.Windows.Forms.Label()
            Me.textBox19 = New System.Windows.Forms.TextBox()
            Me.label10 = New System.Windows.Forms.Label()
            Me.textBox18 = New System.Windows.Forms.TextBox()
            Me.label9 = New System.Windows.Forms.Label()
            Me.textBox17 = New System.Windows.Forms.TextBox()
            Me.textBox16 = New System.Windows.Forms.TextBox()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.textBox15 = New System.Windows.Forms.TextBox()
            Me.textBox14 = New System.Windows.Forms.TextBox()
            Me.groupBox6 = New System.Windows.Forms.GroupBox()
            Me.stringFormattingLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.textBox24 = New System.Windows.Forms.TextBox()
            Me.textBox10 = New System.Windows.Forms.TextBox()
            Me.tabPage2 = New System.Windows.Forms.TabPage()
            Me.groupBox14 = New System.Windows.Forms.GroupBox()
            Me.textBox27 = New System.Windows.Forms.TextBox()
            Me.subscribeAndWriteLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.subscribeAndWriteNumericUpDown = New System.Windows.Forms.NumericUpDown()
            Me.subscribeAndWriteTrackBar = New System.Windows.Forms.TrackBar()
            Me.groupBox13 = New System.Windows.Forms.GroupBox()
            Me.textBox36 = New System.Windows.Forms.TextBox()
            Me.tryWriteButton = New System.Windows.Forms.Button()
            Me.textBox37 = New System.Windows.Forms.TextBox()
            Me.displayWriteErrorsLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.groupBox12 = New System.Windows.Forms.GroupBox()
            Me.textBox35 = New System.Windows.Forms.TextBox()
            Me.textBox34 = New System.Windows.Forms.TextBox()
            Me.textBox32 = New System.Windows.Forms.TextBox()
            Me.writeGroupLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.textBox33 = New System.Windows.Forms.TextBox()
            Me.textBox31 = New System.Windows.Forms.TextBox()
            Me.writeGroupButton = New System.Windows.Forms.Button()
            Me.groupBox11 = New System.Windows.Forms.GroupBox()
            Me.textBox30 = New System.Windows.Forms.TextBox()
            Me.writeSingleLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.textBox29 = New System.Windows.Forms.TextBox()
            Me.writeButton = New System.Windows.Forms.Button()
            Me.textBox28 = New System.Windows.Forms.TextBox()
            Me.richTextBox4 = New System.Windows.Forms.RichTextBox()
            Me.tabPage3 = New System.Windows.Forms.TabPage()
            Me.richTextBox3 = New System.Windows.Forms.RichTextBox()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.automaticGetLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.textBox4 = New System.Windows.Forms.TextBox()
            Me.textBox3 = New System.Windows.Forms.TextBox()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.getOnEventLinkLabel = New System.Windows.Forms.LinkLabel()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.getButton = New System.Windows.Forms.Button()
            Me.bindingExtender1 = New OpcLabs.BaseLib.LiveBinding.BindingExtender(Me.components)
            Me.PointBinding1 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding2 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.AutoReadBindingGroup = New OpcLabs.BaseLib.LiveBinding.PointBindingGroup()
            Me.PointBinding3 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding4 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding5 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding6 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding7 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding8 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding9 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.PointBinding10 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding11 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.statusToColorConverter1 = New OpcLabs.BaseLib.Components.StatusToColorConverter(Me.components)
            Me.PointBinding12 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding13 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
            Me.TryWriteBindingGroup = New OpcLabs.BaseLib.LiveBinding.PointBindingGroup()
            Me.PointBinding25 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding26 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding27 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding28 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.WriteBindingGroup = New OpcLabs.BaseLib.LiveBinding.PointBindingGroup()
            Me.PointBinding29 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding30 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding31 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding32 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding33 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.PointBinding34 = New OpcLabs.BaseLib.LiveBinding.PointBinding(Me.components)
            Me.helpRichTextBox = New System.Windows.Forms.RichTextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.DaConnectivity1 = New OpcLabs.EasyOpc.DataAccess.Connectivity.DAConnectivity(Me.components)
            Me.PointBinder1 = New OpcLabs.BaseLib.LiveBinding.PointBinder(Me.components)
            Me.tabControl1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            Me.groupBox5.SuspendLayout()
            Me.groupBox4.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage4.SuspendLayout()
            Me.groupBox10.SuspendLayout()
            Me.groupBox9.SuspendLayout()
            Me.groupBox8.SuspendLayout()
            Me.groupBox7.SuspendLayout()
            Me.groupBox6.SuspendLayout()
            Me.tabPage2.SuspendLayout()
            Me.groupBox14.SuspendLayout()
            CType(Me.subscribeAndWriteNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.subscribeAndWriteTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox13.SuspendLayout()
            Me.groupBox12.SuspendLayout()
            Me.groupBox11.SuspendLayout()
            Me.tabPage3.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            CType(Me.bindingExtender1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DaConnectivity1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'richTextBox1
            '
            Me.richTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.richTextBox1.Location = New System.Drawing.Point(12, 12)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(760, 39)
            Me.richTextBox1.TabIndex = 49
            Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
            '
            'tabControl1
            '
            Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabControl1.Controls.Add(Me.tabPage1)
            Me.tabControl1.Controls.Add(Me.tabPage4)
            Me.tabControl1.Controls.Add(Me.tabPage2)
            Me.tabControl1.Controls.Add(Me.tabPage3)
            Me.tabControl1.Location = New System.Drawing.Point(12, 57)
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(760, 390)
            Me.tabControl1.TabIndex = 50
            '
            'tabPage1
            '
            Me.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.tabPage1.Controls.Add(Me.richTextBox2)
            Me.tabPage1.Controls.Add(Me.groupBox5)
            Me.tabPage1.Controls.Add(Me.groupBox4)
            Me.tabPage1.Controls.Add(Me.groupBox1)
            Me.tabPage1.Location = New System.Drawing.Point(4, 22)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage1.Size = New System.Drawing.Size(752, 364)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "Subscriptions and Reading"
            Me.tabPage1.UseVisualStyleBackColor = True
            '
            'richTextBox2
            '
            Me.richTextBox2.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox2.Location = New System.Drawing.Point(6, 298)
            Me.richTextBox2.Name = "richTextBox2"
            Me.richTextBox2.Size = New System.Drawing.Size(740, 60)
            Me.richTextBox2.TabIndex = 8
            Me.richTextBox2.Text = resources.GetString("richTextBox2.Text")
            '
            'groupBox5
            '
            Me.groupBox5.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox5.Controls.Add(Me.textBox11)
            Me.groupBox5.Controls.Add(Me.readOnCustomEventLinkLabel)
            Me.groupBox5.Controls.Add(Me.textBox8)
            Me.groupBox5.Controls.Add(Me.readButton)
            Me.groupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox5.Location = New System.Drawing.Point(416, 158)
            Me.groupBox5.Name = "groupBox5"
            Me.groupBox5.Size = New System.Drawing.Size(279, 96)
            Me.groupBox5.TabIndex = 7
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "Read On Custom Event"
            '
            'textBox11
            '
            Me.textBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox11.BackColor = System.Drawing.Color.LightBlue
            Me.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox11.Location = New System.Drawing.Point(6, 19)
            Me.textBox11.Multiline = True
            Me.textBox11.Name = "textBox11"
            Me.textBox11.Size = New System.Drawing.Size(267, 29)
            Me.textBox11.TabIndex = 5
            Me.textBox11.Text = "Clicking the Read button will execute the operation and read the OPC item value i" &
    "nto the text box."
            '
            'readOnCustomEventLinkLabel
            '
            Me.readOnCustomEventLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.readOnCustomEventLinkLabel.AutoSize = True
            Me.readOnCustomEventLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.readOnCustomEventLinkLabel.Location = New System.Drawing.Point(238, 63)
            Me.readOnCustomEventLinkLabel.Name = "readOnCustomEventLinkLabel"
            Me.readOnCustomEventLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.readOnCustomEventLinkLabel.TabIndex = 2
            Me.readOnCustomEventLinkLabel.TabStop = True
            Me.readOnCustomEventLinkLabel.Text = "How?"
            '
            'textBox8
            '
            Me.textBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox8, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding1, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox8.Location = New System.Drawing.Point(88, 60)
            Me.textBox8.Name = "textBox8"
            Me.textBox8.ReadOnly = True
            Me.textBox8.Size = New System.Drawing.Size(100, 20)
            Me.textBox8.TabIndex = 1
            '
            'readButton
            '
            Me.readButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.readButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.readButton.Location = New System.Drawing.Point(6, 58)
            Me.readButton.Name = "readButton"
            Me.readButton.Size = New System.Drawing.Size(75, 23)
            Me.readButton.TabIndex = 0
            Me.readButton.Text = "Read"
            Me.readButton.UseVisualStyleBackColor = True
            '
            'groupBox4
            '
            Me.groupBox4.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox4.Controls.Add(Me.automaticReadLinkLabel)
            Me.groupBox4.Controls.Add(Me.textBox5)
            Me.groupBox4.Controls.Add(Me.textBox9)
            Me.groupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox4.Location = New System.Drawing.Point(416, 32)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Size = New System.Drawing.Size(279, 93)
            Me.groupBox4.TabIndex = 6
            Me.groupBox4.TabStop = False
            Me.groupBox4.Text = "Automatic Read (On Form Load)"
            '
            'automaticReadLinkLabel
            '
            Me.automaticReadLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.automaticReadLinkLabel.AutoSize = True
            Me.automaticReadLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.automaticReadLinkLabel.Location = New System.Drawing.Point(238, 61)
            Me.automaticReadLinkLabel.Name = "automaticReadLinkLabel"
            Me.automaticReadLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.automaticReadLinkLabel.TabIndex = 10
            Me.automaticReadLinkLabel.TabStop = True
            Me.automaticReadLinkLabel.Text = "How?"
            '
            'textBox5
            '
            Me.textBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox5.BackColor = System.Drawing.Color.LightBlue
            Me.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox5.Location = New System.Drawing.Point(6, 19)
            Me.textBox5.Multiline = True
            Me.textBox5.Name = "textBox5"
            Me.textBox5.Size = New System.Drawing.Size(267, 33)
            Me.textBox5.TabIndex = 4
            Me.textBox5.Text = "OPC item values can be also read once, when the form loads."
            '
            'textBox9
            '
            Me.textBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox9, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding2, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox9.Location = New System.Drawing.Point(88, 58)
            Me.textBox9.Name = "textBox9"
            Me.textBox9.ReadOnly = True
            Me.textBox9.Size = New System.Drawing.Size(100, 20)
            Me.textBox9.TabIndex = 0
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox1.Controls.Add(Me.label8)
            Me.groupBox1.Controls.Add(Me.label7)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.automaticSubscriptionLinkLabel)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.checkBox1)
            Me.groupBox1.Controls.Add(Me.trackBar1)
            Me.groupBox1.Controls.Add(Me.progressBar1)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.textBox7)
            Me.groupBox1.Controls.Add(Me.textBox6)
            Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(72, 41)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(280, 213)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Automatic Subscription (With The Form)"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.Location = New System.Drawing.Point(6, 194)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(234, 13)
            Me.label8.TabIndex = 13
            Me.label8.Text = "You can also bind to some methods and events."
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.Location = New System.Drawing.Point(6, 177)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(180, 13)
            Me.label7.TabIndex = 12
            Me.label7.Text = "You can bind to any property or field."
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(6, 160)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(260, 13)
            Me.label4.TabIndex = 11
            Me.label4.Text = "You can bind to all types of components and controls."
            '
            'automaticSubscriptionLinkLabel
            '
            Me.automaticSubscriptionLinkLabel.AutoSize = True
            Me.automaticSubscriptionLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.automaticSubscriptionLinkLabel.Location = New System.Drawing.Point(236, 61)
            Me.automaticSubscriptionLinkLabel.Name = "automaticSubscriptionLinkLabel"
            Me.automaticSubscriptionLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.automaticSubscriptionLinkLabel.TabIndex = 10
            Me.automaticSubscriptionLinkLabel.TabStop = True
            Me.automaticSubscriptionLinkLabel.Text = "How?"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.bindingExtender1.SetBindingBag(Me.label3, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding3, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(114, 61)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(43, 13)
            Me.label3.TabIndex = 9
            Me.label3.Text = "Sunday"
            '
            'checkBox1
            '
            Me.checkBox1.AutoCheck = False
            Me.checkBox1.AutoSize = True
            Me.bindingExtender1.SetBindingBag(Me.checkBox1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding4, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(207, 61)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(15, 14)
            Me.checkBox1.TabIndex = 8
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'trackBar1
            '
            Me.bindingExtender1.SetBindingBag(Me.trackBar1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding5, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.trackBar1.Enabled = False
            Me.trackBar1.LargeChange = 50
            Me.trackBar1.Location = New System.Drawing.Point(7, 116)
            Me.trackBar1.Maximum = 100
            Me.trackBar1.Name = "trackBar1"
            Me.trackBar1.Size = New System.Drawing.Size(264, 45)
            Me.trackBar1.SmallChange = 10
            Me.trackBar1.TabIndex = 7
            Me.trackBar1.TickFrequency = 10
            '
            'progressBar1
            '
            Me.bindingExtender1.SetBindingBag(Me.progressBar1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding6, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.progressBar1.Location = New System.Drawing.Point(7, 87)
            Me.progressBar1.Name = "progressBar1"
            Me.progressBar1.Size = New System.Drawing.Size(264, 23)
            Me.progressBar1.TabIndex = 6
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(113, 64)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(0, 13)
            Me.label2.TabIndex = 5
            '
            'textBox7
            '
            Me.bindingExtender1.SetBindingBag(Me.textBox7, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding7, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox7.Location = New System.Drawing.Point(7, 61)
            Me.textBox7.Name = "textBox7"
            Me.textBox7.ReadOnly = True
            Me.textBox7.Size = New System.Drawing.Size(100, 20)
            Me.textBox7.TabIndex = 4
            '
            'textBox6
            '
            Me.textBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox6.BackColor = System.Drawing.Color.LightBlue
            Me.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox6.Location = New System.Drawing.Point(6, 19)
            Me.textBox6.Multiline = True
            Me.textBox6.Name = "textBox6"
            Me.textBox6.Size = New System.Drawing.Size(268, 35)
            Me.textBox6.TabIndex = 3
            Me.textBox6.Text = "This is the default behavior. The binding is online while the form is open."
            '
            'tabPage4
            '
            Me.tabPage4.Controls.Add(Me.groupBox10)
            Me.tabPage4.Controls.Add(Me.groupBox9)
            Me.tabPage4.Controls.Add(Me.groupBox8)
            Me.tabPage4.Controls.Add(Me.groupBox7)
            Me.tabPage4.Controls.Add(Me.groupBox6)
            Me.tabPage4.Location = New System.Drawing.Point(4, 22)
            Me.tabPage4.Name = "tabPage4"
            Me.tabPage4.Size = New System.Drawing.Size(752, 364)
            Me.tabPage4.TabIndex = 3
            Me.tabPage4.Text = "Flexibility"
            Me.tabPage4.UseVisualStyleBackColor = True
            '
            'groupBox10
            '
            Me.groupBox10.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox10.Controls.Add(Me.textBox13)
            Me.groupBox10.Controls.Add(Me.errorProviderLinkLabel)
            Me.groupBox10.Controls.Add(Me.textBox12)
            Me.groupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox10.Location = New System.Drawing.Point(416, 14)
            Me.groupBox10.Name = "groupBox10"
            Me.groupBox10.Size = New System.Drawing.Size(279, 93)
            Me.groupBox10.TabIndex = 16
            Me.groupBox10.TabStop = False
            Me.groupBox10.Text = "Display Errors with ErrorProvider"
            '
            'textBox13
            '
            Me.textBox13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox13.BackColor = System.Drawing.Color.LightBlue
            Me.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox13.Location = New System.Drawing.Point(6, 21)
            Me.textBox13.Multiline = True
            Me.textBox13.Name = "textBox13"
            Me.textBox13.Size = New System.Drawing.Size(267, 33)
            Me.textBox13.TabIndex = 5
            Me.textBox13.Text = "The standard ErrorProvider extender is useful for displaying OPC operation error " &
    "icons, with tooltips."
            '
            'errorProviderLinkLabel
            '
            Me.errorProviderLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.errorProviderLinkLabel.AutoSize = True
            Me.errorProviderLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.errorProviderLinkLabel.Location = New System.Drawing.Point(238, 61)
            Me.errorProviderLinkLabel.Name = "errorProviderLinkLabel"
            Me.errorProviderLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.errorProviderLinkLabel.TabIndex = 1
            Me.errorProviderLinkLabel.TabStop = True
            Me.errorProviderLinkLabel.Text = "How?"
            '
            'textBox12
            '
            Me.textBox12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox12, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding8, OpcLabs.BaseLib.LiveBinding.IAbstractBinding), CType(Me.PointBinding9, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox12.Location = New System.Drawing.Point(6, 58)
            Me.textBox12.Name = "textBox12"
            Me.textBox12.ReadOnly = True
            Me.textBox12.Size = New System.Drawing.Size(100, 20)
            Me.textBox12.TabIndex = 0
            Me.textBox12.Text = "1"
            '
            'groupBox9
            '
            Me.groupBox9.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox9.Controls.Add(Me.changeBackgroundLinkLabel)
            Me.groupBox9.Controls.Add(Me.textBox25)
            Me.groupBox9.Controls.Add(Me.textBox22)
            Me.groupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox9.Location = New System.Drawing.Point(72, 118)
            Me.groupBox9.Name = "groupBox9"
            Me.groupBox9.Size = New System.Drawing.Size(279, 118)
            Me.groupBox9.TabIndex = 15
            Me.groupBox9.TabStop = False
            Me.groupBox9.Text = "Change Color According to Status"
            '
            'changeBackgroundLinkLabel
            '
            Me.changeBackgroundLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.changeBackgroundLinkLabel.AutoSize = True
            Me.changeBackgroundLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.changeBackgroundLinkLabel.Location = New System.Drawing.Point(238, 87)
            Me.changeBackgroundLinkLabel.Name = "changeBackgroundLinkLabel"
            Me.changeBackgroundLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.changeBackgroundLinkLabel.TabIndex = 18
            Me.changeBackgroundLinkLabel.TabStop = True
            Me.changeBackgroundLinkLabel.Text = "How?"
            '
            'textBox25
            '
            Me.textBox25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox25.BackColor = System.Drawing.Color.LightBlue
            Me.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox25.Location = New System.Drawing.Point(6, 17)
            Me.textBox25.Multiline = True
            Me.textBox25.Name = "textBox25"
            Me.textBox25.Size = New System.Drawing.Size(267, 57)
            Me.textBox25.TabIndex = 5
            Me.textBox25.Text = resources.GetString("textBox25.Text")
            '
            'textBox22
            '
            Me.textBox22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox22, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding10, OpcLabs.BaseLib.LiveBinding.IAbstractBinding), CType(Me.PointBinding11, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox22.Location = New System.Drawing.Point(6, 84)
            Me.textBox22.Name = "textBox22"
            Me.textBox22.ReadOnly = True
            Me.textBox22.Size = New System.Drawing.Size(100, 20)
            Me.textBox22.TabIndex = 1
            '
            'groupBox8
            '
            Me.groupBox8.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox8.Controls.Add(Me.extendersLinkLabel)
            Me.groupBox8.Controls.Add(Me.textBox26)
            Me.groupBox8.Controls.Add(Me.textBox23)
            Me.groupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox8.Location = New System.Drawing.Point(72, 249)
            Me.groupBox8.Name = "groupBox8"
            Me.groupBox8.Size = New System.Drawing.Size(279, 103)
            Me.groupBox8.TabIndex = 14
            Me.groupBox8.TabStop = False
            Me.groupBox8.Text = "ToolTip and Other Extenders"
            '
            'extendersLinkLabel
            '
            Me.extendersLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.extendersLinkLabel.AutoSize = True
            Me.extendersLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.extendersLinkLabel.Location = New System.Drawing.Point(238, 75)
            Me.extendersLinkLabel.Name = "extendersLinkLabel"
            Me.extendersLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.extendersLinkLabel.TabIndex = 18
            Me.extendersLinkLabel.TabStop = True
            Me.extendersLinkLabel.Text = "How?"
            '
            'textBox26
            '
            Me.textBox26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox26.BackColor = System.Drawing.Color.LightBlue
            Me.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox26.Location = New System.Drawing.Point(6, 16)
            Me.textBox26.Multiline = True
            Me.textBox26.Name = "textBox26"
            Me.textBox26.Size = New System.Drawing.Size(267, 47)
            Me.textBox26.TabIndex = 5
            Me.textBox26.Text = "You can bind to properties made available by extender providers, such as ToolTip." &
    " Hover over the box to see more details about the value!"
            '
            'textBox23
            '
            Me.textBox23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox23, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding12, OpcLabs.BaseLib.LiveBinding.IAbstractBinding), CType(Me.PointBinding13, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox23.Location = New System.Drawing.Point(6, 72)
            Me.textBox23.Name = "textBox23"
            Me.textBox23.ReadOnly = True
            Me.textBox23.Size = New System.Drawing.Size(100, 20)
            Me.textBox23.TabIndex = 2
            '
            'groupBox7
            '
            Me.groupBox7.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox7.Controls.Add(Me.bindingKindsLinkLabel)
            Me.groupBox7.Controls.Add(Me.label14)
            Me.groupBox7.Controls.Add(Me.label13)
            Me.groupBox7.Controls.Add(Me.label12)
            Me.groupBox7.Controls.Add(Me.textBox21)
            Me.groupBox7.Controls.Add(Me.textBox20)
            Me.groupBox7.Controls.Add(Me.label11)
            Me.groupBox7.Controls.Add(Me.textBox19)
            Me.groupBox7.Controls.Add(Me.label10)
            Me.groupBox7.Controls.Add(Me.textBox18)
            Me.groupBox7.Controls.Add(Me.label9)
            Me.groupBox7.Controls.Add(Me.textBox17)
            Me.groupBox7.Controls.Add(Me.textBox16)
            Me.groupBox7.Controls.Add(Me.label6)
            Me.groupBox7.Controls.Add(Me.label5)
            Me.groupBox7.Controls.Add(Me.textBox15)
            Me.groupBox7.Controls.Add(Me.textBox14)
            Me.groupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox7.Location = New System.Drawing.Point(416, 118)
            Me.groupBox7.Name = "groupBox7"
            Me.groupBox7.Size = New System.Drawing.Size(279, 234)
            Me.groupBox7.TabIndex = 13
            Me.groupBox7.TabStop = False
            Me.groupBox7.Text = "Various Kinds of Binding"
            '
            'bindingKindsLinkLabel
            '
            Me.bindingKindsLinkLabel.AutoSize = True
            Me.bindingKindsLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bindingKindsLinkLabel.Location = New System.Drawing.Point(241, 211)
            Me.bindingKindsLinkLabel.Name = "bindingKindsLinkLabel"
            Me.bindingKindsLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.bindingKindsLinkLabel.TabIndex = 18
            Me.bindingKindsLinkLabel.TabStop = True
            Me.bindingKindsLinkLabel.Text = "How?"
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label14.Location = New System.Drawing.Point(50, 181)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(58, 13)
            Me.label14.TabIndex = 17
            Me.label14.Text = "StatusInfo:"
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label13.Location = New System.Drawing.Point(32, 161)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(75, 13)
            Me.label13.TabIndex = 16
            Me.label13.Text = "ErrorMessage:"
            '
            'label12
            '
            Me.label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label12.Location = New System.Drawing.Point(6, 212)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(60, 13)
            Me.label12.TabIndex = 15
            Me.label12.Text = "and more..."
            '
            'textBox21
            '
            Me.bindingExtender1.SetBindingBag(Me.textBox21, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding14, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox21.Location = New System.Drawing.Point(113, 178)
            Me.textBox21.Name = "textBox21"
            Me.textBox21.ReadOnly = True
            Me.textBox21.Size = New System.Drawing.Size(160, 20)
            Me.textBox21.TabIndex = 14
            Me.textBox21.Text = "Normal"
            '
            'textBox20
            '
            Me.bindingExtender1.SetBindingBag(Me.textBox20, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding15, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox20.Location = New System.Drawing.Point(113, 158)
            Me.textBox20.Name = "textBox20"
            Me.textBox20.ReadOnly = True
            Me.textBox20.Size = New System.Drawing.Size(160, 20)
            Me.textBox20.TabIndex = 13
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label11.Location = New System.Drawing.Point(66, 141)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(41, 13)
            Me.label11.TabIndex = 12
            Me.label11.Text = "ErrorId:"
            '
            'textBox19
            '
            Me.bindingExtender1.SetBindingBag(Me.textBox19, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding16, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox19.Location = New System.Drawing.Point(113, 138)
            Me.textBox19.Name = "textBox19"
            Me.textBox19.ReadOnly = True
            Me.textBox19.Size = New System.Drawing.Size(160, 20)
            Me.textBox19.TabIndex = 11
            Me.textBox19.Text = "-1"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.Location = New System.Drawing.Point(80, 121)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(26, 13)
            Me.label10.TabIndex = 10
            Me.label10.Text = "Vtq:"
            '
            'textBox18
            '
            Me.bindingExtender1.SetBindingBag(Me.textBox18, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding17, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox18.Location = New System.Drawing.Point(113, 118)
            Me.textBox18.Name = "textBox18"
            Me.textBox18.ReadOnly = True
            Me.textBox18.Size = New System.Drawing.Size(160, 20)
            Me.textBox18.TabIndex = 9
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.Location = New System.Drawing.Point(64, 100)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(42, 13)
            Me.label9.TabIndex = 8
            Me.label9.Text = "Quality:"
            '
            'textBox17
            '
            Me.bindingExtender1.SetBindingBag(Me.textBox17, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding18, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox17.Location = New System.Drawing.Point(113, 98)
            Me.textBox17.Name = "textBox17"
            Me.textBox17.ReadOnly = True
            Me.textBox17.Size = New System.Drawing.Size(160, 20)
            Me.textBox17.TabIndex = 7
            Me.textBox17.Text = "Good GoodNonspecific LimitOk (192)"
            '
            'textBox16
            '
            Me.textBox16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox16.BackColor = System.Drawing.Color.LightBlue
            Me.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox16.Location = New System.Drawing.Point(6, 19)
            Me.textBox16.Multiline = True
            Me.textBox16.Name = "textBox16"
            Me.textBox16.Size = New System.Drawing.Size(267, 33)
            Me.textBox16.TabIndex = 6
            Me.textBox16.Text = "You normally bind to the OPC value itself, but you can select from many other bin" &
    "ding kinds."
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.Location = New System.Drawing.Point(45, 81)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(61, 13)
            Me.label6.TabIndex = 3
            Me.label6.Text = "Timestamp:"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(69, 61)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(37, 13)
            Me.label5.TabIndex = 2
            Me.label5.Text = "Value:"
            '
            'textBox15
            '
            Me.bindingExtender1.SetBindingBag(Me.textBox15, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding19, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox15.Location = New System.Drawing.Point(113, 78)
            Me.textBox15.Name = "textBox15"
            Me.textBox15.ReadOnly = True
            Me.textBox15.Size = New System.Drawing.Size(160, 20)
            Me.textBox15.TabIndex = 1
            '
            'textBox14
            '
            Me.bindingExtender1.SetBindingBag(Me.textBox14, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding20, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox14.Location = New System.Drawing.Point(113, 58)
            Me.textBox14.Name = "textBox14"
            Me.textBox14.ReadOnly = True
            Me.textBox14.Size = New System.Drawing.Size(160, 20)
            Me.textBox14.TabIndex = 0
            '
            'groupBox6
            '
            Me.groupBox6.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox6.Controls.Add(Me.stringFormattingLinkLabel)
            Me.groupBox6.Controls.Add(Me.textBox24)
            Me.groupBox6.Controls.Add(Me.textBox10)
            Me.groupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox6.Location = New System.Drawing.Point(72, 14)
            Me.groupBox6.Name = "groupBox6"
            Me.groupBox6.Size = New System.Drawing.Size(279, 93)
            Me.groupBox6.TabIndex = 12
            Me.groupBox6.TabStop = False
            Me.groupBox6.Text = "String Formatting"
            '
            'stringFormattingLinkLabel
            '
            Me.stringFormattingLinkLabel.AutoSize = True
            Me.stringFormattingLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.stringFormattingLinkLabel.Location = New System.Drawing.Point(238, 62)
            Me.stringFormattingLinkLabel.Name = "stringFormattingLinkLabel"
            Me.stringFormattingLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.stringFormattingLinkLabel.TabIndex = 18
            Me.stringFormattingLinkLabel.TabStop = True
            Me.stringFormattingLinkLabel.Text = "How?"
            '
            'textBox24
            '
            Me.textBox24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox24.BackColor = System.Drawing.Color.LightBlue
            Me.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox24.Location = New System.Drawing.Point(6, 19)
            Me.textBox24.Multiline = True
            Me.textBox24.Name = "textBox24"
            Me.textBox24.Size = New System.Drawing.Size(267, 33)
            Me.textBox24.TabIndex = 5
            Me.textBox24.Text = "All standard .NET formatting features can be used to specify how the OPC values s" &
    "hould be displayed."
            '
            'textBox10
            '
            Me.bindingExtender1.SetBindingBag(Me.textBox10, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding21, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox10.Location = New System.Drawing.Point(6, 59)
            Me.textBox10.Name = "textBox10"
            Me.textBox10.ReadOnly = True
            Me.textBox10.Size = New System.Drawing.Size(150, 20)
            Me.textBox10.TabIndex = 0
            '
            'tabPage2
            '
            Me.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.tabPage2.Controls.Add(Me.groupBox14)
            Me.tabPage2.Controls.Add(Me.groupBox13)
            Me.tabPage2.Controls.Add(Me.groupBox12)
            Me.tabPage2.Controls.Add(Me.groupBox11)
            Me.tabPage2.Controls.Add(Me.richTextBox4)
            Me.tabPage2.Location = New System.Drawing.Point(4, 22)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage2.Size = New System.Drawing.Size(752, 364)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "Writing"
            Me.tabPage2.UseVisualStyleBackColor = True
            '
            'groupBox14
            '
            Me.groupBox14.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox14.Controls.Add(Me.textBox27)
            Me.groupBox14.Controls.Add(Me.subscribeAndWriteLinkLabel)
            Me.groupBox14.Controls.Add(Me.subscribeAndWriteNumericUpDown)
            Me.groupBox14.Controls.Add(Me.subscribeAndWriteTrackBar)
            Me.groupBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox14.Location = New System.Drawing.Point(416, 17)
            Me.groupBox14.Name = "groupBox14"
            Me.groupBox14.Size = New System.Drawing.Size(279, 135)
            Me.groupBox14.TabIndex = 13
            Me.groupBox14.TabStop = False
            Me.groupBox14.Text = "Subscribe && Write"
            '
            'textBox27
            '
            Me.textBox27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox27.BackColor = System.Drawing.Color.LightBlue
            Me.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox27.Location = New System.Drawing.Point(6, 19)
            Me.textBox27.Multiline = True
            Me.textBox27.Name = "textBox27"
            Me.textBox27.Size = New System.Drawing.Size(267, 59)
            Me.textBox27.TabIndex = 6
            Me.textBox27.Text = resources.GetString("textBox27.Text")
            '
            'subscribeAndWriteLinkLabel
            '
            Me.subscribeAndWriteLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.subscribeAndWriteLinkLabel.AutoSize = True
            Me.subscribeAndWriteLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.subscribeAndWriteLinkLabel.Location = New System.Drawing.Point(238, 101)
            Me.subscribeAndWriteLinkLabel.Name = "subscribeAndWriteLinkLabel"
            Me.subscribeAndWriteLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.subscribeAndWriteLinkLabel.TabIndex = 2
            Me.subscribeAndWriteLinkLabel.TabStop = True
            Me.subscribeAndWriteLinkLabel.Text = "How?"
            '
            'subscribeAndWriteNumericUpDown
            '
            Me.subscribeAndWriteNumericUpDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.subscribeAndWriteNumericUpDown, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding22, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.subscribeAndWriteNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.subscribeAndWriteNumericUpDown.Location = New System.Drawing.Point(131, 84)
            Me.subscribeAndWriteNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.subscribeAndWriteNumericUpDown.Name = "subscribeAndWriteNumericUpDown"
            Me.subscribeAndWriteNumericUpDown.Size = New System.Drawing.Size(59, 20)
            Me.subscribeAndWriteNumericUpDown.TabIndex = 1
            '
            'subscribeAndWriteTrackBar
            '
            Me.subscribeAndWriteTrackBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.subscribeAndWriteTrackBar, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding23, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.subscribeAndWriteTrackBar.LargeChange = 3
            Me.subscribeAndWriteTrackBar.Location = New System.Drawing.Point(6, 84)
            Me.subscribeAndWriteTrackBar.Name = "subscribeAndWriteTrackBar"
            Me.subscribeAndWriteTrackBar.Size = New System.Drawing.Size(119, 45)
            Me.subscribeAndWriteTrackBar.TabIndex = 0
            '
            'groupBox13
            '
            Me.groupBox13.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox13.Controls.Add(Me.textBox36)
            Me.groupBox13.Controls.Add(Me.tryWriteButton)
            Me.groupBox13.Controls.Add(Me.textBox37)
            Me.groupBox13.Controls.Add(Me.displayWriteErrorsLinkLabel)
            Me.groupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox13.Location = New System.Drawing.Point(416, 158)
            Me.groupBox13.Name = "groupBox13"
            Me.groupBox13.Size = New System.Drawing.Size(279, 134)
            Me.groupBox13.TabIndex = 12
            Me.groupBox13.TabStop = False
            Me.groupBox13.Text = "Display Write Errors"
            '
            'textBox36
            '
            Me.textBox36.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox36.BackColor = System.Drawing.Color.LightBlue
            Me.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox36.Location = New System.Drawing.Point(6, 19)
            Me.textBox36.Multiline = True
            Me.textBox36.Name = "textBox36"
            Me.textBox36.Size = New System.Drawing.Size(267, 71)
            Me.textBox36.TabIndex = 6
            Me.textBox36.Text = resources.GetString("textBox36.Text")
            '
            'tryWriteButton
            '
            Me.tryWriteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.tryWriteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tryWriteButton.Location = New System.Drawing.Point(72, 102)
            Me.tryWriteButton.Name = "tryWriteButton"
            Me.tryWriteButton.Size = New System.Drawing.Size(60, 23)
            Me.tryWriteButton.TabIndex = 1
            Me.tryWriteButton.Text = "Try Write"
            Me.tryWriteButton.UseVisualStyleBackColor = True
            '
            'textBox37
            '
            Me.textBox37.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox37, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding24, OpcLabs.BaseLib.LiveBinding.IAbstractBinding), CType(Me.PointBinding25, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox37.Location = New System.Drawing.Point(6, 104)
            Me.textBox37.Name = "textBox37"
            Me.textBox37.Size = New System.Drawing.Size(60, 20)
            Me.textBox37.TabIndex = 0
            Me.textBox37.Text = "999999"
            '
            'displayWriteErrorsLinkLabel
            '
            Me.displayWriteErrorsLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.displayWriteErrorsLinkLabel.AutoSize = True
            Me.displayWriteErrorsLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.displayWriteErrorsLinkLabel.Location = New System.Drawing.Point(238, 107)
            Me.displayWriteErrorsLinkLabel.Name = "displayWriteErrorsLinkLabel"
            Me.displayWriteErrorsLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.displayWriteErrorsLinkLabel.TabIndex = 3
            Me.displayWriteErrorsLinkLabel.TabStop = True
            Me.displayWriteErrorsLinkLabel.Text = "How?"
            '
            'groupBox12
            '
            Me.groupBox12.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox12.Controls.Add(Me.textBox35)
            Me.groupBox12.Controls.Add(Me.textBox34)
            Me.groupBox12.Controls.Add(Me.textBox32)
            Me.groupBox12.Controls.Add(Me.writeGroupLinkLabel)
            Me.groupBox12.Controls.Add(Me.textBox33)
            Me.groupBox12.Controls.Add(Me.textBox31)
            Me.groupBox12.Controls.Add(Me.writeGroupButton)
            Me.groupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox12.Location = New System.Drawing.Point(71, 146)
            Me.groupBox12.Name = "groupBox12"
            Me.groupBox12.Size = New System.Drawing.Size(279, 132)
            Me.groupBox12.TabIndex = 11
            Me.groupBox12.TabStop = False
            Me.groupBox12.Text = "Write Group of Values On Custom Event"
            '
            'textBox35
            '
            Me.textBox35.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox35.BackColor = System.Drawing.Color.LightBlue
            Me.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox35.Location = New System.Drawing.Point(6, 19)
            Me.textBox35.Multiline = True
            Me.textBox35.Name = "textBox35"
            Me.textBox35.Size = New System.Drawing.Size(267, 45)
            Me.textBox35.TabIndex = 6
            Me.textBox35.Text = "Multiple property values are gathered and written to their associated OPC items i" &
    "n a single operation, linked to a specified event - in our case, a button click." &
    ""
            '
            'textBox34
            '
            Me.textBox34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox34, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding26, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox34.Location = New System.Drawing.Point(138, 102)
            Me.textBox34.Name = "textBox34"
            Me.textBox34.ReadOnly = True
            Me.textBox34.Size = New System.Drawing.Size(80, 20)
            Me.textBox34.TabIndex = 2
            '
            'textBox32
            '
            Me.textBox32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox32, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding27, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox32.Location = New System.Drawing.Point(138, 76)
            Me.textBox32.Name = "textBox32"
            Me.textBox32.ReadOnly = True
            Me.textBox32.Size = New System.Drawing.Size(80, 20)
            Me.textBox32.TabIndex = 2
            '
            'writeGroupLinkLabel
            '
            Me.writeGroupLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.writeGroupLinkLabel.AutoSize = True
            Me.writeGroupLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.writeGroupLinkLabel.Location = New System.Drawing.Point(238, 109)
            Me.writeGroupLinkLabel.Name = "writeGroupLinkLabel"
            Me.writeGroupLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.writeGroupLinkLabel.TabIndex = 3
            Me.writeGroupLinkLabel.TabStop = True
            Me.writeGroupLinkLabel.Text = "How?"
            '
            'textBox33
            '
            Me.textBox33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox33, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding28, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox33.Location = New System.Drawing.Point(6, 102)
            Me.textBox33.Name = "textBox33"
            Me.textBox33.Size = New System.Drawing.Size(60, 20)
            Me.textBox33.TabIndex = 0
            Me.textBox33.Text = "34567"
            '
            'textBox31
            '
            Me.textBox31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox31, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding29, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox31.Location = New System.Drawing.Point(6, 76)
            Me.textBox31.Name = "textBox31"
            Me.textBox31.Size = New System.Drawing.Size(60, 20)
            Me.textBox31.TabIndex = 0
            Me.textBox31.Text = "23456"
            '
            'writeGroupButton
            '
            Me.writeGroupButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.writeGroupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.writeGroupButton.Location = New System.Drawing.Point(72, 74)
            Me.writeGroupButton.Name = "writeGroupButton"
            Me.writeGroupButton.Size = New System.Drawing.Size(60, 48)
            Me.writeGroupButton.TabIndex = 1
            Me.writeGroupButton.Text = "Write Group"
            Me.writeGroupButton.UseVisualStyleBackColor = True
            '
            'groupBox11
            '
            Me.groupBox11.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox11.Controls.Add(Me.textBox30)
            Me.groupBox11.Controls.Add(Me.writeSingleLinkLabel)
            Me.groupBox11.Controls.Add(Me.textBox29)
            Me.groupBox11.Controls.Add(Me.writeButton)
            Me.groupBox11.Controls.Add(Me.textBox28)
            Me.groupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox11.Location = New System.Drawing.Point(71, 17)
            Me.groupBox11.Name = "groupBox11"
            Me.groupBox11.Size = New System.Drawing.Size(279, 104)
            Me.groupBox11.TabIndex = 10
            Me.groupBox11.TabStop = False
            Me.groupBox11.Text = "Write Single Value On Custom Event"
            '
            'textBox30
            '
            Me.textBox30.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox30.BackColor = System.Drawing.Color.LightBlue
            Me.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox30.Location = New System.Drawing.Point(6, 19)
            Me.textBox30.Multiline = True
            Me.textBox30.Name = "textBox30"
            Me.textBox30.Size = New System.Drawing.Size(267, 43)
            Me.textBox30.TabIndex = 6
            Me.textBox30.Text = "A value of control property is written to the  associated OPC item when a specifi" &
    "ed event is triggered. In our example, we have linked the Write to the button cl" &
    "ick."
            '
            'writeSingleLinkLabel
            '
            Me.writeSingleLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.writeSingleLinkLabel.AutoSize = True
            Me.writeSingleLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.writeSingleLinkLabel.Location = New System.Drawing.Point(238, 76)
            Me.writeSingleLinkLabel.Name = "writeSingleLinkLabel"
            Me.writeSingleLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.writeSingleLinkLabel.TabIndex = 3
            Me.writeSingleLinkLabel.TabStop = True
            Me.writeSingleLinkLabel.Text = "How?"
            '
            'textBox29
            '
            Me.textBox29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox29, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding30, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox29.Location = New System.Drawing.Point(138, 73)
            Me.textBox29.Name = "textBox29"
            Me.textBox29.ReadOnly = True
            Me.textBox29.Size = New System.Drawing.Size(80, 20)
            Me.textBox29.TabIndex = 2
            '
            'writeButton
            '
            Me.writeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.writeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.writeButton.Location = New System.Drawing.Point(72, 71)
            Me.writeButton.Name = "writeButton"
            Me.writeButton.Size = New System.Drawing.Size(60, 23)
            Me.writeButton.TabIndex = 1
            Me.writeButton.Text = "Write"
            Me.writeButton.UseVisualStyleBackColor = True
            '
            'textBox28
            '
            Me.textBox28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox28, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding31, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox28.Location = New System.Drawing.Point(6, 73)
            Me.textBox28.Name = "textBox28"
            Me.textBox28.Size = New System.Drawing.Size(60, 20)
            Me.textBox28.TabIndex = 0
            Me.textBox28.Text = "12345"
            '
            'richTextBox4
            '
            Me.richTextBox4.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox4.Location = New System.Drawing.Point(6, 298)
            Me.richTextBox4.Name = "richTextBox4"
            Me.richTextBox4.Size = New System.Drawing.Size(740, 60)
            Me.richTextBox4.TabIndex = 9
            Me.richTextBox4.Text = resources.GetString("richTextBox4.Text")
            '
            'tabPage3
            '
            Me.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.tabPage3.Controls.Add(Me.richTextBox3)
            Me.tabPage3.Controls.Add(Me.groupBox3)
            Me.tabPage3.Controls.Add(Me.groupBox2)
            Me.tabPage3.Location = New System.Drawing.Point(4, 22)
            Me.tabPage3.Name = "tabPage3"
            Me.tabPage3.Size = New System.Drawing.Size(752, 364)
            Me.tabPage3.TabIndex = 2
            Me.tabPage3.Text = "Properties"
            Me.tabPage3.UseVisualStyleBackColor = True
            '
            'richTextBox3
            '
            Me.richTextBox3.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox3.Location = New System.Drawing.Point(3, 301)
            Me.richTextBox3.Name = "richTextBox3"
            Me.richTextBox3.Size = New System.Drawing.Size(746, 60)
            Me.richTextBox3.TabIndex = 4
            Me.richTextBox3.Text = resources.GetString("richTextBox3.Text")
            '
            'groupBox3
            '
            Me.groupBox3.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox3.Controls.Add(Me.automaticGetLinkLabel)
            Me.groupBox3.Controls.Add(Me.textBox4)
            Me.groupBox3.Controls.Add(Me.textBox3)
            Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox3.Location = New System.Drawing.Point(241, 159)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(249, 98)
            Me.groupBox3.TabIndex = 3
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Automatic Get (On Form Load)"
            '
            'automaticGetLinkLabel
            '
            Me.automaticGetLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.automaticGetLinkLabel.AutoSize = True
            Me.automaticGetLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.automaticGetLinkLabel.Location = New System.Drawing.Point(208, 73)
            Me.automaticGetLinkLabel.Name = "automaticGetLinkLabel"
            Me.automaticGetLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.automaticGetLinkLabel.TabIndex = 4
            Me.automaticGetLinkLabel.TabStop = True
            Me.automaticGetLinkLabel.Text = "How?"
            '
            'textBox4
            '
            Me.textBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox4, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding32, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox4.Location = New System.Drawing.Point(57, 72)
            Me.textBox4.Name = "textBox4"
            Me.textBox4.ReadOnly = True
            Me.textBox4.Size = New System.Drawing.Size(100, 20)
            Me.textBox4.TabIndex = 4
            Me.textBox4.Text = "-10"
            '
            'textBox3
            '
            Me.textBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox3.BackColor = System.Drawing.Color.LightBlue
            Me.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox3.Location = New System.Drawing.Point(6, 19)
            Me.textBox3.Multiline = True
            Me.textBox3.Name = "textBox3"
            Me.textBox3.Size = New System.Drawing.Size(237, 51)
            Me.textBox3.TabIndex = 3
            Me.textBox3.Text = "The OPC property value can also be obtained automatically when the form loads. He" &
    "re we are getting the LowEU property."
            '
            'groupBox2
            '
            Me.groupBox2.BackColor = System.Drawing.Color.LightBlue
            Me.groupBox2.Controls.Add(Me.getOnEventLinkLabel)
            Me.groupBox2.Controls.Add(Me.textBox2)
            Me.groupBox2.Controls.Add(Me.textBox1)
            Me.groupBox2.Controls.Add(Me.getButton)
            Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.Location = New System.Drawing.Point(241, 35)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(249, 88)
            Me.groupBox2.TabIndex = 2
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Get On Custom Event"
            '
            'getOnEventLinkLabel
            '
            Me.getOnEventLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.getOnEventLinkLabel.AutoSize = True
            Me.getOnEventLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.getOnEventLinkLabel.Location = New System.Drawing.Point(208, 62)
            Me.getOnEventLinkLabel.Name = "getOnEventLinkLabel"
            Me.getOnEventLinkLabel.Size = New System.Drawing.Size(35, 13)
            Me.getOnEventLinkLabel.TabIndex = 3
            Me.getOnEventLinkLabel.TabStop = True
            Me.getOnEventLinkLabel.Text = "How?"
            '
            'textBox2
            '
            Me.textBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox2.BackColor = System.Drawing.Color.LightBlue
            Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox2.Location = New System.Drawing.Point(6, 19)
            Me.textBox2.Multiline = True
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(237, 35)
            Me.textBox2.TabIndex = 2
            Me.textBox2.Text = "You can bind to OPC properties as well. Clicking on the Get button obtains the Hi" &
    "ghEU property."
            '
            'textBox1
            '
            Me.textBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.bindingExtender1.SetBindingBag(Me.textBox1, New OpcLabs.BaseLib.LiveBinding.BindingBag(New OpcLabs.BaseLib.LiveBinding.IAbstractBinding() {CType(Me.PointBinding33, OpcLabs.BaseLib.LiveBinding.IAbstractBinding), CType(Me.PointBinding34, OpcLabs.BaseLib.LiveBinding.IAbstractBinding)}))
            Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox1.Location = New System.Drawing.Point(88, 59)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(100, 20)
            Me.textBox1.TabIndex = 1
            '
            'getButton
            '
            Me.getButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.getButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.getButton.Location = New System.Drawing.Point(7, 59)
            Me.getButton.Name = "getButton"
            Me.getButton.Size = New System.Drawing.Size(75, 23)
            Me.getButton.TabIndex = 0
            Me.getButton.Text = "Get"
            Me.getButton.UseVisualStyleBackColor = True
            '
            'bindingExtender1
            '
            Me.bindingExtender1.OfflineEventSource.SourceComponent = Me
            Me.bindingExtender1.OfflineEventSource.SourcePath = "FormClosing"
            Me.bindingExtender1.OnlineEventSource.SourceComponent = Me
            Me.bindingExtender1.OnlineEventSource.SourcePath = "Shown"
            '
            'PointBinding1
            '
            Me.PointBinding1.ArgumentsPath = "Value"
            Me.PointBinding1.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Read
            DaItemPoint1.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint1.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding1.Point = DaItemPoint1
            Me.PointBinding1.ReadEventSource.SourceComponent = Me.readButton
            Me.PointBinding1.ReadEventSource.SourcePath = "Click"
            DaItemPointSubscribeParameters1.RequestedUpdateRate = 100
            Me.PointBinding1.SubscribeParameters = DaItemPointSubscribeParameters1
            Me.PointBinding1.ValueTarget.TargetComponent = Me.textBox8
            Me.PointBinding1.ValueTarget.TargetPath = "Text"
            '
            'PointBinding2
            '
            Me.PointBinding2.ArgumentsPath = "Value"
            Me.PointBinding2.BindingGroup = Me.AutoReadBindingGroup
            DaItemPoint2.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint2.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding2.Point = DaItemPoint2
            DaItemPointSubscribeParameters2.RequestedUpdateRate = 100
            Me.PointBinding2.SubscribeParameters = DaItemPointSubscribeParameters2
            Me.PointBinding2.ValueTarget.TargetComponent = Me.textBox9
            Me.PointBinding2.ValueTarget.TargetPath = "Text"
            '
            'AutoReadBindingGroup
            '
            Me.AutoReadBindingGroup.AutoRead = True
            Me.AutoReadBindingGroup.AutoSubscribe = False
            '
            'PointBinding3
            '
            Me.PointBinding3.ArgumentsPath = "Value"
            DaItemPoint3.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Weekdays (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Weekdays (10 s)"}))
            DaItemPoint3.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding3.Point = DaItemPoint3
            DaItemPointSubscribeParameters3.RequestedUpdateRate = 100
            Me.PointBinding3.SubscribeParameters = DaItemPointSubscribeParameters3
            Me.PointBinding3.ValueTarget.TargetComponent = Me.label3
            Me.PointBinding3.ValueTarget.TargetPath = "Text"
            '
            'PointBinding4
            '
            Me.PointBinding4.ArgumentsPath = "Value"
            DaItemPoint4.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.OnOff (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "OnOff (10 s)"}))
            DaItemPoint4.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding4.Point = DaItemPoint4
            DaItemPointSubscribeParameters4.RequestedUpdateRate = 100
            Me.PointBinding4.SubscribeParameters = DaItemPointSubscribeParameters4
            Me.PointBinding4.ValueTarget.TargetComponent = Me.checkBox1
            Me.PointBinding4.ValueTarget.TargetPath = "Checked"
            '
            'PointBinding5
            '
            Me.PointBinding5.ArgumentsPath = "Value"
            DaItemPoint5.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}), New OpcLabs.BaseLib.ComInterop.VarType(3))
            DaItemPoint5.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding5.Point = DaItemPoint5
            DaItemPointSubscribeParameters5.RequestedUpdateRate = 100
            Me.PointBinding5.SubscribeParameters = DaItemPointSubscribeParameters5
            Me.PointBinding5.ValueTarget.TargetComponent = Me.trackBar1
            Me.PointBinding5.ValueTarget.TargetPath = "Value"
            '
            'PointBinding6
            '
            Me.PointBinding6.ArgumentsPath = "Value"
            DaItemPoint6.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}), New OpcLabs.BaseLib.ComInterop.VarType(3))
            DaItemPoint6.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding6.Point = DaItemPoint6
            DaItemPointSubscribeParameters6.RequestedUpdateRate = 100
            Me.PointBinding6.SubscribeParameters = DaItemPointSubscribeParameters6
            Me.PointBinding6.ValueTarget.TargetComponent = Me.progressBar1
            Me.PointBinding6.ValueTarget.TargetPath = "Value"
            '
            'PointBinding7
            '
            Me.PointBinding7.ArgumentsPath = "Value"
            DaItemPoint7.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint7.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding7.Point = DaItemPoint7
            DaItemPointSubscribeParameters7.RequestedUpdateRate = 100
            Me.PointBinding7.SubscribeParameters = DaItemPointSubscribeParameters7
            Me.PointBinding7.ValueTarget.TargetComponent = Me.textBox7
            Me.PointBinding7.ValueTarget.TargetPath = "Text"
            '
            'PointBinding8
            '
            Me.PointBinding8.ArgumentsPath = "Value"
            DaItemPoint8.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.AlternatingError (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "AlternatingError (10 s)"}))
            DaItemPoint8.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding8.Point = DaItemPoint8
            DaItemPointSubscribeParameters8.RequestedUpdateRate = 100
            Me.PointBinding8.SubscribeParameters = DaItemPointSubscribeParameters8
            Me.PointBinding8.ValueTarget.TargetComponent = Me.textBox12
            Me.PointBinding8.ValueTarget.TargetPath = "Text"
            '
            'PointBinding9
            '
            Me.PointBinding9.ArgumentsPath = "ErrorMessage"
            DaItemPoint9.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.AlternatingError (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "AlternatingError (10 s)"}))
            DaItemPoint9.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding9.Point = DaItemPoint9
            DaItemPointSubscribeParameters9.RequestedUpdateRate = 100
            Me.PointBinding9.SubscribeParameters = DaItemPointSubscribeParameters9
            Me.PointBinding9.ValueTarget.ExtenderProvider = Me.errorProvider1
            Me.PointBinding9.ValueTarget.TargetComponent = Me.textBox12
            Me.PointBinding9.ValueTarget.TargetPath = "Error"
            '
            'errorProvider1
            '
            Me.errorProvider1.ContainerControl = Me
            '
            'PointBinding10
            '
            Me.PointBinding10.ArgumentsPath = "Value"
            DaItemPoint10.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.AlternatingQuality Uncertain (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "AlternatingQuality Uncertain (10 s)"}))
            DaItemPoint10.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding10.Point = DaItemPoint10
            DaItemPointSubscribeParameters10.RequestedUpdateRate = 100
            Me.PointBinding10.SubscribeParameters = DaItemPointSubscribeParameters10
            Me.PointBinding10.ValueTarget.TargetComponent = Me.textBox22
            Me.PointBinding10.ValueTarget.TargetPath = "Text"
            '
            'PointBinding11
            '
            Me.PointBinding11.ArgumentsPath = "StatusInfo"
            Me.PointBinding11.Converter = Me.statusToColorConverter1
            DaItemPoint11.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.AlternatingQuality Uncertain (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "AlternatingQuality Uncertain (10 s)"}))
            DaItemPoint11.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding11.Point = DaItemPoint11
            DaItemPointSubscribeParameters11.RequestedUpdateRate = 100
            Me.PointBinding11.SubscribeParameters = DaItemPointSubscribeParameters11
            Me.PointBinding11.ValueTarget.TargetComponent = Me.textBox22
            Me.PointBinding11.ValueTarget.TargetPath = "BackColor"
            '
            'PointBinding12
            '
            Me.PointBinding12.ArgumentsPath = "Value"
            DaItemPoint12.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint12.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding12.Point = DaItemPoint12
            DaItemPointSubscribeParameters12.RequestedUpdateRate = 100
            Me.PointBinding12.SubscribeParameters = DaItemPointSubscribeParameters12
            Me.PointBinding12.ValueTarget.TargetComponent = Me.textBox23
            Me.PointBinding12.ValueTarget.TargetPath = "Text"
            '
            'PointBinding13
            '
            Me.PointBinding13.ArgumentsPath = "Vtq"
            DaItemPoint13.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint13.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding13.Point = DaItemPoint13
            DaItemPointSubscribeParameters13.RequestedUpdateRate = 100
            Me.PointBinding13.SubscribeParameters = DaItemPointSubscribeParameters13
            Me.PointBinding13.ValueTarget.ExtenderProvider = Me.toolTip1
            Me.PointBinding13.ValueTarget.TargetComponent = Me.textBox23
            Me.PointBinding13.ValueTarget.TargetPath = "ToolTip"
            '
            'PointBinding14
            '
            Me.PointBinding14.ArgumentsPath = "StatusInfo"
            DaItemPoint14.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.AlternatingQuality Bad (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "AlternatingQuality Bad (10 s)"}))
            DaItemPoint14.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding14.Point = DaItemPoint14
            DaItemPointSubscribeParameters14.RequestedUpdateRate = 100
            Me.PointBinding14.SubscribeParameters = DaItemPointSubscribeParameters14
            Me.PointBinding14.ValueTarget.TargetComponent = Me.textBox21
            Me.PointBinding14.ValueTarget.TargetPath = "Text"
            '
            'PointBinding15
            '
            Me.PointBinding15.ArgumentsPath = "ErrorMessage"
            DaItemPoint15.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.AlternatingError (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "AlternatingError (10 s)"}))
            DaItemPoint15.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding15.Point = DaItemPoint15
            DaItemPointSubscribeParameters15.RequestedUpdateRate = 100
            Me.PointBinding15.SubscribeParameters = DaItemPointSubscribeParameters15
            Me.PointBinding15.ValueTarget.TargetComponent = Me.textBox20
            Me.PointBinding15.ValueTarget.TargetPath = "Text"
            '
            'PointBinding16
            '
            Me.PointBinding16.ArgumentsPath = "ErrorId"
            DaItemPoint16.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.AlternatingError (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "AlternatingError (10 s)"}))
            DaItemPoint16.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding16.Point = DaItemPoint16
            DaItemPointSubscribeParameters16.RequestedUpdateRate = 100
            Me.PointBinding16.SubscribeParameters = DaItemPointSubscribeParameters16
            Me.PointBinding16.ValueTarget.TargetComponent = Me.textBox19
            Me.PointBinding16.ValueTarget.TargetPath = "Text"
            '
            'PointBinding17
            '
            Me.PointBinding17.ArgumentsPath = "Vtq"
            DaItemPoint17.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint17.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding17.Point = DaItemPoint17
            DaItemPointSubscribeParameters17.RequestedUpdateRate = 100
            Me.PointBinding17.SubscribeParameters = DaItemPointSubscribeParameters17
            Me.PointBinding17.ValueTarget.TargetComponent = Me.textBox18
            Me.PointBinding17.ValueTarget.TargetPath = "Text"
            '
            'PointBinding18
            '
            Me.PointBinding18.ArgumentsPath = "Quality"
            DaItemPoint18.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.AlternatingQuality Bad (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "AlternatingQuality Bad (10 s)"}))
            DaItemPoint18.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding18.Point = DaItemPoint18
            DaItemPointSubscribeParameters18.RequestedUpdateRate = 100
            Me.PointBinding18.SubscribeParameters = DaItemPointSubscribeParameters18
            Me.PointBinding18.ValueTarget.TargetComponent = Me.textBox17
            Me.PointBinding18.ValueTarget.TargetPath = "Text"
            '
            'PointBinding19
            '
            Me.PointBinding19.ArgumentsPath = "Timestamp"
            DaItemPoint19.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint19.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding19.Point = DaItemPoint19
            DaItemPointSubscribeParameters19.RequestedUpdateRate = 100
            Me.PointBinding19.SubscribeParameters = DaItemPointSubscribeParameters19
            Me.PointBinding19.ValueTarget.TargetComponent = Me.textBox15
            Me.PointBinding19.ValueTarget.TargetPath = "Text"
            '
            'PointBinding20
            '
            Me.PointBinding20.ArgumentsPath = "Value"
            DaItemPoint20.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Ramp 0:100 (10 s)", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Ramp 0:100 (10 s)"}))
            DaItemPoint20.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding20.Point = DaItemPoint20
            DaItemPointSubscribeParameters20.RequestedUpdateRate = 100
            Me.PointBinding20.SubscribeParameters = DaItemPointSubscribeParameters20
            Me.PointBinding20.ValueTarget.TargetComponent = Me.textBox14
            Me.PointBinding20.ValueTarget.TargetPath = "Text"
            '
            'PointBinding21
            '
            Me.PointBinding21.ArgumentsPath = "Value"
            DaItemPoint21.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Greenhouse.Temperature", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Greenhouse", "Temperature"}))
            DaItemPoint21.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding21.Point = DaItemPoint21
            Me.PointBinding21.StringFormat = "Temperature: {0:F1} °C"
            DaItemPointSubscribeParameters21.RequestedUpdateRate = 100
            Me.PointBinding21.SubscribeParameters = DaItemPointSubscribeParameters21
            Me.PointBinding21.ValueTarget.TargetComponent = Me.textBox10
            Me.PointBinding21.ValueTarget.TargetPath = "Text"
            '
            'PointBinding22
            '
            Me.PointBinding22.ArgumentsPath = "Value"
            Me.PointBinding22.BindingOperations = CType(((OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Read Or OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Write) _
            Or OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Subscribe), OpcLabs.BaseLib.LiveBinding.PointBindingOperations)
            DaItemPoint22.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Register_I2", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Register_I2"}), New OpcLabs.BaseLib.ComInterop.VarType(17))
            DaItemPoint22.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding22.Point = DaItemPoint22
            DaItemPointSubscribeParameters22.RequestedUpdateRate = 100
            Me.PointBinding22.SubscribeParameters = DaItemPointSubscribeParameters22
            Me.PointBinding22.ValueTarget.TargetComponent = Me.subscribeAndWriteNumericUpDown
            Me.PointBinding22.ValueTarget.TargetPath = "Value"
            Me.PointBinding22.WriteEventSource.SourceComponent = Me.subscribeAndWriteNumericUpDown
            Me.PointBinding22.WriteEventSource.SourcePath = "ValueChanged"
            '
            'PointBinding23
            '
            Me.PointBinding23.ArgumentsPath = "Value"
            Me.PointBinding23.BindingOperations = CType(((OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Read Or OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Write) _
            Or OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Subscribe), OpcLabs.BaseLib.LiveBinding.PointBindingOperations)
            DaItemPoint23.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Register_I2", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Register_I2"}))
            DaItemPoint23.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding23.Point = DaItemPoint23
            DaItemPointSubscribeParameters23.RequestedUpdateRate = 100
            Me.PointBinding23.SubscribeParameters = DaItemPointSubscribeParameters23
            Me.PointBinding23.ValueTarget.TargetComponent = Me.subscribeAndWriteTrackBar
            Me.PointBinding23.ValueTarget.TargetPath = "Value"
            Me.PointBinding23.WriteEventSource.SourceComponent = Me.subscribeAndWriteTrackBar
            Me.PointBinding23.WriteEventSource.SourcePath = "Scroll"
            '
            'PointBinding24
            '
            Me.PointBinding24.ArgumentsPath = "Value"
            Me.PointBinding24.BindingGroup = Me.TryWriteBindingGroup
            Me.PointBinding24.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Write
            DaItemPoint24.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Register_UI1", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Register_UI1"}))
            DaItemPoint24.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding24.Point = DaItemPoint24
            DaItemPointSubscribeParameters24.RequestedUpdateRate = 100
            Me.PointBinding24.SubscribeParameters = DaItemPointSubscribeParameters24
            Me.PointBinding24.ValueTarget.TargetComponent = Me.textBox37
            Me.PointBinding24.ValueTarget.TargetPath = "Text"
            '
            'TryWriteBindingGroup
            '
            Me.TryWriteBindingGroup.AutoSubscribe = False
            Me.TryWriteBindingGroup.WriteEventSource.SourceComponent = Me.tryWriteButton
            Me.TryWriteBindingGroup.WriteEventSource.SourcePath = "Click"
            '
            'PointBinding25
            '
            Me.PointBinding25.ArgumentsPath = "ErrorMessage"
            Me.PointBinding25.BindingGroup = Me.TryWriteBindingGroup
            Me.PointBinding25.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Write
            DaItemPoint25.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.Register_UI1", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "Register_UI1"}))
            DaItemPoint25.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding25.Point = DaItemPoint25
            DaItemPointSubscribeParameters25.RequestedUpdateRate = 100
            Me.PointBinding25.SubscribeParameters = DaItemPointSubscribeParameters25
            Me.PointBinding25.ValueTarget.ExtenderProvider = Me.errorProvider1
            Me.PointBinding25.ValueTarget.TargetComponent = Me.textBox37
            Me.PointBinding25.ValueTarget.TargetPath = "Error"
            '
            'PointBinding26
            '
            Me.PointBinding26.ArgumentsPath = "Value"
            DaItemPoint26.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.RegisterSet_2.I4", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "RegisterSet_2", "I4"}))
            DaItemPoint26.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding26.Point = DaItemPoint26
            Me.PointBinding26.StringFormat = "=> {0}"
            DaItemPointSubscribeParameters26.RequestedUpdateRate = 100
            Me.PointBinding26.SubscribeParameters = DaItemPointSubscribeParameters26
            Me.PointBinding26.ValueTarget.TargetComponent = Me.textBox34
            Me.PointBinding26.ValueTarget.TargetPath = "Text"
            '
            'PointBinding27
            '
            Me.PointBinding27.ArgumentsPath = "Value"
            DaItemPoint27.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.RegisterSet_1.I4", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "RegisterSet_1", "I4"}))
            DaItemPoint27.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding27.Point = DaItemPoint27
            Me.PointBinding27.StringFormat = "=> {0}"
            DaItemPointSubscribeParameters27.RequestedUpdateRate = 100
            Me.PointBinding27.SubscribeParameters = DaItemPointSubscribeParameters27
            Me.PointBinding27.ValueTarget.TargetComponent = Me.textBox32
            Me.PointBinding27.ValueTarget.TargetPath = "Text"
            '
            'PointBinding28
            '
            Me.PointBinding28.ArgumentsPath = "Value"
            Me.PointBinding28.BindingGroup = Me.WriteBindingGroup
            Me.PointBinding28.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Write
            DaItemPoint28.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.RegisterSet_2.I4", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "RegisterSet_2", "I4"}))
            DaItemPoint28.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding28.Point = DaItemPoint28
            DaItemPointSubscribeParameters28.RequestedUpdateRate = 100
            Me.PointBinding28.SubscribeParameters = DaItemPointSubscribeParameters28
            Me.PointBinding28.ValueTarget.TargetComponent = Me.textBox33
            Me.PointBinding28.ValueTarget.TargetPath = "Text"
            '
            'WriteBindingGroup
            '
            Me.WriteBindingGroup.AutoSubscribe = False
            Me.WriteBindingGroup.WriteEventSource.SourceComponent = Me.writeGroupButton
            Me.WriteBindingGroup.WriteEventSource.SourcePath = "Click"
            '
            'PointBinding29
            '
            Me.PointBinding29.ArgumentsPath = "Value"
            Me.PointBinding29.BindingGroup = Me.WriteBindingGroup
            Me.PointBinding29.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Write
            DaItemPoint29.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.RegisterSet_1.I4", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "RegisterSet_1", "I4"}))
            DaItemPoint29.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding29.Point = DaItemPoint29
            DaItemPointSubscribeParameters29.RequestedUpdateRate = 100
            Me.PointBinding29.SubscribeParameters = DaItemPointSubscribeParameters29
            Me.PointBinding29.ValueTarget.TargetComponent = Me.textBox31
            Me.PointBinding29.ValueTarget.TargetPath = "Text"
            '
            'PointBinding30
            '
            Me.PointBinding30.ArgumentsPath = "Value"
            DaItemPoint30.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.RegisterSet_1.I4", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "RegisterSet_1", "I4"}))
            DaItemPoint30.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding30.Point = DaItemPoint30
            Me.PointBinding30.StringFormat = "=> {0}"
            DaItemPointSubscribeParameters30.RequestedUpdateRate = 100
            Me.PointBinding30.SubscribeParameters = DaItemPointSubscribeParameters30
            Me.PointBinding30.ValueTarget.TargetComponent = Me.textBox29
            Me.PointBinding30.ValueTarget.TargetPath = "Text"
            '
            'PointBinding31
            '
            Me.PointBinding31.ArgumentsPath = "Value"
            Me.PointBinding31.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Write
            DaItemPoint31.ItemDescriptor = New OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Simulation.RegisterSet_1.I4", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Simulation", "RegisterSet_1", "I4"}))
            DaItemPoint31.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding31.Point = DaItemPoint31
            DaItemPointSubscribeParameters31.RequestedUpdateRate = 100
            Me.PointBinding31.SubscribeParameters = DaItemPointSubscribeParameters31
            Me.PointBinding31.ValueTarget.TargetComponent = Me.textBox28
            Me.PointBinding31.ValueTarget.TargetPath = "Text"
            Me.PointBinding31.WriteEventSource.SourceComponent = Me.writeButton
            Me.PointBinding31.WriteEventSource.SourcePath = "Click"
            '
            'PointBinding32
            '
            Me.PointBinding32.ArgumentsPath = "Value"
            Me.PointBinding32.BindingGroup = Me.AutoReadBindingGroup
            Me.PointBinding32.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Read
            DaPropertyPoint1.NodeDescriptor = New OpcLabs.EasyOpc.DataAccess.DANodeDescriptor("Demo.Single", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Demo", "Single"}))
            DaPropertyPoint1.PropertyDescriptor = New OpcLabs.EasyOpc.DataAccess.DAPropertyDescriptor(New OpcLabs.EasyOpc.DataAccess.DAPropertyId(CType(103, Long)))
            DaPropertyPoint1.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding32.Point = DaPropertyPoint1
            Me.PointBinding32.ValueTarget.TargetComponent = Me.textBox4
            Me.PointBinding32.ValueTarget.TargetPath = "Text"
            '
            'PointBinding33
            '
            Me.PointBinding33.ArgumentsPath = "Value"
            Me.PointBinding33.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Read
            DaPropertyPoint2.NodeDescriptor = New OpcLabs.EasyOpc.DataAccess.DANodeDescriptor("Demo.Single", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Demo", "Single"}))
            DaPropertyPoint2.PropertyDescriptor = New OpcLabs.EasyOpc.DataAccess.DAPropertyDescriptor(New OpcLabs.EasyOpc.DataAccess.DAPropertyId(CType(102, Long)))
            DaPropertyPoint2.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding33.Point = DaPropertyPoint2
            Me.PointBinding33.ReadEventSource.SourceComponent = Me.getButton
            Me.PointBinding33.ReadEventSource.SourcePath = "Click"
            Me.PointBinding33.ValueTarget.TargetComponent = Me.textBox1
            Me.PointBinding33.ValueTarget.TargetPath = "Text"
            '
            'PointBinding34
            '
            Me.PointBinding34.ArgumentsPath = "Value"
            Me.PointBinding34.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Read
            DaPropertyPoint3.NodeDescriptor = New OpcLabs.EasyOpc.DataAccess.DANodeDescriptor("Demo.Single", New OpcLabs.BaseLib.Navigation.BrowsePath(New String() {"Demo", "Single"}))
            DaPropertyPoint3.PropertyDescriptor = New OpcLabs.EasyOpc.DataAccess.DAPropertyDescriptor(New OpcLabs.EasyOpc.DataAccess.DAPropertyId(CType(102, Long)))
            DaPropertyPoint3.ServerDescriptor = New OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2")
            Me.PointBinding34.Point = DaPropertyPoint3
            Me.PointBinding34.ReadEventSource.SourceComponent = Me.getButton
            Me.PointBinding34.ReadEventSource.SourcePath = "Click"
            Me.PointBinding34.ValueTarget.TargetComponent = Me.textBox1
            Me.PointBinding34.ValueTarget.TargetPath = "Text"
            '
            'helpRichTextBox
            '
            Me.helpRichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.helpRichTextBox.BackColor = System.Drawing.Color.LightYellow
            Me.helpRichTextBox.Location = New System.Drawing.Point(12, 466)
            Me.helpRichTextBox.Name = "helpRichTextBox"
            Me.helpRichTextBox.ReadOnly = True
            Me.helpRichTextBox.Size = New System.Drawing.Size(760, 92)
            Me.helpRichTextBox.TabIndex = 51
            Me.helpRichTextBox.Text = ""
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(12, 450)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(183, 13)
            Me.label1.TabIndex = 52
            Me.label1.Text = "How to configure this binding feature:"
            '
            'PointBinder1
            '
            Me.PointBinder1.BindingExtender = Me.bindingExtender1
            Me.PointBinder1.BindingGroups.Add(Me.AutoReadBindingGroup)
            Me.PointBinder1.BindingGroups.Add(Me.TryWriteBindingGroup)
            Me.PointBinder1.BindingGroups.Add(Me.WriteBindingGroup)
            Me.PointBinder1.Connectivity = Me.DaConnectivity1
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 570)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.helpRichTextBox)
            Me.Controls.Add(Me.tabControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.Name = "Form1"
            Me.Text = "Live Binding Demo in Windows Forms (there is a separate WPF demo as well)"
            Me.tabControl1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            Me.groupBox5.ResumeLayout(False)
            Me.groupBox5.PerformLayout()
            Me.groupBox4.ResumeLayout(False)
            Me.groupBox4.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage4.ResumeLayout(False)
            Me.groupBox10.ResumeLayout(False)
            Me.groupBox10.PerformLayout()
            Me.groupBox9.ResumeLayout(False)
            Me.groupBox9.PerformLayout()
            Me.groupBox8.ResumeLayout(False)
            Me.groupBox8.PerformLayout()
            Me.groupBox7.ResumeLayout(False)
            Me.groupBox7.PerformLayout()
            Me.groupBox6.ResumeLayout(False)
            Me.groupBox6.PerformLayout()
            Me.tabPage2.ResumeLayout(False)
            Me.groupBox14.ResumeLayout(False)
            Me.groupBox14.PerformLayout()
            CType(Me.subscribeAndWriteNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.subscribeAndWriteTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox13.ResumeLayout(False)
            Me.groupBox13.PerformLayout()
            Me.groupBox12.ResumeLayout(False)
            Me.groupBox12.PerformLayout()
            Me.groupBox11.ResumeLayout(False)
            Me.groupBox11.PerformLayout()
            Me.tabPage3.ResumeLayout(False)
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox3.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            CType(Me.bindingExtender1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DaConnectivity1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private richTextBox1 As System.Windows.Forms.RichTextBox
        Private tabControl1 As System.Windows.Forms.TabControl
        Private WithEvents tabPage1 As System.Windows.Forms.TabPage
        Private WithEvents tabPage2 As System.Windows.Forms.TabPage
        Private bindingExtender1 As OpcLabs.BaseLib.LiveBinding.BindingExtender
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private helpRichTextBox As System.Windows.Forms.RichTextBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents tabPage3 As System.Windows.Forms.TabPage
        Private groupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents getOnEventLinkLabel As System.Windows.Forms.LinkLabel
        Private textBox2 As System.Windows.Forms.TextBox
        Private textBox1 As System.Windows.Forms.TextBox
        Private getButton As System.Windows.Forms.Button
        Private groupBox3 As System.Windows.Forms.GroupBox
        Private textBox3 As System.Windows.Forms.TextBox
        Private textBox4 As System.Windows.Forms.TextBox
        Private WithEvents automaticGetLinkLabel As System.Windows.Forms.LinkLabel
        Private textBox6 As System.Windows.Forms.TextBox
        Private textBox7 As System.Windows.Forms.TextBox
        Private label2 As System.Windows.Forms.Label
        Private progressBar1 As System.Windows.Forms.ProgressBar
        Private trackBar1 As System.Windows.Forms.TrackBar
        Private checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents automaticSubscriptionLinkLabel As System.Windows.Forms.LinkLabel
        Private label3 As System.Windows.Forms.Label
        Private groupBox4 As System.Windows.Forms.GroupBox
        Private textBox9 As System.Windows.Forms.TextBox
        Private groupBox5 As System.Windows.Forms.GroupBox
        Private readButton As System.Windows.Forms.Button
        Private WithEvents tabPage4 As System.Windows.Forms.TabPage
        Private groupBox10 As System.Windows.Forms.GroupBox
        Private groupBox9 As System.Windows.Forms.GroupBox
        Private groupBox8 As System.Windows.Forms.GroupBox
        Private groupBox7 As System.Windows.Forms.GroupBox
        Private groupBox6 As System.Windows.Forms.GroupBox
        Private textBox10 As System.Windows.Forms.TextBox
        Private richTextBox2 As System.Windows.Forms.RichTextBox
        Private richTextBox3 As System.Windows.Forms.RichTextBox
        Private textBox5 As System.Windows.Forms.TextBox
        Private WithEvents automaticReadLinkLabel As System.Windows.Forms.LinkLabel
        Private textBox8 As System.Windows.Forms.TextBox
        Private WithEvents readOnCustomEventLinkLabel As System.Windows.Forms.LinkLabel
        Private textBox11 As System.Windows.Forms.TextBox
        Private label4 As System.Windows.Forms.Label
        Private textBox12 As System.Windows.Forms.TextBox
        Private toolTip1 As System.Windows.Forms.ToolTip
        Private errorProvider1 As System.Windows.Forms.ErrorProvider
        Private WithEvents errorProviderLinkLabel As System.Windows.Forms.LinkLabel
        Private textBox13 As System.Windows.Forms.TextBox
        Private textBox15 As System.Windows.Forms.TextBox
        Private textBox14 As System.Windows.Forms.TextBox
        Private label6 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private textBox16 As System.Windows.Forms.TextBox
        Private label7 As System.Windows.Forms.Label
        Private label8 As System.Windows.Forms.Label
        Private textBox17 As System.Windows.Forms.TextBox
        Private label9 As System.Windows.Forms.Label
        Private textBox18 As System.Windows.Forms.TextBox
        Private label10 As System.Windows.Forms.Label
        Private label11 As System.Windows.Forms.Label
        Private textBox19 As System.Windows.Forms.TextBox
        Private textBox21 As System.Windows.Forms.TextBox
        Private textBox20 As System.Windows.Forms.TextBox
        Private label12 As System.Windows.Forms.Label
        Private label13 As System.Windows.Forms.Label
        Private textBox22 As System.Windows.Forms.TextBox
        Private textBox23 As System.Windows.Forms.TextBox
        Private label14 As System.Windows.Forms.Label
        Private WithEvents bindingKindsLinkLabel As System.Windows.Forms.LinkLabel
        Private textBox24 As System.Windows.Forms.TextBox
        Private textBox25 As System.Windows.Forms.TextBox
        Private textBox26 As System.Windows.Forms.TextBox
        Private WithEvents changeBackgroundLinkLabel As System.Windows.Forms.LinkLabel
        Private WithEvents extendersLinkLabel As System.Windows.Forms.LinkLabel
        Private WithEvents stringFormattingLinkLabel As System.Windows.Forms.LinkLabel
        Private richTextBox4 As System.Windows.Forms.RichTextBox
        Private statusToColorConverter1 As OpcLabs.BaseLib.Components.StatusToColorConverter
        Private groupBox11 As System.Windows.Forms.GroupBox
        Private groupBox12 As System.Windows.Forms.GroupBox
        Private groupBox13 As System.Windows.Forms.GroupBox
        Private groupBox14 As System.Windows.Forms.GroupBox
        Private subscribeAndWriteNumericUpDown As System.Windows.Forms.NumericUpDown
        Private subscribeAndWriteTrackBar As System.Windows.Forms.TrackBar
        Private WithEvents subscribeAndWriteLinkLabel As System.Windows.Forms.LinkLabel
        Private textBox27 As System.Windows.Forms.TextBox
        Private writeButton As System.Windows.Forms.Button
        Private textBox28 As System.Windows.Forms.TextBox
        Private textBox29 As System.Windows.Forms.TextBox
        Private WithEvents writeSingleLinkLabel As System.Windows.Forms.LinkLabel
        Private textBox30 As System.Windows.Forms.TextBox
        Private textBox32 As System.Windows.Forms.TextBox
        Private WithEvents writeGroupLinkLabel As System.Windows.Forms.LinkLabel
        Private textBox31 As System.Windows.Forms.TextBox
        Private writeGroupButton As System.Windows.Forms.Button
        Private textBox34 As System.Windows.Forms.TextBox
        Private textBox33 As System.Windows.Forms.TextBox
        Private textBox35 As System.Windows.Forms.TextBox
        Private textBox36 As System.Windows.Forms.TextBox
        Private tryWriteButton As System.Windows.Forms.Button
        Private textBox37 As System.Windows.Forms.TextBox
        Private WithEvents displayWriteErrorsLinkLabel As System.Windows.Forms.LinkLabel
        Friend WithEvents PointBinding1 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding2 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents AutoReadBindingGroup As OpcLabs.BaseLib.LiveBinding.PointBindingGroup
        Friend WithEvents PointBinding3 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding4 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding5 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding6 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding7 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding8 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding9 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding10 As OpcLabs.BaseLib.LiveBinding.PointBinding
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
        Friend WithEvents PointBinding21 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding22 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding23 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding24 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents TryWriteBindingGroup As OpcLabs.BaseLib.LiveBinding.PointBindingGroup
        Friend WithEvents PointBinding25 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding26 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding27 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding28 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents WriteBindingGroup As OpcLabs.BaseLib.LiveBinding.PointBindingGroup
        Friend WithEvents PointBinding29 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding30 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding31 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding32 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding33 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents PointBinding34 As OpcLabs.BaseLib.LiveBinding.PointBinding
        Friend WithEvents DaConnectivity1 As OpcLabs.EasyOpc.DataAccess.Connectivity.DAConnectivity
        Friend WithEvents PointBinder1 As OpcLabs.BaseLib.LiveBinding.PointBinder
    End Class
End Namespace

