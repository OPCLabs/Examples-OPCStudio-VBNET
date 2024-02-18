﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to subscribe to all dataset messages with specific publisher Id, on an OPC-UA PubSub connection
' with UDP UADP mapping.
'
' In order to produce network messages for this example, run the UADemoPublisher tool. For documentation, see
' https://kb.opclabs.com/UADemoPublisher_Basics . In some cases, you may have to specify the interface name to be used.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA.PubSub
Imports OpcLabs.EasyOpc.UA.PubSub.OperationModel

Namespace PubSub._EasyUASubscriber
    Partial Friend Class SubscribeDataSet
        Public Shared Sub PublisherId()

            ' Define the PubSub connection we will work with. Uses implicit conversion from a string.
            Dim pubSubConnectionDescriptor As UAPubSubConnectionDescriptor = "opc.udp://239.0.0.1"
            ' In some cases you may have to set the interface (network adapter) name that needs to be used, similarly to
            ' the statement below. Your actual interface name may differ, of course.
            ' pubSubConnectionDescriptor.ResourceAddress.InterfaceName = "Ethernet"

            ' Define the arguments for subscribing to the dataset, where the filter is (unsigned 64-bit) publisher Id 31.
            Dim subscribeDataSetArguments = New UASubscribeDataSetArguments(
                pubSubConnectionDescriptor, UAPublisherId.CreateUInt64(31))

            ' Instantiate the subscriber object and hook events.
            Dim subscriber = New EasyUASubscriber()
            AddHandler subscriber.DataSetMessage, AddressOf subscriber_DataSetMessage_PublisherId

            Console.WriteLine("Subscribing...")
            subscriber.SubscribeDataSet(subscribeDataSetArguments)

            Console.WriteLine("Processing dataset message events for 20 seconds...")
            Threading.Thread.Sleep(20 * 1000)

            Console.WriteLine("Unsubscribing...")
            subscriber.UnsubscribeAllDataSets()

            Console.WriteLine("Waiting for 1 second...")
            ' Unsubscribe operation is asynchronous, messages may still come for a short while.
            Threading.Thread.Sleep(1 * 1000)

            Console.WriteLine("Finished...")
        End Sub

        Private Shared Sub subscriber_DataSetMessage_PublisherId(ByVal sender As Object, ByVal e As EasyUADataSetMessageEventArgs)
            ' Display the dataset.
            If e.Succeeded Then
                ' An event with null DataSetData just indicates a successful connection.
                If e.DataSetData IsNot Nothing Then
                    Console.WriteLine()
                    Console.WriteLine($"Dataset data: {e.DataSetData}")
                    For Each pair As KeyValuePair(Of String, UADataSetFieldData) In e.DataSetData.FieldDataDictionary
                        Console.WriteLine(pair)
                    Next
                End If
            Else
                Console.WriteLine()
                Console.WriteLine($"*** Failure: {e.ErrorMessageBrief}")
            End If
        End Sub
    End Class



    ' Example output
    '
    'Subscribing...
    'Processing dataset message events for 20 seconds...
    '
    'Dataset data: Good; Event; publisher=(UInt64)31, writer=51, fields: 4
    '[#0, True {System.Boolean}; Good]
    '[#1, 1237 {System.Int32}; Good]
    '[#2, 2514 {System.Int32}; Good]
    '[#3, 10/1/2019 9:03:59 AM {System.DateTime}; Good]
    '
    'Dataset data: Good; Data; publisher=(UInt64)31, writer=1, fields: 4
    '[#0, False {System.Boolean}; Good]
    '[#1, 1239 {System.Int32}; Good]
    '[#2, 2703 {System.Int32}; Good]
    '[#3, 10/1/2019 9:04:01 AM {System.DateTime}; Good]
    '
    'Dataset data: Good; Data; publisher=(UInt64)31, writer=4, fields: 16
    '[#0, False {System.Boolean}; Good]
    '[#1, 215 {System.Byte}; Good]
    '[#2, 1239 {System.Int16}; Good]
    '[#3, 1239 {System.Int32}; Good]
    '[#4, 1239 {System.Int64}; Good]
    '[#5, 87 {System.Int16}; Good]
    '[#6, 1239 {System.Int32}; Good]
    '[#7, 1239 {System.Int64}; Good]
    '[#8, 1239 {System.Decimal}; Good]
    '[#9, 1239 {System.Single}; Good]
    '[#10, 1239 {System.Double}; Good]
    '[#11, Romeo {System.String}; Good]
    '[#12, [20] {175, 186, 248, 246, 215, ...} {System.Byte[]}; Good]
    '[#13, d4492ca8-35c8-4b98-8edf-6ffa5ca041ca {System.Guid}; Good]
    '[#14, 10/1/2019 9:04:01 AM {System.DateTime}; Good]
    '[#15, [10] {1239, 1240, 1241, 1242, 1243, ...} {System.Int64[]}; Good]
    '
    'Dataset data: Good; Data; publisher=(UInt64)31, writer=1, fields: 4
    '[#2, 2722 {System.Int32}; Good]
    '[#3, 10/1/2019 9:04:01 AM {System.DateTime}; Good]
    '[#0, False {System.Boolean}; Good]
    '[#1, 1239 {System.Int32}; Good]
    '
    'Dataset data: Good; Data; publisher=(UInt64)31, writer=3, fields: 100
    '[#0, 39 {System.Int64}; Good]
    '[#1, 139 {System.Int64}; Good]
    '[#2, 239 {System.Int64}; Good]
    '[#3, 339 {System.Int64}; Good]
    '[#4, 439 {System.Int64}; Good]
    '[#5, 539 {System.Int64}; Good]
    '[#6, 639 {System.Int64}; Good]
    '[#7, 739 {System.Int64}; Good]
    '[#8, 839 {System.Int64}; Good]
    '[#9, 939 {System.Int64}; Good]
    '[#10, 1039 {System.Int64}; Good]
    '...

End Namespace

#End Region
