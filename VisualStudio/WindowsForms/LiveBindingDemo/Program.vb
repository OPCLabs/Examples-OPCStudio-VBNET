
'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

' ReSharper disable CheckNamespace
Imports OpcLabs.BaseLib.Runtime.InteropServices

Namespace LiveBindingDemo
    ' ReSharper restore CheckNamespace

    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <MTAThread> ' needed for COM security initialization to succeed
        Shared Sub Main()
            ComManagement.Instance.AssureSecurityInitialization()

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace
