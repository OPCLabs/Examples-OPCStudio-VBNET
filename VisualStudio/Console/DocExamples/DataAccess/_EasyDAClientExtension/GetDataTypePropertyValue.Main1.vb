' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to obtain a data type of an OPC item.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.BaseLib.ComInterop
Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.Extensions
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClientExtension
    Friend Class GetDataTypePropertyValue
        Public Shared Sub Main1()
            Dim client = New EasyDAClient()

            ' Get the DataType property value, already converted to VarType
            Dim varType As VarType
            Try
                varType = client.GetDataTypePropertyValue("", "OPCLabs.KitServer.2", "Simulation.Random")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            ' Display the obtained data type
            Console.WriteLine("VarType: {0}", varType) ' Display data type symbolically
        End Sub
    End Class
End Namespace
#End Region
