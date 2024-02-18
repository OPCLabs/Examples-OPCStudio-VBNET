' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to obtain current state information for the condition instance corresponding to a Source and 
' certain ConditionName.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.AlarmsAndEvents
Imports OpcLabs.EasyOpc.OperationModel

Namespace AlarmsAndEvents._EasyAEClient

    Friend Class GetConditionState
        Public Shared Sub Main1()
            Dim client = New EasyAEClient()

            Dim conditionState As AEConditionState
            Try
                conditionState = client.GetConditionState("", "OPCLabs.KitEventServer.2", "Simulation.ConditionState1", "Simulated")
            Catch opcException As OpcException
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message)
                Exit Sub
            End Try

            Console.WriteLine("ConditionState:")
            Console.WriteLine("    .ActiveSubcondition: {0}", conditionState.ActiveSubcondition)
            Console.WriteLine("    .Enabled: {0}", conditionState.Enabled)
            Console.WriteLine("    .Active: {0}", conditionState.Active)
            Console.WriteLine("    .Acknowledged: {0}", conditionState.Acknowledged)
            Console.WriteLine("    .Quality: {0}", conditionState.Quality)
            ' Remark: IAEConditionState has many more properties
        End Sub
    End Class

End Namespace
#End Region
