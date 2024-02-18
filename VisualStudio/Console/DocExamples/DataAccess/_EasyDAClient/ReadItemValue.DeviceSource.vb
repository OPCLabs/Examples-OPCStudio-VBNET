' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to read a value of a single item from the device and display its value.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class ReadItemValue
        Public Shared Sub DeviceSource()
            ' Instantiate the client object.
            Dim client As New EasyDAClient()

            Console.WriteLine("Reading item value...")
            Dim value As Object
            Try
                ' DADataSource enumeration:
                ' Selects the data source for OPC reads (from device, from OPC cache, or dynamically determined).
                ' The data source (memory, OPC cache or OPC device) selection is based on the desired value age and
                ' current status of data received from the server.

                value = client.ReadItemValue("OPCLabs.KitServer.2", "Demo.Ramp", DADataSource.Device)
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            Console.WriteLine(value)
        End Sub
    End Class
End Namespace
#End Region
