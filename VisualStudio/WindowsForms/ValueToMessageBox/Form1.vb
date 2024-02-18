' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.OperationModel

Public Class Form1

    ' ReSharper disable InconsistentNaming
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        ' ReSharper restore InconsistentNaming

        ' Create EasyOPC-DA component
        Dim easyDaClient As New OpcLabs.EasyOpc.DataAccess.EasyDAClient

        ' Read item value and display it in a message box
        Try
            MessageBox.Show(easyDaClient.ReadItemValue("", "OPCLabs.KitServer.2", "Demo.Single"))
        Catch opcException As OpcException
            MessageBox.Show($"*** {opcException.Message}")
        End Try
    End Sub
End Class
