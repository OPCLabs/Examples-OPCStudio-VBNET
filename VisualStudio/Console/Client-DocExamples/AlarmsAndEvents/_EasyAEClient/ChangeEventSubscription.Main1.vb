' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable InconsistentNaming
#Region "Example"
' This example shows how to subscribe to events and later change the notification rate.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports System.Threading
Imports OpcLabs.EasyOpc.AlarmsAndEvents
Imports OpcLabs.EasyOpc.AlarmsAndEvents.OperationModel

Namespace AlarmsAndEvents._EasyAEClient

    Friend Class ChangeEventSubscription
        Public Shared Sub Main1()
            Using client = New EasyAEClient()
                Dim eventHandler = New EasyAENotificationEventHandler(AddressOf client_Notification)
                AddHandler client.Notification, eventHandler

                Console.WriteLine("Subscribing...")
                Dim handle As Integer = client.SubscribeEvents("", "OPCLabs.KitEventServer.2", 500)

                Console.WriteLine("Waiting for 10 seconds...")
                Thread.Sleep(10 * 1000)

                Console.WriteLine("Changing subscription...")
                client.ChangeEventSubscription(handle, 5 * 1000)

                Console.WriteLine("Waiting for 50 seconds...")
                Thread.Sleep(50 * 1000)

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
