﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' This example shows how to read data (value, timestamps, and status code) of 3 attributes at once. In this example,
' we are reading a Value attribute of 3 different nodes, but the method can also be used to read multiple attributes
' of the same node.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAClient
    Partial Friend Class ReadMultiple
        Public Shared Sub Main1()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            ' Instantiate the client object
            Dim client = New EasyUAClient()

            ' Obtain attribute data. By default, the Value attributes of the nodes will be read.
            Dim attributeDataResultArray() As UAAttributeDataResult = client.ReadMultiple(New UAReadArguments() _
               {
                   New UAReadArguments(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10845"),
                   New UAReadArguments(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10853"),
                   New UAReadArguments(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10855")
               })

            ' Display results
            For Each attributeDataResult As UAAttributeDataResult In attributeDataResultArray
                If attributeDataResult.Succeeded Then
                    Console.WriteLine("AttributeData: {0}", attributeDataResult.AttributeData)
                Else
                    Console.WriteLine("*** Failure: {0}", attributeDataResult.ErrorMessageBrief)
                End If
            Next attributeDataResult

            ' Example output:
            '
            'AttributeData: 51 {System.Int16} @11/6/2011 1:49:19 PM @11/6/2011 1:49:19 PM; Good
            'AttributeData: -1993984 {System.Single} @11/6/2011 1:49:19 PM @11/6/2011 1:49:19 PM; Good
            'AttributeData: Yellow% Dragon Cat) White Blue Dog# Green Banana- {System.String} @11/6/2011 1:49:19 PM @11/6/2011 1:49:19 PM; Good            
        End Sub
    End Class
End Namespace

#End Region
