﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.Extensions
Imports OpcLabs.EasyOpc.OperationModel

' ReSharper disable InconsistentNaming

Partial Public Class _Default
    Inherits Page

    Shared Sub New()
        ' Enable auto-subscribing optimization (not necessary), which can improve performance with repeated Read requests.
        Client.TryEnableAutoSubscribingOptimization()
    End Sub

    ' Use a shared client instance to allow for better optimization.
    Shared ReadOnly Client As New EasyDAClient

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            Dim value As Object = Client.ReadItemValue("", "OPCLabs.KitServer.2", "Demo.Single")
            TextBox1.Text = value
        Catch opcException As OpcException
            TextBox1.Text = $"*** {opcException.Message}"
        End Try
    End Sub

End Class