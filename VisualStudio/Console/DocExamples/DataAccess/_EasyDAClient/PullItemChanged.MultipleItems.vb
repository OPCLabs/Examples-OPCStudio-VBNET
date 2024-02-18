' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to subscribe to changes of multiple items and obtain the item changed events by pulling them.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class PullItemChanged
        Public Shared Sub MultipleItems()
            ' Instantiate the client object.
            ' In order to use event pull, you must set a non-zero queue capacity upfront.
            Dim client = New EasyDAClient With {.PullItemChangedQueueCapacity = 1000}

            Console.WriteLine("Subscribing item changes...")
            ' Intentionally specifying an unknown item here, to demonstrate its behavior.
            client.SubscribeMultipleItems(
                New DAItemGroupArguments() {
                    New DAItemGroupArguments("", "OPCLabs.KitServer.2", "Simulation.Random", 1000, Nothing),
                    New DAItemGroupArguments("", "OPCLabs.KitServer.2", "Trends.Ramp (1 min)", 1000, Nothing),
                    New DAItemGroupArguments("", "OPCLabs.KitServer.2", "Trends.Sine (1 min)", 1000, Nothing),
                    New DAItemGroupArguments("", "OPCLabs.KitServer.2", "SomeUnknownItem", 1000, Nothing)
                })

            Console.WriteLine("Processing item changes for 1 minute...")
            Dim endTick As Integer = Environment.TickCount + 60 * 1000
            Do
                Dim eventArgs As EasyDAItemChangedEventArgs = client.PullItemChanged(2 * 1000)
                If Not eventArgs Is Nothing Then
                    ' Handle the notification event
                    If eventArgs.Succeeded Then
                        Console.WriteLine($"{eventArgs.Arguments.ItemDescriptor.ItemId}: {eventArgs.Vtq}")
                    Else
                        Console.WriteLine($"{eventArgs.Arguments.ItemDescriptor.ItemId} *** Failure: {eventArgs.ErrorMessageBrief}")
                    End If
                End If
            Loop While Environment.TickCount < endTick

            Console.WriteLine("Unsubscribing item changes...")
            client.UnsubscribeAllItems()

            Console.WriteLine("Finished.")
        End Sub
    End Class
End Namespace
#End Region
