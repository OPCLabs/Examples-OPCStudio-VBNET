﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to let the user browse for an OPC Data Access item.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc
Imports OpcLabs.EasyOpc.DataAccess.Forms.Browsing

Namespace FormsDocExamples._DAItemDialog
    Friend Class ShowDialog
        Shared Sub Main1(owner As IWin32Window)
            Dim itemDialog = New DAItemDialog() With {
                .ServerDescriptor = New ServerDescriptor() With {
                    .ServerClass = "OPCLabs.KitServer.2"
                }
            }

            Dim dialogResult As DialogResult = itemDialog.ShowDialog(owner)
            If dialogResult <> DialogResult.OK Then
                Return
            End If

            ' Display results
            MessageBox.Show(owner, $"NodeElement: {itemDialog.NodeElement}")
        End Sub
    End Class
End Namespace
#End Region