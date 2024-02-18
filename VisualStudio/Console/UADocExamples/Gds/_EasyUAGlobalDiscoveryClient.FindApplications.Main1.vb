﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' Shows how to find all registrations in the GDS.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Discovery
Imports OpcLabs.EasyOpc.UA.Extensions
Imports OpcLabs.EasyOpc.UA.Gds
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace Gds._EasyUAGlobalDiscoveryClient
    Friend Class FindApplications
        Public Shared Sub Main1()

            ' Define which GDS we will work with.
            Dim gdsEndpointDescriptor As UAEndpointDescriptor =
                New UAEndpointDescriptor("opc.tcp://opcua.demo-this.com:58810/GlobalDiscoveryServer") _
                .WithUserNameIdentity("appuser", "demo")

            ' Instantiate the global discovery client object
            Dim globalDiscoveryClient = New EasyUAGlobalDiscoveryClient()

            ' Find all (client or server) applications registered in the GDS.
            Dim applicationDescriptionArray() As UAApplicationDescription = Nothing
            Try
                Dim lastCounterResetTime As DateTime
                Dim nextRecordId As Long
                globalDiscoveryClient.QueryApplications(
                    gdsEndpointDescriptor:=gdsEndpointDescriptor,
                    startingRecordId:=0,
                    maximumRecordsToReturn:=0,
                    applicationName:="",
                    applicationUriString:="",
                    applicationTypes:=UAApplicationTypes.All,
                    productUriString:="",
                    serverCapabilities:=New String() {},
                    lastCounterResetTime:=lastCounterResetTime,
                    nextRecordId:=nextRecordId,
                    applications:=applicationDescriptionArray)
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try

            ' For each application returned by the query, find its registrations in the GDS.
            For Each applicationDescription As UAApplicationDescription In applicationDescriptionArray
                Console.WriteLine()
                Console.WriteLine("Application URI string: {0}", applicationDescription.ApplicationUriString)

                Dim applicationRecordArray() As UAApplicationRecordDataType
                Try
                    applicationRecordArray = globalDiscoveryClient.FindApplications(
                        gdsEndpointDescriptor,
                        applicationDescription.ApplicationUriString)
                Catch uaException As UAException
                    Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                    Continue For
                End Try

                ' Display results
                For Each applicationRecord As UAApplicationRecordDataType In applicationRecordArray
                    Console.WriteLine("  Application ID: {0}", applicationRecord.ApplicationId)
                Next applicationRecord
            Next applicationDescription
        End Sub
    End Class
End Namespace

#End Region
