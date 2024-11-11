﻿
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
' OPC client and subscriber examples in VB.NET on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-VBNET .
' Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
' a commercial license in order to use Online Forums, and we reply to every post.

Imports System.ServiceProcess


Friend NotInheritable Class Program

    Private Sub New()
    End Sub

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    Shared Sub Main()
        Dim servicesToRun() As ServiceBase
        servicesToRun = New ServiceBase() {New Service1()}
        ServiceBase.Run(servicesToRun)
    End Sub
End Class