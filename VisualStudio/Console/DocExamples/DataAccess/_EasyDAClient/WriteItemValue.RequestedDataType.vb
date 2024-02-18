' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to write a value into a single item, specifying its requested data type.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.BaseLib.ComInterop
Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class WriteItemValue
        Public Shared Sub RequestedDataType()
            Dim client = New EasyDAClient()

            Try
                client.WriteItemValue("", "OPCLabs.KitServer.2", "Simulation.Register_I4", 12345,
                                      VarTypes.I4) ' <-- the requested data type
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try
        End Sub
    End Class
End Namespace
#End Region
