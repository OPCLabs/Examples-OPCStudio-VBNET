' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' Shows how to check if an application needs to update its certificate.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports Microsoft.Extensions.DependencyInjection
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.AddressSpace
Imports OpcLabs.EasyOpc.UA.Application
Imports OpcLabs.EasyOpc.UA.Application.ComTypes
Imports OpcLabs.EasyOpc.UA.Extensions
Imports OpcLabs.EasyOpc.UA.Gds
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace Gds._EasyUACertificateManagementClient
    Friend Class GetCertificateStatus
        Public Shared Sub Main1()

            ' Define which GDS we will work with.
            Dim gdsEndpointDescriptor As UAEndpointDescriptor =
                New UAEndpointDescriptor("opc.tcp://opcua.demo-this.com:58810/GlobalDiscoveryServer") _
                .WithUserNameIdentity("appadmin", "demo")

            ' Register our client application with the GDS, so that we obtain an application ID that we need later.
            ' Obtain the application interface.
            Dim application = EasyUAApplication.Instance

            ' Create an application registration in the GDS, assigning it a new application ID.
            Dim applicationId As UANodeId
            Try
                applicationId = application.RegisterToGds(gdsEndpointDescriptor)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Instantiate the certificate management client object
            Dim certificateManagementClient = New EasyUACertificateManagementClient()

            ' Check if the application needs to update its certificate.
            Dim updateRequired As Boolean
            Try
                updateRequired = certificateManagementClient.GetCertificateStatus(gdsEndpointDescriptor, applicationId,
                    UANodeId.Null, UANodeId.Null)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display results
            Console.WriteLine("Update required: {0}", updateRequired)
        End Sub
    End Class
End Namespace

#End Region
