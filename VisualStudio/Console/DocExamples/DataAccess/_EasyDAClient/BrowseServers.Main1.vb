' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
' ReSharper disable CommentTypo
' ReSharper disable StringLiteralTypo
#Region "Example"
' This example shows how to obtain all ProgIDs of all OPC Data Access servers on the local machine.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc
Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Namespace DataAccess._EasyDAClient
    Partial Friend Class BrowseServers
        Shared Sub Main1()
            Dim client = New EasyDAClient()

            Dim serverElements As ServerElementCollection
            Try
                serverElements = client.BrowseServers("")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            For Each serverElement In serverElements
                Console.WriteLine($"ServerElements(""{serverElement.ClsidString}"").ProgId: {serverElement.ProgId}")
            Next serverElement

        End Sub

        ' Example output:
        '
        'ServerElements("c8a12f17-1e03-401e-b53d-6c654dd576da").ProgId: OPCLabs.KitServer.2
    End Class
End Namespace
#End Region
