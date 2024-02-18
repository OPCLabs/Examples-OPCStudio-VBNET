' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to let the user browse for a host (computer) and an endpoint of an OPC-UA server residing on it.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA.Forms.Browsing

Namespace UAFormsDocExamples._UAHostAndEndpointDialog
    Friend Class ShowDialog
        Shared Sub Main1(owner As IWin32Window)
            Dim hostAndEndpointDialog = New UAHostAndEndpointDialog() With {
                .EndpointDescriptor = New OpcLabs.EasyOpc.UA.UAEndpointDescriptor With {
                    .Host = "opcua.demo-this.com"
                    }
                }

            Dim dialogResult As DialogResult = hostAndEndpointDialog.ShowDialog(owner)
            If dialogResult <> DialogResult.OK Then
                Return
            End If

            ' Display results
            MessageBox.Show(owner,
                $"HostElement: {hostAndEndpointDialog.HostElement}" + Environment.NewLine +
                $"DiscoveryElement: {hostAndEndpointDialog.DiscoveryElement}")
        End Sub
    End Class
End Namespace
#End Region