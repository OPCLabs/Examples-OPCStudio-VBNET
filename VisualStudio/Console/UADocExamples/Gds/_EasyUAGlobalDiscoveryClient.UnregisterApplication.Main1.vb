﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' Shows how to unregister all clients from a GDS.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports System.Linq
Imports OpcLabs.BaseLib.Collections.Generic.Extensions
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.AddressSpace
Imports OpcLabs.EasyOpc.UA.Discovery
Imports OpcLabs.EasyOpc.UA.Extensions
Imports OpcLabs.EasyOpc.UA.Gds
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace Gds._EasyUAGlobalDiscoveryClient
    Friend Class UnregisterApplication
        Public Shared Sub Main1()

            ' Define which GDS we will work with.
            Dim gdsEndpointDescriptor As UAEndpointDescriptor =
                New UAEndpointDescriptor("opc.tcp://opcua.demo-this.com:58810/GlobalDiscoveryServer") _
                .WithUserNameIdentity("appadmin", "demo")

            ' Instantiate the global discovery client object
            Dim globalDiscoveryClient = New EasyUAGlobalDiscoveryClient()

            ' Find application IDs of all client applications registered in the GDS.
            Dim clientApplicationIds = New HashSet(Of UANodeId)
            Try
                Dim lastCounterResetTime As DateTime
                Dim nextRecordId As Long
                Dim applicationDescriptionArray() As UAApplicationDescription = Nothing
                globalDiscoveryClient.QueryApplications(
                    gdsEndpointDescriptor:=gdsEndpointDescriptor,
                    startingRecordId:=0,
                    maximumRecordsToReturn:=0,
                    applicationName:="",
                    applicationUriString:="",
                    applicationTypes:=UAApplicationTypes.Client,
                    productUriString:="",
                    serverCapabilities:=New String() {},
                    lastCounterResetTime:=lastCounterResetTime,
                    nextRecordId:=nextRecordId,
                    applications:=applicationDescriptionArray)

                For Each applicationDescription As UAApplicationDescription In applicationDescriptionArray
                    Dim applicationRecordArray = globalDiscoveryClient.FindApplications(
                        gdsEndpointDescriptor,
                        applicationDescription.ApplicationUriString)
                    clientApplicationIds.AddRange(applicationRecordArray.Select(Function(description) description.ApplicationId))
                Next applicationDescription
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Unregister all client applications found.
            For Each applicationId As UANodeId In clientApplicationIds
                Console.WriteLine()
                Console.WriteLine("Application ID: {0}", applicationId)

                Try
                    globalDiscoveryClient.UnregisterApplication(gdsEndpointDescriptor, applicationId)
                Catch uaException As UAException
                    Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                    Continue For
                End Try
                Console.WriteLine("Unregistered.")
            Next applicationId
        End Sub
    End Class
End Namespace

#End Region
