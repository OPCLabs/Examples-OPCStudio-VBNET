﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable ArrangeModifiersOrder
' ReSharper disable InconsistentNaming
' ReSharper disable LocalizableElement
' ReSharper disable StringLiteralTypo
#Region "Example"
' This example shows how to specify additional host name(s) for the server. This is useful when the server is running on a 
' computer that has multiple host names, and you want to make the server accessible under them.
' You can use any OPC UA client, including our Connectivity Explorer and OpcCmd utility, to connect to the server. 
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports System
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.Application
Imports OpcLabs.EasyOpc.UA.Application.Extensions
Imports OpcLabs.EasyOpc.UA.NodeSpace
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _EasyUAServer
    Partial Friend Class AlternateHostNames
        Shared Sub Main1()
            ' Obtain the application interface.
            Dim Application As EasyUAApplication = EasyUAApplication.Instance

            ' Remove the own application certificate. This assures that, when needed, the server will create a new one with
            ' the parameters we want and specify.
            Try
                Console.WriteLine("Removing the own application certificate...")
                Application.RemoveOwnCertificate()
                Console.WriteLine("The application certificate has been removed.")
            Catch uaException As UAException
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException().Message)
            End Try

            ' Instantiate the server object.
            ' By default, the server will run on endpoint URL "opc.tcp://localhost:48040/".
            Dim server = New EasyUAServer()

            ' Add an alternate host name to the server (and its application certificate).
            server.AlternateHostNames.Add("mycomputer.mycompany.example")

            '

            ' Define a data variable providing random integers.
            Dim random = New Random()
            server.Add(New UADataVariable("MyDataVariable").ReadValueFunction(Function() random.Next()))

            ' Start the server.
            Console.WriteLine("The server is starting...")
            server.Start()

            Console.WriteLine("The server is started.")
            Console.WriteLine()

            ' Let the user decide when to stop.
            Console.WriteLine("Press Enter to stop the server...")
            Console.ReadLine()

            ' Stop the server.
            Console.WriteLine("The server is stopping...")
            server.Stop()

            Console.WriteLine("The server is stopped.")
        End Sub
    End Class
End Namespace
#End Region

