' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Forms.Application
Imports OpcLabs.EasyOpc.UA.OperationModel

<Assembly: CLSCompliant(True)>

Partial Public Class MainForm
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    ' ReSharper disable InconsistentNaming
    Private Sub readButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles readButton.Click
        ' ReSharper restore InconsistentNaming

        Dim attributeData As UAAttributeData = Nothing
        Dim exception As Exception = Nothing
        Try
            attributeData = easyUAClient1.Read(serverUriTextBox.Text, nodeIdTextBox.Text)
        Catch ex As UAException
            exception = ex
        End Try
        DisplayAttributeData(attributeData)
        DisplayException(exception)
    End Sub

    Private Sub DisplayAttributeData(ByVal attributeData As UAAttributeData)
        If attributeData Is Nothing Then
            valueTextBox.Text = ""
            statusTextBox.Text = ""
            sourceTimestampTextBox.Text = ""
            serverTimestampTextBox.Text = ""
        Else
            valueTextBox.Text = attributeData.DisplayValue()
            statusTextBox.Text = attributeData.StatusCode.ToString()
            sourceTimestampTextBox.Text = attributeData.SourceTimestamp.ToString()
            serverTimestampTextBox.Text = attributeData.ServerTimestamp.ToString()
        End If
    End Sub

    Private Sub DisplayException(ByVal exception As Exception)
        exceptionTextBox.Text = If(exception Is Nothing, "", exception.GetBaseException().Message)
    End Sub

    Private _isSubscribed As Boolean ' = false
    Private _handle As Integer ' = 0

    Public Property IsSubscribed() As Boolean
        Get
            Return _isSubscribed
        End Get
        Set(ByVal value As Boolean)
            _isSubscribed = value
            subscribeMonitoredItemButton.Enabled = Not _isSubscribed
            changeMonitoredItemSubscriptionButton.Enabled = _isSubscribed
            unsubscribeMonitoredItemButton.Enabled = _isSubscribed
        End Set
    End Property

    ' ReSharper disable InconsistentNaming
    Private Sub subscribeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles subscribeMonitoredItemButton.Click
        ' ReSharper restore InconsistentNaming

        _handle = easyUAClient1.SubscribeDataChange(serverUriTextBox.Text, nodeIdTextBox.Text, CInt(Fix(samplingIntervalNumericUpDown.Value)))
        IsSubscribed = True
    End Sub

    ' ReSharper disable InconsistentNaming
    Private Sub changeSubscriptionButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles changeMonitoredItemSubscriptionButton.Click
        ' ReSharper restore InconsistentNaming
        easyUAClient1.ChangeMonitoredItemSubscription(_handle, CInt(Fix(samplingIntervalNumericUpDown.Value)))
    End Sub

    ' ReSharper disable InconsistentNaming
    Private Sub unsubscribeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles unsubscribeMonitoredItemButton.Click
        ' ReSharper restore InconsistentNaming
        Unsubscribe()
    End Sub

    Private Sub Unsubscribe()
        easyUAClient1.UnsubscribeMonitoredItem(_handle)
        _handle = 0
        IsSubscribed = False
    End Sub

    ' ReSharper disable InconsistentNaming
    Private Sub easyUAClient1_DataChangeNotification(ByVal sender As Object, ByVal e As EasyUADataChangeNotificationEventArgs) Handles easyUAClient1.DataChangeNotification
        ' ReSharper restore InconsistentNaming
        DisplayAttributeData(If(e.Exception Is Nothing, e.AttributeData, Nothing))
        DisplayException(e.Exception)
    End Sub

    ' ReSharper disable InconsistentNaming
    Private Sub aboutButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutButton.Click
        ' ReSharper restore InconsistentNaming
        MessageBox.Show(Me, Reflection.Assembly.GetExecutingAssembly().FullName, My.Resources.MainForm_AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ReSharper disable InconsistentNaming
    Private Sub closeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeButton.Click
        ' ReSharper restore InconsistentNaming
        If IsSubscribed Then
            Unsubscribe()
        End If
        Close()
    End Sub

    ' ReSharper disable InconsistentNaming
    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' ReSharper restore InconsistentNaming
        EasyUAFormsApplication.Instance.AddToSystemMenu(Me)
    End Sub

    ' ReSharper disable InconsistentNaming
    Private Sub writeValueButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles writeValueButton.Click
        ' ReSharper restore InconsistentNaming

        Dim exception As Exception = Nothing
        Try
            easyUAClient1.WriteValue(serverUriTextBox.Text, nodeIdTextBox.Text, valueToWriteTextBox.Text)
        Catch ex As UAException
            exception = ex
        End Try
        DisplayException(exception)
    End Sub

    ' ReSharper disable InconsistentNaming
    Private Sub discoverServersButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles discoverServersButton.Click
        ' ReSharper restore InconsistentNaming

        uaHostAndEndpointDialog1.EndpointDescriptor = serverUriTextBox.Text
        If uaHostAndEndpointDialog1.ShowDialog() = DialogResult.OK Then
            serverUriTextBox.Text = uaHostAndEndpointDialog1.EndpointDescriptor.UrlString
        End If
    End Sub

    ' ReSharper disable InconsistentNaming
    Private Sub browseDataButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles browseDataButton.Click
        ' ReSharper restore InconsistentNaming

        uaDataDialog1.EndpointDescriptor = serverUriTextBox.Text
        If uaDataDialog1.ShowDialog() = DialogResult.OK Then
            nodeIdTextBox.Text = uaDataDialog1.NodeDescriptor.NodeId
        End If
    End Sub
End Class