﻿' WcfService1: A simple Web service using WCF technology. Provides a GetData method to read a value of an OPC item.
' Use WcfClient1 project (under Console folder) to test this Web service.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

Imports OpcLabs.EasyOpc.DataAccess
Imports OpcLabs.EasyOpc.DataAccess.Extensions

' NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config and in the associated .svc file.
Public Class Service1
    Implements IService1

    Shared Sub New()
        ' Enable auto-subscribing optimization (not necessary), which can improve performance with repeated Read requests.
        Client.TryEnableAutoSubscribingOptimization()
    End Sub

    ' Use a shared client instance to allow for better optimization.
    Shared ReadOnly Client As New EasyDAClient

    Public Function GetData() As String Implements IService1.GetData
        ' The following call may throw an OpcException, which would be propagated to the client as a FaultException.
        ' Production-quality code may need to catch the OpcException and handle it differently.
        Dim value As Object = Client.ReadItemValue("", "OPCLabs.KitServer.2", "Demo.Ramp")
        Return If(value Is Nothing, "", value.ToString())
    End Function
End Class