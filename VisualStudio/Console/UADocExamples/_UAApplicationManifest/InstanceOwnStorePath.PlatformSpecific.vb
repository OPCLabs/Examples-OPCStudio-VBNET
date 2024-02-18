' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' This example demonstrates how to place the client certificate in the platform-specific (Windows, Linux, ...) certificate store.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Application
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _UAApplicationManifest
    Friend Class InstanceOwnStorePath
        Public Shared Sub PlatformSpecific()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            ' Set the application certificate store path, which determines the location of the client certificate.
            ' Note that this only works once in each host process.
            EasyUAApplication.Instance.ApplicationParameters.ApplicationManifest.InstanceOwnStorePath = "CurrentUser\\My"

            ' Do something - invoke an OPC read, to trigger creation of the certificate.
            Dim client = New EasyUAClient()
            Try
                client.ReadValue(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10853")
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
            End Try

            ' The certificate will be located or created in the specified platform-specific certificate store.
            ' On Windows, when viewed by the certmgr.msc tool, it will be under
            ' Certificates - Current User -> Personal -> Certificates.

            Console.WriteLine("Finished.")
        End Sub
    End Class
End Namespace

#End Region
