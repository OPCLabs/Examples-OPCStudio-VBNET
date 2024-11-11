﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable ArrangeModifiersOrder
' ReSharper disable ConvertClosureToMethodGroup
' ReSharper disable LocalizableElement
#Region "Example"
' This example shows how to define a data variable of OPC data type UInt16 and use an action to its write behavior.
' This is an example of the push data consumption model.
' You can use any OPC UA client, including our Connectivity Explorer and OpcCmd utility, to connect to the server. 
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports System
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.NodeSpace

Namespace _UADataVariable
    Partial Friend Class WriteValueAction
        Shared Sub UInt16()
            ' Instantiate the server object.
            ' By default, the server will run on endpoint URL "opc.tcp://localhost:48040/".
            Dim server = New EasyUAServer()

            ' Create a writable data variable and add an action that will be executed when the data variable is written to.
            ' We explicitly specify the OPC data type of the variable to be UInt16, but use .NET Int32 in the write value
            ' function. The OPC Wizard will attempt to convert the value being written to the specified .NET type. This is
            ' helpful in languages like VB.NET that do not have full support for some types (such as unsigned integers).
            server.Add(New UADataVariable("WriteToThisVariable").WriteValueAction(Of Integer)(
                GetType(UInt16),
                Sub(value) Console.WriteLine($"Value written: {value}")))

            ' Start the server.
            Console.WriteLine("The server is starting...")
            server.Start()

            Console.WriteLine("The server is started.")
            Console.WriteLine("Any value written to the example data variable will be displayed on the console.")
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

