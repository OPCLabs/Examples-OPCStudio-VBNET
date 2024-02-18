' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' Attempts to parse a relative OPC-UA browse path and displays its elements.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports System
Imports OpcLabs.BaseLib
Imports OpcLabs.EasyOpc.UA.Navigation
Imports OpcLabs.EasyOpc.UA.Navigation.Parsing

Namespace _UABrowsePathParser
    Friend Class TryParseRelative
        Public Shared Sub Main1()
            Dim browsePathElements = New UABrowsePathElementCollection()

            Dim browsePathParser = New UABrowsePathParser()
            Dim stringParsingError As IStringParsingError = browsePathParser.TryParseRelative("/Data.Dynamic.Scalar.CycleComplete", browsePathElements)

            ' Display results
            If Not stringParsingError Is Nothing Then
                Console.WriteLine("*** Error: {0}", stringParsingError)
                Exit Sub
            End If

            For Each browsePathElement As UABrowsePathElement In browsePathElements
                Console.WriteLine(browsePathElement)
            Next browsePathElement

            ' Example output:
            ' /Data
            ' .Dynamic
            ' .Scalar
            ' .CycleComplete
        End Sub
    End Class
End Namespace

#End Region
