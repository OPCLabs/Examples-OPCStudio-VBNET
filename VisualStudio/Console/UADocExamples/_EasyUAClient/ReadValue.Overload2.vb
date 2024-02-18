﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
' ReSharper disable VBPossibleMistakenCallToGetType.2
#Region "Example"
' This example shows how to read a value of a specific attribute of a single node, and display it.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAClient
    Partial Friend Class ReadValue
        Public Shared Sub Overload2()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            Dim nodeDescriptor As UANodeDescriptor = "nsu=http://test.org/UA/Data/ ;i=10853"

            ' Instantiate the client object.
            Dim client = New EasyUAClient()

            ' Obtain value of a DataType attribute.
            Dim value As Object
            Try
                value = client.ReadValue(endpointDescriptor, nodeDescriptor, UAAttributeId.DataType)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display results
            Console.WriteLine("value type: {0}", value.GetType())
            Console.WriteLine("value: {0}", value)
        End Sub
    End Class
End Namespace
#End Region
