﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to write a value into a single node that is of type ByteString.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAClient
    Partial Friend Class WriteValue
        Public Shared Sub ByteString()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            ' Instantiate the client object
            Dim client = New EasyUAClient()

            ' Modify value of a node
            Try
                client.WriteValue(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10230", New Byte() {11, 22, 33, 44, 55})
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try
        End Sub
    End Class
End Namespace

#End Region

