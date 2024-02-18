﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to get a value of a single OPC property.
'
' Note that some properties may not have a useful value initially (e.g. until the item is activated in a group), which also the
' case with Timestamp property as implemented by the demo server. This behavior is server-dependent, and normal. You can run 
' IEasyDAClient.ReadItemValue.Main.vbs shortly before this example, in order to obtain better property values. Your code may 
' also subscribe to the item in order to assure that it remains active.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class GetPropertyValue
        Public Shared Sub Main1()
            Dim client = New EasyDAClient()

            Dim value As Object
            Try
                value = client.GetPropertyValue("", "OPCLabs.KitServer.2", "Simulation.Random", DAPropertyIds.Timestamp)
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            Console.WriteLine(value)
        End Sub
    End Class
End Namespace
#End Region
