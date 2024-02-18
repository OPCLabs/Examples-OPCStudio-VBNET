' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' This example shows how to obtain information about OPC UA servers available on the network.
' The result is hierarchical, i.e. each server is returned in one element, and the element contains all its discovery URLs.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Discovery
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAClient
    Partial Friend Class DiscoverNetworkServers
        Public Shared Sub Hierarchical()
            ' Instantiate the client object
            Dim client = New EasyUAClient()

            ' Obtain collection of application elements
            Dim discoveryElementCollection As UADiscoveryElementCollection
            Try
                discoveryElementCollection = client.DiscoverNetworkServers("opcua.demo-this.com", flat:=False)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display results
            For Each discoveryElement As UADiscoveryElement In discoveryElementCollection
                Console.WriteLine()
                Console.WriteLine("Server name: {0}", discoveryElement.ServerName)
                Console.WriteLine("Discovery URI strings:")
                For Each discoveryUriString As String In discoveryElement.DiscoveryUriStrings
                    Console.WriteLine("  {0}", discoveryUriString)
                Next discoveryUriString
                Console.WriteLine("Server capabilities: {0}", discoveryElement.ServerCapabilities)
            Next discoveryElement
        End Sub
    End Class
End Namespace

#End Region
