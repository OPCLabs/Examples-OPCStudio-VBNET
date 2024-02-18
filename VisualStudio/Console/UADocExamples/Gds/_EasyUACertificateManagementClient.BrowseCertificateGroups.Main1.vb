' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' Shows how to browse and display the certificate groups available in the Certificate Manager.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Discovery
Imports OpcLabs.EasyOpc.UA.Gds
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace Gds._EasyUACertificateManagementClient
    Friend Class BrowseCertificateGroups
        Public Shared Sub Main1()
            ' Define which GDS we will work with.
            Dim gdsEndpointDescriptor As UAEndpointDescriptor = "opc.tcp://opcua.demo-this.com:58810/GlobalDiscoveryServer"

            ' Instantiate the certificate management client object
            Dim certificateManagementClient = New EasyUACertificateManagementClient()

            ' Browse the certificate groups available in the GDS.
            Dim certificateGroupElementCollection As UACertificateGroupElementCollection
            Try
                certificateGroupElementCollection = certificateManagementClient.BrowseCertificateGroups(gdsEndpointDescriptor)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display results
            For Each certificateGroupElement As UACertificateGroupElement In certificateGroupElementCollection
                Console.WriteLine(certificateGroupElement)
            Next certificateGroupElement
        End Sub
    End Class
End Namespace

#End Region
