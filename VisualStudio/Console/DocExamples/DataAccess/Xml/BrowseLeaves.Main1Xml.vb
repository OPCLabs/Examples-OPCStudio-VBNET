' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to obtain all leaves under the "Simulation" branch of the address space. For each leaf, it displays 
' the ItemID of the node.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc
Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.AddressSpace
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess.Xml
    Partial Friend Class BrowseLeaves
        Shared Sub Main1Xml()
            Dim client = New EasyDAClient()

            Dim leafElements As DANodeElementCollection
            Try
                Dim serverDescriptor As ServerDescriptor = "http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx"
                leafElements = client.BrowseLeaves(serverDescriptor, "Static/Analog Types")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            For Each leafElement In leafElements
                Console.WriteLine($"LeafElements(""{leafElement.Name}"").ItemId: {leafElement.ItemId}")
            Next leafElement

        End Sub

        ' Example output
        '
        'LeafElements("Int").ItemId: Static/Analog Types/Int
        'LeafElements("Double").ItemId: Static/Analog Types/Double
        'LeafElements("Int[]").ItemId: Static/Analog Types/Int[]
        'LeafElements("Double[]").ItemId: Static/Analog Types/Double[]

    End Class
End Namespace
#End Region
