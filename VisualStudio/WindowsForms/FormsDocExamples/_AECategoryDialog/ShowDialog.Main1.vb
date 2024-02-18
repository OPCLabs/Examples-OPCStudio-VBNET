﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to let the user browse for OPC Alarms&Events categories.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc
Imports OpcLabs.EasyOpc.AlarmsAndEvents.AddressSpace
Imports OpcLabs.EasyOpc.AlarmsAndEvents.Forms.Browsing

Namespace FormsDocExamples._AECategoryDialog
    Friend Class ShowDialog
        Shared Sub Main1(owner As IWin32Window)
            Dim categoryDialog = New AECategoryDialog() With {
                .ServerDescriptor = New ServerDescriptor() With {
                    .ServerClass = "OPCLabs.KitEventServer.2"
                }
            }

            Dim dialogResult As DialogResult = categoryDialog.ShowDialog(owner)
            If dialogResult <> DialogResult.OK Then
                Return
            End If

            ' Display results
            Dim categoryElementsString As String = String.Join("\n", categoryDialog.CategoryElements.Select(Function(element As AECategoryElement) element))
            MessageBox.Show(owner, categoryElementsString)
        End Sub
    End Class
End Namespace
#End Region