﻿' DataGridWebApplication: Demonstrates how easily can GridView be populated with data read from OPC Data Access server.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.BaseLib.OperationModel
Imports OpcLabs.EasyOpc.DataAccess.Extensions

' ReSharper disable InconsistentNaming

Partial Public Class _Default
    Inherits UI.Page

    Private Class Row
        Public Property ItemId As String

        Public Property Value As String
    End Class

    Shared Sub New()
        ' Enable auto-subscribing optimization (not necessary), which can improve performance with repeated Read requests.
        Client.TryEnableAutoSubscribingOptimization()
    End Sub

    ' Use a shared client instance to allow for better optimization.
    Shared ReadOnly Client As New EasyDAClient

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim itemDescriptors = New DAItemDescriptor() {"Simulation.Register_BOOL", "Simulation.Register_I2", "Demo.Ramp", "Demo.Single"}

        Dim valueResults() As ValueResult = Client.ReadMultipleItemValues("OPCLabs.KitServer.2", itemDescriptors)

        Dim data = New List(Of Row)()
        For i As Integer = 0 To itemDescriptors.Length - 1
            data.Add(New Row With {.ItemId = itemDescriptors(i).ItemId, .Value = valueResults(i).Value.ToString()})
        Next i

        GridView1.DataSource = data
        GridView1.DataBind()
    End Sub
End Class