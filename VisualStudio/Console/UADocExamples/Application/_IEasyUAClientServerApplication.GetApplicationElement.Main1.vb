﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' Shows how to get the OPC UA registration information for this application.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports Microsoft.Extensions.DependencyInjection
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Application
Imports OpcLabs.EasyOpc.UA.Application.ComTypes
Imports OpcLabs.EasyOpc.UA.Application.Extensions

Namespace Application._IEasyUAClientServerApplication
    Friend Class GetApplicationElement
        Public Shared Sub Main1()
            ' Obtain the application interface.
            Dim application As EasyUAApplication = EasyUAApplication.Instance

            ' Get the OPC UA registration information for this application.
            Dim applicationElement = application.GetApplicationElement()

            ' Display results
            Console.WriteLine("Application element:")
            Console.WriteLine("  Application name: {0}", applicationElement.ApplicationName)
            Console.WriteLine("  Application type: {0}", applicationElement.ApplicationType)
            Console.WriteLine("  Application URI string: {0}", applicationElement.ApplicationUriString)
            Console.WriteLine("  Discovery URI strings: {0}", applicationElement.DiscoveryUriStrings)
            Console.WriteLine("  Product URI string: {0}", applicationElement.ProductUriString)
        End Sub
    End Class
End Namespace

#End Region
