﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to read a value of a single item from the device and display its value.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess.Xml
    Partial Friend Class ReadItemValue
        Public Shared Sub DeviceSourceXml()
            ' Instantiate the client object.
            Dim client As New EasyDAClient()

            Console.WriteLine("Reading item value...")
            Dim value As Object
            Try
                ' DADataSource enumeration:
                ' Selects the data source for OPC reads (from device, from OPC cache, or dynamically determined).
                ' The data source (memory, OPC cache or OPC device) selection is based on the desired value age and
                ' current status of data received from the server.

                value = client.ReadItemValue("http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx", "Dynamic/Analog Types/Double", DADataSource.Device)
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            Console.WriteLine(value)
        End Sub
    End Class
End Namespace
#End Region
