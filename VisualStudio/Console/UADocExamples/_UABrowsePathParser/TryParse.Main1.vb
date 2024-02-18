' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' Attempts to parses an absolute  OPC-UA browse path and displays its starting node and elements.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports System
Imports OpcLabs.BaseLib
Imports OpcLabs.EasyOpc.UA.Navigation
Imports OpcLabs.EasyOpc.UA.Navigation.Parsing

Namespace _UABrowsePathParser
    Friend Class TryParse
        Public Shared Sub Main1()
            Dim browsePathParser = New UABrowsePathParser()

            Dim browsePath As UABrowsePath = Nothing
            Dim stringParsingError As IStringParsingError = browsePathParser.TryParse("[ObjectsFolder]/Data/Static/UserScalar", browsePath)

            ' Display results
            If Not stringParsingError Is Nothing Then
                Console.WriteLine("*** Error: {0}", stringParsingError)
                Exit Sub
            End If

            Console.WriteLine("StartingNodeId: {0}", browsePath.StartingNodeId)

            For Each browsePathElement As UABrowsePathElement In browsePath.Elements
                Console.WriteLine(browsePathElement)
            Next browsePathElement

            ' Example output:
            ' StartingNodeId: ObjectsFolder
            ' /Data
            ' /Static
            ' /UserScalar
        End Sub
    End Class
End Namespace

#End Region
