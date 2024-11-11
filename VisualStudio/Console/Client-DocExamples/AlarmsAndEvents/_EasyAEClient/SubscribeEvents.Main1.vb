' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
' ReSharper disable InconsistentNaming
#Region "Example"
' This example shows how to subscribe to events and display the event message with each notification. It also shows how to 
' unsubscribe afterwards.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports System.Threading
Imports OpcLabs.EasyOpc.AlarmsAndEvents
Imports OpcLabs.EasyOpc.AlarmsAndEvents.OperationModel

Namespace AlarmsAndEvents._EasyAEClient
    Partial Friend Class SubscribeEvents
        Public Shared Sub Main1()
            Using client = New EasyAEClient()
                Dim eventHandler = New EasyAENotificationEventHandler(AddressOf client_Notification)
                AddHandler client.Notification, eventHandler

                Dim handle As Integer = client.SubscribeEvents("", "OPCLabs.KitEventServer.2", 1000)

                Console.WriteLine("Processing event notifications for 1 minute...")
                Thread.Sleep(60 * 1000)

                client.UnsubscribeEvents(handle)
            End Using
        End Sub

        ' Notification event handler
        Private Shared Sub client_Notification(ByVal sender As Object, ByVal e As EasyAENotificationEventArgs)
            If Not e.Succeeded Then
                Console.WriteLine("*** Failure: {0}", e.ErrorMessageBrief)
                Exit Sub
            End If
            If e.EventData IsNot Nothing Then
                Console.WriteLine(e.EventData.Message)
            End If
        End Sub
    End Class
End Namespace
#End Region
