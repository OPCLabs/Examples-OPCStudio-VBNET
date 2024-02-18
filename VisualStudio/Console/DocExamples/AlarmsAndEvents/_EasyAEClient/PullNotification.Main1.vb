' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to subscribe to events and obtain the notification events by pulling them.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.AlarmsAndEvents
Imports OpcLabs.EasyOpc.AlarmsAndEvents.OperationModel

Namespace AlarmsAndEvents._EasyAEClient
    Partial Friend Class PullNotification
        Public Shared Sub Main1()
            Using client = New EasyAEClient()
                ' In order to use event pull, you must set a non-zero queue capacity upfront.
                client.PullNotificationQueueCapacity = 1000

                Console.WriteLine("Subscribing events...")
                Dim handle As Integer = client.SubscribeEvents("", "OPCLabs.KitEventServer.2", 1000)

                Console.WriteLine("Processing event notifications for 1 minute...")
                Dim endTick As Integer = Environment.TickCount + 60 * 1000
                Do
                    Dim eventArgs As EasyAENotificationEventArgs = client.PullNotification(2 * 1000)
                    If Not eventArgs Is Nothing Then
                        ' Handle the notification event
                        Console.WriteLine(eventArgs)
                    End If
                Loop While Environment.TickCount < endTick

                Console.WriteLine("Unsubscribing events...")
                client.UnsubscribeEvents(handle)
            End Using

            Console.WriteLine("Finished.")
        End Sub
    End Class
End Namespace
#End Region
