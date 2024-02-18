' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' This example shows how in a console application, the user is asked to allow a server instance certificate with
' mismatched domain name.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.OperationModel
Imports OpcLabs.EasyOpc.UA.Engine

Namespace Interaction
    Friend Class AllowEndpointDomain
        Public Shared Sub Main1()

            ' Define which server we will work with.
            ' Note that extra '.' at the end of the domain name. For the purpose of this example, it allows us to address
            ' the same domain, but cause a mismatch with what the names that are listed in the server instance certificate.
            Dim endpointDescriptor As UAEndpointDescriptor = "opc.tcp://opcua.demo-this.com.:51210/UA/SampleServer"

            ' Instantiate the client object.
            Dim client = New EasyUAClient() With _
            { _
                .Isolated = True, _
                .IsolatedParameters = New EasyUAAdaptableParameters() With _
                { _
                    .SessionParameters = New UASmartSessionParameters() With _
                    { _
                        .CheckEndpointDomain = True _
                    } _
                } _
            }

            Dim attributeData As UAAttributeData
            Try
                ' Obtain attribute data.
                ' The component automatically triggers the necessary user interaction during the first operation.
                attributeData = client.Read(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10853")
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display results.
            Console.WriteLine("Value: {0}", attributeData.Value)
            Console.WriteLine("ServerTimestamp: {0}", attributeData.ServerTimestamp)
            Console.WriteLine("SourceTimestamp: {0}", attributeData.SourceTimestamp)
            Console.WriteLine("StatusCode: {0}", attributeData.StatusCode)
        End Sub
    End Class
End Namespace

#End Region
