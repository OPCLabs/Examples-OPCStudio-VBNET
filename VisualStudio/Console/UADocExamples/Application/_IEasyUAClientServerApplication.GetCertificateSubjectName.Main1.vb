' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' Shows how to get the subject name of application certificates.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports Microsoft.Extensions.DependencyInjection
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Application
Imports OpcLabs.EasyOpc.UA.Application.ComTypes
Imports OpcLabs.EasyOpc.UA.Application.Extensions

Namespace Application._IEasyUAClientServerApplication
    Friend Class GetCertificateSubjectName
        Public Shared Sub Main1()
            ' Obtain the application interface.
            Dim application As EasyUAApplication = EasyUAApplication.Instance

            ' Get the subject name of application certificates.
            Dim certificateSubjectName = application.GetCertificateSubjectName()

            ' Display results
            Console.WriteLine("Certificate subject name: {0}", certificateSubjectName)
        End Sub
    End Class
End Namespace

#End Region
