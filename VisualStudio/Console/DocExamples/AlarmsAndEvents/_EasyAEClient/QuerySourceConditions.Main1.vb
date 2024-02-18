﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to enumerate all event conditions associated with the specified event source.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.AlarmsAndEvents
Imports OpcLabs.EasyOpc.AlarmsAndEvents.AddressSpace
Imports OpcLabs.EasyOpc.OperationModel

Namespace AlarmsAndEvents._EasyAEClient

    Friend Class QuerySourceConditions
        Public Shared Sub Main1()
            Dim client = New EasyAEClient()

            Dim conditionElements As AEConditionElementCollection
            Try
                conditionElements = client.QuerySourceConditions( _
                    "", "OPCLabs.KitEventServer.2", "Simulation.ConditionState1")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            For Each conditionElement As AEConditionElement In conditionElements
                Debug.Assert(conditionElement IsNot Nothing)
                Console.WriteLine("ConditionElements[""{0}""]: {1} subcondition(s)", _
                                  conditionElement.Name, conditionElement.SubconditionNames.Length)
            Next conditionElement
        End Sub
    End Class

End Namespace
#End Region
