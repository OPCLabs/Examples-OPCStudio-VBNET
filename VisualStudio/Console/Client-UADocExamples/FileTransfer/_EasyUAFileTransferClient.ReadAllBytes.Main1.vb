﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
' ReSharper disable PossibleNullReferenceException
#Region "Example"
' Shows how to read the full contents of an OPC UA file at once, using the file transfer client.
' Note: Consider using a higher-level abstraction, OPC UA file provider, instead.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports System.IO
Imports System.Text
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.FileTransfer
Imports OpcLabs.EasyOpc.UA.IO.Extensions

Namespace FileTransfer._EasyUAFileTransferClient

    Friend Class ReadAllBytes

        Public Shared Sub Main1()

            ' Unified Automation .NET based demo server (UaNETServer/UaServerNET.exe)
            Dim endpointDescriptor As UAEndpointDescriptor = "opc.tcp://localhost:48030"

            ' A node that represents an instance of OPC UA FileType object.
            Dim fileNodeDescriptor As UANodeDescriptor = "nsu=http://www.unifiedautomation.com/DemoServer/ ;s=Demo.Files.TextFile"

            ' Instantiate the file transfer client object
            Dim fileTransferClient = New EasyUAFileTransferClient

            ' Read in all contents from a specified file node.
            Dim bytes As Byte()
            Try
                Console.WriteLine("Reading the whole file...")
                bytes = fileTransferClient.ReadAllBytes(endpointDescriptor, fileNodeDescriptor)

                ' Beware that ReadAllFileBytes throws IOException And Not UAException.
            Catch ioException As IOException
                Console.WriteLine("*** Failure: {0}", ioException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display result
            Console.WriteLine()
            ' We know that the file contains text, so we convert the received data to a string. If the file contents was
            ' binary, you would process the data according to their format.
            Dim text As String = Encoding.UTF8.GetString(bytes)
            Console.WriteLine("File content:")
            Console.WriteLine(text)

            Console.WriteLine()
            Console.WriteLine("Finished...")
        End Sub
    End Class
End Namespace

#End Region
