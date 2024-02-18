﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to read a single item, and display its value, timestamp and quality.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class ReadItem
        Public Shared Sub Main1()
            Dim client = New EasyDAClient()

            Dim vtq As DAVtq
            Try
                vtq = client.ReadItem("", "OPCLabs.KitServer.2", "Simulation.Random")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            Console.WriteLine("Vtq: {0}", vtq)
        End Sub
    End Class
End Namespace
#End Region
