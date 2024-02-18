﻿' $Header: $
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.UA

' ReSharper disable InconsistentNaming

Partial Public Class _Default
    Inherits UI.Page

    ' Use a shared client instance to allow for better optimization.
    Shared ReadOnly Client As New EasyUAClient

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        Dim endpointDescriptor As UAEndpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"
        ' or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
        ' or "https://opcua.demo-this.com:51212/UA/SampleServer/"

        TextBox1.Text = Client.ReadValue(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10853").ToString()
    End Sub
End Class