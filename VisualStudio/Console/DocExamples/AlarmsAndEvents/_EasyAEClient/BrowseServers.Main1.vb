' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to obtain all ProgIDs of all OPC Alarms and Events servers on the local machine.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc
Imports OpcLabs.EasyOpc.AlarmsAndEvents
Imports OpcLabs.EasyOpc.OperationModel

Namespace AlarmsAndEvents._EasyAEClient

    Friend Class BrowseServers
        Public Shared Sub Main1()
            Dim client = New EasyAEClient()

            Dim serverElements As ServerElementCollection
            Try
                serverElements = client.BrowseServers("")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            For Each serverElement As ServerElement In serverElements
                Debug.Assert(serverElement IsNot Nothing)
                Console.WriteLine("serverElements[""{0}""].ProgId: {1}", serverElement.Clsid, serverElement.ProgId)
            Next serverElement
        End Sub
    End Class

End Namespace
#End Region
