﻿' WcfClient1: Using a Web service provided by the WcfService1 project (under Web folder), gets and displays a value of 
' an OPC item.
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.


Friend Class Program
    Shared Sub Main()
        Dim client = New Service1Client()

        ' Use the 'client' variable to call operations on the service.
        ' The following call may throw an exception in case of an error. Production-quality code should catch and
        ' handle the exceptions appropriately.
        Dim data As String = client.GetData()
        Console.WriteLine(data)
        Console.ReadLine()

        ' Always close the client.
        client.Close()
    End Sub
End Class