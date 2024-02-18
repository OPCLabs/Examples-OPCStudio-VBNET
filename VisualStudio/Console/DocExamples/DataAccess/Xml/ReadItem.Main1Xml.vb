' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to read a single item, and display its value, timestamp and quality.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess.Xml
    Partial Friend Class ReadItem
        Public Shared Sub Main1Xml()
            Dim client = New EasyDAClient()

            Dim vtq As DAVtq
            Try
                vtq = client.ReadItem("http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx", "Dynamic/Analog Types/Int")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            Console.WriteLine("Vtq: {0}", vtq)
        End Sub
    End Class
End Namespace
#End Region
