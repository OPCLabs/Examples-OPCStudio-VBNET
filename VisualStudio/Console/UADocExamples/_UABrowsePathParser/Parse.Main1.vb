﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' Parses an absolute  OPC-UA browse path and displays its starting node and elements.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA.Navigation
Imports OpcLabs.EasyOpc.UA.Navigation.Parsing

Namespace _UABrowsePathParser
    Friend Class Parse
        Public Shared Sub Main1()
            Dim browsePathParser = New UABrowsePathParser()
            Dim browsePath As UABrowsePath
            Try
                browsePath = browsePathParser.Parse("[ObjectsFolder]/Data/Static/UserScalar")
            Catch browsePathFormatException As UABrowsePathFormatException
                Console.WriteLine("*** Failure: {0}", browsePathFormatException.GetBaseException.Message)
                Exit Sub
            End Try

            ' Display results
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
