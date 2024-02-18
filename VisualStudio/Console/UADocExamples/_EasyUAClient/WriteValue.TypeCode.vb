﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to write a value into a single node, specifying a type code explicitly.
'
' Reasons for specifying the type explicitly might be:
' - The data type in the server has subtypes, and the client therefore needs to pick the subtype to be written.
' - The data type that the reports is incorrect.
' - Writing with an explicitly specified type is more efficient.
'
' TypeCode is easy to use, but it does not cover all possible types. It is also possible to specify the .NET Type, using
' a different overload of the WriteValue method.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAClient
    Partial Friend Class WriteValue
        Public Shared Sub TypeCode()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            ' Instantiate the client object
            Dim client = New EasyUAClient()

            ' Modify value of a node
            Try
                client.WriteValue( _
                    endpointDescriptor, _
                    "nsu=http://test.org/UA/Data/ ;i=10221", _
                    12345, _
                    System.TypeCode.Int32)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try
        End Sub
    End Class
End Namespace

#End Region
