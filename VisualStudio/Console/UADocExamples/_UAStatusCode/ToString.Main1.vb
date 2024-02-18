﻿' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable LocalizableElement
#Region "Example"
' This example shows how the OPC UA status codes are formatted to a string containing their symbolic name.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA

Namespace _UAStatusCode
    Partial Friend Class ToString
        Public Shared Sub Main1()
            Dim internalValueArray() As Long = {0, &H80010000&, 2147614720, &H80340000&}

            For Each internalValue As Long In internalValueArray
                Console.WriteLine($"{internalValue}: {New UAStatusCode(internalValue)}")
            Next internalValue


            ' Example output:
            '0: Good
            '2147549184 BadUnexpectedError
            '2147614720: BadInternalError
            '2150891520: BadNodeIdUnknown
        End Sub
    End Class
End Namespace

#End Region
