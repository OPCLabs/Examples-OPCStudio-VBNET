' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.BaseLib.ComInterop
Imports OpcLabs.EasyOpc.DataAccess
Imports System.Globalization
Imports OpcLabs.EasyOpc.OperationModel
Imports OpcLabs.EasyOpc.DataAccess.OperationModel

<Assembly:CLSCompliant(True)>
' ReSharper disable CheckNamespace
Namespace EasyOpcNetDemo
    ' ReSharper restore CheckNamespace

    Partial Public Class MainForm
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub browseServersButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browseServersButton.Click
            ' ReSharper restore InconsistentNaming

            opcServerDialog1.Location = machineNameTextBox.Text
            If opcServerDialog1.ShowDialog(Me) = DialogResult.OK Then
                serverClassTextBox.Text = opcServerDialog1.ServerElement.ServerClass
            End If
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub browseItemsButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browseItemsButton.Click
            ' ReSharper restore InconsistentNaming

            opcDAItemDialog1.ServerDescriptor.MachineName = machineNameTextBox.Text
            opcDAItemDialog1.ServerDescriptor.ServerClass = serverClassTextBox.Text
            If opcDAItemDialog1.ShowDialog() = DialogResult.OK Then
                itemIdTextBox.Text = opcDAItemDialog1.NodeElement.ItemId
            End If
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub readItemButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles readItemButton.Click
            ' ReSharper restore InconsistentNaming

            Dim vtq As DAVtq = Nothing
            Dim exception As Exception = Nothing
            Try
                vtq = easyDAClient1.ReadItem(machineNameTextBox.Text, serverClassTextBox.Text, itemIdTextBox.Text)
            Catch ex As OpcException
                exception = ex
            End Try
            DisplayVtq(vtq)
            DisplayException(exception)
        End Sub

        Private Sub DisplayVtq(ByVal vtq As DAVtq)
            If vtq Is Nothing Then
                valueTextBox.Text = ""
                timestampTextBox.Text = ""
                qualityTextBox.Text = ""
            Else
                valueTextBox.Text = vtq.DisplayValue()
                timestampTextBox.Text = vtq.Timestamp.ToString()
                qualityTextBox.Text = vtq.Quality.ToString()
            End If
        End Sub

        Private Sub DisplayException(ByVal exception As Exception)
            If CObj(exception) Is CObj(Nothing) Then
                exceptionTextBox.Text = ""
            Else
                exceptionTextBox.Text = exception.GetBaseException().Message
            End If
        End Sub

        Private _isItemSubscribedValue As Boolean ' = false
        Private _itemHandle As Integer ' = 0

        Public Property IsItemSubscribed() As Boolean
            Get
                Return _isItemSubscribedValue
            End Get
            Set(ByVal value As Boolean)
                _isItemSubscribedValue = value
                subscribeItemButton.Enabled = Not _isItemSubscribedValue
                changeItemSubscriptionButton.Enabled = _isItemSubscribedValue
                unsubscribeItemButton.Enabled = _isItemSubscribedValue
            End Set
        End Property

        ' ReSharper disable InconsistentNaming
        Private Sub subscribeItemButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles subscribeItemButton.Click
            ' ReSharper restore InconsistentNaming

            Const dataType As Short = VarTypes.Empty
            Dim requestedUpdateRate As Integer = CInt(Fix(requestedUpdateRateNumericUpDown.Value))
            Dim percentDeadband As Single = CSng(percentDeadbandNumericUpDown.Value)
            _itemHandle = easyDAClient1.SubscribeItem(machineNameTextBox.Text, serverClassTextBox.Text, itemIdTextBox.Text, dataType, requestedUpdateRate, percentDeadband)
            IsItemSubscribed = True
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub changeItemSubscriptionButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles changeItemSubscriptionButton.Click
            ' ReSharper restore InconsistentNaming

            Dim groupParameters = New DAGroupParameters(CInt(Fix(requestedUpdateRateNumericUpDown.Value)), CSng(percentDeadbandNumericUpDown.Value))
            easyDAClient1.ChangeItemSubscription(_itemHandle, groupParameters)
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub unsubscribeItemButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles unsubscribeItemButton.Click
            ' ReSharper restore InconsistentNaming

            easyDAClient1.UnsubscribeItem(_itemHandle)
            _itemHandle = 0
            IsItemSubscribed = False
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub easyDAClient1_ItemChanged(ByVal sender As Object, ByVal e As EasyDAItemChangedEventArgs) Handles easyDAClient1.ItemChanged
            ' ReSharper restore InconsistentNaming

            DisplayVtq(e.Vtq)
            DisplayException(e.Exception)
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub browseMachinesButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browseMachinesButton.Click
            ' ReSharper restore InconsistentNaming

            If computerBrowserDialog1.ShowDialog() = DialogResult.OK Then
                machineNameTextBox.Text = computerBrowserDialog1.SelectedName
            End If
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub aboutButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutButton.Click
            ' ReSharper restore InconsistentNaming

            MessageBox.Show(Me, Reflection.Assembly.GetExecutingAssembly().FullName, "Assembly Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub browsePropertiesButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browsePropertiesButton.Click
            ' ReSharper restore InconsistentNaming

            opcDAPropertyDialog1.ServerDescriptor.MachineName = machineNameTextBox.Text
            opcDAPropertyDialog1.ServerDescriptor.ServerClass = serverClassTextBox.Text
            opcDAPropertyDialog1.NodeDescriptor = itemIdTextBox.Text
            If opcDAPropertyDialog1.ShowDialog() = DialogResult.OK Then
                propertyIdMaskedTextBox.Text = opcDAPropertyDialog1.PropertyElement.PropertyId.ToString()
            End If
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub getPropertyValueButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles getPropertyValueButton.Click
            ' ReSharper restore InconsistentNaming

            Dim propertyId As Integer = Convert.ToInt32(propertyIdMaskedTextBox.Text, CultureInfo.CurrentCulture)
            Dim value As Object = Nothing
            Dim exception As Exception = Nothing
            Try
                value = easyDAClient1.GetPropertyValue(machineNameTextBox.Text, serverClassTextBox.Text, itemIdTextBox.Text, propertyId)
            Catch ex As OpcException
                exception = ex
            End Try
            propertyValueTextBox.Text = (If(value Is Nothing, "(null)", String.Format(CultureInfo.CurrentCulture, "{0}", value)))
            DisplayException(exception)
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub writeItemValueButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles writeItemValueButton.Click
            ' ReSharper restore InconsistentNaming

            Dim value As Object = valueToWriteTextBox.Text
            Dim exception As Exception = Nothing
            Try
                easyDAClient1.WriteItemValue(machineNameTextBox.Text, serverClassTextBox.Text, itemIdTextBox.Text, value)
            Catch ex As OpcException
                exception = ex
            End Try
            DisplayException(exception)
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub closeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeButton.Click
            ' ReSharper restore InconsistentNaming

            Close()
        End Sub

        ' ReSharper disable InconsistentNaming
        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' ReSharper restore InconsistentNaming

        End Sub
    End Class
End Namespace
