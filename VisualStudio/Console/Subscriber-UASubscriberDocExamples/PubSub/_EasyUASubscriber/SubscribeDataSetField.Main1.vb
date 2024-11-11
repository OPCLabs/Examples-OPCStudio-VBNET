﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to subscribe to a single dataset field, resolving logical parameters to physical from an OPC-UA
' PubSub configuration file in binary format. The metadata obtained through the resolution is used to decode fixed layout
' messages with RawData field encoding.
'
' In order to produce network messages for this example, run the UADemoPublisher tool. For documentation, see
' https://kb.opclabs.com/UADemoPublisher_Basics . In some cases, you may have to specify the interface name to be used.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports OpcLabs.EasyOpc.UA.PubSub

Namespace PubSub._EasyUASubscriber
    Friend Class SubscribeDataSetField
        Public Shared Sub Main1()

            ' Define the PubSub resolver. We want the information be resolved from a PubSub binary configuration file that
            ' we have. The file itself is at the root of the project, and we have specified that it has to be copied to the
            ' project's output directory.
            Dim pubSubResolverDescriptor = UAPubSubResolverDescriptor.File("UADemoPublisher-Default.uabinary")

            ' Define the PubSub connection we will work with, using its logical name in the PubSub configuration.
            Dim pubSubConnectionDescriptor = New UAPubSubConnectionDescriptor
            pubSubConnectionDescriptor.Name = "FixedLayoutConnection"
            ' In some cases you may have to set the interface (network adapter) name that needs to be used, similarly to
            ' the statement below. Your actual interface name may differ, of course.
            ' pubSubConnectionDescriptor.ResourceAddress.InterfaceName = "Ethernet"

            ' Define the filter. The writer group and the dataset writer are specified using their logical names in the
            ' PubSub configuration. The publisher Id in the filter will be taken from the logical PubSub connection.
            Dim filter = New UASubscribeDataSetFilter("FixedLayoutGroup", "SimpleWriter")

            ' Instantiate the subscriber object.
            Dim subscriber = New EasyUASubscriber()

            Console.WriteLine("Subscribing...")
            Dim fieldHandle = subscriber.SubscribeDataSetField(
                pubSubResolverDescriptor,
                pubSubConnectionDescriptor,
                filter,
                "Int32Fast",
                Sub(sender, eventArgs)
                    Console.WriteLine(eventArgs)
                End Sub)

            Console.WriteLine("Processing dataset message events for 20 seconds...")
            Threading.Thread.Sleep(20 * 1000)

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
    'Success
    'Success; 1626 {System.Int32}; Good
    'Success; 1711 {System.Int32}; Good
    'Success; 1741 {System.Int32}; Good
    'Success; 1837 {System.Int32}; Good
    'Success; 1897 {System.Int32}; Good
    'Success; 1993 {System.Int32}; Good
    'Success; 2082 {System.Int32}; Good
    'Success; 2135 {System.Int32}; Good
    'Success; 2185 {System.Int32}; Good
    'Success; 2241 {System.Int32}; Good
    'Success; 2324 {System.Int32}; Good
    'Success; 2368 {System.Int32}; Good
    'Success; 2423 {System.Int32}; Good
    'Success; 2445 {System.Int32}; Good
    'Success; 2497 {System.Int32}; Good
    'Success; 2584 {System.Int32}; Good
    'Success; 2608 {System.Int32}; Good
    '...

End Namespace

#End Region

