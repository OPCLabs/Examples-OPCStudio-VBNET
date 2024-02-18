
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

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