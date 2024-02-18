﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
' ReSharper disable InconsistentNaming
' ReSharper disable PossibleNullReferenceException
#Region "Example"
' This example shows how to display specific fields of incoming events that are derived from base event type.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.AddressSpace.Standard
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace AlarmsAndConditions
    Friend Class BaseEvent
        Public Shared Sub Main1()
            ' Instantiate the client object and hook events
            Dim client = New EasyUAClient()
            AddHandler client.EventNotification, AddressOf client_EventNotification

            Console.WriteLine("Subscribing...")
            client.SubscribeEvent( _
                "opc.tcp://opcua.demo-this.com:62544/Quickstarts/AlarmConditionServer", _
                UAObjectIds.Server, _
                1000)

            Console.WriteLine("Processing event notifications for 30 seconds...")
            Threading.Thread.Sleep(30 * 1000)

            Console.WriteLine("Unsubscribing...")
            client.UnsubscribeAllMonitoredItems()

            Console.WriteLine("Waiting for 5 seconds...")
            Threading.Thread.Sleep(5 * 1000)
        End Sub

        Private Shared Sub client_EventNotification(ByVal sender As Object, ByVal e As EasyUAEventNotificationEventArgs)
            Console.WriteLine()

            ' Display the event
            If e.EventData Is Nothing Then
                Console.WriteLine(e)
                Exit Sub
            End If
            Dim baseEventObject = e.EventData.BaseEvent
            Console.WriteLine("Source name: {0}", baseEventObject.SourceName)
            Console.WriteLine("Message: {0}", baseEventObject.Message)
            Console.WriteLine("Severity: {0}", baseEventObject.Severity)
        End Sub
    End Class
End Namespace

#End Region
