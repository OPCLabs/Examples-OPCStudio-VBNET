' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to write values into 3 nodes at once.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAClient
    Partial Friend Class WriteMultipleValues
        Public Shared Sub Main1()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            ' Instantiate the client object
            Dim client = New EasyUAClient()

            ' Modify value of a node
            client.WriteMultipleValues(New UAWriteValueArguments() _
                { _
                    New UAWriteValueArguments(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10221", 23456), _
                    New UAWriteValueArguments(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10226", 2.3456789), _
                    New UAWriteValueArguments(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10227", "ABC") _
                } _
             )
            ' Production code would check the success of the operation. See separate example for that.
        End Sub
    End Class
End Namespace

#End Region
