' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' Parses a relative OPC-UA browse path and displays its elements.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA.Navigation
Imports OpcLabs.EasyOpc.UA.Navigation.Parsing

Namespace _UABrowsePathParser
    Friend Class ParseRelative
        Public Shared Sub Main1()
            Dim browsePathParser = New UABrowsePathParser()
            Dim browsePathElements As UABrowsePathElementCollection
            Try
                browsePathElements = browsePathParser.ParseRelative("/Data.Dynamic.Scalar.CycleComplete")
            Catch browsePathFormatException As UABrowsePathFormatException
                Console.WriteLine("*** Failure: {0}", browsePathFormatException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display results
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
