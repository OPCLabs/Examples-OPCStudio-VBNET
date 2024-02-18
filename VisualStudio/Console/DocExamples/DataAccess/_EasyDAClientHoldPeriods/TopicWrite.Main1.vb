﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how the OPC server can quickly be disconnected after writing a value into one of its OPC items.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClientHoldPeriods
    Friend Class TopicWrite
        Public Shared Sub Main1()
            Dim client = New EasyDAClient()

            client.InstanceParameters.HoldPeriods.TopicWrite = 100 ' in milliseconds

            Try
                client.WriteItemValue("", "OPCLabs.KitServer.2", "Simulation.Register_I4", 12345)
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
            End Try
        End Sub
    End Class
End Namespace
#End Region
