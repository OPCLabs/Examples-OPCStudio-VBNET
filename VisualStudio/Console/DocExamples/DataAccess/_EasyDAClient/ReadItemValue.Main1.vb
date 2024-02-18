﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"

' This example shows how to read and display value of a single item.
' One of the shortest examples possible.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class ReadItemValue
        Public Shared Sub Main1()
            Dim client As New EasyDAClient()

            Console.WriteLine("Reading item...")
            Try
                Console.WriteLine(client.ReadItemValue("", "OPCLabs.KitServer.2", "Demo.Ramp"))
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try
        End Sub
    End Class
End Namespace
#End Region
