﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable ArrangeModifiersOrder
' ReSharper disable LocalizableElement
' ReSharper disable UnusedVariable
#Region "Example"
' This example shows how to add nodes (data variables and folders) to the Objects folder in the address space.
' You can use any OPC UA client, including our Connectivity Explorer and OpcCmd utility, to connect to the server. 
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports System
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.NodeSpace

Namespace _EasyUAServer
    Partial Friend Class Objects
        Shared Sub Main1()
            ' Instantiate the server object.
            ' By default, the server will run on endpoint URL "opc.tcp://localhost:48040/".
            Dim server = New EasyUAServer()

            ' Create a data variable and a folder in the Objects folder, and a data variable under the custom folder.
            Dim constantDataVariable = UADataVariable.CreateIn(server.Objects, "Constant").ConstantValue("abc")
            Dim folder = UAFolder.CreateIn(server.Objects, "Folder")
            Dim readWriteDataVariable = UADataVariable.CreateIn(folder, "ReadWrite").ReadWriteValue(0) ' read-write register

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

