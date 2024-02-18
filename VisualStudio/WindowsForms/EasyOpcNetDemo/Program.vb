' $Header: $ 
' Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

'
' Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

' ReSharper disable CheckNamespace
Namespace EasyOpcNetDemo
    ' ReSharper restore CheckNamespace

    Friend NotInheritable Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <MTAThread> ' needed for COM security initialization to succeed
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MainForm())
            'System.Threading.Thread.Sleep(10 * 60 * 1000);
        End Sub
    End Class
End Namespace
