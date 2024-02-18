﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to obtain all areas directly under the root (denoted by empty string for the parent).
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.AlarmsAndEvents
Imports OpcLabs.EasyOpc.AlarmsAndEvents.AddressSpace
Imports OpcLabs.EasyOpc.OperationModel

Namespace AlarmsAndEvents._EasyAEClient

    Friend Class BrowseAreas
        Public Shared Sub Main1()
            Dim client = New EasyAEClient()

            Dim nodeElements As AENodeElementCollection
            Try
                nodeElements = client.BrowseAreas("", "OPCLabs.KitEventServer.2", "")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            For Each nodeElement As AENodeElement In nodeElements
                Debug.Assert(nodeElement IsNot Nothing)

                Console.WriteLine("nodeElements[""{0}""]:", nodeElement.Name)
                Console.WriteLine("    .QualifiedName: {0}", nodeElement.QualifiedName)
            Next nodeElement
        End Sub
    End Class

End Namespace
#End Region
