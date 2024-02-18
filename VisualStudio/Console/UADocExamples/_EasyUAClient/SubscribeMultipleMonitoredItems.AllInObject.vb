﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
' ReSharper disable InconsistentNaming
' ReSharper disable PossibleNullReferenceException
#Region "Example"
' This example shows how to subscribe to changes of all data variables under a specified object in OPC UA address space.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports System.Linq
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.AddressSpace
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAClient
    Partial Friend Class SubscribeMultipleMonitoredItems
        Public Shared Sub AllInObject()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            ' Instantiate the client object and hook events
            Dim client = New EasyUAClient()
            AddHandler client.DataChangeNotification, AddressOf client_DataChangeNotification_AllInObject

            ' Obtain variables under "Scalar" node
            Console.WriteLine("Subscribing...")
            Dim nodeElementCollection As UANodeElementCollection
            Try
                nodeElementCollection = client.BrowseDataVariables(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;ns=2;i=10787")
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Create array with monitored item arguments

            Dim monitoredItemArgumentsArray() As EasyUAMonitoredItemArguments = nodeElementCollection.Select(Function(element) New EasyUAMonitoredItemArguments(Nothing, endpointDescriptor, element)).ToArray()

            Console.WriteLine("Subscribing...")
            client.SubscribeMultipleMonitoredItems(monitoredItemArgumentsArray)

            Console.WriteLine("Processing monitored item changed events for 20 seconds...")
            Threading.Thread.Sleep(20 * 1000)

            Console.WriteLine("Unsubscribing...")
            client.UnsubscribeAllMonitoredItems()

            Console.WriteLine("Waiting for 5 seconds...")
            Threading.Thread.Sleep(5 * 1000)
        End Sub

        Private Shared Sub client_DataChangeNotification_AllInObject(ByVal sender As Object, ByVal e As EasyUADataChangeNotificationEventArgs)
            ' Display value
            If e.Succeeded Then
                Console.WriteLine("{0}: {1}", e.Arguments.NodeDescriptor, e.AttributeData.Value)
            Else
                Console.WriteLine("{0} *** Failure: {1}", e.Arguments.NodeDescriptor, e.ErrorMessageBrief)
            End If
        End Sub
    End Class
End Namespace

#End Region
