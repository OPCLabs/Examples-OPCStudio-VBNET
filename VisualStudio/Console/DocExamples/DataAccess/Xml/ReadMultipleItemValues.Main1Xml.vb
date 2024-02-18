' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to read values of 4 items at once, and display them.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.BaseLib.OperationModel
Imports OpcLabs.EasyOpc.DataAccess

Namespace DataAccess.Xml
    Partial Friend Class ReadMultipleItemValues
        Public Shared Sub Main1Xml()
            ' Instantiate the client object.
            Dim client = New EasyDAClient()

            Dim valueResults() As ValueResult = client.ReadMultipleItemValues("http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx",
                New DAItemDescriptor() {"Dynamic/Analog Types/Double", "Dynamic/Analog Types/Double[]", "Dynamic/Analog Types/Int", "Static/Analog Types/Int"})

            For i = 0 To valueResults.Length - 1
                Dim valueResult As ValueResult = valueResults(i)
                Debug.Assert(valueResult IsNot Nothing)

                If valueResult.Succeeded Then
                    Console.WriteLine($"valueResults[{i}].Value: {valueResult.Value}")
                Else
                    Console.WriteLine($"valueResults[{i}] *** Failure: {valueResult.ErrorMessageBrief}")
                End If
            Next i
        End Sub

        ' Example output:
        '
        'valueResults[0].Value: 50
        'valueResults[1].Value System.Double[]
        'valueResults[2].Value: 100
        'valueResults[3].Value: 12345

    End Class
End Namespace
#End Region
