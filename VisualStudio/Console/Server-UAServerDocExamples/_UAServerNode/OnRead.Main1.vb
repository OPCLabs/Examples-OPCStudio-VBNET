﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable ArrangeModifiersOrder
' ReSharper disable AssignNullToNotNullAttribute
' ReSharper disable ConvertClosureToMethodGroup
' ReSharper disable LocalizableElement
' ReSharper disable PossibleNullReferenceException
#Region "Example"
' This example shows how to define a custom folder class which implements reading from its data variables.
' You can use any OPC UA client, including our Connectivity Explorer and OpcCmd utility, to connect to the server. 
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports System
Imports OpcLabs.BaseLib.NodeSpace
Imports OpcLabs.EasyOpc.UA
Imports OpcLabs.EasyOpc.UA.NodeSpace
Imports OpcLabs.EasyOpc.UA.OperationModel

Namespace _UAServerNode
    Partial Friend Class OnRead
        ''' <summary>
        ''' A folder in the OPC UA address space, with specialized read behavior.
        ''' </summary>
        Class FolderWithOnRead
            Inherits UAFolder

            Public Sub New(ByVal name As String)
                MyBase.New(name)
            End Sub

            ''' <summary>
            ''' Obtains the data for OPC UA read.
            ''' </summary>
            ''' <param name="e">The event arguments.</param>
            Protected Overrides Sub OnRead(ByVal e As UADataVariableReadEventArgs)
                ' Obtain the state associated with the data variable that is being read.
                ' Use it as the offset for the random value, so that each data variable generates values in a unique range.
                Dim offset As Integer = CInt(e.DataVariable.State * 100)

                ' Generate a random value, indicate that the read has been handled, and return the generated value.
                e.HandleAndReturn(Random.Next(offset, offset + 100))
            End Sub

            Private Shared ReadOnly Random As Random = New Random()
        End Class

        Shared Sub Main1()
            ' Instantiate the server object.
            ' By default, the server will run on endpoint URL "opc.tcp://localhost:48040/".
            Dim server = New EasyUAServer()

            ' Create a folder node.
            Dim myFolder = New FolderWithOnRead("MyFolder")
            server.Add(myFolder)

            ' Create data variables in the folder. Distinguish them by their state.
            myFolder.Add(New UADataVariable("MyDataVariable1").ValueType(Of Integer)().SetState(1))
            myFolder.Add(New UADataVariable("MyDataVariable2").ValueType(Of Integer)().SetState(2))
            myFolder.Add(New UADataVariable("MyDataVariable3").ValueType(Of Integer)().SetState(3))
            myFolder.Add(New UADataVariable("MyDataVariable4").ValueType(Of Integer)().SetState(4))
            myFolder.Add(New UADataVariable("MyDataVariable5").ValueType(Of Integer)().SetState(5))

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
