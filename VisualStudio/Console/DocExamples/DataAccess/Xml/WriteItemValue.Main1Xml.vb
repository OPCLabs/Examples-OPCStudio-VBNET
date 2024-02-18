' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to write a value into a single OPC XML-DA item.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess.Xml
    Partial Friend Class WriteItemValue
        Public Shared Sub Main1Xml()
            Dim client = New EasyDAClient()

            Try
                client.WriteItemValue("http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx", "Static/Analog Types/Int", 12345)
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try
        End Sub
    End Class
End Namespace
#End Region
