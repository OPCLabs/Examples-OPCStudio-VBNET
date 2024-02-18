﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
' ReSharper disable InconsistentNaming
' ReSharper disable PossibleNullReferenceException
#Region "Example"
' This example shows how to select fields for event notifications.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.AddressSpace.Standard
Imports OpcLabs.EasyOpc.UA.AlarmsAndConditions
Imports OpcLabs.EasyOpc.UA.Filtering
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace AlarmsAndConditions
    Friend Class SelectClauses
        Public Shared Sub Main1()
            ' Instantiate the client object and hook events
            Dim client = New EasyUAClient()
            AddHandler client.EventNotification, AddressOf client_EventNotification

            Console.WriteLine("Subscribing...")
            ' Select specific fields using standard operand symbols
            ' Select specific fields using an event type ID and a simple relative path
            client.SubscribeEvent( _
                "opc.tcp://opcua.demo-this.com:62544/Quickstarts/AlarmConditionServer", _
                UAObjectIds.Server, _
                1000, _
                New UAAttributeFieldCollection() From
                {
                    UABaseEventObject.Operands.NodeId,
                    UABaseEventObject.Operands.SourceNode,
                    UABaseEventObject.Operands.SourceName,
                    UABaseEventObject.Operands.Time,
 _
                    UAFilterElements.SimpleAttribute(UAObjectTypeIds.BaseEventType, "/Message"),
                    UAFilterElements.SimpleAttribute(UAObjectTypeIds.BaseEventType, "/Severity")
                })

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
            For Each pair In e.EventData.FieldResults
                Dim attributeField = pair.Key
                Dim valueResult = pair.Value
                Console.WriteLine("  {0} -> {1}", attributeField, valueResult)
            Next pair
            ' Extracting a specific field using a standard operand symbol
            Console.WriteLine("Source name: {0}", _
                e.EventData.FieldResults(UABaseEventObject.Operands.SourceName))
            ' Extracting a specific field using an event type ID and a simple relative path
            Console.WriteLine("Message: {0}", _
                e.EventData.FieldResults(UAFilterElements.SimpleAttribute(UAObjectTypeIds.BaseEventType, "/Message")))
        End Sub
    End Class
End Namespace

#End Region
