' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' Shows how to update an application registration in the GDS, keeping its application ID if possible.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports Microsoft.Extensions.DependencyInjection
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.AddressSpace
Imports OpcLabs.EasyOpc.UA.Application
Imports OpcLabs.EasyOpc.UA.Application.ComTypes
Imports OpcLabs.EasyOpc.UA.Application.Extensions
Imports OpcLabs.EasyOpc.UA.Extensions
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace Application._IEasyUAClientServerApplication
    Friend Class UpdateGdsRegistration
        Public Shared Sub Main1()

            ' Define which GDS we will work with.
            Dim gdsEndpointDescriptor As UAEndpointDescriptor =
                New UAEndpointDescriptor("opc.tcp://opcua.demo-this.com:58810/GlobalDiscoveryServer") _
                .WithUserNameIdentity("appadmin", "demo")

            ' Obtain the application interface.
            Dim application As EasyUAApplication = EasyUAApplication.Instance

            ' Display which application we are about to work with.
            Console.WriteLine("Application URI string: {0}",
                application.GetApplicationElement().ApplicationUriString)

            ' Update an application registration in the GDS, keeping its application ID if possible.
            Dim applicationId As UANodeId
            Try
                applicationId = application.UpdateGdsRegistration(gdsEndpointDescriptor)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display results
            Console.WriteLine("Application ID: {0}", applicationId)
        End Sub
    End Class
End Namespace

#End Region
