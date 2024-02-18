﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to let the user browse for an OPC-UA data node (a Data Variable or a Property). 
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA.Forms.Browsing

Namespace UAFormsDocExamples._UADataDialog
    Friend Class ShowDialog
        Shared Sub Main1(owner As IWin32Window)
            Dim dataDialog = New UADataDialog() With {
                .EndpointDescriptor = New OpcLabs.EasyOpc.UA.UAEndpointDescriptor With {
                    .UrlString = "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
                    },
                .UserPickEndpoint = True
                }
            ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            Dim dialogResult As DialogResult = dataDialog.ShowDialog(owner)
            If dialogResult <> DialogResult.OK Then
                Return
            End If

            ' Display results
            MessageBox.Show(owner,
                $"EndpointDescriptor: {dataDialog.EndpointDescriptor}" + Environment.NewLine +
                $"NodeElement: {dataDialog.NodeElement}")
        End Sub
    End Class
End Namespace
#End Region