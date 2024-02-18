' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"

' This example shows how to read and display value of a single item.
' One of the shortest examples possible.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess.Xml
    Partial Friend Class ReadItemValue
        Public Shared Sub Main1Xml()
            Dim client As New EasyDAClient()

            Console.WriteLine("Reading item value...")
            Dim value As Object
            Try
                value = client.ReadItemValue("http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx", "Dynamic/Analog Types/Double")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            Console.WriteLine(value)
        End Sub
    End Class
End Namespace
#End Region
