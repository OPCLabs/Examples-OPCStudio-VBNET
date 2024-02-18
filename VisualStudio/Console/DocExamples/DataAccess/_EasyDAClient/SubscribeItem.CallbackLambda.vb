' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable InconsistentNaming
#Region "Example"
' This example shows how subscribe to changes of a single item and display the value of the item with each change,
' using a callback method specified using lambda expression.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess

Namespace DataAccess._EasyDAClient
    Partial Friend Class SubscribeItem
        Shared Sub CallbackLambda()
            ' Instantiate the client object
            Dim client = New EasyDAClient()

            Console.WriteLine("Subscribing...")
            ' The callback is a lambda expression the displays the value
            client.SubscribeItem("", "OPCLabs.KitServer.2", "Simulation.Random", 1000,
                    Sub(sender, eventArgs)
                        Debug.Assert(eventArgs IsNot Nothing)
                        If eventArgs.Succeeded Then
                            Debug.Assert(eventArgs.Vtq IsNot Nothing)
                            Console.WriteLine(eventArgs.Vtq.ToString())
                        Else
                            Console.WriteLine("*** Failure: {0}", eventArgs.ErrorMessageBrief)
                        End If
                    End Sub)

            Console.WriteLine("Processing item changed events for 10 seconds...")
            Threading.Thread.Sleep(10 * 1000)

            Console.WriteLine("Unsubscribing...")
            client.UnsubscribeAllItems()

            Console.WriteLine("Waiting for 2 seconds...")
            Threading.Thread.Sleep(2 * 1000)
        End Sub
    End Class
End Namespace
#End Region
