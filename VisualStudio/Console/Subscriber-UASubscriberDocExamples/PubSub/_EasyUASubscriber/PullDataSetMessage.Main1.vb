﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to subscribe to all dataset messages on an OPC-UA PubSub connection, and pull events, and display
' the incoming datasets.
'
' In order to produce network messages for this example, run the UADemoPublisher tool. For documentation, see
' https://kb.opclabs.com/UADemoPublisher_Basics . In some cases, you may have to specify the interface name to be used.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports OpcLabs.EasyOpc.UA.PubSub
Imports OpcLabs.EasyOpc.UA.PubSub.OperationModel

Namespace PubSub._EasyUASubscriber
    Friend Class PullDataSetMessage
        Public Shared Sub Main1()

            ' Define the PubSub connection we will work with. Uses implicit conversion from a string.
            Dim pubSubConnectionDescriptor As UAPubSubConnectionDescriptor = "opc.udp://239.0.0.1"
            ' In some cases you may have to set the interface (network adapter) name that needs to be used, similarly to
            ' the statement below. Your actual interface name may differ, of course.
            ' pubSubConnectionDescriptor.ResourceAddress.InterfaceName = "Ethernet"

            ' Instantiate the subscriber object.
            ' In order to use event pull, you must set a non-zero queue capacity upfront.
            Dim subscriber = New EasyUASubscriber()
            subscriber.PullDataSetMessageQueueCapacity = 1000

            Console.WriteLine("Subscribing...")
            subscriber.SubscribeDataSet(pubSubConnectionDescriptor)

            Console.WriteLine("Processing dataset message events for 20 seconds...")
            Dim endTick As Integer = Environment.TickCount + 20 * 1000
            Do
                Dim eventArgs As EasyUADataSetMessageEventArgs = subscriber.PullDataSetMessage(2 * 1000)
                If Not eventArgs Is Nothing Then
                    ' Display the dataset.
                    If eventArgs.Succeeded Then
                        ' An event with null DataSetData just indicates a successful connection.
                        If Not eventArgs.DataSetData Is Nothing Then
                            Console.WriteLine()
                            Console.WriteLine("Dataset data: {0}", eventArgs.DataSetData)
                            For Each pair As KeyValuePair(Of String, UADataSetFieldData) In eventArgs.DataSetData.FieldDataDictionary
                                Console.WriteLine(pair)
                            Next
                        End If
                    Else
                        Console.WriteLine()
                        Console.WriteLine("*** Failure: {0}", eventArgs.ErrorMessageBrief)
                    End If
                End If
            Loop While Environment.TickCount < endTick

            Console.WriteLine("Unsubscribing...")
            subscriber.UnsubscribeAllDataSets()

            Console.WriteLine("Waiting for 1 second...")
            ' Unsubscribe operation is asynchronous, messages may still come for a short while.
            Threading.Thread.Sleep(1 * 1000)

            Console.WriteLine("Finished...")
        End Sub
    End Class

    ' Example output
    '
    'Subscribing...
    'Processing dataset message events for 20 seconds...
    '
    ''Dataset data: Good; Data; publisher="32", writer=1, class=eae79794-1af7-4f96-8401-4096cd1d8908, fields: 4
    '[#0, True {System.Boolean} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#1, 7945 {System.Int32} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#2, 5246 {System.Int32} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#3, 9/30/2019 11:19:14 AM {System.DateTime} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '
    'Dataset data: Good; Data; publisher="32", writer=3, class=96976b7b-0db7-46c3-a715-0979884b55ae, fields: 100
    '[#0, 45 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#1, 145 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#2, 245 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#3, 345 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#4, 445 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#5, 545 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#6, 645 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#7, 745 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#8, 845 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#9, 945 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '[#10, 1045 {System.Int64} @0001-01-01T00:00:00.000 @@0001-01-01T00:00:00.000; Good]
    '...

End Namespace

#End Region

