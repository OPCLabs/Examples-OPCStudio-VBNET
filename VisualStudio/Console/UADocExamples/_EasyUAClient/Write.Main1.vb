' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to write data (a value, timestamps and status code) into a single attribute of a node.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAClient
    Friend Class Write
        Public Shared Sub Main1()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            ' Instantiate the client object
            Dim client = New EasyUAClient()

            Try
                ' Modify data of a node's attribute
                client.Write(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10221",
                                   New UAAttributeData(12345, UASeverity.GoodOrSuccess, Date.UtcNow)) ' or "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"

                ' The target server may not support this, and in such case a failure will occur.
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException().Message)
            End Try
        End Sub
    End Class
End Namespace

#End Region
