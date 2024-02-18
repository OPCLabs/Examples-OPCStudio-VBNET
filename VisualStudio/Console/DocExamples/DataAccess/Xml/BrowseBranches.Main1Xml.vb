' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to obtain all branches at the root of the address space. For each branch, it displays whether 
' it may have child nodes.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.AddressSpace
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess.Xml
    Partial Friend Class BrowseBranches
        Shared Sub Main1Xml()
            Dim client = New EasyDAClient()

            Dim branchElements As DANodeElementCollection
            Try
                branchElements = client.BrowseBranches("http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            For Each branchElement In branchElements
                Console.WriteLine($"BranchElements(""{branchElement.Name}"").HasChildren: {branchElement.HasChildren}")
            Next branchElement

        End Sub

        ' Example output
        '
        'BranchElements("Static").HasChildren: True
        'BranchElements("Dynamic").HasChildren: True

    End Class
End Namespace
#End Region
