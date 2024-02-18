' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to read an item synchronously, and display its value, timestamp and quality.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class ReadItem
        Public Shared Sub Synchronous()
            ' Instantiate the client object.
            Dim client = New EasyDAClient()

            ' Specify that only synchronous method is allowed. By default, both synchronous and asynchronous methods are
            ' allowed, and the component picks a suitable method automatically. Disallowing asynchronous method leaves
            ' only the synchronous method available for selection.
            client.InstanceParameters.Mode.AllowAsynchronousMethod = False

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
