' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
' ReSharper disable CheckNamespace
#Region "Example"
'  This example for OPC DA type-less mapping shows how to define a mapping and perform a read operation.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.BaseLib.ComponentModel.Linking
Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.LiveMapping

Namespace _DAClientMapper
    Partial Friend Class DefineMapping
        Class MyClass2
            Public Property Value As Object
        End Class

#Region "Example-DefineAndRead"
        Public Shared Sub Main1()
            Dim mapper = New DAClientMapper()
            Dim target = New MyClass2()

            ' Define a type-less mapping.

            mapper.DefineMapping( _
                     New DAClientItemSource( _
                         "OPCLabs.KitServer.2",
                         "Simulation.Register_I4",
                         New DAReadParameters(DADataSource.Cache)),
                     New DAClientItemMapping(GetType(Int32)),
                     New ObjectMemberLinkingTarget(target.GetType(), target, "Value"))

            ' Perform a read operation.
            mapper.Read()

            ' Display the result.
            Console.WriteLine(target.Value)
        End Sub
#End Region
    End Class
End Namespace
#End Region
