﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable PossibleNullReferenceException
#Region "Example"
' This example shows how to write values into 3 nodes at once, specifying a type code explicitly. It tests for success of 
' each write and displays the exception message in case of failure.
'
' Reasons for specifying the type explicitly might be:
' - The data type in the server has subtypes, and the client therefore needs to pick the subtype to be written.
' - The data type that the reports is incorrect.
' - Writing with an explicitly specified type is more efficient.
'
' Alternative ways of specifying the type are using the ValueType or ValueTypeFullName properties.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports System
Imports OpcLabs.BaseLib.OperationModel
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAClient
    Partial Friend Class WriteMultipleValues
        Public Shared Sub ValueTypeCode()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            ' Instantiate the client object
            Dim client = New EasyUAClient()

            ' Modify value of a node
            Dim operationResultArray() As OperationResult = client.WriteMultipleValues(New UAWriteValueArguments() _
                { _
                    New UAWriteValueArguments(endpointDescriptor, _
                        "nsu=http://test.org/UA/Data/ ;i=10221", 23456) _
                        With {.ValueTypeCode = TypeCode.Int32}, _
                    New UAWriteValueArguments(endpointDescriptor, _
                        "nsu=http://test.org/UA/Data/ ;i=10226", "This string cannot be converted to Double") _
                        With {.ValueTypeCode = TypeCode.Double}, _
                    New UAWriteValueArguments(endpointDescriptor, _
                        "nsu=http://test.org/UA/Data/ ;s=UnknownNode", "ABC") _
                        With {.ValueTypeCode = TypeCode.String} _
                } _
             )

            For i As Integer = 0 To operationResultArray.Length - 1
                If operationResultArray(i).Succeeded Then
                    Console.WriteLine("Result {0}: success", i)
                Else
                    Console.WriteLine("Result {0}: {1}", i, operationResultArray(i).Exception.GetBaseException().Message)
                End If
            Next i
        End Sub
    End Class
End Namespace

#End Region
