' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' Shows how to assure presence of the own application certificate, and display its thumbprint.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.BaseLib.Security.Cryptography.PkiCertificates
Imports OpcLabs.EasyOpc.UA.Application
Imports OpcLabs.EasyOpc.UA.Application.Extensions
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace Application._IEasyUAClientServerApplication
    Friend Class AssureOwnCertificate
        Public Shared Sub Main1()
            ' Obtain the application interface.
            Dim application As EasyUAApplication = EasyUAApplication.Instance

            Try
                Console.WriteLine("Assuring presence of the own application certificate...")
                Dim created As Boolean = application.AssureOwnCertificate()

                Console.WriteLine(If(created,
                                  "A new certificate has been created.",
                                  "An existing certificate has been found."))

                Console.WriteLine()
                Console.WriteLine("Finding the current application certificate...")
                Dim pkiCertificate As IPkiCertificate = application.FindOwnCertificate()

                Console.WriteLine()
                Console.WriteLine($"The thumbprint of the current application certificate is: {pkiCertificate?.Thumbprint}")
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException.Message)
                Exit Sub
            End Try
        End Sub
    End Class
End Namespace

#End Region
