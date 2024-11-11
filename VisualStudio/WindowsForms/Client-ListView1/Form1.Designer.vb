<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Demo.Ramp", "", ""}, -1)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Simulation.ReadValue_I1", "", ""}, -1)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Simulation.Random", "", ""}, -1)
        Me.ReadButton = New System.Windows.Forms.Button()
        Me.ItemsListView = New System.Windows.Forms.ListView()
        Me.ItemIdColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VtqColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExceptionColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EasyDAClient1 = New OpcLabs.EasyOpc.DataAccess.EasyDAClient(Me.components)
        Me.SubscribeButton = New System.Windows.Forms.Button()
        Me.UnsubscribeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReadButton
        '
        Me.ReadButton.Location = New System.Drawing.Point(13, 13)
        Me.ReadButton.Name = "ReadButton"
        Me.ReadButton.Size = New System.Drawing.Size(75, 23)
        Me.ReadButton.TabIndex = 0
        Me.ReadButton.Text = "&Read"
        Me.ReadButton.UseVisualStyleBackColor = True
        '
        'ItemsListView
        '
        Me.ItemsListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemIdColumnHeader, Me.VtqColumnHeader, Me.ExceptionColumnHeader})
        Me.ItemsListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem13, ListViewItem14, ListViewItem15})
        Me.ItemsListView.Location = New System.Drawing.Point(13, 43)
        Me.ItemsListView.Name = "ItemsListView"
        Me.ItemsListView.Size = New System.Drawing.Size(759, 207)
        Me.ItemsListView.TabIndex = 1
        Me.ItemsListView.UseCompatibleStateImageBehavior = False
        Me.ItemsListView.View = System.Windows.Forms.View.Details
        '
        'ItemIdColumnHeader
        '
        Me.ItemIdColumnHeader.Text = "Item ID"
        Me.ItemIdColumnHeader.Width = 180
        '
        'VtqColumnHeader
        '
        Me.VtqColumnHeader.Text = "VTQ"
        Me.VtqColumnHeader.Width = 300
        '
        'ExceptionColumnHeader
        '
        Me.ExceptionColumnHeader.Text = "Exception"
        Me.ExceptionColumnHeader.Width = 240
        '
        'EasyDAClient1
        '
        '
        'SubscribeButton
        '
        Me.SubscribeButton.Location = New System.Drawing.Point(94, 13)
        Me.SubscribeButton.Name = "SubscribeButton"
        Me.SubscribeButton.Size = New System.Drawing.Size(75, 23)
        Me.SubscribeButton.TabIndex = 2
        Me.SubscribeButton.Text = "&Subscribe"
        Me.SubscribeButton.UseVisualStyleBackColor = True
        '
        'UnsubscribeButton
        '
        Me.UnsubscribeButton.Enabled = False
        Me.UnsubscribeButton.Location = New System.Drawing.Point(176, 13)
        Me.UnsubscribeButton.Name = "UnsubscribeButton"
        Me.UnsubscribeButton.Size = New System.Drawing.Size(75, 23)
        Me.UnsubscribeButton.TabIndex = 3
        Me.UnsubscribeButton.Text = "&Unsubscribe"
        Me.UnsubscribeButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 262)
        Me.Controls.Add(Me.UnsubscribeButton)
        Me.Controls.Add(Me.SubscribeButton)
        Me.Controls.Add(Me.ItemsListView)
        Me.Controls.Add(Me.ReadButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReadButton As System.Windows.Forms.Button
    Friend WithEvents ItemsListView As System.Windows.Forms.ListView
    Friend WithEvents ItemIdColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents VtqColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents ExceptionColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents EasyDAClient1 As OpcLabs.EasyOpc.DataAccess.EasyDAClient
    Friend WithEvents SubscribeButton As System.Windows.Forms.Button
    Friend WithEvents UnsubscribeButton As System.Windows.Forms.Button

End Class
