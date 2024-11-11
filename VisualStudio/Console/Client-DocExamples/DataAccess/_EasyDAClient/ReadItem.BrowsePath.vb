﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to read a single item using a browse path, and display its value, timestamp and quality.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports OpcLabs.EasyOpc
Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class ReadItem
        Public Shared Sub BrowsePath()
            Dim client = New EasyDAClient()

            Dim vtq As DAVtq
            Try
                vtq = client.ReadItem(New ServerDescriptor("", "OPCLabs.KitServer.2"), New DAItemDescriptor(Nothing, "/Simulation/Random"))
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            Console.WriteLine("Vtq: {0}", vtq)
        End Sub
    End Class
End Namespace
#End Region
