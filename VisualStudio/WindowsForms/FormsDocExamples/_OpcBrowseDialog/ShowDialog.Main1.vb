' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to let the user browse for an OPC Data Access node in a dialog.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.Forms.Browsing

Namespace FormsDocExamples._OpcBrowseDialog
    Friend Class ShowDialog
        Shared Sub Main1(owner As IWin32Window)
            Dim browseDialog = New OpcBrowseDialog()

            Dim dialogResult As DialogResult = browseDialog.ShowDialog(owner)
            If dialogResult <> DialogResult.OK Then
                Return
            End If

            ' Display results
            MessageBox.Show(owner, browseDialog.Outputs.CurrentNodeElement.DANodeElement)
        End Sub
    End Class
End Namespace
#End Region