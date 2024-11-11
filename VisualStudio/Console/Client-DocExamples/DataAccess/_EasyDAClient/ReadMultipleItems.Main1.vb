﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to read 4 items at once, and display their values, timestamps and qualities.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class ReadMultipleItems
        Public Shared Sub Main1()
            Dim client = New EasyDAClient()

            Dim vtqResults() As DAVtqResult = client.ReadMultipleItems(
                "OPCLabs.KitServer.2",
                New DAItemDescriptor() {"Simulation.Random", "Trends.Ramp (1 min)", "Trends.Sine (1 min)", "Simulation.Register_I4"})

            For i = 0 To vtqResults.Length - 1
                Debug.Assert(vtqResults(i) IsNot Nothing)

                If vtqResults(i).Succeeded Then
                    Console.WriteLine("vtqResult[{0}].Vtq: {1}", i, vtqResults(i).Vtq)
                Else
                    Console.WriteLine("vtqResult[{0}] *** Failure: {1}", i, vtqResults(i).ErrorMessageBrief)
                End If
            Next i
        End Sub
    End Class
End Namespace
#End Region
