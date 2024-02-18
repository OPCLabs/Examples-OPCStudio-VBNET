﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to read value of a single item, and display it, using CLSID instead of ProgID of the OPC Server.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class ReadItemValue
        Public Shared Sub CLSID()
            ' Instantiate the client object.
            Dim client As New EasyDAClient()

            Console.WriteLine("Reading item value...")
            Dim value As Object
            Try
                value = client.ReadItemValue("", "{C8A12F17-1E03-401E-B53D-6C654DD576DA}", "Simulation.Random")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            Console.WriteLine($"value: {value}")
        End Sub
    End Class
End Namespace
#End Region
