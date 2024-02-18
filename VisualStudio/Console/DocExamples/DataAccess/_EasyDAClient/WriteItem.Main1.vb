' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to write a value, timestamp and quality into a single item.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class WriteItem
        Public Shared Sub Main1()
            ' Instantiate the client object.
            Dim client = New EasyDAClient()

            Try
                client.WriteItem("", "OPCLabs.KitServer.2", "Simulation.Register_I4",
                    12345, DateTime.SpecifyKind(New DateTime(1980, 1, 1), DateTimeKind.Utc), 192)
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try
            Console.WriteLine("Success")
        End Sub
    End Class
End Namespace
#End Region
