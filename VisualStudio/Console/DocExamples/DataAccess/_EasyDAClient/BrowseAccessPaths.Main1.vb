﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to obtain all access paths available for an item.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class BrowseAccessPaths
        Shared Sub Main1()
            Dim client = New EasyDAClient()

            Dim accessPaths() As String
            Try
                accessPaths = client.BrowseAccessPaths("OPCLabs.KitServer.2", "Simulation.Random")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            For i = 0 To accessPaths.Length - 1
                Console.WriteLine($"accessPaths({i}): {accessPaths(i)}")
            Next i

        End Sub

        ' Example output
        '
        'accessPaths(0): Self
        'accessPaths(1): Other

    End Class
End Namespace
#End Region
