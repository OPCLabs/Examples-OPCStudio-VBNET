' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' Shows how to delete an application registration from the GDS.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports Microsoft.Extensions.DependencyInjection
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Application
Imports OpcLabs.EasyOpc.UA.Application.ComTypes
Imports OpcLabs.EasyOpc.UA.Application.Extensions
Imports OpcLabs.EasyOpc.UA.Extensions
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace Application._IEasyUAClientServerApplication
    Friend Class UnregisterFromGds
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

            ' Delete an application registration from the GDS.
            Try
                application.UnregisterFromGds(gdsEndpointDescriptor)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try
        End Sub
    End Class
End Namespace

#End Region
