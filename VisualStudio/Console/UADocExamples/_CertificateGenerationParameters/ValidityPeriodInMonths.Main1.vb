﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' This example shows how to set the validity period of the application instance certificate.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.BaseLib.Security.Cryptography.PkiCertificates
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Application
Imports OpcLabs.EasyOpc.UA.Application.Extensions
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _CertificateGenerationParameters
    Partial Friend Class ValidityPeriodInMonths
        Public Shared Sub Main1()
            Dim endpointDescriptor As UAEndpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            Console.WriteLine("Setting the validity period of the auto-generated instance certificate to 50 years (600 months)...")
            EasyUAApplication.Instance.ApplicationParameters.InstanceCertificateGenerationParameters.ValidityPeriodInMonths = 600

            Console.WriteLine("Obtaining the application interface...")
            ' Instantiate the client object
            Dim client = New EasyUAClient()
            Dim application As EasyUAApplication = EasyUAApplication.Instance

            Try
                Console.WriteLine("Removing the current application instance certificate...")
                application.RemoveOwnCertificate(mustExist:=False)

                Console.WriteLine("Do something - invoke an OPC read, to trigger auto-generation of a new instance certificate...")
                client.ReadValue(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10853")

                Console.WriteLine("Finding the current application instance certificate...")
                Dim instanceCertificate As IPkiCertificate = application.FindOwnCertificate()

                If (instanceCertificate IsNot Nothing) Then
                    Console.WriteLine($"Expiration date: {instanceCertificate.NotAfter}")
                End If
            Catch uaException As UAException
                Console.WriteLine($"*** Failure: {uaException.GetBaseException().Message}")
                Exit Sub
            End Try
        End Sub
    End Class
End Namespace

#End Region
