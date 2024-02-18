﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
' ReSharper disable VBPossibleMistakenCallToGetType.2
#Region "Example"
' This example shows how to read a single item and obtains a type code of the received value.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class ReadItem
        Public Shared Sub GetTypeCode()
            Dim client = New EasyDAClient()

            Dim vtq As DAVtq
            Try
                vtq = client.ReadItem("", "OPCLabs.KitServer.2", "Simulation.Random")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            If vtq.Value IsNot Nothing Then
                Dim typeCode As TypeCode = Type.GetTypeCode(vtq.Value.GetType())

                Console.WriteLine("TypeCode: {0}", typeCode)
            End If
        End Sub
    End Class
End Namespace
#End Region
