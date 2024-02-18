﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
' ReSharper disable InconsistentNaming
#Region "Example"
' This example shows how change the update rate of an existing OPC XML-DA subscription.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports System.Threading
Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.OperationModel

Namespace DataAccess.Xml

    Partial Friend Class ChangeItemSubscription
        Public Shared Sub Main1Xml()
            Using client = New EasyDAClient()
                AddHandler client.ItemChanged, AddressOf client_ItemChanged

                Console.WriteLine("Subscribing...")
                Dim handle As Integer = client.SubscribeItem(
                        "http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx",
                        "Dynamic/Analog Types/Int",
                        2000,
                        state:=Nothing)

                Console.WriteLine("Waiting for 20 seconds...")
                Thread.Sleep(20 * 1000)

                Console.WriteLine("Changing subscription...")
                client.ChangeItemSubscription(handle, New DAGroupParameters(500))

                Console.WriteLine("Waiting for 10 seconds...")
                Thread.Sleep(10 * 1000)

                Console.WriteLine("Unsubscribing...")
                client.UnsubscribeAllItems()

                Console.WriteLine("Waiting for 10 seconds...")
                Thread.Sleep(10 * 1000)
            End Using
        End Sub

        ' Item changed event handler
        Private Shared Sub client_ItemChanged(ByVal sender As Object, ByVal e As EasyDAItemChangedEventArgs)
            If e.Succeeded Then
                Console.WriteLine(e.Vtq)
            Else
                Console.WriteLine("*** Failure: {0}", e.ErrorMessageBrief)
            End If
        End Sub
    End Class
End Namespace
#End Region
