' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
' ReSharper disable InconsistentNaming
#Region "Example"
' This example shows how to set the filtering criteria to be used for the event subscription.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports System.Threading
Imports OpcLabs.EasyOpc.AlarmsAndEvents
Imports OpcLabs.EasyOpc.AlarmsAndEvents.OperationModel
Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace AlarmsAndEvents._AESubscriptionFilter

    Friend Class Properties
        _
        Private Shared ReadOnly AEClient As New EasyAEClient()
        _
        Private Shared ReadOnly DAClient As New EasyDAClient()

        Public Shared Sub Main1()
            Dim eventHandler = New EasyAENotificationEventHandler(AddressOf AEClient_Notification)
            AddHandler AEClient.Notification, eventHandler

            Console.WriteLine("Processing event notifications...")
            Dim subscriptionFilter As New AESubscriptionFilter
            subscriptionFilter.Sources = New AENodeDescriptor() {"Simulation.ConditionState1", "Simulation.ConditionState3"}
            ' You can also filter using event types, categories, severity, and areas.
            Dim handle As Integer = AEClient.SubscribeEvents("", "OPCLabs.KitEventServer.2", 1000, Nothing, subscriptionFilter)

            ' Allow time for initial refresh
            Thread.Sleep(5 * 1000)

            ' Set some events to active state.
            Try
                ' The activation below will come from a source contained in a filter and the notification will arrive.
                DAClient.WriteItemValue("", "OPCLabs.KitServer.2", "SimulateEvents.ConditionState1.Activate", True)
                ' The activation below will come from a source that is not contained in a filter and the notification will not arrive.
                DAClient.WriteItemValue("", "OPCLabs.KitServer.2", "SimulateEvents.ConditionState2.Activate", True)
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            Thread.Sleep(10 * 1000)

            AEClient.UnsubscribeEvents(handle)
            RemoveHandler AEClient.Notification, eventHandler
        End Sub

        ' Notification event handler
        Private Shared Sub AEClient_Notification(ByVal sender As Object, ByVal e As EasyAENotificationEventArgs)
            Console.WriteLine()
            If Not e.Succeeded Then
                Console.WriteLine("*** Failure: {0}", e.ErrorMessageBrief)
                Exit Sub
            End If

            Console.WriteLine("Refresh: {0}", e.Refresh)
            Console.WriteLine("RefreshComplete: {0}", e.RefreshComplete)
            If e.EventData IsNot Nothing Then
                Dim eventData As AEEventData = e.EventData
                Console.WriteLine("EventData.QualifiedSourceName: {0}", eventData.QualifiedSourceName)
                Console.WriteLine("EventData.Message: {0}", eventData.Message)
                Console.WriteLine("EventData.Active: {0}", eventData.Active)
                Console.WriteLine("EventData.Acknowledged: {0}", eventData.Acknowledged)
            End If
        End Sub
    End Class
End Namespace
#End Region
