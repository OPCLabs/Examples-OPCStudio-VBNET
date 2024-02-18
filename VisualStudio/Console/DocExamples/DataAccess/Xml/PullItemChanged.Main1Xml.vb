' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to subscribe to OPC XML-DA item changes and obtain the events by pulling them.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.OperationModel

Namespace DataAccess.Xml
    Partial Friend Class PullItemChanged
        Public Shared Sub Main1Xml()
            ' In order to use event pull, you must set a non-zero queue capacity upfront.
            Dim client = New EasyDAClient() With {.PullItemChangedQueueCapacity = 1000}

            Console.WriteLine("Subscribing item changes...")
            client.SubscribeItem(
                    "http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx",
                    "Dynamic/Analog Types/Int",
                    1000,
                    state:=Nothing)

            Console.WriteLine("Processing item changes for 1 minute...")
            Dim endTick As Integer = Environment.TickCount + 60 * 1000
            Do
                Dim eventArgs As EasyDAItemChangedEventArgs = client.PullItemChanged(2 * 1000)
                If Not eventArgs Is Nothing Then
                    ' Handle the notification event
                    Console.WriteLine(eventArgs)
                End If
            Loop While Environment.TickCount < endTick

            Console.WriteLine("Unsubscribing item changes...")
            client.UnsubscribeAllItems()

            Console.WriteLine("Finished.")
        End Sub
    End Class
End Namespace
#End Region
