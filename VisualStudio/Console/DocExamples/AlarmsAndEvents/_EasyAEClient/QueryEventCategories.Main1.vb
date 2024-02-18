' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to enumerate all event categories provided by the OPC server. For each category, it displays its Id 
' and description.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.AlarmsAndEvents
Imports OpcLabs.EasyOpc.AlarmsAndEvents.AddressSpace
Imports OpcLabs.EasyOpc.OperationModel

Namespace AlarmsAndEvents._EasyAEClient

    Friend Class QueryEventCategories
        Public Shared Sub Main1()
            Dim client = New EasyAEClient()

            Dim categoryElements As AECategoryElementCollection
            Try
                categoryElements = client.QueryEventCategories("", "OPCLabs.KitEventServer.2")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            For Each categoryElement As AECategoryElement In categoryElements
                Debug.Assert(categoryElement IsNot Nothing)
                Console.WriteLine("CategoryElements[""{0}""].Description: {1}", categoryElement.CategoryId, categoryElement.Description)
            Next categoryElement
        End Sub
    End Class

End Namespace
#End Region
