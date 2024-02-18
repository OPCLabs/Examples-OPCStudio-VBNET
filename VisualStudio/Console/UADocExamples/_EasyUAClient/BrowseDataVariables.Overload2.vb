﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' This example shows how to obtain data variables under the "Server" node in the address space.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.AddressSpace
Imports OpcLabs.EasyOpc.UA.AddressSpace.Standard
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAClient
    Friend Class BrowseDataVariables
        Public Shared Sub Overload2()

            ' Define which server we will work with.
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            ' Instantiate the client object
            Dim client = New EasyUAClient()

            ' Obtain variables under "Server" node
            Dim nodeElementCollection As UANodeElementCollection
            Try
                nodeElementCollection = client.BrowseDataVariables(endpointDescriptor, UAObjectIds.Server)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display results
            For Each nodeElement As UANodeElement In nodeElementCollection
                Console.WriteLine()
                Console.WriteLine("nodeElement.NodeId: {0}", nodeElement.NodeId)
                Console.WriteLine("nodeElement.DisplayName: {0}", nodeElement.DisplayName)
            Next nodeElement

            ' Example output:
            '
            'nodeElement.NodeId: nsu=http://opcfoundation.org/UA/;i=2256
            'nodeElement.DisplayName: ServerStatus            
        End Sub
    End Class
End Namespace

#End Region
