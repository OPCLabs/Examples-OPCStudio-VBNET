' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' Shows how to obtain a new application certificate from the certificate manager (GDS), and store it for subsequent usage.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports OpcLabs.BaseLib.Security.Cryptography.PkiCertificates
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Application
Imports OpcLabs.EasyOpc.UA.Application.Extensions
Imports OpcLabs.EasyOpc.UA.Extensions
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace Application._IEasyUAClientServerApplication
    Partial Friend Class ObtainNewCertificate
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

            ' Obtain a new application certificate from the certificate manager (GDS), and store it for subsequent usage.
            Dim certificate As IPkiCertificate
            Try
                certificate = application.ObtainNewCertificate(gdsEndpointDescriptor)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display results
            Console.WriteLine("Certificate: {0}", certificate)
        End Sub
    End Class
End Namespace

#End Region
