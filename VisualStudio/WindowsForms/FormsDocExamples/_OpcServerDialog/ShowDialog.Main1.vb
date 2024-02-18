' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

' ReSharper disable CheckNamespace
#Region "Example"
' This example shows how to let the user browse for an OPC "Classic" server.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.Forms.Browsing

Namespace FormsDocExamples._OpcServerDialog
    Friend Class ShowDialog
        Shared Sub Main1(owner As IWin32Window)
            Dim serverDialog = New OpcServerDialog()
            'serverDialog.Location = "" 

            Dim dialogResult As DialogResult = serverDialog.ShowDialog(owner)
            If dialogResult <> DialogResult.OK Then
                Return
            End If

            ' Display results
            MessageBox.Show(owner, serverDialog.ServerElement)
        End Sub
    End Class
End Namespace
#End Region